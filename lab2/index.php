<?php
require_once("db.php");
require_once("people.php");
$action = $_REQUEST['action'];
$fName = $_POST['fName'];
$lName = $_POST['lName'];
$age = $_POST['age'];
switch ($action){
	case "Add":
		include_once("personForm.php");
		break;
	case "Save":
		savePerson($db, $fName, $lName, $age);
		// get all the rows
		$people = getRows();
		// display the rows
		
		include_once("peopleTable.php");
		break;
	default:
		// get all the rows
		$people = getRows();
		// display the rows
		include_once("peopleTable.php");
}