<?php
    //function for searching for links to a site
    function siteSearch($db,$searchVar){
        //sets the session variable searchvar = to the local variable searchvar
        $_SESSION['searchVar'] = $searchVar;
        //search term, a regex
        $searchTerm = "/(https?:\/\/[\da-z\.-]+\.[a-z\.]{2,6}[\/\w \.-]+)/";
        $sql = "SELECT * FROM sites";
        $sql = $db->prepare($sql);
        $sql->execute();
        $results = $sql->fetchAll(PDO::FETCH_ASSOC);
        
        $count = 0;//set count = 0
        $resultsSize = count($results);
        $boolV = true;// boolvar = to true
        //while count is less than the size of $results array...
        while ($count < ($resultsSize))
		{	
         if($searchVar == $results[$count]['site']) 
		 {
         $count = $resultsSize; 
         $boolV = false;
         }
                // else keep adding to count
                $count++;
        }  
        if($boolV) {
            //executes a sql statement and inserts the search website in the DB
            $sql = "INSERT INTO sites VALUES (null,:site,NOW())";
            $sql = $db->prepare($sql);
            $sql->bindParam(':site', $searchVar);
            $sql->execute();
           
            $_SESSION["siteID"] = $db->lastInsertID(); //grabing the last ID inserted into the DB
            $file = file_get_contents($searchVar);
            //grabs links from the site typed in and tells how many marches had 
            echo preg_match_all($searchTerm, $file, $matches, PREG_OFFSET_CAPTURE);
            ?>
                 links added !
                <br><br>
            <?php
			
            $newMatches = array_unique($matches, SORT_REGULAR);
            //a foreach loop that inserts every link found on the site into the table sitelinks
           
						foreach ($newMatches as $match) {
							foreach ($match as $ma) {
								//prints the link on screen as text
								print_r($ma[0]);
								//sets variable siteID = to session variable siteID
								$siteID = $_SESSION["siteID"];
								$sql = "INSERT INTO sitelinks VALUES(:siteIDp,:map)";
								$sql = $db->prepare($sql);
								$sql->bindParam(':siteIDp', $siteID);
								$sql->bindParam(':map', $ma[0]);
								$sql->execute();
								echo "<br>";
							}
						}
        }
        else{
            //sets the session variable 'searchVar' to a  local variable
            $_SESSION['searchVar'] = $searchVar;
            //prints to the screen telling the user it's been looked up previously
            echo "\"" . $searchVar . "\"links are already in Data Base !";
        }
    }
    //function for looking the sites
    function siteSelectFunc($db,$siteSelect){
        
        $sql = "SELECT * FROM sitelinks WHERE site_id = :id";
        $sql = $db->prepare($sql);
        $sql->bindParam(':id',$siteSelect);
        $sql->execute();
        $results = $sql->fetchAll(PDO::FETCH_ASSOC);
        //sql statement to pull the sites from the database 
        $sql = "SELECT site FROM sites WHERE site_id = :id";
        $sql = $db->prepare($sql);
        $sql->bindParam(':id',$siteSelect);
        $sql->execute();
        $siteName = $sql->fetchAll(PDO::FETCH_ASSOC);
        ?>

        <h1><?php echo $siteName[0]['site'] ?> links</h1>
        <h2>retrieved and stored  <?php echo date("m-d-Y") ?></h2>

        <?php
       
        foreach($results as $result)
        {
           //for each link, print is out as a actual clickable links
		   //displays all the links for each website 
            ?>
            <a target="popup" href="<?php echo $result['link'];  ?>"><?php echo $result['link']; ?></a>
            <br>
            <?php
        }
    }
?>