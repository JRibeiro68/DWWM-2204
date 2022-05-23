using System;

namespace exercice1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rayon,aire,volume;

            Console.WriteLine("Quel est le rayon de la sphère ?");
            rayon = double.Parse(Console.ReadLine());
            aire = 4 * Math.PI * rayon * rayon;
            volume = 4/3 * Math.PI * rayon * rayon * rayon;
            Console.WriteLine(" L'aire de la sphère est de :" + aire);
            Console.WriteLine(" Le volume de la sphère est de :" + volume);
            Console.ReadKey();

        }
    }
}
