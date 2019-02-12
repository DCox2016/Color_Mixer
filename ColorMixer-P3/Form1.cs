using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer_P3
{
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void ColorForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            if (redButton1.Checked && redButton2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (redButton1.Checked && blueButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (redButton1.Checked && yellowButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blueButton1.Checked && redButton2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blueButton1.Checked && blueButton2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if ( blueButton1.Checked && yellowButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if ( yellowButton1.Checked && redButton2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if ( yellowButton1.Checked && blueButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if ( yellowButton1.Checked && yellowButton2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
        }

    }
}
