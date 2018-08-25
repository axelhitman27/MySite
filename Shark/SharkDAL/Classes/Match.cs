using System;

namespace SharkDAL.Classes
{
    public class Match : BaseClass
    {
        public DateTime DatePlayed { get; set; }
        public int HomeTeamId { get; set; }
        public int AwayTeamId { get; set; }
        public char Result { get; set; }
        public int LeagueId { get; set; }
        public int SeasonId { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
    }
}