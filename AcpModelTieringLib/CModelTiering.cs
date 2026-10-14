using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml;
using AcpCommonLib;
using AcpCryptoLib;
using AcpUtility;

namespace AcpModelTieringLib
{
	// Token: 0x02000010 RID: 16
	public class CModelTiering : global::AcpCommonLib.IAcpModelTiering
	{
		// Token: 0x0600005F RID: 95 RVA: 0x0001067C File Offset: 0x0000E87C
		static CModelTiering()
		{
			int a_ = 14;
			short num = (short)194838528;
			short num2 = num;
			num = (short)2085226668;
			short num3 = num;
			num = (short)384829612;
			switch (num3 == num)
			{
			}
			num = (short)569573377;
			if (num != 0)
			{
			}
			num = (short)893124608;
			if (num != 0)
			{
			}
			global::AcpModelTieringLib.CModelTiering.EncryptionEnabled = new global::System.Diagnostics.BooleanSwitch(global::AcpModelTieringLib.ErrorException.b("톾ꋀ뇂별럆뷈ꋊꋌꇎ铐뷒듔뗖뗘뻚맜", a_), global::AcpModelTieringLib.ErrorException.b("톾ꗀꫂꛄꛆ뷈껊뻌ꛐ믒냔ꏖ뇘뻚꿜￞軠釢엤触蛨鿪췬껮ꋰ룲헴蓶鳸飺裼跾栀眂簄✆怈砊ⴌ樎缐爒眔笖簘缚", a_), global::AcpModelTieringLib.ErrorException.b("즼춾듀ꛂ", a_));
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0001076C File Offset: 0x0000E96C
		public CModelTiering(string strModelTieringFilename)
		{
			this.a = strModelTieringFilename;
			this.b = "";
			this.c = new global::System.Xml.XmlDocument();
			this.d = null;
			this.u = "";
			this.v = "";
			this.w = "";
			this.x = "";
			this.y = "";
			this.z = "";
			this.aa = "";
			this.ab = "";
			this.ac = "";
			this.ad = "";
			this.ai = new global::System.Collections.Generic.List<string>();
			this.aj = new global::System.Collections.Generic.List<string>();
			this.ak = new global::System.Collections.Generic.Dictionary<int, string>();
			this.al = new global::System.Collections.Generic.Dictionary<string, string>();
			this.af = "";
			this.ah = "";
			this.am = new global::System.Collections.Generic.Dictionary<string, string>();
			this.an = new global::System.Collections.Generic.Dictionary<int, string>();
			this.e = null;
			this.f = null;
			this.g = null;
			this.h = null;
			this.i = null;
			this.j = null;
			this.n = null;
			this.k = null;
			this.l = null;
			this.m = null;
			this.o = null;
			this.p = null;
			this.q = null;
			this.r = null;
			this.s = null;
			this.t = null;
			if (global::AcpModelTieringLib.CModelTiering.EncryptionEnabled.Enabled)
			{
				global::AcpCryptoLib.AcpXMLEncryptDecrypt acpXMLEncryptDecrypt = new global::AcpCryptoLib.AcpXMLEncryptDecrypt();
				this.c = acpXMLEncryptDecrypt.DecryptXMLFile(this.a);
				return;
			}
			this.c.Load(this.a);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00010914 File Offset: 0x0000EB14
		public string FieldName
		{
			get
			{
				short num = (short)1845690368;
				short num2 = num;
				num = (short)1424679770;
				short num3 = num;
				num = (short)654107482;
				switch (num3 == num)
				{
				}
				num = (short)1332150273;
				if (num != 0)
				{
				}
				num = (short)375783424;
				if (num != 0)
				{
				}
				return this.u;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00010A74 File Offset: 0x0000EC74
		// (set) Token: 0x06000062 RID: 98 RVA: 0x000109C4 File Offset: 0x0000EBC4
		public string IsVisible
		{
			get
			{
				short num = (short)404750336;
				short num2 = num;
				num = (short)820768698;
				short num3 = num;
				num = (short)1866461114;
				switch (num3 == num)
				{
				}
				num = (short)179240961;
				if (num != 0)
				{
				}
				num = (short)835911680;
				if (num != 0)
				{
				}
				return this.v;
			}
			set
			{
				short num = (short)1862074368;
				short num2 = num;
				num = (short)870907905;
				if (num != 0)
				{
				}
				num = (short)1124621639;
				short num3 = num;
				num = (short)206986567;
				switch (num3 == num)
				{
				}
				num = (short)1354498048;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00010B24 File Offset: 0x0000ED24
		internal string IsVisible_OptExpr
		{
			get
			{
				short num = (short)469893120;
				short num2 = num;
				num = (short)1020437220;
				short num3 = num;
				num = (short)500343524;
				switch (num3 == num)
				{
				}
				num = (short)713555969;
				if (num != 0)
				{
				}
				num = (short)572719104;
				if (num != 0)
				{
				}
				return this.w;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00010BD4 File Offset: 0x0000EDD4
		public string DefaultValue
		{
			get
			{
				short num = (short)655556608;
				short num2 = num;
				num = (short)1331911535;
				short num3 = num;
				num = (short)1028021103;
				switch (num3 == num)
				{
				}
				num = (short)1465581568;
				if (num != 0)
				{
				}
				num = (short)598212609;
				if (num != 0)
				{
				}
				return this.x;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00010C84 File Offset: 0x0000EE84
		internal string OptionDefaultValue
		{
			get
			{
				short num = (short)1133051904;
				short num2 = num;
				num = (short)2042345369;
				short num3 = num;
				num = (short)1766832025;
				switch (num3 == num)
				{
				}
				num = (short)1177157632;
				if (num != 0)
				{
				}
				num = (short)18939905;
				if (num != 0)
				{
				}
				return this.ah;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00010D38 File Offset: 0x0000EF38
		public string MaxValue
		{
			get
			{
				short num = (short)1188757504;
				short num2 = num;
				num = (short)1678375085;
				short num3 = num;
				num = (short)1547827373;
				switch (num3 == num)
				{
				}
				num = (short)2025062401;
				if (num != 0)
				{
				}
				num = (short)908525568;
				if (num != 0)
				{
				}
				return this.y;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		public string MinValue
		{
			get
			{
				short num = (short)1015218176;
				short num2 = num;
				num = (short)1349989017;
				short num3 = num;
				num = (short)305476249;
				switch (num3 == num)
				{
				}
				num = (short)1899364353;
				if (num != 0)
				{
				}
				num = (short)677707776;
				if (num != 0)
				{
				}
				return this.z;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00010E94 File Offset: 0x0000F094
		public string StepSize
		{
			get
			{
				short num = (short)2041905152;
				short num2 = num;
				num = (short)1644888522;
				short num3 = num;
				num = (short)553845194;
				switch (num3 == num)
				{
				}
				num = (short)2103050241;
				if (num != 0)
				{
				}
				num = (short)883163136;
				if (num != 0)
				{
				}
				return this.aa;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		// (set) Token: 0x0600006A RID: 106 RVA: 0x00010F44 File Offset: 0x0000F144
		public global::System.Collections.Generic.List<string> ListOfValues
		{
			get
			{
				short num = (short)324927488;
				short num2 = num;
				num = (short)315686913;
				if (num != 0)
				{
				}
				num = (short)1516728360;
				short num3 = num;
				num = (short)1669689384;
				switch (num3 == num)
				{
				}
				num = (short)1565458432;
				if (num != 0)
				{
				}
				return this.ai;
			}
			set
			{
				short num = (short)1956380672;
				short num2 = num;
				num = (short)985399297;
				if (num != 0)
				{
				}
				num = (short)177546917;
				short num3 = num;
				num = (short)32974501;
				switch (num3 == num)
				{
				}
				num = (short)685375488;
				if (num != 0)
				{
				}
				this.ai = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600006C RID: 108 RVA: 0x000110A8 File Offset: 0x0000F2A8
		internal global::System.Collections.Generic.List<string> ListOfValuesOptions
		{
			get
			{
				short num = (short)1746141184;
				short num2 = num;
				num = (short)1094422084;
				short num3 = num;
				num = (short)622497348;
				switch (num3 == num)
				{
				}
				num = (short)875626496;
				if (num != 0)
				{
				}
				num = (short)1294663681;
				if (num != 0)
				{
				}
				return this.aj;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00011158 File Offset: 0x0000F358
		public string MaxNumOfRecords
		{
			get
			{
				short num = (short)2141847552;
				short num2 = num;
				num = (short)244992581;
				short num3 = num;
				num = (short)192563781;
				switch (num3 == num)
				{
				}
				num = (short)1295384577;
				if (num != 0)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				return this.ab;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0001120C File Offset: 0x0000F40C
		public string MaxpoolNumOfRecords
		{
			get
			{
				short num = (short)1630601216;
				short num2 = num;
				num = (short)95289345;
				if (num != 0)
				{
				}
				num = (short)538382605;
				short num3 = num;
				num = (short)528290061;
				switch (num3 == num)
				{
				}
				num = (short)645136384;
				if (num != 0)
				{
				}
				return this.ac;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000112BC File Offset: 0x0000F4BC
		public string MinNumOfRecords
		{
			get
			{
				short num = (short)1404502016;
				short num2 = num;
				num = (short)623583028;
				short num3 = num;
				num = (short)40443700;
				switch (num3 == num)
				{
				}
				num = (short)105185280;
				if (num != 0)
				{
				}
				num = (short)269746177;
				if (num != 0)
				{
				}
				return this.ad;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000070 RID: 112 RVA: 0x0001136C File Offset: 0x0000F56C
		public string DefaultNumOfRecords
		{
			get
			{
				short num = (short)2144993280;
				short num2 = num;
				num = (short)1413577133;
				short num3 = num;
				num = (short)1757051309;
				switch (num3 == num)
				{
				}
				num = (short)509804545;
				if (num != 0)
				{
				}
				num = (short)1336082432;
				if (num != 0)
				{
				}
				return this.ae;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0001141C File Offset: 0x0000F61C
		internal global::AcpModelTieringLib.CModelTiering.Initialization Initialize
		{
			get
			{
				int a_ = 15;
				switch (0)
				{
				case 0:
					goto IL_51;
				}
				int num;
				short num2;
				string text;
				global::AcpModelTieringLib.CModelTiering.Initialization result;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						num2 = (short)261160968;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (!(text == global::AcpModelTieringLib.ErrorException.b("ꖿ뗁藃ꣅ곇藉볋ꯍ뻏", a_)))
						{
							num2 = (short)673644555;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpModelTieringLib.CModelTiering.Initialization.NewAndOpen;
						num2 = (short)606404620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)681312257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					case 4:
						if (!(text == global::AcpModelTieringLib.ErrorException.b("ꖿ뗁诃ꣅ꓇돉", a_)))
						{
							num2 = (short)784269312;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpModelTieringLib.CModelTiering.Initialization.NewOnly;
						num2 = (short)1441660935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
					{
						num2 = (short)286654464;
						short num3 = num2;
						num2 = (short)1754005517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
						result = global::AcpModelTieringLib.CModelTiering.Initialization.NewOnly;
						num2 = (short)547225610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						return result;
					case 8:
						if (!(text == global::AcpModelTieringLib.ErrorException.b("낿ꟁ꫃觅ꛇꛉ뗋", a_)))
						{
							num2 = (short)985399301;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = global::AcpModelTieringLib.CModelTiering.Initialization.OpenOnly;
						num2 = (short)1728577545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						return result;
					case 10:
						return result;
					case 11:
						num2 = (short)1564344326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						return result;
					case 13:
					{
						if (!(text == global::AcpModelTieringLib.ErrorException.b("낿ꟁ꫃蟅ꛇ껉駋뻍럏ꃑ뗓닕뷗", a_)))
						{
							num2 = (short)1579548674;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1970012133;
						short num4 = num2;
						num2 = (short)2066481125;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1752104961;
							if (num2 != 0)
							{
							}
							num2 = (short)249757696;
							if (num2 != 0)
							{
							}
							result = global::AcpModelTieringLib.CModelTiering.Initialization.OpenAndUpgrade;
							break;
						}
						num2 = (short)664666115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_51;
				}
				return result;
				IL_51:
				text = this.af;
				num2 = (short)621805572;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000116FC File Offset: 0x0000F8FC
		internal string FieldOptionName
		{
			get
			{
				short num = (short)329842688;
				short num2 = num;
				num = (short)733872129;
				if (num != 0)
				{
				}
				num = (short)1745418890;
				short num3 = num;
				num = (short)246872714;
				switch (num3 == num)
				{
				}
				num = (short)1844248576;
				if (num != 0)
				{
				}
				return this.ag;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000073 RID: 115 RVA: 0x000117A8 File Offset: 0x0000F9A8
		internal global::System.Collections.Generic.Dictionary<int, string> DefaultValuePerRecord
		{
			get
			{
				short num = (short)953483264;
				short num2 = num;
				num = (short)1346830337;
				if (num != 0)
				{
				}
				num = (short)606996136;
				short num3 = num;
				num = (short)2054620840;
				switch (num3 == num)
				{
				}
				num = (short)1560215552;
				if (num != 0)
				{
				}
				return this.ak;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00011858 File Offset: 0x0000FA58
		internal global::System.Collections.Generic.Dictionary<int, string> OptionDefaultValuePerRecord
		{
			get
			{
				short num = (short)1002700800;
				short num2 = num;
				num = (short)1434533011;
				short num3 = num;
				num = (short)1761361043;
				switch (num3 == num)
				{
				}
				num = (short)1573519360;
				if (num != 0)
				{
				}
				num = (short)1921974273;
				if (num != 0)
				{
				}
				return this.an;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00011908 File Offset: 0x0000FB08
		internal global::System.Collections.Generic.Dictionary<string, string> DefaultValuePerEmbeddedRecord
		{
			get
			{
				short num = (short)1858732032;
				short num2 = num;
				num = (short)1727524950;
				short num3 = num;
				num = (short)221966422;
				switch (num3 == num)
				{
				}
				num = (short)1484980224;
				if (num != 0)
				{
				}
				num = (short)66322433;
				if (num != 0)
				{
				}
				return this.al;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000119B4 File Offset: 0x0000FBB4
		internal global::System.Collections.Generic.Dictionary<string, string> OptionDefaultValuePerEmbeddedRecord
		{
			get
			{
				short num = (short)1954217984;
				short num2 = num;
				num = (short)410451969;
				if (num != 0)
				{
				}
				num = (short)126056885;
				short num3 = num;
				num = (short)1709799861;
				switch (num3 == num)
				{
				}
				num = (short)988282880;
				if (num != 0)
				{
				}
				return this.am;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00011A64 File Offset: 0x0000FC64
		internal static int MaxNumOfComboOpts
		{
			get
			{
				short num = (short)774832128;
				short num2 = num;
				num = (short)185802667;
				short num3 = num;
				num = (short)1730813867;
				switch (num3 == num)
				{
				}
				num = (short)112852993;
				if (num != 0)
				{
				}
				num = (short)948436992;
				if (num != 0)
				{
				}
				return 150;
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00011B14 File Offset: 0x0000FD14
		internal bool b(string A_0, string A_1)
		{
			int a_ = 4;
			short num = (short)1246494720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1584332800;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<string>.Enumerator enumerator;
				string[] separator;
				bool result;
				for (;;)
				{
					IL_5B:
					switch (num2)
					{
					case 0:
						goto IL_312;
					case 1:
						try
						{
							num = (short)758317057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num4;
								switch (num2)
								{
								case 0:
								{
									string text;
									list.Add(text.Trim());
									num = (short)859504646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_154;
									}
									continue;
								case 2:
									goto IL_1D2;
								case 3:
									goto IL_24D;
								case 4:
								{
									string[] array;
									if (num4 >= array.Length)
									{
										num = (short)421593098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = array[num4];
									num = (short)643563527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1D2;
								case 6:
									goto IL_2C2;
								case 7:
								{
									string text;
									if (!list.Contains(text.Trim()))
									{
										num = (short)1902575616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C2;
								}
								case 8:
									goto IL_2FF;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2018246659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1329286520;
									short num5 = num;
									num = (short)943607160;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_24D;
									default:
									{
										num = (short)1398145024;
										if (num != 0)
										{
										}
										string[] array = enumerator.Current.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
										num4 = 0;
										num = (short)1528233986;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								}
								goto IL_154;
								IL_1D2:
								num = (short)931856388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20F:
								num = (short)1615921161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_154:
								goto IL_20F;
								IL_24D:
								num = (short)1531707400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C2:
								num4++;
								num = (short)987955205;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FF:
							goto IL_BE;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_312;
						IL_BE:
						num = (short)1696006147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (list.Contains(A_1.Trim()))
						{
							num = (short)1459945472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_72;
					IL_312:
					result = true;
					num = (short)197787649;
					if (num != 0)
					{
					}
					num = (short)1141506050;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_72:
				new global::System.Collections.Generic.List<string>();
				list = new global::System.Collections.Generic.List<string>();
				separator = new string[]
				{
					global::AcpModelTieringLib.ErrorException.b("颲", a_)
				};
				result = false;
				enumerator = this.b(A_0).GetEnumerator();
				num = (short)40566785;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_5B;
			}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00011E98 File Offset: 0x00010098
		internal global::System.Collections.Generic.List<string> b(string A_0)
		{
			int a_ = 9;
			short num = (short)1591738368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_31:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_255;
					case 1:
					{
						num = (short)1058406401;
						if (num != 0)
						{
						}
						num = (short)1460207616;
						short num3 = num;
						try
						{
							num = (short)657915904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F0;
									}
									continue;
								case 1:
									num = (short)797704195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_18C;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2011955201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									list.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("횷\udbb9톻\udbbd", a_)].Value);
									num = (short)2090401794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_F2:
								num = (short)265027588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F0:
								goto IL_F2;
							}
							IL_18C:
							return list;
						}
						finally
						{
							num = (short)2025741810;
							short num4 = num;
							num = (short)1341414898;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_21D:
								num = (short)1737031680;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1047658496;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_1FB;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1E8:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)483786753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_252;
								case 2:
									goto IL_219;
								}
								goto IL_1FB;
							}
							IL_219:
							if (disposable != null)
							{
								goto IL_21D;
							}
							IL_252:
							goto EndFinally_5;
							IL_1FB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)513671170;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E8;
							EndFinally_5:;
						}
						goto IL_255;
					}
					case 2:
						if (xmlNodeList.Count > 0)
						{
							num = (short)1448542208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					goto IL_44;
					IL_255:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)1045495809;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_44:
				list = new global::System.Collections.Generic.List<string>();
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("鞷펻\udabdꖿ껁럃藇ꗉ꣋ꯍ볏觑铓룕맗럙맛쟟", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("龷鎻낿뛁귃꧅ꛇ", a_));
				num = (short)1550385154;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00012180 File Offset: 0x00010380
		internal string[] b(string A_0, global::System.Collections.Generic.Dictionary<string, bool> A_1)
		{
			int a_ = 14;
			short num = (short)1993605120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::System.Xml.XmlNodeList xmlNodeList;
				string[] array;
				string[] array2;
				for (;;)
				{
					IL_31:
					int num5;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_3D3;
					case 1:
						if (xmlNodeList.Count > 0)
						{
							num = (short)613613578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_437;
					case 2:
					{
						string text = text.Substring(text.IndexOf(global::AcpModelTieringLib.ErrorException.b("隼", a_)) + 1);
						num = (short)1535508491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_323;
					case 4:
						try
						{
							num = (short)1919811587;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1775697921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_25C;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)152436736;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string value = ((global::System.Xml.XmlNode)enumerator.Current).Attributes[global::AcpModelTieringLib.ErrorException.b("펼\udebe곀ꛂ", a_)].Value;
									int num3;
									array[num3++] = this.a(value).ToString() + global::AcpModelTieringLib.ErrorException.b("隼", a_) + value;
									num = (short)1528365060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_194;
									}
									continue;
								}
								IL_196:
								num = (short)1361051650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_194:
								goto IL_196;
							}
							IL_25C:
							goto IL_437;
						}
						finally
						{
							num = (short)1920780509;
							short num4 = num;
							num = (short)1833748701;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_2EC:
								num = (short)1599012866;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)891420672;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_2C9;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2B6:
								switch (num2)
								{
								case 0:
									goto IL_320;
								case 1:
									goto IL_2E8;
								case 2:
									disposable.Dispose();
									num = (short)826474496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2C9;
							}
							IL_2E8:
							if (disposable != null)
							{
								goto IL_2EC;
							}
							IL_320:
							goto EndFinally_8;
							IL_2C9:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1731592193;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2B6;
							EndFinally_8:;
						}
						goto IL_323;
					case 5:
					{
						string text;
						array2[num5++] = text;
						num = (short)201392131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (num6 >= array.Length)
						{
							num = (short)1430454279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = array[num6];
						num = (short)1107427336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return array2;
					case 8:
					{
						string text;
						if (text != null)
						{
							num = (short)1994784770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					}
					case 9:
						goto IL_3D3;
					case 10:
					{
						int num3 = 0;
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)622460932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						string text;
						if (this.a(text, A_1))
						{
							num = (short)441450501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_323;
					}
					}
					goto IL_68;
					IL_323:
					num6++;
					num = (short)1661599753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D3:
					num = (short)1960312833;
					if (num != 0)
					{
					}
					num = (short)1406205958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_437:
					num = (short)1863254016;
					short num7 = num;
					global::System.Array.Sort<string>(array);
					global::System.Array.Reverse(array);
					num5 = 0;
					num6 = 0;
					num = (short)2060517376;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array2;
				IL_68:
				array = new string[150];
				array2 = new string[150];
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("銼껀Ꟃꃄꯆ뫈背ꃎ뗐뛒맔賖駘뗚볜닞蓠\udee2실", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("骼賂뗄돆ꃈ꓊ꏌ铎釐꟒곔Ꟗ볘﫜鳞軠転蟤軦蟨軪觬ꃮ臰蟲鳴飶韸裺\udafcꋾ", a_));
				num = (short)1832910849;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0001263C File Offset: 0x0001083C
		private bool a(string A_0, global::System.Collections.Generic.Dictionary<string, bool> A_1)
		{
			int a_ = 12;
			short num = (short)1668677632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C4;
				}
				bool flag;
				int num5;
				string[] array;
				bool flag2;
				for (;;)
				{
					IL_30:
					num = (short)851960415;
					short num3 = num;
					num = (short)1794433631;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return flag;
					default:
						num = (short)930873345;
						if (num != 0)
						{
						}
						num = (short)1085145088;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							return flag;
						case 1:
						{
							string key;
							if (A_1.ContainsKey(key))
							{
								num = (short)954335238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_109;
						}
						case 2:
							goto IL_198;
						case 3:
						{
							num = (short)1666514944;
							short num4 = num;
							if (num5 >= array.Length)
							{
								num = (short)903872512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string key = array[num5];
							flag2 = false;
							num = (short)1073283073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_109;
						case 5:
							goto IL_198;
						case 6:
						{
							string key;
							flag2 = A_1[key];
							num = (short)2039152644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_C4;
						IL_109:
						flag = (flag && flag2);
						num5++;
						num = (short)879493125;
						num2 = (int)((global::System.IntPtr)num);
						break;
						IL_198:
						num = (short)2079719427;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return flag;
				IL_C4:
				flag = true;
				flag2 = false;
				string[] separator = new string[]
				{
					global::AcpModelTieringLib.ErrorException.b("邺", a_)
				};
				array = A_0.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries);
				num5 = 0;
				num = (short)218234882;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00012848 File Offset: 0x00010A48
		private int a(string A_0)
		{
			int a_ = 3;
			short num = (short)828432;
			short num2 = num;
			num = (short)420062224;
			switch (num2 == num)
			{
			}
			num = (short)691863552;
			short num3 = num;
			num = (short)53084161;
			if (num != 0)
			{
			}
			num = (short)551878656;
			if (num != 0)
			{
			}
			string[] separator = new string[]
			{
				global::AcpModelTieringLib.ErrorException.b("馱", a_)
			};
			return A_0.Split(separator, global::System.StringSplitOptions.RemoveEmptyEntries).Length;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0001291C File Offset: 0x00010B1C
		internal global::System.Collections.Generic.List<string> c(string A_0)
		{
			int a_ = 0;
			short num = (short)212271104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_30:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)913833984;
						short num3 = num;
						try
						{
							num = (short)328466435;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)423690241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_18C;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1005780992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									list.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("솮킰\udeb2킴", a_)].Value);
									num = (short)1806827524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_EE;
									}
									continue;
								}
								IL_F0:
								num = (short)208666626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EE:
								goto IL_F0;
							}
							IL_18C:
							return list;
						}
						finally
						{
							num = (short)276391401;
							short num4 = num;
							num = (short)1276863977;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_21C:
								num = (short)1926627330;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1080688640;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_1FB;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1E8:
								switch (num2)
								{
								case 0:
									goto IL_253;
								case 1:
									goto IL_218;
								case 2:
									disposable.Dispose();
									num = (short)830144512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1FB;
							}
							IL_218:
							if (disposable != null)
							{
								goto IL_21C;
							}
							IL_253:
							goto EndFinally_5;
							IL_1FB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1957560321;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E8;
							EndFinally_5:;
						}
						goto IL_256;
					}
					case 1:
						if (xmlNodeList.Count > 0)
						{
							num = (short)1931804674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 2:
						goto IL_256;
					}
					goto IL_43;
					IL_256:
					num = (short)521732097;
					if (num != 0)
					{
					}
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)128647168;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_43:
				list = new global::System.Collections.Generic.List<string>();
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("肮ﲰ\udcb2톴튶햸좺銼껀Ꟃꃄꯆ鋈诊ꏌ껎볐뛒", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("袮鲲잶\udcb8\ud8ba풼\udebe귀藂계ꋆꗈ꿊뻌铎釐꟒곔Ꟗ볘﫜髞鏠蓢諤샦듨쓪꯬蛮铰鿲釴", a_));
				num = (short)903479297;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00012C08 File Offset: 0x00010E08
		internal global::System.Collections.Generic.List<string> d(string A_0)
		{
			int a_ = 5;
			short num = (short)1399848960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Xml.XmlNodeList xmlNodeList;
				for (;;)
				{
					IL_31:
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)238157824;
						short num3 = num;
						try
						{
							num = (short)1410531331;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)722075649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1B9;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1045430272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
									list.Add(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("\udab3ힵ햷\udfb9", a_)].Value);
									num = (short)280035332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11B;
									}
									continue;
								}
								IL_11D:
								num = (short)973340674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B:
								goto IL_11D;
							}
							IL_1B9:
							return list;
						}
						finally
						{
							num = (short)813181883;
							short num4 = num;
							num = (short)627583931;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_249:
								num = (short)1957691394;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)162201600;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_227;
								}
								break;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_214:
								switch (num2)
								{
								case 0:
									goto IL_27F;
								case 1:
									goto IL_245;
								case 2:
									disposable.Dispose();
									num = (short)869466112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_227;
							}
							IL_245:
							if (disposable != null)
							{
								goto IL_249;
							}
							IL_27F:
							goto EndFinally_5;
							IL_227:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)671940609;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_214;
							EndFinally_5:;
						}
						goto IL_282;
					}
					case 1:
						if (xmlNodeList.Count > 0)
						{
							num = (short)868876289;
							if (num != 0)
							{
							}
							num = (short)348651522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 2:
						goto IL_282;
					}
					goto IL_44;
					IL_282:
					enumerator = xmlNodeList.GetEnumerator();
					num = (short)38076416;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_44:
				list = new global::System.Collections.Generic.List<string>();
				xmlNodeList = this.c.SelectNodes(global::AcpModelTieringLib.ErrorException.b("鮳﮵ힷ\udeb9\ud9bb튽뎿觃꧅곇꿉ꃋ闍郏병뗓믕뷗ﯛ", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("鎳鞷ﲹ\uddbb\uddbd뒿귁뛃뿅诇뿉뿋뫍뿏뿑뷓곕맗껙뗛뇝軟췡ꯣ雥鳧菩菫胭", a_));
				num = (short)1409417217;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00012EF8 File Offset: 0x000110F8
		internal bool e(string A_0)
		{
			int a_ = 16;
			short num = (short)157140923;
			short num2 = num;
			num = (short)323995579;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E0:
				num = (short)1089536002;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1049821184;
				if (num != 0)
				{
				}
				num = (short)192741376;
				short num4 = num;
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				break;
			}
			}
			bool flag;
			string strFieldToRetrieve;
			for (;;)
			{
				IL_86:
				switch (num3)
				{
				case 0:
					return flag;
				case 1:
					goto IL_DA;
				case 2:
					num = (short)1717239809;
					if (num != 0)
					{
					}
					strFieldToRetrieve = global::AcpModelTieringLib.ErrorException.b("邾賀곂ꇄꋆꗈ룊苎뻐럒냔믖鷚룜뻞闠離韤苦단ꯪ菬軮鳰雲죴탶", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("颾鳀", a_);
					flag = this.GetFieldFromTieringFile(strFieldToRetrieve);
					num = (short)2015428608;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_98;
			}
			IL_DA:
			if (!flag)
			{
				goto IL_E0;
			}
			return flag;
			IL_98:
			flag = false;
			strFieldToRetrieve = global::AcpModelTieringLib.ErrorException.b("邾賀곂ꇄꋆꗈ룊苎뻐럒냔믖苘鯚돜뻞賠蛢\ud8e4샦", a_) + A_0 + global::AcpModelTieringLib.ErrorException.b("颾鳀", a_);
			flag = this.GetFieldFromTieringFile(strFieldToRetrieve);
			num = (short)960692225;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0001306C File Offset: 0x0001126C
		public bool GetFieldFromTieringFile(string strFieldToRetrieve)
		{
			int a_ = 19;
			short num = (short)394133504;
			short num2 = num;
			num = (short)13434880;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)2068054017;
				if (num != 0)
				{
				}
				bool result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					for (;;)
					{
						IL_86:
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.IEnumerator enumerator = this.d.GetEnumerator();
							num = (short)841220098;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_1889;
						case 2:
							try
							{
								num = (short)299368505;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Xml.XmlNode xmlNode3;
									switch (num3)
									{
									case 0:
										this.x = this.g.InnerText;
										num = (short)1109000204;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_700;
									case 2:
										goto IL_7E1;
									case 3:
										goto IL_E70;
									case 4:
										goto IL_5C7;
									case 5:
										if (this.m != null)
										{
											num = (short)402587658;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_86D;
									case 6:
										this.u = this.e.InnerText;
										num = (short)1825112080;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										if (this.g != null)
										{
											num = (short)398327808;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4E0;
									case 8:
										this.z = this.i.InnerText;
										num = (short)436600834;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										this.ae = this.o.InnerText;
										num = (short)1132068902;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										this.ad = this.m.InnerText;
										num = (short)2078867479;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										if (this.f.Attributes.Count > 0)
										{
											num = (short)986382390;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_10BC;
									case 12:
										goto IL_4E0;
									case 13:
										try
										{
											num = (short)225837056;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Xml.XmlNode xmlNode;
												global::System.Collections.IEnumerator enumerator3;
												switch (num3)
												{
												case 0:
													switch (0)
													{
													case 0:
														goto IL_1296;
													}
													continue;
												case 1:
												{
													global::System.Collections.IEnumerator enumerator2 = xmlNode.GetEnumerator();
													num = (short)1588396034;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 2:
													try
													{
														num = (short)1968439297;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
															{
																num = (short)932093053;
																short num4 = num;
																num = (short)1434033277;
																switch ((num4 == num) ? 1 : 0)
																{
																case 0:
																case 2:
																	break;
																default:
																{
																	num = (short)1148911616;
																	if (num != 0)
																	{
																	}
																	global::System.Collections.IEnumerator enumerator2;
																	if (!enumerator2.MoveNext())
																	{
																		num = (short)1040711683;
																		num3 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator2.Current;
																	this.al.Add(global::System.Convert.ToString(global::System.Convert.ToInt32(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1) + global::AcpModelTieringLib.ErrorException.b("鷁", a_) + global::System.Convert.ToString(global::System.Convert.ToInt32(xmlNode2.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1), xmlNode2.InnerText.Trim());
																	num = (short)156368900;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																}
																break;
															}
															case 1:
																switch (0)
																{
																case 0:
																	goto IL_132D;
																}
																continue;
															case 2:
																goto IL_1481;
															case 3:
																num = (short)1106378754;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															IL_13DC:
															num = (short)1613627392;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_132D:
															goto IL_13DC;
														}
														IL_1481:
														break;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_14A3;
														}
														global::System.IDisposable disposable;
														for (;;)
														{
															IL_1490:
															switch (num3)
															{
															case 0:
																goto IL_14FA;
															case 1:
																disposable.Dispose();
																num = (short)271974400;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 2:
																if (disposable != null)
																{
																	num = (short)1203699713;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_14FC;
															}
															goto IL_14A3;
														}
														IL_14FA:
														IL_14FC:
														goto EndFinally_53;
														IL_14A3:
														global::System.Collections.IEnumerator enumerator2;
														disposable = (enumerator2 as global::System.IDisposable);
														num = (short)757727234;
														num3 = (int)((global::System.IntPtr)num);
														goto IL_1490;
														EndFinally_53:;
													}
													goto IL_14FD;
												case 3:
													goto IL_15D7;
												case 4:
													if (!enumerator3.MoveNext())
													{
														num = (short)1399062534;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_14FD;
												case 5:
													if (xmlNode.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蟁꧃꓅귇껉꣋ꯍ듏胑뇓뗕럗꣙룛", a_)) != null)
													{
														num = (short)982712321;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													this.ak.Add(global::System.Convert.ToInt32(xmlNode.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1, xmlNode.InnerText.Trim());
													num = (short)2138177543;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 6:
													num = (short)1770848259;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_1296;
												IL_14FD:
												xmlNode = (global::System.Xml.XmlNode)enumerator3.Current;
												num = (short)1642004485;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_157E:
												num = (short)1632894980;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_1296:
												goto IL_157E;
											}
											IL_15D7:
											goto IL_6A4;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_15F9;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_15E6:
												switch (num3)
												{
												case 0:
													goto IL_164E;
												case 1:
													disposable.Dispose();
													num = (short)989528064;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													if (disposable != null)
													{
														num = (short)958726145;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_1650;
												}
												goto IL_15F9;
											}
											IL_164E:
											IL_1650:
											goto EndFinally_54;
											IL_15F9:
											global::System.Collections.IEnumerator enumerator3;
											disposable = (enumerator3 as global::System.IDisposable);
											num = (short)1203240962;
											num3 = (int)((global::System.IntPtr)num);
											goto IL_15E6;
											EndFinally_54:;
										}
										goto IL_1651;
									case 14:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)479002670;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										xmlNode3 = (global::System.Xml.XmlNode)enumerator.Current;
										this.e = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蓁귃ꏅ꓇껉駋蟍黏돑맓돕", a_));
										num = (short)209584173;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
										goto IL_923;
									case 16:
										goto IL_A61;
									case 17:
										num = (short)762249251;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										goto IL_53D;
									case 19:
										this.ag = this.r.Attributes[global::AcpModelTieringLib.ErrorException.b("곁ꗃꯅ귇", a_)].Value;
										num = (short)1657471020;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 20:
										if (this.o != null)
										{
											num = (short)1478295561;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_11F4;
									case 21:
										this.ab = this.k.InnerText;
										num = (short)1219887119;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 22:
										if (this.l != null)
										{
											num = (short)1807220786;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_119A;
									case 23:
										goto IL_86D;
									case 24:
										this.aa = this.j.InnerText;
										num = (short)1511063553;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 25:
										this.ah = this.s.InnerText;
										num = (short)459735044;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 26:
										goto IL_119A;
									case 27:
										try
										{
											num = (short)1159921668;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num3)
												{
												case 0:
												{
													global::System.Xml.XmlNode xmlNode4;
													global::System.Collections.IEnumerator enumerator2 = xmlNode4.GetEnumerator();
													num = (short)1888485382;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 1:
													goto IL_DDD;
												case 2:
												{
													global::System.Xml.XmlNode xmlNode4;
													if (xmlNode4.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蟁꧃꓅귇껉꣋ꯍ듏胑뇓뗕럗꣙룛", a_)) != null)
													{
														num = (short)1587937280;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													this.an.Add(global::System.Convert.ToInt32(xmlNode4.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1, xmlNode4.InnerText.Trim());
													num = (short)1786183687;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
												{
													global::System.Collections.IEnumerator enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)265158657;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::System.Xml.XmlNode xmlNode4 = (global::System.Xml.XmlNode)enumerator3.Current;
													num = (short)916324354;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 4:
													switch (0)
													{
													case 0:
														goto IL_B02;
													}
													continue;
												case 5:
													goto IL_DF6;
												case 6:
													try
													{
														num = (short)345964546;
														num3 = (int)((global::System.IntPtr)num);
														for (;;)
														{
															switch (num3)
															{
															case 0:
																num = (short)1087242244;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
															{
																global::System.Collections.IEnumerator enumerator2;
																if (!enumerator2.MoveNext())
																{
																	num = (short)485490688;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																global::System.Xml.XmlNode xmlNode5 = (global::System.Xml.XmlNode)enumerator2.Current;
																global::System.Xml.XmlNode xmlNode4;
																this.am.Add(global::System.Convert.ToString(global::System.Convert.ToInt32(xmlNode4.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1) + global::AcpModelTieringLib.ErrorException.b("鷁", a_) + global::System.Convert.ToString(global::System.Convert.ToInt32(xmlNode5.Attributes[global::AcpModelTieringLib.ErrorException.b("곁뇃ꯅ꫇꿉뻋", a_)].InnerText) - 1), xmlNode5.InnerText.Trim());
																num = (short)1633878019;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															}
															case 2:
																switch (0)
																{
																case 0:
																	goto IL_C5A;
																}
																continue;
															case 4:
																goto IL_D5F;
															}
															IL_D08:
															num = (short)812908545;
															num3 = (int)((global::System.IntPtr)num);
															continue;
															IL_C5A:
															goto IL_D08;
														}
														IL_D5F:
														break;
													}
													finally
													{
														switch (0)
														{
														case 0:
															goto IL_D81;
														}
														global::System.IDisposable disposable;
														for (;;)
														{
															IL_D6E:
															switch (num3)
															{
															case 0:
																disposable.Dispose();
																num = (short)236257282;
																num3 = (int)((global::System.IntPtr)num);
																continue;
															case 1:
																if (disposable != null)
																{
																	num = (short)917504;
																	num3 = (int)((global::System.IntPtr)num);
																	continue;
																}
																goto IL_DDC;
															case 2:
																goto IL_DDA;
															}
															goto IL_D81;
														}
														IL_DDA:
														IL_DDC:
														goto EndFinally_51;
														IL_D81:
														global::System.Collections.IEnumerator enumerator2;
														disposable = (enumerator2 as global::System.IDisposable);
														num = (short)1181483009;
														num3 = (int)((global::System.IntPtr)num);
														goto IL_D6E;
														EndFinally_51:;
													}
													goto IL_DDD;
												}
												IL_B82:
												num = (short)1175912451;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_B02:
												goto IL_B82;
												IL_DDD:
												num = (short)2067136517;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_DF6:
											break;
										}
										finally
										{
											switch (0)
											{
											case 0:
												goto IL_E18;
											}
											global::System.IDisposable disposable;
											for (;;)
											{
												IL_E05:
												switch (num3)
												{
												case 0:
													disposable.Dispose();
													num = (short)2124414978;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													if (disposable != null)
													{
														num = (short)1536425984;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_E6F;
												case 2:
													goto IL_E6D;
												}
												goto IL_E18;
											}
											IL_E6D:
											IL_E6F:
											goto EndFinally_52;
											IL_E18:
											global::System.Collections.IEnumerator enumerator3;
											disposable = (enumerator3 as global::System.IDisposable);
											num = (short)1783496705;
											num3 = (int)((global::System.IntPtr)num);
											goto IL_E05;
											EndFinally_52:;
										}
										goto Block_18;
									case 28:
										if (this.j != null)
										{
											num = (short)800522264;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_700;
									case 29:
									{
										global::System.Collections.IEnumerator enumerator3 = this.p.GetEnumerator();
										num = (short)691273741;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 30:
										if (this.k != null)
										{
											num = (short)476315669;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_923;
									case 31:
									{
										global::System.Collections.IEnumerator enumerator3 = this.t.GetEnumerator();
										num = (short)176554011;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 32:
										goto IL_178E;
									case 33:
										this.y = this.h.InnerText;
										num = (short)1925251114;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 34:
										if (this.s != null)
										{
											num = (short)24313881;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5C7;
									case 35:
										if (this.r.Attributes.Count > 0)
										{
											num = (short)2020999187;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										this.ag = "";
										num = (short)747765797;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 36:
										if (this.q != null)
										{
											num = (short)1358299192;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_10E4;
									case 37:
										goto IL_1651;
									case 38:
										goto IL_11F4;
									case 39:
										if (this.t != null)
										{
											num = (short)1982791711;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 40:
										if (this.f != null)
										{
											num = (short)544342071;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_53D;
									case 41:
									{
										global::System.Collections.IEnumerator enumerator3 = this.n.GetEnumerator();
										num = (short)1994129411;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 42:
										goto IL_393;
									case 43:
										if (this.i != null)
										{
											num = (short)1446248456;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_7E1;
									case 44:
										goto IL_1651;
									case 45:
										if (this.e != null)
										{
											num = (short)282263558;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A61;
									case 46:
										num = (short)1380384800;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 47:
										if (this.h != null)
										{
											num = (short)274071585;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_393;
									case 48:
										goto IL_10E4;
									case 49:
										if (this.p != null)
										{
											num = (short)1778188317;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_6A4;
									case 50:
										this.ac = this.l.InnerText;
										num = (short)898498586;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 51:
										if (this.r != null)
										{
											num = (short)624230417;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 52:
										goto IL_53D;
									case 53:
										if (this.n != null)
										{
											num = (short)1168834601;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_41D;
									case 54:
										this.w = this.f.Attributes[global::AcpModelTieringLib.ErrorException.b("귁듃닅ꇇꗉꋋ", a_)].Value;
										num = (short)1969553426;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 55:
										this.v = this.f.InnerText;
										num = (short)753926155;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 56:
										this.af = this.q.InnerText;
										num = (short)2018508848;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 57:
										switch (0)
										{
										case 0:
											goto IL_364;
										}
										continue;
									}
									goto IL_364;
									IL_393:
									this.i = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("迁귃ꣅ黇ꯉꃋ믍뗏", a_));
									num = (short)900988971;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_41D:
									this.k = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("迁ꗃ뻅蛇뿉ꇋ臍뛏胑뇓뗕럗꣙룛귝", a_));
									num = (short)440860702;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									Block_18:
									try
									{
										IL_E70:
										num = (short)1246953478;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::System.Xml.XmlNode xmlNode6;
												this.aj.Add(xmlNode6.Attributes[global::AcpModelTieringLib.ErrorException.b("귁듃닅ꇇꗉꋋ", a_)].Value);
												num = (short)2112290823;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												num = (short)1344471043;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												global::System.Xml.XmlNode xmlNode6;
												if (xmlNode6.Name == global::AcpModelTieringLib.ErrorException.b("铁ꗃ꫅뷇꿉", a_))
												{
													num = (short)1961689093;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												goto IL_1043;
											case 4:
											{
												global::System.Xml.XmlNode xmlNode6;
												if (xmlNode6.Attributes.Count > 0)
												{
													num = (short)499908608;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												this.aj.Add("");
												num = (short)1569521673;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::System.Xml.XmlNode xmlNode6;
												this.ai.Add(xmlNode6.InnerText);
												num = (short)1473052676;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												switch (0)
												{
												case 0:
													goto IL_EBE;
												}
												continue;
											case 8:
											{
												global::System.Collections.IEnumerator enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)1514405889;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Xml.XmlNode xmlNode6 = (global::System.Xml.XmlNode)enumerator3.Current;
												num = (short)1454047234;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_F02:
											num = (short)1113915400;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_EBE:
											goto IL_F02;
										}
										IL_1043:
										goto IL_41D;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_1065;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_1052:
											switch (num3)
											{
											case 0:
												goto IL_10B9;
											case 1:
												disposable.Dispose();
												num = (short)1655504896;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (disposable != null)
												{
													num = (short)596115457;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_10BB;
											}
											goto IL_1065;
										}
										IL_10B9:
										IL_10BB:
										goto EndFinally_50;
										IL_1065:
										global::System.Collections.IEnumerator enumerator3;
										disposable = (enumerator3 as global::System.IDisposable);
										num = (short)1831141378;
										num3 = (int)((global::System.IntPtr)num);
										goto IL_1052;
										EndFinally_50:;
									}
									goto IL_10BC;
									IL_4E0:
									this.h = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("迁ꗃ뻅黇ꯉꃋ믍뗏", a_));
									num = (short)216465455;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_53D:
									this.g = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蛁ꇃꃅ꧇뿉ꃋ뫍蛏돑룓ꏕ뷗", a_));
									num = (short)1545994247;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_5C7:
									this.t = this.r.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蛁ꇃꃅ꧇뿉ꃋ뫍蛏돑룓ꏕ뷗諙맛곝닟蟡蟣觥髧軩", a_));
									num = (short)1458831399;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_6A4:
									this.o = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蛁ꇃꃅ꧇뿉ꃋ뫍黏ꟑ맓駕뻗裙맛뷝迟郡胣闥", a_));
									num = (short)1317208084;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_700:
									this.n = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("軁귃뗅볇藉꫋飍뇏뻑ꇓ돕ꯗ", a_));
									num = (short)1205338165;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_7E1:
									this.j = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("釁냃ꏅ룇駉ꗋ듍뗏", a_));
									num = (short)1506017308;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_86D:
									this.p = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蛁ꇃꃅ꧇뿉ꃋ뫍蛏돑룓ꏕ뷗諙맛곝닟蟡蟣觥髧軩", a_));
									num = (short)363986993;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_923:
									this.l = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("迁ꗃ뻅룇ꗉꏋꋍ黏ꟑ맓駕뻗裙맛뷝迟郡胣闥", a_));
									num = (short)2096365590;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_A61:
									this.f = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("证럃郅ꇇ막ꗋ곍볏럑", a_));
									num = (short)849805352;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_10BC:
									this.w = "";
									num = (short)747044916;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_10E4:
									this.r = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("跁듃닅ꇇꗉꋋ", a_));
									num = (short)710344755;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_119A:
									this.m = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("迁귃ꣅ蛇뿉ꇋ臍뛏胑뇓뗕럗꣙룛귝", a_));
									num = (short)1067646981;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_11F4:
									this.q = xmlNode3.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("证꫃꿅볇ꏉ귋ꋍ맏꣑뇓", a_));
									num = (short)386662436;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1651:
									this.s = this.r.SelectSingleNode(global::AcpModelTieringLib.ErrorException.b("蛁ꇃꃅ꧇뿉ꃋ뫍蛏돑룓ꏕ뷗", a_));
									num = (short)539164706;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_16DF:
									num = (short)1998389262;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_364:
									goto IL_16DF;
								}
								IL_178E:
								goto IL_1851;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_17B0;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_179D:
									switch (num3)
									{
									case 0:
										goto IL_1806;
									case 1:
										disposable.Dispose();
										num = (short)1434451968;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										if (disposable != null)
										{
											num = (short)110624769;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1808;
									}
									goto IL_17B0;
								}
								IL_1806:
								IL_1808:
								goto EndFinally_55;
								IL_17B0:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1284898818;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_179D;
								EndFinally_55:;
							}
							goto IL_1809;
							IL_1851:
							result = true;
							num = (short)655163396;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_186F;
						case 4:
							goto IL_186F;
						case 5:
							if (this.d.Count > 0)
							{
								num = (short)1588264960;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1809;
						}
						goto IL_A5;
						IL_1809:
						result = false;
						num = (short)2050424835;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_186F:
						num = (short)340852737;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1889:
					return result;
					IL_A5:
					this.b = strFieldToRetrieve;
					this.d = this.c.SelectNodes(this.b);
					this.u = "";
					this.v = "";
					this.w = "";
					this.x = "";
					this.y = "";
					this.z = "";
					this.aa = "";
					this.ab = "";
					this.ac = "";
					this.ad = "";
					this.ae = "";
					this.af = "";
					this.ai.Clear();
					this.aj.Clear();
					this.ak.Clear();
					this.al.Clear();
					this.e = null;
					this.f = null;
					this.g = null;
					this.h = null;
					this.i = null;
					this.j = null;
					this.n = null;
					this.k = null;
					this.l = null;
					this.m = null;
					this.o = null;
					this.p = null;
					this.q = null;
					this.r = null;
					this.ag = "";
					this.s = null;
					this.ah = "";
					this.t = null;
					this.am.Clear();
					this.an.Clear();
					num = (short)96796677;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_86;
				}
				catch (global::System.Exception)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000149B4 File Offset: 0x00012BB4
		private int a(global::System.Collections.Generic.List<string> A_0, string A_1)
		{
			short num = (short)1392246784;
			short num2 = num;
			num = (short)1261772051;
			short num3 = num;
			num = (short)1427381523;
			int result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)11796480;
				if (num != 0)
				{
				}
				num = (short)2143027200;
				switch (num)
				{
				default:
				{
					result = -1;
					int num4 = -1;
					string text = "";
					string text2 = "";
					char c = '\t';
					char c2 = '\u00a0';
					char c3 = ' ';
					global::System.Collections.Generic.List<string>.Enumerator enumerator = A_0.GetEnumerator();
					try
					{
						num = (short)901054464;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_FE;
								}
								continue;
							case 1:
								num = (short)1628504069;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (text == text2)
								{
									num = (short)940834820;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_229;
							case 4:
								result = num4;
								num = (short)313917443;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_245;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1076428801;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text3 = enumerator.Current;
								text = text3.Trim();
								text = text3.Replace(c.ToString(), "");
								text = text3.Replace(c2.ToString(), c3.ToString());
								text2 = A_1.Trim();
								text2 = A_1.Replace(c.ToString(), "");
								text2 = A_1.Replace(c2.ToString(), c3.ToString());
								char[] array = new char[0];
								array = text.ToCharArray();
								char[] obj = new char[0];
								obj = text2.ToCharArray();
								array.Equals(obj);
								num4++;
								num = (short)1896349698;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_1D0:
							num = (short)377880582;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_FE:
							goto IL_1D0;
						}
						IL_229:
						IL_245:;
					}
					finally
					{
						num = (short)580976641;
						if (num != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					break;
				}
				}
				break;
			}
			return result;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00014C5C File Offset: 0x00012E5C
		private bool a(string A_0, string A_1)
		{
			short num = (short)1570570240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				bool result;
				for (;;)
				{
					IL_27:
					num = (short)1911866823;
					short num3 = num;
					num = (short)232048071;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num = (short)1608712192;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							if (A_0 == A_1)
							{
								num = (short)1476198402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_179;
						case 1:
							goto IL_177;
						case 2:
						{
							num = (short)21430272;
							short num4 = num;
							result = true;
							num = (short)1974009857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_83;
					}
				}
				IL_177:
				IL_179:
				num = (short)1898643457;
				if (num != 0)
				{
				}
				return result;
				IL_83:
				result = false;
				char c = '\t';
				char c2 = '\u00a0';
				char c3 = ' ';
				A_0 = A_0.Trim();
				A_0 = A_0.Replace(c.ToString(), "");
				A_0 = A_0.Replace(c2.ToString(), c3.ToString());
				A_1 = A_1.Trim();
				A_1 = A_1.Replace(c.ToString(), "");
				A_1 = A_1.Replace(c2.ToString(), c3.ToString());
				num = (short)135200768;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000042 RID: 66
		private string a;

		// Token: 0x04000043 RID: 67
		private string b;

		// Token: 0x04000044 RID: 68
		private global::System.Xml.XmlDocument c;

		// Token: 0x04000045 RID: 69
		private global::System.Xml.XmlNodeList d;

		// Token: 0x04000046 RID: 70
		private global::System.Xml.XmlNode e;

		// Token: 0x04000047 RID: 71
		private global::System.Xml.XmlNode f;

		// Token: 0x04000048 RID: 72
		private global::System.Xml.XmlNode g;

		// Token: 0x04000049 RID: 73
		private global::System.Xml.XmlNode h;

		// Token: 0x0400004A RID: 74
		private global::System.Xml.XmlNode i;

		// Token: 0x0400004B RID: 75
		private global::System.Xml.XmlNode j;

		// Token: 0x0400004C RID: 76
		private global::System.Xml.XmlNode k;

		// Token: 0x0400004D RID: 77
		private global::System.Xml.XmlNode l;

		// Token: 0x0400004E RID: 78
		private global::System.Xml.XmlNode m;

		// Token: 0x0400004F RID: 79
		private global::System.Xml.XmlNode n;

		// Token: 0x04000050 RID: 80
		private global::System.Xml.XmlNode o;

		// Token: 0x04000051 RID: 81
		private global::System.Xml.XmlNode p;

		// Token: 0x04000052 RID: 82
		private global::System.Xml.XmlNode q;

		// Token: 0x04000053 RID: 83
		private global::System.Xml.XmlNode r;

		// Token: 0x04000054 RID: 84
		private global::System.Xml.XmlNode s;

		// Token: 0x04000055 RID: 85
		private global::System.Xml.XmlNode t;

		// Token: 0x04000056 RID: 86
		private string u;

		// Token: 0x04000057 RID: 87
		private string v;

		// Token: 0x04000058 RID: 88
		private string w;

		// Token: 0x04000059 RID: 89
		private string x;

		// Token: 0x0400005A RID: 90
		private string y;

		// Token: 0x0400005B RID: 91
		private string z;

		// Token: 0x0400005C RID: 92
		private string aa;

		// Token: 0x0400005D RID: 93
		private string ab;

		// Token: 0x0400005E RID: 94
		private string ac;

		// Token: 0x0400005F RID: 95
		private string ad;

		// Token: 0x04000060 RID: 96
		private string ae;

		// Token: 0x04000061 RID: 97
		private string af;

		// Token: 0x04000062 RID: 98
		private string ag;

		// Token: 0x04000063 RID: 99
		private string ah;

		// Token: 0x04000064 RID: 100
		private global::System.Collections.Generic.List<string> ai;

		// Token: 0x04000065 RID: 101
		private global::System.Collections.Generic.List<string> aj;

		// Token: 0x04000066 RID: 102
		private global::System.Collections.Generic.Dictionary<int, string> ak;

		// Token: 0x04000067 RID: 103
		private global::System.Collections.Generic.Dictionary<string, string> al;

		// Token: 0x04000068 RID: 104
		private global::System.Collections.Generic.Dictionary<string, string> am;

		// Token: 0x04000069 RID: 105
		private global::System.Collections.Generic.Dictionary<int, string> an;

		// Token: 0x0400006A RID: 106
		private const int ao = 150;

		// Token: 0x0400006B RID: 107
		public static global::System.Diagnostics.BooleanSwitch EncryptionEnabled;

		// Token: 0x02000011 RID: 17
		public enum Initialization
		{
			// Token: 0x0400006D RID: 109
			NewOnly,
			// Token: 0x0400006E RID: 110
			OpenOnly,
			// Token: 0x0400006F RID: 111
			NewAndOpen,
			// Token: 0x04000070 RID: 112
			OpenAndUpgrade
		}
	}
}
