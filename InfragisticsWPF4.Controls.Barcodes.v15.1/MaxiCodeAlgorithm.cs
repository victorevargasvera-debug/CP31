using System;

namespace Infragistics.Controls.Barcodes
{
	// Token: 0x02000014 RID: 20
	internal class MaxiCodeAlgorithm : global::Infragistics.Controls.Barcodes.BarcodeAlgorithm
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000774C File Offset: 0x0000594C
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00007754 File Offset: 0x00005954
		public bool IsUpsCarrierPrefixUsed
		{
			get
			{
				return this._isUpsCarrierPrefixUsed;
			}
			set
			{
				this._isUpsCarrierPrefixUsed = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000775D File Offset: 0x0000595D
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00007765 File Offset: 0x00005965
		private string PostalCodeValue
		{
			get
			{
				return this._postalCodeValue;
			}
			set
			{
				this._postalCodeValue = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000776E File Offset: 0x0000596E
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00007776 File Offset: 0x00005976
		private int ServiceClassValue
		{
			get
			{
				return this._serviceClassValue;
			}
			set
			{
				this._serviceClassValue = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000065 RID: 101 RVA: 0x0000777F File Offset: 0x0000597F
		// (set) Token: 0x06000066 RID: 102 RVA: 0x00007787 File Offset: 0x00005987
		private int CountryValue
		{
			get
			{
				return this._countryValue;
			}
			set
			{
				this._countryValue = value;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007790 File Offset: 0x00005990
		static MaxiCodeAlgorithm()
		{
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.LoadLayout();
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.LoadCodeSetsData();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000088A4 File Offset: 0x00006AA4
		private static void LoadCodeSetsData()
		{
			int[][] array = new int[12][];
			int[] array2 = new int[10];
			array = new int[277][];
			array2 = new int[3];
			array2[1] = 69;
			array[0] = array2;
			array[1] = new int[]
			{
				1,
				69,
				1
			};
			array[2] = new int[]
			{
				2,
				69,
				2
			};
			array[3] = new int[]
			{
				3,
				69,
				3
			};
			array[4] = new int[]
			{
				4,
				69,
				4
			};
			array[5] = new int[]
			{
				5,
				69,
				5
			};
			array[6] = new int[]
			{
				6,
				69,
				6
			};
			array[7] = new int[]
			{
				7,
				69,
				7
			};
			array[8] = new int[]
			{
				8,
				69,
				8
			};
			array[9] = new int[]
			{
				9,
				69,
				9
			};
			array[10] = new int[]
			{
				10,
				69,
				10
			};
			array[11] = new int[]
			{
				11,
				69,
				11
			};
			array[12] = new int[]
			{
				12,
				69,
				12
			};
			array[13] = new int[]
			{
				13,
				69,
				13
			};
			array2 = new int[3];
			array2[0] = 13;
			array2[1] = 65;
			array[14] = array2;
			array[15] = new int[]
			{
				14,
				69,
				14
			};
			array[16] = new int[]
			{
				15,
				69,
				15
			};
			array[17] = new int[]
			{
				16,
				69,
				16
			};
			array[18] = new int[]
			{
				17,
				69,
				17
			};
			array[19] = new int[]
			{
				18,
				69,
				18
			};
			array[20] = new int[]
			{
				19,
				69,
				19
			};
			array[21] = new int[]
			{
				20,
				69,
				20
			};
			array[22] = new int[]
			{
				21,
				69,
				21
			};
			array[23] = new int[]
			{
				22,
				69,
				22
			};
			array[24] = new int[]
			{
				23,
				69,
				23
			};
			array[25] = new int[]
			{
				24,
				69,
				24
			};
			array[26] = new int[]
			{
				25,
				69,
				25
			};
			array[27] = new int[]
			{
				26,
				69,
				26
			};
			array[28] = new int[]
			{
				27,
				69,
				30
			};
			array[29] = new int[]
			{
				28,
				69,
				32
			};
			array[30] = new int[]
			{
				28,
				65,
				28
			};
			array[31] = new int[]
			{
				28,
				66,
				28
			};
			array[32] = new int[]
			{
				28,
				67,
				28
			};
			array[33] = new int[]
			{
				28,
				68,
				28
			};
			array[34] = new int[]
			{
				29,
				67,
				29
			};
			array[35] = new int[]
			{
				29,
				68,
				29
			};
			array[36] = new int[]
			{
				29,
				66,
				29
			};
			array[37] = new int[]
			{
				29,
				65,
				29
			};
			array[38] = new int[]
			{
				29,
				68,
				33
			};
			array[39] = new int[]
			{
				30,
				67,
				30
			};
			array[40] = new int[]
			{
				30,
				68,
				30
			};
			array[41] = new int[]
			{
				30,
				66,
				30
			};
			array[42] = new int[]
			{
				30,
				69,
				34
			};
			array[43] = new int[]
			{
				30,
				65,
				30
			};
			array[44] = new int[]
			{
				31,
				69,
				35
			};
			array[45] = new int[]
			{
				32,
				68,
				59
			};
			array[46] = new int[]
			{
				32,
				65,
				32
			};
			array[47] = new int[]
			{
				32,
				69,
				59
			};
			array[48] = new int[]
			{
				32,
				67,
				59
			};
			array[49] = new int[]
			{
				32,
				66,
				47
			};
			array[50] = new int[]
			{
				33,
				66,
				53
			};
			array[51] = new int[]
			{
				34,
				65,
				34
			};
			array[52] = new int[]
			{
				35,
				65,
				35
			};
			array[53] = new int[]
			{
				36,
				65,
				36
			};
			array[54] = new int[]
			{
				37,
				65,
				37
			};
			array[55] = new int[]
			{
				38,
				65,
				38
			};
			array[56] = new int[]
			{
				39,
				65,
				39
			};
			array[57] = new int[]
			{
				40,
				65,
				40
			};
			array[58] = new int[]
			{
				41,
				65,
				41
			};
			array[59] = new int[]
			{
				42,
				65,
				42
			};
			array[60] = new int[]
			{
				43,
				65,
				43
			};
			array[61] = new int[]
			{
				44,
				65,
				44
			};
			array[62] = new int[]
			{
				44,
				66,
				48
			};
			array[63] = new int[]
			{
				45,
				65,
				45
			};
			array[64] = new int[]
			{
				46,
				66,
				49
			};
			array[65] = new int[]
			{
				46,
				65,
				46
			};
			array[66] = new int[]
			{
				47,
				66,
				50
			};
			array[67] = new int[]
			{
				47,
				65,
				47
			};
			array[68] = new int[]
			{
				48,
				65,
				48
			};
			array[69] = new int[]
			{
				49,
				65,
				49
			};
			array[70] = new int[]
			{
				50,
				65,
				50
			};
			array[71] = new int[]
			{
				51,
				65,
				51
			};
			array[72] = new int[]
			{
				52,
				65,
				52
			};
			array[73] = new int[]
			{
				53,
				65,
				53
			};
			array[74] = new int[]
			{
				54,
				65,
				54
			};
			array[75] = new int[]
			{
				55,
				65,
				55
			};
			array[76] = new int[]
			{
				56,
				65,
				56
			};
			array[77] = new int[]
			{
				57,
				65,
				57
			};
			array[78] = new int[]
			{
				58,
				65,
				58
			};
			array[79] = new int[]
			{
				58,
				66,
				51
			};
			array[80] = new int[]
			{
				59,
				66,
				37
			};
			array[81] = new int[]
			{
				60,
				66,
				38
			};
			array[82] = new int[]
			{
				61,
				66,
				39
			};
			array[83] = new int[]
			{
				62,
				66,
				40
			};
			array[84] = new int[]
			{
				63,
				66,
				41
			};
			array[85] = new int[]
			{
				64,
				66,
				52
			};
			array[86] = new int[]
			{
				65,
				65,
				1
			};
			array[87] = new int[]
			{
				66,
				65,
				2
			};
			array[88] = new int[]
			{
				67,
				65,
				3
			};
			array[89] = new int[]
			{
				68,
				65,
				4
			};
			array[90] = new int[]
			{
				69,
				65,
				5
			};
			array[91] = new int[]
			{
				70,
				65,
				6
			};
			array[92] = new int[]
			{
				71,
				65,
				7
			};
			array[93] = new int[]
			{
				72,
				65,
				8
			};
			array[94] = new int[]
			{
				73,
				65,
				9
			};
			array[95] = new int[]
			{
				74,
				65,
				10
			};
			array[96] = new int[]
			{
				75,
				65,
				11
			};
			array[97] = new int[]
			{
				76,
				65,
				12
			};
			array[98] = new int[]
			{
				77,
				65,
				13
			};
			array[99] = new int[]
			{
				78,
				65,
				14
			};
			array[100] = new int[]
			{
				79,
				65,
				15
			};
			array[101] = new int[]
			{
				80,
				65,
				16
			};
			array[102] = new int[]
			{
				81,
				65,
				17
			};
			array[103] = new int[]
			{
				82,
				65,
				18
			};
			array[104] = new int[]
			{
				83,
				65,
				19
			};
			array[105] = new int[]
			{
				84,
				65,
				20
			};
			array[106] = new int[]
			{
				85,
				65,
				21
			};
			array[107] = new int[]
			{
				86,
				65,
				22
			};
			array[108] = new int[]
			{
				87,
				65,
				23
			};
			array[109] = new int[]
			{
				88,
				65,
				24
			};
			array[110] = new int[]
			{
				89,
				65,
				25
			};
			array[111] = new int[]
			{
				90,
				65,
				26
			};
			array[112] = new int[]
			{
				91,
				66,
				42
			};
			array[113] = new int[]
			{
				92,
				66,
				43
			};
			array[114] = new int[]
			{
				93,
				66,
				44
			};
			array[115] = new int[]
			{
				94,
				66,
				45
			};
			array[116] = new int[]
			{
				95,
				66,
				46
			};
			array2 = new int[3];
			array2[0] = 96;
			array2[1] = 66;
			array[117] = array2;
			array[118] = new int[]
			{
				97,
				66,
				1
			};
			array[119] = new int[]
			{
				98,
				66,
				2
			};
			array[120] = new int[]
			{
				99,
				66,
				3
			};
			array[121] = new int[]
			{
				100,
				66,
				4
			};
			array[122] = new int[]
			{
				101,
				66,
				5
			};
			array[123] = new int[]
			{
				102,
				66,
				6
			};
			array[124] = new int[]
			{
				103,
				66,
				7
			};
			array[125] = new int[]
			{
				104,
				66,
				8
			};
			array[126] = new int[]
			{
				105,
				66,
				9
			};
			array[127] = new int[]
			{
				106,
				66,
				10
			};
			array[128] = new int[]
			{
				107,
				66,
				11
			};
			array[129] = new int[]
			{
				108,
				66,
				12
			};
			array[130] = new int[]
			{
				109,
				66,
				13
			};
			array[131] = new int[]
			{
				110,
				66,
				14
			};
			array[132] = new int[]
			{
				111,
				66,
				15
			};
			array[133] = new int[]
			{
				112,
				66,
				16
			};
			array[134] = new int[]
			{
				113,
				66,
				17
			};
			array[135] = new int[]
			{
				114,
				66,
				18
			};
			array[136] = new int[]
			{
				115,
				66,
				19
			};
			array[137] = new int[]
			{
				116,
				66,
				20
			};
			array[138] = new int[]
			{
				117,
				66,
				21
			};
			array[139] = new int[]
			{
				118,
				66,
				22
			};
			array[140] = new int[]
			{
				119,
				66,
				23
			};
			array[141] = new int[]
			{
				120,
				66,
				24
			};
			array[142] = new int[]
			{
				121,
				66,
				25
			};
			array[143] = new int[]
			{
				122,
				66,
				26
			};
			array[144] = new int[]
			{
				123,
				66,
				32
			};
			array[145] = new int[]
			{
				124,
				66,
				54
			};
			array[146] = new int[]
			{
				125,
				66,
				34
			};
			array[147] = new int[]
			{
				126,
				66,
				35
			};
			array[148] = new int[]
			{
				127,
				66,
				36
			};
			array[149] = new int[]
			{
				128,
				67,
				48
			};
			array[150] = new int[]
			{
				129,
				67,
				49
			};
			array[151] = new int[]
			{
				130,
				67,
				50
			};
			array[152] = new int[]
			{
				131,
				67,
				51
			};
			array[153] = new int[]
			{
				132,
				67,
				52
			};
			array[154] = new int[]
			{
				133,
				67,
				53
			};
			array[155] = new int[]
			{
				134,
				67,
				54
			};
			array[156] = new int[]
			{
				135,
				67,
				55
			};
			array[157] = new int[]
			{
				136,
				67,
				56
			};
			array[158] = new int[]
			{
				137,
				67,
				57
			};
			array[159] = new int[]
			{
				138,
				68,
				47
			};
			array[160] = new int[]
			{
				139,
				68,
				48
			};
			array[161] = new int[]
			{
				140,
				68,
				49
			};
			array[162] = new int[]
			{
				141,
				68,
				50
			};
			array[163] = new int[]
			{
				142,
				68,
				51
			};
			array[164] = new int[]
			{
				143,
				68,
				52
			};
			array[165] = new int[]
			{
				144,
				68,
				53
			};
			array[166] = new int[]
			{
				145,
				68,
				54
			};
			array[167] = new int[]
			{
				146,
				68,
				55
			};
			array[168] = new int[]
			{
				147,
				68,
				56
			};
			array[169] = new int[]
			{
				148,
				68,
				57
			};
			array[170] = new int[]
			{
				149,
				69,
				48
			};
			array[171] = new int[]
			{
				150,
				69,
				49
			};
			array[172] = new int[]
			{
				151,
				69,
				50
			};
			array[173] = new int[]
			{
				152,
				69,
				51
			};
			array[174] = new int[]
			{
				153,
				69,
				52
			};
			array[175] = new int[]
			{
				154,
				69,
				53
			};
			array[176] = new int[]
			{
				155,
				69,
				54
			};
			array[177] = new int[]
			{
				156,
				69,
				55
			};
			array[178] = new int[]
			{
				157,
				69,
				56
			};
			array[179] = new int[]
			{
				158,
				69,
				57
			};
			array[180] = new int[]
			{
				159,
				69,
				36
			};
			array[181] = new int[]
			{
				160,
				69,
				37
			};
			array[182] = new int[]
			{
				161,
				68,
				37
			};
			array[183] = new int[]
			{
				162,
				69,
				38
			};
			array[184] = new int[]
			{
				163,
				69,
				39
			};
			array[185] = new int[]
			{
				164,
				69,
				40
			};
			array[186] = new int[]
			{
				165,
				69,
				41
			};
			array[187] = new int[]
			{
				166,
				68,
				42
			};
			array[188] = new int[]
			{
				167,
				69,
				43
			};
			array[189] = new int[]
			{
				168,
				68,
				38
			};
			array[190] = new int[]
			{
				169,
				69,
				44
			};
			array[191] = new int[]
			{
				170,
				67,
				37
			};
			array[192] = new int[]
			{
				171,
				68,
				39
			};
			array[193] = new int[]
			{
				172,
				67,
				38
			};
			array[194] = new int[]
			{
				173,
				69,
				45
			};
			array[195] = new int[]
			{
				174,
				69,
				46
			};
			array[196] = new int[]
			{
				175,
				68,
				40
			};
			array[197] = new int[]
			{
				176,
				68,
				41
			};
			array[198] = new int[]
			{
				177,
				67,
				39
			};
			array[199] = new int[]
			{
				178,
				67,
				40
			};
			array[200] = new int[]
			{
				179,
				67,
				41
			};
			array[201] = new int[]
			{
				180,
				68,
				42
			};
			array[202] = new int[]
			{
				181,
				67,
				42
			};
			array[203] = new int[]
			{
				182,
				69,
				47
			};
			array[204] = new int[]
			{
				183,
				68,
				43
			};
			array[205] = new int[]
			{
				184,
				68,
				44
			};
			array[206] = new int[]
			{
				185,
				67,
				43
			};
			array[207] = new int[]
			{
				186,
				67,
				44
			};
			array[208] = new int[]
			{
				187,
				68,
				45
			};
			array[209] = new int[]
			{
				188,
				67,
				45
			};
			array[210] = new int[]
			{
				189,
				67,
				46
			};
			array[211] = new int[]
			{
				190,
				67,
				47
			};
			array[212] = new int[]
			{
				191,
				68,
				46
			};
			array2 = new int[3];
			array2[0] = 192;
			array2[1] = 67;
			array[213] = array2;
			array[214] = new int[]
			{
				193,
				67,
				1
			};
			array[215] = new int[]
			{
				194,
				67,
				2
			};
			array[216] = new int[]
			{
				195,
				67,
				3
			};
			array[217] = new int[]
			{
				196,
				67,
				4
			};
			array[218] = new int[]
			{
				197,
				67,
				5
			};
			array[219] = new int[]
			{
				198,
				67,
				6
			};
			array[220] = new int[]
			{
				199,
				67,
				7
			};
			array[221] = new int[]
			{
				200,
				67,
				8
			};
			array[222] = new int[]
			{
				201,
				67,
				9
			};
			array[223] = new int[]
			{
				202,
				67,
				10
			};
			array[224] = new int[]
			{
				203,
				67,
				11
			};
			array[225] = new int[]
			{
				204,
				67,
				12
			};
			array[226] = new int[]
			{
				205,
				67,
				13
			};
			array[227] = new int[]
			{
				206,
				67,
				14
			};
			array[228] = new int[]
			{
				207,
				67,
				15
			};
			array[229] = new int[]
			{
				208,
				67,
				16
			};
			array[230] = new int[]
			{
				209,
				67,
				17
			};
			array[231] = new int[]
			{
				210,
				67,
				18
			};
			array[232] = new int[]
			{
				211,
				67,
				19
			};
			array[233] = new int[]
			{
				212,
				67,
				20
			};
			array[234] = new int[]
			{
				213,
				67,
				21
			};
			array[235] = new int[]
			{
				214,
				67,
				22
			};
			array[236] = new int[]
			{
				215,
				67,
				23
			};
			array[237] = new int[]
			{
				216,
				67,
				24
			};
			array[238] = new int[]
			{
				217,
				67,
				25
			};
			array[239] = new int[]
			{
				218,
				67,
				26
			};
			array[240] = new int[]
			{
				219,
				67,
				32
			};
			array[241] = new int[]
			{
				220,
				67,
				33
			};
			array[242] = new int[]
			{
				221,
				67,
				34
			};
			array[243] = new int[]
			{
				222,
				67,
				35
			};
			array[244] = new int[]
			{
				223,
				67,
				36
			};
			array2 = new int[3];
			array2[0] = 224;
			array2[1] = 68;
			array[245] = array2;
			array[246] = new int[]
			{
				225,
				68,
				1
			};
			array[247] = new int[]
			{
				226,
				68,
				2
			};
			array[248] = new int[]
			{
				227,
				68,
				3
			};
			array[249] = new int[]
			{
				228,
				68,
				4
			};
			array[250] = new int[]
			{
				229,
				68,
				5
			};
			array[251] = new int[]
			{
				230,
				68,
				6
			};
			array[252] = new int[]
			{
				231,
				68,
				7
			};
			array[253] = new int[]
			{
				232,
				68,
				8
			};
			array[254] = new int[]
			{
				233,
				68,
				9
			};
			array[255] = new int[]
			{
				234,
				68,
				10
			};
			array[256] = new int[]
			{
				235,
				68,
				11
			};
			array[257] = new int[]
			{
				236,
				68,
				12
			};
			array[258] = new int[]
			{
				237,
				68,
				13
			};
			array[259] = new int[]
			{
				238,
				68,
				14
			};
			array[260] = new int[]
			{
				239,
				68,
				15
			};
			array[261] = new int[]
			{
				240,
				68,
				16
			};
			array[262] = new int[]
			{
				241,
				68,
				17
			};
			array[263] = new int[]
			{
				242,
				68,
				18
			};
			array[264] = new int[]
			{
				243,
				68,
				19
			};
			array[265] = new int[]
			{
				244,
				68,
				20
			};
			array[266] = new int[]
			{
				245,
				68,
				21
			};
			array[267] = new int[]
			{
				246,
				68,
				22
			};
			array[268] = new int[]
			{
				247,
				68,
				23
			};
			array[269] = new int[]
			{
				248,
				68,
				24
			};
			array[270] = new int[]
			{
				249,
				68,
				25
			};
			array[271] = new int[]
			{
				250,
				68,
				26
			};
			array[272] = new int[]
			{
				251,
				68,
				32
			};
			array[273] = new int[]
			{
				252,
				67,
				33
			};
			array[274] = new int[]
			{
				253,
				68,
				34
			};
			array[275] = new int[]
			{
				254,
				68,
				35
			};
			array[276] = new int[]
			{
				255,
				68,
				36
			};
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData = array;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000A148 File Offset: 0x00008348
		private static void LoadLayout()
		{
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence = new int[30][];
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(21, 35, 0, 0);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(48, 34, 0, 3);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(49, 63, 0, 6);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(69, 65, 0, 9);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(70, 73, 0, 12);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(81, 78, 0, 15);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(82, 85, 0, 18);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(94, 90, 0, 21);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(95, 109, 0, 24);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(122, 108, 0, 27);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(123, 137, 0, 30);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(65, 62, 22, 9);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(73, 76, 22, 12);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(78, 75, 22, 15);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(85, 88, 22, 18);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateHexagonList(90, 87, 22, 21);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(8, 9, 14);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(8, 12, 10);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(6, 12, 18);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(8, 18, 11);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(6, 18, 17);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(8, 21, 13);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(20, 9, 19);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(20, 12, 15);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(20, 18, 16);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(20, 21, 20);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(18, 21, 12);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 1, 137);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 5, 138);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 9, 139);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 13, 140);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 17, 141);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 21, 142);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 25, 143);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonEvenRow(28, 29, 144);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[28][0] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[29][0] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][9] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[11][9] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[11][10] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][9] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][9] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][10] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[7][15] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[7][16] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[8][16] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[20][16] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[21][16] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[20][17] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][22] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[11][22] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][23] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][22] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[16][23] = 0;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][23] = -1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[12][9] = 14;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[13][9] = 13;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[14][9] = 38;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[15][9] = 37;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[16][9] = 3;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][9] = 45;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][9] = 44;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][10] = 41;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[12][10] = 16;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[13][10] = 15;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[14][10] = 40;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[15][10] = 39;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[16][10] = 4;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][10] = 46;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][11] = 42;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[16][11] = 6;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][11] = 5;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][11] = 48;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][11] = 47;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][12] = 17;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][12] = 21;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][12] = 20;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][13] = 23;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][13] = 22;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][14] = 24;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[6][15] = 49;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[8][15] = 31;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][15] = 1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[20][15] = 54;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[21][15] = 53;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[6][16] = 50;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[6][17] = 52;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[7][17] = 51;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[8][17] = 32;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][17] = 2;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[21][17] = 43;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][18] = 27;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][19] = 29;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][19] = 28;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][20] = 18;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[18][20] = 19;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[19][20] = 30;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[10][21] = 33;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[17][21] = 11;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[12][22] = 8;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[13][22] = 7;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[14][22] = 36;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[15][22] = 35;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[16][22] = 12;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[11][23] = 34;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[12][23] = 10;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[13][23] = 9;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[14][23] = 26;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[15][23] = 25;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000A6A4 File Offset: 0x000088A4
		private static void CreateHexagonList(int start, int end, int x, int y)
		{
			int num = start;
			int num2 = 1;
			if (end < start)
			{
				num2 = -1;
			}
			while (num != end)
			{
				global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CreateLayoutHexagonOddRow(x, y, num);
				x += 2;
				num += num2;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000A6D4 File Offset: 0x000088D4
		private static void CreateLayoutHexagonOddRow(int x, int y, int c)
		{
			int num = (c - 1) * 6;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CheckRowLayoutInitialization(x);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CheckRowLayoutInitialization(x + 1);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y] = num + 2;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x + 1][y] = num + 1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y + 1] = num + 4;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x + 1][y + 1] = num + 3;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y + 2] = num + 6;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x + 1][y + 2] = num + 5;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A74C File Offset: 0x0000894C
		private static void CreateLayoutHexagonEvenRow(int x, int y, int c)
		{
			int num = (c - 1) * 6;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CheckRowLayoutInitialization(x);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CheckRowLayoutInitialization(x + 1);
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y] = num + 1;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x + 1][y + 1] = num + 2;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y + 1] = num + 3;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y + 2] = num + 4;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x + 1][y + 3] = num + 5;
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x][y + 3] = num + 6;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A7C3 File Offset: 0x000089C3
		private static void CheckRowLayoutInitialization(int x)
		{
			if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x] == null)
			{
				global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ModulesSequence[x] = new int[33];
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A7DC File Offset: 0x000089DC
		public void ClearProperties()
		{
			this.IsUpsCarrierPrefixUsed = false;
			this.CountryValue = 0;
			this.PostalCodeValue = string.Empty;
			this.ServiceClassValue = 0;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000A800 File Offset: 0x00008A00
		public byte[] GenerateEncodingData(string dataStr, global::Infragistics.Controls.Barcodes.ModeIndicator mode, global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel errorCorrectionLevel, string postalCodeDP, int serviceCodeDP, int countryDP)
		{
			byte[] array = new byte[20];
			if (mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2 || mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3)
			{
				dataStr = this.ExtractPrimaryData(dataStr, mode, postalCodeDP, serviceCodeDP, countryDP);
				if (string.IsNullOrEmpty(dataStr))
				{
					return null;
				}
				array = this.CreatePrimaryMessage(mode);
				if (array == null)
				{
					return null;
				}
			}
			byte[] array2 = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.Encode(dataStr);
			if (array2 == null)
			{
				string @string = global::SR.GetString("EncodingError");
				global::System.ArgumentException ex = new global::System.ArgumentException(@string);
				throw ex;
			}
			if (mode > global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3)
			{
				for (int i = 0; i < 9; i++)
				{
					array[i + 1] = array2[i];
				}
				array[0] = (byte)mode;
				for (int i = 9; i < 144; i++)
				{
					array2[i - 9] = array2[i];
				}
			}
			byte[] array3 = new byte[144];
			for (int i = 0; i < 10; i++)
			{
				array3[i] = array[i];
			}
			for (int i = 20; i < 144; i++)
			{
				array3[i] = array2[i - 20];
			}
			global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.GenerateErrorCorrectionCodewords(array3, errorCorrectionLevel);
			return array3;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A8F8 File Offset: 0x00008AF8
		private string ExtractPrimaryData(string data, global::Infragistics.Controls.Barcodes.ModeIndicator mode, string postalCodePropValue, int serviceClasPropValue, int countryPropValue)
		{
			int num = 0;
			string strB = string.Concat(new object[]
			{
				"[)>",
				'\u001e',
				"01",
				'\u001d'
			});
			string message = string.Empty;
			if (data.Length >= 9 && string.Compare(data.Substring(0, 7), strB, global::System.StringComparison.CurrentCulture) == 0)
			{
				this.IsUpsCarrierPrefixUsed = true;
				num = 9;
			}
			else
			{
				this.IsUpsCarrierPrefixUsed = false;
			}
			if (!this.IsUpsCarrierPrefixUsed)
			{
				this.PostalCodeValue = postalCodePropValue;
				this.ServiceClassValue = serviceClasPropValue;
				this.CountryValue = countryPropValue;
				return data;
			}
			int num2 = 0;
			int i = num;
			if (data.Contains('\u001d'.ToString()))
			{
				while (i < data.Length)
				{
					if (data[i] == '\u001d')
					{
						num2++;
					}
					else
					{
						switch (num2)
						{
						case 0:
							this.PostalCodeValue += data[i];
							goto IL_1A2;
						case 1:
							try
							{
								this.CountryValue = int.Parse(this.CountryValue.ToString(global::Infragistics.CultureInfoHelper.CultureToUse) + data[i], global::Infragistics.CultureInfoHelper.CultureToUse);
								goto IL_1A2;
							}
							catch
							{
								message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("CountryError"), new object[0]);
								throw new global::System.ArgumentException(message);
							}
							break;
						case 2:
							break;
						default:
							goto IL_1A2;
						}
						try
						{
							this.ServiceClassValue = int.Parse(this.ServiceClassValue.ToString(global::Infragistics.CultureInfoHelper.CultureToUse) + data[i], global::Infragistics.CultureInfoHelper.CultureToUse);
						}
						catch
						{
							message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("ServiceClassError"), new object[0]);
							throw new global::System.ArgumentException(message);
						}
					}
					IL_1A2:
					if (num2 == 3)
					{
						break;
					}
					i++;
				}
			}
			if (num2 != 3 || !global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsPostalCodeValid(this.PostalCodeValue, mode) || !global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsServiceClassValid(this.ServiceClassValue, mode) || !global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsCountryValid(this.CountryValue, mode))
			{
				message = global::SR.GetString("PrimaryMessageError");
				throw new global::System.ArgumentException(message);
			}
			if (i < data.Length)
			{
				data = data.Substring(0, num) + data.Substring(i + 1);
			}
			else
			{
				data = data.Substring(0, num);
			}
			return data;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000AB64 File Offset: 0x00008D64
		private byte[] CreatePrimaryMessage(global::Infragistics.Controls.Barcodes.ModeIndicator mode)
		{
			if (this.PostalCodeValue == null)
			{
				this.PostalCodeValue = string.Empty;
			}
			bool flag = string.IsNullOrEmpty(this.PostalCodeValue) || global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(this.PostalCodeValue, "0123456789");
			if ((mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2 && (!flag || this.PostalCodeValue.Length > 9)) || (mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3 && this.PostalCodeValue.Length > 6))
			{
				string @string = global::SR.GetString("InvalidPostalCode");
				global::System.ArgumentException ex = new global::System.ArgumentException(@string);
				throw ex;
			}
			byte[] array = new byte[20];
			if (mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3)
			{
				this.PostalCodeValue = this.PostalCodeValue.PadRight(6, ' ');
				int num = 0;
				int num2 = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)this.PostalCodeValue[0], global::Infragistics.Controls.Barcodes.CodeSet.A);
				int num3 = 0;
				if (this.PostalCodeValue.Length == 6)
				{
					num3 = (num2 & 60) >> 2;
					num |= (num2 & 3) << 30;
				}
				else
				{
					num |= num2 << (this.PostalCodeValue.Length - 1) * 6;
				}
				for (int i = 1; i < this.PostalCodeValue.Length; i++)
				{
					num2 = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)this.PostalCodeValue[i], global::Infragistics.Controls.Barcodes.CodeSet.A);
					num |= num2 << (this.PostalCodeValue.Length - i - 1) * 6;
				}
				array[0] = (byte)((num & 1) << 4 | (num & 2) << 4 | (int)(mode & (global::Infragistics.Controls.Barcodes.ModeIndicator)15));
				array[1] = (byte)((num & 252) >> 2);
				array[2] = (byte)((num & 16128) >> 8);
				array[3] = (byte)((num & 1032192) >> 14);
				array[4] = (byte)((num & 66060288) >> 20);
				array[5] = (byte)(((long)num & (long)((ulong)-67108864)) >> 26);
				array[6] = (byte)((num3 & 15) | (this.CountryValue & 3) << 4);
				array[7] = (byte)((this.CountryValue & 252) >> 2);
				array[8] = (byte)((this.CountryValue & 768) >> 8 | (this.ServiceClassValue & 15) << 2);
				array[9] = (byte)((this.ServiceClassValue & 1008) >> 4);
			}
			if (mode == global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2)
			{
				int num4 = 0;
				try
				{
					num4 = (string.IsNullOrEmpty(this.PostalCodeValue) ? 0 : int.Parse(this.PostalCodeValue, global::Infragistics.CultureInfoHelper.CultureToUse));
				}
				catch
				{
					string message = string.Format(global::Infragistics.CultureInfoHelper.CultureToUse, global::SR.GetString("InvalidPostalCode"), new object[0]);
					global::System.ArgumentException ex2 = new global::System.ArgumentException(message);
					throw ex2;
				}
				array[0] = (byte)((num4 & 1) << 4 | (num4 & 2) << 4 | (int)(mode & (global::Infragistics.Controls.Barcodes.ModeIndicator)15));
				array[1] = (byte)((num4 & 252) >> 2);
				array[2] = (byte)((num4 & 16128) >> 8);
				array[3] = (byte)((num4 & 1032192) >> 14);
				array[4] = (byte)((num4 & 66060288) >> 20);
				array[5] = (byte)((num4 & 1006632960) >> 26 | (this.PostalCodeValue.Length & 3) << 4);
				array[6] = (byte)((this.PostalCodeValue.Length & 60) >> 2 | (this.CountryValue & 3) << 4);
				array[7] = (byte)((this.CountryValue & 252) >> 2);
				array[8] = (byte)((this.CountryValue & 768) >> 8 | (this.ServiceClassValue & 15) << 2);
				array[9] = (byte)((this.ServiceClassValue & 1008) >> 4);
			}
			return array;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000AE9C File Offset: 0x0000909C
		private static byte[] Encode(string data)
		{
			byte[] array = new byte[144];
			int num = 0;
			int num2 = 0;
			int length = data.Length;
			global::Infragistics.Controls.Barcodes.CodeSet codeSet = global::Infragistics.Controls.Barcodes.CodeSet.A;
			while (num2 < length && num < 144)
			{
				bool flag = false;
				if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.IsNumericEncodable(num2, data))
				{
					int digits = int.Parse(data.Substring(num2, 9), global::Infragistics.CultureInfoHelper.CultureToUse);
					byte[] array2 = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.Encode9Digits(digits);
					if (array2 == null)
					{
						return null;
					}
					array[num++] = 31;
					for (int i = 0; i < 5; i++)
					{
						array[num++] = array2[i];
					}
					flag = true;
					num2 += 9;
				}
				if (codeSet == global::Infragistics.Controls.Barcodes.CodeSet.B && !flag)
				{
					global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeFromCodeSetB(data, array, ref num, ref num2, ref codeSet, ref flag);
				}
				if (codeSet == global::Infragistics.Controls.Barcodes.CodeSet.A && !flag)
				{
					global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeFromCodeSetA(data, array, ref num, ref num2, ref codeSet, ref flag);
				}
				if ((ushort)codeSet <= 66 && !flag)
				{
					global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeAndLockInCDE(data, array, ref num, ref num2, ref codeSet, ref flag);
				}
				if ((ushort)codeSet > 66 && !flag)
				{
					if (!flag)
					{
						global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeCDEtoAB(data, array, ref num, ref num2, ref codeSet, ref flag);
					}
					if (!flag)
					{
						global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeFromCDE(data, array, ref num, ref num2, ref codeSet, ref flag);
					}
					if (!flag)
					{
						global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.EncodeOneCharInCDE(data, array, ref num, ref num2, codeSet, ref flag);
					}
				}
			}
			for (int j = num; j < 144; j++)
			{
				array[num++] = 33;
			}
			return array;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000AFE4 File Offset: 0x000091E4
		private static void EncodeOneCharInCDE(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.C))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.C)
				{
					buffer[currentBufferIndex++] = 60;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.C);
				startIndex++;
				alreadyEncoded = true;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.D))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.D)
				{
					buffer[currentBufferIndex++] = 61;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.D);
				startIndex++;
				alreadyEncoded = true;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.E))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.E)
				{
					buffer[currentBufferIndex++] = 62;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.E);
				startIndex++;
				alreadyEncoded = true;
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000B0D4 File Offset: 0x000092D4
		private static void EncodeFromCDE(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, ref global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 2, global::Infragistics.Controls.Barcodes.CodeSet.C))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.C)
				{
					buffer[currentBufferIndex++] = 60;
					buffer[currentBufferIndex++] = 60;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.C);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.C;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 2, global::Infragistics.Controls.Barcodes.CodeSet.D))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.D)
				{
					buffer[currentBufferIndex++] = 61;
					buffer[currentBufferIndex++] = 61;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.D);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.D;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 2, global::Infragistics.Controls.Barcodes.CodeSet.E))
			{
				if (currentSet != global::Infragistics.Controls.Barcodes.CodeSet.E)
				{
					buffer[currentBufferIndex++] = 62;
					buffer[currentBufferIndex++] = 62;
				}
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.E);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.E;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000B204 File Offset: 0x00009404
		private static void EncodeCDEtoAB(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, ref global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.A))
			{
				buffer[currentBufferIndex++] = 58;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.A;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.B))
			{
				buffer[currentBufferIndex++] = 63;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.B);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.B;
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000B2A4 File Offset: 0x000094A4
		private static void EncodeAndLockInCDE(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, ref global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 4, global::Infragistics.Controls.Barcodes.CodeSet.C))
			{
				buffer[currentBufferIndex++] = 60;
				buffer[currentBufferIndex++] = 60;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.C);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.C;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 4, global::Infragistics.Controls.Barcodes.CodeSet.D))
			{
				buffer[currentBufferIndex++] = 61;
				buffer[currentBufferIndex++] = 61;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.D);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.D;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 4, global::Infragistics.Controls.Barcodes.CodeSet.E))
			{
				buffer[currentBufferIndex++] = 62;
				buffer[currentBufferIndex++] = 62;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.E);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.E;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.C))
			{
				buffer[currentBufferIndex++] = 60;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.C);
				startIndex++;
				alreadyEncoded = true;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.D))
			{
				buffer[currentBufferIndex++] = 61;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.D);
				startIndex++;
				alreadyEncoded = true;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.E))
			{
				buffer[currentBufferIndex++] = 62;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.E);
				startIndex++;
				alreadyEncoded = true;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000B498 File Offset: 0x00009698
		private static void EncodeFromCodeSetA(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, ref global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.A))
			{
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				alreadyEncoded = true;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 2, global::Infragistics.Controls.Barcodes.CodeSet.B) && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 1], global::Infragistics.Controls.Barcodes.CodeSet.A) == -1)
			{
				buffer[currentBufferIndex++] = 63;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.B);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.B;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.B))
			{
				buffer[currentBufferIndex++] = 59;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.B);
				startIndex++;
				alreadyEncoded = true;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000B580 File Offset: 0x00009780
		private static void EncodeFromCodeSetB(string data, byte[] buffer, ref int currentBufferIndex, ref int startIndex, ref global::Infragistics.Controls.Barcodes.CodeSet currentSet, ref bool alreadyEncoded)
		{
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.B))
			{
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.B);
				startIndex++;
				alreadyEncoded = true;
				return;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ShouldEncodeInCharA(startIndex, data))
			{
				buffer[currentBufferIndex++] = 63;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				alreadyEncoded = true;
				currentSet = global::Infragistics.Controls.Barcodes.CodeSet.A;
				return;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 3, global::Infragistics.Controls.Barcodes.CodeSet.A))
			{
				buffer[currentBufferIndex++] = 57;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 1], global::Infragistics.Controls.Barcodes.CodeSet.A);
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 2], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				startIndex++;
				startIndex++;
				alreadyEncoded = true;
				return;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 2, global::Infragistics.Controls.Barcodes.CodeSet.A))
			{
				buffer[currentBufferIndex++] = 56;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 1], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				startIndex++;
				alreadyEncoded = true;
				return;
			}
			if (!alreadyEncoded && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 1, global::Infragistics.Controls.Barcodes.CodeSet.A))
			{
				buffer[currentBufferIndex++] = 59;
				buffer[currentBufferIndex++] = (byte)global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex], global::Infragistics.Controls.Barcodes.CodeSet.A);
				startIndex++;
				alreadyEncoded = true;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000B758 File Offset: 0x00009958
		private static bool ShouldEncodeInCharA(int startIndex, string data)
		{
			bool flag = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.HasProperNumberOfCodeSetChars(data, startIndex, 4, global::Infragistics.Controls.Barcodes.CodeSet.A);
			if (flag && startIndex + 4 < data.Length && (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 3], global::Infragistics.Controls.Barcodes.CodeSet.B) < 0 || data.Length - startIndex >= 5))
			{
				flag = (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + 4], global::Infragistics.Controls.Barcodes.CodeSet.A) != -1);
			}
			return flag;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000B7B4 File Offset: 0x000099B4
		private static bool HasProperNumberOfCodeSetChars(string data, int startIndex, int charsNumber, global::Infragistics.Controls.Barcodes.CodeSet codeSet)
		{
			if (data.Length - startIndex >= charsNumber)
			{
				for (int i = 0; i < charsNumber; i++)
				{
					if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.CharSet((int)data[startIndex + i], codeSet) == -1)
					{
						return false;
					}
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000B7F0 File Offset: 0x000099F0
		private static bool IsNumericEncodable(int startIndex, string data)
		{
			return data.Length - startIndex >= 9 && char.IsDigit(data[startIndex]) && char.IsDigit(data[startIndex + 1]) && char.IsDigit(data[startIndex + 2]) && char.IsDigit(data[startIndex + 3]) && char.IsDigit(data[startIndex + 4]) && char.IsDigit(data[startIndex + 5]) && char.IsDigit(data[startIndex + 6]) && char.IsDigit(data[startIndex + 7]) && char.IsDigit(data[startIndex + 8]);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000B89C File Offset: 0x00009A9C
		private static byte[] Encode9Digits(int digits)
		{
			string bits = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.GetBits(digits, 30);
			byte[] array = new byte[5];
			for (int i = 0; i < 5; i++)
			{
				array[i] = global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.ParseBits(bits.Substring(i * 6, 6));
			}
			return array;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000B8D8 File Offset: 0x00009AD8
		private static string GetBits(int c, int num)
		{
			string text = global::System.Convert.ToString(c, 2);
			if (text.Length < num)
			{
				for (int i = text.Length; i < num; i++)
				{
					text = "0" + text;
				}
				return text;
			}
			return text.Substring(text.Length - num);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000B924 File Offset: 0x00009B24
		private static byte ParseBits(string vStr)
		{
			int num = 0;
			if (vStr[0] == '1')
			{
				num += 32;
			}
			if (vStr[1] == '1')
			{
				num += 16;
			}
			if (vStr[2] == '1')
			{
				num += 8;
			}
			if (vStr[3] == '1')
			{
				num += 4;
			}
			if (vStr[4] == '1')
			{
				num += 2;
			}
			if (vStr[5] == '1')
			{
				num++;
			}
			return (byte)num;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B994 File Offset: 0x00009B94
		private static int CharSet(int c, global::Infragistics.Controls.Barcodes.CodeSet cs)
		{
			for (int i = c - 1; i < global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData.GetLength(0); i++)
			{
				if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData[i][0] == c && global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData[i][1] == (int)((ushort)cs))
				{
					return global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData[i][2];
				}
				if (global::Infragistics.Controls.Barcodes.MaxiCodeAlgorithm.codeSetsData[i][0] > c)
				{
					break;
				}
			}
			return -1;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B9EC File Offset: 0x00009BEC
		private static void GenerateErrorCorrectionCodewords(byte[] data, global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel level)
		{
			int[] array = new int[144];
			int[] array2 = new int[144];
			int[] array3 = new int[144];
			for (int i = 0; i < 10; i++)
			{
				array[i] = (int)data[i];
			}
			for (int j = 10; j < 20; j++)
			{
				array[j] = 0;
			}
			global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon maxiCodeReedSolomon = new global::Infragistics.Controls.Barcodes.MaxiCodeReedSolomon();
			maxiCodeReedSolomon.CalculateReedSolomonCheckwords(array, 10, 10);
			int num = 0;
			for (int k = 0; k < 124; k += 2)
			{
				array2[num] = (int)data[20 + k];
				array3[num] = (int)data[20 + k + 1];
				num++;
			}
			int startIndex = (level == global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel.Standard) ? 42 : 34;
			int checkwordsNumber = (level == global::Infragistics.Controls.Barcodes.MaxiCodeErrorCorrectionLevel.Standard) ? 20 : 28;
			maxiCodeReedSolomon.CalculateReedSolomonCheckwords(array2, startIndex, checkwordsNumber);
			maxiCodeReedSolomon.CalculateReedSolomonCheckwords(array3, startIndex, checkwordsNumber);
			for (int l = 0; l < 20; l++)
			{
				data[l] = (byte)array[l];
			}
			num = 20;
			for (int m = 0; m < 62; m++)
			{
				data[num] = (byte)array2[m];
				num++;
				data[num] = (byte)array3[m];
				num++;
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000BB04 File Offset: 0x00009D04
		public static bool IsServiceClassValid(int serviceClass, global::Infragistics.Controls.Barcodes.ModeIndicator mode)
		{
			return (mode != global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2 && mode != global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3) || (serviceClass >= 0 && serviceClass <= 999);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000BB21 File Offset: 0x00009D21
		public static bool IsCountryValid(int country, global::Infragistics.Controls.Barcodes.ModeIndicator mode)
		{
			return (mode != global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2 && mode != global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3) || (country >= 0 && country <= 999);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000BB40 File Offset: 0x00009D40
		public static bool IsPostalCodeValid(string postalCode, global::Infragistics.Controls.Barcodes.ModeIndicator mode)
		{
			switch (mode)
			{
			case global::Infragistics.Controls.Barcodes.ModeIndicator.Mode2:
				return postalCode.Length <= 9 && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(postalCode, "0123456789");
			case global::Infragistics.Controls.Barcodes.ModeIndicator.Mode3:
				return postalCode.Length <= 6 && global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AreCharsValid(postalCode, "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ");
			default:
				return true;
			}
		}

		// Token: 0x0400006C RID: 108
		public const int RowCount = 33;

		// Token: 0x0400006D RID: 109
		public const int ColumnCount = 30;

		// Token: 0x0400006E RID: 110
		public const int MinCoutryNumber = 0;

		// Token: 0x0400006F RID: 111
		public const int MinServiceClass = 0;

		// Token: 0x04000070 RID: 112
		public const int MaxCountryNumber = 999;

		// Token: 0x04000071 RID: 113
		public const int MaxServiceClass = 999;

		// Token: 0x04000072 RID: 114
		public const int MinNumberOfSymbols = 1;

		// Token: 0x04000073 RID: 115
		public const int MaxNumberOfSymbols = 8;

		// Token: 0x04000074 RID: 116
		private const int CodewordsNumber = 144;

		// Token: 0x04000075 RID: 117
		private const int LatchBtoA = 63;

		// Token: 0x04000076 RID: 118
		private const int LatchCDEtoA = 58;

		// Token: 0x04000077 RID: 119
		private const int LatchToB = 63;

		// Token: 0x04000078 RID: 120
		private const int ShiftBtoA = 59;

		// Token: 0x04000079 RID: 121
		private const int ShiftAtoB = 59;

		// Token: 0x0400007A RID: 122
		private const int ShiftC = 60;

		// Token: 0x0400007B RID: 123
		private const int ShiftD = 61;

		// Token: 0x0400007C RID: 124
		private const int ShiftE = 62;

		// Token: 0x0400007D RID: 125
		private const int LockInC = 60;

		// Token: 0x0400007E RID: 126
		private const int LockInD = 61;

		// Token: 0x0400007F RID: 127
		private const int LockInE = 62;

		// Token: 0x04000080 RID: 128
		private const int DoubleShiftA = 56;

		// Token: 0x04000081 RID: 129
		private const int TripleShiftA = 57;

		// Token: 0x04000082 RID: 130
		private const int NumericShift = 31;

		// Token: 0x04000083 RID: 131
		private const int PadAB = 33;

		// Token: 0x04000084 RID: 132
		private const int NotFound = -1;

		// Token: 0x04000085 RID: 133
		public const int BlackModule = -1;

		// Token: 0x04000086 RID: 134
		private const int WhiteModule = 0;

		// Token: 0x04000087 RID: 135
		public const double NominalPanelL = 25.5;

		// Token: 0x04000088 RID: 136
		public static readonly string ValidMaxiCodeCharSet = global::Infragistics.Controls.Barcodes.BarcodeAlgorithm.AsciiChars;

		// Token: 0x04000089 RID: 137
		private static int[][] codeSetsData;

		// Token: 0x0400008A RID: 138
		public static int[][] ModulesSequence;

		// Token: 0x0400008B RID: 139
		private bool _isUpsCarrierPrefixUsed;

		// Token: 0x0400008C RID: 140
		private string _postalCodeValue;

		// Token: 0x0400008D RID: 141
		private int _serviceClassValue;

		// Token: 0x0400008E RID: 142
		private int _countryValue;
	}
}
