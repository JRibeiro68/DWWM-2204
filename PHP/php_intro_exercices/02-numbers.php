<?php
//Exercice 2.a
//Créer une fonction « getSum() » qui accepte deux arguments de type int. Elle devra retourner la somme des deux valeurs. 

function getSum (int $nbr1, int $nbr2) : int
{
    return $nbr1 + $nbr2;
}

$nbr1 = readline('Veuillez saisir un 1er nombre: ');
$nbr2 = readline('Veuillez saisir un 2ème nombre: ');

echo 'La somme de '. $nbr1 . ' et de ' . $nbr2 . ' est de ' . getSum($nbr1, $nbr2) . PHP_EOL;


//Exercice 2.b
//Créer une fonction « getSub() » qui accepte deux arguments de type int. Elle devra retourner la soustraction des deux valeurs. 

function getsub (int $nbr1, int $nbr2) : int
{
    return $nbr1 - $nbr2;
}

$nbr1 = readline('Veuillez saisir un 1er nombre: ');
$nbr2 = readline('Veuillez saisir un 2ème nombre: ');

echo 'La soustraction de ' . $nbr1 . ' et de ' . $nbr2 . ' est égal à ' . getsub($nbr1, $nbr2) . PHP_EOL;


//Exercice 2.c
/**
 * Créer une fonction getMulti() qui accepte deux arguments de type float. Elle devra retourner la multiplication des deux valeurs.
 * Limitez le résultat à 2 décimales.
 */

 function getMulti (float $nbr1, float $nbr2) : float
 {
     return number_format($nbr1 * $nbr2, 2);
 }

 $nbr1 = readline('Veuillez saisir un 1er nombre: ');
 $nbr2 = readline('Veuillez saisir un 2ème nombre: ');

 echo 'La multiplication de ' . $nbr1 . ' et de ' . $nbr2 . ' est égal à ' . getMulti($nbr1, $nbr2) . PHP_EOL;


