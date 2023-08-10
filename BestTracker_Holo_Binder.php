<!--<?php/*
function PrintBinderInfo($ID, $name)
{
	print('<li><a href="BestTracker.php?holo&binder='.$ID.'">'.$name.'</a></li>');
}

function PrintBinder($ID, $binder, $name, $numPages = 40)
{
	if (isset($_GET['noimg']))
	{
		print('<div id="container-'.$ID.'">');
		print('<h1 class="center">'.$name.'</h1>');
		print('<div class="center"><img class="binder" src="images/best_tracker/binder/holo.png"></div>');
		print('</div>');
		return;
	}
	
	print('<h1 id="binder-'.$ID.'" class="center" onclick="toggleSection(this, '.$ID.')">'.$name.'</h1>');
	print('<div class="center"><img class="binder" src="images/best_tracker/binder/holo.png" onclick="toggleSection(this, '.$ID.')"></div>');
	
	print('<div id="container-'.$ID.'" class="hidden"><table class="center">');
	
	for ($i = 0; $i < $numPages; $i++)
	{
		print('<tr><td style="border: 10px solid white;">');
		
		if ($i != 0)
			PrintPage($binder, $i++);
		else
			PrintPage($binder, -1);
		
		print('</td><td style="border: 10px solid white;">');
		
		if ($i != $numPages)
			PrintPage($binder, $i);
		else
			PrintPage($binder, -1);
		
		print('</td></tr>');
	}
	
	print('</table></div>');
}

function PrintPage($binder, $pageNumber)
{
	$arr;
	$index;
	
	if ($pageNumber == -1)
	{
		$arr = array(0,0,0,0,0,0,0,0,0,0,0,0);
		$index = 0;
	}
	else
	{
		$arr = $binder;
		$index = $pageNumber * 9;
	}
	
	print('<table class="page">');
	
	for ($i = 0; $i < 9; $i++)
	{
		if ($i % 3 == 0)
			print('<tr>');
		
		print(GetBinderCell($arr, $index++));
		
		if ($i % 3 == 2)
			print('</tr>');
	}
	
	print('</table>');
}

function GetBinderCell($arr, $index)
{
	$id = $arr[$index];
	return '<td><img class="'.GetBinderImageClass($id).'" data-src="images/best_tracker/holo/'.GetImagePrefix($id).$id.'.png"></td>';
}

function GetBinderImageClass($id)
{
	global $holoHave;
	
	if ($id <= 0)
		return 'no-style';
	
	return in_array($id, $holoHave, true) ? 'have' : 'not-have';
}

function GetImagePrefix($id)
{
	return is_numeric($id) && $id != -1 ? str_repeat("0", 5 - strlen($id)) : '';
}

function Align(&$binder, $align, $rest = 0, $padNum = -1)
{
	while (count($binder) % $align != $rest)
		array_push($binder, $padNum);
}

function AlignRow(&$binder)
{
	return Align($binder, 3);
}

function AlignPage(&$binder)
{
	return Align($binder, 9);
}

function AlignPages(&$binder)
{
	if (count($binder) == 0) // otherwise the first page may be empty
		return;
	
	Align($binder, 18, 9);
}

function AlignBinder(&$binder)
{
	if (count($binder) > 360)
		$binder = array();
	
	AlignPage($binder);
	Align($binder, 360, 0, 0);
}

function AddCards(&$binder, $cards)
{
	$binder = array_merge($binder, $cards);
}

function SplitCards(&$binders, $cards)
{
	$freeSpace = 0;
	
	for ($i = 0; $i < count($binders); $i++)
		$freeSpace += CountFree($binders[$i]);
	
	if ($freeSpace < count($cards))
	{
		print('Not enough space to split cards. Needed '.count($cards).', has '.$freeSpace.'.<br>');
		return ;
	}
	
	for ($i = 0; $i < count($binders); $i++)
	{
		$freeSpace = CountFree($binders[$i]);
		$offset = FirstFreeOffset($binders[$i]);
		
		$binders[$i] = array_merge($binders[$i], $cards);
		
		// print('count($binders['.$i.']) = '.count($binders[$i]).'<br>');
		
		array_splice($binders[$i], 360, count($binders[$i]) - 360);
		
		for ($j = 0; $j < $freeSpace; $j++)
			unset($cards[$j]);
		
		array_splice($cards, 1, 1);
	}
	
	
	// for ($i = 0; $i < count($binders); $i++)
		// print('count($binders['.$i.']) = '.count($binders[$i]).'<br>');
}

function FirstFreeOffset(&$binder)
{
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == 0)
			return $i;
	}
	
	return -1;
}

function CountMarkers(&$binder)
{
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == -1)
			$amount++;
	}
	
	return $amount;
}

function CountFree(&$binder)
{
	if (count($binder) == 0)
		return 360;
	
	if (count($binder) < 360)
		return 360 - count($binder);
	
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == 0)
			$amount++;
	}
	
	return $amount;
}

function CountValidCards(&$binder)
{
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] != 0 && $binder[$i] != -1)
			$amount++;
	}
	
	return $amount;
}

function CountHaveBinder(&$binder)
{
	global $holoHave;
	
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] != 0 && $binder[$i] != -1 && in_array($binder[$i], $holoHave, true))
			$amount++;
	}
	
	return $amount;
}

$binder0 = array();
$binder1 = array();
$binder2 = array();
$binder3 = array();
$binder4 = array();
$binder5 = array();
$binder6 = array();
$binder7 = array();
$binder8 = array();
$binder9 = array();
$binder10 = array();
$binder11 = array();
$binder12 = array();
$binder13 = array();
$binder14 = array();
$binder15 = array();
$binder16 = array();
$binder17 = array();
$binder18 = array();
$binder19 = array();
$binder20 = array();
$binder21 = array();
$binder22 = array();
$binder23 = array();
$binder24 = array();
$binder25 = array();
$binder26 = array();
$binder27 = array();

AddCards($binder0, $OS_STAR_HOLO);
AlignRow($binder0);
AddCards($binder0, $OS_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $OS_COSMOS_HOLO_ENERGY);
AlignPage($binder0);
AddCards($binder0, $OS_REVERSE_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $NEO_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $NEO_REVERSE_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $LC_STAR_HOLO);
AlignPage($binder0);
AddCards($binder0, $E_COSMOS_HOLO);
AlignBinder($binder0);

AddCards($binder1, $LC_REVERSE_FIREWORKS_HOLO);
AlignPage($binder1);

$lcReverseBinders = array(&$binder1, &$binder2);
SplitCards($lcReverseBinders, $E_REVERSE_PLAIN_HOLO);

AlignBinder($binder1);
AlignBinder($binder2);

AddCards($binder3, $EX_COSMOS_HOLO);
AlignRow($binder3);
AddCards($binder3, $EX_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder3);
AddCards($binder3, $EX_COSMOS_HOLO_DELTA);
AlignPage($binder3);
AddCards($binder3, $EX_VERTICAL_PLAIN_HOLO_DELTA);
AlignPage($binder3);
AddCards($binder3, $EX_PIXEL_WAVE_HOLO_ENERGY);
AlignBinder($binder3);

$exReverseBinders = array(&$binder4, &$binder5);
SplitCards($exReverseBinders, $EX_REVERSE_PLAIN_HOLO);

AlignBinder($binder4);

AlignPage($binder5);
AddCards($binder5, $EX_BIG_ENERGY_HOLO_HL);
AlignPage($binder5);
AddCards($binder5, $EX_ENERGY_HOLO_FL);
AlignPage($binder5);
AddCards($binder5, $EX_ENERGY_HOLO_TRR);
AlignBinder($binder5);

AddCards($binder6, $EX_PRISM_HOLO_D);
AlignPage($binder6);
AddCards($binder6, $EX_2D_POKEBALL_HOLO_E);
AlignPage($binder6);
AddCards($binder6, $EX_3D_POKEBALL_HOLO_UF);
AlignBinder($binder6);

AddCards($binder7, $EX_PLAIN_HOLO_DS);
AlignPage($binder7);
AddCards($binder7, $EX_COSMOS_HOLO_LM);
AlignPage($binder7);
AddCards($binder7, $EX_MIRROR_HOLO_HP);
AlignBinder($binder7);

AddCards($binder8, $EX_MIRROR_HOLO_CG);
AlignPage($binder8);
AddCards($binder8, $EX_MIRROR_HOLO_DF);
AlignPage($binder8);
AddCards($binder8, $EX_PLAIN_HOLO_PK);
AlignBinder($binder8);

AddCards($binder9, $DP_COSMOS_HOLO);
AlignRow($binder9);
AddCards($binder9, $DP_COSMOS_HOLO_VICTORY_MEDAL);
AlignPage($binder9);
AddCards($binder9, $DP_CRACKED_ICE_HOLO);
AlignPage($binder9);
AddCards($binder9, $DP_MIRROR_HOLO_ENERGY);
AlignPage($binder9);
AddCards($binder9, $DP_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder9);
AddCards($binder9, $DP_RUMBLE_COSMOS_HOLO);
AddCards($binder9, $DP_RUMBLE_COSMOS_HOLO_LOGO);
AlignBinder($binder9);

$dpReverseBinders = array(&$binder10, &$binder11, &$binder12, &$binder13);
SplitCards($dpReverseBinders, $DP_REVERSE_MIRROR_HOLO);

AlignBinder($binder10);
AlignBinder($binder11);
AlignBinder($binder12);

AlignPage($binder13);
AddCards($binder13, $DP_REVERSE_CRACKED_ICE_HOLO);
AlignPage($binder13);
AddCards($binder13, $DP_REVERSE_CROSSHATCH_HOLO);
AlignPage($binder13);
AddCards($binder13, $DP_REVERSE_PLAIN_HOLO);
AlignBinder($binder13);

AddCards($binder14, $HGSS_COSMOS_HOLO);
AlignRow($binder14);
AddCards($binder14, $HGSS_COSMOS_HOLO_VICTORY_MEDAL);
AlignPage($binder14);
AddCards($binder14, $HGSS_CRACKED_ICE_HOLO);
AlignPage($binder14);
AddCards($binder14, $HGSS_MIRROR_HOLO_ENERGY_COL);
AlignPage($binder14);
AddCards($binder14, $HGSS_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder14);
AddCards($binder14, $HGSS_CROSSHATCH_HOLO_ENERGY_COL);
AlignPage($binder14);
AddCards($binder14, $HGSS_REVERSE_CROSSHATCH_HOLO);

$hgssReverseBinders = array(&$binder14, &$binder15);
SplitCards($hgssReverseBinders, $HGSS_REVERSE_MIRROR_HOLO);

AlignBinder($binder14);
AlignBinder($binder15);

AddCards($binder16, $BWXY_TINSEL_HOLO);
AlignPage($binder16);
AddCards($binder16, $BWXY_TINSEL_HOLO_PLASMA);
AlignPage($binder16);
AddCards($binder16, $BWXY_MIRROR_HOLO);
AlignPage($binder16);
AddCards($binder16, $BWXY_CRACKED_ICE_HOLO);
AlignPage($binder16);
AddCards($binder16, $BWXY_CRACKED_ICE_HOLO_PLASMA);
AlignBinder($binder16);

AddCards($binder17, $BWXY_SHEEN_HOLO);
AlignPage($binder17);
AddCards($binder17, $BWXY_SHEEN_HOLO_AQUA);
AlignRow($binder17);
AddCards($binder17, $BWXY_SHEEN_HOLO_MAGMA);
AlignRow($binder17);
AddCards($binder17, $BWXY_SHEEN_HOLO_FLARE);
AlignPage($binder17);
AddCards($binder17, $BWXY_CONFETTI_HOLO);
AlignPage($binder17);
AddCards($binder17, $BWXY_MIRROR_HOLO_ENERGY);
AlignPage($binder17);
AddCards($binder17, $BWXY_CROSSHATCH_HOLO_ENERGY_BW);
AlignPage($binder17);
AddCards($binder17, $BWXY_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder17);
AddCards($binder17, $BWXY_SHEEN_HOLO_ENERGY);
AlignPage($binder17);
AddCards($binder17, $BWXY_MIRROR_HOLO_ENERGY_GENERATIONS);
AlignPage($binder17);
AddCards($binder17, $BWXY_REVERSE_CROSSHATCH_HOLO);
AlignRow($binder17);
AddCards($binder17, $BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA);
AlignBinder($binder17);

AddCards($binder18, $BWXY_COSMOS_HOLO);
AlignPage($binder18);
AddCards($binder18, $BWXY_COSMOS_HOLO_PLASMA);
AlignBinder($binder18);

AddCards($binder19, $BWXY_REVERSE_MIRROR_HOLO);
AlignPage($binder19);
AddCards($binder19, $BWXY_REVERSE_MIRROR_HOLO_PLASMA);
AlignPage($binder19);
AddCards($binder19, $BWXY_REVERSE_MIRROR_HOLO_AQUA);
AlignPage($binder19);
AddCards($binder19, $BWXY_REVERSE_MIRROR_HOLO_MAGMA);
AlignPage($binder19);

$bwxyReverseBinders = array(&$binder19, &$binder20, &$binder21, &$binder22, &$binder23, &$binder24, &$binder25);
SplitCards($bwxyReverseBinders, $BWXY_REVERSE_ENERGY_HOLO);

AlignBinder($binder19);
AlignBinder($binder20);
AlignBinder($binder21);
AlignBinder($binder22);
AlignBinder($binder23);
AlignBinder($binder24);
AlignBinder($binder25);

AddCards($binder26, $EV_STAR_HOLO);
AlignPage($binder26);
AddCards($binder26, $EV_COSMOS_HOLO);
AlignRow($binder26);
AddCards($binder26, $EV_CRACKED_ICE_HOLO);
AlignPage($binder26);
AddCards($binder26, $EV_SHEEN_HOLO);
AlignRow($binder26);
AddCards($binder26, array(-1));
AddCards($binder26, $EV_MIRROR_HOLO);
AlignPage($binder26);
AddCards($binder26, $EV_MIRROR_HOLO_ENERGY);
AlignPage($binder26);
AddCards($binder26, $EV_REVERSE_MIRROR_HOLO);
AlignBinder($binder26);

AddCards($binder27, array(-1));
AlignBinder($binder27);

$binders = array
(
	&$binder0,
	&$binder1,
	&$binder2,
	&$binder3,
	&$binder4,
	&$binder5,
	&$binder6,
	&$binder7,
	&$binder8,
	&$binder9,
	&$binder10,
	&$binder11,
	&$binder12,
	&$binder13,
	&$binder14,
	&$binder15,
	&$binder16,
	&$binder17,
	&$binder18,
	&$binder19,
	&$binder20,
	&$binder21,
	&$binder22,
	&$binder23,
	&$binder24,
	&$binder25,
	&$binder26,
	&$binder27,
);

$markers = 0;

for ($i = 0; $i < count($binders); $i++)
	$markers += CountMarkers($binders[$i]);

$binderContents = array
(
	'OS Holo, Neo Holo, LC Holo, e Series Holo',
	'LC Reverse, e Series Reverse 1',
	'e Series Reverse 2',
	'EX Holo',
	'EX Reverse 1',
	'EX Reverse 2',
	'EX Reverse 3',
	'EX Reverse 4',
	'EX Reverse 5',
	'DPPt Holo',
	'DPPt Reverse 1',
	'DPPt Reverse 2',
	'DPPt Reverse 3',
	'DPPt Reverse 4',
	'HGSS Holo, HGSS Reverse 1',
	'HGSS Reverse 2',
	'BWXY Holo 1',
	'BWXY Holo 2',
	'BWXY Holo 3',
	'BWXY Reverse 1',
	'BWXY Reverse 2',
	'BWXY Reverse 3',
	'BWXY Reverse 4',
	'BWXY Reverse 5',
	'BWXY Reverse 6',
	'BWXY Reverse 7',
	'EV Holo, EV Reverse',
	'TBA',
);

print('<h1>Number of VSTAR Markers: '.$markers.'</h1>');

print('<ul>');

for ($i = 0; $i < count($binders); $i++)
{
	$validCards = CountValidCards($binders[$i]);
	$haveCount = CountHaveBinder($binders[$i]);
	$havePercent = $validCards == 0 ? 0 : round($haveCount / $validCards * 100, 2);
	
	PrintBinderInfo($i, 'Binder '.$i.' ('.$binderContents[$i].') - Free Space: '.CountFree($binders[$i]).' - Completion: '.$haveCount.'/'.$validCards.' ('.$havePercent.'%)');
}

print('</ul>');


if (is_numeric($_GET['binder']))
{
	$i = $_GET['binder'];
	PrintBinder($i, $binders[$i], 'Binder '.$i.' ('.$binderContents[$i].')');
}

// for ($i = 0; $i < count($binders); $i++)
	// PrintBinder($i + 1, $binders[$i], 'Binder '.($i + 1).' ('.$binderContents[$i].')');
*/?>-->

