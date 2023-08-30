<?php
function acetoneImg($ID, $color)
{
	print('<img class="card-img" src="images/best_tracker/cards/'.idToName($ID).'.png" style="background-color: '.$color.'; border: 3px solid '.$color.';">');
}

function acetoneImgH($ID, $color)
{
	print('<img class="card-img" src="images/best_tracker/holo/'.idToHoloName($ID).'.png" style="background-color: '.$color.'; border: 3px solid '.$color.';">');
}
function foreignImg($ID, $color)
{
	print('<img class="card-img" src="images/best_tracker/foreign_holo_'.$ID.'.png" style="background-color: '.$color.'; border: 3px solid '.$color.';">');
}

$temp = array(array(31,'h', 'orange'),array(202,'h', 'red'),array(195,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Starlight Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(8083,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Starlight Holo (Evolutions)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(60,'h', 'orange'),array(80,'h', 'red'),array(93,'h', 'red'),array(99,'h', 'red'),array(437,'h', 'red'),array(426,'h', 'red'),array(430,'h', 'red'),array(127,'h', 'orange'),array(183,'h', 'red'),array(190,'h', 'red'),array(435,'h', 'red'),array(395,'h', 'red'),array(996,'h', 'red'),array(956,'h', 'red'),array(959,'h', 'red'),array(997,'h', 'red'),array(899,'h', 'red'),array(1190,'h', 'red'),array(2269,'h', 'red'),array(2840,'h', 'red'),array(2857,'h', 'red'),array(2961,'h', 'red'),array(3048,'h', 'red'),array(3051,'h', 'red'),array(4445,'h', 'red'),array(13973,'h', 'red'),array(4463,'h', 'red'),array(5144,'h', 'red'),array(5312,'h', 'red'),array(13747,'h', 'red'),array(2936,'u', 'red'),array(1,'u', 'red'),array(3,'u', 'red'),array(13,'u', 'red'),array(72,'u', 'red'),array(239,'u', 'red'),array(114,'u', 'red'),array(140,'u', 'red'),array(144,'u', 'red'),array(3851,'u', 'red'),array(253,'u', 'red'),array(321,'u', 'red'),array(344,'u', 'red'),array(358,'u', 'red'),array(360,'u', 'red'),array(2943,'u', 'red'),array(372,'u', 'red'),array(404,'u', 'red'),array(408,'u', 'red'),array(411,'u', 'red'),array(427,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Pixel Cosmos Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2707,'h', 'red'),array(2706,'h', 'red'),array(2708,'h', 'red'),array(6810,'h', 'red'),array(6816,'h', 'red'),array(8573,'h', 'orange'),array(8499,'h', 'red'),array(11127,'h', 'red'),array(10993,'h', 'red'),array(13542,'h', 'red'),array(3055,'u', 'red'),array(3052,'u', 'red'),array(1918,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Smooth Cosmos Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(309,'h', 'red'),array(248,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Fireworks Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(592,'h', 'red'),array(1307,'h', 'red'),array(1472,'h', 'red'),array(1491,'h', 'red'),array(1496,'h', 'red'),array(16,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (1)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2213,'h', 'red'),array(2221,'h', 'red'),array(2164,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (2)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2682,'h', 'red'),array(3865,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (3)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2920,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (4)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(10819,'h', 'orange'),array(11276,'h', 'red'),array(11285,'h', 'red'),array(11463,'h', 'orange'),array(11028,'h', 'red'),array(2595,'u', 'orange'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (5)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(13425,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Plain Holo (6)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1134,'h', 'red'),array(215,'u', 'red'),array(220,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Vertical Plain Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2397,'h', 'red'),array(2383,'h', 'red'),array(2349,'h', 'red'),array(2496,'h', 'red'),array(2505,'h', 'red'),array(2576,'h', 'red'),array(2529,'h', 'orange'),array(3856,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirror Holo (1)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2963,'h', 'red'),array(3310,'h', 'orange'),array(4233,'h', 'red'),array(4926,'h', 'red'),array(4881,'h', 'red'),array(6732,'h', 'red'),array(5356,'h', 'red'),array(7888,'h', 'red'),array(5419,'h', 'red'),array(6233,'h', 'red'),array(7438,'h', 'red'),array(7433,'h', 'red'),array(5770,'h', 'orange'),array(8098,'h', 'red'),array(8179,'h', 'red'),array(8149,'h', 'red'),array(8448,'h', 'red'),array(324,'u', 'red'),array(3625,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirror Holo (2)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(11219,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirror Holo (3)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(10973,'h', 'red'),array(11021,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirror Holo (4)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(901,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Pixel Wave Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1659,'h', 'orange'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Big Energy Holo*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1681,'h', 'red'),array(1834,'h', 'red'),array(1808,'h', 'red'),array(1817,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Energy Holo*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1948,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Prism Holo*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2013,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>2D Pokéball Holo*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2062,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>3D Pokéball Holo*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2942,'h', 'red'),array(2944,'h', 'red'),array(3032,'h', 'red'),array(2933,'h', 'red'),array(4450,'h', 'red'),array(5157,'h', 'red'),array(5244,'h', 'red'),array(8094,'h', 'red'),array(8471,'h', 'red'),array(10987,'h', 'red'),array(83,'u', 'red'),array(309,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Cracked Ice Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2971,'h', 'red'),array(2919,'h', 'red'),array(2949,'h', 'red'),array(4465,'h', 'red'),array(4436,'h', 'red'),array(4409,'h', 'red'),array(5133,'h', 'red'),array(5358,'h', 'red'),array(6664,'h', 'red'),array(5232,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Crosshatch Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(4952,'h', 'red'),array(5037,'h', 'red'),array(486,'u', 'red'),array(494,'u', 'red'),array(557,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Tinsel Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(6549,'h', 'red'),array(6548,'h', 'red'),array(6566,'h', 'red'),array(6561,'h', 'red'),array(5366,'h', 'red'),array(8092,'h', 'red'),array(2949,'u', 'red'),array(2951,'u', 'red'),array(2959,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Sheen Holo (1)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(8770,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Sheen Holo (2)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(8652,'h', 'red'),array(8771,'h', 'red'),array(8780,'h', 'red'),array(8975,'h', 'orange'),array(8459,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Sheen Holo (3)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(5336,'h', 'red'),array(8736,'h', 'red'),array(11273,'h', 'orange'),array(13971,'h', 'red'),array(2611,'u', 'orange'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Confetti Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(8386,'h', 'red'),array(13769,'h', 'red'),array(1072,'u', 'orange'),array(1233,'u', 'red'),array(1773,'u', 'red'),array(1775,'u', 'red'),array(1421,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Water Web Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(8478,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Sequin Holo (1)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(11137,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Sequin Holo (2)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(10786,'h', 'orange'),array(11076,'h', 'red'),array(11096,'h', 'red'),array(11051,'h', 'red'),array(13539,'h', 'red'),array(3921,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Line Holo</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(13536,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirage Holo (1)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(13965,'h', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Mirage Holo (2)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(583,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (BW Gold)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3062,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (SWSH Gold)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(11,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Shining Neo)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(430,'u', 'red'),array(468,'u', 'red'),array(545,'u', 'red'),array(879,'u', 'red'),array(552,'u', 'red'),array(925,'u', 'red'),array(626,'u', 'red'),array(684,'u', 'red'),array(932,'u', 'red'),array(566,'u', 'red'),array(543,'u', 'red'),array(941,'u', 'red'),array(436,'u', 'red'),array(602,'u', 'red'),array(989,'u', 'red'),array(1012,'u', 'red'),array(1063,'u', 'red'),array(940,'u', 'red'),array(522,'u', 'red'),array(723,'u', 'red'),array(1023,'u', 'red'),array(1055,'u', 'red'),array(709,'u', 'red'),array(935,'u', 'red'),array(917,'u', 'red'),array(791,'u', 'red'),array(671,'u', 'red'),array(672,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Mirror Holo (BWXY)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(585,'u', 'red'),array(3234,'u', 'red'),array(588,'u', 'red'),array(590,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Confetti Holo (Radiant BW)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3243,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Star Holo (Radiant BW)*</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(861,'u', 'red'),array(3255,'u', 'orange'),array(863,'u', 'red'),array(862,'u', 'red'),array(865,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo (Radiant XY)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(927,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (BREAK)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1864,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Shining SM)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1288,'u', 'red'),array(1106,'u', 'red'),array(1652,'u', 'red'),array(1107,'u', 'red'),array(1156,'u', 'red'),array(1098,'u', 'red'),array(1253,'u', 'red'),array(1522,'u', 'red'),array(1573,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo (SM, Confirmed: Factory Video)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1678,'u', 'red'),array(1716,'u', 'red'),array(1730,'u', 'red'),array(1419,'u', 'red'),array(3090,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Probably belong to above ^</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1128,'u', 'red'),array(1243,'u', 'red'),array(1498,'u', 'red'),array(1549,'u', 'red'),array(1779,'u', 'red'),array(1784,'u', 'red'),array(1792,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Sheen Holo (SM)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1230,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Special Mewtwo GX)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1805,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo (Character Art SM)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3054,'u', 'orange'),array(2493,'u', 'red'),array(2403,'u', 'red'),array(1961,'u', 'red'),array(2066,'u', 'red'),array(2721,'u', 'red'),array(3071,'u', 'red'),array(2314,'u', 'red'),array(2783,'u', 'red'),array(3635,'u', 'red'),array(3371,'u', 'red'),array(2328,'u', 'red'),array(3604,'u', 'red'),array(2836,'u', 'red'),array(3596,'u', 'red'),array(2888,'u', 'red'),array(3353,'u', 'red'),array(3394,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Sheen Holo (SWSH)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2133,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Amazing Rare)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2797,'u', 'orange'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Radiant)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3222,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo 1 (SWSH)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3009,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo 2 (SWSH)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2319,'u', 'red'),array(3087,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (VMAX Shiny & VMAX Special Art)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1992,'u', 'red'),array(2693,'u', 'red'),array(2487,'u', 'red'),array(2391,'u', 'red'),array(2585,'u', 'red'),array(1987,'u', 'red'),array(2868,'u', 'red'),array(2332,'u', 'red'),array(3611,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Gold SWSH)<br>Probably belong to above ^</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(2175,'u', 'red'),array(1981,'u', 'red'),array(2458,'u', 'red'),array(2210,'u', 'red'),array(2087,'u', 'red'),array(2745,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (Rainbow SWSH)<br>Probably belong to above ^</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3554,'u', 'red'),array(3571,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo 3 (SWSH)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3341,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Plain Holo 4 (SWSH)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3649,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Sheen Holo 1 (SV)**</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3646,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (SV Tera ex)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3696,'u', 'red'),array(3828,'u', 'red'),array(3686,'u', 'red'),array(3751,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Sheen Holo 2 (SV)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3900,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (SV Tera ex Full Art)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3817,'u', 'red'),array(3703,'u', 'red'),array(3912,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (SV Special Illustration Rare)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(3713,'u', 'red'),array(3918,'u', 'red'),array(3715,'u', 'red'),array(3711,'u', 'red'),array(3917,'u', 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Unknown Holo (SV Gold)</h1>');
foreach ($temp as $cur) { if ($cur[1] == 'u') {acetoneImg($cur[0], $cur[2]);} else {acetoneImgH($cur[0], $cur[2]);} }
print('</div>');

$temp = array(array(1, 'orange'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Foreign Starlight Holo</h1>');
foreach ($temp as $cur) { foreignImg($cur[0], $cur[1]); }
print('</div>');

$temp = array(array(2, 'red'));
print('<div id="container - '.$j++.'" class="center">');
print('<h1>Foreign Glitter Holo</h1>');
foreach ($temp as $cur) { foreignImg($cur[0], $cur[1]); }
print('</div>');

?>
