<?php
/*

//Exercice 5.A
echo "Exercice 5.A" . PHP_EOL;
echo "Créer une fonction « getToday() ». Cette fonction doit afficher et retourner la date du jour au format d/m/Y sous forme de 
chaine de caractères (exemple : 21/10/2020)." . PHP_EOL;

function getToday() : string
{
$date = date("d/m/y");
echo $date . PHP_EOL;
return $date;

}

$resultat = getToday();

*/

//Exercice 5.B
echo "Exercice 5.B" . PHP_EOL;
echo "Créer une fonction « getTimeLeft() » acceptant un argument de type string et qui retourne une chaine de caractère.
La valeur de l'argument représente une date au format Y-m-d (ex: 2020-11-23). 
La fonction doit vérifier si la date fournie est valide (bon format, date cohérente).
Si la date est ultérieure à la date du jour, la fonction retourne la différence en années/mois/jours.
Si la date est égale à la date du jour, la fonction retourne « Aujourd'hui ».
Si la date est antérieur à la date du jour, la fonction retourne « Évènement passé »." . PHP_EOL;

function getTimeLeft($date) : string
{
    $date = new DateTime("Y/m/d");
    $dateDuJour = new DateTime();
    
   
    $interval = date_diff($dateDuJour,$date);

    if ($date == $dateDuJour)
    {
        return 'Aujourd\'hui';
    }

    if ($date < $dateDuJour)
    {
       return 'Evenement passé';
    }
    else if ($date > $dateDuJour)
    {
        return $interval->format("Y-m-d");
    }
    else 
        return 'Date invalide';
     
}
echo getTimeLeft("2022-11-07");
