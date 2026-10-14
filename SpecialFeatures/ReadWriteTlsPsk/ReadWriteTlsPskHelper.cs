using System;
using AcpCommonLib;
using CommonUtility;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.ReadWritePassword;

namespace SpecialFeatures.ReadWriteTlsPsk
{
	// Token: 0x0200005C RID: 92
	public class ReadWriteTlsPskHelper
	{
		// Token: 0x06000863 RID: 2147 RVA: 0x0008D908 File Offset: 0x0008BB08
		public static void SetTlsPskFromCodeplugPassword()
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.a();
			global::SpecialFeatures.ReadWritePassword.ReadWriteUtil readWriteUtil = new global::SpecialFeatures.ReadWritePassword.ReadWriteUtil();
			bool radWideLabtoolRadioReadPasswordEnable_A8869Value = radioWide.Labtool.RadWideLabtoolRadioReadPasswordEnable_A8869Value;
			bool radWideLabtoolRadioWritePasswordEnable_A8889Value = radioWide.Labtool.RadWideLabtoolRadioWritePasswordEnable_A8889Value;
			string value = radioWide.Labtool.RadWideLabtoolRadioPassword_A8837.Value;
			if (!global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.IsPasswordEnabled(radWideLabtoolRadioReadPasswordEnable_A8869Value, radWideLabtoolRadioWritePasswordEnable_A8889Value, value))
			{
				short num = (short)1506124123;
				short num2 = num;
				num = (short)438346075;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)471728128;
					short num3 = num;
					num = (short)370606081;
					if (num != 0)
					{
					}
					num = (short)133758976;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			string value2 = global::CommonUtility.TlsPskHashManager.Hash(readWriteUtil.decryptMesg(value), 4000, 16);
			radioWide.General.RadWideGeneralTlsPsk_44841.SetValue(value2);
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x0008DA20 File Offset: 0x0008BC20
		public static bool IsPasswordEnabled(bool readEnabled, bool writeEnabled, string encryptedPasswordValue)
		{
			short num = (short)1450203235;
			short num2 = num;
			num = (short)1371560035;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1411252224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)82182145;
			if (num != 0)
			{
			}
			num = (short)608108544;
			if (num != 0)
			{
			}
			bool flag = readEnabled || writeEnabled;
			bool flag2 = !string.IsNullOrEmpty(encryptedPasswordValue);
			return flag && flag2;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x0008DADC File Offset: 0x0008BCDC
		public void SetTlsPskHashInCodeplug(string password)
		{
			int a_ = 15;
			short num = (short)1954414593;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string value;
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					try
					{
						global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.a().General.RadWideGeneralTlsPsk_44841.SetValue(value);
						return;
					}
					catch (global::System.InvalidOperationException ex)
					{
						global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톑ﮓﺙ릝풟芡힣쎥\udca7誩\ud8ab욭햯銱鞹諾듁ꗃ꫅뷇꿉ꯍ꣏뇑뇓ꛕ곗동돛냝샟闡藣闥죧黩蓫鳭鿯藱髳\ud8f5\ud8f7뿹蓻鷽旿爁瀃漅朇搉Ⰻ挍甏愑朓眕缗缙☛㸝", a_) + ex.Message);
						return;
					}
					goto IL_10D;
				}
				IL_39:
				if (!string.IsNullOrEmpty(password))
				{
					goto IL_10D;
				}
				num = (short)1481120107;
				short num3 = num;
				num = (short)1782061419;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1479147521;
					if (num != 0)
					{
					}
					num = (short)421855232;
					if (num != 0)
					{
					}
					num = (short)1556545536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_13E:
				num = (short)1919352834;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10D:
				num = (short)1757216768;
				short num4 = num;
				value = this.a(password);
				goto IL_13E;
			}
			IL_CD:
			global::System.ArgumentNullException ex2 = new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒟", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슑聯鍊얟킡蒣얥즧쒩讫\udaad邯킱톳隵횷쾹킻튽귁뛃귇Ꟊ볋뫍ꧏﳑ", a_));
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(ex2.Message);
			throw ex2;
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0008DC84 File Offset: 0x0008BE84
		public void ResetTlsPskFields()
		{
			int a_ = 5;
			short num;
			try
			{
				num = (short)1178462580;
				short num2 = num;
				num = (short)88795508;
				switch (num2 == num)
				{
				}
				num = (short)235864064;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::SpecialFeatures.ReadWriteTlsPsk.ReadWriteTlsPskHelper.a();
				string defaultValue = radioWide.General.RadWideGeneralTlsPsk_44841.DefaultValue;
				radioWide.General.RadWideGeneralTlsPsk_44841.SetValue(defaultValue);
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udc87ﾋ꺍삏ﾓ뚕ﮙ뺝슟잡솣좥袧\ud8a9즫\uddad햯욱", a_));
			}
			catch (global::System.InvalidOperationException ex)
			{
				global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮇曆ﲑ뎓뢗鍊肟횡첣쎥袧睊ﾫ鶯ﮱ隵캷\udbb9킻쮽ꖿꇃ뻅ꯇ꿉볋뫍맏뷑뫓꿗믙꿛ﻝ铟諡難觥鿧蓩싫컭뗯諱音鏵裷軹闻釽滿∁椃挅笇礉洋植甏⠑㐓", a_) + ex.Message;
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(ex.Message);
			}
			num = (short)1891762176;
			short num3 = num;
			num = (short)1766916097;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0008DDAC File Offset: 0x0008BFAC
		private static global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide a()
		{
			int a_ = 17;
			short num = (short)1660551169;
			if (num != 0)
			{
			}
			num = (short)2052194304;
			short num2 = num;
			num = (short)622201398;
			short num3 = num;
			num = (short)452921910;
			switch (num3 == num)
			{
			}
			num = (short)1022623744;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			if (radioWide == null)
			{
				global::System.InvalidOperationException ex = new global::System.InvalidOperationException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힓秊螟횡蒣솥춧\udea9貫\udaad\ud8afힱ钳쒵\ud9b7\udeb9햻톽뗁귃ꋅ귇꫋ꯍ뇏ꛑꇓꓕ뷗", a_));
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(ex.Message);
				throw ex;
			}
			return radioWide;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0008DE98 File Offset: 0x0008C098
		private string a(string A_0)
		{
			short num = (short)678514436;
			short num2 = num;
			num = (short)1694846724;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1374879744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)661127169;
			if (num != 0)
			{
			}
			num = (short)2022572032;
			if (num != 0)
			{
			}
			return global::CommonUtility.TlsPskHashManager.Hash(A_0, 4000, 16);
		}
	}
}
