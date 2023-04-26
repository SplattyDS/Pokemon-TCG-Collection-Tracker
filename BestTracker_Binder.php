<?php
function PrintBinderInfo($ID, $name)
{
	print('<li><a href="#container-'.$ID.'">'.$name.'</a></li>');
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
	
	// <div id="container-'.$ID.'" class="center">
	print('<table id="container-'.$ID.'">');
	print('<tr><td colspan="2"><h1 class="center">'.$name.'</h1></td></tr>');
	print('<tr><td colspan="2" class="center"><img class="binder" src="images/best_tracker/binder/'.$ID.'.png"></td></tr>');
	
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
	
	print('</table>');
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
	return '<td><img class="'.GetBinderImageClass($id).'" src="images/best_tracker/cards/'.GetImagePrefix($id).$id.'.png"></td>';
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

function Align($binder, $align, $rest = 0, $padNum = -1)
{
	while (count($binder) % $align != $rest)
		array_push($binder, $padNum);
	
	return $binder;
}

function AlignRow($binder)
{
	return Align($binder, 4);
}

function AlignPage($binder)
{
	return Align($binder, 12);
}

function AlignPages($binder)
{
	if (count($binder) == 0) // otherwise the first page may be empty
		return $binder;
	
	return Align($binder, 24, 12);
}

function AlignBinder($binder)
{
	if (count($binder) > 480)
		return array();
	
	$binder = AlignPage($binder);
	return Align($binder, 480, 0, 0);
}

function AddCards($binder, $cards)
{
	return array_merge($binder, $cards);
}

function AddV_Union($binder, $cards)
{
	$cards = Align($cards, 8);
	
	for ($i = 0; $i < count($cards); $i += 8)
	{
		$sortedCards = array($cards[$i + 0], $cards[$i + 1], $cards[$i + 4], $cards[$i + 5], 
		                     $cards[$i + 2], $cards[$i + 3], $cards[$i + 6], $cards[$i + 7],
			                             -1,             -1,             -1,             -1,);
		
		$binder = array_merge($binder, $sortedCards);
	}
	
	return $binder;
}

function CountMarkers($binder)
{
	$amount = 0;
	
	for ($i = 0; $i < count($binder); $i++)
	{
		if ($binder[$i] == -1)
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

$binder0 = AddCards($binder0, $Metal);
$binder0 = AlignPages($binder0);

$binder1 = AddCards($binder1, $Secret);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $Full_Art);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $Japanese_Full_art);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $Gold_Pokemon);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $Ancient_Mew);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $Shining_Neo);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $Crystal_Type);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $ex);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $Gold_Star);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $Unown);
$binder1 = AlignRow($binder1);
$binder1 = AlignBinder($binder1);

$binder2 = AddCards($binder2, $LV_X);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $Shiny_Holo);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $Rotom);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $Arceus);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $Prime);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $LEGEND);
$binder2 = AlignRow($binder2);
$binder2 = AddCards($binder2, $Alph_Lithograph);
$binder2 = AlignRow($binder2);
$binder2 = AddCards($binder2, $Shiny_Legend);
$binder2 = AlignPage($binder2);
$binder2 = AddCards($binder2, $EX);
$binder2 = AddCards($binder2, $M_EX);
$binder2 = AlignBinder($binder2);

$binder3 = AddCards($binder3, $Ace_Spec);
$binder3 = AddCards($binder3, $BREAK);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Ancient_Trait_Alpha);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Ancient_Trait_Omega);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Ancient_Trait_Delta);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Ancient_Trait_Theta);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Radiant_Collection);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Full_Art_Trainer_BW_XY);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $Full_Art_Trainer_Evolutions);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_Full_Art);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $M_EX_Full_Art);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_Full_Art_Plasma);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_Full_Art_Radiant);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $M_EX_Full_Art_Radiant);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_Full_Art_Special);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_Special_Art);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $M_EX_Special_Art);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $Secret_M_EX);
$binder3 = AlignBinder($binder3);

$binder4 = AddCards($binder4, $GX);
$binder4 = AlignPage($binder4);
$binder4 = AddCards($binder4, $UB_GX);
$binder4 = AlignPage($binder4);
$binder4 = AddCards($binder4, $TT_GX);
$binder4 = AlignRow($binder4);
$binder4 = AddCards($binder4, $TT_UB_GX);
$binder4 = AlignPage($binder4);
$binder4 = AddCards($binder4, $Shining_SM);
$binder4 = AlignPage($binder4);
$binder4 = AddCards($binder4, $Prism_Star);
$binder4 = AddCards($binder4, $Shiny_Vault_SM);
$binder4 = AddCards($binder4, $Full_Art_Trainer_SM);
$binder4 = AlignBinder($binder4);

$binder5 = AddCards($binder5, $GX_Full_Art);
$binder5 = AddCards($binder5, $UB_GX_Full_Art);
$binder5 = AddCards($binder5, $TT_GX_Full_Art);
$binder5 = AddCards($binder5, $TT_UB_GX_Full_Art);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $GX_Shiny_Full_Art);
$binder5 = AddCards($binder5, $UB_GX_Shiny_Full_Art);
$binder5 = AlignRow($binder5);
$binder5 = AddCards($binder5, $GX_Special_Art);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $TT_GX_Special_Art);
$binder5 = AddCards($binder5, $TT_UB_GX_Special_Art);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $Character_Art_SM);
$binder5 = AddCards($binder5, $Gold_Item_SM);
$binder5 = AddCards($binder5, $Gold_Stadium_SM);
$binder5 = AddCards($binder5, $Gold_Energy_SM);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $Gold_Special_Energy_SM);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $GX_Gold);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $TT_GX_Gold);
$binder5 = AlignBinder($binder5);

