using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Blood_Bank
{
    public partial class Fillout : Form
    {
        public Fillout()
        {
            InitializeComponent();
        }

        private List<int> usedIds = new List<int>();
        private string dataFilePath = "donor_data.txt";

        private void Fillout_Load_1(object sender, EventArgs e)
        {
            LoadUsedIds();
            ShowCurrentDate();
        }
        private void ShowCurrentDate()
        {
            labelDateOfDonation2.Text = DateTime.Now.ToString("dddd, MMM dd yyyy, hh:mm:ss");
        }

        private void LoadUsedIds()
        {
            if (File.Exists(dataFilePath))
            {
                string[] lines = File.ReadAllLines(dataFilePath);

                foreach (string line in lines)
                {
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        string[] parts = line.Split(',');
                        int id = int.Parse(parts[0]);
                        usedIds.Add(id);
                    }
                }
            }
        }
        private int GenerateUniqueId()
        {
            Random r = new Random();

            int startId = 1000;
            int endId = 9999;

            while (true)
            {
                int uniqueId = r.Next(startId, endId);

                if (!usedIds.Contains(uniqueId))
                {
                    usedIds.Add(uniqueId);
                    return uniqueId;
                }
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

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            try
            {
                int uniqueId = GenerateUniqueId();

                DateTime dateOfDonation = DateTime.Now;
                string name = textBoxName1.Text.Trim();
                string surname = textBoxSurname1.Text.Trim();
                string socialId = textBoxSocialID1.Text.Trim();
                string phoneNumber = textBoxPhoneNumber1.Text.Trim();
                string email = textBoxEmail1.Text.Trim();
                string bloodType = comboBoxBloodType1.SelectedItem.ToString();

                string dataLine = $"{uniqueId};{dateOfDonation:dddd, MMM dd yyyy, hh:mm:ss};{name};{surname};{socialId};{phoneNumber};{email};{bloodType}";
                File.AppendAllText(dataFilePath, dataLine + Environment.NewLine);

                string photoFileName = $"photo_{uniqueId}.jpg";
                string appPath = Path.GetDirectoryName(Application.ExecutablePath);
                string photoPath = Path.Combine(appPath, photoFileName);
                pictureBox1.Image.Save(photoPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                this.Close();

                MessageBox.Show("Donor information saved successfully.");
            }
            catch
            {
                MessageBox.Show("Not all required information was given.");
            }
        }

        private void buttonAddPhoto1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Img = new OpenFileDialog();
            Img.Filter = "Image Files (*.jpg; *jpeg)|*.jpg;*.jpeg";
            Img.Title = "Select an image";

            if (Img.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = Img.FileName;
                pictureBox1.Image = Image.FromFile(selectedFileName);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
