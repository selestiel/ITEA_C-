using Xenko.Engine;

namespace MyGameXenko
{
    class MyGameXenkoApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
