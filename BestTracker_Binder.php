<?php
function PrintBinderInfo($ID, $name)
{
	print('<li><a href="BestTracker.php?binder='.$ID.'">'.$name.'</a></li>');
}

function PrintBinder($ID, $binder, $name, $numPages = 40)
{
	if (isset($_GET['noimg']))
	{
		print('<div id="container-'.$ID.'">');
		print('<h1 class="center">'.$name.'</h1>');
		print('<div class="center"><img class="binder" src="images/best_tracker/binder/'.$ID.'.png"></div>');
		print('</div>');
		return;
	}
	
	print('<h1 id="binder-'.$ID.'" class="center" onclick="toggleSection(this, '.$ID.')">'.$name.'</h1>');
	print('<div class="center"><img class="binder" src="images/best_tracker/binder/'.$ID.'.png" onclick="toggleSection(this, '.$ID.')"></div>');
	
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
	return '<td><img class="'.GetBinderImageClass($id).'" data-src="images/best_tracker/cards/'.GetImagePrefix($id).$id.'.png"></td>';
}

function GetBinderImageClass($id)
{
	global $have;
	
	if ($id <= 0)
		return 'no-style';
	
	return in_array($id, $have, true) ? 'have' : 'not-have';
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

function AddV_Union(&$binder, $cards)
{
	Align($cards, 8);
	
	for ($i = 0; $i < count($cards); $i += 8)
	{
		$sortedCards = array($cards[$i + 0], $cards[$i + 1], $cards[$i + 4], $cards[$i + 5], 
		                     $cards[$i + 2], $cards[$i + 3], $cards[$i + 6], $cards[$i + 7],
			                             -1,             -1,             -1,             -1,);
		
		$binder = array_merge($binder, $sortedCards);
	}
}

function AddRows(&$binder, $cardsRow1, $cardsRow2, $cardsRow3, $padCols = 0)
{
	$count = count($binder);
	
	if ($count % 12 != 0)
	{
		print('AddRows: binder not aligned to 12.<br>');
		return;
	}
	else if ($count >= 480)
	{
		print('AddRows: binder is full.<br>');
		return;
	}
	else if ($padCols > 3)
	{
		print('AddRows: $padCols cannot be bigger than 3, was '.$padCols.'.<br>');
		return;
	}
	
	$maxRowLength = ($count == 0 || $count == 468) ? 4 : 8;
	
	if (count($cardsRow1) + $padCols > $maxRowLength)
	{
		print('AddRows: row 1 was '.(count($cardsRow1) + $padCols).', max is '.$maxRowLength.'<br>');
		return;
	}
	else if (count($cardsRow2) + $padCols > $maxRowLength)
	{
		print('AddRows: row 2 was '.(count($cardsRow2) + $padCols).', max is '.$maxRowLength.'<br>');
		return;
	}
	else if (count($cardsRow3) + $padCols > $maxRowLength)
	{
		print('AddRows: row 3 was '.(count($cardsRow3) + $padCols).', max is '.$maxRowLength.'<br>');
		return;
	}
	
	$padArr = array();
	for ($i = 0; $i < $padCols; $i++)
		array_push($padArr, -1);
	
	$offset = 0;
	$length = 4 - $padCols;
	
	$binder = array_merge($binder, $padArr);
	$binder = array_merge($binder, array_slice($cardsRow1, $offset, $length));
	AlignRow($binder);
	$binder = array_merge($binder, $padArr);
	$binder = array_merge($binder, array_slice($cardsRow2, $offset, $length));
	AlignRow($binder);
	$binder = array_merge($binder, $padArr);
	$binder = array_merge($binder, array_slice($cardsRow3, $offset, $length));
	AlignRow($binder);
	
	if ($maxRowLength != 4)
	{
		$offset = 4 - $padCols;
		$length = 4;
		
		$binder = array_merge($binder, array_slice($cardsRow1, $offset, $length));
		AlignRow($binder);
		$binder = array_merge($binder, array_slice($cardsRow2, $offset, $length));
		AlignRow($binder);
		$binder = array_merge($binder, array_slice($cardsRow3, $offset, $length));
		AlignRow($binder);
	}
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
		return 480;
	
	if (count($binder) < 480)
		return 480 - count($binder);
	
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
	global $have;
	
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] != 0 && $binder[$i] != -1 && in_array($binder[$i], $have, true))
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
// $binder11 = array();

AddCards($binder0, $Metal);
AlignBinder($binder0);

