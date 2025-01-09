using Domino_Challenge.Core.Logic;
using Domino_Challenge.UI;
using Microsoft.Extensions.Logging;

public class Program
{

    static void Main(string[] args)
    {
        // Setup logger
        using var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();  // Log to console
        });

        // Create logger for DominoInputHandler
        var inputHandlerLogger = loggerFactory.CreateLogger<DominoInputHandler>();

        try
        {
            // Create an instance of ConsoleDominoInputHandler
            var inputHandler = new DominoInputHandler(inputHandlerLogger);
            var dominoes = inputHandler.GetDominoesFromUser();

            var displayer = new Displayer();
            displayer.DisplayDominoes(dominoes);

            // Find all possible circular chains.
            var chains = CircularChains.FindAllCircularChains(dominoes);

            // Display results.
            displayer.DisplayResult(chains);
        }
        catch (Exception ex)
        {
            // Create a logger for the Program class if you want to log program-wide errors
            var logger = loggerFactory.CreateLogger<Program>();
            logger.LogError(ex, "An unexpected error occurred.");
        }
    }
}