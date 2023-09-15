<?php
$FUT_PC = array('PC1','PC2','PC3','PC4','PC5','PC6','PC7','PC8','PC9','PC10','PC11','PC12','PC13','PC14','PC15','PC16','PC17','PC18','PC19','PC20','PC21','PC22','PC23','PC24','PC25','PC26','PC27','PC28','PC29','PC30','PC31','PC32','PC33','PC34','PC35','PC36','PC37','PC38','PC39','PC40','PC41','PC42','PC43','PC44','PC45','PC46','PC47','PC48','PC49','PC50','PC51','PC52','PC53','PC54');
start($j++, 'Pokemon Card 151 (JP)', $have, $FUT_PC);
foreach ($FUT_PC as $cur) { imgF($cur); }
finish();

$FUT_RS = array('RS1','RS2','RS3','RS4','RS5','RS6','RS7','RS8','RS9','RS10','RS11','RS12','RS13','RS14','RS15','RS16','RS17','RS18');
start($j++, 'Raging Surf (JP)', $have, $FUT_RS);
foreach ($FUT_RS as $cur) { imgF($cur); }
finish();

$FUT_AR = array('AR1');
start($j++, 'Ancient Roar (JP)', $have, $FUT_AR);
foreach ($FUT_AR as $cur) { imgF($cur); }
finish();

$FUT_FF = array('FF1');
start($j++, 'Future Flash (JP)', $have, $FUT_FF);
foreach ($FUT_FF as $cur) { imgF($cur); }
finish();

$FUT_PR = array('PR1','PR2','PR3','PR4');
start($j++, 'Paradox Rift', $have, $FUT_PR);
foreach ($FUT_PR as $cur) { imgF($cur); }
finish();

$FUT_SVPEN = array('SVPEN1','SVPEN2');
start($j++, 'Scarlet & Violet Promo', $have, $FUT_SVPEN);
foreach ($FUT_SVPEN as $cur) { imgF($cur); }
finish();

$FUT_SVP = array('SVP1','SVP2','SVP3','SVP4','SVP5');
start($j++, 'Scarlet & Violet Promo (JP)', $have, $FUT_SVP);
foreach ($FUT_SVP as $cur) { imgF($cur); }
finish();

$FUT_EXSD = array('EXSD1');
start($j++, 'ex Starter Decks (JP)', $have, $FUT_EXSD);
foreach ($FUT_EXSD as $cur) { imgF($cur); }
finish();

$FUT_SST = array('SST1','SST2');
start($j++, 'Starter Set Terastal ex (JP)', $have, $FUT_SST);
foreach ($FUT_SST as $cur) { imgF($cur); }
finish();

$FUT_CLV = array('CLV1');
start($j++, 'Classic - Venusaur Deck', $have, $FUT_CLV);
foreach ($FUT_CLV as $cur) { imgF($cur); }
finish();

$FUT_CLC = array('CLC1');
start($j++, 'Classic - Charizard Deck', $have, $FUT_CLC);
foreach ($FUT_CLC as $cur) { imgF($cur); }
finish();

$FUT_CLB = array('CLB1');
start($j++, 'Classic - Blastoise Deck', $have, $FUT_CLB);
foreach ($FUT_CLB as $cur) { imgF($cur); }
finish();

$FUT_All = array('PC1','PC2','PC3','PC4','PC5','PC6','PC7','PC8','PC9','PC10','PC11','PC12','PC13','PC14','PC15','PC16','PC17','PC18','PC19','PC20','PC21','PC22','PC23','PC24','PC25','PC26','PC27','PC28','PC29','PC30','PC31','PC32','PC33','PC34','PC35','PC36','PC37','PC38','PC39','PC40','PC41','PC42','PC43','PC44','PC45','PC46','PC47','PC48','PC49','PC50','PC51','PC52','PC53','PC54','RS1','RS2','RS3','RS4','RS5','RS6','RS7','RS8','RS9','RS10','RS11','RS12','RS13','RS14','RS15','RS16','RS17','RS18','AR1','FF1','PR1','PR2','PR3','PR4','SVPEN1','SVPEN2','SVP1','SVP2','SVP3','SVP4','SVP5','EXSD1','SST1','SST2','CLV1','CLC1','CLB1');
start($j++, 'All', $have, $FUT_All);
foreach ($FUT_All as $cur) { imgF($cur); }
finish();

?>
