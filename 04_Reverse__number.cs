using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse__number_04 //reverse numbers means 12345  54321.
{
    class Program
    {
        static void Main(string[] args)
        {
            int  number;
            int  reverse=0;                                         //we take 2 verible.                                                         
            Console.WriteLine("Plase Enter  a number to reverce");     // take input from users.
            number = Convert.ToInt32(Console.ReadLine());

            while(number!=0)     //use while loop .  number is not equal to zero .
            {
                reverse = (reverse * 10) + (number %10); //( number %10 )is take as a reminder.
                number = number / 10;
            }
            Console.WriteLine("reverse number is {0} ",reverse); //print reverse value.
            Console.ReadLine();
        }
    }
}
