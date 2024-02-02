using OTUS_DZ_3_SOLID.Services;

namespace OTUS_DZ_3_SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(new RandomGenerator(), new Binder(), new ConsoleReader(), new GameService());

            game.Start();
        }
    }
}
