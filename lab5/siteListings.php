<?php
    //grabs all info from the sites 
    $sql = "SELECT * FROM sites";
    $sql = $db->prepare($sql);
    $sql->execute();
    $results = $sql->fetchAll(PDO::FETCH_ASSOC);
?>
<form action="sitelist.php" method="get">
    <?php
    if(!isset($_GET['siteSelectList'])){
        $_GET['siteSelectList'] = 0;
    }
    ?>
    <!--creates a drop down list-->
    <select name="siteSelectList">
        <!---default option-->
        <option selected="selected">pick a website
        <?php
            foreach($results as $result) {
                ?>
                <!--lists every site in the sites table-->
                <option id="listoption" <?php
                    if($_GET['siteSelectList'] == $result['site_id']){
                        echo 'selected="true"';
                    }
                ?> value="<?php print_r($result['site_id']); ?>"><?php print_r($result['site']); ?></option>
                <?php
            }
            ?>
    </select>
    <input type="submit" name="action" value="SiteSelect" />
</form>