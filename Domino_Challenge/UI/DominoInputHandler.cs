using Domino_Challenge.Core.Initialization;
using Domino_Challenge.Core.Interfaces;
using Domino_Challenge.Core.Models;
using Microsoft.Extensions.Logging;

namespace Domino_Challenge.UI;

/// <summary>
/// Provides functionality to handle user input for selecting and generating dominoes.
/// </summary>
public class DominoInputHandler : IDominoInputHandler
{
    private readonly ILogger<DominoInputHandler> _logger;

    // Constructor with ILogger dependency
    public DominoInputHandler(ILogger<DominoInputHandler> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Prompts the user to select between predefined dominoes or generating random dominoes.
    /// It ensures valid input and returns the corresponding list of dominoes.
    /// </summary>
    /// <returns>A list of dominoes based on user input.</returns>
    public List<Domino> GetDominoesFromUser()
    {
        bool isValidInput = false;
        List<Domino> dominoes = new List<Domino>();

        // Keep prompting the user until valid input is received
        while (!isValidInput)
        {
            try
            {
                Console.WriteLine("Enter 1 to use predefined dominoes, 2 to generate random dominoes, or 0 to exit:");
                var choice = Console.ReadLine()?.Trim();

                switch (choice)
                {
                    case "1":
                        dominoes = HandlePredefinedDominoes();
                        isValidInput = true;
                        break;
                    case "2":
                        dominoes = HandleRandomDominoesInput();
                        isValidInput = true;
                        break;
                    case "0":
                        HandleExit();
                        break;
                    default:
                        HandleInvalidOption();
                        break;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing user input.");
            }
        }

        return dominoes;
    }

    /// <summary>
    /// Handles the predefined dominoes case.
    /// </summary>
    /// <returns>A predefined list of dominoes.</returns>
    private List<Domino> HandlePredefinedDominoes()
    {
        Console.Clear();
        return InitializeDominoes.InitDominoes();
    }

    /// <summary>
    /// Handles the random dominoes generation case.
    /// </summary>
    /// <returns>A list of randomly generated dominoes.</returns>
    private List<Domino> HandleRandomDominoesInput()
    {
        List<Domino> dominoes = new List<Domino>();
        bool isValidDominoesInput = false;

        while (!isValidDominoesInput)
        {
            Console.Write("Enter the number of dominoes to generate: ");
            if (int.TryParse(Console.ReadLine()?.Trim(), out var count) && count > 0)
            {
                dominoes = InitializeDominoes.GenerateRandomDominoes(count);
                isValidDominoesInput = true;
                Console.Clear();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid number of dominoes. Please enter a positive integer.\n");
            }
        }

        return dominoes;
    }

    /// <summary>
    /// Handles the exit case, terminating the application.
    /// </summary>
    private void HandleExit()
    {
        Console.WriteLine("Exiting program...");
        Environment.Exit(0);
    }

    /// <summary>
    /// Handles invalid input by notifying the user.
    /// </summary>
    private void HandleInvalidOption()
    {
        Console.Clear();
        Console.WriteLine("Invalid option. Please enter 1, 2, or 0 to exit.\n");
    }
}