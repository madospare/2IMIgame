<?php

// Registreringskoden
// Sjekker først etter feil fra bruker input, før brukeren registreres

if (isset($_POST["submit"])) {
    
    $name = $_POST["name"];
    $email = $_POST["email"];
    $username = $_POST["username"];
    $password = $_POST["password"];
    $confirmpw = $_POST["confirmpw"];

    require_once 'dbh-inc.php';
    require_once 'functions-inc.php';

    if (emptyInputSignup($name, $email, $username, $password, $confirmpw) !== false) {
        header("location: ../signup.php?error=emptyinput");
        exit();
    }

    if (invalidUsername($username) !== false) {
        header("location: ../signup.php?error=invalidusername");
        exit();
    }

    if (invalidEmail($email) !== false) {
        header("location: ../signup.php?error=invalidemail");
        exit();
    }

    if (passwordMatch($password, $confirmpw) !== false) {
        header("location: ../signup.php?error=passwordunmatch");
        exit();
    }

    if (usernameExists($conn, $username, $email) !== false) {
        header("location: ../signup.php?error=usernametaken");
        exit();
    }

    createUser($conn, $name, $email, $username, $password);

} else {
    header("location: ../signup.php");
    exit();
}