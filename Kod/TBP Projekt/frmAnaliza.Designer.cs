
namespace TBP_Projekt
{
    partial class frmAnaliza
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtProizvodi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtSastojci = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtNarudzba = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chrtProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSastojci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtNarudzba)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtProizvodi
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtProizvodi.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtProizvodi.Legends.Add(legend1);
            this.chrtProizvodi.Location = new System.Drawing.Point(12, 12);
            this.chrtProizvodi.Name = "chrtProizvodi";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtProizvodi.Series.Add(series1);
            this.chrtProizvodi.Size = new System.Drawing.Size(450, 309);
            this.chrtProizvodi.TabIndex = 0;
            this.chrtProizvodi.Text = "chart1";
            // 
            // chrtSastojci
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtSastojci.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtSastojci.Legends.Add(legend2);
            this.chrtSastojci.Location = new System.Drawing.Point(483, 12);
            this.chrtSastojci.Name = "chrtSastojci";
            this.chrtSastojci.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chrtSastojci.Series.Add(series2);
            this.chrtSastojci.Size = new System.Drawing.Size(463, 309);
            this.chrtSastojci.TabIndex = 1;
            this.chrtSastojci.Text = "chart1";
            // 
            // chrtNarudzba
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtNarudzba.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chrtNarudzba.Legends.Add(legend3);
            this.chrtNarudzba.Location = new System.Drawing.Point(236, 327);
            this.chrtNarudzba.Name = "chrtNarudzba";
            this.chrtNarudzba.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chrtNarudzba.Series.Add(series3);
            this.chrtNarudzba.Size = new System.Drawing.Size(544, 309);
            this.chrtNarudzba.TabIndex = 2;
            this.chrtNarudzba.Text = "chart1";
            // 
            // frmAnaliza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 666);
            this.Controls.Add(this.chrtNarudzba);
            this.Controls.Add(this.chrtSastojci);
            this.Controls.Add(this.chrtProizvodi);
            this.Name = "frmAnaliza";
            this.Text = "frmAnaliza";
            this.Load += new System.EventHandler(this.frmAnaliza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chrtProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtSastojci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtNarudzba)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtProizvodi;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtSastojci;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtNarudzba;
    }
}