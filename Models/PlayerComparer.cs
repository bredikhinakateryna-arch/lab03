using System.Collections.Generic;

namespace GameLeaderboard;

public class PlayerComparer : IComparer<Player>
{
    public int Compare(Player? x, Player? y)
    {
        if (x is null && y is null) return 0;
        if (x is null) return -1;  
        if (y is null) return 1;  

        int mmrComparison = y.MMR.CompareTo(x.MMR);

        if (mmrComparison != 0)
        {
            return mmrComparison;
        }

        return x.SummonerName.CompareTo(y.SummonerName);
    }
}