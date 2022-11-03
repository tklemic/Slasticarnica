
namespace TBP_Projekt
{
    partial class frmZaposlenik
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
            this.txtOib = new System.Windows.Forms.TextBox();
            this.txtRadnoMjesto = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvZaposlenik = new System.Windows.Forms.DataGridView();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDatumZaposlenja = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOib
            // 
            this.txtOib.Location = new System.Drawing.Point(134, 384);
            this.txtOib.Name = "txtOib";
            this.txtOib.Size = new System.Drawing.Size(100, 20);
            this.txtOib.TabIndex = 56;
            this.txtOib.TextChanged += new System.EventHandler(this.txtOib_TextChanged);
            // 
            // txtRadnoMjesto
            // 
            this.txtRadnoMjesto.Location = new System.Drawing.Point(444, 306);
            this.txtRadnoMjesto.Name = "txtRadnoMjesto";
            this.txtRadnoMjesto.Size = new System.Drawing.Size(100, 20);
            this.txtRadnoMjesto.TabIndex = 55;
            this.txtRadnoMjesto.TextChanged += new System.EventHandler(this.txtRadnoMjesto_TextChanged);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(134, 309);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(100, 20);
            this.txtIme.TabIndex = 53;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(876, 312);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 52;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(876, 364);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 51;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Pretraga po datumu zaposlenja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 309);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Pretraga po radnom mjestu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Pretraga po oib-u:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Pretraga po imenu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Popis zaposlenika:";
            // 
            // dgvZaposlenik
            // 
            this.dgvZaposlenik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZaposlenik.Location = new System.Drawing.Point(12, 24);
            this.dgvZaposlenik.Name = "dgvZaposlenik";
            this.dgvZaposlenik.Size = new System.Drawing.Size(983, 275);
            this.dgvZaposlenik.TabIndex = 45;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(134, 345);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(100, 20);
            this.txtPrezime.TabIndex = 60;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Pretraga po prezimenu:";
            // 
            // dtpDatumZaposlenja
            // 
            this.dtpDatumZaposlenja.Location = new System.Drawing.Point(444, 388);
            this.dtpDatumZaposlenja.Name = "dtpDatumZaposlenja";
            this.dtpDatumZaposlenja.Size = new System.Drawing.Size(200, 20);
            this.dtpDatumZaposlenja.TabIndex = 61;
            this.dtpDatumZaposlenja.ValueChanged += new System.EventHandler(this.dtpDatumZaposlenja_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 13);
            this.label8.TabIndex = 64;
            this.label8.Text = "Pretraga po kontaktu:";
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(444, 344);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(100, 20);
            this.txtKontakt.TabIndex = 63;
            this.txtKontakt.TextChanged += new System.EventHandler(this.txtKontakt_TextChanged);
            // 
            // frmZaposlenik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 447);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.dtpDatumZaposlenja);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOib);
            this.Controls.Add(this.txtRadnoMjesto);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvZaposlenik);
            this.Name = "frmZaposlenik";
            this.Text = "frmZaposlenik";
            this.Load += new System.EventHandler(this.frmZaposlenik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZaposlenik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOib;
        private System.Windows.Forms.TextBox txtRadnoMjesto;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvZaposlenik;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDatumZaposlenja;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKontakt;
    }
}