using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public static class FunctionalTemplate
    {
        public static void Run(Action start,Action takeTurn, Func<bool> haveWinner, Func<int> winningPlayer)
        {
            start();
            while (!haveWinner())
                takeTurn();

            Console.WriteLine($"Player {winningPlayer()} wins.");
        }

    }

    public class Demo2
    {
        static void Main3(String[] args)
        {
            var numberOfPlayers = 3;
            int currentPlayer = 0;
            int turn = 1, maxTurns = 10;

            void Start()
            {
                Console.WriteLine($"Starting a game of chess with {numberOfPlayers} players.");
            }

            bool haveWinner()
            {
                return turn == maxTurns;
            }

            void TakeTurn()
            {
                Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
                currentPlayer = (currentPlayer + 1) % numberOfPlayers;
            }

            int WinningPlayer()
            {
                return currentPlayer;
            }

            FunctionalTemplate.Run(Start, TakeTurn, haveWinner, WinningPlayer);
        }
    }
}
