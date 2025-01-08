using Domino_Challenge.Core.Models;

namespace Domino_Challenge.Core.Interfaces;

public interface IDominoInputHandler
{
    List<Domino> GetDominoesFromUser();
}