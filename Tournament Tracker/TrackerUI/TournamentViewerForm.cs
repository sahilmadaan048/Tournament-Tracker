namespace TrackerUI
{
    public partial class TournamentViewerLabel : Form
    {
        public TournamentViewerLabel()
        {
            InitializeComponent();
        }

        private void TournamentViewerForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private Label headerLabel;

        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentNameLabel = new Label();
            roundLabel = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckBox = new CheckBox();
            matchUpListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            teamOneScoreValue = new TextBox();
            teamTwoScoreValue = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            versusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            headerLabel.ForeColor = Color.FromArgb(51, 151, 255);
            headerLabel.Location = new Point(36, 41);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(284, 62);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament: ";
            // 
            // tournamentNameLabel
            // 
            tournamentNameLabel.AutoSize = true;
            tournamentNameLabel.Font = new Font("Segoe UI Light", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tournamentNameLabel.ForeColor = Color.FromArgb(51, 151, 255);
            tournamentNameLabel.Location = new Point(292, 41);
            tournamentNameLabel.Name = "tournamentNameLabel";
            tournamentNameLabel.Size = new Size(202, 62);
            tournamentNameLabel.TabIndex = 1;
            tournamentNameLabel.Text = "<none> ";
            tournamentNameLabel.Click += tournamentNameLabel_Click;
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Segoe UI", 20F);
            roundLabel.ForeColor = Color.FromArgb(51, 151, 255);
            roundLabel.Location = new Point(36, 127);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(117, 46);
            roundLabel.TabIndex = 2;
            roundLabel.Text = "Round";
            roundLabel.Click += roundLabel_Click;
            // 
            // roundDropDown
            // 
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(169, 127);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(286, 45);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // unplayedOnlyCheckBox
            // 
            unplayedOnlyCheckBox.AutoSize = true;
            unplayedOnlyCheckBox.Font = new Font("Segoe UI", 16F);
            unplayedOnlyCheckBox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckBox.Location = new Point(169, 178);
            unplayedOnlyCheckBox.Name = "unplayedOnlyCheckBox";
            unplayedOnlyCheckBox.Size = new Size(215, 41);
            unplayedOnlyCheckBox.TabIndex = 4;
            unplayedOnlyCheckBox.Text = "Unplayed Only";
            unplayedOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            matchUpListBox.FormattingEnabled = true;
            matchUpListBox.ItemHeight = 37;
            matchUpListBox.Location = new Point(43, 236);
            matchUpListBox.Name = "matchUpListBox";
            matchUpListBox.Size = new Size(412, 300);
            matchUpListBox.TabIndex = 5;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 20F);
            teamOneName.ForeColor = Color.FromArgb(51, 151, 255);
            teamOneName.Location = new Point(503, 235);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(208, 46);
            teamOneName.TabIndex = 6;
            teamOneName.Text = "<team one>";
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 20F);
            teamOneScoreLabel.ForeColor = Color.FromArgb(51, 151, 255);
            teamOneScoreLabel.Location = new Point(517, 289);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(104, 46);
            teamOneScoreLabel.TabIndex = 7;
            teamOneScoreLabel.Text = "Score";
            teamOneScoreLabel.Click += teamOneScoreLabel_Click;
            // 
            // teamOneScoreValue
            // 
            teamOneScoreValue.Location = new Point(637, 289);
            teamOneScoreValue.Name = "teamOneScoreValue";
            teamOneScoreValue.Size = new Size(125, 43);
            teamOneScoreValue.TabIndex = 8;
            // 
            // teamTwoScoreValue
            // 
            teamTwoScoreValue.Location = new Point(637, 489);
            teamTwoScoreValue.Name = "teamTwoScoreValue";
            teamTwoScoreValue.Size = new Size(125, 43);
            teamTwoScoreValue.TabIndex = 11;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 20F);
            teamTwoScoreLabel.ForeColor = Color.FromArgb(51, 151, 255);
            teamTwoScoreLabel.Location = new Point(517, 489);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(104, 46);
            teamTwoScoreLabel.TabIndex = 10;
            teamTwoScoreLabel.Text = "Score";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 20F);
            teamTwoName.ForeColor = Color.FromArgb(51, 151, 255);
            teamTwoName.Location = new Point(503, 435);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(208, 46);
            teamTwoName.TabIndex = 9;
            teamTwoName.Text = "<team two>";
            // 
            // versusLabel
            // 
            versusLabel.AutoSize = true;
            versusLabel.Font = new Font("Segoe UI", 20F);
            versusLabel.ForeColor = Color.FromArgb(51, 151, 255);
            versusLabel.Location = new Point(591, 359);
            versusLabel.Name = "versusLabel";
            versusLabel.Size = new Size(87, 46);
            versusLabel.TabIndex = 12;
            versusLabel.Text = "-VS-";
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.BorderColor = Color.Silver;
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.ForeColor = SystemColors.MenuHighlight;
            scoreButton.Location = new Point(754, 359);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(123, 63);
            scoreButton.TabIndex = 13;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(924, 631);
            Controls.Add(scoreButton);
            Controls.Add(versusLabel);
            Controls.Add(teamTwoScoreValue);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(teamOneScoreValue);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchUpListBox);
            Controls.Add(unplayedOnlyCheckBox);
            Controls.Add(roundDropDown);
            Controls.Add(roundLabel);
            Controls.Add(tournamentNameLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.MenuHighlight;
            Name = "TournamentViewerForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label tournamentNameLabel;
        private Label roundLabel;

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentNameLabel_Click(object sender, EventArgs e)
        {

        }
        private ComboBox roundDropDown;

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private CheckBox unplayedOnlyCheckBox;
        private ListBox matchUpListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;

        private void teamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }
        private TextBox teamOneScoreValue;
        private TextBox teamTwoScoreValue;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label versusLabel;
        private Button scoreButton;
    }
}
