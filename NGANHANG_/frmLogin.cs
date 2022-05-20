using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmLogin : Form
    {

        private SqlConnection conn_publisher = new SqlConnection();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frLogin_Load(object sender, EventArgs e)
        {
            Program.servername = Program.server_publisher;
            if (Program.KetNoiGoc() == 0) return;
            LayDSPM("select * from Get_Subscribes");
            cmbChiNhanh.SelectedIndex = 1; //bỏ đi thì gặp lỗi  khi đăng nhập lần đầu tiên vào chi nhánh 0
            cmbChiNhanh.SelectedIndex = 0;
            cbSavePass.Checked = true;
            txtUsername.Text = Properties.Settings.Default.username;
            txtPassword.Text = Properties.Settings.Default.password;

        }

        private void LayDSPM(String cmd)
        {
            DataTable dt = new DataTable();


            conn_publisher.ConnectionString = Program.connstr_publisher;
            if (conn_publisher.State == ConnectionState.Closed) conn_publisher.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_publisher);
            SqlDataReader reader;
            reader = Program.ExecSqlDataReader(cmd);
            da.Fill(dt);
            conn_publisher.Close();
            Program.bds_dspm.DataSource = dt;
            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";

        }

        private bool ExistsLogin()
        {

            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            //Program.conn.ConnectionString = Program.connstr_publisher;
            if (Program.KetNoiGoc() == 0) return false;

            String strLenh = @"SELECT NAME FROM master.sys.sql_logins";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            while (Program.myReader.Read())
            {
                if (Program.myReader.GetString(0).Equals(Program.mlogin))
                {
                    return true;
                }
            }

            return false;

        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = cmbChiNhanh.SelectedValue.ToString();
            }
            catch { }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không được bỏ trống", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = txtUsername.Text.Trim().ToUpper();
            Program.password = txtPassword.Text.Trim();

            if (Program.KetNoi(false, true) == 0)
            {

                if (ExistsLogin())
                {
                    MessageBox.Show("Mật khẩu sai. Vui lòng nhập lại !", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    MessageBox.Show("Tài khoản khoản không tồn tại !", "", MessageBoxButtons.OK);
                    return;
                }
            }
            else if (Program.KetNoi(false, true) == 1)
            {
                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                String strLenh = "SP_Lay_Thong_Tin_NV_Tu_Login '" + Program.mlogin + "'";

                Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                Program.username = Program.myReader.GetString(0).Trim();
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Tài khoản của bạn không có quyền truy cập dữ liệu.\n", "", MessageBoxButtons.OK);
                    return;
                }

                try
                {
                    Program.mHoten = Program.myReader.GetString(1);
                    Program.mGroup = Program.myReader.GetString(2);
                    Program.frMain.HienThiMenu();

                    if (cbSavePass.Checked)
                    {
                        Properties.Settings.Default.username = txtUsername.Text;
                        Properties.Settings.Default.password = txtPassword.Text;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Reset();
                    }


                    Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tài khoản không đúng", "", MessageBoxButtons.OK);
                    return;
                }
                finally
                {
                    Program.myReader.Close();
                    Program.conn.Close();
                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập vào tài khoản này!\n", "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắn thoát Đăng Nhập ?\n", "", MessageBoxButtons.OK) == DialogResult.OK)
                Close();

            return;
        }

    }
}
