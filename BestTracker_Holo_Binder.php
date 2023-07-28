<?php
function PrintBinderInfo($ID, $name)
{
	print('<li><a href="#binder-'.$ID.'">'.$name.'</a></li>');
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
	
	// <div id="container-'.$ID.'" class="center">
	// print('<table class="center">');
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
		
		if ($i % 3 == 3)
			print('<tr>');
	}
	
	print('</table>');
	
	
	
	// print('<table class="page">
	// <tr><td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td></tr>
	// <tr><td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td></tr>
	// <tr><td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td>
	// <td><img src="images/best_tracker/cards/'.GetImagePrefix($arr[$index]).$arr[$index++].'.png"></td></tr>
	// </table>');
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
	return is_numeric($id) && $id != -1 ? str_repeat("0", 4 - strlen($id)) : '';
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

AddCards($binder1, $OS_STAR_HOLO);
AlignRow($binder1);
AddCards($binder1, $OS_COSMOS_HOLO);
AlignPage($binder1);
AddCards($binder1, $OS_COSMOS_HOLO_ENERGY);
AlignPage($binder1);
AddCards($binder1, $OS_REVERSE_COSMOS_HOLO);
AlignPage($binder1);
AddCards($binder1, $NEO_COSMOS_HOLO);
AlignPage($binder1);
AddCards($binder1, $NEO_REVERSE_COSMOS_HOLO);
AlignPage($binder1);
AddCards($binder1, $LC_STAR_HOLO);
AlignPage($binder1);
AddCards($binder1, $E_COSMOS_HOLO);
AlignBinder($binder1);

AddCards($binder2, $LC_REVERSE_SILVER_FIREWORKS_HOLO);
AlignPage($binder2);

$lcReverseBinders = array(&$binder2, &$binder3);
SplitCards($lcReverseBinders, $E_REVERSE_REFRACTOR_HOLO);

AlignBinder($binder2);
AlignBinder($binder3);

AddCards($binder4, $EX_COSMOS_HOLO);
AlignRow($binder4);
AddCards($binder4, $EX_COSMOS_HOLO_VICTORY_MEDAL);
AlignRow($binder4);
AddCards($binder4, $EX_COSMOS_HOLO_DELTA);
AlignPage($binder4);
AddCards($binder4, $EX_VERTICAL_REFRACTOR_HOLO_DELTA);
AlignPage($binder4);
AddCards($binder4, $EX_PIXEL_WAVE_HOLO_ENERGY);
AlignBinder($binder4);

$exReverseBinders = array(&$binder5, &$binder6);
SplitCards($exReverseBinders, $EX_REVERSE_REFRACTOR_HOLO);

AlignBinder($binder5);

AlignPage($binder6);
AddCards($binder6, $EX_BIG_ENERGY_HOLO_HL);
AlignPage($binder6);
AddCards($binder6, $EX_ENERGY_HOLO_FL);
AlignPage($binder6);
AddCards($binder6, $EX_ENERGY_HOLO_TRR);
AlignBinder($binder6);

AddCards($binder7, $EX_PRISM_HOLO_D);
AlignPage($binder7);
AddCards($binder7, $EX_2D_POKEBALL_HOLO_E);
AlignPage($binder7);
AddCards($binder7, $EX_3D_POKEBALL_HOLO_UF);
AlignBinder($binder7);

AddCards($binder8, $EX_REFRACTOR_HOLO_DS);
AlignPage($binder8);
AddCards($binder8, $EX_COSMOS_HOLO_LM);
AlignPage($binder8);
AddCards($binder8, $EX_REFRACTOR_HOLO_HP);
AlignBinder($binder8);

AddCards($binder9, $EX_REFRACTOR_HOLO_CG);
AlignPage($binder9);
AddCards($binder9, $EX_REFRACTOR_HOLO_DF);
AlignPage($binder9);
AddCards($binder9, $EX_REFRACTOR_HOLO_PK);
AlignBinder($binder9);

AddCards($binder10, $DP_COSMOS_HOLO);
AlignPage($binder10);
AddCards($binder10, $DP_COSMOS_HOLO_VICTORY_MEDAL);
AlignPage($binder10);
AddCards($binder10, $DP_CRACKED_ICE_HOLO);
AlignPage($binder10);
AddCards($binder10, $DP_MIRROR_HOLO_ENERGY);
AlignPage($binder10);
AddCards($binder10, $DP_SCRATCH_HOLO_ENERGY);
AlignPage($binder10);
AddCards($binder10, $DP_RUMBLE_COSMOS_HOLO_LOGO);
AlignBinder($binder10);

