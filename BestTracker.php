<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Best Collection Tracker</title>
		<link rel="icon" href="images/best_tracker/icon.png" type="image/png">
		
		<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
		
		<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.min.js" integrity="sha384-fbbOQedDUMZZ5KreZpsbe1LCZPVmfTnH7ois6mU1QK+m14rQ1l2bGBq41eYeM/fS" crossorigin="anonymous"></script>
		
		<!--<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor" crossorigin="anonymous">
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.bundle.min.js" integrity="sha384-pprn3073KE6tl6bjs2QrFaJGz5/SUsLqktiwsUTF55Jfv3qYSDhgCecCxMW52nD2" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.5/dist/umd/popper.min.js" integrity="sha384-Xe+8cL9oJa6tN/veChSP7q+mnSPaj5Bcu9mPX5F5xIGE0DVittaqT5lorf0EI7Vk" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/js/bootstrap.min.js" integrity="sha384-kjU+l4N0Yf4ZOJErLsIcvOU2qSb74wXpOhqTvwVx3OElZRweTnQ6d31fXEoRD1Jy" crossorigin="anonymous"></script>-->
		
		<style>
		body {
			/* background-image: url('images/best_tracker/background/0.png'); */
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
			/* text-shadow: 1px 1px 5px black, 2px 2px 5px black, -1px -1px 5px black, -2px -2px 5px black, -1px 1px 5px black, -2px 2px 5px black, 1px -1px 5px black, 2px -2px 5px black; */
		}
		
		nav a {
			/* text-shadow: none; */
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
		
		table.infoTable {
			font-family: arial, sans-serif;
			border-collapse: collapse;
			width: 90%;
			margin-left: 5%;
			margin-bottom: 20px;
		}
					
		table.infoTable tr td, table.infoTable tr th {
			border: 1px solid #dddddd;
			text-align: left;
			padding: 8px;
		}
		
		table.infoTable tr {
			background-color: #ffffff;
		}
		
		table.infoTable tr:nth-child(even) {
			background-color: #dddddd;
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
		
		const NUM_BACKGROUNDS = 31;
		
		let currentIndex = 30;
		let intervalId;
		
		function setBackgroundImage(index)
		{
			console.log(index);
			document.body.style.backgroundImage = `url(images/best_tracker/background/${index}.png)`;
			currentIndex = index;
			
			setCookie("background", index, 365);
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
		
		function initBackground()
		{
			// preloads the images to avoid white flashes
			for (let i = 0; i < NUM_BACKGROUNDS; i++)
				preloadImage(i);
			
			let backgroundCookie = getCookie("background");
			
			if (backgroundCookie != -1)
				currentIndex = backgroundCookie;
			
			console.log("currentIndex:", currentIndex);
			
			setBackgroundImage(currentIndex);
		}
		
		function preloadImage(index)
		{
			let img = new Image();
			img.src = "images/best_tracker/background/" + index + ".png";
		}
		
		// Function to set a cookie
		function setCookie(name, value, days)
		{
			console.log("set cookie:", name, "=", value);
			
			let expires = "";
			
			if (days)
			{
				let date = new Date();
				date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
				expires = "; expires=" + date.toUTCString();
			}
			
			document.cookie = name + "=" + value + expires + "; path=/";
		}
		
		// Function to get the value of a cookie
		function getCookie(name)
		{
			let nameEQ = name + "=";
			let cookies = document.cookie.split(';');
			
			console.log("get cookie:", name);
			
			for (let i = 0; i < cookies.length; i++)
			{
				let cookie = cookies[i];
				
				while (cookie.charAt(0) == ' ')
					cookie = cookie.substring(1, cookie.length);
				
				if (cookie.indexOf(nameEQ) == 0)
					return parseInt(cookie.substring(nameEQ.length, cookie.length));
			}
			
			return -1;
		}
		</script>
	</head>
	<body onload="initBackground()" style="background-position: top center;">
		
		<nav class="navbar navbar-expand-lg navbar-dark bg-dark">
			<a class="navbar-brand" href="index.php">Best Collection Tracker</a>
			
			<button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarNavDropdown" aria-controls="navbarNavDropdown" aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>
			
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
					
					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
							Holo
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
							<li><a class="dropdown-item" href="BestTracker.php?holo">Main</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&set">Set</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&setrev">Set (Reverse)</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&col">Collection</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&binder">Binder</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&type">Type</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&dex">Dex</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&all">All</a></li>
							<!--<li><a class="dropdown-item" href="BestTracker.php?holo&fut">Future</a></li>-->
							<!--<li><a class="dropdown-item" href="BestTracker.php?holo&test">Test</a></li>-->
						</ul>
					</li>
					
					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
							Worlds
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdown">
							<li><a class="dropdown-item" href="BestTracker.php?worlds">Main</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?worlds&set">Set</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?worlds&year">Year</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?worlds&col">Collection</a></li>
							<!--<li><a class="dropdown-item" href="BestTracker.php?worlds&binder">Binder</a></li>-->
							<li><a class="dropdown-item" href="BestTracker.php?worlds&type">Type</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?worlds&dex">Dex</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?worlds&all">All</a></li>
							<!--<li><a class="dropdown-item" href="BestTracker.php?worlds&fut">Future</a></li>-->
							<!--<li><a class="dropdown-item" href="BestTracker.php?worlds&test">Test</a></li>-->
						</ul>
					</li>
					
					<!--<li class="nav-item"><a class="nav-link" href="BestTracker.php?test">Test</a></li>-->
				</ul>
			</div>
		</nav>
		
		<label for="background-checkbox">Enable automatic background</label>
		<input type="checkbox" id="background-checkbox" onclick="toggleAutomaticBackground()">
		<br>
		<button onclick="previousImage()">Previous</button>
		<button onclick="nextImage()">Next</button>
		
<?php
function cardImg($class, $path, $visible = false)
{
	if (isset($_GET['noimg']))
		return;
	
	$tag = $visible ? 'src' : 'data-src';
	
	print('<img class="'.$class.'" '.$tag.'="'.$path.'">');
}

function idToName($ID)
{
	return ''.(is_numeric($ID) ? str_repeat("0", 4 - strlen($ID)) : '').$ID;
}

function idToHoloName($ID)
{
	return ''.(is_numeric($ID) ? str_repeat("0", 5 - strlen($ID)) : '').$ID;
}

function img($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/cards/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-img', 'images/best_tracker/cards/'.idToName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/cards/'.$ID.'.png', $visible);
}

function imgN($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/cards/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-have-img', 'images/best_tracker/cards/'.idToName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/cards/'.$ID.'.png', $visible);
}

function imgF($ID, $visible = false)
{
	cardImg('card-fut-img', 'images/best_tracker/FUT/'.idToName($ID).'.png', $visible);
}

function imgH($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/holo/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-img', 'images/best_tracker/holo/'.idToHoloName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/holo/'.$ID.'.png', $visible);
}

