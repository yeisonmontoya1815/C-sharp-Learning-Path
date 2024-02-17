using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Yeison";
            
            int A = 0; 
            int B = 0; 

            Console.WriteLine("My name is {0} Let's get started!", name);
            Console.WriteLine("\n");
            Console.WriteLine("Input the first Number:");
            A=int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second Number:");
            B=int.Parse(Console.ReadLine());

            Suma(ref A, ref B); // asi e llama el metodo "Suma"
            Resta(ref A, ref B); // asi se llama el metodo "Resta"
            Console.WriteLine("Thanks for using my CalcApp!");

            Console.WriteLine("\n");
            Console.ReadKey();

        }
        static void Suma(ref int _A, ref int _B) //metodo "Suma"
        {
            int C = _A + _B;
            Console.WriteLine("The Sum result is: {0}", C);
            Console.WriteLine("\n");
        }
        static void Resta(ref int _A, ref int _B) //metodo "Resta"
        {
            int D = _A - _B;
            Console.WriteLine("The Rest result is: {0}", D);
            Console.WriteLine("\n");

        }
    }
}
