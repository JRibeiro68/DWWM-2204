<?php

//Exercice 4.A
echo "Exercice 4.A" . PHP_EOL;
echo "Créer une fonction « isMajor() » acceptant un argument de type int. Elle devra retourner un booléen. 
Si l’âge est supérieur ou égal à 18, elle doit retourner true. Sinon elle doit retourner false." . PHP_EOL;

function isMajor($majority) : bool
 {
    $majority = 18;
    $age = readline('quel âge avez-vous ? ');
    if ($age >= $majority)
    {
        return  true;
    }
    else
    {
        return  false;
    }
    
 }
 echo isMajor($majority);



 //Exercice 4.B
 echo 'Créer une fonction « getRetired() » acceptant un argument de type int. Elle devra retourner un string. 
 Cette fonction permet de calculer le nombre d’années restant avant la retraite ou le nombre d’années depuis la retraite.
 Pour cet exercice, l’âge de la retraite est fixé à 60 ans.' . PHP_EOL;


function getRetired(int $ageActuel) : string 
{
$ageRetraite = intval(60);

if ($ageActuel > $ageRetraite)
    {
        $ageDiff = $ageActuel - $ageRetraite;
        
        return ' Vous ètes à la retraite depuis ' . $ageDiff . ' an';
    }
    elseif (($ageActuel < $ageRetraite) && ($ageActuel > 0))
    {
        $ageDiff = $ageRetraite - $ageActuel;
        return 'Il vous reste ' . $ageDiff . ' avant la retraite';
    }
    elseif ($ageActuel === $ageRetraite)
    {
        return ' Vous ètes à la retraite cette annéee ';
    }
    else
    {
        return " Vous n'ètes pas encore né ";
    }

}
echo getRetired(-3) . PHP_EOL;



//Exercice 4.C
 echo 'Créer une fonction « getRetired() » acceptant un argument de type int. Elle devra retourner un string. 
 Cette fonction permet de calculer le nombre d’années restant avant la retraite ou le nombre d’années depuis la retraite.
 Pour cet exercice, l’âge de la retraite est fixé à 60 ans.' . PHP_EOL;

 function getMax(float $nbr1, float $nbr2, float $nbr3) : float

 {
     if ($nbr1 === $nbr2 || $nbr1 === $nbr3 || $nbr2 === $nbr3)
     {
         return "0";
     }
     if($nbr1 < $nbr2)
     {
         if($nbr2 < $nbr3)
         {
             return $nbr3;
         }
         elseif ($nbr3 < $nbr2)
         {
             return $nbr2;
         }
         else
         {
             return $nbr1;
         }
     }
    else// $nbr2< $nbr1
     {
         if($nbr1 < $nbr3)
         {
             return $nbr3;
         }
         elseif($nbr3 < $nbr2)
         {
             return $nbr1;
         }
         else
         {
             return $nbr2;
         }
     }

 }

 $nbr1 = floatval(readline('Veuillez saisir le 1er nombre : '));
 $nbr2 = floatval(readline('Veuillez saisir le 2ème nombre : '));
 $nbr3 = floatval(readline('Veuillez saisir le 3ème nombre : '));

 $result = number_format(getMax($nbr1, $nbr2, $nbr3), 3, ',');

 echo 'Le plus grand des 3 nombres est : ' . $result . PHP_EOL;


 //Exercice 4.C
 echo 'Créez une fonction « capitalCity() » qui accepte un argument de type string (le pays dont on cherche la capitale). 
 Elle devra retourner le nom de la capitale des pays suivants :' . PHP_EOL;

 function capitalCity(string $pays) : string
 {
    switch($pays)
    {
        case 'France' :
            return 'paris'; 
            break;
        case 'Allemagne' :
            return 'Berlin';
            break;
        case 'Italie' :
            return 'Rome';
            break;
        case 'Maroc' :
            return 'Rabat';
            break;
        case 'Espagne' :
            return 'Madrid';
            break;
        case 'Portugal' :
            return 'Lisbonne';
            break;
        case 'Angleterre' :
            return 'Londres';
            break;
        default :
            return 'Capitale inconnue';
            break;
    }

 }

 $pays = readline('Entrez un nom de pays : ');
 $reponse = capitalCity($pays);

 echo $reponse . PHP_EOL;
