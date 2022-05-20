using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void HienThiMenu()
        {
            txtMANV.Text = "Mã NV: " + Program.username;
            txtHoTen.Text = "Họ tên nhân viên: " + Program.mHoten;
            txtNhom.Text = "Nhóm: " + Program.mGroup;
            btnLogout.Enabled = btnCreateAcount.Enabled = true;
            btnLogin.Enabled = false;
            // phân quyền
            pageDanhMuc.Visible = pageNghiepVu.Visible = pageBaoCao.Visible = true;
        }

        public void AnMenu()
        {
            txtMANV.Text = "Mã NV: ";
            txtHoTen.Text = "Họ tên nhân viên: ";
            txtNhom.Text = "Nhóm: ";
            btnLogout.Enabled = btnCreateAcount.Enabled = false;
            btnLogin.Enabled = true;
            pageDanhMuc.Visible = pageNghiepVu.Visible = pageBaoCao.Visible = false;

            foreach (Form f in this.MdiChildren)
                f.Close();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = Program.CheckExists(typeof(frmLogin));
            if (form != null) form.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCreateAcount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = Program.CheckExists(typeof(frmCreateAccount_));
            if (form != null) form.Activate();
            else
            {
                frmCreateAccount_ f = new frmCreateAccount_();
                f.MdiParent = this;
                f.Show();
                f.HideRows(f.listExistsLogin, false);
            }
        }

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AnMenu();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = Program.CheckExists(typeof(frmUser));
            if (form != null) form.Activate();
            else
            {
                frmUser f = new frmUser();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCLCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = Program.CheckExists(typeof(frmChuyenTien));
            if (form != null) form.Activate();
            else
            {
                frmChuyenTien f = new frmChuyenTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        /*private void frmMain_Load(object sender, System.EventArgs e)
        {
            Form form = Program.CheckExists(typeof(frmAler));
            if (form != null) form.Activate();
            else
            {
                frmAler f = new frmAler();
                f.MdiParent = this;
                f.Show();
            }
        }*/
    }
}
