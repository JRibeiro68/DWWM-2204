// See https://aka.ms/new-console-template for more information

string strLigne;
int entier;
int reste;


Console.WriteLine("Saisissez un entire :");
strLigne = Console.ReadLine();

entier = Int32.Parse(strLigne);

reste = entier % 2;
if (reste == 0)
{
    Console.WriteLine("Entier pair !");
}

