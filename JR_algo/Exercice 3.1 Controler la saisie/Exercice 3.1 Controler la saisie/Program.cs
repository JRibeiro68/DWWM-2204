// See https://aka.ms/new-console-template for more information

string prenom;

do
{
    Console.WriteLine("Entrez votre prénom");
    prenom = (Console.ReadLine());
}
while (prenom.Length <= 2);
Console.WriteLine("Bonjour " + prenom);