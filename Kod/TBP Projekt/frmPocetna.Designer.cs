
namespace TBP_Projekt
{
    partial class frmPocetna
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
            this.btnRacun = new System.Windows.Forms.Button();
            this.btnZaposlenik = new System.Windows.Forms.Button();
            this.btnProizvod = new System.Windows.Forms.Button();
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPoslovniPartner = new System.Windows.Forms.Button();
            this.btnAnaliza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRacun
            // 
            this.btnRacun.BackColor = System.Drawing.Color.DarkGray;
            this.btnRacun.Location = new System.Drawing.Point(179, 82);
            this.btnRacun.Name = "btnRacun";
            this.btnRacun.Size = new System.Drawing.Size(124, 36);
            this.btnRacun.TabIndex = 14;
            this.btnRacun.Text = "Pregled računa";
            this.btnRacun.UseVisualStyleBackColor = false;
            this.btnRacun.Click += new System.EventHandler(this.btnRacun_Click);
            // 
            // btnZaposlenik
            // 
            this.btnZaposlenik.BackColor = System.Drawing.Color.DarkGray;
            this.btnZaposlenik.Location = new System.Drawing.Point(18, 12);
            this.btnZaposlenik.Name = "btnZaposlenik";
            this.btnZaposlenik.Size = new System.Drawing.Size(124, 36);
            this.btnZaposlenik.TabIndex = 13;
            this.btnZaposlenik.Text = "Pregled zaposlenika";
            this.btnZaposlenik.UseVisualStyleBackColor = false;
            this.btnZaposlenik.Click += new System.EventHandler(this.btnZaposlenik_Click);
            // 
            // btnProizvod
            // 
            this.btnProizvod.BackColor = System.Drawing.Color.DarkGray;
            this.btnProizvod.Location = new System.Drawing.Point(342, 12);
            this.btnProizvod.Name = "btnProizvod";
            this.btnProizvod.Size = new System.Drawing.Size(125, 36);
            this.btnProizvod.TabIndex = 3;
            this.btnProizvod.Text = "Pregled proizvoda";
            this.btnProizvod.UseVisualStyleBackColor = false;
            this.btnProizvod.Click += new System.EventHandler(this.btnProizvod_Click);
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.BackColor = System.Drawing.Color.DarkGray;
            this.btnSkladiste.Location = new System.Drawing.Point(18, 82);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(124, 36);
            this.btnSkladiste.TabIndex = 0;
            this.btnSkladiste.Text = "Pregled stanja skladišta";
            this.btnSkladiste.UseVisualStyleBackColor = false;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.BackColor = System.Drawing.Color.DarkGray;
            this.btnNarudzbe.Location = new System.Drawing.Point(342, 82);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Size = new System.Drawing.Size(125, 36);
            this.btnNarudzbe.TabIndex = 2;
            this.btnNarudzbe.Text = "Pregled narudžbi";
            this.btnNarudzbe.UseVisualStyleBackColor = false;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(348, 150);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 9;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPoslovniPartner
            // 
            this.btnPoslovniPartner.BackColor = System.Drawing.Color.DarkGray;
            this.btnPoslovniPartner.Location = new System.Drawing.Point(182, 12);
            this.btnPoslovniPartner.Name = "btnPoslovniPartner";
            this.btnPoslovniPartner.Size = new System.Drawing.Size(121, 36);
            this.btnPoslovniPartner.TabIndex = 12;
            this.btnPoslovniPartner.Text = "Pregled poslovnih partnera";
            this.btnPoslovniPartner.UseVisualStyleBackColor = false;
            this.btnPoslovniPartner.Click += new System.EventHandler(this.btnPoslovniPartner_Click);
            // 
            // btnAnaliza
            // 
            this.btnAnaliza.BackColor = System.Drawing.Color.DarkGray;
            this.btnAnaliza.Location = new System.Drawing.Point(18, 150);
            this.btnAnaliza.Name = "btnAnaliza";
            this.btnAnaliza.Size = new System.Drawing.Size(124, 36);
            this.btnAnaliza.TabIndex = 5;
            this.btnAnaliza.Text = "Analiza";
            this.btnAnaliza.UseVisualStyleBackColor = false;
            this.btnAnaliza.Click += new System.EventHandler(this.btnAnaliza_Click);
            // 
            // frmPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 212);
            this.Controls.Add(this.btnRacun);
            this.Controls.Add(this.btnAnaliza);
            this.Controls.Add(this.btnZaposlenik);
            this.Controls.Add(this.btnPoslovniPartner);
            this.Controls.Add(this.btnProizvod);
            this.Controls.Add(this.btnSkladiste);
            this.Controls.Add(this.btnNarudzbe);
            this.Controls.Add(this.btnIzlaz);
            this.Name = "frmPocetna";
            this.Text = "Početni izbornik";
            this.Load += new System.EventHandler(this.frmPocetna_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnProizvod;
        private System.Windows.Forms.Button btnPoslovniPartner;
        private System.Windows.Forms.Button btnZaposlenik;
        private System.Windows.Forms.Button btnRacun;
        private System.Windows.Forms.Button btnAnaliza;
    }
}

