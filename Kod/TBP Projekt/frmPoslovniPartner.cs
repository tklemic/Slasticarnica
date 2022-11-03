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
using Npgsql;

namespace TBP_Projekt
{
    public partial class frmPoslovniPartner : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();

        public frmPoslovniPartner()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }

        private void PretraziPoNazivu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"naziv\" LIKE '%" + txtNaziv.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }

        private void PretraziPoAdresi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"adresa\" LIKE '%" + txtAdresa.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }

        private void PretraziPoOibu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"oib\" LIKE '%" + txtOib.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }

        private void PretraziPoVrsti(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"vrsta_poslovnog_partnera\" LIKE '%" + txtVrstaPartnera.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }

        private void PretraziPoVrstiKontakta(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"vrsta_kontakta\" LIKE '%" + txtVrstaKontakta.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }
        private void PretraziPoKontaktu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"poslovni_partner_v\"" +
                          "WHERE  \"poslovni_partner_v\".\"kontakt\" LIKE '%" + txtKontakt.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterPoslovniPartner = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetPoslovniPartner = new DataSet();
            adapterPoslovniPartner.Fill(dataSetPoslovniPartner);

            dgvPoslovniPartner.DataSource = dataSetPoslovniPartner.Tables[0];
        }
        private void frmPoslovniPartner_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {
            PretraziPoNazivu(baza.veza);
        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {
            PretraziPoAdresi(baza.veza);
        }

        private void txtOib_TextChanged(object sender, EventArgs e)
        {
            PretraziPoOibu(baza.veza);
        }

        private void txtVrstaPartnera_TextChanged(object sender, EventArgs e)
        {
            PretraziPoVrsti(baza.veza);
        }

        private void txtVrstaKontakta_TextChanged(object sender, EventArgs e)
        {
            PretraziPoVrstiKontakta(baza.veza);
        }

        private void txtKontakt_TextChanged(object sender, EventArgs e)
        {
            PretraziPoKontaktu(baza.veza);
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            txtNaziv.Clear();
            txtAdresa.Clear();
            txtOib.Clear();
            txtKontakt.Clear();
            txtVrstaPartnera.Clear();
            txtVrstaKontakta.Clear();
            Osvjezi(baza.veza);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }
    }
}
