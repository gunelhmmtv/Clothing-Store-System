using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vallahson
{
    public partial class Splash : Form
    {
        public Splash()
        {
            
            InitializeComponent();
            timer1.Start();
        }
         int startP = 0;
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            startP += 1;
            MyProgressBar.Value = startP;
            Percent.Text = startP + "%";
            if (MyProgressBar.Value == 100)
            {
                MyProgressBar.Value = 0;
                Login Obj = new Login();
                Obj.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
