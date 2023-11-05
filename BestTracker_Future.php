<?php
$FUT_AR = array('AR1','AR2');
start($j++, 'Ancient Roar (JP)', $have, $FUT_AR);
foreach ($FUT_AR as $cur) { imgF($cur); }
finish();

$FUT_FF = array('FF1','FF2');
start($j++, 'Future Flash (JP)', $have, $FUT_FF);
foreach ($FUT_FF as $cur) { imgF($cur); }
finish();

$FUT_ST = array('ST1','ST2','ST3','ST4','ST5','ST6','ST7','ST8','ST9','ST10','ST11','ST12','ST13','ST14','ST15','ST16','ST17');
start($j++, 'Shiny Treasure ex (JP)', $have, $FUT_ST);
foreach ($FUT_ST as $cur) { imgF($cur); }
finish();

$FUT_SVPEN = array('SVPEN1','SVPEN2');
start($j++, 'Scarlet & Violet Promo', $have, $FUT_SVPEN);
foreach ($FUT_SVPEN as $cur) { imgF($cur); }
finish();

$FUT_SVP = array('SVP1','SVP2','SVP3','SVP4','SVP5','SVP6');
start($j++, 'Scarlet & Violet Promo (JP)', $have, $FUT_SVP);
foreach ($FUT_SVP as $cur) { imgF($cur); }
finish();

$FUT_CH = array('CH1','CH2','CH3','CH4');
start($j++, 'Chinese Cards', $have, $FUT_CH);
foreach ($FUT_CH as $cur) { imgF($cur); }
finish();

$FUT_SVG = array('SVG1','SVG2','SVG3','SVG4','SVG5');
start($j++, 'Special Deck Set ex Venusaur & Charizard & Blastoise (JP)', $have, $FUT_SVG);
foreach ($FUT_SVG as $cur) { imgF($cur); }
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

$FUT_All = array('AR1','AR2','FF1','FF2','ST1','ST2','ST3','ST4','ST5','ST6','ST7','ST8','ST9','ST10','ST11','ST12','ST13','ST14','ST15','ST16','ST17','SVPEN1','SVPEN2','SVP1','SVP2','SVP3','SVP4','SVP5','SVP6','CH1','CH2','CH3','CH4','SVG1','SVG2','SVG3','SVG4','SVG5','CLV1','CLC1','CLB1');
start($j++, 'All', $have, $FUT_All);
foreach ($FUT_All as $cur) { imgF($cur); }
finish();

?>
