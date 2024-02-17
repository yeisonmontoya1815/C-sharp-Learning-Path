using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PedirMostrarNombres _PedirMostrarNombres = new PedirMostrarNombres(); // Instantiate the class

            // Call the methods from the class
            _PedirMostrarNombres.PedirNombres();
            _PedirMostrarNombres.PedirEdad();
            _PedirMostrarNombres.PedirEsperanzadeVida();
            _PedirMostrarNombres.Calculo();
            _PedirMostrarNombres.MostrarResultados();

            Console.ReadKey();
        }
    }

    internal class PedirMostrarNombres //clase creada
    {
        //variables globales
        string[] Nombres;
        string[] Apellidos;
        int[] Edad;
        int[] EsperanzaVida;
        int[] RemainingLife;

        public PedirMostrarNombres() //constructor
        {
            //variables llamadas desde la clase e inicializadas
            Nombres = new string[3];
            Apellidos = new string[3];
            Edad = new int[3];
            EsperanzaVida = new int[3];
            RemainingLife = new int[3];
        }

        public void PedirNombres() //metodo 
        {
            for (int i = 0; i < Nombres.Length; i++) //for para pedir nombres
            {
                Console.WriteLine("Input Name #" + (i + 1) + ":");
                Nombres[i] = Console.ReadLine();
            }
            Console.WriteLine(); //da un espacio despues de hacer las iteraciones del for

            for (int i = 0; i < Apellidos.Length; i++) //for para pedir apellidos
            {
                Console.WriteLine(Nombres[i] + "! Input your lastname:"); //uso un array previo para anidarlo a la siguiente pregunta
                Apellidos[i] = Console.ReadLine(); //guardo la info en el array "Apeliidos[i]"
            }
            Console.WriteLine(); //da un espacio despues de hacer las iteraciones del for
        }

        public void PedirEdad() //Con validacion de datos numericos
        {
            Console.WriteLine("Age must be a number from (0 - 99)\n");

            for (int i = 0; i < Edad.Length; i++)
            {
                Console.WriteLine(Nombres[i] + "! Input your age in number: ");

                while (int.TryParse(Console.ReadLine(), out Edad[i]) == false || Edad[i] < 0 || Edad[i] > 99) //esta es la estructura para validar datos numericos
                {
                    Console.WriteLine("Input NOT Valid!, Try again!");
                    Console.WriteLine("Age must be a number from (0 - 99)\n");
                }
                Console.WriteLine(); //da un espacio despues de hacer las iteraciones del for
            }
        }

        public void PedirEsperanzadeVida() //Con validacion de datos numericos
        {
            for (int i = 0; i < EsperanzaVida.Length; i++)
            {
                Console.WriteLine(Nombres[i] + "! from (" + Edad[i] + " - 200) up to what age do you expect to live?");
                while (int.TryParse(Console.ReadLine(), out EsperanzaVida[i]) == false || EsperanzaVida[i] < Edad[i] || EsperanzaVida[i] > 200) //esta es la estructura para validar datos numericos
                {
                    Console.WriteLine("Age expected to live must be a number from (" + Edad[i] + " - 200)");
                }
            }
            Console.WriteLine(); //da un espacio despues de hacer las iteraciones del for
        }

        public void Calculo() //metodo para calcular el remanente de anos de vida
        {
            for (int i = 0; i < EsperanzaVida.Length; i++)
            {
                RemainingLife[i] = EsperanzaVida[i] - Edad[i];
            }
        }

        public void MostrarResultados() // muestro los resultados
        {
            for (int i = 0; i < Nombres.Length; i++) // for para mostrar resultados
            {
                Console.WriteLine("P#" + (i + 1) + " is " + Nombres[i] + " lastname " + Apellidos[i] +
                    " has " + Edad[i] + " years old, expected life years is " + EsperanzaVida[i] +
                    " years, years remaining to die " + RemainingLife[i]);
            }
            Console.WriteLine();
        }
    }
}
