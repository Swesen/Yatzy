using System;

namespace Yatzy
{
    class Program
    {
        static string[] playerNames;
        static int[,] scoreboard;

        static void Main(string[] args)
        {
            int numberOfPlayers = AskForNumberOfPlayers();

            playerNames = new string[numberOfPlayers];
            scoreboard = new int[numberOfPlayers, 16];

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

        static void UpdatePlayerScore(int player, int scoreLine)
        {
            
        }
    }
}
