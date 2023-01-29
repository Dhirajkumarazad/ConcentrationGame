using System.Text.Json;
using ConcentrationGame.Model;

namespace ConcentrationGame.Repository;
public class GameRepositoryFile
{
    /// <summary>
    /// Reads the json file for input
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>s
    public static GameData GetGameData(string fileName)
    {
        // Read the JSON file
        string json = File.ReadAllText(fileName);

        // Deserialize the JSON into a C# object
        GameData game = JsonSerializer.Deserialize<GameData>(json);
        return game;
    }
}
