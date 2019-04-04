namespace NursanWinFormUI.Views.Copper
{
    partial class CopperStandartForm
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
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colUrunKodu = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colAnmaKesit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colKesit = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colTelSayisi = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinDirenc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMaxDirenc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMaxBukuluCap = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMinHatveBoy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colMaxHatveBoy = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colBirimAgırlık = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colCopperControl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.nursanKabloDataBaseDataSet = new NursanWinFormUI.NursanKabloDataBaseDataSet();
            this.nursanKabloDataBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursanKabloDataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursanKabloDataBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.nursanKabloDataBaseDataSetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(835, 389);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1,
            this.layoutView1,
            this.tileView1});
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colId,
            this.colUrunKodu,
            this.colAnmaKesit,
            this.colKesit,
            this.colTelSayisi,
            this.colCap,
            this.colMinDirenc,
            this.colMaxDirenc,
            this.colMaxBukuluCap,
            this.colMinHatveBoy,
            this.colMaxHatveBoy,
            this.colBirimAgırlık,
            this.colCopperControl});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.advBandedGridView1.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.Click;
            this.advBandedGridView1.OptionsFind.AlwaysVisible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Columns.Add(this.colId);
            this.gridBand1.Columns.Add(this.colUrunKodu);
            this.gridBand1.Columns.Add(this.colAnmaKesit);
            this.gridBand1.Columns.Add(this.colKesit);
            this.gridBand1.Columns.Add(this.colTelSayisi);
            this.gridBand1.Columns.Add(this.colCap);
            this.gridBand1.Columns.Add(this.colMinDirenc);
            this.gridBand1.Columns.Add(this.colMaxDirenc);
            this.gridBand1.Columns.Add(this.colMaxBukuluCap);
            this.gridBand1.Columns.Add(this.colMinHatveBoy);
            this.gridBand1.Columns.Add(this.colMaxHatveBoy);
            this.gridBand1.Columns.Add(this.colBirimAgırlık);
            this.gridBand1.Columns.Add(this.colCopperControl);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 975;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            // 
            // colUrunKodu
            // 
            this.colUrunKodu.FieldName = "UrunKodu";
            this.colUrunKodu.Name = "colUrunKodu";
            this.colUrunKodu.Visible = true;
            // 
            // colAnmaKesit
            // 
            this.colAnmaKesit.FieldName = "AnmaKesit";
            this.colAnmaKesit.Name = "colAnmaKesit";
            this.colAnmaKesit.Visible = true;
            // 
            // colKesit
            // 
            this.colKesit.FieldName = "Kesit";
            this.colKesit.Name = "colKesit";
            this.colKesit.Visible = true;
            // 
            // colTelSayisi
            // 
            this.colTelSayisi.FieldName = "TelSayisi";
            this.colTelSayisi.Name = "colTelSayisi";
            this.colTelSayisi.Visible = true;
            // 
            // colCap
            // 
            this.colCap.FieldName = "Cap";
            this.colCap.Name = "colCap";
            this.colCap.Visible = true;
            // 
            // colMinDirenc
            // 
            this.colMinDirenc.FieldName = "MinDirenc";
            this.colMinDirenc.Name = "colMinDirenc";
            this.colMinDirenc.Visible = true;
            // 
            // colMaxDirenc
            // 
            this.colMaxDirenc.FieldName = "MaxDirenc";
            this.colMaxDirenc.Name = "colMaxDirenc";
            this.colMaxDirenc.Visible = true;
            // 
            // colMaxBukuluCap
            // 
            this.colMaxBukuluCap.FieldName = "MaxBukuluCap";
            this.colMaxBukuluCap.Name = "colMaxBukuluCap";
            this.colMaxBukuluCap.Visible = true;
            // 
            // colMinHatveBoy
            // 
            this.colMinHatveBoy.FieldName = "MinHatveBoy";
            this.colMinHatveBoy.Name = "colMinHatveBoy";
            this.colMinHatveBoy.Visible = true;
            // 
            // colMaxHatveBoy
            // 
            this.colMaxHatveBoy.FieldName = "MaxHatveBoy";
            this.colMaxHatveBoy.Name = "colMaxHatveBoy";
            this.colMaxHatveBoy.Visible = true;
            // 
            // colBirimAgırlık
            // 
            this.colBirimAgırlık.FieldName = "BirimAgırlık";
            this.colBirimAgırlık.Name = "colBirimAgırlık";
            this.colBirimAgırlık.Visible = true;
            // 
            // colCopperControl
            // 
            this.colCopperControl.FieldName = "CopperControl";
            this.colCopperControl.Name = "colCopperControl";
            this.colCopperControl.Visible = true;
            // 
            // layoutView1
            // 
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Name = "layoutViewTemplateCard";
            // 
            // nursanKabloDataBaseDataSet
            // 
            this.nursanKabloDataBaseDataSet.DataSetName = "NursanKabloDataBaseDataSet";
            this.nursanKabloDataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nursanKabloDataBaseDataSetBindingSource
            // 
            this.nursanKabloDataBaseDataSetBindingSource.DataSource = this.nursanKabloDataBaseDataSet;
            this.nursanKabloDataBaseDataSetBindingSource.Position = 0;
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridControl1;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridControl1);
            this.gridSplitContainer1.Size = new System.Drawing.Size(835, 389);
            this.gridSplitContainer1.TabIndex = 0;
            // 
            // CopperStandartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 389);
            this.Controls.Add(this.gridSplitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CopperStandartForm";
            this.Text = "CopperStandartForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CopperStandartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursanKabloDataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nursanKabloDataBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colUrunKodu;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colAnmaKesit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colKesit;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colTelSayisi;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCap;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinDirenc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaxDirenc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaxBukuluCap;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMinHatveBoy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colMaxHatveBoy;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBirimAgırlık;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCopperControl;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private System.Windows.Forms.BindingSource nursanKabloDataBaseDataSetBindingSource;
        private NursanKabloDataBaseDataSet nursanKabloDataBaseDataSet;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
    }
}