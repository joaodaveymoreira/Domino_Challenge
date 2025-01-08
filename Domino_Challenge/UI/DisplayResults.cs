using Domino_Challenge.Core.Interfaces;
using Domino_Challenge.Core.Models;

namespace Domino_Challenge.UI;

/// <summary>
/// Provides functionality to display results for circular domino chains.
/// </summary>
public class DisplayResults : IDominoDisplay
{
    /// <summary>
    /// Throws an exception as this method is not intended to be used by this class.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to display.</param>
    public void DisplayDominoes(List<Domino> dominoes)
    {
        throw new InvalidOperationException("DisplayDominoes method should not be called on DisplayResults.");
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