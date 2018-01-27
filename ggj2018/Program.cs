using System;

namespace ggj2018
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            using (var game = new LabEscapeGame()) {
                game.Run();
            }
                
        }
    }
}
