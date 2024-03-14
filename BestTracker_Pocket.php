<?php
$pocketHave = array();
$pocketAll = array(1,2,3,4,5,6,7);
start($j++, 'All Revealed Pocket Cards', $pocketHave, $pocketAll);
foreach ($pocketAll as $cur) { if (in_array($cur, $pocketHave, true)) {imgPN($cur);} else {imgP($cur);} }
finish();
?>
