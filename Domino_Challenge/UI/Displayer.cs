using Domino_Challenge.Core.Interfaces;
using Domino_Challenge.Core.Models;

namespace Domino_Challenge.UI;

/// <summary>
/// Provides functionality for displaying dominoes and circular chain results.
/// </summary>
public class Displayer : IDisplayer

{
    /// <summary>
    /// Displays the list of dominoes.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to display.</param>
    public void DisplayDominoes(List<Domino> dominoes)
    {
        Console.WriteLine("Dominoes:");
        Console.WriteLine(string.Join(" ", dominoes));
    }

    /// <summary>
    /// Displays the circular chains or a message indicating no chains are possible.
    /// </summary>
    /// <param name="chains">The list of all valid circular chains.</param>
    public void DisplayResult(List<List<Domino>> chains)
    {
        if (chains.Count == 0)
        {
            Console.WriteLine("\nNo circular chain is possible.");
        }
        else
        {
            Console.WriteLine("\nCircular chains:\n");
            foreach (var chain in chains)
            {
                Console.WriteLine(string.Join(" ", chain));
            }
        }
    }
}