$binder6 = AddCards($binder6, $V);
$binder6 = AlignPage($binder6);
$binder6 = AddCards($binder6, $VMAX);
$binder6 = AlignPage($binder6);
$binder6 = AddCards($binder6, $VSTAR);
$binder6 = AlignBinder($binder6);

$binder7 = AddV_Union($binder7, $V_Union);
$binder7 = AddCards($binder7, $Amazing_Rare);
$binder7 = AddCards($binder7, $Radiant);
$binder7 = AddCards($binder7, $Shiny_Vault_SWSH);
$binder7 = AddCards($binder7, $Classic_Collection);
$binder7 = AlignPage($binder7);
$binder7 = AddCards($binder7, $Full_Art_Trainer_SWSH);
$binder7 = AlignPage($binder7);
$binder7 = AddCards($binder7, $Full_Art_Energy_SWSH);
$binder7 = AlignBinder($binder7);

$binder8 = AddCards($binder8, $V_Full_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $V_Shiny_Full_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $VMAX_Shiny_Full_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $Special_Art_Trainer_SWSH);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $Special_Art_Pokemon_SWSH);
$binder8 = AlignRow($binder8);
$binder8 = AddCards($binder8, $V_Special_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $VMAX_Special_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $VSTAR_Special_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $Character_Art_SWSH);
$binder8 = AlignPage($binder8);
$binder8 = AddCards($binder8, $V_Character_Art);
$binder8 = AlignRow($binder8);
$binder8 = AddCards($binder8, $VMAX_Character_Art);
$binder8 = AlignPage($binder8);
$binder8 = AddV_Union($binder8, $V_UNION_Character_Art);
$binder8 = AlignBinder($binder8);

$binder9 = AddCards($binder9, $Gold_Item_SWSH);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $Gold_Stadium_SWSH);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $Gold_Energy_SWSH);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $Gold_Special_Energy_SWSH);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $Gold_Shiny);
$binder9 = AddCards($binder9, $V_Gold);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $VSTAR_Gold);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $V_VMAX_Gold);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $VSTAR_Gold_Special_Art);
$binder9 = AlignPage($binder9);
$binder9 = AddCards($binder9, $GX_Rainbow);
$binder9 = AddCards($binder9, $UB_GX_Rainbow);
$binder9 = AlignRow($binder9);
$binder9 = AddCards($binder9, $TT_GX_Rainbow);
$binder9 = AddCards($binder9, $TT_UB_GX_Rainbow);
$binder9 = AlignRow($binder9);
$binder9 = AddCards($binder9, $Rainbow_Trainer);
$binder9 = AlignRow($binder9);
$binder9 = AddCards($binder9, $VMAX_Rainbow);
$binder9 = AlignRow($binder9);
$binder9 = AddCards($binder9, $VSTAR_Rainbow);
$binder9 = AlignBinder($binder9);

$binder10 = AddCards($binder10, $ex_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $ex_SV_Tera);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $Full_Art_Trainer_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $ex_SV_Full_Art);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $ex_SV_Tera_Full_Art);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $Special_Art_Trainer_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $Special_Art_Pokemon_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $ex_SV_Special_Art);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $Gold_Item_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $Gold_Energy_SV);
$binder10 = AlignPages($binder10);
$binder10 = AddCards($binder10, $ex_SV_Gold);
$binder10 = AlignPages($binder10);
$binder10 = AlignBinder($binder10);

$markers = CountMarkers($binder1) + CountMarkers($binder2) + CountMarkers($binder3) + CountMarkers($binder4) + CountMarkers($binder5) + CountMarkers($binder6) + CountMarkers($binder7) + CountMarkers($binder8) + CountMarkers($binder9);

print('<h1>Number of VSTAR Markers: '.$markers.'</h1>');

$i = 0;
print('<ul>');
PrintBinderInfo($i++, 'Not in a Binder');
PrintBinderInfo($i++, 'Binder 1 (General, Gen 1-3)');
PrintBinderInfo($i++, 'Binder 2 (Gen 4, Gen 5.1 & 6.1)');
PrintBinderInfo($i++, 'Binder 3 (Gen 5.2 & 6.2)');
PrintBinderInfo($i++, 'Binder 4 (Gen 7.1)');
PrintBinderInfo($i++, 'Binder 5 (Gen 7.2)');
PrintBinderInfo($i++, 'Binder 6 (Gen 8.1)');
PrintBinderInfo($i++, 'Binder 7 (Gen 8.2)');
PrintBinderInfo($i++, 'Binder 8 (Gen 8.3)');
PrintBinderInfo($i++, 'Binder 9 (Gen 8.4, Rainbow)');
PrintBinderInfo($i++, 'Binder 10 (Gen 9) - Ongoing');
print('</ul>');

$i = 0;
PrintBinder($i++, $binder0, 'Not in a Binder', 1);
PrintBinder($i++, $binder1, 'Binder 1 (General, Gen 1-3)');
PrintBinder($i++, $binder2, 'Binder 2 (Gen 4, Gen 5.1 & 6.1)');
PrintBinder($i++, $binder3, 'Binder 3 (Gen 5.2 & 6.2)');
PrintBinder($i++, $binder4, 'Binder 4 (Gen 7.1)');
PrintBinder($i++, $binder5, 'Binder 5 (Gen 7.2)');
PrintBinder($i++, $binder6, 'Binder 6 (Gen 8.1)');
PrintBinder($i++, $binder7, 'Binder 7 (Gen 8.2)');
PrintBinder($i++, $binder8, 'Binder 8 (Gen 8.3)');
PrintBinder($i++, $binder9, 'Binder 9 (Gen 8.4, Rainbow)');
PrintBinder($i++, $binder10, 'Binder 10 (Gen 9) - Ongoing');
?>