using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchCase();
           
            Console.ReadKey();
        }

        public static void SwitchCase()
        {
            float num1;
            float num2;
            float total;
            float menu;

            Console.WriteLine("****************************");
            Console.WriteLine("****** CALCULATOR APP ******");
            Console.WriteLine("****************************");

            Console.WriteLine("\nInput (1-4) Menu Option:\n\t*1:Sum\n\t*2:Debt\n\t*3:Multiplication\n\t*4:Division");
            
            while(float.TryParse(Console.ReadLine(), out menu)==false) 
            {
                Console.WriteLine("Data must be an integer number");
                SwitchCase();
            }
                        
            if (menu == 1|| menu == 2||menu == 3|| menu == 4) 
            {
                Console.WriteLine("input the first number: ");
                while (float.TryParse(Console.ReadLine(), out num1) == false)
                {
                    Console.WriteLine("Data entered must be a number");
                }

                Console.WriteLine("input the second number: ");
                while (float.TryParse(Console.ReadLine(), out num2) == false)
                {
                    Console.WriteLine("Data entered must be a number");
                }

                switch (menu)
                {
                    
                    case 1:
                        Console.WriteLine("You have choosen The Sum\n");
                        total = num1 + num2;
                        Console.WriteLine($"Sum of: {num1} + {num2} = {total}");
                        ValidationToNewCalculation();
                        break;

                    case 2:
                        Console.WriteLine("You have choosen The Debt\n");
                        total = num1 - num2;
                        Console.WriteLine($"Debt of: {num1} - {num2} = {total}");
                        ValidationToNewCalculation();
                        break;

                    case 3:
                        Console.WriteLine("You have choosen The Multiplication\n");
                        total = num1 * num2;
                        Console.WriteLine($"Multiplication of: {num1} * {num2} = {total}");
                        ValidationToNewCalculation();
                        break;

                    case 4:
                        Console.WriteLine("You have choosen The Division\n");
                        total = num1 / num2;
                        Console.WriteLine($"Division of: {num1} / {num2} = {total}");
                        ValidationToNewCalculation();
                        break;

                    default:
                        Console.WriteLine("Selection must be between options:\n 1 Sum\n 2 Debt\n 3 Multiply\n 4 Division");
                        break;
                }
            }
            else 
            {
                Console.WriteLine($"{menu} is not a Menu Option. Choose a valid number!\n");
                SwitchCase();
            }          
        }
        public static void ValidationToNewCalculation()
        {
            while (true) //esto es para indicarle al usuario que si quiero volver a calcular algo SI o NO
            {
                Console.WriteLine("Do you want to continue? (Y/N)");
                string response = Console.ReadLine();
                if (response.ToUpper() != "Y")
                {
                    Console.WriteLine("********************************************");
                    Console.WriteLine("** Thanks for using the Calculator App    **");
                    Console.WriteLine("** Developed by: Yeison Montoya           **");
                    Console.WriteLine("********************************************");
                }
                else 
                {
                    SwitchCase();
                }
                break;
            }
            
        }
    }
}
