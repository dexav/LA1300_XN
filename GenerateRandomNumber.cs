using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA1300_RandomNumberGuesser.GenerateNumber
{
    internal class GenerateRandomNumber
    {
        private int _randomNumber;  
        public GenerateRandomNumber()
        {
           
            
            
               
                
                Random random = new Random();
                _randomNumber = random.Next(0, 101);
                 

            
        }
        public int RandomNumber
        {
            get { return _randomNumber; }   
        }
    }
}
