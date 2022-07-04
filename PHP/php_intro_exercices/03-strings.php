<?php
echo "Exercice 3.a : " . PHP_EOL;
echo "Créer une fonction « getMC2() ».Cette fonction doit retourner Le nom de l’inventeur de la formule « E = MC² ».. " . PHP_EOL;
echo "". PHP_EOL;

function getMC2() 
{
    return "Einstein";
}
echo getMC2() . PHP_EOL;
echo "". PHP_EOL;

echo "Exercice 3.b : " . PHP_EOL;
echo "Créer une fonction « getUserName() » qui accepte deux arguments (prénom et nom) de type string. 
Cette fonction doit retourner la concaténation des deux valeurs. " . PHP_EOL;
echo "". PHP_EOL;

function getUserName (string $firstName, $name): string
{
    return $firstName . $name;
}

$firstName = readline('Veuillez saisir vortre prénom : ');
$name = readline('Veuillez saisir votre nom : ');

echo  getUserName($firstName, $name) . PHP_EOL;


echo "Exercice 3.c : " . PHP_EOL;
echo "Créer une fonction « getFullName() » acceptant deux arguments (nom et prénom) de type string. 
Cette fonction doit retourner la concaténation des deux valeurs avec un espace entre les 2, le prénom en minuscule et le nom
en MAJUSCULE." . PHP_EOL;
echo "". PHP_EOL;

function getFullName (string $firstName, $name): string
{
    $name = strtoupper($name);
    $firstName = strtolower($firstName);
    return $firstName . ' ' . $name;
}

$firstName = readline('Veuillez saisir vortre prénom : ');
$name = readline('Veuillez saisir votre nom : ');

echo  getFullName($firstName, $name) . PHP_EOL;


echo "Exercice 3.d : " . PHP_EOL;
echo "Créer une fonction « askUser() » acceptant deux arguments (nom et prénom) de type string. 
Cette fonction doit retourner une chaîne de caractères sous la forme :
« Bonjour prénom, nom. Connaissez-vous Einstein ? »
Cette fonction doit réutiliser les fonctions
- « getFullName() » pour obtenir la concaténation des deux valeurs.
- « getMC2() » pour obtenir le nom de l'inventeur de la formule E = MC²" . PHP_EOL;
echo "". PHP_EOL;

function askUser (string $firstName, string $name): string
{
return 'Bonjour ' . getFullName($firstName, $name) . ', connaissez- vous ' . getMC2() . ' ? ';
}


echo askUser($firstName, $name) . PHP_EOL;

?>