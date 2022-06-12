using DevExpress.XtraBars;
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
    public partial class AnaSayfa : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //datacontextler
        public Data.dbDataContext _dbDimer = new Data.dbDataContext();


        public Data.dbDiminDataContext _dbDimin = new Data.dbDiminDataContext();
        public Data.dbDmineralDataContext _dbDmineral = new Data.dbDmineralDataContext();


        //Yetki Kontrol
        public static int userRole { get; set; }

        //DİMER DEĞİŞKENLER
        private DimerNakitAkisForm nakitakis;
        private DimerIntacTarihiForm intacTarihi;
        private DimerEximBankForm eximbank;

        //DİMİN DEĞİŞKENLER
        private DiminNakitAkisForm diminNakitAkis;
        private DiminEximBankForm diminEximBank;
        private DiminIntacTarihi diminIntacTarihi;

        //DMİNERAL DEĞİŞKENLER
        private DmineralNakitAkisForm dmineralNakitAkis;
        private DmineralEximBankForm dmineralEximBank;
        private DmineralIntacTarihiForm dmineralIntacTarihi;

        //HIPOTEK DEĞİŞKENLER
       
        private GayriMenkul gayriMenkul;
     

        //CARI KARSILASTIRMA
        private CARI_KARSILASTIRMA carikarsılastirma;


        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void DimerAnaSayfa_Load(object sender, EventArgs e)
        {
            if (userRole == 1)
            {
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
            }
            else if (userRole == 2)
            {
                ribbonPage1.Visible = false;
                ribbonPage3.Visible = false;
            }
            else if (userRole == 3)
            {
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
            }
            else if (userRole == 5)
            {
                ribbonPage1.Visible = false;
                ribbonPage2.Visible = false;
                ribbonPage3.Visible = false;
                ribbonPage4.Visible = false;
            }

            ArkaPlan arka = new ArkaPlan();
            arka.MdiParent = this;
            arka.Show();
        }



        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (nakitakis == null || nakitakis.IsDisposed || nakitakis.Disposing)
            {
                nakitakis = new DimerNakitAkisForm();
                nakitakis.MdiParent = this;

                nakitakis.Show();
            }

            nakitakis.Focus();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (eximbank == null || eximbank.IsDisposed || eximbank.Disposing)
            {
                eximbank = new DimerEximBankForm();
                eximbank.MdiParent = this;
                eximbank.Show();
            }
            eximbank.Focus();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (intacTarihi == null || intacTarihi.IsDisposed || intacTarihi.Disposing)
            {
                intacTarihi = new DimerIntacTarihiForm();
                intacTarihi.MdiParent = this;
                intacTarihi.Show();
            }
            intacTarihi.Focus();
        }



        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Dimer Nakit Akış Ekleme

            Data.DIMER_TBL_NAKITAKIS_NEW DimerNakitAkis = new Data.DIMER_TBL_NAKITAKIS_NEW();

            DimerNakitAkis.KALEM = "Yeni Eklenen Kayıt...";
            DimerNakitAkis.P_1 = 0;
            DimerNakitAkis.P_2 = 0;
            DimerNakitAkis.P_3 = 0;
            DimerNakitAkis.P_4 = 0;
            DimerNakitAkis.P_5 = 0;
            DimerNakitAkis.P_6 = 0;
            DimerNakitAkis.P_7 = 0;
            DimerNakitAkis.P_8 = 0;
            DimerNakitAkis.P_9 = 0;
            DimerNakitAkis.P_10 = 0;
            DimerNakitAkis.P_11 = 0;
            DimerNakitAkis.P_12 = 0;
            DimerNakitAkis.G_1 = 0;
            DimerNakitAkis.G_2 = 0;
            DimerNakitAkis.G_3 = 0;
            DimerNakitAkis.G_4 = 0;
            DimerNakitAkis.G_5 = 0;
            DimerNakitAkis.G_6 = 0;
            DimerNakitAkis.G_7 = 0;
            DimerNakitAkis.G_8 = 0;
            DimerNakitAkis.G_9 = 0;
            DimerNakitAkis.G_10 = 0;
            DimerNakitAkis.G_11 = 0;
            DimerNakitAkis.G_12 = 0;


            _dbDimer.DIMER_TBL_NAKITAKIS_NEWs.InsertOnSubmit(DimerNakitAkis);
            _dbDimer.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;


         

        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Dimer Intac Tarihi Ekle
            Data.TBLFATUEK intac = new Data.TBLFATUEK();

            intac.SUBE_KODU = 0;
            intac.FKOD = '0';
            intac.FATIRSNO = "Yeni Eklenen";
            intac.CKOD = "Yeni Eklenen";
            intac.ACIK1 = null;
            intac.ACIK2 = null;
            intac.ACIK3 = null;
            intac.ACIK4 = null;
            intac.ACIK5 = null;
            intac.ACIK6 = null;
            intac.ACIK7 = null;
            intac.ACIK8 = null;
            intac.ACIK9 = null;
            intac.ACIK10 = null;
            intac.ACIK11 = null;
            intac.ACIK12 = null;
            intac.ACIK13 = null;
            intac.ACIK14 = null;
            intac.ACIK15 = null;
            intac.ACIK16 = null;

            _dbDimer.TBLFATUEKs.InsertOnSubmit(intac);
            _dbDimer.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
         

         
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Dimer Exim Bank Hareket Ekle

            Data.DIM_NDI_EXIMBANK exim = new Data.DIM_NDI_EXIMBANK();

            exim.TARIH = DateTime.Now;
            exim.BELGENO = "Yeni Kayıt";
            exim.BANKA_NO = null;
            exim.ACIKLAMA = null;
            exim.VADE_TARIHI = null;
            exim.BA = null;
            exim.TUTAR = 0;
            exim.DOVTIP = null;
            exim.DOVIZTUT = null;
            exim.FAIZ_ORANI = null;
            exim.D_KUR = null;
            exim.DURUM = null;
            exim.ONAYTIPI = null;
            exim.ONAYNUM = null;

            _dbDimer.DIM_NDI_EXIMBANKs.InsertOnSubmit(exim);
            _dbDimer.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
            

          

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diminNakitAkis == null || diminNakitAkis.IsDisposed || diminNakitAkis.Disposing)
            {
                diminNakitAkis = new DiminNakitAkisForm();
                diminNakitAkis.MdiParent = this;
                diminNakitAkis.Show();
            }

            diminNakitAkis.Focus();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dimin nakit akış ekle

            Data.DIMER_TBL_NAKITAKIS_NEW DiminNakitAkis = new Data.DIMER_TBL_NAKITAKIS_NEW();

            DiminNakitAkis.KALEM = "Yeni Eklenen Kayıt...";
            DiminNakitAkis.P_1 = 0;
            DiminNakitAkis.P_2 = 0;
            DiminNakitAkis.P_3 = 0;
            DiminNakitAkis.P_4 = 0;
            DiminNakitAkis.P_5 = 0;
            DiminNakitAkis.P_6 = 0;
            DiminNakitAkis.P_7 = 0;
            DiminNakitAkis.P_8 = 0;
            DiminNakitAkis.P_9 = 0;
            DiminNakitAkis.P_10 = 0;
            DiminNakitAkis.P_11 = 0;
            DiminNakitAkis.P_12 = 0;
            DiminNakitAkis.G_1 = 0;
            DiminNakitAkis.G_2 = 0;
            DiminNakitAkis.G_3 = 0;
            DiminNakitAkis.G_4 = 0;
            DiminNakitAkis.G_5 = 0;
            DiminNakitAkis.G_6 = 0;
            DiminNakitAkis.G_7 = 0;
            DiminNakitAkis.G_8 = 0;
            DiminNakitAkis.G_9 = 0;
            DiminNakitAkis.G_10 = 0;
            DiminNakitAkis.G_11 = 0;
            DiminNakitAkis.G_12 = 0;


            _dbDimin.DIMER_TBL_NAKITAKIS_NEWs.InsertOnSubmit(DiminNakitAkis);
            _dbDimin.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
         
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diminEximBank == null || diminEximBank.IsDisposed || diminEximBank.Disposing)
            {
                diminEximBank = new DiminEximBankForm();
                diminEximBank.MdiParent = this;
                diminEximBank.Show();
            }
            diminEximBank.Focus();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dimin eximbank ekle

            Data.DIM_NDI_EXIMBANK Diminexim = new Data.DIM_NDI_EXIMBANK();

            Diminexim.TARIH = DateTime.Now;
            Diminexim.BELGENO = "Yeni Kayıt";
            Diminexim.BANKA_NO = null;
            Diminexim.ACIKLAMA = null;
            Diminexim.VADE_TARIHI = null;
            Diminexim.BA = null;
            Diminexim.TUTAR = 0;
            Diminexim.DOVTIP = null;
            Diminexim.DOVIZTUT = null;
            Diminexim.FAIZ_ORANI = null;
            Diminexim.D_KUR = null;
            Diminexim.DURUM = null;
            Diminexim.ONAYTIPI = null;
            Diminexim.ONAYNUM = null;

            _dbDimin.DIM_NDI_EXIMBANKs.InsertOnSubmit(Diminexim);
            _dbDimin.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
        
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (diminIntacTarihi == null || diminIntacTarihi.IsDisposed || diminIntacTarihi.Disposing)
            {
                diminIntacTarihi = new DiminIntacTarihi();
                diminIntacTarihi.MdiParent = this;
                diminIntacTarihi.Show();
            }
            diminIntacTarihi.Focus();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dimin intac tarihi ekle

            Data.TBLFATUEK intac = new Data.TBLFATUEK();

            intac.SUBE_KODU = 0;
            intac.FKOD = '0';
            intac.FATIRSNO = "Yeni Eklenen";
            intac.CKOD = "Yeni Eklenen";
            intac.ACIK1 = null;
            intac.ACIK2 = null;
            intac.ACIK3 = null;
            intac.ACIK4 = null;
            intac.ACIK5 = null;
            intac.ACIK6 = null;
            intac.ACIK7 = null;
            intac.ACIK8 = null;
            intac.ACIK9 = null;
            intac.ACIK10 = null;
            intac.ACIK11 = null;
            intac.ACIK12 = null;
            intac.ACIK13 = null;
            intac.ACIK14 = null;
            intac.ACIK15 = null;
            intac.ACIK16 = null;

            _dbDimin.TBLFATUEKs.InsertOnSubmit(intac);
            _dbDimin.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;


        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dmineralNakitAkis == null || dmineralNakitAkis.IsDisposed || dmineralNakitAkis.Disposing)
            {
                dmineralNakitAkis = new DmineralNakitAkisForm();
                dmineralNakitAkis.MdiParent = this;
                dmineralNakitAkis.Show();
            }
            dmineralNakitAkis.Focus();
        }

        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dmineralEximBank == null || dmineralEximBank.IsDisposed || dmineralEximBank.Disposing)
            {
                dmineralEximBank = new DmineralEximBankForm();
                dmineralEximBank.MdiParent = this;
                dmineralEximBank.Show();
            }
            dmineralEximBank.Focus();
        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (dmineralIntacTarihi == null || dmineralIntacTarihi.IsDisposed || dmineralIntacTarihi.Disposing)
            {
                dmineralIntacTarihi = new DmineralIntacTarihiForm();
                dmineralIntacTarihi.MdiParent = this;
                dmineralIntacTarihi.Show();
            }
            dmineralIntacTarihi.Focus();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Dmineral Nakit Akış Ekle

            Data.DIMER_TBL_NAKITAKIS_NEW Dmineral = new Data.DIMER_TBL_NAKITAKIS_NEW();

            Dmineral.KALEM = "Yeni Eklenen Kayıt...";
            Dmineral.P_1 = 0;
            Dmineral.P_2 = 0;
            Dmineral.P_3 = 0;
            Dmineral.P_4 = 0;
            Dmineral.P_5 = 0;
            Dmineral.P_6 = 0;
            Dmineral.P_7 = 0;
            Dmineral.P_8 = 0;
            Dmineral.P_9 = 0;
            Dmineral.P_10 = 0;
            Dmineral.P_11 = 0;
            Dmineral.P_12 = 0;
            Dmineral.G_1 = 0;
            Dmineral.G_2 = 0;
            Dmineral.G_3 = 0;
            Dmineral.G_4 = 0;
            Dmineral.G_5 = 0;
            Dmineral.G_6 = 0;
            Dmineral.G_7 = 0;
            Dmineral.G_8 = 0;
            Dmineral.G_9 = 0;
            Dmineral.G_10 = 0;
            Dmineral.G_11 = 0;
            Dmineral.G_12 = 0;


            _dbDmineral.DIMER_TBL_NAKITAKIS_NEWs.InsertOnSubmit(Dmineral);
            _dbDmineral.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
         
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            //dmineral Exim Bank Ekle


            Data.DIM_NDI_EXIMBANK Dminralexim = new Data.DIM_NDI_EXIMBANK();

            Dminralexim.TARIH = DateTime.Now;
            Dminralexim.BELGENO = "Yeni Kayıt";
            Dminralexim.BANKA_NO = null;
            Dminralexim.ACIKLAMA = null;
            Dminralexim.VADE_TARIHI = null;
            Dminralexim.BA = null;
            Dminralexim.TUTAR = 0;
            Dminralexim.DOVTIP = null;
            Dminralexim.DOVIZTUT = null;
            Dminralexim.FAIZ_ORANI = null;
            Dminralexim.D_KUR = null;
            Dminralexim.DURUM = null;
            Dminralexim.ONAYTIPI = null;
            Dminralexim.ONAYNUM = null;

            _dbDmineral.DIM_NDI_EXIMBANKs.InsertOnSubmit(Dminralexim);
            _dbDmineral.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
           

        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Dmineral Intac Tarihi Ekle


            Data.TBLFATUEK Dmineralintac = new Data.TBLFATUEK();

            Dmineralintac.SUBE_KODU = 0;
            Dmineralintac.FKOD = '0';
            Dmineralintac.FATIRSNO = "Yeni Eklenen";
            Dmineralintac.CKOD = "Yeni Eklenen";
            Dmineralintac.ACIK1 = null;
            Dmineralintac.ACIK2 = null;
            Dmineralintac.ACIK3 = null;
            Dmineralintac.ACIK4 = null;
            Dmineralintac.ACIK5 = null;
            Dmineralintac.ACIK6 = null;
            Dmineralintac.ACIK7 = null;
            Dmineralintac.ACIK8 = null;
            Dmineralintac.ACIK9 = null;
            Dmineralintac.ACIK10 = null;
            Dmineralintac.ACIK11 = null;
            Dmineralintac.ACIK12 = null;
            Dmineralintac.ACIK13 = null;
            Dmineralintac.ACIK14 = null;
            Dmineralintac.ACIK15 = null;
            Dmineralintac.ACIK16 = null;

            _dbDmineral.TBLFATUEKs.InsertOnSubmit(Dmineralintac);
            _dbDmineral.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;

            

        }

        public void Kapat()
        {
            Application.Exit();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Close();
            Kapat();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Close();
            Kapat();
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Close();
            Kapat();
        }


        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {

            if (gayriMenkul == null || gayriMenkul.IsDisposed || gayriMenkul.Disposing)
            {
                gayriMenkul = new GayriMenkul();
                gayriMenkul.MdiParent = this;
                gayriMenkul.Show();
                gayriMenkul.Refresh();
            }
            gayriMenkul.Refresh();
            gayriMenkul.Focus();

        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
          
            Data.TBL_CHD_FINANS_HIPOTEK chd = new Data.TBL_CHD_FINANS_HIPOTEK();              

            
            _dbDimer.TBL_CHD_FINANS_HIPOTEKs.InsertOnSubmit(chd);
           
            _dbDimer.SubmitChanges();

            int a = chd.ID;


            Data.DIMER_TBL_GM gayri = new Data.DIMER_TBL_GM();

            gayri.SIRANO = ("DIMER"+a).ToString();
            gayri.CINSI = "ZZ-YENİ EKLENEN KAYIT";
            _dbDimer.DIMER_TBL_GMs.InsertOnSubmit(gayri);

            _dbDimer.SubmitChanges();

            alertControl1.Show(this, "BİLGİ", "Veri Eklendi. Sekmeyi Yenileyiniz.", "");
            alertControl1.AutoFormDelay = 3000;
           

            GayriMenkul fr = new GayriMenkul();
            fr.gridView1.RefreshData();


        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (carikarsılastirma == null || carikarsılastirma.IsDisposed || carikarsılastirma.Disposing)
            {
                carikarsılastirma = new CARI_KARSILASTIRMA();
                carikarsılastirma.MdiParent = this;
                carikarsılastirma.Show();
                carikarsılastirma.Refresh();
            }
            carikarsılastirma.Refresh();
            carikarsılastirma.Focus();
        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
            Kapat();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            Kapat();
        }
    }
}