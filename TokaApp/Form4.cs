using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace TokaApp
{
    public partial class Form4 : Form
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

        public Form4()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 60, 60));

        }


        


        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\LoginDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        //Conects to the SQL database if the user has entered text in both text boxes if it incorrect, they will get an orreor message
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsernameDB.Text == "" && txtPasswordDB.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPasswordDB.Text != "" && txtUsernameDB.Text != "" )
            {
                con.Open();
                string register = "INSERT INTO tbl_users VALUES ('" + txtUsernameDB.Text + "','" + txtPasswordDB.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsernameDB.Text = "";
                txtPasswordDB.Text = "";

                MessageBox.Show("Your Account has been successfully created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You have left a field blank, please try again.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordDB.Text = "";
                txtPasswordDB.Focus();
            }
        }

        ////The user can click this to go to the login page
        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // if the check box is ticked, it allows the user to view their password.
        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPasswordDB.PasswordChar = '\0';
            }

            else
            {
                txtPasswordDB.PasswordChar = '•';
            }
        }

        private void txtUsernameDB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