<?php
function PrintBinderInfo($ID, $name)
{
	print('<li><a href="BestTracker.php?holo&binder='.$ID.'">'.$name.'</a></li>');
}

function PrintBinder($ID, $binder, $name, $numPages = 40)
{
	if (isset($_GET['noimg']))
	{
		print('<div id="container-'.$ID.'">');
		print('<h1 class="center">'.$name.'</h1>');
		print('<div class="center"><img class="binder" src="images/best_tracker/binder/holo.png"></div>');
		print('</div>');
		return;
	}
	
	print('<h1 id="binder-'.$ID.'" class="center" onclick="toggleSection(this, '.$ID.')">'.$name.'</h1>');
	print('<div class="center"><img class="binder" src="images/best_tracker/binder/holo.png" onclick="toggleSection(this, '.$ID.')"></div>');
	
	print('<div id="container-'.$ID.'" class="hidden"><table class="center">');
	
	for ($i = 0; $i < $numPages; $i++)
	{
		print('<tr><td style="border: 10px solid white;">');
		
		if ($i != 0)
			PrintPage($binder, $i++);
		else
			PrintPage($binder, -1);
		
		print('</td><td style="border: 10px solid white;">');
		
		if ($i != $numPages)
			PrintPage($binder, $i);
		else
			PrintPage($binder, -1);
		
		print('</td></tr>');
	}
	
	print('</table></div>');
}

