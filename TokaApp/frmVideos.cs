using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokaApp
{
    public partial class frmVideos : Form
    {
        public frmVideos()
        {
            InitializeComponent();
        }

        // All lines of code below this are for the functionality for the play, pause and stop buttons

        private void PlayB1_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid1.mp4");
            mp.URL = path;
            mp.settings.autoStart = true;
        }

        private void PauseB1_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.pause();
        }

        private void RestartB1_Click(object sender, EventArgs e)
        {
            mp.Ctlcontrols.stop();
        }

        private void PlayB2_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath (@"..\..\..\..\\Videos\Vid2.mp4");
            mp2.URL = path;
            mp2.settings.autoStart = true;
        }

        private void PauseB2_Click(object sender, EventArgs e)
        {
            mp2.Ctlcontrols.pause();
        }

        private void RestarB2_Click(object sender, EventArgs e)
        {
            mp2.Ctlcontrols.stop();
        }

        private void PlayB3_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid3.mp4");
            mp3.URL = path;
            mp.settings.autoStart = true;
        }

        private void PlayB4_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid4.mp4");
            mp4.URL = path;
            mp.settings.autoStart = true;
        }

        private void PauseB3_Click(object sender, EventArgs e)
        {
            mp3.Ctlcontrols.pause();
        }

        private void RestartB3_Click(object sender, EventArgs e)
        {
            mp3.Ctlcontrols.stop();
        }

        private void PauseB4_Click(object sender, EventArgs e)
        {
            mp4.Ctlcontrols.pause();
        }

        private void RestartB4_Click(object sender, EventArgs e)
        {
            mp4.Ctlcontrols.stop();
        }

        private void mp_Enter(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer4_Enter(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid1.mp4");
            wmp.URL = path;
            wmp.settings.autoStart = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.pause();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.stop();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Vid2.mp4");
            wmp2.URL = path;
            wmp2.settings.autoStart = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            wmp2.Ctlcontrols.pause();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            wmp2.Ctlcontrols.stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid3.mp4");
            wmp3.URL = path;
            wmp.settings.autoStart = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(@"..\..\..\..\\Videos\Vid4.mp4");
            wmp4.URL = path;
            wmp.settings.autoStart = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            wmp3.Ctlcontrols.pause();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wmp3.Ctlcontrols.stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wmp4.Ctlcontrols.pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wmp4.Ctlcontrols.stop();
        }

        private void axWindowsMediaPlayer4_Enter_1(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void frmVideos_Load(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage2)
            {
                wmp.Ctlcontrols.stop();
                wmp2.Ctlcontrols.stop();
                wmp3.Ctlcontrols.stop();
                wmp4.Ctlcontrols.stop();
            }

            

        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            
            
        }


        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
