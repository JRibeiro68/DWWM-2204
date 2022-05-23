// See https://aka.ms/new-console-template for more information

int age, diffPlus, diffMoins;

Console.WriteLine("Quel âge avez vous ?");
age = int.Parse(Console.ReadLine());

diffPlus = age - 60;
diffMoins = 60 - age;

if (age < 0 )
{
    Console.WriteLine("L'âge saisi n'est pas valide");
}
else
{
    if (age < 60)
    {
        Console.WriteLine("il vous reste " + diffMoins);
    }
    else
    {
        if (age > 60)
        {
            Console.WriteLine("Vous ètes à la retraite " + diffPlus + " années");
        }
        else
        {
            Console.WriteLine("C'est le moment de prendre votre retraite");
        }
    }
}