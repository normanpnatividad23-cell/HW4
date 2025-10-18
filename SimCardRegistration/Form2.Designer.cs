namespace SimCardRegistration
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle, lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation;
        private PictureBox pictureBox;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.lblMobile = new Label();
            this.lblFirstname = new Label();
            this.lblLastname = new Label();
            this.lblSex = new Label();
            this.lblStatus = new Label();
            this.lblBirthday = new Label();
            this.lblLocation = new Label();
            this.pictureBox = new PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();

            // Form2
            this.ClientSize = new Size(500, 320);
            this.Text = "Registration Details";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Title
            this.lblTitle.Text = "SIM CARD REGISTRATION DETAILS";
            this.lblTitle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            this.lblTitle.Location = new Point(90, 20);
            this.lblTitle.AutoSize = true;

            int y = 70;
            Label[] labels = { lblMobile, lblFirstname, lblLastname, lblSex, lblStatus, lblBirthday, lblLocation };
            string[] titles = { "Mobile:", "Firstname:", "Lastname:", "Sex:", "Status:", "Birthday:", "Location:" };

            for (int i = 0; i < labels.Length; i++)
            {
                Label title = new Label
                {
                    Text = titles[i],
                    Location = new Point(40, y),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10, FontStyle.Bold)
                };
                this.Controls.Add(title);

                labels[i].Location = new Point(150, y);
                labels[i].Font = new Font("Segoe UI", 10, FontStyle.Regular);
                labels[i].AutoSize = true;
                y += 30;
            }

            // PictureBox
            this.pictureBox.Location = new Point(350, 70);
            this.pictureBox.Size = new Size(120, 120);
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(this.lblTitle);
            this.Controls.AddRange(labels);
            this.Controls.Add(this.pictureBox);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
