using System;
using AcpBusinessLayer;
using AcpCommonLib;
using Common;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200018B RID: 395
	public static class DataModemPasswordUtil
	{
		// Token: 0x06001318 RID: 4888 RVA: 0x001BA33C File Offset: 0x001B853C
		public static void UpdateCipherPasswordsToPlain()
		{
			int a_ = 5;
			short num = (short)401080321;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_76;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem;
			for (;;)
			{
				IL_3C:
				num = (short)1338114048;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_106;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
					if (dataWide == null)
					{
						num = (short)656080896;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					externalDataModem = dataWide.ExternalDataModem;
					if (externalDataModem != null)
					{
						goto IL_17A;
					}
					num = (short)337152916;
					short num4 = num;
					num = (short)1578732436;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1639186432;
						if (num != 0)
						{
						}
						num = (short)101646338;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_177;
				}
				goto IL_76;
			}
			IL_106:
			object obj = null;
			goto IL_181;
			IL_177:
			obj = null;
			goto IL_181;
			IL_17A:
			obj = externalDataModem.EmbeddedRecset;
			IL_181:
			global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.b = new global::SpecialFeatures.Clone_Configuration.Common.ClearAndRestorePassword(obj as global::AcpBusinessLayer.Recordset, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첇잏ﮑ\udd97ﾛ\ud99f튡킣쎥첧쎫쪭햯\udfb1ힵ쮷즹쮻톽늿ꛁ鯃﯇柳頋ￍ", a_));
			global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.b.ClearFieldsAndRemember(new global::System.Func<string, string>(global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForDataModemPassword));
			return;
			IL_76:
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide2 = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			string text = global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForDataModemPassword(dataWide2.ExternalDataModem.DataWideDataModemPassword_A42848.Value);
			dataWide2.ExternalDataModem.DataWideDataModemPassword_A42848.SetValue(string.Empty);
			global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.a = text;
			num = (short)2128347137;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3C;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x001BA500 File Offset: 0x001B8700
		public static void RestorePlainPasswordToCipher()
		{
			short num = (short)865468416;
			short num2 = num;
			num = (short)178520065;
			if (num != 0)
			{
			}
			num = (short)393381797;
			short num3 = num;
			num = (short)1348962213;
			switch (num3 == num)
			{
			}
			num = (short)1421017088;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			string text = global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForDataModemPassword(global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.a);
			text = text.Substring(0, 66);
			dataWide.ExternalDataModem.DataWideDataModemPassword_A42848.SetValue(text);
			global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.b.RestorePasswordsAndForgot(new global::System.Func<string, string>(global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForDataModemPassword), 66);
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x001BA5FC File Offset: 0x001B87FC
		// Note: this type is marked as 'beforefieldinit'.
		static DataModemPasswordUtil()
		{
			short num = (short)2088304640;
			short num2 = num;
			num = (short)887616862;
			short num3 = num;
			num = (short)1882322270;
			switch (num3 == num)
			{
			}
			num = (short)1058340864;
			if (num != 0)
			{
			}
			num = (short)765263873;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Clone_Configuration.Common.DataModemPasswordUtil.a = string.Empty;
		}

		// Token: 0x04000A35 RID: 2613
		private static string a;

		// Token: 0x04000A36 RID: 2614
		private static global::SpecialFeatures.Clone_Configuration.Common.ClearAndRestorePassword b;
	}
}
