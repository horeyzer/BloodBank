using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank
{
    public partial class Records : Form
    {
        pictureloger pic = new pictureloger();
        private int currentLineIndex = 0;
        private string[] lines;
        public int count = 1;
        public Records()
        {
            InitializeComponent();
        }
        public class pictureloger
        {
            private List<string> strings;

            public pictureloger()
            {
                strings = new List<string>();
            }

            public void Logpic(string str)
            {
                strings.Add(str);
            }

            public void Delpic()
            {
                foreach (string str in strings)
                {
                    File.Delete("photo_" + str + ".jpg");
                }
            }
        }
        private void ReadAndFillLabels()
        {
            string[] parts = lines[currentLineIndex].Split(';');

            if (parts.Length >= 8)
            {
                labelID2.Text = parts[0];
                labelName2.Text = parts[1];
                labelSurname2.Text = parts[2];
                labelSocialID2.Text = parts[3];
                labelPhoneNumber2.Text = parts[4];
                labelEmail2.Text = parts[5];
                labelBloodType2.Text = parts[6];
                labelDonationDate2.Text = parts[7];
                pictureBox1.Image = Image.FromFile("photo_" + labelID2.Text + ".jpg");
            }
        }
        
        private void buttonBackToMainMenu1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void resetLabels()
        {
            labelID2.Text = "";
            labelName2.Text = "";
            labelSurname2.Text = "";
            labelSocialID2.Text = "";
            labelPhoneNumber2.Text = "";
            labelEmail2.Text = "";
            labelBloodType2.Text = "";
            labelDonationDate2.Text = "";
        }

        private void Records_Load(object sender, EventArgs e)
        {
            string filePath = "donor_data.txt";
            lines = File.ReadAllLines(filePath);

            if (lines.Length > 0)
            {
                ReadAndFillLabels();
                label2.Text = lines.Length.ToString();
            }
            else
            {
                MessageBox.Show("No more donors.");
            }
            label1.Text = count.ToString();
            buttonLeft1.Enabled = false;
            if (Convert.ToInt32(label2.Text) <= 1) buttonRight1.Enabled = false;
        }
        private void Check()
        {
            if (Convert.ToInt32(label1.Text) <= 1)
            {
                buttonLeft1.Enabled = false;
            }
            if (label1.Text == label2.Text)
            {
                buttonRight1.Enabled = false;
            }
            else
            {
                buttonLeft1.Enabled = true;
                buttonRight1.Enabled = true;
            }
        }

        private void buttonLeft1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label1.Text) > 1)
            {

                resetLabels();
                currentLineIndex--;
                count--;
                label1.Text = count.ToString();
                if (count == 1)
                {
                    buttonLeft1.Enabled = false;
                }
                if (currentLineIndex < lines.Length)
                {
                    ReadAndFillLabels();
                }
                else
                {
                    MessageBox.Show("This is the start of the list.");
                    currentLineIndex = lines.Length - 1;
                }
                Check();
            }
            if (Convert.ToInt32(label1.Text) <= 1)
            {
                buttonLeft1.Enabled = false;
            }
        }

        private void buttonRight1_Click(object sender, EventArgs e)
        {
            resetLabels();
            currentLineIndex++;
            count++;
            label1.Text = count.ToString();
            if (count == lines.Length)
            {
                buttonLeft1.Enabled = true;
                buttonRight1.Enabled = false;
            }
            if (currentLineIndex < lines.Length)
            {
                ReadAndFillLabels();
            }
            else
            {
                MessageBox.Show("No more donors.");
                currentLineIndex = lines.Length - 1;
            }
            Check();
        }

        private void buttonDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                string namepicdel = labelID2.Text;
                pic.Logpic(namepicdel);
                string[] lines2 = File.ReadAllLines("donor_data.txt");
                lines2 = lines2.Where((line, index) => index != currentLineIndex).ToArray();
                File.WriteAllLines("donor_data.txt", lines2);
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                if (Convert.ToInt32(label1.Text) > 1)
                {
                    Check();
                    resetLabels();
                    currentLineIndex--;
                    count--;
                    label1.Text = count.ToString();
                    if (count == 1)
                    {
                        buttonLeft1.Enabled = false;
                    }
                    if (currentLineIndex < lines.Length)
                    {
                        ReadAndFillLabels();
                    }
                    else
                    {
                        MessageBox.Show("This is the start of the list.");
                        currentLineIndex = lines.Length - 1;
                    }
                }
                if (Convert.ToInt32(label1.Text) == 1)
                {
                    Check();
                    resetLabels();
                    string filePath = "donor_data.txt";
                    lines = File.ReadAllLines(filePath);

                    if (lines.Length > 0)
                    {
                        ReadAndFillLabels();
                        label2.Text = lines.Length.ToString();
                    }
                    else
                    {
                        MessageBox.Show("No more donor.");
                    }
                    label1.Text = count.ToString();
                    buttonLeft1.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("No more donors to delete.");
            }
        }
    }  
}
