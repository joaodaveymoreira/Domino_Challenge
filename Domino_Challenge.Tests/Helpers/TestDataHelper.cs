using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Tests.Helpers;

/// <summary>
/// A helper class containing methods to initialize test data for dominoes and chains.
/// </summary>
public static class TestDataHelper
{
    /// <summary>
    /// Initializes and returns a list of dominoes for testing purposes.
    /// </summary>
    /// <returns>A list of dominoes with predefined values.</returns>
    public static List<Domino> InitDominoes()
    {
        return new List<Domino>
        {
            // Initializing a list of dominoes with specific values for testing
            new Domino(1, 2),
            new Domino(4, 1),
            new Domino(2, 3)
        };
    }

    /// <summary>
    /// Initializes and returns a list of circular chains for testing purposes.
    /// A circular chain represents a series of connected dominoes.
    /// </summary>
    /// <returns>A list of circular chains, where each chain is a list of dominoes.</returns>
    public static List<List<Domino>> InitChains()
    {
        return new List<List<Domino>>
        {
            // First chain: [1|2], [2|3]
            new List<Domino>
            {
                new Domino(1, 2),
                new Domino(2, 3)
            },
            // Second chain: [4|5], [5|6]
            new List<Domino>
            {
                new Domino(4, 5),
                new Domino(5, 6)
            }
        };
    }
}