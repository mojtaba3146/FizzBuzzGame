using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class BuzzFizz
    {
        public string FBGame(int number)
        {
            
                if (number % 3 == 0)
                {
                    return "fizz";
                }

                else if (number % 5 == 0)
                {
                    return "buzz";
                }

                else if (number % 5 == 0 && number % 3 == 0)
                {
                    return "FizzBuzz";
                }
            
            return "Invalid";
        }
    }
}
