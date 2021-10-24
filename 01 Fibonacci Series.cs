using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    class Program
    {
        static void Main(string[] args)
        {                                                 //we   create 4 Variables
            int a;
            int b;
            int c;
            int d;
            
            Console.WriteLine("<<<<Welcome to Fibonacci Series>>>>");   //welcome massage
            Console.Write("Please Enter a value : ");
            d = Convert.ToInt32(Console.ReadLine());        //convert int d

            Console.Write( 0 + " " + 1 ); //it's start from 0 and 1 ,so we write output 0 and 1
            a = 0;                         //suppose a=0 and b=1
            b = 1;
            for( int i=2; i<d; i++)      //we user for loop
            {
                c = a + b;
                Console.Write(" " + c);
                a = b;
                b = c;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
