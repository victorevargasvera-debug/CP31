using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Windows;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI.Common;
using Common;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.CloneWiFi;

namespace SpecialFeatures.Clone_Configuration.Common
{
	// Token: 0x0200018A RID: 394
	public class WiFiPasswordUtil
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x001B7F28 File Offset: 0x001B6128
		static WiFiPasswordUtil()
		{
			short num = (short)160104448;
			short num2 = num;
			num = (short)1367857201;
			short num3 = num;
			num = (short)1339611185;
			switch (num3 == num)
			{
			}
			num = (short)1412038657;
			if (num != 0)
			{
			}
			num = (short)647233536;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a = new global::System.Collections.Generic.List<string>();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b = 1;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.f = true;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g = new global::System.Collections.Generic.Dictionary<string, string>();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h = new global::System.Collections.Generic.Dictionary<string, string>();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e = new global::System.Timers.Timer(900000.0);
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e.Elapsed += global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e.AutoReset = false;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x001B802C File Offset: 0x001B622C
		public static void UpdateCipherPasswordsToPlain()
		{
			int a_ = 9;
			short num = (short)109182976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						if (configuredNetworksListInnerRecset == null)
						{
							num = (short)937754624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1048444929;
						if (num != 0)
						{
						}
						global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a.Clear();
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = configuredNetworksListInnerRecset.GetEnumerator();
						num = (short)1585709059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_34E;
					case 3:
						try
						{
							num = (short)1238892546;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1624047621;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_183;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									string item = global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForWiFiPassword(configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value);
									configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.SetValue(string.Empty);
									global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a.Add(item);
									num = (short)1997996033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)829816832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
									num = (short)1722089478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_26E;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									if (configuredNetworksListInner != null)
									{
										num = (short)923926531;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_21B:
								num = (short)933298180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_183:
								goto IL_21B;
							}
							IL_26E:
							goto IL_A7;
						}
						finally
						{
							num = (short)1037323592;
							short num3 = num;
							num = (short)910118216;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1772486656;
								if (num != 0)
								{
								}
								num = (short)1835663361;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_328;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2F2;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)899743744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2F2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)929890306;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_328:;
						}
						goto IL_32B;
						IL_A7:
						num = (short)1107427333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_394;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
						if (dataWide == null)
						{
							num = (short)1755774978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						externalDataModem = dataWide.ExternalDataModem;
						if (externalDataModem == null)
						{
							num = (short)520945668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32B;
					}
					}
					goto IL_4F;
				}
				return;
				IL_32B:
				global::AcpCommonLib.IAcpRecordset acpRecordset = externalDataModem.EmbeddedRecset;
				goto IL_397;
				IL_34E:
				num = (short)1618542592;
				short num4 = num;
				acpRecordset = null;
				goto IL_397;
				IL_394:
				acpRecordset = null;
				IL_397:
				global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.i = new global::SpecialFeatures.Clone_Configuration.Common.ClearAndRestorePassword(acpRecordset as global::AcpBusinessLayer.Recordset, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋쎓ﾕﲗﾙ\ud99b쎟킡\udda3횥\udca7쾩좫햯욱쎳\ud9b5쪷톹\udfbd뎿뇁돃꧅뫇껉鏋鬒", a_));
				global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.i.ClearFieldsAndRemember(new global::System.Func<string, string>(global::Common.AESCryptoUtil.AESDecryptWithDefKey_ForWiFiPassword));
				return;
				IL_4F:
				configuredNetworksListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
				num = (short)2116026369;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x001B8420 File Offset: 0x001B6620
		public static void RestorePlainPasswordToCipher()
		{
			short num = (short)1992884224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)664356465;
				short num3 = num;
				num = (short)1891518065;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
				int num4;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D6:
					if (configuredNetworksListInnerRecset == null)
					{
						num = (short)2063335428;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num4 = 0;
						num = (short)20905986;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				default:
					num = (short)161153024;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_9C;
					}
					break;
				}
				for (;;)
				{
					IL_71:
					switch (num2)
					{
					case 0:
						goto IL_D6;
					case 1:
						goto IL_1EC;
					case 2:
						goto IL_188;
					case 3:
						goto IL_188;
					case 4:
						return;
					case 5:
					{
						num = (short)589627392;
						short num5 = num;
						string value = global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForWiFiPassword(global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a[num4]);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.SetValue(value);
						num = (short)2142961671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (num4 >= configuredNetworksListInnerRecset.Count)
						{
							num = (short)98631681;
							if (num != 0)
							{
							}
							num = (short)1689452545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = configuredNetworksListInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
						num = (short)275382280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_FA;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						if (configuredNetworksListInner != null)
						{
							num = (short)471924741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					}
					}
					goto IL_9C;
					IL_FA:
					num4++;
					num = (short)2128412675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_188:
					num = (short)320733190;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1EC:
				global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.i.RestorePasswordsAndForgot(new global::System.Func<string, string>(global::Common.AESCryptoUtil.AESEncryptWithDefKey_ForWiFiPassword), -1);
				return;
				IL_9C:
				configuredNetworksListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
				num = (short)1572077568;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_71;
			}
			}
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x001B8690 File Offset: 0x001B6890
		private static void a(object A_0, global::System.Timers.ElapsedEventArgs A_1)
		{
			short num = (short)1942093824;
			short num2 = num;
			num = (short)1344821204;
			short num3 = num;
			num = (short)1766610900;
			switch (num3 == num)
			{
			}
			num = (short)1935867905;
			if (num != 0)
			{
			}
			num = (short)442368000;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.ResetSessionTimer();
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x001B8740 File Offset: 0x001B6940
		internal static bool NeedValidation()
		{
			short num = (short)2110586880;
			short num2 = num;
			num = (short)1224509510;
			short num3 = num;
			num = (short)1656326214;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)131006465;
				if (num != 0)
				{
				}
				num = (short)1475870720;
				if (num != 0)
				{
				}
				if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.c())
				{
					return true;
				}
				break;
			}
			return global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b();
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x001B87F8 File Offset: 0x001B69F8
		private static bool c()
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)185270276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (dataWide != null)
					{
						num2 = (short)633667584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					return false;
				case 3:
					return false;
				case 4:
				{
					num2 = (short)1230873674;
					short num3 = num2;
					num2 = (short)551330890;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
						num2 = (short)1543176192;
						if (num2 != 0)
						{
						}
						if (!dataWide.WIFI.DataWideWIFIEnable_42506.Value)
						{
							num2 = (short)1715208193;
							if (num2 != 0)
							{
							}
							num2 = (short)1640169479;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						configuredNetworksListInnerRecset = (dataWide.WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
						num2 = (short)2125004805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
				{
					if (configuredNetworksListInnerRecset == null)
					{
						num2 = (short)1719926786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					bool isUpdated = false;
					num2 = (short)1499136010;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_1CD;
				case 7:
					goto IL_19F;
				case 8:
				{
					bool isUpdated;
					if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.IsTimerRefreshedAndWiFiPasswordValidationSkept(isUpdated))
					{
						num2 = (short)2013724675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_252;
				}
				case 9:
				{
					bool isUpdated = global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a(configuredNetworksListInnerRecset);
					num2 = (short)110100486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g.Count != 0)
					{
						num2 = (short)528809993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1CD;
				}
				goto IL_3C;
				IL_1CD:
				num2 = (short)742457352;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_19F:
			num2 = (short)2075525120;
			short num4 = num2;
			return false;
			IL_252:
			return global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b(configuredNetworksListInnerRecset);
			IL_3C:
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)1345585153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x001B8A60 File Offset: 0x001B6C60
		private static bool b()
		{
			switch (0)
			{
			case 0:
				goto IL_7E;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset a_;
			for (;;)
			{
				IL_0A:
				num = (short)1955625750;
				short num2 = num;
				num = (short)1542617878;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_138;
				default:
					num = (short)1642659840;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (dataWide != null)
						{
							num = (short)211222532;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
					{
						if (dataWide.ExternalDataModem.ModemConnectionType_43350 != 1)
						{
							num = (short)1907884034;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = (dataWide.ExternalDataModem.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset);
						bool isUpdated = false;
						num = (short)1425997829;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return false;
					case 3:
					{
						bool isUpdated;
						if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.IsTimerRefreshedAndWiFiPasswordValidationSkept(isUpdated))
						{
							num = (short)2000486408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					}
					case 4:
						num = (short)1989804033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_138;
					case 6:
					{
						bool isUpdated = global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a(a_);
						num = (short)1644494848;
						short num4 = num;
						num = (short)849543175;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_CD;
					case 8:
						return false;
					}
					goto IL_7E;
				}
				IL_CD:
				num = (short)1513029635;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_138:
				if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h.Count == 0)
				{
					goto IL_CD;
				}
				num = (short)945356801;
				if (num != 0)
				{
				}
				num = (short)1114767366;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_21A:
			return global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b(a_);
			IL_7E:
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num = (short)603586560;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x001B8C90 File Offset: 0x001B6E90
		public static bool IsTimerRefreshedAndWiFiPasswordValidationSkept(bool isUpdated)
		{
			short num = (short)2023620609;
			if (num != 0)
			{
			}
			num = (short)1860698112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3D;
				case 1:
				{
					if (isUpdated)
					{
						return false;
					}
					num = (short)1987834696;
					short num3 = num;
					num = (short)1435366216;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3D;
					default:
						num = (short)442892288;
						if (num != 0)
						{
						}
						num = (short)2033516546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_128;
				case 3:
					num = (short)1900281857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5D;
				IL_3D:
				switch (0)
				{
				case 0:
				{
					IL_5D:
					num = (short)1378091008;
					short num4 = num;
					if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.f)
					{
						return false;
					}
					num = (short)813039619;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_128:
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.RefreshSessionTimer();
			return true;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x001B8DCC File Offset: 0x001B6FCC
		private static bool b(global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset A_0)
		{
			short num = (short)1109852161;
			if (num != 0)
			{
			}
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)1707081728;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					case 1:
						result = true;
						num = (short)1660747778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14A;
					case 3:
						num = (short)394526726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						if (configuredNetworksListInner != null)
						{
							num = (short)1932263427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)2078670855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
						if (configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value != 0)
						{
							num = (short)2055667713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_168;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1238171653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
						num = (short)230686724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_B7:
					num = (short)797442056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A:
					goto IL_B7;
				}
				IL_14A:
				IL_168:;
			}
			finally
			{
				num = (short)1569626376;
				short num3 = num;
				num = (short)1953732872;
				int num2;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)344326144;
					if (num != 0)
					{
					}
					num = (short)1579352065;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_21A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1E6;
						}
						continue;
					case 2:
						enumerator.Dispose();
						num = (short)1561657344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1E6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)668336130;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21A:;
			}
			num = (short)1830944768;
			short num4 = num;
			return result;
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x001B903C File Offset: 0x001B723C
		private static bool b(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset A_0)
		{
			short num = (short)2127495168;
			short num2 = num;
			num = (short)1029338180;
			short num3 = num;
			num = (short)1847292996;
			switch (num3 == num)
			{
			}
			num = (short)715849729;
			if (num != 0)
			{
			}
			num = (short)196083712;
			if (num != 0)
			{
			}
			return A_0.Count > 0;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x001B90F0 File Offset: 0x001B72F0
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset A_0)
		{
			short num = (short)1741422592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1507655680;
				short num3 = num;
				num = (short)500498433;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = A_0.GetEnumerator();
				bool result;
				try
				{
					num = (short)1029636099;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
							if (configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value != 0)
							{
								num = (short)973930503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1277493254;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
							num = (short)1012465672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_F0;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						case 4:
							goto IL_290;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection = configuredNetworksListInner.ConfiguredNetworksListInnerSection;
							num = (short)2111897600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)197459972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1238171657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
							if (configuredNetworksListInner != null)
							{
								num = (short)294715397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
							if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g.ContainsKey(configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value))
							{
								num = (short)2012282890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D9;
						}
						case 10:
							num = (short)1503330316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_D9;
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
							if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g[configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value] != configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value)
							{
								num = (short)1937309707;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_D4;
						IL_D9:
						result = true;
						num = (short)1547436034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_196:
						num = (short)1554513921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D4:
						goto IL_196;
					}
					IL_F0:
					return result;
					IL_290:
					return false;
				}
				finally
				{
					num = (short)286676157;
					short num4 = num;
					num = (short)200496317;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)227475456;
						if (num != 0)
						{
						}
						num = (short)1674182657;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_348;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_312;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)549191680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_312:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1881931778;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_348:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x001B9468 File Offset: 0x001B7668
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset A_0)
		{
			short num = (short)1220608000;
			switch (num)
			{
			default:
			{
				num = (short)2112225280;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = A_0.GetEnumerator();
				bool result;
				try
				{
					num = (short)1143537672;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1958915547;
						short num4 = num;
						num = (short)1616162267;
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2123890688;
							if (num != 0)
							{
							}
							switch (num3)
							{
							case 0:
								goto IL_25F;
							case 1:
								goto IL_18D;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection;
								if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h[dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value] != dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.Value)
								{
									num = (short)1532952586;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1353580544;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection;
								if (global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h.ContainsKey(dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value))
								{
									num = (short)1054081031;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_171;
							}
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = dataModemTableInner.DataModemTableInnerSection;
								num = (short)376438788;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								if (dataModemTableInner != null)
								{
									num = (short)400293893;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 7:
								num = (short)2141126658;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_EE;
								}
								continue;
							case 9:
								if (!enumerator.MoveNext())
								{
									num = (short)1130561539;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_12D;
							case 10:
								goto IL_171;
							}
							IL_F0:
							num = (short)1788542985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_EE:
							goto IL_F0;
							IL_171:
							result = true;
							num = (short)1951989761;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_12D:
						dataModemTableInner = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner);
						num = (short)1491271686;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_18D:
					return result;
					IL_25F:
					return false;
				}
				finally
				{
					num = (short)1128267777;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)993001474;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_296;
							}
							continue;
						case 2:
							goto IL_2F2;
						}
						IL_296:
						num = (short)1882718209;
						if (num != 0)
						{
						}
						if (enumerator == null)
						{
							break;
						}
						num = (short)1468006400;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2F2:;
				}
				return result;
			}
			}
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x001B9788 File Offset: 0x001B7988
		internal static bool OpenValidateDlg(global::System.Windows.Window parent)
		{
			short num = (short)55508995;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::System.Windows.Window window = new global::System.Windows.Window();
					global::SpecialFeatures.CloneWiFi.PageCloneWiFiView pageCloneWiFiView = new global::SpecialFeatures.CloneWiFi.PageCloneWiFiView();
					window.Title = global::CommonResources.AppResources.WiFi_Password_Validation;
					window.Content = pageCloneWiFiView;
					window.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
					window.SizeToContent = global::System.Windows.SizeToContent.WidthAndHeight;
					window.ResizeMode = global::System.Windows.ResizeMode.CanResize;
					window.Background = parent.Background;
					pageCloneWiFiView.LblCloneWiFiWarning.Visibility = global::System.Windows.Visibility.Hidden;
					global::AcpUI.Common.Utility.SetDirection(window);
					bool? flag = window.ShowDialog();
					bool flag2 = false;
					num = (short)1777139716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_111;
				case 2:
					return false;
				case 3:
					num = (short)663617537;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 4:
				{
					bool? flag;
					bool flag2;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)1892220930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a();
					num = (short)809631745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_5F:
				if (!global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.NeedValidation())
				{
					break;
				}
				num = (short)262032606;
				short num3 = num;
				num = (short)1087524062;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_111;
				default:
				{
					num = (short)1916534784;
					short num4 = num;
					num = (short)423821312;
					if (num != 0)
					{
					}
					num = (short)1789722624;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_111:
			return true;
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x001B9950 File Offset: 0x001B7B50
		private static void a()
		{
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
			if (dataWide == null)
			{
				short num = (short)780125261;
				short num2 = num;
				num = (short)274908237;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1987903489;
					if (num != 0)
					{
					}
					num = (short)2007826432;
					short num3 = num;
					num = (short)313655296;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g.Clear();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h.Clear();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b(dataWide);
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.a(dataWide);
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x001B9A38 File Offset: 0x001B7C38
		private static void b(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide A_0)
		{
			short num = (short)1677131776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1347223552;
						short num3 = num;
						num = (short)2043740161;
						if (num != 0)
						{
						}
						goto IL_302;
					}
					case 1:
						if (configuredNetworksListInnerRecset != null)
						{
							num = (short)993918976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						try
						{
							num = (short)690749447;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									if (configuredNetworksListInner != null)
									{
										num = (short)498532355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16D;
								}
								case 1:
									goto IL_16D;
								case 2:
									goto IL_292;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection = configuredNetworksListInner.ConfiguredNetworksListInnerSection;
									num = (short)1667825672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1911554050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)87818244;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
									goto IL_1B9;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
									global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g.Add(configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value, configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value);
									num = (short)1669332993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_11F;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
									if (configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value != 0)
									{
										num = (short)1856700422;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_16D;
								}
								}
								goto IL_11F;
								IL_16D:
								num = (short)711852037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11F:
								num = (short)1192916308;
								short num4 = num;
								num = (short)509310292;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_1B9:
									num = (short)1408172032;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)1993474048;
									if (num != 0)
									{
									}
									goto IL_16D;
								}
							}
							IL_292:
							return;
						}
						finally
						{
							num = (short)643956737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)228917250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C9;
									}
									continue;
								case 2:
									goto IL_2FF;
								}
								IL_2C9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1477902336;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2FF:;
						}
						goto IL_302;
					}
					goto IL_3B;
					IL_302:
					enumerator = configuredNetworksListInnerRecset.GetEnumerator();
					num = (short)1199964162;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3B:
				configuredNetworksListInnerRecset = (A_0.WIFI.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
				num = (short)1381957633;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x001B9D88 File Offset: 0x001B7F88
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide A_0)
		{
			short num = (short)700579840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset dataModemTableInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1594097668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)1955725317;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)802684934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner;
									num = (short)1647851166;
									short num3 = num;
									num = (short)881669790;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_F1;
									default:
										num = (short)2051473408;
										if (num != 0)
										{
										}
										num = (short)1963786242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = dataModemTableInner.DataModemTableInnerSection;
									global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h.Add(dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value, dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.Value);
									num = (short)1910702084;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
									if (dataModemTableInner != null)
									{
										num = (short)1480392705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_249;
								case 5:
									goto IL_F1;
								case 6:
									num = (short)774766595;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_11E;
								IL_F1:
								switch (0)
								{
								case 0:
									IL_11E:
									goto IL_1B1;
								}
								continue;
								IL_1B1:
								num = (short)909901824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_249:
							return;
						}
						finally
						{
							num = (short)701497345;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1520369666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_280;
									}
									continue;
								case 2:
									goto IL_2B8;
								}
								IL_280:
								if (enumerator == null)
								{
									break;
								}
								num = (short)980615168;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B8:;
						}
						goto IL_2BB;
					case 2:
						goto IL_2BB;
					case 3:
					{
						num = (short)1934819328;
						short num4 = num;
						num = (short)1003159553;
						if (num != 0)
						{
						}
						if (dataModemTableInnerRecset != null)
						{
							num = (short)2066546688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						if (A_0.ExternalDataModem.ModemConnectionType_43350 == 1)
						{
							num = (short)1310785538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_42;
					IL_2BB:
					enumerator = dataModemTableInnerRecset.GetEnumerator();
					num = (short)1540685825;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_42:
				dataModemTableInnerRecset = (A_0.ExternalDataModem.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset);
				num = (short)445054979;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x001BA0D8 File Offset: 0x001B82D8
		internal static void RefreshSessionTimer()
		{
			short num = (short)43319296;
			short num2 = num;
			num = (short)1940901653;
			short num3 = num;
			num = (short)676122389;
			switch (num3 == num)
			{
			}
			num = (short)1990656001;
			if (num != 0)
			{
			}
			num = (short)483917824;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.f = false;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b = 1;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e.Stop();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e.Start();
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x001BA1A0 File Offset: 0x001B83A0
		public static void ResetSessionTimer()
		{
			short num = (short)540934144;
			short num2 = num;
			num = (short)1286284658;
			short num3 = num;
			num = (short)1840784754;
			switch (num3 == num)
			{
			}
			num = (short)921108481;
			if (num != 0)
			{
			}
			num = (short)170852352;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.f = true;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b = 1;
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.g.Clear();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.h.Clear();
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.e.Stop();
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x001BA278 File Offset: 0x001B8478
		internal static void WaitNextValidate()
		{
			short num = (short)177995776;
			short num2 = num;
			num = (short)1031602177;
			if (num != 0)
			{
			}
			num = (short)2105313859;
			short num3 = num;
			num = (short)730696259;
			switch (num3 == num)
			{
			}
			num = (short)1267073024;
			if (num != 0)
			{
			}
			global::System.Threading.Thread.Sleep(1000 * global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b);
			global::SpecialFeatures.Clone_Configuration.Common.WiFiPasswordUtil.b *= 2;
		}

		// Token: 0x04000A2C RID: 2604
		private static global::System.Collections.Generic.List<string> a;

		// Token: 0x04000A2D RID: 2605
		private static int b;

		// Token: 0x04000A2E RID: 2606
		private const int c = 1000;

		// Token: 0x04000A2F RID: 2607
		private const int d = 900000;

		// Token: 0x04000A30 RID: 2608
		private static global::System.Timers.Timer e;

		// Token: 0x04000A31 RID: 2609
		private static bool f;

		// Token: 0x04000A32 RID: 2610
		private static readonly global::System.Collections.Generic.Dictionary<string, string> g;

		// Token: 0x04000A33 RID: 2611
		private static readonly global::System.Collections.Generic.Dictionary<string, string> h;

		// Token: 0x04000A34 RID: 2612
		private static global::SpecialFeatures.Clone_Configuration.Common.ClearAndRestorePassword i;
	}
}
