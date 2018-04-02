<?php

$table='';
for ($rows=0; $rows<10; $rows++)
	{
    $table .= "<tr>";
    for ($cols=0; $cols<10; $cols++) 
	{
        $colors = randColor();
        $table .= "<td style='background-color:#$colors'>$colors<br><span class='whitetext'>$colors</span></td>";
    }
    $table .= '</tr>';
	}
	
	
function randColor() 
{	

	$blue = rand(0,255);
    $red = rand(0,255);
    $green = rand(0,255);
    

    return sprintf('%02X%02X%02X', $red, $green, $blue);
}
?>
<!doctype html>

<html lang="en">
<head>
<meta charset="UTF-8">
<style type='text/css'>
table {
    border-collapse: separate;
	
}
td {
    width: 50;
    height: 50;
    font-family: Arial;
    font-size: 10pt;
    text-align: center;
}
.whitetext {
    color: white;
}

</style>
<title>Random grid</title>
</head>
<body>
<table align="center">
    <?=$table?>
</table>
</body>
</html>