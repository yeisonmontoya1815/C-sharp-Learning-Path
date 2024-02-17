using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Jogging_Yeison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. declarando la primera parte de las variables e invocando el primer metodo para calcular el Average
            int fsteps = 0;
            int lsteps = 0;
            double avgsteps = 0;
            calc_steps(ref fsteps, ref lsteps, ref avgsteps); //aca estoy invocando el metodo que cree abajo

            // 2. declarando la segunda parte de las variables e invocando el segundo metodo
            int hour_steps = 0;
            int min_steps = 0;
            int total_time = 0;
            calc_time(ref hour_steps, ref min_steps, ref total_time); //aca estoy invocando el segundo metodo que cree debajo del primero

            // 3. Calculando el total de pasos
            double total_steps_in_all_time;

            total_steps_in_all_time = total_time*avgsteps;
            Console.WriteLine("you did: {0} in your jogging", total_steps_in_all_time);
            //calculate the toal distance

            double total_distance_feet;
            double total_distance_miles;
            total_distance_feet = total_steps_in_all_time*2.5;
            total_distance_miles = total_distance_feet * 0.0001893939;
            Console.WriteLine("you run {0} feets or {1} miles",total_distance_feet,total_distance_miles);
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("Thanks for using My Jogging Calculator App");
            Console.WriteLine("Dev By Yeison Montoya - 300375916");

            Console.ReadKey();
        }
        static void calc_steps(ref int fsteps, ref int lsteps, ref double avgsteps) //if I use "ref" I have to inicialize Variable=0;    //if I use "out" just inicialize variable;
        {
            Console.WriteLine("Input the First minute steps:");
            fsteps = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Input the Last minute steps:");
            lsteps = int.Parse(Console.ReadLine());

            avgsteps = (fsteps+lsteps)/2.0;
            Console.WriteLine("Step in First Minute: {0},Step in last Minute: {1}, Average step: {2}", fsteps, lsteps, avgsteps);
        }
        static void calc_time(ref int hour_steps, ref int min_steps, ref int total_time)
        {
            int hour_step_to_min;
            Console.WriteLine("Input the hours you are jogging:");
            hour_steps = int.Parse(Console.ReadLine());
            hour_step_to_min = hour_steps * 60;

            Console.WriteLine("Input the number of minutes you are jogging:");
            min_steps = int.Parse(Console.ReadLine());
            total_time = hour_step_to_min + min_steps;
            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("This is the Summary of your Jogging Day!");
            Console.WriteLine("----------------------------------------\n");
            Console.WriteLine("The number of hours jogging were: {0} hours." +
                              "\nThe number of minutes jogging were: {1} minutes." +
                              "\nFinally your average of steps were {2} steps.", hour_steps, min_steps, total_time);
            Console.WriteLine("\n----------------------------------------");
        }

    }
}
