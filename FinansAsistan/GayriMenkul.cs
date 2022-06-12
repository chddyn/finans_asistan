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
    public partial class GayriMenkul : DevExpress.XtraEditors.XtraForm
    {
        Data.dbDataContext _db = new Data.dbDataContext();

        public GayriMenkul()
        {
            InitializeComponent();
        }

        private void GayriMenkul_Load(object sender, EventArgs e)
        {
                        
            var gayrimenkulsira = _db.DIMER_TBL_GMs;

            gridControl1.DataSource = gayrimenkulsira.OrderByDescending(x => x.CINSI);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            XtraSaveFileDialog dialog = new XtraSaveFileDialog();
            dialog.Filter = dialog.FileName;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                gridView1.ExportToXlsx(dialog.FileName + ".xlsx");
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
           // Dimer Gayri Menkul Hipotek Güncelleme

            labelControl1.Text = gridView1.GetFocusedRowCellValue(colSIRANO).ToString();

            var guncelle = _db.DIMER_TBL_GMs.FirstOrDefault(x => x.SIRANO == labelControl1.Text);

            _db.SubmitChanges();

            gridControl1.Refresh();
        }
    }
}