using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FactorialCalculation
{
    public class Class1
    {
        // int fact;
     //  int value = 1;
       // int i = 1;

        public int factCalculator(int fact_meth)
        {
            //   int value = 1;
            //int i = 1;

            // i  = i+1;

            /* if (fact1 < 0 || fact1 > 10)

             {
                 // (i <= fact1)
                 Console.WriteLine(" The entered number is outof range enter another number");
                 return fact1 = int.Parse(Console.ReadLine());


             }
             else */
            if (fact_meth == 1)
            {
                return 1;
                //return value;
            }
            else
            {
                return fact_meth * factCalculator(--fact_meth);



            }
            


            }
           

          

        }   
    /*   int value = 1;
           
            for(int i=1;i<= fact1;i++)
            {
               value = value * i;
                //Console.WriteLine("The factorial of   " + value + "  is   " + value);

            }
            return value;*/
    }


