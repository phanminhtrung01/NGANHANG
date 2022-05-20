
namespace NGANHANG_
{
    partial class frCreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frCreateAccount));
            this.txtDRole = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDExit = new System.Windows.Forms.Button();
            this.btnDCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDUser = new System.Windows.Forms.TextBox();
            this.txtDPass = new System.Windows.Forms.TextBox();
            this.txtDLogin = new System.Windows.Forms.TextBox();
            this.grcDelete = new DevExpress.XtraEditors.GroupControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.grcCreate = new DevExpress.XtraEditors.GroupControl();
            this.txtCRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCExit = new System.Windows.Forms.Button();
            this.btnCCreate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCUser = new System.Windows.Forms.TextBox();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.txtCLogin = new System.Windows.Forms.TextBox();
            this.txtELogin = new System.Windows.Forms.TextBox();
            this.txtEPassOld = new System.Windows.Forms.TextBox();
            this.txtEUser = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnECreate = new System.Windows.Forms.Button();
            this.btnEExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtERole = new System.Windows.Forms.TextBox();
            this.txtEPass = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.grcEdit = new DevExpress.XtraEditors.GroupControl();
            this.DS = new NGANHANG_.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.tbaNV = new NGANHANG_.DSTableAdapters.NhanVienTableAdapter();
            this.tbmNV = new NGANHANG_.DSTableAdapters.TableAdapterManager();
            this.gcNV = new DevExpress.XtraGrid.GridControl();
            this.gvNV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDel = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.grcDelete)).BeginInit();
            this.grcDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCreate)).BeginInit();
            this.grcCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcEdit)).BeginInit();
            this.grcEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDRole
            // 
            this.txtDRole.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtDRole.Location = new System.Drawing.Point(240, 336);
            this.txtDRole.Name = "txtDRole";
            this.txtDRole.ReadOnly = true;
            this.txtDRole.Size = new System.Drawing.Size(186, 27);
            this.txtDRole.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Quyền";
            // 
            // btnDExit
            // 
            this.btnDExit.Location = new System.Drawing.Point(356, 472);
            this.btnDExit.Name = "btnDExit";
            this.btnDExit.Size = new System.Drawing.Size(133, 43);
            this.btnDExit.TabIndex = 10;
            this.btnDExit.Text = "Hủy";
            this.btnDExit.UseVisualStyleBackColor = true;
            this.btnDExit.Click += new System.EventHandler(this.btnDExit_Click);
            // 
            // btnDCreate
            // 
            this.btnDCreate.Location = new System.Drawing.Point(112, 472);
            this.btnDCreate.Name = "btnDCreate";
            this.btnDCreate.Size = new System.Drawing.Size(133, 43);
            this.btnDCreate.TabIndex = 9;
            this.btnDCreate.Text = "Xác Nhận";
            this.btnDCreate.UseVisualStyleBackColor = true;
            this.btnDCreate.Click += new System.EventHandler(this.btnDCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Người dùng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mật Khẩu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 19);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tài Khoản";
            // 
            // txtDUser
            // 
            this.txtDUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtDUser.Location = new System.Drawing.Point(240, 254);
            this.txtDUser.Name = "txtDUser";
            this.txtDUser.ReadOnly = true;
            this.txtDUser.Size = new System.Drawing.Size(186, 27);
            this.txtDUser.TabIndex = 3;
            // 
            // txtDPass
            // 
            this.txtDPass.Location = new System.Drawing.Point(240, 177);
            this.txtDPass.Name = "txtDPass";
            this.txtDPass.Size = new System.Drawing.Size(186, 27);
            this.txtDPass.TabIndex = 2;
            this.txtDPass.UseSystemPasswordChar = true;
            // 
            // txtDLogin
            // 
            this.txtDLogin.Location = new System.Drawing.Point(240, 96);
            this.txtDLogin.Name = "txtDLogin";
            this.txtDLogin.Size = new System.Drawing.Size(186, 27);
            this.txtDLogin.TabIndex = 1;
            // 
            // grcDelete
            // 
            this.grcDelete.Controls.Add(this.txtDRole);
            this.grcDelete.Controls.Add(this.label5);
            this.grcDelete.Controls.Add(this.btnDExit);
            this.grcDelete.Controls.Add(this.btnDCreate);
            this.grcDelete.Controls.Add(this.label6);
            this.grcDelete.Controls.Add(this.label7);
            this.grcDelete.Controls.Add(this.label8);
            this.grcDelete.Controls.Add(this.txtDUser);
            this.grcDelete.Controls.Add(this.txtDPass);
            this.grcDelete.Controls.Add(this.txtDLogin);
            this.grcDelete.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcDelete.Location = new System.Drawing.Point(808, 34);
            this.grcDelete.Name = "grcDelete";
            this.grcDelete.Size = new System.Drawing.Size(558, 593);
            this.grcDelete.TabIndex = 6;
            this.grcDelete.Text = "XÓA TÀI KHOẢN ĐĂNG NHẬP";
            this.grcDelete.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // grcCreate
            // 
            this.grcCreate.Controls.Add(this.txtCRole);
            this.grcCreate.Controls.Add(this.label1);
            this.grcCreate.Controls.Add(this.btnCExit);
            this.grcCreate.Controls.Add(this.btnCCreate);
            this.grcCreate.Controls.Add(this.label4);
            this.grcCreate.Controls.Add(this.label3);
            this.grcCreate.Controls.Add(this.label2);
            this.grcCreate.Controls.Add(this.txtCUser);
            this.grcCreate.Controls.Add(this.txtCPass);
            this.grcCreate.Controls.Add(this.txtCLogin);
            this.grcCreate.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcCreate.Location = new System.Drawing.Point(1366, 34);
            this.grcCreate.Name = "grcCreate";
            this.grcCreate.Size = new System.Drawing.Size(558, 593);
            this.grcCreate.TabIndex = 7;
            this.grcCreate.Text = "TẠO TÀI KHOẢN ĐĂNG NHẬP";
            // 
            // txtCRole
            // 
            this.txtCRole.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCRole.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCRole.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCRole.Location = new System.Drawing.Point(240, 336);
            this.txtCRole.Name = "txtCRole";
            this.txtCRole.ReadOnly = true;
            this.txtCRole.Size = new System.Drawing.Size(186, 27);
            this.txtCRole.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quyền";
            // 
            // btnCExit
            // 
            this.btnCExit.Location = new System.Drawing.Point(356, 472);
            this.btnCExit.Name = "btnCExit";
            this.btnCExit.Size = new System.Drawing.Size(133, 43);
            this.btnCExit.TabIndex = 10;
            this.btnCExit.Text = "Thoát";
            this.btnCExit.UseVisualStyleBackColor = true;
            this.btnCExit.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCCreate
            // 
            this.btnCCreate.Location = new System.Drawing.Point(112, 472);
            this.btnCCreate.Name = "btnCCreate";
            this.btnCCreate.Size = new System.Drawing.Size(133, 43);
            this.btnCCreate.TabIndex = 9;
            this.btnCCreate.Text = "Tạo ";
            this.btnCCreate.UseVisualStyleBackColor = true;
            this.btnCCreate.Click += new System.EventHandler(this.btnCCreate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Người dùng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tài Khoản";
            // 
            // txtCUser
            // 
            this.txtCUser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtCUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCUser.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCUser.Location = new System.Drawing.Point(240, 254);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.ReadOnly = true;
            this.txtCUser.Size = new System.Drawing.Size(186, 27);
            this.txtCUser.TabIndex = 3;
            // 
            // txtCPass
            // 
            this.txtCPass.Location = new System.Drawing.Point(240, 177);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.Size = new System.Drawing.Size(186, 27);
            this.txtCPass.TabIndex = 2;
            this.txtCPass.UseSystemPasswordChar = true;
            // 
            // txtCLogin
            // 
            this.txtCLogin.Location = new System.Drawing.Point(240, 96);
            this.txtCLogin.Name = "txtCLogin";
            this.txtCLogin.Size = new System.Drawing.Size(186, 27);
            this.txtCLogin.TabIndex = 1;
            // 
            // txtELogin
            // 
            this.txtELogin.BackColor = System.Drawing.SystemColors.Window;
            this.txtELogin.Location = new System.Drawing.Point(243, 94);
            this.txtELogin.Name = "txtELogin";
            this.txtELogin.Size = new System.Drawing.Size(186, 27);
            this.txtELogin.TabIndex = 1;
            // 
            // txtEPassOld
            // 
            this.txtEPassOld.Location = new System.Drawing.Point(243, 162);
            this.txtEPassOld.Name = "txtEPassOld";
            this.txtEPassOld.Size = new System.Drawing.Size(186, 27);
            this.txtEPassOld.TabIndex = 2;
            // 
            // txtEUser
            // 
            this.txtEUser.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEUser.Location = new System.Drawing.Point(243, 316);
            this.txtEUser.Name = "txtEUser";
            this.txtEUser.ReadOnly = true;
            this.txtEUser.Size = new System.Drawing.Size(186, 27);
            this.txtEUser.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(106, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 5;
            this.label12.Text = "Tài Khoản";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mật Khẩu Cũ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(106, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "Người dùng";
            // 
            // btnECreate
            // 
            this.btnECreate.Location = new System.Drawing.Point(103, 502);
            this.btnECreate.Name = "btnECreate";
            this.btnECreate.Size = new System.Drawing.Size(133, 43);
            this.btnECreate.TabIndex = 9;
            this.btnECreate.Text = "Xác Nhận";
            this.btnECreate.UseVisualStyleBackColor = true;
            this.btnECreate.Click += new System.EventHandler(this.btnECreate_Click);
            // 
            // btnEExit
            // 
            this.btnEExit.Location = new System.Drawing.Point(347, 502);
            this.btnEExit.Name = "btnEExit";
            this.btnEExit.Size = new System.Drawing.Size(133, 43);
            this.btnEExit.TabIndex = 10;
            this.btnEExit.Text = "Hủy";
            this.btnEExit.UseVisualStyleBackColor = true;
            this.btnEExit.Click += new System.EventHandler(this.btnEExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 11;
            this.label9.Text = "Quyền";
            // 
            // txtERole
            // 
            this.txtERole.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtERole.Location = new System.Drawing.Point(243, 400);
            this.txtERole.Name = "txtERole";
            this.txtERole.ReadOnly = true;
            this.txtERole.Size = new System.Drawing.Size(186, 27);
            this.txtERole.TabIndex = 12;
            // 
            // txtEPass
            // 
            this.txtEPass.Location = new System.Drawing.Point(243, 234);
            this.txtEPass.Name = "txtEPass";
            this.txtEPass.Size = new System.Drawing.Size(186, 27);
            this.txtEPass.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(106, 237);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Mật Khẩu";
            // 
            // grcEdit
            // 
            this.grcEdit.Controls.Add(this.label13);
            this.grcEdit.Controls.Add(this.txtEPass);
            this.grcEdit.Controls.Add(this.txtERole);
            this.grcEdit.Controls.Add(this.label9);
            this.grcEdit.Controls.Add(this.btnEExit);
            this.grcEdit.Controls.Add(this.btnECreate);
            this.grcEdit.Controls.Add(this.label10);
            this.grcEdit.Controls.Add(this.label11);
            this.grcEdit.Controls.Add(this.label12);
            this.grcEdit.Controls.Add(this.txtEUser);
            this.grcEdit.Controls.Add(this.txtEPassOld);
            this.grcEdit.Controls.Add(this.txtELogin);
            this.grcEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.grcEdit.Location = new System.Drawing.Point(250, 34);
            this.grcEdit.Name = "grcEdit";
            this.grcEdit.Size = new System.Drawing.Size(558, 593);
            this.grcEdit.TabIndex = 5;
            this.grcEdit.Text = "SỬA TÀI KHOẢN ĐĂNG NHẬP";
            this.grcEdit.Visible = false;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tbmNV
            // 
            this.tbmNV.BackupDataSetBeforeUpdate = false;
            this.tbmNV.GD_CHUYENTIENTableAdapter = null;
            this.tbmNV.GD_GOIRUTTableAdapter = null;
            this.tbmNV.KhachHangTableAdapter = null;
            this.tbmNV.NhanVienTableAdapter = this.tbaNV;
            this.tbmNV.TaiKhoanTableAdapter = null;
            this.tbmNV.UpdateOrder = NGANHANG_.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcNV
            // 
            this.gcNV.DataSource = this.bdsNV;
            this.gcNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcNV.Location = new System.Drawing.Point(0, 34);
            this.gcNV.MainView = this.gvNV;
            this.gcNV.Name = "gcNV";
            this.gcNV.Size = new System.Drawing.Size(250, 593);
            this.gcNV.TabIndex = 11;
            this.gcNV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNV});
            this.gcNV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nhanVienGridControl_MouseClick);
            // 
            // gvNV
            // 
            this.gvNV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colMACN});
            this.gvNV.GridControl = this.gcNV;
            this.gvNV.Name = "gvNV";
            this.gvNV.OptionsBehavior.Editable = false;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 30;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 112;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 30;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 112;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 30;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 112;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 30;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 112;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnDel
            // 
            this.btnDel.Caption = "Xóa";
            this.btnDel.Id = 1;
            this.btnDel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDel.ImageOptions.LargeImage")));
            this.btnDel.Name = "btnDel";
            this.btnDel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar4;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem2, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem4, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thêm";
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Xóa";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Sửa";
            this.barButtonItem4.Id = 2;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // bar4
            // 
            this.bar4.BarName = "Status bar";
            this.bar4.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar4.OptionsBar.AllowQuickCustomization = false;
            this.bar4.OptionsBar.DrawDragBorder = false;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1924, 34);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 627);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1924, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 34);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 593);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1924, 34);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 593);
            // 
            // frCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1924, 647);
            this.Controls.Add(this.gcNV);
            this.Controls.Add(this.grcEdit);
            this.Controls.Add(this.grcDelete);
            this.Controls.Add(this.grcCreate);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frCreateAccount";
            this.Text = "Tạo Tài Khoản";
            this.Load += new System.EventHandler(this.frCreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grcDelete)).EndInit();
            this.grcDelete.ResumeLayout(false);
            this.grcDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCreate)).EndInit();
            this.grcCreate.ResumeLayout(false);
            this.grcCreate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcEdit)).EndInit();
            this.grcEdit.ResumeLayout(false);
            this.grcEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDExit;
        private System.Windows.Forms.Button btnDCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDUser;
        private System.Windows.Forms.TextBox txtDPass;
        private System.Windows.Forms.TextBox txtDLogin;
        private DevExpress.XtraEditors.GroupControl grcDelete;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.GroupControl grcCreate;
        private System.Windows.Forms.TextBox txtCRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCExit;
        private System.Windows.Forms.Button btnCCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCUser;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.TextBox txtCLogin;
        private DevExpress.XtraEditors.GroupControl grcEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEPass;
        private System.Windows.Forms.TextBox txtERole;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEExit;
        private System.Windows.Forms.Button btnECreate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEUser;
        private System.Windows.Forms.TextBox txtEPassOld;
        private System.Windows.Forms.TextBox txtELogin;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.NhanVienTableAdapter tbaNV;
        private DSTableAdapters.TableAdapterManager tbmNV;
        private DevExpress.XtraGrid.GridControl gcNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDel;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}