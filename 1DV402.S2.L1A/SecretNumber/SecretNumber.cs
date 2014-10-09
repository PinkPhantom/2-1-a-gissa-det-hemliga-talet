using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretNumber
{
    class SecretNumber
    {
        // F�lt
        public const int MaxNumberOfGuesses = 8;
        public int _count = MaxNumberOfGuesses;
        private int _secretNumber = -1;

        //Default konstruktor
        public SecretNumber()
        {
        }

        //Initialize slumpar ut ett random tal och s�tter det som _secretNumber
        public void Initialize()
        {
            Random random = new Random();
            _secretNumber = random.Next(1, 101);
        }

        //Gissar
        public bool MakeGuess(int number)
        {
            _count--;
            if (number > _secretNumber)
            {
                Console.WriteLine("{0} �r f�r h�gt. Du har {1} gissningar kvar", number, _count);
                if (_count == 0)
                {
                    Console.WriteLine("Det hemliga talet var {0}", _secretNumber);
                }
                return false;
            }
            else if (number < _secretNumber)
            {
                Console.WriteLine("{0} �r f�r l�gt. Du har {1} gissningar kvar", number, _count);
                if (_count == 0)
                {
                    Console.WriteLine("Det hemliga talet var {0}", _secretNumber);
                }
                return false;
            }
            else
            {
                Console.WriteLine("R�TT GISSAT. Du klarade det p� {0} f�rs�k", MaxNumberOfGuesses - _count);
                return true;
            }
        }
    }
}
