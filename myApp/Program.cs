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
            HandelUserInput handleInput = new HandelUserInput();
            Console.WriteLine("Hej och välkommen. Var god välj en av följande val: 1, 2 eller 3");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                handleInput.respondToUserInput1(); 
            }
            else if (userInput == "2")
            {
                handleInput.respondToUserInput2();
            }
            else if (userInput == "3")
            {
                handleInput.respondToUserInput3();
            }
            else {
                Console.WriteLine("Du har gjort ett felaktigt val.");
            }

            Console.ReadKey();

        }
    }
}
