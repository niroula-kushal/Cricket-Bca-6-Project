using System;
using System.Windows.Forms;

namespace Cricket
{
    public partial class Form1 : Form
    {
        static int times = 0;
        Timer tm = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            tm.Interval = 100;
            tm.Tick += tm_Tick;
            tm.Start();
            label1.Text = DateTime.Now.ToString();
         
        }

        void tm_Tick(object sender, EventArgs e)
        {
            
            String[] files = { "MainForm.cs","ShowOffForm.cs","RunOutWindow.cs","NextStrikeWindow.cs","App.config","app.manifest"};
            Random rn = new Random();
            int i = rn.Next(0, files.Length);
            label1.Text = "Loading: " + files[i]; 
            if(++times == 30)
            {
                tm.Enabled = false;
                this.Hide();
                Form2 fm = new Form2();
                fm.ShowDialog(); 
                this.Close();   //the application will close as soon as form2 closes
            }
        }

    }
}
