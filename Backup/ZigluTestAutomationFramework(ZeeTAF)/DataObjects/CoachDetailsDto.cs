using System;
using System.Collections.Generic;
using System.Text;

namespace ZigluTestAutomation
{

    public class CoachDetailsDtoApi
    {
        public CoachApi Api { get; set; }
        
    }

    public class CoachApi
    {
        public string results { get; set; }
        public List<Coachs> coachs { get; set; }
        public List<Career> career { get; set; }
    }



  public  class Coachs
    {
        public int id { get; set; }
        public string  name { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int  age { get; set; }
        public string birth_date { get; set; }
        public string birth_place { get; set; }
        public string birth_country { get; set; }
        public string nationality { get; set; }
        public int  height { get; set; }
        public int weight { get; set; }
        public List<Team> team { get; set; }
    }



    public class Team
    {
        public int id { get; set; }
        public string  name { get; set; }
    }

    public class Career
        {
            public List<CareerTeam> team { get; set; }
            public string start { get; set; }
            public string end { get; set; }
    }

 
    public class CareerTeam
    {
        public int id { get; set; }
        public string name { get; set; }
    }


}
