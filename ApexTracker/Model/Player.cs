using System.Collections.Generic;

namespace ApexTracker.Model
{
    public class Rank
    {
        public int rankScore { get; set; }
        public string rankName { get; set; }
        public int rankDiv { get; set; }
        public int ladderPosPlatform { get; set; }
        public string rankImg { get; set; }
        public string rankedSeason { get; set; }
        public int rankPos { get; set; }
        public double topPercent { get; set; }
    }

    public class Arena
    {
        public int rankScore { get; set; }
        public string rankName { get; set; }
        public int rankDiv { get; set; }
        public int ladderPosPlatform { get; set; }
        public string rankImg { get; set; }
        public string rankedSeason { get; set; }
    }

    public class Global
    {
        public string name { get; set; }
        public long uid { get; set; }
        public string avatar { get; set; }
        public string platform { get; set; }
        public int level { get; set; }
        public int toNextLevelPercent { get; set; }
        public int internalUpdateCount { get; set; }
        public Rank rank { get; set; }
        public Arena arena { get; set; }
    }

    public class Player
    {
        public Global global { get; set; }
    }


}
