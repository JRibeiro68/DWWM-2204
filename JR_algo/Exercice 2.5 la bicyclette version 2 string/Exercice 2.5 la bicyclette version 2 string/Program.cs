String Beau, BonEtat, reparationimmediate, livreDispoSalon, LivreDispoBibliotheque, oui, non;

Console.WriteLine("fait_il beau ce matin?");
Beau = (Console.ReadLine());
oui = (Console.ReadLine());
non = (Console.ReadLine());


if (Beau == oui)
{
    Console.WriteLine("La bicyclette est-elle en bon état?");
    BonEtat = (Console.ReadLine());
    if (BonEtat == non)
    {
        Console.WriteLine("Allez chez le garagiste");
        Console.WriteLine("La réparation est-elle immédiate?");
        reparationimmediate = (Console.ReadLine());
        if (reparationimmediate == non)
        {
            Console.WriteLine("Allez à pied à l'étang et ceuillir des joncs");
        }
    }
    else
        Console.WriteLine("Allez faire une ballade à bicyclette");

    {
        Console.WriteLine("Consacrer ma journée à la lecture");
    }
    {
        Console.WriteLine("Le livre Game of thrones est-il dans le salon?");
        livreDispoSalon = (Console.ReadLine());
        if (livreDispoSalon == non)
        {
            Console.WriteLine("Allez à la bibliothèque municipale");
            Console.WriteLine("Le livre est_il disponible à la bibliothèque?");
        }
        LivreDispoBibliotheque = (Console.ReadLine());
        if(LivreDispoBibliotheque == non)
        {
            Console.WriteLine("Emprunter un roman policier");
        }
        Console.WriteLine("Rentrer directement à la maison");
    }
    {
        Console.WriteLine("M'installe conforatablement dans un fauteuil");
    }
}