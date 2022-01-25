using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anon_Antivirus_v1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked) fullScanPage1.BringToFront();
        }

        private void siticoneHtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            if(siticoneButton1.Checked) quickScanPage1.BringToFront();
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked) customScanPage1.BringToFront();
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked) threatsPage1.BringToFront();
        }

        private void siticoneButton5_Click(object sender, EventArgs e)
        {
            if (siticoneButton5.Checked) aboutPage1.BringToFront();
        }

        private void siticoneButton5_Click_1(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
