namespace Domino_Challenge.Core.Models;

/// <summary>
/// Represents a domino tile with a left and right value.
/// </summary>
public class Domino
{
    public int Left { get; set; }
    public int Right { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Domino"/> class.
    /// </summary>
    /// <param name="left">The left value of the domino.</param>
    /// <param name="right">The right value of the domino.</param>
    public Domino(int left, int right)
    {
        Left = left;
        Right = right;
    }

    /// <summary>
    /// Returns a string representation of the domino in the format [Left|Right].
    /// </summary>
    public override string ToString() => $"[{Left}|{Right}]";

    /// <summary>
    /// Returns a flipped version of this domino.
    /// </summary>
    public Domino Flip() => new Domino(Right, Left);
}