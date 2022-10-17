namespace CodingExercises.TournamentWinner
{
    public class Exercise
    {
        /*
        
        There's an algorithms tournament taking place in which teams of programmers compete against each other to 
        solve algorithmic problems as fast as possible. 
        Teams compete in a round robin, where each team faces off against all other teams. 
        Only two teams compete against each other at a time, and for each competition, 
        one team is designated the home team, while the other team is the away team. 
        In each competition there's always 
        one winner and one loser; there are no ties. 
        A team receives 3 points if it wins and 0 points if it loses. 
        The winner of the tournament is the team that receives the most amount of points.

        Given an array of pairs representing the teams that have competed against each other and an array containing the results 
        of each competition, write a function that returns the winner of the tournament. 
        The input arrays are named competitions and results, respectively. 
        The competitions array has elements in the 
        form of [homeTeam, awayTeam], where each team is a string of at most 30 characters 
        representing the name of the team. 
        The results array contains information about the winner of each corresponding 
        competition in the competitions array. 
        Specifically, results[i] denotes the winner of competitions[i], 
        where a 1 in the results array means that the home 
        team in the corresponding competition won and a 0 means that the away team won.
        
        */

        public static string TournamentWinner(List<List<string>> competitions, List<int> results)
        {
            var languagePoints = new Dictionary<string, int>();

            for (var i = 0; i < competitions.Count; i++)
            {
                var currentMatch = competitions[i];
                var didHomeTimeWin = results[i] == 1;
                var winningLanguage = "";
                if (didHomeTimeWin)
                {
                    winningLanguage = currentMatch[0];
                }
                else
                {
                    winningLanguage = currentMatch[1];
                }

                if (languagePoints.Keys.Contains(winningLanguage))
                {
                    // update
                    languagePoints[winningLanguage] = languagePoints[winningLanguage] + 3;
                }
                else
                {
                    //insert
                    languagePoints[winningLanguage] = 3;

                }
            }

            var maxPoints = languagePoints.Max(x => x.Value);

            return languagePoints.ToList().FirstOrDefault(x => x.Value == maxPoints).Key;

        }
    }
}