AddCards($binder1, $Secret);
AlignPage($binder1);
AddCards($binder1, $Full_Art);
AlignPage($binder1);
AddCards($binder1, $Japanese_Full_art);
AlignPage($binder1);
AddCards($binder1, $Gold_Pokemon);
AlignRow($binder1);
AddCards($binder1, $Ancient_Mew);
AlignPage($binder1);
AddCards($binder1, $Shining_Neo);
AlignRow($binder1);
AddCards($binder1, $Crystal_Type);
AlignRow($binder1);
AddCards($binder1, $ex);
AlignRow($binder1);
AddCards($binder1, $Gold_Star);
AlignRow($binder1);
AddCards($binder1, $Unown);
AlignPage($binder1);
AddRows($binder1, $Holo_Energy_EX_Emerald, $Holo_Energy_EX_Holon_Phantoms, $Holo_Energy_EX_Power_Keepers, 1);
AlignBinder($binder1);

AddCards($binder2, $LV_X);
AlignPage($binder2);
AddCards($binder2, $Shiny_Holo);
AlignPage($binder2);
AddCards($binder2, $Rotom);
AlignPage($binder2);
AddCards($binder2, $Arceus);
AlignPage($binder2);
AddCards($binder2, $Prime);
AlignPage($binder2);
AddCards($binder2, $LEGEND);
AlignRow($binder2);
AddCards($binder2, $Alph_Lithograph);
AlignRow($binder2);
AddCards($binder2, $Shiny_Legend);
AlignPage($binder2);
AddCards($binder2, $EX);
AddCards($binder2, $M_EX);
AlignBinder($binder2);

AddCards($binder3, $Ace_Spec);
AlignRow($binder3);
AddCards($binder3, $Mirrored_Stadium);
AlignPage($binder3);
AddCards($binder3, $BREAK);
AlignRow($binder3);
AddCards($binder3, $Ancient_Trait_Alpha);
AlignPage($binder3);
AddCards($binder3, $Ancient_Trait_Omega);
AlignPage($binder3);
AddCards($binder3, $Ancient_Trait_Delta);
AlignPage($binder3);
AddCards($binder3, $Ancient_Trait_Theta);
AlignPage($binder3);
AddCards($binder3, $Radiant_Collection);
AlignPage($binder3);
AddCards($binder3, $Full_Art_Trainer_BW_XY);
AlignRow($binder3);
AddCards($binder3, $Full_Art_Trainer_Evolutions);
AlignPage($binder3);
AddCards($binder3, $EX_Full_Art);
AlignRow($binder3);
AddCards($binder3, $M_EX_Full_Art);
AlignPage($binder3);
AddCards($binder3, $EX_Full_Art_Plasma);
AlignPage($binder3);
AddCards($binder3, $EX_Full_Art_Radiant);
AlignRow($binder3);
AddCards($binder3, $M_EX_Full_Art_Radiant);
AlignPage($binder3);
AddCards($binder3, $EX_Full_Art_Special);
AlignPage($binder3);
AddCards($binder3, $EX_Special_Art);
AlignRow($binder3);
AddCards($binder3, $M_EX_Special_Art);
AlignPage($binder3);
AddCards($binder3, $Secret_M_EX);
AlignBinder($binder3);

AddCards($binder4, $GX);
AlignPage($binder4);
AddCards($binder4, $UB_GX);
AlignPage($binder4);
AddCards($binder4, $TT_GX);
AlignRow($binder4);
AddCards($binder4, $TT_UB_GX);
AlignPage($binder4);
AddCards($binder4, $Shining_SM);
AlignPage($binder4);
AddCards($binder4, $Prism_Star);
AddCards($binder4, $Shiny_Vault_SM);
AddCards($binder4, $Full_Art_Trainer_SM);
AlignBinder($binder4);

AddCards($binder5, $GX_Full_Art);
AddCards($binder5, $UB_GX_Full_Art);
AddCards($binder5, $TT_GX_Full_Art);
AddCards($binder5, $TT_UB_GX_Full_Art);
AlignPage($binder5);
AddCards($binder5, $GX_Shiny_Full_Art);
AddCards($binder5, $UB_GX_Shiny_Full_Art);
AlignRow($binder5);
AddCards($binder5, $GX_Special_Art);
AlignPage($binder5);
AddCards($binder5, $TT_GX_Special_Art);
AddCards($binder5, $TT_UB_GX_Special_Art);
AlignPage($binder5);
AddCards($binder5, $Character_Art_SM);
AddCards($binder5, $Gold_Item_SM);
AddCards($binder5, $Gold_Stadium_SM);
AddCards($binder5, $Gold_Energy_SM);
AlignPage($binder5);
AddCards($binder5, $Gold_Special_Energy_SM);
AlignPage($binder5);
AddCards($binder5, $GX_Gold);
AlignPage($binder5);
AddCards($binder5, $TT_GX_Gold);
AlignBinder($binder5);

AddCards($binder6, $V);
AlignPages($binder6);
AddCards($binder6, $VMAX);
AddCards($binder6, $VMAX_Blue);
AddCards($binder6, $VMAX_Gigantamax);
AddCards($binder6, $VMAX_Eternamax);
AlignPage($binder6);
AddCards($binder6, $VSTAR);
AlignBinder($binder6);

