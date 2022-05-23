// See https://aka.ms/new-console-template for more information

int nbrA, nbrB, nbrC

Console.WriteLine("entrez un premier nombre entier");
nbrA = int.Parse(Console.ReadLine());
Console.WriteLine("entrez un deuxième nombre premier");
nbrB = int.Parse(Console.ReadLine());
Console.WriteLine("entrez un troisième nombre premier");
nbrC = int.Parse(Console.ReadLine());

if (nbrA < nbrB) &(nbrA < nbrC) & (nbrB < nbrC);
{
    Console.WriteLine(+ nbrC+ ">" + nbrB + ">" + nbrA);
}