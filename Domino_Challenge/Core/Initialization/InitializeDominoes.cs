using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Core.Initialization;

/// <summary>
/// Provides functionality to initialize dominoes.
/// </summary>
public static class InitializeDominoes
{
    /// <summary>
    /// Initializes a predefined list of dominoes.
    /// </summary>
    /// <returns>A list of dominoes.</returns>
    public static List<Domino> InitDominoes()
    {
        var dominoes = new List<Domino>
        {
            new Domino(2, 1),
            new Domino(2, 3),
            new Domino(1, 3)
        };

        return dominoes;
    }

    /// <summary>
    /// Generates a random list of dominoes.
    /// </summary>
    /// <param name="count">Number of dominoes to generate.</param>
    /// <returns>A random list of dominoes.</returns>
    public static List<Domino> GenerateRandomDominoes(int count)
    {
        var random = new Random();
        var dominoes = new List<Domino>();
        for (int i = 0; i < count; i++)
        {
            dominoes.Add(new Domino(random.Next(1, 7), random.Next(1, 7)));
        }
        return dominoes;
    }
}