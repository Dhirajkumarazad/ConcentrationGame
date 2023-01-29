using ConcentrationGame.Counter;
using ConcentrationGame.Model;

namespace ConcentrationGame;
public class PlayGame
{
    private readonly List<string> _boards;
    private readonly List<Guess> _guesses;
    private readonly PairsCounter _pairsCounter;

    public PlayGame(List<string> boards, List<Guess> guesses)
    {
        _boards = boards;
        _guesses = guesses;
        _pairsCounter = new();

        foreach (var letter in boards)
        {
            _pairsCounter.AddLetter(letter);
        }
    }

    /// <summary>
    /// Logic to play the game
    /// </summary>
    /// <returns>The correct output message</returns>
    public string Play()
    {
        if (_pairsCounter.AreAllLettersPaired())
        {            
            int pairsCount = _pairsCounter.GetCountOfPairs();
            int finalScore = 0;

            foreach (Guess guess in _guesses)
            {
                if (_boards[Int32.Parse(guess.Guesses[0]) - 1] == _boards[Int32.Parse(guess.Guesses[1]) - 1])
                {
                    finalScore -= 1;
                    pairsCount -= 1;
                    if(pairsCount == 0)
                    {
                        return "The game data is correct.";
                    }
                }
                else
                {
                    finalScore += 7;
                }

                if (finalScore != guess.Score)
                {
                    return "The game data is incorrect.";
                }
            }

            if (pairsCount != 0)
            {
                return "Error in game data.";
            }
            
        }

        return "Board data is incorrect.";
    }
}


