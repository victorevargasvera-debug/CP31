using System;
using AcpCommonLib;
using Common;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.Comms;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x02000189 RID: 393
	public class PINPasswordUtil
	{
		// Token: 0x060012FF RID: 4863 RVA: 0x001B7720 File Offset: 0x001B5920
		public static void UpdatePINPasswordFromRadio(global::SpecialFeatures.Comms.RadioIdInfo tempRadioIds)
		{
			short num = (short)349175808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				string value;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_27:
					string text;
					string str;
					switch (num2)
					{
					case 0:
						num = (short)90177544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2B0;
					case 2:
						goto IL_1DB;
					case 3:
						if (text.Length > 4)
						{
							num = (short)344981513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 4:
						if (tempRadioIds.IsEncryptedPwd)
						{
							num = (short)1759576064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1539375115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (tempRadioIds.SoftIds[2] == null)
						{
							num = (short)1784807424;
							short num3 = num;
							str = "";
							num = (short)1520238599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1891827576;
						short num4 = num;
						num = (short)1395916664;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17C;
						default:
							num = (short)292487168;
							if (num != 0)
							{
							}
							num = (short)684392454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)318832641;
						if (num != 0)
						{
						}
						str = global::SpecialFeatures.Clone_Configuration.Common.PINPasswordUtil.a(tempRadioIds.SoftIds[2]);
						num = (short)1308098573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_C6;
					case 8:
						if (!string.IsNullOrEmpty(tempRadioIds.EncryptedPwd))
						{
							num = (short)811401218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						text = text.Substring(0, 4);
						goto IL_17C;
					case 10:
						goto IL_263;
					case 11:
						if (tempRadioIds.IsManagedUpgrade)
						{
							num = (short)2054750209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::SpecialFeatures.Clone_Configuration.Common.PINPasswordUtil.a(tempRadioIds.SoftIds[1]);
						num = (short)1536360453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_22D;
					case 13:
						goto IL_C6;
					}
					goto IL_66;
					IL_C6:
					num = (short)1389494275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17C:
					num = (short)1198260236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					value = global::Common.AESCryptoUtil.AESEncryptWithDefKey(text + str);
					radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.SetValue(value);
					num = (short)1879048202;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DB:
				radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.SetValue(tempRadioIds.EncryptedPwd);
				return;
				IL_263:
				return;
				IL_2B0:
				global::SpecialFeatures.Clone_Configuration.Common.PINPasswordUtil.UpdatePasswordsToClear(tempRadioIds.EncryptedPwd);
				return;
				IL_66:
				radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				value = string.Empty;
				num = (short)1677852676;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001300 RID: 4864 RVA: 0x001B7A80 File Offset: 0x001B5C80
		private static string a(string A_0)
		{
			int num;
			short num2;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						A_0 = "";
						num2 = (short)1629476123;
						short num3 = num2;
						num2 = (short)279041307;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_80;
						default:
							num2 = (short)1497956352;
							if (num2 != 0)
							{
							}
							num2 = (short)540147716;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (num4 == 0)
						{
							num2 = (short)1972764672;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)2079522819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						A_0 = A_0.Substring(0, num4);
						num2 = (short)1794310149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (num4 > 0)
						{
							num2 = (short)1013710850;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return A_0;
					case 4:
						return A_0;
					case 5:
						return A_0;
					}
					goto IL_28;
				}
				return A_0;
			}
			IL_28:
			num2 = (short)1839136769;
			if (num2 != 0)
			{
			}
			num2 = (short)583073792;
			short num5 = num2;
			num4 = A_0.IndexOf('\0');
			IL_80:
			num2 = (short)2100428801;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001301 RID: 4865 RVA: 0x001B7C0C File Offset: 0x001B5E0C
		public static string UpdatePasswordsToClear(string encryptedPswd = null)
		{
			short num = (short)939130880;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_27:
					num = (short)266141696;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (encryptedPswd != null)
						{
							goto IL_C5;
						}
						goto IL_156;
					case 1:
					{
						num = (short)625422714;
						short num4 = num;
						num = (short)680472954;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C5;
						default:
							num = (short)2123169792;
							if (num != 0)
							{
							}
							goto IL_156;
						}
						break;
					}
					case 2:
						goto IL_16E;
					case 3:
						radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.SetValue(encryptedPswd);
						num = (short)997064705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_68;
					IL_C5:
					num = (short)1654063107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_156:
					num = (short)1348599810;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_16E:
				string value = radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPassword_41303.Value;
				string text = string.Empty;
				string value2 = string.Empty;
				string value3 = string.Empty;
				text = global::Common.AESCryptoUtil.AESDecryptWithDefKey(value);
				if (text.Length > 4)
				{
					value2 = text.Substring(0, 4);
					value3 = text.Substring(4);
				}
				else
				{
					value2 = text;
				}
				radioWide.Labtool.RadWideLabtoolEncryptPassword_A41695.SetValue(false);
				radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsPIN_A8705.SetValue(value2);
				radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPasswordPart2_41304.SetValue(value3);
				radioWide.Labtool.RadWideLabtoolEncryptedPINPassword_A41702.SetValue(string.Empty);
				return value;
				IL_68:
				num = (short)1609367553;
				if (num != 0)
				{
				}
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)999292928;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001302 RID: 4866 RVA: 0x001B7E1C File Offset: 0x001B601C
		public static void RestorePasswordsBackEncrypt(string originalPwd)
		{
			short num = (short)107020288;
			short num2 = num;
			num = (short)333590879;
			short num3 = num;
			num = (short)798634335;
			switch (num3 == num)
			{
			}
			num = (short)1420492801;
			if (num != 0)
			{
			}
			num = (short)726990848;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			radioWide.Labtool.RadWideLabtoolEncryptPassword_A41695.SetValue(true);
			radioWide.Labtool.RadWideLabtoolEncryptedPINPassword_A41702.SetValue(originalPwd);
			radioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsPIN_A8705.SetValue(string.Empty);
			radioWide.UserInformationAndPasswords.RadWideUserInformationandPINPasswordPart2_41304.SetValue(string.Empty);
		}
	}
}
