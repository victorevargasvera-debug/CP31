using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil.Extensions;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005B RID: 91
	public static class PbbDeviceInfoConverters
	{
		// Token: 0x06000257 RID: 599 RVA: 0x0002CDA0 File Offset: 0x0002AFA0
		public static string GetDefaultModelNumber(string pbbProductIdentifier)
		{
			int a_ = 3;
			global::System.Collections.Generic.List<string> source;
			if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.ProductModelsMap.TryGetValue(pbbProductIdentifier, out source))
			{
				short num = (short)1967487812;
				short num2 = num;
				num = (short)974682948;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1996292096;
					if (num != 0)
					{
					}
					num = (short)57147392;
					short num3 = num;
					break;
				}
				}
				num = (short)114556929;
				if (num != 0)
				{
				}
				return source.First<string>();
			}
			throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䨆昈漊栌挎ㄐ栒└樖㤘甚爜欞Ġ倢値圦夨䐪弬嬮吰圲", a_), pbbProductIdentifier));
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0002CE8C File Offset: 0x0002B08C
		public static bool IsFusion(string pbbModelNumber)
		{
			int a_ = 14;
			short num = (short)15990788;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!pbbModelNumber.StartsWith(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("少⌓☕⠗⬙", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)1843920897;
						if (num != 0)
						{
						}
						num = (short)1888419841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_EC;
				case 2:
					num = (short)1568210949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1769799680;
					short num3 = num;
					num = (short)1070030028;
					short num4 = num;
					num = (short)1008098508;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num = (short)77332480;
						if (num != 0)
						{
						}
						num = (short)1037303808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					goto IL_10A;
				}
				IL_45:
				if (!string.IsNullOrEmpty(pbbModelNumber))
				{
					num = (short)290193410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_10A:
				if (pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娑弓␕⠗Ⱉ⸛弝", a_))
				{
					return true;
				}
				num = (short)470024195;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EC:
			return pbbModelNumber.StartsWith(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("少⌓☕⠗⠙", a_), global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x0002D050 File Offset: 0x0002B250
		public static bool IsFusionByProductIdentifier(string pbbProductIdentifier)
		{
			int a_ = 7;
			short num = (short)111083521;
			if (num != 0)
			{
			}
			if (!(pbbProductIdentifier == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("堊搌㨎ℐ⌒", a_)))
			{
				num = (short)418862782;
				short num2 = num;
				num = (short)667113150;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)522518528;
					short num3 = num;
					num = (short)400949248;
					if (num != 0)
					{
					}
					break;
				}
				}
				return pbbProductIdentifier == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("堊搌㠎ℐ⌒", a_);
			}
			return true;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x0002D134 File Offset: 0x0002B334
		public static bool IsCascadeNotInternational(string pbbModelNumber)
		{
			int a_ = 4;
			if (!(pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀇䄉㸋㸍┏␑唓", a_)))
			{
				short num = (short)924292154;
				short num2 = num;
				num = (short)1851364410;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1764687873;
					if (num != 0)
					{
					}
					num = (short)1741684736;
					short num3 = num;
					num = (short)1438384128;
					if (num != 0)
					{
					}
					break;
				}
				}
				return pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀇䄉㸋㸍☏☑唓", a_);
			}
			return true;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x0002D214 File Offset: 0x0002B414
		public static bool IsCascadeInternational(string pbbModelNumber)
		{
			int a_ = 2;
			short num = (short)1404829698;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					IL_6B:
					num = (short)1115684865;
					if (num != 0)
					{
					}
					num = (short)986185729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (!(pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("刅㰇㬉㰋㤍儏㴑䀓∕⤗⨙␛弝༟瘡ဣᜥᠧጩ洫", a_)))
					{
						num = (short)865599491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 3:
					goto IL_EF;
				}
				IL_3E:
				if (!(pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("刅㰇㬉㰋㨍儏㴑䀓∕⤗⨙⤛弝༟瘡ဣᜥᠧᰩ洫", a_)))
				{
					num = (short)176881664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_F4:
				num = (short)370635560;
				short num3 = num;
				num = (short)1739289384;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6B;
				default:
					goto IL_12A;
				}
			}
			IL_EF:
			return pbbModelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䨅䴇刉Ⰻ䈍ℏ⌑", a_);
			IL_12A:
			num = (short)1955004416;
			if (num != 0)
			{
			}
			num = (short)1428029440;
			short num4 = num;
			return true;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0002D38C File Offset: 0x0002B58C
		public static bool IsFeatureLicensingSupportedByModel(string modelNumber)
		{
			int a_ = 14;
			short num = (short)244973573;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFusion(modelNumber))
					{
						num = (short)833224707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)750780416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_EF;
				case 3:
					goto IL_12F;
				case 4:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帑䀓䈕䬗㜙䠛弝戟ጡሣଥ欧欩缫", a_)))
					{
						num = (short)1851981826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 6:
				{
					num = (short)819462144;
					short num3 = num;
					num = (short)2082340871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					num = (short)1172048290;
					short num4 = num;
					num = (short)1016465826;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12F;
					default:
						num = (short)1404370944;
						if (num != 0)
						{
						}
						if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("向␓☕ⴗ⼙崛", a_)))
						{
							num = (short)1710817281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				}
				IL_4E:
				if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("向␓☕ⴗ⨙崛", a_)))
				{
					num = (short)421134342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_12F:
				num = (short)229244929;
				if (num != 0)
				{
				}
				num = (short)10092548;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			return !(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("帑儓丕㠗尙ⴛ⸝", a_));
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0002D5A4 File Offset: 0x0002B7A4
		public static bool IsCertificateSupportedByModel(string modelNumber)
		{
			int a_ = 7;
			short num = (short)744882178;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)291185361;
				short num3 = num;
				num = (short)935273169;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)460062720;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)1163198477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2AA;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 3:
						num = (short)1335754757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌊䘌㴎ℐ┒␔嘖", a_)))
						{
							num = (short)2048131080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䴊㴌㼎␐⌒吔", a_)))
						{
							num = (short)309002250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						num = (short)1265958916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䴊㴌㼎␐☒吔", a_)))
						{
							num = (short)34537478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						num = (short)1514668041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFusion(modelNumber))
						{
							num = (short)533725184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						num = (short)801767431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)757923852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)982646785;
						if (num != 0)
						{
						}
						if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜊夌嬎䈐㸒䄔嘖嬘⨚⬜㈞戠戢瘤", a_)))
						{
							num = (short)1380122625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsCascadeNotInternational(modelNumber))
						{
							num = (short)1213726731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_B0:
					if (modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("弊㔌㸎✐␒吔", a_))
					{
						return false;
					}
					num = (short)174194691;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2AA:
			num = (short)1130233856;
			short num4 = num;
			return !(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜊䠌圎ㄐ唒␔✖", a_));
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0002D8AC File Offset: 0x0002BAAC
		public static bool IsLogRetrievalSupportedByModel(string modelNumber)
		{
			int a_ = 10;
			short num = (short)214040577;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1440978499;
					short num3 = num;
					num = (short)1265276483;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						goto IL_9F;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 2:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠍‏∑ℓ☕夗", a_)))
					{
						num = (short)346488832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1164771329;
					if (num != 0)
					{
					}
					num = (short)944701442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFusion(modelNumber))
					{
						num = (short)1611464707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
				{
					num = (short)848494592;
					short num4 = num;
					num = (short)1104609284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_46;
				IL_51:
				num = (short)1456144389;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_46:
				if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsCascadeInternational(modelNumber))
				{
					goto IL_51;
				}
				return true;
			}
			IL_9F:
			num = (short)2042298368;
			if (num != 0)
			{
			}
			return modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠍‏∑ℓ⌕夗", a_);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0002DA64 File Offset: 0x0002BC64
		public static bool IsHomeSetSupportedByModel(string modelNumber)
		{
			int a_ = 10;
			short num = (short)734658561;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1036845056;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_1E5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 2:
					if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFusion(modelNumber))
					{
						num = (short)1171062793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠍‏∑ℓ☕夗", a_)))
					{
						num = (short)1024000000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)364251590;
					short num4 = num;
					num = (short)541133254;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E5;
					default:
						num = (short)1514143744;
						if (num != 0)
						{
						}
						num = (short)803405826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘍嬏‑␓―⤗嬙", a_)))
					{
						num = (short)1059979268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					num = (short)1328414723;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_12E;
				case 8:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠍‏∑ℓ⌕夗", a_)))
					{
						num = (short)832634890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					num = (short)1945501707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1970864133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈍䐏䘑䜓㬕䰗嬙帛⼝ᘟ༡朣朥笧", a_)))
					{
						num = (short)936312839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_86:
				if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("娍⠏⌑∓ℕ夗", a_)))
				{
					num = (short)1213923329;
					if (num != 0)
					{
					}
					num = (short)1836580870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_1E5:
				num = (short)1874657288;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12E:
			return !(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䈍唏䨑㐓倕⤗⨙", a_));
		}

		// Token: 0x06000260 RID: 608 RVA: 0x0002DD2C File Offset: 0x0002BF2C
		public static bool IsFactoryResetSupportedByModel(string modelNumber)
		{
			int a_ = 19;
			short num = (short)1897660417;
			if (num != 0)
			{
			}
			num = (short)1912799233;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1925251072;
					short num3 = num;
					num = (short)131956224;
					short num4 = num;
					num = (short)70614528;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						goto IL_D4;
					}
					break;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 2:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("弖刘⤚ⴜ⤞ဠ戢", a_)))
					{
						num = (short)1760559104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1466630146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儖⤘⬚⠜⨞怠", a_)))
					{
						num = (short)586612739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)2087256068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6C;
				IL_85:
				num = (short)1726414853;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_6C:
				if (!(modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("儖⤘⬚⠜⼞怠", a_)))
				{
					goto IL_85;
				}
				return true;
			}
			IL_D4:
			num = (short)135200768;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsFusion(modelNumber);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0002DEEC File Offset: 0x0002C0EC
		public static bool IsApnConfigurationSupportedByModel(string modelNumber)
		{
			int a_ = 15;
			short num = (short)383385601;
			if (num != 0)
			{
			}
			if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsCascadeInternational(modelNumber))
			{
				num = (short)1789591552;
				short num2 = num;
				num = (short)384361139;
				short num3 = num;
				num = (short)1974854323;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)853999616;
					if (num != 0)
					{
					}
					return modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("弒倔伖㤘崚Ⱌ⼞", a_);
				}
			}
			return true;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0002DFC4 File Offset: 0x0002C1C4
		public static bool DoesRadioNeedsToBeRecognizedByItsModelNumberBase(string modelNo)
		{
			int a_ = 2;
			short num = (short)1529151489;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_141;
				case 1:
					num = (short)172883969;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 2:
					if (modelNo.Trim() != global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䨅䴇刉Ⰻ䈍ℏ⌑", a_))
					{
						num = (short)2049703936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)924348912;
					short num3 = num;
					num = (short)234451440;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)906231808;
						if (num != 0)
						{
						}
						num = (short)58130434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					if (!modelNo.StartsWith(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠅㼇㨉㰋㰍", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)463536128;
						short num4 = num;
						num = (short)2126315523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)1881014276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6D:
				if (modelNo.StartsWith(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠅㼇㨉㰋㼍", a_), global::System.StringComparison.Ordinal))
				{
					return true;
				}
				num = (short)1473380357;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_141:
			return global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsLEXL11ModelNumber(modelNo);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0002E190 File Offset: 0x0002C390
		public static bool IsMCIFSupportedByDevice(string productIdentifier)
		{
			int a_ = 0;
			short num = (short)388956161;
			if (num != 0)
			{
			}
			if (!(productIdentifier == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠃䌅倇⨉䀋㼍‏笑", a_)))
			{
				num = (short)1666449408;
				short num2 = num;
				num = (short)2098296360;
				short num3 = num;
				num = (short)1442281000;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1267597312;
					if (num != 0)
					{
					}
					return productIdentifier == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䠃䌅倇⨉䀋㼍‏笑猓", a_);
				}
			}
			return true;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0002E270 File Offset: 0x0002C470
		public static bool IsModeSupportedByDevice(string productIdentifier)
		{
			short num = (short)1126396929;
			short num2 = num;
			num = (short)904033281;
			switch (num2 == num)
			{
			}
			num = (short)45613056;
			short num3 = num;
			num = (short)1972961280;
			if (num != 0)
			{
			}
			num = (short)605028353;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsLEXL11ModelNumber(productIdentifier);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0002E324 File Offset: 0x0002C524
		public static string GetModeName(string serialNumber)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1722744835;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)694484993;
						if (num != 0)
						{
						}
						num = (short)1125461899;
						short num3 = num;
						num = (short)312094603;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)461963264;
							if (num != 0)
							{
							}
							num = (short)1224015874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_123;
					case 2:
						if (serialNumber.Length <= 10)
						{
							num = (short)490340353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_128;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					}
					IL_34:
					if (serialNumber == null)
					{
						goto IL_4E;
					}
					num = (short)504365056;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_4E:
			num = (short)1918631936;
			short num4 = num;
			return null;
			IL_123:
			goto IL_4E;
			IL_128:
			return serialNumber.Substring(10);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0002E464 File Offset: 0x0002C664
		public static global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID GetDeviceType(string modelFilter)
		{
			short num = (short)1226301985;
			short num2 = num;
			num = (short)2100748833;
			global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_A2:
				if (!global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.FirmwareModelsMaskMap.TryGetValue(((modelFilter != null) ? modelFilter.Trim() : null) ?? "", out result))
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_PBB_Fail_To_Parse_FW_Package_Model);
				}
				num = (short)280952832;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)625999873;
				if (num != 0)
				{
				}
				num = (short)1263206400;
				if (num != 0)
				{
				}
				num = (short)930086914;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)349241345;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D8;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_A2;
					}
					continue;
				}
				goto IL_A2;
			}
			IL_D8:
			num = (short)847511552;
			short num4 = num;
			return result;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0002E5A0 File Offset: 0x0002C7A0
		public static string GetFusionModelNumberBase(string modelNo)
		{
			int a_ = 7;
			global::System.Text.RegularExpressions.Match match = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("唊嘌渎㰐椒吔㨖䌘䘚昜⸞尠砢ᔤਦဨ瘪嘬ᬮ䰰", a_)).Match(modelNo);
			if (match.Success)
			{
				short num = (short)1486281517;
				short num2 = num;
				num = (short)1527765805;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D3;
				case 1:
					break;
				default:
				{
					num = (short)1541931008;
					short num3 = num;
					break;
				}
				}
				num = (short)2062024704;
				if (num != 0)
				{
				}
				num = (short)105906177;
				if (num != 0)
				{
				}
				return match.Value;
			}
			IL_D3:
			return null;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x0002E684 File Offset: 0x0002C884
		public static bool IsLEXL11ModelNumber(string modelNo)
		{
			int a_ = 8;
			global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("刋䈍唏䨑㐓娕⤗⬙", a_));
			if (!string.IsNullOrEmpty(modelNo))
			{
				short num = (short)1483940296;
				short num2 = num;
				num = (short)43917768;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)1288634368;
					short num3 = num;
					break;
				}
				}
				num = (short)1992163328;
				if (num != 0)
				{
				}
				num = (short)591790081;
				if (num != 0)
				{
				}
				return regex.Match(modelNo).Success;
			}
			return false;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0002E768 File Offset: 0x0002C968
		public static global::System.Collections.Generic.List<string> GetAllSupportedFirmwareModels()
		{
			short num = (short)2048458753;
			if (num != 0)
			{
			}
			num = (short)1751997130;
			short num2 = num;
			num = (short)836917962;
			switch (num2 == num)
			{
			default:
			{
				num = (short)367263744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)331087872;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.FirmwareModelsMaskMap.Keys.ToList<string>();
		}

		// Token: 0x0600026A RID: 618 RVA: 0x0002E820 File Offset: 0x0002CA20
		public static bool IsFirmwareModelSupported(string firmwareModel)
		{
			if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.FirmwareModelsMaskMap.Keys.Contains(firmwareModel))
			{
				short num = (short)590479361;
				if (num != 0)
				{
				}
				num = (short)1833893888;
				short num2 = num;
				num = (short)1395096093;
				short num3 = num;
				num = (short)507738653;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1870987264;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0002E8E4 File Offset: 0x0002CAE4
		public static bool DoesRadioNeedsWiFiLegacyConfig(string modelNumber)
		{
			int a_ = 17;
			if (modelNumber == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崔尖⬘⬚⬜ⴞ怠", a_))
			{
				short num = (short)68539670;
				short num2 = num;
				num = (short)591648022;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				case 1:
					break;
				default:
				{
					num = (short)1065025536;
					short num3 = num;
					break;
				}
				}
				num = (short)2040725505;
				if (num != 0)
				{
				}
				num = (short)595329024;
				if (num != 0)
				{
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0002E9B4 File Offset: 0x0002CBB4
		public static void UnifyProductIdentifierModelNumberValues(global::Motorola.Common.Communication.CommonUtil.PBBDeviceInfo pbbDeviceInfo)
		{
			int a_ = 15;
			short num = (short)1374289920;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1066466846;
					short num3 = num;
					num = (short)1597439518;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18F;
					default:
					{
						num = (short)423362560;
						if (num != 0)
						{
						}
						num = (short)1765801984;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					}
					}
					break;
				}
				case 1:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.GetFusionModelNumberBase(pbbDeviceInfo.ProductIdentifier) == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崒∔✖⤘⤚", a_))
					{
						num = (short)1366425605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1400242180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)57606145;
					if (num != 0)
					{
					}
					pbbDeviceInfo.ModelNumber = global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.GetDefaultModelNumber(pbbDeviceInfo.ProductIdentifier);
					num = (short)524156937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (pbbDeviceInfo.ModelNumber == null)
					{
						num = (short)535035906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsLEXL11ModelNumber(pbbDeviceInfo.ProductIdentifier))
					{
						num = (short)1863974919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)175308803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_2FB;
				case 6:
					goto IL_1A6;
				case 7:
					goto IL_276;
				case 8:
					if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.GetFusionModelNumberBase(pbbDeviceInfo.ProductIdentifier) == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崒∔✖⤘⨚", a_))
					{
						goto IL_18F;
					}
					num = (short)1053622273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_2A5;
				case 10:
					goto IL_FC;
				}
				IL_CD:
				if (pbbDeviceInfo.ProductIdentifier == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬒帔┖⤘ⴚ⼜帞", a_))
				{
					num = (short)693633034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)548929544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18F:
				num = (short)230162438;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FC:
			pbbDeviceInfo.ProductIdentifier = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔∖⤘⬚", a_);
			pbbDeviceInfo.ModelNumber = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬒帔┖⤘ⴚ⼜帞", a_);
			return;
			IL_1A6:
			pbbDeviceInfo.ProductIdentifier = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔∖⤘⬚", a_);
			pbbDeviceInfo.ModelNumber = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崒∔✖⤘⨚", a_);
			return;
			IL_276:
			pbbDeviceInfo.ProductIdentifier = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("弒倔伖㤘圚Ⱌ⸞", a_);
			pbbDeviceInfo.ModelNumber = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("弒倔伖㤘圚Ⱌ⸞", a_);
			return;
			IL_2A5:
			return;
			IL_2FB:
			pbbDeviceInfo.ProductIdentifier = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䀒簔‖⤘⬚", a_);
			pbbDeviceInfo.ModelNumber = global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("崒∔✖⤘⤚", a_);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		public static string UnifyBuildPropModelValues(string modelValue)
		{
			int a_ = 12;
			if (global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.IsLEXL11ModelNumber(modelValue))
			{
				short num = (short)170657995;
				short num2 = num;
				num = (short)683542731;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return modelValue;
				case 1:
					break;
				default:
				{
					num = (short)1616969728;
					short num3 = num;
					break;
				}
				}
				num = (short)203948033;
				if (num != 0)
				{
				}
				num = (short)1947402240;
				if (num != 0)
				{
				}
				return global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("小圑䰓㘕吗⬙ⴛ", a_);
			}
			return modelValue;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0002EDBC File Offset: 0x0002CFBC
		public static global::Motorola.Common.Communication.CommonUtil.ProductFamily GetProductFamily(string productId)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_14D;
			}
			int num;
			uint num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 != 1013598875U)
					{
						num3 = (short)1473576966;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)719519769;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					num3 = (short)1181155376;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					num3 = (short)1652031514;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
					goto IL_B65;
				case 4:
					num3 = (short)439418904;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					num3 = (short)248250415;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 6:
					num3 = (short)1577451590;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					num3 = (short)872153115;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 8:
					num3 = (short)1437204498;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					if (productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("吆怈㰊㴌㼎", a_))
					{
						num3 = (short)1634664481;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_BF1;
				case 10:
					num3 = (short)301989907;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䌎‐−", a_)))
					{
						num3 = (short)1918763052;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 12:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("匆䐈䜊ⴌ䈎∐⌒", a_)))
					{
						num3 = (short)1484324922;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 13:
					if (num2 != 338400976U)
					{
						num3 = (short)1625817089;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)2108096523;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䌎‐⌒簔", a_)))
					{
						num3 = (short)1009385531;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 15:
					num3 = (short)1636565028;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 16:
					if (num2 <= 662562229U)
					{
						num3 = (short)1560805437;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1084817408;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䤎‐⌒", a_)))
					{
						num3 = (short)1411186725;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 18:
					goto IL_5B7;
				case 19:
					goto IL_963;
				case 20:
					if (num2 <= 1265139244U)
					{
						num3 = (short)1106706477;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)863174679;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 21:
					goto IL_62F;
				case 22:
					goto IL_97F;
				case 23:
					if (num2 <= 1613247157U)
					{
						num3 = (short)319291431;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)917307457;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 24:
					goto IL_5D4;
				case 25:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䌎‐⌒簔瀖", a_)))
					{
						num3 = (short)1223229441;
						if (num3 != 0)
						{
						}
						num3 = (short)56623153;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 26:
					if (num2 != 1613247157U)
					{
						num3 = (short)1162805263;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1207631889;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 27:
					goto IL_252;
				case 28:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆崈弊希∎䔐划圔☖⼘㘚帜帞爠", a_)))
					{
						num3 = (short)2078343176;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 29:
					if (num2 != 1470123596U)
					{
						num3 = (short)559022155;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1934164034;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 30:
					num3 = (short)208732201;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 31:
					IL_B2D:
					num3 = (short)856948776;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 32:
					goto IL_B49;
				case 33:
					goto IL_B6A;
				case 34:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䌎‐⌒", a_)))
					{
						num3 = (short)1880817695;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 35:
					num3 = (short)1416626197;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 36:
					goto IL_599;
				case 37:
					num3 = (short)1943732246;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 38:
					goto IL_BD4;
				case 39:
					num3 = (short)1541406749;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 40:
					goto IL_8AE;
				case 41:
					if (num2 != 1849287734U)
					{
						num3 = (short)89718846;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1868038200;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 42:
					if (num2 != 662562229U)
					{
						num3 = (short)1217986615;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)538312732;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 43:
					goto IL_BEF;
				case 44:
					num3 = (short)399310894;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 45:
					num3 = (short)1593966608;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 46:
					goto IL_9F8;
				case 47:
					goto IL_1F7;
				case 48:
					if (num2 != 355178595U)
					{
						num3 = (short)449970245;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)214106146;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 49:
					num3 = (short)1952383008;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 50:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊㨌㨎␐", a_)))
					{
						num3 = (short)159318026;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 51:
					goto IL_99C;
				case 52:
					if (num2 != 2579842711U)
					{
						num3 = (short)1929904202;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1086718024;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 53:
					num3 = (short)618004548;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 54:
					num3 = (short)779354169;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 55:
					num3 = (short)1215561779;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 56:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("吆怈㠊㴌㼎", a_)))
					{
						num3 = (short)22347780;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 57:
					goto IL_540;
				case 58:
					num3 = (short)305266726;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 59:
					num3 = (short)297730091;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 60:
					if (num2 != 2281833074U)
					{
						num3 = (short)2141716543;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1553268748;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 61:
					num3 = (short)1915879437;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 62:
					num3 = (short)658964540;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 63:
					num3 = (short)887750720;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 64:
					goto IL_A15;
				case 65:
					if (num2 <= 2281833074U)
					{
						num3 = (short)120520734;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1151533108;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 66:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䌎‐⌒爔", a_)))
					{
						num3 = (short)1325858821;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 67:
					num3 = (short)691601411;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 68:
					if (num2 != 1265139244U)
					{
						num3 = (short)1761542198;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)648806476;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 69:
					num3 = (short)1506017322;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 70:
					if (num2 != 1190594149U)
					{
						num3 = (short)380239925;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)291569714;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 71:
					if (num2 != 1570789310U)
					{
						num3 = (short)1300496386;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)832765966;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 72:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬆䰈匊ⴌ䈎⌐⌒", a_)))
					{
						num3 = (short)1568079939;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				case 73:
					if (num2 != 2844091458U)
					{
						num3 = (short)1209466880;
						short num4 = num3;
						num3 = (short)441974819;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)517799945;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 74:
					num3 = (short)1356726345;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 75:
					num3 = (short)1938030663;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 76:
					if (!(productId == global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("吆怈㸊㴌㼎", a_)))
					{
						num3 = (short)727908359;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B6A;
				}
				goto IL_14D;
				IL_B6A:
				num3 = (short)2128881645;
				short num5 = num3;
				num3 = (short)336734189;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B2D;
				default:
					goto IL_BA1;
				}
			}
			IL_1F7:
			IL_252:
			IL_540:
			IL_599:
			IL_5B7:
			IL_5D4:
			IL_62F:
			IL_8AE:
			IL_963:
			IL_97F:
			IL_99C:
			IL_9F8:
			IL_A15:
			IL_B49:
			IL_B65:
			goto IL_BF1;
			IL_BA1:
			num3 = (short)468582400;
			if (num3 != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
			IL_BD4:
			IL_BEF:
			IL_BF1:
			throw new global::System.NotSupportedException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤆昈缊ⴌ簎搐挒攔砖欘漚砜笞Ġ猢圤䠦䴨帪丬嬮ᄰ稲儴制圸伺吼夾⡀♂㝄", a_));
			IL_14D:
			num2 = global::c.a(productId);
			num3 = (short)1223688212;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0002F9D0 File Offset: 0x0002DBD0
		// Note: this type is marked as 'beforefieldinit'.
		static PbbDeviceInfoConverters()
		{
			int a_ = 11;
			short num = (short)683147264;
			short num2 = num;
			num = (short)1808720330;
			short num3 = num;
			num = (short)2061754826;
			switch (num3 == num)
			{
			}
			num = (short)462815232;
			if (num != 0)
			{
			}
			num = (short)2012151809;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.FirmwareModelsMaskMap = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID>
			{
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.Cascade
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚稜", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.CascadeGSM
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚琜", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.CascadeInternational
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚琜砞", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.CascadeInternationalGSM
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔娖⬘⬚", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.Prince
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬎尐弒㔔娖⨘⬚", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.TacticalModem
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("導砐☒└✖", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.FusionSI500
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎䔐䜒䘔㨖䴘娚弜⸞ᜠย昤昦稨", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.LTTS_TAB16_CAS
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("導堐㌒䘔刖䬘刚堜䰞Ġ產瘤樦", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.FusionSI500
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔儖⠘⬚", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.LEX_F10
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄎☐⌒└☖", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.N7001
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⨚", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.LEX_L11
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄎☐⌒└┖", a_),
					global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID.N7002
				}
			};
			global::Motorola.Common.Communication.CommonUtil.PbbDeviceInfoConverters.ProductModelsMap = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>
			{
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜎娐ℒ└∖⼘娚", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚稜", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜎娐ℒ└№ⴘ娚", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚琜", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬎┐−└⌖堘㐚䤜⬞ဠጢဤ昦ب缪᤬ḮİԲ琴", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⬚琜砞", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬎┐−└‖堘㐚䤜⬞ဠጢᴤ昦ب缪᤬Ḯİਲ琴", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔娖⬘⬚", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤎ℐ⌒—✖堘", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("嬎尐弒㔔娖⨘⬚", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䤎ℐ⌒—∖堘", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎䔐䜒䘔㨖䴘娚弜⸞ᜠย昤昦稨", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎䔐䜒䘔㨖䴘娚弜⸞ᜠย昤昦稨", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔儖⠘⬚", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔儖⠘⬚", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("導砐☒└✖", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䜎娐ℒ└№⬘娚", a_),
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄎☐⌒└☖", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⨚", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䌎吐䬒㔔嬖⠘⨚", a_)
					}
				},
				{
					global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("導砐␒└✖", a_),
					new global::System.Collections.Generic.List<string>
					{
						global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䄎☐⌒└┖", a_)
					}
				}
			};
		}

		// Token: 0x04000235 RID: 565
		public static global::System.Collections.Generic.Dictionary<string, global::Motorola.Common.Communication.CommonUtil.PBBDeviceTypeID> FirmwareModelsMaskMap;

		// Token: 0x04000236 RID: 566
		public static readonly global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> ProductModelsMap;
	}
}
