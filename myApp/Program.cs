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

            int n = 0;
            while (n < 1000)
            {

                Console.WriteLine("Hej och välkommen. Var god välj en av följande val: 1, 2 eller 3");
                Console.WriteLine("Vill du avsluta applikationen tryck 4.");
                string userInput = Console.ReadLine();
                n++;

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
                else if (userInput == "4")
                {
                    return;
                }
                else {
                    Console.WriteLine("Du har gjort ett felaktigt val.");
                }

            }
        }
    }
}
