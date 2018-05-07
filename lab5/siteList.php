<?php
    //starts a session
    session_start();
    //includes different php pages
    include_once('header.php');
    require_once("db.php");
    require_once("functions.php");
    include_once("sitelistings.php");
    //initializes variables
    $action = ( array_key_exists( 'action',$_REQUEST) ? $_REQUEST['action'] : "");
    $siteSelectList = filter_input(INPUT_GET,'siteSelectList', FILTER_SANITIZE_STRING) ?? "";
    //switch for action
    switch($action)
    {
        case "SiteSelect":
            siteSelectFunc($db,$siteSelectList);
            break;
    }
   
?>