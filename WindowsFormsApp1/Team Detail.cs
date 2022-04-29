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
        public  int teamId;
        public int playerId;
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
            
            this.label36.Text = team.name;

            for (int i = 0; i < Form1.players.Length; i++)
                if (Teams_main.teams[i].teamId == this.teamId)
                    dataGridView1.Rows.Add(Form1.players[i].playerId, Form1.players[i].firstName, Form1.players[i].lastNam, Form1.players[i].height, Form1.players[i].weight, Form1.players[i].countryCode);

        }

        private void label36_Click(object sender, EventArgs e)
        {
           
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
           
        
        }
    }
}
