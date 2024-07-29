using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public static class Criteria
    {
        //critera wise scores
        public static int ScoreByKillCountFunction(PlayerStats ListOfPlayers)
        {
            return ListOfPlayers.kills;
        }
        public static int ScoreByFlagCapturesFunction(PlayerStats ListOfPlayers)
        {
            return ListOfPlayers.flagsCaptured;
        }
    }
}
