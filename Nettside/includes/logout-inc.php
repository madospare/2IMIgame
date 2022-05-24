<?php

// Logut kode
// Fjerner all data som er registrert for akkurat denne "økta",
//og så er brukeren flyttet til hoved siden

session_start();
session_unset();
session_destroy();

header("location: ../index.php");
exit();