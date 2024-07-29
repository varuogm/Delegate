using Delegate;
using System;

public class DisplayPlayerNames
{
    //i will get a array and i will return a score... not sure what thing but it will be a INT for sure
    delegate int ScoreDelegate(PlayerStats stats);

    public void OnGameOver(List<PlayerStats> players)
    {
        // ayy i want most kills 

        //I have  a topscore function already  and i'll just give him the whole array and the criteia ,i will chose cretia by kills now
        string playerNameMostKills = GetPlayerNameTopScore(players, Criteria.ScoreByKillCountFunction);
        Console.WriteLine($"Player with most kills: {playerNameMostKills}");

        // ayy i want most flags captured 
        //I have  a topscore function already and i'll just give him the whole array and the criteia ,i will chose cretia by flags now
        string playerNameMostFlagsCaptured = GetPlayerNameTopScore(players, Criteria.ScoreByFlagCapturesFunction);
        Console.WriteLine($"Player with most flags captured: {playerNameMostFlagsCaptured}");
    }

    string GetPlayerNameTopScore(List<PlayerStats> allPlayerStats, ScoreDelegate scoreCalculator)
    {
        //mujhe lund faark nhi padta ,tujhe players leke konsa criteria pe top score nikalna hai
        // bas ye pata he data deke tujhe bas ek score wlaa number hi chiaye ,
        // criteria to apne hisab se send kardena 
        string name = "";
        int bestScore = 0;
        foreach (PlayerStats stats in allPlayerStats)
        {
            // yaha score aajke liye kills and kal flagscaptured dono nikalega
            int x = scoreCalculator(stats);
            if (x > bestScore)
            {
                bestScore = x;
                name = stats.name;
            }
        }
        return name;
    }
}

public class PlayerStats
{
    public int kills;
    public int flagsCaptured;
    public string deaths;
    public string name;
}

public class Program
{
    public static void Main(string[] args)
    {
        List<PlayerStats> players = new List<PlayerStats>
        {
            new PlayerStats { name = "Alice", kills = 10, flagsCaptured = 3, deaths = "2" },
            new PlayerStats { name = "Bob", kills = 8, flagsCaptured = 5, deaths = "3" },
            new PlayerStats { name = "Charlie", kills = 15, flagsCaptured = 2, deaths = "4" },
            new PlayerStats { name = "Diana", kills = 12, flagsCaptured = 4, deaths = "1" }
        };

        DisplayPlayerNames displayNames = new DisplayPlayerNames();
        displayNames.OnGameOver(players);
    }
}