using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TBP_projekt;

namespace TBP_Projekt
{
    public partial class frmProizvod : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();
                
        public frmProizvod()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"proizvodi_v\"" +
                            
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvProizvod.DataSource = dataSetProizvodi.Tables[0];
        }
        private void PretraziPoNazivu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"proizvodi_v\"" +                               
                          "WHERE  \"proizvodi_v\".\"naziv_proizvoda\" LIKE '%" + txtNaziv.Text + "%' "+                                  
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvProizvod.DataSource = dataSetProizvodi.Tables[0];
        }
        private void PretraziPoCijeni(NpgsqlConnection veza)
        {
            
            string upit = "SELECT * FROM \"proizvodi_v\"" +
                          "WHERE  \"proizvodi_v\".\"cijena\" >= " + txtCijenaOd.Text +
                          "AND \"proizvodi_v\".\"cijena\" <= " + txtCijenaDo.Text +
                          "ORDER BY 1";       
            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvProizvod.DataSource = dataSetProizvodi.Tables[0];                        
                       
        }

  
        private void PretraziPoVrsti(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"proizvodi_v\"" +
                          "WHERE  \"proizvodi_v\".\"naziv\" LIKE '%" + txtVrsta.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvProizvod.DataSource = dataSetProizvodi.Tables[0];

        }
        private void PretraziPoSastojcima(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"proizvodi_v\"" +
                          "WHERE  \"proizvodi_v\".\"sastojci\" LIKE '%" + txtSastojci.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvProizvod.DataSource = dataSetProizvodi.Tables[0];
        }
        private void frmProizvod_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
            txtCijenaDo.Text = "999";
            txtCijenaOd.Text = "0";

        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            PretraziPoNazivu(baza.veza);
        }            

        private void txtVrsta_TextChanged(object sender, EventArgs e)
        {
            PretraziPoVrsti(baza.veza);
        }

        private void txtSastojci_TextChanged(object sender, EventArgs e)
        {
            PretraziPoSastojcima(baza.veza);
        }
             
        private void btnCijena_Click(object sender, EventArgs e)
        {
            PretraziPoCijeni(baza.veza);
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            txtNaziv.Clear();
            txtSastojci.Clear();
            txtVrsta.Clear();
            txtCijenaDo.Text = "999";
            txtCijenaOd.Text = "0";
            Osvjezi(baza.veza);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }
    }
}
