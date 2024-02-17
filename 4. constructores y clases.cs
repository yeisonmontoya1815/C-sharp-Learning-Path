using System;
using static System.Console;

namespace MuestraSalario
{
    internal class MuestraSalario
    {
        static void Main(string[] args)
        {
            Salario _Salario = new Salario(); // Instantiate the "Salario" class

            double a = _Salario.Salary(); // Create a variable "a" for the "Salary" object of the "Salario" class
            double b = _Salario.Taxes(); // Create a variable "b" for the "Taxes" object of the "Salario" class
            double c = _Salario.Ganancia(a, b); // Calculate net gain using the "Ganancia" method

            WriteLine("El salario es: {0}\nLos impuestos son: {1}\nLa ganancia neta es: {2}", a, b, c);
            ReadKey();
        }
    }

    internal class Salario
    {
        public Salario()
        {
            Console.WriteLine("Resumen de su Salario: ");
        }

        public double Salary()
        {
            double salario = 150;
            return salario;
        }

        public double Taxes()
        {
            double impuesto = 0.3;
            return impuesto;
        }

        public double Ganancia(double _salario, double _impuesto)
        {
            double Ganancia_Neta = _salario - (_salario * _impuesto);
            return Ganancia_Neta;
        }
    }
}
