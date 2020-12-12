using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Cricket
{ 
    
    public partial class MainForm : Form
    {
        Match match;
        bool chooseNext , undoAble = false;
        ContextMenu cm = new ContextMenu();
        MenuItem mi;
        
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(Match mt)
        {
            this.reload(mt);            
        }
        public void reload(Match mt)
        {
            InitializeComponent();
            this.Size = new Size(1000, 1000);
            // label1.Size = new Size(200, 200);
            button1.Enabled = false; //Stop the game before the batsman have been choosen
            Undo.Enabled = false;    //Disabing the Undo context menu item, so that undo is not available before the first ball has been bowled.
            this.match = mt;
            if (match.secondInnings){
                this.Text += "Second Innings";
            }
            else {
                this.Text += "First Innings";
            }
            match.BatsmanChanged += new BatsmanChangedEventHandler(enableOrNotListBox); //Setting the eventhandling function to either enable or disable listbox
            groupBox1.Text = match.BatTeam; //Setting the caption of the groupbocx to BattingTeam name.
            batteam.Text = match.BatTeam;   //Setting the name of the batting in the score 
            if (!match.secondInnings) //The inning is first so hide the targets
            {
                Target.Hide();
                TargetValue.Hide();
            }
            else if (match.secondInnings) //The inning is second So display the targets
            {
                Target.Show();
                Target.Text = "Target";
                TargetValue.Show();
                TargetValue.Text = match.Target.ToString();
            }
            outMechanics.Enabled = false; //disabling all the out options.
            /**
             DataGridView dgv = new DataGridView();
             DataGridView dgv2 = new DataGridView();
             dgv.Location = new Point(200, 400);
             dgv.Size = new Size(300, 300);
             dgv2.Location = new Point(500, 400);
             dgv2.Size = new Size(300, 300);

             this.Controls.Add(dgv); this.Controls.Add(dgv2);

           
             DataView dv = new DataView(match.ds.Tables["Team1"]);
             DataView dv2 = new DataView(match.ds.Tables["Team2"]);

             dgv.DataSource = dv;
             dgv2.DataSource = dv2;

             */
            int m = match.Batting.Rows.Count;
            match.poBat = new Player[m];
            int n = match.Bowling.Rows.Count;
            match.poBall = new Player[n];
            for (int i = 0; i < m; i++)  // populating the batsman listbox
            {
                match.poBat[i] = (Player)match.Batting.Rows[i]["playerObject"];
                if (!match.poBat[i].OutAlready && !match.poBat[i].strike && !match.poBat[i].P2)  //The batsman is not out, is not nonstriker(P2) and is not strike batsman. then add him/her to the list.
                {
                    BatsmanList.Items.Add(match.poBat[i]);
                }
            }
            for (int i = 0; i < n; i++)  //populating the bowler listbox
            {
                match.poBall[i] = (Player)match.Bowling.Rows[i]["playerObject"];
                BowlerList.Items.Add(match.poBall[i]);
            }

            //  listBox1.Enabled = false;
            mi = new MenuItem("&WhatIf");
            cm.MenuItems.Add(mi);
            RunRatesAndStuffs.ContextMenu = cm;
            mi.Click += mi_Click;

            //Additional settings if the match was loaded from memory
            if(match.Loaded)
            {
                for (int i = 0; i < m; i++ )
                {
                    Player temp;
                    temp = (Player)match.Batting.Rows[i]["playerObject"];
                    if(temp.strike)    //Setting up the strike batsman
                    {
                        match.batsman1 = temp;
                    }
                    if(temp.P2)        //Setting up the nonstriker
                    {
                        match.batsman2 = temp;
                    }
                }
                button1.Enabled = true;
                BatsmanList.Enabled = false;
                bowlerLabel.Text = match.bowlerCurrent.Name;
                BowlsDetails.Text = match.bowlerCurrent.overState;
                BowlerList.Enabled = false;
                match.batsman1.strike = false;
                match.batsman1.P2 = false;
                match.batsman2.strike = false;
                match.batsman2.P2 = false;
                match.Loaded = false;
                this.showTwoPlayers();
            }
        }
        void mi_Click(object sender, EventArgs e)
        {
            Form whatIf;
            try
            {
                whatIf = Form4.getForm(match, false);
                whatIf.Owner = this;
                whatIf.Show();
            }
            catch (Exception ex)
            {
                whatIf = Form4.getForm(match, true); whatIf.Owner = this;
                whatIf.Show();
            }
   
        }
        public void showTwoPlayers()
        {
            if(match.onStrike == null)
            {
                Batsman1Label.Text = "{ }";
                Batsman2Label.Text = "{ }";
            }
            else if(match.onStrike == match.batsman1)
            {
                Batsman1Label.Text = match.onStrike.Name;
                Batsman1Score.Text = match.onStrike.Runs.ToString() + "("+ match.onStrike.BallsFaced.ToString() + ")";
                Batsman2Label.Text = match.batsman2.Name; //Batsman2 is the nonstriker
                Batsman2Score.Text = match.batsman2.Runs.ToString() + "(" + match.batsman2.BallsFaced.ToString() + ")";
            }
            else if(match.onStrike == match.batsman2)
            {
                Batsman1Label.Text = match.onStrike.Name;
                Batsman1Score.Text = match.onStrike.Runs.ToString() + "(" + match.onStrike.BallsFaced.ToString() + ")";
                Batsman2Label.Text = match.batsman1.Name; //Batsman1 is the nonstriker
                Batsman2Score.Text = match.batsman1.Runs.ToString() + "(" + match.batsman1.BallsFaced.ToString() + ")";
            }
            try
            {
                //Overs left 
                OversLeftValue.Text = ((match.totalBowls - match.bowlingTeam.ballsBowled) / 6).ToString() + "." + ((match.totalBowls - match.bowlingTeam.ballsBowled) % 6).ToString();
                //Current run rate runs/balls * 6
                float crr = ((float) match.battingTeam.runs / (float)match.bowlingTeam.ballsBowled) * 6;
                crrValue.Text = match.bowlingTeam.ballsBowled == 0? "{ }":crr.ToString() + " RPO";
                //for projected score
                if (!match.secondInnings) //IF first innings
                {
                    ReqRRorProjected.Text = "Projected Score";
                    rrOrProjValue.Text = match.bowlingTeam.ballsBowled == 0? "{ }": Math.Round((crr * match.overs)).ToString();
                    neededForBatting.Text = (match.totalBowls - match.bowlingTeam.ballsBowled).ToString() + " balls remaining.";

//My be needed in future if glitches                //    neededForBowling.Text = (match.poBat.Length - 1 - match.battingTeam.wickets).ToString() + " wickets remaining.";

                    neededForBowling.Text = (match.playerCount - 1 - match.battingTeam.wickets).ToString() + " wickets remaining.";
                }
                else  //IF SECOND INNINGS
                {
                    ReqRRorProjected.Text = "Required Run Rate";
                    int remBalls = match.totalBowls - match.bowlingTeam.ballsBowled;
                    rrOrProjValue.Text = ((((float)match.Target - (float)match.battingTeam.runs) / (float)remBalls) * 6).ToString() + " RPO";
                    neededForBatting.Text = match.BatTeam + " needs "+ (match.Target - match.battingTeam.runs).ToString() + " runs off " + (match.totalBowls - match.bowlingTeam.ballsBowled).ToString() + " balls.";
                    neededForBowling.Text = match.BowlTeam + " needs " + (match.playerCount - 1 - match.battingTeam.wickets).ToString() + " wickets to win the match";
                }
            }
            catch (Exception ex) { }            
         }

        public void enableOrNotListBox(object sender , BatsmanChangedEventArgs e) //For enabling or disabling the batsman selection listbox.
        {
            if(e.batsMan1 && e.batsMan2)
            {
                BatsmanList.Enabled = false;
                if(!BowlerList.Enabled)
                {
                    button1.Enabled = true; //Resume the game by enabling the next ball button
                }
               
            }
            else
            {
                BatsmanList.Enabled = true;
                button1.Enabled = false; //Stop game while choosing the batsman
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //For selecting the batsman
        {
            try
            {
                if (!match.BatsMan1)
                {
                    Player po = (Player)BatsmanList.SelectedItem;
                    transformReferenceValid(match.poBat, po);
                    Batsman1Label.Text = po.Name;
                    match.BatsMan1 = true;
                    match.batsman1 = po;//Setting the first batsman. Batsman1 should be used to access the first batsman....
                }
                else if (!match.BatsMan2)
                {
                    Player po = (Player)BatsmanList.SelectedItem;
                    transformReferenceValid(match.poBat, po);
                    Batsman2Label.Text = po.Name;
                    match.BatsMan2 = true;
                    match.batsman2 = po; //Setting the second batsman. Batsman2 should be used to access the second batsman....
                }
                BatsmanList.Items.RemoveAt(BatsmanList.SelectedIndex);
               /* if (match.toBeOnStrike == "batsman1")
                {
                    match.onStrike = match.batsman1;
                }
                else if (match.toBeOnStrike == "batsman2")
                {
                    match.onStrike = match.batsman2;
                } */
                if (match.onStrike == null)
                {
                    match.onStrike = match.batsman1;
                }
              //  match.toBeOnStrike = ""; //Disabling it

                if(chooseNext)
                {
                    groupBox1.Enabled = false;
                    chooseNext = false;
                    NextStrikeWindow nsw = new NextStrikeWindow(match);
                    nsw.ShowDialog(this);
                    groupBox1.Enabled = true; 
                }
                showTwoPlayers();      
            }
            catch (Exception ex) { ; }
        }

        private void button1_Click(object sender, EventArgs e)  //For every ball by ball logic here ballbyball ball-by-ball SEO
        {
            try
            {
                File.SetAttributes("tempFile", FileAttributes.Normal);
            }
            catch (Exception ex) { ;}
           this.MatchSave("tempFile");  //Saving the match for UNDO purposes.
           File.SetAttributes("tempFile", FileAttributes.Hidden);
           this.undoAble = true; //Setting the Match as undoable. i.e the match can be undone after a ball has been bowled, even if the match is loaded.
           this.Undo.Enabled = true; //Enabling the Undo context menu item, as the first ball has been bowled and the undo can be done.
            if(LegalDelivery.Checked) //If the delivery is legal
           {
               match.battingTeam.extras += (int)Extras.Value;         //Add any extra runs to team's total extras.
               match.battingTeam.runs += (int)RunsOffBat.Value;       //Add the runs scored off bat to the team;s total.
               match.battingTeam.runs += (int)Extras.Value;           //Add any extra runs excluding the noBall run to the team's total runs.
               match.bowlerCurrent.RunsConceeded = (int)Extras.Value + (int)RunsOffBat.Value; // Add the runs to the bOWLER STATS    
               match.onStrike.Runs = (int)RunsOffBat.Value;           // Add the runs to the Batsman. No need for += automatically does it property used get set  
               match.onStrike.BallsFaced = 1;                         //Increase the balls faced of the batsman.
               match.bowlerCurrent.BallsBowled = 1;                   //Increase the balls bowled of the bowler
               match.bowlingTeam.ballsBowled = 1;
               if ((int)RunsOffBat.Value == 4) { match.onStrike.Fours = 1; } //If the run is 4, treat it as a four boundary and add it to the stats of the batsman
               if ((int)RunsOffBat.Value == 6) { match.onStrike.Sixes = 1; } //If the run is 6, treat it as a Six boundary and add it to the stats of the batsman
               BowlsDetails.Text += "  " + ((int)RunsOffBat.Value + (int)Extras.Value); //Showing the balls next to bowler ball by ball
               makeOut();    //out mechanics
           }
            if(wide.Checked)    //If wide ball bowled
            {
                match.bowlerCurrent.Wides = 1;                               //Inrease the wides of bowler.
                match.battingTeam.extras += (int) Extras.Value;             //Add any extra runs excluding the wide run to team's total extras.
                match.battingTeam.extras++;                                //Add the wide run to team's extra too.
                match.battingTeam.runs += (int) Extras.Value;             //Add any extra runs excluding the wide run to the team's total runs.
                match.battingTeam.runs++;                                //Add the wide run to team's total runs too.
                match.bowlerCurrent.RunsConceeded = 1+ (int)Extras.Value; // Add the runs to the bOWLER STATS
                BowlsDetails.Text += "  " + (int)Extras.Value + "Wd"; //Showing the balls next to bowler ball by ball 
                makeOut();                                   //OUT MECHANISM

            }
            if(noBall.Checked) //If NoBall
            {
                match.bowlerCurrent.NoBalls = 1;                        //Inrease the noBalls of bowler.
                match.battingTeam.extras += (int) Extras.Value;         //Add any extra runs excluding the noBall run to team's total extras.
                match.battingTeam.extras++;                             //Add the noBall run to team's extra too.
                match.battingTeam.runs += (int) RunsOffBat.Value;       //Add the runs scored off bat to the team;s total.
                match.battingTeam.runs += (int) Extras.Value;           //Add any extra runs excluding the noBall run to the team's total runs.
                match.battingTeam.runs++;                               //Add the noBall run to team's total runs too.
                match.bowlerCurrent.RunsConceeded = 1 + (int)Extras.Value + (int) RunsOffBat.Value; // Add the runs to the bOWLER STATS    
                match.onStrike.Runs = (int)RunsOffBat.Value;           // Add the runs to the Batsman
                match.onStrike.BallsFaced = 1;                         //Increase the balls faced of the batsman.
                if ((int)RunsOffBat.Value == 4) { match.onStrike.Fours = 1; } //If the run is 4, treat it as a four boundary and add it to the stats of the batsman
                if ((int)RunsOffBat.Value == 6) { match.onStrike.Sixes = 1; } //If the run is 6, treat it as a Six boundary and add it to the stats of the batsman
                BowlsDetails.Text += "  " + ((int)RunsOffBat.Value + (int)Extras.Value) + "Nb"; //Showing the balls next to bowler ball by ball 
                makeOut();                                  //OUT MECHANISM
            }

            if(match.bowlerCurrent.BallsBowled !=0 && match.bowlerCurrent.BallsBowled % 6 == 0) //Every six ball
            {
                BowlerList.Enabled = true;
                match.bowlerPast = match.bowlerCurrent; //Set the current bowler as past so that he wont be able to bowl consecutibvely
                button1.Enabled = false; //Stop the game until a bowler is choosen
                match.changeStrike(); //If over, switch sides
                match.bowlingTeam.overs++;
                //Go to scorecard if the overs are complete
                if(match.bowlingTeam.overs == match.overs && !match.secondInnings) //First innings complete by over finishing
                {
                    //First inning over code here.
                    MessageBox.Show(this, "First Innings complete. Overs finished.", "Inning completion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.setStrikeAndP2();
                    ScoreCardForm scoresheet = new ScoreCardForm(match);
                    this.cleanUpCrew();
                    scoresheet.ShowDialog();
                    this.Close();
                    return;
                }
                else if (match.bowlingTeam.overs == match.overs && match.secondInnings) //Second innings complete by over finishing
                {
                    string msg = "";
                    if (match.battingTeam.runs > match.bowlingTeam.runs) { msg = "Second Innings complete. Overs finished. Congrats, " + match.BatTeam + " has Won!!"; }
                    else if (match.battingTeam.runs < match.bowlingTeam.runs) { msg = "Second Innings complete. Overs finished.Congrats, " + match.BowlTeam + " has Won!!"; }
                    else if (match.battingTeam.runs == match.bowlingTeam.runs) { msg = "Second Innings complete. Overs finished.Congrats, it's a tie"; }
                    MessageBox.Show(this, msg, "Inning completion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    //Second innning over code here.
                    this.setStrikeAndP2();
                    ShowOffForm lastScoreSheet = new ShowOffForm(match);
                    this.cleanUpCrew();
                    lastScoreSheet.ShowDialog();
                    this.Close();
                    return;
                }

            }
            if(RunsOffBat.Value % 2 ==1) //Change the strike if the run is odd
            {
                match.changeStrike();
            }
            showTwoPlayers();
            if(match.secondInnings) //Team is chasing a target
            {
                if(match.battingTeam.runs >= match.Target)
                {
                    MessageBox.Show(this, "Congrats,"+ match.BatTeam +" has Won!!", "Match Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.setStrikeAndP2();
                    ShowOffForm frm = new ShowOffForm(match);
                    this.cleanUpCrew();
                    frm.ShowDialog();
                    this.Close();
                    return;
                }
            }
            Score.Text = match.battingTeam.runs + " / " + match.battingTeam.wickets;
            //Go to scorecard if the wickets are finished
            if (match.battingTeam.wickets == match.playerCount - 1 && !match.secondInnings)  //First innings over. No wickets left
            {
                MessageBox.Show(this, "First Innings complete. "+ match.BatTeam+" is all out", "Inning completion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.setStrikeAndP2();
                ScoreCardForm scoresheet = new ScoreCardForm(match);
                this.cleanUpCrew();
                scoresheet.ShowDialog();
                this.Close();
                return;
            }
            else if (match.battingTeam.wickets == match.playerCount - 1 && match.secondInnings)  //Second innings over. No wickets left
            {
                string msg="";
                if (match.battingTeam.runs > match.bowlingTeam.runs) { msg = "Second Innings complete. "+ match.BatTeam +" is all out . However, Congrats, " + match.BatTeam + " has still Won!!"; }
                else if (match.battingTeam.runs < match.bowlingTeam.runs) { msg = "Second Innings complete. " + match.BatTeam + " is all out . Congrats, " + match.BowlTeam + " has Won!!"; }
                else if (match.battingTeam.runs == match.bowlingTeam.runs) { msg = "Second Innings complete. " + match.BatTeam + " is all out . It's a tie"; }
                MessageBox.Show(this, msg, "Inning completion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.setStrikeAndP2();
                ShowOffForm lastScoreSheet = new ShowOffForm(match);
                this.cleanUpCrew();
                lastScoreSheet.ShowDialog();
                this.Close();
                return;
            }

        }

        //Function to handle the disimissal of the batsman
        public void makeOut()
        {
            //Catch Out for 
            if((Out.Checked || Caught.Checked ) && !RunOut.Checked && !noBall.Checked) //Ultimately works. Slight glitch in naming while choosing nwxt striker.
            {
                if(match.onStrike == match.batsman1)
                {
                    match.BatsMan1 = false;
                    match.batsman1.OutAlready = true;
                }
                else
                {
                    match.BatsMan2 = false;
                    match.batsman2.OutAlready = true;
                }
                match.bowlerCurrent.Wickets = 1; //The bowler picked up the wicket so the stats is increased
                match.battingTeam.wickets++;     //Increase the wickets of the batting team
                chooseNext = true;
                BowlsDetails.Text += "Out";
            }
            //RunOut
            if(Out.Checked && RunOut.Checked) //uLTIMATELY WORKS. sLIGHT GLITCH IN NAMING WHILE CHOOSING WHO OUT ABD NEXT STRIKER.
            {
                groupBox1.Enabled = false;
                RunOutWindow rw = new RunOutWindow(match);
                rw.ShowDialog();

                chooseNext = true;
                groupBox1.Enabled = true;
                match.battingTeam.wickets++;     //Increase the wickets of the batting team
                BowlsDetails.Text += "Out";
               
            }
        }
        private void BowlerList_SelectedIndexChanged(object sender, EventArgs e) //Bowler selection logic here
        {
            if ((Player)BowlerList.SelectedItem != match.bowlerPast)
            {

                Player po = (Player)BowlerList.SelectedItem;
                transformReferenceValid(match.poBall, po);    
                if (po.Overs >= match.bowlingLimit)
                {
                    MessageBox.Show(this, "A bowler cannot bowl more than the Bowling Limit specified", "Error: Bowling Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    match.bowlerCurrent = (Player)BowlerList.SelectedItem;
                    bowlerLabel.Text = match.bowlerCurrent.Name;
                    BowlsDetails.Text = "";
                    BowlerList.Enabled = false;
                    if (!BatsmanList.Enabled)
                    {
                        button1.Enabled = true; //Let the game continue.
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "A bowler cannot bowl consecutive overs!! Please choose another bowler", "Error: Consecutive Overs Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(wide.Checked)
            {
                RunsOffBat.Enabled = false;
                Caught.Enabled = false;
                Caught.Checked = false;
            }
            else
            {
                RunsOffBat.Enabled = true;
                Caught.Enabled = true;
            }
        }

        private void Caught_CheckedChanged(object sender, EventArgs e)
        {
            if(Caught.Checked)
            {
                RunOut.Enabled = false;
            }
            else if(!Caught.Checked)
            {
                RunOut.Enabled = true;
            }
            if(RunOut.Checked)
            {
                Caught.Enabled = false;
                if(Caught.Checked)
                {
                    Caught.Checked = false;
                }
            }
        }

        private void RunOut_CheckedChanged(object sender, EventArgs e)
        {
            if (RunOut.Checked)
            {
                Caught.Enabled = false;
               // StrikeChanged.Enabled = false;
            }
            else if(!RunOut.Checked)
            {
                Caught.Enabled = true;
              //  StrikeChanged.Enabled = true;
            }
            if(Caught.Checked)
            {
                RunOut.Enabled = false;
                if (RunOut.Checked)
                {
                    RunOut.Checked = false;
                }
            }
        }

        private void Out_CheckedChanged(object sender, EventArgs e)
        {
            if(Out.Checked)
            {
                outMechanics.Enabled = true ;
                if(noBall.Checked)
                {
                    RunOut.Checked = true;
                }
                if(wide.Checked)
                {
                    RunOut.Enabled = true;
                }
            }
            else
            {
                outMechanics.Enabled = false;
                for (int i = 0; i < outMechanics.Controls.Count; i++)
                {
                    RadioButton rb = (RadioButton)outMechanics.Controls[i];
                    rb.Checked = false;
                }
            }
        }

        private void LegalDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (LegalDelivery.Checked)
            {
                if (!Caught.Checked && !RunOut.Enabled)
                {
                    RunOut.Enabled = true;
                }
            }
        }

        private void noBall_CheckedChanged(object sender, EventArgs e)
        {
            if (noBall.Checked)
            {
                Caught.Enabled = false;
                Caught.Checked = false;
                if(Out.Checked)
                {
                    RunOut.Enabled = false;
                    RunOut.Checked = true;
                }
            }
            else
            {
                Caught.Enabled = true;
            }
        }

        public void transformReferenceValid(Player [] poB, Player po)
        {
            for (int i = 0; i < poB.Length; i++)
            {
                if (poB[i].ID == po.ID)
                {
                    po = poB[i];
                }
            }
        }

        public void cleanUpCrew()
        {
            foreach (Form child in this.OwnedForms)
            {
                child.Close();
            }
            Form4.loseForm();
            this.Hide();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e) //cAUGHT RADIO BUITTON
        {
            if(Caught.Checked) //If the batsman is caught out, there can be no extra and runs off bat
            {
                RunsOffBat.Value = 0;
                RunsOffBat.Enabled = false;
                Extras.Value = 0;
                Extras.Enabled = false;
            }
            else
            {
                RunsOffBat.Enabled = true;
                Extras.Enabled = true;
            }
        }

        private void SaveMatch_Click(object sender, EventArgs e)
        {
            SaveBox.ShowDialog();
            String saveInFile = SaveBox.FileName;
            this.MatchSave(saveInFile);
           
        }
        public void MatchSave(String saveInFile)
        {
            this.setStrikeAndP2();
            
            match.bowlerCurrent.overState = BowlsDetails.Text;
            System.Runtime.Serialization.IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
            using (FileStream fs = File.Create(saveInFile))
                formatter.Serialize(fs, match);
            match.batsman1.strike = false;
            match.batsman1.P2 = false;
            match.batsman2.strike = false;
            match.batsman2.P2 = false;
        }
        public void setStrikeAndP2()
        {
            if (match.onStrike == match.batsman1)
            {
                if(!match.batsman1.OutAlready) match.batsman1.strike = true;  //If the batsman is not out, set him as striker
                if(!match.batsman2.OutAlready) match.batsman2.P2 = true;
            }
            else if (match.onStrike == match.batsman2)
            {
                if(!match.batsman2.OutAlready) match.batsman2.strike = true;
                if(!match.batsman1.OutAlready) match.batsman1.P2 = true;
            }
        }

        private void NextBallEnabledChanged(object sender, EventArgs e)
        {
            if(button1.Enabled)
            {
                SaveMatch.Enabled = true;
            }
            else
            {
                SaveMatch.Enabled = false;
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.undoByOneBall("tempFile");
        }
        public void undoByOneBall(String loadFromFile ) //Undo works by loading the match state from a ball before. i.e the state of game before the NEXTBall button was clicked.
        {
            if (loadFromFile != "")
            {
                IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                using (FileStream fs = File.OpenRead(loadFromFile))
                {
                    Match mt = (Match)formatter.Deserialize(fs);
                    MainForm mf = new MainForm(mt);
                    this.Hide();
                    fs.Dispose();  //So that the file resource is released before the form is closed.
                    mf.ShowDialog();
                    this.Close();
                    //Here
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
