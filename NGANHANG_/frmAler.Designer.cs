
namespace NGANHANG_
{
    partial class frmAler
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
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.pncAler = new DevExpress.XtraEditors.PanelControl();
            this.txtInfo_ = new System.Windows.Forms.TextBox();
            this.ptbType = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gcTK_KH = new DevExpress.XtraGrid.GridControl();
            this.gvTK_KH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rpstMACN = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pncAler)).BeginInit();
            this.pncAler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstMACN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // pncAler
            // 
            this.pncAler.Controls.Add(this.txtInfo_);
            this.pncAler.Controls.Add(this.ptbType);
            this.pncAler.Location = new System.Drawing.Point(115, 55);
            this.pncAler.Name = "pncAler";
            this.pncAler.Size = new System.Drawing.Size(200, 100);
            this.pncAler.TabIndex = 0;
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
            this.txtInfo_.Location = new System.Drawing.Point(103, 2);
            this.txtInfo_.Multiline = true;
            this.txtInfo_.Name = "txtInfo_";
            this.txtInfo_.ReadOnly = true;
            this.txtInfo_.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo_.Size = new System.Drawing.Size(95, 96);
            this.txtInfo_.TabIndex = 11;
            // 
            // ptbType
            // 
            this.ptbType.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbType.Location = new System.Drawing.Point(2, 2);
            this.ptbType.Name = "ptbType";
            this.ptbType.Size = new System.Drawing.Size(101, 96);
            this.ptbType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbType.TabIndex = 10;
            this.ptbType.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gcTK_KH
            // 
            this.gcTK_KH.DataMember = "FK_TaiKhoan_KhachHang";
            this.gcTK_KH.Dock = System.Windows.Forms.DockStyle.Right;
            this.gcTK_KH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gcTK_KH.Location = new System.Drawing.Point(762, 0);
            this.gcTK_KH.MainView = this.gvTK_KH;
            this.gcTK_KH.Name = "gcTK_KH";
            this.gcTK_KH.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rpstMACN});
            this.gcTK_KH.Size = new System.Drawing.Size(525, 713);
            this.gcTK_KH.TabIndex = 23;
            this.gcTK_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTK_KH});
            // 
            // gvTK_KH
            // 
            this.gvTK_KH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colSODU,
            this.colNGAYMOTK,
            this.colCMND1,
            this.colMACN1});
            this.gvTK_KH.GridControl = this.gcTK_KH;
            this.gvTK_KH.Name = "gvTK_KH";
            this.gvTK_KH.NewItemRowText = "Thêm Tài Khoản Mới";
            this.gvTK_KH.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTK_KH.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvTK_KH.OptionsCustomization.AllowColumnMoving = false;
            this.gvTK_KH.OptionsCustomization.AllowColumnResizing = false;
            this.gvTK_KH.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gvTK_KH.OptionsView.ShowDetailButtons = false;
            this.gvTK_KH.OptionsView.ShowGroupPanel = false;
            this.gvTK_KH.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvTK_KH.OptionsView.ShowIndicator = false;
            this.gvTK_KH.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gvTK_KH.OptionsView.ShowViewCaption = true;
            this.gvTK_KH.ViewCaption = "TÀI KHOẢN KHÁCH HÀNG";
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(416, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(346, 713);
            this.dataGridView1.TabIndex = 49;
            // 
            // frmAler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 713);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gcTK_KH);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pncAler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAler";
            this.Text = "Aler";
            ((System.ComponentModel.ISupportInitialize)(this.pncAler)).EndInit();
            this.pncAler.ResumeLayout(false);
            this.pncAler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpstMACN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Time;
        private DevExpress.XtraEditors.PanelControl pncAler;
        private System.Windows.Forms.TextBox txtInfo_;
        private System.Windows.Forms.PictureBox ptbType;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gcTK_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTK_KH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox rpstMACN;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}