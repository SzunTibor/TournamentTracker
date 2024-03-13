﻿namespace TrackerUI
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
      teamNameValue = new TextBox();
      teamNameLabel = new Label();
      createTeamLabel = new Label();
      addMemberButton = new Button();
      selectTeamMemberDropDown = new ComboBox();
      selectTeamMemberLabel = new Label();
      addNewMemberBox = new GroupBox();
      firstNameValue = new TextBox();
      firstNameLabel = new Label();
      lastNameLabel = new Label();
      lastNameValue = new TextBox();
      emailLabel = new Label();
      emailValue = new TextBox();
      cellPhoneLabel = new Label();
      cellPhoneValue = new TextBox();
      createMemberButton = new Button();
      teamMembersListBox = new ListBox();
      deleteMemberButton = new Button();
      createTeamButton = new Button();
      addNewMemberBox.SuspendLayout();
      SuspendLayout();
      // 
      // teamNameValue
      // 
      teamNameValue.Location = new Point(33, 112);
      teamNameValue.Name = "teamNameValue";
      teamNameValue.Size = new Size(437, 35);
      teamNameValue.TabIndex = 11;
      // 
      // teamNameLabel
      // 
      teamNameLabel.AutoSize = true;
      teamNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      teamNameLabel.ForeColor = SystemColors.Highlight;
      teamNameLabel.Location = new Point(21, 72);
      teamNameLabel.Name = "teamNameLabel";
      teamNameLabel.Size = new Size(157, 37);
      teamNameLabel.TabIndex = 10;
      teamNameLabel.Text = "Team Name";
      // 
      // createTeamLabel
      // 
      createTeamLabel.AutoSize = true;
      createTeamLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      createTeamLabel.ForeColor = SystemColors.Highlight;
      createTeamLabel.Location = new Point(12, 9);
      createTeamLabel.Name = "createTeamLabel";
      createTeamLabel.Size = new Size(213, 50);
      createTeamLabel.TabIndex = 9;
      createTeamLabel.Text = "Create Team";
      // 
      // addMemberButton
      // 
      addMemberButton.FlatAppearance.BorderColor = Color.Silver;
      addMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      addMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      addMemberButton.FlatStyle = FlatStyle.Flat;
      addMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      addMemberButton.ForeColor = SystemColors.Highlight;
      addMemberButton.Location = new Point(157, 279);
      addMemberButton.Name = "addMemberButton";
      addMemberButton.Size = new Size(188, 55);
      addMemberButton.TabIndex = 17;
      addMemberButton.Text = "Add Member";
      addMemberButton.UseVisualStyleBackColor = true;
      // 
      // selectTeamMemberDropDown
      // 
      selectTeamMemberDropDown.FormattingEnabled = true;
      selectTeamMemberDropDown.Location = new Point(33, 224);
      selectTeamMemberDropDown.Name = "selectTeamMemberDropDown";
      selectTeamMemberDropDown.Size = new Size(437, 38);
      selectTeamMemberDropDown.TabIndex = 16;
      // 
      // selectTeamMemberLabel
      // 
      selectTeamMemberLabel.AutoSize = true;
      selectTeamMemberLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      selectTeamMemberLabel.ForeColor = SystemColors.Highlight;
      selectTeamMemberLabel.Location = new Point(20, 184);
      selectTeamMemberLabel.Name = "selectTeamMemberLabel";
      selectTeamMemberLabel.Size = new Size(263, 37);
      selectTeamMemberLabel.TabIndex = 15;
      selectTeamMemberLabel.Text = "Select Team Member";
      // 
      // addNewMemberBox
      // 
      addNewMemberBox.Controls.Add(lastNameValue);
      addNewMemberBox.Controls.Add(lastNameLabel);
      addNewMemberBox.Controls.Add(emailValue);
      addNewMemberBox.Controls.Add(emailLabel);
      addNewMemberBox.Controls.Add(createMemberButton);
      addNewMemberBox.Controls.Add(cellPhoneValue);
      addNewMemberBox.Controls.Add(cellPhoneLabel);
      addNewMemberBox.Controls.Add(firstNameValue);
      addNewMemberBox.Controls.Add(firstNameLabel);
      addNewMemberBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      addNewMemberBox.ForeColor = SystemColors.Highlight;
      addNewMemberBox.Location = new Point(33, 384);
      addNewMemberBox.Name = "addNewMemberBox";
      addNewMemberBox.Size = new Size(437, 415);
      addNewMemberBox.TabIndex = 18;
      addNewMemberBox.TabStop = false;
      addNewMemberBox.Text = "Add New Member";
      // 
      // firstNameValue
      // 
      firstNameValue.Location = new Point(156, 71);
      firstNameValue.Name = "firstNameValue";
      firstNameValue.Size = new Size(249, 43);
      firstNameValue.TabIndex = 20;
      // 
      // firstNameLabel
      // 
      firstNameLabel.AutoSize = true;
      firstNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      firstNameLabel.ForeColor = SystemColors.Highlight;
      firstNameLabel.Location = new Point(6, 68);
      firstNameLabel.Name = "firstNameLabel";
      firstNameLabel.Size = new Size(144, 37);
      firstNameLabel.TabIndex = 19;
      firstNameLabel.Text = "First Name";
      // 
      // lastNameLabel
      // 
      lastNameLabel.AutoSize = true;
      lastNameLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      lastNameLabel.ForeColor = SystemColors.Highlight;
      lastNameLabel.Location = new Point(6, 133);
      lastNameLabel.Name = "lastNameLabel";
      lastNameLabel.Size = new Size(142, 37);
      lastNameLabel.TabIndex = 19;
      lastNameLabel.Text = "Last Name";
      // 
      // lastNameValue
      // 
      lastNameValue.Location = new Point(156, 136);
      lastNameValue.Name = "lastNameValue";
      lastNameValue.Size = new Size(249, 43);
      lastNameValue.TabIndex = 20;
      // 
      // emailLabel
      // 
      emailLabel.AutoSize = true;
      emailLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      emailLabel.ForeColor = SystemColors.Highlight;
      emailLabel.Location = new Point(6, 201);
      emailLabel.Name = "emailLabel";
      emailLabel.Size = new Size(82, 37);
      emailLabel.TabIndex = 19;
      emailLabel.Text = "Email";
      // 
      // emailValue
      // 
      emailValue.Location = new Point(156, 204);
      emailValue.Name = "emailValue";
      emailValue.Size = new Size(249, 43);
      emailValue.TabIndex = 20;
      // 
      // cellPhoneLabel
      // 
      cellPhoneLabel.AutoSize = true;
      cellPhoneLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
      cellPhoneLabel.ForeColor = SystemColors.Highlight;
      cellPhoneLabel.Location = new Point(6, 266);
      cellPhoneLabel.Name = "cellPhoneLabel";
      cellPhoneLabel.Size = new Size(138, 37);
      cellPhoneLabel.TabIndex = 19;
      cellPhoneLabel.Text = "Cellphone";
      // 
      // cellPhoneValue
      // 
      cellPhoneValue.Location = new Point(156, 269);
      cellPhoneValue.Name = "cellPhoneValue";
      cellPhoneValue.Size = new Size(249, 43);
      cellPhoneValue.TabIndex = 20;
      // 
      // createMemberButton
      // 
      createMemberButton.FlatAppearance.BorderColor = Color.Silver;
      createMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createMemberButton.FlatStyle = FlatStyle.Flat;
      createMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createMemberButton.ForeColor = SystemColors.Highlight;
      createMemberButton.Location = new Point(124, 335);
      createMemberButton.Name = "createMemberButton";
      createMemberButton.Size = new Size(188, 55);
      createMemberButton.TabIndex = 17;
      createMemberButton.Text = "Create Member";
      createMemberButton.UseVisualStyleBackColor = true;
      // 
      // teamMembersListBox
      // 
      teamMembersListBox.BorderStyle = BorderStyle.FixedSingle;
      teamMembersListBox.FormattingEnabled = true;
      teamMembersListBox.ItemHeight = 30;
      teamMembersListBox.Location = new Point(545, 112);
      teamMembersListBox.Name = "teamMembersListBox";
      teamMembersListBox.Size = new Size(401, 662);
      teamMembersListBox.TabIndex = 19;
      // 
      // deleteMemberButton
      // 
      deleteMemberButton.FlatAppearance.BorderColor = Color.Silver;
      deleteMemberButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      deleteMemberButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      deleteMemberButton.FlatStyle = FlatStyle.Flat;
      deleteMemberButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      deleteMemberButton.ForeColor = SystemColors.Highlight;
      deleteMemberButton.Location = new Point(965, 406);
      deleteMemberButton.Name = "deleteMemberButton";
      deleteMemberButton.Size = new Size(154, 75);
      deleteMemberButton.TabIndex = 20;
      deleteMemberButton.Text = "Delete Selected";
      deleteMemberButton.UseVisualStyleBackColor = true;
      // 
      // createTeamButton
      // 
      createTeamButton.FlatAppearance.BorderColor = Color.Silver;
      createTeamButton.FlatAppearance.MouseDownBackColor = Color.Gray;
      createTeamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
      createTeamButton.FlatStyle = FlatStyle.Flat;
      createTeamButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
      createTeamButton.ForeColor = SystemColors.Highlight;
      createTeamButton.Location = new Point(365, 830);
      createTeamButton.Name = "createTeamButton";
      createTeamButton.Size = new Size(342, 70);
      createTeamButton.TabIndex = 21;
      createTeamButton.Text = "Create Team";
      createTeamButton.UseVisualStyleBackColor = true;
      // 
      // CreateTeamForm
      // 
      AutoScaleDimensions = new SizeF(12F, 30F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.White;
      ClientSize = new Size(1140, 949);
      Controls.Add(createTeamButton);
      Controls.Add(deleteMemberButton);
      Controls.Add(teamMembersListBox);
      Controls.Add(addNewMemberBox);
      Controls.Add(addMemberButton);
      Controls.Add(selectTeamMemberDropDown);
      Controls.Add(selectTeamMemberLabel);
      Controls.Add(teamNameValue);
      Controls.Add(teamNameLabel);
      Controls.Add(createTeamLabel);
      Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
      Margin = new Padding(5, 6, 5, 6);
      Name = "CreateTeamForm";
      Text = "Create Team";
      addNewMemberBox.ResumeLayout(false);
      addNewMemberBox.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox teamNameValue;
    private Label teamNameLabel;
    private Label createTeamLabel;
    private Button addMemberButton;
    private ComboBox selectTeamMemberDropDown;
    private Label selectTeamMemberLabel;
    private GroupBox addNewMemberBox;
    private TextBox firstNameValue;
    private Label firstNameLabel;
    private TextBox lastNameValue;
    private Label lastNameLabel;
    private TextBox emailValue;
    private Label emailLabel;
    private TextBox cellPhoneValue;
    private Label cellPhoneLabel;
    private Button createMemberButton;
    private ListBox teamMembersListBox;
    private Button deleteMemberButton;
    private Button createTeamButton;
  }
}