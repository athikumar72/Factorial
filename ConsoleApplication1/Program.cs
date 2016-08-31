using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorialCalculation;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
            

        {

            string option = "";

            do
            {
               
                Console.WriteLine("Welcome to the Factorial Calculation");
                Console.WriteLine("Enter an integer that's  greater than 0 but less  than 10:");
                int fact_input = int.Parse(Console.ReadLine());


                Class1 fact1 = new Class1();
                Console.WriteLine("The factorial of   " + fact_input  +"  is  " + fact1.factCalculator(fact_input) );

                Console.WriteLine("y/n");
                option = Console.ReadLine();
            } while (option == "y");

            
        }
    }
}
