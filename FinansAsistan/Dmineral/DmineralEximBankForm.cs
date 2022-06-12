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
    public partial class DmineralEximBankForm : DevExpress.XtraEditors.XtraForm
    {
        Data.dbDmineralDataContext _db = new Data.dbDmineralDataContext();

        public DmineralEximBankForm()
        {
            InitializeComponent();
        }

        private void DmineralEximBankForm_Load(object sender, EventArgs e)
        {

            var eximbank = _db.DIM_NDI_EXIMBANKs;

            gridControl1.DataSource = eximbank.OrderByDescending(x => x.ID);


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Dmineral Exim Bank Güncelleme

            labelControl1.Text= gridView1.GetFocusedRowCellValue(colID).ToString();

            var guncelle = _db.DIM_NDI_EXIMBANKs.FirstOrDefault(x => x.ID == int.Parse(labelControl1.Text));

            _db.SubmitChanges();

            gridControl1.Refresh();
        }
    }
}