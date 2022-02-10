using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a number between 10 and 100");
            int x;
            x = int.Parse(Console.ReadLine());
            int y;
            y = (x / 10);
            int q;
            q = (x % 10);
            if (y == q)
                Console.WriteLine("ok");
            else
                Console.WriteLine("error");
        }
    }
}
