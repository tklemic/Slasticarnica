
namespace TBP_Projekt
{
    partial class frmProizvod
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
            this.dgvProizvod = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.btnPocetniPrikaz = new System.Windows.Forms.Button();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSastojci = new System.Windows.Forms.TextBox();
            this.txtCijenaOd = new System.Windows.Forms.TextBox();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.txtCijenaDo = new System.Windows.Forms.TextBox();
            this.btnCijena = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvod
            // 
            this.dgvProizvod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvod.Location = new System.Drawing.Point(12, 24);
            this.dgvProizvod.Name = "dgvProizvod";
            this.dgvProizvod.Size = new System.Drawing.Size(755, 275);
            this.dgvProizvod.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Popis proizvoda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pretraga po nazivu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pretraga po vrsti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pretraga po cijeni većoj od:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Pretraga po sastojcima:";
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIzlaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIzlaz.Location = new System.Drawing.Point(669, 364);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(119, 36);
            this.btnIzlaz.TabIndex = 10;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = false;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // btnPocetniPrikaz
            // 
            this.btnPocetniPrikaz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPocetniPrikaz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPocetniPrikaz.Location = new System.Drawing.Point(669, 312);
            this.btnPocetniPrikaz.Name = "btnPocetniPrikaz";
            this.btnPocetniPrikaz.Size = new System.Drawing.Size(119, 36);
            this.btnPocetniPrikaz.TabIndex = 35;
            this.btnPocetniPrikaz.Text = "Vrati početni prikaz";
            this.btnPocetniPrikaz.UseVisualStyleBackColor = false;
            this.btnPocetniPrikaz.Click += new System.EventHandler(this.btnPocetniPrikaz_Click);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(154, 312);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 36;
            this.txtNaziv.TextChanged += new System.EventHandler(this.txtNaziv_TextChanged);
            // 
            // txtSastojci
            // 
            this.txtSastojci.Location = new System.Drawing.Point(422, 358);
            this.txtSastojci.Name = "txtSastojci";
            this.txtSastojci.Size = new System.Drawing.Size(100, 20);
            this.txtSastojci.TabIndex = 38;
            this.txtSastojci.TextChanged += new System.EventHandler(this.txtSastojci_TextChanged);
            // 
            // txtCijenaOd
            // 
            this.txtCijenaOd.Location = new System.Drawing.Point(151, 401);
            this.txtCijenaOd.Name = "txtCijenaOd";
            this.txtCijenaOd.Size = new System.Drawing.Size(100, 20);
            this.txtCijenaOd.TabIndex = 39;
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(422, 312);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(100, 20);
            this.txtVrsta.TabIndex = 41;
            this.txtVrsta.TextChanged += new System.EventHandler(this.txtVrsta_TextChanged);
            // 
            // txtCijenaDo
            // 
            this.txtCijenaDo.Location = new System.Drawing.Point(285, 401);
            this.txtCijenaDo.Name = "txtCijenaDo";
            this.txtCijenaDo.Size = new System.Drawing.Size(100, 20);
            this.txtCijenaDo.TabIndex = 43;
            // 
            // btnCijena
            // 
            this.btnCijena.Location = new System.Drawing.Point(422, 398);
            this.btnCijena.Name = "btnCijena";
            this.btnCijena.Size = new System.Drawing.Size(75, 23);
            this.btnCijena.TabIndex = 44;
            this.btnCijena.Text = "Pretraga";
            this.btnCijena.UseVisualStyleBackColor = true;
            this.btnCijena.Click += new System.EventHandler(this.btnCijena_Click);
            // 
            // frmProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCijena);
            this.Controls.Add(this.txtCijenaDo);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.txtCijenaOd);
            this.Controls.Add(this.txtSastojci);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.btnPocetniPrikaz);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProizvod);
            this.Name = "frmProizvod";
            this.Text = "frmProizvod";
            this.Load += new System.EventHandler(this.frmProizvod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Button btnPocetniPrikaz;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSastojci;
        private System.Windows.Forms.TextBox txtCijenaOd;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.TextBox txtCijenaDo;
        private System.Windows.Forms.Button btnCijena;
    }
}