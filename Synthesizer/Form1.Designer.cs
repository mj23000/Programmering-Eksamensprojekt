namespace Synthesizer
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.titel = new System.Windows.Forms.Label();
			this.startProeve = new System.Windows.Forms.Button();
			this.sinusTestGroupbox = new System.Windows.Forms.GroupBox();
			this.sinusTest = new System.Windows.Forms.Label();
			this.volumeLabel = new System.Windows.Forms.Label();
			this.frekvensLabel = new System.Windows.Forms.Label();
			this.sinusVolumeBoks = new System.Windows.Forms.TextBox();
			this.sinusFrekvens = new System.Windows.Forms.TrackBar();
			this.sinusKnap = new System.Windows.Forms.Button();
			this.sinusVolume = new System.Windows.Forms.TrackBar();
			this.sinusFrekvensBoks = new System.Windows.Forms.TextBox();
			this.frekvensrespons = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.hoereproeveGroupbox = new System.Windows.Forms.GroupBox();
			this.lydInformationProeve = new System.Windows.Forms.Label();
			this.lydinformationerCheckbox = new System.Windows.Forms.CheckBox();
			this.toneHoeresIkke = new System.Windows.Forms.Button();
			this.startForfra = new System.Windows.Forms.Button();
			this.slutProeve = new System.Windows.Forms.Button();
			this.toneHoeres = new System.Windows.Forms.Button();
			this.proeveFrekvensgang = new System.Windows.Forms.Label();
			this.tekstProeve = new System.Windows.Forms.Label();
			this.sinusTestGroupbox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinusFrekvens)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sinusVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frekvensrespons)).BeginInit();
			this.hoereproeveGroupbox.SuspendLayout();
			this.SuspendLayout();
			// 
			// titel
			// 
			this.titel.AutoSize = true;
			this.titel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titel.Location = new System.Drawing.Point(40, 70);
			this.titel.Name = "titel";
			this.titel.Size = new System.Drawing.Size(222, 25);
			this.titel.TabIndex = 8;
			this.titel.Text = "Høreprøve sinusbølge";
			// 
			// startProeve
			// 
			this.startProeve.Location = new System.Drawing.Point(45, 156);
			this.startProeve.Name = "startProeve";
			this.startProeve.Size = new System.Drawing.Size(107, 23);
			this.startProeve.TabIndex = 9;
			this.startProeve.Text = "Start høreprøve";
			this.startProeve.UseVisualStyleBackColor = true;
			this.startProeve.Click += new System.EventHandler(this.startProeve_Click);
			// 
			// sinusTestGroupbox
			// 
			this.sinusTestGroupbox.Controls.Add(this.sinusTest);
			this.sinusTestGroupbox.Controls.Add(this.volumeLabel);
			this.sinusTestGroupbox.Controls.Add(this.frekvensLabel);
			this.sinusTestGroupbox.Controls.Add(this.sinusVolumeBoks);
			this.sinusTestGroupbox.Controls.Add(this.sinusFrekvens);
			this.sinusTestGroupbox.Controls.Add(this.sinusKnap);
			this.sinusTestGroupbox.Controls.Add(this.sinusVolume);
			this.sinusTestGroupbox.Controls.Add(this.sinusFrekvensBoks);
			this.sinusTestGroupbox.Location = new System.Drawing.Point(302, 198);
			this.sinusTestGroupbox.Name = "sinusTestGroupbox";
			this.sinusTestGroupbox.Size = new System.Drawing.Size(481, 346);
			this.sinusTestGroupbox.TabIndex = 11;
			this.sinusTestGroupbox.TabStop = false;
			this.sinusTestGroupbox.Text = " ";
			// 
			// sinusTest
			// 
			this.sinusTest.AutoSize = true;
			this.sinusTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sinusTest.Location = new System.Drawing.Point(4, 38);
			this.sinusTest.Name = "sinusTest";
			this.sinusTest.Size = new System.Drawing.Size(185, 25);
			this.sinusTest.TabIndex = 19;
			this.sinusTest.Text = "Test frekvenserne";
			// 
			// volumeLabel
			// 
			this.volumeLabel.AutoSize = true;
			this.volumeLabel.Location = new System.Drawing.Point(6, 242);
			this.volumeLabel.Name = "volumeLabel";
			this.volumeLabel.Size = new System.Drawing.Size(45, 13);
			this.volumeLabel.TabIndex = 18;
			this.volumeLabel.Text = "Volume ";
			// 
			// frekvensLabel
			// 
			this.frekvensLabel.AutoSize = true;
			this.frekvensLabel.Location = new System.Drawing.Point(6, 148);
			this.frekvensLabel.Name = "frekvensLabel";
			this.frekvensLabel.Size = new System.Drawing.Size(51, 13);
			this.frekvensLabel.TabIndex = 17;
			this.frekvensLabel.Text = "Frekvens";
			// 
			// sinusVolumeBoks
			// 
			this.sinusVolumeBoks.Location = new System.Drawing.Point(86, 239);
			this.sinusVolumeBoks.Name = "sinusVolumeBoks";
			this.sinusVolumeBoks.Size = new System.Drawing.Size(100, 20);
			this.sinusVolumeBoks.TabIndex = 16;
			this.sinusVolumeBoks.Text = "1";
			this.sinusVolumeBoks.TextChanged += new System.EventHandler(this.sinusVolumeBoks_TextChanged);
			// 
			// sinusFrekvens
			// 
			this.sinusFrekvens.Location = new System.Drawing.Point(86, 174);
			this.sinusFrekvens.Maximum = 20000;
			this.sinusFrekvens.Name = "sinusFrekvens";
			this.sinusFrekvens.Size = new System.Drawing.Size(386, 45);
			this.sinusFrekvens.TabIndex = 15;
			this.sinusFrekvens.Value = 20;
			this.sinusFrekvens.Scroll += new System.EventHandler(this.sinusFrekvens_Scroll);
			// 
			// sinusKnap
			// 
			this.sinusKnap.Location = new System.Drawing.Point(0, 303);
			this.sinusKnap.Name = "sinusKnap";
			this.sinusKnap.Size = new System.Drawing.Size(100, 23);
			this.sinusKnap.TabIndex = 12;
			this.sinusKnap.Text = "Spil sinusbølge";
			this.sinusKnap.UseVisualStyleBackColor = true;
			this.sinusKnap.Click += new System.EventHandler(this.sinusKnap_Click);
			// 
			// sinusVolume
			// 
			this.sinusVolume.Location = new System.Drawing.Point(86, 265);
			this.sinusVolume.Maximum = 1000;
			this.sinusVolume.Name = "sinusVolume";
			this.sinusVolume.Size = new System.Drawing.Size(386, 45);
			this.sinusVolume.TabIndex = 14;
			this.sinusVolume.Value = 1;
			this.sinusVolume.Scroll += new System.EventHandler(this.sinusVolume_Scroll);
			// 
			// sinusFrekvensBoks
			// 
			this.sinusFrekvensBoks.Location = new System.Drawing.Point(86, 148);
			this.sinusFrekvensBoks.Name = "sinusFrekvensBoks";
			this.sinusFrekvensBoks.Size = new System.Drawing.Size(100, 20);
			this.sinusFrekvensBoks.TabIndex = 13;
			this.sinusFrekvensBoks.Text = "20";
			this.sinusFrekvensBoks.TextChanged += new System.EventHandler(this.sinusFrekvensBoks_TextChanged);
			// 
			// frekvensrespons
			// 
			this.frekvensrespons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.frekvensrespons.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Unscaled;
			chartArea1.Name = "ChartArea1";
			this.frekvensrespons.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.frekvensrespons.Legends.Add(legend1);
			this.frekvensrespons.Location = new System.Drawing.Point(268, 244);
			this.frekvensrespons.Name = "frekvensrespons";
			this.frekvensrespons.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Målinger";
			this.frekvensrespons.Series.Add(series1);
			this.frekvensrespons.Size = new System.Drawing.Size(1049, 300);
			this.frekvensrespons.TabIndex = 12;
			this.frekvensrespons.Text = "Lydmålinger";
			this.frekvensrespons.Visible = false;
			// 
			// hoereproeveGroupbox
			// 
			this.hoereproeveGroupbox.Controls.Add(this.lydInformationProeve);
			this.hoereproeveGroupbox.Controls.Add(this.lydinformationerCheckbox);
			this.hoereproeveGroupbox.Controls.Add(this.toneHoeresIkke);
			this.hoereproeveGroupbox.Controls.Add(this.startForfra);
			this.hoereproeveGroupbox.Controls.Add(this.slutProeve);
			this.hoereproeveGroupbox.Controls.Add(this.toneHoeres);
			this.hoereproeveGroupbox.Location = new System.Drawing.Point(28, 185);
			this.hoereproeveGroupbox.Name = "hoereproeveGroupbox";
			this.hoereproeveGroupbox.Size = new System.Drawing.Size(234, 292);
			this.hoereproeveGroupbox.TabIndex = 17;
			this.hoereproeveGroupbox.TabStop = false;
			this.hoereproeveGroupbox.Visible = false;
			// 
			// lydInformationProeve
			// 
			this.lydInformationProeve.AutoSize = true;
			this.lydInformationProeve.Location = new System.Drawing.Point(6, 51);
			this.lydInformationProeve.Name = "lydInformationProeve";
			this.lydInformationProeve.Size = new System.Drawing.Size(10, 13);
			this.lydInformationProeve.TabIndex = 30;
			this.lydInformationProeve.Text = " ";
			this.lydInformationProeve.Visible = false;
			// 
			// lydinformationerCheckbox
			// 
			this.lydinformationerCheckbox.AutoSize = true;
			this.lydinformationerCheckbox.Location = new System.Drawing.Point(6, 232);
			this.lydinformationerCheckbox.Name = "lydinformationerCheckbox";
			this.lydinformationerCheckbox.Size = new System.Drawing.Size(116, 17);
			this.lydinformationerCheckbox.TabIndex = 29;
			this.lydinformationerCheckbox.Text = "Vis lydinformationer";
			this.lydinformationerCheckbox.UseVisualStyleBackColor = true;
			this.lydinformationerCheckbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// toneHoeresIkke
			// 
			this.toneHoeresIkke.Location = new System.Drawing.Point(6, 174);
			this.toneHoeresIkke.Name = "toneHoeresIkke";
			this.toneHoeresIkke.Size = new System.Drawing.Size(220, 23);
			this.toneHoeresIkke.TabIndex = 24;
			this.toneHoeresIkke.Text = "Tonen kan ikke høres";
			this.toneHoeresIkke.UseVisualStyleBackColor = true;
			this.toneHoeresIkke.Click += new System.EventHandler(this.toneHoeresIkke_Click);
			// 
			// startForfra
			// 
			this.startForfra.Location = new System.Drawing.Point(6, 203);
			this.startForfra.Name = "startForfra";
			this.startForfra.Size = new System.Drawing.Size(107, 23);
			this.startForfra.TabIndex = 27;
			this.startForfra.Text = "Start forfra";
			this.startForfra.UseVisualStyleBackColor = true;
			this.startForfra.Click += new System.EventHandler(this.startForfra_Click);
			// 
			// slutProeve
			// 
			this.slutProeve.Location = new System.Drawing.Point(119, 203);
			this.slutProeve.Name = "slutProeve";
			this.slutProeve.Size = new System.Drawing.Size(107, 23);
			this.slutProeve.TabIndex = 22;
			this.slutProeve.Text = "Slut høreprøve";
			this.slutProeve.UseVisualStyleBackColor = true;
			this.slutProeve.Click += new System.EventHandler(this.slutProeve_Click);
			// 
			// toneHoeres
			// 
			this.toneHoeres.Location = new System.Drawing.Point(6, 145);
			this.toneHoeres.Name = "toneHoeres";
			this.toneHoeres.Size = new System.Drawing.Size(220, 23);
			this.toneHoeres.TabIndex = 26;
			this.toneHoeres.Text = "Spil tone";
			this.toneHoeres.UseVisualStyleBackColor = true;
			this.toneHoeres.Click += new System.EventHandler(this.toneHoeres_Click);
			// 
			// proeveFrekvensgang
			// 
			this.proeveFrekvensgang.AutoSize = true;
			this.proeveFrekvensgang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.proeveFrekvensgang.Location = new System.Drawing.Point(311, 156);
			this.proeveFrekvensgang.Name = "proeveFrekvensgang";
			this.proeveFrekvensgang.Size = new System.Drawing.Size(285, 25);
			this.proeveFrekvensgang.TabIndex = 18;
			this.proeveFrekvensgang.Text = "Frekvensgang af din hørelse";
			this.proeveFrekvensgang.Visible = false;
			// 
			// tekstProeve
			// 
			this.tekstProeve.AllowDrop = true;
			this.tekstProeve.AutoSize = true;
			this.tekstProeve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tekstProeve.Location = new System.Drawing.Point(24, 575);
			this.tekstProeve.Name = "tekstProeve";
			this.tekstProeve.Size = new System.Drawing.Size(752, 20);
			this.tekstProeve.TabIndex = 19;
			this.tekstProeve.Text = "Høreprøvens resultater varierer baseret på lydstyrken på din computer og dine hør" +
    "etelefoner eller højtalere";
			this.tekstProeve.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 619);
			this.Controls.Add(this.tekstProeve);
			this.Controls.Add(this.proeveFrekvensgang);
			this.Controls.Add(this.sinusTestGroupbox);
			this.Controls.Add(this.startProeve);
			this.Controls.Add(this.titel);
			this.Controls.Add(this.hoereproeveGroupbox);
			this.Controls.Add(this.frekvensrespons);
			this.Name = "Form1";
			this.Text = "Form1";
			this.sinusTestGroupbox.ResumeLayout(false);
			this.sinusTestGroupbox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sinusFrekvens)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sinusVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frekvensrespons)).EndInit();
			this.hoereproeveGroupbox.ResumeLayout(false);
			this.hoereproeveGroupbox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
			
			
		}

		#endregion
		private System.Windows.Forms.Label titel;
		private System.Windows.Forms.Button startProeve;
		private System.Windows.Forms.GroupBox sinusTestGroupbox;
		private System.Windows.Forms.Label sinusTest;
		private System.Windows.Forms.Label volumeLabel;
		private System.Windows.Forms.Label frekvensLabel;
		private System.Windows.Forms.TextBox sinusVolumeBoks;
		private System.Windows.Forms.TrackBar sinusFrekvens;
		private System.Windows.Forms.TrackBar sinusVolume;
		private System.Windows.Forms.TextBox sinusFrekvensBoks;
		private System.Windows.Forms.Button sinusKnap;
		private System.Windows.Forms.DataVisualization.Charting.Chart frekvensrespons;
		private System.Windows.Forms.GroupBox hoereproeveGroupbox;
		private System.Windows.Forms.Button toneHoeresIkke;
		private System.Windows.Forms.Button startForfra;
		private System.Windows.Forms.Button slutProeve;
		private System.Windows.Forms.Button toneHoeres;
		private System.Windows.Forms.Label lydInformationProeve;
		private System.Windows.Forms.CheckBox lydinformationerCheckbox;
		private System.Windows.Forms.Label proeveFrekvensgang;
		private System.Windows.Forms.Label tekstProeve;
	}
}

