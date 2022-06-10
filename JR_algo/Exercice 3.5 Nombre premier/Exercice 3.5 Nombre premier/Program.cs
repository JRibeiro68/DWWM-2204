float nbrPremier;
string resultat = "est un nombre premier";


Console.WriteLine("Entrer un nombre premier");
nbrPremier = float.Parse(Console.ReadLine());


for (int i = 2; i < nbrPremier; i++)

    if (nbrPremier % i == 0) 
    {
        resultat = nbrPremier + " n'est pas un nombre premier";
    }
Console.WriteLine(resultat);



