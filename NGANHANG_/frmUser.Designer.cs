
namespace NGANHANG_
{
    partial class frmUser
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
            System.Windows.Forms.Label sODTLabel;
            System.Windows.Forms.Label nGAYCAPLabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label kHLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bmgCRUD = new DevExpress.XtraBars.BarManager(this.components);
            this.barTool = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnWri = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new NGANHANG_.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaKH = new NGANHANG_.DSTableAdapters.KhachHangTableAdapter();
            this.tbmKH = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.bdsTTKH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaTTKH = new NGANHANG_.DSTableAdapters.TTKHTableAdapter();
            this.pncChiNhanh = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.gvKH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCancel = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.pcKH = new DevExpress.XtraEditors.PanelControl();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtMCN = new System.Windows.Forms.TextBox();
            this.txeSDT = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayCap = new System.Windows.Forms.DateTimePicker();
            this.cmbPhai = new System.Windows.Forms.ComboBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.cmbTTKH = new System.Windows.Forms.ComboBox();
            this.bdsTK_KH = new System.Windows.Forms.BindingSource(this.components);
            this.tbaTK_KH = new NGANHANG_.DSTableAdapters.TaiKhoanTableAdapter();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.tbaNV = new NGANHANG_.DSTableAdapters.NhanVienTableAdapter();
            this.pncAler = new DevExpress.XtraEditors.PanelControl();
            this.txtInfo_ = new System.Windows.Forms.TextBox();
            this.ptbType = new System.Windows.Forms.PictureBox();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.gcTK_KH = new DevExpress.XtraGrid.GridControl();
            this.gvTK_KH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstMACN = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bdsGRTK = new System.Windows.Forms.BindingSource(this.components);
            this.tbaGRTK = new NGANHANG_.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.bdsCTTKC = new System.Windows.Forms.BindingSource(this.components);
            this.tbaCT = new NGANHANG_.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.bdsCTTKN = new System.Windows.Forms.BindingSource(this.components);
            sODTLabel = new System.Windows.Forms.Label();
            nGAYCAPLabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            kHLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bmgCRUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).BeginInit();
            this.pncChiNhanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcKH)).BeginInit();
            this.pcKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncAler)).BeginInit();
            this.pncAler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstMACN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGRTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTTKC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTTKN)).BeginInit();
            this.SuspendLayout();
            // 
            // sODTLabel
            // 
            sODTLabel.AutoSize = true;
            sODTLabel.Location = new System.Drawing.Point(397, 196);
            sODTLabel.Name = "sODTLabel";
            sODTLabel.Size = new System.Drawing.Size(57, 19);
            sODTLabel.TabIndex = 14;
            sODTLabel.Text = "SODT:";
            // 
            // nGAYCAPLabel
            // 
            nGAYCAPLabel.AutoSize = true;
            nGAYCAPLabel.Location = new System.Drawing.Point(24, 196);
            nGAYCAPLabel.Name = "nGAYCAPLabel";
            nGAYCAPLabel.Size = new System.Drawing.Size(88, 19);
            nGAYCAPLabel.TabIndex = 12;
            nGAYCAPLabel.Text = "NGAYCAP:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(195, 141);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(52, 19);
            pHAILabel.TabIndex = 10;
            pHAILabel.Text = "PHAI:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(397, 86);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(70, 19);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(22, 140);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(45, 19);
            tENLabel.TabIndex = 6;
            tENLabel.Text = "TEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(23, 86);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(38, 19);
            hOLabel.TabIndex = 4;
            hOLabel.Text = "HO:";
            // 
            // kHLabel
            // 
            kHLabel.AutoSize = true;
            kHLabel.Location = new System.Drawing.Point(24, 31);
            kHLabel.Name = "kHLabel";
            kHLabel.Size = new System.Drawing.Size(35, 19);
            kHLabel.TabIndex = 0;
            kHLabel.Text = "KH:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(398, 142);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(59, 19);
            mACNLabel.TabIndex = 16;
            mACNLabel.Text = "MACN:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(397, 31);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(59, 19);
            cMNDLabel.TabIndex = 17;
            cMNDLabel.Text = "CMND:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 45);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(1645, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 785);
            this.barDockControlBottom.Manager = null;
            this.barDockControlBottom.Size = new System.Drawing.Size(1645, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = null;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 740);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1645, 45);
            this.barDockControlRight.Manager = null;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 740);
            // 
            // bmgCRUD
            // 
            this.bmgCRUD.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barTool});
            this.bmgCRUD.DockControls.Add(this.barDockControl1);
            this.bmgCRUD.DockControls.Add(this.barDockControl2);
            this.bmgCRUD.DockControls.Add(this.barDockControl3);
            this.bmgCRUD.DockControls.Add(this.barDockControl4);
            this.bmgCRUD.Form = this;
            this.bmgCRUD.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDel,
            this.btnEdit,
            this.btnWri,
            this.btnUndo,
            this.btnCancel,
            this.btnExit});
            this.bmgCRUD.MainMenu = this.barTool;
            this.bmgCRUD.MaxItemId = 8;
            // 
            // barTool
            // 
            this.barTool.BarName = "Main menu";
            this.barTool.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barTool.DockCol = 0;
            this.barTool.DockRow = 0;
            this.barTool.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barTool.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnWri, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCancel, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barTool.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barTool.OptionsBar.MultiLine = true;
            this.barTool.OptionsBar.UseWholeRow = true;
            this.barTool.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_add_5;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnDel.Caption = "Xóa";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDel.ImageOptions.SvgImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDel_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnWri
            // 
            this.btnWri.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnWri.Caption = "Ghi";
            this.btnWri.Enabled = false;
            this.btnWri.Id = 3;
            this.btnWri.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWri.ImageOptions.SvgImage")));
            this.btnWri.Name = "btnWri";
            this.btnWri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnWri_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 4;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnCancel.Caption = "Hủy Bỏ";
            this.btnCancel.Enabled = false;
            this.btnCancel.Id = 5;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.btnExit.Caption = "Thoát";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.bmgCRUD;
            this.barDockControl1.Size = new System.Drawing.Size(1645, 45);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 785);
            this.barDockControl2.Manager = this.bmgCRUD;
            this.barDockControl2.Size = new System.Drawing.Size(1645, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 45);
            this.barDockControl3.Manager = this.bmgCRUD;
            this.barDockControl3.Size = new System.Drawing.Size(0, 740);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1645, 45);
            this.barDockControl4.Manager = this.bmgCRUD;
            this.barDockControl4.Size = new System.Drawing.Size(0, 740);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // tbaKH
            // 
            this.tbaKH.ClearBeforeFill = true;
            // 
            // tbmKH
            // 
            this.tbmKH.BackupDataSetBeforeUpdate = false;
            this.tbmKH.GD_CHUYENTIENTableAdapter = null;
            this.tbmKH.GD_GOIRUTTableAdapter = null;
            this.tbmKH.KhachHangTableAdapter = this.tbaKH;
            this.tbmKH.NhanVienTableAdapter = null;
            this.tbmKH.TaiKhoanTableAdapter = null;
            this.tbmKH.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsTTKH
            // 
            this.bdsTTKH.DataMember = "TTKH";
            this.bdsTTKH.DataSource = this.DS;
            // 
            // tbaTTKH
            // 
            this.tbaTTKH.ClearBeforeFill = true;
            // 
            // pncChiNhanh
            // 
            this.pncChiNhanh.Controls.Add(this.label1);
            this.pncChiNhanh.Controls.Add(this.cmbChiNhanh);
            this.pncChiNhanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncChiNhanh.Location = new System.Drawing.Point(0, 45);
            this.pncChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pncChiNhanh.Name = "pncChiNhanh";
            this.pncChiNhanh.Size = new System.Drawing.Size(1645, 50);
            this.pncChiNhanh.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh: ";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(340, 11);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(373, 27);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // gcKH
            // 
            this.gcKH.DataMember = null;
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcKH.Location = new System.Drawing.Point(0, 95);
            this.gcKH.MainView = this.gvKH;
            this.gcKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1645, 350);
            this.gcKH.TabIndex = 21;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvKH});
            // 
            // gvKH
            // 
            this.gvKH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colNGAYCAP,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN});
            this.gvKH.DetailHeight = 285;
            this.gvKH.GridControl = this.gcKH;
            this.gvKH.Name = "gvKH";
            this.gvKH.OptionsBehavior.Editable = false;
            this.gvKH.OptionsCustomization.AllowColumnMoving = false;
            this.gvKH.OptionsView.RowAutoHeight = true;
            this.gvKH.OptionsView.ShowDetailButtons = false;
            this.gvKH.OptionsView.ShowGroupPanel = false;
            this.gvKH.OptionsView.ShowIndicator = false;
            this.gvKH.OptionsView.ShowViewCaption = true;
            this.gvKH.ViewCaption = "DANH SÁCH KHÁCH HÀNG";
            // 
            // colCMND
            // 
            this.colCMND.Caption = "Chứng Minh Nhân Dân";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 30;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 187;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày Cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 30;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 243;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 210;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 189;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa Chỉ Liên Hệ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 30;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 405;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Phái";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 30;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 168;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số ĐT Liên Lạc";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 30;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 241;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã CHi Nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 265;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAdd,
            this.tsmiDel,
            this.tsmiCancel,
            this.tsmiSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(221, 132);
            // 
            // tsmiAdd
            // 
            this.tsmiAdd.Image = global::NGANHANG_.Properties.Resources.add;
            this.tsmiAdd.Name = "tsmiAdd";
            this.tsmiAdd.Size = new System.Drawing.Size(220, 32);
            this.tsmiAdd.Text = "Thêm Tài Khoản";
            this.tsmiAdd.Click += new System.EventHandler(this.tsmiAdd_Click);
            // 
            // tsmiDel
            // 
            this.tsmiDel.Image = global::NGANHANG_.Properties.Resources.remove;
            this.tsmiDel.Name = "tsmiDel";
            this.tsmiDel.Size = new System.Drawing.Size(220, 32);
            this.tsmiDel.Text = "Xóa Tài Khoản";
            this.tsmiDel.Click += new System.EventHandler(this.tsmiDel_Click);
            // 
            // tsmiCancel
            // 
            this.tsmiCancel.Enabled = false;
            this.tsmiCancel.Image = global::NGANHANG_.Properties.Resources.cancel_;
            this.tsmiCancel.Name = "tsmiCancel";
            this.tsmiCancel.Size = new System.Drawing.Size(220, 32);
            this.tsmiCancel.Text = "Hủy Thao Tác";
            this.tsmiCancel.Click += new System.EventHandler(this.tsmiCancel_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Enabled = false;
            this.tsmiSave.Image = global::NGANHANG_.Properties.Resources.save;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(220, 32);
            this.tsmiSave.Text = "Lưu Thay Đổi";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // pcKH
            // 
            this.pcKH.Controls.Add(cMNDLabel);
            this.pcKH.Controls.Add(this.txtCMND);
            this.pcKH.Controls.Add(mACNLabel);
            this.pcKH.Controls.Add(this.txtMCN);
            this.pcKH.Controls.Add(sODTLabel);
            this.pcKH.Controls.Add(this.txeSDT);
            this.pcKH.Controls.Add(nGAYCAPLabel);
            this.pcKH.Controls.Add(this.dtpNgayCap);
            this.pcKH.Controls.Add(pHAILabel);
            this.pcKH.Controls.Add(this.cmbPhai);
            this.pcKH.Controls.Add(dIACHILabel);
            this.pcKH.Controls.Add(this.txtPlace);
            this.pcKH.Controls.Add(tENLabel);
            this.pcKH.Controls.Add(this.txtTen);
            this.pcKH.Controls.Add(hOLabel);
            this.pcKH.Controls.Add(this.txtHo);
            this.pcKH.Controls.Add(kHLabel);
            this.pcKH.Controls.Add(this.cmbTTKH);
            this.pcKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcKH.Location = new System.Drawing.Point(0, 445);
            this.pcKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcKH.Name = "pcKH";
            this.pcKH.Size = new System.Drawing.Size(850, 340);
            this.pcKH.TabIndex = 22;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(470, 29);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(159, 27);
            this.txtCMND.TabIndex = 18;
            this.txtCMND.TextChanged += new System.EventHandler(this.txtCMND_TextChanged);
            // 
            // txtMCN
            // 
            this.txtMCN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txtMCN.Location = new System.Drawing.Point(471, 139);
            this.txtMCN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMCN.Name = "txtMCN";
            this.txtMCN.ReadOnly = true;
            this.txtMCN.Size = new System.Drawing.Size(123, 27);
            this.txtMCN.TabIndex = 17;
            // 
            // txeSDT
            // 
            this.txeSDT.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "SODT", true));
            this.txeSDT.Location = new System.Drawing.Point(472, 194);
            this.txeSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txeSDT.Name = "txeSDT";
            this.txeSDT.Size = new System.Drawing.Size(127, 26);
            this.txeSDT.TabIndex = 15;
            // 
            // dtpNgayCap
            // 
            this.dtpNgayCap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayCap.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsKH, "NGAYCAP", true));
            this.dtpNgayCap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCap.Location = new System.Drawing.Point(133, 193);
            this.dtpNgayCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayCap.Name = "dtpNgayCap";
            this.dtpNgayCap.Size = new System.Drawing.Size(183, 27);
            this.dtpNgayCap.TabIndex = 13;
            // 
            // cmbPhai
            // 
            this.cmbPhai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "PHAI", true));
            this.cmbPhai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhai.FormattingEnabled = true;
            this.cmbPhai.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbPhai.Location = new System.Drawing.Point(261, 139);
            this.cmbPhai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbPhai.Name = "cmbPhai";
            this.cmbPhai.Size = new System.Drawing.Size(89, 27);
            this.cmbPhai.TabIndex = 11;
            // 
            // txtPlace
            // 
            this.txtPlace.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "DIACHI", true));
            this.txtPlace.Location = new System.Drawing.Point(470, 84);
            this.txtPlace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(346, 27);
            this.txtPlace.TabIndex = 9;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.txtTen.Location = new System.Drawing.Point(77, 138);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(89, 27);
            this.txtTen.TabIndex = 7;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.txtHo.Location = new System.Drawing.Point(77, 84);
            this.txtHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(89, 27);
            this.txtHo.TabIndex = 5;
            // 
            // cmbTTKH
            // 
            this.cmbTTKH.DataSource = this.bdsTTKH;
            this.cmbTTKH.DisplayMember = "KH";
            this.cmbTTKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTTKH.Enabled = false;
            this.cmbTTKH.FormattingEnabled = true;
            this.cmbTTKH.Location = new System.Drawing.Point(77, 29);
            this.cmbTTKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTTKH.Name = "cmbTTKH";
            this.cmbTTKH.Size = new System.Drawing.Size(183, 27);
            this.cmbTTKH.TabIndex = 1;
            this.cmbTTKH.ValueMember = "CMND";
            this.cmbTTKH.SelectedIndexChanged += new System.EventHandler(this.cbmTTKH_SelectedIndexChanged);
            // 
            // bdsTK_KH
            // 
            this.bdsTK_KH.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK_KH.DataSource = this.bdsKH;
            // 
            // tbaTK_KH
            // 
            this.tbaTK_KH.ClearBeforeFill = true;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "NhanVien";
            this.bdsNV.DataSource = this.DS;
            // 
            // tbaNV
            // 
            this.tbaNV.ClearBeforeFill = true;
            // 
            // pncAler
            // 
            this.pncAler.Controls.Add(this.txtInfo_);
            this.pncAler.Controls.Add(this.ptbType);
            this.pncAler.Controls.Add(this.ptbClose);
            this.pncAler.Location = new System.Drawing.Point(341, 301);
            this.pncAler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pncAler.Name = "pncAler";
            this.pncAler.Size = new System.Drawing.Size(292, 39);
            this.pncAler.TabIndex = 40;
            this.pncAler.Visible = false;
            // 
            // txtInfo_
            // 
            this.txtInfo_.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInfo_.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo_.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtInfo_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInfo_.Enabled = false;
            this.txtInfo_.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.txtInfo_.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtInfo_.Location = new System.Drawing.Point(87, 2);
            this.txtInfo_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInfo_.Multiline = true;
            this.txtInfo_.Name = "txtInfo_";
            this.txtInfo_.ReadOnly = true;
            this.txtInfo_.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo_.Size = new System.Drawing.Size(173, 35);
            this.txtInfo_.TabIndex = 13;
            // 
            // ptbType
            // 
            this.ptbType.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbType.Location = new System.Drawing.Point(2, 2);
            this.ptbType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbType.Name = "ptbType";
            this.ptbType.Size = new System.Drawing.Size(85, 35);
            this.ptbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbType.TabIndex = 12;
            this.ptbType.TabStop = false;
            // 
            // ptbClose
            // 
            this.ptbClose.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ptbClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbClose.Image = global::NGANHANG_.Properties.Resources.close;
            this.ptbClose.Location = new System.Drawing.Point(260, 2);
            this.ptbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(30, 35);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // Time
            // 
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // gcTK_KH
            // 
            this.gcTK_KH.ContextMenuStrip = this.contextMenuStrip1;
            this.gcTK_KH.DataMember = "FK_TaiKhoan_KhachHang";
            this.gcTK_KH.DataSource = this.bdsKH;
            this.gcTK_KH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTK_KH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcTK_KH.Location = new System.Drawing.Point(850, 445);
            this.gcTK_KH.MainView = this.gvTK_KH;
            this.gcTK_KH.Name = "gcTK_KH";
            this.gcTK_KH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpstMACN});
            this.gcTK_KH.Size = new System.Drawing.Size(795, 340);
            this.gcTK_KH.TabIndex = 49;
            this.gcTK_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTK_KH});
            // 
            // gvTK_KH
            // 
            this.gvTK_KH.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvTK_KH.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gvTK_KH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colSODU,
            this.colNGAYMOTK,
            this.colCMND1,
            this.colMACN1});
            this.gvTK_KH.GridControl = this.gcTK_KH;
            this.gvTK_KH.Name = "gvTK_KH";
            this.gvTK_KH.OptionsCustomization.AllowColumnMoving = false;
            this.gvTK_KH.OptionsCustomization.AllowColumnResizing = false;
            this.gvTK_KH.OptionsView.ShowDetailButtons = false;
            this.gvTK_KH.OptionsView.ShowGroupPanel = false;
            this.gvTK_KH.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvTK_KH.OptionsView.ShowIndicator = false;
            this.gvTK_KH.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvTK_KH.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvTK_KH.OptionsView.ShowViewCaption = true;
            this.gvTK_KH.ViewCaption = "TÀI KHOẢN KHÁCH HÀNG";
            this.gvTK_KH.ShownEditor += new System.EventHandler(this.gvTK_KH_ShownEditor);
            this.gvTK_KH.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvTK_KH_CellValueChanged);
            this.gvTK_KH.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvTK_KH_ValidatingEditor);
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số Tài Khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 30;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 112;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "Số Dư Tài Khoản";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 30;
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowShowHide = false;
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            this.colSODU.Width = 112;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày Mở Tài Khoản";
            this.colNGAYMOTK.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYMOTK.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 30;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            this.colNGAYMOTK.Width = 112;
            // 
            // colCMND1
            // 
            this.colCMND1.Caption = "Chứng Minh Nhân Dân";
            this.colCMND1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 30;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.OptionsColumn.AllowEdit = false;
            this.colCMND1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.colCMND1.OptionsColumn.AllowShowHide = false;
            this.colCMND1.OptionsColumn.ReadOnly = true;
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            this.colCMND1.Width = 112;
            // 
            // colMACN1
            // 
            this.colMACN1.Caption = "Mã Chi Nhánh";
            this.colMACN1.ColumnEdit = this.rpstMACN;
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 30;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.OptionsColumn.AllowShowHide = false;
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            this.colMACN1.Width = 112;
            // 
            // rpstMACN
            // 
            this.rpstMACN.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.rpstMACN.AutoHeight = false;
            this.rpstMACN.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rpstMACN.Items.AddRange(new object[] {
            "BENTHANH",
            "TANDINH"});
            this.rpstMACN.Name = "rpstMACN";
            this.rpstMACN.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // bdsGRTK
            // 
            this.bdsGRTK.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bdsGRTK.DataSource = this.bdsTK_KH;
            // 
            // tbaGRTK
            // 
            this.tbaGRTK.ClearBeforeFill = true;
            // 
            // bdsCTTKC
            // 
            this.bdsCTTKC.DataMember = "FK_GD_CHUYENTIEN_TK_CHUYEN";
            this.bdsCTTKC.DataSource = this.bdsTK_KH;
            // 
            // tbaCT
            // 
            this.tbaCT.ClearBeforeFill = true;
            // 
            // bdsCTTKN
            // 
            this.bdsCTTKN.DataMember = "FK_GD_CHUYENTIEN_TK_NHAN";
            this.bdsCTTKN.DataSource = this.bdsTK_KH;
            // 
            // frmUser
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1645, 785);
            this.Controls.Add(this.gcTK_KH);
            this.Controls.Add(this.pncAler);
            this.Controls.Add(this.pcKH);
            this.Controls.Add(this.gcKH);
            this.Controls.Add(this.pncChiNhanh);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_users_1;
            this.Name = "frmUser";
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frCreateAccountUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bmgCRUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTTKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncChiNhanh)).EndInit();
            this.pncChiNhanh.ResumeLayout(false);
            this.pncChiNhanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvKH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcKH)).EndInit();
            this.pcKH.ResumeLayout(false);
            this.pcKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncAler)).EndInit();
            this.pncAler.ResumeLayout(false);
            this.pncAler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstMACN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGRTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTTKC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTTKN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager bmgCRUD;
        private DevExpress.XtraBars.Bar barTool;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnWri;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS DS;
        private DSTableAdapters.KhachHangTableAdapter tbaKH;
        private DSTableAdapters.TableAdapterManager tbmKH;
        private System.Windows.Forms.BindingSource bdsTTKH;
        private DSTableAdapters.TTKHTableAdapter tbaTTKH;
        private DevExpress.XtraEditors.PanelControl pncChiNhanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvKH;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.PanelControl pcKH;
        private DevExpress.XtraEditors.TextEdit txeSDT;
        private System.Windows.Forms.DateTimePicker dtpNgayCap;
        private System.Windows.Forms.ComboBox cmbPhai;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.ComboBox cmbTTKH;
        private System.Windows.Forms.TextBox txtMCN;
        private System.Windows.Forms.BindingSource bdsTK_KH;
        private DSTableAdapters.TaiKhoanTableAdapter tbaTK_KH;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NhanVienTableAdapter tbaNV;
        private DevExpress.XtraEditors.PanelControl pncAler;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.TextBox txtInfo_;
        private System.Windows.Forms.PictureBox ptbType;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiAdd;
        private System.Windows.Forms.ToolStripMenuItem tsmiDel;
        private DevExpress.XtraGrid.GridControl gcTK_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTK_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpstMACN;
        private System.Windows.Forms.ToolStripMenuItem tsmiCancel;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.BindingSource bdsGRTK;
        private DSTableAdapters.GD_GOIRUTTableAdapter tbaGRTK;
        private System.Windows.Forms.BindingSource bdsCTTKC;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter tbaCT;
        private System.Windows.Forms.BindingSource bdsCTTKN;
    }
}