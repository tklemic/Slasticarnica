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
    public partial class frmNarudzbe : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();

        public frmNarudzbe()
        {
            InitializeComponent();
        }
        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"narudzba_v\"" +
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzbe = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetNarudzbe = new DataSet();
            adapterNarudzbe.Fill(dataSetNarudzbe);

            dgvNarudzbe.DataSource = dataSetNarudzbe.Tables[0];
        }
        private void PretraziPoSastojku(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"narudzba_v\"" +
                          "WHERE  \"narudzba_v\".\"sastojak\" LIKE '%" + txtSastojak.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzbe = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetNarudzbe = new DataSet();
            adapterNarudzbe.Fill(dataSetNarudzbe);

            dgvNarudzbe.DataSource = dataSetNarudzbe.Tables[0];
        }
        private void PretraziPoZaposleniku(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"narudzba_v\"" +
                          "WHERE  \"narudzba_v\".\"kreirao\" LIKE '%" + txtZaposlenik.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzbe = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetNarudzbe = new DataSet();
            adapterNarudzbe.Fill(dataSetNarudzbe);

            dgvNarudzbe.DataSource = dataSetNarudzbe.Tables[0];
        }
        private void PretraziPoPartneru(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"narudzba_v\"" +
                          "WHERE  \"narudzba_v\".\"poslovni_partner\" LIKE '%" + txtPoslovniPartner.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzbe = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetNarudzbe = new DataSet();
            adapterNarudzbe.Fill(dataSetNarudzbe);

            dgvNarudzbe.DataSource = dataSetNarudzbe.Tables[0];
        }
        private void PretraziPoCijeni(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"narudzba_v\"" +
                          "WHERE  \"narudzba_v\".\"cijena_ukupno\" = " + txtCijena.Text +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzbe = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetNarudzbe = new DataSet();
            adapterNarudzbe.Fill(dataSetNarudzbe);

            dgvNarudzbe.DataSource = dataSetNarudzbe.Tables[0];
        }
        private void frmNarudzbe_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
        }

        private void txtSastojak_TextChanged(object sender, EventArgs e)
        {
            PretraziPoSastojku(baza.veza);
        }

        private void txtZaposlenik_TextChanged(object sender, EventArgs e)
        {
            PretraziPoZaposleniku(baza.veza);
        }

        private void txtPoslovniPartner_TextChanged(object sender, EventArgs e)
        {
            PretraziPoPartneru(baza.veza);
        }

       

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            txtCijena.Clear();
            txtPoslovniPartner.Clear();
            txtSastojak.Clear();
            txtZaposlenik.Clear();           
            Osvjezi(baza.veza);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }

        private void btnCijena_Click(object sender, EventArgs e)
        {
            PretraziPoCijeni(baza.veza);
        }
    }
}
