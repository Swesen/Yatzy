using System;

namespace Yatzy
{
    class Program
    {
        // rules
        private const int turns = 3;

        static string[] playerNames;
        static string[] scoreboardNames = new string[]
        {
            "Ones",
            "Twoes",
            "Threes",
            "Fours",
            "Fives",
            "Sixes",
            "Bonus (50)",
            "Pair",
            "Double pair",
            "Tripple",
            "Four of a kind",
            "House",
            "Small straight",
            "Full straight",
            "Chanse",
            "Yatzy (50)"
        };
        static int[,] scoreboard;

        static void Main(string[] args)
        {
            int numberOfPlayers = AskForNumberOfPlayers();

            playerNames = new string[numberOfPlayers];
            scoreboard = new int[numberOfPlayers, scoreboardNames.Length];

            // ask eatch player for their name
            AskForPlayerNames(numberOfPlayers);

            // enter game loop
            PlayGame();

            // print result and ask for a rematch with same players or new players
            PrintGameResults();

        }

        private static void PrintGameResults()
        {
            for (int i = 0; i < playerNames.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < scoreboardNames.Length; j++)
                {
                    sum += scoreboard[i, j];
                }
                Console.WriteLine($"{playerNames[i]}: {sum} points");
            }
        }

        private static void PlayGame()
        {
            for (int i = 0; i < scoreboardNames.Length; i++)
            {
                for (int player = 0; player < playerNames.Length; player++)
                {
                    int[] dice = new int[5];
                    // print out current player name and scoreboard
                    for (int turn = 0; turn < turns; turn++)
                    {
                        // roll dice then ask which to keep
                    }

                    // let player choose from a list of possible places to place dice rolls result
                }
            }
        }

        private static void AskForPlayerNames(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine("Player name: ");
                playerNames[i] = Console.ReadLine();
            }

            Console.WriteLine("Players in this game:");
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Console.WriteLine(playerNames[i]);
            }
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
