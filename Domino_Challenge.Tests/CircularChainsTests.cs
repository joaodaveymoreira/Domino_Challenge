using Domino_Challenge.Core.Initialization;
using Domino_Challenge.Core.Logic;
using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Tests;

public class CircularChainsTests
{
    [Fact]
    public void FindAllCircularChains_ValidCircularChain_ReturnsValidChains()
    {
        // Arrange
        var dominoes = InitializeDominoes.InitDominoes();

        // Act
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Assert
        Assert.NotEmpty(chains);
        Assert.Contains(chains, chain => chain[0].Left == chain[chain.Count - 1].Right); // Circular check
    }

    [Fact]
    public void FindAllCircularChains_InvalidCircularChain_ReturnsEmpty()
    {
        // Arrange
        var dominoes = new List<Domino>
        {
            new Domino(1, 2),
            new Domino(4, 1),
            new Domino(2, 3)
        };

        // Act
        var chains = CircularChains.FindAllCircularChains(dominoes);

        // Assert
        Assert.Empty(chains); // No valid circular chain
    }
}