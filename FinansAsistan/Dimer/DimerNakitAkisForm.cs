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
    public partial class DimerNakitAkisForm : DevExpress.XtraEditors.XtraForm
    {
        Data.dbDataContext _db = new Data.dbDataContext();
        public DimerNakitAkisForm()
        {
            InitializeComponent();
        }

        private void DimerNakitAkisForm_Load(object sender, EventArgs e)
        {

            var nakitakis = _db.DIMER_TBL_NAKITAKIS_NEWs;

            gridControl1.DataSource = nakitakis.OrderByDescending(x => x.ID);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            //Dimer Nakit Akış Güncelleme

            labelControl1.Text= gridView1.GetFocusedRowCellValue(colID).ToString();

            var guncelle = _db.DIMER_TBL_NAKITAKIS_NEWs.FirstOrDefault(x => x.ID == int.Parse(labelControl1.Text));

            _db.SubmitChanges();

            gridControl1.Refresh();
        }
    }
}