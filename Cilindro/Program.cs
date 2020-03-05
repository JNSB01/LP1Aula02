using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string sa, sr;
            float aF,rF;
            float pi = 3.1415926f;
            Console.WriteLine("Pf escreva a altura e raio do cilindro");

            sa = Console.ReadLine();
            sr = Console.ReadLine();
            aF = float.Parse(sa);
            rF = float.Parse(sr);

            float VF = pi * (rF * 2 * 2) * aF;
            float ASF = 2 * pi * rF * (rF + aF);

            Console.WriteLine($"Volume = {VF}");
            Console.WriteLine($"Area de superficie = {ASF}");

        }
    }
}
