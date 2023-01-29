using System.Text.Json.Serialization;

namespace ConcentrationGame.Model;
public class Guess
{
    [JsonPropertyName("guess")]
    public List<string> Guesses { get; set; }
    [JsonPropertyName("score")]
    public int Score { get; set; }
    public Guess(List<string> guesses, int score)
    {
        Guesses = guesses;
        Score = score;
    }
}
