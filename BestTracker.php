<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Best Collection Tracker</title>
		<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.5/dist/umd/popper.min.js" integrity="sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js" integrity="sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy" crossorigin="anonymous"></script>
		<style>
		body {
			background-image: url('images/best_tracker/background/0.png');
			background-size: cover;
			background-attachment: fixed;
			background-repeat: no-repeat;
			transition: background-image 1s;
		}
		
		p, h1, h2, h3, h4, label {
			color: black;
			text-shadow: 1px 1px 5px white, 2px 2px 5px white, -1px -1px 5px white, -2px -2px 5px white, -1px 1px 5px white, -2px 2px 5px white, 1px -1px 5px white, 2px -2px 5px white;
		}
		
		a {
			color: white;
			text-shadow: 1px 1px 5px black, 2px 2px 5px black, -1px -1px 5px black, -2px -2px 5px black, -1px 1px 5px black, -2px 2px 5px black, 1px -1px 5px black, 2px -2px 5px black;
		}
		
		nav a {
			text-shadow: none;
		}
		
		.navbar {
			padding: 0.5rem 1rem;
		}
		
		.bg-dark {
			background-color: #343a40!important;
		}
		
		.center {
			text-align: center;
			margin-left: 10px;
			margin-right: 10px;
		}
		
		.hidden {
			display: none;
		}
		
		.progress {
			margin-bottom: 10px;
		}
		
		img {
			height:180px;
			transition: transform .3s;
		}
		
		img:hover {
			-ms-transform: scale(2); /* IE 9 */
			-webkit-transform: scale(2); /* Safari 3-8 */
			transform: scale(2.25);
		}
		
		.card-img {
			width: 120px;
			margin: 2px;
			border: 3px solid red;
			background-color: red;
		}
		
		.card-have-img {
			width: 120px;
			margin: 2px;
			border: 3px solid lime;
			background-color: lime;
		}
		
		.card-fut-img {
			width: 120px;
			margin: 2px;
			border: 3px solid purple;
			background-color: purple;
		}
		
		.page img {
			height: 150px;
			border: 3px solid black;
			background-color: black;
		}
		
		.page img.no-style {
			transform: none;
		}
		
		.page img.no-style:hover {
			transform: none;
		}
		
		.page img.not-have {
			border: 3px solid red;
			background-color: red;
		}
		
		.page img.have {
			border: 3px solid lime;
			background-color: lime;
		}
		
		table.page {
			background-color: black;
			display: table;
			border-collapse: separate;
			box-sizing: border-box;
			text-indent: initial;
			border-spacing: 1px;
			border-color: grey;
			min-width: 530px;
			min-height: 530px;
		}
		
		.page td {
			padding-left: 10px;
			padding-right: 10px;
			margin: 0px;
		}
		</style>
		
		<script>
		function toggleSection(element, id)
		{
			console.log(1);
			let container = document.getElementById("container-" + id);
			
			if (container.classList.contains("hidden"))
			{
				container.classList.remove("hidden");
				
				var images = document.querySelectorAll("#container-" + id + " img");
				
				for(var i = 0; i < images.length; i++)
					images[i].src = images[i].getAttribute('data-src');
			}
			else
			{
				container.classList.add("hidden");
			}
		}
		
		const NUM_BACKGROUNDS = 18;
		
		let currentIndex = 0;
		let intervalId;
		
		function setBackgroundImage(index)
		{
			document.body.style.backgroundImage = `url(images/best_tracker/background/${index}.png)`;
			currentIndex = index;
		}
		
		function nextImage()
		{
			let nextIndex = currentIndex + 1;
			
			if (nextIndex === NUM_BACKGROUNDS)
				nextIndex = 0;
			
			setBackgroundImage(nextIndex);
		}
		
		function previousImage()
		{
			let previousIndex = currentIndex - 1;
			
			if (previousIndex < 0)
				previousIndex = NUM_BACKGROUNDS - 1;
			
			setBackgroundImage(previousIndex);
		}
		
		let canChange = true;
		
		document.addEventListener('keydown', (event) =>
		{
			if (!canChange)
				return;
			
			if (event.code === 'ArrowLeft')
				previousImage();
			else if (event.code === 'ArrowRight')
				nextImage();
			
			canChange = false;
			
			setTimeout(() =>
			{
				canChange = true;
			}, 1000);
		});
		
		function toggleAutomaticBackground()
		{
			if (document.getElementById('background-checkbox').checked)
			{
				intervalId = setInterval(nextImage, 30000);
			}
			else
			{
				clearInterval(intervalId);
				intervalId = null;
			}
		}
		
		function initAutomaticBackground()
		{
			// preloads the images to avoid white flashes
			for (let i = 0; i < NUM_BACKGROUNDS; i++)
				setBackgroundImage(i);
			
			setBackgroundImage(0);
		}
		</script>
	</head>
	<body onload="initAutomaticBackground()">
		
		<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
			<a class="navbar-brand" href="BestTracker.php">Best Collection Tracker</a>
			
			<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation"> <span class="navbar-toggler-icon"></span></button>
			
			<div class="collapse navbar-collapse" id="navbarNavDropdown">
				<ul class="navbar-nav mr-auto">
					<li class="nav-item"><a class="nav-link" href="BestTracker.php">Main</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?set">Set</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?col">Collection</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?binder">Binder</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?type">Type</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?dex">Dex</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?all">All</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?fut">Future</a></li>
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?test">Test</a></li>
				</ul>
			</div>
		</nav>
		
		<label for="background-checkbox">Enable automatic background</label>
		<input type="checkbox" id="background-checkbox" onclick="toggleAutomaticBackground()">
		
