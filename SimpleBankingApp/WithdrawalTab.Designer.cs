namespace SimpleBankingApp
{
    partial class WithdrawalTab
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
            tableLayoutPanel4 = new TableLayoutPanel();
            label3 = new Label();
            WIthdrawalBack = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            WithdrawalTabLabel = new Label();
            WithdrawalTabButton = new Button();
            button1000 = new Button();
            button500 = new Button();
            button200 = new Button();
            button100 = new Button();
            WithdrawalTextBox = new TextBox();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.MidnightBlue;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(WIthdrawalBack, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Left;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Size = new Size(217, 575);
            tableLayoutPanel4.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 31);
            label3.Name = "label3";
            label3.Size = new Size(211, 32);
            label3.TabIndex = 10;
            label3.Text = "Menu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WIthdrawalBack
            // 
            WIthdrawalBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            WIthdrawalBack.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            WIthdrawalBack.Location = new Point(3, 122);
            WIthdrawalBack.Name = "WIthdrawalBack";
            WIthdrawalBack.Size = new Size(211, 40);
            WIthdrawalBack.TabIndex = 3;
            WIthdrawalBack.Text = "Back";
            WIthdrawalBack.UseVisualStyleBackColor = true;
            WIthdrawalBack.Click += WIthdrawalBack_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(WithdrawalTabLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(WithdrawalTabButton, 2, 4);
            tableLayoutPanel1.Controls.Add(button1000, 1, 1);
            tableLayoutPanel1.Controls.Add(button200, 3, 1);
            tableLayoutPanel1.Controls.Add(WithdrawalTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(button500, 1, 2);
            tableLayoutPanel1.Controls.Add(button100, 3, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(217, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1223, 575);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // WithdrawalTabLabel
            // 
            WithdrawalTabLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            WithdrawalTabLabel.AutoSize = true;
            WithdrawalTabLabel.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawalTabLabel.ForeColor = SystemColors.ActiveCaptionText;
            WithdrawalTabLabel.Location = new Point(491, 25);
            WithdrawalTabLabel.Name = "WithdrawalTabLabel";
            WithdrawalTabLabel.Size = new Size(238, 64);
            WithdrawalTabLabel.TabIndex = 11;
            WithdrawalTabLabel.Text = "Withdrawal Amount";
            WithdrawalTabLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WithdrawalTabButton
            // 
            WithdrawalTabButton.Anchor = AnchorStyles.None;
            WithdrawalTabButton.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawalTabButton.Location = new Point(491, 481);
            WithdrawalTabButton.Name = "WithdrawalTabButton";
            WithdrawalTabButton.Size = new Size(238, 72);
            WithdrawalTabButton.TabIndex = 11;
            WithdrawalTabButton.Text = "Withdrawal";
            WithdrawalTabButton.UseVisualStyleBackColor = true;
            WithdrawalTabButton.Click += WithdrawalTabButton_Click;
            // 
            // button1000
            // 
            button1000.Anchor = AnchorStyles.None;
            button1000.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button1000.Location = new Point(247, 129);
            button1000.Name = "button1000";
            button1000.Size = new Size(238, 86);
            button1000.TabIndex = 12;
            button1000.Text = "₱1000";
            button1000.UseVisualStyleBackColor = true;
            button1000.Click += button1000_Click;
            // 
            // button500
            // 
            button500.Anchor = AnchorStyles.None;
            button500.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button500.Location = new Point(247, 244);
            button500.Name = "button500";
            button500.Size = new Size(238, 86);
            button500.TabIndex = 13;
            button500.Text = "₱500";
            button500.UseVisualStyleBackColor = true;
            button500.Click += button500_Click;
            // 
            // button200
            // 
            button200.Anchor = AnchorStyles.None;
            button200.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button200.Location = new Point(735, 129);
            button200.Name = "button200";
            button200.Size = new Size(238, 86);
            button200.TabIndex = 14;
            button200.Text = "₱200";
            button200.UseVisualStyleBackColor = true;
            button200.Click += button200_Click;
            // 
            // button100
            // 
            button100.Anchor = AnchorStyles.None;
            button100.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            button100.Location = new Point(735, 244);
            button100.Name = "button100";
            button100.Size = new Size(238, 86);
            button100.TabIndex = 15;
            button100.Text = "₱100";
            button100.UseVisualStyleBackColor = true;
            button100.Click += button100_Click;
            // 
            // WithdrawalTextBox
            // 
            WithdrawalTextBox.Anchor = AnchorStyles.None;
            WithdrawalTextBox.Font = new Font("Arial", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawalTextBox.Location = new Point(491, 386);
            WithdrawalTextBox.Name = "WithdrawalTextBox";
            WithdrawalTextBox.ReadOnly = true;
            WithdrawalTextBox.Size = new Size(238, 32);
            WithdrawalTextBox.TabIndex = 18;
            WithdrawalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // WithdrawalTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 575);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Name = "WithdrawalTab";
            Text = "WithdrawalTab";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Button WIthdrawalBack;
        private TableLayoutPanel tableLayoutPanel1;
        private Label WithdrawalTabLabel;
        private Button WithdrawalTabButton;
        private Button button1000;
        private Button button500;
        private Button button200;
        private Button button100;
        private TextBox WithdrawalTextBox;
    }
}