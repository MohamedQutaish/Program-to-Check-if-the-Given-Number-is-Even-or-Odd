using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_to_Check_Whether_a_Given_Number_is_Even_or_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i;

            Console.Write("Enter any number:");
             i = int.Parse(Console.ReadLine());

            if (i % 2 == 0)

            {
                Console.Write("Entered number is Even");
            }
            
            else
            
                {
                Console.Write("Entered nubmer is Odd");
                
            }
            Console.Read();
            

        }







    }
}
