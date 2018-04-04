<?php
// people table view
foreach ($people as $person) {
	echo $person['fName'] ." " . $person['lName'] . " " . $person['age'];
	echo "<br />";
	
}
?>
<form action='index.php' method='get'>
	<input type='submit' name='action' value="Add" />
</form>