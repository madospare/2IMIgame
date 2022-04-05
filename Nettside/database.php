<?php

$host = "localhost";    // Host name
$db_username = "admin";     //Mysql username
$db_password = "gnome123";     // Mysql password
$db_name = "GameDB";     // Database name

$mysqli_connection = mysqli_connect($host, $db_username, $db_password, $db_name)or die("cannot connect");

?>