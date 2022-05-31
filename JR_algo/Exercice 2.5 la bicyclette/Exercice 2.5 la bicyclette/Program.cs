// See https://aka.ms/new-console-template for more information

bool Beau, BonEtat, ReparationImmediate, LivreDispoSalon, LivreDispoBibliotheque;

Console.WriteLine("Fait - il beau ce matin?");
Beau = bool.Parse(Console.ReadLine());



if (Beau == true)
{
    Console.WriteLine("La bicyclette est-elle en bon état?");
    BonEtat = bool.Parse(Console.ReadLine());
    if (BonEtat == false)
    {
        Console.WriteLine("Allez chez le garagiste");
        Console.WriteLine("La réparation est - elle immédiate ?");
        ReparationImmediate = bool.Parse(Console.ReadLine());
        if (ReparationImmediate == false)
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
    LivreDispoSalon = bool.Parse(Console.ReadLine());
    if (LivreDispoSalon == false)
    {
        Console.WriteLine("Allez à la bibliothèque municipale");
        Console.WriteLine("Le livre est-il disponible à la bibliothèque?");
    }
    LivreDispoBibliotheque = bool.Parse(Console.ReadLine());
    if (LivreDispoBibliotheque == false)
    {
        Console.WriteLine("Emprunter un roman policier.");
    }
    Console.WriteLine("Rentrer directrement à la maison");


    {
        Console.WriteLine("M'installer corectement dans un fauteuil");
    }
}
