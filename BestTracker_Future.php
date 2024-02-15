<?php
$FUT_AR = array('AR1');
start($j++, 'Ancient Roar (JP)', $have, $FUT_AR);
foreach ($FUT_AR as $cur) { imgF($cur); }
finish();

$FUT_FF = array('FF1');
start($j++, 'Future Flash (JP)', $have, $FUT_FF);
foreach ($FUT_FF as $cur) { imgF($cur); }
finish();

$FUT_WF = array('WF1','WF2','WF3','WF4');
start($j++, 'Wild Force ex (JP)', $have, $FUT_WF);
foreach ($FUT_WF as $cur) { imgF($cur); }
finish();

$FUT_CJ = array('CJ1','CJ2','CJ3','CJ4');
start($j++, 'Cyber Judge ex (JP)', $have, $FUT_CJ);
foreach ($FUT_CJ as $cur) { imgF($cur); }
finish();

$FUT_SVPEN = array('SVPEN1','SVPEN2','SVPEN3');
start($j++, 'Scarlet & Violet Promo', $have, $FUT_SVPEN);
foreach ($FUT_SVPEN as $cur) { imgF($cur); }
finish();

$FUT_SVP = array('SVP1','SVP2','SVP3','SVP4','SVP5','SVP6');
start($j++, 'Scarlet & Violet Promo (JP)', $have, $FUT_SVP);
foreach ($FUT_SVP as $cur) { imgF($cur); }
finish();

$FUT_CH = array('CH1','CH2','CH3','CH4','CH5','CH6');
start($j++, 'Chinese Cards', $have, $FUT_CH);
foreach ($FUT_CH as $cur) { imgF($cur); }
finish();

$FUT_SVG = array('SVG1','SVG2','SVG3','SVG4','SVG5');
start($j++, 'Special Deck Set ex Venusaur & Charizard & Blastoise (JP)', $have, $FUT_SVG);
foreach ($FUT_SVG as $cur) { imgF($cur); }
finish();

$FUT_SVH = array('SVH1','SVH2','SVH3');
start($j++, 'Starter Deck & Build Sets (JP)', $have, $FUT_SVH);
foreach ($FUT_SVH as $cur) { imgF($cur); }
finish();

$FUT_All = array('AR1','FF1','WF1','WF2','WF3','WF4','CJ1','CJ2','CJ3','CJ4','SVPEN1','SVPEN2','SVPEN3','SVP1','SVP2','SVP3','SVP4','SVP5','SVP6','CH1','CH2','CH3','CH4','CH5','CH6','SVG1','SVG2','SVG3','SVG4','SVG5','SVH1','SVH2','SVH3');
start($j++, 'All', $have, $FUT_All);
foreach ($FUT_All as $cur) { imgF($cur); }
finish();

?>
