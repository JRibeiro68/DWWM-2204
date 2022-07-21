<?php

//Exercice 6.A
echo "Exercice 6.A" . PHP_EOL;
echo "Créer une fonction « firstItem() » qui accepte un argument de type array. Elle devra retourner le premier élément du tableau. Si 
le tableau est vide, la fonction retourne null." . PHP_EOL;


function firstItem(array $names)

{
    if ($names[0] === '')
    {
        return null;
    }
    else
    {
        return $names[0];
    }
}
echo firstItem($names);


//Exercice 6.B

echo "Exercice 6.B" . PHP_EOL;
echo "Créer une fonction « lastItem() » acceptant un argument de type array. Elle devra retourner le dernier élément du tableau. Si le 
tableau est vide, il faudra retourner null." . PHP_EOL;


$names = ['Joe', 'Jack', 'Léa', 'Zoé', 'Néo'];

function lastitem(array $names)
{
    if ($names === '')
    {
        return null;
    }
    else
    {
        return $names;
    }
    
}
echo lastitem($names);
