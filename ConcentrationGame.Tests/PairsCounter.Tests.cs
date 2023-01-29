using ConcentrationGame.Counter;
using System.Diagnostics.Metrics;

namespace ConcentrationGame.Tests;

public class PairsCounterTests
{   
    [Fact]
    public void AreAllLettersPaired_ReturnsValidFalseData()
    {
        // Arrange
        List<string> letters = new() { "AA", "BB", "BB", "DD", "CC", "CC", "AA", "A" , "A"};
        PairsCounter pairsCounter = new();
        foreach (string letter in letters)
        {
            pairsCounter.AddLetter(letter);
        }

        // Act
        bool paired = pairsCounter.AreAllLettersPaired();

        // Assert
        Assert.False(paired);
    }

    [Fact]
    public void AreAllLettersPaired_ReturnsValidTrueData()
    {
        // Arrange
        List<string> letters = new() { "A", "B", "C", "D", "E", "F", "A", "B", "C", "D", "E", "F", "G", "G", "G", "G" , "HH", "HH", "III", "III"};
        PairsCounter pairsCounter = new();
        foreach (string letter in letters)
        {
            pairsCounter.AddLetter(letter);
        }

        // Act
        bool paired = pairsCounter.AreAllLettersPaired();

        // Assert
        Assert.True(paired);
    }

    [Fact]
    public void GetCountOfPairs_ReturnsValidData()
    {
        // Arrange
        List<string> letters = new() { "A", "A", "C", "C", "B", "B", "A", "A", "D", "E", "F", "HHH", "HHH"};
        PairsCounter pairsCounter = new();
        foreach(string letter in letters)
        {
            pairsCounter.AddLetter(letter);
        }

        // Act
        int count = pairsCounter.GetCountOfPairs();

        // Assert
        Assert.Equal(5, count);
    }
}
