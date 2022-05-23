// See https://aka.ms/new-console-template for more information

int a, b;

Console.WriteLine("Veuillez saisir un premier nombre:");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Veuillez saisir un second nombre:");
b = int.Parse(Console.ReadLine());
if (a < b)
{
    Console.WriteLine(+ a + "<" + b);
}
else
{
    if (b < a)
    {
        Console.WriteLine(b + "<" + a);
    }
}