function PrintPage($binder, $pageNumber)
{
	$arr;
	$index;
	
	if ($pageNumber == -1)
	{
		$arr = array(0,0,0,0,0,0,0,0,0,0,0,0);
		$index = 0;
	}
	else
	{
		$arr = $binder;
		$index = $pageNumber * 12;
	}
	
	print('<table class="page">');
	
	for ($i = 0; $i < 12; $i++)
	{
		if ($i % 4 == 0)
			print('<tr>');
		
		print(GetBinderCell($arr, $index++));
		
		if ($i % 4 == 3)
			print('</tr>');
	}
	
	print('</table>');
}

function GetBinderCell($arr, $index)
{
	$id = $arr[$index];
	return '<td><img class="'.GetBinderImageClass($id).'" data-src="images/best_tracker/holo/'.GetImagePrefix($id).$id.'.png"></td>';
}

function GetBinderImageClass($id)
{
	global $holoHave;
	
	if ($id <= 0)
		return 'no-style';
	
	return in_array($id, $holoHave, true) ? 'have' : 'not-have';
}

function GetImagePrefix($id)
{
	return is_numeric($id) && $id != -1 ? str_repeat("0", 5 - strlen($id)) : '';
}

function Align(&$binder, $align, $rest = 0, $padNum = -1)
{
	while (count($binder) % $align != $rest)
		array_push($binder, $padNum);
}

