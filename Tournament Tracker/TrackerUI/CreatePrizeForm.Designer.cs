namespace TrackerUI
{
    partial class CreatePrizeForm
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
            createPrizeLabel = new Label();
            placeNumberValue = new TextBox();
            placeNumberLabel = new Label();
            prizePercentageValue = new TextBox();
            prizePercentageLabel = new Label();
            prizeAmountValue = new TextBox();
            prizeAmountLabel = new Label();
            placeNameValue = new TextBox();
            placeNameLabel = new Label();
            orLabel = new Label();
            createPrizeButton = new Button();
            SuspendLayout();
            // 
            // createPrizeLabel
            // 
            createPrizeLabel.AutoSize = true;
            createPrizeLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createPrizeLabel.ForeColor = Color.FromArgb(51, 151, 255);
            createPrizeLabel.Location = new Point(38, 27);
            createPrizeLabel.Name = "createPrizeLabel";
            createPrizeLabel.Size = new Size(267, 62);
            createPrizeLabel.TabIndex = 12;
            createPrizeLabel.Text = "Create Prize";
            // 
            // placeNumberValue
            // 
            placeNumberValue.Location = new Point(286, 114);
            placeNumberValue.Name = "placeNumberValue";
            placeNumberValue.Size = new Size(214, 43);
            placeNumberValue.TabIndex = 24;
            placeNumberValue.Text = " ";
            placeNumberValue.TextChanged += placeNumberValue_TextChanged;
            // 
            // placeNumberLabel
            // 
            placeNumberLabel.AutoSize = true;
            placeNumberLabel.Font = new Font("Segoe UI", 18F);
            placeNumberLabel.ForeColor = Color.FromArgb(51, 151, 255);
            placeNumberLabel.Location = new Point(47, 116);
            placeNumberLabel.Name = "placeNumberLabel";
            placeNumberLabel.Size = new Size(204, 41);
            placeNumberLabel.TabIndex = 23;
            placeNumberLabel.Text = "Place Number";
            // 
            // prizePercentageValue
            // 
            prizePercentageValue.Location = new Point(286, 396);
            prizePercentageValue.Name = "prizePercentageValue";
            prizePercentageValue.Size = new Size(214, 43);
            prizePercentageValue.TabIndex = 26;
            prizePercentageValue.Text = " ";
            // 
            // prizePercentageLabel
            // 
            prizePercentageLabel.AutoSize = true;
            prizePercentageLabel.Font = new Font("Segoe UI", 18F);
            prizePercentageLabel.ForeColor = Color.FromArgb(51, 151, 255);
            prizePercentageLabel.Location = new Point(42, 398);
            prizePercentageLabel.Name = "prizePercentageLabel";
            prizePercentageLabel.Size = new Size(238, 41);
            prizePercentageLabel.TabIndex = 25;
            prizePercentageLabel.Text = "Prize Percentage";
            // 
            // prizeAmountValue
            // 
            prizeAmountValue.Location = new Point(286, 252);
            prizeAmountValue.Name = "prizeAmountValue";
            prizeAmountValue.Size = new Size(214, 43);
            prizeAmountValue.TabIndex = 28;
            prizeAmountValue.Text = " ";
            // 
            // prizeAmountLabel
            // 
            prizeAmountLabel.AutoSize = true;
            prizeAmountLabel.Font = new Font("Segoe UI", 18F);
            prizeAmountLabel.ForeColor = Color.FromArgb(51, 151, 255);
            prizeAmountLabel.Location = new Point(47, 252);
            prizeAmountLabel.Name = "prizeAmountLabel";
            prizeAmountLabel.Size = new Size(197, 41);
            prizeAmountLabel.TabIndex = 27;
            prizeAmountLabel.Text = "Prize Amount";
            // 
            // placeNameValue
            // 
            placeNameValue.Location = new Point(286, 181);
            placeNameValue.Name = "placeNameValue";
            placeNameValue.Size = new Size(214, 43);
            placeNameValue.TabIndex = 30;
            placeNameValue.Text = " ";
            // 
            // placeNameLabel
            // 
            placeNameLabel.AutoSize = true;
            placeNameLabel.Font = new Font("Segoe UI", 18F);
            placeNameLabel.ForeColor = Color.FromArgb(51, 151, 255);
            placeNameLabel.Location = new Point(47, 181);
            placeNameLabel.Name = "placeNameLabel";
            placeNameLabel.Size = new Size(174, 41);
            placeNameLabel.TabIndex = 29;
            placeNameLabel.Text = "Place Name";
            // 
            // orLabel
            // 
            orLabel.AutoSize = true;
            orLabel.Font = new Font("Segoe UI", 18F);
            orLabel.ForeColor = Color.FromArgb(51, 151, 255);
            orLabel.Location = new Point(235, 330);
            orLabel.Name = "orLabel";
            orLabel.Size = new Size(70, 41);
            orLabel.TabIndex = 31;
            orLabel.Text = "-or-";
            // 
            // createPrizeButton
            // 
            createPrizeButton.FlatAppearance.BorderColor = Color.Silver;
            createPrizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createPrizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createPrizeButton.FlatStyle = FlatStyle.Flat;
            createPrizeButton.Font = new Font("Segoe UI", 16F);
            createPrizeButton.ForeColor = SystemColors.MenuHighlight;
            createPrizeButton.Location = new Point(97, 498);
            createPrizeButton.Name = "createPrizeButton";
            createPrizeButton.Size = new Size(331, 108);
            createPrizeButton.TabIndex = 32;
            createPrizeButton.Text = "Create Prize";
            createPrizeButton.UseVisualStyleBackColor = true;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(583, 671);
            Controls.Add(createPrizeButton);
            Controls.Add(orLabel);
            Controls.Add(placeNameValue);
            Controls.Add(placeNameLabel);
            Controls.Add(prizeAmountValue);
            Controls.Add(prizeAmountLabel);
            Controls.Add(prizePercentageValue);
            Controls.Add(prizePercentageLabel);
            Controls.Add(placeNumberValue);
            Controls.Add(placeNumberLabel);
            Controls.Add(createPrizeLabel);
            Font = new Font("Segoe UI", 16F);
            Margin = new Padding(6);
            Name = "CreatePrizeForm";
            Text = "Create Prize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createPrizeLabel;
        private TextBox placeNumberValue;
        private Label placeNumberLabel;
        private TextBox prizePercentageValue;
        private Label prizePercentageLabel;
        private TextBox prizeAmountValue;
        private Label prizeAmountLabel;
        private TextBox placeNameValue;
        private Label placeNameLabel;
        private Label orLabel;
        private Button createPrizeButton;
    }
}