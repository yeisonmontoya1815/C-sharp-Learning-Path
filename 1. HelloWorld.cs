//First way to do without "System.Console;" 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World check the second way to do that!"); // it has to be written "Console.WriteLine("bla bla bla....");"
            Console.WriteLine("you have to unlock 'second code in green'"); // it has to be written "Console.WriteLine("bla bla bla....");"
            Console.ReadKey(); // "Console.ReadKey();" is for wait until closing the window
        }
    }
}

/*

//Another way to do without using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //this is to avoid using the "Console. and just write "WriteLine"


namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello World Yeison, Lets's do it!"); // using this command without "Console."
            WriteLine("this is another way usnig this command without 'Console.'"); // using this command without "Console."
            ReadKey();                // using this command without "Console."
        }
    }
}
*/