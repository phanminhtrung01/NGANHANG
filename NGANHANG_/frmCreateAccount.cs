using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frCreateAccount : Form
    {

        private int pos = 0;
        private String tempLogin;
        private String tempPass;

        private List<int> list = new List<int>();

        public frCreateAccount()
        {
            InitializeComponent();
        }

        private void frCreateAccount_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.tbaNV.Connection.ConnectionString = Program.connstr;
            this.tbaNV.Fill(this.DS.NhanVien);

            //HIDE ROW_GRIDVIEW_GRIDCONTROL
            list = ListExistsLogin();

            if (list[0] == 0 && list[list.Count - 1] != list[1])
                pos = list[0] + 1;
            else if (0 < list[0] && list[list.Count - 1] > list[0])
                pos = list[0] - 1;
            else
                pos = list.Count;

            String MANV = ((DataRowView)bdsNV[pos])["MANV"].ToString().Trim();
            txtCUser.Text = MANV;
            txtCRole.Text = Program.mGroup;
            txtDRole.Text = Program.mGroup;
            txtERole.Text = Program.mGroup;

        }

        private void nhanVienGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            pos = bdsNV.Position;
            String MANV = ((DataRowView)bdsNV[pos])["MANV"].ToString();
            txtCUser.Text = MANV;
            txtDUser.Text = MANV;
            txtEUser.Text = MANV;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //HIDE ROW_EXISTS_LOGIN
            this.tbaNV.Fill(this.DS.NhanVien);
            gvNV.RefreshData();

            DeleteRowsLogin(list);

            String MANV = ((DataRowView)bdsNV[0])["MANV"].ToString();
            txtDUser.Text = MANV;

            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            gcNV.Visible = false;
            grcDelete.Visible = false;
            grcEdit.Visible = false;
            grcCreate.Visible = true;
            gcNV.Anchor = AnchorStyles.Left;
            gcNV.Anchor = AnchorStyles.Right;
            gcNV.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            this.tbaNV.Fill(this.DS.NhanVien);
            gvNV.RefreshData();

            DeleteRowsLogin(ListNoExistsLogin(list));

            String MANV = ((DataRowView)bdsNV[0])["MANV"].ToString();
            txtDUser.Text = MANV;

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            gcNV.Visible = false;
            grcCreate.Visible = false;
            grcEdit.Visible = false;
            grcDelete.Visible = true;
            gcNV.Anchor = AnchorStyles.Left;
            gcNV.Anchor = AnchorStyles.Right;
            gcNV.Visible = true;

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // HIDE ROW
            this.tbaNV.Fill(this.DS.NhanVien);
            gvNV.RefreshData();

            DeleteRowsLogin(ListNoExistsLogin(list));

            String MANV = ((DataRowView)bdsNV[0])["MANV"].ToString();
            txtEUser.Text = MANV;

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            gcNV.Visible = false;
            grcCreate.Visible = false;
            grcDelete.Visible = false;
            grcEdit.Visible = true;
            gcNV.Anchor = AnchorStyles.Left;
            gcNV.Anchor = AnchorStyles.Right;
            gcNV.Visible = true;

        }

        private void btnDExit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

            barButtonItem1_ItemClick(null, null);

        }

        private void btnEExit_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;

            barButtonItem1_ItemClick(null, null);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCCreate_Click(object sender, EventArgs e)
        {

            if (txtCLogin.Text.Trim() == "")
            {
                MessageBox.Show("Login khong duoc trong !", "", MessageBoxButtons.OK);
                txtCLogin.Focus();
                return;
            }
            else if (txtCPass.Text.Trim() == "")
            {
                MessageBox.Show("Password khong duoc trong !", "", MessageBoxButtons.OK);
                txtCPass.Focus();
                return;

            }

            //c1
            /*String StrLenh = @"EXEC [dbo].[SP_CREATE_LOGIN] '" + txtCLogin.Text + "', '" + txtCPass.Text + "', '" + txtCUser.Text + "', '" + txtCRole.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(StrLenh);

            if (Program.myReader == null) return;
            Program.myReader.Close();*/

            //c2
            if (Program.ExecSqlStoredProcedureValue("SP_CREATE_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtCLogin.Text.Trim()),
                                        new SqlParameter("@PASS", txtCPass.Text.Trim()),
                                        new SqlParameter("@USERNAME", txtCUser.Text.Trim()),
                                        new SqlParameter("@ROLE", txtCRole.Text.Trim()),
                                    }, CommandType.StoredProcedure) == 0)
            {

                MessageBox.Show("Tao Login thanh cong !", "", MessageBoxButtons.OK);

                //String tempMANV = ((DataRowView)bdsNV[pos])["MANV"].ToString().Trim();
                list.Add(pos);

                return;
            }
            else
            {
                MessageBox.Show("Tao Login that bai !", "", MessageBoxButtons.OK);
                txtCLogin.Focus();
                return;
            }

        }

        private void btnDCreate_Click(object sender, EventArgs e)
        {
            if (txtDLogin.Text.Trim() == "")
            {
                MessageBox.Show("Ten dang nhap khong duoc trong !", "", MessageBoxButtons.OK);
                txtDLogin.Focus();
                return;
            }
            else if (txtDPass.Text.Trim() == "")
            {
                MessageBox.Show("Mat khau khong duoc trong !", "", MessageBoxButtons.OK);
                txtCPass.Focus();
                return;

            }

            tempLogin = Program.mlogin;
            tempPass = Program.password;
            Program.mlogin = txtDLogin.Text.Trim();
            Program.password = txtDPass.Text.Trim();

            if (Program.KetNoi(false, true) == 0)
            {
                MessageBox.Show("Mat khau sai. Xin thu lai !", "", MessageBoxButtons.OK);
                txtDPass.Focus();
                return;
            }

            if (Program.ExecSqlStoredProcedureValue("SP_DELETE_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtDLogin.Text.Trim()),
                                        new SqlParameter("@USERNAME", txtDUser.Text.Trim()),
                                    }, CommandType.StoredProcedure) == 0)
            {

                MessageBox.Show("Xoa thanh cong !", "", MessageBoxButtons.OK);

                String tempMANV = ((DataRowView)bdsNV[pos])["MANV"].ToString().Trim();
                list.Remove(pos);

                return;
            }

            Program.mlogin = tempLogin;
            Program.password = tempPass;

        }

        private void btnECreate_Click(object sender, EventArgs e)
        {
            if (txtELogin.Text.Trim() == "")
            {
                MessageBox.Show("Ten dang nhap khong duoc trong !", "", MessageBoxButtons.OK);
                txtDLogin.Focus();
                return;
            }
            else if (txtEPass.Text.Trim() == "" || txtEPassOld.Text == "")
            {
                MessageBox.Show("Mat khau khong duoc trong !", "", MessageBoxButtons.OK);
                txtEPassOld.Focus();
                return;
            }

            tempLogin = Program.mlogin;
            tempPass = Program.password;
            Program.mlogin = txtDLogin.Text.Trim();
            Program.password = txtDPass.Text.Trim();
            if (Program.KetNoi(false, true) == 0)
            {
                MessageBox.Show("Mat khau sai. Xin thu lai !", "", MessageBoxButtons.OK);
                txtEPassOld.Focus();
                return;
            }

            if (Program.ExecSqlStoredProcedureValue("SP_EDIT_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtELogin.Text.Trim()),
                                        new SqlParameter("@PASS", txtEPass.Text.Trim()),
                                    }, CommandType.StoredProcedure) == 0)
            {
                MessageBox.Show("Sua doi tai khoan thanh cong !", "", MessageBoxButtons.OK);
                return;
            }

            Program.mlogin = tempLogin;
            Program.password = tempPass;

        }

        public List<int> ListExistsLogin()
        {

            String strLenh = @"SELECT name FROM sys.database_principals where type = 's'";
            String tempMANV;
            String tempMANV_;
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return list;

            while (Program.myReader.Read())
            {
                tempMANV = Program.myReader.GetString(0).Trim();
                for (int i = 0; i < bdsNV.Count; i++)
                {
                    tempMANV_ = ((DataRowView)bdsNV[i])["MANV"].ToString().Trim();
                    if (tempMANV.Equals(tempMANV_))
                        list.Add(i);
                }

            }

            Program.myReader.Close();

            return list;
        }

        private List<int> ListNoExistsLogin(List<int> list_)
        {
            int i, k = 0;
            List<int> list1 = new List<int>();

            for (i = 0; i < bdsNV.Count; i++)
            {
                k = 0;
                foreach (int j in list_)
                {
                    if (i == j)
                    {
                        k++;
                        break;
                    }
                }

                if (k == 0)
                    list1.Add(i);

            }

            return list1;

        }

        public void DeleteRowsLogin(List<int> listLogin)
        {

            gvNV.OptionsSelection.MultiSelect = true;

            foreach (int i in listLogin)
                gvNV.SelectRow(i);

            gvNV.DeleteSelectedRows();

            gvNV.OptionsSelection.MultiSelect = false;

        }
    }
}
