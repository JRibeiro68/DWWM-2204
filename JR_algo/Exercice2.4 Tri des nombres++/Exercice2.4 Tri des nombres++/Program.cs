// See https://aka.ms/new-console-template for more information

int nbrA, nbrB, nbrC;

Console.WriteLine("entrez un premier nombre entier");
nbrA = int.Parse(Console.ReadLine());
Console.WriteLine("entrez un deuxième nombre premier");
nbrB = int.Parse(Console.ReadLine());
Console.WriteLine("entrez un troisième nombre premier");
nbrC = int.Parse(Console.ReadLine());

if ((nbrA > nbrB) && (nbrB > nbrC))
{
    Console.WriteLine(+nbrA + ">" + nbrB + ">" + nbrC);
}
else if ((nbrA > nbrC) && (nbrC > nbrB))
{
    Console.WriteLine(+nbrA + ">" + nbrC + ">" + nbrB);
}
if ((nbrB > nbrA) && (nbrA > nbrC))
{
    Console.WriteLine(nbrB + ">" + nbrA + ">" + nbrC); 
}
if ((nbrB > nbrC) && (nbrC > nbrA))
{
    Console.WriteLine(nbrB + ">" + nbrC + ">" + nbrA);
}
if ((nbrC > nbrB) && (nbrB > nbrA))
{
    Console.WriteLine(nbrC + ">" + nbrB + ">" + nbrA);
}
if ((nbrC > nbrA) && (nbrA > nbrB))
{
    Console.WriteLine(nbrC + ">" + nbrA + ">" + nbrB);
}