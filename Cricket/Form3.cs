using System;
using System.Windows.Forms;

namespace Cricket
{
    public partial class ScoreCardForm : Form
    {
        int Score; //Stores the score of the batting team.
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
        
        public ScoreCardForm(Match mt)
        {
            InitializeComponent(); //For the AutoDesigner
            match = mt;
            this.Score = match.battingTeam.runs;
            TotalRunsScored.Text = this.Score.ToString();  //Setting up the score in the display form
            TargetToGet.Text = (this.Score + 1).ToString(); // Setting up the target in the display form
            BatTeamName.Text = match.BatTeam;
            BowlingTeamName.Text = match.BowlTeam;
            //Setting up the column names for the batting scorecard
            lblempty1ForBatting.Text = "Name";
            lblempty2ForBatting.Text = "4's";
            lblempty3ForBatting.Text = "6'S";
            lblempty4ForBatting.Text = "Balls Faced";
            lblempty5ForBatting.Text = "Runs";
            lblempty6ForBatting.Text = "Strike Rate";

            ScoreCardBatting.Controls.AddRange(new Control[] { lblempty1ForBatting, lblempty2ForBatting, lblempty3ForBatting, lblempty4ForBatting, lblempty5ForBatting, lblempty6ForBatting }); //Adding the column names to the batting scorecards
            //Adding the batting stats to the scorecard
            for(int i=0;i<match.Batting.Rows.Count;i++) 
            {
                Label lblempty1 = new Label();
                Label lblempty2 = new Label();
                Label lblempty3 = new Label();
                Label lblempty4 = new Label();
                Label lblempty5 = new Label();
                Label lblempty6 = new Label();
                Player po = (Player) match.Batting.Rows[i]["playerObject"];
                lblempty1.Text = po.Name;
                lblempty2.Text = po.Fours.ToString();
                lblempty3.Text = po.Sixes.ToString();
                lblempty4.Text = po.BallsFaced.ToString();
                lblempty5.Text = po.Runs.ToString();
                lblempty6.Text = po.StrikeRate.ToString();
                ScoreCardBatting.Controls.AddRange(new Control[] { lblempty1, lblempty2, lblempty3, lblempty4, lblempty5, lblempty6 }); 
            }
            lblempty1ForBowling.Text = "Name";
            lblempty2ForBowling.Text = "Overs";
            lblempty3ForBowling.Text = "Wickets";
            lblempty4ForBowling.Text = "Wides";
            lblempty5ForBowling.Text = "NoBalls";
            lblempty6ForBowling.Text = "RunsConceded";
            ScoreCardBowling.Controls.AddRange(new Control[] { lblempty1ForBowling, lblempty2ForBowling, lblempty3ForBowling, lblempty4ForBowling, lblempty5ForBowling, lblempty6ForBowling }); //Adding the column names to the bOWLING scorecards
            //Adding the bowling stats to the scorecard
            for (int i = 0; i < match.Bowling.Rows.Count; i++)
            {
                Label lblempty1 = new Label();
                Label lblempty2 = new Label();
                Label lblempty3 = new Label();
                Label lblempty4 = new Label();
                Label lblempty5 = new Label();
                Label lblempty6 = new Label();
                Player po = (Player)match.Bowling.Rows[i]["playerObject"];
                lblempty1.Text = po.Name;
                lblempty2.Text = po.Overs.ToString();
                lblempty3.Text = po.Wickets.ToString();
                lblempty4.Text = po.Wides.ToString();
                lblempty5.Text = po.NoBalls.ToString();
                lblempty6.Text = po.RunsConceeded.ToString();
                ScoreCardBowling.Controls.AddRange(new Control[] { lblempty1, lblempty2, lblempty3, lblempty4, lblempty5, lblempty6 });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Swapping the datatables for the batting and the bowling team as the roles will be reversed in the second innings
            match.temp = match.Batting;
            match.Batting = match.Bowling;
            match.Bowling = match.temp;
            

          /*  if(match.team1FirstBat)     //If team1 did first batting in first inning, it is a bowling team now and team 2 is batting
            {
                match.Batting = match.ds.Tables["Team2"];
                match.Bowling = match.ds.Tables["Team1"];
            }
            else //If team1 did first bowling in first inning, it is a batting team now and team 2 is bowling
            {
                match.Batting = match.ds.Tables["Team1"];
                match.Bowling = match.ds.Tables["Team2"];
            }*/

            //Swapping the name of the batting team and the bowling team due to the reasons mentioned above.
            String tempS = match.BatTeam;
            match.BatTeam = match.BowlTeam;
            match.BowlTeam = tempS;
            //Creating new Team objects for Batting team and Bowling team with Previous attributes as well. First inning batting team will be a bowling team but will retain runs wickets etc

            Team Cap = new Team(match.BowlTeam);  //First inning batting team so bowlTeam used now
            Cap.runs = match.battingTeam.runs;
            Cap.wickets = match.battingTeam.wickets;
            Cap.extras = match.battingTeam.extras;
            Cap.overs = match.battingTeam.overs;

            Team IronMan = new Team(match.BatTeam); //First inning bowling team. so batting team now
            IronMan.runs = match.bowlingTeam.runs;
            IronMan.wickets = match.bowlingTeam.wickets;
            IronMan.extras = match.bowlingTeam.extras;
            IronMan.overs = match.bowlingTeam.overs;

            match.battingTeam = IronMan;        //Setting the teams as batting and 
            match.bowlingTeam = Cap;            // bowling respectively
            match.Target = this.Score + 1;
            match.secondInnings = true; //So that the MainForm will acknowledge it as a second inning.


         //   match.Batsman1 = false;
            match.BatsMan1 = false;
            match.BatsMan2 = false;
            match.onStrike = null;       // I WILL KILL YOU!!!
            MainForm secondI = new MainForm(match);
            this.Hide();
            secondI.ShowDialog();
            this.Close();
            return;
        }

    }
}


/**
 * DataTable mt.Batting
String mt.BatTeam
mt.battingTeam create new with new name and assign runs, wickets an all

*/