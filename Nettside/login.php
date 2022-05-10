<?php
    include_once 'header.php';
?>

<h3>Log In</h3>

<form action="includes/login-inc.php" method="post" class="userUI">

    <input type="text" name="uid" placeholder="Username/Email...">
    <br>
    <br>
    <input type="password" name="pwd" placeholder="Password...">
    <br>
    <br>
    <button type="submit" name="submit">Log In</button>

<?php

if (isset($_GET["error"])) {
    if ($_GET["error"] == "emptyinput") {
        echo "<p>Error: Fill in all fields before signing up!</p>";
    } else if ($_GET["error"] == "wronglogin") {
        echo "<p>Error: Incorrect username or password!</p>";        
    }
}

?>

</form>

<h4>What will account information be used for?</h4>
<p>Account information will be stored. Email will be used for sending updates, usernames will be visible for other players in game. Account name won't be used for anything.</p>

<?php
    include_once 'footer.php';
?>