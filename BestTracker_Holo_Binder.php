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
		print('<div class="center"><img class="binder" src="images/best_tracker/binder/holo.png"></div>');
		print('</div>');
		return;
	}
	
	// <div id="container-'.$ID.'" class="center">
	print('<table id="container-'.$ID.'">');
	print('<tr><td colspan="2"><h1 class="center">'.$name.'</h1></td></tr>');
	print('<tr><td colspan="2" class="center"><img class="binder" src="images/best_tracker/binder/holo.png"></td></tr>');
	
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
	return '<td><img class="'.GetBinderImageClass($id).'" src="images/best_tracker/holo/'.GetImagePrefix($id).$id.'.png"></td>';
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

$binder1 = AddCards($binder1, $OS_STAR_HOLO);
$binder1 = AddCards($binder1, $OS_COSMOS_HOLO);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $OS_REVERSE_COSMOS_HOLO);
$binder1 = AlignRow($binder1);
$binder1 = AddCards($binder1, $OS_COSMOS_HOLO_ENERGY);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $NEO_COSMOS_HOLO);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $NEO_REVERSE_COSMOS_HOLO);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $LC_STAR_HOLO);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $LC_REVERSE_SILVER_FIREWORKS_HOLO);
$binder1 = AlignPage($binder1);
$binder1 = AddCards($binder1, $E_COSMOS_HOLO);
$binder1 = AlignBinder($binder1);

$binder2 = AddCards($binder2, $E_REVERSE_REFRACTOR_HOLO);
$binder2 = AlignBinder($binder2);

$binder3 = AddCards($binder3, $EX_COSMOS_HOLO);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $EX_COSMOS_HOLO_VICTORY_MEDAL);
$binder3 = AlignRow($binder3);
$binder3 = AddCards($binder3, $EX_COSMOS_HOLO_DELTA);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_VERTICAL_REFRACTOR_HOLO_DELTA);
$binder3 = AlignPage($binder3);
$binder3 = AddCards($binder3, $EX_PIXEL_WAVE_HOLO_ENERGY);
$binder3 = AlignBinder($binder3);

$binder4 = AddCards($binder4, $EX_REVERSE_REFRACTOR_HOLO);
$binder4 = AlignPage($binder4);
$binder4 = AddCards($binder4, $EX_BIG_ENERGY_HOLO_HL);
$binder4 = AlignBinder($binder4);

$binder5 = AddCards($binder5, $EX_ENERGY_HOLO_FL);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $EX_ENERGY_HOLO_TRR);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $EX_PRISM_HOLO_D);
$binder5 = AlignPage($binder5);
$binder5 = AddCards($binder5, $EX_2D_POKEBALL_HOLO_E);
$binder5 = AlignBinder($binder5);

$binder6 = AddCards($binder6, $EX_3D_POKEBALL_HOLO_UF);
$binder6 = AlignPage($binder6);
$binder6 = AddCards($binder6, $EX_REFRACTOR_HOLO_DS);
$binder6 = AlignPage($binder6);
$binder6 = AddCards($binder6, $EX_COSMOS_HOLO_LM);
$binder6 = AlignPage($binder6);
$binder6 = AddCards($binder6, $EX_REFRACTOR_HOLO_HP);
$binder6 = AlignBinder($binder6);

$binder7 = AddCards($binder7, $EX_REFRACTOR_HOLO_CG);
$binder7 = AlignPage($binder7);
$binder7 = AddCards($binder7, $EX_REFRACTOR_HOLO_DF);
$binder7 = AlignPage($binder7);
$binder7 = AddCards($binder7, $EX_REFRACTOR_HOLO_PK);
$binder7 = AlignBinder($binder7);

$binder8 = AlignBinder($binder8);

$binder9 = AlignBinder($binder9);

$binder10 = AlignBinder($binder10);

$markers = CountMarkers($binder1) + CountMarkers($binder2) + CountMarkers($binder3) + CountMarkers($binder4) + CountMarkers($binder5) + CountMarkers($binder6) + CountMarkers($binder7) + CountMarkers($binder8) + CountMarkers($binder9);

print('<h1>Number of VSTAR Markers: '.$markers.'</h1>');

$i = 1;
print('<ul>');
PrintBinderInfo($i++, 'Binder 1 (OS, Neo, e Series)');
PrintBinderInfo($i++, 'Binder 2 (e Series Reverse)');
PrintBinderInfo($i++, 'Binder 3 (EX)');
PrintBinderInfo($i++, 'Binder 4 (EX Reverse 1)');
PrintBinderInfo($i++, 'Binder 5 (EX Reverse 2)');
PrintBinderInfo($i++, 'Binder 6 (EX Reverse 3)');
PrintBinderInfo($i++, 'Binder 7 (EX Reverse 4)');
// PrintBinderInfo($i++, 'Binder 8 ()');
// PrintBinderInfo($i++, 'Binder 9 ()');
// PrintBinderInfo($i++, 'Binder 10 ()');
print('</ul>');

$i = 1;
PrintBinder($i++, $binder1, 'Binder 1 ()');
PrintBinder($i++, $binder2, 'Binder 2 ()');
PrintBinder($i++, $binder3, 'Binder 3 ()');
PrintBinder($i++, $binder4, 'Binder 4 ()');
PrintBinder($i++, $binder5, 'Binder 5 ()');
PrintBinder($i++, $binder6, 'Binder 6 ()');
PrintBinder($i++, $binder7, 'Binder 7 ()');
// PrintBinder($i++, $binder8, 'Binder 8 ()');
// PrintBinder($i++, $binder9, 'Binder 9 ()');
// PrintBinder($i++, $binder10, 'Binder 10 ()');
?>