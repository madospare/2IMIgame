<?php

$serverName = "localhost";
$dbUsername = "root";
$dbPassword = "";
$dbName = "cnackDB";

$conn = mysqli_connect($serverName, $dbUsername, $dbPassword, $dbName);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Kode som skaper en kobling mellom server og database