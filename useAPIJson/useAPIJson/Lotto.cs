using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace useAPIJson
{
    public class Lotto
    {
        public string drwNo1 { get; set; }
        public string drwNo2 { get; set; }
        public string drwNo3 { get; set; }
        public string drwNo4 { get; set; }
        public string drwNo5 { get; set; }
        public string drwNo6 { get; set; }
        public string bnusNo { get; set; }
        public string drwNo { get; set; }
        public string drwNoDate { get; set; }

        public Lotto(string drwNo1, string drwNo2, string drwNo3, string drwNo4, string drwNo5, string drwNo6, string bnusNo, string drwNo, string drwNoDate)
        {
            this.drwNo1 = drwNo1;
            this.drwNo2 = drwNo2;
            this.drwNo3 = drwNo3;
            this.drwNo4 = drwNo4;
            this.drwNo5 = drwNo5;
            this.drwNo6 = drwNo6;
            this.bnusNo = bnusNo;
            this.drwNo = drwNo;
            this.drwNoDate = drwNoDate;
        }
    }


}
