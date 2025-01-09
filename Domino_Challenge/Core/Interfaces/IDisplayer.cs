using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Core.Interfaces;

/// <summary>
/// Defines functionality for displaying dominoes and results of circular domino chains.
/// </summary>
public interface IDisplayer
{
    /// <summary>
    /// Displays the list of dominoes.
    /// </summary>
    /// <param name="dominoes">The list of dominoes to display.</param>
    void DisplayDominoes(List<Domino> dominoes);

    /// <summary>
    /// Displays the results of circular domino chains.
    /// </summary>
    /// <param name="chains">The list of all valid circular chains.</param>
    void DisplayResult(List<List<Domino>> chains);
}