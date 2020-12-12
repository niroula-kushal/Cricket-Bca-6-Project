using System;
using System.Windows.Forms;

namespace Cricket
{
    public partial class NextStrikeWindow : Form
    {
        Match match;
        public NextStrikeWindow(Match mt)
        {
            InitializeComponent();
            this.match = mt;
            Bats1.Text = match.batsman1.Name;
            Bats2.Text = match.batsman2.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Bats1.Checked)
            {
                match.onStrike = match.batsman1;
            }
            else
            {
                match.onStrike = match.batsman2;
            }
            this.Close();
        }
    }
}
