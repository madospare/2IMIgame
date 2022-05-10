<?php

function emptyInputSignup($name, $email, $username, $password, $confirmpw) {
    $result;
    if (empty($name) || empty($email) || empty($username) || empty($password) || empty($confirmpw)) {
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function invalidUsername($username) {
    $result;
    if (!preg_match("/^[a-zA-Z0-9]*$/", $username)) {
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function invalidEmail($email) {
    $result;
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function passwordMatch($password, $confirmpw) {
    $result;
    if ($password !== $confirmpw) {
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function usernameExists($conn, $username, $email) {
    $sql = "SELECT * FROM users WHERE username = ? OR email = ?;";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("location: ../signup.php?error=stmtfailed");
        exit();    
    }

    mysqli_stmt_bind_param($stmt, "ss", $username, $email);
    mysqli_stmt_execute($stmt);

    $resultData = mysqli_stmt_get_result($stmt);

    if ($row = mysqli_fetch_assoc($resultData)) {
        return $row;
    } else {
        $result = false;
        return $result;
    }

    mysqli_stmt_close($stmt);
}

function createUser($conn, $name, $email, $username, $password) {
    $sql = "INSERT INTO users (name, email, username, password) VALUES (?, ?, ?, ?);";
    $stmt = mysqli_stmt_init($conn);
    if (!mysqli_stmt_prepare($stmt, $sql)) {
        header("location: ../signup.php?error=stmtfailed");
        exit();    
    }

    $hashedPwd = password_hash($password, PASSWORD_DEFAULT);

    mysqli_stmt_bind_param($stmt, "ssss", $name, $email, $username, $hashedPwd);
    mysqli_stmt_execute($stmt);
    mysqli_stmt_close($stmt);
    header("location: ../signup.php?error=none");
    exit();     
}

function emptyInputLogin($username, $password) {
    $result;
    if (empty($username) || empty($password)) {
        $result = true;
    } else {
        $result = false;
    }

    return $result;
}

function loginUser($conn, $username, $password) {
    $usernameExists = usernameExists($conn, $username, $username);

    if ($usernameExists === false) {
        header("Location: ../login.php?error=wronglogin");
        exit();
    }

    $passwordHashed = $usernameExists["password"];
    $checkPassword = password_verify($password, $passwordHashed);

    if ($checkPassword === false) {
        header("Location: ../login.php?error=wronglogin");
        exit();    
    } else if ($checkPassword === true) {
        session_start();
        $_SESSION["ID"] = $usernameExists["userID"]; 
        $_SESSION["Username"] = $usernameExists["username"]; 
        header("Location: ../index.php");
        exit();  
    }
}