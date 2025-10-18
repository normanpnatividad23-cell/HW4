using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace SimCardRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string selectedImagePath = "";

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = open.FileName;
                pictureBox.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string sex = rbMale.Checked ? "Male" : "Female";

            Form2 displayForm = new Form2(
                txtMobile.Text,
                txtFirstname.Text,
                txtLastname.Text,
                sex,
                txtStatus.Text,
                dtpBirthday.Value,
                txtLocation.Text,
                selectedImagePath
            );

            displayForm.Show();
        }
    }
}
