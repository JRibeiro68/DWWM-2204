int A, B;

Console.WriteLine("Saisir un premier nombre");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Saisir un deuxième nombre");
B = int.Parse(Console.ReadLine());

if (A < B)
{
    for (int i = A; i < B; i++)
    {
        Console.WriteLine(i);
    }
}
else if (B < A)
{
    for (int i = B; i < A; i++)
    {
        Console.WriteLine(i);
    }
}
else
{
    Console.WriteLine("Saisir deux nombres différents");
}