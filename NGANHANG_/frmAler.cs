using System;
using System.Drawing;

namespace NGANHANG_
{
    public partial class frmAler : DevExpress.XtraEditors.XtraForm
    {
        public frmAler()
        {
            InitializeComponent();
        }

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
        }

        private enmAction action;

        private int speed;

        public void ShowAlert(string msg, enmType type, int height, int speed)
        {
            int padding = 15;
            this.speed = speed;
            this.pncAler.Location = new Point(this.Width - padding, 0);
            this.pncAler.Size = new Size(new Point(this.Width, height));

            switch (type)
            {
                case enmType.Success:
                    break;
                case enmType.Error:
                    break;
            }

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
                    this.Time.Interval = 1;
                    this.pncAler.Left -= speed;
                    if (this.pncAler.Left < speed)
                    {
                        this.pncAler.Left -= (this.Width - padding) % speed;
                        action = enmAction.wait;
                    }

                    break;
                case enmAction.wait:
                    Time.Interval = 3000;
                    this.txtInfo_.Text = "Success !";
                    this.ptbType.Image = global::NGANHANG_.Properties.Resources.success;
                    action = enmAction.close;
                    break;
                case enmAction.close:
                    this.Time.Interval = 1;
                    this.pncAler.Left -= (speed + speed / 40);
                    break;
            }
        }

        private void txtInfo_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            txtInfo_.ForeColor = Color.Purple;
        }

        private void txtInfo_MouseHover(object sender, EventArgs e)
        {
            txtInfo_.ForeColor = Color.Red;
        }

        private void txtInfo_MouseLeave(object sender, EventArgs e)
        {
            txtInfo_.ForeColor = Color.Blue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAlert("dsgdsg", enmType.Success, 40, 100);
        }
    }
}