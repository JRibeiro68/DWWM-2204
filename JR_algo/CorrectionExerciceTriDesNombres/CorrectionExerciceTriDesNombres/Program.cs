// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tri des nombres");
Console.Title = "Tri des nombres entiers";
Console.ReadLine();


int a;
int b;
int c;
string reponse;


Console.WriteLine("Saisissez un premier nombre entier");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Saisissez une deuxiéme nombre entier");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Saisissez un troisième nombre entier");
c = int.Parse(Console.ReadLine());


if (a > b)
{
    if (b > c)
    {
        reponse = a + " > " + b + " > " + c;
    }
    else if (a > c)
    {
        reponse = a + " > " + c + " > " + b;

    }
    else if (b == c)
    {
        reponse = c + " > " + a + " > " + b;
    } else
    {
        reponse = c + " > " + a + " > " + b;
    }
}
else
{
    if (a > c)
    {
        reponse = b + " > " + a + " > " + c;
    }
    else if (b > c)
    {
        reponse = b + " > " + c + " > " + a;
    }
    else
    {
        reponse = c + " > " + b + " > " + a;
    }
}
Console.WriteLine(reponse);