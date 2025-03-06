namespace SimpleBankingApp
{
    partial class BankingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankingForm));
            Deposit = new Button();
            Withdraw = new Button();
            Back = new Button();
            lblWelcome = new Label();
            panel1 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            toggleViewLabel = new PictureBox();
            textBox2 = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            WithdrawalButton2 = new Button();
            DepositButton2 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)toggleViewLabel).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // Deposit
            // 
            Deposit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Deposit.Location = new Point(3, 110);
            Deposit.Name = "Deposit";
            Deposit.Size = new Size(211, 58);
            Deposit.TabIndex = 0;
            Deposit.Text = "Deposit";
            Deposit.UseVisualStyleBackColor = true;
            Deposit.Click += Deposit_Click;
            // 
            // Withdraw
            // 
            Withdraw.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Withdraw.Location = new Point(3, 203);
            Withdraw.Name = "Withdraw";
            Withdraw.Size = new Size(211, 58);
            Withdraw.TabIndex = 1;
            Withdraw.Text = "Withdraw";
            Withdraw.UseVisualStyleBackColor = true;
            Withdraw.Click += Withdraw_Click;
            // 
            // Back
            // 
            Back.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Back.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            Back.Location = new Point(3, 494);
            Back.Name = "Back";
            Back.Size = new Size(211, 40);
            Back.TabIndex = 3;
            Back.Text = "Log Out";
            Back.UseVisualStyleBackColor = true;
            Back.Click += logOutButton_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.Anchor = AnchorStyles.Left;
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = SystemColors.ButtonHighlight;
            lblWelcome.Location = new Point(3, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(240, 55);
            lblWelcome.TabIndex = 5;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.MidnightBlue;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(221, 567);
            panel1.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(Back, 0, 5);
            tableLayoutPanel4.Controls.Add(Withdraw, 0, 2);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(Deposit, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Size = new Size(217, 563);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 30);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 10;
            label3.Text = "Menu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(10, 75);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 8;
            label2.Text = "My Account";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.2622948F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.5456676F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.8337231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.2026358F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(lblWelcome, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Location = new Point(221, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 57.2973F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 42.7027F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(854, 185);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(toggleViewLabel, 1, 0);
            tableLayoutPanel3.Controls.Add(textBox2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 109);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(568, 73);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // toggleViewLabel
            // 
            toggleViewLabel.Anchor = AnchorStyles.Left;
            toggleViewLabel.Image = (Image)resources.GetObject("toggleViewLabel.Image");
            toggleViewLabel.Location = new Point(500, 11);
            toggleViewLabel.Name = "toggleViewLabel";
            toggleViewLabel.Size = new Size(64, 51);
            toggleViewLabel.SizeMode = PictureBoxSizeMode.Zoom;
            toggleViewLabel.TabIndex = 12;
            toggleViewLabel.TabStop = false;
            toggleViewLabel.MouseClick += toggleViewLabel_MouseClick;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBox2.BackColor = SystemColors.MenuHighlight;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(3, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(491, 31);
            textBox2.TabIndex = 10;
            textBox2.Text = "Current Balance:";
            textBox2.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel5.Controls.Add(label2, 0, 0);
            tableLayoutPanel5.Location = new Point(1074, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(361, 183);
            tableLayoutPanel5.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(183, 66);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanel1.Controls.Add(WithdrawalButton2, 2, 1);
            tableLayoutPanel1.Controls.Add(DepositButton2, 1, 1);
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(221, 188);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.201058F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 83.8624344F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.9365077F));
            tableLayoutPanel1.Size = new Size(1214, 379);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // WithdrawalButton2
            // 
            WithdrawalButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            WithdrawalButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            WithdrawalButton2.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawalButton2.Location = new Point(609, 34);
            WithdrawalButton2.Name = "WithdrawalButton2";
            WithdrawalButton2.Size = new Size(516, 311);
            WithdrawalButton2.TabIndex = 5;
            WithdrawalButton2.Text = "Withdraw";
            WithdrawalButton2.UseVisualStyleBackColor = true;
            WithdrawalButton2.Click += WithdrawalButton2_Click;
            // 
            // DepositButton2
            // 
            DepositButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DepositButton2.Font = new Font("Arial", 19.875F, FontStyle.Bold, GraphicsUnit.Point);
            DepositButton2.Location = new Point(87, 34);
            DepositButton2.Name = "DepositButton2";
            DepositButton2.Size = new Size(516, 311);
            DepositButton2.TabIndex = 4;
            DepositButton2.Text = "Deposit";
            DepositButton2.UseVisualStyleBackColor = true;
            DepositButton2.Click += DepositButton2_Click;
            // 
            // BankingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1435, 567);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(panel1);
            Name = "BankingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BankingForm";
            WindowState = FormWindowState.Maximized;
            Load += BankingForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)toggleViewLabel).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Button Deposit;
        private Button Withdraw;
        private Button Back;
        private Label lblWelcome;
        private Label textBox1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox toggleViewLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel1;
        private Button WithdrawalButton2;
        private Button DepositButton2;
        private PictureBox pictureBox2;
        private TextBox textBox2;
    }
}