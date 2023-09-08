using LA1300_RandomNumberGuesser.RNGAndPoints;
using LA1300_RandomNumberGuesser.GenerateNumber;
using LA1300_RandomNumberGuesser.Player;


using System;

namespace LA1300_RandomNumberGuesser
{
    internal class Program
    {
        static void Main()
        {
            
       

            Console.WriteLine("Geben gib deinen Namen ein:");
            PlayerCreate player1 = new PlayerCreate(Console.ReadLine());

           
            GuessNumb guessingGame = new GuessNumb();
            guessingGame.MakeGuess();

            Console.WriteLine($"Danke fürs Spielen {player1.PlayerName} bis zum nächsten Mal.");
            
            
        }
    }
}