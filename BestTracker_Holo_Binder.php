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
			else if ($var == PHP_INT_MAX)
			{
				array_push($output, -1);
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

$binders = array();
$binderContents = array();

$binder = array();
AddCards($binder, $OS_STARLIGHT_HOLO);
AlignRow($binder);
AddCards($binder, $OS_PIXEL_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $OS_PIXEL_COSMOS_HOLO_DARK);
AlignPage($binder);
AddCards($binder, $OS_PIXEL_COSMOS_HOLO_OWNER);
AlignRow($binder);
AddCards($binder, $OS_PIXEL_COSMOS_HOLO_ROCKET);
AlignPage($binder);
AddCards($binder, $OS_CLASSIC_STARS_HOLO);
AlignRow($binder);
AddCards($binder, $OS_REVERSE_PIXEL_COSMOS_HOLO);
AddCards($binder, $OS_REVERSE_PIXEL_COSMOS_HOLO_ROCKET);
AlignPage($binder);
AddCards($binder, $OS_PIXEL_COSMOS_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $OS_CLASSIC_STARS_HOLO_ENERGY);
AlignPages($binder);
AddCards($binder, $NEO_PIXEL_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $NEO_PIXEL_COSMOS_HOLO_DARK);
AlignRow($binder);
AddCards($binder, $NEO_PIXEL_COSMOS_HOLO_LIGHT);
AlignRow($binder);
AddCards($binder, $NEO_SMOOTH_COSMOS_HOLO_LIGHT);
// AddCards($binder, array(-1,-1));
// AddCards($binder, $NEO_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $NEO_REVERSE_PIXEL_COSMOS_HOLO);
AlignPages($binder);
AddCards($binder, $LC_STARLIGHT_HOLO);
AddCards($binder, $LC_STARLIGHT_HOLO_DARK);
AlignPage($binder);
AddCards($binder, $LC_REVERSE_FIREWORKS_HOLO);
AlignPage($binder);
AddCards($binder, $LC_REVERSE_FIREWORKS_HOLO_DARK);
AlignPages($binder);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'OS Holo, Neo Holo, LC Holo, LC Reverse');

$binder = array();
AddCards($binder, $E_REVERSE_PLAIN_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'e Series Reverse');

$binder = array();
AddCards($binder, $E_PIXEL_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $E_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_DELTA);
AlignRow($binder);
AddCards($binder, $EX_SMOOTH_COSMOS_HOLO_DELTA);
AlignPage($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_AQUA);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_MAGMA);
AlignRow($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_DARK);
AlignPage($binder);
AddCards($binder, $EX_VERTICAL_PLAIN_HOLO_DELTA);
AlignPage($binder);
AddCards($binder, $EX_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $EX_PIXEL_WAVE_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $EX_PLAIN_HOLO_ENERGY);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'e Series Holo, EX Holo');

$binder = array();
AddCards($binder, $EX_REVERSE_PLAIN_HOLO);
AlignRow($binder);
AddCards($binder, $EX_REVERSE_PLAIN_HOLO_AQUA);
AlignRow($binder);
AddCards($binder, $EX_REVERSE_PLAIN_HOLO_MAGMA);
AlignPages($binder);
AddCards($binder, $EX_BIG_ENERGY_HOLO_HL);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'EX Reverse 1');

$binder = array();
AddCards($binder, $EX_ENERGY_HOLO_FL);
AlignPages($binder);
AddCards($binder, $EX_ENERGY_HOLO_TRR);
AlignPage($binder);
AddCards($binder, $EX_ENERGY_HOLO_TRR_DARK);
AlignPage($binder);
AddCards($binder, $EX_ENERGY_HOLO_TRR_ROCKET);
AlignPages($binder);
AddCards($binder, $EX_PRISM_HOLO_D);
AlignPages($binder);
AddCards($binder, $EX_2D_POKEBALL_HOLO_E);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'EX Reverse 2');

$binder = array();
AddCards($binder, $EX_3D_POKEBALL_HOLO_UF);
AlignPages($binder);
AddCards($binder, $EX_PLAIN_HOLO_DS);
AddCards($binder, $EX_PLAIN_HOLO_DS_HOLON);
AlignPage($binder);
AddCards($binder, $EX_PLAIN_HOLO_DS_DELTA);
AlignPages($binder);
AddCards($binder, $EX_PIXEL_COSMOS_HOLO_LM);
AlignPages($binder);
AddCards($binder, $EX_MIRROR_HOLO_HP);
AddCards($binder, array(-1,-1));
AddCards($binder, $EX_MIRROR_HOLO_HP_HOLON);
AlignPage($binder);
AddCards($binder, $EX_MIRROR_HOLO_HP_DELTA);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'EX Reverse 3');