<?php
function img($ID)
{
	if (isset($_GET['noimg']))
		return;
	
	if ($ID == -1)
		print('<img class="card-img" data-src="images/best_tracker/cards/-1.png">');
	else if (is_numeric($ID))
		print('<img class="card-img" data-src="images/best_tracker/cards/'.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID.'.png">');
}

function imgN($ID)
{
	if (isset($_GET['noimg']))
		return;
	
	if ($ID == -1)
		print('<img class="card-img" data-src="images/best_tracker/cards/-1.png">');
	else if (is_numeric($ID))
		print('<img class="card-have-img" data-src="images/best_tracker/cards/'.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID.'.png">');
}

function imgF($ID)
{
	if (isset($_GET['noimg']))
		return;
	
	print('<img class="card-fut-img" data-src="images/best_tracker/FUT/'.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID.'.png">');
}

function start($ID, $name, $have, $arrC)
{
	$amount = countN($arrC);
	$haveAmount = countHave($arrC, $have);
	if ($amount != 0)
		$percent = round($haveAmount / $amount * 100, 2);
	else
		$percent = 0;
	
	if ($percent == 100)
		$barClass = 'success';
	else if ($percent >= 50)
		$barClass = 'info';
	else if ($percent >= 25)
		$barClass = 'warning';
	else
		$barClass = 'danger';
	
	// progress-bar-animated
	
	print('<div id="header-'.$ID.'" class="center" onclick="toggleSection(this, '.$ID.')">');
	
	print('<h1>'.$name.'</h1>');
	print('<h2>'.$haveAmount.'/'.$amount.' ('.$percent.'%)</h2>');
	
	print('
	<div class="progress">
		<div class="progress-bar bg-'.$barClass.' progress-bar-striped" role="progressbar" aria-valuenow="'.$percent.'" aria-valuemin="0" aria-valuemax="100" style="width:'.$percent.'%">
			'.$percent.'%
		</div>
	</div>
	');
	
	print('</div><div id="container-'.$ID.'" class="center hidden">');
}

function finish()
{
	print('</div>');
}

function countN($array)
{
	$i = 0;
	foreach ($array as $item) { if ($item != '0') { $i++; } }
	return $i;
}

function countHave($arr, $have)
{
	$i = 0;
	
	foreach ($arr as $cur_arr)
	{
		if (in_array($cur_arr, $have, true))
			$i++;
	}
	
	return $i;
}

// $have = array(288,319,320,321,468,545,943,944,945,946,947,'AM',16,3061,3016,209,215,203,199,356,'JP18',328,350,255,354,3055,325,360,326,361,327,399,3052,370,371,408,409,493,494,495,535,536,557,925,1026,1033,693,645,776,743,883,610,658,626,922,927,928,682,686,'0673_2',690,'0702_2',725,728,'0729_2',740,'0740_2',744,762,767,768,775,973,1423,1072,1160,1844,1854,1075,1915,1113,1115,1078,1855,1841,1169,1080,1662,1119,1081,1840,1773,1421,1496,3111,3092,3003,2698,3053,2336,2702,3045,3094,2000,3060,3096,2596,2598,2132,2644,3108,2401,2910,3099,3100,3054,2600,2404,1954,2912,2601,2407,3101,2408,3046,3083,2714,2139,3007,3008,2717,2718,2518,2144,2720,3125,3015,2493,3021,2597,2599,2513,2136,2517,2914,3032,1961,3093,2700,3095,2911,2710,3103,2807,3123,2721,2123,2186,2134,2137,2195,2143,2906,2908,2805,3116,3071,3072,3073,3074,3056,3057,3058,3059,3104,3105,3106,3107,3075,3076,3077,3078,3079,3080,3081,3082,436,587,588,2595,1805,1816,2760,2762,2880,2763,2764,2766,2768,590,1063,618,889,501,502,1055,2523,2111,3115,3102,2920,3122,2315,2086,2167,2927,3062,3063,2786,2603,2487,1156,2392,2935,3084,3086,3088,2836,3085,3087,3089,144,146,148,154,160,163,165,166,169,306,307,308,309,310,311,324,334,335,336,337,338,339,340,341,342,'0338_A','RC2_1','RC2_4','RC2_14','RC2_17','RC2_18','RC2_19','RC2_20','RC2_21','RC2_22','RC2_23',1675,1678,2241,2314,2604,2605,2606,2607,2608,2609,2610,2611,2612,2613,2614,2615,2616,2617,2618,2619,2620,2621,2622,2623,2624,2625,2626,2627,2628,'METAL_1','METAL_2',355,347,282,404,1547,1603,1943,2347);

$j = 1;

require 'BestTracker_Have.php';
require 'BestTracker_Cards.php';

if (isset($_GET['test']))
{
	// $have = array();
	
	$test = array(3399,3408,3513,3526,3527,3275,3282,3315,3396);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(727,1914,1660,1665,2051,2788,3406,2492,2795,2504,3415,2511,2512,3420,3421,2516,3023,2067,3070,2413,3289,2817,2015,2071,2796,3418,3407,2793,3422,1684,1697,1702,1705,2325);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(2815,2905);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(3390,2715,2069,3414,3281,3542,2882,3483,3645,3648,3648,3641,3652,3653,3654,3655,3656,3646,3647);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(1852,1694,1695,1701,2124,3409,3512,3270,3274,3424,2196,2414,3536,3515,3416,3280,2189,3509,3717,3531,3554,2764,3345);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(3730,3649,3725,3735);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	$test = array(3732,3734);
	start($j++, 'Test', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
	finish();
	
	return;
}

// $have = array_merge($have, array(3390,2715,2069,3414,3281,3542,2882,3483,3645,3648,3641,3652,3653,3654,3655,3656,3646,3647));
// $have = array_merge($have, array(1852,1694,1695,1701,2124,3409,3512,3270,3274,3424,2196,2414,3536,3515,3416,3280,2189,3509,3717,3531,3554,3345));

if (isset($_GET['set']))
{
	require 'BestTracker_Sets.php';
	return;
}

if (isset($_GET['type']))
{
	require 'BestTracker_Types.php';
	return;
}

if (isset($_GET['dex']))
{
	require 'BestTracker_Pokedex.php';
	return;
}

if (isset($_GET['fut']))
{
	require 'BestTracker_Future.php';
	return;
}

if (isset($_GET['all']))
{
	require 'BestTracker_All.php';
	return;
}

if (isset($_GET['col']))
{
	start($j++, 'Collection', $have, $have);
	foreach ($have as $cur) { imgN($cur); }
	finish();
	
	return;
}

if (isset($_GET['binder']))
{
	require 'BestTracker_Binder.php';
	return;
}

if (isset($_GET['percent']))
{
	require 'BestTracker_Percent.php';
	return;
}

require 'BestTracker_Sections.php';
?>
	</body>
</html>