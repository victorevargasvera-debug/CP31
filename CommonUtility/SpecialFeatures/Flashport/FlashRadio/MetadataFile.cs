using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CommonUtility;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x02000003 RID: 3
	public class MetadataFile
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000213C File Offset: 0x0000033C
		public MetadataFile(string androidOtaType, string otaPackage, string postBuild, string postBuildIncremental, string postTimestamp, string targetDevice, string targetProductName, string releaseBranch, string preBuildIncremental, string bpFirmware, string targetRelease)
		{
			this.AndroidOtaType = androidOtaType;
			this.OtaPackage = otaPackage;
			this.PostBuild = postBuild;
			this.PreBuildIncremental = preBuildIncremental;
			this.PostBuildIncremental = postBuildIncremental;
			this.PostTimestamp = postTimestamp;
			this.TargetDevice = targetDevice;
			this.TargetProductName = targetProductName;
			this.ReleaseBranch = releaseBranch;
			this.BpFirmware = bpFirmware;
			this.TargetRelease = targetRelease;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021A4 File Offset: 0x000003A4
		public MetadataFile(global::System.Collections.Generic.Dictionary<string, string> input)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> a_ in input)
			{
				this.a(a_);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002200 File Offset: 0x00000400
		// (set) Token: 0x06000007 RID: 7 RVA: 0x000022B0 File Offset: 0x000004B0
		public string AndroidOtaType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1079258740;
				short num2 = num;
				num = (short)568209012;
				switch (num2 == num)
				{
				default:
				{
					num = (short)904462336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945618945;
				if (num != 0)
				{
				}
				num = (short)1395982336;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1507065857;
				if (num != 0)
				{
				}
				num = (short)842661888;
				short num2 = num;
				num = (short)2051445689;
				short num3 = num;
				num = (short)841520057;
				switch (num3 == num)
				{
				}
				num = (short)916848640;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002360 File Offset: 0x00000560
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002410 File Offset: 0x00000610
		public string OtaPackage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1779433473;
				if (num != 0)
				{
				}
				num = (short)310771712;
				short num2 = num;
				num = (short)1509731338;
				short num3 = num;
				num = (short)437431306;
				switch (num3 == num)
				{
				}
				num = (short)342097920;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1147295739;
				short num2 = num;
				num = (short)65165307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1889337344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1333067776;
				if (num != 0)
				{
				}
				num = (short)1916469249;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000024C4 File Offset: 0x000006C4
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002578 File Offset: 0x00000778
		public string PostBuild
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1438919182;
				short num2 = num;
				num = (short)844638734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)61931520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)643629056;
				if (num != 0)
				{
				}
				num = (short)561381377;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1360670659;
				short num2 = num;
				num = (short)1779642307;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1630011392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812384257;
				if (num != 0)
				{
				}
				num = (short)341180416;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002628 File Offset: 0x00000828
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000026D4 File Offset: 0x000008D4
		public string PreBuildIncremental
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)658833409;
				if (num != 0)
				{
				}
				num = (short)1621688320;
				short num2 = num;
				num = (short)1477680616;
				short num3 = num;
				num = (short)32546280;
				switch (num3 == num)
				{
				}
				num = (short)551288832;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)68925382;
				short num2 = num;
				num = (short)752662470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728380928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)298647553;
				if (num != 0)
				{
				}
				num = (short)1847918592;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002784 File Offset: 0x00000984
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002830 File Offset: 0x00000A30
		public string PostBuildIncremental
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127638681;
				short num2 = num;
				num = (short)621780121;
				switch (num2 == num)
				{
				default:
				{
					num = (short)427753472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028470272;
				if (num != 0)
				{
				}
				num = (short)258342913;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)651973124;
				short num2 = num;
				num = (short)1945129476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72679424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)463929345;
				if (num != 0)
				{
				}
				num = (short)810352640;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000028E0 File Offset: 0x00000AE0
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002990 File Offset: 0x00000B90
		public string PostTimestamp
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)128247923;
				short num2 = num;
				num = (short)2099636339;
				switch (num2 == num)
				{
				default:
				{
					num = (short)627113984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1600126976;
				if (num != 0)
				{
				}
				num = (short)654311425;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)523586436;
				short num2 = num;
				num = (short)290278276;
				switch (num2 == num)
				{
				default:
				{
					num = (short)326828032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1982791680;
				if (num != 0)
				{
				}
				num = (short)1860501505;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002A44 File Offset: 0x00000C44
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002AF4 File Offset: 0x00000CF4
		public string TargetDevice
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)89432128;
				short num2 = num;
				num = (short)1656266816;
				switch (num2 == num)
				{
				default:
				{
					num = (short)343015424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1692270592;
				if (num != 0)
				{
				}
				num = (short)2127626241;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1103809916;
				short num2 = num;
				num = (short)1953353084;
				switch (num2 == num)
				{
				default:
				{
					num = (short)150142976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1672282113;
				if (num != 0)
				{
				}
				num = (short)1468334080;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002BA8 File Offset: 0x00000DA8
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002C58 File Offset: 0x00000E58
		public string TargetProductName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)799279257;
				short num2 = num;
				num = (short)270731417;
				switch (num2 == num)
				{
				default:
				{
					num = (short)70451200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1022820353;
				if (num != 0)
				{
				}
				num = (short)1657602048;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1087897600;
				short num2 = num;
				num = (short)387776282;
				short num3 = num;
				num = (short)224001818;
				switch (num3 == num)
				{
				}
				num = (short)752287745;
				if (num != 0)
				{
				}
				num = (short)521338880;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002D08 File Offset: 0x00000F08
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002DB8 File Offset: 0x00000FB8
		public string ReleaseBranch
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)627310592;
				short num2 = num;
				num = (short)940491584;
				short num3 = num;
				num = (short)1716306752;
				switch (num3 == num)
				{
				}
				num = (short)329908225;
				if (num != 0)
				{
				}
				num = (short)1831731200;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1697841152;
				short num2 = num;
				num = (short)1891186543;
				short num3 = num;
				num = (short)2016491375;
				switch (num3 == num)
				{
				}
				num = (short)441778176;
				if (num != 0)
				{
				}
				num = (short)1604321281;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002F1C File Offset: 0x0000111C
		public string BpFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1443627008;
				short num2 = num;
				num = (short)25952257;
				if (num != 0)
				{
				}
				num = (short)447742211;
				short num3 = num;
				num = (short)2122318083;
				switch (num3 == num)
				{
				}
				num = (short)1934098432;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)692256768;
				short num2 = num;
				num = (short)783466046;
				short num3 = num;
				num = (short)1300545086;
				switch (num3 == num)
				{
				}
				num = (short)1129578497;
				if (num != 0)
				{
				}
				num = (short)1009451008;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003078 File Offset: 0x00001278
		public string TargetRelease
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)287637504;
				short num2 = num;
				num = (short)556844314;
				short num3 = num;
				num = (short)1651033370;
				switch (num3 == num)
				{
				}
				num = (short)1133510657;
				if (num != 0)
				{
				}
				num = (short)1727463424;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1411842048;
				short num2 = num;
				num = (short)495569933;
				short num3 = num;
				num = (short)274713613;
				switch (num3 == num)
				{
				}
				num = (short)1659109376;
				if (num != 0)
				{
				}
				num = (short)1558577153;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003128 File Offset: 0x00001328
		private void a(global::System.Collections.Generic.KeyValuePair<string, string> A_0)
		{
			int a_ = 9;
			short num = (short)1965555713;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_108;
			}
			int num2;
			uint num3;
			string key;
			for (;;)
			{
				IL_3A:
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (num3 != 3481372369U)
					{
						num = (short)1251672105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1458831400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿㙁╃㑅⽇⽉㡋捍≏㝑㡓㍕㥗⥙㥛", a_)))
					{
						num = (short)138674201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8DF;
				case 3:
					num = (short)1533345831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					if (num3 <= 3341019667U)
					{
						num = (short)911671315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1471152129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)748421127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_468;
				case 8:
					num = (short)1600847899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1180434453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return;
				case 11:
					if (num3 <= 2941308260U)
					{
						num = (short)24576003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)866975749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)513212454;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿㉁㙃⍅敇⡉㥋❍㱏㙑祓㽕㙗㥙⹛㭝ൟݡ੣ብ१٩", a_)))
					{
						num = (short)218234923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_829;
				case 14:
					return;
				case 15:
					return;
				case 16:
					num = (short)1738997777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (num3 != 2912706580U)
					{
						num = (short)184025100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)804651056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (num3 != 3286842468U)
					{
						num = (short)266862627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)892076055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1065484325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿ⵁぃ❅敇㩉ⵋⵍ㭏㍑㍓㍕", a_)))
					{
						num = (short)1755709455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				case 21:
					if (num3 != 1385809262U)
					{
						num = (short)479658033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)775159828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1968766994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿㉁⭃㕅㱇杉⹋㭍㥏㹑こ", a_)))
					{
						num = (short)568524847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_838;
				case 24:
				{
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿⍁⩃≅㩇╉╋⩍絏㵑⁓㝕畗⹙╛⹝՟", a_)))
					{
						num = (short)101384225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)675288020;
					short num4 = num;
					num = (short)473764820;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_468;
					default:
						goto IL_502;
					}
					break;
				}
				case 25:
					return;
				case 26:
					return;
				case 27:
					if (num3 != 16524115U)
					{
						num = (short)1401946121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2141913119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽Ἷ㙁╃㑅⽇⽉㡋ᅍ⁏⁑㭓㉕ⵗ㥙⡛ŝ๟͡ॣͥ", a_)))
					{
						num = (short)141885476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66B;
				case 29:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿ぁ⅃⩅ⵇ⭉㽋⭍絏け♓㝕㙗㥙㑛", a_)))
					{
						num = (short)555352109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F7;
				case 30:
				{
					num = (short)1068957696;
					short num5 = num;
					if (num3 != 4046473808U)
					{
						num = (short)291635206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)915865613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 31:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽Ἷ㙁╃㑅⽇⽉㡋ᅍ㑏㝑≓㽕㭗㽙", a_)))
					{
						num = (short)376111114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 32:
					return;
				case 33:
					return;
				case 34:
					if (num3 != 3341019667U)
					{
						num = (short)1091239950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)807862301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)617414690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					return;
				case 37:
					if (num3 != 3066974693U)
					{
						num = (short)367984662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1387921452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					if (num3 != 2941308260U)
					{
						num = (short)1951596544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1381826584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 39:
					if (num3 <= 1385809262U)
					{
						num = (short)642777096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)118947882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿⁁㑃歅⹇⍉㹋⍍❏㍑♓㍕", a_)))
					{
						num = (short)1850474542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D7;
				case 41:
					num = (short)1347616798;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 42:
					if (num3 != 2517119106U)
					{
						num = (short)1116471312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1446182940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					return;
				case 44:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿㉁⭃㕅㱇杉⹋㭍㥏㹑こ筕ㅗ㑙㽛ⱝ՟ཡţࡥᱧ୩k", a_)))
					{
						num = (short)369491994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C9;
				case 45:
					return;
				case 46:
					return;
				case 47:
					return;
				case 48:
					if (!(key == global::CommonUtility.VersionUtility.b("圹伻圽洿㉁⭃㕅㱇杉㡋❍㵏㝑❓≕㥗㝙ⱛ", a_)))
					{
						num = (short)664600608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A4;
				case 49:
					return;
				}
				goto IL_108;
				IL_468:
				if (num3 != 4284870262U)
				{
					num = (short)718274564;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1326579714;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_1E3:
			this.OtaPackage = A_0.Value;
			return;
			IL_27C:
			this.TargetDevice = A_0.Value;
			return;
			IL_2C9:
			this.PostBuildIncremental = A_0.Value;
			return;
			IL_2D7:
			this.BpFirmware = A_0.Value;
			return;
			IL_3A4:
			this.PostTimestamp = A_0.Value;
			return;
			IL_502:
			num = (short)545259520;
			if (num != 0)
			{
			}
			this.AndroidOtaType = A_0.Value;
			return;
			IL_66B:
			this.TargetProductName = A_0.Value;
			return;
			IL_6F7:
			this.ReleaseBranch = A_0.Value;
			return;
			IL_829:
			this.PreBuildIncremental = A_0.Value;
			return;
			IL_838:
			this.PostBuild = A_0.Value;
			return;
			IL_8DF:
			this.TargetRelease = A_0.Value;
			return;
			IL_108:
			key = A_0.Key;
			num3 = global::f.a(key);
			num = (short)1448280075;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3A;
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000004 RID: 4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string g;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h;

		// Token: 0x0400000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x0400000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string j;

		// Token: 0x0400000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k;
	}
}
