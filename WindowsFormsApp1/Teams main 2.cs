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
    public partial class Teams_Main__2_ : Form
    {
        Team[] teams = new Team[5];

        //imgList
        String[] imgList = new String[]
            {"16.jpg", "17.jpg", "18.jpg", "19.jpg", "20.jpg", "21.jpg", "22.jpg", "23.jpg", "24.jpg", "25.jpg", "26.jpg", "27.jpg", "28.jpg", "29.jpg", "30.jpg"};
        public Teams_Main__2_()
        {
            teams[0] = new Team();
            teams[0].setAll(1, 1, "Miami Heat", "MIA", "1.jpg");

            teams[1] = new Team();
            teams[1].setAll(1, 2, "Orlando Magic", "ORL", "2.jpg");

            teams[2] = new Team();
            teams[2].setAll(1, 3, "Atlanta Hawks", "ATL", "3.jpg");

            teams[3] = new Team();
            teams[3].setAll(1, 4, "Washington Wizards", "WSH", "4.jpg");

            teams[4] = new Team();
            teams[4].setAll(1, 5, "Charlotte Hornets", "CHA", "5.jpg");

            InitializeComponent();

            for (int i = 0; i < 5; i++)
                Controls["s" + (i + 1)].Text = teams[i].name;

            for (int i = 0; i < 5; i++)
                Controls["l" + (i + 1)].Text = teams[i].name;

            for (int i = 0; i < 5; i++)
                Controls["j" + (i + 1)].Text = teams[i].name;

            Lg1.Load("../../../Team/" + imgList[0]); Lg2.Load("../../../Team/" + imgList[1]); Lg3.Load("../../../Team/" + imgList[2]);
            Lg4.Load("../../../Team/" + imgList[3]); Lg5.Load("../../../Team/" + imgList[4]); Lg6.Load("../../../Team/" + imgList[5]);
            Lg7.Load("../../../Team/" + imgList[6]); Lg8.Load("../../../Team/" + imgList[7]); Lg9.Load("../../../Team/" + imgList[8]);
            Lg10.Load("../../../Team/" + imgList[9]); Lg11.Load("../../../Team/" + imgList[10]); Lg12.Load("../../../Team/" + imgList[11]);
            Lg13.Load("../../../Team/" + imgList[12]); Lg14.Load("../../../Team/" + imgList[13]); Lg15.Load("../../../Team/" + imgList[14]);

        }

        private void label33_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label39_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label61_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label63_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label64_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label40_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label41_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label60_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label62_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label67_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label56_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label57_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label59_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label65_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void label66_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail();
            adminForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form adminForm = new Teams_main();
            adminForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Visitor_Menu();
            adminForm.Show();
        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label45_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label49_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label50_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label54_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label42_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label44_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label48_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label51_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label55_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label43_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label46_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label47_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label52_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label53_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_2();
            adminForm.Show();
        }

        private void label38_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form adminForm = new Team_Detail_3();
            adminForm.Show();
        }
    }
}
