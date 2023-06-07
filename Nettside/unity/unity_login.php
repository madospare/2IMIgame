<?php

$serverName = "localhost";
$dbUsername = "root";
$dbPassword = "gnome123";
$dbName = "cnackDB";

$uid = $_POST["uid"];
$pwd = $_POST["pwd"];

$conn = mysqli_connect($serverName, $dbUsername, $dbPassword, $dbName);

if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}
echo "Connected successfully. User list: <br><br>";

$sql = "SELECT password FROM users WHERE username = " . "'" . $uid . "'";

$result = $conn->query($sql);

if ($result->num_rows > 0) {
    while ($row = $result->fetch_assoc()) {
        if (password_verify($pwd, $row["password"])) {
            echo "Login Success!";
        } else {
            echo "Login failed. Please try again.";
        }
    }
} else {
    echo "Login failed. That user does not exist!";
}

$conn->close();

?>