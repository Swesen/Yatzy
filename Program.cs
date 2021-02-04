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
            for(int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Player name: ");
                playerNames[i] = Console.ReadLine();
            }
          
            Console.WriteLine("Players in this game:");
            for(int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine(playerNames[i]);
            }
            
            int[] dice = new int[5];
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

        static int[] RandomDice(int amountOfDices)
        {
            Random rnd = new Random();
            int[] outputArray = new int[amountOfDices];

            for (int i = 0; i < amountOfDices; i++)
            {
                outputArray[i] = rnd.Next(1, 6);
            }
            return outputArray;
        }

        static void UpdatePlayerScore(int player, int scoreLine, int score)
        {
            scoreboard[player, scoreLine] = score;
        }
    }
}
