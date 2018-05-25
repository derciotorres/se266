
<?php

    if(!isset($_SESSION["subtotal"])){
        session_start();
        $_SESSION["subtotal"] = 0;
    }

    include_once("header.php");
    include_once("db.php");
    include_once("functions.php");
    include_once("products.php");

    ?>
    <?php

    $action = ( array_key_exists( 'action',$_REQUEST) ? $_REQUEST['action'] : "");

    include_once("cartTable.php");

    ?>
<center>
    <a href="checkout.php">Checkout</a>&nbsp;&nbsp;&nbsp;
    <a href="index.php?action=clearCart">Clear Cart</a>
</center>
    <?php



    switch($action){
        case "clearCart":
            clearCart();
            break;

        default:
    }



    include_once("footer.php");
?>