function AlignRow(&$binder)
{
	return Align($binder, 4);
}

function AlignPage(&$binder)
{
	return Align($binder, 12);
}

function AlignPages(&$binder)
{
	if (count($binder) == 0) // otherwise the first page may be empty
		return;
	
	Align($binder, 24, 12);
}

function AlignBinder(&$binder)
{
	if (count($binder) > 480)
		$binder = array();
	
	AlignPage($binder);
	Align($binder, 480, 0, 0);
}

function AddCards(&$binder, $cards)
{
	$binder = array_merge($binder, $cards);
}

function SplitCards(&$binders, $cards)
{
	$freeSpace = 0;
	
	for ($i = 0; $i < count($binders); $i++)
		$freeSpace += CountFree($binders[$i]);
	
	if ($freeSpace < count($cards))
	{
		print('Not enough space to split cards. Needed '.count($cards).', has '.$freeSpace.'.<br>');
		return ;
	}
	
	for ($i = 0; $i < count($binders); $i++)
	{
		$freeSpace = CountFree($binders[$i]);
		$offset = FirstFreeOffset($binders[$i]);
		
		$binders[$i] = array_merge($binders[$i], $cards);
		
		// print('count($binders['.$i.']) = '.count($binders[$i]).'<br>');
		
		array_splice($binders[$i], 480, count($binders[$i]) - 480);
		
		for ($j = 0; $j < $freeSpace; $j++)
			unset($cards[$j]);
		
		array_splice($cards, 1, 0);
	}
	
	
	// for ($i = 0; $i < count($binders); $i++)
		// print('count($binders['.$i.']) = '.count($binders[$i]).'<br>');
}

