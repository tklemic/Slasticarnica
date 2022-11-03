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
    public partial class frmRacun : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();
        public frmRacun()
        {
            InitializeComponent();
        }

        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"racun\"" +
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterRacun = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetRacun = new DataSet();
            adapterRacun.Fill(dataSetRacun);

            dgvRacun.DataSource = dataSetRacun.Tables[0];
        }
        private void PretraziPoRokuTrajanja(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"racun\"" +
                          "WHERE  \"racun\".\"datum_racuna\" >= '" + dtpDatum.Value.Date + "'" +
                          "AND \"racun\".\"datum_racuna\" < '" + dtpDatum.Value.Date.AddDays(1) + "'" +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterRacun = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetRacun = new DataSet();
            adapterRacun.Fill(dataSetRacun);

            dgvRacun.DataSource = dataSetRacun.Tables[0];

        }
 
        private void frmRacun_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
        }

        
        private void dtpDatum_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoRokuTrajanja(baza.veza);
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            dtpDatum.ResetText();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }
    }
}
