using Domino_Challenge;

public class Program
{
    static void Main(string[] args)
    {
        // Initializes the list of dominoes to form circular chains.
        var dominoes = InitializeDominoes.InitDominoes();

        // Find all possible circular chains.
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Display results.
        DisplayResults.DisplayResult(chains);
    }
}