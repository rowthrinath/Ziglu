using System;
using System.Collections.Generic;
using System.Text;

namespace ZigluTestAutomation
{

    public class LeaugeScoresDtoApi
    {    
        public Api Api { get; set; }       
    }

    public class Api
    {
        public string results { get; set; }
        public statistics statistics { get; set; }     
    }

  public  class statistics
    {
        public Matchs Matchs { get; set; }
        public Goals Goals { get; set; }
        public GoalsAverage GoalsAverage { get; set; }
    }

    public class Matchs
    {
        public List<MatchsPlayed> MatchesPlayed { get; set; }
        public List<Wins> Wins { get; set; }
        public List<Draws> Draws { get; set; }
        public List<Loses> Loses { get; set; }
    }
    public class MatchsPlayed
        { 
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
        }

 
    public class Wins
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Draws
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Loses
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class Goals
    {
        public List<GoalsFor> GoalsFor { get; set; }
        public List<GoalsAgainst> GoalsAgainst { get; set; }
    }

    public class GoalsFor
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class GoalsAgainst
    {
        public int home { get; set; }
        public int away { get; set; }
        public int total { get; set; }
    }

    public class GoalsAverage
    {
        public List<GoalsForAverage> GoalsForAverage { get; set; }
        public List<GoalsAgainstAverage> GoalsAgainstAverage { get; set; }
    }

    public class GoalsForAverage
    {
        public decimal home { get; set; }
        public decimal away { get; set; }
        public decimal total { get; set; }
    }

    public class GoalsAgainstAverage
    {
        public decimal home { get; set; }
        public decimal away { get; set; }
        public decimal total { get; set; }
    }

}