function imgHN($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/holo/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-have-img', 'images/best_tracker/holo/'.idToHoloName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/holo/'.$ID.'.png', $visible);
}

function imgW($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/worlds/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-img', 'images/best_tracker/worlds/'.idToName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/worlds/'.$ID.'.png', $visible);
}

function imgWN($ID, $visible = false)
{
	if ($ID == -1)
		cardImg('card-img', 'images/best_tracker/worlds/-1.png', $visible);
	else if (is_numeric($ID))
		cardImg('card-have-img', 'images/best_tracker/worlds/'.idToName($ID).'.png', $visible);
	// else
		// cardImg('card-img', 'images/best_tracker/worlds/'.$ID.'.png', $visible);
}

function imgER($name, $visible = false)
{
	if ($name == '<br>')
	{
		print($name);
		return;
	}
	
	cardImg('card-img', 'images/best_tracker/extremely_rare/'.$name.'.png', $visible);
}

function start($ID, $name, $have, $arrC, $visible = false)
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
	
	$onclick = $visible ? '' : 'onclick="toggleSection(this, '.$ID.')"';
	
	print('<div id="header-'.$ID.'" class="center" '.$onclick.'>');
	
	print('<h1>'.$name.'</h1>');
	print('<h2>'.$haveAmount.'/'.$amount.' ('.$percent.'%)</h2>');
	
	print('
	<div class="progress">
		<div class="progress-bar bg-'.$barClass.' progress-bar-striped" role="progressbar" aria-valuenow="'.$percent.'" aria-valuemin="0" aria-valuemax="100" style="width:'.$percent.'%">
			'.$percent.'%
		</div>
	</div>
	');
	
	$class = $visible ? 'center' : 'center hidden';
	
	print('</div><div id="container-'.$ID.'" class="'.$class.'">');
}

