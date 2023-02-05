using System;
using System.Windows.Forms;

namespace Практическая_1
{
    public partial class frmSumma : Form
    {
        public frmSumma()
        {
            InitializeComponent();
        }

        private void bthExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bthCount_Click(object sender, EventArgs e)
        {
            int summa = Int32.Parse(txtA.Text) + Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
            txtSumma.Text = summa.ToString();
        }

        private void txtA_Click(object sender, EventArgs e)
        {
            txtA.Clear();
        }

        private void txtB_Click(object sender, EventArgs e)
        {
            txtB.Clear();
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            txtC.Clear();
        }
    }
}