$dpReverseBinders = array(&$binder11, &$binder12, &$binder13, &$binder14);
SplitCards($dpReverseBinders, $DP_REVERSE_MIRROR_HOLO);

AlignBinder($binder11);
AlignBinder($binder12);
AlignBinder($binder13);

AlignPage($binder14);
AddCards($binder14, $DP_REVERSE_CRACKED_ICE_HOLO);
AlignPage($binder14);
AddCards($binder14, $DP_REVERSE_SCRATCH_HOLO);
AlignPage($binder14);
AddCards($binder14, $DP_REVERSE_REFRACTOR_HOLO);
AlignBinder($binder14);

AddCards($binder15, $HGSS_COSMOS_HOLO);
AlignRow($binder15);
AddCards($binder15, $HGSS_COSMOS_HOLO_VICTORY_MEDAL);
AlignPage($binder15);
AddCards($binder15, $HGSS_CRACKED_ICE_HOLO);
AlignPage($binder15);
AddCards($binder15, $HGSS_MIRROR_HOLO_ENERGY_COL);
AlignPage($binder15);
AddCards($binder15, $HGSS_SCRATCH_HOLO_ENERGY);
AlignPage($binder15);
AddCards($binder15, $HGSS_SCRATCH_HOLO_ENERGY_COL);
AlignPage($binder15);
AddCards($binder15, $HGSS_REVERSE_SCRATCH_HOLO);

$hgssReverseBinders = array(&$binder15, &$binder16);
SplitCards($hgssReverseBinders, $HGSS_REVERSE_MIRROR_HOLO);

AlignBinder($binder15);
AlignBinder($binder16);

AddCards($binder17, $BWXY_TINSEL_HOLO);
AlignPage($binder17);
AddCards($binder17, $BWXY_TINSEL_HOLO_PLASMA);
AlignPage($binder17);
AddCards($binder17, $BWXY_MIRROR_HOLO);
AlignPage($binder17);
AddCards($binder17, $BWXY_CRACKED_ICE_HOLO);
AlignPage($binder17);
AddCards($binder17, $BWXY_CRACKED_ICE_HOLO_PLASMA);
AlignPage($binder17);
AddCards($binder17, $BWXY_CONFETTI_HOLO);
AlignBinder($binder17);

AddCards($binder18, $BWXY_SHEEN_HOLO);
AlignPage($binder18);
AddCards($binder18, $BWXY_SHEEN_HOLO_AQUA);
AlignRow($binder18);
AddCards($binder18, $BWXY_SHEEN_HOLO_MAGMA);
AlignRow($binder18);
AddCards($binder18, $BWXY_SHEEN_HOLO_FLARE);
AlignPage($binder18);
AddCards($binder18, $BWXY_MIRROR_HOLO_ENERGY);
AlignPage($binder18);
AddCards($binder18, $BWXY_SCRATCH_HOLO_ENERGY_BW);
AlignPage($binder18);
AddCards($binder18, $BWXY_SCRATCH_HOLO_ENERGY);
AlignPage($binder18);
AddCards($binder18, $BWXY_SHEEN_HOLO_ENERGY);
AlignPage($binder18);
AddCards($binder18, $BWXY_MIRROR_HOLO_ENERGY_GENERATIONS);
AlignPage($binder18);
AddCards($binder18, $BWXY_REVERSE_SCRATCH_HOLO);
AlignRow($binder18);
AddCards($binder18, $BWXY_REVERSE_SCRATCH_HOLO_PLASMA);
AlignBinder($binder18);

AddCards($binder19, $BWXY_COSMOS_HOLO);
AlignPage($binder19);
AddCards($binder19, $BWXY_COSMOS_HOLO_PLASMA);
AlignBinder($binder19);

AddCards($binder20, $BWXY_REVERSE_MIRROR_HOLO);
AlignPage($binder20);
AddCards($binder20, $BWXY_REVERSE_MIRROR_HOLO_PLASMA);
AlignPage($binder20);
AddCards($binder20, $BWXY_REVERSE_MIRROR_HOLO_AQUA);
AlignPage($binder20);
AddCards($binder20, $BWXY_REVERSE_MIRROR_HOLO_MAGMA);
AlignPage($binder20);

