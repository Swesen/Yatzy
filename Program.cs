using System;

namespace Yatzy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlayers = AskForNumberOfPlayers();

            string[] playerNames = new string[numberOfPlayers];
            int[,] scoreboard = new int[numberOfPlayers, 16];

            // ask eatch player for their name

            // enter game loop

            // print result and ask for a rematch with same players or new players
        }

        static int AskForNumberOfPlayers()
        {
            Console.Write("How many players: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out int amountOfPlayers))
            {
                return amountOfPlayers;
            }

            return 0; // error in player input handle in main

        }
    }
}
