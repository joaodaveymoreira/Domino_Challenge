using Domino_Challenge.Core.Interfaces;
using Domino_Challenge.Core.Models;

namespace Domino_Challenge.UI;

/// <summary>
/// Responsible for displaying dominoes or results to the user.
/// </summary>
public class DominoesDisplay : IDominoDisplay
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
    /// Throws an exception as this method is not intended to be used by this class.
    /// </summary>
    /// <param name="chains">The list of all valid circular chains.</param>
    public void DisplayResult(List<List<Domino>> chains)
    {
        throw new InvalidOperationException("DisplayResult method should not be called on DominoesDisplay.");
    }
}