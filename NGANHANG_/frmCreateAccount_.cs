using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmCreateAccount_ : Form
    {

        private int pos = 0;

        public List<int> listExistsLogin = new List<int>();
        private List<int> listNoExistsLogin = new List<int>();

        public frmCreateAccount_()
        {
            InitializeComponent();
        }

        private void frCreateAccount__Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.tbaNV.Connection.ConnectionString = Program.connstr;
            this.tbaNV.Fill(this.DS.NhanVien);

            listExistsLogin = ListExistsLogin();
            listNoExistsLogin = ListNoExistsLogin(listExistsLogin);

            //null-all exsistlogin
            if (listNoExistsLogin.Count != 0)
            {
                txtCUser.Text = ((DataRowView)bdsNV[listNoExistsLogin[0]])["MANV"].ToString();
                bdsNV.Position = listNoExistsLogin[0];
            }
            else
            {
                btnAdd.Enabled = false;
                txtCLogin.Enabled = false;
                txtCPass.Enabled = false;
                gvNV.Enabled = false;
                btnCExit.Enabled = true;
                btnCCreate.Enabled = false;
            }

            txtCRole.Text = Program.mGroup;
            txtDRole.Text = Program.mGroup;
            txtERole.Text = Program.mGroup;

        }

        private void gvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pos = bdsNV.Position;
            String MANV = ((DataRowView)bdsNV[pos])["MANV"].ToString();
            txtCUser.Text = MANV;
            txtDUser.Text = MANV;
            txtEUser.Text = MANV;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HideRows(listNoExistsLogin, true);
            HideRows(listExistsLogin, false);

            if (listNoExistsLogin.Count != 0)
            {
                txtCUser.Text = ((DataRowView)bdsNV[listNoExistsLogin[0]])["MANV"].ToString();
                bdsNV.Position = listNoExistsLogin[0];
            }
            else
            {
                btnAdd.Enabled = false;
                txtCLogin.Enabled = false;
                txtCPass.Enabled = false;
                gvNV.Enabled = false;
                btnCExit.Enabled = true;
                btnCCreate.Enabled = false;
            }

            btnDel.Enabled = true;
            btnEdit.Enabled = true;
            gvNV.Visible = false;
            grcDelete.Visible = false;
            grcEdit.Visible = false;
            grcCreate.Visible = true;
            gvNV.Anchor = AnchorStyles.Left;
            gvNV.Anchor = AnchorStyles.Right;
            gvNV.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            HideRows(listExistsLogin, true);
            HideRows(listNoExistsLogin, false);

            btnAdd.Enabled = false;
            btnEdit.Enabled = false;
            gvNV.Visible = false;
            grcCreate.Visible = false;
            grcEdit.Visible = false;
            grcDelete.Visible = true;
            gvNV.Anchor = AnchorStyles.Left;
            gvNV.Anchor = AnchorStyles.Right;
            gvNV.Visible = true;

            if (listExistsLogin.Count != 0)
            {
                txtDUser.Text = ((DataRowView)bdsNV[listExistsLogin[0]])["MANV"].ToString();
                //bdsNV.Position = listExistsLogin[1];
                //gvNV.Enabled = true;
                bdsNV.Position = listExistsLogin[0];
            }
            else
            {
                btnDel.Enabled = false;
                grcDelete.Enabled = false;
                gvNV.Enabled = false;
            }

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            HideRows(listExistsLogin, true);
            HideRows(listNoExistsLogin, false);

            if (listExistsLogin.Count != 0)
            {
                txtEUser.Text = ((DataRowView)bdsNV[listExistsLogin[0]])["MANV"].ToString();
                //bdsNV.Position = listExistsLogin[1];
                bdsNV.Position = listExistsLogin[0];
                gvNV.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                grcEdit.Enabled = false;
                gvNV.Enabled = false;
            }

            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            gvNV.Visible = false;
            grcCreate.Visible = false;
            grcDelete.Visible = false;
            grcEdit.Visible = true;
            gvNV.Anchor = AnchorStyles.Left;
            gvNV.Anchor = AnchorStyles.Right;
            gvNV.Visible = true;

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
            if (Program.KetNoi(false, false) == 0) return;
            int temp = Program.ExecSqlStoredProcedureValue("SP_CREATE_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtCLogin.Text.Trim().ToUpper()),
                                        new SqlParameter("@PASS", txtCPass.Text.Trim()),
                                        new SqlParameter("@USERNAME", txtCUser.Text.Trim()),
                                        new SqlParameter("@ROLE", txtCRole.Text.Trim()),
                                    }, CommandType.StoredProcedure);
            if (temp == 0)
            {

                MessageBox.Show("Tao Login thanh cong !", "", MessageBoxButtons.OK);

                listExistsLogin.Add(pos);
                listNoExistsLogin.Remove(pos);

                HideRows(listNoExistsLogin, true);
                HideRows(listExistsLogin, false);

                if (listExistsLogin.Count != 0)
                {
                    txtCUser.Text = ((DataRowView)bdsNV[listNoExistsLogin[0]])["MANV"].ToString();
                    bdsNV.Position = listNoExistsLogin[0];
                }

                txtCLogin.Text = "";
                txtCPass.Text = "";

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
                txtDPass.Focus();
                return;

            }

            /*Program.mlogin = txtDLogin.Text.Trim().ToUpper();
            Program.password = txtDPass.Text.Trim();

            if (Program.KetNoi(false, true) == 0)
            {
                MessageBox.Show("Mat khau sai. Xin thu lai !", "", MessageBoxButtons.OK);
                txtDPass.Focus();
                return;
            }

            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;*/

            if (Program.KetNoi(false, false) == 0) return;
            if (Program.ExecSqlStoredProcedureValue("SP_DELETE_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtDLogin.Text.Trim()),
                                        new SqlParameter("@USERNAME", txtDUser.Text.Trim()),
                                    }, CommandType.StoredProcedure) == 0)
            {

                MessageBox.Show("Xoa thanh cong !", "", MessageBoxButtons.OK);

                listNoExistsLogin.Add(pos);
                listExistsLogin.Remove(pos);

                HideRows(listExistsLogin, true);
                HideRows(listNoExistsLogin, false);

                if (listExistsLogin.Count != 0)
                {
                    txtDUser.Text = ((DataRowView)bdsNV[listExistsLogin[0]])["MANV"].ToString();
                    bdsNV.Position = listExistsLogin[0];
                    //gvNV.Enabled = true;
                }

                txtDLogin.Text = "";
                txtDPass.Text = "";

                return;
            }

        }

        private void btnECreate_Click(object sender, EventArgs e)
        {
            if (txtELogin.Text.Trim() == "")
            {
                MessageBox.Show("Ten dang nhap khong duoc trong !", "", MessageBoxButtons.OK);
                txtELogin.Focus();
                return;
            }
            else if (txtEPass.Text.Trim() == "")
            {
                MessageBox.Show("Mat khau khong duoc trong !", "", MessageBoxButtons.OK);
                txtEPass.Focus();
                return;
            }
            else if (txtEPassOld.Text.Trim() == "")
            {
                MessageBox.Show("Mat khau khong duoc trong !", "", MessageBoxButtons.OK);
                txtEPassOld.Focus();
                return;
            }

            /*Program.mlogin = txtELogin.Text.Trim();
            Program.password = txtEPassOld.Text.Trim();

            if (Program.KetNoi(false, true) == 0)
            {
                MessageBox.Show("Mat khau sai. Xin thu lai !", "", MessageBoxButtons.OK);
                txtEPassOld.Focus();
                return;
            }
            else Program.conn.Close();

            Program.mlogin = Program.mloginDN;
            Program.password = Program.passwordDN;*/

            if (Program.KetNoi(false, false) == 0) return;
            if (Program.ExecSqlStoredProcedureValue("SP_EDIT_LOGIN",
                                    new List<SqlParameter> {
                                        new SqlParameter("@LOGINNAME", txtELogin.Text.Trim()),
                                        new SqlParameter("@PASS", txtEPass.Text.Trim()),
                                    }, CommandType.StoredProcedure) == 0)
            {
                MessageBox.Show("Sua doi tai khoan thanh cong !", "", MessageBoxButtons.OK);
                return;
            }

        }

        public List<int> ListExistsLogin()
        {

            String strLenh = @"SELECT name FROM sys.database_principals where type = 's'";
            String tempMANV;
            String tempMANV_;

            if (Program.KetNoi(false, false) == 0) return listExistsLogin;

            Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return listExistsLogin;

            while (Program.myReader.Read())
            {
                tempMANV = Program.myReader.GetString(0).Trim();
                for (int i = 0; i < bdsNV.Count; i++)
                {
                    tempMANV_ = ((DataRowView)bdsNV[i])["MANV"].ToString().Trim();
                    if (tempMANV.Equals(tempMANV_))
                        listExistsLogin.Add(i);
                }

            }

            Program.myReader.Close();
            Program.conn.Close();

            return listExistsLogin;
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

        public void HideRows(List<int> list_, bool visible)
        {

            CurrencyManager currencyManager1 = (CurrencyManager)gvNV.BindingContext[gvNV.DataSource];

            currencyManager1.SuspendBinding();

            foreach (int i in list_)
            {
                gvNV.Rows[i].Visible = visible;
            }

            // Wanted to add the resume statement to make it complete. Thank You for the solution, this works perfect!

            currencyManager1.ResumeBinding();
        }

    }
}
