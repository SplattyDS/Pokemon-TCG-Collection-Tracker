<!doctype html>
<html>
	<head>
		<meta charset="utf-8">
		<title>Best Collection Tracker</title>
		
		<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">
		
		<script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.11.8/dist/umd/popper.min.js" integrity="sha384-I7E8VVD/ismYTF4hNIPjVp/Zjvgyol6VFvRkX/vR+Vc4jQkC+hVqc2pM8ODewa9r" crossorigin="anonymous"></script>
		<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.min.js" integrity="sha384-fbbOQedDUMZZ5KreZpsbe1LCZPVmfTnH7ois6mU1QK+m14rQ1l2bGBq41eYeM/fS" crossorigin="anonymous"></script>
		
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
		
		const NUM_BACKGROUNDS = 18;
		
		let currentIndex = 0;
		let intervalId;
		
		function setBackgroundImage(index)
		{
			document.body.style.backgroundImage = `url(images/best_tracker/background/${index}.png)`;
			document.body.style.backgroundPosition = "center";
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
				preloadImage(i);
			
			setBackgroundImage(0);
		}
		
		function preloadImage(index)
		{
			let img = new Image();
			img.src = "images/best_tracker/background/" + index + ".png";
		}
		</script>
	</head>
	<body onload="initAutomaticBackground()" style="background-position: center;">
		
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
							<li><a class="dropdown-item" href="BestTracker.php?holo&col">Collection</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&binder">Binder</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&type">Type</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&dex">Dex</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&all">All</a></li>
							<li><a class="dropdown-item" href="BestTracker.php?holo&test">Test</a></li>
						</ul>
					</li>
					
					<li class="nav-item"><a class="nav-link" href="BestTracker.php?test">Test</a></li>
				</ul>
			</div>
		</nav>
		
		<label for="background-checkbox">Enable automatic background</label>
		<input type="checkbox" id="background-checkbox" onclick="toggleAutomaticBackground()">
		<br>
		<button onclick="previousImage()">Previous</button>
		<button onclick="nextImage()">Next</button>
	</body>
</html>