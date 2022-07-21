<?php

class Animal
{
    //Attribut de la classe
    protected string $species;

    private string $food;

    public function __construct(string $_species, string $_food)
    {
        $this->specifies = $_species;
        $this->food = $_food;
        echo 'Animal\'s Contructor for '.$this->species . PHP_EOL;

    }
    //Comportement de la fonction manger
    public function Eat() : void
    {
        echo $this->species . 'eats' . $this->food . PHP_EOL;

    }
    //Comportement de la function deplacer
    public function Move() : void
    
    {
        echo $this->species . 'moves' .PHP_EOL;
    }

    
}