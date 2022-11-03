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
    public partial class frmSkladiste : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();
        private int odabir;

        public frmSkladiste()
        {
            InitializeComponent();
        }
        private void Osvjezi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"skladiste_v\"" +
                           "ORDER BY 1";

            NpgsqlDataAdapter adapterSkladiste = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetSkladiste = new DataSet();
            adapterSkladiste.Fill(dataSetSkladiste);

            dgvSkladiste.DataSource = dataSetSkladiste.Tables[0];         
        }

        private void PretraziPoKolicini(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"skladiste_v\"" +
                         "WHERE  \"skladiste_v\".\"kolicina\" >= " + txtKolicinaOd.Text +
                         "AND \"skladiste_v\".\"kolicina\" <= " + txtKolicinaDo.Text +
                         "ORDER BY 1";

            NpgsqlDataAdapter adapterSkladiste = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetSkladiste = new DataSet();
            adapterSkladiste.Fill(dataSetSkladiste);

            dgvSkladiste.DataSource = dataSetSkladiste.Tables[0];
        }
        private void PretraziPoRobi(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"skladiste_v\"" +
                         "WHERE  \"skladiste_v\".\"roba\" LIKE '%" + txtRoba.Text + "%' " +
                         "ORDER BY 1";
           
            NpgsqlDataAdapter adapterSkladiste = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetSkladiste = new DataSet();
            adapterSkladiste.Fill(dataSetSkladiste);

            dgvSkladiste.DataSource = dataSetSkladiste.Tables[0];
        }
        private void PretraziPoRokuTrajanja(NpgsqlConnection veza)
        {
            string upit = "SELECT * FROM \"skladiste_v\"" +                         
                          "WHERE  \"skladiste_v\".\"rok_trajanja\" >= '" + dtpRokTrajanja.Value.Date + "'" +
                          "AND \"skladiste_v\".\"rok_trajanja\" < '" + dtpRokTrajanja.Value.Date.AddDays(1) + "'" +
                          "ORDER BY 1";

            NpgsqlDataAdapter adapterSkladiste = new NpgsqlDataAdapter(upit, veza);
            DataSet dataSetSkladiste = new DataSet();
            adapterSkladiste.Fill(dataSetSkladiste);

            dgvSkladiste.DataSource = dataSetSkladiste.Tables[0];

        }
        
        private void ProvjeraOdabira()
        {
            try
            {
                odabir = int.Parse(dgvSkladiste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                odabir = 0;
            }
        }
        
        private void UnosKolicine(NpgsqlConnection veza)
        {
            if (odabir != 0)
            {
                if (txtUnosKolicine.Text == "")
                {
                    MessageBox.Show("Niste unijeli količinu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int zeljenaKolicina;
                    int.TryParse(txtUnosKolicine.Text, out zeljenaKolicina);
                    if (zeljenaKolicina > 0)
                    {
                        string upit = "UPDATE \"skladiste\" SET \"kolicina\"=\"kolicina\"+" + zeljenaKolicina +
                                      " WHERE \"id\"=" + odabir + ";";
                        NpgsqlCommand naredba = new NpgsqlCommand(upit, veza);
                        try
                        {
                            naredba.ExecuteNonQuery();
                        }
                        catch (NpgsqlException iznimka)
                        {
                            MessageBox.Show(iznimka.Message, "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Osvjezi(veza);
                        txtUnosKolicine.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nije moguće unijeti negativan broj!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnosKolicine.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana nijedna sirovina s popisa!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SmanjenjeKolicine(NpgsqlConnection veza)
        {
            if (odabir != 0)
            {
                if (txtSmanjanje.Text == "")
                {
                    MessageBox.Show("Niste unijeli količinu!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int zeljenaKolicina;
                    int.TryParse(txtSmanjanje.Text, out zeljenaKolicina);
                    if (zeljenaKolicina > 0)
                    {
                        string upit = "UPDATE \"skladiste\" SET \"kolicina\"=\"kolicina\"-" + zeljenaKolicina +
                                      " WHERE \"id\"=" + odabir + ";";
                        NpgsqlCommand naredba = new NpgsqlCommand(upit, veza);
                        try
                        {
                            naredba.ExecuteNonQuery();
                        }
                        catch (NpgsqlException iznimka)
                        {
                            MessageBox.Show(iznimka.Message, "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Osvjezi(veza);
                        txtSmanjanje.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Nije moguće unijeti negativan broj!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUnosKolicine.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nije odabrana nijedna sirovina s popisa!", "UPOZORENJE!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmSkladiste_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
            Osvjezi(baza.veza);
            txtKolicinaDo.Text = "999";
            txtKolicinaOd.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UnosKolicine(baza.veza);
        }

        private void dgvSkladiste_SelectionChanged(object sender, EventArgs e)
        {
            ProvjeraOdabira();
        }

     
        private void btnPretraga_Click(object sender, EventArgs e)
        {
            PretraziPoKolicini(baza.veza);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            PretraziPoRokuTrajanja(baza.veza);
        }

        private void btnPocetniPrikaz_Click(object sender, EventArgs e)
        {
            txtKolicinaDo.Text = "999";
            txtKolicinaOd.Text = "0";
            dtpRokTrajanja.ResetText();
            Osvjezi(baza.veza);
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            UnosKolicine(baza.veza);
        }

        private void txtRoba_TextChanged(object sender, EventArgs e)
        {
            PretraziPoRobi(baza.veza);
        }

        private void btnUnosSmanjenja_Click(object sender, EventArgs e)
        {
            SmanjenjeKolicine(baza.veza);
        }

        private void btnPregledRacuna_Click(object sender, EventArgs e)
        {
            frmRacun frmRacun = new frmRacun();
            frmRacun.ShowDialog();
        }

        private void btnPregledNarudzbi_Click(object sender, EventArgs e)
        {
            frmNarudzbe frmNarudzbe = new frmNarudzbe();
            frmNarudzbe.ShowDialog();
        }
    }
}
