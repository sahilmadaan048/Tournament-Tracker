namespace TrackerUI
{
    partial class CreateTeamForm
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
            teamNameValueValue = new TextBox();
            teamNameLabel = new Label();
            createTeamLabel = new Label();
            addMemberButton = new Button();
            selectTeamMemberDropDown = new ComboBox();
            selectTeamMemberLabel = new Label();
            createMemberGroupBox = new GroupBox();
            createMemberButton = new Button();
            cellphoneValue = new TextBox();
            cellphoneLabel = new Label();
            emailValue = new TextBox();
            emailLabel = new Label();
            lastNameValue = new TextBox();
            lastNameLabel = new Label();
            firstNameValue = new TextBox();
            firstName = new Label();
            firstNameLabel = new Label();
            teamMembersListBox = new ListBox();
            removeSelectedMemberButton = new Button();
            createTeamButton = new Button();
            createMemberGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // teamNameValueValue
            // 
            teamNameValueValue.Location = new Point(32, 141);
            teamNameValueValue.Name = "teamNameValueValue";
            teamNameValueValue.Size = new Size(422, 27);
            teamNameValueValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Font = new Font("Segoe UI", 20F);
            teamNameLabel.ForeColor = Color.FromArgb(51, 151, 255);
            teamNameLabel.Location = new Point(35, 79);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new Size(197, 46);
            teamNameLabel.TabIndex = 12;
            teamNameLabel.Text = "Team Name";
            // 
            // createTeamLabel
            // 
            createTeamLabel.AutoSize = true;
            createTeamLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            createTeamLabel.ForeColor = Color.FromArgb(51, 151, 255);
            createTeamLabel.Location = new Point(27, 6);
            createTeamLabel.Name = "createTeamLabel";
            createTeamLabel.Size = new Size(272, 62);
            createTeamLabel.TabIndex = 11;
            createTeamLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            addMemberButton.FlatAppearance.BorderColor = Color.Silver;
            addMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            addMemberButton.FlatStyle = FlatStyle.Flat;
            addMemberButton.Font = new Font("Segoe UI", 16F);
            addMemberButton.ForeColor = SystemColors.MenuHighlight;
            addMemberButton.Location = new Point(155, 298);
            addMemberButton.Name = "addMemberButton";
            addMemberButton.Size = new Size(194, 63);
            addMemberButton.TabIndex = 19;
            addMemberButton.Text = "Add Member";
            addMemberButton.UseVisualStyleBackColor = true;
            addMemberButton.Click += addMemberButton_Click;
            // 
            // selectTeamMemberDropDown
            // 
            selectTeamMemberDropDown.FormattingEnabled = true;
            selectTeamMemberDropDown.Location = new Point(32, 253);
            selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
            selectTeamMemberDropDown.Size = new Size(422, 28);
            selectTeamMemberDropDown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            selectTeamMemberLabel.AutoSize = true;
            selectTeamMemberLabel.Font = new Font("Segoe UI", 20F);
            selectTeamMemberLabel.ForeColor = Color.FromArgb(51, 151, 255);
            selectTeamMemberLabel.Location = new Point(32, 204);
            selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            selectTeamMemberLabel.Size = new Size(335, 46);
            selectTeamMemberLabel.TabIndex = 17;
            selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // createMemberGroupBox
            // 
            createMemberGroupBox.Controls.Add(createMemberButton);
            createMemberGroupBox.Controls.Add(cellphoneValue);
            createMemberGroupBox.Controls.Add(cellphoneLabel);
            createMemberGroupBox.Controls.Add(emailValue);
            createMemberGroupBox.Controls.Add(emailLabel);
            createMemberGroupBox.Controls.Add(lastNameValue);
            createMemberGroupBox.Controls.Add(lastNameLabel);
            createMemberGroupBox.Controls.Add(firstNameValue);
            createMemberGroupBox.Controls.Add(firstName);
            createMemberGroupBox.Controls.Add(firstNameLabel);
            createMemberGroupBox.Font = new Font("Segoe UI", 20.25F);
            createMemberGroupBox.ForeColor = SystemColors.MenuHighlight;
            createMemberGroupBox.Location = new Point(32, 380);
            createMemberGroupBox.Name = "createMemberGroupBox";
            createMemberGroupBox.Size = new Size(425, 401);
            createMemberGroupBox.TabIndex = 20;
            createMemberGroupBox.TabStop = false;
            createMemberGroupBox.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            createMemberButton.FlatAppearance.BorderColor = Color.Silver;
            createMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMemberButton.FlatStyle = FlatStyle.Flat;
            createMemberButton.Font = new Font("Segoe UI", 16F);
            createMemberButton.ForeColor = SystemColors.MenuHighlight;
            createMemberButton.Location = new Point(100, 335);
            createMemberButton.Name = "createMemberButton";
            createMemberButton.Size = new Size(235, 50);
            createMemberButton.TabIndex = 29;
            createMemberButton.Text = "Create Member";
            createMemberButton.UseVisualStyleBackColor = true;
            createMemberButton.Click += createMemberButton_Click;
            // 
            // cellphoneValue
            // 
            cellphoneValue.Location = new Point(196, 263);
            cellphoneValue.Name = "cellphoneValue";
            cellphoneValue.Size = new Size(214, 52);
            cellphoneValue.TabIndex = 28;
            cellphoneValue.Text = " ";
            // 
            // cellphoneLabel
            // 
            cellphoneLabel.AutoSize = true;
            cellphoneLabel.Font = new Font("Segoe UI", 18F);
            cellphoneLabel.ForeColor = Color.FromArgb(51, 151, 255);
            cellphoneLabel.Location = new Point(20, 274);
            cellphoneLabel.Name = "cellphoneLabel";
            cellphoneLabel.Size = new Size(153, 41);
            cellphoneLabel.TabIndex = 27;
            cellphoneLabel.Text = "Cellphone";
            // 
            // emailValue
            // 
            emailValue.Location = new Point(193, 189);
            emailValue.Name = "emailValue";
            emailValue.Size = new Size(214, 52);
            emailValue.TabIndex = 26;
            emailValue.Text = " ";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 18F);
            emailLabel.ForeColor = Color.FromArgb(51, 151, 255);
            emailLabel.Location = new Point(17, 200);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(88, 41);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            lastNameValue.Location = new Point(193, 128);
            lastNameValue.Name = "lastNameValue";
            lastNameValue.Size = new Size(214, 52);
            lastNameValue.TabIndex = 24;
            lastNameValue.Text = " ";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 18F);
            lastNameLabel.ForeColor = Color.FromArgb(51, 151, 255);
            lastNameLabel.Location = new Point(17, 139);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(157, 41);
            lastNameLabel.TabIndex = 23;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            firstNameValue.Location = new Point(190, 54);
            firstNameValue.Name = "firstNameValue";
            firstNameValue.Size = new Size(214, 52);
            firstNameValue.TabIndex = 22;
            firstNameValue.Text = " ";
            firstNameValue.TextChanged += teamOneScoreValue_TextChanged;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Font = new Font("Segoe UI", 18F);
            firstName.ForeColor = SystemColors.MenuHighlight;
            firstName.Location = new Point(20, 65);
            firstName.Name = "firstName";
            firstName.Size = new Size(160, 41);
            firstName.TabIndex = 21;
            firstName.Text = "First Name";
            firstName.Click += teamOneScoreLabel_Click;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 18F);
            firstNameLabel.ForeColor = Color.FromArgb(51, 151, 255);
            firstNameLabel.Location = new Point(14, 65);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(160, 41);
            firstNameLabel.TabIndex = 21;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamMembersListBox
            // 
            teamMembersListBox.Font = new Font("Segoe UI", 16F);
            teamMembersListBox.FormattingEnabled = true;
            teamMembersListBox.ItemHeight = 37;
            teamMembersListBox.Location = new Point(492, 35);
            teamMembersListBox.Name = "teamMembersListBox";
            teamMembersListBox.Size = new Size(353, 596);
            teamMembersListBox.TabIndex = 24;
            // 
            // removeSelectedMemberButton
            // 
            removeSelectedMemberButton.FlatAppearance.BorderColor = Color.Silver;
            removeSelectedMemberButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            removeSelectedMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            removeSelectedMemberButton.FlatStyle = FlatStyle.Flat;
            removeSelectedMemberButton.Font = new Font("Segoe UI", 15F);
            removeSelectedMemberButton.ForeColor = SystemColors.MenuHighlight;
            removeSelectedMemberButton.Location = new Point(865, 298);
            removeSelectedMemberButton.Name = "removeSelectedMemberButton";
            removeSelectedMemberButton.Size = new Size(164, 89);
            removeSelectedMemberButton.TabIndex = 25;
            removeSelectedMemberButton.Text = "Remove Selected";
            removeSelectedMemberButton.UseVisualStyleBackColor = true;
            removeSelectedMemberButton.Click += removeSelectedMemberButton_Click;
            // 
            // createTeamButton
            // 
            createTeamButton.FlatAppearance.BorderColor = Color.Silver;
            createTeamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createTeamButton.FlatStyle = FlatStyle.Flat;
            createTeamButton.Font = new Font("Segoe UI", 16F);
            createTeamButton.ForeColor = SystemColors.MenuHighlight;
            createTeamButton.Location = new Point(575, 696);
            createTeamButton.Name = "createTeamButton";
            createTeamButton.Size = new Size(331, 85);
            createTeamButton.TabIndex = 26;
            createTeamButton.Text = "Create Team";
            createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1080, 829);
            Controls.Add(createTeamButton);
            Controls.Add(removeSelectedMemberButton);
            Controls.Add(teamMembersListBox);
            Controls.Add(createMemberGroupBox);
            Controls.Add(addMemberButton);
            Controls.Add(selectTeamMemberDropDown);
            Controls.Add(selectTeamMemberLabel);
            Controls.Add(teamNameValueValue);
            Controls.Add(teamNameLabel);
            Controls.Add(createTeamLabel);
            Name = "CreateTeamForm";
            Text = "Create Team";
            Load += CreateTeamForm_Load;
            createMemberGroupBox.ResumeLayout(false);
            createMemberGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox teamNameValueValue;
        private Label teamNameLabel;
        private Label createTeamLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropDown;
        private Label selectTeamMemberLabel;
        private GroupBox createMemberGroupBox;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private TextBox lastNameValue;
        private Label lastNameLabel;
        private TextBox cellphoneValue;
        private Label cellphoneLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private Button createMemberButton;
        private ListBox teamMembersListBox;
        private Button removeSelectedMemberButton;
        private Button createTeamButton;
        private Label firstName;
    }
}