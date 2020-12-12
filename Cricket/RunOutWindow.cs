using System;
using System.Windows.Forms;

namespace Cricket
{
    public partial class RunOutWindow : Form
    {
        Match match;
        public RunOutWindow(Match mt)
        {
            this.match = mt;
            InitializeComponent();
            nameB1.Text = match.batsman1.Name;
            nameB2.Text = match.batsman2.Name;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nameB1.Checked)
            {
                match.BatsMan1 = false;
                match.batsman1.OutAlready = true;
            }
            else
            {
                match.BatsMan2 = false;
                match.batsman2.OutAlready = true;
            }
            this.Close();
        }
    }
}
