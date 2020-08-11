using System;
using System.Collections.Generic;
using System.Text;

namespace ZigluTestAutomationFramework_ZeeTAF_.DataObjects
{
    public class TrophiesDtoApi
    {
        public TrophiesApi Api { get; set; }
    }

    public class TrophiesApi
    {
        public string results { get; set; }
        public List<Trophies> Trophies { get; set; }
    }

    public class Trophies
    {
        public string leauge { get; set; }
        public string country { get; set; }
        public string season { get; set; }
        public string place { get; set; }
    }

 }

