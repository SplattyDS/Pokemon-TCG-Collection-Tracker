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
		return;
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

function Process(&$input)
{
	global $holoHave;
	
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
			else if ($var < 0)
			{
				for ($j = 0; $j < abs($var); $j++)
					array_push($output, 0);
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
	
	return $output;
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
$binder28 = array();
$binder29 = array();
$binder30 = array();
$binder31 = array();
$binder32 = array();
$binder33 = array();

AddCards($binder0, $OS_STARLIGHT_HOLO);
AlignRow($binder0);
AddCards($binder0, $OS_PIXEL_COSMOS_HOLO);
AddCards($binder0, $OS_PIXEL_COSMOS_HOLO_DARK);
AddCards($binder0, $OS_PIXEL_COSMOS_HOLO_OWNER);
AddCards($binder0, $OS_PIXEL_COSMOS_HOLO_ROCKET);
AlignRow($binder0);
AddCards($binder0, $OS_PIXEL_COSMOS_HOLO_ENERGY);
AlignPage($binder0);
AddCards($binder0, $OS_REVERSE_PIXEL_COSMOS_HOLO);
AddCards($binder0, $OS_REVERSE_PIXEL_COSMOS_HOLO_ROCKET);
AlignPage($binder0);
AddCards($binder0, $NEO_PIXEL_COSMOS_HOLO);
AddCards($binder0, $NEO_PIXEL_COSMOS_HOLO_DARK);
AddCards($binder0, $NEO_PIXEL_COSMOS_HOLO_LIGHT);
AddCards($binder0, $NEO_SMOOTH_COSMOS_HOLO_LIGHT);
AlignPage($binder0);
AddCards($binder0, $NEO_REVERSE_PIXEL_COSMOS_HOLO);
AlignPage($binder0);
AddCards($binder0, $LC_STARLIGHT_HOLO);
AddCards($binder0, $LC_STARLIGHT_HOLO_DARK);
AlignPage($binder0);
AddCards($binder0, $LC_REVERSE_FIREWORKS_HOLO);
AddCards($binder0, $LC_REVERSE_FIREWORKS_HOLO_DARK);
AlignPage($binder0);
AddCards($binder0, $E_PIXEL_COSMOS_HOLO);
AlignBinder($binder0);

AddCards($binder1, $E_REVERSE_PLAIN_HOLO);
AlignBinder($binder1);

AddCards($binder2, $EX_PIXEL_COSMOS_HOLO);
AlignRow($binder2);
AddCards($binder2, $EX_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder2);
AddCards($binder2, $EX_PIXEL_COSMOS_HOLO_DELTA);
AddCards($binder2, $EX_SMOOTH_COSMOS_HOLO_DELTA);
AlignPage($binder2);
AddCards($binder2, $EX_PIXEL_COSMOS_HOLO_AQUA);
AddCards($binder2, $EX_PIXEL_COSMOS_HOLO_MAGMA);
AlignRow($binder2);
AddCards($binder2, $EX_PIXEL_COSMOS_HOLO_DARK);
AlignPage($binder2);
AddCards($binder2, $EX_VERTICAL_PLAIN_HOLO_DELTA);
AlignPages($binder2);
AddCards($binder2, $EX_PIXEL_WAVE_HOLO_ENERGY);
AlignPage($binder2);
AddCards($binder2, $EX_PLAIN_HOLO_ENERGY);
AlignBinder($binder2);

AddCards($binder3, $EX_REVERSE_PLAIN_HOLO);
AlignRow($binder3);
AddCards($binder3, $EX_REVERSE_PLAIN_HOLO_AQUA);
AlignRow($binder3);
AddCards($binder3, $EX_REVERSE_PLAIN_HOLO_MAGMA);
AlignPages($binder3);
AddCards($binder3, $EX_BIG_ENERGY_HOLO_HL);
AlignBinder($binder3);

AddCards($binder4, $EX_ENERGY_HOLO_FL);
AlignPages($binder4);
AddCards($binder4, $EX_ENERGY_HOLO_TRR);
AlignPage($binder4);
AddCards($binder4, $EX_ENERGY_HOLO_TRR_DARK);
AlignPage($binder4);
AddCards($binder4, $EX_ENERGY_HOLO_TRR_ROCKET);
AlignPages($binder4);
AddCards($binder4, $EX_PRISM_HOLO_D);
AlignPages($binder4);
AddCards($binder4, $EX_2D_POKEBALL_HOLO_E);
AlignBinder($binder4);

AddCards($binder5, $EX_3D_POKEBALL_HOLO_UF);
AlignPages($binder5);
AddCards($binder5, $EX_PLAIN_HOLO_DS);
AddCards($binder5, $EX_PLAIN_HOLO_DS_HOLON);
AlignPage($binder5);
AddCards($binder5, $EX_PLAIN_HOLO_DS_DELTA);
AlignPages($binder5);
AddCards($binder5, $EX_PIXEL_COSMOS_HOLO_LM);
AlignPages($binder5);
AddCards($binder5, $EX_MIRROR_HOLO_HP);
AddCards($binder5, array(-1,-1));
AddCards($binder5, $EX_MIRROR_HOLO_HP_HOLON);
AlignPage($binder5);
AddCards($binder5, $EX_MIRROR_HOLO_HP_DELTA);
AlignBinder($binder5);

AddCards($binder6, $EX_MIRROR_HOLO_CG);
AlignPage($binder6);
AddCards($binder6, $EX_MIRROR_HOLO_CG_DELTA);
AlignPages($binder6);
AddCards($binder6, $EX_MIRROR_HOLO_DF);
AlignPage($binder6);
AddCards($binder6, $EX_MIRROR_HOLO_DF_DELTA);
AlignPages($binder6);
AddCards($binder6, $EX_PLAIN_HOLO_PK);
AlignBinder($binder6);

AddCards($binder7, $DP_PIXEL_COSMOS_HOLO);
AddCards($binder7, $DP_PIXEL_COSMOS_HOLO_SP);
AddCards($binder7, $DP_SMOOTH_COSMOS_HOLO_SP);
AlignRow($binder7);
AddCards($binder7, $DP_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder7);
AddCards($binder7, $DP_RUMBLE_PIXEL_COSMOS_HOLO);
AlignPage($binder7);
AddCards($binder7, $DP_RUMBLE_PIXEL_COSMOS_HOLO_LOGO);
AlignPage($binder7);
AddCards($binder7, $DP_MIRROR_HOLO_ENERGY);
AlignPage($binder7);
AddCards($binder7, $DP_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder7);
AddCards($binder7, $DP_CRACKED_ICE_HOLO);
AlignRow($binder7);
AddCards($binder7, $DP_CRACKED_ICE_HOLO_SP);
AlignPage($binder7);
AddCards($binder7, $DP_REVERSE_CRACKED_ICE_HOLO);
AlignRow($binder7);
AddCards($binder7, $DP_REVERSE_CRACKED_ICE_HOLO_SP);
AlignPage($binder7);
AddCards($binder7, $DP_REVERSE_CROSSHATCH_HOLO);
AlignRow($binder7);
AddCards($binder7, $DP_REVERSE_CROSSHATCH_HOLO_SP);
AlignPages($binder7);
AddCards($binder7, $DP_REVERSE_PLAIN_HOLO);
AlignBinder($binder7);

$dpReverseBinders = array(&$binder8, &$binder9, &$binder10);
SplitCards($dpReverseBinders, $DP_REVERSE_MIRROR_HOLO);

AlignBinder($binder8);
AlignBinder($binder9);

AddCards($binder10, $DP_REVERSE_MIRROR_HOLO_SP);
AlignBinder($binder10);

AddCards($binder11, $HGSS_PIXEL_COSMOS_HOLO);
AlignRow($binder11);
AddCards($binder11, $HGSS_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
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

AddCards($binder14, $BWXY_PIXEL_COSMOS_HOLO);
AlignRow($binder14);
AddCards($binder14, $BWXY_PIXEL_COSMOS_HOLO_PLASMA);
AlignPage($binder14);
AddCards($binder14, $BWXY_SMOOTH_COSMOS_HOLO);
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

AddCards($binder20, $EV_STARLIGHT_HOLO);
AddCards($binder20, array(-1));
AddCards($binder20, $EV_CRACKED_ICE_HOLO);
AlignRow($binder20);
AddCards($binder20, $EV_SMOOTH_COSMOS_HOLO);
AlignRow($binder20);
AddCards($binder20, $EV_SHEEN_HOLO);
AlignPage($binder20);
AddCards($binder20, $EV_MIRROR_HOLO);
AlignPage($binder20);
AddCards($binder20, $EV_MIRROR_HOLO_ENERGY);
AlignPages($binder20);
AddCards($binder20, $EV_REVERSE_MIRROR_HOLO);
AlignBinder($binder20);

AddCards($binder21, $SM_WATER_WEB_HOLO);
AlignPage($binder21);
AddCards($binder21, $SM_SMOOTH_COSMOS_HOLO);
AlignBinder($binder21);

AddCards($binder22, $SM_CRACKED_ICE_HOLO);
AlignRow($binder22);
AddCards($binder22, $SM_MIRROR_HOLO);
AlignPage($binder22);
AddCards($binder22, $SM_CONFETTI_HOLO);
AlignPage($binder22);
AddCards($binder22, $SM_SEQUIN_HOLO);
AlignRow($binder22);
AddCards($binder22, $SM_SHEEN_HOLO);
AddCards($binder22, array(-1));
AddCards($binder22, $SM_SHEEN_HOLO_DP);
AlignPage($binder22);
AddCards($binder22, $SM_SHEEN_HOLO_ENERGY);
AlignPage($binder22);
AddCards($binder22, $SM_SHEEN_HOLO_ENERGY_TT);
AlignPage($binder22);
AddCards($binder22, $SM_WATER_WEB_HOLO_ENERGY);
AlignRow($binder22);
AddCards($binder22, $SM_REVERSE_SHEEN_HOLO);
AlignRow($binder22);
AddCards($binder22, $SM_REVERSE_SMOOTH_COSMOS_BIG_ENERGY_HOLO);
AlignPage($binder22);

$smReverseBinders = array(&$binder23, &$binder24, &$binder25, &$binder26);
SplitCards($smReverseBinders, $SM_REVERSE_BIG_ENERGY_HOLO);

AlignBinder($binder22);
AlignBinder($binder23);
AlignBinder($binder24);
AlignBinder($binder25);
AlignBinder($binder26);

AddCards($binder27, array(-1));
AlignBinder($binder27);

AddCards($binder28, array(-1));
AlignBinder($binder28);

AddCards($binder29, array(-1));
AlignBinder($binder29);

AddCards($binder30, array(-1));
AlignBinder($binder30);

// oopsies:
// Iron Moth (Pixel Cosmos Holo)
	// stamped: already had base

// not added yet (blank spots):
// Iron Thorns (Mirage Holo)
// Iron Valiant (Mirage Holo)
// Miraidon (Reverse Holo)
// Miraidon (Pixel Cosmos Holo)

// $input = array(2, '/r', 2, '/p', 2, '/r', 1, '/p', 1, '/p', 4, '/r', 1, '/r', 2, '/p', 2, '/r', 4, '/r', 1, '/r', 2, '/r', 3, '/r', 1, '/r', 4, '/p', 28, '/r', 1, '/r', 1, '/p', 25, '/r', 2, '/r', 1, '/p', 3, '/r', 1, '/r', 3, '/p', 11, '/p', 1, '/p', 9, '/p', 1, '/r', 3, '/p', 3, '/r', 1, '/r', 4, '/p', 7, '/p', 10, '/p', 1, '/r', 4, '/p', 6, '/r', 2, '/p', 80, '/s', 2, '/r', 1, '/r', 2, '/p', 8, '/p', 12, '/p', 12, '/p', 2, '/p', 6, '/p', 1, '/b', 45, '/s', 48, '/s', 16, '/p', 11, '/p', 7, '/p', 1, '/r', 1, '/s', 167, 1, '/s', 16, '/p', 3, '/r', 2, '/p', 6, '/r', 1, '/p', 1, '/r', 2, '/p', 26, '/s', 0, '/s', '/b');
$input = array(2, '/r', 2, '/p', 1, '/r', 1, '/r', 1, '/p', 3, '/p', 4, '/r', 1, '/r', 2, '/p', 2, '/r', 4, '/r', 1, 1, '/r', 2, '/r', 3, '/r', 1, '/r', 4, '/p', 31, '/r', 1, '/r', 1, '/p', 25, '/r', 2, '/r', 1, '/p', 3, '/r', 1, '/r', 3, '/p', 11, '/p', 1, '/p', 10, '/p', 2, '/r', 3, '/p', 3, 1, '/r', 6, '/p', 7, '/p', 12, '/p', 1, '/r', 4, '/p', 6, '/r', 2, '/p', 87, '/p', 2, '/r', 1, '/r', 3, '/p', 8, '/p', 15, '/p', 12, '/p', 2, '/p', 12, '/r', 1, '/b', 49, '/p', 50, '/r', -1, '/r', 16, '/r', 14, '/r', 5, '/r', 7, '/r', 1, '/r', 4, '/r', 1, '/p', 182, 1, '/b', 38, '/r', 1, '/r', 4, '/p', 3, '/r', 3, 2, 3, '/r', 6, -1, 1, '/r', 3, '/r', 2, '/r', 3, '/p', 97, '/p', 1, '/r', 2, '/s', 0, '/b');

// start($j++, 'Collection Test', $holoHave, $output);
// foreach ($output as $cur) { if (in_array($cur, $holoHave, true)) {imgHN($cur);} else {imgH($cur);} }
// finish();

$testBinders = array(&$binder31, &$binder32, &$binder33);
SplitCards($testBinders, Process($input));

AlignBinder($binder31);
AlignBinder($binder32);
AlignBinder($binder33);

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
	&$binder28,
	&$binder29,
	&$binder30,
	&$binder31,
	&$binder32,
	&$binder33,
);

$markers = 0;

for ($i = 0; $i < count($binders); $i++)
	$markers += CountMarkers($binders[$i]);

$binderContents = array
(
	'OS Holo, Neo Holo, LC Holo, LC Reverse, e Series Holo',
	'e Series Reverse',
	'EX Holo',
	'EX Reverse 1',
	'EX Reverse 2',
	'EX Reverse 3',
	'EX Reverse 4',
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
	'SM Holo 1',
	'SM Holo 2',
	'SM Reverse 1',
	'SM Reverse 2',
	'SM Reverse 3',
	'SM Reverse 4',
	'TBA',
	'TBA',
	'TBA',
	'TBA',
	'Collection 1',
	'Collection 2',
	'Collection 3',
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