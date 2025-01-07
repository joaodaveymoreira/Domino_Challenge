namespace Domino_Challenge;

/// <summary>
/// Provides functionality to define and initialize dominoes.
/// </summary>
public static class DefineDominoes
{
    /// <summary>
    /// Initializes a predefined list of dominoes.
    /// </summary>
    /// <returns>A list of dominoes.</returns>
    public static List<Domino> InitializeDominoes()
    {
        var dominoes = new List<Domino>
        {
            new Domino(2, 1),
            new Domino(2, 3),
            new Domino(1, 3)
        };

        return dominoes;
    }
}