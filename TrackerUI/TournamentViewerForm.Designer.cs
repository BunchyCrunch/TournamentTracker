namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerLabel = new Label();
            tournamentName = new Label();
            Round = new Label();
            roundDropDown = new ComboBox();
            unplayedOnlyCheckbox = new CheckBox();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.ForeColor = SystemColors.MenuHighlight;
            headerLabel.Location = new Point(29, 24);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(214, 50);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Tournament:";
            headerLabel.Click += label1_Click;
            // 
            // tournamentName
            // 
            tournamentName.AutoSize = true;
            tournamentName.Font = new Font("Segoe UI Light", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            tournamentName.ForeColor = SystemColors.MenuHighlight;
            tournamentName.Location = new Point(239, 24);
            tournamentName.Name = "tournamentName";
            tournamentName.Size = new Size(150, 50);
            tournamentName.TabIndex = 1;
            tournamentName.Text = "<none>";
            // 
            // Round
            // 
            Round.AutoSize = true;
            Round.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            Round.ForeColor = SystemColors.MenuHighlight;
            Round.Location = new Point(38, 91);
            Round.Name = "Round";
            Round.Size = new Size(94, 37);
            Round.TabIndex = 2;
            Round.Text = "Round";
            Round.Click += label1_Click_1;
            // 
            // roundDropDown
            // 
            roundDropDown.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            roundDropDown.FormattingEnabled = true;
            roundDropDown.Location = new Point(138, 90);
            roundDropDown.Name = "roundDropDown";
            roundDropDown.Size = new Size(121, 38);
            roundDropDown.TabIndex = 3;
            roundDropDown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // unplayedOnlyCheckbox
            // 
            unplayedOnlyCheckbox.AutoSize = true;
            unplayedOnlyCheckbox.FlatStyle = FlatStyle.Flat;
            unplayedOnlyCheckbox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            unplayedOnlyCheckbox.ForeColor = SystemColors.MenuHighlight;
            unplayedOnlyCheckbox.Location = new Point(38, 144);
            unplayedOnlyCheckbox.Name = "unplayedOnlyCheckbox";
            unplayedOnlyCheckbox.Size = new Size(209, 41);
            unplayedOnlyCheckbox.TabIndex = 4;
            unplayedOnlyCheckbox.Text = "Unplayed Only";
            unplayedOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(unplayedOnlyCheckbox);
            Controls.Add(roundDropDown);
            Controls.Add(Round);
            Controls.Add(tournamentName);
            Controls.Add(headerLabel);
            Name = "TournamentViewerForm";
            Text = "TournamentViewerForm";
            Load += TournamentViewerForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label tournamentName;
        private Label Round;
        private ComboBox roundDropDown;
        private CheckBox unplayedOnlyCheckbox;
    }
}