using System;

namespace ggj2018
{
    class MainClass
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var game = new LabEscapeGame()) {
                game.Run();
            }
                
        }
    }
}
