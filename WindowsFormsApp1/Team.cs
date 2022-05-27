using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Team
    {
        public int Id2;
        public int teamId;
        public string name;
        string abbr;
        string logo;

        public void setAll(int Id2, int teamId, string name, string abbr, string logo)
        {
            
            this.Id2 = Id2;
            this.teamId = teamId;
            this.name = name;
            this.abbr = abbr;
            this.logo = logo;
        }
        
    }
}
