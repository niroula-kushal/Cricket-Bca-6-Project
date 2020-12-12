using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Cricket
{
    public partial class ShowOffForm : Form
    {
        Match match;
     
        Label lblempty1ForBatting = new Label();
        Label lblempty2ForBatting = new Label();
        Label lblempty3ForBatting = new Label();
        Label lblempty4ForBatting = new Label();
        Label lblempty5ForBatting = new Label();
        Label lblempty6ForBatting = new Label();
        Label lblempty1ForBowling = new Label();
        Label lblempty2ForBowling = new Label();
        Label lblempty3ForBowling = new Label();
        Label lblempty4ForBowling = new Label();
        Label lblempty5ForBowling = new Label();
        Label lblempty6ForBowling = new Label();
  
        public ShowOffForm(Match mt)
        {
            InitializeComponent();
            match = mt;
            this.reload(); //HAHAH!! DONT WORRY, ITS JUST A NAME.            
        }
        public void reload()
        {
            BattingPanel.Controls.Clear();
            BowlingPanel.Controls.Clear();
            Team1Name.Text = match.team1;
            firstTeamToolStripMenuItem.Text = match.team1;
            Team2Name.Text = match.team2;
            secondTeamToolStripMenuItem.Text = match.team2;
            match.team1Obj = match.team1FirstBat ? match.bowlingTeam : match.battingTeam;
            match.team2Obj = match.team1FirstBat ? match.battingTeam : match.bowlingTeam;
            Team1Score.Text = match.team1Obj.runs.ToString() + "/" + match.team1Obj.wickets.ToString();
            Team2Score.Text = match.team2Obj.runs.ToString() + "/" + match.team2Obj.wickets.ToString();

            if (match.battingTeam.runs < match.bowlingTeam.runs) //If the second batting team lost
            {
                Verdict.Text = match.BowlTeam + " won the match by " + (match.bowlingTeam.runs - match.battingTeam.runs).ToString() + " runs.";
            }
            else if (match.battingTeam.runs > match.bowlingTeam.runs) //IF the second batting team won
            {
                Verdict.Text = match.BatTeam + " won the match by " + (match.playerCount - match.battingTeam.wickets).ToString() + " wickets";
            }
            else
            {
                Verdict.Text = "Match Tied!!";

            }
        }
     
        private void firstTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateStats(true);

        }

        private void secondTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            populateStats(false); //Not for team1
        }
        public void populateStats(bool team1)
        {
            String dataTableIdentifierString, statForTeam;
            if (team1) { dataTableIdentifierString = "Team1"; statForTeam = match.team1; }
            else { dataTableIdentifierString = "Team2"; statForTeam = match.team2; }
            //GENETIC ALGORITHM STARTS HAHAHAHAH!!! SORY
            BattingPanel.Controls.Clear();
            BowlingPanel.Controls.Clear();

            /**
             * StatPage sg = new StatPage();
            sg.MdiParent = this;
            sg.Show();*/
            //Setting up the ColumnhEADER
            lblempty1ForBatting.Text = "Name";
            lblempty1ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty1ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            lblempty2ForBatting.Text = "4's";
            lblempty2ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty2ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            lblempty3ForBatting.Text = "6'S";
            lblempty3ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty3ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            lblempty4ForBatting.Text = "Balls Faced";
            lblempty4ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty4ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            lblempty5ForBatting.Text = "Runs";
            lblempty5ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty5ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            lblempty6ForBatting.Text = "Strike Rate";
            lblempty6ForBatting.BackColor = Color.FromArgb(10, 59, 2);
            lblempty6ForBatting.ForeColor = Color.FromArgb(0, 192, 19);
            BattingPanel.Controls.AddRange(new Control[] { lblempty1ForBatting, lblempty2ForBatting, lblempty3ForBatting, lblempty4ForBatting, lblempty5ForBatting, lblempty6ForBatting }); //Adding the column names to the batting scorecards

            for (int i = 0; i < match.ds.Tables[dataTableIdentifierString].Rows.Count; i++)
            {
                Label lblempty1 = new Label();
                Label lblempty2 = new Label();
                Label lblempty3 = new Label();
                Label lblempty4 = new Label();
                Label lblempty5 = new Label();
                Label lblempty6 = new Label();
                Player po = (Player)match.ds.Tables[dataTableIdentifierString].Rows[i]["playerObject"];
                lblempty1.Text = po.Name;
                if (po.strike || po.P2) // if the batsman is notout at the end of the innings, display specially.
                {
                   // lblempty1.Text += "*"; 
                    lblempty1.BackColor = Color.FromArgb(156,58,58);
                    lblempty2.BackColor = Color.FromArgb(156, 58, 58);
                    lblempty3.BackColor = Color.FromArgb(156, 58, 58);
                    lblempty4.BackColor = Color.FromArgb(156, 58, 58);
                    lblempty5.BackColor = Color.FromArgb(156, 58, 58);
                    lblempty6.BackColor = Color.FromArgb(156, 58, 58); 
                }
                lblempty2.Text = po.Fours.ToString();
                lblempty3.Text = po.Sixes.ToString();
                lblempty4.Text = po.BallsFaced.ToString();
                lblempty5.Text = po.Runs.ToString();
                lblempty6.Text = po.StrikeRate.ToString();
                BattingPanel.Controls.AddRange(new Control[] { lblempty1, lblempty2, lblempty3, lblempty4, lblempty5, lblempty6 });
            }


            lblempty1ForBowling.Text = "Name";
            lblempty1ForBowling.BackColor = Color.FromArgb(10,59,2);
            lblempty2ForBowling.Text = "Overs";
            lblempty2ForBowling.BackColor = Color.FromArgb(10,59,2);
            lblempty3ForBowling.Text = "Wickets";
            lblempty3ForBowling.BackColor = Color.FromArgb(10,59,2);
            lblempty4ForBowling.Text = "Wides";
            lblempty4ForBowling.BackColor = Color.FromArgb(10,59,2);
            lblempty5ForBowling.Text = "NoBalls";
            lblempty5ForBowling.BackColor = Color.FromArgb(10,59,2);
            lblempty6ForBowling.Text = "RunsConceded";
            lblempty6ForBowling.BackColor = Color.FromArgb(10,59,2);
            BowlingPanel.Controls.AddRange(new Control[] { lblempty1ForBowling, lblempty2ForBowling, lblempty3ForBowling, lblempty4ForBowling, lblempty5ForBowling, lblempty6ForBowling }); //Adding the column names to the bOWLING scorecards
            //Adding the bowling stats to the scorecard
            for (int i = 0; i < match.ds.Tables[dataTableIdentifierString].Rows.Count; i++)
            {
                Label lblempty1 = new Label();
                Label lblempty2 = new Label();
                Label lblempty3 = new Label();
                Label lblempty4 = new Label();
                Label lblempty5 = new Label();
                Label lblempty6 = new Label();
                Player po = (Player)match.ds.Tables[dataTableIdentifierString].Rows[i]["playerObject"];
                lblempty1.Text = po.Name;
                lblempty2.Text = po.Overs.ToString();
                lblempty3.Text = po.Wickets.ToString();
                lblempty4.Text = po.Wides.ToString();
                lblempty5.Text = po.NoBalls.ToString();
                lblempty6.Text = po.RunsConceeded.ToString();
                BowlingPanel.Controls.AddRange(new Control[] { lblempty1, lblempty2, lblempty3, lblempty4, lblempty5, lblempty6 });
            }

            foreach (Control ctrl in BattingPanel.Controls)
            {
                Label lbl;
                lbl = (Label)ctrl;
                //lbl.ForeColor = Color.FromArgb(0, 192, 19);
                lbl.ForeColor = Color.FromArgb(243,173,7);
            }
            foreach (Control ctrl in BowlingPanel.Controls)
            {
                Label lbl;
                lbl = (Label)ctrl;
//                lbl.ForeColor = Color.FromArgb(0, 192, 19);
                lbl.ForeColor = Color.FromArgb(243, 173, 7);
            }
            teamName.Text = statForTeam;
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveGameStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveBox.ShowDialog();
            String saveInFile = SaveBox.FileName;
            IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (FileStream fs = File.Create(saveInFile))
                formatter.Serialize(fs, match);
            MessageBox.Show(this, "The match stats have been saved", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadGameStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBox.ShowDialog();
            String loadFromFile = "";
            loadFromFile = OpenBox.FileName;
            Match mt = new Match();
            if (DeserializeMatchFile(loadFromFile, ref mt))
            {
                match = mt;       // this tweak is added because ShowOffForm doesnot open up new instance with new match file. It uses the file to display the data. So the actual oatch object will only be updated once it is confirmed that it is actually sound.
                MessageBox.Show(this, "The match stats have been loaded sucessfully.", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.reload();
            } 
        }
        public bool DeserializeMatchFile(String loadFromFile, ref Match mt)
        {
            try
            {
                if (loadFromFile != "" && File.Exists(loadFromFile))
                {
                    IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    FileStream fs = File.OpenRead(loadFromFile);
                    
                    mt = (Match)formatter.Deserialize(fs);
                    fs.Dispose();
                    if (Player.loadError || Team.loadError || Match.loadError)
                    {
                        MessageBox.Show(this, "The file is corrupted", "Error: Cannot Load Match", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Player.loadError = false;    //This is necessary, without it,
                        Team.loadError = false;      // the program would treat all other files as corrupt.
                        Match.loadError = false;
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }

        private void Team1Score_Click(object sender, EventArgs e)
        {

        }

        private void Team2Score_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void teamName_TextChanged(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutUsAll obj = new AboutUsAll();
            obj.ShowDialog();
        }
        
    }
}
