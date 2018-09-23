using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args != null && args.Length > 0)
            {
                Console.WriteLine("Args:");
                for (int i = 0; i < args.Length; i++)
                {
                    Console.WriteLine(string.Format("args[{0}]: {1}", i, args[i]));
                }
            }
            else
            {
                Console.WriteLine("no Args.");
            }
        }
    }
}
