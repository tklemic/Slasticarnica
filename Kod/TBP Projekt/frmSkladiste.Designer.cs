
namespace TBP_Projekt
{
    partial class frmSkladiste
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
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            this.txtKolicinaOd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.txtKolicinaDo = new System.Windows.Forms.TextBox();
            this.dtpRokTrajanja = new System.Windows.Forms.DateTimePicker();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.txtUnosKolicine = new System.Windows.Forms.TextBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUnosSmanjenja = new System.Windows.Forms.Button();
            this.txtSmanjanje = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoba = new System.Windows.Forms.TextBox();
            this.btnPregledRacuna = new System.Windows.Forms.Button();
            this.btnPregledNarudzbi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladiste
            // 
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.Location = new System.Drawing.Point(12, 22);
            this.dgvSkladiste.Name = "dgvSkladiste";
            this.dgvSkladiste.Size = new System.Drawing.Size(989, 301);
            this.dgvSkladiste.TabIndex = 0;
            this.dgvSkladiste.SelectionChanged += new System.EventHandler(this.dgvSkladiste_SelectionChanged);
            // 
            // txtKolicinaOd
            // 
            this.txtKolicinaOd.Location = new System.Drawing.Point(187, 338);
            this.txtKolicinaOd.Name = "txtKolicinaOd";
            this.txtKolicinaOd.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaOd.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Pretraga po roku trajanja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Pretraga po količini većoj od do:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Stanje na skladištu:";
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(444, 338);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 49;
            this.btnPretraga.Text = "Pretraga";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // txtKolicinaDo
            // 
            this.txtKolicinaDo.Location = new System.Drawing.Point(314, 338);
            this.txtKolicinaDo.Name = "txtKolicinaDo";
            this.txtKolicinaDo.Size = new System.Drawing.Size(100, 20);
            this.txtKolicinaDo.TabIndex = 50;
            // 
            // dtpRokTrajanja
            // 
            this.dtpRokTrajanja.Location = new System.Drawing.Point(187, 390);
            this.dtpRokTrajanja.Name = "dtpRokTrajanja";
            this.dtpRokTrajanja.Size = new System.Drawing.Size(200, 20);
            this.dtpRokTrajanja.TabIndex = 51;
            this.dtpRokTrajanja.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(882, 338);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 54;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(882, 390);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 53;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // txtUnosKolicine
            // 
            this.txtUnosKolicine.Location = new System.Drawing.Point(396, 391);
            this.txtUnosKolicine.Name = "txtUnosKolicine";
            this.txtUnosKolicine.Size = new System.Drawing.Size(100, 20);
            this.txtUnosKolicine.TabIndex = 55;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(517, 391);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 56;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Povećanje količine: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Smanjenje količine:";
            // 
            // btnUnosSmanjenja
            // 
            this.btnUnosSmanjenja.Location = new System.Drawing.Point(751, 391);
            this.btnUnosSmanjenja.Name = "btnUnosSmanjenja";
            this.btnUnosSmanjenja.Size = new System.Drawing.Size(75, 23);
            this.btnUnosSmanjenja.TabIndex = 59;
            this.btnUnosSmanjenja.Text = "Unos";
            this.btnUnosSmanjenja.UseVisualStyleBackColor = true;
            this.btnUnosSmanjenja.Click += new System.EventHandler(this.btnUnosSmanjenja_Click);
            // 
            // txtSmanjanje
            // 
            this.txtSmanjanje.Location = new System.Drawing.Point(630, 391);
            this.txtSmanjanje.Name = "txtSmanjanje";
            this.txtSmanjanje.Size = new System.Drawing.Size(100, 20);
            this.txtSmanjanje.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Pretraga po robi:";
            // 
            // txtRoba
            // 
            this.txtRoba.Location = new System.Drawing.Point(187, 436);
            this.txtRoba.Name = "txtRoba";
            this.txtRoba.Size = new System.Drawing.Size(100, 20);
            this.txtRoba.TabIndex = 62;
            this.txtRoba.TextChanged += new System.EventHandler(this.txtRoba_TextChanged);
            // 
            // btnPregledRacuna
            // 
            this.btnPregledRacuna.Location = new System.Drawing.Point(1007, 44);
            this.btnPregledRacuna.Name = "btnPregledRacuna";
            this.btnPregledRacuna.Size = new System.Drawing.Size(115, 30);
            this.btnPregledRacuna.TabIndex = 63;
            this.btnPregledRacuna.Text = "Pregled računa";
            this.btnPregledRacuna.UseVisualStyleBackColor = true;
            this.btnPregledRacuna.Click += new System.EventHandler(this.btnPregledRacuna_Click);
            // 
            // btnPregledNarudzbi
            // 
            this.btnPregledNarudzbi.Location = new System.Drawing.Point(1007, 103);
            this.btnPregledNarudzbi.Name = "btnPregledNarudzbi";
            this.btnPregledNarudzbi.Size = new System.Drawing.Size(115, 30);
            this.btnPregledNarudzbi.TabIndex = 64;
            this.btnPregledNarudzbi.Text = "Pregled narudžbi";
            this.btnPregledNarudzbi.UseVisualStyleBackColor = true;
            this.btnPregledNarudzbi.Click += new System.EventHandler(this.btnPregledNarudzbi_Click);
            // 
            // frmSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 470);
            this.Controls.Add(this.btnPregledNarudzbi);
            this.Controls.Add(this.btnPregledRacuna);
            this.Controls.Add(this.txtRoba);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUnosSmanjenja);
            this.Controls.Add(this.txtSmanjanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.txtUnosKolicine);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.dtpRokTrajanja);
            this.Controls.Add(this.txtKolicinaDo);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKolicinaOd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSkladiste);
            this.Name = "frmSkladiste";
            this.Text = "frmSkladiste";
            this.Load += new System.EventHandler(this.frmSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkladiste;
        private System.Windows.Forms.TextBox txtKolicinaOd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.TextBox txtKolicinaDo;
        private System.Windows.Forms.DateTimePicker dtpRokTrajanja;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.TextBox txtUnosKolicine;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUnosSmanjenja;
        private System.Windows.Forms.TextBox txtSmanjanje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRoba;
        private System.Windows.Forms.Button btnPregledRacuna;
        private System.Windows.Forms.Button btnPregledNarudzbi;
    }
}