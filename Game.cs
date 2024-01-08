using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
  
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            Console.WriteLine("Welcome to Hangman!");
            string[] listwords = new string[10];
            listwords[0] = "sheep";
            listwords[1] = "goat";
            listwords[2] = "computer";
            listwords[3] = "america";
            listwords[4] = "watermelon";
            listwords[5] = "icecream";
            listwords[6] = "jasmine";
            listwords[7] = "pineapple";
            listwords[8] = "orange";
            listwords[9] = "mango";
            Random randGen = new Random();
            var idx = randGen.Next(0, 10);
            string mysteryWord = listwords[idx];
            char[] guess = new char[mysteryWord.Length];
            Console.Write("Please enter your guess: ");

            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';

            while (a)
            {
                char playerGuess = char.Parse(Console.ReadLine());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    if (playerGuess == mysteryWord[j])
                        guess[j] = playerGuess;
                }
                Console.WriteLine(guess);
                if (new string(guess) == mysteryWord)
                    a = false;
   }
            Console.WriteLine("You got the word :)");
            Console.Read();
        }
    }
}









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
  
    class Program
    {
        public static void Main(string[] args)
        {
           while (true)
           {
                int randno = Newnum(1, 101);
                int count = 1;
                while (true)
                {
                    Console.Write("Enter a number between 1 and 100(0 to quit):");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                        return;
                    else if (input < randno)
                    {
                        Console.WriteLine("Low, try again.");
                        ++count;
                        continue;
                    }
                    else if (input > randno)
                    {
                        Console.WriteLine("High, try again.");
                        ++count;
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("You guessed it! The number was {0}!", randno);
                        Console.WriteLine("It took you {0} {1}.\n", count, count == 1 ? "try" : "tries");
                        break;
                    }
                }
            }
         }
        static int Newnum(int min, int max)
        {
            Random random = new Random();
            return random = new Random();
            return random.Next(min, max);
        }
    }
}









using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCub
{
    class TowerOfHanoi
    {
        int m_numdiscs;
        public TowerOfHanoi()
        {
            numdiscs = 0;
        }
        public TowerOfHanoi(int newval)
        {
            numdiscs = newval;
        }
        public int numdiscs
        {
            get
            {
                return m_numdiscs;
            }
            set
            {
                if (value > 0)
                    m_numdiscs = value;
            }
        }public void movetower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, from, to);
                movetower(n - 1, other, to, from);
            }
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            TowerOfHanoi T = new TowerOfHanoi();
            string cnumdiscs;
            Console.Write("Enter the number of discs: ");
            cnumdiscs = Console.ReadLine();
            T.numdiscs = Convert.ToInt32(cnumdiscs);
            T.movetower(T.numdiscs, 1, 3, 2);
            Console.ReadLine();
        }
    }
}