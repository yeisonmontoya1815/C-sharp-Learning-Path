using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Despiece();
            //ForLoopExample();
            //WhileExample();
            DoWhileExample();
            Console.ReadKey();
        }

        private static void Despiece()
        {
            string text = "A\nB\nC\nD"; //Console.WriteLine(text);
            Console.WriteLine("\"Hello World!\"\n\"Welcome to the Instructions examples!\"\n");
        }

        private static void DoWhileExample()
        {
            //Do While primero ejecuta y despues se detiene, esa es la diferencia con el if

           
            //quiero devolver el resultado de una suma
            Console.WriteLine("\"Example of Do While loop!\"");
            Console.WriteLine("Input various numbers to add...\nPress'0' to finish");
            
            int suma = 0;
            int numAsumar = 0;

            do
            {
                while (!int.TryParse(Console.ReadLine(), out numAsumar)) // "!" is used as other way to check invalid input data
                { 
                    Console.WriteLine("Data input must be an integer");
                }
                suma += numAsumar;
            }
            while (numAsumar != 0);
            Console.WriteLine($"{suma} This is the Final Result");
        }

        private static void ForLoopExample() 
        {
            int num1 = 0;
            //Console.WriteLine("This is for Loop\n");
            Console.WriteLine("\"Example of for loop!\"");
            Console.WriteLine("Input the number");
            num1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int total = num1 * i;
                Console.WriteLine($"{num1} * {i} = {total}");
            }
            Console.WriteLine("\n");
        }
        private static void WhileExample() //incrementa num2 hasta llegar a 30 
        {
            int num2 = 0;
            Console.WriteLine("\"Example of While loop!\"\n");
            Console.WriteLine("Input number between 0 and 30");
            num2 = int.Parse(Console.ReadLine());
 
            while (num2<=30) 
            {
                Console.WriteLine(num2);
                num2++;
            }
            Console.WriteLine("Bye Bye!");
        }
    }
}
