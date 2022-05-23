using System;

namespace exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A,B;
            Console.WriteLine("Veuillez entre le nombre A:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer le nombre B:");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("La valeur de A est:" + A);
            Console.WriteLine("La valeur de B est:" + B);
            Console.WriteLine("*****inversion*****");
            int temp;
            temp = B;
            B = A;
            A = temp;
            Console.WriteLine("La valeur A est après inversion:" + A);
            Console.WriteLine("La valeur B est après inversion:" + B);
            Console.ReadKey();
        }
    }
}
