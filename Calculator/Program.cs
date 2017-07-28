using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 3));
        }
        static int Add(int i, int j)
        {
            return i + j;
        }
    }
}
