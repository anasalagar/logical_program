using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Stop_Watch_06
{
    class Program
    {
        static void Main(string[] args)

        {         
                Stopwatch stopwatch = new Stopwatch();
                Console.WriteLine("<<<< STOPWATCH >>>>");
                Console.WriteLine("Press ENTER to start stopwatch ");
                
                Console.ReadKey();
                stopwatch.Start();
            Console.WriteLine("<<<RUNNING>>>");
            Console.WriteLine("For stop , press S");
                
                Console.ReadKey();
                stopwatch.Stop();
            Console.WriteLine("Your Time is {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                Console.ReadLine();      
        }
        
    }
}