$binder = array();
AddCards($binder, $EX_MIRROR_HOLO_CG);
AlignPage($binder);
AddCards($binder, $EX_MIRROR_HOLO_CG_DELTA);
AlignPages($binder);
AddCards($binder, $EX_MIRROR_HOLO_DF);
AlignPage($binder);
AddCards($binder, $EX_MIRROR_HOLO_DF_DELTA);
AlignPages($binder);
AddCards($binder, $EX_PLAIN_HOLO_PK);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'EX Reverse 4');

$binder = array();
AddCards($binder, $DP_PIXEL_COSMOS_HOLO);
AddCards($binder, $DP_PIXEL_COSMOS_HOLO_SP);
AddCards($binder, $DP_SMOOTH_COSMOS_HOLO_SP);
AlignRow($binder);
AddCards($binder, $DP_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder);
AddCards($binder, $DP_RUMBLE_PIXEL_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $DP_RUMBLE_PIXEL_COSMOS_HOLO_LOGO);
AlignRow($binder);
AddCards($binder, array(-1));
AlignRow($binder);
AddCards($binder, $DP_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $DP_MIRROR_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $DP_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $DP_CRACKED_ICE_HOLO);
AlignRow($binder);
AddCards($binder, $DP_CRACKED_ICE_HOLO_SP);
AlignPage($binder);
AddCards($binder, $DP_REVERSE_CRACKED_ICE_HOLO);
AlignRow($binder);
AddCards($binder, $DP_REVERSE_CRACKED_ICE_HOLO_SP);
AlignPage($binder);
AddCards($binder, $DP_REVERSE_CROSSHATCH_HOLO);
AlignRow($binder);
AddCards($binder, $DP_REVERSE_CROSSHATCH_HOLO_SP);
AlignPages($binder);
AddCards($binder, $DP_REVERSE_PLAIN_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'DPPt Holo');

$dpReverseBinders = array(array(), array(), array());
SplitCards($dpReverseBinders, $DP_REVERSE_MIRROR_HOLO);
AddCards($dpReverseBinders[2], $DP_REVERSE_MIRROR_HOLO_SP);
foreach ($dpReverseBinders as $dpReverseBinder)
{
	AlignBinder($dpReverseBinder);
	array_push($binders, $dpReverseBinder);
}
array_push($binderContents, 'DPPt Reverse 1');
array_push($binderContents, 'DPPt Reverse 2');
array_push($binderContents, 'DPPt Reverse 3');

$binder = array();
AddCards($binder, $HGSS_PIXEL_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $HGSS_PIXEL_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder);
AddCards($binder, $HGSS_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $HGSS_CRACKED_ICE_HOLO);
AlignPage($binder);
AddCards($binder, $HGSS_MIRROR_HOLO_ENERGY_COL);
AlignPage($binder);
AddCards($binder, $HGSS_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $HGSS_CROSSHATCH_HOLO_ENERGY_COL);
AlignPage($binder);
AddCards($binder, $HGSS_REVERSE_CROSSHATCH_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'HGSS Holo');

$binder = array();
AddCards($binder, $HGSS_REVERSE_MIRROR_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'HGSS Reverse');

$binder = array();
AddCards($binder, $BWXY_TINSEL_HOLO);
AlignPage($binder);
AddCards($binder, $BWXY_TINSEL_HOLO_PLASMA);
AlignPage($binder);
AddCards($binder, $BWXY_SHEEN_HOLO);
AlignPage($binder);
AddCards($binder, $BWXY_SHEEN_HOLO_AQUA);
AlignRow($binder);
AddCards($binder, $BWXY_SHEEN_HOLO_MAGMA);
AlignPage($binder);
AddCards($binder, $BWXY_SHEEN_HOLO_FLARE);
AlignPages($binder);
AddCards($binder, $BWXY_MIRROR_HOLO);
AlignRow($binder);
AddCards($binder, $BWXY_CRACKED_ICE_HOLO_PLASMA);
AlignRow($binder);
AddCards($binder, $BWXY_CRACKED_ICE_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'BWXY Holo 1');