$bwxyReverseBinders = array(&$binder20, &$binder21, &$binder22, &$binder23, &$binder24, &$binder25, &$binder26);
SplitCards($bwxyReverseBinders, $BWXY_REVERSE_ENERGY_HOLO);

AlignBinder($binder20);
AlignBinder($binder21);
AlignBinder($binder22);
AlignBinder($binder23);
AlignBinder($binder24);
AlignBinder($binder25);
AlignBinder($binder26);

AddCards($binder27, $EV_STAR_HOLO);
AlignPage($binder27);
AddCards($binder27, $EV_COSMOS_HOLO);
AlignRow($binder27);
AddCards($binder27, $EV_CRACKED_ICE_HOLO);
AlignPage($binder27);
AddCards($binder27, $EV_SHEEN_HOLO);
AlignRow($binder27);
AddCards($binder27, array(-1));
AddCards($binder27, $EV_MIRROR_HOLO);
AlignPage($binder27);
AddCards($binder27, $EV_MIRROR_HOLO_ENERGY);
AlignPage($binder27);
AddCards($binder27, $EV_REVERSE_MIRROR_HOLO);
AlignBinder($binder27);

AddCards($binder28, array(-1));
AlignBinder($binder28);

$markers = CountMarkers($binder1)
	+ CountMarkers($binder2)
	+ CountMarkers($binder3)
	+ CountMarkers($binder4)
	+ CountMarkers($binder5)
	+ CountMarkers($binder6)
	+ CountMarkers($binder7)
	+ CountMarkers($binder8)
	+ CountMarkers($binder9)
	+ CountMarkers($binder10)
	+ CountMarkers($binder11)
	+ CountMarkers($binder12)
	+ CountMarkers($binder13)
	+ CountMarkers($binder14)
	+ CountMarkers($binder15)
	+ CountMarkers($binder16)
	+ CountMarkers($binder17)
	+ CountMarkers($binder18)
	+ CountMarkers($binder19)
	+ CountMarkers($binder20)
	+ CountMarkers($binder21)
	+ CountMarkers($binder22)
	+ CountMarkers($binder23)
	+ CountMarkers($binder24)
	+ CountMarkers($binder25)
	+ CountMarkers($binder26)
	+ CountMarkers($binder27);

print('<h1>Number of VSTAR Markers: '.$markers.'</h1>');

$i = 1;
print('<ul>');
PrintBinderInfo($i++, 'Binder 1 (OS, Neo, LC Holo, e Series Holo) - Free Space: '.CountFree($binder1));
PrintBinderInfo($i++, 'Binder 2 (LC Reverse, e Series Reverse 1) - Free Space: '.CountFree($binder2));
PrintBinderInfo($i++, 'Binder 3 (e Series Reverse 2) - Free Space: '.CountFree($binder3));
PrintBinderInfo($i++, 'Binder 4 (EX) - Free Space: '.CountFree($binder4));
PrintBinderInfo($i++, 'Binder 5 (EX Reverse 1) - Free Space: '.CountFree($binder5));
PrintBinderInfo($i++, 'Binder 6 (EX Reverse 2) - Free Space: '.CountFree($binder6));
PrintBinderInfo($i++, 'Binder 7 (EX Reverse 3) - Free Space: '.CountFree($binder7));
PrintBinderInfo($i++, 'Binder 8 (EX Reverse 4) - Free Space: '.CountFree($binder8));
PrintBinderInfo($i++, 'Binder 9 (EX Reverse 5) - Free Space: '.CountFree($binder9));
PrintBinderInfo($i++, 'Binder 10 (DPPt) - Free Space: '.CountFree($binder10));
PrintBinderInfo($i++, 'Binder 11 (DPPt Reverse 1) - Free Space: '.CountFree($binder11));
PrintBinderInfo($i++, 'Binder 12 (DPPt Reverse 2) - Free Space: '.CountFree($binder12));
PrintBinderInfo($i++, 'Binder 13 (DPPt Reverse 3) - Free Space: '.CountFree($binder13));
PrintBinderInfo($i++, 'Binder 14 (DPPt Reverse 4) - Free Space: '.CountFree($binder14));
PrintBinderInfo($i++, 'Binder 15 (HGSS, HGSS Reverse 1) - Free Space: '.CountFree($binder15));
PrintBinderInfo($i++, 'Binder 16 (HGSS Reverse 2) - Free Space: '.CountFree($binder16));
PrintBinderInfo($i++, 'Binder 17 (BWXY Holo 1) - Free Space: '.CountFree($binder17));
PrintBinderInfo($i++, 'Binder 18 (BWXY Holo 2) - Free Space: '.CountFree($binder18));
PrintBinderInfo($i++, 'Binder 19 (BWXY Holo 3) - Free Space: '.CountFree($binder19));
PrintBinderInfo($i++, 'Binder 20 (BWXY Reverse 1) - Free Space: '.CountFree($binder20));
PrintBinderInfo($i++, 'Binder 21 (BWXY Reverse 2) - Free Space: '.CountFree($binder21));
PrintBinderInfo($i++, 'Binder 22 (BWXY Reverse 3) - Free Space: '.CountFree($binder22));
PrintBinderInfo($i++, 'Binder 23 (BWXY Reverse 4) - Free Space: '.CountFree($binder23));
PrintBinderInfo($i++, 'Binder 24 (BWXY Reverse 5) - Free Space: '.CountFree($binder24));
PrintBinderInfo($i++, 'Binder 25 (BWXY Reverse 6) - Free Space: '.CountFree($binder25));
PrintBinderInfo($i++, 'Binder 26 (BWXY Reverse 7) - Free Space: '.CountFree($binder26));
PrintBinderInfo($i++, 'Binder 27 (TBA) - Free Space: '.CountFree($binder27));
PrintBinderInfo($i++, 'Binder 28 (TBA) - Free Space: '.CountFree($binder28));
print('</ul>');

