using Domino_Challenge.Core.Initialization;
using Domino_Challenge.Core.Models;
using Domino_Challenge.UI;

namespace Domino_Challenge.Tests;

public class DisplayerTests
{
    [Fact]
    public void Displayer_DisplaysDominesCorrectly()
    {
        // Arrange
        var dominoes = InitializeDominoes.InitDominoes();

        // Capture the output using StringWriter
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var displayer = new Displayer(); // Use the existing constructor

        // Act
        displayer.DisplayDominoes(dominoes);

        // Assert
        var output = stringWriter.ToString();
        Assert.Contains("[2|1]", output);
        Assert.Contains("[2|3]", output);
        Assert.Contains("[1|3]", output);
    }

    [Fact]
    public void Displayer_DisplaysResultsCorrectly()
    {
        // Arrange
        var chains = new List<List<Domino>>
        {
            new List<Domino>
            {
                new Domino(1, 2),
                new Domino(2, 3)
            },
            new List<Domino>
            {
                new Domino(4, 5),
                new Domino(5, 6)
            }
        };

        // Capture the output using StringWriter
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var displayer = new Displayer(); // Use the existing constructor

        // Act
        displayer.DisplayResult(chains);

        // Assert
        var output = stringWriter.ToString();
        Assert.Contains("Circular chains:", output);
        Assert.Contains("[1|2] [2|3]", output); // Assert that the first chain is displayed correctly
        Assert.Contains("[4|5] [5|6]", output); // Assert that the second chain is displayed correctly
    }

    [Fact]
    public void Displayer_DisplaysNoChainMessage_WhenNoChainsExist()
    {
        // Arrange
        var chains = new List<List<Domino>>(); // Empty list of chains

        // Capture the output using StringWriter
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        var displayer = new Displayer(); // Use the existing constructor

        // Act
        displayer.DisplayResult(chains);

        // Assert
        var output = stringWriter.ToString();
        Assert.Contains("No circular chain is possible.", output); // Assert the message when no chains exist
    }
}