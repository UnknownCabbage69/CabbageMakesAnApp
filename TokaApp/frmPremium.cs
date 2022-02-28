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
    public partial class frmPremium : Form
    {
        public frmPremium()
        {
            InitializeComponent();
        }

        private void frmPremium_Load(object sender, EventArgs e)
        {

        }

        private void btnJoinNow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Visit the Payment tab to join premium.", "Join Premium", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
