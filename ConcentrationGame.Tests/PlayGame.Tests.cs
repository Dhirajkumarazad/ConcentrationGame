using ConcentrationGame.Repository;
using System.Reflection;

namespace ConcentrationGame.Tests;

public class PlayGAmeTests
{
    private readonly string _path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    [Fact]
    public void PlayGame_ReturnsCorrectGame()
    {
        // Arrange
        var Game = GameRepositoryFile.GetGameData(Path.Combine(_path, @"SampleData\sample-data1.json"));
        var PlayGame = new PlayGame(Game.Boards, Game.Guesses);

        // Act
        string result = PlayGame.Play();

        // Assert
        Assert.Equal("The game data is correct.", result);
    }

    [Fact]
    public void PlayGame_ReturnsIncorrectBoard()
    {
        // Arrange
        var Game = GameRepositoryFile.GetGameData(Path.Combine(_path, @"SampleData\sample-data2.json"));
        var PlayGame = new PlayGame(Game.Boards, Game.Guesses);

        // Act
        string result = PlayGame.Play();

        // Assert
        Assert.Equal("Board data is incorrect.", result);
    }

    [Fact]
    public void PlayGame_ReturnsIncorrectGame()
    {
        // Arrange
        var Game = GameRepositoryFile.GetGameData(Path.Combine(_path, @"SampleData\sample-data3.json"));
        var PlayGame = new PlayGame(Game.Boards, Game.Guesses);

        // Act
        string result = PlayGame.Play();

        // Assert
        Assert.Equal("The game data is incorrect.", result);
    }

    [Fact]
    public void PlayGame_ReturnsErrorGame()
    {
        // Arrange
        var Game = GameRepositoryFile.GetGameData(Path.Combine(_path, @"SampleData\sample-data4.json"));
        var PlayGame = new PlayGame(Game.Boards, Game.Guesses);

        // Act
        string result = PlayGame.Play();

        // Assert
        Assert.Equal("Error in game data.", result);
    }
}
