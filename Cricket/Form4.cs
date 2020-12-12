using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cricket
{
    public partial class Form4 : Form
    {
        Match match;
        static private Form4 instance;
        private Form4(Match mt)
        {
            InitializeComponent();
            match = mt;
            optionalLabel.BackColor = Color.Transparent;
        }
        public static Form4 getForm(Match mt , bool NewInstance)
        {
            if (Form4.instance == null || NewInstance) return instance = new Form4(mt);
            else return instance;
        }
        public static void loseForm()
        {
            Form4.instance = null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(hypotheticalQuestion.SelectedIndex == -1)
            {
                optionalValue.Text = "";
                optionalLabel.Text = "";
                hypotheticalRR.Enabled = true;
                hypotheticalRRLabel.Text = "What if the run rate was";

                optionalValue.Enabled = false;
            }
            else if( hypotheticalQuestion.SelectedIndex == 0)
            {
                optionalValue.Text = "";
                optionalLabel.Text = "";
                hypotheticalRR.Enabled = false;
                hypotheticalRRLabel.Text = "The Run Rate should be ";
                
                optionalValue.Enabled = false;
                ShowMe.PerformClick();
            }
            else if (hypotheticalQuestion.SelectedIndex == 1)
            {
                optionalValue.Enabled = true;
                optionalValue.Focus();
                optionalValue.Text = "";
                optionalLabel.Text = "Score X";
                hypotheticalRR.Enabled = false;
                hypotheticalRRLabel.Text = "The Run Rate should be ";
            }
            else if (hypotheticalQuestion.SelectedIndex == 2)
            {
                optionalValue.Text = "";
                optionalLabel.Text = "X Overs ";
                optionalValue.Focus();
                hypotheticalRR.Enabled = false;
                hypotheticalRRLabel.Text = "The Run Rate should be ";
                optionalValue.Enabled = true;
            }
            else if(hypotheticalQuestion.SelectedIndex == 3)
            {
                optionalValue.Enabled = true;
                optionalValue.Focus();
                optionalValue.Text = "100:1";
                optionalLabel.Text = "Score X : Over X";
                hypotheticalRR.Enabled = false;
                hypotheticalRRLabel.Text = "The Run Rate should be ";
            }
        }
        private void hypotheticalRR_TextChanged(object sender, EventArgs e)
        {
            if(hypotheticalQuestion.SelectedIndex == -1) ShowMe.PerformClick();
        }
        private void optionalValue_TextChanged(object sender, EventArgs e)
        {
            ShowMe.PerformClick();
        }
        public void verdictAndAll(int hypotheticalRuns, int toGetRun)
        {
            hypotheticalScore.Text = hypotheticalRuns.ToString();
            if (!match.secondInnings)
            {
                hypotheticalVerdict.Text = match.BowlTeam + " will have to chase with a required run rate of " + ((hypotheticalRuns + 1) / match.overs).ToString() + " per over.";
            }
            else
            {
                int diff = toGetRun - hypotheticalRuns;
                if (diff < 0)
                {
                    hypotheticalVerdict.Text = match.BatTeam + " will win the match by " + (match.playerCount - 1 - match.battingTeam.wickets).ToString() + " wickets.";
                }
                else if (diff > 0)
                {
                    hypotheticalVerdict.Text = match.BowlTeam + " will win the match by " + (match.bowlingTeam.runs - hypotheticalRuns).ToString() + " runs.";
                }
                else if (diff == 0)
                {
                    hypotheticalVerdict.Text = "The match will be a tie";
                }
            }
        }
        public bool ScoreIsLess(int ScoreX, String errorMessage) //returns true if the score is less than current score
        {
            if (ScoreX < match.battingTeam.runs)
            {
                optionalValue.BackColor = System.Drawing.Color.Red;
                errorText.Text = errorMessage;
                errorText.ForeColor = Color.Red;
                return true;
            }
            else
            {
                optionalValue.BackColor = System.Drawing.Color.White;
                errorText.Text = "";
                return false;
            }
        }
        public bool overIsMore(int lessBalls)
        {
            int remainningBalls = match.totalBowls - match.bowlingTeam.ballsBowled;
            if(lessBalls >= remainningBalls)
            {
                optionalValue.BackColor = System.Drawing.Color.Red;
                errorText.Text = "OverX cannot be more than or equal to actual remaining overs.";
                return true;
            }
            else
            {
                optionalValue.BackColor = System.Drawing.Color.White;
                errorText.Text = "";
                return false;
            }
        }
        public void hypotheticalQuestionNone()
        {
            try
            {
                float rr = hypotheticalRR.Text.Trim() == "" ? 0 : float.Parse(hypotheticalRR.Text);  //Would throw exception if string was passed
                //For the hypothetical score
                /**
                 *HypoThetical score = currentScore + hypoThetical runrate * balls remaining /6
                 * Curly
                 */
                int hypotheticalRuns = (int)(match.battingTeam.runs + ((match.totalBowls - match.bowlingTeam.ballsBowled) * rr) / 6);
                verdictAndAll(hypotheticalRuns, match.bowlingTeam.runs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Run Rate can only be number, no strings allowed", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                hypotheticalRR.Focus();
                return;
            }
        }
        public void hypotheticalQuestionSelectedFirst()
        {
            if (!match.secondInnings)  //First innings. Not allowed to ask that question
            {
                MessageBox.Show(this, "At this moment, This question is applicable only while chasing. Feature to show probabilities of winning for a certain score will be added later.", "Error: Invalid Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int remBalls = match.totalBowls - match.bowlingTeam.ballsBowled;
                // lastQuestion.Text = hypotheticalQuestion.Items[hypotheticalQuestion.SelectedIndex].ToString();
                float hypotheticalCRR = ((((float)match.Target - (float)match.battingTeam.runs) / (float)remBalls) * 6);
                hypotheticalRR.Text = hypotheticalCRR.ToString() + " RPO";
                verdictAndAll((int)(hypotheticalCRR * remBalls) / 6, match.bowlingTeam.runs);
            }
        }
        public void hypotheticalQuestionSelectedSecond()
        {
            optionalLabel.Text = "Score X ";
            if (optionalValue.Text == "{ }") //Has not  been set by the user
            {

            }
            else
            {
                int ScoreX;
                try
                {
                    ScoreX = optionalValue.Text.Trim() == "" ? 0 : int.Parse(optionalValue.Text);  //Would throw exception if string was passed
                    if (ScoreIsLess(ScoreX, "* ScoreX cannot be less than the current score"))
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Score can only be a integer value.", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                int remBalls = match.totalBowls - match.bowlingTeam.ballsBowled;
                //    lastQuestion.Text = hypotheticalQuestion.Items[hypotheticalQuestion.SelectedIndex].ToString();
                //    hypotheticalQuestion.SelectedIndex = -1;
                hypotheticalRR.Text = ((((float)ScoreX - (float)match.battingTeam.runs) / (float)remBalls) * 6).ToString() + " RPO";
                verdictAndAll((int)ScoreX, match.bowlingTeam.runs);
            }
        }
        public void hypotheticalQuestionSelectedThird()
        {
            if (!match.secondInnings)  //First innings. Not allowed to ask that question
            {
                MessageBox.Show(this, "This question is applicable only while chasing.", "Error: Invalid Question", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                int lessBalls;
                try
                {
                    float overX = optionalValue.Text.Trim() == "" ? 1 : float.Parse(optionalValue.Text); //Would throw exception if string was passed
                    string OverX = overX.ToString();
                    String[] parts = OverX.Split('.');
                    if (parts.Length == 1) { OverX = "0"; } //If there is no number after decimal, assign 0 as the number after zero. It would work as the balls.
                    else { OverX = parts[1].Substring(0, 1); } //Else assign the decimal value
                    lessBalls = int.Parse(parts[0]) * 6 + int.Parse(OverX);
                    if (overIsMore(lessBalls))
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Over can only be integer or float.", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                int remBalls = match.totalBowls - lessBalls - match.bowlingTeam.ballsBowled;  //Remaining balls = total ball in game - the balls the user wants the game to finish faster - balls actually bowled
                // lastQuestion.Text = hypotheticalQuestion.Items[hypotheticalQuestion.SelectedIndex].ToString();
                float hypotheticalCRR = ((((float)match.Target - (float)match.battingTeam.runs) / (float)remBalls) * 6);
                hypotheticalRR.Text = hypotheticalCRR.ToString() + " RPO";
                verdictAndAll((int)(match.battingTeam.runs + hypotheticalCRR * remBalls) / 6, match.bowlingTeam.runs);
            }
        }
        public void hypotheticalQuestionSelectedFourth()
        {
            String[] parts = optionalValue.Text.Split(':');
            if (parts.Length != 2)
            {
                MessageBox.Show(this, "Input the data in format ScoreX:OversX (20:1)", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else if (parts.Length == 2)
            {
                int ScoreX;
                float OverX;
                try
                {
                    ScoreX = int.Parse(parts[0].Trim());
                    if (ScoreIsLess(ScoreX, "* ScoreX cannot be less than the current score"))
                    {
                        return;
                    }
                    OverX = float.Parse(parts[1].Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "ScoreX can only be integer. OverX can only be integer or float. Please correct your input accordingly.", "Error: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                String afterDecimal;
                String[] partParts = OverX.ToString().Split('.');
                if (partParts.Length == 1) { afterDecimal = "0"; } //If there is no number after decimal, assign 0 as the number after zero. It would work as the balls.
                else { afterDecimal = partParts[1].Substring(0, 1); } //Else assign the decimal value
                int lessBalls = int.Parse(partParts[0]) * 6 + int.Parse(afterDecimal);
                if (overIsMore(lessBalls))
                {
                    return;
                }
                int remBalls = match.totalBowls - lessBalls - match.bowlingTeam.ballsBowled;  //Remaining balls = total ball in game - the balls the user wants the game to finish faster - balls actually bowled
                // lastQuestion.Text = hypotheticalQuestion.Items[hypotheticalQuestion.SelectedIndex].ToString();
                float hypotheticalCRR = ((((float)ScoreX - (float)match.battingTeam.runs) / (float)remBalls) * 6);
                hypotheticalRR.Text = hypotheticalCRR.ToString() + " RPO";
                verdictAndAll((int)(hypotheticalCRR * remBalls) / 6, match.bowlingTeam.runs);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (hypotheticalQuestion.SelectedIndex == -1) //None selected
            {
                this.hypotheticalQuestionNone();
            }
            else if (hypotheticalQuestion.SelectedIndex == 0) //What should be the Run Rate to Win?
            {
                this.hypotheticalQuestionSelectedFirst();
            }
            else if (hypotheticalQuestion.SelectedIndex == 1) //What should be the Run Rate to reach score X? 1
            {
                this.hypotheticalQuestionSelectedSecond();
            }
            else if (hypotheticalQuestion.SelectedIndex == 2) // What should be the Run Rate to Win with X overs remaining? 2 
            {
                this.hypotheticalQuestionSelectedThird();
            }
            else if(hypotheticalQuestion.SelectedIndex == 3) //What should be the Run Rate to reach score X with X overs remaining?
            {
                this.hypotheticalQuestionSelectedFourth();
            }
                /**
             * What should be the Run Rate to Win?  0 

             * What should be the Run Rate to reach score X? 1

             * What should be the Run Rate to Win with X overs remaining? 2 

             * What should be the Run Rate to reach score X with Y overs remaining? 3
             */
        }

        private void whatIfRunRateWasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hypotheticalQuestion.SelectedIndex = -1;
            optionalValue.Text = "";
            optionalLabel.Text = "";
            hypotheticalRR.Enabled = true;
            hypotheticalRRLabel.Text = "What if the run rate was";
            optionalValue.Enabled = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void errorText_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

