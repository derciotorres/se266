<center>
<?php
    if(!isset($_SESSION["imagePH"])){
        session_start();
    }

    include_once("header.php");
    include_once("functions.php");
    include_once("db.php");
    include_once("../products.php");

    $action = ( array_key_exists( 'action',$_REQUEST) ? $_REQUEST['action'] : "");

    $emailVar = filter_input(INPUT_GET,'emailVar', FILTER_SANITIZE_EMAIL) ?? "";
    $passwordVar = filter_input(INPUT_GET,'passwordVar', FILTER_SANITIZE_STRING) ?? "";
    $categoryID = filter_input(INPUT_GET,'categoryID', FILTER_SANITIZE_STRING) ?? "";
    $ProductName = filter_input(INPUT_GET,'ProductName', FILTER_SANITIZE_STRING) ?? "";
    $Price = filter_input(INPUT_GET,'Price', FILTER_SANITIZE_STRING) ?? "";
    $image = filter_input(INPUT_GET,'image', FILTER_SANITIZE_STRING) ?? "";
    $categoryName = filter_input(INPUT_GET,'categoryName', FILTER_SANITIZE_STRING) ?? "";
    $productID = filter_input(INPUT_GET,'productID', FILTER_SANITIZE_STRING) ?? "";
    $imagePH = filter_input(INPUT_GET,'imagePH', FILTER_SANITIZE_STRING) ?? "";

    $passwordVarConfirm = filter_input(INPUT_GET,'passwordVarConfirm', FILTER_SANITIZE_STRING) ?? "";
    if(isset($_SESSION['loggedIn'])){

    }
    else{
        $_SESSION['loggedIn'] = "";
    }

    if($_SESSION['loggedInUsername'] != ""){
        ?>
        <h2>Welcome back, <?php echo $_SESSION['loggedInUsername'];?> </h2>
        <br><br>

        <?php
        include_once("categoryAdd.php");
        ?>
 <br><br>
        <?php
        include_once("admin2.php");
        ?>
 <br><br>
        <?php

    }

    switch($action)
    {
        case "registerUser":
            registerUserFunc($db,$emailVar,$passwordVar,$passwordVarConfirm);
            break;
        case "Login":
            loginUserFunc($db,$emailVar,$passwordVar);
            break;
        case "AddProduct2":
            include_once("addProduct.php");
            break;
        case"AddCategory":
            addCategory($db,$categoryName);
            break;
        case "UpdateProduct":
            updateProductFunc($db,$productID);
            break;
        case "UpdateProduct2":
            include_once('updateProduct.php');
            break;
        case "Update":
            updateFunc2($db,$ProductName,$Price,$image);
            break;
        case "CategoryAdd":
            categoryAddFunc($db,$categoryName);
            break;
        case "DeleteProduct2":
            include_once("deleteProduct.php");
            break;
        case "DeleteProduct":
            deleteProductFunc($db,$productID);
            break;
        case "ViewOrders":
            include_once("../ordersTable.php");
            break;



        default:
}
include_once("footer.php");
?>
</center>


