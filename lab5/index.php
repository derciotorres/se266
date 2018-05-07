<?php
    //the index page is the site entry page
  
    session_start();  //create a session
    if(isset($_SESSION['searchVar']))
    {
    }
    else{
        $_SESSION['searchVar'] = "";
    }
    if(isset($searchVar)) {
        if ($searchVar != null) {
            $_SESSION['searchVar'] = $searchVar;
        }
        if ($searchVar == null) {
            $_SESSION['searchVar'] = null;
        }
    }
			//database connection, and the site entry form.
			include_once("header.php");
			require_once("db.php");
			require_once("functions.php");
			include_once("Entries.php");
	
	
			//initializes different variables
			$action = ( array_key_exists( 'action',$_REQUEST) ? $_REQUEST['action'] : "");
			$searchVar = filter_input(INPUT_GET,'searchVar', FILTER_SANITIZE_STRING) ?? "";
			$searchTerm = filter_input(INPUT_GET,'searchTerm', FILTER_SANITIZE_STRING) ?? "";
    //creates a switch
    switch($action)
    {
        case "SiteSearch":
            $_SESSION['searchVar'] = $searchVar;
            siteSearch($db,$searchVar);
            break;
    }
	
	?>