function FirstFreeOffset(&$binder)
{
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == 0)
			return $i;
	}
	
	return -1;
}

function CountMarkers(&$binder)
{
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == -1)
			$amount++;
	}
	
	return $amount;
}

function CountFree(&$binder)
{
	if (count($binder) == 0)
		return 480;
	
	if (count($binder) < 480)
		return 480 - count($binder);
	
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == 0)
			$amount++;
		else
			$amount = 0;
	}
	
	return $amount;
}

function CountValidCards(&$binder)
{
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] != 0 && $binder[$i] != -1)
			$amount++;
	}
	
	return $amount;
}

function CountHaveBinder(&$binder)
{
	global $holoHave;
	
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] != 0 && $binder[$i] != -1 && in_array($binder[$i], $holoHave, true))
			$amount++;
	}
	
	return $amount;
}

$binder0 = array();
$binder1 = array();
$binder2 = array();
$binder3 = array();
$binder4 = array();
$binder5 = array();
$binder6 = array();
$binder7 = array();
$binder8 = array();
$binder9 = array();
$binder10 = array();
$binder11 = array();
$binder12 = array();
$binder13 = array();
$binder14 = array();
$binder15 = array();
$binder16 = array();
$binder17 = array();
$binder18 = array();
$binder19 = array();
$binder20 = array();
$binder21 = array();
$binder22 = array();
$binder23 = array();

