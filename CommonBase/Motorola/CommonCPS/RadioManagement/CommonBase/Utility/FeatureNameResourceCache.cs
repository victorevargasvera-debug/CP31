using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Comparers;
using Motorola.CommonCPS.Server.CommonDBConstants;
using RFResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x0200000F RID: 15
	public class FeatureNameResourceCache
	{
		// Token: 0x0600004B RID: 75 RVA: 0x0000717C File Offset: 0x0000537C
		static FeatureNameResourceCache()
		{
			short num = (short)1325847487;
			short num2 = num;
			num = (short)1722405823;
			switch (num2 == num)
			{
			}
			num = (short)52822016;
			if (num != 0)
			{
			}
			num = (short)25493505;
			if (num != 0)
			{
			}
			num = (short)1808596992;
			short num3 = num;
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a = new global::System.Collections.Generic.Dictionary<int, string>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b = new global::System.Collections.Generic.Dictionary<int, string>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c = new global::System.Collections.Generic.Dictionary<string, string>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum, string>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000725C File Offset: 0x0000545C
		private static void c()
		{
			short num = (short)717881344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs)).GetEnumerator();
				try
				{
					num = (short)77791234;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_125;
						case 1:
							num = (short)1026818048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_70;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)68419585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							string text = ((global::Motorola.CommonCPS.Server.CommonDBConstants.ASTRO_OptionIDs)obj).ToString();
							string rfresourceValueByResourceID = global::RFResourceRepository.ASTROResourceHelper.Instance().GetRFResourceValueByResourceID(text, null);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a.Add((int)obj, rfresourceValueByResourceID);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c.Add(text, rfresourceValueByResourceID);
							num = (short)811073539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_D2:
						num = (short)1213136900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_70:
						goto IL_D2;
					}
					IL_125:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_147;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_134:
						switch (num2)
						{
						case 0:
						{
							num = (short)2087249998;
							short num3 = num;
							num = (short)1232267342;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1B2;
							default:
								goto IL_1FF;
							}
							break;
						}
						case 1:
							if (disposable != null)
							{
								num = (short)1090453506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_216;
						case 2:
							num = (short)1699020801;
							if (num != 0)
							{
							}
							disposable.Dispose();
							goto IL_1B2;
						}
						goto IL_147;
						IL_1B2:
						num = (short)1770389504;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1FF:
					num = (short)1815543808;
					if (num != 0)
					{
					}
					IL_216:
					goto EndFinally_5;
					IL_147:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)2041380865;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_134;
					EndFinally_5:;
				}
				num = (short)982450176;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000074BC File Offset: 0x000056BC
		private static void b()
		{
			short num = (short)940965889;
			if (num != 0)
			{
			}
			num = (short)1420689408;
			short num2 = num;
			num = (short)283967488;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode)).GetEnumerator();
				try
				{
					num = (short)2031419398;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						string rfresourceValueByResourceID;
						object obj;
						switch (num3)
						{
						case 0:
							rfresourceValueByResourceID = global::RFResourceRepository.PCRResourceHelper.Instance().GetRFResourceValueByResourceID(text, null);
							goto IL_193;
						case 1:
							goto IL_224;
						case 2:
							rfresourceValueByResourceID = global::RFResourceRepository.PCRResourceHelper.Instance().GetRFResourceValueByResourceID(global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode.CFS_SMA.ToString(), null);
							goto IL_193;
						case 4:
							num = (short)1490223105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode a_;
							if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d((int)a_))
							{
								num = (short)230096904;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1773993986;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_D3;
							}
							continue;
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)146145284;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							obj = enumerator.Current;
							global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode a_ = (global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode)obj;
							text = a_.ToString();
							num = (short)155582469;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							num = (short)1270087680;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_FB:
						num = (short)528089095;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D3:
						goto IL_FB;
						IL_193:
						string value = rfresourceValueByResourceID;
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b.Add((int)obj, value);
						global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c.Add(text, value);
						num = (short)192020483;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_224:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_246;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_233:
						switch (num3)
						{
						case 0:
						{
							num = (short)91432945;
							short num4 = num;
							num = (short)548808689;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_289;
							default:
								goto IL_2D2;
							}
							break;
						}
						case 1:
							if (disposable != null)
							{
								num = (short)1560150018;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EA;
						case 2:
							disposable.Dispose();
							goto IL_289;
						}
						goto IL_246;
						IL_289:
						num = (short)2003042304;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2D2:
					num = (short)1647575040;
					if (num != 0)
					{
					}
					IL_2EA:
					goto EndFinally_6;
					IL_246:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1410662401;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_233;
					EndFinally_6:;
				}
				return;
			}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000077D0 File Offset: 0x000059D0
		private static void a()
		{
			short num = (short)711917568;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.IEnumerator enumerator = global::System.Enum.GetValues(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum)).GetEnumerator();
				try
				{
					num = (short)1669201922;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_10C;
						case 1:
							num = (short)1711996928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_6E;
							}
							continue;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1858863105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum key = (global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum)enumerator.Current;
							string resourceID = key.ToString();
							string rfresourceValueByResourceID = global::RFResourceRepository.RFResourceHelper.Instance().GetRFResourceValueByResourceID(resourceID, null);
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d.Add(key, rfresourceValueByResourceID);
							num = (short)1719599107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_BA:
						num = (short)570163204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E:
						goto IL_BA;
					}
					IL_10C:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_12E;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_11B:
						switch (num2)
						{
						case 0:
						{
							num = (short)426827926;
							short num3 = num;
							num = (short)584638614;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_171;
							default:
								goto IL_1BD;
							}
							break;
						}
						case 1:
							if (disposable != null)
							{
								num = (short)1299054594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FA;
						case 2:
							disposable.Dispose();
							goto IL_171;
						}
						goto IL_12E;
						IL_171:
						num = (short)1957494784;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1BD:
					num = (short)1055129601;
					if (num != 0)
					{
					}
					num = (short)394002432;
					if (num != 0)
					{
					}
					IL_1FA:
					goto EndFinally_5;
					IL_12E:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1954545665;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_11B;
					EndFinally_5:;
				}
				num = (short)648413184;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007A14 File Offset: 0x00005C14
		public static string GetAstroFeatureName(int featureID)
		{
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a.Keys.Contains(featureID))
			{
				num = (short)1294008321;
				if (num != 0)
				{
				}
				num = (short)1979904067;
				short num2 = num;
				num = (short)747434051;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)431554560;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a[featureID];
				}
			}
			num = (short)664928256;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00007AE8 File Offset: 0x00005CE8
		public static string GetFeatureNameByFeatureName(string featureResourceID)
		{
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c.Keys.Contains(featureResourceID))
			{
				num = (short)312147969;
				if (num != 0)
				{
				}
				num = (short)1006839977;
				short num2 = num;
				num = (short)2037262505;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)335151104;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c[featureResourceID];
				}
			}
			num = (short)1329070080;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007BBC File Offset: 0x00005DBC
		public static string GetFeatureStatusDisplayString(global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum featureStatus)
		{
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d.Keys.Contains(featureStatus))
			{
				num = (short)357123244;
				short num2 = num;
				num = (short)60245164;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)296943617;
					if (num != 0)
					{
					}
					num = (short)325779456;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d[featureStatus];
				}
			}
			num = (short)2003173376;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007C8C File Offset: 0x00005E8C
		public static string GetPcrFeatureDisplayName(int featureCode, string licenceNotice = null)
		{
			short num = (short)81264641;
			if (num != 0)
			{
			}
			num = (short)844228636;
			short num2 = num;
			num = (short)1669982236;
			switch (num2 == num)
			{
			}
			num = (short)1229717504;
			if (num != 0)
			{
			}
			num = (short)1673461760;
			short num3 = num;
			string a_ = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.e(featureCode);
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a(featureCode, licenceNotice, a_);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007D48 File Offset: 0x00005F48
		public static string GetPcrLicenseDisplayName(int featureCode, string resourceID = "", string licenceNotice = null)
		{
			short num = (short)417706997;
			short num2 = num;
			num = (short)1690350581;
			switch (num2 == num)
			{
			}
			num = (short)730660865;
			if (num != 0)
			{
			}
			num = (short)824573952;
			if (num != 0)
			{
			}
			num = (short)516030464;
			short num3 = num;
			string rfresourceValueByResourceID = global::RFResourceRepository.PCRResourceHelper.Instance().GetRFResourceValueByResourceID(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a(resourceID), null);
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a(featureCode, licenceNotice, rfresourceValueByResourceID);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007E0C File Offset: 0x0000600C
		private static string e(int A_0)
		{
			short num;
			if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b.Keys.Contains(A_0))
			{
				num = (short)727491685;
				short num2 = num;
				num = (short)447849573;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)596574208;
					if (num != 0)
					{
					}
					num = (short)491388929;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b[A_0];
				}
			}
			num = (short)554041344;
			short num3 = num;
			return string.Empty;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007EE0 File Offset: 0x000060E0
		private static string a(int A_0, string A_1, string A_2)
		{
			int a_ = 1;
			short num;
			string result;
			try
			{
				num = (short)1621819392;
				switch (num)
				{
				default:
					for (;;)
					{
						IL_26:
						num = (short)1632763909;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1FC;
							case 1:
							{
								byte[] bytes = global::System.Convert.FromBase64String(A_1);
								num = (short)1549277810;
								short num3 = num;
								num = (short)1574181490;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_26;
								default:
									num = (short)221118464;
									if (num != 0)
									{
									}
									num = (short)93323268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								if (!string.IsNullOrWhiteSpace(A_1))
								{
									num = (short)870907905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E1;
							case 3:
								goto IL_1E1;
							case 4:
							{
								num = (short)24772609;
								if (num != 0)
								{
								}
								byte[] bytes;
								byte smaNumber;
								if (global::CommonUtility.FeatureNoticeUtility.GetLatestNoticeValue(global::System.Text.Encoding.UTF8.GetString(bytes), out smaNumber))
								{
									num = (short)1276248071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1E1;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_6C;
								}
								continue;
							case 6:
								num = (short)1137901570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								byte smaNumber;
								string str = new global::CommonUtility.SMAConverter().ConvertNumberToDateTimeString(smaNumber, global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("ᡔᩖ癘㽚㥜灞ᡠᩢᱤṦ", a_), null);
								A_2 = A_2 + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("畔", a_) + str;
								num = (short)1599471619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_6C:
							if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.a(A_0))
							{
								num = (short)1063649286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1E1:
							result = A_2;
							num = (short)1713438720;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1FC:
					break;
				}
			}
			catch (global::System.Exception)
			{
				result = A_2;
			}
			num = (short)293273600;
			short num4 = num;
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008138 File Offset: 0x00006338
		private static bool d(int A_0)
		{
			short num;
			if (A_0 >= 1001)
			{
				num = (short)474873857;
				if (num != 0)
				{
				}
				num = (short)2082904342;
				short num2 = num;
				num = (short)275159318;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)226361344;
					if (num != 0)
					{
					}
					return A_0 <= 1080;
				}
			}
			num = (short)1105133568;
			short num3 = num;
			return false;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000081FC File Offset: 0x000063FC
		private static bool c(int A_0)
		{
			short num = (short)1389380108;
			short num2 = num;
			num = (short)364593676;
			switch (num2 == num)
			{
			}
			num = (short)364707841;
			if (num != 0)
			{
			}
			num = (short)20381696;
			if (num != 0)
			{
			}
			num = (short)1163460608;
			short num3 = num;
			return A_0 == 1000;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000082B0 File Offset: 0x000064B0
		private static bool b(int A_0)
		{
			short num = (short)424164974;
			short num2 = num;
			num = (short)58146414;
			switch (num2 == num)
			{
			}
			num = (short)2087256065;
			if (num != 0)
			{
			}
			num = (short)1715273728;
			if (num != 0)
			{
			}
			num = (short)629997568;
			short num3 = num;
			return A_0 == 2000;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008360 File Offset: 0x00006560
		private static bool a(int A_0)
		{
			short num = (short)1879769090;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)348389376;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)867827715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 3:
					if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.c(A_0))
					{
						num = (short)1485373441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_5E:
				num = (short)1929248930;
				short num4 = num;
				num = (short)149487778;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10C;
				default:
					num = (short)1341849600;
					if (num != 0)
					{
					}
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.d(A_0))
					{
						return true;
					}
					num = (short)1100218368;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10C:
			num = (short)1328087041;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.FeatureNameResourceCache.b(A_0);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000084A8 File Offset: 0x000066A8
		private static string a(string A_0)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_81;
			}
			int num;
			string text;
			short num2;
			string result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⍥╧⽩⵫", a_).Substring(0, 2);
					num2 = (short)325845011;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					A_0 = A_0.Remove(4, 8);
					num2 = (short)289013783;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					result = A_0;
					num2 = (short)1256521739;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (A_0.Length >= 11)
					{
						num2 = (short)912195585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AB;
				case 4:
					goto IL_1AB;
				case 5:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⍥╧⽩⵫", a_).Substring(0, 2) + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥥", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1473904640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)209387545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱", a_).TrimEnd(new char[]
					{
						'_'
					});
					num2 = (short)356712457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					A_0 = A_0.Replace(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱", a_), string.Empty);
					num2 = (short)2005139459;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_1AB;
				case 10:
					goto IL_41A;
				case 11:
					goto IL_306;
				case 12:
					goto IL_1C2;
				case 13:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("❥㭧", a_).Substring(0, 2) + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥥", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1275330584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1918697477;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⡥⥧", a_).Substring(0, 2) + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥥", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1270480912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)382402573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)355401735;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AB;
				case 16:
				{
					num2 = (short)821048835;
					short num3 = num2;
					num2 = (short)1390556675;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C2;
					default:
						num2 = (short)1321402368;
						if (num2 != 0)
						{
						}
						text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⡥⥧", a_).Substring(0, 2);
						num2 = (short)58064900;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 17:
					if (string.IsNullOrWhiteSpace(A_0))
					{
						num2 = (short)945356806;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2052456462;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("Ⅵ⑧╩⹫⽭㱯⵱❳㭵㥷╹", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)2058158088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1754660879;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1327890433;
					if (num2 != 0)
					{
					}
					goto IL_1AB;
				case 20:
					goto IL_1AB;
				case 21:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⩥⥧", a_).Substring(0, 2);
					num2 = (short)94240788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_1AB;
				case 23:
					goto IL_1AB;
				case 24:
					text = global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("❥㭧", a_).Substring(0, 2);
					num2 = (short)1870921750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (A_0.StartsWith(global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("⩥⥧", a_).Substring(0, 2) + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥥", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)591855637;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)780861458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_81;
				IL_1AB:
				num2 = (short)345964556;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C2:
				if (string.IsNullOrEmpty(text))
				{
					num2 = (short)1310523394;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					result = A_0.Replace(text + global::Motorola.CommonCPS.RadioManagement.CommonBase.Comparers.EnableFeatureCountComparer.b("㥥", a_), string.Empty);
					num2 = (short)672858122;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return result;
			IL_306:
			IL_41A:
			num2 = (short)720896000;
			short num4 = num2;
			return result;
			IL_81:
			text = string.Empty;
			result = string.Empty;
			num2 = (short)1957232657;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000029 RID: 41
		private static global::System.Collections.Generic.Dictionary<int, string> a;

		// Token: 0x0400002A RID: 42
		private static global::System.Collections.Generic.Dictionary<int, string> b;

		// Token: 0x0400002B RID: 43
		private static global::System.Collections.Generic.Dictionary<string, string> c;

		// Token: 0x0400002C RID: 44
		private static global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum, string> d;

		// Token: 0x0400002D RID: 45
		private const string e = "MM/dd/yyyy";
	}
}