$binder = array();
AddCards($binder, $BWXY_PIXEL_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $BWXY_PIXEL_COSMOS_HOLO_PLASMA);
AlignPage($binder);
AddCards($binder, $BWXY_SMOOTH_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $BWXY_CONFETTI_HOLO);
AlignPage($binder);
AddCards($binder, $BWXY_CLASSIC_STARS_HOLO);
AlignPages($binder);
AddCards($binder, $BWXY_REVERSE_CROSSHATCH_HOLO);
AlignRow($binder);
AddCards($binder, $BWXY_REVERSE_CROSSHATCH_HOLO_PLASMA);
AlignRow($binder);
AddCards($binder, $BWXY_MIRROR_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $BWXY_CROSSHATCH_HOLO_ENERGY_BW);
AlignPage($binder);
AddCards($binder, $BWXY_CROSSHATCH_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $BWXY_SHEEN_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $BWXY_MIRROR_HOLO_ENERGY_GENERATIONS);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'BWXY Holo 2');

$bwxyReverseBinders = array(array(), array(), array(), array(), array());
AddCards($bwxyReverseBinders[0], $BWXY_REVERSE_MIRROR_HOLO);
AlignPage($bwxyReverseBinders[0]);
AddCards($bwxyReverseBinders[0], $BWXY_REVERSE_MIRROR_HOLO_PLASMA);
AlignPage($bwxyReverseBinders[0]);
AddCards($bwxyReverseBinders[0], $BWXY_REVERSE_MIRROR_HOLO_AQUA);
AlignPage($bwxyReverseBinders[0]);
AddCards($bwxyReverseBinders[0], $BWXY_REVERSE_MIRROR_HOLO_MAGMA);
AlignPage($bwxyReverseBinders[0]);
SplitCards($bwxyReverseBinders, $BWXY_REVERSE_ENERGY_HOLO);
foreach ($bwxyReverseBinders as $bwxyReverseBinder)
{
	AlignBinder($bwxyReverseBinder);
	array_push($binders, $bwxyReverseBinder);
}
array_push($binderContents, 'BWXY Reverse 1');
array_push($binderContents, 'BWXY Reverse 2');
array_push($binderContents, 'BWXY Reverse 3');
array_push($binderContents, 'BWXY Reverse 4');
array_push($binderContents, 'BWXY Reverse 5');

$binder = array();
AddCards($binder, $EV_STARLIGHT_HOLO);
AlignRow($binder);
AddCards($binder, $EV_SMOOTH_COSMOS_HOLO);
AlignRow($binder);
AddCards($binder, $EV_SHEEN_HOLO);
AlignRow($binder);
AddCards($binder, $EV_CRACKED_ICE_HOLO);
AlignRow($binder);
AddCards($binder, $EV_CLASSIC_STARS_HOLO);
AlignPages($binder);
AddCards($binder, $EV_MIRROR_HOLO);
AlignPage($binder);
AddCards($binder, $EV_MIRROR_HOLO_ENERGY);
AlignPages($binder);
AddCards($binder, $EV_REVERSE_MIRROR_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'EV Holo, EV Reverse');

$binder = array();
AddCards($binder, $SM_WATER_WEB_HOLO);
AlignPage($binder);
AddCards($binder, $SM_SMOOTH_COSMOS_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'SM Holo 1');

$binder = array();
AddCards($binder, $SM_CRACKED_ICE_HOLO);
AlignRow($binder);
AddCards($binder, $SM_MIRROR_HOLO);
AlignPage($binder);
AddCards($binder, $SM_CONFETTI_HOLO);
AlignPage($binder);
AddCards($binder, $SM_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $SM_SEQUIN_HOLO);
AlignRow($binder);
AddCards($binder, $SM_SHEEN_HOLO);
AddCards($binder, array(-1));
AddCards($binder, $SM_SHEEN_HOLO_DP);
AlignPage($binder);
AddCards($binder, $SM_SHEEN_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $SM_SHEEN_HOLO_ENERGY_TT);
AlignPage($binder);
AddCards($binder, $SM_WATER_WEB_HOLO_ENERGY);
AlignRow($binder);
AddCards($binder, $SM_REVERSE_SHEEN_HOLO);
AlignRow($binder);
AddCards($binder, $SM_REVERSE_SMOOTH_COSMOS_BIG_ENERGY_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'SM Holo 2');

$smReverseBinders = array(array(), array(), array(), array());
SplitCards($smReverseBinders, $SM_REVERSE_BIG_ENERGY_HOLO);
foreach ($smReverseBinders as $smReverseBinder)
{
	AlignBinder($smReverseBinder);
	array_push($binders, $smReverseBinder);
}
array_push($binderContents, 'SM Reverse 1');
array_push($binderContents, 'SM Reverse 2');
array_push($binderContents, 'SM Reverse 3');
array_push($binderContents, 'SM Reverse 4');

