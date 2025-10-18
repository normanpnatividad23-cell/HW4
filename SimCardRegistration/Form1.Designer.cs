namespace SimCardRegistration
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MaskedTextBox txtMobile;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtStatus;
        private DateTimePicker dtpBirthday;
        private TextBox txtLocation;
        private PictureBox pictureBox;
        private Button btnBrowse;
        private Button btnSubmit;
        private Label lblTitle;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private GroupBox grpSex;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtMobile = new MaskedTextBox();
            this.txtFirstname = new TextBox();
            this.txtLastname = new TextBox();
            this.txtStatus = new TextBox();
            this.dtpBirthday = new DateTimePicker();
            this.txtLocation = new TextBox();
            this.pictureBox = new PictureBox();
            this.btnBrowse = new Button();
            this.btnSubmit = new Button();
            this.lblTitle = new Label();
            this.rbMale = new RadioButton();
            this.rbFemale = new RadioButton();
            this.grpSex = new GroupBox();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.grpSex.SuspendLayout();
            this.SuspendLayout();

            // Form Properties
            this.ClientSize = new Size(600, 380);
            this.Text = "SIM CARD REGISTRATION";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.WhiteSmoke;

            // Title
            this.lblTitle.Text = "SIM CARD REGISTRATION";
            this.lblTitle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            this.lblTitle.Location = new Point(160, 20);
            this.lblTitle.AutoSize = true;

            // Mobile
            this.txtMobile.Mask = "0000-000-0000";
            this.txtMobile.Location = new Point(40, 70);
            this.txtMobile.Size = new Size(180, 25);

            // Browse Button
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Location = new Point(240, 70);
            this.btnBrowse.Size = new Size(80, 25);
            this.btnBrowse.Click += new EventHandler(this.btnBrowse_Click);

            // Firstname
            this.txtFirstname.PlaceholderText = "Firstname";
            this.txtFirstname.Location = new Point(40, 110);
            this.txtFirstname.Size = new Size(180, 25);

            // Lastname
            this.txtLastname.PlaceholderText = "Lastname";
            this.txtLastname.Location = new Point(240, 110);
            this.txtLastname.Size = new Size(180, 25);

            // GroupBox for Sex
            this.grpSex.Text = "Sex";
            this.grpSex.Location = new Point(40, 150);
            this.grpSex.Size = new Size(200, 50);

            this.rbMale.Text = "Male";
            this.rbMale.Location = new Point(15, 20);
            this.rbMale.AutoSize = true;

            this.rbFemale.Text = "Female";
            this.rbFemale.Location = new Point(90, 20);
            this.rbFemale.AutoSize = true;

            this.grpSex.Controls.Add(this.rbMale);
            this.grpSex.Controls.Add(this.rbFemale);

            // Status
            this.txtStatus.PlaceholderText = "Status";
            this.txtStatus.Location = new Point(260, 160);
            this.txtStatus.Size = new Size(160, 25);

            // Birthday
            this.dtpBirthday.Location = new Point(40, 210);
            this.dtpBirthday.Size = new Size(180, 25);

            // Location
            this.txtLocation.PlaceholderText = "Location";
            this.txtLocation.Location = new Point(40, 250);
            this.txtLocation.Size = new Size(380, 25);

            // PictureBox
            this.pictureBox.Location = new Point(440, 70);
            this.pictureBox.Size = new Size(120, 120);
            this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            // Submit Button
            this.btnSubmit.Text = "Submit Registration";
            this.btnSubmit.BackColor = Color.SteelBlue;
            this.btnSubmit.ForeColor = Color.White;
            this.btnSubmit.FlatStyle = FlatStyle.Flat;
            this.btnSubmit.Location = new Point(180, 300);
            this.btnSubmit.Size = new Size(180, 35);
            this.btnSubmit.Click += new EventHandler(this.btnSubmit_Click);

            // Add Controls
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.grpSex);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnSubmit);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.grpSex.ResumeLayout(false);
            this.grpSex.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
