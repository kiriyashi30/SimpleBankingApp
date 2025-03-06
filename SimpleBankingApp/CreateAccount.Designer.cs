namespace SimpleBankingApp
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            txtUsernameSignUp = new TextBox();
            txtPasswordSignUp = new TextBox();
            pictureBox1 = new PictureBox();
            BackSignUp = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.AutoSize = true;
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(BackSignUp);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsernameSignUp);
            panel1.Controls.Add(txtPasswordSignUp);
            panel1.Location = new Point(901, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(534, 572);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(142, 412);
            button1.Name = "button1";
            button1.Size = new Size(237, 48);
            button1.TabIndex = 9;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(173, 62);
            label3.Name = "label3";
            label3.Size = new Size(206, 55);
            label3.TabIndex = 8;
            label3.Text = "Sign Up";
            // 
            // txtUsernameSignUp
            // 
            txtUsernameSignUp.BackColor = Color.Azure;
            txtUsernameSignUp.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsernameSignUp.ForeColor = SystemColors.ScrollBar;
            txtUsernameSignUp.Location = new Point(62, 253);
            txtUsernameSignUp.Name = "txtUsernameSignUp";
            txtUsernameSignUp.PlaceholderText = "Username";
            txtUsernameSignUp.Size = new Size(407, 35);
            txtUsernameSignUp.TabIndex = 0;
            txtUsernameSignUp.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPasswordSignUp
            // 
            txtPasswordSignUp.BackColor = Color.Azure;
            txtPasswordSignUp.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPasswordSignUp.ForeColor = SystemColors.ScrollBar;
            txtPasswordSignUp.Location = new Point(62, 305);
            txtPasswordSignUp.Name = "txtPasswordSignUp";
            txtPasswordSignUp.PlaceholderText = "Password";
            txtPasswordSignUp.Size = new Size(407, 35);
            txtPasswordSignUp.TabIndex = 1;
            txtPasswordSignUp.TextAlign = HorizontalAlignment.Center;
            txtPasswordSignUp.UseSystemPasswordChar = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(117, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(550, 439);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // BackSignUp
            // 
            BackSignUp.BackColor = Color.DodgerBlue;
            BackSignUp.FlatStyle = FlatStyle.Popup;
            BackSignUp.Font = new Font("Arial", 10.125F, FontStyle.Bold, GraphicsUnit.Point);
            BackSignUp.ForeColor = Color.WhiteSmoke;
            BackSignUp.Location = new Point(173, 466);
            BackSignUp.Name = "BackSignUp";
            BackSignUp.Size = new Size(175, 48);
            BackSignUp.TabIndex = 10;
            BackSignUp.Text = "Back";
            BackSignUp.UseVisualStyleBackColor = false;
            BackSignUp.Click += BackSignUp_Click;
            // 
            // CreateAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1435, 572);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "CreateAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAccount";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private Label label3;
        private TextBox txtUsernameSignUp;
        private TextBox txtPasswordSignUp;
        private PictureBox pictureBox1;
        private Button button1;
        private Button BackSignUp;
    }
}