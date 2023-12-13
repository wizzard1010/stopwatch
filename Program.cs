using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            try
            {
                stopwatch.Start();
                System.Threading.Thread.Sleep(2000);
                stopwatch.Stop();

                stopwatch.Start();
                System.Threading.Thread.Sleep(2000);
                stopwatch.Stop();
            }
            catch (InvalidOperationException)
            {

                Console.WriteLine("Invalid operation");
            }

        }
    }
}
