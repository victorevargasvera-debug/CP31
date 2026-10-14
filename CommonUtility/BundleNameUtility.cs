using System;

namespace CommonUtility
{
	// Token: 0x02000027 RID: 39
	public static class BundleNameUtility
	{
		// Token: 0x060000E7 RID: 231 RVA: 0x0001844C File Offset: 0x0001664C
		public static bool IsBBFImageSection(string imageName)
		{
			int a_ = 9;
			short num = (short)1224212485;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)213057537;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)164526384;
					short num3 = num;
					num = (short)987068720;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
						goto IL_136;
					}
					break;
				}
				case 1:
					num = (short)126943235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!global::CommonUtility.VersionUtility.b("圹崻崽⬿㉁⭃㑅", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_17F;
					}
					return true;
				case 3:
					if (!global::CommonUtility.VersionUtility.b("帹唻䴽⌿⽁⭃⑅", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)1869742080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)412286978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				}
				IL_6F:
				if (!global::CommonUtility.VersionUtility.b("圹崻崽⬿⽁⭃⑅", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					num = (short)1990066180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_17F:
				num = (short)35323904;
				short num4 = num;
				num = (short)1199636481;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_136:
			num = (short)1740636160;
			if (num != 0)
			{
			}
			return global::CommonUtility.VersionUtility.b("帹唻䴽⌿㉁⭃㑅", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00018620 File Offset: 0x00016820
		public static bool IsCVNImageSection(string imageName)
		{
			int a_ = 5;
			if (!global::CommonUtility.VersionUtility.b("䘵圷䠹弻䠽⸿", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num;
				for (;;)
				{
					num = (short)305135617;
					if (num != 0)
					{
					}
					num = (short)1807751295;
					short num2 = num;
					num = (short)16980095;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_80;
					}
				}
				IL_80:
				num = (short)62390272;
				short num3 = num;
				num = (short)1281294336;
				if (num != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("嬵圷堹弻䠽⸿", a_).Equals(imageName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00018704 File Offset: 0x00016904
		public static bool IsCVNFile(string filename)
		{
			int a_ = 6;
			short num = (short)1932132353;
			if (num != 0)
			{
			}
			if (!string.IsNullOrEmpty(filename))
			{
				for (;;)
				{
					num = (short)1012041104;
					short num2 = num;
					num = (short)1936885136;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_75;
					}
				}
				IL_75:
				num = (short)1270349824;
				short num3 = num;
				num = (short)1470300160;
				if (num != 0)
				{
				}
				return filename.EndsWith(global::CommonUtility.VersionUtility.b("ᤶ娸䴺匼", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000187E0 File Offset: 0x000169E0
		public static bool IsBBFFile(string filename)
		{
			int a_ = 0;
			if (!string.IsNullOrEmpty(filename))
			{
				short num;
				for (;;)
				{
					num = (short)2093513507;
					short num2 = num;
					num = (short)502364963;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4D;
					}
				}
				IL_4D:
				num = (short)519897089;
				if (num != 0)
				{
				}
				num = (short)1071185920;
				short num3 = num;
				num = (short)583335936;
				if (num != 0)
				{
				}
				return filename.EndsWith(global::CommonUtility.VersionUtility.b("ἰ儲圴儶", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000188B8 File Offset: 0x00016AB8
		public static bool IsZIPFile(string filename)
		{
			int a_ = 6;
			if (!string.IsNullOrEmpty(filename))
			{
				short num;
				for (;;)
				{
					num = (short)1921424097;
					short num2 = num;
					num = (short)520198881;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4A;
					}
				}
				IL_4A:
				num = (short)1977679873;
				if (num != 0)
				{
				}
				num = (short)1194131456;
				short num3 = num;
				num = (short)1441398784;
				if (num != 0)
				{
				}
				return filename.EndsWith(global::CommonUtility.VersionUtility.b("ᤶ䌸刺䴼", a_), global::System.StringComparison.OrdinalIgnoreCase);
			}
			return false;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0001898C File Offset: 0x00016B8C
		public static bool IsMegaBundle(string bundleName)
		{
			int a_ = 15;
			short num = (short)551761357;
			short num2 = num;
			num = (short)1847277005;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1121714176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)425263105;
			if (num != 0)
			{
			}
			num = (short)312344576;
			if (num != 0)
			{
			}
			return global::CommonUtility.VersionUtility.b("ℿ㉁㱃᥅⭇㩉㽋", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00018A54 File Offset: 0x00016C54
		public static bool IsFreonBundle(string bundleName)
		{
			int a_ = 10;
			if (!global::CommonUtility.VersionUtility.b("强吼䰾≀᱂⡄⡆⭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num;
				for (;;)
				{
					num = (short)159711233;
					if (num != 0)
					{
					}
					num = (short)706505276;
					short num2 = num;
					num = (short)976120380;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_83;
					}
				}
				IL_83:
				num = (short)1337458688;
				short num3 = num;
				num = (short)1894318080;
				if (num != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("强吼䰾≀᱂㕄⡆㭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00018B3C File Offset: 0x00016D3C
		public static bool IsOMAPBundle(string bundleName)
		{
			int a_ = 3;
			short num = (short)123273217;
			if (num != 0)
			{
			}
			if (!global::CommonUtility.VersionUtility.b("夳圵嬷儹挻丽⼿ぁ", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				for (;;)
				{
					num = (short)1360453397;
					short num2 = num;
					num = (short)649649941;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7F;
					}
				}
				IL_7F:
				num = (short)725155840;
				short num3 = num;
				num = (short)1710292992;
				if (num != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("夳圵嬷儹挻匽⼿⁁", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00018C20 File Offset: 0x00016E20
		public static bool IsBBFBundle(string bundleName)
		{
			int a_ = 10;
			short num = (short)1319305221;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1171686261;
					short num3 = num;
					num = (short)1107198837;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
						goto IL_135;
					}
					break;
				}
				case 1:
					num = (short)2084962307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!global::CommonUtility.VersionUtility.b("强吼䰾≀᱂㕄⡆㭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						goto IL_17F;
					}
					return true;
				case 3:
					if (!global::CommonUtility.VersionUtility.b("嘺尼尾⩀᱂㕄⡆㭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)750452736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					num = (short)2074476546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				}
				IL_45:
				num = (short)1068826625;
				if (num != 0)
				{
				}
				if (!global::CommonUtility.VersionUtility.b("强吼䰾≀᱂⡄⡆⭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					num = (short)1877475332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_17F:
				num = (short)1081606144;
				short num4 = num;
				num = (short)1768423425;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_135:
			num = (short)1829765120;
			if (num != 0)
			{
			}
			return global::CommonUtility.VersionUtility.b("嘺尼尾⩀᱂⡄⡆⭈", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00018DF4 File Offset: 0x00016FF4
		public static bool IsPortableBBF(string bundleName)
		{
			int a_ = 11;
			if (!global::CommonUtility.VersionUtility.b("儻弽⌿⥁ᭃ㙅❇㡉", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num;
				for (;;)
				{
					num = (short)1506677503;
					short num2 = num;
					num = (short)1789989631;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_59;
					}
				}
				IL_59:
				num = (short)2010251265;
				if (num != 0)
				{
				}
				num = (short)45285376;
				short num3 = num;
				num = (short)1794637824;
				if (num != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("堻圽㌿⅁ᭃ㙅❇㡉", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00018ED8 File Offset: 0x000170D8
		public static bool IsMobileBBF(string bundleName)
		{
			int a_ = 16;
			if (!global::CommonUtility.VersionUtility.b("ⱀ≂♄ⱆᙈ♊≌ⵎ", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase))
			{
				short num;
				for (;;)
				{
					num = (short)470717541;
					short num2 = num;
					num = (short)941659237;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_59;
					}
				}
				IL_59:
				num = (short)946536449;
				if (num != 0)
				{
				}
				num = (short)817889280;
				short num3 = num;
				num = (short)649134080;
				if (num != 0)
				{
				}
				return global::CommonUtility.VersionUtility.b("╀⩂㙄⑆ᙈ♊≌ⵎ", a_).Equals(bundleName, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00018FBC File Offset: 0x000171BC
		public static bool IsNextBundle(string bundleName)
		{
			int a_ = 19;
			short num = (short)121569281;
			if (num != 0)
			{
			}
			num = (short)125108224;
			short num2 = num;
			num = (short)1402113301;
			short num3 = num;
			num = (short)221220117;
			switch (num3 == num)
			{
			}
			num = (short)747175936;
			if (num != 0)
			{
			}
			return bundleName.ToLower().Contains(global::CommonUtility.VersionUtility.b("╃⭅㡇", a_));
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0001908C File Offset: 0x0001728C
		public static bool IsAlohaBundle(string bundleName)
		{
			int a_ = 2;
			short num = (short)1195733561;
			short num2 = num;
			num = (short)625832505;
			switch (num2 == num)
			{
			default:
			{
				num = (short)775356416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)797638657;
			if (num != 0)
			{
			}
			num = (short)1768685568;
			if (num != 0)
			{
			}
			return bundleName.ToLower().Contains(global::CommonUtility.VersionUtility.b("刲头堶儸娺", a_));
		}

		// Token: 0x04000061 RID: 97
		public const string MEGA_BBF_BUNDLENAME = "apx_cps";

		// Token: 0x04000062 RID: 98
		public const string EXTENTION_CVN = ".cvn";

		// Token: 0x04000063 RID: 99
		public const string EXTENTION_BBF = ".bbf";

		// Token: 0x04000064 RID: 100
		public const string EXTENTION_ZIP = ".zip";

		// Token: 0x04000065 RID: 101
		public const string MOBILE_FREON_BBF_BUNDLENAME = "disc_mob";

		// Token: 0x04000066 RID: 102
		public const string MOBILE_NON_FREON_BBF_BUNDLENAME = "M";

		// Token: 0x04000067 RID: 103
		public const string PORTABLE_FREON_BBF_BUNDLENAME = "disc_por";

		// Token: 0x04000068 RID: 104
		public const string PORTABLE_NON_FREON_BBF_BUNDLENAME = "H";

		// Token: 0x04000069 RID: 105
		public const string PORTABLE_OMAP_BBF_BUNDLENAME = "mack_por";

		// Token: 0x0400006A RID: 106
		public const string MOBILE_OMAP_BBF_BUNDLENAME = "mack_mob";

		// Token: 0x0400006B RID: 107
		public const string MACK_MOB_SECTIONNAME = "mackmob";

		// Token: 0x0400006C RID: 108
		public const string MACK_POR_SECTIONNAME = "mackpor";

		// Token: 0x0400006D RID: 109
		public const string DISC_MOB_SECTIONNAME = "discmob";

		// Token: 0x0400006E RID: 110
		public const string DISC_POR_SECTIONNAME = "discpor";

		// Token: 0x0400006F RID: 111
		public const string POR_CVN_SECTIONNAME = "porcvn";

		// Token: 0x04000070 RID: 112
		public const string MOB_CVN_SECTIONNAME = "mobcvn";

		// Token: 0x04000071 RID: 113
		public const string NEXT_BUNDLENAME = "amp";

		// Token: 0x04000072 RID: 114
		public const string NEXT_FULL_BUNDLENAME = "amp_sdm660_64";

		// Token: 0x04000073 RID: 115
		public const string ALOHA_BUNDLENAME = "aloha";

		// Token: 0x04000074 RID: 116
		public const string ALOHA_FULL_BUNDLENAME = "aloha_32go";
	}
}
