using Domino_Challenge.UI;
using Microsoft.Extensions.Logging;
using Moq;

namespace Domino_Challenge.Tests;

public class DominoInputHandlerTests
{
    [Fact]
    public void GetDominoesFromUser_ValidInput_UsesPredefinedDominoes()
    {
        // Arrange
        var predefinedInput = "1" + Environment.NewLine; // Simulate entering "1" for predefined dominoes
        var stringReader = new StringReader(predefinedInput);
        Console.SetIn(stringReader);

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var mockLogger = new Mock<ILogger<DominoInputHandler>>();
        var dominoInputHandler = new DominoInputHandler(mockLogger.Object);

        // Act
        var result = dominoInputHandler.GetDominoesFromUser();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(3, result.Count); // Assuming the predefined list has 3 dominoes

        // Restore the original console streams
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
    }

    [Fact]
    public void GetDominoesFromUser_ValidInput_GeneratesRandomDominoes()
    {
        // Arrange
        var predefinedInput = "2" + Environment.NewLine + "5" + Environment.NewLine; // Simulate user selecting random dominoes and entering the number 5
        var stringReader = new StringReader(predefinedInput);
        Console.SetIn(stringReader);

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var mockLogger = new Mock<ILogger<DominoInputHandler>>();
        var dominoInputHandler = new DominoInputHandler(mockLogger.Object);

        // Act
        var result = dominoInputHandler.GetDominoesFromUser();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count); // Random dominoes count

        // Restore the original console streams
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
    }

    [Fact]
    public void GetDominoesFromUser_InvalidInput_KeepsAsking()
    {
        // Arrange
        var predefinedInput = "3" + Environment.NewLine + "2" + Environment.NewLine + "-1" + Environment.NewLine + "5" + Environment.NewLine;
        var stringReader = new StringReader(predefinedInput);
        Console.SetIn(stringReader);

        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var mockLogger = new Mock<ILogger<DominoInputHandler>>();
        var dominoInputHandler = new DominoInputHandler(mockLogger.Object);

        // Act
        var result = dominoInputHandler.GetDominoesFromUser();

        // Assert
        Assert.NotNull(result);
        Assert.Equal(5, result.Count); // Should have 5 dominoes after valid input

        // Restore the original console streams
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        Console.SetOut(new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true });
    }
}