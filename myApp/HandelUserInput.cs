using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myApp
{
    class HandelUserInput: IRespond
    {
        public void respondToUserInput1() {
            Console.WriteLine("Kul att du valde nummer 1");
        }
        public void respondToUserInput2()
        {
            Console.WriteLine("Yes nr2.");
        }
        public void respondToUserInput3()
        {
            Console.WriteLine("Number 3 it is.");
        }
    }
}
