using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NGANHANG_
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {

        private Stack<object[]> undoTodo = new Stack<object[]>();
        private Stack<DataRowState> undoType = new Stack<DataRowState>();
        private List<string> listDelete = new List<string>();
        private List<String> listChiNhanh = new List<string>();
        private int pos = 0;

        public frmUser()
        {
            InitializeComponent();
        }

        private void frCreateAccountUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.
            this.tbaNV.Connection.ConnectionString = Program.connstr;
            this.tbaNV.Fill(this.DS.NhanVien);

            this.DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.tbaKH.Connection.ConnectionString = Program.connstr;
            this.tbaKH.Fill(this.DS.KhachHang);
            // TODO: This line of code loads data into the 'DS.TTKH' table. You can move, or remove it, as needed.
            this.tbaTTKH.Connection.ConnectionString = Program.connstr;
            this.tbaTTKH.Fill(this.DS.TTKH);
            // TODO: This line of code loads data into the 'DS.TaiKhoan' table. You can move, or remove it, as needed.
            this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
            this.tbaTK_KH.Fill(this.DS.TaiKhoan);
            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.tbaCT.Connection.ConnectionString = Program.connstr;
            this.tbaCT.Fill(this.DS.GD_CHUYENTIEN);
            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.tbaGRTK.Connection.ConnectionString = Program.connstr;
            this.tbaGRTK.Fill(this.DS.GD_GOIRUT);
            int index;
            for (index = 0; index < bdsKH.Count; index++)
            {
                bdsKH.Position = index;
                if (bdsTK_KH.Count > 0)
                {
                    listDelete.Add(((DataRowView)bdsKH.Current)["CMND"].ToString());
                }
            }

            cmbChiNhanh.DataSource = Program.bds_dspm.DataSource;

            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;

            bdsKH.Position = 0;
            bdsTTKH.Position = 0;
            gvKH_RowCellClick(null, null);

            if (Program.mGroup == "ChiNhanh")
            {
                cmbChiNhanh.Enabled = false;
            }
            else cmbChiNhanh.Enabled = true;

        }

        private void cbmTTKH_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbTTKH.SelectedValue != null)
                {
                    bdsKH.Position = bdsKH.Find("CMND", cmbTTKH.SelectedValue.ToString());
                }
            }
            catch (Exception) { }

        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbTTKH.SelectedIndex = bdsTTKH.Find("CMND", txtCMND.Text);
            }
            catch (Exception) { }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Enable1(false);
            cmbTTKH.Enabled = false;
            txtCMND.Enabled = true;
            pos = bdsKH.Position;
            bdsKH.AddNew();
            cmbPhai.ValueMember = "Nam";
            cmbPhai.SelectedIndex = 0;
            //gvKH.SetFocusedRowCellValue("MACN", Program.username);
            txtMCN.Text = getChiNhanh(Program.username);
            txtCMND.Focus();
            //default date;

        }

        private void btnDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pos = bdsKH.Position;
            this.Enable1(false);
            cmbTTKH.Enabled = true;
            txtHo.Enabled = txtCMND.Enabled = txtTen.Enabled = txtPlace.Enabled
                 = txtMCN.Enabled = dtpNgayCap.Enabled = txeSDT.Enabled = cmbPhai.Enabled = false;

            int index;
            for (index = 0; index < listDelete.Count; index++)
            {
                int pos = bdsTTKH.Find("CMND", listDelete[index]);
                DataRowView rowView = ((DataRowView)bdsTTKH[pos]);
                rowView.Delete();
            }

            bdsTTKH.EndEdit();
            bdsTTKH.Position = pos;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pos = bdsKH.Position;
            Enable1(false);
            cmbTTKH.Enabled = true;
            txtCMND.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoTodo.Count != 0 && undoTodo.Count == undoType.Count)
            {
                switch (undoType.Pop())
                {
                    case DataRowState.Added:
                        RemoveARow(undoTodo.Pop());
                        break;
                    case DataRowState.Deleted:
                        AddNewRow(undoTodo.Pop());
                        break;
                    case DataRowState.Modified:
                        ModifyRow(undoTodo.Pop());
                        break;
                    default:
                        AddNewRow(undoTodo.Pop());
                        break;
                }

            }
            else
            {
                MessageBox.Show("Loi he thong! Thu dong mo lai form!", "Cảnh Báo", MessageBoxButtons.OK);
            }

            if (undoTodo.Count == 0) btnUndo.Enabled = false;
        }

        private void btnWri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ khách hàng không được thiếu !", "", MessageBoxButtons.OK);
                txtHo.Focus();
                return;
            }

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên khách hàng không được thiếu !", "", MessageBoxButtons.OK);
                txtTen.Focus();
                return;
            }

            if (txtCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND khách hàng không được thiếu !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (int.Parse(txtCMND.Text.Trim().Length.ToString()) > 9)
            {
                MessageBox.Show("Số CMND phải đủ 9 số !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }

            if (txtPlace.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được thiếu !", "", MessageBoxButtons.OK);
                txtPlace.Focus();
                return;
            }

            if (dtpNgayCap.Text.Trim() == "")
            {
                MessageBox.Show("Ngày cấp không được thiếu !", "", MessageBoxButtons.OK);
                dtpNgayCap.Focus();
                return;
            }

            if (DateTime.Parse(dtpNgayCap.Value.ToString()) >= DateTime.Now)
            {
                MessageBox.Show("Ngày cấp không hợp lệ, vượt quá ngày hiện tại !", "", MessageBoxButtons.OK);
                dtpNgayCap.Focus();
                return;
            }

            /*if (Program.ExecSqlStoredProcedureValue("SP_KT_CMND", new List<SqlParameter> {
                                        new SqlParameter("@CMND", txtCMND.Text.Trim())
                                    }, CommandType.StoredProcedure) == 0)
            {
                MessageBox.Show("Số CMND đã tồn tại vui lòng không nhập trùng !", "", MessageBoxButtons.OK);
                txtCMND.Focus();
                return;
            }*/

            try
            {
                object[] arrKH = ((DataRowView)bdsKH.Current).Row.ItemArray;
                this.undoTodo.Push(arrKH);

                bdsKH.EndEdit();

                DataRowState rowState = ((DataRowView)bdsKH.Current).Row.RowState;
                if (rowState == DataRowState.Unchanged)
                {

                    if (btnDel.Enabled == false && txtHo.Enabled == false)
                    {
                        if (MessageBox.Show("Bạn chắn chắn xóa khách hàng này!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                pos = bdsKH.Position;
                                bdsKH.RemoveCurrent();
                                undoType.Push(rowState);
                                tbaKH.Update(this.DS.KhachHang);
                                tbaKH.Fill(this.DS.KhachHang);
                                tbaTTKH.Fill(this.DS.TTKH);
                            }
                            catch
                            {
                                AddNewRow(undoTodo.Pop());
                                undoType.Pop();
                            }
                            finally
                            {
                                if (undoTodo.Count != 0)
                                    btnUndo.Enabled = true;
                                else
                                    btnUndo.Enabled = false;
                            }

                        }

                        if (bdsKH.Count == 0) btnDel.Enabled = false;
                        this.Enable1(true);

                        return;
                    }
                    else
                    {
                        this.ShowAlert("Chưa có sự thay đổi !", enmType.Warning, 50, 150, 0);
                        this.undoTodo.Pop();
                        return;
                    }

                }

                this.undoType.Push(rowState);
                if (this.undoType.Peek() == DataRowState.Added)
                {
                    this.undoTodo.Pop();
                    this.undoTodo.Push(arrKH);
                }

                bdsKH.ResetCurrentItem();
                tbaKH.Update(this.DS.KhachHang);

                this.ShowAlert("Lưu thông tin khách hàng thành công !", enmType.Success, 50, 150, 0);

                tbaKH.Fill(this.DS.KhachHang);
                tbaTTKH.Fill(this.DS.TTKH);

                btnWri.Enabled = false;
                this.Enable1(true);
            }
            catch (Exception ex)
            {
                if (this.undoType.Peek() == DataRowState.Added)
                    this.RemoveARow(undoTodo.Pop());
                else if (this.undoType.Peek() == DataRowState.Modified)
                    this.ModifyRow(this.undoTodo.Pop());
                this.undoType.Pop();

                MessageBox.Show("Lỗi ghi nhân viên.\n " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            finally
            {
                if (undoTodo.Count != 0 && undoType.Count != 0)
                    btnUndo.Enabled = true;
                else
                    btnUndo.Enabled = false;
            }

            bdsKH.Position = pos;

        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnCancel.Enabled = false;
            bdsKH.CancelEdit();
            tbaTTKH.Fill(this.DS.TTKH);
            Enable1(true);
            bdsKH.Position = pos;
            bdsTTKH.Position = pos;
            gvKH_RowCellClick(null, null);
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (MessageBox.Show("Bạn chắn thoát form!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Program.conn.Close();
                Close();
            }

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi(false, true) == 0)
                MessageBox.Show("Loi ket noi ve chi nhanh moi", "", MessageBoxButtons.OK);
            else
            {

                Program.mChinhanh = cmbChiNhanh.SelectedIndex;
                // TODO: This line of code loads data into the 'DS.NhanVien' table. You can move, or remove it, as needed.
                this.tbaNV.Connection.ConnectionString = Program.connstr;
                this.tbaNV.Fill(this.DS.NhanVien);

                this.DS.EnforceConstraints = false;
                // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
                this.tbaKH.Connection.ConnectionString = Program.connstr;
                this.tbaKH.Fill(this.DS.KhachHang);
                // TODO: This line of code loads data into the 'DS.TTKH' table. You can move, or remove it, as needed.
                this.tbaTTKH.Connection.ConnectionString = Program.connstr;
                this.tbaTTKH.Fill(this.DS.TTKH);
                // TODO: This line of code loads data into the 'DS.TaiKhoan' table. You can move, or remove it, as needed.
                this.tbaTK_KH.Connection.ConnectionString = Program.connstr;
                this.tbaTK_KH.Fill(this.DS.TaiKhoan);
                int index;
                for (index = 0; index < bdsKH.Count; index++)
                {
                    bdsKH.Position = index;
                    if (bdsTK_KH.Count > 0)
                        listDelete.Add(((DataRowView)bdsKH.Current)["CMND"].ToString());
                }

                gvKH_RowCellClick(null, null);
                bdsKH.Position = 0;
                bdsTTKH.Position = 0;

            }

        }

        private void Enable1(bool enable)
        {
            btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = btnExit.Enabled = enable;
            btnWri.Enabled = btnCancel.Enabled = !enable;
            gcKH.Enabled = gcTK_KH.Enabled = enable;
            //pcKH.Enabled = !enable;
            txtHo.Enabled = txtCMND.Enabled = txtTen.Enabled = txtPlace.Enabled
                 = txtMCN.Enabled = dtpNgayCap.Enabled = txeSDT.Enabled = cmbPhai.Enabled = cmbTTKH.Enabled = !enable;
        }

        private void AddNewRow(object[] list)
        {

            try
            {

                bdsKH.AddNew();
                DataRowView rowView = ((DataRowView)bdsKH.Current);

                rowView.Row.ItemArray = list;
                rowView.DataView.Table.Rows.Add(rowView.Row);

                bdsKH.EndEdit();

                tbaKH.Update(this.DS.KhachHang);
                tbaKH.Fill(this.DS.KhachHang);
                tbaTTKH.Fill(this.DS.TTKH);
                int pos = bdsKH.Find("CMND", list[0]);
                bdsTTKH.Position = pos;
                bdsKH.Position = pos;
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString(), "Cảnh Báo", MessageBoxButtons.OK); }

        }

        private void RemoveARow(object[] list)
        {
            try
            {

                int index = bdsKH.Find("CMND", list[0]);
                DataRowView rowView = ((DataRowView)bdsKH[index]);

                bdsKH.Position = index;
                bdsKH.RemoveCurrent();

                tbaKH.Update(this.DS.KhachHang);
                tbaKH.Fill(this.DS.KhachHang);

                bdsTTKH.Position = pos;
                bdsKH.Position = pos;
            }
            catch (Exception) { }

        }

        private void ModifyRow(object[] list)
        {
            try
            {

                int index = bdsKH.Find("CMND", list[0]);
                DataRowView rowView = ((DataRowView)bdsKH[index]);

                rowView.Row.ItemArray = list;
                bdsKH.ResetCurrentItem();
                tbaKH.Update(this.DS.KhachHang);
                tbaTTKH.Fill(this.DS.TTKH);

                bdsTTKH.Position = index;
                bdsKH.Position = index;
            }
            catch (Exception) { }
        }

        private String getChiNhanh(String manv)
        {
            string macn;
            int pos = this.bdsNV.Find("MANV", manv);
            macn = ((DataRowView)bdsNV[pos])["MACN"].ToString();

            return macn;
        }

        private void txeSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        //Aler_Form
        public enum enmAction
        {
            wait,
            start,
            close
        }

        public enum enmType
        {
            Success,
            Error,
            Warning
        }

        private enmType type;
        private enmAction action;
        private int speed;
        private string msg;

        public void ShowAlert(string msg, enmType type, int height, int speed, int pos)
        {
            int padding = 15;
            this.pncAler.Visible = true;
            this.speed = speed;
            this.msg = msg;
            this.pncAler.Location = new Point(this.Width - padding, pos);
            this.pncAler.Size = new Size(new Point(this.Width, height));
            this.type = type;
            this.action = enmAction.start;
            this.Time.Interval = 1;
            this.Time.Start();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            int padding = 15;
            switch (this.action)
            {
                case enmAction.start:
                    this.pncAler.Left -= speed;
                    if (this.pncAler.Left < speed)
                    {
                        this.pncAler.Left -= (this.Width - padding) % speed;
                        action = enmAction.wait;
                    }
                    break;
                case enmAction.wait:
                    this.txtInfo_.Text = this.msg;
                    switch (type)
                    {
                        case enmType.Success:
                            this.ptbType.Image = global::NGANHANG_.Properties.Resources.success;
                            this.pncAler.Enabled = false;
                            this.Time.Interval = 2000;
                            action = enmAction.close;
                            break;
                        case enmType.Error:
                            this.Time.Interval = 1;
                            this.ptbType.Image = global::NGANHANG_.Properties.Resources.error;
                            this.pncAler.Enabled = true;

                            break;
                        case enmType.Warning:
                            this.Time.Interval = 1;
                            this.ptbType.Image = global::NGANHANG_.Properties.Resources.warn;
                            this.pncAler.Enabled = true;
                            break;
                    }

                    break;
                case enmAction.close:
                    this.Time.Interval = 1;
                    this.pncAler.Left -= (speed + speed / 40);
                    break;
            }
        }

        private void ptbClose_Click(object sender, EventArgs e)
        {
            action = enmAction.close;
        }

        private void gvKH_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (bdsTK_KH.Count > 0)
            {
                btnDel.Enabled = false;
            }
            else
            {
                btnDel.Enabled = true;
            }
            //bdsKH.Position = e.RowHandle;
        }

        private void gvTK_KH_ShownEditor(object sender, EventArgs e)
        {

            GridView view = sender as GridView;

            view.ActiveEditor.IsModified = true;

            object[] itemsRow = ((DataRowView)((BindingSource)((BaseView)sender).DataSource).Current).Row.ItemArray;

            undoTodo.Push(itemsRow);

        }

        private void gvTK_KH_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {

            GridView view = sender as GridView;
            object val = e.Value;
            bdsTK_KH.CancelEdit();
            if (view.FocusedColumn.FieldName == "SOTK")
            {
                if (val == null || string.IsNullOrWhiteSpace(e.Value.ToString()))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập Số Tài Khoản !";
                    tsmiSave.Enabled = false;
                }
                else
                    tsmiSave.Enabled = true;

            }
            else if (view.FocusedColumn.FieldName == "SODU")
            {

                Int64 priceMin = 0;
                string priceStr = e.Value.ToString();
                if (val == null || string.IsNullOrWhiteSpace(priceStr))
                {
                    e.Valid = false;
                    e.ErrorText = "Vui lòng nhập Số Tài Khoản !";
                    tsmiSave.Enabled = false;
                }
                else if (Int64.Parse(priceStr.Split(',')[0]) < priceMin)
                {
                    e.Valid = false;
                    e.ErrorText = "Số tiền phải lớn hơn 0 !";
                    tsmiSave.Enabled = false;
                }
                else
                    tsmiSave.Enabled = true;
            }
            else if (view.FocusedColumn.FieldName == "NGAYMOTK")
            {
                if ((DateTime)val > DateTime.Now)
                {
                    e.Valid = false;
                    e.ErrorText = "Ngày cấp không quá ngày hiện tại !";
                    tsmiSave.Enabled = false;
                }
                else
                    tsmiSave.Enabled = true;
            }

        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {

            bdsTK_KH.AddNew();
            bdsTK_KH.EndEdit();
            tsmiAdd.Enabled = tsmiDel.Enabled = false;
            tsmiSave.Enabled = tsmiCancel.Enabled = true;

            btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = btnUndo.Enabled = btnExit.Enabled = false;

            this.ShowAlert("Lưu thông tin tài khoản khách hàng (nếu có sửa chữa) để tiếp tục hiệu chỉnh khách hàng !", enmType.Warning, 50, 150, 0);

        }

        private void tsmiDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắn chắn xóa tài khoản này!", "Cảnh Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsTK_KH.RemoveCurrent();
                    tbaTK_KH.Update(this.DS.TaiKhoan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa tài khoản: " + ex, "Cảnh Báo", MessageBoxButtons.OK);
                }

            }
        }

        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            bdsTK_KH.EndEdit();
            DataRowState rowState = ((DataRowView)bdsTK_KH.Current).Row.RowState;
            if (rowState == DataRowState.Added)
            {
                bdsTK_KH.RemoveCurrent();
            }
            else if (rowState == DataRowState.Modified)
            {
                tbaTK_KH.Fill(this.DS.TaiKhoan);
            }

            tsmiCancel.Enabled = false;
            tsmiAdd.Enabled = tsmiDel.Enabled = true;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {

            try
            {
                bdsTK_KH.EndEdit();
                tbaTK_KH.Update(this.DS.TaiKhoan);
                tsmiAdd.Enabled = tsmiDel.Enabled = true;
                tsmiSave.Enabled = tsmiCancel.Enabled = false;
                MessageBox.Show("Thanh cong!", "", MessageBoxButtons.OK);

                btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = btnUndo.Enabled = btnExit.Enabled = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("" + ex, "", MessageBoxButtons.OK);
            }
        }

        private void gvTK_KH_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            object[] itemsRow = ((DataRowView)((BindingSource)((BaseView)sender).DataSource).Current).Row.ItemArray;

            if (!itemsRow[e.Column.ColumnHandle].Equals(undoTodo.Pop()[e.Column.ColumnHandle]))
            {
                btnAdd.Enabled = btnDel.Enabled = btnEdit.Enabled = btnUndo.Enabled = btnExit.Enabled = false;

                this.ShowAlert("Lưu thông tin tài khoản khách hàng (nếu có sửa chữa) để tiếp tục hiệu chỉnh khách hàng !", enmType.Warning, 50, 150, 0);

                tsmiSave.Enabled = true;
                tsmiCancel.Enabled = true;
                tsmiAdd.Enabled = false;
                tsmiDel.Enabled = false;
            }
            else
            {
                tsmiSave.Enabled = false;
                tsmiCancel.Enabled = false;
                tsmiAdd.Enabled = true;
                tsmiDel.Enabled = true;
            }
        }

    }
}