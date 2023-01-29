namespace ConcentrationGame.Counter;
public class PairsCounter
{
    private readonly Dictionary<string, int> _lettersCount;
    public PairsCounter()
    {
        _lettersCount = new Dictionary<string, int>();
    }

    /// <summary>
    /// Add letter to the dictionary
    /// </summary>
    /// <param name="letter"></param>
    public void AddLetter(string letter)
    {
        if (_lettersCount.ContainsKey(letter))
        {
            _lettersCount[letter]++;
        }
        else
        {
            _lettersCount[letter] = 1;
        }
    }

    /// <summary>
    /// Checks if all the letters are paired or not
    /// </summary>
    /// <returns>Returns true if all letters are paired else false</returns>
    public bool AreAllLettersPaired()
    {
        bool isCorrect = true;
        foreach (var count in _lettersCount.Values)
        {
            if (count % 2 != 0)
            {
                isCorrect = false;
                break;
            }
        }
        return isCorrect;
    }

    /// <summary>
    /// Counts the number of pairs
    /// </summary>
    /// <returns>Pairs count value</returns>
    public int GetCountOfPairs()
    {
        int pairsCount = 0;
        foreach (var count in _lettersCount.Values)
        {
            if (count % 2 == 0)
            {
                pairsCount += count/2;
            }
        }
        return pairsCount;
    }
}
