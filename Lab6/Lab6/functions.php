<center>
<?php

//this is all my functions for my whole shopping cart 
    
//Function to register my user 
    function registerUserFunc($db,$email,$pword,$pword2){
        $sql = "SELECT * FROM users";
        $sql = $db->prepare($sql);
        $sql->execute();
        $results = $sql->fetchAll(PDO::FETCH_ASSOC);

        $boolVar = true;

        foreach($results as $result) {
            if ($email == $result['email']) {
                $boolVar = false;
            }
        }

        if($pword == $pword2) {

            if ($boolVar) {
                try {
                    $pwordHash = hash('sha1',$pword);
                    $sql = "INSERT INTO users VALUES(null,:email,:password,NOW())";
                    $sql = $db->prepare($sql);
                    $sql->bindParam(':email', $email);
                    $sql->bindParam(':password', $pwordHash);
                    $sql->execute();

                    echo "<br>Successfully created!";
                } catch (PDOException $err) {
                    die("Error");
                }
            } else {
                ?>
                <p>Email already exists </p>
                <?php
            }
        }
        else{
            ?>
                <p>Passwords do not match.</p>
            <?php
            include_once('register.php');
        }
    }
	
	function pullTable($db,$categorySelectList){
        $sql = "SELECT * FROM products WHERE category_id = :category";
        $sql = $db->prepare($sql);
        $sql->bindParam(':category',$categorySelectList);
        $sql->execute();
        $results = $sql->fetchAll(PDO::FETCH_ASSOC);
        return $results;
    }
//log in function
    function loginUserFunc($db,$email,$pword){
        $sql = "SELECT * FROM users WHERE email = :email";
        $sql = $db->prepare($sql);
        $sql->bindParam(':email',$email);
        $sql->execute();
        $results = $sql->fetch(PDO::FETCH_ASSOC);

        $loggedInBool = false;

        $pwordHash = hash('sha1',$pword);

        //iif email and password checks up it will go through
        if($email == $results['email'] && $pwordHash == $results['password']){
            ?>
                <p>Logged in!</p>
            <?php
            //sets loggedinbool variable to true
            $loggedInBool = true;
            $_SESSION["loggedIn"] = true;

            $_SESSION["loggedInUsername"] = $email;
            ?>
            <br><br>
            <a href="index.php" >Continue</a>
            <br><br>
            <?php
        }

        else{
            ?>
            <p>Incorrect username Or password.</p>
            <?php
            include_once("login.php");
        }
    }

    //adds a new category
    function addCategory($db,$categoryName){
        $sql = "SELECT * FROM categories";
        $sql = $db->prepare($sql);
        $sql->execute();
        $results = $sql->fetchAll(PDO::FETCH_ASSOC);
        $boolVar = false;

        foreach($results as $result){
            if($categoryName == $result['category']){
                $boolVar = true;
            }
        }

        if($boolVar == false) {
            try {
                $sql = "INSERT INTO categories VALUES (null,:category)";
                $sql = $db->prepare($sql);
                $sql->bindParam(':category', $categoryName);
                $sql->execute();
            } catch (PDOException $e) {
                die("category could not be added");
            }
        }
        else{
            echo "already in DataBase.";
        }
    }
    //adds a new product to the Database
    function addProductFunc($db,$categoryID,$productName,$price,$image){
        try {
            $sql = "INSERT INTO products VALUES (null,:category_id,:product,:price,:image)";
            $sql = $db->prepare($sql);
            $sql->bindParam(':category_id', $categoryID);
            $sql->bindParam(':product', $productName);
            $sql->bindParam(':price', $price);
            $sql->bindParam(':image', $image);
            $sql->execute();
            ?>
                <p>product inserted!</p>
                <br><br>
                <a href="index.php">Back</a>
                <br><br>
            <?php
        }
        catch(PDOException $e){
            die("couldn't add product to DB.");
        }

    }

    function updateProductFunc($db,$ProductID){
        $sql = "SELECT * FROM products WHERE product_id = :product";
        $sql = $db->prepare($sql);
        $sql->bindParam(':product',$ProductID);
        $sql->execute();
        $results = $sql->fetch(PDO::FETCH_ASSOC);
		//my sessions will carrie my product 
        $_SESSION["imagePH"] = $results['image'];
        $_SESSION['productID'] = $ProductID;
        $_SESSION['categoryID'] = $results['category_id'];

        ?>

        <form method="get" action="adminside.php">
		<center>
                <p>Product Name: </p>
                <input type="text" name="ProductName" value="<?php echo $results['product'] ?>" />
                <p>Price: </p>
                <input type="text" name="Price" value="<?php echo $results['price'] ?>" />
                <p>Image: </p>
                <input type="file" name="image" value="<?php echo $results['image'] ?>" />
                <input type="submit" name="action" value="Update" />
		</center>
        </form>
        <?php
    }
    function updateFunc2($db,$ProductName,$Price,$image){
        ?>
            <p>Records Updated!</p>
        <?php
        $sql = "UPDATE products SET product = :product, price = :price,image = :image WHERE product_id = :productid";
        $sql = $db->prepare($sql);
        $sql->bindParam(':product',$ProductName);
        $sql->bindParam(':price',$Price);
        if($image == null){
           $image = $_SESSION["imagePH"];
        }
        $sql->bindParam(':image',$image);
        $sql->bindParam(':productid',$_SESSION['productID']);

        $sql->execute();
    }
	
	// function delete
    function deleteProductFunc($db,$productID){
        try {
            echo $productID;
            $sql = "SELECT * FROM products WHERE product_id = :id";
            $sql = $db->prepare($sql);
            $sql->bindParam(':id',$productID);
            $sql->execute();
            $results = $sql->fetch(PDO::FETCH_ASSOC);
            $sql = $db->prepare("DELETE FROM products WHERE product_id = :id");
            $sql->bindParam(':id', $productID,PDO::PARAM_INT);
            $sql->execute();
            ?>
            <h1><?php

                echo $results['product'];

                if($results['product'] == null){
                    echo $results['product_id'];
                }
                ?>deleted!</h1>
            <?php
        }
        catch(PDOException $e){
            die("couldn't delete product.");
        }
    }
