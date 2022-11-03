
namespace TBP_Projekt
{
    partial class frmRacun
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.lblNazivSirovine = new System.Windows.Forms.Label();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis računa:";
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Location = new System.Drawing.Point(12, 25);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.Size = new System.Drawing.Size(755, 251);
            this.dgvRacun.TabIndex = 3;
            // 
            // lblNazivSirovine
            // 
            this.lblNazivSirovine.AutoSize = true;
            this.lblNazivSirovine.BackColor = System.Drawing.Color.Transparent;
            this.lblNazivSirovine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNazivSirovine.ForeColor = System.Drawing.Color.Black;
            this.lblNazivSirovine.Location = new System.Drawing.Point(9, 292);
            this.lblNazivSirovine.Name = "lblNazivSirovine";
            this.lblNazivSirovine.Size = new System.Drawing.Size(103, 13);
            this.lblNazivSirovine.TabIndex = 19;
            this.lblNazivSirovine.Text = "Pretraga po datumu:";
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(648, 292);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 53;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(648, 344);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 52;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(160, 292);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 54;
            this.dtpDatum.ValueChanged += new System.EventHandler(this.dtpDatum_ValueChanged);
            // 
            // frmRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 407);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.lblNazivSirovine);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.label1);
            this.Name = "frmRacun";
            this.Text = "frmRacun";
            this.Load += new System.EventHandler(this.frmRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label lblNazivSirovine;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.DateTimePicker dtpDatum;
    }
}