AddV_Union($binder7, $V_Union);
AddCards($binder7, $Amazing_Rare);
AddCards($binder7, $Radiant);
AddCards($binder7, $Shiny_Vault_SWSH);
AddCards($binder7, $Classic_Collection);
AlignPage($binder7);
AddCards($binder7, $Full_Art_Trainer_SWSH);
AlignPage($binder7);
AddCards($binder7, $Full_Art_Energy_SWSH);
AlignBinder($binder7);

AddCards($binder8, $V_Full_Art);
AlignPage($binder8);
AddCards($binder8, $V_Shiny_Full_Art);
AlignPage($binder8);
AddCards($binder8, $VMAX_Shiny_Full_Art);
AlignPage($binder8);
AddCards($binder8, $Special_Art_Trainer_SWSH);
AlignPage($binder8);
AddCards($binder8, $Special_Art_Pokemon_SWSH);
AlignRow($binder8);
AddCards($binder8, $V_Special_Art);
AlignPage($binder8);
AddCards($binder8, $VMAX_Special_Art);
AlignPage($binder8);
AddCards($binder8, $VSTAR_Special_Art);
AlignPage($binder8);
AddCards($binder8, $Character_Art_SWSH);
AlignPage($binder8);
AddCards($binder8, $V_Character_Art);
AlignRow($binder8);
AddCards($binder8, $VMAX_Character_Art);
AlignPage($binder8);
AddV_Union($binder8, $V_UNION_Character_Art);
AlignBinder($binder8);

AddCards($binder9, $Gold_Item_SWSH);
AlignPage($binder9);
AddCards($binder9, $Gold_Stadium_SWSH);
AlignPage($binder9);
AddCards($binder9, $Gold_Energy_SWSH);
AlignPage($binder9);
AddCards($binder9, $Gold_Special_Energy_SWSH);
AlignPage($binder9);
AddCards($binder9, $Gold_Shiny);
AddCards($binder9, $V_Gold);
AlignPage($binder9);
AddCards($binder9, $VSTAR_Gold);
AlignPage($binder9);
AddCards($binder9, $V_VMAX_Gold);
AlignPage($binder9);
AddCards($binder9, $VSTAR_Gold_Special_Art);
AlignPage($binder9);
AddCards($binder9, $GX_Rainbow);
AddCards($binder9, $UB_GX_Rainbow);
AlignRow($binder9);
AddCards($binder9, $TT_GX_Rainbow);
AddCards($binder9, $TT_UB_GX_Rainbow);
AlignRow($binder9);
AddCards($binder9, $Rainbow_Trainer);
AlignRow($binder9);
AddCards($binder9, $VMAX_Rainbow);
AddCards($binder9, $VMAX_Rainbow_Blue);
AddCards($binder9, $VMAX_Rainbow_Gigantamax);
AddCards($binder9, $VMAX_Rainbow_Eternamax);
AlignRow($binder9);
AddCards($binder9, $VSTAR_Rainbow);
AlignBinder($binder9);

AddCards($binder10, $ex_SV);
AlignPages($binder10);
AddCards($binder10, $ex_SV_Tera);
AlignPages($binder10);
AddCards($binder10, $Full_Art_Trainer_SV);
AlignPages($binder10);
AddCards($binder10, $ex_SV_Full_Art);
AlignPages($binder10);
AddCards($binder10, $ex_SV_Tera_Full_Art);
AlignPages($binder10);
AddCards($binder10, $Special_Art_Trainer_SV);
AlignPages($binder10);
AddCards($binder10, $Special_Art_Pokemon_SV);
AlignPages($binder10);
AddCards($binder10, $ex_SV_Special_Art);
AlignPages($binder10);
AddCards($binder10, $Gold_Item_SV);
AlignPages($binder10);
AddCards($binder10, $Gold_Energy_SV);
AlignPages($binder10);
AddCards($binder10, $ex_SV_Gold);
AlignPages($binder10);
AlignBinder($binder10);

// AddCards($binder11, array(-1));
// AlignBinder($binder11);

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
	// &$binder11,
);

$markers = 0;

for ($i = 0; $i < count($binders); $i++)
	$markers += CountMarkers($binders[$i]);

$binderContents = array
(
	'Not in a Binder',
	'General, Gen 1-3',
	'Gen 4, Gen 5.1 & 6.1',
	'Gen 5.2 & 6.2',
	'Gen 7.1',
	'Gen 7.2',
	'Gen 8.1',
	'Gen 8.2',
	'Gen 8.3',
	'Gen 8.4, Rainbow',
	'Gen 9 - Ongoing',
	// 'TBA',
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