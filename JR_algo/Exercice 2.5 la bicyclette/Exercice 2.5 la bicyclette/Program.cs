// See https://aka.ms/new-console-template for more information

string Beau, BonEtat, ReparationImmediate, LivreDispoSalon, LivreDispoBibliotheque;
 
Console.WriteLine("Fait - il beau ce matin?");
Beau = (Console.ReadLine());



if (Beau == "oui")
{
    Console.WriteLine("La bicyclette est-elle en bon état?");
    BonEtat = (Console.ReadLine());
    if (BonEtat == "non")
    {
        Console.WriteLine("Allez chez le garagiste");
        Console.WriteLine("La réparation est - elle immédiate ?");
        ReparationImmediate = (Console.ReadLine());
        if (ReparationImmediate == "non")
        {
            Console.WriteLine("Allez à pied à l'étang et ceuillir des joncs");
        }
    }
    else
        Console.WriteLine("Allez fair eune ballade à bicyclette");
}
else
{
    Console.WriteLine("Consacrer ma journée à la lecture");
}

{
    Console.WriteLine("Le livre Game of thrones est - il dans le salon ?");
    LivreDispoSalon = (Console.ReadLine());
    if (LivreDispoSalon == "non")
    {
        Console.WriteLine("Allez à la bibliothèque municipale");
        Console.WriteLine("Le livre est-il disponible à la bibliothèque?");
    }
    LivreDispoBibliotheque = (Console.ReadLine());
    if (LivreDispoBibliotheque == "non")
    {
        Console.WriteLine("Emprunter un roman policier.");
    }
    Console.WriteLine("Rentrer directrement à la maison");


    {
        Console.WriteLine("M'installer corectement dans un fauteuil");
    }
}
