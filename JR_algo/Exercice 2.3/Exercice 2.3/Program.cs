// See https://aka.ms/new-console-template for more information

int age, diffPlus, diffMoins;

Console.WriteLine("Quel âge avez vous ?");
age = int.Parse(Console.ReadLine());

diffPlus = age - 60;
diffMoins = 60 - age;

if (age > 60)
{
    Console.WriteLine("Vous êtes à la retraite depuis " + diffPlus + " années");

     else
        if (age < 60)
    {
        Console.WriteLine.("Il vous reste " + diffMoins + " années avant la retraite");
    }
}
else
    if (age == 60)
{
    Console.WriteLine("C'est le moment de prendre sa retraite");
}
else
    Console.WriteLine("La valeur fournie n'est pas un âge légale");