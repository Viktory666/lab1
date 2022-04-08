using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Team_Detail : Form
    {
        public static int teamId;
        Team team = new Team();
         
        public Team_Detail()
        {
            
            
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_main();
            adminForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {

            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {

        }

        private void Team_Detail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                if (teamId == Teams_main.teams[i].teamId)                    
            this.team = Teams_main.teams[i];
            

        }

        private void label36_Click(object sender, EventArgs e)
        {
           
        }
    }
}