AddCards($binder0, $OS_STAR_HOLO);
AlignRow($binder0);
AddCards($binder0, $OS_COSMOS_HOLO);
AlignRow($binder0);
AddCards($binder0, $OS_COSMOS_HOLO_ENERGY);
AlignPage($binder0);
AddCards($binder0, $OS_REVERSE_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $NEO_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $NEO_REVERSE_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $LC_STAR_HOLO);
AlignPage($binder0);
AddCards($binder0, $LC_REVERSE_FIREWORKS_HOLO);
AlignPage($binder0);
AddCards($binder0, $E_COSMOS_HOLO);
AlignBinder($binder0);

AddCards($binder1, $E_REVERSE_PLAIN_HOLO);
AlignBinder($binder1);

AddCards($binder2, $EX_COSMOS_HOLO);
AlignRow($binder2);
AddCards($binder2, $EX_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder2);
AddCards($binder2, $EX_COSMOS_HOLO_DELTA);
AlignPage($binder2);
AddCards($binder2, $EX_VERTICAL_PLAIN_HOLO_DELTA);
AlignPage($binder2);
AddCards($binder2, $EX_PIXEL_WAVE_HOLO_ENERGY);
AlignPage($binder2);

AddCards($binder3, $EX_REVERSE_PLAIN_HOLO);
AlignPage($binder3);
AddCards($binder3, $EX_BIG_ENERGY_HOLO_HL);
AlignBinder($binder3);

AddCards($binder4, $EX_ENERGY_HOLO_FL);
AlignPage($binder4);
AddCards($binder4, $EX_ENERGY_HOLO_TRR);
AlignPage($binder4);
AddCards($binder4, $EX_PRISM_HOLO_D);
AlignPage($binder4);
AddCards($binder4, $EX_2D_POKEBALL_HOLO_E);
AlignBinder($binder4);

AddCards($binder5, $EX_3D_POKEBALL_HOLO_UF);
AlignPage($binder5);
AddCards($binder5, $EX_PLAIN_HOLO_DS);
AlignPage($binder5);
AddCards($binder5, $EX_COSMOS_HOLO_LM);
AlignPage($binder5);
AddCards($binder5, $EX_MIRROR_HOLO_HP);
AlignBinder($binder5);

AddCards($binder6, $EX_MIRROR_HOLO_CG);
AlignPage($binder6);
AddCards($binder6, $EX_MIRROR_HOLO_DF);
AlignPage($binder6);
AddCards($binder6, $EX_PLAIN_HOLO_PK);
AlignBinder($binder6);

AddCards($binder7, $DP_COSMOS_HOLO);
AlignRow($binder7);
AddCards($binder7, $DP_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder7);
AddCards($binder7, $DP_RUMBLE_COSMOS_HOLO);
AlignPage($binder7);
AddCards($binder7, $DP_RUMBLE_COSMOS_HOLO_LOGO);
AlignPage($binder7);
AddCards($binder7, $DP_MIRROR_HOLO_ENERGY);
AlignPage($binder7);
AddCards($binder7, $DP_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder7);
AddCards($binder7, $DP_CRACKED_ICE_HOLO);
AlignPage($binder7);
AddCards($binder7, $DP_REVERSE_CRACKED_ICE_HOLO);
AlignPage($binder7);
AddCards($binder7, $DP_REVERSE_CROSSHATCH_HOLO);
AlignPages($binder7);
AddCards($binder7, $DP_REVERSE_PLAIN_HOLO);
AlignBinder($binder7);

$dpReverseBinders = array(&$binder8, &$binder9, &$binder10);
SplitCards($dpReverseBinders, $DP_REVERSE_MIRROR_HOLO);

AlignBinder($binder8);
AlignBinder($binder9);
AlignBinder($binder10);

