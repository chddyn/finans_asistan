using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrintingLinks;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace FinansAsistan
{
    public partial class CARI_KARSILASTIRMA : DevExpress.XtraEditors.XtraForm
    {
        Data.dbDataContext _db = new Data.dbDataContext();


        public CARI_KARSILASTIRMA()
        {
            InitializeComponent();
        }

        private void CARI_KARSILASTIRMA_Load(object sender, EventArgs e)
        {
           


            gridControl1.DataSource = _db._VW_CHD_CARI_KARSILASTIRMAs;

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Cari Açıklama Güncelleme / ekleme

            labelControl2.Text = gridView1.GetFocusedRowCellValue(colACIKLAMA).ToString();

            labelControl3.Text = gridView1.GetFocusedRowCellValue(colCARI_KOD).ToString();


            if (labelControl1.Text == "" || labelControl1.Text == null || labelControl1.Text == " ")
            {
                Data.TBL_CHD_FINANS_CARI_KARSILASTIRMA ekle = new Data.TBL_CHD_FINANS_CARI_KARSILASTIRMA();
                ekle.CARI_KOD = labelControl3.Text;
                ekle.ACIKLAMA = labelControl2.Text;

                _db.TBL_CHD_FINANS_CARI_KARSILASTIRMAs.InsertOnSubmit(ekle);
            }
            else
            {
                labelControl1.Text = gridView1.GetFocusedRowCellValue(colID).ToString();
                var guncelle = _db.TBL_CHD_FINANS_CARI_KARSILASTIRMAs.First(x => x.ID == int.Parse(labelControl1.Text));
                if (guncelle != null)
                {
                    guncelle.ACIKLAMA = labelControl2.Text;



                    alertControl1.Show(this, "BİLGİ", "Güncelleme Başarılı", string.Empty);
                    alertControl1.AutoFormDelay = 3000;
                }
                else
                {
                    Data.TBL_CHD_FINANS_CARI_KARSILASTIRMA ekle = new Data.TBL_CHD_FINANS_CARI_KARSILASTIRMA();
                    ekle.CARI_KOD = labelControl3.Text;
                    ekle.ACIKLAMA = labelControl2.Text;
                    _db.TBL_CHD_FINANS_CARI_KARSILASTIRMAs.InsertOnSubmit(ekle);
                }

            }


            _db.SubmitChanges();

        }


        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            labelControl1.Text = "";
            labelControl2.Text = "";
            labelControl3.Text = "";
        }

        private void ExcelAktar_Click(object sender, EventArgs e)
        {
            XtraSaveFileDialog dialog = new XtraSaveFileDialog();
            dialog.Filter = dialog.FileName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {

                gridView1.ExportToXlsx(dialog.FileName+".xlsx");
            }

        }
    }
}