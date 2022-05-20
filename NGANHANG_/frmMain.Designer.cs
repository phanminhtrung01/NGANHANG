
namespace NGANHANG_
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.txtHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.pageDanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgNhanVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnNV = new DevExpress.XtraBars.BarButtonItem();
            this.pgKhachhang = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnKH = new DevExpress.XtraBars.BarButtonItem();
            this.pageNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgGuiRut = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGui = new DevExpress.XtraBars.BarButtonItem();
            this.btnRut = new DevExpress.XtraBars.BarButtonItem();
            this.pgChuyenTien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnCLCN = new DevExpress.XtraBars.BarButtonItem();
            this.btnCT = new DevExpress.XtraBars.BarButtonItem();
            this.pageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.pgBCNV = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnKXNV = new DevExpress.XtraBars.BarButtonItem();
            this.pgBCKH = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnSK = new DevExpress.XtraBars.BarButtonItem();
            this.btnKHKH = new DevExpress.XtraBars.BarButtonItem();
            this.pgHTTK = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAcount = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtMANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.pageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barWorkspaceMenuItem1 = new DevExpress.XtraBars.BarWorkspaceMenuItem();
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHoTen
            // 
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(76, 25);
            this.txtHoTen.Text = "Họ Tên: ";
            // 
            // pageDanhMuc
            // 
            this.pageDanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgNhanVien,
            this.pgKhachhang});
            this.pageDanhMuc.Name = "pageDanhMuc";
            this.pageDanhMuc.Text = "Danh Mục";
            // 
            // pgNhanVien
            // 
            this.pgNhanVien.ItemLinks.Add(this.btnNV);
            this.pgNhanVien.Name = "pgNhanVien";
            this.pgNhanVien.Text = "Nhân Viên";
            // 
            // btnNV
            // 
            this.btnNV.Caption = "Nhân Viên            ";
            this.btnNV.Id = 4;
            this.btnNV.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_management;
            this.btnNV.Name = "btnNV";
            this.btnNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // pgKhachhang
            // 
            this.pgKhachhang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("pgKhachhang.ImageOptions.Image")));
            this.pgKhachhang.ItemLinks.Add(this.btnKH);
            this.pgKhachhang.Name = "pgKhachhang";
            this.pgKhachhang.Text = "Khách Hàng";
            // 
            // btnKH
            // 
            this.btnKH.Caption = "Khách Hàng            ";
            this.btnKH.Id = 5;
            this.btnKH.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_users_1;
            this.btnKH.Name = "btnKH";
            this.btnKH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKH_ItemClick);
            // 
            // pageNghiepVu
            // 
            this.pageNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgGuiRut,
            this.pgChuyenTien});
            this.pageNghiepVu.Name = "pageNghiepVu";
            this.pageNghiepVu.Text = "Nghiệp Vụ";
            this.pageNghiepVu.Visible = false;
            // 
            // pgGuiRut
            // 
            this.pgGuiRut.ItemLinks.Add(this.btnGui);
            this.pgGuiRut.ItemLinks.Add(this.btnRut);
            this.pgGuiRut.Name = "pgGuiRut";
            this.pgGuiRut.Text = "Gửi, Rút Tiền";
            // 
            // btnGui
            // 
            this.btnGui.Caption = "Gửi Tiền";
            this.btnGui.Id = 6;
            this.btnGui.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_request_money;
            this.btnGui.Name = "btnGui";
            // 
            // btnRut
            // 
            this.btnRut.Caption = "Rút Tiền";
            this.btnRut.Id = 8;
            this.btnRut.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_initiate_money_transfer;
            this.btnRut.Name = "btnRut";
            // 
            // pgChuyenTien
            // 
            this.pgChuyenTien.ItemLinks.Add(this.btnCLCN);
            this.pgChuyenTien.Name = "pgChuyenTien";
            this.pgChuyenTien.Text = "Chuyển Tiền";
            // 
            // btnCLCN
            // 
            this.btnCLCN.Caption = "Chuyển Tiền";
            this.btnCLCN.Id = 7;
            this.btnCLCN.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_transfer;
            this.btnCLCN.Name = "btnCLCN";
            this.btnCLCN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCLCN_ItemClick);
            // 
            // btnCT
            // 
            this.btnCT.Caption = "Chuyển Thường";
            this.btnCT.Id = 9;
            this.btnCT.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_Transaction;
            this.btnCT.Name = "btnCT";
            this.btnCT.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // pageBaoCao
            // 
            this.pageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgBCNV,
            this.pgBCKH});
            this.pageBaoCao.Name = "pageBaoCao";
            this.pageBaoCao.Text = "Báo Cáo";
            this.pageBaoCao.Visible = false;
            // 
            // pgBCNV
            // 
            this.pgBCNV.ItemLinks.Add(this.btnKXNV);
            this.pgBCNV.Name = "pgBCNV";
            this.pgBCNV.Text = "Nhân Viên";
            // 
            // btnKXNV
            // 
            this.btnKXNV.Caption = "Kết Xuất";
            this.btnKXNV.Id = 11;
            this.btnKXNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKXNV.ImageOptions.SvgImage")));
            this.btnKXNV.Name = "btnKXNV";
            // 
            // pgBCKH
            // 
            this.pgBCKH.ItemLinks.Add(this.btnSK);
            this.pgBCKH.ItemLinks.Add(this.btnKHKH);
            this.pgBCKH.Name = "pgBCKH";
            this.pgBCKH.Text = "Khách Hàng";
            // 
            // btnSK
            // 
            this.btnSK.Caption = "Sao Kê";
            this.btnSK.Id = 12;
            this.btnSK.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_graph;
            this.btnSK.Name = "btnSK";
            this.btnSK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnKHKH
            // 
            this.btnKHKH.Caption = "Kết Xuất";
            this.btnKHKH.Id = 13;
            this.btnKHKH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKHKH.ImageOptions.SvgImage")));
            this.btnKHKH.Name = "btnKHKH";
            // 
            // pgHTTK
            // 
            this.pgHTTK.ItemLinks.Add(this.btnLogin);
            this.pgHTTK.ItemLinks.Add(this.btnCreateAcount);
            this.pgHTTK.ItemLinks.Add(this.btnLogout);
            this.pgHTTK.Name = "pgHTTK";
            this.pgHTTK.Text = "Tài Khoản";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Id = 1;
            this.btnLogin.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_login;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnCreateAcount
            // 
            this.btnCreateAcount.Caption = "Tạo Tài Khoản";
            this.btnCreateAcount.Enabled = false;
            this.btnCreateAcount.Id = 2;
            this.btnCreateAcount.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_add_user_group_man_man;
            this.btnCreateAcount.Name = "btnCreateAcount";
            this.btnCreateAcount.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnCreateAcount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAcount_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng Xuất";
            this.btnLogout.Enabled = false;
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_Logout;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtMANV,
            this.txtHoTen,
            this.txtNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 651);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1145, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtMANV
            // 
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Size = new System.Drawing.Size(75, 25);
            this.txtMANV.Text = "Mã NV: ";
            // 
            // txtNhom
            // 
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Size = new System.Drawing.Size(71, 25);
            this.txtNhom.Text = "Nhóm: ";
            // 
            // pageHeThong
            // 
            this.pageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.pgHTTK});
            this.pageHeThong.Name = "pageHeThong";
            this.pageHeThong.Text = "Hệ Thống";
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.ribbonControl2.SearchEditItem,
            this.btnLogin,
            this.btnCreateAcount,
            this.btnLogout,
            this.btnNV,
            this.btnKH,
            this.btnGui,
            this.btnCLCN,
            this.btnRut,
            this.btnCT,
            this.btnKXNV,
            this.btnSK,
            this.btnKHKH,
            this.barButtonItem14,
            this.barWorkspaceMenuItem1});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl2.MaxItemId = 25;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.OptionsMenuMinWidth = 495;
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageHeThong,
            this.pageDanhMuc,
            this.pageNghiepVu,
            this.pageBaoCao});
            this.ribbonControl2.Size = new System.Drawing.Size(1145, 231);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "barButtonItem14";
            this.barButtonItem14.Id = 15;
            this.barButtonItem14.Name = "barButtonItem14";
            // 
            // barWorkspaceMenuItem1
            // 
            this.barWorkspaceMenuItem1.Caption = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.Id = 16;
            this.barWorkspaceMenuItem1.Name = "barWorkspaceMenuItem1";
            this.barWorkspaceMenuItem1.WorkspaceManager = this.workspaceManager1;
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1145, 683);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = global::NGANHANG_.Properties.Resources.icons8_euro_bank_building;
            this.IconOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl2;
            this.Text = "Màn Hình Chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel txtHoTen;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageDanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgKhachhang;
        private DevExpress.XtraBars.BarButtonItem btnKH;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgGuiRut;
        private DevExpress.XtraBars.BarButtonItem btnGui;
        private DevExpress.XtraBars.BarButtonItem btnRut;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgChuyenTien;
        private DevExpress.XtraBars.BarButtonItem btnCLCN;
        private DevExpress.XtraBars.BarButtonItem btnCT;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgBCNV;
        private DevExpress.XtraBars.BarButtonItem btnKXNV;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgBCKH;
        private DevExpress.XtraBars.BarButtonItem btnSK;
        private DevExpress.XtraBars.BarButtonItem btnKHKH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup pgHTTK;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnCreateAcount;
        private DevExpress.XtraBars.BarButtonItem btnLogout;


        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtMANV;
        private System.Windows.Forms.ToolStripStatusLabel txtNhom;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.BarWorkspaceMenuItem barWorkspaceMenuItem1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
    }
}

