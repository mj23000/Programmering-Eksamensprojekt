using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace Synthesizer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			//Afgrænser grafen 
			frekvensrespons.ChartAreas[0].AxisX.ScaleView.Zoom(500, 20000);
			frekvensrespons.ChartAreas[0].AxisY.ScaleView.Zoom(0, 1000);
			frekvensrespons.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
			frekvensrespons.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
			frekvensrespons.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
		}

		int frekvensTaeller = 500;
		int volume = 500;

		public void genererSinusTone(int frekvens, int volume)//frekvens er vilkårlig og volume er maks 1000
		{
			// Laver en sinustone på et sekund
			int sampleRate = 96000;
			short bitsPerSample = 16;
			short[] svingning = new short [sampleRate];

			for (int i = 0; i < sampleRate; i++)// selve sinus udregningen, gemt i et short array
			{
				svingning[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frekvens) / sampleRate) * i)*volume/1000);
				//kan blive lavere ved at gange et tal mindre end 1 på
			}
			byte[] binaryWave = new byte[sampleRate * sizeof(short)];
			//En short er 16bit og en byte er 8 bit. for at få 16bit ned i 8bit ganges 16 bit dataen med antal bytes i 16 bits (2), som er sizeof(short)
			Buffer.BlockCopy(svingning, 0, binaryWave, 0, sampleRate * sizeof(short));// igen er hver short delt i to for at få længden i 8bit
			//Konverterer svingning (short) til bytes og placerer det i binaryWave
			using (MemoryStream memoryStream = new MemoryStream())
			using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
			{
				//Selve konvertering af sinus bølgen til WAV fil.
				short BlockAlign = Convert.ToInt16(bitsPerSample / 8); //skal konverteres til short da programmet ser bitsPerSample som en int af en eller anden grund
				int Subchunk2Size = sampleRate * BlockAlign;
				binaryWriter.Write(new[] { 'R', 'I', 'F', 'F' });
				binaryWriter.Write(36 + Subchunk2Size);
				binaryWriter.Write(new[] { 'W', 'A', 'V', 'E', 'f', 'm', 't', ' ' });
				binaryWriter.Write(16);
				binaryWriter.Write((short)1);
				binaryWriter.Write((short)1);
				binaryWriter.Write(sampleRate);
				binaryWriter.Write(sampleRate * BlockAlign);
				binaryWriter.Write(BlockAlign);
				binaryWriter.Write(bitsPerSample);
				binaryWriter.Write(new[] { 'd', 'a', 't', 'a' });
				binaryWriter.Write(Subchunk2Size);
				binaryWriter.Write(binaryWave);
				memoryStream.Position = 0;// ved at skrive til memorystream rykkes placeringen. For at spille hele streamen sættes placeringen til et
				new SoundPlayer(memoryStream).Play();
			}
		}

		void hoereProeve()
		{
			//Tonegeneratoren gemmes og frekvens og 
			sinusTestGroupbox.Hide();
			startProeve.Hide();
			MessageBox.Show("Du har nu startet høreprøven.");
			MessageBox.Show("Tryk på: 'spil tone' knappen, indtil du ikke kan høre tonen mere.");
			MessageBox.Show("Når du ikke kan høre tonen, tryk på knappen: 'tone kan ikke høres mere'");
			hoereproeveGroupbox.Show();
			frekvensrespons.Show();
			tekstProeve.Show();
			proeveFrekvensgang.Show();

			frekvensTaeller = 500;
			volume = 500;
			frekvensrespons.Series[0].Points.Clear();
		}

		private void startProeve_Click(object sender, EventArgs e)
		{
			hoereProeve();
		}

		private void sinusVolumeBoks_TextChanged(object sender, EventArgs e)
		{
			if (sinusVolumeBoks.Text != "")
			{
				if (Convert.ToInt32(sinusVolumeBoks.Text) > 1000)
				{
					MessageBox.Show("Den indtastede volumen er for høj. Volumen er sat til 1000");
					sinusVolumeBoks.Text = "1000";
				}
				else sinusVolume.Value = Convert.ToInt32(sinusVolumeBoks.Text);
			}
		}

		private void sinusFrekvens_Scroll(object sender, EventArgs e)
		{
			sinusFrekvensBoks.Text = Convert.ToString(sinusFrekvens.Value);
		}

		private void sinusVolume_Scroll(object sender, EventArgs e)
		{
			sinusVolumeBoks.Text = Convert.ToString(sinusVolume.Value);
		}

		private void sinusFrekvensBoks_TextChanged(object sender, EventArgs e)
		{
			if(sinusFrekvensBoks.Text != "") 

			if (sinusFrekvensBoks.Text != "")
			{
				if (Convert.ToInt32(sinusFrekvensBoks.Text) > 20000)
				{
					MessageBox.Show("Den indtastede frekvens er for høj. Frekvensen er sat til 20000");
					sinusFrekvensBoks.Text = "20000";
				}
				else sinusFrekvens.Value = Convert.ToInt32(sinusFrekvensBoks.Text);
			}
		}

		private void sinusKnap_Click(object sender, EventArgs e)
		{
			if(sinusVolumeBoks.Text != "" && sinusFrekvensBoks.Text != "") genererSinusTone(Convert.ToInt32(sinusFrekvensBoks.Text), sinusVolume.Value);
		}

		private void spilTone_Click(object sender, EventArgs e)
		{
			genererSinusTone(frekvensTaeller, volume);
		}

		private void toneHoeres_Click(object sender, EventArgs e)
		{
			if (frekvensTaeller > 20000) MessageBox.Show("Du har nu gennemført høreprøven. Se grafen til højre for at se dine resultater");
			
			else
			{
				if (volume == 1)
				{
					frekvensrespons.Series[0].Points.AddXY(frekvensTaeller, 1000 - volume);
					MessageBox.Show("Du kan høre tonen på alle lydniveauer!");
					frekvensTaeller = frekvensTaeller + 500;
					volume = 500;
				}
				
				if (volume >= 200) volume = volume - 100;
				if (volume <= 200) volume = volume - 50;
				if (volume <= 50) volume = volume - 10;
				if (volume <= 20) volume = volume - 5;
				if (volume <= 5) volume = 1;
				genererSinusTone(frekvensTaeller, volume);
			}
			lydInformationProeve.Text = Convert.ToString(frekvensTaeller + "Hz, ved " + volume + "/1000 lydniveau ");
		}

		private void toneHoeresIkke_Click(object sender, EventArgs e)
		{
			if (frekvensTaeller > 20000) MessageBox.Show("Du har nu gennemført høreprøven. Se grafen til højre for at se dine resultater");
			
			else
			{
				if (volume >= 200) volume = volume + 100;
				if (volume <= 200) volume = volume + 50;
				if (volume <= 50) volume = volume + 10;
				if (volume <= 20) volume = volume + 5;

				MessageBox.Show("Resultatet registreret. Tryk videre på spil tone");
				frekvensrespons.Series[0].Points.AddXY(frekvensTaeller, 1000 - volume);
				frekvensTaeller = frekvensTaeller + 500;
				volume = 500;
				lydInformationProeve.Text = Convert.ToString(frekvensTaeller + "Hz, ved " + volume + "/1000 lydniveau ");
			}
		}

		private void slutProeve_Click(object sender, EventArgs e)
		{
			sinusTestGroupbox.Show();
			startProeve.Show();
			hoereproeveGroupbox.Hide();
			frekvensrespons.Hide();
			tekstProeve.Hide();
			proeveFrekvensgang.Hide();
			frekvensrespons.Series[0].Points.Clear();
		}

		private void startForfra_Click(object sender, EventArgs e)
		{
			frekvensTaeller = 500;
			volume = 500;
			frekvensrespons.Series[0].Points.Clear();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (lydinformationerCheckbox.Checked == true) lydInformationProeve.Show();
			else lydInformationProeve.Hide();
			lydInformationProeve.Text = Convert.ToString(frekvensTaeller + "Hz, ved " + volume + "/1000 lydniveau ");

		}

	}
}