AddCards($binder11, $HGSS_COSMOS_HOLO);
AlignRow($binder11);
AddCards($binder11, $HGSS_COSMOS_HOLO_VICTORY_MEDAL);
AlignPage($binder11);
AddCards($binder11, $HGSS_CRACKED_ICE_HOLO);
AlignPage($binder11);
AddCards($binder11, $HGSS_MIRROR_HOLO_ENERGY_COL);
AlignPage($binder11);
AddCards($binder11, $HGSS_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder11);
AddCards($binder11, $HGSS_CROSSHATCH_HOLO_ENERGY_COL);
AlignPage($binder11);
AddCards($binder11, $HGSS_REVERSE_CROSSHATCH_HOLO);
AlignBinder($binder11);

AddCards($binder12, $HGSS_REVERSE_MIRROR_HOLO);
AlignBinder($binder12);

AddCards($binder13, $BWXY_TINSEL_HOLO);
AlignPage($binder13);
AddCards($binder13, $BWXY_TINSEL_HOLO_PLASMA);
AlignPage($binder13);
AddCards($binder13, $BWXY_SHEEN_HOLO);
AlignPage($binder13);
AddCards($binder13, $BWXY_SHEEN_HOLO_AQUA);
AlignRow($binder13);
AddCards($binder13, $BWXY_SHEEN_HOLO_MAGMA);
AlignPage($binder13);
AddCards($binder13, $BWXY_SHEEN_HOLO_FLARE);
AlignPages($binder13);
AddCards($binder13, $BWXY_MIRROR_HOLO);
AlignRow($binder13);
AddCards($binder13, $BWXY_CRACKED_ICE_HOLO_PLASMA);
AlignRow($binder13);
AddCards($binder13, $BWXY_CRACKED_ICE_HOLO);
AlignBinder($binder13);

AddCards($binder14, $BWXY_COSMOS_HOLO);
AlignRow($binder14);
AddCards($binder14, $BWXY_COSMOS_HOLO_PLASMA);
AlignPage($binder14);
AddCards($binder14, $BWXY_CONFETTI_HOLO);
AlignPage($binder14);
AddCards($binder14, $BWXY_REVERSE_CROSSHATCH_HOLO);
AlignRow($binder14);
AddCards($binder14, $BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA);
AlignRow($binder14);
AddCards($binder14, $BWXY_MIRROR_HOLO_ENERGY);
AlignPage($binder14);
AddCards($binder14, $BWXY_CROSSHATCH_HOLO_ENERGY_BW);
AlignPage($binder14);
AddCards($binder14, $BWXY_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder14);
AddCards($binder14, $BWXY_SHEEN_HOLO_ENERGY);
AlignPage($binder14);
AddCards($binder14, $BWXY_MIRROR_HOLO_ENERGY_GENERATIONS);
AlignBinder($binder14);

AddCards($binder15, $BWXY_REVERSE_MIRROR_HOLO);
AlignPage($binder15);
AddCards($binder15, $BWXY_REVERSE_MIRROR_HOLO_PLASMA);
AlignPage($binder15);
AddCards($binder15, $BWXY_REVERSE_MIRROR_HOLO_AQUA);
AlignPage($binder15);
AddCards($binder15, $BWXY_REVERSE_MIRROR_HOLO_MAGMA);
AlignPage($binder15);

$bwxyReverseBinders = array(&$binder15, &$binder16, &$binder17, &$binder18, &$binder19);
SplitCards($bwxyReverseBinders, $BWXY_REVERSE_ENERGY_HOLO);

AlignBinder($binder15);
AlignBinder($binder16);
AlignBinder($binder17);
AlignBinder($binder18);
AlignBinder($binder19);

AddCards($binder20, $EV_STAR_HOLO);
AddCards($binder20, array(-1));
AddCards($binder20, $EV_CRACKED_ICE_HOLO);
AlignRow($binder20);
AddCards($binder20, $EV_COSMOS_HOLO);
AlignRow($binder20);
AddCards($binder20, $EV_SHEEN_HOLO);
AlignPage($binder20);
AddCards($binder20, $EV_MIRROR_HOLO);
AlignPage($binder20);
AddCards($binder20, $EV_MIRROR_HOLO_ENERGY);
AlignPages($binder20);
AddCards($binder20, $EV_REVERSE_MIRROR_HOLO);
AlignBinder($binder20);

AddCards($binder21, array(-1));
AlignBinder($binder21);

