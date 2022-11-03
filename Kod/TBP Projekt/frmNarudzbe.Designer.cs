
namespace TBP_Projekt
{
    partial class frmNarudzbe
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
            this.txtPoslovniPartner = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.txtSastojak = new System.Windows.Forms.TextBox();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvNarudzbe = new System.Windows.Forms.DataGridView();
            this.btnCijena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPoslovniPartner
            // 
            this.txtPoslovniPartner.Location = new System.Drawing.Point(179, 345);
            this.txtPoslovniPartner.Name = "txtPoslovniPartner";
            this.txtPoslovniPartner.Size = new System.Drawing.Size(100, 20);
            this.txtPoslovniPartner.TabIndex = 95;
            this.txtPoslovniPartner.TextChanged += new System.EventHandler(this.txtPoslovniPartner_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "Pretraga po poslovnom partneru:";
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(494, 344);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 92;
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(494, 305);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.Size = new System.Drawing.Size(100, 20);
            this.txtZaposlenik.TabIndex = 91;
            this.txtZaposlenik.TextChanged += new System.EventHandler(this.txtZaposlenik_TextChanged);
            // 
            // txtSastojak
            // 
            this.txtSastojak.Location = new System.Drawing.Point(179, 306);
            this.txtSastojak.Name = "txtSastojak";
            this.txtSastojak.Size = new System.Drawing.Size(100, 20);
            this.txtSastojak.TabIndex = 90;
            this.txtSastojak.TextChanged += new System.EventHandler(this.txtSastojak_TextChanged);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(879, 312);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 89;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(879, 364);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 88;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Pretraga po zaposleniku:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "Pretraga po cijeni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 85;
            this.label2.Text = "Pretraga po sastojku:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Popis narudžbi:";
            // 
            // dgvNarudzbe
            // 
            this.dgvNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbe.Location = new System.Drawing.Point(12, 24);
            this.dgvNarudzbe.Name = "dgvNarudzbe";
            this.dgvNarudzbe.Size = new System.Drawing.Size(986, 275);
            this.dgvNarudzbe.TabIndex = 83;
            // 
            // btnCijena
            // 
            this.btnCijena.Location = new System.Drawing.Point(628, 342);
            this.btnCijena.Name = "btnCijena";
            this.btnCijena.Size = new System.Drawing.Size(75, 23);
            this.btnCijena.TabIndex = 96;
            this.btnCijena.Text = "Pretraži";
            this.btnCijena.UseVisualStyleBackColor = true;
            this.btnCijena.Click += new System.EventHandler(this.btnCijena_Click);
            // 
            // frmNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 417);
            this.Controls.Add(this.btnCijena);
            this.Controls.Add(this.txtPoslovniPartner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.txtSastojak);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNarudzbe);
            this.Name = "frmNarudzbe";
            this.Text = "frmNarudzbe";
            this.Load += new System.EventHandler(this.frmNarudzbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPoslovniPartner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.TextBox txtSastojak;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNarudzbe;
        private System.Windows.Forms.Button btnCijena;
    }
}