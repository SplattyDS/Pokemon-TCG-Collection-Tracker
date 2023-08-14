<?php
$Grass = array(4,33,49,55,58,70,81,99,102,116,132,143,182,208,210,249,262,286,287,290,291,324,330,335,343,356,366,399,405,423,433,439,445,482,487,497,551,552,561,562,567,568,3225,3226,3227,586,607,608,615,639,640,646,653,673,2961,674,703,725,2979,758,759,760,2990,777,778,794,846,847,848,3244,3245,895,918,919,934,943,952,956,969,1000,1010,1014,1022,1030,1036,1037,1072,1073,1083,1095,1136,1160,1172,1173,1191,1192,1213,1263,1276,1277,1294,1295,1352,1366,1383,1420,1421,1422,1423,1440,1441,1442,1460,1461,1462,1482,1483,1497,1520,1535,1536,1549,1550,1551,1573,1574,1593,1610,1611,1633,1655,1668,1669,1670,1671,1672,1713,1714,1715,1758,1762,1763,1778,1779,1817,1818,1844,1849,1853,1858,1860,1866,1887,1892,1919,3211,1942,1943,1963,1993,1994,1995,2016,2017,2034,2051,2052,2072,2085,2092,2097,2098,2123,2124,2125,2126,2146,2147,2166,2184,2185,2211,2212,2213,2214,2215,2216,2217,2218,2219,2220,2221,2222,2223,2224,2315,2316,2333,2334,2335,2351,2352,2373,2393,2394,2416,2455,2490,2491,2492,2493,2523,2524,2525,2561,2562,2563,2606,2629,2630,2631,2632,2633,2656,2657,2696,2697,2698,2723,2744,2788,2789,2790,2819,2820,2821,2822,2823,2849,2876,2877,2906,2907,2918,3291,3337,3338,3348,3349,3404,3405,3406,3407,3429,3430,3455,3469,3486,3487,3505,3506,3542,3543,3572,3573,3576,3003,3027,3029,3037,3039,3092,3093,3111,3399,3400,3645,3657,3658,3659,3660,3681,3701,3726,3727,3742,3743,3744,3745,3746,3779,3780,3804,3805,3819,3866,3867,3887,3829);
start($j++, 'Grass', $have, $Grass);
foreach ($Grass as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Fire = array(3223,5,31,40,48,51,52,53,54,56,66,74,82,84,98,100,117,130,136,139,172,179,193,212,214,229,241,235,2940,3132,248,252,272,276,277,278,293,299,313,314,320,332,336,344,353,357,367,368,369,413,415,424,426,428,434,440,446,451,455,461,470,2946,476,510,2951,511,521,526,529,537,571,572,583,3228,3229,587,591,621,622,2958,623,629,636,675,2962,676,2963,677,704,761,2991,762,2992,795,796,808,809,820,849,850,851,3246,3247,3248,860,862,867,896,897,898,908,916,920,921,922,935,951,953,957,970,985,997,1016,1020,1034,1043,1046,1050,1052,1070,3146,1074,1109,1121,1137,1138,1161,1162,1163,1174,1175,1193,1194,1214,1223,1226,1353,1367,1384,1398,1399,1406,1412,1424,1425,1443,1444,1463,1464,1537,1552,1575,1594,1612,1634,1656,1673,1674,1716,1717,1718,1719,1764,1765,1780,1781,1805,1819,1820,1850,1854,1857,1859,1864,1867,1883,1895,1908,1911,1913,1920,3090,1933,1944,1945,1964,1996,1997,1998,2018,2019,2035,2053,2054,2055,2056,2057,2073,2074,2086,2099,2116,2121,2127,2148,2186,2187,2188,2225,2226,2227,2228,2229,2317,2318,2319,2336,2337,2353,2374,2395,2396,2397,2417,2418,2456,2457,2494,2495,2526,2527,2605,2617,2623,2634,2635,2636,2637,2638,2658,2676,2699,2700,2701,2702,2724,2725,2745,2758,2791,2792,2793,2824,2850,2908,3269,3292,3339,3340,3350,3351,3408,3431,3475,3488,3489,3507,3508,3509,3510,3511,3544,3545,3577,3578,3004,3016,3041,3053,3066,3084,3085,3368,3376,3377,3378,3661,3728,3729,3747,3748,3749,3750,3781,3782,3806,3807,3820,3868,3888,3830,3837);
start($j++, 'Fire', $have, $Fire);
foreach ($Fire as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Water = array(2,3,30,38,41,45,59,64,67,73,78,83,97,121,123,129,133,141,174,176,178,185,186,190,203,206,209,215,217,220,228,231,239,2941,242,244,247,259,261,285,295,319,322,337,345,348,3138,365,370,371,372,3625,375,416,417,418,421,422,427,441,447,456,462,488,2948,498,512,2952,522,527,545,553,573,574,3230,592,598,609,2956,610,2957,616,641,647,678,2964,679,2965,680,681,2966,682,2967,683,684,705,706,707,723,726,2980,763,2993,2994,2995,764,779,789,797,798,810,811,821,822,823,824,825,826,836,837,838,845,852,853,854,855,3249,3250,868,869,885,899,923,924,925,926,927,936,954,958,962,971,975,986,998,1003,1006,1012,1017,1021,1026,1027,1075,1076,1084,1096,1110,1111,1122,1123,1139,1140,1141,1164,1176,1195,1215,1231,1239,1250,1264,1278,1296,1311,1312,1313,1324,1325,1337,1338,1354,1368,1385,1400,1407,1426,1445,1465,1498,1499,1521,1538,1576,1595,1596,1613,1614,1615,1635,1636,1657,1658,1675,1676,1677,1678,1679,1720,1721,1722,1723,1759,1766,1767,1782,1783,1806,1807,1808,1821,1851,1888,1889,1891,1896,1904,1910,1914,1923,1931,3165,3186,3207,1946,1947,1948,1965,1979,1999,2000,2001,2002,2020,2021,2036,2045,2100,2101,2102,2111,2117,2128,2129,2149,2167,2189,2230,2231,2232,2233,2234,2235,2236,2237,2238,2239,2240,2241,2242,2243,2244,2245,2246,2247,2320,2321,2338,2354,2355,2387,2398,2399,2419,2420,2458,2459,2496,2497,2498,2499,2500,2501,2502,2528,2529,2530,2531,2532,2533,2564,2565,2566,2583,2584,2604,2608,2613,2639,3621,2640,2641,2642,2659,2677,2703,2704,2705,2726,2727,2759,2760,2794,2795,2796,2797,2798,2825,2826,2851,2867,2868,2878,2879,2888,2889,2890,2904,2909,3270,3271,3293,3316,3409,3410,3411,3432,3433,3456,3476,3512,3513,3546,3547,3548,3579,3580,3581,3608,3005,3038,3040,3045,3050,3067,3071,3072,3073,3074,3086,3087,3094,3095,3124,3369,3370,3220,3924,3662,3663,3664,3665,3730,3731,3751,3752,3753,3754,3755,3756,3757,3758,3783,3784,3808,3809,3821,3822,3889,3722,3831);
start($j++, 'Water', $have, $Water);
foreach ($Water as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Lightning = array(3224,1,9,28,39,42,57,76,85,107,122,140,173,195,216,218,230,243,250,274,281,288,300,303,304,305,306,307,308,309,310,315,321,333,339,3142,362,376,389,400,403,419,425,429,430,431,442,448,457,463,513,2953,530,538,575,584,3231,588,593,603,611,617,624,630,655,656,663,670,685,2968,686,2969,727,745,765,766,780,781,799,827,856,857,3251,3252,863,944,945,987,995,1023,1044,1056,1061,3145,3147,3148,3149,3151,3152,3153,3154,3155,3159,3160,3161,1112,1113,1124,1125,1142,1143,1216,1227,1232,1240,1251,1279,1297,1355,1369,1386,1427,1446,1466,1484,1485,1486,1500,1501,1522,1523,1539,1553,1577,1597,1616,1617,1637,1659,1680,1681,1724,1725,1760,1809,1810,1845,1852,1862,1870,1877,1881,1884,1893,1897,1915,1921,3091,1937,3163,3200,3201,3204,3205,3206,3209,3218,1949,1950,1951,1966,1980,2003,2004,2005,2006,2022,2023,2037,2058,2075,2130,2131,2132,2133,2150,2151,2168,2190,2191,2248,2249,2250,2251,2252,2253,2254,2255,2256,2322,2323,2339,2340,2356,2375,2400,2421,2422,2478,2503,2504,2505,2534,2535,2567,2595,2596,2597,2598,2599,2610,2611,2620,2624,2643,2644,2645,2660,2678,2691,2706,2707,2728,2729,2761,2762,2770,2799,2827,3272,3273,3274,3294,3295,3296,3317,3341,3352,3353,3365,3412,3413,3434,3457,3477,3490,3514,3515,3717,3516,3517,3518,3222,3549,3550,3571,3575,3582,3583,3584,3006,3009,3018,3020,3021,3022,3030,3056,3057,3058,3059,3060,3062,3068,3088,3089,3096,3104,3105,3106,3107,3108,3373,3379,3380,3381,3385,3390,3391,3392,3393,3394,3395,3221,3648,3649,3666,3667,3684,3685,3702,3711,3732,3733,3759,3785,3871,3872,3890,3638,3643,3828,3720,3834);
start($j++, 'Lightning', $have, $Lightning);
foreach ($Lightning as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Psychic = array(2936,3839,7,3000,32,37,62,77,79,80,103,104,105,118,119,128,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,164,165,166,167,168,169,170,171,181,184,191,194,196,3624,202,204,207,211,222,234,2939,236,237,3126,3130,3133,254,256,264,267,268,270,271,279,280,284,294,297,301,328,340,350,355,374,387,391,401,404,411,443,2944,449,452,467,471,477,483,489,499,506,531,539,546,547,569,576,577,3232,3233,3234,585,589,590,595,602,604,625,631,657,658,664,671,687,2970,688,2971,728,2981,729,2982,730,731,746,747,767,2996,768,2997,769,782,800,801,802,803,812,813,814,815,818,819,828,829,839,858,3253,3254,3255,3256,3257,870,871,886,887,894,928,929,937,966,982,996,999,1007,1009,1019,1024,1025,1028,1035,1038,1047,1049,3150,1077,1078,1085,1086,1097,1098,1114,1115,1126,1127,1144,1145,1165,1177,1196,1217,1218,1219,1224,1228,1230,1233,1241,1252,1265,1266,1267,1280,1298,1309,1314,1326,1339,1356,1357,1370,1371,1387,1388,1428,1447,1467,1487,1488,1502,1503,1524,1540,1554,1555,1578,1598,1599,1600,1601,1618,1619,1638,1639,1660,1682,1683,1684,1685,1686,1726,1727,1728,1729,1730,1761,1768,1769,1784,1785,1811,1812,1813,1822,1823,1843,1847,1855,1873,1875,1879,1905,1909,1917,1918,1925,1928,1938,1940,3164,3166,3167,3168,3187,3188,3189,3195,3210,3212,3213,1952,1953,1967,1968,2007,2008,2024,2038,2059,2103,2104,2105,2106,2107,2112,2113,2118,2134,2152,2192,2201,2210,2257,2258,2259,2260,2261,2262,2263,2264,2265,2266,2267,2268,2269,2270,2271,2272,2324,2341,2342,2357,2358,2401,2402,2403,2423,2424,2425,2426,2427,2428,2460,2461,2506,2507,2508,2509,2510,2536,2537,2538,2539,2540,2541,2568,2569,2585,2600,2603,2616,2625,2628,2646,2647,2661,2662,2679,2680,2681,2708,2709,2710,2711,2712,2730,2731,2746,2752,2763,2764,2765,2771,2772,2773,2774,2800,2801,2828,2829,2852,2880,2881,2891,2892,2893,2905,2910,2911,2919,2926,2933,3275,3276,3297,3342,3343,3354,3366,3414,3415,3416,3417,3418,3435,3436,3437,3458,3459,3478,3479,3480,3491,3519,3520,3521,3551,3552,3553,3554,3555,3569,3585,3586,3587,3588,3589,3010,3017,3028,3033,3034,3042,3048,3051,3052,3054,3075,3076,3077,3078,3099,3100,3109,3115,3119,3382,3383,3384,3387,3832,3403,3650,3651,3668,3669,3670,3671,3672,3686,3687,3703,3760,3761,3762,3763,3764,3765,3788,3810,3873,3875,3891,3641,3723,3835,3840,3841);
start($j++, 'Psychic', $have, $Psychic);
foreach ($Psychic as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Fighting = array(6,29,44,60,63,68,72,106,120,124,175,180,187,198,201,213,240,2942,245,232,2937,251,265,269,273,289,298,323,341,346,351,364,402,414,435,458,464,468,472,478,490,500,507,578,3235,594,642,643,644,648,654,689,2972,690,2973,691,692,708,709,724,770,783,790,804,859,872,873,874,930,963,968,1001,1002,1008,1033,1055,1063,1064,1116,1128,1146,1166,1167,1178,1179,1180,1197,1198,1199,1234,1242,1253,1315,1316,1327,1328,1340,1341,1358,1489,1541,1556,1557,1579,1602,1620,1640,1661,1687,1688,1689,1690,1691,1731,1732,1733,1734,1735,1770,1786,1814,1824,1841,1856,1863,1872,1878,1902,1924,3203,1954,1955,1956,1969,1981,2009,2010,2025,2026,2060,2076,2093,2108,3622,2109,2114,2135,2136,2137,2153,2154,2169,2273,2274,2275,2276,2277,2278,2279,2280,2281,2282,2283,2284,2285,2325,2343,2344,2345,2346,2359,2360,2361,2362,2376,2377,2378,2379,2404,2405,2406,2429,2430,2431,2462,2511,2512,2513,2542,2543,2544,2570,2601,2614,2619,2622,2648,2663,2753,2775,2776,2777,2778,2786,2787,2802,2803,2804,2805,2806,2807,2808,2830,2831,2832,2853,2854,2855,2882,2883,2894,2912,2920,2921,3277,3278,3298,3299,3300,3318,3344,3355,3419,3420,3438,3481,3482,3556,3567,3012,3043,3044,3097,3102,3103,3120,3122,3123,3374,3388,3396,3923,3652,3653,3673,3674,3675,3688,3689,3704,3705,3712,3736,3737,3766,3767,3768,3789,3790,3791,3811,3823,3876,3877,3878,3892,3902,3639,3644,3721,3724);
start($j++, 'Fighting', $have, $Fighting);
foreach ($Fighting as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Darkness = array(11,34,61,86,87,88,89,90,91,92,93,94,95,96,110,114,137,138,142,192,205,219,221,226,233,2938,238,255,257,283,312,334,349,3141,378,388,392,398,453,454,459,2945,465,484,579,3236,596,601,612,618,659,665,693,710,771,772,784,785,805,830,840,3258,875,888,900,949,955,973,977,978,1013,1032,1048,1053,1068,1071,1079,1087,1099,1168,1169,1181,1182,1200,1201,1220,1229,1235,1243,1254,1268,1317,1329,1342,1359,1429,1448,1468,1490,1491,1504,1505,1525,1526,1542,1543,1558,1559,1560,1580,1581,1603,1604,1605,1621,1622,1641,1692,1693,1736,1737,1738,1771,1787,1825,1848,1869,1926,1932,1934,1935,3169,3170,3190,3191,3196,1957,1970,2011,2012,2027,2039,2061,2062,2063,2064,2065,2066,2077,2087,2138,2155,2178,2193,2194,2195,2286,2287,2288,2289,2290,2291,2292,2293,2294,2295,2326,2327,2331,2332,2347,2363,2364,2388,2407,2408,2409,2410,2432,2433,2434,2435,2436,2463,2514,3623,2515,2516,2517,2545,2546,2547,2571,2572,2573,2618,2649,2650,2651,2664,2682,2713,2714,2732,2733,2754,2766,2767,2779,2780,2809,2810,2811,2812,2813,2833,2834,2835,2856,2884,2885,2895,3279,3280,3281,3301,3319,3345,3356,3357,3358,3421,3439,3440,3557,3558,3574,3590,3591,3592,3593,3594,3013,3014,3019,3023,3035,3036,3046,3047,3061,3083,3101,3121,3389,3654,3676,3677,3678,3690,3738,3769,3770,3771,3792,3880,3881,3893,3903);
start($j++, 'Darkness', $have, $Darkness);
foreach ($Darkness as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Metal = array(10,36,65,69,125,134,135,177,188,189,197,224,227,3134,3136,3137,258,266,282,342,347,354,377,390,412,436,473,479,514,523,554,563,613,619,660,661,672,694,695,696,2974,711,712,773,2998,831,832,841,842,876,877,889,901,902,903,909,910,911,959,960,988,1011,1018,1045,1051,1057,1067,3156,1080,1088,1100,1117,1129,1147,1236,1244,1255,1269,1270,1281,1282,1299,1300,1310,1318,1330,1343,1360,1361,1362,1372,1373,1389,1390,1430,1449,1469,1492,1506,1527,1544,1561,1582,1606,1623,1642,1694,1695,1696,1697,1698,1699,1700,1739,1740,1741,1815,1842,1861,1874,1876,1901,1906,1929,1941,3171,3192,3197,1958,1959,1971,1972,1987,1988,2013,2014,2028,2040,2046,2067,2068,2069,2078,2079,2088,2110,2139,2140,2141,2142,2156,2157,2170,2296,2297,2298,2299,2300,2301,2302,2348,2349,2365,2380,2411,2412,2437,2464,2479,2652,2665,2666,2715,2716,2717,2734,2814,2815,2836,2857,2869,2886,2896,2897,2913,2914,2922,2927,3282,3283,3302,3303,3422,3423,3441,3492,3493,3522,3523,3524,3525,3559,3595,3609,3007,3008,3011,3025,3026,3055,3079,3080,3081,3082,3098,3110,3371,3372,3397,3398,3655,3691,3706,3739,3772,3793,3882,3883,3894,3895,3905,3913);
start($j++, 'Metal', $have, $Metal);
foreach ($Metal as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Fairy = array(614,620,662,666,697,2975,698,699,713,714,732,2983,806,833,3259,3260,3261,3262,861,3263,864,865,866,878,879,890,904,905,906,912,913,917,948,964,965,1004,1005,1031,1118,1130,1148,1170,1183,1202,1319,1331,1344,1431,1432,1433,1450,1451,1470,1471,1545,1546,1562,1563,1564,1583,1584,1662,1701,1702,1703,1742,1743,1772,1930,1939,3172,3193,3214,2626);
start($j++, 'Fairy', $have, $Fairy);
foreach ($Fairy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Dragon = array(474,2947,475,480,481,485,486,491,2949,492,2950,501,502,508,515,2954,516,2955,532,533,540,541,548,555,556,564,565,580,581,597,599,600,626,2959,637,645,649,700,2976,733,2984,2985,734,735,736,737,738,748,749,750,774,786,807,880,891,907,950,961,974,976,981,983,984,989,990,991,992,1039,1040,1041,1042,3143,3144,1119,1131,1149,1171,1184,1203,1221,1237,1245,1256,1271,1272,1283,1284,1301,1302,1320,1332,1345,1363,1364,1365,1374,1391,1401,1402,1403,1404,1408,1409,1413,1414,1415,1419,1493,1507,1508,1528,1607,1608,1609,1624,1625,1626,1643,1644,1645,1704,1705,1706,1707,1744,1745,1773,1774,1775,1788,1789,1790,1791,1792,1826,1827,1828,1865,1880,1885,1886,1890,1907,1936,3198,2518,2519,2520,2521,2522,2548,2549,2550,2551,2552,2553,2554,2555,2574,2575,2576,2577,2718,2719,2735,2816,2837,2898,2915,2916,2923,2928,3284,3285,3286,3287,3304,3305,3306,3320,3321,3331,3424,3425,3442,3443,3460,3483,3494,3495,3503,3504,3526,3527,3528,3529,3530,3531,3560,3561,3562,3610,3064,3065,3070,3117,3118,3375,3386,3740,3794);
start($j++, 'Dragon', $have, $Dragon);
foreach ($Dragon as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Colorless = array(3612,3613,8,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,35,43,46,47,50,71,75,108,109,111,112,113,115,126,127,131,183,199,200,223,225,246,3127,3128,3129,3131,3135,260,263,275,292,296,302,316,317,318,325,326,327,329,331,338,352,358,359,2943,360,361,3139,3140,3838,363,379,420,432,438,444,450,460,466,517,524,534,542,582,3237,3238,3239,3240,3241,3242,605,606,627,628,632,638,701,2977,702,2978,739,2986,2987,740,2988,741,742,743,744,2989,751,752,753,775,2999,776,2960,787,791,834,835,843,3264,3265,3266,881,882,883,884,892,931,932,933,938,939,940,946,967,972,979,980,993,994,1015,1029,1058,1081,1082,1089,1090,1101,1102,1120,1132,1150,1222,1238,1246,1257,1273,1321,1434,1435,1452,1472,1494,1509,1529,1547,1548,1565,1566,1585,1586,1663,1664,1667,1708,1709,1710,1711,1712,1746,1747,1776,1777,1793,1794,1795,1816,1829,1830,1840,1846,1868,1871,1882,1894,1898,1899,1900,1903,1912,1916,1922,1927,3194,3199,3208,1960,1961,1962,1973,1974,1982,2015,2029,2070,2071,2080,2089,2143,2144,2145,2158,2171,2179,2196,2197,2198,2199,2200,2303,2304,2305,2306,2307,2308,2309,2310,2311,2312,2313,2314,2328,2329,2330,2350,2366,2413,2414,2415,2438,2439,2440,2441,2465,2480,2612,2621,2627,2653,2654,2655,2667,2668,2683,2720,2721,2722,2736,2737,2747,2755,2768,2769,2817,2818,2838,2839,2887,2917,2924,3288,3289,3290,3307,3322,3332,3346,3347,3426,3427,3428,3444,3445,3446,3461,3470,3484,3485,3496,3532,3533,3534,3535,3536,3563,3564,3565,3566,3568,3570,3596,3597,3611,3001,3002,3015,3024,3031,3032,3125,3116,3401,3402,3833,3718,3719,3925,3656,3679,3680,3692,3741,3773,3774,3775,3776,3777,3795,3812,3885,3896,3897,3898,3906,3914,3642,3836);
start($j++, 'Colorless', $have, $Colorless);
foreach ($Colorless as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();


$Tera_Bug = array(3725,3778);
start($j++, 'Tera Bug', $have, $Tera_Bug);
foreach ($Tera_Bug as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Fire = array(3646,3682,3869,3899,3911);
start($j++, 'Tera Fire', $have, $Tera_Fire);
foreach ($Tera_Fire as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Water = array(3647,3683);
start($j++, 'Tera Water', $have, $Tera_Water);
foreach ($Tera_Water as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();


$Tera_Electric = array(3870,3900);
start($j++, 'Tera Electric', $have, $Tera_Electric);
foreach ($Tera_Electric as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Psychic = array(3734,3786);
start($j++, 'Tera Psychic', $have, $Tera_Psychic);
foreach ($Tera_Psychic as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Ghost = array(3874,3901);
start($j++, 'Tera Ghost', $have, $Tera_Ghost);
foreach ($Tera_Ghost as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Fairy = array(3735,3787);
start($j++, 'Tera Fairy', $have, $Tera_Fairy);
foreach ($Tera_Fairy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();




$Tera_Dark = array(3879,3904,3912,3917);
start($j++, 'Tera Dark', $have, $Tera_Dark);
foreach ($Tera_Dark as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();



$Tera_Dragon = array(3884);
start($j++, 'Tera Dragon', $have, $Tera_Dragon);
foreach ($Tera_Dragon as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tera_Normal = array(3886);
start($j++, 'Tera Normal', $have, $Tera_Normal);
foreach ($Tera_Normal as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();


$Other = array(380,381,382,383,384,385,393,394,395,396,406,407,408,409);
start($j++, 'Other', $have, $Other);
foreach ($Other as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Item = array(253,373,386,397,410,469,493,496,518,519,528,549,550,559,560,570,719,720,721,756,757,792,793,1103,1104,1105,1106,1151,1152,1153,1154,1155,1206,1207,1208,1209,1258,1303,1305,1306,1346,1347,1348,1350,1392,1394,1395,1396,1417,1418,1473,1476,1477,1478,1479,1481,1530,1531,1532,1534,1588,1589,1591,1646,1649,1650,1832,1834,1835,1838,1990,1991,1992,2048,2049,2095,2122,2390,2481,2482,2483,2485,2486,2586,2590,2607,2609,2692,2757,2874,2934,2935,3335,3336,3471,3063,3713,3714,3824,3825);
start($j++, 'Item', $have, $Item);
foreach ($Item as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tool = array(494,495,509,520,535,536,557,558,722,3267,1204,1205,1259,1304,1349,1393,1416,1474,1475,1480,1533,1587,1590,1647,1648,1651,1833,1989,2047,2094,2180,2181,2182,2183,2389,2484,2588,2870,3333,3920,3921,3473,3922);
start($j++, 'Tool', $have, $Tool);
foreach ($Tool as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();



$Supporter = array(101,311,437,503,504,505,525,543,544,566,3243,633,634,635,650,651,652,667,668,669,715,716,717,718,754,755,788,816,817,844,3268,893,914,915,941,942,947,1054,1059,1060,1062,1065,1066,1069,3157,3158,1091,1092,1093,1094,1133,1134,1135,1185,1186,1187,1188,1189,1190,1225,1247,1248,1249,1274,1285,1286,1287,1288,1289,1290,1291,1292,1293,1322,1333,1334,1335,1336,1375,1376,1377,1378,1379,1380,1381,1382,1405,1410,1411,1438,1453,1454,1455,1456,1457,1458,1459,1510,1511,1512,1513,1514,1515,1516,1517,1518,1519,1567,1568,1569,1570,1571,1572,1627,1628,1629,1630,1631,1632,1665,1666,1748,1749,1750,1751,1752,1753,1798,1800,1801,1803,1804,3162,3173,3174,3176,3177,3179,3180,3181,3182,3183,3184,3185,3202,3215,3216,3217,3219,1975,1976,1977,1978,1983,1984,1985,1986,2030,2031,2032,2033,2041,2042,2043,2044,2081,2082,2083,2084,2090,2091,2115,2119,2120,2159,2160,2161,2162,2163,2164,2165,2172,2173,2174,2175,2176,2177,2202,2203,2204,2205,2206,2207,2208,2209,2367,2368,2369,2370,2371,2372,2381,2382,2383,2384,2385,2386,2442,2443,2444,2445,2446,2447,2448,2449,2450,2451,2452,2453,2454,2466,2467,2468,2469,2470,2471,2472,2473,2474,2475,2476,2477,2556,2557,2558,2559,2560,2578,2579,2580,2581,2582,2602,2615,2669,2670,2671,2672,2673,2674,2675,2684,2685,2686,2687,2688,2689,2690,2738,2739,2740,2741,2742,2743,2748,2749,2750,2751,2781,2782,2783,2784,2785,2840,2841,2842,2843,2844,2845,2846,2847,2848,2858,2859,2860,2861,2862,2863,2864,2865,2866,2899,2900,2901,2902,2903,2925,2929,2930,2931,2932,3308,3309,3310,3311,3312,3313,3314,3315,3323,3324,3325,3326,3327,3328,3329,3330,3359,3360,3361,3362,3363,3364,3447,3448,3449,3450,3451,3452,3453,3454,3462,3463,3464,3465,3466,3467,3468,3497,3498,3499,3500,3501,3502,3537,3538,3539,3540,3541,3598,3599,3600,3601,3602,3603,3604,3605,3606,3607,3049,3069,3112,3113,3114,3367,3640,3693,3694,3695,3696,3697,3698,3699,3700,3707,3708,3709,3710,3796,3797,3798,3799,3800,3801,3802,3803,3813,3814,3815,3816,3817,3818,3907,3908,3909,3910,3915,3916);
start($j++, 'Supporter', $have, $Supporter);
foreach ($Supporter as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Tag_Team_Supporter = array(1796,1797,1799,1802,3175,3178);
start($j++, 'Tag Team Supporter', $have, $Tag_Team_Supporter);
foreach ($Tag_Team_Supporter as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Stadium = array(3842,3843,3844,3845,3846,3847,1436,1437,1439,1495,1496,1652,1754,1755,1756,1757,1831,1836,1837,2587,2589,2591,2693,2756,2871,2872,2873,3334,3472,3918);
start($j++, 'Stadium', $have, $Stadium);
foreach ($Stadium as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Special_Energy = array(1156,1260,1261,1275,1307,1308,1323,1351,1397,1592,1653,1654,1839,2050,2096,2391,2392,2875,3474);
start($j++, 'Special Energy', $have, $Special_Energy);
foreach ($Special_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Grass_Energy = array(3848,3854,3860,1157,2694,3630,3826);
start($j++, 'Basic Grass Energy', $have, $Basic_Grass_Energy);
foreach ($Basic_Grass_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Fire_Energy = array(3849,3855,3861,1210,2695,3631,3919);
start($j++, 'Basic Fire Energy', $have, $Basic_Fire_Energy);
foreach ($Basic_Fire_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Water_Energy = array(3850,3856,3862,1262,2487,3632,3827);
start($j++, 'Basic Water Energy', $have, $Basic_Water_Energy);
foreach ($Basic_Water_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Lightning_Energy = array(3851,3857,3863,1158,2592,3633,3715);
start($j++, 'Basic Lightning Energy', $have, $Basic_Lightning_Energy);
foreach ($Basic_Lightning_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Psychic_Energy = array(3852,3858,3864,1107,2488,3634);
start($j++, 'Basic Psychic Energy', $have, $Basic_Psychic_Energy);
foreach ($Basic_Psychic_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Fighting_Energy = array(3853,3859,3865,1159,2489,3635,3716);
start($j++, 'Basic Fighting Energy', $have, $Basic_Fighting_Energy);
foreach ($Basic_Fighting_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Darkness_Energy = array(1211,2593,3636);
start($j++, 'Basic Darkness Energy', $have, $Basic_Darkness_Energy);
foreach ($Basic_Darkness_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Metal_Energy = array(1108,2594,3637);
start($j++, 'Basic Metal Energy', $have, $Basic_Metal_Energy);
foreach ($Basic_Metal_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();

$Basic_Fairy_Energy = array(1212);
start($j++, 'Basic Fairy Energy', $have, $Basic_Fairy_Energy);
foreach ($Basic_Fairy_Energy as $cur) { if (in_array($cur, $have, true)) {imgN($cur);} else {img($cur);} }
finish();



?>
