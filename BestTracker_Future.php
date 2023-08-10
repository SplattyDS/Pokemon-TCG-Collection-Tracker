<?php
$FUT_PC = array('PC1','PC2','PC3','PC4','PC5','PC6','PC7','PC8','PC9','PC10','PC11','PC12','PC13','PC14','PC15','PC16','PC17','PC18','PC19','PC20','PC21','PC22','PC23','PC24','PC25','PC26','PC27','PC28','PC29','PC30','PC31','PC32','PC33','PC34','PC35','PC36','PC37','PC38','PC39','PC40','PC41','PC42','PC43','PC44','PC45','PC46','PC47','PC48','PC49','PC50','PC51','PC52','PC53','PC54');
start($j++, 'Pokemon Card 151 (JP)', $have, $FUT_PC);
foreach ($FUT_PC as $cur) { imgF($cur); }
finish();

$FUT_BF = array('BF1','BF2','BF3','BF4','BF5','BF6','BF7','BF8','BF9','BF10','BF11','BF12','BF13','BF14','BF15','BF16','BF17','BF18','BF19','BF20','BF21','BF22','BF23','BF24','BF25','BF26','BF27','BF28','BF29','BF30','BF31','BF32','BF33','BF34','BF35','BF36','BF37','BF38','BF39','BF40','BF41');
start($j++, 'Ruler of the Black Flame (JP)', $have, $FUT_BF);
foreach ($FUT_BF as $cur) { imgF($cur); }
finish();

$FUT_SSP = array('SSP1','SSP2','SSP3');
start($j++, 'Sword & Shield Promo (JP)', $have, $FUT_SSP);
foreach ($FUT_SSP as $cur) { imgF($cur); }
finish();

$FUT_SVP = array('SVP1','SVP2','SVP3','SVP4','SVP5','SVP6');
start($j++, 'Scarlet & Violet Promo (JP)', $have, $FUT_SVP);
foreach ($FUT_SVP as $cur) { imgF($cur); }
finish();

$FUT_EXSS = array('EXSS1','EXSS2','EXSS3');
start($j++, 'ex Special Set (JP)', $have, $FUT_EXSS);
foreach ($FUT_EXSS as $cur) { imgF($cur); }
finish();

$FUT_EXSD = array('EXSD1','EXSD2','EXSD3','EXSD4','EXSD5','EXSD6','EXSD7','EXSD8','EXSD9','EXSD10');
start($j++, 'ex Starter Decks (JP)', $have, $FUT_EXSD);
foreach ($FUT_EXSD as $cur) { imgF($cur); }
finish();

$FUT_CLF = array('CLF1');
start($j++, 'Pokemon TCG Classic - Venusaur & Lugia ex Deck (JP)', $have, $FUT_CLF);
foreach ($FUT_CLF as $cur) { imgF($cur); }
finish();

$FUT_CLL = array('CLL1');
start($j++, 'Pokemon TCG Classic - Charizard & Ho-Oh ex Deck (JP)', $have, $FUT_CLL);
foreach ($FUT_CLL as $cur) { imgF($cur); }
finish();

$FUT_CLK = array('CLK1');
start($j++, 'Pokemon TCG Classic - Blastoise & Suicune ex Deck (JP)', $have, $FUT_CLK);
foreach ($FUT_CLK as $cur) { imgF($cur); }
finish();

$FUT_All = array('PC1','PC2','PC3','PC4','PC5','PC6','PC7','PC8','PC9','PC10','PC11','PC12','PC13','PC14','PC15','PC16','PC17','PC18','PC19','PC20','PC21','PC22','PC23','PC24','PC25','PC26','PC27','PC28','PC29','PC30','PC31','PC32','PC33','PC34','PC35','PC36','PC37','PC38','PC39','PC40','PC41','PC42','PC43','PC44','PC45','PC46','PC47','PC48','PC49','PC50','PC51','PC52','PC53','PC54','BF1','BF2','BF3','BF4','BF5','BF6','BF7','BF8','BF9','BF10','BF11','BF12','BF13','BF14','BF15','BF16','BF17','BF18','BF19','BF20','BF21','BF22','BF23','BF24','BF25','BF26','BF27','BF28','BF29','BF30','BF31','BF32','BF33','BF34','BF35','BF36','BF37','BF38','BF39','BF40','BF41','SSP1','SSP2','SSP3','SVP1','SVP2','SVP3','SVP4','SVP5','SVP6','EXSS1','EXSS2','EXSS3','EXSD1','EXSD2','EXSD3','EXSD4','EXSD5','EXSD6','EXSD7','EXSD8','EXSD9','EXSD10','CLF1','CLL1','CLK1');
start($j++, 'All', $have, $FUT_All);
foreach ($FUT_All as $cur) { imgF($cur); }
finish();

?>
