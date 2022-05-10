<?php
    include_once 'header.php';
?>

<?php
    if (isset($_SESSION["Username"])) {
        echo "<p id='hello'>Hello there " . $_SESSION["Username"] . ".</p>";
    }
?>
        <h3>Downloads:</h3>
        <a href="../media/CNACK.zip" download>Download latest version of the game</a> <br>
        <p>Extract the zip-file and play the game!</p>
        <br>
        <a href="https://github.com/madospare/2IMIgame" target="_blank">Download the gamefiles from github</a>

<?php
    include_once 'footer.php';
?>