using Domino_Challenge.Core.Models;

namespace Domino_Challenge.UI;

/// <summary>
/// Provides functionality to display results for circular domino chains.
/// </summary>
public static class DisplayResults
{
    /// <summary>
    /// Displays the circular chains or a message indicating no chains are possible.
    /// </summary>
    /// <param name="chains">The list of all valid circular chains.</param>
    public static void DisplayResult(List<List<Domino>> chains)
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