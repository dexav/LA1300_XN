using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LA1300_RandomNumberGuesser.GenerateNumber;
using LA1300_RandomNumberGuesser.Player;

namespace LA1300_RandomNumberGuesser.RNGAndPoints
{
    internal class GuessNumb
    {
        private int _randomNumber;
        private int _tries;
        private int _guessNumb;
       
        
       

          
           

        public bool MakeGuess() {  //das diese Methode ein Bool ist, habe ich auch von Chat GPT.
           
            int Tries = this._tries;
            bool check = true;
            string again = "j";
            while (again == "j")
            {

                    GenerateRandomNumber random = new GenerateRandomNumber();
                    Tries = 0;
                    check = true;
                    Console.Clear();
                while (check)
                 {
                     try
                     {
                         Console.Write("Bitte rate eine Zahl zwischen 0 und 100: ");

                         string input1 = Console.ReadLine();
                         int input = Convert.ToInt32(input1);//Diese Line von Code habe von Chat GPT. Es überprüft ob der Int kein string oder so ist.
                         

                         if (input < 0 || input > 100)
                         {
                             Console.WriteLine("Deine Zahl muss zwischen 0-100 sein");

                         }
                       
                         if (input < random.RandomNumber)
                          {
                              Console.WriteLine(input + " ist zu klein");
                              Tries++;
                          }
                          else if (input > random.RandomNumber)
                          {
                              Console.WriteLine(input + " ist zu gross");
                              Tries++;
                          }
                          else if(input == random.RandomNumber)
                          {
                              Console.WriteLine($"Glückwunsch! Du hast die Zahl nach {Tries} Versuchen erraten.");
                              Console.ReadLine();
                              check = false;
                              
                          }
                        
                     }
                     catch (Exception ex)
                     {
                         Console.WriteLine("Ungütlige Eingabe");
                     }


                 }
            
           

                Console.WriteLine("Willst du nochmal spielen? (j/n)");
                again = Console.ReadLine();
                if (again == "n")
                {

                    break;
                }
            }
                 return false;
        }
    }
}
