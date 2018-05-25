
<?php
    include_once("header.php");
    include_once("db.php");
    include_once("functions.php");
    include_once("products.php");


    $action = ( array_key_exists( 'action',$_REQUEST) ? $_REQUEST['action'] : "");

    ?>

<Center>

    <h4><b>Subtotal: $</b><?php echo $_SESSION["subtotal"]; ?></h4>
    <h4>Shipping: $<?php $shippingVar = 20.00;
    echo $shippingVar; ?></h4>
    <h4>Taxes: $<?php $taxVar = ($_SESSION["subtotal"] * .08);
    echo $taxVar ?></h4>

    <h5>Total: $<?php
        $_SESSION["total"] = $_SESSION["subtotal"] + $shippingVar + $taxVar;
        $_SESSION["total"] = round($_SESSION["total"],2);
        echo $_SESSION["total"]; ?></h5>
    <?php

    ?>

    <br><br>
    <a href="?action=order" id="orderBtn">Order</a>
</Center>

    <?php
    include_once("footer.php");

  
?>






































