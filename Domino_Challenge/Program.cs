using Domino_Challenge.Core.Logic;
using Domino_Challenge.UI;

public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ConsoleDominoInputHandler
        var inputHandler = new DominoInputHandler();
        var dominoes = inputHandler.GetDominoesFromUser();

        DominoDisplay.DisplayDominoes(dominoes);

        // Find all possible circular chains.
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Display results.
        DisplayResults.DisplayResult(chains);
    }
}