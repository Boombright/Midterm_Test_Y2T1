using System;

namespace Midterm_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum;
            bool gamestate = true;
            gamesystem game = new gamesystem();
            while (gamestate)
            {
                Console.WriteLine("Welcome to Hangman Game");
                Console.WriteLine("------------------------");
                Console.WriteLine("1.Play game");
                Console.WriteLine("2.Exit");
                Console.WriteLine();
                Console.WriteLine("input number and press enter");
                inputNum = Console.ReadLine();
                if(inputNum == "1")
                {
                    game.Startgame();
                }
                if (inputNum == "2")
                {
                    Console.WriteLine("Understandable Have a nice day :)");
                    gamestate = false;
                }
                else
                    Console.Clear();
            }
        }
    }
}
