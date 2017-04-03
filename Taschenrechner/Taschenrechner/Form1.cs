using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rechnerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNull_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("0");
        }

        private void buttonEins_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("1");
        }

        private void buttonZwei_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("2");
        }

        private void buttonDrei_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("3");
        }

        private void buttonVier_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("4");
        }

        private void buttonFünf_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("5");
        }

        private void buttonSechs_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("6");
        }

        private void buttonSieben_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("7");
        }

        private void buttonAcht_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("8");
        }

        private void buttonNeun_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("9");        
        }

        private void einLöschenButton_Click(object sender, EventArgs e)
        {
            if (rechnerTextBox.TextLength > 0)
            {
               rechnerTextBox.Text= rechnerTextBox.Text.Remove(rechnerTextBox.Text.Length -1, 1);
            }
        }
    }
}
