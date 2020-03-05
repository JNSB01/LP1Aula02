using System;
using System.Text;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double dM = double.MaxValue;
            float fM = float.MaxValue;
            uint iM = uint.MaxValue;
            ulong lM = ulong.MaxValue;
            ushort sM = ushort.MaxValue;
            sbyte bM = sbyte.MaxValue;

            float Pinf = float .PositiveInfinity;
            float Ninf = float .NegativeInfinity;
            float nan = float .NaN;

            double PInf = double .PositiveInfinity;
            double NInf = double .NegativeInfinity;
            double Nan = double .NaN;

            Console.WriteLine(dM);
            Console.WriteLine(dM + 2);
            dM = double.MinValue;
            Console.WriteLine(dM);
            Console.WriteLine(dM - 2);
            Console.WriteLine(dM * 2);
            Console.WriteLine(fM);
            Console.WriteLine(fM * 2);

            Console.WriteLine(iM);
            Console.WriteLine(iM + 2);
            Console.WriteLine(iM * 2);
            iM = uint.MinValue;
            Console.WriteLine(iM - 2);
            Console.WriteLine(lM);
            Console.WriteLine(sM);
            Console.WriteLine(bM);
            Console.WriteLine("Floats infs and nan " + Pinf +" "+ Ninf + " " + nan);
            Console.WriteLine("Double infs and nan " + PInf +" "+ NInf + " " + Nan);

        }
    }
}
