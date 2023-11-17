using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonExit1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonInfo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is simple game from team: Coder'sCheer.\nDeveloped by:\nID63374, ID63274, ID63513", "INFO", MessageBoxButtons.OK);
        }

        private void buttonAddDonor1_Click(object sender, EventArgs e)
        {
            Fillout fi = new Fillout();
            fi.ShowDialog();
        }

        private void buttonShowRecords1_Click(object sender, EventArgs e)
        {
            Records re = new Records();
            re.ShowDialog();
        }
    }
}
