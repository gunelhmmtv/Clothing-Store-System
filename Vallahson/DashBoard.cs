using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vallahson
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Itemss itemss = new Itemss();
            itemss.Show();
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Categoryss categoryss = new Categoryss();
            categoryss.Show();
            Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Customerss customerss = new Customerss();
            customerss.Show();
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Billss billss = new Billss();
            billss.Show();
            Close();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            DashBoard dashboard = new DashBoard();
            dashboard.Show();
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
