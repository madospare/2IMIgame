<?php
    session_start();
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>CNACK</title>
    <link rel="icon" type="image/x-icon" href="media/favicon.ico">
    <link rel="stylesheet" href="CSS/style.css"?v=<?php echo time(); ?>">>
</head>
<body>
    
    <div class="navbar" id="top">
        <img src="media/GameIcon.png" class="gameIcon">
        <h1>CNACK</h1>
        <ul>
            <li><a href="index.php">Home</a></li>
            <li><a href="lovverk.php">Laws (Norwegian)</a></li>
            <li><a href="support.php">Support</a></li>
            <?php
                if (isset($_SESSION["Username"])) {
                    echo "<li><a href='downloads.php'>Downloads</a></li>";
                    echo "<li><a href='includes/logout-inc.php'>Log out</a></li>";
                } else {
                    echo "<li><a href='login.php'>Log in</a></li>";
                    echo "<li><a href='signup.php'>Sign up</a></li>";    
                }
            ?>
        </ul>
    </div>

    <div class="textbox">