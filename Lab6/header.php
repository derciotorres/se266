<center>


<h1>The most boring Cart Website, Have fun!</h1>
<?php
echo date("Y-m-d");
?>
<br>
<a href="index.php">Home Page</a> &nbsp;&nbsp;&nbsp;
<a href="cartCheckout.php">Cart</a> &nbsp;&nbsp;&nbsp;


<?php
if(session_status() == PHP_SESSION_NONE){
    session_start();
}

if(isset($_SESSION['loggedInUsername']))
{

}

else{
    $_SESSION['loggedInUsername'] = "";
}

if($_SESSION['loggedInUsername'] != "")
{
    ?>
        <a href="logout.php">Log Out</a>
    <?php
}
else
{
    ?>
        <a href="login.php">Login Page</a>
		
    <?php
}


?>

<br><br>
</center>