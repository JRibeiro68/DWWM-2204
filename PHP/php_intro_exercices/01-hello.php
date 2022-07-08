<?php
/**
 * Affiche "Hello world !"
 */

function helloWorld()
{
    echo "Hello World !". PHP_EOL;
}

//test de la fonction (la fonction affiche directement le résultat)
helloWorld();

/**
 * Retourne "Hello $name !"
 * @param string $name le nom à afficher
 */


 function hello(string $name) : string
{
    return "Hello $name !" . PHP_EOL;
}

echo hello("Mike");



function helloNobody(string $name) : string
{
    if ($name === '')
    {
        return 'Nobody'. PHP_EOL;
    }
    else
    {
        return "Hello $name !" . PHP_EOL;
    }
}

$name = readline('Veuillez entrer votre prénom : ');
echo helloNobody($name);

?>