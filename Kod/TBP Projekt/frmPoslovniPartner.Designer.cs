
namespace TBP_Projekt
{
    partial class frmPoslovniPartner
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVrstaKontakta = new System.Windows.Forms.TextBox();
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtVrstaPartnera = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPoslovniPartner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartner)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Pretraga po kontaktu:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(444, 392);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 20);
            this.txtKontakt.TabIndex = 81;
            this.txtKontakt.TextChanged += new System.EventHandler(this.txtKontakt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Pretraga po vrsti kontakta:";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(134, 349);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(100, 20);
            this.txtAdresa.TabIndex = 78;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 77;
            this.label4.Text = "Pretraga po adresi:";
            // 
            // txtVrstaKontakta
            // 
            this.txtVrstaKontakta.Location = new System.Drawing.Point(444, 349);
            this.txtVrstaKontakta.Name = "txtVrstaKontakta";
            this.txtVrstaKontakta.Size = new System.Drawing.Size(100, 20);
            this.txtVrstaKontakta.TabIndex = 76;
            this.txtVrstaKontakta.TextChanged += new System.EventHandler(this.txtVrstaKontakta_TextChanged);
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(134, 388);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(100, 20);
            this.txtOib.TabIndex = 75;
            this.txtOib.TextChanged += new System.EventHandler(this.txtOib_TextChanged);
            // 
            // txtVrstaPartnera
            // 
            this.txtVrstaPartnera.Location = new System.Drawing.Point(444, 310);
            this.txtVrstaPartnera.Name = "txtVrstaPartnera";
            this.txtVrstaPartnera.Size = new System.Drawing.Size(100, 20);
            this.txtVrstaPartnera.TabIndex = 74;
            this.txtVrstaPartnera.TextChanged += new System.EventHandler(this.txtVrstaPartnera_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(134, 313);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 73;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(771, 309);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 72;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(771, 361);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 71;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = "Pretraga po vrsti partnera:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 68;
            this.label3.Text = "Pretraga po oib-u:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Pretraga po nazivu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Popis poslovnih partnera:";
            // 
            // dgvPoslovniPartner
            // 
            this.dgvPoslovniPartner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoslovniPartner.Location = new System.Drawing.Point(12, 28);
            this.dgvPoslovniPartner.Name = "dgvPoslovniPartner";
            this.dgvPoslovniPartner.Size = new System.Drawing.Size(878, 275);
            this.dgvPoslovniPartner.TabIndex = 65;
            // 
            // frmPoslovniPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 441);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVrstaKontakta);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtVrstaPartnera);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPoslovniPartner);
            this.Name = "frmPoslovniPartner";
            this.Text = "frmPoslovniPartner";
            this.Load += new System.EventHandler(this.frmPoslovniPartner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoslovniPartner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVrstaKontakta;
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtVrstaPartnera;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPoslovniPartner;
    }
}