$binder = array();
AddCards($binder, $SWSH_LINE_HOLO);
AlignRow($binder);
AddCards($binder, $SWSH_LINE_HOLO_LOST);
AlignPage($binder);
AddCards($binder, $SWSH_PLAIN_HOLO);
AlignPage($binder);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'SWSH Holo 1');

$binder = array();
AddCards($binder, $SWSH_SMOOTH_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_PIXEL_COSMOS_HOLO);
AddCards($binder, array(-1));
AddCards($binder, $SWSH_PIXEL_COSMOS_HOLO_LOST);
AlignPage($binder);
AddCards($binder, $SWSH_CRACKED_ICE_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_CONFETTI_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_MIRROR_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_MIRAGE_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_SEQUIN_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_CLASSIC_STARS_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_PLAIN_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $SWSH_PLAIN_HOLO_ENERGY_STAR);
AlignPage($binder);
AddCards($binder, $SWSH_LINE_HOLO_ENERGY);
AlignPage($binder);
AddCards($binder, $SWSH_LINE_HOLO_ENERGY_STAR);
AlignPage($binder);
AddCards($binder, $SWSH_PIXEL_COSMOS_HOLO_ENERGY_STAR);
AlignPage($binder);
AddCards($binder, $SWSH_REVERSE_SMOOTH_COSMOS_ENERGY_BANNER_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_REVERSE_MIRROR_ENERGY_BANNER_HOLO);
AlignRow($binder);
AddCards($binder, $SWSH_REVERSE_MIRROR_HOLO);
AddCards($binder, array(-1));
AddCards($binder, $SWSH_REVERSE_PLAIN_HOLO);
AlignPage($binder);
AddCards($binder, $SWSH_REVERSE_LINE_HOLO);
AlignRow($binder);
AddCards($binder, $SWSH_REVERSE_PIXEL_COSMOS_HOLO);
AlignPages($binder);

$swshReverseBinders = array($binder, array(), array(), array(), array());
SplitCards($swshReverseBinders, $SWSH_REVERSE_ENERGY_BANNER_HOLO);
AlignRow($swshReverseBinders[4]);
AddCards($swshReverseBinders[4], $SWSH_REVERSE_ENERGY_BANNER_HOLO_LOST);
foreach ($swshReverseBinders as $swshReverseBinder)
{
	AlignBinder($swshReverseBinder);
	array_push($binders, $swshReverseBinder);
}
array_push($binderContents, 'SWSH Holo 2, SWSH Reverse 1');
array_push($binderContents, 'SWSH Reverse 2');
array_push($binderContents, 'SWSH Reverse 3');
array_push($binderContents, 'SWSH Reverse 4');
array_push($binderContents, 'SWSH Reverse 5');

$binder = array();
AddCards($binder, $SV_MIRAGE_HOLO);
AlignPage($binder);
AddCards($binder, $SV_MIRAGE_HOLO_ANCIENT);
AlignPage($binder);
AddCards($binder, $SV_MIRAGE_HOLO_FUTURE);
AlignPage($binder);
AddCards($binder, $SV_SMOOTH_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $SV_PIXEL_COSMOS_HOLO);
AlignPage($binder);
AddCards($binder, $SV_PIXEL_COSMOS_HOLO_ANCIENT);
AlignPage($binder);
AddCards($binder, $SV_PIXEL_COSMOS_HOLO_FUTURE);
AlignPage($binder);
AddCards($binder, $SV_CONFETTI_HOLO);
AlignPage($binder);
AddCards($binder, $SV_LINE_HOLO);
AlignPage($binder);
AddCards($binder, $SV_SNOWFLAKE_HOLO);
AlignPage($binder);
AddCards($binder, $SV_CLASSIC_STARS_HOLO);
AlignBinder($binder);
array_push($binders, $binder);
array_push($binderContents, 'SV Holo 1');
/*
// SV

SV_SMOOTH_COSMOS_HOLO_ENERGY,
SV_PIXEL_COSMOS_HOLO_ENERGY,
SV_TOXIC_CHAIN_HOLO_ENERGY,

SV_REVERSE_ROCKY_HOLO,
SV_REVERSE_TOXIC_CHAIN_HOLO,
SV_REVERSE_ANCIENT_HOLO,
SV_REVERSE_FUTURE_HOLO,

SV_REVERSE_MIRAGE_ROCKY_HOLO,
SV_REVERSE_PIXEL_COSMOS_HOLO,
SV_REVERSE_LINE_HOLO,
SV_REVERSE_PLAIN_HOLO,
*/

