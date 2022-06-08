int[] tab = new int[] { 8, 16, 32, 64, 128, 256, 512 };
int nombreN;

Console.WriteLine("Entrez un nombre");
nombreN = int.Parse(Console.ReadLine());
var check = Array.Exists(tab, x => x == nombreN);
if (check == true)
{
    Console.WriteLine("La valeur de l'indice du tableau est {0}", nombreN);
}
else
{
    Console.WriteLine("nombre non trouvé");
}


