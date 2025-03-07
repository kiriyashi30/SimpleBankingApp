namespace SimpleBankingApp
{
    partial class BankingFormAccount
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            AccountBack = new Button();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBoxPurpose = new TextBox();
            textBoxName = new TextBox();
            textBoxDate = new TextBox();
            textBoxTime = new TextBox();
            textBoxAmount = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(217, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(1218, 251);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(525, 15);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 20;
            label2.Text = "My Account";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(559, 92);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 24;
            label1.Text = "Money";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BackColor = Color.GhostWhite;
            label4.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(87, 202);
            label4.Name = "label4";
            label4.Size = new Size(231, 32);
            label4.TabIndex = 22;
            label4.Text = "Account number";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(504, 205);
            label5.Name = "label5";
            label5.Size = new Size(209, 27);
            label5.TabIndex = 23;
            label5.Text = "Account number #";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.MidnightBlue;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(AccountBack, 0, 1);
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
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
            tableLayoutPanel4.Size = new Size(217, 569);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // AccountBack
            // 
            AccountBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AccountBack.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            AccountBack.Location = new Point(3, 121);
            AccountBack.Name = "AccountBack";
            AccountBack.Size = new Size(211, 40);
            AccountBack.TabIndex = 11;
            AccountBack.Text = "Back";
            AccountBack.UseVisualStyleBackColor = true;
            AccountBack.Click += AccountBack_Click;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.PaleTurquoise;
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(label6, 2, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(label8, 1, 1);
            tableLayoutPanel2.Controls.Add(label9, 2, 1);
            tableLayoutPanel2.Controls.Add(label10, 3, 1);
            tableLayoutPanel2.Controls.Add(label11, 4, 1);
            tableLayoutPanel2.Controls.Add(textBoxPurpose, 0, 2);
            tableLayoutPanel2.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanel2.Controls.Add(textBoxDate, 2, 2);
            tableLayoutPanel2.Controls.Add(textBoxTime, 3, 2);
            tableLayoutPanel2.Controls.Add(textBoxAmount, 4, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(217, 251);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2362871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2362871F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 75.52743F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1218, 318);
            tableLayoutPanel2.TabIndex = 20;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.BackColor = Color.PaleTurquoise;
            label6.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(522, 0);
            label6.Name = "label6";
            label6.Size = new Size(171, 32);
            label6.TabIndex = 25;
            label6.Text = "Transaction";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.BackColor = Color.PaleTurquoise;
            label7.Font = new Font("Arial Rounded MT Bold", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(70, 38);
            label7.Name = "label7";
            label7.Size = new Size(102, 26);
            label7.TabIndex = 26;
            label7.Text = "Purpose";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.BackColor = Color.PaleTurquoise;
            label8.Font = new Font("Arial Rounded MT Bold", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(327, 38);
            label8.Name = "label8";
            label8.Size = new Size(74, 26);
            label8.TabIndex = 27;
            label8.Text = "Name";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top;
            label9.AutoSize = true;
            label9.BackColor = Color.PaleTurquoise;
            label9.Font = new Font("Arial Rounded MT Bold", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(576, 38);
            label9.Name = "label9";
            label9.Size = new Size(62, 26);
            label9.TabIndex = 28;
            label9.Text = "Date";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top;
            label10.AutoSize = true;
            label10.BackColor = Color.PaleTurquoise;
            label10.Font = new Font("Arial Rounded MT Bold", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(818, 38);
            label10.Name = "label10";
            label10.Size = new Size(64, 26);
            label10.TabIndex = 29;
            label10.Text = "Time";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top;
            label11.AutoSize = true;
            label11.BackColor = Color.PaleTurquoise;
            label11.Font = new Font("Arial Rounded MT Bold", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ActiveCaptionText;
            label11.Location = new Point(1048, 38);
            label11.Name = "label11";
            label11.Size = new Size(94, 26);
            label11.TabIndex = 30;
            label11.Text = "Amount";
            // 
            // textBoxPurpose
            // 
            textBoxPurpose.BackColor = Color.PaleTurquoise;
            textBoxPurpose.BorderStyle = BorderStyle.None;
            textBoxPurpose.Dock = DockStyle.Fill;
            textBoxPurpose.Location = new Point(3, 79);
            textBoxPurpose.Multiline = true;
            textBoxPurpose.Name = "textBoxPurpose";
            textBoxPurpose.ReadOnly = true;
            textBoxPurpose.ScrollBars = ScrollBars.Vertical;
            textBoxPurpose.Size = new Size(237, 236);
            textBoxPurpose.TabIndex = 31;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.PaleTurquoise;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Dock = DockStyle.Fill;
            textBoxName.Location = new Point(246, 79);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.ScrollBars = ScrollBars.Vertical;
            textBoxName.Size = new Size(237, 236);
            textBoxName.TabIndex = 32;
            // 
            // textBoxDate
            // 
            textBoxDate.BackColor = Color.PaleTurquoise;
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Dock = DockStyle.Fill;
            textBoxDate.Location = new Point(489, 79);
            textBoxDate.Multiline = true;
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.ScrollBars = ScrollBars.Vertical;
            textBoxDate.Size = new Size(237, 236);
            textBoxDate.TabIndex = 33;
            // 
            // textBoxTime
            // 
            textBoxTime.BackColor = Color.PaleTurquoise;
            textBoxTime.BorderStyle = BorderStyle.None;
            textBoxTime.Dock = DockStyle.Fill;
            textBoxTime.Location = new Point(732, 79);
            textBoxTime.Multiline = true;
            textBoxTime.Name = "textBoxTime";
            textBoxTime.ReadOnly = true;
            textBoxTime.ScrollBars = ScrollBars.Vertical;
            textBoxTime.Size = new Size(237, 236);
            textBoxTime.TabIndex = 34;
            // 
            // textBoxAmount
            // 
            textBoxAmount.BackColor = Color.PaleTurquoise;
            textBoxAmount.BorderStyle = BorderStyle.None;
            textBoxAmount.Dock = DockStyle.Fill;
            textBoxAmount.Location = new Point(975, 79);
            textBoxAmount.Multiline = true;
            textBoxAmount.Name = "textBoxAmount";
            textBoxAmount.ReadOnly = true;
            textBoxAmount.ScrollBars = ScrollBars.Vertical;
            textBoxAmount.Size = new Size(240, 236);
            textBoxAmount.TabIndex = 35;
            // 
            // BankingFormAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 569);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel4);
            Name = "BankingFormAccount";
            Text = "BankingFormAccount";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label6;
        private Button AccountBack;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBoxPurpose;
        private TextBox textBoxName;
        private TextBox textBoxDate;
        private TextBox textBoxTime;
        private TextBox textBoxAmount;
    }
}