using Domino_Challenge;

public class Program
{
    static void Main(string[] args)
    {
        // Define the list of dominoes to form circular chains.
        var dominoes = DefineDominoes.InitializeDominoes();

        // Find all possible circular chains.
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Display results.
        DisplayResults.DisplayResult(chains);
    }
}