using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace CommonUtility
{
	// Token: 0x0200003A RID: 58
	public static class PCRKeyUtility
	{
		// Token: 0x0600012B RID: 299 RVA: 0x0001F7E8 File Offset: 0x0001D9E8
		public static bool IsPCRKeySet(string setType)
		{
			short num = (short)297205761;
			if (num != 0)
			{
			}
			num = (short)447479808;
			short num2 = num;
			num = (short)515058504;
			short num3 = num;
			num = (short)1366895432;
			switch (num3 == num)
			{
			}
			num = (short)1283850240;
			if (num != 0)
			{
			}
			return global::CommonUtility.PCRKeyUtility.k.Contains(setType);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0001F8A0 File Offset: 0x0001DAA0
		public static bool IsVirtualAlias(string name)
		{
			short num = (short)164538756;
			short num2 = num;
			num = (short)17869188;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1844838400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1667629057;
			if (num != 0)
			{
			}
			num = (short)1360723968;
			if (num != 0)
			{
			}
			return global::CommonUtility.PCRKeyUtility.l.Contains(name);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0001F954 File Offset: 0x0001DB54
		public static bool IsKeysCached(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData existedCache, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData newIDs)
		{
			short num = (short)1034027016;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					if (newIDs.SymmetricKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a)).Except(existedCache.SymmetricKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b))).ToList<int>().Count > 0)
					{
						num = (short)2055864327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)301727755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_126;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
				{
					num = (short)395771904;
					short num3 = num;
					if (newIDs.RASKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey, string>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a)).Except(existedCache.RASKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey, string>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b))).ToList<string>().Count > 0)
					{
						num = (short)1492189188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2021780563;
					short num4 = num;
					num = (short)116059219;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					default:
						num = (short)1822097408;
						if (num != 0)
						{
						}
						num = (short)531628033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					return false;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 9:
					if (newIDs.OTAPKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a)).Except(existedCache.OTAPKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b))).ToList<int>().Count > 0)
					{
						num = (short)1268580355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1609760770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return false;
				case 11:
					if (newIDs.PreSharedKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey, string>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a)).Except(existedCache.PreSharedKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey, string>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b))).ToList<string>().Count > 0)
					{
						num = (short)1475805184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_55:
				if (existedCache == null)
				{
					num = (short)265224202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)450953225;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_126:
				if (newIDs.PrivacyKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a)).Except(existedCache.PrivacyKeys.Select(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey, int>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b))).ToList<int>().Count > 0)
				{
					num = (short)376504321;
					if (num != 0)
					{
					}
					num = (short)687538181;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)275316742;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0001FD90 File Offset: 0x0001DF90
		public static bool IsOtapAuthenticationKeyValid(int? id, string alias, string value, bool allowFullFValue)
		{
			int a_ = 6;
			short num = (short)1879441415;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1642397697;
					if (num != 0)
					{
					}
					num = (short)1964769282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_24D;
				case 2:
					goto IL_143;
				case 3:
					if (global::CommonUtility.PCRKeyUtility.IsOtapAuthenticationKeyIDValid(id))
					{
						num = (short)858390528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)630325256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (global::CommonUtility.PCRKeyUtility.IsOTAPAuthorizationKeyAliasValid(alias))
					{
						num = (short)1698758656;
						short num3 = num;
						num = (short)603979781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_1AF;
				case 6:
					if (global::CommonUtility.PCRKeyUtility.IsOtapAuthenticationKeyIDValid(id))
					{
						num = (short)1490288650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 8:
				{
					num = (short)1203046637;
					short num4 = num;
					num = (short)363989229;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AF;
					default:
						goto IL_C5;
					}
					break;
				}
				case 9:
					num = (short)1527185414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)152436740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				if (!allowFullFValue)
				{
					num = (short)944439305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1404829699;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AF:
				num = (short)2124152833;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_C5:
			num = (short)1510342656;
			if (num != 0)
			{
			}
			bool flag = false;
			IL_DF:
			bool flag2 = value.Trim().Equals(global::CommonUtility.VersionUtility.b("然缸紺笼社݀Ղ̈́ņ཈", a_), global::System.StringComparison.OrdinalIgnoreCase) || global::CommonUtility.PCRKeyUtility.IsOTAPAuthorizationKeyValueValid(value);
			return flag && flag2;
			IL_143:
			flag = global::CommonUtility.PCRKeyUtility.IsOTAPAuthorizationKeyAliasValid(alias);
			goto IL_DF;
			IL_24D:
			return global::CommonUtility.PCRKeyUtility.IsOTAPAuthorizationKeyValueValid(value);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001FFFC File Offset: 0x0001E1FC
		public static bool IsOtapAuthenticationKeyIDValid(int? otapAuthenticationKeyID)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num4;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					int? num2;
					int num3;
					if (num2.GetValueOrDefault() > num3 & num2 != null)
					{
						num4 = (short)275644418;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					return result;
				}
				case 1:
					return result;
				case 2:
					goto IL_B7;
				case 3:
				{
					num4 = (short)1922105344;
					short num5 = num4;
					int? num2 = otapAuthenticationKeyID;
					int num3 = 65535;
					num4 = (short)1023213568;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 4:
				{
					int? num2 = otapAuthenticationKeyID;
					int num3 = 0;
					num4 = (short)663093254;
					num = (int)((global::System.IntPtr)num4);
					continue;
				}
				case 5:
					if (otapAuthenticationKeyID != null)
					{
						num4 = (short)1211629572;
						num = (int)((global::System.IntPtr)num4);
						continue;
					}
					return result;
				case 6:
				{
					int? num2;
					int num3;
					if (!(num2.GetValueOrDefault() <= num3 & num2 != null))
					{
						goto IL_15C;
					}
					goto IL_B7;
				}
				}
				goto IL_2C;
				IL_B7:
				result = false;
				num4 = (short)557121537;
				num = (int)((global::System.IntPtr)num4);
			}
			return result;
			IL_2C:
			result = true;
			num4 = (short)1451380686;
			short num6 = num4;
			num4 = (short)1898401742;
			switch ((num6 == num4) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_15C:
				num4 = (short)1530462209;
				if (num4 != 0)
				{
				}
				num4 = (short)1464205315;
				int num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
			default:
			{
				num4 = (short)116129792;
				if (num4 != 0)
				{
				}
				num4 = (short)138477573;
				int num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000201D4 File Offset: 0x0001E3D4
		public static bool IsOTAPAuthorizationKeyValueValid(string otapValue)
		{
			int a_ = 9;
			short num = (short)1478033410;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				IL_27:
				switch (num2)
				{
				case 0:
					if (otapValue.Trim().ToUpperInvariant().Equals(global::CommonUtility.VersionUtility.b("簹稻砽ؿсɃE็౉ੋ", a_)))
					{
						num = (short)1486487556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 1:
					num = (short)1549336577;
					if (num != 0)
					{
					}
					try
					{
						long num3 = long.Parse(otapValue, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.NumberFormatInfo.InvariantInfo);
						goto IL_198;
					}
					catch (global::System.Exception)
					{
						result = false;
						goto IL_218;
					}
					return false;
					IL_198:
					num = (short)1763311623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 3:
					goto IL_107;
				case 4:
					return false;
				case 5:
					return false;
				case 6:
				{
					if (string.IsNullOrWhiteSpace(otapValue))
					{
						num = (short)183959555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					long num3 = 0L;
					num = (short)330170369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
				{
					long num3;
					if (num3 == 0L)
					{
						num = (short)1918304261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1240989696;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					return true;
				}
				IL_51:
				while (otapValue.Equals(global::CommonUtility.VersionUtility.b("㼛", a_)))
				{
					num = (short)2013161123;
					short num4 = num;
					num = (short)733767331;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1685258240;
						if (num != 0)
						{
						}
						num = (short)1779499016;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
				}
				num = (short)821297158;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_107:
			return false;
			IL_161:
			return new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("搹朻弽洿⑁Ճ歅็穉態睍൏⥑敓穕慗❙ݛ㽝䵟ѡ╣䭥⹧婩䅫坭ⵯॱ䑳婵䥷ݹ塻", a_)).IsMatch(otapValue);
			IL_218:
			num = (short)521994240;
			short num5 = num;
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00020434 File Offset: 0x0001E634
		public static bool IsOTAPAuthorizationKeyAliasValid(string keyAlias)
		{
			short num = (short)620135075;
			short num2 = num;
			num = (short)360874659;
			switch (num2 == num)
			{
			}
			num = (short)2011299840;
			short num3 = num;
			num = (short)1818689537;
			if (num != 0)
			{
			}
			num = (short)1469251584;
			if (num != 0)
			{
			}
			return global::CommonUtility.PCRKeyUtility.a(keyAlias);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000204E4 File Offset: 0x0001E6E4
		public static bool IsPrivacyKeyValid(int? id, string alias, string value)
		{
			short num = (short)2068774915;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)369754112;
				short num3 = num;
				switch (num2)
				{
				case 0:
				{
					num = (short)1761975964;
					short num4 = num;
					num = (short)1571004060;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)851771392;
						if (num != 0)
						{
						}
						num = (short)1675755522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_12D;
				case 2:
					if (global::CommonUtility.PCRKeyUtility.IsPrivacyKeyAliasValid(alias))
					{
						num = (short)1189216257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					goto IL_14;
				}
				goto IL_5E;
				IL_14:
				switch (0)
				{
				case 0:
					IL_5E:
					if (!global::CommonUtility.PCRKeyUtility.IsPrivacyKeyIDValid(id))
					{
						return false;
					}
					num = (short)955580416;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_12D:
			num = (short)554237953;
			if (num != 0)
			{
			}
			return global::CommonUtility.PCRKeyUtility.IsPrivacyKeyValueValid(value);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00020624 File Offset: 0x0001E824
		public static bool IsPrivacyKeyIDValid(int? privacyKeyID)
		{
			short num = (short)482803712;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 1:
				{
					int? num3;
					int num4;
					if (num3.GetValueOrDefault() > num4 & num3 != null)
					{
						num = (short)853016578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 2:
					goto IL_14E;
				case 3:
				{
					int? num3 = privacyKeyID;
					int num4 = 255;
					num = (short)1725956097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					int? num3;
					int num4;
					if (!(num3.GetValueOrDefault() <= num4 & num3 != null))
					{
						num = (short)1937702915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 5:
				{
					int? num3 = privacyKeyID;
					int num4 = 0;
					num = (short)1316093956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_3D:
				num = (short)1788870657;
				if (num != 0)
				{
				}
				if (privacyKeyID == null)
				{
					break;
				}
				num = (short)1652424704;
				short num5 = num;
				num = (short)1137450981;
				short num6 = num;
				num = (short)407248869;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)991363072;
					if (num != 0)
					{
					}
					num = (short)106758149;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_14E:
			return false;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000207D4 File Offset: 0x0001E9D4
		public static bool IsPrivacyKeyValueValid(string privacyKeyValue)
		{
			int a_ = 10;
			short num = (short)1032847362;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				long num3;
				switch (num2)
				{
				case 0:
					if (num3 == 0L)
					{
						num = (short)47185924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)641269766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1374336102;
					short num4 = num;
					num = (short)1380758630;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)353435648;
						if (num != 0)
						{
						}
						num = (short)118554625;
						if (num != 0)
						{
						}
						try
						{
							num3 = long.Parse(privacyKeyValue, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.NumberFormatInfo.InvariantInfo);
							goto IL_EE;
						}
						catch (global::System.Exception)
						{
							return false;
						}
						goto IL_1A7;
						IL_EE:
						num = (short)794427392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_52;
					}
					continue;
				case 3:
					return false;
				case 4:
					return false;
				case 5:
					goto IL_16B;
				case 6:
					if (privacyKeyValue.Trim().Equals(global::CommonUtility.VersionUtility.b("紺笼社݀Ղ̈́ņ཈ൊୌ", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)2123890691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
				case 7:
					if (privacyKeyValue.Equals(global::CommonUtility.VersionUtility.b("㸘", a_)))
					{
						num = (short)1222115333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A7;
				case 8:
				{
					num = (short)475463680;
					short num5 = num;
					num = (short)94109703;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_52:
				if (!string.IsNullOrWhiteSpace(privacyKeyValue))
				{
					num = (short)1075773448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_1A7:
				num3 = 0L;
				num = (short)1465581569;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_16B:
			return false;
			IL_16F:
			return new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("攺昼帾汀╂ф橆཈筊恌癎౐⡒摔策桘歚⁜筞", a_)).IsMatch(privacyKeyValue);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00020A2C File Offset: 0x0001EC2C
		public static bool IsPrivacyKeyAliasValid(string keyAlias)
		{
			short num = (short)1479420259;
			short num2 = num;
			num = (short)1058482531;
			switch (num2 == num)
			{
			}
			num = (short)914554880;
			short num3 = num;
			num = (short)1422721025;
			if (num != 0)
			{
			}
			num = (short)609026048;
			if (num != 0)
			{
			}
			return global::CommonUtility.PCRKeyUtility.a(keyAlias);
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00020ADC File Offset: 0x0001ECDC
		public static bool IsRASKeyValid(string alias, string value)
		{
			short num;
			if (global::CommonUtility.PCRKeyUtility.IsRASKeyAliasValid(alias))
			{
				num = (short)1167744563;
				short num2 = num;
				num = (short)556359219;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)655032321;
					if (num != 0)
					{
					}
					num = (short)2079129600;
					if (num != 0)
					{
					}
					return global::CommonUtility.PCRKeyUtility.IsRASKeyValueValid(value);
				}
			}
			num = (short)955252736;
			short num3 = num;
			return false;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00020B94 File Offset: 0x0001ED94
		public static bool IsRASKeyValueValid(string rasKeyValue)
		{
			int a_ = 1;
			short num = (short)1028390913;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1D0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 2:
					return false;
				case 3:
					if (string.IsNullOrWhiteSpace(rasKeyValue))
					{
						num = (short)115212288;
						short num3 = num;
						num = (short)205783046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1346895877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (rasKeyValue.Trim().Length > 24)
					{
						num = (short)228786176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D4;
				case 5:
					if (rasKeyValue.Trim().Length < 6)
					{
						num = (short)794624001;
						if (num != 0)
						{
						}
						num = (short)368771074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1306525700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return false;
				case 7:
					return false;
				}
				IL_4E:
				num = (short)360702760;
				short num4 = num;
				num = (short)349627176;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)1616576512;
					if (num != 0)
					{
					}
					if (string.IsNullOrEmpty(rasKeyValue))
					{
						num = (short)88539143;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1551695875;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			return false;
			IL_1D0:
			return false;
			IL_1D4:
			return new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("氱漳圵ᔷ䀹紻ጽᨿ牁楃罅ᑇ湉潋ᅍ絏ད⽓恕瑗桙桛⍝䑟", a_)).IsMatch(rasKeyValue);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00020D90 File Offset: 0x0001EF90
		public static bool IsRASKeyAliasValid(string keyAlias)
		{
			short num = (short)1926600080;
			short num2 = num;
			num = (short)1879741840;
			switch (num2 == num)
			{
			}
			num = (short)480313344;
			if (num != 0)
			{
			}
			num = (short)1058930689;
			if (num != 0)
			{
			}
			num = (short)1441529856;
			short num3 = num;
			return global::CommonUtility.PCRKeyUtility.a(keyAlias);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00020E44 File Offset: 0x0001F044
		public static bool IsSymmetricKeyValid(int? id, string alias, string value)
		{
			short num = (short)107741185;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_110;
				case 1:
					goto IL_15;
				case 2:
					if (global::CommonUtility.PCRKeyUtility.IsSymmetricKeyAliasValid(alias))
					{
						num = (short)1893007360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					num = (short)1150222338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_35;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_35:
					num = (short)1836100696;
					short num3 = num;
					num = (short)1570286680;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1645936640;
						if (num != 0)
						{
						}
						if (!global::CommonUtility.PCRKeyUtility.IsSymmetricKeyIDValid(id))
						{
							return false;
						}
						num = (short)274792451;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_110:
			num = (short)1739522049;
			if (num != 0)
			{
			}
			num = (short)1628241920;
			short num4 = num;
			return global::CommonUtility.PCRKeyUtility.IsSymmetricKeyValueValid(value);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00020F94 File Offset: 0x0001F194
		public static bool IsSymmetricKeyIDValid(int? symmetricKeyID)
		{
			short num = (short)308871171;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					int? num3 = symmetricKeyID;
					int num4 = 255;
					num = (short)918880261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					num = (short)424083457;
					if (num != 0)
					{
					}
					int? num3 = symmetricKeyID;
					int num4 = 0;
					num = (short)1426325508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_149;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 4:
				{
					int? num3;
					int num4;
					if (!(num3.GetValueOrDefault() <= num4 & num3 != null))
					{
						num = (short)429654016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87;
				}
				case 5:
				{
					int? num3;
					int num4;
					if (!(num3.GetValueOrDefault() > num4 & num3 != null))
					{
						return true;
					}
					num = (short)40894968;
					short num5 = num;
					num = (short)1701380600;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_149;
					default:
						num = (short)451215360;
						if (num != 0)
						{
						}
						num = (short)796459010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_3E:
				if (symmetricKeyID == null)
				{
					break;
				}
				num = (short)1163591681;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_87:
			num = (short)1488912384;
			short num6 = num;
			return false;
			IL_149:
			goto IL_87;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00021144 File Offset: 0x0001F344
		public static bool IsSymmetricKeyAliasValid(string keyAlias)
		{
			short num = (short)152507865;
			short num2 = num;
			num = (short)422254041;
			switch (num2 == num)
			{
			}
			num = (short)837484544;
			if (num != 0)
			{
			}
			num = (short)1039990785;
			if (num != 0)
			{
			}
			num = (short)1930100736;
			short num3 = num;
			return global::CommonUtility.PCRKeyUtility.a(keyAlias);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x000211F4 File Offset: 0x0001F3F4
		public static bool IsSymmetricKeyValueValid(string symmetricKeyValue)
		{
			int a_ = 7;
			short num = (short)173932549;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_194;
				case 1:
					return false;
				case 2:
					if (string.IsNullOrEmpty(symmetricKeyValue.Replace(global::CommonUtility.VersionUtility.b("࠷", a_), "")))
					{
						num = (short)45023236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)302579715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (symmetricKeyValue.Equals(global::CommonUtility.VersionUtility.b("縷簹稻砽ؿсɃE็౉ੋࡍᙏᑑቓၕṗ᱙ᩛᡝ♟②≣⁥⹧Ⱪ⩫⡭㙯㑱㉳ふ㹷㱹㩻㡽왿쒁슃삅캇첉쪋좍횏풑튓킕\ude97\udc99\uda9b\ud89d", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num = (short)2064777223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_20A;
				case 4:
					goto IL_16A;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 6:
					if (symmetricKeyValue.Equals(global::CommonUtility.VersionUtility.b("㴕", a_)))
					{
						num = (short)1453916161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					symmetricKeyValue = symmetricKeyValue.Trim();
					num = (short)293470210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return false;
				}
				IL_4D:
				num = (short)543714586;
				short num3 = num;
				num = (short)518155546;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_194:
					num = (short)140574721;
					if (num != 0)
					{
					}
					num = (short)1448804358;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1234632704;
					if (num != 0)
					{
					}
					if (string.IsNullOrWhiteSpace(symmetricKeyValue))
					{
						return false;
					}
					num = (short)996671488;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_16A:
			num = (short)637009920;
			short num4 = num;
			return false;
			IL_20A:
			return new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("昷愹崻ጽ☿́楃E硇杉畋ፍ⭏捑硓恕汗❙硛", a_)).IsMatch(symmetricKeyValue);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00021424 File Offset: 0x0001F624
		public static bool IsPreSharedKeyValid(string alias, string value)
		{
			short num;
			while (!global::CommonUtility.PCRKeyUtility.IsPreSharedKeyAliasValid(alias))
			{
				num = (short)378803824;
				short num2 = num;
				num = (short)1460147824;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)175243265;
					if (num != 0)
					{
					}
					num = (short)1103888384;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)701235200;
			short num3 = num;
			return global::CommonUtility.PCRKeyUtility.IsPreSharedKeyValueValid(value);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000214DC File Offset: 0x0001F6DC
		public static bool IsPreSharedKeyValueValid(string psKeyValue)
		{
			int a_ = 8;
			short num = (short)1888681991;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (string.IsNullOrWhiteSpace(psKeyValue))
					{
						num = (short)1213202441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)554958856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)566701734;
					short num3 = num;
					num = (short)1565863590;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AD;
					default:
						goto IL_AC;
					}
					break;
				}
				case 2:
					return false;
				case 3:
					num = (short)195362817;
					if (num != 0)
					{
					}
					if (psKeyValue.Trim().Equals(global::CommonUtility.VersionUtility.b("स଺഼༾煀獂畄睆祈筊経罎慐捒敔杖楘歚浜潞兠卢啤坦奨孪嵬彮䅰䍲䕴䝶", a_)))
					{
						num = (short)640221186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_252;
				case 4:
					if (psKeyValue.Trim().ToUpperInvariant().Equals(global::CommonUtility.VersionUtility.b("缸紺笼社݀Ղ̈́ņ཈ൊୌॎᝐᕒፔᅖ὘ᵚ᭜ᥞ❠╢⍤Ⅶ⽨⵪⭬⥮㝰㕲㍴ㅶ", a_)))
					{
						num = (short)34013190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)142344195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_24B;
				case 6:
					return false;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					continue;
				case 8:
					if (psKeyValue.Trim().Length != 32)
					{
						num = (short)871432197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1AD;
				case 9:
					return false;
				}
				IL_57:
				if (string.IsNullOrEmpty(psKeyValue))
				{
					num = (short)1404305409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2145845248;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1AD:
				num = (short)1419313156;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AC:
			num = (short)35717120;
			if (num != 0)
			{
			}
			return false;
			IL_24B:
			num = (short)492371968;
			short num4 = num;
			return false;
			IL_252:
			return new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("朸怺഼ሾ础≂桄ⅆࡈ晊ୌ቎⩐恒杔⩖絘", a_)).IsMatch(psKeyValue);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00021754 File Offset: 0x0001F954
		public static bool IsPreSharedKeyAliasValid(string keyAlias)
		{
			short num;
			while (!global::CommonUtility.PCRKeyUtility.a(keyAlias))
			{
				num = (short)38823787;
				short num2 = num;
				num = (short)2098554731;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2089484289;
					if (num != 0)
					{
					}
					num = (short)708116480;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1432354816;
			short num3 = num;
			return global::System.Text.Encoding.ASCII.GetByteCount(keyAlias.Trim()) <= 16;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00021820 File Offset: 0x0001FA20
		private static bool a(string A_0)
		{
			short num = (short)533118768;
			short num2 = num;
			num = (short)143638320;
			switch (num2 == num)
			{
			}
			num = (short)47841281;
			if (num != 0)
			{
			}
			num = (short)557056000;
			if (num != 0)
			{
			}
			num = (short)1414725632;
			short num3 = num;
			return !string.IsNullOrWhiteSpace(A_0);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x000218D0 File Offset: 0x0001FAD0
		public static void Update(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData source, global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration)
		{
			int a_ = 17;
			short num = (short)987103232;
			switch (num)
			{
			default:
			{
				num = (short)1302331408;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						enumerator = dbnode.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)281149444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1365704713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)530448394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1804468225;
						if (num != 0)
						{
						}
						num = (short)869269519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_9CE;
					case 5:
						num = (short)114425867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2 = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b));
						num = (short)250281991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						if (dbnode2 != null)
						{
							num = (short)1762000916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C8;
					}
					case 8:
					{
						num = (short)602603520;
						short num3 = num;
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						if (dbnode2.ChildNodesList.Count > 0)
						{
							num = (short)1655767057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C8;
					}
					case 9:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3 = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a));
						num = (short)822935571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode.ChildNodesList.Any<global::Motorola.CommonCPS.Server.EntityModel.DBNode>())
						{
							num = (short)211812352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						if (dbnode3.ChildNodesList.Count > 0)
						{
							num = (short)1744371725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode != null)
						{
							num = (short)1334444034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 13:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						enumerator = dbnode3.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)905642002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						try
						{
							num = (short)735313925;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								string name;
								switch (num2)
								{
								case 0:
									goto IL_8B8;
								case 2:
								{
									if (!(name == global::CommonUtility.VersionUtility.b("ཁ੃ཅᭇ᥉㕋⍍㵏㝑⁓⑕ㅗ㥙᝛㭝ᥟᅡ", a_)))
									{
										num = (short)1060700168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1528507574;
									short num4 = num;
									num = (short)878324918;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_867;
									default:
									{
										num = (short)1523712000;
										if (num != 0)
										{
										}
										global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4;
										global::CommonUtility.PCRKeyUtility.b(source, dbnode4);
										num = (short)1024851969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1425866761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4 = enumerator.Current;
									name = dbnode4.Name;
									num = (short)394133514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_705;
									}
									continue;
								case 6:
									num = (short)1273954306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1664417799;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)124125184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_867;
								}
								IL_76A:
								num = (short)1959067651;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_705:
								goto IL_76A;
								IL_867:
								if (!(name == global::CommonUtility.VersionUtility.b("ཁ੃ཅᭇཉ≋♍ㅏ㱑㝓㍕㱗ਖ਼⹛㝝ᙟ͡ݣὥ⍧ཀྵᕫᵭ", a_)))
								{
									num = (short)1251147782;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4;
									global::CommonUtility.PCRKeyUtility.c(source, dbnode4);
									num = (short)1657470980;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_8B8:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_8C8;
					case 15:
						if (configuration.DBNode != null)
						{
							num = (short)1960050689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 17:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						enumerator = dbnode2.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)1901985806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						try
						{
							num = (short)1647312910;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("၁Ճᕅ͇⽉㕋㵍", a_)))
									{
										num = (short)53018637;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.e(source, dbnode5);
									num = (short)964821010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1462632458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)767295505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)69795846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)30736385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5 = enumerator.Current;
									string name = dbnode5.Name;
									num = (short)1757085715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("݁⩃⹅⥇⑉⽋⭍㑏ɑ♓㽕⹗㭙㽛❝⭟ݡᵣᕥ", a_)))
									{
										num = (short)412221451;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.f(source, dbnode5);
									num = (short)71434243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1638662159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_573;
								case 11:
									num = (short)1518862336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("́Ńᕅ͇⽉㕋㵍", a_)))
									{
										num = (short)1006632962;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.d(source, dbnode5);
									num = (short)375062535;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									num = (short)1108148236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									switch (0)
									{
									case 0:
										goto IL_2A1;
									}
									continue;
								case 17:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ቁ㙃⍅ᭇ≉ⵋ㱍㕏㙑ὓ㍕⅗⥙", a_)))
									{
										num = (short)1356070921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.g(source, dbnode5);
									num = (short)752615432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ു၃݅ᡇ୉㥋㩍㡏㝑㩓≕ㅗ㥙㵛⩝य़ൡ੣ⵥ൧፩", a_)))
									{
										num = (short)268173316;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.h(source, dbnode5);
									num = (short)1377828880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3DB:
								num = (short)1345257477;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A1:
								goto IL_3DB;
							}
							IL_573:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_583;
					case 19:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						if (dbnode3 != null)
						{
							num = (short)1084882949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					}
					case 20:
						num = (short)1817575432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.c));
						num = (short)23003148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A6:
					if (configuration != null)
					{
						num = (short)682754051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_583:
					num = (short)611778566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C8:
					num = (short)1849032725;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9CE:
				try
				{
					num = (short)1454768129;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_ADE;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A13;
							}
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6;
							if (dbnode6.Name == global::CommonUtility.VersionUtility.b("فृᑅ筇ᩉ㹋⭍͏㩑㕓⑕㵗㹙᝛㭝ᥟᅡ", a_))
							{
								num = (short)1409548293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)334823430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6 = enumerator.Current;
							num = (short)2121334786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6;
							global::CommonUtility.PCRKeyUtility.a(source, dbnode6);
							num = (short)131792900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)782827520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_A89:
						num = (short)1369833475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A13:
						goto IL_A89;
					}
					IL_ADE:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00022418 File Offset: 0x00020618
		private static int b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, string A_1)
		{
			short num = (short)1932249920;
			short num2 = num;
			num = (short)988138304;
			global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)649789440;
				if (num != 0)
				{
				}
				global::CommonUtility.PCRKeyUtility.a a = new global::CommonUtility.PCRKeyUtility.a();
				a.a = A_1;
				dbfield = (A_0.ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(a.b)) as global::Motorola.CommonCPS.Server.EntityModel.DBField);
				if (dbfield == null)
				{
					return 0;
				}
				break;
			}
			}
			num = (short)213516289;
			if (num != 0)
			{
			}
			num = (short)1052639232;
			short num3 = num;
			return global::System.Convert.ToInt32(dbfield.Value, global::System.Globalization.NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00022504 File Offset: 0x00020704
		private static string a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, string A_1)
		{
			short num = (short)1902204619;
			short num2 = num;
			num = (short)682579659;
			global::Motorola.CommonCPS.Server.EntityModel.DBField dbfield;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1317208065;
				if (num != 0)
				{
				}
				num = (short)1881931776;
				if (num != 0)
				{
				}
				global::CommonUtility.PCRKeyUtility.b b = new global::CommonUtility.PCRKeyUtility.b();
				b.a = A_1;
				dbfield = (A_0.ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(b.b)) as global::Motorola.CommonCPS.Server.EntityModel.DBField);
				if (dbfield == null)
				{
					return string.Empty;
				}
				break;
			}
			}
			num = (short)1747714048;
			short num3 = num;
			return dbfield.Value;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000225E8 File Offset: 0x000207E8
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, string A_1, string A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dbnode != null)
					{
						num2 = (short)2102853633;
						if (num2 != 0)
						{
						}
						num2 = (short)1957036034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_137;
				case 1:
					goto IL_135;
				case 2:
				{
					num2 = (short)1577582592;
					short num3 = num2;
					num2 = (short)828407138;
					short num4 = num2;
					num2 = (short)842759522;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)570556416;
						if (num2 != 0)
						{
						}
						A_0.ChildNodesList.Remove(dbnode);
						break;
					}
					num2 = (short)1993867265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_135:
			IL_137:
			global::CommonUtility.PCRKeyUtility.c c;
			A_0.ChildNodesList.Add(new global::Motorola.CommonCPS.Server.EntityModel.DBField
			{
				Name = c.a,
				Value = A_2
			});
			return;
			IL_1C:
			c = new global::CommonUtility.PCRKeyUtility.c();
			c.a = A_1;
			dbnode = A_0.ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(c.b));
			num2 = (short)259325952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00022750 File Offset: 0x00020950
		private static void h(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 7;
			short num = (short)989774255;
			short num2 = num;
			num = (short)575324591;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1478230017;
				if (num != 0)
				{
				}
				num = (short)1841889280;
				if (num != 0)
				{
				}
				num = (short)630194176;
				switch (num)
				{
				}
				break;
			}
			num = (short)407175168;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey>.Enumerator enumerator = A_0.OTAPKeys.GetEnumerator())
			{
				num = (short)868876288;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39B;
						}
						continue;
					case 2:
						goto IL_418;
					case 3:
						num = (short)1510932482;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)6619139;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey = enumerator.Current;
						dictionary[matrixOTAPKey.Id] = matrixOTAPKey;
						num = (short)1100218369;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_3C9:
					num = (short)422510596;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B:
					goto IL_3C9;
				}
				IL_418:
				goto IL_350;
			}
			return;
			for (;;)
			{
				IL_350:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
				{
					num = (short)1349844998;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							int num5;
							if (dictionary.ContainsKey(num5))
							{
								num = (short)284491786;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1076953092;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator2.Current;
							int num5 = global::CommonUtility.PCRKeyUtility.b(dbnode, global::CommonUtility.VersionUtility.b("眷礹挻焽ᐿ́ᑃ݅ᵇṉыՍᕏ୑ᵓቕ", a_));
							num = (short)1906245640;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)2115567625;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = dbnode;
							string a_3 = global::CommonUtility.VersionUtility.b("眷礹挻焽ᐿ́ᑃՅ᱇݉݋୍ॏ", a_);
							global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
							string format = global::CommonUtility.VersionUtility.b("䌷ਹػ昽㴿", a_);
							int num5;
							long? value = dictionary[num5].Value;
							global::CommonUtility.PCRKeyUtility.a(a_2, a_3, string.Format(invariantCulture, format, value.Value));
							num = (short)701366272;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_12F;
							}
							continue;
						case 7:
						{
							long? value;
							if (value != null)
							{
								num = (short)249167877;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("眷礹挻焽ᐿ́ᑃՅ᱇݉݋୍ॏ", a_), global::CommonUtility.VersionUtility.b("縷簹稻砽ؿсɃE็౉", a_));
							num = (short)731381763;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							int num5;
							if (num5 != 0)
							{
								num = (short)1685258251;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_33D;
						case 10:
						{
							int num5;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("眷礹挻焽ᐿ́ᑃՅ᱇݉݋ᝍᅏṑݓ", a_), dictionary[num5].Alias);
							long? value = dictionary[num5].Value;
							num = (short)1963393031;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)1880817665;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_16F:
						num = (short)53215234;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12F:
						goto IL_16F;
					}
					IL_33D:
					break;
				}
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00022BBC File Offset: 0x00020DBC
		private static void g(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 3;
			short num = (short)507104621;
			short num2 = num;
			num = (short)304139629;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)76611585;
				if (num != 0)
				{
				}
				num = (short)1337655296;
				if (num != 0)
				{
				}
				num = (short)137887744;
				switch (num)
				{
				}
				break;
			}
			num = (short)2004353024;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>.Enumerator enumerator = A_0.PreSharedKeys.GetEnumerator())
			{
				num = (short)776404992;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34A;
						}
						continue;
					case 2:
						goto IL_3C6;
					case 3:
						num = (short)200146946;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)695009283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey matrixPreSharedKey = enumerator.Current;
						dictionary[matrixPreSharedKey.Alias] = matrixPreSharedKey;
						num = (short)1421213697;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_378:
					num = (short)1318846468;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_34A:
					goto IL_378;
				}
				IL_3C6:
				goto IL_2FE;
			}
			return;
			for (;;)
			{
				IL_2FE:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
				{
					num = (short)216530950;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							string text;
							if (dictionary.ContainsKey(text))
							{
								num = (short)309461002;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1118568452;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator2.Current;
							string text = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("搳攵猷縹紻樽Ŀᵁᑃᕅ͇͉ࡋ", a_));
							num = (short)833093640;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)750321673;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							string text;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
							global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("搳攵猷縹紻樽Ŀᵁᑃᕅ้͇ോᩍᅏ", a_), dictionary[text].Value);
							num = (short)851968;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_12F;
							}
							continue;
						case 7:
						{
							string text;
							if (!string.IsNullOrEmpty(dictionary[text].Value))
							{
								num = (short)1624047621;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
							global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("搳攵猷縹紻樽Ŀᵁᑃᕅ้͇ോᩍᅏ", a_), string.Empty);
							num = (short)1318191107;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							string text;
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)1057423371;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_2EB;
						case 10:
							num = (short)637140999;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)613154817;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_163:
						num = (short)11862018;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12F:
						goto IL_163;
					}
					IL_2EB:
					break;
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00022FD8 File Offset: 0x000211D8
		private static void f(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 16;
			short num = (short)1656422401;
			if (num != 0)
			{
			}
			num = (short)1547239832;
			short num2 = num;
			num = (short)805044632;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1512112128;
				if (num != 0)
				{
				}
				num = (short)1447100416;
				switch (num)
				{
				}
				break;
			}
			num = (short)111542272;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>.Enumerator enumerator = A_0.PrivacyKeys.GetEnumerator())
			{
				num = (short)867893248;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_39E;
						}
						continue;
					case 2:
						goto IL_41B;
					case 3:
						num = (short)683409410;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1027932163;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey matrixPrivacyKey = enumerator.Current;
						dictionary[matrixPrivacyKey.Id] = matrixPrivacyKey;
						num = (short)893452289;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_3CC:
					num = (short)707854340;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_39E:
					goto IL_3CC;
				}
				IL_41B:
				goto IL_351;
			}
			return;
			for (;;)
			{
				IL_351:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
				{
					num = (short)9633798;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							int num5;
							if (dictionary.ContainsKey(num5))
							{
								num = (short)1168900106;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1624113156;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator2.Current;
							int num5 = global::CommonUtility.PCRKeyUtility.b(dbnode, global::CommonUtility.VersionUtility.b("рൂൄᝆᭈɊቌ὎ᩐᙒ౔Ṗᵘ", a_));
							num = (short)1871904776;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)999882761;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = dbnode;
							string a_3 = global::CommonUtility.VersionUtility.b("рൂൄᝆᭈɊቌ὎ᩐᙒ౔", a_);
							global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
							string format = global::CommonUtility.VersionUtility.b("㩀獂罄὆㑈", a_);
							int num5;
							long? value = dictionary[num5].Value;
							global::CommonUtility.PCRKeyUtility.a(a_2, a_3, string.Format(invariantCulture, format, value.Value));
							num = (short)65077248;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_12E;
							}
							continue;
						case 7:
						{
							long? value;
							if (value != null)
							{
								num = (short)1911619589;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("рൂൄᝆᭈɊቌ὎ᩐᙒ౔", a_), global::CommonUtility.VersionUtility.b("݀Ղ̈́ņ཈ൊୌॎᝐᕒ", a_));
							num = (short)1708392451;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							int num5;
							if (num5 != 0)
							{
								num = (short)1942880267;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_33E;
						case 10:
						{
							int num5;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
							global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("рൂൄᝆᭈɊቌ὎ᩐᙒ౔ᙖᕘቚᱜ౞", a_), dictionary[num5].Alias);
							long? value = dictionary[num5].Value;
							num = (short)1884422151;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)799277057;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_16F:
						num = (short)394264578;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12E:
						goto IL_16F;
					}
					IL_33E:
					break;
				}
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00023448 File Offset: 0x00021648
		private static void e(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 0;
			short num = (short)445993803;
			short num2 = num;
			num = (short)230708043;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1918500865;
				if (num != 0)
				{
				}
				num = (short)988348416;
				if (num != 0)
				{
				}
				num = (short)1503068160;
				switch (num)
				{
				}
				break;
			}
			num = (short)232783872;
			short num3 = num;
			global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>.Enumerator enumerator = A_0.RASKeys.GetEnumerator())
			{
				num = (short)903086080;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_345;
						}
						continue;
					case 2:
						goto IL_3C5;
					case 3:
						num = (short)346947586;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)2094202883;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey = enumerator.Current;
						dictionary[matrixRASKey.Alias] = matrixRASKey;
						num = (short)944570369;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_374:
					num = (short)339345412;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_345:
					goto IL_374;
				}
				IL_3C5:
				goto IL_2F8;
			}
			return;
			for (;;)
			{
				IL_2F8:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
				{
					num = (short)1412628486;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
						{
							string text;
							if (dictionary.ContainsKey(text))
							{
								num = (short)196476938;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)924123140;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator2.Current;
							string text = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("挰爲昴猶砸漺簼怾ፀɂᙄنՈɊౌᱎ", a_));
							num = (short)536936456;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1668612105;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							string text;
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
							global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("挰爲昴猶砸漺簼怾ፀɂᙄెైቊ", a_), dictionary[text].Value);
							num = (short)1318649856;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_12F;
							}
							continue;
						case 7:
						{
							string text;
							if (!string.IsNullOrEmpty(dictionary[text].Value))
							{
								num = (short)494403589;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
							global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("挰爲昴猶砸漺簼怾ፀɂᙄెైቊ", a_), string.Empty);
							num = (short)970522627;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							string text;
							if (!string.IsNullOrEmpty(text))
							{
								num = (short)1171914763;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_2E5;
						case 10:
							num = (short)1191510023;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)560005121;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_162:
						num = (short)48693250;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12F:
						goto IL_162;
					}
					IL_2E5:
					break;
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00023864 File Offset: 0x00021A64
		private static void d(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 18;
			short num = (short)905427098;
			short num2 = num;
			num = (short)126990490;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9C;
			case 1:
				break;
			default:
			{
				num = (short)1882193920;
				short num3 = num;
				break;
			}
			}
			num = (short)853278720;
			if (num != 0)
			{
			}
			num = (short)1210056704;
			switch (num)
			{
			default:
			{
				IL_9C:
				global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>.Enumerator enumerator = A_0.SymmetricKeys.GetEnumerator())
				{
					num = (short)295043073;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_370;
							}
							continue;
						case 2:
							num = (short)1386545156;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)873529346;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey = enumerator.Current;
							dictionary[matrixSymmetricKey.Id] = matrixSymmetricKey;
							num = (short)650379264;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_3ED;
						}
						IL_39E:
						num = (short)856621059;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_370:
						goto IL_39E;
					}
					IL_3ED:
					goto IL_2FE;
				}
				return;
				for (;;)
				{
					IL_2FE:
					num = (short)1974665217;
					if (num != 0)
					{
					}
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
					{
						num = (short)937164806;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 1:
							{
								int num5;
								if (dictionary.ContainsKey(num5))
								{
									num = (short)1797324810;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)404226052;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator2.Current;
								int num5 = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("ɂDᑆ᥈᥊ь၎Őᡒၔ๖ၘ὚", a_));
								num = (short)623509512;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1761476617;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								int num5;
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("ɂDᑆ᥈᥊ь၎Őᡒၔ๖", a_), dictionary[num5].Value);
								num = (short)1117454336;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_109;
								}
								continue;
							case 7:
							{
								int num5;
								if (!string.IsNullOrEmpty(dictionary[num5].Value))
								{
									num = (short)1372258309;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("ɂDᑆ᥈᥊ь၎Őᡒၔ๖", a_), global::CommonUtility.VersionUtility.b("Ղ̈́ņ཈ൊୌॎᝐᕒፔᅖ὘ᵚ᭜ᥞ❠╢⍤Ⅶ⽨⵪⭬⥮㝰㕲㍴ㅶ㽸㵺㭼㥾잀얂쎄솆쾈춊쮌즎힐햒펔톖\udf98\udd9a\udb9c\ud99eﾸﶺ﮼料蟀", a_));
								num = (short)614727683;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								int num5;
								if (num5 != 0)
								{
									num = (short)1589903371;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_2EB;
							case 10:
							{
								int num5;
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("ɂDᑆ᥈᥊ь၎Őᡒၔ๖ᡘ᝚ᑜṞ㉠", a_), dictionary[num5].Alias);
								num = (short)253689863;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								num = (short)2228225;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_145:
							num = (short)1967652866;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_109:
							goto IL_145;
						}
						IL_2EB:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00023CA8 File Offset: 0x00021EA8
		private static void c(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 8;
			short num = (short)1651707087;
			short num2 = num;
			num = (short)1537805519;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C5;
			case 1:
				break;
			default:
			{
				num = (short)899284992;
				short num3 = num;
				break;
			}
			}
			num = (short)516161537;
			if (num != 0)
			{
			}
			num = (short)2065170432;
			if (num != 0)
			{
			}
			num = (short)741670912;
			switch (num)
			{
			default:
			{
				IL_C5:
				global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>.Enumerator enumerator = A_0.PrivacyKeys.GetEnumerator())
				{
					num = (short)506200065;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3A3;
							}
							continue;
						case 2:
							num = (short)1340932100;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1398276098;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey matrixPrivacyKey = enumerator.Current;
							dictionary[matrixPrivacyKey.Id] = matrixPrivacyKey;
							num = (short)126943232;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_41E;
						}
						IL_3D1:
						num = (short)861863939;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A3:
						goto IL_3D1;
					}
					IL_41E:
					goto IL_357;
				}
				return;
				for (;;)
				{
					IL_357:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
					{
						num = (short)1452605448;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)787152900;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator2.Current;
								int num5 = global::CommonUtility.PCRKeyUtility.b(dbnode, global::CommonUtility.VersionUtility.b("琸町琼氾рൂൄᝆᭈɊቌ὎ᩐᙒ౔Ṗᵘ", a_));
								num = (short)1352794119;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = dbnode;
								string a_3 = global::CommonUtility.VersionUtility.b("琸町琼氾рൂൄᝆᭈɊቌ὎ᩐᙒ౔", a_);
								global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
								string format = global::CommonUtility.VersionUtility.b("䈸଺ܼ朾㱀", a_);
								int num5;
								long? value = dictionary[num5].Value;
								global::CommonUtility.PCRKeyUtility.a(a_2, a_3, string.Format(invariantCulture, format, value.Value));
								num = (short)1596981254;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								long? value;
								if (value != null)
								{
									num = (short)1741750273;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
								global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("琸町琼氾рൂൄᝆᭈɊቌ὎ᩐᙒ౔", a_), global::CommonUtility.VersionUtility.b("缸紺笼社݀Ղ̈́ņ཈ൊ", a_));
								num = (short)1082327043;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1671430155;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
								int num5;
								global::CommonUtility.PCRKeyUtility.a(dbnode, global::CommonUtility.VersionUtility.b("琸町琼氾рൂൄᝆᭈɊቌ὎ᩐᙒ౔ᙖᕘቚᱜ౞", a_), dictionary[num5].Alias);
								long? value = dictionary[num5].Value;
								num = (short)593690626;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								int num5;
								if (num5 != 0)
								{
									num = (short)1371865098;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_133;
								}
								continue;
							case 9:
							{
								int num5;
								if (dictionary.ContainsKey(num5))
								{
									num = (short)1214840837;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)1222377481;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_344;
							}
							IL_173:
							num = (short)1031798784;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_133:
							goto IL_173;
						}
						IL_344:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0002411C File Offset: 0x0002231C
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 7;
			short num = (short)1704170362;
			short num2 = num;
			num = (short)1262523258;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C3;
			case 1:
				break;
			default:
			{
				num = (short)638255104;
				short num3 = num;
				break;
			}
			}
			num = (short)679739393;
			if (num != 0)
			{
			}
			num = (short)138543104;
			if (num != 0)
			{
			}
			num = (short)1572405248;
			switch (num)
			{
			default:
			{
				IL_C3:
				global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>.Enumerator enumerator = A_0.SymmetricKeys.GetEnumerator())
				{
					num = (short)641073153;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_371;
							}
							continue;
						case 2:
							num = (short)1471086596;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1510211586;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey = enumerator.Current;
							dictionary[matrixSymmetricKey.Id] = matrixSymmetricKey;
							num = (short)629473280;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_3EE;
						}
						IL_3A0:
						num = (short)1676345347;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_371:
						goto IL_3A0;
					}
					IL_3EE:
					goto IL_325;
				}
				return;
				for (;;)
				{
					IL_325:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
					{
						num = (short)734527496;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)306446340;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator2.Current;
								int num5 = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("男琹画洽ጿᭁृ᥅ᡇŉोᝍ᥏ᙑ", a_));
								num = (short)625213447;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								int num5;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("男琹画洽ጿᭁृ᥅ᡇŉोᝍ", a_), dictionary[num5].Value);
								num = (short)826277894;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								int num5;
								if (!string.IsNullOrEmpty(dictionary[num5].Value))
								{
									num = (short)1873936385;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("男琹画洽ጿᭁृ᥅ᡇŉोᝍ", a_), global::CommonUtility.VersionUtility.b("縷簹稻砽ؿсɃE็౉ੋࡍᙏᑑቓၕṗ᱙ᩛᡝ♟②≣⁥⹧Ⱪ⩫⡭㙯㑱㉳ふ㹷㱹㩻㡽왿쒁슃삅캇첉쪋좍횏풑튓킕\ude97\udc99\uda9b\ud89d", a_));
								num = (short)1847721987;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1439301643;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								int num5;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("男琹画洽ጿᭁृ᥅ᡇŉोᝍᅏṑᵓ᝕ୗ", a_), dictionary[num5].Alias);
								num = (short)1638268930;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								int num5;
								if (num5 != 0)
								{
									num = (short)1847132170;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_131;
								}
								continue;
							case 9:
							{
								int num5;
								if (dictionary.ContainsKey(num5))
								{
									num = (short)1794441221;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)859045897;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_312;
							}
							IL_16D:
							num = (short)1160249344;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_131:
							goto IL_16D;
						}
						IL_312:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00024560 File Offset: 0x00022760
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::Motorola.CommonCPS.Server.EntityModel.DBNode A_1)
		{
			int a_ = 6;
			short num = (short)448272119;
			short num2 = num;
			num = (short)2121209591;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C3;
			case 1:
				break;
			default:
			{
				num = (short)730464256;
				short num3 = num;
				break;
			}
			}
			num = (short)1587740673;
			if (num != 0)
			{
			}
			num = (short)248446976;
			if (num != 0)
			{
			}
			num = (short)1895563264;
			switch (num)
			{
			default:
			{
				IL_C3:
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>.Enumerator enumerator = A_0.PreSharedKeys.GetEnumerator())
				{
					num = (short)247398401;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_34B;
							}
							continue;
						case 2:
							num = (short)1587019780;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)135397378;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey matrixPreSharedKey = enumerator.Current;
							dictionary[matrixPreSharedKey.Alias] = matrixPreSharedKey;
							num = (short)875954176;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_3C9;
						}
						IL_379:
						num = (short)623640579;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_34B:
						goto IL_379;
					}
					IL_3C9:
					goto IL_2FF;
				}
				return;
				for (;;)
				{
					IL_2FF:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator2 = A_1.ChildNodesList.GetEnumerator())
					{
						num = (short)1128595464;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)911343620;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator2.Current;
								string text = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("猶琸椺฼漾ቀࡂńنᵈ੊ቌ὎ɐᡒ᱔ፖ", a_));
								num = (short)1716715527;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								string text;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("猶琸椺฼漾ቀࡂńنᵈ੊ቌ὎ɐᡒᅔᙖ൘ᩚ", a_), dictionary[text].Value);
								num = (short)1370685446;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								string text;
								if (!string.IsNullOrEmpty(dictionary[text].Value))
								{
									num = (short)1651048449;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("猶琸椺฼漾ቀࡂńنᵈ੊ቌ὎ɐᡒᅔᙖ൘ᩚ", a_), string.Empty);
								num = (short)2131165187;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)2137653259;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)1680474114;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								string text;
								if (!string.IsNullOrEmpty(text))
								{
									num = (short)1299447818;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_131;
								}
								continue;
							case 9:
							{
								string text;
								if (dictionary.ContainsKey(text))
								{
									num = (short)2088763397;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)2111635465;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_2EC;
							}
							IL_166:
							num = (short)1830486016;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_131:
							goto IL_166;
						}
						IL_2EC:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00024980 File Offset: 0x00022B80
		public static void Update(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData source, global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention target)
		{
			int a_ = 12;
			short num = (short)1247412224;
			switch (num)
			{
			default:
			{
				num = (short)2145189889;
				if (num != 0)
				{
				}
				num = (short)1183055875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_682;
					case 1:
						if (target.SyncRecords != null)
						{
							num = (short)219807749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)171507719;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator = keyValuePair.Value.BLLSyncData[global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes.KeyDatas].GetEnumerator();
									num = (short)976355333;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value.BLLSyncData.ContainsKey(global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes.KeyDatas))
									{
										num = (short)1661861888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)634322947;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair = enumerator2.Current;
									num = (short)571539462;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)523436042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1070792705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									try
									{
										num = (short)668925961;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 1:
												num = (short)2050621448;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀼帾㕀ㅂⱄ㽆ᩈ㉊⁌≎㑐❒❔㹖㩘ၚ㡜♞በ", a_)))
												{
													num = (short)1747124225;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.a(source, a_2);
												num = (short)827916310;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1267007508;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem = enumerator.Current;
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2 = syncData_FieldItem.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>;
												string fieldID = syncData_FieldItem.FieldID;
												num = (short)1940193297;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀼帾㕀ㅂⱄ㽆᥈㥊⑌㥎ぐげⱔ᱖㱘≚⹜", a_)))
												{
													num = (short)1540554768;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.d(source, a_2);
												num = (short)1764884480;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀼帾㕀ㅂⱄ㽆᥈㥊⡌ᱎ㥐㉒❔㉖㵘ၚ㡜♞", a_)))
												{
													num = (short)766443541;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.b(source, a_2);
												num = (short)825491462;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												switch (0)
												{
												case 0:
													goto IL_18A;
												}
												continue;
											case 10:
												num = (short)1820459011;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 11:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("礼爾ፀ灂ࡄ♆㵈㥊⑌㝎Ő⅒ごіㅘ㩚⽜㩞ՠ⡢dṦ", a_)))
												{
													num = (short)260112394;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.b(source, a_2);
												num = (short)332005389;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 12:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀼帾㕀ㅂⱄ㽆ᭈ੊Ṍю㑐⩒♔", a_)))
												{
													num = (short)823066638;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.c(source, a_2);
												num = (short)1803419652;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 14:
												num = (short)2047737858;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 16:
												num = (short)1490550796;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 17:
											{
												string fieldID;
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀼帾㕀ㅂⱄ㽆وὊౌ὎ᩐ㙒ⱔ", a_)))
												{
													num = (short)1603403795;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> a_2;
												global::CommonUtility.PCRKeyUtility.e(source, a_2);
												num = (short)1564344335;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 18:
												goto IL_4CB;
											case 19:
												num = (short)151584775;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 20:
												num = (short)1713111058;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 21:
												num = (short)549322763;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_42D:
											num = (short)1736900613;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_18A:
											goto IL_42D;
										}
										IL_4CB:;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									break;
								case 6:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value != null)
									{
										num = (short)1418133513;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_102;
									}
									continue;
								case 8:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value.BLLSyncData != null)
									{
										num = (short)361103364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)1855586312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_645;
								}
								IL_4DB:
								num = (short)1806827522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_102:
								goto IL_4DB;
							}
							IL_645:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_658;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 4:
						if (target.SyncRecords.Count > 0)
						{
							num = (short)1330053120;
							short num3 = num;
							num = (short)1835925510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
					{
						num = (short)1354022377;
						short num4 = num;
						num = (short)189185513;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_682;
						default:
							num = (short)850460672;
							if (num != 0)
							{
							}
							num = (short)2137915396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_658;
					}
					IL_8F:
					if (target != null)
					{
						num = (short)1105330176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_658:
					enumerator2 = target.SyncRecords.GetEnumerator();
					num = (short)877985794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_682:
					num = (short)756416513;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00025144 File Offset: 0x00023344
		private static int b(global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem A_0)
		{
			short num = (short)1773010944;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1405846125;
					short num3 = num;
					num = (short)2097381997;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1272119296;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					break;
				}
				case 1:
					if (syncData_FieldItem != null)
					{
						num = (short)1017839618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return 0;
				case 2:
					goto IL_FF;
				}
				IL_7E:
				num = (short)1272446977;
				if (num != 0)
				{
				}
				syncData_FieldItem = (A_0.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>).FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.a));
				num = (short)1272905729;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FF:
			num = (short)2080833536;
			short num4 = num;
			return global::System.Convert.ToInt32(syncData_FieldItem.FieldValue, global::System.Globalization.NumberFormatInfo.InvariantInfo);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00025298 File Offset: 0x00023498
		private static string a(global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem A_0)
		{
			short num = (short)2041511936;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1784338779;
					short num3 = num;
					num = (short)484235611;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)701956096;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					break;
				}
				case 1:
					if (syncData_FieldItem != null)
					{
						num = (short)114032642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 2:
					goto IL_D0;
				}
				IL_7C:
				syncData_FieldItem = (A_0.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>).FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.b));
				num = (short)1687879681;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			return (string)syncData_FieldItem.FieldValue;
			IL_EB:
			num = (short)2069037056;
			short num4 = num;
			num = (short)765067265;
			if (num != 0)
			{
			}
			return string.Empty;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000253E8 File Offset: 0x000235E8
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem A_0, string A_1)
		{
			short num = (short)1391132673;
			if (num != 0)
			{
			}
			num = (short)1896153088;
			short num2 = num;
			num = (short)1227808093;
			short num3 = num;
			num = (short)322428253;
			switch (num3 == num)
			{
			}
			num = (short)1040449536;
			if (num != 0)
			{
			}
			(A_0.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>).FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.c)).FieldValue = A_1;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000254C8 File Offset: 0x000236C8
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem A_0, string A_1)
		{
			short num = (short)1237791643;
			short num2 = num;
			num = (short)340891;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2033778688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2140536832;
			if (num != 0)
			{
			}
			num = (short)1492189185;
			if (num != 0)
			{
			}
			(A_0.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>).FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.d)).FieldValue = A_1;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000255AC File Offset: 0x000237AC
		private static void e(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> A_1)
		{
			int a_ = 10;
			short num = (short)945235649;
			short num2 = num;
			num = (short)899163841;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C5;
			case 1:
				break;
			default:
			{
				num = (short)1861287936;
				short num3 = num;
				break;
			}
			}
			num = (short)899874816;
			if (num != 0)
			{
			}
			num = (short)951582721;
			if (num != 0)
			{
			}
			num = (short)1298399232;
			switch (num)
			{
			default:
			{
				IL_C5:
				global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey>.Enumerator enumerator = A_0.OTAPKeys.GetEnumerator())
				{
					num = (short)2138046465;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_361;
							}
							continue;
						case 2:
							num = (short)68354052;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1801060354;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey = enumerator.Current;
							dictionary[matrixOTAPKey.Id] = matrixOTAPKey;
							num = (short)1123680256;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_3E0;
						}
						IL_390:
						num = (short)2144993283;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_361:
						goto IL_390;
					}
					IL_3E0:
					goto IL_31A;
				}
				return;
				for (;;)
				{
					IL_31A:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = A_1.GetEnumerator())
					{
						num = (short)1081737224;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1741225988;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem = enumerator2.Current;
								int num5 = global::CommonUtility.PCRKeyUtility.b(syncData_FieldItem);
								num = (short)1559363591;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2 = syncData_FieldItem;
								global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
								string format = global::CommonUtility.VersionUtility.b("䀺഼Ծ᥀㹂", a_);
								int num5;
								long? value = dictionary[num5].Value;
								global::CommonUtility.PCRKeyUtility.a(a_2, string.Format(invariantCulture, format, value.Value));
								num = (short)1102839814;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								long? value;
								if (value != null)
								{
									num = (short)1657995265;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
								global::CommonUtility.PCRKeyUtility.a(syncData_FieldItem, global::CommonUtility.VersionUtility.b("紺笼社݀Ղ̈́ņ཈ൊୌ", a_));
								num = (short)584777731;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1492975627;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
								int num5;
								global::CommonUtility.PCRKeyUtility.b(syncData_FieldItem, dictionary[num5].Alias);
								long? value = dictionary[num5].Value;
								num = (short)1813446658;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								int num5;
								if (num5 != 0)
								{
									num = (short)1872101386;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_132;
								}
								continue;
							case 9:
							{
								int num5;
								if (dictionary.ContainsKey(num5))
								{
									num = (short)1044381701;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)1924136969;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								goto IL_307;
							}
							IL_163:
							num = (short)615186432;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_132:
							goto IL_163;
						}
						IL_307:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000259E0 File Offset: 0x00023BE0
		private static void d(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> A_1)
		{
			int a_ = 17;
			short num = (short)579545964;
			short num2 = num;
			num = (short)119090028;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1000603649;
				if (num != 0)
				{
				}
				num = (short)1209401344;
				if (num != 0)
				{
				}
				num = (short)1000079360;
				short num3 = num;
				num = (short)690487296;
				switch (num)
				{
				}
				break;
			}
			}
			global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>();
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey>.Enumerator enumerator = A_0.PrivacyKeys.GetEnumerator())
			{
				num = (short)766902273;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						case 0:
							goto IL_35C;
						}
						continue;
					case 2:
						num = (short)1360986116;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)655622146;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey matrixPrivacyKey = enumerator.Current;
						dictionary[matrixPrivacyKey.Id] = matrixPrivacyKey;
						num = (short)1790181376;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_3D9;
					}
					IL_38B:
					num = (short)1528823811;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					goto IL_38B;
				}
				IL_3D9:
				goto IL_316;
			}
			return;
			for (;;)
			{
				IL_316:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = A_1.GetEnumerator())
				{
					num = (short)1884094472;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator2.MoveNext())
							{
								num = (short)1555103748;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem = enumerator2.Current;
							int num5 = global::CommonUtility.PCRKeyUtility.b(syncData_FieldItem);
							num = (short)1553661959;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
							global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2 = syncData_FieldItem;
							global::System.IFormatProvider invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
							string format = global::CommonUtility.VersionUtility.b("㥁瑃籅၇㝉", a_);
							int num5;
							long? value = dictionary[num5].Value;
							global::CommonUtility.PCRKeyUtility.a(a_2, string.Format(invariantCulture, format, value.Value));
							num = (short)682295302;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							long? value;
							if (value != null)
							{
								num = (short)629211137;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
							global::CommonUtility.PCRKeyUtility.a(syncData_FieldItem, global::CommonUtility.VersionUtility.b("сɃE็౉ੋࡍᙏᑑቓ", a_));
							num = (short)580255747;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)373424139;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
							int num5;
							global::CommonUtility.PCRKeyUtility.b(syncData_FieldItem, dictionary[num5].Alias);
							long? value = dictionary[num5].Value;
							num = (short)1389756418;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							int num5;
							if (num5 != 0)
							{
								num = (short)1171128330;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_12F;
							}
							continue;
						case 9:
						{
							int num5;
							if (dictionary.ContainsKey(num5))
							{
								num = (short)568459269;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							num = (short)1354629129;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_303;
						}
						IL_161:
						num = (short)783220736;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_12F:
						goto IL_161;
					}
					IL_303:
					break;
				}
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00025E10 File Offset: 0x00024010
		private static void c(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> A_1)
		{
			short num = (short)224854016;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey>.Enumerator enumerator = A_0.RASKeys.GetEnumerator())
				{
					num = (short)1812987908;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_27F:
						switch (num2)
						{
						case 0:
							goto IL_38F;
						case 1:
							num = (short)881131520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							while (!enumerator.MoveNext())
							{
								num = (short)393792767;
								short num3 = num;
								num = (short)1022545151;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1898446848;
									if (num != 0)
									{
									}
									num = (short)263454721;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_27F;
								}
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey = enumerator.Current;
							dictionary[matrixRASKey.Alias] = matrixRASKey;
							num = (short)1765343234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_29A;
							}
							continue;
						}
						IL_2C8:
						num = (short)1902116865;
						if (num != 0)
						{
						}
						num = (short)467009539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_29A:
						goto IL_2C8;
					}
					IL_38F:
					goto IL_22B;
				}
				return;
				for (;;)
				{
					IL_22B:
					num = (short)1641349120;
					short num4 = num;
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = A_1.GetEnumerator())
					{
						num = (short)1895497733;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_218;
							case 2:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_;
								string text;
								global::CommonUtility.PCRKeyUtility.a(a_, dictionary[text].Value);
								num = (short)783548416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)1069023240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1959723014;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_8B;
								}
								continue;
							case 6:
							{
								string text;
								if (dictionary.ContainsKey(text))
								{
									num = (short)1699020803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								string text;
								if (!string.IsNullOrEmpty(dictionary[text].Value))
								{
									num = (short)1817182210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_;
								global::CommonUtility.PCRKeyUtility.a(a_, string.Empty);
								num = (short)521994247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								num = (short)765132801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								string text;
								if (!string.IsNullOrEmpty(text))
								{
									num = (short)933167108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 11:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)168296457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_ = enumerator2.Current;
								string text = global::CommonUtility.PCRKeyUtility.a(a_);
								num = (short)571146250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_B1:
							num = (short)1113194507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8B:
							goto IL_B1;
						}
						IL_218:
						break;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000261F4 File Offset: 0x000243F4
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> A_1)
		{
			short num = (short)1727987712;
			switch (num)
			{
			default:
			{
				num = (short)534446081;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey>.Enumerator enumerator = A_0.PreSharedKeys.GetEnumerator())
				{
					num = (short)1994326020;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_27C:
						switch (num2)
						{
						case 0:
							goto IL_361;
						case 1:
							num = (short)590938112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							while (!enumerator.MoveNext())
							{
								num = (short)359869295;
								short num3 = num;
								num = (short)192097135;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1665662976;
									if (num != 0)
									{
									}
									num = (short)1781071873;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_27C;
								}
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey matrixPreSharedKey = enumerator.Current;
							dictionary[matrixPreSharedKey.Alias] = matrixPreSharedKey;
							num = (short)467402754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_297;
							}
							continue;
						}
						IL_2C5:
						num = (short)312147971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_297:
						goto IL_2C5;
					}
					IL_361:
					goto IL_251;
				}
				goto IL_374;
				for (;;)
				{
					IL_251:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = A_1.GetEnumerator())
					{
						num = (short)1980432389;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_23E;
							case 2:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_;
								string text;
								global::CommonUtility.PCRKeyUtility.a(a_, dictionary[text].Value);
								num = (short)1201864704;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)2039349256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)104136710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_B2;
								}
								continue;
							case 6:
							{
								string text;
								if (dictionary.ContainsKey(text))
								{
									num = (short)2035351555;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								string text;
								if (!string.IsNullOrEmpty(dictionary[text].Value))
								{
									num = (short)1118175234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_;
								global::CommonUtility.PCRKeyUtility.a(a_, string.Empty);
								num = (short)2014642183;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								num = (short)924581889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								string text;
								if (!string.IsNullOrEmpty(text))
								{
									num = (short)95944708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 11:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)962920457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_ = enumerator2.Current;
								string text = global::CommonUtility.PCRKeyUtility.a(a_);
								num = (short)885325834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_D7:
							num = (short)2070675467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B2:
							goto IL_D7;
						}
						IL_23E:
						break;
					}
				}
				IL_374:
				num = (short)480051200;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x000265D4 File Offset: 0x000247D4
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> A_1)
		{
			int a_ = 9;
			short num = (short)1989541888;
			switch (num)
			{
			default:
			{
				num = (short)1539571713;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> dictionary = new global::System.Collections.Generic.Dictionary<int, global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey>.Enumerator enumerator = A_0.SymmetricKeys.GetEnumerator())
				{
					num = (short)726466564;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_29A:
						switch (num2)
						{
						case 0:
							goto IL_380;
						case 1:
							num = (short)266797056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							while (!enumerator.MoveNext())
							{
								num = (short)1498406811;
								short num3 = num;
								num = (short)882106267;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)186187776;
									if (num != 0)
									{
									}
									num = (short)1863974913;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_29A;
								}
							}
							global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey = enumerator.Current;
							dictionary[matrixSymmetricKey.Id] = matrixSymmetricKey;
							num = (short)653328386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_2B5;
							}
							continue;
						}
						IL_2E5:
						num = (short)1815740419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B5:
						goto IL_2E5;
					}
					IL_380:
					goto IL_26F;
				}
				goto IL_393;
				for (;;)
				{
					IL_26F:
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = A_1.GetEnumerator())
					{
						num = (short)500695045;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_25C;
							case 2:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2;
								int num4;
								global::CommonUtility.PCRKeyUtility.a(a_2, dictionary[num4].Value);
								num = (short)708444160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2;
								int num4;
								global::CommonUtility.PCRKeyUtility.b(a_2, dictionary[num4].Alias);
								num = (short)1321664520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)2014642182;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 6:
							{
								int num4;
								if (dictionary.ContainsKey(num4))
								{
									num = (short)673382403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								int num4;
								if (!string.IsNullOrEmpty(dictionary[num4].Value))
								{
									num = (short)1932394498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2;
								global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("簹稻砽ؿсɃE็౉ੋࡍᙏᑑቓၕṗ᱙ᩛᡝ♟②≣⁥⹧Ⱪ⩫⡭㙯㑱㉳ふ㹷㱹㩻㡽왿쒁슃삅캇첉쪋좍횏풑튓킕\ude97\udc99\uda9b\ud89dﺷ", a_));
								num = (short)2079588359;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								num = (short)833486849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								int num4;
								if (num4 != 0)
								{
									num = (short)855703556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 11:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)2109734921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem a_2 = enumerator2.Current;
								int num4 = global::CommonUtility.PCRKeyUtility.b(a_2);
								num = (short)1567358986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_E9:
							num = (short)713162763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							goto IL_E9;
						}
						IL_25C:
						break;
					}
				}
				IL_393:
				num = (short)2040004608;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x000269D4 File Offset: 0x00024BD4
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData LoadData(global::Motorola.CommonCPS.Server.EntityModel.Configuration configuration)
		{
			int a_ = 17;
			short num = (short)2081488896;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData pcrkeyData;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.e));
						num = (short)1817051156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1510014977;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						if (dbnode2.ChildNodesList.Count > 0)
						{
							num = (short)671744007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrkeyData;
					}
					case 2:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode.ChildNodesList.Count > 0)
						{
							num = (short)1217331204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88C;
					}
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2 = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.f));
						num = (short)1397030923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						enumerator = dbnode.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)527106060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						if (dbnode3.ChildNodesList.Count > 0)
						{
							num = (short)76087306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AE;
					}
					case 6:
						num = (short)1155465233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						enumerator = dbnode2.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)2048851977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3 = configuration.DBNode.ChildNodesList[0].ChildNodesList.FirstOrDefault(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.DBNode, bool>(global::CommonUtility.PCRKeyUtility.<>c.<>9.d));
						num = (short)1567358990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_9B8;
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						enumerator = dbnode3.ChildNodesList[0].ChildNodesList.GetEnumerator();
						num = (short)1937637394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						if (dbnode2 != null)
						{
							num = (short)2068185104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrkeyData;
					}
					case 12:
						try
						{
							num = (short)470745094;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1452343306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1519517704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_87C;
								case 5:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ཁ੃ཅᭇཉ≋♍ㅏ㱑㝓㍕㱗ਖ਼⹛㝝ᙟ͡ݣὥ⍧ཀྵᕫᵭ", a_)))
									{
										num = (short)567083008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4;
									global::CommonUtility.PCRKeyUtility.a(dbnode4, pcrkeyData.PrivacyKeys);
									num = (short)1340735492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_706;
									}
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)247988233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4 = enumerator.Current;
									string name = dbnode4.Name;
									num = (short)903086085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1189740547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ཁ੃ཅᭇ᥉㕋⍍㵏㝑⁓⑕ㅗ㥙᝛㭝ᥟᅡ", a_)))
									{
										num = (short)343343106;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode4;
									global::CommonUtility.PCRKeyUtility.a(dbnode4, pcrkeyData.SymmetricKeys);
									num = (short)771883009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_76B:
								num = (short)1154940935;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_706:
								goto IL_76B;
							}
							IL_87C:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_88C;
					case 13:
						num = (short)1920794626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode3;
						if (dbnode3 != null)
						{
							num = (short)1749745683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5AE;
					}
					case 15:
						if (configuration != null)
						{
							num = (short)2075918342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrkeyData;
					case 16:
						num = (short)997457921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (configuration.DBNode != null)
						{
							num = (short)40108053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return pcrkeyData;
					case 18:
						try
						{
							num = (short)1660682253;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ቁ㙃⍅ᭇ≉ⵋ㱍㕏㙑ὓ㍕⅗⥙", a_)))
									{
										num = (short)416219148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.b(dbnode5, pcrkeyData.PreSharedKeys);
									num = (short)1591279624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2117664768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)203948050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5 = enumerator.Current;
									string name = dbnode5.Name;
									num = (short)2125004805;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("ു၃݅ᡇ୉㥋㩍㡏㝑㩓≕ㅗ㥙㵛⩝य़ൡ੣ⵥ൧፩", a_)))
									{
										num = (short)882901006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.a(dbnode5, pcrkeyData.OTAPKeys);
									num = (short)1090977808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1324089353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_59E;
								case 9:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("၁Ճᕅ͇⽉㕋㵍", a_)))
									{
										num = (short)1763639311;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.a(dbnode5, pcrkeyData.RASKeys);
									num = (short)1821900804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("́Ńᕅ͇⽉㕋㵍", a_)))
									{
										num = (short)853606402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.b(dbnode5, pcrkeyData.SymmetricKeys);
									num = (short)125763603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)643563521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_2B3;
									}
									continue;
								case 14:
									num = (short)730791953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									num = (short)34799626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									string name;
									if (!(name == global::CommonUtility.VersionUtility.b("݁⩃⹅⥇⑉⽋⭍㑏ɑ♓㽕⹗㭙㽛❝⭟ݡᵣᕥ", a_)))
									{
										num = (short)188416006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode5;
									global::CommonUtility.PCRKeyUtility.b(dbnode5, pcrkeyData.PrivacyKeys);
									num = (short)1614479371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
									num = (short)1796603911;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3F9:
								num = (short)567607299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2B3:
								goto IL_3F9;
							}
							IL_59E:;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_5AE;
					case 19:
						num = (short)1479409669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode != null)
						{
							num = (short)828112909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88C;
					}
					case 21:
						num = (short)1120927752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_5AE:
					num = (short)677576704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_88C:
					num = (short)2107375619;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9B8:
				try
				{
					num = (short)1280835584;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_9FD;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)115343362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6 = enumerator.Current;
							num = (short)1524760580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1662713859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_B23;
						case 4:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6;
							if (dbnode6.Name == global::CommonUtility.VersionUtility.b("فृᑅ筇ᩉ㹋⭍͏㩑㕓⑕㵗㹙᝛㭝ᥟᅡ", a_))
							{
								num = (short)1356988422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							num = (short)514391581;
							short num3 = num;
							num = (short)2017394205;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2095382528;
								if (num != 0)
								{
								}
								break;
							}
							break;
						}
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode6;
							global::CommonUtility.PCRKeyUtility.a(dbnode6, pcrkeyData.PreSharedKeys);
							num = (short)1624375301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_ACE:
						num = (short)294518785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_9FD:
						goto IL_ACE;
					}
					IL_B23:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return pcrkeyData;
				IL_8F:
				pcrkeyData = new global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData();
				num = (short)949878784;
				short num4 = num;
				num = (short)778960911;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00027564 File Offset: 0x00025764
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey> A_1)
		{
			int a_ = 6;
			short num;
			for (;;)
			{
				num = (short)2044198912;
				short num2 = num;
				num = (short)1772421120;
				switch (num)
				{
				default:
				{
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
					{
						num = (short)768606208;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_97;
								}
								continue;
							case 1:
								goto IL_157;
							case 2:
								num = (short)648347649;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)792788994;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
								int id = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("砶稸携爼款@ፂфቆᵈٌ͊੎ࡐᩒᅔ", a_));
								string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("砶稸携爼款@ፂلፆшJᑌ๎ᵐR", a_));
								string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("砶稸携爼款@ፂلፆшJࡌᙎ", a_));
								global::CommonUtility.PCRKeyUtility.MergeMatrixOTAPKey(A_1, id, alias, value);
								num = (short)693043203;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_FE:
							num = (short)1058406404;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_97:
							goto IL_FE;
						}
						IL_157:;
					}
					num = (short)231196041;
					short num4 = num;
					num = (short)2016789897;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_19F;
					}
					break;
				}
				}
			}
			IL_19F:
			num = (short)710672385;
			if (num != 0)
			{
			}
			num = (short)1371078656;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00027760 File Offset: 0x00025960
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> A_1)
		{
			int a_ = 12;
			short num;
			for (;;)
			{
				num = (short)671940608;
				short num2 = num;
				num = (short)1532559360;
				switch (num)
				{
				default:
				{
					using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
					{
						num = (short)1327104000;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_98;
								}
								continue;
							case 1:
								goto IL_157;
							case 2:
								num = (short)631767041;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)772014082;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
								int id = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("砼焾ीፂᝄๆᙈᭊٌ੎ࡐᩒᅔ", a_));
								string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("砼焾ीፂᝄๆᙈᭊٌ੎ࡐቒᥔṖᡘ࡚", a_));
								string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("砼焾ीፂᝄๆᙈᭊٌ੎ࡐ", a_));
								global::CommonUtility.PCRKeyUtility.MergeMatrixPrivacyKey(A_1, id, alias, value);
								num = (short)293797891;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_FF:
							num = (short)407961604;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_98:
							goto IL_FF;
						}
						IL_157:;
					}
					num = (short)217186305;
					if (num != 0)
					{
					}
					num = (short)1494770341;
					short num4 = num;
					num = (short)1191338661;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_1C1;
					}
					break;
				}
				}
			}
			IL_1C1:
			num = (short)1589051392;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00027954 File Offset: 0x00025B54
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> A_1)
		{
			int a_ = 16;
			short num = (short)718395009;
			short num2 = num;
			num = (short)1534056065;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)985137153;
				if (num != 0)
				{
				}
				num = (short)887029760;
				if (num != 0)
				{
				}
				num = (short)615710720;
				short num3 = num;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
				{
					num = (short)15335424;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						case 1:
							goto IL_188;
						case 2:
							num = (short)972357633;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1741357058;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
							string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("ፀɂᙄ͆ࡈὊౌ၎͐ቒٔᙖᕘቚᱜ౞", a_));
							string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("ፀɂᙄ͆ࡈὊౌ၎͐ቒٔ᱖᱘ɚ", a_));
							global::CommonUtility.PCRKeyUtility.MergeMatrixRASKey(A_1, alias, value);
							num = (short)502595587;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_139:
						num = (short)288882692;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E8:
						goto IL_139;
					}
					IL_188:;
				}
				break;
			}
			}
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00027B0C File Offset: 0x00025D0C
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> A_1)
		{
			int a_ = 6;
			short num = (short)1152253952;
			short num2 = num;
			num = (short)1928069121;
			if (num != 0)
			{
			}
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
			{
				num = (short)1976369154;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1505136813;
					short num4 = num;
					num = (short)1071812781;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_191;
					default:
						num = (short)1653407744;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_191;
						case 1:
							num = (short)1343946752;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_EC;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1636827137;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
							string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("朶樸瀺礼績ᕀɂᩄᝆᩈJь୎", a_));
							string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("朶樸瀺礼績ᕀɂᩄᝆᩈJौ๎Րቒ", a_));
							global::CommonUtility.PCRKeyUtility.MergeMatrixPreSharedKey(A_1, alias, value);
							num = (short)1310720004;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_13F:
						num = (short)1263730691;
						num3 = (int)((global::System.IntPtr)num);
						break;
						IL_EC:
						goto IL_13F;
					}
				}
				IL_191:;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00027CD8 File Offset: 0x00025ED8
		private static void b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> A_1)
		{
			int a_ = 0;
			short num = (short)183238656;
			switch (num)
			{
			default:
			{
				num = (short)1276772353;
				if (num != 0)
				{
				}
				num = (short)1373372416;
				short num2 = num;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
				{
					num = (short)859176962;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1086836747;
						short num4 = num;
						num = (short)1177604107;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CD;
						default:
							num = (short)534970368;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_1CD;
							case 1:
								num = (short)1048444928;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_109;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2131623937;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
								int id = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("瀰瘲昴朶欸爺戼漾ੀق᱄ๆൈ", a_));
								string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("瀰瘲昴朶欸爺戼漾ੀق᱄نՈɊౌᱎ", a_));
								string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("瀰瘲昴朶欸爺戼漾ੀق᱄", a_));
								global::CommonUtility.PCRKeyUtility.MergeMatrixSymmetricKey(A_1, id, alias, value);
								num = (short)1301807108;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_174:
							num = (short)1176895491;
							num3 = (int)((global::System.IntPtr)num);
							break;
							IL_109:
							goto IL_174;
						}
					}
					IL_1CD:;
				}
				return;
			}
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00027EE0 File Offset: 0x000260E0
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> A_1)
		{
			int a_ = 4;
			short num = (short)892272640;
			short num2 = num;
			num = (short)616235008;
			switch (num)
			{
			default:
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
				{
					num = (short)1943470082;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1861510961;
						short num4 = num;
						num = (short)1055418161;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CA;
						default:
							num = (short)469172225;
							if (num != 0)
							{
							}
							num = (short)1635385344;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_1CA;
							case 1:
								num = (short)835256320;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_10A;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1969618945;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
								int id = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("破礶瀸栺砼焾ीፂᝄๆᙈᭊٌ੎ࡐᩒᅔ", a_));
								string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("破礶瀸栺砼焾ीፂᝄๆᙈᭊٌ੎ࡐቒᥔṖᡘ࡚", a_));
								string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("破礶瀸栺砼焾ीፂᝄๆᙈᭊٌ੎ࡐ", a_));
								global::CommonUtility.PCRKeyUtility.MergeMatrixPrivacyKey(A_1, id, alias, value);
								num = (short)380436484;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_174:
							num = (short)225902595;
							num3 = (int)((global::System.IntPtr)num);
							break;
							IL_10A:
							goto IL_174;
						}
					}
					IL_1CA:;
				}
				return;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x000280E4 File Offset: 0x000262E4
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> A_1)
		{
			int a_ = 5;
			short num = (short)600113152;
			switch (num)
			{
			default:
			{
				num = (short)1222770689;
				if (num != 0)
				{
				}
				num = (short)1566638080;
				short num2 = num;
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
				{
					num = (short)1210712066;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1857010400;
						short num4 = num;
						num = (short)1193523936;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CF;
						default:
							num = (short)1876099072;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_1CF;
							case 1:
								num = (short)1368653824;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_10C;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1542127617;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
								int id = global::CommonUtility.PCRKeyUtility.b(a_2, global::CommonUtility.VersionUtility.b("笵瘷猹漻洽᤿ཁᭃᙅ͇ཉᕋݍᑏ", a_));
								string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("笵瘷猹漻洽᤿ཁᭃᙅ͇ཉᕋཌྷᱏ᭑ᕓՕ", a_));
								string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("笵瘷猹漻洽᤿ཁᭃᙅ͇ཉᕋ", a_));
								global::CommonUtility.PCRKeyUtility.MergeMatrixSymmetricKey(A_1, id, alias, value);
								num = (short)421724164;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_177:
							num = (short)1184235523;
							num3 = (int)((global::System.IntPtr)num);
							break;
							IL_10C:
							goto IL_177;
						}
					}
					IL_1CF:;
				}
				return;
			}
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000282EC File Offset: 0x000264EC
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0, global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> A_1)
		{
			int a_ = 5;
			short num = (short)230948864;
			short num2 = num;
			using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator = A_0.ChildNodesList.GetEnumerator())
			{
				num = (short)2099314690;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)786025291;
					short num4 = num;
					num = (short)575916875;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
						num = (short)1520369664;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_169;
						case 1:
							num = (short)1327366144;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_C6;
							}
							continue;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)596443137;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode a_2 = enumerator.Current;
							string alias = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("爵男根༻渽ጿुC݅᱇୉ፋṍ͏ᥑᵓቕ", a_));
							string value = global::CommonUtility.PCRKeyUtility.a(a_2, global::CommonUtility.VersionUtility.b("爵男根༻渽ጿुC݅᱇୉ፋṍ͏ᥑၓ᝕౗᭙", a_));
							global::CommonUtility.PCRKeyUtility.MergeMatrixPreSharedKey(A_1, alias, value);
							num = (short)241238020;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_119:
						num = (short)1812725763;
						num3 = (int)((global::System.IntPtr)num);
						break;
						IL_C6:
						goto IL_119;
					}
				}
				IL_169:;
			}
			num = (short)17825793;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x000284B8 File Offset: 0x000266B8
		public static global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData LoadData(global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationExtention cfgExt)
		{
			short num = (short)1838284800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData pcrkeyData;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord>.Enumerator enumerator2;
					switch (num2)
					{
					case 0:
						goto IL_313;
					case 1:
						num = (short)95485957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1879572480;
						short num3 = num;
						if (cfgExt.SyncRecords.Count > 0)
						{
							num = (short)1820786688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					}
					case 3:
						num = (short)1696595969;
						if (num != 0)
						{
						}
						num = (short)1420492802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (cfgExt != null)
						{
							num = (short)1961033729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 5:
						if (cfgExt.SyncRecords != null)
						{
							num = (short)546570243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 6:
						try
						{
							num = (short)615645192;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)339148802;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_18E;
											case 1:
												num = (short)2042167296;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_118;
												}
												continue;
											case 3:
											{
												global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)38928385;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::CommonUtility.PCRKeyUtility.a(enumerator.Current, pcrkeyData);
												num = (short)92536836;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_140:
											num = (short)50528259;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_118:
											goto IL_140;
										}
										IL_18E:;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator;
										((global::System.IDisposable)enumerator).Dispose();
									}
									break;
								case 1:
									num = (short)517603333;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)2086273028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value != null)
									{
										num = (short)388628489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_300;
								case 5:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value.BLLSyncData.ContainsKey(global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes.KeyDatas))
									{
										num = (short)1614872586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									if (keyValuePair.Value.BLLSyncData != null)
									{
										num = (short)1313865729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)421199874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair = enumerator2.Current;
									num = (short)1842348035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_D9;
									}
									continue;
								case 9:
									num = (short)342556678;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Collections.Generic.KeyValuePair<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord> keyValuePair;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator = keyValuePair.Value.BLLSyncData[global::Motorola.CommonCPS.Server.EntityModel.SyncDataTypes.KeyDatas].GetEnumerator();
									num = (short)558759936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_19E:
								num = (short)1974075399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D9:
								goto IL_19E;
							}
							IL_300:
							goto IL_414;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_313;
					}
					goto IL_4A;
					IL_313:
					enumerator2 = cfgExt.SyncRecords.GetEnumerator();
					num = (short)198770694;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_414:
				num = (short)1206415303;
				short num4 = num;
				num = (short)64647111;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_4A:
					pcrkeyData = new global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData();
					num = (short)1542586372;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
					num = (short)1262551040;
					if (num != 0)
					{
					}
					return pcrkeyData;
				}
				break;
			}
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0002895C File Offset: 0x00026B5C
		private static void a(global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem A_0, global::Motorola.CommonCPS.Server.EntityModel.PCRKeyData A_1)
		{
			int a_ = 0;
			short num = (short)705953792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1256849408;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> list;
				for (;;)
				{
					IL_58:
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						if (list != null)
						{
							num = (short)1435435010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						try
						{
							num = (short)1348337724;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int id;
								string alias;
								string value;
								switch (num2)
								{
								case 0:
								{
									uint num4;
									if (num4 != 283073731U)
									{
										num = (short)1145372710;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)297467950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1194852356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									uint num4;
									if (num4 <= 2246854501U)
									{
										num = (short)1239416862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1856831509;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)404684836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)2045182013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									uint num4;
									if (num4 != 3228908589U)
									{
										num = (short)779943950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1196228617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰刲䄴䔶倸䌺爼款@ፂไ≆え", a_)))
									{
										num = (short)400883728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::CommonUtility.PCRKeyUtility.MergeMatrixOTAPKey(A_1.OTAPKeys, id, alias, value);
									num = (short)1027014710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("田縲朴ж琸娺䤼䴾⡀㭂ᕄ㕆ⱈᡊ╌⹎⍐㙒ㅔ᱖㱘≚", a_)))
									{
										num = (short)811925538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B1A;
								}
								case 12:
								{
									uint num4;
									if (num4 != 2246854501U)
									{
										num = (short)1375666225;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)750977063;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									num = (short)1926955059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)289538076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1273495557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> list2 = enumerator.Current.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>;
									num = (short)396230689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									num = (short)1820721154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰紲簴搶琸娺䤼䴾⡀㭂ᙄ㹆⑈♊⡌㭎⍐㩒㙔᱖㱘≚⹜", a_)))
									{
										num = (short)1888026649;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								}
								case 20:
									num = (short)1686634514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									uint num4;
									if (num4 <= 3754554170U)
									{
										num = (short)977076274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1260978229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									num = (short)1336147980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)1677721600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)1753350200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									num = (short)1452408875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 27:
									num = (short)607715375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									uint num4;
									if (num4 != 3754554170U)
									{
										num = (short)1754923021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1443233809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									num = (short)906559536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> list2;
									if (list2 != null)
									{
										num = (short)27590693;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 34:
									num = (short)783482932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰刲䄴䔶倸䌺漼績ቀࡂ⁄㹆㩈", a_)))
									{
										num = (short)502071351;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::CommonUtility.PCRKeyUtility.MergeMatrixRASKey(A_1.RASKeys, alias, value);
									num = (short)1734213640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 36:
									goto IL_D5C;
								case 37:
								{
									id = 0;
									alias = null;
									value = null;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem> list2;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2 = list2.GetEnumerator();
									num = (short)277282858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 38:
									num = (short)2045837369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰紲簴搶琸娺䤼䴾⡀㭂ᕄ㕆⁈㵊ⱌⱎ⡐ᡒご⹖⩘", a_)))
									{
										num = (short)990576646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33A;
								}
								case 41:
									num = (short)2084044829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
								{
									string fieldID;
									try
									{
										num = (short)1050148871;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem syncData_FieldItem;
											switch (num2)
											{
											case 1:
												if (!(fieldID == global::CommonUtility.VersionUtility.b("朰刲头䈶尸", a_)))
												{
													num = (short)1229717509;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												value = (string)syncData_FieldItem.FieldValue;
												num = (short)1310982155;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												if (!(fieldID == global::CommonUtility.VersionUtility.b("瀰弲尴嘶䨸", a_)))
												{
													num = (short)467468291;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_8C9;
											case 3:
												num = (short)14090241;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												num = (short)2072444928;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												goto IL_B07;
											case 7:
												switch (0)
												{
												case 0:
													goto IL_8C7;
												}
												continue;
											case 8:
												if (!(fieldID == global::CommonUtility.VersionUtility.b("砰圲", a_)))
												{
													num = (short)37093386;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												id = global::System.Convert.ToInt32(syncData_FieldItem.FieldValue, global::System.Globalization.NumberFormatInfo.InvariantInfo);
												num = (short)302907405;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												num = (short)804216943;
												short num5 = num;
												num = (short)2130141295;
												switch ((num5 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_8C9;
												default:
												{
													num = (short)172752896;
													if (num != 0)
													{
													}
													global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2;
													if (!enumerator2.MoveNext())
													{
														num = (short)2077818892;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													syncData_FieldItem = enumerator2.Current;
													fieldID = syncData_FieldItem.FieldID;
													num = (short)465960968;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												}
												break;
											}
											case 10:
												num = (short)1659568130;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												num = (short)808386566;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_8C7;
											IL_8C9:
											alias = (string)syncData_FieldItem.FieldValue;
											num = (short)814415876;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_919:
											num = (short)1830682633;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_8C7:
											goto IL_919;
										}
										IL_B07:
										goto IL_BD1;
									}
									finally
									{
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>.Enumerator enumerator2;
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_B1A;
									IL_BD1:
									fieldID = A_0.FieldID;
									uint num4 = global::f.a(fieldID);
									num = (short)2070675459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 43:
								{
									uint num4;
									if (num4 != 4190176175U)
									{
										num = (short)616824859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1186594826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰刲䄴䔶倸䌺洼䴾⡀㕂⑄⑆えJ⡌㙎≐", a_)))
									{
										num = (short)1799618561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_33A;
								}
								case 46:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰刲䄴䔶倸䌺洼䴾⑀၂ⵄ♆㭈⹊⥌ю㑐⩒", a_)))
									{
										num = (short)1762459710;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::CommonUtility.PCRKeyUtility.MergeMatrixPreSharedKey(A_1.PreSharedKeys, alias, value);
									num = (short)354943008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 48:
								{
									uint num4;
									if (num4 <= 1381523258U)
									{
										num = (short)1361051671;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)859308091;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 49:
									num = (short)939261971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									num = (short)1855717383;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
								{
									uint num4;
									if (num4 != 4034816223U)
									{
										num = (short)694616090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1837170746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 55:
									num = (short)1390673964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
								{
									uint num4;
									if (num4 != 1381523258U)
									{
										num = (short)899285033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2100887587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 58:
								{
									string fieldID;
									if (!(fieldID == global::CommonUtility.VersionUtility.b("簰刲䄴䔶倸䌺渼䘾ⱀ⹂⁄㍆㭈≊⹌ю㑐⩒♔", a_)))
									{
										num = (short)159186964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27C;
								}
								case 59:
								{
									uint num4;
									if (num4 != 1823881544U)
									{
										num = (short)911343638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)413728813;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 60:
									switch (0)
									{
									case 0:
										goto IL_1F9;
									}
									continue;
								case 62:
									num = (short)1593573407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F9;
								IL_27C:
								global::CommonUtility.PCRKeyUtility.MergeMatrixSymmetricKey(A_1.SymmetricKeys, id, alias, value);
								num = (short)1285619752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33A:
								global::CommonUtility.PCRKeyUtility.MergeMatrixPrivacyKey(A_1.PrivacyKeys, id, alias, value);
								num = (short)533790744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_365:
								num = (short)33292303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F9:
								goto IL_365;
								IL_B1A:
								global::CommonUtility.PCRKeyUtility.MergeMatrixPreSharedKey(A_1.PreSharedKeys, alias, value);
								num = (short)881524747;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D5C:
							return;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_D6C;
					case 2:
						goto IL_D6C;
					}
					goto IL_6B;
					IL_D6C:
					enumerator = list.GetEnumerator();
					num = (short)721682433;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6B:
				num = (short)607518721;
				if (num != 0)
				{
				}
				list = (A_0.FieldValue as global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SyncData_FieldItem>);
				num = (short)2019295232;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00029730 File Offset: 0x00027930
		public static void MergeMatrixOTAPKey(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey> keys, int id, string alias, string value)
		{
			short num = (short)1119813638;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1E:
				global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey matrixOTAPKey;
				switch (num2)
				{
				case 0:
				{
					string text;
					while (!global::CommonUtility.PCRKeyUtility.IsOTAPAuthorizationKeyValueValid(text))
					{
						num = (short)2055236632;
						short num3 = num;
						num = (short)1706454040;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1106640897;
							if (num != 0)
							{
							}
							num = (short)150863872;
							if (num != 0)
							{
							}
							num = (short)1774845959;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					num = (short)1074724868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					matrixOTAPKey = new global::Motorola.CommonCPS.Server.EntityModel.MatrixOTAPKey
					{
						Id = id,
						Alias = alias
					};
					string text = value.Trim().ToUpperInvariant();
					num = (short)564133888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (global::CommonUtility.PCRKeyUtility.IsOtapAuthenticationKeyIDValid(new int?(matrixOTAPKey.Id)))
					{
						num = (short)608567301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					try
					{
						string text;
						matrixOTAPKey.Value = new long?(global::System.Convert.ToInt64(text, 16));
						goto IL_1E1;
					}
					catch
					{
						matrixOTAPKey.Value = null;
						goto IL_1E1;
					}
					goto IL_94;
				case 5:
				{
					num = (short)1167523840;
					short num4 = num;
					keys.Add(matrixOTAPKey);
					num = (short)1461977091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 7:
					goto IL_94;
				case 8:
					goto IL_1E1;
				}
				IL_48:
				if (keys != null)
				{
					num = (short)665845761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_94:
				matrixOTAPKey.Value = null;
				num = (short)1298137096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E1:
				num = (short)2076114946;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00029994 File Offset: 0x00027B94
		public static void MergeMatrixPrivacyKey(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey> keys, int id, string alias, string value)
		{
			short num = (short)99549190;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey matrixPrivacyKey;
				switch (num2)
				{
				case 0:
				{
					string text;
					while (!global::CommonUtility.PCRKeyUtility.IsPrivacyKeyValueValid(text))
					{
						num = (short)1846181070;
						short num3 = num;
						num = (short)1141406926;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1295384576;
							if (num != 0)
							{
							}
							num = (short)1308884999;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					num = (short)201654276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
				{
					matrixPrivacyKey = new global::Motorola.CommonCPS.Server.EntityModel.MatrixPrivacyKey
					{
						Id = id,
						Alias = alias
					};
					string text = value.Trim().ToUpperInvariant();
					num = (short)1800732672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (global::CommonUtility.PCRKeyUtility.IsPrivacyKeyIDValid(new int?(matrixPrivacyKey.Id)))
					{
						num = (short)192348165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 3:
					goto IL_109;
				case 4:
					try
					{
						string text;
						matrixPrivacyKey.Value = new long?(global::System.Convert.ToInt64(text, 16));
						goto IL_1B8;
					}
					catch
					{
						matrixPrivacyKey.Value = null;
						goto IL_1B8;
					}
					goto IL_96;
				case 5:
				{
					num = (short)491913216;
					short num4 = num;
					keys.Add(matrixPrivacyKey);
					num = (short)1706098691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
					goto IL_96;
				case 8:
					goto IL_1B8;
				}
				IL_49:
				if (keys != null)
				{
					num = (short)783810561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_96:
				matrixPrivacyKey.Value = null;
				num = (short)202833928;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B8:
				num = (short)319422466;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_109:
			IL_21C:
			num = (short)1479868417;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00029BF4 File Offset: 0x00027DF4
		public static void MergeMatrixRASKey(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey> keys, string alias, string value)
		{
			short num = (short)824770566;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_68;
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey = new global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey
					{
						Alias = alias
					};
					goto IL_102;
				}
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey;
					matrixRASKey.Value = null;
					num = (short)1694367748;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)1417347072;
					short num3 = num;
					global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey;
					keys.Add(matrixRASKey);
					num = (short)1387134981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_68;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
				{
					num = (short)1297612801;
					if (num != 0)
					{
					}
					num = (short)957358355;
					short num4 = num;
					num = (short)1893146899;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_102;
					default:
					{
						num = (short)1754923008;
						if (num != 0)
						{
						}
						if (!global::CommonUtility.PCRKeyUtility.IsRASKeyValueValid(value))
						{
							num = (short)609353730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey;
						matrixRASKey.Value = value;
						num = (short)2102132736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixRASKey matrixRASKey;
					if (global::CommonUtility.PCRKeyUtility.IsRASKeyAliasValid(matrixRASKey.Alias))
					{
						num = (short)899809283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_49:
				if (keys != null)
				{
					num = (short)1354170369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_68:
				num = (short)396558344;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_102:
				num = (short)993001479;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00029DF8 File Offset: 0x00027FF8
		public static void MergeMatrixSymmetricKey(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey> keys, int id, string alias, string value)
		{
			short num = (short)404357126;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_68;
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey = new global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey
					{
						Id = id,
						Alias = alias
					};
					string text = value.Trim().ToUpperInvariant();
					goto IL_11B;
				}
				case 2:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey;
					matrixSymmetricKey.Value = null;
					num = (short)411303940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					num = (short)1380122624;
					short num3 = num;
					global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey;
					keys.Add(matrixSymmetricKey);
					num = (short)259915781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					goto IL_68;
				case 5:
					return;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 7:
				{
					num = (short)790802978;
					short num4 = num;
					num = (short)628142626;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11B;
					default:
					{
						num = (short)2074017792;
						if (num != 0)
						{
						}
						num = (short)18153473;
						if (num != 0)
						{
						}
						string text;
						if (!global::CommonUtility.PCRKeyUtility.IsSymmetricKeyValueValid(text))
						{
							num = (short)1273167874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey;
						matrixSymmetricKey.Value = text;
						num = (short)93978624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
				{
					global::Motorola.CommonCPS.Server.EntityModel.MatrixSymmetricKey matrixSymmetricKey;
					if (global::CommonUtility.PCRKeyUtility.IsSymmetricKeyIDValid(new int?(matrixSymmetricKey.Id)))
					{
						num = (short)667025411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_49:
				if (keys != null)
				{
					num = (short)1278541825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_68:
				num = (short)1745682440;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_11B:
				num = (short)1639055367;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0002A014 File Offset: 0x00028214
		public static void MergeMatrixPreSharedKey(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey> keys, string alias, string value)
		{
			short num = (short)326500354;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey matrixPreSharedKey;
				string value2;
				switch (num2)
				{
				case 0:
					goto IL_103;
				case 1:
					if (!string.IsNullOrEmpty(alias))
					{
						num = (short)804126724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_103;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 3:
					IL_54:
					num = (short)754450433;
					if (num != 0)
					{
					}
					goto IL_8F;
				case 4:
					try
					{
						matrixPreSharedKey.Value = value2;
						goto IL_E1;
					}
					catch
					{
						matrixPreSharedKey.Value = null;
						goto IL_E1;
					}
					goto IL_8F;
					IL_E1:
					keys.Add(matrixPreSharedKey);
					num = (short)511246336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_38:
				if (keys != null)
				{
					num = (short)330956803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_103;
				IL_8F:
				matrixPreSharedKey = new global::Motorola.CommonCPS.Server.EntityModel.MatrixPreSharedKey
				{
					Alias = alias
				};
				value2 = value.Trim().ToUpperInvariant();
				num = (short)523370497;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_103:
				num = (short)823394304;
				short num3 = num;
				num = (short)363123308;
				short num4 = num;
				num = (short)1850266220;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_54;
				default:
					goto IL_162;
				}
			}
			IL_162:
			num = (short)1917911040;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0002A1AC File Offset: 0x000283AC
		public static bool IsKeyApplicable(global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType type, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			int a_ = 7;
			short num = (short)1835008002;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1199416564;
					short num3 = num;
					num = (short)944678132;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						goto IL_147;
					}
					break;
				}
				case 1:
					goto IL_B3;
				case 2:
				{
					num = (short)727187456;
					short num4 = num;
					switch (0)
					{
					case 0:
						goto IL_6A;
					}
					continue;
				}
				case 3:
					num = (short)993787905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise)
					{
						num = (short)843055105;
						if (num != 0)
						{
						}
						num = (short)861011968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_6A:
				switch (type)
				{
				case global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.PrivacyKey:
				case global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.RASKey:
				case global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.SymmetricKey:
				case global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.PreSharedKey:
					return true;
				case global::Motorola.CommonCPS.Server.CommonDBConstants.MatrixKeyType.OTAPKey:
					IL_BA:
					num = (short)1237450756;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)407633923;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_B3:
			throw new global::System.NotImplementedException(global::CommonUtility.VersionUtility.b("洷吹主嬽⌿ⵁ⍃⡅ⅇぉ⥋⩍灏ɑᝓѕ硗๙╛⹝՟䍡", a_));
			IL_147:
			num = (short)1626996736;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0002A330 File Offset: 0x00028530
		// Note: this type is marked as 'beforefieldinit'.
		static PCRKeyUtility()
		{
			int a_ = 18;
			short num = (short)992982326;
			short num2 = num;
			num = (short)1586935094;
			switch (num2 == num)
			{
			}
			num = (short)664403968;
			if (num != 0)
			{
			}
			num = (short)2121203713;
			if (num != 0)
			{
			}
			num = (short)449708032;
			short num3 = num;
			global::CommonUtility.PCRKeyUtility.k = new string[]
			{
				global::CommonUtility.VersionUtility.b("ూᅄن᥈੊㡌㭎㥐㙒㭔⍖じ㡚㱜⭞ࡠౢ୤ⱦ౨ቪ", a_),
				global::CommonUtility.VersionUtility.b("ق⭄⽆⡈╊⹌⩎㕐͒❔㹖⽘㩚㹜♞⩠٢ᱤᑦ", a_),
				global::CommonUtility.VersionUtility.b("ᅂфᑆɈ⹊㑌㱎", a_),
				global::CommonUtility.VersionUtility.b("ɂDᑆɈ⹊㑌㱎", a_),
				global::CommonUtility.VersionUtility.b("โୄๆᩈ๊⍌❎ぐ㵒㙔㉖㵘୚⽜㙞ᝠɢ٤Ṧ≨๪ᑬᱮ", a_),
				global::CommonUtility.VersionUtility.b("โୄๆᩈᡊ㑌≎㱐㙒⅔╖じ㡚ᙜ㩞ᡠၢ", a_)
			};
			global::CommonUtility.PCRKeyUtility.l = new string[]
			{
				global::CommonUtility.VersionUtility.b("ూلᡆوὊౌ὎ቐݒᡔ᱖Xᩚᅜ౞", a_),
				global::CommonUtility.VersionUtility.b("قୄཆ᥈᥊ь၎Őᡒၔ๖ᡘ᝚ᑜṞ㉠", a_),
				global::CommonUtility.VersionUtility.b("ɂDᑆ᥈᥊ь၎Őᡒၔ๖ᡘ᝚ᑜṞ㉠", a_),
				global::CommonUtility.VersionUtility.b("โୄๆᩈ๊͌ݎŐŒ᱔ࡖक़ၚᡜٞ⁠⽢Ɽ♦㩨", a_),
				global::CommonUtility.VersionUtility.b("โୄๆᩈᡊᑌɎ๐͒ṔቖXᩚᅜᙞ⁠ぢ", a_)
			};
		}

		// Token: 0x040000A6 RID: 166
		private const int a = 0;

		// Token: 0x040000A7 RID: 167
		private const int b = 65535;

		// Token: 0x040000A8 RID: 168
		private const int c = 255;

		// Token: 0x040000A9 RID: 169
		private const int d = 255;

		// Token: 0x040000AA RID: 170
		private const int e = 6;

		// Token: 0x040000AB RID: 171
		private const int f = 24;

		// Token: 0x040000AC RID: 172
		private const string g = "^[a-fA-F0-9]{1,9}[a-fA-F0-9]{0,1}$";

		// Token: 0x040000AD RID: 173
		private const string h = "^[a-fA-F0-9]{1,10}$";

		// Token: 0x040000AE RID: 174
		private const string i = "^[a-fA-F0-9]{1,64}$";

		// Token: 0x040000AF RID: 175
		private const string j = "^[a-zA-Z0-9\\$#_-]{6,24}$";

		// Token: 0x040000B0 RID: 176
		private static readonly string[] k;

		// Token: 0x040000B1 RID: 177
		private static readonly string[] l;

		// Token: 0x040000B2 RID: 178
		private const int m = 32;

		// Token: 0x040000B3 RID: 179
		private const int n = 16;

		// Token: 0x040000B4 RID: 180
		private const string o = "^[0-9a-fA-F]{32}$";

		// Token: 0x0200003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000180 RID: 384 RVA: 0x0002B46C File Offset: 0x0002966C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0)
			{
				short num = (short)1102524813;
				short num2 = num;
				num = (short)1039741325;
				switch (num2 == num)
				{
				}
				num = (short)1170800641;
				if (num != 0)
				{
				}
				num = (short)1141768192;
				if (num != 0)
				{
				}
				num = (short)1289748480;
				short num3 = num;
				return A_0.Name.Equals(this.a);
			}

			// Token: 0x040000CA RID: 202
			public string a;
		}

		// Token: 0x0200003D RID: 61
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000182 RID: 386 RVA: 0x0002B53C File Offset: 0x0002973C
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0)
			{
				short num = (short)943057945;
				short num2 = num;
				num = (short)1933896729;
				switch (num2 == num)
				{
				}
				num = (short)957612033;
				if (num != 0)
				{
				}
				num = (short)1024065536;
				if (num != 0)
				{
				}
				num = (short)2142961664;
				short num3 = num;
				return A_0.Name.Equals(this.a);
			}

			// Token: 0x040000CB RID: 203
			public string a;
		}

		// Token: 0x0200003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000184 RID: 388 RVA: 0x0002B608 File Offset: 0x00029808
			internal bool b(global::Motorola.CommonCPS.Server.EntityModel.DBNode A_0)
			{
				short num = (short)90504633;
				short num2 = num;
				num = (short)1417215417;
				switch (num2 == num)
				{
				}
				num = (short)995753984;
				if (num != 0)
				{
				}
				num = (short)103481345;
				if (num != 0)
				{
				}
				num = (short)682295296;
				short num3 = num;
				return A_0.Name.Equals(this.a);
			}

			// Token: 0x040000CC RID: 204
			public string a;
		}
	}
}
