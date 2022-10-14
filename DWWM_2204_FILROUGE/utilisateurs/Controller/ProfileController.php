<?php

namespace Users\Controller;

class ProfileController
{

    public function index()
    {
        echo ProfileController::class;
        require '../View/profile.php';
    }
}

// User\Controller\Profilecontroller