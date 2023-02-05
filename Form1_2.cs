using System;
using System.Windows.Forms;

namespace Практическая_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int per = 4 * Int32.Parse(txtA.Text);
            Perimetr.Text = per.ToString();
        }

        private void bthCount2_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            Perimetr.Clear();
        }
    }
}
