using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TokaApp
{
    public partial class Form2 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // height of ellipse
              int nHeightEllipse // width of ellipse
          );


        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

            lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        //when the user clicks the dashboard button, it will show up the dash board information
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 lblTitle.Text = "Dashboard";
            this.PnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        //when the user clicks the Create Goal button, it will show the create goal menu
        private void BtnCreateGoal_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Goals";
            this.PnlFormLoader.Controls.Clear();
            frmCreateGoal FrmCreateGoal_Vrb = new frmCreateGoal() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmCreateGoal_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmCreateGoal_Vrb);
            FrmCreateGoal_Vrb.Show();
        }

        private void BtnMessage_Click(object sender, EventArgs e)
        {

        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        //when the user clicks the video button, it will show up the videos
        private void button1_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Videos";
            this.PnlFormLoader.Controls.Clear();
            frmVideos FrmVideos_Vrb = new frmVideos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmVideos_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmVideos_Vrb);
            FrmVideos_Vrb.Show();
        }

        //when the user clicks the premium button, it will show up information  about ToKa Premium and how to sign up to it.
        private void btnPremium_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "";
            this.PnlFormLoader.Controls.Clear();
            frmPremium FrmPremium_Vrb = new frmPremium() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmPremium_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmPremium_Vrb);
            FrmPremium_Vrb.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnJoinNow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        //when the user clicks the payment button, it will show up the the payment and lets them pay
        private void button3_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Payment Gateway";
            this.PnlFormLoader.Controls.Clear();
            Payment FrmPayment_Vrb = new Payment() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmPayment_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FrmPayment_Vrb);
            FrmPayment_Vrb.Show();
        }
    }
}
