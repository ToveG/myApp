using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen. Var god välj en av följande val: 1, 2 eller 3");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("Kul att du valde nummer 1");
            }
            else if (userInput == "2")
            {
                Console.WriteLine("Tack för att du valde nummer 2.");
            }
            else if (userInput == "3")
            {
                Console.WriteLine("Number 3 it is.");
            }
            else {
                Console.WriteLine("Du har gjort ett felaktigt val.");
            }

            Console.ReadKey();

        }
    }
}
