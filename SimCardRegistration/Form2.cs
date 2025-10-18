using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimCardRegistration
{
    public partial class Form2 : Form
    {
        public Form2(string mobile, string firstname, string lastname, string sex, string status, DateTime birthday, string location, string imagePath)
        {
            InitializeComponent();

            lblMobile.Text = mobile;
            lblFirstname.Text = firstname;
            lblLastname.Text = lastname;
            lblSex.Text = sex;
            lblStatus.Text = status;
            lblBirthday.Text = birthday.ToShortDateString();
            lblLocation.Text = location;

            if (!string.IsNullOrEmpty(imagePath))
                pictureBox.Image = Image.FromFile(imagePath);
        }
    }
}
