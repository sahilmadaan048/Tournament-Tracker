using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;
using TrackerLibrary;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form
    {
        public List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        public List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();
        public CreateTournamentForm()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            selectTeamDropDown.DataSource = null;
            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;
            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }
        private void addTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {   
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpLists();
            }
        }
        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            // call the create Prize form
            //CreatePrizeForm frm = new CreatePrizeForm(this);

            //frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            // Get back from the form a PrizeModel
            // Take the PrizeModel and put it into our list of selected prizes
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //CreateTeamForm frm = new CreateTeamForm(this);
            //frm.Show();
        }


        private void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void teamOneScoreLabel_Click(object sender, EventArgs e)
        {

        }

        private void teamOneScoreValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundLabel_Click(object sender, EventArgs e)
        {

        }

        private void tournamentPlayersLabel_Click(object sender, EventArgs e)
        {

        }
        private void teamOneScoreLabel_Click_1(object sender, EventArgs e)
        {
        }

        private void roundDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tournamentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void prizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void prizesLabel_Click(object sender, EventArgs e)
        {

        }


        private void deleteSelectedPrizeButton_Click(object sender, EventArgs e)
        {

        }

        private void tournamentTeamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
