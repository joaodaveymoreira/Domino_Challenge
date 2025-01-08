using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Core.Interfaces;

/// <summary>
/// Defines the functionality for handling user input to retrieve a list of dominoes.
/// </summary>
public interface IDominoInputHandler
{
    /// <summary>
    /// Prompts the user to select between predefined dominoes or generating random dominoes.
    /// Ensures valid input and returns the corresponding list of dominoes.
    /// </summary>
    /// <returns>A list of dominoes based on user input.</returns>
    List<Domino> GetDominoesFromUser();
}