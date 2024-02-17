using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YeisonMontoya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ValuesLong = new int[10];

            LosDiezNumeros _LosDiezNumeros = new LosDiezNumeros(); // Initialize the class within the main program
            _LosDiezNumeros.InputValues(ValuesLong); // Call the class, method, and pass the value within the main program

            for (int i = 0; i < ValuesLong.Length; i++) // Loop to print the values
            {
                Console.Write(ValuesLong[i] + " ");
            }
            Console.Write("\n");
            _LosDiezNumeros.Drawing(ValuesLong);

            Console.WriteLine("\nProgram By Yeison Montoya ID: 300375916");
            Console.ReadKey();
        }
    }

    internal class LosDiezNumeros // Class declaration
    {
        public void InputValues(int[] InputValues) // First method of the class
        {
            int OutValue = 0;

            for (int i = 0; i < InputValues.Length; i++) // Loop to input numbers
            {
                while (true) // While loop for continuously asking for numbers
                {
                    Console.WriteLine("Ingrese el numero:"); // Ask the user to input a number
                    if (int.TryParse(Console.ReadLine(), out OutValue)) // Convert to "int" and store in "OutValue"
                    {
                        if (OutValue >= 0 && OutValue < 11)
                        {
                            InputValues[i] = OutValue;
                            break; // Exit the while loop
                        }
                        else
                        {
                            Console.WriteLine("Out of Range, please Try Again!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Data Try Again");
                    }
                }
            }
            Console.Clear();
        }

        public void Drawing(int[] _InputValues) // Second method
        {
            for (int i = 10; i > 0; i--) // Loop for vertical lines
            {
                for (int j = 0; j < _InputValues.Length; j++) // Loop for horizontal lines
                {
                    if (_InputValues[j] >= i)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write(" \t");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
