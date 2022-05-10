<?php
    include_once 'header.php';
?>

<h3>Sign Up</h3>

<form action="includes/signup-inc.php" method="post" class="userUI">

    <input type="text" name="name" placeholder="Full name...">
    <br>
    <br>
    <input type="text" name="email" placeholder="Email...">
    <br>
    <br>
    <input type="text" name="username" placeholder="Username...">
    <br>
    <br>
    <input type="password" name="password" placeholder="Password...">
    <br>
    <br>
    <input type="password" name="confirmpw" placeholder="Confirm Password...">
    <br>
    <br>
    <button type="submit" name="submit">Sign Up</button>

<?php

if (isset($_GET["error"])) {
    if ($_GET["error"] == "emptyinput") {
        echo "<p>Error: Fill in all fields before signing up!</p>";
    } else if ($_GET["error"] == "invalidusername") {
        echo "<p>Error: Choose a propper username!</p>";        
    } else if ($_GET["error"] == "invalidemail") {
        echo "<p>Error: Choose a propper email!</p>";        
    } else if ($_GET["error"] == "passwordunmatch") {
        echo "<p>Error: Password doesn't match!</p>";        
    } else if ($_GET["error"] == "stmtfailed") {
        echo "<p>Error: An unexpected error has occured! Please try again.</p>";        
    } else if ($_GET["error"] == "usernametaken") {
        echo "<p>Error: Username already exists! Please choose a different username.</p>";        
    } else if ($_GET["error"] == "none") {
        echo "<p>Success... You're signed up!</p>";        
    }
}

?>

</form>

<h4>What will account information be used for?</h4>
<p>Account information will be stored. Email will be used for sending updates, usernames will be visible for other players in game. Account name won't be used for anything.</p>

<?php
    include_once 'footer.php';
?>