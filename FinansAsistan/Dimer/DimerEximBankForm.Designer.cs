namespace FinansAsistan
{
    partial class DimerEximBankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DimerEximBankForm));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTARIH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBANKA_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVADE_TARIHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOVTIP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOVIZTUT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAIZ_ORANI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_KUR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONAYTIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONAYNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dIMNDIEXIMBANKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIMNDIEXIMBANKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1446, 790);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTARIH,
            this.colBELGENO,
            this.colBANKA_NO,
            this.colACIKLAMA,
            this.colVADE_TARIHI,
            this.colBA,
            this.colTUTAR,
            this.colDOVTIP,
            this.colDOVIZTUT,
            this.colFAIZ_ORANI,
            this.colD_KUR,
            this.colDURUM,
            this.colONAYTIPI,
            this.colONAYNUM,
            this.colID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colTARIH
            // 
            this.colTARIH.FieldName = "TARIH";
            this.colTARIH.Name = "colTARIH";
            this.colTARIH.Visible = true;
            this.colTARIH.VisibleIndex = 0;
            // 
            // colBELGENO
            // 
            this.colBELGENO.FieldName = "BELGENO";
            this.colBELGENO.Name = "colBELGENO";
            this.colBELGENO.Visible = true;
            this.colBELGENO.VisibleIndex = 1;
            // 
            // colBANKA_NO
            // 
            this.colBANKA_NO.FieldName = "BANKA_NO";
            this.colBANKA_NO.Name = "colBANKA_NO";
            this.colBANKA_NO.Visible = true;
            this.colBANKA_NO.VisibleIndex = 2;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 3;
            // 
            // colVADE_TARIHI
            // 
            this.colVADE_TARIHI.FieldName = "VADE_TARIHI";
            this.colVADE_TARIHI.Name = "colVADE_TARIHI";
            this.colVADE_TARIHI.Visible = true;
            this.colVADE_TARIHI.VisibleIndex = 4;
            // 
            // colBA
            // 
            this.colBA.FieldName = "BA";
            this.colBA.Name = "colBA";
            this.colBA.Visible = true;
            this.colBA.VisibleIndex = 5;
            // 
            // colTUTAR
            // 
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 6;
            // 
            // colDOVTIP
            // 
            this.colDOVTIP.FieldName = "DOVTIP";
            this.colDOVTIP.Name = "colDOVTIP";
            this.colDOVTIP.Visible = true;
            this.colDOVTIP.VisibleIndex = 7;
            // 
            // colDOVIZTUT
            // 
            this.colDOVIZTUT.FieldName = "DOVIZTUT";
            this.colDOVIZTUT.Name = "colDOVIZTUT";
            this.colDOVIZTUT.Visible = true;
            this.colDOVIZTUT.VisibleIndex = 8;
            // 
            // colFAIZ_ORANI
            // 
            this.colFAIZ_ORANI.FieldName = "FAIZ_ORANI";
            this.colFAIZ_ORANI.Name = "colFAIZ_ORANI";
            this.colFAIZ_ORANI.Visible = true;
            this.colFAIZ_ORANI.VisibleIndex = 9;
            // 
            // colD_KUR
            // 
            this.colD_KUR.FieldName = "D_KUR";
            this.colD_KUR.Name = "colD_KUR";
            this.colD_KUR.Visible = true;
            this.colD_KUR.VisibleIndex = 10;
            // 
            // colDURUM
            // 
            this.colDURUM.FieldName = "DURUM";
            this.colDURUM.Name = "colDURUM";
            this.colDURUM.Visible = true;
            this.colDURUM.VisibleIndex = 11;
            // 
            // colONAYTIPI
            // 
            this.colONAYTIPI.FieldName = "ONAYTIPI";
            this.colONAYTIPI.Name = "colONAYTIPI";
            this.colONAYTIPI.Visible = true;
            this.colONAYTIPI.VisibleIndex = 12;
            // 
            // colONAYNUM
            // 
            this.colONAYNUM.FieldName = "ONAYNUM";
            this.colONAYNUM.Name = "colONAYNUM";
            this.colONAYNUM.Visible = true;
            this.colONAYNUM.VisibleIndex = 13;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 158);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            this.labelControl1.Visible = false;
            // 
            // DimerEximBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 790);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DimerEximBankForm.IconOptions.SvgImage")));
            this.Name = "DimerEximBankForm";
            this.Text = "DIMER EXIM BANK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DimerEximBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIMNDIEXIMBANKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
   
        private System.Windows.Forms.BindingSource dIMNDIEXIMBANKBindingSource;

        private DevExpress.XtraGrid.Columns.GridColumn colTARIH;
        private DevExpress.XtraGrid.Columns.GridColumn colBELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn colBANKA_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colVADE_TARIHI;
        private DevExpress.XtraGrid.Columns.GridColumn colBA;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colDOVTIP;
        private DevExpress.XtraGrid.Columns.GridColumn colDOVIZTUT;
        private DevExpress.XtraGrid.Columns.GridColumn colFAIZ_ORANI;
        private DevExpress.XtraGrid.Columns.GridColumn colD_KUR;
        private DevExpress.XtraGrid.Columns.GridColumn colDURUM;
        private DevExpress.XtraGrid.Columns.GridColumn colONAYTIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colONAYNUM;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}