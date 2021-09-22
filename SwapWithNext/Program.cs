using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapWithNext
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");            
            string s = Console.ReadLine();
            Console.WriteLine();

            SwapNext mySwap = new SwapNext(s);
            mySwap.SwapWNext(s);

            Console.ReadLine();
        }
    }
}
