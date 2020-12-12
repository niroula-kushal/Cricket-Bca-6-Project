using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace Cricket
{
    public partial class Form2 : Form
    {
        public Match mt;// = new Match();
       
        public Form2()
        {
            InitializeComponent();
            String[] args = Environment.GetCommandLineArgs();
            if (args.Length > 1)
            {
                if (File.Exists(args[1]))
                {
                    if (args[1].ToLower().Contains(".curl"))
                    {
                        this.Hide();
                        this.loadMatch(args[1]);
                    }
                    if(args[1].ToLower().Contains(".3yrs"))
                    {
                        this.Hide();
                        this.loadStat(args[1]);                        
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mt = new Match();
            //sETTING THE OVERS OF THE MATCH
            mt.overs = (int)OversTotal.Value;
            mt.totalBowls = mt.overs * 6;
            //sETTING THE BowlingLimit
            mt.bowlingLimit = (int)bowlingLimit.Value;
            //If the bowling limit is more than half of actual overs in the match. Donot create new forms.
            if(mt.overs/mt.bowlingLimit <2 && (mt.overs !=1 && mt.bowlingLimit !=1))
            {
                MessageBox.Show(this, "Bowling Limit cannot be more than half of the actual Overs in the match!! For Overs "+ mt.overs + " choose BowlingLimit greater or equal to "+ mt.overs/2 ,"Error: LargeBowlingLimit",MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            if(numOfPlayers.Value * mt.bowlingLimit < mt.overs)
            {
                MessageBox.Show(this,"The bowling limit cannot be set so low that makes it impossible to complete the match!!"  ,"Error: Smaller Bowling Limit", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            //Set the names of the team
            mt.team1 = Team1.Text.Trim() == "" ? "TeamThor" : Team1.Text.Trim();
            mt.team2 = Team2.Text.Trim() == "" ? "TeamCap" : Team2.Text.Trim(); ;

            //Extracting the names of the players from the textboxes
            string team1TextBoxText = team1TextBox.Text.Trim();
            string team2TextBoxText = team2TextBox.Text.Trim();
            char[] delimiter = { '\n', '\r' };
            String[] players = team1TextBoxText.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);  //Team1 player list, excluding any empty values inbetween.
            String[] players2 = team2TextBoxText.Split(delimiter, StringSplitOptions.RemoveEmptyEntries); //Team2 player list, excluding any empty values in between.
            if (players.Length < numOfPlayers.Value || players2.Length < numOfPlayers.Value)
            {
                MessageBox.Show(this, "Each team must have players more than or equal to the number of players specified. ", "Error: Insufficient Players.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;    
            }
            mt.playerCount = (int) numOfPlayers.Value; //Setting up the number of players in the match.
            //Setting the names and ids to the respective datatables in the dataset ds.
            for (int i = 0; i < players.Length; i++)
            {
                mt.ds.Tables["Team1"].Rows.Add(i,new Player(players[i],mt.team1, i));
            
            }
            for (int i = 0; i < players2.Length; i++)
            {
                mt.ds.Tables["Team2"].Rows.Add(i, new Player(players2[i],mt.team2, i));

            }

            //Setting the batting and the bowling team
            if(team1Bat.Checked)
            {
                mt.Batting = mt.ds.Tables["Team1"];
                mt.team1FirstBat = true;
                mt.BatTeam = mt.team1;
                mt.battingTeam = new Team(mt.BatTeam); //sETUP THE TEAM object  for batting
                mt.bowlingTeam = new Team(mt.BowlTeam); 
                mt.Bowling = mt.ds.Tables["Team2"];
                mt.BowlTeam = mt.team2;
              //  mt.team1Obj = mt.battingTeam;
               // mt.team2Obj = mt
            }
            else
            {
                mt.Bowling = mt.ds.Tables["Team1"];
                mt.BowlTeam = mt.team1;
                mt.Batting = mt.ds.Tables["Team2"];
                mt.BatTeam = mt.team2;
                mt.battingTeam = new Team(mt.BatTeam); //sETUP THE TEAM  object for batting
                mt.bowlingTeam = new Team(mt.BowlTeam);
            }

            //Opening up the MainForm.cs sending the Match object as argument
            this.Hide();
            MainForm mf = new MainForm(mt);
            mf.ShowDialog();
            this.Show();
        }
        
        public void saveTeamConfigure(bool xTeam1)
        {
            SaveBox.DefaultExt = "Team File|*.team";
           // SaveBox.FileName = "TeamFile";
            SaveBox.Filter = "Team File (*.team)|*.team";
            SaveBox.ShowDialog();
            TextBox tb = xTeam1 ? team1TextBox : team2TextBox;  //If called for team1, team1TextBox will be choosen, else team2TextBox
            TextBox temN = xTeam1 ? Team1 : Team2;  //If called for team1, team1's name will be choosen, else team2's name
            String fileToSaveIn = "";
            fileToSaveIn = SaveBox.FileName;
            if (fileToSaveIn != "")   //If the user didnt choose cancel or close the Save dialog box
            {
                using (FileStream fs = File.Create(fileToSaveIn))
                using (TextWriter writer = new StreamWriter(fs))
                {

                    String[] players = tb.Text.Trim().Split('\n');
                    foreach (string player in players)
                    {
                        writer.WriteLine(player);
                    }
                    writer.WriteLine("<!C!U!R!L!Y<!TeamName>Y!L!R!U!C>" + temN.Text);
                }
            }
        }
        public void loadTeamConfigure(bool xTeam1)
        {
            OpenBox.DefaultExt = "Team File|*.team";
            //OpenBox.FileName = "TeamFile";
            OpenBox.Filter = "Team File (*.team)|*.team";
            OpenBox.ShowDialog();
            TextBox tb = xTeam1 ? team1TextBox : team2TextBox; //If called for team1, team1TextBox will be choosen, else team2TextBox
            TextBox temN = xTeam1 ? Team1 : Team2;
            String fileToLoadFrom = "";
            fileToLoadFrom = OpenBox.FileName;
            if (fileToLoadFrom != "") //If the user didnt choose cancel or close the open dialog box
            {
                String allText = File.ReadAllText(fileToLoadFrom);
                if (allText.Contains("<!C!U!R!L!Y<!TeamName>Y!L!R!U!C>"))
                {
                    String players = allText.Substring(0, allText.LastIndexOf("<!C!U!R!L!Y<!TeamName>Y!L!R!U!C>"));
                    string teamName = allText.Substring(allText.LastIndexOf("<!C!U!R!L!Y<!TeamName>Y!L!R!U!C>")).Substring(32);
                    tb.Text = players;
                    temN.Text = teamName;
                }
                else
                {
                    tb.Text = allText;
                }
            }
        }

        private void saveTeamInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveTeamConfigure(true); 
        }

        private void loadTeamInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadTeamConfigure(true);
        }
        
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveTeamConfigure(false);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.loadTeamConfigure(false);
        }
        private void matchConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBox.DefaultExt = "MatchConfig File(*.mt)|*.mt";
            //OpenBox.FileName = "TeamFile";
            OpenBox.Filter = "MatchConfig File(*.mt)|*.mt";
            OpenBox.ShowDialog();
            String fileToLoadFrom = "";
            fileToLoadFrom = OpenBox.FileName;
            if (fileToLoadFrom != "") //If the user didnt choose cancel or close the open dialog box
            {
                String allText = File.ReadAllText(fileToLoadFrom);
                String[] parts = allText.Split('\n');
                try
                {
                    OversTotal.Value = (decimal)decimal.Parse(parts[0]);
                    bowlingLimit.Value = (decimal)decimal.Parse(parts[1]);
                    numOfPlayers.Value = (decimal)decimal.Parse(parts[2]);
                }
                catch (Exception ex) { MessageBox.Show(this, "Dont kill the Bar, Barney!!"); }
            }    
        }

        private void matchConfigurationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveBox.DefaultExt = "MatchConfig File(*.mt)|*.mt";
            SaveBox.Filter = "MatchConfig File(*.mt)|*.mt";
            //SaveBox.FileName = "Configuration File";
            SaveBox.ShowDialog();
            String fileToSaveIn = "";
            fileToSaveIn = SaveBox.FileName;
            if (fileToSaveIn != "")  //If the user didnt choose cancel or close the Save dialog box
            {
                using (FileStream fs = File.Create(fileToSaveIn))
                using (TextWriter writer = new StreamWriter(fs))
                {
                    String ov = OversTotal.Value.ToString();
                    String lim = bowlingLimit.Value.ToString();
                    String playersNum = numOfPlayers.Value.ToString();
                    writer.WriteLine(ov);
                    writer.WriteLine(lim);
                    writer.WriteLine(playersNum);
                    MessageBox.Show(this, "The match configuration has been saved", "Operation Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void team1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadTeamConfigure(true);
        }

        private void team2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadTeamConfigure(false);
        }

        private void team1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveTeamConfigure(true);
        }

        private void team2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveTeamConfigure(false);
        }
        public void loadStat(String loadFromFile)
        {
            Match mt = new Match();
            if(DeserializeMatchFile(loadFromFile, ref mt))
            {
                ShowOffForm mf = new ShowOffForm(mt);
                this.Hide();
                // fs.Dispose(); // Disposing the file already, because it can cause problem to the application.
                mf.ShowDialog();
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
                        Player.loadError = false;
                        Team.loadError = false;
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
        private void matchStatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBox.DefaultExt = "Match File (*.3yrs)|*.3yrs";
           // OpenBox.FileName = "Match1";
            OpenBox.Filter = "Match File (*.3yrs)|*.3yrs";
            OpenBox.ShowDialog();
            String loadFromFile = "";
            loadFromFile = OpenBox.FileName;
            if(loadFromFile!="")
            {
                this.loadStat(loadFromFile);
            }
        }

        private void matchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBox.DefaultExt = "Match File(*.curl)|*.curl";
            //OpenBox.FileName = "Match1";
            OpenBox.Filter = "Match File(*.curl)|*.curl";
            OpenBox.ShowDialog();
            String loadFromFile = "";
            loadFromFile = OpenBox.FileName;
            this.loadMatch(loadFromFile);
            this.Show();
        }
        private void loadMatch(String loadFromFile)
        {
            Match mt = new Match();
            if(DeserializeMatchFile(loadFromFile, ref mt))
            {
                MainForm mf = new MainForm(mt);
                this.Hide(); //Hiding this form when the MainFoem is shown.
                mf.ShowDialog();
            }           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveLoadContextMenuForTeam1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void SaveLoadContextMenuForTeam2_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }

    //For event handling
    [Serializable]public class BatsmanChangedEventArgs : EventArgs, ISerializable
    {
        public bool batsMan1, batsMan2;
        public Player batsman1, batsman2;
        public BatsmanChangedEventArgs() { }
        public BatsmanChangedEventArgs(bool bat1, bool bat2, Player Bat1, Player Bat2)
        {
            batsMan1 = bat1;  //Setting the boolean values
            batsMan2 = bat2;  //
            batsman1 = Bat1;  // Setting the Player objects
            batsman2 = Bat2;  //
        }
        public virtual void GetObjectData(SerializationInfo si, StreamingContext sc)
        {  }
            
        protected BatsmanChangedEventArgs(SerializationInfo si, StreamingContext sc)
         {}



    }
   public delegate void BatsmanChangedEventHandler(object sender, BatsmanChangedEventArgs e );
   [Serializable] public class Match : ISerializable
    {
       public static bool loadError = false;
       public bool Loaded = false, batsman1Strike = true;
        public Team battingTeam, bowlingTeam, team1Obj, team2Obj;
        public Player[] poBat; 
        public Player[] poBall;
        public bool team1FirstBat = false;
        public bool secondInnings = false;
        public int Target = 0, totalBowls, playerCount;
        public event BatsmanChangedEventHandler BatsmanChanged; //Call BatsmanChanged whenever BatsmanChanges to fire event
        private bool batsMan1, batsMan2;
        public int bowlingLimit;
        public string toBeOnStrike;
        public bool BatsMan1
        {
            get { return batsMan1; }
            set
            {
                batsMan1 = value;
                BatsmanChangedEventArgs e = new BatsmanChangedEventArgs(batsMan1, batsMan2, batsman1, batsman2);
                BatsmanChanged(this, e);
            }
        }
        public bool BatsMan2
        {
            get { return batsMan2; }
            set
            {
                batsMan2 = value;
                BatsmanChangedEventArgs e = new BatsmanChangedEventArgs(batsMan1, batsMan2, batsman1, batsman2);
                BatsmanChanged(this, e); 
            }
        }
        public Player batsman1, batsman2 , onStrike, bowlerCurrent, bowlerPast ;  //BowlerPast is the bowler who bowled previous over. sHOULD NOT BE GIVEN TO Bowl.
        public DataSet ds = new DataSet();
       // public Player test = new Player("NaNANANA", "tryr", 2); //TESTING PURPOSE
        public DataTable dt1 = new DataTable("Team1");
        public DataTable dt2 = new DataTable("Team2");
        public DataTable dt3 = new DataTable("Team3");
        public string team1, team2 , BatTeam, BowlTeam;
        public int overs = 10;
        public DataTable Batting, Bowling, temp;
        public Match()
        {
            dt1.Columns.Add("Id", typeof(int));
            dt1.Columns.Add("playerObject", typeof(Player));
            dt2.Columns.Add("Id", typeof(int));
            dt2.Columns.Add("playerObject", typeof(Player));
            dt3.Columns.Add("Id", typeof(int));
            dt3.Columns.Add("playerObject", typeof(Player));
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);
            ds.Tables.Add(dt3);
        }
        public void  changeStrike()
        {
            if(onStrike == batsman1)
            {
                onStrike = batsman2;
            }
            else
            {
                onStrike = batsman1;
            }
        }
        public virtual void GetObjectData(SerializationInfo si, StreamingContext sc)
        {
            //si.AddValue("Name", Name);
            //si.AddValue("PlayerData", Players.ToArray());
             si.AddValue("battingTeam", this.battingTeam, typeof(Team));
             si.AddValue("bowlingTeam", this.bowlingTeam, typeof(Team));
             si.AddValue("team1Obj", this.team1Obj, typeof(Team));
             si.AddValue("team2Obj", this.team2Obj, typeof(Team));
             si.AddValue("team1", this.team1); 
             si.AddValue("team2", this.team2);
             si.AddValue("team1FirstBat", this.team1FirstBat);
             si.AddValue("BatTeam", this.BatTeam);
             si.AddValue("BowlTeam", this.BowlTeam);
             si.AddValue("playerCount", this.playerCount);
             si.AddValue("dataset", this.ds, typeof(DataSet));
            //here on
             int team1DtRow = this.ds.Tables["Team1"].Rows.Count;
             si.AddValue("team1DtRow", team1DtRow);
             int team2DtRow = this.ds.Tables["Team2"].Rows.Count;
             si.AddValue("team2DtRow", team2DtRow);

            Player[] po = new Player[team1DtRow];
            Player[] po2 = new Player[team2DtRow];
            for (int i = 0; i < team1DtRow; i++) //Setting up the team1 player stats for serialization.
            {
                po[i] = (Player)this.ds.Tables["Team1"].Rows[i]["playerObject"];
                si.AddValue("Team1" + i, po[i], typeof(Player));
            } 
            for (int i = 0; i < team2DtRow; i++) //Setting up the team2 player stats for serialization.
            {
                po2[i] = (Player)this.ds.Tables["Team2"].Rows[i]["playerObject"];
                si.AddValue("Team2" + i, po2[i], typeof(Player));
            }

            //For whole match save
            /**secondInnings
Target
team1FirstBat
Batting datatable -> table1 or two depending on second innings and 
Bowling datatable
onStrike
bowlerCurrent
bowlerPast
totalBowls
overs
BatsMan1 , BatsMan2 boolean
poBat [] poBall[]

             * */
            si.AddValue("Target", this.Target);
            si.AddValue("secondInnings", this.secondInnings);
            if (this.batsman1 == this.onStrike) { si.AddValue("onStrike", this.batsman1, typeof(Player)); }
            else if (this.batsman2 == this.onStrike) { si.AddValue("onStrike", this.batsman2, typeof(Player)); }
            si.AddValue("bowlerCurrent", this.bowlerCurrent, typeof(Player));
            si.AddValue("bowlerPast", this.bowlerPast, typeof(Player));
            si.AddValue("totalBowls", this.totalBowls);
            si.AddValue("overs", this.overs);
            si.AddValue("batsMan1", this.batsMan1);
            si.AddValue("batsMan2", this.batsMan2);
            si.AddValue("poBat[]", this.poBat , typeof(Player[]));
            si.AddValue("poBall[]", this.poBall , typeof(Player[]));
            si.AddValue("Loaded", true);
            si.AddValue("bowlingLimit", this.bowlingLimit, typeof(int));
            si.AddValue("batsman1Strike", this.batsman1Strike);
            

        }
        protected Match(SerializationInfo si, StreamingContext sc)
        {
            /**
            //Preliminary
            dt1.Columns.Add("Id", typeof(int));
            dt1.Columns.Add("playerObject", typeof(Player));
            dt2.Columns.Add("Id", typeof(int));
            dt2.Columns.Add("playerObject", typeof(Player));
             
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2); */
            try
            {
                this.battingTeam = (Team)si.GetValue("battingTeam", typeof(Team));
                this.bowlingTeam = (Team)si.GetValue("bowlingTeam", typeof(Team));
                this.team1Obj = (Team)si.GetValue("team1Obj", typeof(Team));
                this.team2Obj = (Team)si.GetValue("team2Obj", typeof(Team));
                this.team1 = (String)si.GetValue("team1", typeof(String));
                this.team2 = (String)si.GetValue("team2", typeof(String));
                this.team1FirstBat = (bool)si.GetValue("team1FirstBat", typeof(bool));
                this.BatTeam = (String)si.GetValue("BatTeam", typeof(String));
                this.BowlTeam = (String)si.GetValue("BowlTeam", typeof(String));
                this.playerCount = (int)si.GetValue("playerCount", typeof(int));
                this.ds = (DataSet)si.GetValue("dataset", typeof(DataSet));
                /**I will Kill you....You son of a Bitttttttth. .|.. you 
                 * 
                 * Sorry mate!! I love you!! 
                 * */
                int team1DtRow = (int)si.GetValue("team1DtRow", typeof(int));
                int team2DtRow = (int)si.GetValue("team2DtRow", typeof(int));
                Player[] po = new Player[team1DtRow];
                Player[] po2 = new Player[team2DtRow];
                this.ds.Tables["Team1"].Rows.Clear();
                this.ds.Tables["Team2"].Rows.Clear();
                for (int i = 0; i < team1DtRow; i++)
                {
                    po[i] = (Player)si.GetValue("Team1" + i, typeof(Player));
                    this.ds.Tables["Team1"].Rows.Add(i, po[i]);
                }
                for (int i = 0; i < team1DtRow; i++)
                {
                    po2[i] = (Player)si.GetValue("Team2" + i, typeof(Player));
                    this.ds.Tables["Team2"].Rows.Add(i, po2[i]);
                }
                //For full match Load
                this.Target = (int)si.GetValue("Target", typeof(int));
                this.batsMan1 = (bool)si.GetValue("batsMan1", typeof(bool));
                this.batsMan2 = (bool)si.GetValue("batsMan2", typeof(bool));
                this.secondInnings = (bool)si.GetValue("secondInnings", typeof(bool));
                this.onStrike = (Player)si.GetValue("onStrike", typeof(Player));
                this.bowlerCurrent = (Player)si.GetValue("bowlerCurrent", typeof(Player));
                this.bowlerPast = (Player)si.GetValue("bowlerPast", typeof(Player));

                this.totalBowls = (int)si.GetValue("totalBowls", typeof(int));
                this.overs = (int)si.GetValue("overs", typeof(int));

                this.poBat = (Player[])si.GetValue("poBat[]", typeof(Player[]));
                this.poBall = (Player[])si.GetValue("poBall[]", typeof(Player[]));
                this.Loaded = (bool)si.GetValue("Loaded", typeof(bool));
                this.batsman1Strike = (bool)si.GetValue("batsman1Strike", typeof(bool));
                this.bowlingLimit = (int)si.GetValue("bowlingLimit", typeof(int));

                // ye ankhe hai, dil ki juwaan, dil ka bhabar bole sun sathiye chup naa dupate mai tu o chaliya/////
                if (this.team1FirstBat) //If team1 batted first
                {
                    if (!this.secondInnings)  //If it is still first inning, Team1 is the batting team
                    {
                        this.Batting = this.ds.Tables["Team1"];
                        this.Bowling = this.ds.Tables["Team2"];
                    }
                    else                     //If it is second innings, Team2 is the batting team
                    {
                        this.Batting = this.ds.Tables["Team2"];
                        this.Bowling = this.ds.Tables["Team1"];
                    }
                }
                else if (!this.team1FirstBat)  //If team1 didnt bat first i.e team2 batted first
                {
                    if (!this.secondInnings)  //If it is still first inning, Team2 is the batting team
                    {
                        this.Batting = this.ds.Tables["Team2"];
                        this.Bowling = this.ds.Tables["Team1"];
                    }
                    else                     //If it is second innings, Team1 is the batting team
                    {
                        this.Batting = this.ds.Tables["Team1"];
                        this.Bowling = this.ds.Tables["Team2"];
                    }
                }
            }
            catch (Exception ex) { Match.loadError = true; }  //Will be used while loading match to see if the match can be loaded without error or not.
        }

    }
    [Serializable]public  class Team : ISerializable
    {
        public static bool loadError = false;
        public string TeamName="";
        public int runs, wickets, extras;
        public int overs, BallsBowled;
        public virtual void GetObjectData(SerializationInfo si, StreamingContext sc)
        {
            si.AddValue("TeamName", this.TeamName);
            si.AddValue("runs", this.runs);
            si.AddValue("wickets", this.wickets);
            si.AddValue("extras", this.extras);
            si.AddValue("overs", this.overs);
            si.AddValue("BallsBowled", this.BallsBowled);

            //si.AddValue("PlayerData", Players.ToArray());
           
        }
        protected Team(SerializationInfo si, StreamingContext sc)
        {
           // this.TeamName = si.GetValue("TeamName", typeof(string)).ToString();
            try
            {
                this.runs = (int)si.GetValue("runs", typeof(int));
                this.wickets = (int)si.GetValue("wickets", typeof(int));
                this.extras = (int)si.GetValue("extras", typeof(int));
                this.overs = (int)si.GetValue("overs", typeof(int));
                this.BallsBowled = (int)si.GetValue("BallsBowled", typeof(int));
            }
            catch (Exception ex) { Team.loadError = true; }  //Will be used while loading match to see if the match can be loaded without error or not.
        }

        public int ballsBowled
        {
            get
            {
                return BallsBowled;
            }
            set
            {
                BallsBowled++;
            }
        }

        public Team(string name)
        {
            TeamName = name;
        }
        public Team() { }
    }
    [Serializable]public class Player : ISerializable
    {
        public static bool loadError = false;
        public bool OutAlready = false;
        public String overState = "";
        public bool P2 = false, strike = false;
        public int ID;
        private string name, team;
        private int runs, ballsFaced, fours, sixes; //strikeRate
        private int ballsBowled, wickets, wides, noBalls, runsConceded; // Overs
          public virtual void GetObjectData(SerializationInfo si, StreamingContext sc)
        {
            si.AddValue("ID", this.ID);
            si.AddValue("name", this.name);
            si.AddValue("team", this.team);
            si.AddValue("runs", this.Runs);
            si.AddValue("ballsFaced", this.BallsFaced);
            si.AddValue("fours", this.Fours);
            si.AddValue("sixes", this.Sixes);
            si.AddValue("ballsBowled", this.BallsBowled);
            si.AddValue("wickets", this.Wickets);
            si.AddValue("wides", this.Wides);
            si.AddValue("noBalls", this.NoBalls);
            si.AddValue("runsConceded", this.RunsConceeded);
            si.AddValue("OutAlready", this.OutAlready);
            si.AddValue("P2", this.P2);
            si.AddValue("strike", this.strike);
            si.AddValue("overState", this.overState);
            //si.AddValue("PlayerData", Players.ToArray());
           
        }
        protected Player(SerializationInfo si, StreamingContext sc)
        {
            try
            {
                this.ID = (int)si.GetValue("ID", typeof(int));
                this.name = (String)si.GetValue("name", typeof(String));
                this.team = (String)si.GetValue("team", typeof(String));
                this.runs = (int)si.GetValue("runs", typeof(int));
                this.ballsFaced = (int)si.GetValue("ballsFaced", typeof(int));
                this.fours = (int)si.GetValue("fours", typeof(int));
                this.sixes = (int)si.GetValue("sixes", typeof(int));
                this.ballsBowled = (int)si.GetValue("ballsBowled", typeof(int));
                this.wickets = (int)si.GetValue("wickets", typeof(int));
                this.wides = (int)si.GetValue("wides", typeof(int));
                this.noBalls = (int)si.GetValue("noBalls", typeof(int));
                this.runsConceded = (int)si.GetValue("runsConceded", typeof(int));
                this.OutAlready = (bool)si.GetValue("OutAlready", typeof(bool));
                this.P2 = (bool)si.GetValue("P2", typeof(bool));
                this.strike = (bool)si.GetValue("strike", typeof(bool));
                this.overState = (string)si.GetValue("overState", typeof(string));
            }
            catch (Exception ex) { Player.loadError = true; }  //Will be used while loading match to see if the match can be loaded without error or not.
        }
        public Player(String Name, String Team, int Id)
        {
            this.name = Name;
            this.team = Team;
            this.ID = Id;
        }
        public Player() { }
        public override string ToString()
        {
            return name;// +"Runs = " + Runs;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Team
        {
            get { return team; }
            set { team = value; }
        }
        
        //Stats while batting
        public int Runs
        {
            get { return runs; }
            set { runs += value; }
        }
        public int BallsFaced
        {
            get { return ballsFaced; }
            set { ballsFaced ++; }
        }
        public int Fours //Fours can be increased by any assignment of integer to Fours
        {
            get { return fours; }
            set { fours++; }
        }
        public int Sixes //Fours can be increased by any assignment of integer to Fours
        {
            get { return sixes; }
            set { sixes++; }
        }
        public float StrikeRate
        {
            get { return ((float)runs / ballsFaced) * 100; }
        }

        //Stats while bowling
        //Increased with any assignment of integer value to them
        public int BallsBowled
        {
            get { return ballsBowled; }
            set { ballsBowled++; }
        }
        public int Wides
        {
            get { return wides; }
            set { wides++; }
        }
        public int Wickets
        {
            get { return wickets; }
            set { wickets++; }
        }
        public int NoBalls
        {
            get { return noBalls; }
            set { noBalls++; }
        }
        public int RunsConceeded
        {
            get { return runsConceded; }
            set { runsConceded += value; }
        }
        public float Overs
        {
            get 
            { 
                string ft;
                int ov = ballsBowled / 6;
                int lef = ballsBowled - ov * 6;
                ft = ov.ToString() + "." + lef.ToString();
                float rt = float.Parse(ft);
                return rt;
            }
        }




    }


}
/**
 * public int Runs
        {
            get { return runs; }
            set { runs+= value; }
        }
        public int BallsFaced
        {
            get { return ballsFaced; }
            set { ballsFaced += value; }
        }
        public int Fours //Fours can be increased by any assignment of integer to Fours
        {
            get { return fours; }
            set { fours++; }
        }
        public int Sixes //Fours can be increased by any assignment of integer to Fours
        {
            get { return sixes; }
            set { sixes++; }
        }
 *  burkhat ka sarara hai, kaisa angara hai,, tere tisnagi ne mujhe mara hai..
 *  bewajah nahi milna tera mera,, rehnuma rehnuma rehnumaaaa
 * bewajah nahi milna tera mera,, rehnuma rehnuma rehnumaaaa
 * bewajah nahi milna tera mera,, rehnuma rehnuma rehnumaaaa
 *  yaado ki kaid mai giraftar ho gaya dil..
 *  dar badar ishk mai  tar tar ho gaya dil...
*/