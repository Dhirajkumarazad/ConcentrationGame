using ConcentrationGame.Repository;

namespace ConcentrationGame;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            var Game = GameRepositoryFile.GetGameData(args[0]);
            var PlayGame = new PlayGame(Game.Boards, Game.Guesses);
            Console.WriteLine(PlayGame.Play());
        }
        catch (Exception)
        {
            Console.WriteLine("The program has run into an error.");
        }
    }
}