$i = 1;
PrintBinder($i++, $binder1, 'Binder 1 (OS, Neo, LC, e Series)');
PrintBinder($i++, $binder2, 'Binder 2 (LC Reverse, e Series Reverse 1)');
PrintBinder($i++, $binder3, 'Binder 3 (e Series Reverse 2)');
PrintBinder($i++, $binder4, 'Binder 4 (EX)');
PrintBinder($i++, $binder5, 'Binder 5 (EX Reverse 1)');
PrintBinder($i++, $binder6, 'Binder 6 (EX Reverse 2)');
PrintBinder($i++, $binder7, 'Binder 7 (EX Reverse 3)');
PrintBinder($i++, $binder8, 'Binder 8 (EX Reverse 4)');
PrintBinder($i++, $binder9, 'Binder 9 (EX Reverse 5)');
PrintBinder($i++, $binder10, 'Binder 10 (DPPt)');
PrintBinder($i++, $binder11, 'Binder 11 (DPPt Reverse 1)');
PrintBinder($i++, $binder12, 'Binder 12 (DPPt Reverse 2)');
PrintBinder($i++, $binder13, 'Binder 13 (DPPt Reverse 3)');
PrintBinder($i++, $binder14, 'Binder 14 (DPPt Reverse 4)');
PrintBinder($i++, $binder15, 'Binder 15 (HGSS, HGSS Reverse 1)');
PrintBinder($i++, $binder16, 'Binder 16 (HGSS Reverse 2)');
PrintBinder($i++, $binder17, 'Binder 17 (BWXY Holo 1)');
PrintBinder($i++, $binder18, 'Binder 18 (BWXY Holo 2)');
PrintBinder($i++, $binder19, 'Binder 19 (BWXY Holo 3)');
PrintBinder($i++, $binder20, 'Binder 20 (BWXY Reverse 1)');
PrintBinder($i++, $binder21, 'Binder 21 (BWXY Reverse 2)');
PrintBinder($i++, $binder22, 'Binder 22 (BWXY Reverse 3)');
PrintBinder($i++, $binder23, 'Binder 23 (BWXY Reverse 4)');
PrintBinder($i++, $binder24, 'Binder 24 (BWXY Reverse 5)');
PrintBinder($i++, $binder25, 'Binder 25 (BWXY Reverse 6)');
PrintBinder($i++, $binder26, 'Binder 26 (BWXY Reverse 7)');
PrintBinder($i++, $binder27, 'Binder 27 (TBA)');
PrintBinder($i++, $binder28, 'Binder 28 (TBA)');
?>