$input = array(2, '/r', 2, '/p', 2, '/p', 1, '/p', 4, '/r', 1, '/r', 2, '/p', 1, '/r', 1, '/r', 2, '/r', 3, '/r', 2, '/r', 4, '/p', 29, '/p', 26, '/r', 1, '/p', 3, '/r', 1, '/r', 3, '/p', 11, '/p', 1, '/p', 9, '/p', 1, '/r', 3, '/p', 6, '/r', 1, '/p', 6, '/p', 8, '/p', 2, '/r', 5, -1, 1, 1, '/p', 74, '/s', 1, '/r', 1, '/r', 2, '/p', 7, '/p', 3, '/p', 11, '/p', 1, '/p', 5, '/p', 40, '/b', 40, '/s', 16, '/p', 3, '/p', 5, '/p', 1, '/s', 142, '/s', -1, '/s', 3, '/p', 1, '/s', 0, '/s', '/b');
$output = array();
$haveIndex = 0;

for ($i = 0; $i < count($input); $i++)
{
	$var = $input[$i];
	
	if (is_numeric($var))
	{
		if ($var == 0)
		{
			for ($j = $haveIndex; $j < count($holoHave); $j++)
				array_push($output, $holoHave[$j]);
		}
		else if ($var == -1)
		{
			array_push($output, -1);
			// print('<p>Added: -1</p>');
		}
		else
		{
			for ($j = 0; $j < $var; $j++)
			{
				array_push($output, $holoHave[$haveIndex + $j]);
				// print('<p>Added: '.$holoHave[$haveIndex + $j].'</p>');
			}
			
			$haveIndex += $var;
		}
	}
	else if ($var == '/r')
	{
		Align($output, 4, 0, 0);
	}
	else if ($var == '/p')
	{
		Align($output, 12, 0, 0);
	}
	else if ($var == '/s')
	{
		Align($output, 24, 12, 0);
	}
	else if ($var == '/b')
	{
		Align($output, 480, 0, 0);
	}
}

// start($j++, 'Collection Test', $holoHave, $output);
// foreach ($output as $cur) { if (in_array($cur, $holoHave, true)) {imgHN($cur);} else {imgH($cur);} }
// finish();

$testBinders = array(&$binder22, &$binder23);
SplitCards($testBinders, $output);

AlignBinder($binder22);
AlignBinder($binder23);

$binders = array
(
	&$binder0,
	&$binder1,
	&$binder2,
	&$binder3,
	&$binder4,
	&$binder5,
	&$binder6,
	&$binder7,
	&$binder8,
	&$binder9,
	&$binder10,
	&$binder11,
	&$binder12,
	&$binder13,
	&$binder14,
	&$binder15,
	&$binder16,
	&$binder17,
	&$binder18,
	&$binder19,
	&$binder20,
	&$binder21,
	&$binder22,
	&$binder23,
);

$markers = 0;

for ($i = 0; $i < count($binders); $i++)
	$markers += CountMarkers($binders[$i]);

$binderContents = array
(
	'OS Holo, Neo Holo, LC Holo, LC Reverse, e Series Holo',
	'e Series Reverse',
	'EX Holo, EX Reverse 1',
	'EX Reverse 2',
	'EX Reverse 3',
	'EX Reverse 4',
	'EX Reverse 5',
	'DPPt Holo',
	'DPPt Reverse 1',
	'DPPt Reverse 2',
	'DPPt Reverse 3',
	'HGSS Holo',
	'HGSS Reverse',
	'BWXY Holo 1',
	'BWXY Holo 2',
	'BWXY Reverse 1',
	'BWXY Reverse 2',
	'BWXY Reverse 3',
	'BWXY Reverse 4',
	'BWXY Reverse 5',
	'EV Holo, EV Reverse',
	'TBA',
	'Collection 1',
	'Collection 2',
);

print('<h1>Number of VSTAR Markers: '.$markers.'</h1>');

print('<ul>');

for ($i = 0; $i < count($binders); $i++)
{
	$validCards = CountValidCards($binders[$i]);
	$haveCount = CountHaveBinder($binders[$i]);
	$havePercent = $validCards == 0 ? 0 : round($haveCount / $validCards * 100, 2);
	
	PrintBinderInfo($i, 'Binder '.$i.' ('.$binderContents[$i].') - Free Space: '.CountFree($binders[$i]).' - Completion: '.$haveCount.'/'.$validCards.' ('.$havePercent.'%)');
}

print('</ul>');


if (is_numeric($_GET['binder']))
{
	$i = $_GET['binder'];
	PrintBinder($i, $binders[$i], 'Binder '.$i.' ('.$binderContents[$i].')');
}

// for ($i = 0; $i < count($binders); $i++)
	// PrintBinder($i + 1, $binders[$i], 'Binder '.($i + 1).' ('.$binderContents[$i].')');
?>