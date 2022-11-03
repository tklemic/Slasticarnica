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
    public partial class frmZaposlenik : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();
        public frmZaposlenik()
        {
            InitializeComponent();
        }
        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterZaposlenik = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetZaposlenik = new DataSet();
            adapterZaposlenik.Fill(dataSetZaposlenik);

            dgvZaposlenik.DataSource = dataSetZaposlenik.Tables[0];
        }

        private void PretraziPoImenu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"ime\" LIKE '%" + txtIme.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }

        private void PretraziPoPrezimenu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"prezime\" LIKE '%" + txtPrezime.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }

        private void PretraziPoOibu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"oib\" LIKE '%" + txtOib.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }

        private void PretraziPoRadnomMjestu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"naziv\" LIKE '%" + txtRadnoMjesto.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }

      
        private void PretraziPoKontaktu(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"kontakt\" LIKE '%" + txtKontakt.Text + "%' " +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }
        private void PretraziPoDatumuZaposlenja(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"zaposlenik_v\"" +
                          "WHERE  \"zaposlenik_v\".\"datum_zaposlenja\" >= '" + dtpDatumZaposlenja.Value.Date + "'" +
                          "AND \"zaposlenik_v\".\"datum_zaposlenja\" < '" + dtpDatumZaposlenja.Value.Date.AddDays(1) + "'" +
                          "ORDER BY 1";
            
            NpgsqlDataAdapter adapterProizvodi = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetProizvodi = new DataSet();
            adapterProizvodi.Fill(dataSetProizvodi);

            dgvZaposlenik.DataSource = dataSetProizvodi.Tables[0];
        }

        private void frmZaposlenik_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
        }

        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            PretraziPoImenu(baza.veza);
        }

        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            PretraziPoPrezimenu(baza.veza);
        }

        private void txtOib_TextChanged(object sender, EventArgs e)
        {
            PretraziPoOibu(baza.veza);
        }

        private void txtRadnoMjesto_TextChanged(object sender, EventArgs e)
        {
            PretraziPoRadnomMjestu(baza.veza);
        }

             private void dtpDatumZaposlenja_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoDatumuZaposlenja(baza.veza);
        }

        private void txtKontakt_TextChanged(object sender, EventArgs e)
        {
            PretraziPoKontaktu(baza.veza);
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            txtIme.Clear();
            txtPrezime.Clear();
            txtOib.Clear();
            txtKontakt.Clear();
            txtRadnoMjesto.Clear();
            dtpDatumZaposlenja.ResetText();
            Osvjezi(baza.veza);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }
    }
}