function finish()
{
	print('</div>');
}

// function startTable($id)
// {
	// print('<div id="header-'.$ID.'" class="center" onclick="toggleSection(this, '.$ID.')">
	// <h1>'.$name.'</h1>
	// <h2>'.$haveAmount.'/'.$amount.' ('.$percent.'%)</h2>
	// </div>');
	
	// print('<div id="container-'.$id.'" class="hidden"><table class="infoTable">
	// <tr>
	// <th>Name</th>
	// <th>Image</th>
	// <th>Type</th>
	// <th>Set<br>+ Number</th>
	// <th>Price</th>
	// </tr>');
// }

// function printRow($id, $name, $type, $set, $setno, $price)
// {
	// print('<tr>
	// <td>'.$name.'</td>
	// <td>'.'</td>
	// <td>'.$type.'</td>
	// <td>'.$set.'<br>'.$setno.'</td>
	// <td>€'.$price.'</td>
	// </tr>');
// }

function finishTable()
{
	print('</table></div>');
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

if (isset($_GET['holo']))
{
	require 'BestTracker_HoloHave.php';
	require 'BestTracker_HoloCards.php';
}
else if (isset($_GET['worlds']))
{
	require 'BestTracker_WorldsHave.php';
	require 'BestTracker_WorldsCards.php';
}
else
{
	require 'BestTracker_Have.php';
	require 'BestTracker_Cards.php';
}

// $have = array_merge($have, array(3390,2715,2069,3414,3281,3542,2882,3483,3645,3648,3641,3652,3653,3654,3655,3656,3646,3647));
// $have = array_merge($have, array(1852,1694,1695,1701,2124,3409,3512,3270,3274,3424,2196,2414,3536,3515,3416,3280,2189,3509,3717,3531,3554,3345));

if (isset($_GET['holo']))
{
	if (isset($_GET['test']))
	{
		$test = array(29,39,43,7,3,23,40,77,2707,147,433,424,592,1082,1205,1206,2706,1114,1138,1139,1134,1126,1123,1472,1611,1817,2255,2322,2300,2408,2430,2496,2500,2520,2596,2588,2569,2613,2601,2698,2704,2703,2732,2979,2927,2784,2863,2762,3015,2719,2901,2782,3040,2770,2758,2804,2710,2792,2926,2776,3008,2841,2742,2777,2994,2708,2731,2810,2778,2821,2917,2761,3019,3020,2803,3002,3037,4125,2921,2886,3529,3310,4926,4437,3032,4332,4345,4363,4432,5071,5072,4952,5166,5058,5035,5084,4968,5331,4957,5330,5066,5067,5036,5059,5037,5040,6736,5871,6357,5543,7680,8097);
		start($j++, 'Lost', $holoHave, $test);
		foreach ($test as $cur) { if (in_array($cur, $holoHave, true)) {/*imgHN($cur);*/} else {imgH($cur);} }
		finish();
		
		$test = array(11197,11230,11246,11251,11262,11263,10806,10840,10843,11270,11270,11271,11271,11275,13338);
		$test = array_merge($test, array(11473,12099,12179,12139,12146,12158,12190,12231,12358,12376,12289,12307,12326,12357,12410,12578,12749,12797,12854,12755,12880,13449));
		start($j++, 'Purchase 31/8/2023', $holoHave, $test);
		print('<img class="card-img" data-src="images/best_tracker/foreign_holo_2.png" style="background-color: red; border: 3px solid red;">');
		foreach ($test as $cur) { if (in_array($cur, $holoHave, true)) {imgHN($cur);} else {imgH($cur);} }
		finish();
		
		$test = array(43,162,202,414,1062,2719,4443,4952,8083,8282,10736,13536);
		start($j++, 'Eras', $holoHave, $test);
		foreach ($test as $cur) { imgHN($cur); }
		finish();
		
		$test = array(43,79,439,426,155,424,195,296,339,592,1199,899,1190,1139,902,1472,1580,1695,1817,1944,2019,2062,2213,2322,2396,2500,2588,2682,2719,2962,3048,3047,3038,2969,2974,3772,3032,2954,2882,4330,4464,4432,4921,4470,4439,4881,4411,4952,5037,6546,6548,6566,6561,6782,5317,6733,6649,5236,11257,5130,5357,5362,5374,7887,5419,6233,7416,7414,5770,5207,5232,8083,8091,8098,8094,8099,8174,8168,8199,8573,8448,8471,8736,8770,8652,8480,8777,8788,8823,8499,8459,10786,10819,11127,11219,10979,11273,11118,11281,11288,11078,11103,11463,10957,10973,11021,11028,11052,13337,13542,13539,13656);
		start($j++, '1 of each type', $holoHave, $test);
		foreach ($test as $cur) { if (in_array($cur, $holoHave, true)) {imgHN($cur);} else {imgH($cur);} }
		finish();
		
		$test = array(1,72,321,468,2936,434,588,863,985,1918,2595,3222,3009,3828,583,3063,672,3,6,15,16,235,83,215,111,220,144,345,324,309,342,404,368,411,622,2958,585,610,2957,494,927,2966,968,975,3843,3243,3228,3263,566,941,1063,565,590,862,865,723,1055,1068,791,637,1072,1233,1773,1775,1215,1405,1683,1185,1440,1244,1500,1549,1716,1730,1779,1230,1784,1792,1805,1151,1837,1107,1156,1310,3091,1574,1464,1520,1573,3054,2493,2399,2704,2066,2721,3071,2133,3116,2211,2615,2602,3630,1964,2328,2329,3604,3573,2737,3087,3578,2876,3486,3351,3394,2935,2693,2487,2392,2603,1987,3470,3365,3611,2173,2374,2458,2927,2087,3455,3645,3646,3696,3691,3683,3817,3657,3807,3714,3715,3820);
		start($j++, '1 of each type (ultra rare)', array(), $test);
		foreach ($test as $cur) { if ($cur == '<br>') { print('<br>'); } else if (in_array($cur, array(), true)) {imgN($cur);} else {img($cur);} }
		finish();
		
		
		
		$test = array(
		43,195, // star
		'<br>',
		8083, // EV star
		'<br>',
		79,439,426,155,424,339,1199,899,1190,2322,2719,2962,3048,3047,4330,4464,6782,5317, // cosmos (pixel)
		'<br>',
		8091,8573,8499,11127,10957,13542, // cosmos (smooth)
		'<br>',
		296, // lc reverse
		'<br>',
		592,1472,2882, // plain reverse
		'<br>',
		2213,2682, // plain
		'<br>',
		10819,11281,11288,11028,11463, // SWSH plain reverse
		'<br>',
		13656, // rocky energy reverse
		'<br>',
		1139, // mirror
		'<br>',
		2396,2500,2588, // mirror
		'<br>',
		2969,3772,4921,4881,6733,7887,5419,6233,7416,7414,11219,5357,8098,8174,8168,8448,10973,11021, // mirror
		'<br>',
		5770, // energy reverse
		'<br>',
		902, // pixel wave
		'<br>',
		1580, // big energy
		'<br>',
		1695,1817, // small energy
		'<br>',
		1944, // prism
		'<br>',
		2019, // 2D pokeball
		'<br>',
		2062, // 3D pokeball
		'<br>',
		3038,3032,4432,6649,5236,8094,8471,10979, // cracked ice
		'<br>',
		2974,2954,4470,4439,4411,5130,5362,5207,5232, // crosshatch
		'<br>',
		4952,5037, // tinsel
		'<br>',
		6546,6548,6566,6561,5374,8099,8770, // sheen
		'<br>',
		8652,8777,8788,8823,8459, // sheen (mirrored)
		'<br>',
		11257,8736,11273, // confetti
		'<br>',
		8199, // water web
		'<br>',
		8480,11118, // sequin
		'<br>',
		10786,11078,11103,11052,13539, // lines
		'<br>',
		13337, // mirage
		);
		start($j++, '1 of each type for acetone', array(), $test);
		foreach ($test as $cur) { if ($cur == '<br>') { print('<br>'); } else if (in_array($cur, array(), true)) {imgHN($cur);} else {imgH($cur);} }
		finish();
		
		
		
		// victini is mirror - textured
		// emolga is confetti(?)
		// pikachu is plain (RC)
		// reshiram is mirror
		// armored mewtwo is cosmos (smooth)
		// pikachu is plain (CEL)
		// pikachu is plain (CZ)
		// pikachu is plain (SWSH P)
		// pikachu is mirrored sheen (SV P)
		// reshiram is gold(?) - textured
		// poke ball is gold(?) - textured
		// charizard EX is mirror
		// charizard EX is sheen
		// flareon EX is plain(?) - same for sylveon EX and shaymin EX
		// meloetta EX is same as emolga
		// elesa is star
		// growlithe is same as emolga (with plain?)
		// diancie is plain (RC)
		// iris is mirror - textured
		// brock's grit is mirror - textured
		// zygarde EX is mirror - textured
		// palkia EX is mirror - textured
		// meloetta EX is same as emolga - same for shaymin EX and mew EX
		// flareon EX is same as flareon EX - same for sylveon EX and gardevoir EX
		// M gardevoir EX is same as flareon EX
		// team aqua's kyogre EX is mirror
		// M lucario EX is mirror - textured
		// yveltal EX is mirror - textured
		// M rayquaza EX is mirror - textured
		// M charizard EX is mirror
		// decidueye GX is water web
		// nihilego GX is same as decidueye GX
		// arceus & dialga & palkia GX is same as decidueye GX
		// naganadel & guzzlord GX is same as decidueye GX
		// shining volcanion is ???
		// lance prism star is water web
		// shuppet is ???
		// acerola is plain - textured
		// shuckle GX is sheen(?) - textured
		// kartana GX is same as shuckle GX
		// pikachu & zekrom GX is same as shuckle GX
		// pheromosa & buzzwhole GX is same as shuckle GX
		// charizard GX is ???
		// naganadel GX is same as charizard GX
		// vileplume GX is sheen(?) - textured
		// mewtwo GX is same as shining volcanion(?)
		// solgaleo & lunala GX is sheen(?) - textured
		// naganadel & guzzlord GX is same as solgaleo & lunala GX
		// torkoal is plain
		// aqua patch is ??? - textured
		// power plant is same as aqua patch
		// psychic energy is same as aqua patch
		// double colorless energy is same as aqua patch
		// solgaleo GX is ??? - textured
		// pikachu & zekrom GX is same as solgaleo GX
		// venomoth GX is ??? - textured
		// blacephalon GX is same as venomoth GX
		// celebi & venusaur GX is same as venomoth GX
		// pheromosa & buzzwhole GX is same as venomoth GX
		// dark sylveon V is (mirrored) sheen(?)
		// trevenant VMAX is same as dark sylveon V - textured
		// ice rider calyrex VMAX is same as dark sylveon V - textured
		// kingler VMAX is same as dark sylveon V - textured
		// eternatus VMAX is same as dark sylveon V - textured
		// arceus VSTAR is same as dark sylveon V - textured
		// greninja V-Union is same as dark sylveon V
		// raikou is ??? - textured
		// radiant eevee is radiant - textured
		// rowlet is (mirrored) sheen(?) - textured
		// rocket's admin is confetti(?) - textured
		// professor's research is (mirrored) sheen(?) - textured
		// grass energy is (mirrored) sheen(?) - textured
		// torkoal V is (mirrored) sheen(?) - textured
		// ditto V is (mirrored) sheen(?) - textured
		// ditto VMAX is ???
		// irida is (mirrored) sheen(?) - textured
		// paras is plain
		// arceus V is (mirrored) sheen(?) - textured
		// vaporeon VMAX is ditto VMAX
		// simisear VSTAR is (mirrored) sheen(?) - textured
		// abomasnow is plain
		// kricketune V is (mirrored) sheen(?)
		// centiskorch VMAX is (mirrored) sheen(?) - textured
		// morpeko V-Union is (mirrored) sheen(?)
		// lure module is ???
		// training court is ???
		// water energy is ???
		// single strike energy is ???
		// mew is ???
		// zacian V is ???
		// lugia VSTAR is ???
		// pikachu VMAX is ???
		// Arceus VSTAR is ???
		// bea is ???
		// victini VMAX is ???
		// ice rider calyrex VMAX is ???
		// melmetal VMAX is ???
		// eternatus VMAX is ???
		// serperior VSTAR is ???
		// spidops ex is (mirrored) sheen(?)
		// arcanine ex is ???
		// miriam is (mirrored) sheen(?) - textured
		// iron threads ex is (mirrored) sheen(?) - textured
		// gyarados ex is ???
		// iono is ???
		// tarountula is (mirrored) sheen(?)
		// chi-yu ex is ???
		// rare candy is ???
		// lightning energy is ???
		// skeledirge ex is ???
		
		$test = array(
		// 1,72,321,2936,1918,3,15,235,111,144,345,342,404,368,411,968,'<br>', // cosmos
		// 468,434,985,672,215,220,324,622,610,2966,3843,566,941,1063,565,723,1055,1068,791,637,'<br>', // mirror
		588,585,3228,590,'<br>', // radiant confetti
		2595,3222,3009,16,863,860,3263,862,865,1683,1185,1716,1730,1805,3573,2876,'<br>', // plain
		1440,1244,1500,1549,1779,1784,1792,3054,2493,2399,2704,2066,2721,3071,2211,2602,3630,1964,2328,3604,2737,3578,3486,3351,3394,3645,3696,3691,3657,3828,'<br>', // sheen (mirrored)
		583,'<br>', // gold 1 (?)
		3063,'<br>', // gold 2 (?)
		6,'<br>', // shining (neo)
		// 83,309,'<br>', // cracked ice
		// 2958,2957,975,'<br>', // sheen
		// 494,'<br>', // tinsel
		927,'<br>', // BREAK
		3243,'<br>', // radiant star
		// 1072,1233,1773,1775,1405,'<br>', // water web
		1215,1230,'<br>', // shining (sm)
		1151,1837,1107,1156,1310,3091,'<br>', // gold 3 (?)
		1574,1464,1520,1573,'<br>', // gold 4 (?)
		2133,2329,3087,2935,2693,2487,2392,2603,1987,3470,3365,3611,2173,2374,2458,2927,2087,3455,'<br>', // sparkle 1
		3116,'<br>', // radiant
		// 2615,'<br>', // confetti
		3646,3683,3817,3807,3714,3715,3820,'<br>', // sparkle 2
		);
		start($j++, '1 of each type for acetone (ultra rare)', array(), $test);
		foreach ($test as $cur) { if ($cur == '<br>') { print($cur); } else if (in_array($cur, array(), true)) {imgN($cur);} else {img($cur);} }
		finish();
		
		return;
	}
	else if (isset($_GET['random']))
	{
		$random = rand(1, 13766);
		
		start($j++, 'Random Card', $holoHave, array($random), true);
		if (in_array($random, $holoHave, true)) {imgHN($random, true);} else {imgH($random, true);}
		finish();
	}
	else if (isset($_GET['set']))
		require 'BestTracker_Holo_Sets.php';
	else if (isset($_GET['setrev']))
		require 'BestTracker_Holo_Sets_Reverse.php';
	else if (isset($_GET['type']))
		require 'BestTracker_Holo_Types.php';
	else if (isset($_GET['dex']))
		require 'BestTracker_Holo_Pokedex.php';
	else if (isset($_GET['all']))
		require 'BestTracker_Holo_All.php';
	else if (isset($_GET['col']))
	{
		start($j++, 'Holo Collection', $holoHave, $holoHave);
		foreach ($holoHave as $cur) { imgHN($cur); }
		finish();
	}
	else if (isset($_GET['binder']))
		require 'BestTracker_Holo_Binder.php';
	else
		require 'BestTracker_Holo.php';
}
else if (isset($_GET['worlds']))
{
	if (isset($_GET['test']))
	{
		
	}
	else if (isset($_GET['random']))
	{
		$random = rand(1, 10);
		
		start($j++, 'Random Card', $worldsHave, array($random), true);
		if (in_array($random, $worldsHave, true)) {imgWN($random, true);} else {imgW($random, true);}
		finish();
	}
	else if (isset($_GET['set']))
		require 'BestTracker_Worlds_Sets.php';
	else if (isset($_GET['year']))
		require 'BestTracker_Worlds_Years.php';
	else if (isset($_GET['type']))
		require 'BestTracker_Worlds_Types.php';
	else if (isset($_GET['dex']))
		require 'BestTracker_Worlds_Pokedex.php';
	else if (isset($_GET['all']))
		require 'BestTracker_Worlds_All.php';
	else if (isset($_GET['col']))
	{
		start($j++, 'Worlds Collection', $worldsHave, $worldsHave);
		foreach ($worldsHave as $cur) { imgWN($cur); }
		finish();
	}
	// else if (isset($_GET['binder']))
		// require 'BestTracker_Worlds_Binder.php';
	else
		require 'BestTracker_Worlds.php';
}
else if (isset($_GET['extremely_rare']))
{
	$extreme_rares = array
	(
		'EX_1','EX_2','EX_3','<br>',
		'DP_1','DP_2','DP_3','<br>',
		'HGSS_1','HGSS_2','HGSS_3','<br>',
		'BW_1','BW_2','BW_3','BW_4','<br>',
		'XY_1','XY_2','XY_3','XY_4','<br>',
		'SM_1','SM_2','SM_3','SM_4','<br>',
		'SWSH_1','<br>',
		'SV_1','SV_2','SV_3','SV_4','<br>',
		'M_Sachiko_EX','<br>',
		'Ishihara_GX','Ishihara_Pikachu_GX','<br>',
		'J_Balvin_V','Katy_Perry_V','Post_Malone_V','<br>',
	);
	
	start($j++, 'Extremely Rare Cards', array(), $extreme_rares, true);
	foreach ($extreme_rares as $cur) { imgER($cur, true); }
	finish();
}
else if (isset($_GET['acetone']))
{
	require 'BestTracker_Acetone.php';
}
else if (isset($_GET['test']))
{
	$test = array(
	290,321, // Secret Rare
	436,863, // Full Art Pokémon
	22, // Crystal Type
	56,215,216,184,29,180,221,35, // ex
	220,230, // Gold Star
	3851, // Holo Energy EX Emerald
	3856,3857, // Holo Energy EX Holon Phantoms
	3860,3861,3862,3864, // Holo Energy EX Power Keepers
	328,349,354,263, // LV.X
	281,292, // Shiny Holo Subset
	366,404, // Prime
	368,369,382, // LEGEND
	414, // Shiny Legend Subset
	621,622,970,553,488,693,554,861,948,597,774,980,743,460, // EX
	552,2951,2952,2953,603,531,605, // EX (Plasma)
	803,832, // Mega EX
	794,927,799,930,1048, // BREAK
	2966,968, // ancient trait
	3229,3234,3235,3243, // Radiant Collection
	667,754, // Full Art Trainer (BW & XY)
	1061,751, // EX Full Art
	1056, // Mega EX Full Art
	791, // Mega EX Special Art
	1852,1843,1167,1168,1117,1842,1081, // GX
	1362, // Ultra Beast GX
	1694, // Shiny Vault (SM)
	1128, // GX Full Art
	2124, // V
	2396, // VMAX
	3280, // VSTAR
	3016, // V Full Art
	3030, // V Shiny
	2737, // V Special Art
	2769 // Character Art (SWSH)
	);
	start($j++, 'Lost', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {/*imgN($cur);*/} else {img($cur);} }
	finish();
	
	// $have = array_merge($have, $test);
	
	$test = array(2697,2796,2911,3103,2807,3123,943,944,945,946,947,863,2595,2762,2759,2760,2764,794,927,930,1048,2097,3037,2051,2393,2333,2184,2126,3053,2395,2336,3041,2127,3004,3045,2128,1948,2639,2640,2398,2130,3020,3060,3096,2596,2598,3068,2058,2339,2400,3028,2401,2910,2059,2506,3054,2600,2108,2060,2135,2601,3044,2649,2193,2347,2713,2138,2011,3083,2063,2714,1958,3070,3064,3065,3001,3125,3039,1994,2396,2337,2704,3021,2597,2599,2005,1951,2510,2803,2650,2412,703,1023,664,911,938,1778,1086,1927,1090,2146,2073,1964,2530,2425,3115,3102,2920,3122,2077,2665,1892,1911,3086,2919,2433,3087,1667,2168,2210,2040,2089,2175,552,621,2951,970,2952,1026,2953,603,657,966,831,554,903,1045,774,1031,931,627,605,460,919,921,924,865,1655,1072,1883,1074,1884,1427,1356,1217,1843,1602,1841,1167,1168,1079,1169,1935,1362,1081,1871,941,1094,2165,2451,2369,2371,2602,3113,357,3055,275,352,360,3061,3052,1219,1730,3116,1361,1364,1436,2133,2134,2195,2143,3233,3235,3238,3261,3056,3057,3058,3059,2603,2754,2933,2181,3062,3063,3223,3224,2604,2605,2606,2607,2608,2609,2610,2611,2612,2613,2614,2615,2616,2617,2618,2619,2620,2621,2622,2623,2624,2625,2626,2627,2628);
	start($j++, 'Mat', $have, $test);
	foreach ($test as $cur) { if (in_array($cur, $have, true)) {/*imgN($cur);*/} else {img($cur);} }
	finish();
	
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
else if (isset($_GET['set']))
	require 'BestTracker_Sets.php';
else if (isset($_GET['type']))
	require 'BestTracker_Types.php';
else if (isset($_GET['dex']))
	require 'BestTracker_Pokedex.php';
else if (isset($_GET['fut']))
	require 'BestTracker_Future.php';
else if (isset($_GET['all']))
	require 'BestTracker_All.php';
else if (isset($_GET['col']))
{
	start($j++, 'Collection', $have, $have);
	foreach ($have as $cur) { imgN($cur); }
	finish();
}
else if (isset($_GET['allall']))
{
	require 'BestTracker_HoloHave.php';
	require 'BestTracker_WorldsHave.php';
	
	require 'BestTracker_All.php';
	require 'BestTracker_Holo_All.php';
	require 'BestTracker_Worlds_All.php';
	
	$name = 'All Cards (TOTAL)';
	$visible = false;
	$ID = 3;
	
	$amount = countN($all) + countN($holoAll) + countN($worldsAll);
	$haveAmount = countHave($all, $have) + countHave($holoAll, $holoHave) + countHave($worldsAll, $worldsHave);
	
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
	
	$onclick = $visible ? '' : 'onclick="toggleSection(this, '.$ID.')"';
	
	print('<div id="header-'.$ID.'" class="center" '.$onclick.'>');
	
	print('<h1>'.$name.'</h1>');
	print('<h2>'.$haveAmount.'/'.$amount.' ('.$percent.'%)</h2>');
	
	print('
	<div class="progress">
		<div class="progress-bar bg-'.$barClass.' progress-bar-striped" role="progressbar" aria-valuenow="'.$percent.'" aria-valuemin="0" aria-valuemax="100" style="width:'.$percent.'%">
			'.$percent.'%
		</div>
	</div>
	');
	
	$class = $visible ? 'center' : 'center hidden';
	
	print('</div><div id="container-'.$ID.'" class="'.$class.'">');
}
else if (isset($_GET['random']))
{
	$random = rand(1, 3865);
	
	start($j++, 'Random Card', $have, array($random), true);
	if (in_array($random, $have, true)) {imgN($random, true);} else {img($random, true);}
	finish();
}
else if (isset($_GET['binder']))
	require 'BestTracker_Binder.php';
else if (isset($_GET['percent']))
	require 'BestTracker_Percent.php';
else
	require 'BestTracker_Sections.php';
?>
	</body>
</html>