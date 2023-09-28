<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Date Tracker</title>
		<!-- Bootstrap CSS -->
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
		
		<!-- JavaScript voor Bootstrap4 -->
		<!-- jQuery first, then Popper.js, then Bootstrap JS -->
		<script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
		<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.3/umd/popper.min.js" integrity="sha384-ZMP7rVo3mIykV+2+9J3UJ46jBk0WLaUAdn689aCwoqbBJiSnjAK/l8WvCWPIPm49" crossorigin="anonymous"></script>
		<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/js/bootstrap.min.js" integrity="sha384-ChfqqxuZUCnJSK3+MXmPNIyE6ZbWh2IMqE241rYiqJxyMiZ6OW/JmZQ5stwEULTy" crossorigin="anonymous"></script>
		<style>
		.card-img {
			width: 100px;
			margin-left: 0px;
			margin-right: 0px;
			border: 3px solid red;
			background-color: red;
		}
		
		.card-have-img {
			width: 100px;
			margin-left: 0px;
			margin-right: 0px;
			border: 3px solid lime;
			background-color: lime;
		}
		
		.center {
			text-align: center;
			margin-left: 10px;
			margin-right: 10px;
		}
		
		img {
			height:150px;
			transition: transform .3s;
		}
		
		img:hover {
			-ms-transform: scale(2.25); /* IE 9 */
			-webkit-transform: scale(2.25); /* Safari 3-8 */
			transform: scale(2.75); 
		}
		</style>
	</head>
	<body>
<?php
function img($ID)
{
	print('<img class="card-img" src="images/cards/'.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID.'.png">');
}

function imgN($ID)
{
	print('<img class="card-have-img" src="images/cards/'.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID.'.png">');
}

function start($ID, $name, $arrC)
{
	print('<div id="container-'.$ID.'" class="center"><h1>'.$name.' ('.$arrC.')'.'</h1>');
}

function finish()
{
	print('</div>');
}

$have = array('AM',288,319,320,321,468,545,943,946,16,209,203,199,144,146,148,154,166,160,163,165,169,356,328,350,255,354,325,326,327,360,361,324,306,307,308,309,310,311,334,335,336,337,338,339,340,341,342,'0338_A',399,370,371,408,409,436,587,588,863,566,1185,1665,925,1033,554,645,776,883,590,1063,618,889,501,502,493,494,535,536,557,'RC2_1','RC2_4','RC2_14','RC2_18','RC2_19','RC2_20','RC2_21','RC2_22','RC2_23',610,658,626,1055,682,686,'0673_2',690,'0702_2',725,728,'0729_2',740,744,762,767,768,775,973,1423,1072,1844,1854,1075,1915,1113,1115,1855,1841,1169,1117,1119,1840,1156,2241,2314,1805,3003,1954,3032,1961,2315,2195,3070,3071,3072,3073,3074,3075,3076,3077,3078,3079,3080,3081,3052,3053,3054,3055,3056,3057,3058,3059,3060,3021,3061,3062,3063,'METAL_1','METAL_2',2487,2392,2336,2596,2598,2132,2401,2600,2404,2601,2408,2347,2139,2396,2597,2599,2123,2134,2595,2602,2604,2605,2606,2608,2611,2612,2613,2614,2615,2616,2620,2624,2626,2627);

$have2 = array(288,468,545,203,199,356,350,354,360,306,307,309,310,311,334,335,336,337,338,339,340,341,342,'0338_A',587,588,566,1185,925,1033,554,645,776,883,590,1063,618,889,501,502,493,494,535,536,557,'RC2_1','RC2_4','RC2_21','RC2_23',610,658,626,1055,682,725,728,744,762,767,768,775,973,1423,1072,1844,1854,1075,1113,1115,1841,1169,1117,1119,1840,1156);

$maart_12_2021 = array(1805,3003,1954,1961);
$maart_14_2021 = array(319,320,321,16);
$mei_4_2021 = array('AM',370,371);
$mei_13_2021 = array(408,409,399,326,160,436);
$mei_25_2021 = array(144,308);
$mei_28_2021 = array(324);
$juni_31_2021 = array(2241,2314,3032,2315,2195);
$juli_8_2021 = array(163,165);
$juli_10_2021 = array(943,946,169,255,'RC2_18','RC2_19',686,690,'0702_2',740);
$juli_17_2021 = array(146);
$juli_21_2021 = array(325,327,328,361,148,154,166);
$september_19_2021 = array(1855);
$september_26_2021 = array(209,863,1665,'RC2_14','RC2_20','RC2_22','0673_2','0729_2',1915);
$oktober_2021 = array(3070,3071,3072,3073,3074,3075,3076,3077,3078,3079,3080,3081,3052,3053,3054,3055,3056,3057,3058,3059,3060,3021,3061,3062,3063,'METAL_1','METAL_2',2487,2392,2336,2596,2598,2132,2401,2600,2404,2601,2408,2347,2139,2396,2597,2599,2123,2134,2595,2602);
//2595,2596,2597,2598,2599,2600,2601,2602,2603,2604,2605,2606,2607,2608,2609,2610,2611,2612,2613,2614,2615,2616,2617,2618,2619,2620,2621,2622,2623,2624,2625,2626,2627,2628

$j = 1;

start($j++, 'Collection Before Tracker', count($have2));
foreach ($have2 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Grookey Tin + 2x 3 Pack SWSH Base Blisters (12/3/2021)', count($maart_12_2021));
foreach ($maart_12_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (14/3/2021)', count($maart_14_2021));
foreach ($maart_14_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (4/5/2021)', count($mei_4_2021));
foreach ($mei_4_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (13/5/2021)', count($mei_13_2021));
foreach ($mei_13_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (25/5/2021)', count($mei_25_2021));
foreach ($mei_25_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (28/5/2021)', count($mei_28_2021));
foreach ($mei_28_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Shining Fates ETB (31/6/2021)', count($juni_31_2021));
foreach ($juni_31_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (8/7/2021)', count($juli_8_2021));
foreach ($juli_8_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Rommelmarkt De Haan (10/7/2021)', count($juli_10_2021));
foreach ($juli_10_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (17/7/2021)', count($juli_17_2021));
foreach ($juli_17_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Facebook Groepen (21/7/2021)', count($juli_21_2021));
foreach ($juli_21_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Geruild met Matteo tegen Dhelmise V (19/9/2021)', count($september_19_2021));
foreach ($september_19_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Rommelmarkt Ruddervoorde (26/9/2021)', count($september_26_2021));
foreach ($september_26_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

start($j++, 'Celebrations & V-Union (10/2021)', count($oktober_2021));
foreach ($oktober_2021 as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();
?>
	</body>
</html>