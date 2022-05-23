// See https://aka.ms/new-console-template for more information

int age;

Console.WriteLine("Entrez votre âge:");
age = int.Parse(Console.ReadLine());
if (age < 18)
{
    Console.WriteLine("Vous êtes mineur");
}
else
    Console.WriteLine("Vous êtes majeur");