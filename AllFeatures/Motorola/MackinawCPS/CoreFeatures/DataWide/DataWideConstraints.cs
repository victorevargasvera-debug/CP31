using System;
using System.Collections.Generic;
using System.Net;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using CommonResources;
using ConstraintHelper;
using ConstraintHelper.Validators;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004C6 RID: 1222
	public static class DataWideConstraints
	{
		// Token: 0x0600A0A3 RID: 41123 RVA: 0x0095BF40 File Offset: 0x0095A140
		internal static bool ConListinfoRadWideOtapIndicationsIsAlertDisplay(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1846957194;
			short num2 = num;
			num = (short)312104074;
			switch (num2 == num)
			{
			}
			num = (short)224329729;
			if (num != 0)
			{
			}
			num = (short)747765760;
			if (num != 0)
			{
			}
			num = (short)2008809472;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.POP25).DataWidePOP25OTAPIndications_A8670.Value == 3;
		}

		// Token: 0x0600A0A4 RID: 41124 RVA: 0x0095C000 File Offset: 0x0095A200
		internal static bool ConIsTextLengthValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<string> dataWideQuickTextMessageListQuickTextMessage_A;
			for (;;)
			{
				short num = (short)777125888;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				for (;;)
				{
					IL_35:
					int num3;
					switch (num3)
					{
					case 0:
						return false;
					case 1:
						goto IL_14E;
					case 2:
						if (dataWideQuickTextMessageListQuickTextMessage_A.Value == null)
						{
							num = (short)1462370304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1797324803;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (dataWideQuickTextMessageListQuickTextMessage_A.Value.Length > 0)
						{
							num = (short)50200577;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				IL_4B:
				dataWideQuickTextMessageListQuickTextMessage_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInnerSection).DataWideQuickTextMessageListQuickTextMessage_A8810;
				num = (short)1692473720;
				short num4 = num;
				num = (short)1241323896;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1294139393;
					if (num != 0)
					{
					}
					num = (short)768409600;
					if (num != 0)
					{
					}
					num = (short)1224409090;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_35;
				}
				}
			}
			return false;
			IL_14E:
			return dataWideQuickTextMessageListQuickTextMessage_A.Value.Length <= 50;
		}

		// Token: 0x0600A0A5 RID: 41125 RVA: 0x0095C160 File Offset: 0x0095A360
		internal static bool conReturnFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1282922858;
			short num2 = num;
			num = (short)466737514;
			switch (num2 == num)
			{
			}
			num = (short)1367801857;
			if (num != 0)
			{
			}
			num = (short)863174656;
			if (num != 0)
			{
			}
			num = (short)1301151744;
			short num3 = num;
			return false;
		}

		// Token: 0x0600A0A6 RID: 41126 RVA: 0x0095C20C File Offset: 0x0095A40C
		public static bool conEnsureSameSubnetBetweenDCEAndDTE(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1232797696;
			switch (num)
			{
			default:
			{
				num = (short)96600077;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					switch (num2)
					{
					case 0:
						if (addressBytes[12] >= 192)
						{
							num = (short)952631326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)1030881288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (addressBytes[12] <= 127)
						{
							num = (short)349306897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)519503882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1867317250;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)840826881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_400;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_333;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
									{
										num = (short)1926889478;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)453050368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1336606723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_3A5;
								case 6:
									result = false;
									num = (short)1758330885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3AA:
								num = (short)1961426948;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_333:
								goto IL_3AA;
							}
							IL_3A5:
							return result;
							IL_400:
							goto IL_4F9;
						}
						finally
						{
							num = (short)1789526016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_437;
									}
									continue;
								case 1:
									goto IL_46E;
								case 2:
									enumerator.Dispose();
									num = (short)833224705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_437:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2105868290;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46E:;
						}
						goto IL_471;
					case 4:
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)1222443035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
					{
						num = (short)1908697767;
						short num3 = num;
						num = (short)1211198119;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4F9;
						default:
							goto IL_1E8;
						}
						break;
					}
					case 6:
						return false;
					case 7:
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)699727881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						num = (short)2009268225;
						if (num != 0)
						{
						}
						num = (short)1410531351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_58D;
					case 10:
						if (addressBytes[12] >= 128)
						{
							num = (short)1558446109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B4;
					case 11:
						return true;
					case 12:
						if (addressBytes[12] <= 191)
						{
							num = (short)1058209814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B4;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					case 14:
						return false;
					case 15:
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralPeerIPAddress1_A8524.Value)))
						{
							num = (short)1366491142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)688259088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (general.DataWideGeneralSubscriberIPAddress1_A9222.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
						{
							num = (short)341770268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
						num = (short)309133315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1703739399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (general.DataWideGeneralPeerIPAddress1_A8524.Value == 0L)
						{
							num = (short)2137784334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)549584911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_471;
					case 20:
						num = (short)1360199684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (addressBytes[13] == addressBytes2[13])
						{
							num = (short)33226771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						num = (short)731054081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (addressBytes[13] == addressBytes2[13])
						{
							num = (short)1270939653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
						return true;
					case 25:
						if (addressBytes[12] <= 223)
						{
							num = (short)1848967188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						if (addressBytes[14] == addressBytes2[14])
						{
							num = (short)1016594456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						num = (short)624492565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return false;
					case 29:
						num = (short)1322123276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1434779673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C0:
					if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
					{
						num = (short)473104395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
					num = (short)743178258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_471:
					num = (short)1831338010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B4:
					num = (short)1268580352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F9:
					addressBytes = general.DataWideGeneralSubscriberIPAddress1_A9222.AddressBytes;
					addressBytes2 = general.DataWideGeneralPeerIPAddress1_A8524.AddressBytes;
					num = (short)1684733954;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1E8:
				num = (short)1243152384;
				if (num != 0)
				{
				}
				return true;
				IL_58D:
				num = (short)1204813824;
				short num4 = num;
				return true;
			}
			}
		}

		// Token: 0x0600A0A7 RID: 41127 RVA: 0x0095C96C File Offset: 0x0095AB6C
		public static void conSetDataPrfSubIpValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
				try
				{
					num = (short)1493434370;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						switch (num2)
						{
						case 0:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
							{
								num = (short)1942683654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							goto IL_18D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_68;
							}
							continue;
						case 4:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
							{
								num = (short)333119493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_138;
						case 5:
							num = (short)1212350464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_138;
						case 7:
							num = (short)1800470529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)385482759;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
							num = (short)1915551748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B9:
						num = (short)1988034568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_68:
						goto IL_B9;
						IL_138:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157, general.DataWideGeneralSubscriberIPAddress1_A9222.Value));
						num = (short)1108279299;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_18D:;
				}
				finally
				{
					num = (short)1820000256;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1BF;
							}
							continue;
						case 1:
							goto IL_1F4;
						case 2:
							enumerator.Dispose();
							num = (short)248119297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1BF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2090270722;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1F4:;
				}
				num = (short)1186069395;
				short num3 = num;
				num = (short)202374035;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_22B;
				}
			}
			IL_22B:
			num = (short)1914109953;
			if (num != 0)
			{
			}
			num = (short)1243611136;
			short num4 = num;
			num = (short)1907490816;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A0A8 RID: 41128 RVA: 0x0095CC24 File Offset: 0x0095AE24
		public static void conSetDataPrfPeerIpValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)1438384129;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
				try
				{
					num = (short)1570570242;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						switch (num2)
						{
						case 0:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
							{
								num = (short)1187446790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							goto IL_1B3;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_8F;
							}
							continue;
						case 4:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
							{
								num = (short)1562968069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15E;
						case 5:
							num = (short)530841600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_15E;
						case 7:
							num = (short)1365901313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)923074567;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
							num = (short)1854078980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DE:
						num = (short)1525415944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8F:
						goto IL_DE;
						IL_15E:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523, general.DataWideGeneralPeerIPAddress1_A8524.Value));
						num = (short)171442179;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B3:;
				}
				finally
				{
					num = (short)1243676672;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1E6;
							}
							continue;
						case 1:
							goto IL_219;
						case 2:
							enumerator.Dispose();
							num = (short)1346895873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1009713154;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_219:;
				}
				num = (short)1983162465;
				short num3 = num;
				num = (short)1223927905;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_253;
				}
			}
			IL_253:
			num = (short)1316749312;
			short num4 = num;
			num = (short)1473576960;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A0A9 RID: 41129 RVA: 0x0095CEE0 File Offset: 0x0095B0E0
		public static void conSetDataPrfPeerIpAssignTypeValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
				try
				{
					num = (short)1882128386;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						switch (num2)
						{
						case 0:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
							{
								num = (short)934936582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							goto IL_18F;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_66;
							}
							continue;
						case 4:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
							{
								num = (short)410910725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_139;
						case 5:
							num = (short)387383296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_139;
						case 7:
							num = (short)1738670081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)392560647;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
							num = (short)816709636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B6:
						num = (short)473694216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_66:
						goto IL_B6;
						IL_139:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataProfiles.General.DataWideGeneralPeerIPAddressAssignmentType_A22263, general.DataWideGeneralPeerIPAddressAssignmentType1_A22376.Value));
						num = (short)1221787651;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_18F:;
				}
				finally
				{
					num = (short)1130954752;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)667156481;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_1ED;
							}
							continue;
						case 1:
							goto IL_220;
						case 2:
							enumerator.Dispose();
							num = (short)1370619905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1ED:
						if (enumerator == null)
						{
							break;
						}
						num = (short)935198722;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_220:;
				}
				num = (short)1790115840;
				short num3 = num;
				num = (short)318291374;
				short num4 = num;
				num = (short)1130413486;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_281;
				}
			}
			IL_281:
			num = (short)491651072;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A0AA RID: 41130 RVA: 0x0095D1A4 File Offset: 0x0095B3A4
		internal static bool conStaticNatIPAddressValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpIPAddressField dataWideNATListStaticNATIPAddress_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dataWideNATListStaticNATIPAddress_A.Value == 0L)
					{
						num2 = (short)244776961;
						if (num2 != 0)
						{
						}
						num2 = (short)422248451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1303052289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataWideNATListStaticNATIPAddress_A.Value)))
					{
						num2 = (short)1387331586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_119;
				case 2:
					return false;
				case 3:
				{
					num2 = (short)1832050361;
					short num3 = num2;
					num2 = (short)529391289;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_101;
					}
					break;
				}
				}
				goto IL_20;
			}
			return false;
			IL_101:
			num2 = (short)1928986624;
			if (num2 != 0)
			{
			}
			return false;
			IL_119:
			num2 = (short)1005846528;
			short num4 = num2;
			return true;
			IL_20:
			dataWideNATListStaticNATIPAddress_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListStaticNATIPAddress_A9181;
			num2 = (short)1416101888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0AB RID: 41131 RVA: 0x0095D2F4 File Offset: 0x0095B4F4
		public static bool conSubIpAddress1Valid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)373686272;
			switch (num)
			{
			default:
			{
				num = (short)1823408130;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralSubscriberIPAddress1_A9222.Value)))
						{
							num = (short)1717764097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
						num = (short)1022361604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_40D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						return true;
					case 4:
						goto IL_392;
					case 5:
						return false;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
						if (general.DataWideGeneralSubscriberIPAddress1_A9222.Value == 0L)
						{
							num = (short)2112946181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)423821312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5F:
					if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
					{
						num = (short)217055235;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
						num = (short)2078605318;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return true;
				IL_392:
				num = (short)174063616;
				short num3 = num;
				bool result;
				try
				{
					num = (short)90308608;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D6;
							}
							continue;
						case 1:
							goto IL_112;
						case 2:
							goto IL_29F;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
							{
								num = (short)294715393;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)858783750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
							num = (short)831848453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
							{
								goto IL_112;
							}
							num = (short)1280619399;
							short num4 = num;
							num = (short)944944007;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1623457792;
								if (num != 0)
								{
								}
								num = (short)1769930760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							num = (short)12779522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_12D;
						case 8:
							num = (short)1280770058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1316159491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.Value != general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
							{
								num = (short)1852440585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_112;
						}
						}
						IL_D8:
						num = (short)585433092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D6:
						goto IL_D8;
						IL_112:
						result = false;
						num = (short)234160135;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12D:
					goto IL_414;
					IL_29F:
					return true;
				}
				finally
				{
					num = (short)1506410496;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2D7;
							}
							continue;
						case 1:
							goto IL_30D;
						case 2:
							enumerator.Dispose();
							num = (short)1829240833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2D7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)295632898;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_30D:;
				}
				return false;
				IL_414:
				num = (short)367394817;
				if (num != 0)
				{
				}
				return result;
				IL_40D:
				return false;
			}
			}
		}

		// Token: 0x0600A0AC RID: 41132 RVA: 0x0095D758 File Offset: 0x0095B958
		internal static bool conLanPortNotZero(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value == 0)
			{
				num = (short)2107965441;
				if (num != 0)
				{
				}
				num = (short)1812843159;
				short num2 = num;
				num = (short)1913440919;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)216006656;
					if (num != 0)
					{
					}
					break;
				}
				return false;
			}
			num = (short)789708800;
			short num3 = num;
			return true;
		}

		// Token: 0x0600A0AD RID: 41133 RVA: 0x0095D818 File Offset: 0x0095BA18
		internal static bool conWanPortNotZero(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)71696385;
			if (num != 0)
			{
			}
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == 0)
			{
				num = (short)1075015574;
				short num2 = num;
				num = (short)263745430;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)3932160;
					if (num != 0)
					{
					}
					break;
				}
				return false;
			}
			num = (short)1155858432;
			short num3 = num;
			return true;
		}

		// Token: 0x0600A0AE RID: 41134 RVA: 0x0095D8DC File Offset: 0x0095BADC
		public static bool ConBluetoothEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)117649868;
			short num2 = num;
			num = (short)1776693708;
			switch (num2 == num)
			{
			}
			num = (short)1687617536;
			short num3 = num;
			num = (short)1014497280;
			if (num != 0)
			{
			}
			num = (short)1063780353;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x0095D9A8 File Offset: 0x0095BBA8
		public static bool ConDataWideBTDUNPeerIPAddressesIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1882670584;
			short num2 = num;
			num = (short)249054712;
			switch (num2 == num)
			{
			}
			num = (short)1545142272;
			short num3 = num;
			num = (short)337641473;
			if (num != 0)
			{
			}
			num = (short)1166344192;
			if (num != 0)
			{
			}
			bool value = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value == 0 && value;
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x0095DA8C File Offset: 0x0095BC8C
		public static bool ConDataWideBTDUNSUIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)586022924;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
				switch (num2)
				{
				case 0:
				{
					num = (short)406978498;
					short num3 = num;
					num = (short)2126315458;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_480;
					default:
						goto IL_2CE;
					}
					break;
				}
				case 1:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						num = (short)1737687060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45A;
				}
				case 2:
					num = (short)1322844176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (general.DataWideGeneralBTDUNSUIPAddress_A41120.Value == 0L)
					{
						num = (short)760414232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1990459400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (general.DataWideGeneralBTDUNSUIPAddress_A41120.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
					{
						num = (short)1297809427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1626865675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return true;
				case 6:
					num = (short)1647640583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)1819869197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 8:
				{
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralBTDUNSUIPAddress_A41120.Value)))
					{
						num = (short)119078942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] addressBytes = general.DataWideGeneralBTDUNSUIPAddress_A41120.AddressBytes;
					byte[] addressBytes2 = general.DataWideGeneralBTDUNPeerIPAddress_A41123.AddressBytes;
					num = (short)64749586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						goto IL_480;
					}
					return false;
				}
				case 10:
					return true;
				case 11:
					if (general.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value == 0)
					{
						num = (short)1318912023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					continue;
				case 13:
					return true;
				case 14:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)776863776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 15:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num = (short)1304297507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45A;
				}
				case 16:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num = (short)2015952922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 17:
					return true;
				case 18:
					if (general.DataWideGeneralBTDUNSUIPAddress_A41120.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
					{
						num = (short)751435776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)586874884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					return false;
				case 20:
					num = (short)1785266191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)266207266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 22:
					num = (short)303890457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)1254227995;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					return false;
				case 25:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[14] == addressBytes2[14])
					{
						num = (short)214237194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 26:
					num = (short)13238293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					if (general.DataWideGeneralBTDUNSUIPAddress_A41120.Value == general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value)
					{
						num = (short)675151903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)315097116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num = (short)1339949062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1497759745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 29:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num = (short)632291350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 30:
					goto IL_210;
				case 31:
					return false;
				case 32:
					num = (short)1716125729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num = (short)247005189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 34:
					num = (short)1280507933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)1737883662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B5:
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)485031953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
				num = (short)1871904771;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_45A:
				num = (short)640876553;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_480:
				num = (short)1334181890;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_210:
			num = (short)764280833;
			if (num != 0)
			{
			}
			return false;
			IL_2CE:
			num = (short)1229062144;
			if (num != 0)
			{
			}
			num = (short)1476460544;
			short num4 = num;
			return false;
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x0095E0D8 File Offset: 0x0095C2D8
		public static bool ConDataWideBTDUNPeerIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)152436748;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)274006043;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num = (short)1775829012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1653735435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					return false;
				case 3:
				{
					num = (short)1143799809;
					if (num != 0)
					{
					}
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num = (short)1701773336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 4:
				{
					if (global::ConstraintHelper.UtilityMack.isInCxfEditingMode)
					{
						num = (short)1129578515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
					num = (short)1490026517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					return true;
				case 6:
					num = (short)399179794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)1885339661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 8:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)1007878174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 9:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					if (general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
					{
						num = (short)1783103490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)882507791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					return true;
				case 11:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						num = (short)881393687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_427;
				}
				case 12:
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					continue;
				case 13:
					return true;
				case 14:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num = (short)1442709536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_427;
				}
				case 15:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					if (general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
					{
						num = (short)815398947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1838284801;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value)))
					{
						num = (short)2119237658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)80216093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 17:
					num = (short)40566788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num = (short)2109865984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 19:
					goto IL_343;
				case 20:
					num = (short)618856455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					if (general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value == 0L)
					{
						num = (short)1329332258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)107610128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					return false;
				case 23:
					num = (short)174587918;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)2113011737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[14] == addressBytes[14])
					{
						num = (short)1053949962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 26:
					return false;
				case 27:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)919404575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 28:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						num = (short)1327562758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 29:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
					if (general.DataWideGeneralBTDUNSUIPAddress_A41120.Value == general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value)
					{
						num = (short)1308426262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] addressBytes2 = general.DataWideGeneralBTDUNSUIPAddress_A41120.AddressBytes;
					byte[] addressBytes = general.DataWideGeneralBTDUNPeerIPAddress_A41123.AddressBytes;
					num = (short)1053949961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					num = (short)474742817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_2FF;
				case 32:
				{
					num = (short)1386702396;
					short num3 = num;
					num = (short)976840252;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2FF;
					default:
						num = (short)2117730304;
						if (num != 0)
						{
						}
						num = (short)1833435144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 33:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num = (short)1298399237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 34:
					goto IL_1AD;
				case 35:
					return false;
				}
				IL_B4:
				if (!global::ConstraintHelper.UtilityMack.bOpenFromRMC)
				{
					num = (short)1556348945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_2FF:
				num = (short)1967783939;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_427:
				num = (short)1581645852;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_1AD:
			num = (short)1496121344;
			short num4 = num;
			return false;
			IL_343:
			return true;
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x0095E71C File Offset: 0x0095C91C
		public static void ConSetDataProBTDUNSUIPADDValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1364983809;
			if (num != 0)
			{
			}
			num = (short)2097217536;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
			try
			{
				num = (short)882704390;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num3)
					{
					case 0:
						goto IL_22F;
					case 1:
						goto IL_1AB;
					case 2:
					{
						if (enumerator.MoveNext())
						{
							dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
							num = (short)1372323847;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)336855612;
						short num4 = num;
						num = (short)8979004;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AB;
						default:
							num = (short)412286976;
							if (num != 0)
							{
							}
							num = (short)1461518341;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1526726657;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1384054784;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_B6;
						}
						continue;
					case 7:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
						{
							num = (short)1261895684;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					case 8:
						goto IL_1DB;
					}
					IL_108:
					num = (short)1157300226;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
					{
						num = (short)484048904;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B6:
					goto IL_108;
					IL_1DB:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126, general.DataWideGeneralBTDUNSUIPAddress_A41120.Value));
					num = (short)353042435;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_22F:;
			}
			finally
			{
				num = (short)863240193;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)57475074;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_261;
						}
						continue;
					case 2:
						goto IL_295;
					}
					IL_261:
					if (enumerator == null)
					{
						break;
					}
					num = (short)907149312;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_295:;
			}
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x0095E9E0 File Offset: 0x0095CBE0
		public static void ConSetDataProBTDUNPeerIPADDValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1160445953;
			if (num != 0)
			{
			}
			num = (short)526712832;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
			try
			{
				num = (short)47906822;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num3)
					{
					case 0:
						goto IL_22D;
					case 1:
						goto IL_1A8;
					case 2:
					{
						if (enumerator.MoveNext())
						{
							dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
							num = (short)1422000135;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1484899749;
						short num4 = num;
						num = (short)1058784677;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A8;
						default:
							num = (short)1020133376;
							if (num != 0)
							{
							}
							num = (short)891944965;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1363214337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1464467456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					case 7:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
						{
							num = (short)92274692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D7;
					case 8:
						goto IL_1D7;
					}
					IL_109:
					num = (short)538050562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
					{
						num = (short)199622664;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B7:
					goto IL_109;
					IL_1D7:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127, general.DataWideGeneralBTDUNPeerIPAddress_A41123.Value));
					num = (short)589234179;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_22D:;
			}
			finally
			{
				num = (short)1007747073;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1808334850;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_25F;
						}
						continue;
					case 2:
						goto IL_293;
					}
					IL_25F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)278921216;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_293:;
			}
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x0095ECA0 File Offset: 0x0095CEA0
		public static void ConSetDataProBTDUNPeerIPADDAssignTypeValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)819921064;
			short num2 = num;
			num = (short)717226152;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1231618048;
				short num3 = num;
				break;
			}
			}
			num = (short)1983578113;
			if (num != 0)
			{
			}
			num = (short)1895759872;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
			try
			{
				num = (short)1661730821;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num4)
					{
					case 0:
						goto IL_1CE;
					case 1:
						num = (short)1702363144;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_223;
					case 4:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
						{
							num = (short)726138881;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CE;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_101;
						}
						continue;
					case 6:
						if (!enumerator.MoveNext())
						{
							num = (short)1641218055;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						dataProfiles = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
						num = (short)1383464964;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)130613250;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
						{
							num = (short)1599012864;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_14F:
					num = (short)1189806086;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_101:
					goto IL_14F;
					IL_1CE:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128, general.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value));
					num = (short)1087897603;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_223:;
			}
			finally
			{
				num = (short)2045771776;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_255;
						}
						continue;
					case 1:
						goto IL_28A;
					case 2:
						enumerator.Dispose();
						num = (short)449314817;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_255:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1693450242;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_28A:;
			}
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x0095EF58 File Offset: 0x0095D158
		public static bool conNonEditableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1321453043;
			short num2 = num;
			num = (short)1427228147;
			switch (num2 == num)
			{
			}
			num = (short)1942487041;
			if (num != 0)
			{
			}
			num = (short)1464205312;
			if (num != 0)
			{
			}
			num = (short)2082537472;
			short num3 = num;
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x0095F008 File Offset: 0x0095D208
		internal static bool ConDVRSHardWareIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2074551834;
			short num2 = num;
			num = (short)540616218;
			switch (num2 == num)
			{
			}
			num = (short)1594425344;
			if (num != 0)
			{
			}
			num = (short)1459093505;
			if (num != 0)
			{
			}
			num = (short)605880320;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x0095F0CC File Offset: 0x0095D2CC
		public static bool ConDataWideDVRSSUIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num2 = (short)1065484309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)716046344;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return false;
				case 2:
					num2 = (short)904986651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralMobileSubIPAddress_A41819.Value)))
					{
						num2 = (short)1444413454;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte[] addressBytes = general.DataWideGeneralMobileSubIPAddress_A41819.AddressBytes;
					byte[] addressBytes2 = general.DataWideGeneralDVRIPAddress_A41818.AddressBytes;
					num2 = (short)1349521165;
					short num3 = num2;
					num2 = (short)996085517;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)687996928;
						if (num2 != 0)
						{
						}
						num2 = (short)79298577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)1308753933;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1258160135;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						num2 = (short)698417182;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 7:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num2 = (short)361234456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_568;
				}
				case 8:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						num2 = (short)1560346629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_568;
				}
				case 9:
					return true;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num2 = (short)1727397890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 13:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num2 = (short)116850710;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 14:
					goto IL_563;
				case 15:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num2 = (short)357171225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 16:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num2 = (short)225181700;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 17:
					if (general.DataWideGeneralMobileSubIPAddress_A41819.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
					{
						num2 = (short)464125963;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)733478935;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					return true;
				case 19:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num2 = (short)361758751;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 20:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num2 = (short)2046099465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 21:
					num2 = (short)1178796052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_1D2;
				case 23:
					if (general.DataWideGeneralMobileSubIPAddress_A41819.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
					{
						num2 = (short)498532378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)405078045;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)1712914448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					num2 = (short)33423372;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					return false;
				case 27:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[14] == addressBytes2[14])
					{
						num2 = (short)2107965458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 28:
					if (general.DataWideGeneralMobileSubIPAddress_A41819.Value == 0L)
					{
						num2 = (short)677904384;
						short num4 = num2;
						num2 = (short)1255276554;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1875378179;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (general.DataWideGeneralMobileSubIPAddress_A41819.Value == general.DataWideGeneralDVRIPAddress_A41818.Value)
					{
						num2 = (short)312934401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)793444352;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)681836563;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1426456591;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_90;
				IL_568:
				num2 = (short)608305158;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_1D2:
			num2 = (short)49152001;
			if (num2 != 0)
			{
			}
			return true;
			IL_563:
			return false;
			IL_90:
			global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
			num2 = (short)1836908572;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x0095F684 File Offset: 0x0095D884
		public static bool ConDataWideDVRSPeerIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num2 = (short)1118830613;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)313851912;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return false;
				case 2:
					num2 = (short)214106139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataWideGeneralDVRIPAddress_A41818.Value)))
					{
						num2 = (short)423100430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					byte[] addressBytes2 = general.DataWideGeneralMobileSubIPAddress_A41819.AddressBytes;
					byte[] addressBytes = general.DataWideGeneralDVRIPAddress_A41818.AddressBytes;
					num2 = (short)33112445;
					short num3 = num2;
					num2 = (short)533676413;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)1383923712;
						if (num2 != 0)
						{
						}
						num2 = (short)2113470481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					num2 = (short)70713357;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)885456903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						num2 = (short)1847132190;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 7:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num2 = (short)609157144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_56A;
				}
				case 8:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						num2 = (short)1780416517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_56A;
				}
				case 9:
					return true;
				case 10:
					return false;
				case 11:
					return false;
				case 12:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num2 = (short)986513410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 13:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num2 = (short)1835335702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 14:
					goto IL_565;
				case 15:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num2 = (short)1069809689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 16:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num2 = (short)1824653316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 17:
					if (general.DataWideGeneralDVRIPAddress_A41818.Value == general.DataWideGeneralSubscriberIPAddress1_A9222.Value)
					{
						num2 = (short)390791179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1809055767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					return true;
				case 19:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num2 = (short)1162543135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 20:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num2 = (short)1219952649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 21:
					num2 = (short)1360723988;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					return true;
				case 23:
					if (general.DataWideGeneralDVRIPAddress_A41818.Value == general.DataWideGeneralPeerIPAddress1_A8524.Value)
					{
						num2 = (short)1712783386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)59244573;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)503578640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					num2 = (short)1344667660;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					return false;
				case 27:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[14] == addressBytes[14])
					{
						num2 = (short)1258029074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 28:
				{
					num2 = (short)1444282369;
					if (num2 != 0)
					{
					}
					num2 = (short)878575616;
					short num4 = num2;
					if (general.DataWideGeneralDVRIPAddress_A41818.Value == 0L)
					{
						num2 = (short)872873994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1139671043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 29:
					if (general.DataWideGeneralMobileSubIPAddress_A41819.Value == general.DataWideGeneralDVRIPAddress_A41818.Value)
					{
						num2 = (short)1189412865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)95223808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)872153107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)2012807183;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_90;
				IL_56A:
				num2 = (short)43581446;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_565:
			return false;
			IL_90:
			global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
			num2 = (short)519110684;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x0095FC3C File Offset: 0x0095DE3C
		public static bool ConInvisibleWhenOpenfromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)212426746;
			short num2 = num;
			num = (short)931815418;
			switch (num2 == num)
			{
			}
			num = (short)10420224;
			if (num != 0)
			{
			}
			num = (short)2490369;
			if (num != 0)
			{
			}
			num = (short)467533824;
			short num3 = num;
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x0095FCEC File Offset: 0x0095DEEC
		internal static bool ConZeroIsInvalidForNonEnhData(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)275644416;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					return false;
				case 2:
					num = (short)913965059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)778108928;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					if (!radioInformation.Labtool.EnhancedDataOperation_42024.Value)
					{
						num = (short)274726913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				}
				IL_35:
				num = (short)1706606683;
				short num4 = num;
				num = (short)1241890907;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)1441398785;
					if (num != 0)
					{
					}
					num = (short)121765888;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration dataProtocolConfiguration = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					if (dataProtocolConfiguration.DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.Value != 0)
					{
						return true;
					}
					num = (short)20250626;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return false;
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x0095FE54 File Offset: 0x0095E054
		internal static bool ConInternalRadioSubnetValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			byte[] addressBytes;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)118797539;
					short num3 = num2;
					num2 = (short)892384483;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_111;
					default:
					{
						num2 = (short)1721434112;
						short num4 = num2;
						num2 = (short)2096824320;
						if (num2 != 0)
						{
						}
						if (addressBytes[3] >= 193)
						{
							num2 = (short)2113208322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_134;
					}
					}
					break;
				}
				case 1:
					goto IL_132;
				case 2:
					num2 = (short)1062993923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_111;
				}
				goto IL_20;
				IL_111:
				if (addressBytes[3] > 207)
				{
					goto IL_134;
				}
				num2 = (short)1799487489;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_132:
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
			return global::ConstraintHelper.UtilityMack.CheckIPConflictionWithAllIPs(general.DataWideGeneralInternalRadioSubnet_A42073);
			IL_134:
			num2 = (short)2140667905;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
			addressBytes = new global::System.Net.IPAddress(general.DataWideGeneralInternalRadioSubnet_A42073.Value).GetAddressBytes();
			num2 = (short)860618752;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0BC RID: 41148 RVA: 0x0095FFC0 File Offset: 0x0095E1C0
		internal static bool ConP25LocReportAppAndEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1038190162;
			short num2 = num;
			num = (short)1382450770;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)294649856;
				short num3 = num;
				num = (short)2098987008;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration portConfiguration = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration;
				if (portConfiguration.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
				{
					return portConfiguration.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.Value;
				}
				break;
			}
			}
			num = (short)586416129;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x009600A4 File Offset: 0x0095E2A4
		internal static bool ConP25LocReportValueUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1466957824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D2;
				}
				int value;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						num = (short)1556348951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)2124546082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)266010631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1032519681;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8F0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_80D;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfLTEBackupPTTGatewayPort_A43618.Value == value)
									{
										num = (short)564133888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.Features.DatProFeaturesDestinationPort_A20544.Value != value)
									{
										num = (short)841940999;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8F0;
								}
								case 4:
									num = (short)61145096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_90C;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2061631492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1024196611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1694695426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_929;
								}
								IL_8B0:
								num = (short)187170822;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_80D:
								goto IL_8B0;
								IL_8F0:
								result = false;
								num = (short)744292357;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_90C:
							return result;
							IL_929:
							goto IL_667;
						}
						finally
						{
							num = (short)30277633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1912078338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_961;
									}
									continue;
								case 2:
									goto IL_99B;
								}
								IL_961:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1756168192;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_99B:;
						}
						goto IL_99E;
					case 5:
						if (value != 4007)
						{
							num = (short)2116681740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						num = (short)721092638;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)2129592321;
						if (num != 0)
						{
						}
						if (value != 4002)
						{
							num = (short)1045495839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (dataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.Value == value)
						{
							num = (short)1952186368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5C;
					case 9:
						num = (short)145424389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_46D;
					case 11:
						if (value != 4004)
						{
							num = (short)997982222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						num = (short)2016083990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (value != 4000)
						{
							num = (short)1701642246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
					{
						num = (short)1563426816;
						short num3 = num;
						num = (short)700973074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (value != 4003)
						{
							num = (short)661717028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 16:
						if (dataProfilesRecset != null)
						{
							num = (short)22020117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_667;
					case 17:
						if (value != 162)
						{
							num = (short)1998127141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						if (value != 4005)
						{
							num = (short)1615331329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 19:
						num = (short)1176829969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (secureKMFProfileRecset != null)
						{
							num = (short)1357381656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)1504378884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (value != 4011)
						{
							num = (short)919994395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
						if (value != 4006)
						{
							num = (short)1714356233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)548012071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (value != 4012)
						{
							num = (short)56033282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						if (value != 161)
						{
							num = (short)653131795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						goto IL_99E;
					case 28:
						if (value == 49223)
						{
							num = (short)1042677789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						num = (short)60358688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return false;
					case 30:
						if (value != 4001)
						{
							num = (short)1899823107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 31:
						num = (short)221577231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (dataWide != null)
						{
							num = (short)1173094410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					case 33:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = natlistInnerRecset.GetEnumerator();
						num = (short)114819110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (value != 4050)
						{
							num = (short)147324963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 35:
						num = (short)742326300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)1274019851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)418054157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						try
						{
							num = (short)1842806785;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)650903560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_AC0;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)465240064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)enumerator.Current;
									num = (short)1449132035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value != value)
									{
										num = (short)1804533767;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BB0;
								}
								case 4:
									goto IL_BB0;
								case 5:
									goto IL_BCC;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == value)
									{
										num = (short)423100420;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1045561350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_BEA;
								}
								IL_B22:
								num = (short)998506498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AC0:
								goto IL_B22;
								IL_BB0:
								result = false;
								num = (short)779485189;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BCC:
							return result;
							IL_BEA:
							goto IL_125;
						}
						finally
						{
							num = (short)2060189697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1840316418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C22;
									}
									continue;
								case 2:
									goto IL_C59;
								}
								IL_C22:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1418264576;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C59:;
						}
						goto IL_C5C;
					case 39:
						try
						{
							num = (short)1992818689;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1756758024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_290;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1985740800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1944125446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == value)
									{
										num = (short)106823687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1015742467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_38B;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != value)
									{
										num = (short)1456472068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_36E;
								}
								case 7:
									goto IL_36E;
								case 8:
									goto IL_3A9;
								}
								IL_2D8:
								num = (short)732299266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_290:
								goto IL_2D8;
								IL_36E:
								result = false;
								num = (short)810418181;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38B:
							return result;
							IL_3A9:
							return true;
						}
						finally
						{
							for (;;)
							{
								IL_3AE:
								num = (short)624885761;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1572866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_3E1;
										}
										continue;
									case 2:
										goto IL_46A;
									}
									IL_3E1:
									if (enumerator == null)
									{
										goto IL_46C;
									}
									num = (short)1281252984;
									short num4 = num;
									num = (short)484007544;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3AE;
									default:
										num = (short)706740224;
										if (num != 0)
										{
										}
										num = (short)1048969216;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
							}
							IL_46A:
							IL_46C:;
						}
						goto IL_46D;
					case 40:
						if (natlistInnerRecset != null)
						{
							num = (short)1181351969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125;
					}
					goto IL_D2;
					IL_125:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)1568210960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46D:
					num = (short)984809480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_667:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)454623252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99E:
					num = (short)1224802329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C5C:
					natlistInnerRecset = (dataWide.NATList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset);
					num = (short)751370280;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_D2:
				value = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration).DataWideP25LocationReportingUDPPort_42413.Value;
				num = (short)1780678682;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x00960DAC File Offset: 0x0095EFAC
		internal static bool ConWiFiIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)262233300;
			short num2 = num;
			num = (short)1988975828;
			switch (num2 == num)
			{
			}
			num = (short)703004672;
			if (num != 0)
			{
			}
			num = (short)1099956224;
			short num3 = num;
			num = (short)86179841;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).WIFI.DataWideWIFIEnable_42506.Value;
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x00960E7C File Offset: 0x0095F07C
		internal static bool ConWiFiAllowUserControlIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1277469425;
			short num2 = num;
			num = (short)1803854577;
			switch (num2 == num)
			{
			}
			num = (short)1810104320;
			if (num != 0)
			{
			}
			num = (short)349372416;
			short num3 = num;
			num = (short)356450305;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI).DataWideWIFIEnable_42506Value;
		}

		// Token: 0x0600A0C0 RID: 41152 RVA: 0x00960F30 File Offset: 0x0095F130
		internal static bool ConWiFiPasswordIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)642580480;
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
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						int num3;
						string uivalue;
						if (num3 >= uivalue.Length)
						{
							num = (short)1081147393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1814888452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1077805058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_FC;
					case 3:
						goto IL_1C7;
					case 4:
					{
						int num3;
						string uivalue;
						if (uivalue[num3] > '\u007f')
						{
							num = (short)881459205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)90374147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return true;
					case 6:
						goto IL_1C7;
					case 7:
						goto IL_154;
					}
					goto IL_4F;
					IL_1C7:
					num = (short)1727856640;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				if (dataWide.WIFI.DataWideWIFIEnable_42506.Value)
				{
					goto IL_111;
				}
				num = (short)1378746369;
				if (num != 0)
				{
				}
				return false;
				IL_154:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
				return configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value != 0;
				IL_4F:
				num = (short)569917301;
				short num4 = num;
				num = (short)1070940021;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_111:
					num = (short)618135552;
					short num5 = num;
					num = (short)1414463495;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				default:
				{
					num = (short)2083848192;
					if (num != 0)
					{
					}
					configuredNetworksListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection);
					dataWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					string uivalue = configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.UIValue;
					int num3 = 0;
					num = (short)630718470;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x0096116C File Offset: 0x0095F36C
		internal static bool ConWiFiPasswordIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)172883969;
			if (num != 0)
			{
			}
			num = (short)1770034702;
			short num2 = num;
			num = (short)40605198;
			switch (num2 == num)
			{
			}
			num = (short)1853816832;
			short num3 = num;
			num = (short)505544704;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection;
			string uivalue = configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.UIValue;
			int value = configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value;
			return global::ConstraintHelper.Validators.PasswordFieldValidator.IsWifiPasswordValid(ref uivalue, value);
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x0096123C File Offset: 0x0095F43C
		internal static bool ConWiFiSSIDIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1435500544;
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
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
				string value;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset configuredNetworksListInnerRecset;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = configuredNetworksListInnerRecset.GetEnumerator();
						num = (short)1831010305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1163657223;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_295;
								case 1:
									goto IL_277;
								case 2:
								{
									num = (short)1131157333;
									short num3 = num;
									num = (short)370874197;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1181614080;
										if (num != 0)
										{
										}
										result = false;
										num = (short)783089665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1652883464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner;
									num = (short)454819845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									if (string.Equals(configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value, configuredNetworksListInner.ConfiguredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value, global::System.StringComparison.CurrentCulture))
									{
										num = (short)1436942338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner configuredNetworksListInner;
									if (configuredNetworksListInnerSection.Parent != configuredNetworksListInner)
									{
										num = (short)2141192198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)666828804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_12B;
									}
									continue;
								case 8:
									num = (short)1915813888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12D:
								num = (short)714932227;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12B:
								goto IL_12D;
							}
							IL_277:
							return result;
							IL_295:
							return true;
						}
						finally
						{
							num = (short)1654128642;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1259143169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_302;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2CC;
									}
									continue;
								}
								IL_2CC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1417543680;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_302:;
						}
						goto IL_305;
					case 2:
						if (configuredNetworksListInnerRecset != null)
						{
							num = (short)660078592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						if (global::ConstraintHelper.Validators.SsidFieldValidator.IsSsidNameValid(ref value))
						{
							num = (short)1698299908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
					{
						num = (short)1988952065;
						if (num != 0)
						{
						}
						num = (short)1506410496;
						short num4 = num;
						goto IL_305;
					}
					}
					goto IL_42;
					IL_305:
					configuredNetworksListInnerRecset = (self.Parent.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerRecset);
					num = (short)773652482;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_42:
				configuredNetworksListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection);
				value = configuredNetworksListInnerSection.DataWideWiFiNetworkSSID_42519.Value;
				num = (short)132055043;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x009615DC File Offset: 0x0095F7DC
		internal static bool ConWifiPortValueUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1037041664;
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
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration portConfiguration;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool result;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset enhancedDataPortListRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)624033797;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfLTEBackupPTTGatewayPort_A43618.Value == value)
									{
										num = (short)899874818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1020395520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_D0B;
								case 3:
									goto IL_DEA;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.Features.DatProFeaturesDestinationPort_A20544.Value != value)
									{
										num = (short)1699086337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D0B;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_CCD;
									}
									continue;
								case 6:
									num = (short)221118467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_D27;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1056899078;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1906114564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_CCF:
								num = (short)1935343624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CCD:
								goto IL_CCF;
								IL_D0B:
								result = false;
								num = (short)1357119495;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D27:
							return result;
							IL_DEA:
							goto IL_263;
						}
						finally
						{
							num = (short)34275330;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)620036097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_E59;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E21;
									}
									continue;
								}
								IL_E21:
								if (enumerator == null)
								{
									break;
								}
								num = (short)329646080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E59:;
						}
						return result;
					case 1:
						if (dataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.Value == value)
						{
							num = (short)384434182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1571618824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)698417152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						enumerator = natlistInnerRecset.GetEnumerator();
						num = (short)1290010635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						enumerator = enhancedDataPortListRecset.GetEnumerator();
						num = (short)553189385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1695875082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return false;
					case 7:
						if (dataProfilesRecset != null)
						{
							num = (short)2089680898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
					case 8:
						if (dataWide.PortConfiguration.DataWideP25LocationReportingUDPPort_42413.Value == value)
						{
							num = (short)83361804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 9:
						goto IL_610;
					case 10:
						if (portConfiguration.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.Value)
						{
							num = (short)96141331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 11:
						goto IL_A48;
					case 12:
						num = (short)16646164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (dataWide != null)
						{
							num = (short)408748050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B1;
					case 14:
						return false;
					case 15:
						try
						{
							num = (short)943849479;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_59C;
								case 1:
									goto IL_57F;
								case 2:
									num = (short)716767235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == value)
									{
										num = (short)641400840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != value)
									{
										num = (short)1249312770;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_563;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1113194502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)908918788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1132068864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_484;
									}
									continue;
								case 8:
									goto IL_563;
								}
								IL_526:
								num = (short)609222661;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_484:
								goto IL_526;
								IL_563:
								result = false;
								num = (short)619118593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_57F:
							return result;
							IL_59C:
							return true;
						}
						finally
						{
							num = (short)780206082;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1530068993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_60D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5D3;
									}
									continue;
								}
								IL_5D3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1915420672;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_60D:;
						}
						goto Block_11;
					case 16:
						if (secureKMFProfileRecset != null)
						{
							num = (short)1106706432;
							short num3 = num;
							num = (short)761462807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						if (enhancedDataPortListRecset != null)
						{
							num = (short)1160708100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					case 18:
						num = (short)222363649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_348;
					case 20:
						if (portConfiguration.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)1806761989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EB;
					case 21:
						if (natlistInnerRecset != null)
						{
							num = (short)2125463555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B1;
					case 22:
						if (value == 49223)
						{
							num = (short)1471217678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						num = (short)1962868749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1814429697;
						if (num != 0)
						{
						}
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1084751887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_179:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)924712976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_11:
					try
					{
						IL_610:
						num = (short)833617931;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
								if (enhancedDataPortTableInnerRecset != null)
								{
									num = (short)213057541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_9D4;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
								if (enhancedDataPortList != null)
								{
									num = (short)300285962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								try
								{
									num = (short)1059782661;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if ((enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner).EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.Value == value)
											{
												num = (short)264765446;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 1:
											num = (short)2089484290;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											goto IL_8F6;
										case 3:
											goto IL_89B;
										case 4:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)350289921;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											num = (short)1307181056;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											switch (0)
											{
											case 0:
												goto IL_832;
											}
											continue;
										case 6:
											result = false;
											num = (short)850526211;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_8A0:
										num = (short)541458436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_832:
										goto IL_8A0;
									}
									IL_89B:
									return result;
									IL_8F6:
									break;
								}
								finally
								{
									num = (short)1742012418;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										switch (num2)
										{
										case 0:
										{
											num = (short)242732703;
											short num4 = num;
											num = (short)389795487;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												break;
											default:
												num = (short)669450240;
												if (num != 0)
												{
												}
												break;
											}
											enumerator2.Dispose();
											num = (short)1162805249;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 1:
											goto IL_9B7;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_92E;
											}
											continue;
										}
										IL_92E:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)1567490048;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_9B7:;
								}
								goto IL_9BA;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
								if (enhancedDataPortList.EnhancedDataPortList42005 != null)
								{
									num = (short)1310851080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = enhancedDataPortTableInnerRecset.GetEnumerator();
								num = (short)2007629827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1721499657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
								num = (short)39059458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
								if (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset != null)
								{
									num = (short)1214119948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
								num = (short)705560583;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_9BA;
							case 10:
								num = (short)1245118468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								switch (0)
								{
								case 0:
									goto IL_66A;
								}
								continue;
							case 12:
							{
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
								global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset = enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset;
								num = (short)386727936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_741:
							num = (short)1439891462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_66A:
							goto IL_741;
							IL_9BA:
							num = (short)602603521;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_9D4:
						goto IL_179;
					}
					finally
					{
						num = (short)1960181762;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1735131137;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_A45;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A0C;
								}
								continue;
							}
							IL_A0C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)375521280;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A45:;
					}
					goto Block_12;
					IL_263:
					enhancedDataPortListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4148) as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset);
					num = (short)767819793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B1:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)1259995143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_A48:
						num = (short)1172439047;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_BBE;
							case 1:
								goto IL_BA1;
							case 2:
								goto IL_B86;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
								if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value != value)
								{
									num = (short)2102984712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B86;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
								if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == value)
								{
									num = (short)1766326274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2045968390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)enumerator.Current;
								num = (short)743309315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)944242688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_A92;
								}
								continue;
							case 8:
								num = (short)957546500;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B46:
							num = (short)1535115269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A92:
							goto IL_B46;
							IL_B86:
							result = false;
							num = (short)843382785;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BA1:
						return result;
						IL_BBE:
						goto IL_2B1;
					}
					finally
					{
						num = (short)1272971266;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1858797569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_C2C;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BF5;
								}
								continue;
							}
							IL_BF5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1468137472;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_C2C:;
					}
					return false;
					IL_3EB:
					natlistInnerRecset = (dataWide.NATList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset);
					num = (short)127074325;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_348:
				return false;
				IL_8F:
				portConfiguration = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration);
				value = portConfiguration.DataWideWIFIOTAPTCPPort_42627.Value;
				num = (short)456196118;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x009624C4 File Offset: 0x009606C4
		internal static void ConClearWiFiPWD(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517, configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.DefaultValue));
					num2 = (short)1064674024;
					short num3 = num2;
					num2 = (short)799974120;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
					{
						num2 = (short)1414332416;
						short num4 = num2;
						num2 = (short)1326776320;
						if (num2 != 0)
						{
						}
						num2 = (short)1468137473;
						if (num2 != 0)
						{
						}
						num2 = (short)188940288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					if (configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value != configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.DefaultValue)
					{
						num2 = (short)1594949633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_64;
				case 4:
					if (configuredNetworksListInnerSection.DataWideWiFiNetworkSecurityType_42516.Value == 0)
					{
						num2 = (short)1311637507;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_24;
				IL_64:
				num2 = (short)18546690;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			configuredNetworksListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection);
			num2 = (short)23724036;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0C5 RID: 41157 RVA: 0x00962658 File Offset: 0x00960858
		internal static void ConClearWiFiPWDWhenSSIDChange(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection configuredNetworksListInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517, configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.DefaultValue));
					num2 = (short)1628569601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
				{
					if (!(configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.Value != configuredNetworksListInnerSection.DataWideWiFiNetworkEncryptedNetworkPassword_42517.DefaultValue))
					{
						return;
					}
					num2 = (short)1278042694;
					short num3 = num2;
					num2 = (short)1791451718;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)994574337;
						if (num2 != 0)
						{
						}
						num2 = (short)76611584;
						short num4 = num2;
						num2 = (short)1370030080;
						if (num2 != 0)
						{
						}
						num2 = (short)1747320832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			configuredNetworksListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInnerSection);
			num2 = (short)1086390274;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x009627AC File Offset: 0x009609AC
		internal static bool ConModemTypeIsSierralWirelessGXESLSSeries(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)74138232;
			short num2 = num;
			num = (short)1080902264;
			switch (num2 == num)
			{
			}
			num = (short)1577582592;
			if (num != 0)
			{
			}
			num = (short)1202126849;
			if (num != 0)
			{
			}
			num = (short)1973092352;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired(self);
			bool flag2 = externalDataModem.DataWideExternalDataModemType_42843.Value == 2;
			return flag && flag2;
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x00962874 File Offset: 0x00960A74
		internal static bool ConModemTypeIsSierralWirelessGXESLSSeriesOrMG90(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired(self);
			bool flag2 = externalDataModem.DataWideExternalDataModemType_42843.Value == 2;
			bool flag3 = externalDataModem.DataWideExternalDataModemType_42843.Value == 3;
			if (!flag)
			{
				short num = (short)777584641;
				if (num != 0)
				{
				}
				num = (short)1752665001;
				short num2 = num;
				num = (short)1055624105;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1392246784;
					if (num != 0)
					{
					}
					num = (short)1282473984;
					short num3 = num;
					return false;
				}
				}
			}
			return flag3 || flag2;
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x00962950 File Offset: 0x00960B50
		internal static void ConSetLTECheckbackTime(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)37881030;
					short num3 = num2;
					num2 = (short)1890845894;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					case 1:
						break;
					default:
					{
						num2 = (short)2071134208;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)773718016;
					if (num2 != 0)
					{
					}
					if (dataWide.LTE.DataWideLTELTECheckbackTime_A42205.Value != general.DataWideGeneralBroadbandCheckbackTime_A42862.Value)
					{
						num2 = (short)276365314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataWide.LTE.DataWideLTELTECheckbackTime_A42205, general.DataWideGeneralBroadbandCheckbackTime_A42862.Value));
					num2 = (short)1465647104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
			dataWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)1240596481;
			if (num2 != 0)
			{
			}
			num2 = (short)1169620993;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x00962AB0 File Offset: 0x00960CB0
		internal static bool ConDataModemPasswordIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1410635251;
			short num2 = num;
			num = (short)157193715;
			switch (num2 == num)
			{
			}
			num = (short)1393688576;
			if (num != 0)
			{
			}
			num = (short)594804737;
			if (num != 0)
			{
			}
			num = (short)1052246016;
			short num3 = num;
			string uivalue = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem).DataWideDataModemPassword_A42848.UIValue;
			return global::ConstraintHelper.Validators.PasswordFieldValidator.IsDataModemPasswordValid(ref uivalue);
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x00962B74 File Offset: 0x00960D74
		internal static void ConSetBroadbandCheckbackTime(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE lte;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
				{
					num2 = (short)705707655;
					short num3 = num2;
					num2 = (short)265371271;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1693057024;
						short num4 = num2;
						num2 = (short)984940544;
						if (num2 != 0)
						{
						}
						if (lte.DataWideLTELTECheckbackTime_A42205.Value != dataWide.General.DataWideGeneralBroadbandCheckbackTime_A42862.Value)
						{
							num2 = (short)1730609154;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 2:
					num2 = (short)1273888769;
					if (num2 != 0)
					{
					}
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataWide.General.DataWideGeneralBroadbandCheckbackTime_A42862, lte.DataWideLTELTECheckbackTime_A42205.Value));
					num2 = (short)1759117312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			lte = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE);
			dataWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)855506945;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0CB RID: 41163 RVA: 0x00962CD4 File Offset: 0x00960ED4
		internal static bool ConDataModemIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1610114304;
			short num2 = num;
			num = (short)226125056;
			switch (num2 == num)
			{
			}
			num = (short)921829376;
			if (num != 0)
			{
			}
			num = (short)1898381313;
			if (num != 0)
			{
			}
			num = (short)741408768;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired(self);
			bool flag2 = externalDataModem.DataWideExternalDataModemType_42843.Value != 0;
			return flag && flag2;
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x00962DA0 File Offset: 0x00960FA0
		internal static bool ConSensorMeasurementRepApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1161313683;
			short num2 = num;
			num = (short)1497644435;
			switch (num2 == num)
			{
			}
			num = (short)1984299009;
			if (num != 0)
			{
			}
			num = (short)839516160;
			if (num != 0)
			{
			}
			num = (short)262668288;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).General.SensorMeasurementReporting_A43021.Value;
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x00962E64 File Offset: 0x00961064
		internal static bool ConSensorPortValueUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1689452544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration portConfiguration;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2129199111;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_22E;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1918238722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1722417156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)972423174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfLTEBackupPTTGatewayPort_A43618.Value == value)
									{
										num = (short)116785157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.Features.DatProFeaturesDestinationPort_A20544.Value != value)
									{
										num = (short)1462042632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_212;
								}
								case 5:
									goto IL_212;
								case 6:
									goto IL_24C;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_133;
									}
									continue;
								case 8:
									num = (short)76414979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D4:
								num = (short)1162215425;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_133:
								goto IL_1D4;
								IL_212:
								result = false;
								num = (short)951975936;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22E:
							return result;
							IL_24C:
							goto IL_916;
						}
						finally
						{
							num = (short)1845231617;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2BA;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_283;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1766326272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_283:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1643905026;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BA:;
						}
						goto IL_2BD;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)985923584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (dataWide != null)
						{
							num = (short)1057947656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B0;
					case 3:
						if (secureKMFProfileRecset != null)
						{
							num = (short)513867780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)2018115589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_32E;
					case 6:
						try
						{
							num = (short)1075249159;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_52F;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1671692290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)enumerator.Current;
									num = (short)1455095812;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1996357638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == value)
									{
										num = (short)1899560965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value != value)
									{
										num = (short)1065156616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_514;
								}
								case 5:
									goto IL_514;
								case 6:
									goto IL_54C;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_418;
									}
									continue;
								case 8:
									num = (short)1638072323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4D3:
								num = (short)1335164929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_418:
								goto IL_4D3;
								IL_514:
								result = false;
								num = (short)739049472;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_52F:
							return result;
							IL_54C:
							goto IL_9B0;
						}
						finally
						{
							num = (short)705560577;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_5BC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_585;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1607532544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_585:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1117126658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5BC:;
						}
						return false;
					case 7:
						if (dataProfilesRecset != null)
						{
							num = (short)28770305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_916;
					case 8:
						num = (short)970063887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)1534001152;
						short num3 = num;
						if (dataWide.PortConfiguration.DataWideP25LocationReportingUDPPort_42413.Value == value)
						{
							num = (short)624558094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_882;
					}
					case 10:
						if (portConfiguration.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)193396756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_882;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = natlistInnerRecset.GetEnumerator();
						num = (short)251330566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_307;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
						if (natlistInnerRecset != null)
						{
							num = (short)1443561483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9B0;
					}
					case 14:
						num = (short)1065746433;
						if (num != 0)
						{
						}
						num = (short)641662986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (dataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.Value == value)
						{
							num = (short)121110545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2032599049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					case 17:
						return false;
					case 18:
					{
						if (dataWide.PortConfiguration.DataWideWIFIOTAPTCPPort_42627.Value == value)
						{
							num = (short)613810192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset = dataWide.NATList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset;
						num = (short)1123418125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (portConfiguration.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.Value)
						{
							num = (short)2043871244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_882;
					case 20:
						goto IL_2BD;
					}
					goto IL_82;
					IL_2BD:
					num = (short)636223507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_882:
					num = (short)1242955794;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_916:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)90439683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B0:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)1214840839;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_307:
				return false;
				IL_32E:
				try
				{
					num = (short)1744830471;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_703;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1671168002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
							num = (short)1469054980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)653197318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
							if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == value)
							{
								num = (short)1352794117;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
							if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != value)
							{
								num = (short)1812201480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6E7;
						}
						case 5:
							goto IL_6E7;
						case 6:
							goto IL_720;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_60B;
							}
							continue;
						case 8:
							num = (short)346292227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_6AB:
						num = (short)2007629825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_60B:
						goto IL_6AB;
						IL_6E7:
						result = false;
						num = (short)1203109888;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_703:
					return result;
					IL_720:;
				}
				finally
				{
					num = (short)1287913473;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_7E1;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_757;
							}
							continue;
						case 2:
						{
							num = (short)1790348931;
							short num4 = num;
							num = (short)775589507;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7E1;
							default:
								num = (short)859308032;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)155123712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_757:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2085748738;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7E1:;
				}
				return true;
				IL_82:
				portConfiguration = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration);
				value = portConfiguration.SensorMeasurementReportingUDPPort_A43022.Value;
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				num = (short)970391554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x009638BC File Offset: 0x00961ABC
		internal static bool ConKVLKeyloadingSourceIsKVL(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1371800073;
			short num2 = num;
			num = (short)687079945;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1892286464;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide;
				for (;;)
				{
					IL_56:
					num = (short)1783889921;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)61865984;
						short num4 = num;
						if (secureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)2114715649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
						num = (short)961216515;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)82968576;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (secureWide.General.SecureWideKeyloadingSource_43204.Value == 1)
						{
							num = (short)1910374405;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (secureWide != null)
						{
							num = (short)924385282;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						return true;
					}
					goto IL_9C;
				}
				return false;
				IL_9C:
				secureWide = (global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide);
				num = (short)1633746948;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
			return true;
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x00963A6C File Offset: 0x00961C6C
		internal static bool ConKVLKeyloadingUDPPortValueUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)406454272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration portConfiguration;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset enhancedDataPortListRecset;
					switch (num2)
					{
					case 0:
						if (secureKMFProfileRecset != null)
						{
							num = (short)1039663113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (dataWide.PortConfiguration.DataWideWIFIOTAPTCPPort_42627.Value == value)
						{
							num = (short)1552416768;
							short num3 = num;
							num = (short)1351090180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)614924299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (dataWide.PortConfiguration.DataWideP25LocationReportingUDPPort_42413.Value == value)
						{
							num = (short)512163853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 3:
						if (dataWide != null)
						{
							num = (short)1454047239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14C;
					case 4:
						return false;
					case 5:
						return false;
					case 6:
						goto IL_9E4;
					case 7:
						num = (short)556007445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)439615503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						enumerator = secureKMFProfileRecset.GetEnumerator();
						num = (short)1665269785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return false;
					case 11:
						if (dataWide.PortConfiguration.SensorMeasurementReportingUDPPort_A43022.Value == value)
						{
							num = (short)642973706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						natlistInnerRecset = (dataWide.NATList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset);
						num = (short)1896611863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						enumerator = enhancedDataPortListRecset.GetEnumerator();
						num = (short)98762774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)2032533523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return false;
					case 15:
						goto IL_C63;
					case 16:
						num = (short)1393491986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (dataProfilesRecset != null)
						{
							num = (short)104005640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					case 18:
						if (portConfiguration.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.Value)
						{
							num = (short)95092750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 19:
						if (portConfiguration.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)541523984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42F;
					case 20:
						num = (short)313524225;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1661534209;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
								switch (num2)
								{
								case 0:
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == value)
									{
										num = (short)314416973;
										short num4 = num;
										num = (short)2061606733;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_A9A;
										default:
											num = (short)1324548096;
											if (num != 0)
											{
											}
											num = (short)1413611524;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A7B;
									}
									continue;
								case 2:
									goto IL_BF0;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)889585669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A9A;
								case 4:
									goto IL_A7D;
								case 5:
									num = (short)1254490114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value != value)
									{
										num = (short)1012006919;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A7D;
								case 7:
									num = (short)285212672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_A95;
								}
								goto IL_A7B;
								IL_A7D:
								result = false;
								num = (short)1760690184;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A9A:
								natlistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)enumerator.Current;
								num = (short)2140864518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AF8:
								num = (short)1370816515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A7B:
								goto IL_AF8;
							}
							IL_A95:
							return result;
							IL_BF0:
							goto IL_14C;
						}
						finally
						{
							num = (short)254738434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1308884993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_C60;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C27;
									}
									continue;
								}
								IL_C27:
								if (enumerator == null)
								{
									break;
								}
								num = (short)884539392;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C60:;
						}
						goto Block_14;
					case 21:
						if (dataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.Value == value)
						{
							num = (short)352124933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3A;
					case 22:
						try
						{
							num = (short)1018757124;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									if (enhancedDataPortTableInnerRecset != null)
									{
										num = (short)66191366;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_972;
								case 2:
									num = (short)1181548545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)475267079;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_660;
									}
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset = enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset;
									num = (short)597229568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = enhancedDataPortTableInnerRecset.GetEnumerator();
									num = (short)337248264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005 != null)
									{
										num = (short)1988952073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									try
									{
										num = (short)675151878;
										num2 = (int)((global::System.IntPtr)num);
										bool result;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_765;
											case 1:
												goto IL_748;
											case 2:
												result = false;
												num = (short)1474887681;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if ((enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner).EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.Value == value)
												{
													num = (short)1596522498;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 4:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1370161157;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)604766211;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												num = (short)935788544;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												switch (0)
												{
												case 0:
													goto IL_6A8;
												}
												continue;
											}
											IL_6AA:
											num = (short)1895170052;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6A8:
											goto IL_6AA;
										}
										IL_748:
										return result;
										IL_765:
										break;
									}
									finally
									{
										num = (short)1464139778;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)579010561;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_7D5;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_79C;
												}
												continue;
											}
											IL_79C:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)600768512;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_7D5:;
									}
									goto IL_7D8;
								case 9:
									goto IL_7D8;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1832452098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
									num = (short)1515061259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList != null)
									{
										num = (short)1874526211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset != null)
									{
										num = (short)1581973509;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_660;
								IL_7D8:
								num = (short)6815756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_81E:
								num = (short)1413939210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_660:
								goto IL_81E;
							}
							IL_972:
							goto IL_199;
						}
						finally
						{
							num = (short)511180802;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)498401281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_9E1;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_9A9;
									}
									continue;
								}
								IL_9A9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1459421184;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9E1:;
						}
						goto IL_9E4;
					case 23:
						if (natlistInnerRecset != null)
						{
							num = (short)572653574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14C;
					case 24:
						if (enhancedDataPortListRecset != null)
						{
							num = (short)602603532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					case 25:
						try
						{
							num = (short)592052231;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)584450054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2AD;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2087976960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)200212485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2C5;
								case 4:
									num = (short)779747336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != value)
									{
										num = (short)451543044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2AD;
								}
								case 6:
									goto IL_3BE;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_2A8;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == value)
									{
										num = (short)1174142977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_2A8;
								IL_2AD:
								result = false;
								num = (short)2012807171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_366:
								num = (short)2143879170;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A8:
								goto IL_366;
							}
							IL_2C5:
							return result;
							IL_3BE:
							return true;
						}
						finally
						{
							num = (short)520290305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_42C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3F5;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1934491648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3F5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1590624258;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_42C:;
						}
						goto IL_42F;
					}
					goto IL_97;
					IL_FC:
					enhancedDataPortListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4148) as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset);
					num = (short)1601503256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_14:
					try
					{
						IL_C63:
						num = (short)389087233;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2085486596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_CAE;
								}
								continue;
							case 2:
								num = (short)89784323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
								if (dataProfiles.LTE.DataProfLTEBackupPTTGatewayPort_A43618.Value == value)
								{
									num = (short)915734533;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_DC7;
							case 5:
								goto IL_CEA;
							case 6:
								goto IL_D07;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1955201024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
								num = (short)1239154696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
								if (dataProfiles.Features.DatProFeaturesDestinationPort_A20544.Value != value)
								{
									num = (short)674103298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_CEA;
							}
							}
							IL_CB0:
							num = (short)1624113159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CAE:
							goto IL_CB0;
							IL_CEA:
							result = false;
							num = (short)1734148102;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_D07:
						return result;
						IL_DC7:
						goto IL_FC;
					}
					finally
					{
						num = (short)476971009;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_E37;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_E00;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)577437696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_E00:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1673723906;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_E37:;
					}
					goto IL_E3A;
					IL_14C:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)648937489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)797310976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42F:
					num = (short)247791617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E4:
					enumerator = natlistInnerRecset.GetEnumerator();
					num = (short)1359151124;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3A:
					num = (short)1131085826;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_97:
				portConfiguration = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration);
				value = portConfiguration.DataWideKVLKeyloadingUDPPort_43205.Value;
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				num = (short)995819523;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x009649A8 File Offset: 0x00962BA8
		internal static void ModemConnectionTypeChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2141432207;
			short num2 = num;
			num = (short)988064143;
			switch (num2 == num)
			{
			}
			num = (short)1134559232;
			if (num != 0)
			{
			}
			num = (short)1975451649;
			if (num != 0)
			{
			}
			num = (short)1006960640;
			short num3 = num;
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x00964A54 File Offset: 0x00962C54
		public static bool ConActionExternalDataModemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dataWide.ExternalDataModem.ModemConnectionType_43350_UIValue == global::CommonResources.AcgResources.ID_WIRELESS)
					{
						num2 = (short)1361969153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_C5;
				case 2:
					if (dataWide.ExternalDataModem.HasVisibleObjects)
					{
						num2 = (short)1977614339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)289931264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_C5:
			num2 = (short)665480087;
			short num3 = num2;
			num2 = (short)188902295;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
			{
				num2 = (short)1090060288;
				short num4 = num2;
				num2 = (short)1454702593;
				if (num2 != 0)
				{
				}
				num2 = (short)1733623808;
				if (num2 != 0)
				{
				}
				return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			}
			}
			IL_20:
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)544145410;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x00964BC8 File Offset: 0x00962DC8
		public static bool ConActionExternalDataModemWired(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2067944414;
			short num2 = num;
			num = (short)310858718;
			switch (num2 == num)
			{
			}
			num = (short)15007745;
			if (num != 0)
			{
			}
			num = (short)1776418816;
			if (num != 0)
			{
			}
			num = (short)1102381056;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).ExternalDataModem.ModemConnectionType_43350_UIValue == global::CommonResources.AcgResources.ID_WIRED;
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x00964C98 File Offset: 0x00962E98
		internal static bool ConIsSierraWirlessModemSelected(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)291373056;
			short num2 = num;
			if (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType(self))
			{
				num = (short)2142356628;
				short num3 = num;
				num = (short)144491668;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)506855424;
					if (num != 0)
					{
					}
					num = (short)680460289;
					if (num != 0)
					{
					}
					return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection).DataWideExternalDataModemType_43362.Value == 2;
				}
			}
			return false;
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x00964D68 File Offset: 0x00962F68
		internal static bool ConExternalDataModemWiFiPasswordIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)273621028;
			short num2 = num;
			num = (short)446832676;
			switch (num2 == num)
			{
			}
			num = (short)1040777217;
			if (num != 0)
			{
			}
			num = (short)1481637888;
			if (num != 0)
			{
			}
			num = (short)695468032;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
			string uivalue = dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.UIValue;
			int value = dataModemTableInnerSection.DataWideExternalDataModemSecurityType_43360.Value;
			return global::ConstraintHelper.Validators.PasswordFieldValidator.IsWifiPasswordValid(ref uivalue, value);
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x00964E38 File Offset: 0x00963038
		internal static bool ConExternalDataModemPasswordIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1903438986;
			short num2 = num;
			num = (short)78392458;
			switch (num2 == num)
			{
			}
			num = (short)518848513;
			if (num != 0)
			{
			}
			num = (short)833159168;
			if (num != 0)
			{
			}
			num = (short)1143209984;
			short num3 = num;
			string uivalue = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection).DataWideEncryptedModemPassword_43361.UIValue;
			return global::ConstraintHelper.Validators.PasswordFieldValidator.IsDataModemPasswordValid(ref uivalue);
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x00964EF8 File Offset: 0x009630F8
		internal static bool ConExternalDataModemWiFiSSIDIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1323302912;
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
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection;
				string value;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset dataModemTableInnerRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)774832129;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)126550020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_12F;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
									if (dataModemTableInnerSection.Parent != dataModemTableInner)
									{
										num = (short)986710019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1711276038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_244;
								case 5:
									goto IL_227;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner;
									if (string.Equals(dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value, dataModemTableInner.DataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value, global::System.StringComparison.CurrentCulture))
									{
										num = (short)2143354888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)420675584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner dataModemTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner;
									num = (short)1811021826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									result = false;
									num = (short)724828165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_131:
								num = (short)1797259271;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12F:
								goto IL_131;
							}
							IL_227:
							return result;
							IL_244:
							return true;
						}
						finally
						{
							for (;;)
							{
								IL_249:
								num = (short)1735655425;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_301;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_27C;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)630194176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_27C:
									num = (short)1222868022;
									short num3 = num;
									num = (short)1463122998;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_249;
									default:
										num = (short)738918400;
										if (num != 0)
										{
										}
										if (enumerator == null)
										{
											goto IL_303;
										}
										num = (short)1317666818;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
							}
							IL_301:
							IL_303:;
						}
						goto IL_304;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataModemTableInnerRecset.GetEnumerator();
						num = (short)2036137984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_304;
					case 3:
						num = (short)805109761;
						if (num != 0)
						{
						}
						if (global::ConstraintHelper.Validators.SsidFieldValidator.IsSsidNameValid(ref value))
						{
							num = (short)834404354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (dataModemTableInnerRecset != null)
						{
							num = (short)733478913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_43;
					IL_304:
					dataModemTableInnerRecset = (self.Parent.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerRecset);
					num = (short)1114374148;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_43:
				num = (short)384237568;
				short num4 = num;
				dataModemTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection);
				value = dataModemTableInnerSection.DataWideExternalDataModemNetworkSsid_43358.Value;
				num = (short)1675100163;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x00965298 File Offset: 0x00963498
		internal static void ConExternalDataModemClearWiFiPwdWhenSsidChange(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_115;
				case 1:
					if (dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.Value != dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.DefaultValue)
					{
						num2 = (short)1975582722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)872995841;
					short num3 = num2;
					num2 = (short)1218829313;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1509883905;
						if (num2 != 0)
						{
						}
						num2 = (short)1321926656;
						if (num2 != 0)
						{
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361, dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.DefaultValue));
						break;
					}
					num2 = (short)1238433792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_115:
			num2 = (short)322043904;
			short num4 = num2;
			return;
			IL_1C:
			dataModemTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection);
			num2 = (short)1047461889;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x009653E4 File Offset: 0x009635E4
		internal static void ConExternalDataModemClearWiFiPwd(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1853485078;
					short num3 = num2;
					num2 = (short)1843064854;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)985071616;
						if (num2 != 0)
						{
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361, dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.DefaultValue));
						break;
					}
					num2 = (short)1680343044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.Value != dataModemTableInnerSection.DataWideEncryptedNetworkPassword_43361.DefaultValue)
					{
						num2 = (short)1578631168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)335085568;
					short num4 = num2;
					num2 = (short)896335873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)500695041;
					if (num2 != 0)
					{
					}
					if (dataModemTableInnerSection.DataWideExternalDataModemSecurityType_43360.Value == 0)
					{
						num2 = (short)1843920898;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					return;
				}
				goto IL_24;
			}
			return;
			IL_24:
			dataModemTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection);
			num2 = (short)1389166595;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0D9 RID: 41177 RVA: 0x0096557C File Offset: 0x0096377C
		public static bool WifiDataModemPasswordApplicability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)792860357;
			short num2 = num;
			num = (short)1398740677;
			switch (num2 == num)
			{
			}
			num = (short)1122631680;
			if (num != 0)
			{
			}
			num = (short)1441071105;
			if (num != 0)
			{
			}
			num = (short)2086338560;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType(self);
			bool flag2 = dataModemTableInnerSection.DataWideExternalDataModemSecurityType_43360.Value != 0;
			return flag && flag2;
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x00965644 File Offset: 0x00963844
		public static bool ConActionIsWifiDataModemPortValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1348145933;
			short num2 = num;
			num = (short)304157453;
			switch (num2 == num)
			{
			}
			num = (short)1144651777;
			if (num != 0)
			{
			}
			num = (short)1139605504;
			if (num != 0)
			{
			}
			num = (short)984940544;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
			bool flag = dataModemTableInnerSection.DataWideExternalDataModemType_43362.Value == 1;
			bool flag2 = dataModemTableInnerSection.DataWideExternalDataModemPort.Value == 49480;
			return !flag || !flag2;
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x0096571C File Offset: 0x0096391C
		public static bool IsDataModemConnectionTypeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!dataWide.WIFI.DataWideWIFIEnable_42506Value)
					{
						num2 = (short)2047148033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_F6;
				case 2:
					if (dataWide.ExternalDataModem.HasVisibleObjects && flag)
					{
						num2 = (short)1193148419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B3;
				case 3:
					num2 = (short)928120832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_B3:
			return !flag;
			IL_F6:
			num2 = (short)1431550333;
			short num3 = num2;
			num2 = (short)508017021;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num2 = (short)1414135809;
				if (num2 != 0)
				{
				}
				num2 = (short)1785069568;
				if (num2 != 0)
				{
				}
				goto IL_B3;
			}
			IL_20:
			num2 = (short)150208512;
			short num4 = num2;
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			flag = (dataWide.ExternalDataModem.ModemConnectionType_43350_UIValue == global::CommonResources.AcgResources.ID_WIRELESS);
			num2 = (short)1125122050;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x00965898 File Offset: 0x00963A98
		internal static bool SensorsReportingEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
			short num;
			for (;;)
			{
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General);
				if (general != null)
				{
					goto IL_AD;
				}
				num = (short)2066415616;
				short num2 = num;
				num = (short)1251744015;
				short num3 = num;
				num = (short)888281359;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6D;
				}
			}
			IL_6D:
			num = (short)2136342529;
			if (num != 0)
			{
			}
			num = (short)636944384;
			if (num != 0)
			{
			}
			return false;
			IL_AD:
			return general.SensorMeasurementReporting_A43021.Value;
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x00965960 File Offset: 0x00963B60
		internal static bool ConAcknowledgedWeaponFiredEventReportingEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)899855811;
			short num2 = num;
			num = (short)1872475587;
			switch (num2 == num)
			{
			}
			num = (short)632422400;
			if (num != 0)
			{
			}
			num = (short)2099707905;
			if (num != 0)
			{
			}
			num = (short)320405504;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.General).SensorMeasurementReporting_A43021.Value;
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x00965A1C File Offset: 0x00963C1C
		internal static bool ConDataModemIsEnabledAndNotSierraWirelessMG90Modem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool flag3;
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
				bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired(self);
				bool flag2 = externalDataModem.DataWideExternalDataModemType_42843.Value != 0;
				flag3 = (externalDataModem.DataWideExternalDataModemType_42843.Value == 3);
				if (!flag || !flag2)
				{
					return false;
				}
				num = (short)871825408;
				short num2 = num;
				num = (short)618135553;
				if (num != 0)
				{
				}
				num = (short)2033284417;
				short num3 = num;
				num = (short)1870361921;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BA;
				}
			}
			IL_BA:
			num = (short)1264648192;
			if (num != 0)
			{
			}
			return !flag3;
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x00965B00 File Offset: 0x00963D00
		internal static bool ConWiredModeAndModemTypeIsSierraWirelessMG90(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1950547969;
			if (num != 0)
			{
			}
			num = (short)79317480;
			short num2 = num;
			num = (short)1174096360;
			switch (num2 == num)
			{
			}
			num = (short)491585536;
			if (num != 0)
			{
			}
			num = (short)734986240;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWired(self);
			bool flag2 = externalDataModem.DataWideExternalDataModemType_42843.Value == 3;
			return flag && flag2;
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x00965BC8 File Offset: 0x00963DC8
		internal static bool ConMG90SatelliteEnabledAndWiredModeAndModemTypeIsSierraWirelessMG90(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)74801370;
			short num2 = num;
			num = (short)1214079194;
			switch (num2 == num)
			{
			}
			num = (short)158072833;
			if (num != 0)
			{
			}
			num = (short)134676480;
			if (num != 0)
			{
			}
			num = (short)1608122368;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWiredModeAndModemTypeIsSierraWirelessMG90(self);
			bool dataWideExternalDataModemMG90SatelliteEnabled_43777Value = externalDataModem.DataWideExternalDataModemMG90SatelliteEnabled_43777Value;
			return flag && dataWideExternalDataModemMG90SatelliteEnabled_43777Value;
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x00965C88 File Offset: 0x00963E88
		internal static bool ConModemVPNFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)354877441;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)1696989186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					IL_14:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_139;
				case 3:
					text2 = null;
					goto IL_8A;
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
				if (externalDataModem == null)
				{
					num = (short)1078198275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = externalDataModem.DataWideExternalDataModemVPNFriendlyName_43774Value;
				IL_8A:
				text = text2;
				num = (short)846347208;
				short num3 = num;
				num = (short)1977564104;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
				{
					num = (short)1534853120;
					if (num != 0)
					{
					}
					num = (short)2071920640;
					short num4 = num;
					num = (short)1529217024;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_139:
			num = (short)1525547009;
			if (num != 0)
			{
			}
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x00965DE0 File Offset: 0x00963FE0
		internal static bool ConModemLTEFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)4521985;
			if (num != 0)
			{
			}
			num = (short)24969217;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)112721922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					IL_3B:
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					goto IL_138;
				case 3:
					text2 = null;
					goto IL_89;
				}
				IL_5B:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
				if (externalDataModem == null)
				{
					num = (short)1206255619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = externalDataModem.DataWideExternalDataModemLTEFriendlyName_43775Value;
				IL_89:
				text = text2;
				num = (short)1808626705;
				short num3 = num;
				num = (short)825521169;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3B;
				default:
				{
					num = (short)1491206144;
					if (num != 0)
					{
					}
					num = (short)66977792;
					short num4 = num;
					num = (short)1696006144;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_138:
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x00965F38 File Offset: 0x00964138
		internal static bool ConMG90SatelliteFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)706543617;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)176095234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					IL_16:
					num = (short)248446977;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					goto IL_136;
				case 3:
					text2 = null;
					goto IL_8B;
				}
				IL_5D:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem;
				if (externalDataModem == null)
				{
					num = (short)2046558211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = externalDataModem.DataWideExternalDataModemMG90SatelliteFriendlyName_43776Value;
				IL_8B:
				text = text2;
				num = (short)262288521;
				short num3 = num;
				num = (short)1075262601;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_16;
				default:
				{
					num = (short)1110376448;
					if (num != 0)
					{
					}
					num = (short)322109440;
					short num4 = num;
					num = (short)1635581952;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_136:
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x0096608C File Offset: 0x0096428C
		public static bool ConActionExternalDataModemWireless(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1252218945;
			short num2 = num;
			num = (short)1823365185;
			switch (num2 == num)
			{
			}
			num = (short)590479361;
			if (num != 0)
			{
			}
			num = (short)1534263296;
			if (num != 0)
			{
			}
			num = (short)1084358656;
			short num3 = num;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).ExternalDataModem.ModemConnectionType_43350.Value == 1;
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x00966160 File Offset: 0x00964360
		internal static bool ConWirelessModeAndModemTypeIsSierraWirelessMG90(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1659527981;
			short num2 = num;
			num = (short)1732797229;
			switch (num2 == num)
			{
			}
			num = (short)2105671681;
			if (num != 0)
			{
			}
			num = (short)427950080;
			if (num != 0)
			{
			}
			num = (short)1747189760;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemType(self);
			bool flag2 = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConActionExternalDataModemWireless(self);
			bool flag3 = dataModemTableInnerSection.DataWideExternalDataModemType_43362.Value == 3;
			return flag && flag2 && flag3;
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x00966234 File Offset: 0x00964434
		internal static bool ConMG90SatelliteEnabledAndWirelessModeAndModemTypeIsSierraWirelessMG90(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1344250640;
			short num2 = num;
			num = (short)298033936;
			switch (num2 == num)
			{
			}
			num = (short)1283260417;
			if (num != 0)
			{
			}
			num = (short)1746075648;
			if (num != 0)
			{
			}
			num = (short)1725169664;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
			bool flag = global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWideConstraints.ConWirelessModeAndModemTypeIsSierraWirelessMG90(self);
			bool dataWideMG90WirelessSatelliteEnable_43788Value = dataModemTableInnerSection.DataWideMG90WirelessSatelliteEnable_43788Value;
			return flag && dataWideMG90WirelessSatelliteEnable_43788Value;
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x009662F4 File Offset: 0x009644F4
		internal static bool ConModemWirelessVPNFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)186122241;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)1693843458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					IL_15:
					num = (short)290914305;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5B;
					}
					continue;
				case 2:
					goto IL_136;
				case 3:
					text2 = null;
					goto IL_88;
				}
				IL_5B:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
				if (dataModemTableInnerSection == null)
				{
					num = (short)1894055939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = dataModemTableInnerSection.DataWideMG90WirelessVPNFriendlyName_43785Value;
				IL_88:
				text = text2;
				num = (short)2119998843;
				short num3 = num;
				num = (short)1124244859;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15;
				default:
				{
					num = (short)927334400;
					if (num != 0)
					{
					}
					num = (short)186646528;
					short num4 = num;
					num = (short)1520631808;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_136:
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x00966448 File Offset: 0x00964648
		internal static bool ConModemWirelessLTEFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)590807041;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
				{
					num = (short)115605504;
					short num3 = num;
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)1589313537;
						if (num != 0)
						{
						}
						num = (short)427753474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
					IL_14:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_133;
				case 3:
					text2 = null;
					goto IL_61;
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
				if (dataModemTableInnerSection == null)
				{
					num = (short)43712515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = dataModemTableInnerSection.DataWideMG90WirelessLTEFriendlyName_43786Value;
				IL_61:
				text = text2;
				num = (short)184558532;
				short num4 = num;
				num = (short)1669800900;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
					num = (short)12386304;
					if (num != 0)
					{
					}
					num = (short)1983184896;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_133:
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x00966598 File Offset: 0x00964798
		internal static bool ConWirelessMG90SatelliteFriendlyNameIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)895614977;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				string text2;
				switch (num2)
				{
				case 0:
				{
					num = (short)1829634048;
					short num3 = num;
					num = (short)1611005953;
					if (num != 0)
					{
					}
					if (!string.IsNullOrEmpty(text))
					{
						num = (short)936247298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
					IL_14:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					goto IL_134;
				case 3:
					text2 = null;
					goto IL_61;
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection dataModemTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInnerSection;
				if (dataModemTableInnerSection == null)
				{
					num = (short)730464259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text2 = dataModemTableInnerSection.DataWideMG90WirelessSatelliteFriendlyName_43787Value;
				IL_61:
				text = text2;
				num = (short)1027241618;
				short num4 = num;
				num = (short)663189138;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_14;
				default:
					num = (short)2049572864;
					if (num != 0)
					{
					}
					num = (short)1691615232;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_134:
			return global::Motorola.MackinawCPS.CoreFeatures.DataWide.FriendlyNameValidator.IsFriendlyNameValid(text);
		}
	}
}
