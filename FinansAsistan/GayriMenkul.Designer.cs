namespace FinansAsistan
{
    partial class GayriMenkul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GayriMenkul));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCINSI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSIRANO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTAPUADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBELEDIYESI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADRESI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDURUMU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOSYA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONAYTIPI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colONAYNUM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALINANYER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALIMBEDELI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPIYASADEGERI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATILANYER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSATISBEDELI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dIMERTBLGMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIMERTBLGMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1762, 708);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCINSI,
            this.colSIRANO,
            this.colTAPUADI,
            this.colBELEDIYESI,
            this.colADRESI,
            this.colDURUMU,
            this.colACIKLAMA,
            this.colDOSYA,
            this.colONAYTIPI,
            this.colONAYNUM,
            this.colALINANYER,
            this.colALIMBEDELI,
            this.colPIYASADEGERI,
            this.colSATILANYER,
            this.colSATISBEDELI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // colCINSI
            // 
            this.colCINSI.FieldName = "CINSI";
            this.colCINSI.Name = "colCINSI";
            this.colCINSI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colCINSI.Visible = true;
            this.colCINSI.VisibleIndex = 0;
            // 
            // colSIRANO
            // 
            this.colSIRANO.FieldName = "SIRANO";
            this.colSIRANO.Name = "colSIRANO";
            this.colSIRANO.OptionsColumn.AllowEdit = false;
            this.colSIRANO.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colSIRANO.Visible = true;
            this.colSIRANO.VisibleIndex = 1;
            // 
            // colTAPUADI
            // 
            this.colTAPUADI.FieldName = "TAPUADI";
            this.colTAPUADI.Name = "colTAPUADI";
            this.colTAPUADI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colTAPUADI.Visible = true;
            this.colTAPUADI.VisibleIndex = 2;
            // 
            // colBELEDIYESI
            // 
            this.colBELEDIYESI.FieldName = "BELEDIYESI";
            this.colBELEDIYESI.Name = "colBELEDIYESI";
            this.colBELEDIYESI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colBELEDIYESI.Visible = true;
            this.colBELEDIYESI.VisibleIndex = 3;
            // 
            // colADRESI
            // 
            this.colADRESI.FieldName = "ADRESI";
            this.colADRESI.Name = "colADRESI";
            this.colADRESI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colADRESI.Visible = true;
            this.colADRESI.VisibleIndex = 4;
            // 
            // colDURUMU
            // 
            this.colDURUMU.FieldName = "DURUMU";
            this.colDURUMU.Name = "colDURUMU";
            this.colDURUMU.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colDURUMU.Visible = true;
            this.colDURUMU.VisibleIndex = 5;
            // 
            // colACIKLAMA
            // 
            this.colACIKLAMA.FieldName = "ACIKLAMA";
            this.colACIKLAMA.Name = "colACIKLAMA";
            this.colACIKLAMA.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colACIKLAMA.Visible = true;
            this.colACIKLAMA.VisibleIndex = 6;
            // 
            // colDOSYA
            // 
            this.colDOSYA.FieldName = "DOSYA";
            this.colDOSYA.Name = "colDOSYA";
            this.colDOSYA.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colDOSYA.Visible = true;
            this.colDOSYA.VisibleIndex = 7;
            // 
            // colONAYTIPI
            // 
            this.colONAYTIPI.FieldName = "ONAYTIPI";
            this.colONAYTIPI.Name = "colONAYTIPI";
            this.colONAYTIPI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colONAYTIPI.Visible = true;
            this.colONAYTIPI.VisibleIndex = 8;
            // 
            // colONAYNUM
            // 
            this.colONAYNUM.FieldName = "ONAYNUM";
            this.colONAYNUM.Name = "colONAYNUM";
            this.colONAYNUM.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colONAYNUM.Visible = true;
            this.colONAYNUM.VisibleIndex = 9;
            // 
            // colALINANYER
            // 
            this.colALINANYER.FieldName = "ALINANYER";
            this.colALINANYER.Name = "colALINANYER";
            this.colALINANYER.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colALINANYER.Visible = true;
            this.colALINANYER.VisibleIndex = 10;
            // 
            // colALIMBEDELI
            // 
            this.colALIMBEDELI.FieldName = "ALIMBEDELI";
            this.colALIMBEDELI.Name = "colALIMBEDELI";
            this.colALIMBEDELI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colALIMBEDELI.Visible = true;
            this.colALIMBEDELI.VisibleIndex = 11;
            // 
            // colPIYASADEGERI
            // 
            this.colPIYASADEGERI.FieldName = "PIYASADEGERI";
            this.colPIYASADEGERI.Name = "colPIYASADEGERI";
            this.colPIYASADEGERI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colPIYASADEGERI.Visible = true;
            this.colPIYASADEGERI.VisibleIndex = 12;
            // 
            // colSATILANYER
            // 
            this.colSATILANYER.FieldName = "SATILANYER";
            this.colSATILANYER.Name = "colSATILANYER";
            this.colSATILANYER.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colSATILANYER.Visible = true;
            this.colSATILANYER.VisibleIndex = 13;
            // 
            // colSATISBEDELI
            // 
            this.colSATISBEDELI.FieldName = "SATISBEDELI";
            this.colSATISBEDELI.Name = "colSATISBEDELI";
            this.colSATISBEDELI.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.True;
            this.colSATISBEDELI.Visible = true;
            this.colSATISBEDELI.VisibleIndex = 14;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(161, 236);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "labelControl1";
            this.labelControl1.Visible = false;
            // 
            // dIMERTBLGMBindingSource
            // 
            this.dIMERTBLGMBindingSource.DataMember = "DIMER_TBL_GM";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(791, 738);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(122, 37);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Excele Aktar";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // GayriMenkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1762, 787);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "GayriMenkul";
            this.Text = "GayriMenkul";
            this.Load += new System.EventHandler(this.GayriMenkul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIMERTBLGMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
       
        private System.Windows.Forms.BindingSource dIMERTBLGMBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCINSI;
        private DevExpress.XtraGrid.Columns.GridColumn colSIRANO;
        private DevExpress.XtraGrid.Columns.GridColumn colTAPUADI;
        private DevExpress.XtraGrid.Columns.GridColumn colBELEDIYESI;
        private DevExpress.XtraGrid.Columns.GridColumn colADRESI;
        private DevExpress.XtraGrid.Columns.GridColumn colDURUMU;
        private DevExpress.XtraGrid.Columns.GridColumn colACIKLAMA;
        private DevExpress.XtraGrid.Columns.GridColumn colDOSYA;
        private DevExpress.XtraGrid.Columns.GridColumn colONAYTIPI;
        private DevExpress.XtraGrid.Columns.GridColumn colONAYNUM;
        private DevExpress.XtraGrid.Columns.GridColumn colALINANYER;
        private DevExpress.XtraGrid.Columns.GridColumn colALIMBEDELI;
        private DevExpress.XtraGrid.Columns.GridColumn colPIYASADEGERI;
        private DevExpress.XtraGrid.Columns.GridColumn colSATILANYER;
        private DevExpress.XtraGrid.Columns.GridColumn colSATISBEDELI;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}