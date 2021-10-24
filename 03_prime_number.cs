using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Number03
{
    class Program    //prime number means a number that can be divided exactly only by itself. 1,3,5,7....
    {
        static void Main(string[] args)
        {
            int a = 0;              //we take 2 verible 
            int b;
            Console.WriteLine("<<<<<<<<<<<<<<prime number>>>>>>>>>>>>>>>"); 
            Console.WriteLine("Please , Enter a number : ");    //take input from users.
            a = Convert.ToInt32(Console.ReadLine());
           b =a / 2;              //variable b with value of a/2 is exactly half of the initial user input .                      
            for (int i = 2; i <= a; a++)      //use for loop to initial value 2 for the loop variable.
            {
                if (a % i == 0)        //count how much time 0 is present.
                {
                    b = b + 1;       //Compute the "b" variable with the value of "i" variable.
                }
                if (b == 2)
                {                       //If the condition is true then print.
                    Console.WriteLine("YES,"+ a + " this is prime number.");
                    Console.ReadLine();
                }

                else
                {                            ////If the condition is  false then print .
                    Console.WriteLine("NO," + a + " this is not a prime number ");
                    Console.ReadLine();
                }
            }
        }
    }
}
