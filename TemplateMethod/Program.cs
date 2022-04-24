using System;

namespace TemplateMethod
{

    public abstract class Game
    {
        public void Run()
        {
            Start();
            while (!HaveWinner)
                TakeTurn();

            Console.WriteLine($"Player {WinningPlayer} wins.");
        }

       
        protected int currentPlayer;
        protected readonly int numberofPlayers;

        protected Game(int numberOfPlayers)
        {
            this.numberofPlayers = numberOfPlayers;

        }

        protected abstract void Start();
        protected abstract void TakeTurn();
        protected abstract bool HaveWinner { get; }
        protected abstract int WinningPlayer { get; }

    }


    public class chess : Game
    {
        public chess(int numberOfPlayers) : base(numberOfPlayers)
        {
                
        }
        protected override bool HaveWinner => turn == maxTurns;

        protected override int WinningPlayer => currentPlayer;

        protected override void Start()
        {
            Console.WriteLine($"Starting a game of chess with {numberofPlayers} players");
        }

        protected override void TakeTurn()
        {
            Console.WriteLine($"Turn {turn++} taken by player {currentPlayer}.");
            currentPlayer = (currentPlayer + 1) % numberofPlayers;
        }

        private int turn = 1;
        private int maxTurns = 10;
    }

    class Program
    {
        static void Main2(string[] args)
        {
            var chess = new chess(3);
            chess.Run();
        }
    }
}
