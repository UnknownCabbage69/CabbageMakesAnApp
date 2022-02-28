using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokaApp
{
    public partial class frmCreateGoal : Form
    {
        public frmCreateGoal()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnJoinNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Goals have been saved");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExcersizeAdvice excersizeAdvice = new ExcersizeAdvice();
            excersizeAdvice.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPage2);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnJoinNow_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Your workouts have been saved", "Saved successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
