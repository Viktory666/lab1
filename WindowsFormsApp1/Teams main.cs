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
    public partial class Teams_main : Form
    {
        Team[] teams = new Team[5];
        public Teams_main()
        {




            Team team = new Team();

            team.setAll(1, "Miami Heat", "MIA", "1.jpg");
            teams[0] = team;
            team.setAll(2, "Orlando Magic", "ORL", "2.jpg");
            teams[1] = team;
            team.setAll(3, "Atlanta Hawks", "ATL", "3.jpg");
            teams[2] = team;
            team.setAll(4, "Washington Wizards", "WSH", "4.jpg");
            teams[3] = team;
            team.setAll(5, "Charlotte Hornets", "CHA", "5.jpg");
            teams[4] = team;

                      

            
            InitializeComponent();

           // for (int i = 0; i < 5; i++) ;
          Controls["rn1"].Text = teams[0].name;
           
        }

        private void label35_Click(object sender, EventArgs e)
        {
           
                
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click_1(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_Main__2_();
            adminForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Visitor_Menu();
            adminForm.Show();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
