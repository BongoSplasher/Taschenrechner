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

        private void buttonZwei_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("2");
        }

        private void buttonVier_Click(object sender, EventArgs e)
        {
            rechnerTextBox.AppendText("4");
        }

        private void buttonAcht_Click(object sender, EventArgs e)
        {

        }
    }
}
