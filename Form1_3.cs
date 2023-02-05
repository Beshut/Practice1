using System;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Практическая_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst.SelectedItem == "чёрный")
            {
                txt.BackColor = System.Drawing.Color.Black;
            }
            else if (lst.SelectedItem == "красный")
            {
                txt.BackColor = System.Drawing.Color.Red;
            }
            else if (lst.SelectedItem == "синий")
            {
                txt.BackColor = System.Drawing.Color.Blue;
            }
            else if (lst.SelectedItem == "зелёный")
            {
                txt.BackColor = System.Drawing.Color.Green;
            }
        }
        private void bthExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
