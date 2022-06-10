int nbrPremier;
string resultat = " est un nombre premier";


Console.WriteLine("Entrer un nombre premier");
nbrPremier = int.Parse(Console.ReadLine());


for (int i = 2; i < nbrPremier; i++)

    if (nbrPremier % i == 0) 
    {
        resultat = " n'est pas un nombre premier";
    }
Console.WriteLine(nbrPremier + resultat);
