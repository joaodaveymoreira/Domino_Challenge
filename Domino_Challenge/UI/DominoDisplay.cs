using Domino_Challenge.Core.Models;

namespace Domino_Challenge.UI;

/// <summary>
/// Responsible for displaying dominoes or results to the user.
/// </summary>
public static class DominoDisplay
{
    /// <summary>
    /// Displays the list of dominoes.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to display.</param>
    public static void DisplayDominoes(List<Domino> dominoes)
    {
        Console.WriteLine("Dominoes:");
        Console.WriteLine(string.Join(" ", dominoes));
    }
}