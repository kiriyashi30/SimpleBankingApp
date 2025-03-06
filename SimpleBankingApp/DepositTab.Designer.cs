namespace SimpleBankingApp
{
    partial class DepositTab
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
            DepositTabLabel = new Label();
            DepositTabButton = new Button();
            DepositTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            DepositBack = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.GhostWhite;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.2331238F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.4335423F));
            tableLayoutPanel1.Controls.Add(DepositTabLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(DepositTabButton, 1, 2);
            tableLayoutPanel1.Controls.Add(DepositTextBox, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1437, 570);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // DepositTabLabel
            // 
            DepositTabLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DepositTabLabel.AutoSize = true;
            DepositTabLabel.Font = new Font("Arial Rounded MT Bold", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            DepositTabLabel.ForeColor = SystemColors.ActiveCaptionText;
            DepositTabLabel.Location = new Point(482, 79);
            DepositTabLabel.Name = "DepositTabLabel";
            DepositTabLabel.Size = new Size(644, 32);
            DepositTabLabel.TabIndex = 11;
            DepositTabLabel.Text = "Deposit Amount";
            DepositTabLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DepositTabButton
            // 
            DepositTabButton.Anchor = AnchorStyles.None;
            DepositTabButton.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            DepositTabButton.Location = new Point(686, 435);
            DepositTabButton.Name = "DepositTabButton";
            DepositTabButton.Size = new Size(236, 79);
            DepositTabButton.TabIndex = 11;
            DepositTabButton.Text = "Deposit";
            DepositTabButton.UseVisualStyleBackColor = true;
            DepositTabButton.Click += DepositTabButton_Click;
            // 
            // DepositTextBox
            // 
            DepositTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DepositTextBox.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DepositTextBox.Location = new Point(482, 267);
            DepositTextBox.Name = "DepositTextBox";
            DepositTextBox.PlaceholderText = "₱ 0.00";
            DepositTextBox.Size = new Size(644, 35);
            DepositTextBox.TabIndex = 12;
            DepositTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.MidnightBlue;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(label3, 0, 0);
            tableLayoutPanel4.Controls.Add(DepositBack, 0, 1);
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
            tableLayoutPanel4.Size = new Size(217, 570);
            tableLayoutPanel4.TabIndex = 17;
            // 
            // DepositBack
            // 
            DepositBack.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DepositBack.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point);
            DepositBack.Location = new Point(3, 122);
            DepositBack.Name = "DepositBack";
            DepositBack.Size = new Size(211, 40);
            DepositBack.TabIndex = 3;
            DepositBack.Text = "Back";
            DepositBack.UseVisualStyleBackColor = true;
            DepositBack.Click += DepositBack_Click;
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
            // DepositTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 570);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel1);
            Name = "DepositTab";
            Text = "DepositTab";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label DepositTabLabel;
        private Button DepositTabButton;
        private TextBox DepositTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Button DepositBack;
        private Label label3;
    }
}