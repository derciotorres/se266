<!---form for entering sites-->
<form action="index.php" method="get">
    <!--textbox for user to enter a site-->
    <input type="text" name="searchVar" id="searchVar" placeholder="http://www.google.com" pattern="https?://www.[A-z,0-9]{2,}.[A-z]{2,}" title="https://www.google.com" value="<?php
    //if it exists already
    if($_SESSION['searchVar'] != null)
    {
        echo $_SESSION['searchVar'];
    }

    else{
        echo "";
    } ?>">

    <!--submit button-->
    <input type="submit" name="action" value="SiteSearch">
</form>