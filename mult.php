<?php
$size = mt_rand(5, 10);
$table = "<table>\n";
for ($rows= 1; $rows <= $size; $rows++)
{
	$table .="\t<tr>";
	for($cols =1; $cols<=$size; $cols++):
	$table .="<td>" . $rows*$cols . "</td>";
	endfor;
	$table .="\t</tr>\n";
	
}
$table .= "</table>\n";
echo $table;
?>

<!Doctype html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>Multiplication table</title>

</head>
<body>
<?php echo $table; ?>
</body>

</html>