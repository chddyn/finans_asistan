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
    public partial class DiminIntacTarihi : DevExpress.XtraEditors.XtraForm
    {
        Data.dbDiminDataContext _db = new Data.dbDiminDataContext();

        public DiminIntacTarihi()
        {
            InitializeComponent();
        }

        private void DiminIntacTarihi_Load(object sender, EventArgs e)
        {

            var intactarihi = _db.TBLFATUEKs;

            gridControl1.DataSource= intactarihi.OrderByDescending(x => x.CKOD);

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Dimin İntac Tarihi Güncelleme

            labelControl1.Text= gridView1.GetFocusedRowCellValue(colFKOD).ToString();

            labelControl2.Text= gridView1.GetFocusedRowCellValue(colFATIRSNO).ToString();


            var guncelle = _db.TBLFATUEKs.FirstOrDefault(x => x.FKOD == char.Parse(labelControl1.Text) && x.FATIRSNO == labelControl2.Text.ToString());

            _db.SubmitChanges();

            gridControl1.Refresh();
        }
    }
}