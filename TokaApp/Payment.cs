using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokaApp
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\\LoginDB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();


        //When the button is clicked for them to make the payment - it will check if meets all of the conditions

        private void btnJoinNow_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text !="" && txtCardNum.TextLength == 16 && txtCVV.TextLength == 3 && txtMMYY.TextLength == 6)
            {
                MessageBox.Show("Payment Accepted");

            }
            else
            {
                MessageBox.Show("Your Details are incorrect");
            }
        }

        //When the user clicks off from the text it goes to a dark grey color (visual effect)

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                txtUsername.Text = "Username";
            txtUsername.ForeColor = Color.DarkGray;
        }

        //When the user clicks onto the textbox, it clears the textbox and makes the colour of the text black
        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = null;
            txtUsername.ForeColor = Color.Black;
        }

        //When the user clicks onto the textbox, it clears the textbox and makes the colour of the text black
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = null;
            txtPassword.ForeColor = Color.Black;
        }

        //When the user clicks off from the text it goes to a dark grey color (visual effect)
        private void txtSurname_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
                txtPassword.Text = "Password";
            txtPassword.ForeColor = Color.DarkGray;
        }

        //When the user clicks onto the textbox, it clears the textbox and makes the colour of the text black
        private void txtCardNum_Enter(object sender, EventArgs e)
        {
            if (txtCardNum.Text == "Card Number")
                txtCardNum.Text = null;
            txtCardNum.ForeColor = Color.Black;
        }

        //When the user clicks off from the text it goes to a dark grey color (visual effect)
        private void txtCardNum_Leave(object sender, EventArgs e)
        {
            if (txtCardNum.Text == "")
                txtCardNum.Text = "Card Number";
            txtCardNum.ForeColor = Color.DarkGray;
            
        }

        //When the user clicks onto the textbox, it clears the textbox and makes the colour of the text black
        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (txtCVV.Text == "CVV")
                txtCVV.Text = null;
            txtCVV.ForeColor = Color.Black;
        }

        //When the user clicks off from the text it goes to a dark grey color (visual effect)
        private void txtCVV_Leave(object sender, EventArgs e)
        {
            if (txtCVV.Text == "")
                txtCVV.Text = "CVV";
            txtCVV.ForeColor = Color.DarkGray;
        }

        //When the user clicks onto the textbox, it clears the textbox and makes the colour of the text black
        private void txtMMYY_Enter(object sender, EventArgs e)
        {
            if (txtMMYY.Text == "MM/YYYY")
                txtMMYY.Text = null;
            txtMMYY.ForeColor = Color.Black;
        }

        //When the user clicks off from the text it goes to a dark grey color (visual effect)
        private void txtMMYY_Leave(object sender, EventArgs e)
        {
            if (txtMMYY.Text == "")
                txtMMYY.Text = "MM/YYYY";
            txtMMYY.ForeColor = Color.DarkGray;
        }

        //Only lets a maximum of 16 numbers input into the textbox
        private void txtCardNum_TextChanged(object sender, EventArgs e)
        {
            txtCardNum.MaxLength = 16;
        }

        //Only lets a maximum of 3 numbers input into the textbox
        private void txtCVV_TextChanged(object sender, EventArgs e)
        {
            txtCVV.MaxLength = 3;
        }

        //Only lets a maximum of 6 numbers input into the textbox
        private void txtMMYY_TextChanged(object sender, EventArgs e)
        {
            txtMMYY.MaxLength = 6;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
           
        }
    }
    }

