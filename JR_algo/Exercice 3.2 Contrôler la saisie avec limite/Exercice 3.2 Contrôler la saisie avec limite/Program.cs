// See https://aka.ms/new-console-template for more information

string motDePasse = "formation";
int tentative = 0;



    Console.WriteLine("Veuillez saisir votre mot de passe svp:");
    motDePasse = (Console.ReadLine());

if ((tentative < 3) && (motDePasse != "formation")) ;
{
    if (motDePasse == "formation") ;
    {
        Console.WriteLine("Vous ètes connecté:");

    }
}
    {
    if (tentative >= 3) ;
        Console.WriteLine("Votre compte est bloqué");
    }
