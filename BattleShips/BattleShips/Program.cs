using System;
using System.IO;
using System.Collections.Generic;
using BattleShips;
using System.Linq;



namespace BattleShips
{
    class Battleships
    {
        public Player Player1 { get; set; }

        public Battleships()
        {
            //Setup player class for game initialisation
            Player1 = new Player();

        }
        static void Main()
        {
            //Initialise the game by creating a playspace, placing ships and showing the board
            Battleships Game1 = new Battleships();
            Game1.Player1.PlaceShips();
            Game1.Player1.OutPutPlaySpace();

            do //Whilst not all ships are sunk, ask player for input and calculate it on the boardstate
            {
                Coords playerinput = Game1.Player1.InputCoords();
                Game1.Player1.ProcessShot(playerinput);
                Game1.Player1.OutPutPlaySpace();
            } while (Game1.Player1.HasWon == false);
            //If player has sunk all the ships, print the message and wait for user input
            Console.WriteLine("You sunk all the battleships, you won the game!");
            Console.ReadKey();
        }
    }
}
