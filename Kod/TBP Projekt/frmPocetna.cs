using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using TBP_projekt;

namespace TBP_Projekt
{
    public partial class frmPocetna : Form
    {
        private PovezivanjeNaBazu baza = new PovezivanjeNaBazu();

        public frmPocetna()
        {
            InitializeComponent();
        }
        private void frmPocetna_Load(object sender, EventArgs e)
        {
            baza.OtvoriVezu();
        }

        private void btnSkladiste_Click(object sender, EventArgs e)
        {
            frmSkladiste frmSkladiste = new frmSkladiste();
            frmSkladiste.ShowDialog();
        }

        private void btnNarudzbe_Click(object sender, EventArgs e)
        {
            frmNarudzbe frmNarudzbe = new frmNarudzbe();
            frmNarudzbe.ShowDialog();
        }

        private void btnProizvod_Click(object sender, EventArgs e)
        {
            frmProizvod frmProizvod = new frmProizvod();
            frmProizvod.ShowDialog();
        }

        private void btnPoslovniPartner_Click(object sender, EventArgs e)
        {
            frmPoslovniPartner frmPoslovniPartner = new frmPoslovniPartner();
            frmPoslovniPartner.ShowDialog();
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            baza.ZatvoriVezu();
            Close();
        }

        private void btnZaposlenik_Click(object sender, EventArgs e)
        {
            frmZaposlenik frmZaposlenik = new frmZaposlenik();
            frmZaposlenik.ShowDialog();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            frmRacun frmRacun = new frmRacun();
            frmRacun.ShowDialog();
        }

        private void btnAnaliza_Click(object sender, EventArgs e)
        {
            frmAnaliza frmAnaliza = new frmAnaliza();
            frmAnaliza.ShowDialog();
        }
    }
}
