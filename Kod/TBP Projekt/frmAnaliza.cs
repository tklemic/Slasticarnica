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
    public partial class frmAnaliza : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();

        public frmAnaliza()
        {
            InitializeComponent();
        }
        private void Osvjezi(NpgsqlConnection veza)
        {
            string upitKolicinaProizvodi = "SELECT \"proizvodi\".\"naziv_proizvoda\", \"skladiste\".\"kolicina\" " +
                                  "FROM \"proizvodi\", \"skladiste\"" +
                                  "WHERE \"proizvodi\".\"id\" = \"skladiste\".\"proizvod_id\"" +
                                  "ORDER BY 1";
            NpgsqlDataAdapter adapterAnalizaProizvoda = new NpgsqlDataAdapter(upitKolicinaProizvodi, veza);
            DataSet dataSetAnalizaProizvoda = new DataSet();
            adapterAnalizaProizvoda.Fill(dataSetAnalizaProizvoda);

            chrtProizvodi.DataSource = dataSetAnalizaProizvoda.Tables[0];
            chrtProizvodi.Series[0].XValueMember = "naziv_proizvoda";
            chrtProizvodi.Series[0].YValueMembers = "kolicina";
            chrtProizvodi.Series[0].Name = "Količina proizvoda";
            chrtProizvodi.DataBind();

            string upitKolicinaSastojci = "SELECT \"sastojci\".\"naziv\", \"skladiste\".\"kolicina\" " +
                                  "FROM \"sastojci\", \"skladiste\"" +
                                  "WHERE \"sastojci\".\"id\" = \"skladiste\".\"sastojci_id\"" +
                                  "ORDER BY 1";

            NpgsqlDataAdapter adapterAnalizaSastojaka = new NpgsqlDataAdapter(upitKolicinaSastojci, veza);
            DataSet dataSetAnalizaSastojaka = new DataSet();
            adapterAnalizaSastojaka.Fill(dataSetAnalizaSastojaka);

            chrtSastojci.DataSource = dataSetAnalizaSastojaka.Tables[0];
            chrtSastojci.Series[0].XValueMember = "naziv";
            chrtSastojci.Series[0].YValueMembers = "kolicina";
            chrtSastojci.Series[0].Name = "Količina sastojaka";
            chrtSastojci.DataBind();

            string upitNarudzba = "SELECT \"narudzba_v\".\"sastojak\", SUM(\"narudzba_v\".\"kolicina\") AS ukupno_naruceno " +
                                  "FROM \"narudzba_v\"" +
                                  //"WHERE \"narudzba_v\".\"id\" = \"narudzba\".\"sastojak_id\"" +
                                  "GROUP BY 1" +
                                  "ORDER BY 1";

            NpgsqlDataAdapter adapterNarudzba = new NpgsqlDataAdapter(upitNarudzba, veza);
            DataSet dataSetNarudzba = new DataSet();
            adapterNarudzba.Fill(dataSetNarudzba);

            chrtNarudzba.DataSource = dataSetNarudzba.Tables[0];
            chrtNarudzba.Series[0].XValueMember = "sastojak";
            chrtNarudzba.Series[0].YValueMembers = "ukupno_naruceno";
            chrtNarudzba.Series[0].Name = "Broj narudžbi";
            chrtNarudzba.DataBind();

            
        }

        private void frmAnaliza_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
        }
    }
}
