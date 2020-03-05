using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x++;
            Console.WriteLine(x);
            Console.WriteLine(y);
            int z = --y;
            Console.WriteLine(z);
            Console.WriteLine(y);
        }
    }
}
