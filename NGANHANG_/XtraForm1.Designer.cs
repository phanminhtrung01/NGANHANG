
namespace NGANHANG_
{
    partial class XtraForm1
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
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.gvTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbmTK = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.tbaTK = new NGANHANG_.DSTableAdapters.TaiKhoanTableAdapter();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            this.SuspendLayout();
            // 
            // gcTK
            // 
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTK.Location = new System.Drawing.Point(0, 0);
            this.gcTK.MainView = this.gvTK;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(1436, 637);
            this.gcTK.TabIndex = 12;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTK});
            // 
            // gvTK
            // 
            this.gvTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gvTK.GridControl = this.gcTK;
            this.gvTK.Name = "gvTK";
            this.gvTK.OptionsBehavior.Editable = false;
            this.gvTK.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gvTK.OptionsView.ShowDetailButtons = false;
            this.gvTK.OptionsView.ShowGroupPanel = false;
            this.gvTK.OptionsView.ShowIndicator = false;
            this.gvTK.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvTK.OptionsView.ShowViewCaption = true;
            this.gvTK.ViewCaption = "Tài Khoản Khách hàng";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số Tài Khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 2;
            this.colSOTK.Width = 112;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Chứng Minh Nhân Dân";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 1;
            this.colCMND.Width = 112;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số Dư Tài Khoản";
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 30;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 0;
            this.colSODU.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã Chi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 112;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày Mở Tài Khoản";
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 30;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 112;
            // 
            // tbmTK
            // 
            this.tbmTK.BackupDataSetBeforeUpdate = false;
            this.tbmTK.GD_CHUYENTIENTableAdapter = null;
            this.tbmTK.GD_GOIRUTTableAdapter = null;
            this.tbmTK.KhachHangTableAdapter = null;
            this.tbmTK.NhanVienTableAdapter = null;
            this.tbmTK.TaiKhoanTableAdapter = this.tbaTK;
            this.tbmTK.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbaTK
            // 
            this.tbaTK.ClearBeforeFill = true;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TaiKhoan";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 637);
            this.Controls.Add(this.gcTK);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DSTableAdapters.TableAdapterManager tbmTK;
        private DSTableAdapters.TaiKhoanTableAdapter tbaTK;
        private System.Windows.Forms.BindingSource bdsTK;
    }
}