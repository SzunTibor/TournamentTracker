﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
  public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
  {
    List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
    List<TeamModel> selectedTeams = [];
    List<PrizeModel> selectedPrizes = [];

    public CreateTournamentForm()
    {
      InitializeComponent();

      wireUpLists();
    }

    private void wireUpLists()
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
      if (selectTeamDropDown.SelectedItem is TeamModel team)
      {
        availableTeams.Remove(team);
        selectedTeams.Add(team);

        wireUpLists();
      }
    }

    private void createPrizeButton_Click(object sender, EventArgs e)
    {
      // Call the CreatePrizeForm
      CreatePrizeForm form = new CreatePrizeForm(this);
      form.Show();
    }

    public void PrizeComplete(PrizeModel model)
    {
      // Get back from the form a PrizeModel
      // Take the tourney and put it into our selected prizes
      selectedPrizes.Add(model);
      wireUpLists();
    }

    public void TeamComplete(TeamModel model)
    {
      selectedTeams.Add(model);
      wireUpLists();
    }

    private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      CreateTeamForm form = new CreateTeamForm(this);
      form.Show();
    }

    private void removePlayerButton_Click(object sender, EventArgs e)
    {
      if (tournamentTeamsListBox.SelectedItem is TeamModel team)
      {
        selectedTeams.Remove(team);
        availableTeams.Add(team);

        wireUpLists();
      }
    }

    private void removePrizeButton_Click(object sender, EventArgs e)
    {
      if (prizesListBox.SelectedItem is PrizeModel prize)
      {
        selectedPrizes.Remove(prize);

        wireUpLists();
      }
    }

    private void createTournamentButton_Click(object sender, EventArgs e)
    {
      if (!validateForm())
      {
        MessageBox.Show("Invalid tournament information");
        return;
      }

      // Create TournamentModel
      TournamentModel tourney = new TournamentModel();
      tourney.TournamentName = tournamentNameValue.Text;
      tourney.EntryFee = decimal.Parse(entryFeeValue.Text);

      tourney.Prizes = selectedPrizes;
      tourney.EnteredTeams = selectedTeams;

      // Create Matchups.
      TournamentLogic.CreateRounds(tourney);

      // Create Tournament entry.
      // Create all Prize entries.
      // Create all Team entries.
      GlobalConfig.Connection.CreateTournament(tourney);
    }

    private bool validateForm()
    {
      bool result = true;

      if (tournamentNameValue.Text.Length <= 0)
      {
        result = false;
      }

      decimal entryFee;
      if (!decimal.TryParse(entryFeeValue.Text, out entryFee))
      {
        result = false;
      }

      if (entryFee < 0)
      {
        result = false;
      }

      return result;
    }
  }
}
