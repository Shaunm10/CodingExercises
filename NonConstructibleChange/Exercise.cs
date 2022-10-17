namespace CodingExercises.NonConstructibleChange;

public class Exercise
{
    /*
        Given an array of positive integers representing the values of coins in your possession, write a function 
        that returns the minimum amount of change (the minimum sum of money) that you cannot create. 
        The given coins can have any positive integer value and aren't necessarily unique 
        (i.e., you can have multiple coins of the same value).

        For example, if you're given coins = [1, 2, 5], the minimum amount of change that you can't create is 4. 
        If you're given no coins, the minimum amount of change that you can't create is 1.
    */

    public static int NonConstructibleChange(int[] coins)
    {
        // first sort the coins
        var sortedCoins = coins.OrderBy(x => x);

        var coinPermutations = GetPermutations(coins);
        var amountsCollected = coinPermutations
            .Select(x => x.Sum(c => c))
            .OrderBy(x => x)
            .ToList();

        var counter = 1;
        var amountFound = 0;
        while (counter < amountsCollected.Count())
        {
            // get the amount
            var amount = amountsCollected.FirstOrDefault(c => c == counter);

            if (amount != 0)
            {
                amountFound = amount;
            }
            else
            {
                break;
            }

            // increment the counter.
            counter++;
        }

        return counter;
    }

    private static List<List<int>> GetPermutations(int[] coins)
    {
        var variants = new List<List<int>>();
        for (int i = 0; i < coins.Length; i++)
        {
            variants.Add(coins.Take(i + 1).ToList());
        }

        if (coins.Length > 1)
        {
            variants.AddRange(GetPermutations(coins.Skip(1).ToArray()));
        }
        return variants;
    }
}
