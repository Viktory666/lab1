using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Player
    {
        public int Id;
        public int playerId;
        public String lastNam;
        public String firstName;
        public String height;
        public String weight;
        public String countryCode;

        public void setAll(int Id, int playerId, String lastNam, String firstName, String height, String weight, String countryCode)
        {
            this.Id = Id;
            this.playerId = playerId;
            this.lastNam = lastNam;
            this.firstName = firstName;
            this.height = height;
            this.weight = weight;
            this.countryCode = countryCode;


        }
    }
}
