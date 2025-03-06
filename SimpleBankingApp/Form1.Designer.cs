namespace SimpleBankingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private string ShowInputDialog(string title, string prompt)
        {
            Form inputForm = new Form();
            inputForm.Text = title;
            inputForm.Size = new Size(300, 150);
            inputForm.StartPosition = FormStartPosition.CenterParent;

            Label label = new Label() { Text = prompt, Left = 10, Top = 10, Width = 260 };
            TextBox textBox = new TextBox() { Left = 10, Top = 35, Width = 260 };
            Button confirmButton = new Button() { Text = "OK", Left = 190, Width = 80, Top = 65, DialogResult = DialogResult.OK };

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(confirmButton);
            inputForm.AcceptButton = confirmButton;

            return inputForm.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            Login = new Button();
            label3 = new Label();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            createAccountLink = new LinkLabel();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Azure;
            txtUsername.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = SystemColors.InfoText;
            txtUsername.Location = new Point(67, 252);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(407, 29);
            txtUsername.TabIndex = 0;
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Azure;
            txtPassword.Font = new Font("Arial", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = SystemColors.InfoText;
            txtPassword.Location = new Point(67, 299);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(407, 29);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            Login.BackColor = Color.DodgerBlue;
            Login.FlatStyle = FlatStyle.Popup;
            Login.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.WhiteSmoke;
            Login.Location = new Point(152, 448);
            Login.Name = "Login";
            Login.Size = new Size(237, 48);
            Login.TabIndex = 2;
            Login.Text = "LOG IN";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(193, 64);
            label3.Name = "label3";
            label3.Size = new Size(154, 55);
            label3.TabIndex = 8;
            label3.Text = "Login";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(createAccountLink);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(Login);
            panel1.Location = new Point(909, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 587);
            panel1.TabIndex = 9;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(347, 331);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(127, 15);
            linkLabel1.TabIndex = 14;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your Password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // createAccountLink
            // 
            createAccountLink.AutoSize = true;
            createAccountLink.Location = new Point(299, 507);
            createAccountLink.Name = "createAccountLink";
            createAccountLink.Size = new Size(48, 15);
            createAccountLink.TabIndex = 12;
            createAccountLink.TabStop = true;
            createAccountLink.Text = "Sign Up";
            createAccountLink.LinkClicked += createAccountLink_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(173, 508);
            label5.Name = "label5";
            label5.Size = new Size(127, 14);
            label5.TabIndex = 10;
            label5.Text = "Don't have an account?";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1440, 584);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button Login;
        private Label label3;
        private Panel panel1;
        private Label label5;
        private LinkLabel createAccountLink;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
    }
}