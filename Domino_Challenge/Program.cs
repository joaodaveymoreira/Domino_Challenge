using Domino_Challenge.Core.Logic;
using Domino_Challenge.UI;

public class Program
{
    static void Main(string[] args)
    {
        // Create an instance of ConsoleDominoInputHandler
        var inputHandler = new DominoInputHandler();
        var dominoes = inputHandler.GetDominoesFromUser();

        var displayDominoes = new DominoesDisplay();
        displayDominoes.DisplayDominoes(dominoes);

        // Find all possible circular chains.
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Display results.
        var displayResults = new DisplayResults();
        displayResults.DisplayResult(chains);
    }
}