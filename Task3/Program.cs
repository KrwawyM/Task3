using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj długość prostokąta:");
            double dlu = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj wysokość prosotkąta:");
            double wys = double.Parse(Console.ReadLine());

            double diagonal = Math.Sqrt(Math.Pow(dlu, 2) + Math.Pow(wys, 2));
            Console.WriteLine("Przekątna prostokąta to: " + diagonal);
        }
    }
}