$binder = array();
// array_push($binders, $binder);
// array_push($binders, $binder);
// array_push($binders, $binder);
// array_push($binders, $binder);
// array_push($binderContents, 'TBA');
// array_push($binderContents, 'TBA');
// array_push($binderContents, 'TBA');
// array_push($binderContents, 'TBA');

// oopsies:
// Iron Moth (Pixel Cosmos Holo)
	// stamped: already had base

// $input = array(2, '/r', 2, '/p', 1, '/r', 1, '/r', 1, '/p', 3, '/p', 4, '/r', 1, '/r', 2, '/p', 2, '/r', 4, '/r', 2, 1, '/r', 3, '/r', 4, '/r', 1, '/r', 4, '/p', 28, '/r', 1, 1, '/p', 28, '/r', 2, '/r', 1, '/p', 3, '/r', 1, '/r', 3, 1, '/p', 13, '/r', 1, '/p', 11, '/p', 2, '/r', 3, '/p', 3, 1, '/r', 6, '/p', 7, '/p', 12, '/p', 1, '/r', 6, '/p', 6, '/r', 2, '/p', 87, '/p', 2, '/r', 1, '/r', 3, '/p', 8, '/p', 15, '/p', 12, '/p', 3, '/p', 12, '/r', 1, '/b', 49, '/p', 50, 1, '/r', -1, '/r', 16, '/r', 14, '/r', 5, '/r', 7, '/r', 1, '/r', 4, '/r', 1, '/p', 182, 1, '/b', 45, '/r', 2, '/r', 4, '/p', 4, '/r', 14, '/p', 2, '/r', 3, '/p', 11, 1, '/r', 1, '/r', 3, '/r', 3, '/p', 2, '/r', 3, '/r', 1, '/s', 103, '/p', 1, '/r', 5, '/s', 0, '/b');
$input = array(2, '/r', 2, '/p', 1, '/r', 1, '/r', 1, '/p', 3, '/p', 4, '/r', 1, '/r', 2, '/p', 2, '/r', 4, '/r', 2, 1, '/r', 3, '/r', 4, '/r', 1, '/r', 4, '/p', 28, '/r', 1, 1, '/p', 28, '/r', 2, '/r', 1, '/p', 3, '/r', 1, '/r', 3, 1, '/p', 13, '/r', 1, '/p', 11, '/p', 2, '/r', 3, '/p', 3, 1, '/r', 6, '/p', 7, '/p', 12, '/p', 1, '/r', 6, '/p', 6, '/r', 2, '/p', 87, '/p', 2, '/r', 1, '/r', 3, '/p', 8, '/p', 15, '/p', 12, '/p', 3, '/p', 12, '/r', 1, '/b', 49, '/p', 50, 1, '/r', -1, '/r', 16, '/r', 14, '/r', 5, '/r', 7, '/r', 1, '/r', 4, '/r', 1, '/p', 182, 1, '/b',
PHP_INT_MAX,12,PHP_INT_MAX,13,PHP_INT_MAX,13,PHP_INT_MAX,6,PHP_INT_MAX,1, '/s', 1,PHP_INT_MAX,1,PHP_INT_MAX, '/p', 4, '/s',
3,PHP_INT_MAX,1, '/r', PHP_INT_MAX,4,PHP_INT_MAX,PHP_INT_MAX,3,PHP_INT_MAX,PHP_INT_MAX,PHP_INT_MAX,2,PHP_INT_MAX,5,PHP_INT_MAX, '/p', 2, '/r', 3, '/p',
9,PHP_INT_MAX,2, 1,
1,PHP_INT_MAX,PHP_INT_MAX, '/r', 3, '/r', 3, '/p',
2, '/r', PHP_INT_MAX,2,PHP_INT_MAX,PHP_INT_MAX,1, '/r', 1, '/s',
103, '/p', 1,PHP_INT_MAX, '/r', 5, '/s', 0, '/b');

$collectionBinders = array(array(), array(), array());
SplitCards($collectionBinders, Process($input));
foreach ($collectionBinders as $collectionBinder)
{
	AlignBinder($collectionBinder);
	array_push($binders, $collectionBinder);
}
array_push($binderContents, 'Collection 1');
array_push($binderContents, 'Collection 2');
array_push($binderContents, 'Collection 3');

$markers = 0;

foreach ($binders as $curBinder)
{
	AlignBinder($curBinder);
	$markers += CountMarkers($curBinder);
}

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