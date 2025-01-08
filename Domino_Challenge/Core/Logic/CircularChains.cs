using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Core.Logic;

public static class CircularChains
{
    /// <summary>
    /// Finds all possible circular chains that can be formed using the given dominoes.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to use.</param>
    /// <returns>A list of all valid circular chains.</returns>
    public static List<List<Domino>> FindAllCircularChains(List<Domino> dominoes)
    {
        var usedDominoes = new bool[dominoes.Count];
        var chain = new List<Domino>();
        var results = new List<List<Domino>>();

        // Attempts to start a chain with each domino.
        for (int i = 0; i < dominoes.Count; i++)
        {
            chain.Clear();
            Array.Fill(usedDominoes, false);

            FindChains(dominoes, usedDominoes, chain, dominoes[i], i, results);
        }

        return results;
    }

    /// <summary>
    /// Recursively finds all valid chains starting with the specified domino.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to use.</param>
    /// <param name="usedDominoes">An array indicating whether each domino has been used.</param>
    /// <param name="chain">The current chain being formed.</param>
    /// <param name="current">The current domino being added to the chain.</param>
    /// <param name="currentIndex">The index of the current domino in the list.</param>
    /// <param name="results">The list to store all valid chains.</param>
    static void FindChains(List<Domino> dominoes, bool[] usedDominoes, List<Domino> chain, Domino current,
        int currentIndex, List<List<Domino>> results)
    {
        // Add the current domino to the chain.
        chain.Add(current);
        // Mark the current domino as used
        usedDominoes[currentIndex] = true;

        // Base Case 1: If the chain contains all the dominoes, check if it forms a valid circular chain
        if (chain.Count == dominoes.Count)
        {
            // Base Case 2: A valid circular chain must start and end with the same number
            if (chain.First().Left == chain.Last().Right)
            {
                // Add the chain to results if it's circular.
                results.Add(new List<Domino>(chain));
            }
        }

        // Explore all unused dominoes for the next link in the chain.
        for (int i = 0; i < dominoes.Count; i++)
        {
            if (!usedDominoes[i])
            {
                var next = dominoes[i];

                // Try adding the domino as-is if it matches the current domino's right value.
                if (current.Right == next.Left)
                {
                    FindChains(dominoes, usedDominoes, chain, next, i, results);
                }

                // Try adding the flipped domino if it matches the current domino's right value.
                if (current.Right == next.Right)
                {
                    FindChains(dominoes, usedDominoes, chain, next.Flip(), i, results);
                }
            }
        }

        // Backtrack: unmark the current domino as used and remove it from the chain.
        usedDominoes[currentIndex] = false;
        chain.RemoveAt(chain.Count - 1);
    }
}