using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class BuzzFizz
    {
        public string FBGame()
        {
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    return "fizz";
                }

                else if (i % 5 == 0)
                {
                    return "buzz";
                }

                else if (i % 5 == 0 && i % 3 == 0)
                {
                    return "FizzBuzz";
                }
            }
            return "Invali";
        }
    }
}
