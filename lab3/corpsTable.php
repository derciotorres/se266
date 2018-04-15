
<center>
<h1> Corporations App </h1>
<form action="index.php" method="get">
        <?php

    foreach($corp as $corporation) 
	{
        ?>

        <tr><br>
            <td id="corpNameTD">
                <?php
                    echo $corporation["corp"];
                ?>
            </td>
            <td><a href="?action=Read&id=<?php echo $corporation['id'] ?>">Read</a></td>
            <td><a href="?action=Update&id=<?php echo $corporation['id'] ?>">Update</a></td>
            <td><a href="?action=Delete&id=<?php echo $corporation['id'] ?>">Delete</a></td>
        </tr>
        <?php
    }
    ?>
        <br />
</center>
		<center>
        <a href="?action=Add2">Add New Corporation</a>
        </center>


<center>
        <h2>4/15/218 Dercio Torres</h2>
</center>
</form>
