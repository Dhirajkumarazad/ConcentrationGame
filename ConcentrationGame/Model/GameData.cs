using System.Text.Json.Serialization;

namespace ConcentrationGame.Model;
public class GameData
{
    [JsonPropertyName("board")]
    public List<string> Boards { get; set; }
    [JsonPropertyName("guesses")]
    public List<Guess> Guesses { get; set; }
    public GameData(List<string> boards, List<Guess> guesses)
    {
        Boards = boards;
        Guesses = guesses;
    }
}
