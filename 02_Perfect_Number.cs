using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number02   //Perfect numbers means that are equal to the sum of its factors except for the number itself.
				//6=1+2+3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int number;                                     //we take "number " as a verible.
            int sum=0 ; 
            Console.WriteLine("<<<<<<<<<perfact number >>>>>>>>>>");
                Console.WriteLine("please Enter a number : ");  //take input from users.
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)           //use for loop ,for checking the number is a perfact or not.
                                                       //value of "i" variable is less than the value of "number" variable.
            {
                if (number % i == 0)                    //"i" variable is equal to 0.
                {                                       //if the condition is true then execute if condition statement.
                    sum = sum + i;                      //Compute the "sum" variable with the value of "i" variable.

                }
            }
                if (sum == number)
            {                                           //If the condition is true then print
                Console.WriteLine("YES ," + number + " this is perfact number. " ); 
                Console.ReadLine();
                }
                else
            {                                      ////If the condition is  false then print 
                Console.WriteLine("NO , "+ number + " this is not perfact number ." );
                Console.ReadLine();
                }
            }

        }
    }
