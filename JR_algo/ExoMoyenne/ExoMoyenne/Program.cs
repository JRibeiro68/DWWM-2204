﻿using System;

namespace ExoMoyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nbr1, nbr2, moyenne;

            Console.WriteLine("Veuillez saisir un premier nombre entier:");
            nbr1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un second nombre entier:");
            nbr2 = double.Parse(Console.ReadLine());
            moyenne = (nbr1 + nbr2) / 2;
            Console.WriteLine("La moyenne de " + nbr1 + " et " + nbr2 + " est égal à:" + moyenne);
        }
    }
}
