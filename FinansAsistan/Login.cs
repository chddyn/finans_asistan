using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinansAsistan
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        //roller
        //Dimer = 1 
        //Dimin = 2
        //Dmineral = 3
        //Genel = 4 hepsine yetkisi var
        //Muhasebe= 5 sadece cari karşılaştırma listesini görebilir

        public Login()
        {
            InitializeComponent();
        }

        private void Login2_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (Kontrol.Validate())
            {

                if (cmbSirket.EditValue == "DIMER" && txtSifre.Text == "Dimer2022")
                {

                    AnaSayfa form = new AnaSayfa();
                    AnaSayfa.userRole= 1;

                    form.Show();
                    this.Hide();
                }
                else if (cmbSirket.EditValue == "DIMIN" && txtSifre.Text == "Dimin2022")
                {
                    AnaSayfa form = new AnaSayfa();
                    AnaSayfa.userRole= 2;

                    form.Show();
                    this.Hide();
                }
                else if (cmbSirket.EditValue == "DMINERAL" && txtSifre.Text == "Dmineral2022")
                {
                    AnaSayfa form = new AnaSayfa();
                    AnaSayfa.userRole= 3;

                    form.Show();
                    this.Hide();
                }
            
                else if (cmbSirket.EditValue == "GENEL" && txtSifre.Text == "Dimergrup2022")
                {
                    AnaSayfa form = new AnaSayfa();
                    AnaSayfa.userRole= 4;

                    form.Show();
                    this.Hide();
                }
                else if (cmbSirket.EditValue == "MUHASEBE" && txtSifre.Text == "Muhasebe2022")
                {
                    AnaSayfa form = new AnaSayfa();
                    AnaSayfa.userRole = 5;

                    form.Show();
                    this.Hide();
                }
            }

        }
    }
}