//clear function , clear all the sessions variables 
    function clearCart()
    {
        $_SESSION["cart"] = array();
        $_SESSION["count"] = 1;
        $_SESSION["subtotal"] = 0;

        ?>
            <p>Cart Cleared!</p>
        <br>
            <a href="index.php">Back</a>
        <br><br>
        <?php
    }
//Order submit 
    function orderSubmitFunc($db,$shippingVar,$taxVar)
    {
        if(!isset($_SESSION["loggedIn"]))
        {
            $_SESSION["loggedIn"] = false;
        }

        if($_SESSION["loggedIn"] == true) {
            $sql = "SELECT * FROM users WHERE email = :email";
            $sql = $db->prepare($sql);
            $sql->bindParam(':email', $_SESSION["loggedInUsername"]);
            $sql->execute();
            $resultsUsers = $sql->fetch(PDO::FETCH_ASSOC);
            try {
                $sql = "INSERT INTO orders VALUES(null,:userID,:dateN,:shipping,:taxes,:total)";
                $dateN = date("Y/m/d");
                $sql = $db->prepare($sql);
                $sql->bindParam(':userID', $resultsUsers["user_id"]);
                $sql->bindParam(':dateN', $dateN);
                $sql->bindParam(':shipping', $shippingVar);
                $sql->bindParam(':taxes', $taxVar);
                $sql->bindParam(':total', $_SESSION["total"]);
                $sql->execute();
                $lastInsertVar = $db->lastInsertId();

                ?>

                <p>Order Placed!</p>
                <br>
                <p>Order #: <?php echo $lastInsertVar ?></p>

                <?php

                foreach ($_SESSION["cart"] as $items) {
                    $sql = "INSERT INTO orderItems VALUES(:order_id,NULL,:product_id,:quantity,:price)";
                    $sql = $db->prepare($sql);
                    $sql->bindParam(':order_id', $lastInsertVar);
                    $sql->bindParam(':product_id', $items['product_id']);
                    $sql->bindParam(':quantity', $items['quantity']);
                    $sql->bindParam(':price', $items['price']);
                    $sql->execute();
                }
            } catch (PDOException $e) {
                die("INSERTION FAILED");
            }
        }
        if($_SESSION["loggedIn"] == false)
        {
            ?>
                <p>You need an account to log in </p>
                <a href="login.php">Click Here To Login</a>
            <?php
        }
    }

?>

<center>











































