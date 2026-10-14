using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpCommonLib;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x02000110 RID: 272
	public static class ScanListConstraints
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x00271124 File Offset: 0x0026F324
		internal static bool ConPrtyOneTypeIsOperatorSelectOrFixedAndScanLstTypeIsCnvOrPriMon(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
			global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)541131135;
					short num3 = num2;
					num2 = (short)459473279;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DB;
					default:
						num2 = (short)925106176;
						if (num2 != 0)
						{
						}
						if (scanLstGeneralPriority1Type_A.Value != 3)
						{
							num2 = (short)2008285186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1A3;
					}
					break;
				}
				case 1:
					if (scanLstGeneralScanType_A.Value != 2)
					{
						num2 = (short)713490439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					num2 = (short)881917957;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_1DB;
				case 4:
					if (scanLstGeneralScanType_A.Value != 0)
					{
						num2 = (short)836042755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (scanLstGeneralPriority1Type_A.Value == 1)
					{
						num2 = (short)1001848838;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					goto IL_1A3;
				case 7:
					goto IL_111;
				}
				goto IL_30;
				IL_1A3:
				num2 = (short)1696202756;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DB:
				num2 = (short)254476289;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_111:
			num2 = (short)1993736192;
			short num4 = num2;
			num2 = (short)284164097;
			if (num2 != 0)
			{
			}
			return scanLstGeneralScanType_A.Value == 1;
			IL_30:
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General;
			scanLstGeneralPriority1Type_A = general.ScanLstGeneralPriority1Type_A8745;
			scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
			num2 = (short)1042546688;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00271314 File Offset: 0x0026F514
		internal static bool ConScanLstTypeIsConventionalOrPriorityMonitor(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (scanLstGeneralScanType_A.Value != 0)
						{
							num2 = (short)697106435;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CE;
					case 1:
						goto IL_CC;
					case 2:
						if (scanLstGeneralScanType_A.Value != 2)
						{
							num2 = (short)1026555905;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_CE;
					case 3:
					{
						num2 = (short)1162018816;
						short num3 = num2;
						num2 = (short)1190330370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_20;
				}
				IL_CC:
				return scanLstGeneralScanType_A.Value == 1;
				IL_CE:
				num2 = (short)1923874817;
				if (num2 != 0)
				{
				}
				num2 = (short)588813943;
				short num4 = num2;
				num2 = (short)1136367223;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_2C;
				default:
					num2 = (short)472907776;
					if (num2 != 0)
					{
					}
					return true;
				}
				break;
			}
			}
			IL_20:
			scanLstGeneralScanType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058;
			IL_2C:
			num2 = (short)173998080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00271460 File Offset: 0x0026F660
		internal static bool ConScanLstTypeIsCnvAndDynPrtyEnIsDisOrScanLstTypeIsPriorityMonitor(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_C2;
				case 1:
					num2 = (short)2105147395;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1243873285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1391132673;
					if (num2 != 0)
					{
					}
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
					if (scanLstGeneralScanType_A.Value != 1)
					{
						num2 = (short)791019522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 4:
					goto IL_130;
				case 5:
				{
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
					if (scanLstGeneralScanType_A.Value == 0)
					{
						num2 = (short)76546052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_28;
			}
			IL_130:
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			return !general.ScanLstGeneralDynamicPriority_A7915.Value;
			IL_28:
			num2 = (short)119681723;
			short num3 = num2;
			num2 = (short)1054225083;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C2:
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				if (scanLstGeneralScanType_A.Value != 2)
				{
					num2 = (short)86835201;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)256770048;
				short num4 = num2;
				num2 = (short)1501036544;
				if (num2 != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
				num2 = (short)945815552;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return true;
		}

		// Token: 0x06002862 RID: 10338 RVA: 0x00271608 File Offset: 0x0026F808
		internal static bool ConIsScanTypePriorityMonitor(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)95354880;
			short num2 = num;
			num = (short)1263622339;
			short num3 = num;
			num = (short)215111875;
			switch (num3 == num)
			{
			}
			num = (short)88539137;
			if (num != 0)
			{
			}
			num = (short)230948864;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058.Value == 2;
		}

		// Token: 0x06002863 RID: 10339 RVA: 0x002716C4 File Offset: 0x0026F8C4
		internal static bool ConScanLstTypeIsVotingScanORConvScan(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)579076096;
			short num2 = num;
			num = (short)1456694386;
			short num3 = num;
			num = (short)1359111282;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1049690112;
				if (num != 0)
				{
				}
				num = (short)1003487233;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList).General.ScanLstGeneralScanType_A9058;
				if (scanLstGeneralScanType_A.Value != 4)
				{
					return scanLstGeneralScanType_A.Value == 0;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06002864 RID: 10340 RVA: 0x00271798 File Offset: 0x0026F998
		internal static bool ConScanLstTypeIsCnvAndDataTxRxTypeIsNotNone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1997471744;
			short num2 = num;
			num = (short)1171610612;
			short num3 = num;
			num = (short)165174260;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)875102208;
				if (num != 0)
				{
				}
				num = (short)606994433;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
				if (scanList.General.ScanLstGeneralScanType_A9058.Value == 0)
				{
					return scanList.General.ScanLstGeneralDesignatedDataTxRxType_A21525.Value != 0;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06002865 RID: 10341 RVA: 0x00271878 File Offset: 0x0026FA78
		internal static bool ConIsPriorityOneAndTwoValidforPriorityOne(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			short num;
			int num2;
			global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			for (;;)
			{
				IL_0A:
				num = (short)1989607425;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)847511560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (scanLstGeneralScanType_A.Value != 1)
					{
						num = (short)835321856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D4;
				case 2:
					num = (short)1838481417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_156;
				case 4:
				{
					num = (short)1886579947;
					short num3 = num;
					num = (short)1496313067;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
						num = (short)556531712;
						if (num != 0)
						{
						}
						if (index == 2)
						{
							num = (short)1001783299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 5:
					goto IL_D4;
				case 6:
					num = (short)657129479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (scanLstGeneralScanType_A.Value == 0)
					{
						num = (short)624558082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					if (scanLstGeneralScanType_A.Value != 2)
					{
						num = (short)1865154566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D4;
				case 9:
					if (!general.ScanLstGeneralDynamicPriority_A7915.Value)
					{
						num = (short)1949630469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_5E;
				IL_D4:
				num = (short)2084503556;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_156:
			return general.ScanLstGeneralPriority2Type_A8748.Value != 2;
			IL_5E:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
			scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
			num = (short)1371340800;
			short num4 = num;
			num = (short)1412562945;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06002866 RID: 10342 RVA: 0x00271AB4 File Offset: 0x0026FCB4
		internal static bool ConScanLstTypeIsNotVotingScan(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)228786176;
			short num2 = num;
			num = (short)841310253;
			short num3 = num;
			num = (short)650076205;
			switch (num3 == num)
			{
			}
			num = (short)6815745;
			if (num != 0)
			{
			}
			num = (short)1505361920;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058.Value != 4;
		}

		// Token: 0x06002867 RID: 10343 RVA: 0x00271B70 File Offset: 0x0026FD70
		internal static bool ConScanTypeIsNotVotingScanOrTxSteeringIsDisAndDsgnTxMbrType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (general.ScanLstGeneralScanType_A9058.Value == 4)
						{
							num2 = (short)396427264;
							short num3 = num2;
							num2 = (short)468123651;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_BE;
					case 1:
						goto IL_10E;
					case 2:
						if (!scanList.Advanced.ScanLstAdvancedTxSteering_A9572.Value)
						{
							num2 = (short)415301633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_110;
					case 3:
						num2 = (short)1867710466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_BE:
				return general.ScanLstGeneralDesignatedVoiceTxMemberType_A21524.Value == 1;
				IL_10E:
				goto IL_BE;
				IL_110:
				num2 = (short)1565270863;
				short num4 = num2;
				num2 = (short)1347298127;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_33;
				default:
					num2 = (short)1955135488;
					if (num2 != 0)
					{
					}
					return false;
				}
				break;
			}
			}
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
			scanList = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList);
			IL_33:
			num2 = (short)2087190529;
			if (num2 != 0)
			{
			}
			num2 = (short)1286471680;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002868 RID: 10344 RVA: 0x00271CD8 File Offset: 0x0026FED8
		internal static bool ConScanLstTypeIsCnv(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2016083968;
			short num2 = num;
			num = (short)702462768;
			short num3 = num;
			num = (short)1423031088;
			switch (num3 == num)
			{
			}
			num = (short)2039808000;
			if (num != 0)
			{
			}
			num = (short)1847590913;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058.Value == 0;
		}

		// Token: 0x06002869 RID: 10345 RVA: 0x00271D94 File Offset: 0x0026FF94
		internal static bool ConPrtyTwoTypeIsOpertSelOrFixedAndScanTypeIsCnvAndDynPrtyEnIsDisOrScanTypeIsPriorMon(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A;
			global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)277020672;
					short num3 = num2;
					num2 = (short)841809929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (scanLstGeneralPriority2Type_A.Value != 3)
					{
						num2 = (short)323616768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AD;
				case 2:
					goto IL_220;
				case 3:
					goto IL_1E8;
				case 4:
					goto IL_CF;
				case 5:
					goto IL_1AD;
				case 6:
					num2 = (short)523501572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (scanLstGeneralScanType_A.Value != 2)
					{
						num2 = (short)958005250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					if (scanLstGeneralScanType_A.Value == 0)
					{
						num2 = (short)2036662278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E8;
				case 9:
				{
					if (scanLstGeneralPriority2Type_A.Value != 1)
					{
						return false;
					}
					num2 = (short)1506265754;
					short num4 = num2;
					num2 = (short)1088408218;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CF;
					default:
						num2 = (short)1576992769;
						if (num2 != 0)
						{
						}
						num2 = (short)1322450944;
						if (num2 != 0)
						{
						}
						num2 = (short)809238533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_38;
				IL_CF:
				if (general.ScanLstGeneralDynamicPriority_A7915.Value)
				{
					num2 = (short)804061187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_1AD:
				num2 = (short)965541896;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E8:
				num2 = (short)1715339271;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_220:
			return scanLstGeneralScanType_A.Value == 1;
			IL_38:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
			scanLstGeneralPriority2Type_A = general.ScanLstGeneralPriority2Type_A8748;
			scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
			num2 = (short)317915137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600286A RID: 10346 RVA: 0x00271FC8 File Offset: 0x002701C8
		public static bool ConScanMrbZnIsNotUnassigned(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1207894016;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)393936897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)750125060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_20A;
									}
									continue;
								case 2:
									goto IL_36E;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)
									{
										num = (short)1344798729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1580466176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									(featureNode[10175] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Features).TrkPerFeaturesScanListSelection_A9053.CalculateValidity();
									num = (short)1236205574;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1505558536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1313931267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1244594178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									(featureNode[10135] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Features).CnvPerLabtoolScanListSelection_A9054.CalculateApplicability();
									(featureNode[10135] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Features).CnvPerLabtoolScanListSelection_A9054.CalculateValidity();
									num = (short)844955655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_28D:
								num = (short)1463812101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20A:
								goto IL_28D;
							}
							IL_36E:
							goto IL_42A;
						}
						finally
						{
							num = (short)1280180224;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3A6;
									}
									continue;
								case 1:
									goto IL_3DC;
								case 2:
									enumerator.Dispose();
									num = (short)700514305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1998258178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3DC:;
						}
						goto IL_3DF;
						IL_42A:
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = scanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1682964485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						while (radioWide != null)
						{
							num = (short)1894113531;
							short num3 = num;
							num = (short)714465531;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)486801408;
								if (num != 0)
								{
								}
								num = (short)1818689539;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_29;
							}
						}
						goto IL_48C;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)904855560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					case 3:
						num = (short)1707671553;
						if (num != 0)
						{
						}
						goto IL_3DF;
					case 4:
						num = (short)1651900418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num = (short)821952516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.Labtool.RadWideLabtoolDynamicZoneScanCapability_42749.Value)
						{
							num = (short)2050818055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					case 7:
						return false;
					case 8:
						num = (short)2013986817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_54;
					IL_3DF:
					num = (short)630915078;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_48C:
				return scanListInnerSection.ScanLstScanListZone_A9718.Value > 0;
				IL_54:
				scanListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection);
				enumerator = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList).ReferencingNodes.GetEnumerator();
				num = (short)1398603776;
				short num4 = num;
				num = (short)1401094144;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600286B RID: 10347 RVA: 0x0027248C File Offset: 0x0027068C
		internal static bool conLookupTrkSysTypeForScanLst(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1185153025;
			if (num != 0)
			{
			}
			num = (short)2073034752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1139861576;
				short num3 = num;
				num = (short)685500488;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_161:
					general.ScanLstGeneralType_A9578.PointedField = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
					num = (short)1688666115;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)2132082688;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					break;
				}
				bool flag;
				for (;;)
				{
					IL_98:
					switch (num2)
					{
					case 0:
						if (trunkingSystem != null && flag)
						{
							num = (short)2040070144;
							short num4 = num;
							num = (short)2073034754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						general.ScanLstGeneralType_A9578.PointedField = null;
						num = (short)1657143297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						goto IL_138;
					case 3:
						return true;
					}
					goto IL_AF;
				}
				IL_138:
				goto IL_161;
				IL_AF:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
				global::AcpBusinessLayer.AcpRecRefField scanLstGeneralRecord_A = general.ScanLstGeneralRecord_A8921;
				flag = (general.ScanLstGeneralScanType_A9058.Value == 2);
				trunkingSystem = (scanLstGeneralRecord_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				num = (short)260767744;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_98;
			}
			}
		}

		// Token: 0x0600286C RID: 10348 RVA: 0x0027262C File Offset: 0x0027082C
		internal static bool ConScanTypeIsCnvAndDesignatedDataTxRxTypeIsFixed(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)215903514;
			short num2 = num;
			num = (short)882994458;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1800732673;
				if (num != 0)
				{
				}
				num = (short)1626013696;
				if (num != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
				if (general.ScanLstGeneralScanType_A9058.Value != 0)
				{
					num = (short)248250368;
					short num3 = num;
					return false;
				}
				break;
			}
			return general.ScanLstGeneralDesignatedDataTxRxType_A21525.Value == 1;
		}

		// Token: 0x0600286D RID: 10349 RVA: 0x002726FC File Offset: 0x002708FC
		internal static bool ConScanTypeIsNotVotingScanOrTxSteeringIsDis(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)997626716;
			short num2 = num;
			num = (short)146772828;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1419902976;
				if (num != 0)
				{
				}
				num = (short)680132609;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General;
				scanList = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList);
				if (general.ScanLstGeneralScanType_A9058.Value != 4)
				{
					num = (short)947322880;
					short num3 = num;
					return true;
				}
				break;
			}
			}
			return !scanList.Advanced.ScanLstAdvancedTxSteering_A9572.Value;
		}

		// Token: 0x0600286E RID: 10350 RVA: 0x002727DC File Offset: 0x002709DC
		internal static bool ConIsPriorityMonitorScanValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return true;
				case 1:
					if (index != 3)
					{
						num2 = (short)1437794310;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				case 2:
				{
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
					if (scanLstGeneralScanType_A.Value != 3)
					{
						num2 = (short)134217733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70;
				}
				case 3:
				{
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
					if (scanLstGeneralScanType_A.Value != 2)
					{
						num2 = (short)1030553604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70;
				}
				case 4:
					num2 = (short)352714754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1488453632;
					short num3 = num2;
					num2 = (short)488701959;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_A2;
				case 7:
				{
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
					if (scanLstGeneralScanType_A.Value != 1)
					{
						num2 = (short)587464704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_70;
				}
				}
				goto IL_30;
				IL_70:
				num2 = (short)2009464833;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A2:
			return index == 2;
			IL_152:
			num2 = (short)906586538;
			short num4 = num2;
			num2 = (short)81095082;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_30:
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058;
				num2 = (short)1779892227;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1880031233;
				if (num2 != 0)
				{
				}
				num2 = (short)123731968;
				if (num2 != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x0600286F RID: 10351 RVA: 0x002729AC File Offset: 0x00270BAC
		internal static bool ConIsPriorityOneAndTwoValidforPriorityTwo(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_AA;
				case 1:
					num2 = (short)1871446017;
					if (num2 != 0)
					{
					}
					if (scanLstGeneralScanType_A.Value != 1)
					{
						num2 = (short)2031878149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AA;
				case 2:
					num2 = (short)404881416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_EA;
				case 4:
				{
					num2 = (short)682977746;
					short num3 = num2;
					num2 = (short)371091922;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A5;
					default:
						num2 = (short)1210122240;
						if (num2 != 0)
						{
						}
						if (scanLstGeneralScanType_A.Value != 2)
						{
							num2 = (short)1820393479;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AA;
					}
					break;
				}
				case 5:
					goto IL_A5;
				case 6:
					if (general.ScanLstGeneralPriority1Type_A8745.Value == 2)
					{
						num2 = (short)1878196227;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					num2 = (short)529465353;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!general.ScanLstGeneralDynamicPriority_A7915.Value)
					{
						num2 = (short)1812987904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					if (scanLstGeneralScanType_A.Value == 0)
					{
						num2 = (short)215613442;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_38;
				IL_A5:
				num2 = (short)640942084;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_AA:
				num2 = (short)667877382;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EA:
			num2 = (short)1197408256;
			short num4 = num2;
			return index != 2;
			IL_38:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
			scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
			num2 = (short)1620246529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002870 RID: 10352 RVA: 0x00272BE0 File Offset: 0x00270DE0
		public static bool ConScanTypeSetMaxChannels(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)332136448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListMembers scanListMembers;
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (scanListMembers != null)
						{
							num = (short)1259732998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
						if (scanListInnerRecset != null)
						{
							num = (short)1584594952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
						goto IL_1C4;
					case 3:
						num = (short)711131140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
						goto IL_146;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset = scanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset;
						num = (short)938213377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)470870759;
						short num3 = num;
						num = (short)263908071;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12D;
						default:
							goto IL_109;
						}
						break;
					}
					case 8:
					{
						int value = scanLstGeneralScanType_A.Value;
						num = (short)249233417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						int value;
						switch (value)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							scanListInnerRecset.SetMax(30);
							goto IL_12D;
						}
						case 1:
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							scanListInnerRecset.SetMax(250);
							num = (short)17039360;
							short num4 = num;
							num = (short)2033319946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							scanListInnerRecset.SetMax(50);
							num = (short)1509490695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							scanListInnerRecset.SetMax(10);
							num = (short)696254466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)790560771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						return true;
					}
					goto IL_5A;
					IL_12D:
					num = (short)1873215493;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_109:
				num = (short)1020264448;
				if (num != 0)
				{
				}
				IL_146:
				return true;
				IL_1C4:
				num = (short)1917648897;
				if (num != 0)
				{
				}
				return true;
				IL_5A:
				scanLstGeneralScanType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General).ScanLstGeneralScanType_A9058;
				scanListMembers = (self.Parent[10132] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListMembers);
				num = (short)1985347584;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002871 RID: 10353 RVA: 0x00272E90 File Offset: 0x00271090
		public static bool ConIsScanDesignatedTxMbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)180617216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				global::AcpBusinessLayer.AcpListField scanLstGeneralDesignatedVoiceTxMemberType_A;
				bool flag;
				global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedVoiceTxMember_A;
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num = (short)175177760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					}
					case 1:
						goto IL_120;
					case 2:
						if (scanLstGeneralDesignatedVoiceTxMemberType_A.Value == 1)
						{
							num = (short)216203286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)584974346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)647299080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46B;
					}
					case 4:
						num = (short)527499266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1914306580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1171390465;
						if (num != 0)
						{
						}
						goto IL_120;
					case 7:
						return false;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						flag = !conventionalPersonality.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value;
						num = (short)1381892129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						return false;
					case 10:
						goto IL_2CA;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner == null)
						{
							num = (short)744751118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1560150043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (scanLstGeneralDesignatedVoiceTxMember_A.RefRecset == null)
						{
							num = (short)456785929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)156499989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_120;
					case 14:
						flag = false;
						num = (short)445317126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag = false;
						num = (short)700579868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (scanLstGeneralDesignatedVoiceTxMemberType_A.Value != 2)
						{
							num = (short)1519124499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						goto IL_35E;
					case 18:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
						if (scanLstScanListChannel_A.Value == 0)
						{
							num = (short)909312007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanLstScanListChannel_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						num = (short)1955528715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						num = (short)1350172695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_21B;
					case 21:
						if (index >= 1)
						{
							num = (short)1824849951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
					{
						num = (short)1414233441;
						short num3 = num;
						num = (short)307068257;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_288;
						default:
							num = (short)1090977792;
							if (num != 0)
							{
							}
							num = (short)1404764186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 23:
						goto IL_288;
					case 24:
						flag = false;
						num = (short)2131689473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						if (index > scanLstGeneralDesignatedVoiceTxMember_A.RefRecset.Count)
						{
							num = (short)1171390494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanLstGeneralDesignatedVoiceTxMember_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						num = (short)1329135645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (scanLstGeneralScanType_A.Value != 0)
						{
							num = (short)736493568;
							short num4 = num;
							num = (short)1522728965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1270939665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality == null)
						{
							num = (short)1858142232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1047199744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_120;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner == null)
						{
							num = (short)321978383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620;
						num = (short)1208418322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						goto IL_26A;
					case 31:
						num = (short)33030169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1591083011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_120;
					}
					goto IL_B7;
					IL_120:
					num = (short)415563792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_288:
					if (scanLstGeneralDesignatedVoiceTxMemberType_A.Value != 3)
					{
						num = (short)2022637572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
					IL_46B:
					flag = false;
					num = (short)1886846989;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_21B:
				bool flag2 = scanLstGeneralScanType_A.Value == 4;
				goto IL_361;
				IL_26A:
				return false;
				IL_2CA:
				flag2 = false;
				goto IL_361;
				IL_35E:
				flag2 = true;
				IL_361:
				return flag2 && flag;
				IL_B7:
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General;
				general.ScanLstGeneralDesignatedVoiceTxMember_A7830.CalculateApplicability();
				scanLstGeneralDesignatedVoiceTxMemberType_A = general.ScanLstGeneralDesignatedVoiceTxMemberType_A21524;
				scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
				scanLstGeneralDesignatedVoiceTxMember_A = general.ScanLstGeneralDesignatedVoiceTxMember_A7830;
				flag = false;
				num = (short)1775108108;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002872 RID: 10354 RVA: 0x002734E8 File Offset: 0x002716E8
		public static bool ConIsScanChanMbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)560594944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F2;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
				bool flag6;
				bool flag7;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
				bool flag9;
				bool flag10;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection;
				global::AcpBusinessLayer.AcpField<bool> scanLstAdvancedTxSteering_A;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner;
					bool flag4;
					int num5;
					bool flag5;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num9;
					int num10;
					global::System.Collections.Generic.List<int> list;
					bool flag11;
					int num11;
					switch (num2)
					{
					case 0:
						num = (short)535953409;
						if (num != 0)
						{
						}
						num = (short)2043216135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						frequencyOptionsInner = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner);
						num = (short)1943535861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2;
						if (frequencyOptionsInner2 != null)
						{
							num = (short)1235812606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3;
						if (frequencyOptionsInner3.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65534)
						{
							num = (short)1975517233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 4:
						if (channelAssignmentListInner != null)
						{
							num = (short)1413349465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2021;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698;
						num = (short)2058092801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1220673637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.Value == 0)
						{
							num = (short)721748122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)965017827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A2;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A2.Features.CnvPerFeaturesMixedVoteScanEnable_A38723)
						{
							num = (short)387317926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF6;
					}
					case 9:
						num = (short)2038563078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)870711403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2E3A;
					case 12:
						num = (short)279249173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)1381040333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)1397817561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
						if (conventionalPersonality2 != null)
						{
							num = (short)1158480040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 16:
						num = (short)2143223936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 0)
						{
							num = (short)706543911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						goto IL_22DC;
					case 19:
						if (scanLstGeneralScanType_A.Value == 2)
						{
							num = (short)1784545455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F1;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5;
						if (frequencyOptionsInner5.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65534)
						{
							num = (short)1253834966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 21:
						if (talkgroupInner != null)
						{
							num = (short)1011155226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxSquelchType_A9426.Value == 3)
						{
							num = (short)1675297017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 23:
						num = (short)267059437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)830013637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
						if (conventionalPersonality2.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value == 1)
						{
							num = (short)1232011374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1930231871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						num = (short)258277520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1366360295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1403;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.Value != 0)
						{
							num = (short)1973747764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 29:
						num = (short)1874264129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)1191248127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
						if (conventionalPersonality2.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value)
						{
							num = (short)1825636653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698;
						num = (short)100597853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						return false;
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxSquelchType_A9426.Value == 2)
						{
							num = (short)1813577828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1741357078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						num = (short)662503580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)1758068900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 36:
						goto IL_2E3A;
					case 37:
						return false;
					case 38:
						num = (short)1882128631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1209401550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1455816894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality != null)
						{
							num = (short)311689263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 42:
						return false;
					case 43:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2;
						if (frequencyOptionsInner2.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 != null)
						{
							num = (short)1748959261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 44:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)467337277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 45:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3 == null)
						{
							num = (short)1663631657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2047082697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)1121517606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_352B;
					case 47:
						goto IL_46B0;
					case 48:
						return false;
					case 49:
						goto IL_30C5;
					case 50:
						num = (short)275644444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_31C9;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner3;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner3.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1796604017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						int num3;
						if (num3 + conventionalPersonalityForZnChanCfgChannelsPersonality_A3.FrequencyOptions.EmbeddedRecset.Count > 30)
						{
							num = (short)983302291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)969736278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						if (radioInformation != null)
						{
							num = (short)1893203980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4729;
					case 55:
						num = (short)1115816054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)1345061057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 57:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560 != null)
						{
							num = (short)1451819021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					case 58:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.Features.CnvPerFeaturesMixedVoteScanEnable_A38723)
						{
							num = (short)1235878139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)845807713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						return false;
					case 60:
						num = (short)281149485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)838598869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5;
						if (frequencyOptionsInner5.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 != null)
						{
							num = (short)1933901858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 63:
					{
						bool flag3;
						if (!flag3)
						{
							num = (short)362545256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1952121072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						num = (short)967966962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2;
						if (frequencyOptionsInner2.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value != 65535)
						{
							num = (short)257294419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 66:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
						{
							num = (short)1776877721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 67:
					{
						int num4;
						if (num4 + 1 > 3)
						{
							num = (short)1628176432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1182728245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						num = (short)950337582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
						if (!conventionalPersonality3.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value)
						{
							num = (short)1028456750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5B;
					}
					case 70:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 65535)
						{
							num = (short)792068242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2;
						if (frequencyOptionsInner2.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value == 65534)
						{
							num = (short)1724645394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 72:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A2;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner4;
						if ((conventionalPersonalityForZnChanCfgChannelsPersonality_A2 = channelAssignmentListInner4.ChannelAssignmentListInnerSection.ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698) != null)
						{
							num = (short)375980306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF6;
					}
					case 73:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2;
						if (talkgroupInner2.TalkgroupInnerSection.TrkPerTalkgroupTGWACNID_A19716.Value != 0)
						{
							num = (short)2049573097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4923;
					}
					case 74:
						if (zoneChannelAssignment != null)
						{
							num = (short)453771332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 75:
						if (scanLstScanListChannel_A.RefRecset.Count > index)
						{
							num = (short)531562656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 76:
						goto IL_39D0;
					case 77:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205.Value != talkgroupInner2.TalkgroupInnerSection.TrkPerTalkgroupTGWACNID_A19716.Value)
						{
							num = (short)151584889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4923;
					}
					case 78:
						return true;
					case 79:
					{
						if (flag4)
						{
							num = (short)1972240555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2 = scanList.General.ScanLstGeneralRecord_A8921.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						talkgroupInner = (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner);
						num = (short)1261109289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
						num = (short)410583117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality2;
						num5 = trunkingPersonality2.General.TrkPerGeneralSystem_A9237.Value;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality2.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						num = (short)1228800195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044 != null)
						{
							num = (short)1759707366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 83:
						num = (short)1706164295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2;
						if (talkgroupInner2 != null)
						{
							num = (short)530972752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30CA;
					}
					case 85:
						return false;
					case 86:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						global::System.Collections.Generic.HashSet<int> hashSet;
						if (hashSet.Contains(conventionalPersonalityForZnChanCfgChannelsPersonality_A3.NodeId))
						{
							num = (short)1436221482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 87:
						num = (short)696582256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_2231;
					case 89:
						goto IL_D40;
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
						if (conventionalPersonality3 != null)
						{
							num = (short)1265369381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FD;
					}
					case 91:
						return false;
					case 92:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)1917780103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CEC;
					case 93:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)735707176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 94:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner5;
						if (channelAssignmentListInner5.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)359137340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 95:
						if (channelAssignmentListInner2.Position > 48)
						{
							num = (short)1987903691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340E;
					case 96:
						return false;
					case 97:
					{
						int num3;
						if (num3 + 1 > 30)
						{
							num = (short)712310966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 98:
						flag5 = true;
						num = (short)1416822820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
					{
						int num6;
						if (num6 > 0 && flag5)
						{
							num = (short)1934033190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CEC;
					}
					case 100:
						goto IL_1E12;
					case 101:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 65535)
						{
							num = (short)1955987739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 102:
						if (scanLstGeneralScanType_A.Value != 3)
						{
							num = (short)1760886848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2082;
					case 103:
						num = (short)1173749854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						return false;
					case 105:
						if (index == 0)
						{
							num = (short)224133343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1157169391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.FrequencyOptions.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value)
						{
							num = (short)287440987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 107:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							num = (short)1283719367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 108:
						num = (short)1432158265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num = (short)2057044109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						num = (short)189530139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (scanList.General.ScanLstGeneralRecord_A8921.Value == trunkingPersonality.General.TrkPerGeneralSystem_A9237.Value)
						{
							num = (short)997785727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 112:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3;
						if (frequencyOptionsInner3.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281 != null)
						{
							num = (short)297992384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 113:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)1032782059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 114:
						num = (short)528351298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						num = (short)272433410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
					{
						int num3;
						if (num3 + 1 > 30)
						{
							num = (short)1755447381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 117:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value != talkgroupInner2.TalkgroupInnerSection.TrkPerTalkgroupTGSystemID_A19715.Value)
						{
							num = (short)343343357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30CA;
					}
					case 118:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2;
						if (trunkingSystem2.General.TrkSysGeneralCoverageType_A7782.Value == 6)
						{
							num = (short)1961558286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1911095320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 119:
						num = (short)1062010900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)1186660367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						num = (short)623968329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						return flag6;
					case 123:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 == 2)
						{
							num = (short)794886220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 124:
						num = (short)494665763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						try
						{
							num = (short)407502885;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1450508321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									if (!conventionalPersonality2.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value)
									{
										num = (short)1563820070;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2661;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner6;
									if (channelAssignmentListInner6.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
									{
										num = (short)1612972042;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality4;
									if (conventionalPersonality2.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value != conventionalPersonality4.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574.Value)
									{
										num = (short)1577189401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A61;
								}
								case 4:
									goto IL_2A61;
								case 5:
									goto IL_2661;
								case 6:
									flag7 = false;
									num = (short)783089672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									int num7;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (num7 == frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.Value)
									{
										num = (short)2041905170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2661;
								}
								case 8:
									goto IL_274C;
								case 9:
								{
									bool flag = false;
									num = (short)209846288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner6;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6 = channelAssignmentListInner6.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality4 = channelAssignmentListInner6.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)1607598094;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)64684033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_2AFC;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)386596899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									acpRecRefField = (acpFeatureNode[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner6 = acpRecRefField.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)351862801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner6 != null)
									{
										num = (short)951123992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									goto IL_27A9;
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner6;
									if (channelAssignmentListInner6 != null)
									{
										num = (short)1670184992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 18:
									goto IL_2876;
								case 19:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDPLCode_A9409.Value == frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDPLCode_A9409.Value)
									{
										num = (short)273022976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25F7;
								}
								case 20:
									num = (short)1970733058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_25F7;
								case 22:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxSquelchType_A9426.Value != frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxSquelchType_A9426.Value)
									{
										num = (short)336723999;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2A05;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner6;
									if (channelAssignmentListInner6 != null)
									{
										num = (short)483262484;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 24:
									num = (short)1005322279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									bool flag8 = false;
									num = (short)1231814660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxNetworkID_A9550.Value != frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxNetworkID_A9550.Value)
									{
										num = (short)1799356425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_27A9;
								}
								case 27:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (scanListInnerRecset.IndexOf(self.Parent) != scanListInnerRecset.IndexOf(acpFeatureNode))
									{
										num = (short)759496715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 28:
									num = (short)1305083931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									goto IL_2A05;
								case 30:
									goto IL_2B72;
								case 31:
								{
									bool flag3 = false;
									num = (short)223936541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 32:
									num = (short)190513175;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value != frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDPLInvert_A9410.Value)
									{
										num = (short)1811121625;
										short num8 = num;
										num = (short)818906585;
										switch ((num8 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2876;
										default:
											num = (short)1786118144;
											if (num != 0)
											{
											}
											num = (short)1673134101;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxPLCode_A9418.Value != frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxPLCode_A9418.Value)
									{
										num = (short)111607814;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_274C;
								}
								case 35:
									num = (short)920191006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner6;
									if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value != frequencyOptionsInner6.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value)
									{
										num = (short)2070085637;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2AFC;
								}
								case 37:
									switch (0)
									{
									case 0:
										goto IL_24F7;
									}
									continue;
								case 38:
									num = (short)1222115335;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality4;
									if (conventionalPersonality4 != null)
									{
										num = (short)1507262492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_24F7;
								IL_25F7:
								flag9 = false;
								num = (short)676134927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2661:
								flag10 = false;
								num = (short)1673920524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_274C:
								num = (short)370868243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27A9:
								num = (short)67764246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2876:
								num = (short)84934692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A05:
								num = (short)371064866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2A61:
								num = (short)1727922202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2ABD:
								num = (short)1427505165;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_24F7:
								goto IL_2ABD;
								IL_2AFC:
								num = (short)974127107;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B72:
							goto IL_235D;
						}
						finally
						{
							num = (short)1165492224;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2BA9;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)489947138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2BE3;
								}
								IL_2BA9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)791347201;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BE3:;
						}
						goto IL_2BE6;
						IL_235D:
						num = (short)657522846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand2;
						if (frequencyBand != frequencyBand2)
						{
							num = (short)36372512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5B;
					}
					case 127:
						num = (short)825425937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 != null)
						{
							num = (short)356319377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 129:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.ASTROTalkgroup != null)
						{
							num = (short)1976303725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 130:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2;
						if (frequencyOptionsInner2.FrequencyOptionsInnerSection != null)
						{
							num = (short)1846673711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 131:
						num = (short)1886585016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						num = (short)1220870432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
					{
						bool flag2 = radioInformation.Labtool.RadioInfoLabToolQA00631DvrsPsuActivation_A40166.Value;
						num = (short)877199601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 134:
						num = (short)1308950597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand3 = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand4 = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand2 = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
						int num6 = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).Position - 1;
						flag5 = false;
						num9 = 0;
						num = (short)1098121371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 136:
					{
						if (!scanListInnerSection.ScanLstScanListZone_A9718.Valid)
						{
							num = (short)920191013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag2 = false;
						num = (short)1058406454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 137:
						num = (short)1104347422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3;
						if (frequencyOptionsInner3.FrequencyOptionsInnerSection != null)
						{
							num = (short)522125399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 139:
						goto IL_228A;
					case 140:
						goto IL_3762;
					case 141:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 != null)
						{
							num = (short)315555964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 142:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand3;
						if (frequencyBand != frequencyBand3)
						{
							num = (short)797245536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CEC;
					}
					case 143:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand = global::ConstraintHelper.UtilityMack.GetRxBand(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxFrequency_A8911.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3 = frequencyOptionsInner.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1376846113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 144:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)
						{
							num = (short)1555496965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 145:
						num = (short)1774714910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						num = (short)179962108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						return false;
					case 148:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner3 = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						num = (short)1391263916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 149:
						try
						{
							num = (short)546635785;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num3;
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality5;
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = (acpFeatureNode2[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
									num = (short)1704787988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)74317837;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField3;
									if (acpRecRefField3.ParentNode != acpFeatureNode2)
									{
										num = (short)244056076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner7 = acpRecRefField2.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)2096955400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField4;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = acpRecRefField4.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									num = (short)647364626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField4;
									if (acpRecRefField4 != null)
									{
										num = (short)448856069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)1083637789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_41F9;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner7;
									if (channelAssignmentListInner7 != null)
									{
										num = (short)286523416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_41F4;
									}
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner7;
									if (channelAssignmentListInner7.ChannelAssignmentListInnerSection.ChannelsActiveChannel.Value)
									{
										num = (short)847708177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_41F9;
								}
								case 11:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)888078364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField4 = (acpFeatureNode2[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListZone_A9718;
									num = (short)1327497222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)705101831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (conventionalPersonality5.Features.CnvPerFeaturesMixedVoteScanEnable_A38723)
									{
										num = (short)112918547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num3++;
									num = (short)1334444047;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_463E;
								case 16:
									goto IL_45F0;
								case 17:
									num3++;
									num = (short)714735643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
									if (zoneChannelAssignment2 != null)
									{
										num = (short)1081344000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 19:
									num = (short)716898329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									if (acpRecRefField2 != null)
									{
										num = (short)1240334340;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
									if (conventionalPersonality5 != null)
									{
										num = (short)1507524610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 22:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner7;
									conventionalPersonality5 = channelAssignmentListInner7.ChannelAssignmentListInnerSection.ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698;
									num = (short)1625423893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									global::System.Collections.Generic.HashSet<int> hashSet;
									hashSet.Add(conventionalPersonality5.NodeId);
									num = (short)2019819536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									num = (short)1035665411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::System.Collections.Generic.HashSet<int> hashSet;
									if (!hashSet.Contains(conventionalPersonality5.NodeId))
									{
										num = (short)210698263;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_45F0;
								}
								case 26:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
									if (acpRecRefField2.ReferencedIndex != 0)
									{
										num = (short)1278214166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 28:
									num = (short)1713438734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									num = (short)1877606410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_41F4;
								IL_41F9:
								num = (short)807075866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45B0:
								num = (short)1316093963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_41F4:
								goto IL_45B0;
								IL_45F0:
								int num4;
								num4++;
								num3 += conventionalPersonality5.FrequencyOptions.EmbeddedRecset.Count;
								num = (short)853737473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_463E:
							goto IL_46EC;
						}
						finally
						{
							num = (short)486932482;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)671678465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_46AD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4675;
									}
									continue;
								}
								IL_4675:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1702559744;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46AD:;
						}
						goto IL_46B0;
						IL_46EC:
						num = (short)977994003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						if (frequencyOptionsInner4 != null)
						{
							num = (short)1236009080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 151:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner;
						num = (short)631963732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 152:
						if (frequencyOptionsInner != null)
						{
							num = (short)2102395184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2021;
					case 153:
						num = (short)309264560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						num = (short)1721499933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						goto IL_3762;
					case 156:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5;
						if (frequencyOptionsInner5.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value != 65535)
						{
							num = (short)1486946423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 157:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)1044643840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 158:
					{
						bool flag8;
						if (!flag8)
						{
							num = (short)1297088750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)315097113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 159:
						num = (short)1344995439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 160:
						channelAssignmentListInner2 = (scanLstScanListChannel_A.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						num = (short)1062731908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.ASTROTalkgroup != null)
						{
							num = (short)340918288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 162:
						try
						{
							num = (short)1596063774;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality3;
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem3;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner8;
									if (!channelAssignmentListInner8.ChannelAssignmentListInnerSection.ChannelsActiveChannel.Value)
									{
										num = (short)2060845084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)951779338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									result = false;
									num = (short)1353777185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1957756935;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3 = (acpFeatureNode3[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									acpRecRefField = (acpFeatureNode3[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner8 = acpRecRefField.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)993918993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner8;
									if (channelAssignmentListInner8 != null)
									{
										num = (short)736231456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1518338075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)659619856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)2098987029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									result = false;
									num = (short)1004404755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)105775104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									int value;
									if (num5 != value)
									{
										num = (short)112853015;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_892;
								}
								case 11:
								{
									int value = trunkingPersonality3.General.TrkPerGeneralSystem_A9237.Value;
									num = (short)670760984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num10++;
									num = (short)561381389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (num10 > 50)
									{
										num = (short)2013724680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3;
									if (zoneChannelAssignment3.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)1731330073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_834;
								}
								case 15:
									if (list.Count >= 5)
									{
										num = (short)45613058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_892;
								case 16:
								{
									int value;
									if (!list.Contains(value))
									{
										num = (short)1742077981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_892;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3;
									if (zoneChannelAssignment3 != null)
									{
										num = (short)55967764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_834;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner8;
									if (channelAssignmentListInner8 != null)
									{
										num = (short)526385161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_834;
								}
								case 19:
									goto IL_C28;
								case 20:
									num = (short)1908211726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									goto IL_CCE;
								case 22:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (self.Parent != acpFeatureNode3)
									{
										num = (short)220725253;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 23:
									num = (short)1512243231;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									if (trunkingPersonality3 != null)
									{
										num = (short)1928265729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_892;
								case 25:
									num = (short)119275538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									if (trunkingPersonality3 != null)
									{
										num = (short)2048786443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 27:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem3 == trunkingSystem)
									{
										num = (short)767098892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 28:
									goto IL_834;
								case 29:
								{
									int value;
									list.Add(value);
									num = (short)1216020495;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									switch (0)
									{
									case 0:
										goto IL_7EE;
									}
									continue;
								case 31:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (!self.Parent.Equals(acpFeatureNode3))
									{
										num = (short)675086342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_892;
								}
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner8;
									trunkingPersonality3 = (channelAssignmentListInner8.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality);
									num = (short)707330074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 33:
									goto IL_88D;
								}
								IL_7F3:
								num = (short)1141047299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7EE:
								goto IL_7F3;
								IL_834:
								num = (short)298123268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_892:
								trunkingSystem3 = (trunkingPersonality3.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
								num = (short)817954838;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_88D:
							IL_C28:
							return result;
							IL_CCE:
							return true;
						}
						finally
						{
							num = (short)2025521152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_D05;
									}
									continue;
								case 1:
									goto IL_D3D;
								case 2:
									enumerator.Dispose();
									num = (short)211746817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_D05:
								if (enumerator == null)
								{
									break;
								}
								num = (short)496828418;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D3D:;
						}
						goto IL_D40;
					case 163:
						num = (short)103088186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						num = (short)68026542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality2 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						num = (short)810942675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 166:
						return false;
					case 167:
						if (channelAssignmentListInner != null)
						{
							num = (short)224854017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CEC;
					case 168:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						int num7 = frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.Value;
						num = (short)1334444039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 169:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)1617953058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 170:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)1041236133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 171:
						return true;
					case 172:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner3;
						if (channelAssignmentListInner3 != null)
						{
							num = (short)923992114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 173:
						goto IL_352B;
					case 174:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)293404953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 175:
						num = (short)405995599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272.Value)
						{
							num = (short)1016529004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 177:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem != null)
						{
							num = (short)1867382793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30CA;
					}
					case 178:
						if (scanLstScanListChannel_A.OneBased)
						{
							num = (short)1698365628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B4B;
					case 179:
						num = (short)186515617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044 != null)
						{
							num = (short)1080492254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 181:
						if (scanLstGeneralScanType_A.Value == 4)
						{
							num = (short)524288248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1814233107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						return false;
					case 183:
						num = (short)15073283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 0)
						{
							num = (short)1045889034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 185:
						return true;
					case 186:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5;
						if (frequencyOptionsInner5.FrequencyOptionsInnerSection != null)
						{
							num = (short)1088225564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 187:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner5 = channelAssignmentListInner2;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality5 = null;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3 = channelAssignmentListInner5.ChannelAssignmentListInnerSection.ConventionalPersonalityForZnChanCfgChannelsPersonality_A8698;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField2 = null;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField4 = null;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField3 = scanLstScanListChannel_A;
						int num4 = 0;
						int num3 = 0;
						global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
						num = (short)1295122656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 188:
						num = (short)1102053655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand3;
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand4;
						if (frequencyBand3 == frequencyBand4)
						{
							num = (short)947585122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2021;
					}
					case 190:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A4;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A4.RxOptions != null)
						{
							num = (short)793968872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 191:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 0)
						{
							num = (short)184549620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 192:
						num = (short)1333330218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						flag6 = false;
						int num7 = 0;
						flag10 = true;
						bool flag8 = true;
						bool flag = true;
						bool flag3 = true;
						flag7 = true;
						flag9 = true;
						num = (short)1086128278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 194:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560 != null)
						{
							num = (short)1892941993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					case 195:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 0)
						{
							num = (short)570228742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 196:
						if (radioInformation.Labtool.RadioInfoLabToolQA00631DvrsPsuActivation_A40166 != null)
						{
							num = (short)1209860229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4729;
					case 197:
						num = (short)810483958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 198:
						num = (short)1677525087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
						num = (short)1947402449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 200:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner2 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner;
						num = (short)1530658818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 201:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
						{
							num = (short)1124007975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					case 202:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanList.General.ScanLstGeneralDesignatedDataMember_A7829.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						num = (short)1980170536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 203:
						return false;
					case 204:
						goto IL_2E3A;
					case 205:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3;
						if (frequencyOptionsInner3 != null)
						{
							num = (short)1802109196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 206:
						if (scanList.General.ScanLstGeneralDesignatedDataTxRxType_A21525.Value == 1)
						{
							num = (short)2112749770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					case 207:
						goto IL_3B4B;
					case 208:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)1075314847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 209:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320 != 3)
						{
							num = (short)1644363996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39D0;
					}
					case 210:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2;
						if (talkgroupInner.TalkgroupInnerSection.TrkPerTalkgroupTGSystemID_A19715.Value != trunkingSystem2.General.TrkSysGeneralSystemID_A9239.Value)
						{
							num = (short)751042699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 211:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality2;
						if (trunkingPersonality2 != null)
						{
							num = (short)383254609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 212:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand4 = global::ConstraintHelper.UtilityMack.GetTxBand(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.Value);
						num = (short)1320550589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 213:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.RxOptions != null)
						{
							num = (short)1026097175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 214:
						goto IL_375D;
					case 215:
						if (scanListInnerSection.ScanLstScanListZone_A9718.Value == 0)
						{
							num = (short)910950478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 216:
						num = (short)2007367901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)623640842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 218:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner2;
						if (talkgroupInner2.TalkgroupInnerSection.TrkPerTalkgroupTGSystemID_A19715.Value != 0)
						{
							num = (short)1176830011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30CA;
					}
					case 219:
					{
						if (scanLstGeneralScanType_A.Value == 0)
						{
							num = (short)508100795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner4 = channelAssignmentListInner2;
						num = (short)2114388246;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 220:
						num = (short)1676738683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 221:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.RxOptions != null)
						{
							num = (short)873922840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 222:
						num = (short)2002845996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 223:
						num = (short)1503658199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
						if (!flag4)
						{
							num = (short)356057191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					case 225:
						num = (short)1288765546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2;
						if (trunkingSystem2 != null)
						{
							num = (short)1800077367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 227:
						flag11 = false;
						goto IL_1B95;
					case 228:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.LTE.DataProfBroadbandSource_A42858.Value == 1)
						{
							num = (short)483721441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 229:
						index--;
						num = (short)604635343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 230:
						num = (short)917241985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						return false;
					case 232:
						num = (short)655949906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 233:
						return false;
					case 234:
						return true;
					case 235:
						num = (short)256507918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 236:
						goto IL_2082;
					case 237:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A3;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A3.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044 != null)
						{
							num = (short)483197107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					}
					case 238:
						return false;
					case 239:
						if (scanLstScanListChannel_A.RefRecset == null)
						{
							num = (short)844955833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1673461938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner4;
						if (frequencyOptionsInner4.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxSquelchType_A9426.Value == 0)
						{
							num = (short)1614413875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)600047649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 241:
						goto IL_4729;
					case 242:
						if (scanLstGeneralScanType_A.Value == 1)
						{
							num = (short)456524012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 243:
						num = (short)120914106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
						goto IL_1824;
					case 245:
						if (frequencyOptionsInner != null)
						{
							num = (short)231211151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CEC;
					case 246:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (scanList.General.ScanLstGeneralRecord_A8921.Value == trunkingPersonality.General.TrkPerGeneralSystem_A9237.Value)
						{
							num = (short)104792356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 247:
						if (scanLstGeneralScanType_A.Value != 4)
						{
							num = (short)827523363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 248:
						num = (short)778371128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 249:
						goto IL_1DC9;
					case 250:
					{
						if (flag4)
						{
							num = (short)1997144340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = null;
						num = (short)839319812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 251:
						num = (short)2086207555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 252:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2;
						if (talkgroupInner.TalkgroupInnerSection.TrkPerTalkgroupTGWACNID_A19716.Value != trunkingSystem2.General.TrkSysGeneralHomeWACNID_A8205.Value)
						{
							num = (short)247005299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2231;
					}
					case 253:
						num = (short)1344930010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 254:
						num = (short)54001794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 255:
						num = (short)1564606621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 256:
						num = (short)389545992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 257:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)1416364248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 258:
						if (talkgroupInner.TalkgroupInnerSection.TrkPerTalkgroupTGWACNID_A19716.Value == 0)
						{
							num = (short)1501036632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 259:
						try
						{
							num = (short)1424752640;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F4A;
									}
									continue;
								case 1:
									num = (short)18546702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment4;
									if (zoneChannelAssignment4 != null)
									{
										num = (short)764870662;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FF5;
								}
								case 3:
									num = (short)149684245;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner9;
									if (channelAssignmentListInner9 != null)
									{
										num = (short)890044425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_FAD;
								case 6:
									num = (short)78446612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1636565011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num11++;
									num = (short)7667728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1949302796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									result = false;
									num = (short)1000669189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_FF5;
								case 12:
									if (acpRecRefField.Value != 0)
									{
										num = (short)2123431939;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner9;
									if (channelAssignmentListInner9 != null)
									{
										num = (short)258867207;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FF5;
								}
								case 14:
									goto IL_127F;
								case 15:
									num = (short)1718026258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (num11 >= 10)
									{
										num = (short)394133514;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 17:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)643301377;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment4 = (acpFeatureNode4[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
									acpRecRefField = (acpFeatureNode4[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListChannel_A7620;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner9 = acpRecRefField.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)375128066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner9;
									if (channelAssignmentListInner9.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
									{
										num = (short)673841160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 19:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner9;
									if (!channelAssignmentListInner9.ChannelAssignmentListInnerSection.ChannelsActiveChannel.Value)
									{
										num = (short)1528692747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment4;
									if (zoneChannelAssignment4.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
									{
										num = (short)116654102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FF5;
								}
								case 21:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (self.Parent != acpFeatureNode4)
									{
										num = (short)841547791;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 22:
									num = (short)712704013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F4A;
								IL_FF5:
								num = (short)1475608580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1104:
								num = (short)123994129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4A:
								goto IL_1104;
							}
							IL_FAD:
							return result;
							IL_127F:
							return true;
						}
						finally
						{
							num = (short)507379712;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12B7;
									}
									continue;
								case 1:
									goto IL_12EE;
								case 2:
									enumerator.Dispose();
									num = (short)1338769409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)562495490;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12EE:;
						}
						goto IL_12F1;
					case 260:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)445448218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1304690858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 261:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner4;
						if (channelAssignmentListInner4.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)998244608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF6;
					}
					case 262:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value == 6)
						{
							num = (short)883622039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30CA;
					}
					case 263:
						if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560 != null)
						{
							num = (short)1321599176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36EA;
					case 264:
						num = (short)1931608136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 265:
					{
						int num6;
						if (num9 >= num6)
						{
							num = (short)2082013184;
							short num12 = num;
							num = (short)1565327371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						channelAssignmentListInner = ((scanListInnerRecset[num9] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						num = (short)576585732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 266:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem != null)
						{
							num = (short)1363280003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 267:
						num = (short)972357901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 268:
						num = (short)1618280586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 269:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.ASTROTalkgroup.CnvPerASTROTalkgroupOptionsTalkGroupEnable_A9272 != null)
						{
							num = (short)841089138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 270:
						num = (short)2112225488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						num = (short)1609826396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 272:
						num = (short)1246298308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 273:
						if (scanLstAdvancedTxSteering_A)
						{
							num = (short)1411055738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1874264095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 274:
						num = (short)825884933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 275:
						if (!flag4)
						{
							num = (short)1986920611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1794179188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 276:
						return true;
					case 277:
						if (radioInformation.Labtool != null)
						{
							num = (short)657195280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4729;
					case 278:
						if (!flag4)
						{
							num = (short)807207176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF6;
					case 279:
						if (index - 1 >= 0)
						{
							num = (short)2124611813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B4B;
					case 280:
						num = (short)1229979828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						num = (short)650772674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 282:
						num = (short)1893073122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						num = (short)457048241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 284:
						num = (short)1986723902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
						flag11 = !conventionalPersonality2.Features.CnvPerLabtoolAutomaticScan_A7527.Value;
						goto IL_1B95;
					}
					case 286:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation2;
						if (radioInformation2.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value == 13)
						{
							num = (short)1979908294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340E;
					}
					case 287:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
						if (!conventionalPersonality3.RxOptions.CnvPerRxOptionsReceiveOnlyPersonality_A8916.Value)
						{
							num = (short)1111752916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FD;
					}
					case 288:
					{
						if (channelAssignmentListInner2 == null)
						{
							num = (short)479920362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation2 = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1791164715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 289:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
						if (conventionalPersonality3 != null)
						{
							num = (short)301662342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5B;
					}
					case 290:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner5;
						if (frequencyOptionsInner5 != null)
						{
							num = (short)1118503155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					}
					case 291:
						flag4 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.ChannelsActiveChannel.Value;
						num = (short)1543831725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 292:
						num = (short)1910505663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 293:
						num = (short)1577451807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 294:
						num = (short)1103167630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 295:
						num = (short)842006598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner != null)
						{
							num = (short)1347027092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E8B;
					}
					case 297:
						goto IL_207D;
					case 298:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner frequencyOptionsInner3;
						if (frequencyOptionsInner3.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsASTROTalkgroupID_A9281.Value != 65535)
						{
							num = (short)971374775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 299:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation2;
						if (radioInformation2 != null)
						{
							num = (short)36438153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340E;
					}
					case 300:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonalityForZnChanCfgChannelsPersonality_A;
						if (conventionalPersonalityForZnChanCfgChannelsPersonality_A.ASTROTalkgroup != null)
						{
							num = (short)2125857035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B7;
					}
					case 301:
						return flag6;
					case 302:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand2 = global::ConstraintHelper.UtilityMack.GetTxBand(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.Value);
						num = (short)2094727294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 303:
						num = (short)1299316779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 304:
					{
						global::ConstraintHelper.UtilityMack.FrequencyBand frequencyBand3 = global::ConstraintHelper.UtilityMack.GetRxBand(frequencyOptionsInner.FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxFrequency_A8911.Value);
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3 = frequencyOptionsInner.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)1025376346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4F2;
					IL_D40:
					frequencyOptionsInner = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsConventionalChannelReference_A20560.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner);
					num = (short)683540632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E8B:
					num = (short)1747255340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12F1:
					num = (short)1255473254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FD:
					flag5 = true;
					num = (short)1680343244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187E:
					enumerator = scanListInnerRecset.GetEnumerator();
					num = (short)1228931197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B95:
					flag6 = flag11;
					num = (short)1637220623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5B:
					num = (short)2053439587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2021:
					num9++;
					num = (short)222429324;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2082:
					num11 = 0;
					list = new global::System.Collections.Generic.List<int>();
					num5 = 0;
					num10 = 0;
					num = (short)1043529978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2231:
					num = (short)1059389650;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CEC:
					num = (short)1116012817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DF6:
					num = (short)1054867637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E3A:
					channelAssignmentListInner = (scanLstScanListChannel_A.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
					num = (short)500695207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30CA:
					num10 = 1;
					enumerator = scanListInnerRecset.GetEnumerator();
					num = (short)1798111394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340E:
					flag4 = false;
					num = (short)1604124746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_352B:
					num = (short)1252983003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36EA:
					enumerator = scanListInnerRecset.GetEnumerator();
					num = (short)160563349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3762:
					num = (short)832569609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39D0:
					num = (short)1323040996;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B4B:
					num = (short)1953103947;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_46B0:
					num = (short)672792597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4729:
					num = (short)1278804073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48B7:
					enumerator = scanListInnerRecset.GetEnumerator();
					num = (short)88408323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4923:
					num = (short)1676214389;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1403:
				return flag6 && flag10;
				IL_1824:
				return channelAssignmentListInner2.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value != 65535;
				IL_1DC9:
				return flag6 && flag10 && flag9;
				IL_1E12:
				return flag6 && flag10 && flag7;
				IL_207D:
				return false;
				IL_228A:
				return talkgroupInner.TalkgroupInnerSection.TrkPerTalkgroupTGSystemID_A19715.Value == 0;
				IL_22DC:
				return false;
				IL_2BE6:
				return flag6 && flag10;
				IL_30C5:
				return false;
				IL_31C9:
				goto IL_2BE6;
				IL_375D:
				return false;
				IL_4F2:
				scanListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection);
				scanList = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList);
				scanLstGeneralScanType_A = scanList.General.ScanLstGeneralScanType_A9058;
				scanLstScanListChannel_A = scanListInnerSection.ScanLstScanListChannel_A7620;
				acpRecRefField = null;
				scanLstAdvancedTxSteering_A = scanList.Advanced.ScanLstAdvancedTxSteering_A9572;
				scanListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
				channelAssignmentListInner2 = null;
				global::AcpCommonLib.FeatureManager.GetFeature(2059);
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				zoneChannelAssignment = (scanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)1289420936;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x002780B0 File Offset: 0x002762B0
		public static bool ConIsScanZoneMbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)801243136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
				global::AcpBusinessLayer.AcpRecRefField scanLstScanListZone_A;
				global::AcpBusinessLayer.AcpRecRefField scanLstScanListZone_A2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						num = (short)600309766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1106509840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return true;
					case 4:
						num = (short)1562378253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment == null)
						{
							num = (short)787087383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
						num = (short)1896939528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (zoneChannelAssignment2.RSI != null)
						{
							num = (short)1540554752;
							short num3 = num;
							num = (short)731185154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E7;
					}
					case 7:
						return true;
					case 8:
						goto IL_1E0;
					case 9:
					{
						if (scanList.General.ScanLstGeneralScanType_A9058.Value != 4)
						{
							num = (short)886046727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = scanLstScanListZone_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1225981957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return false;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (zoneChannelAssignment2.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)818479121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.Labtool.RadWideLabtoolDynamicZoneScanCapability_42749.Value)
						{
							num = (short)2033385487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					}
					case 13:
					{
						if (index > scanLstScanListZone_A2.RefRecset.Count)
						{
							num = (short)331612181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2 = scanLstScanListZone_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)804735495;
						short num4 = num;
						num = (short)883902983;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6B2;
						default:
							num = (short)1397817344;
							if (num != 0)
							{
							}
							num = (short)2105278483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						num = (short)859832332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return false;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (zoneChannelAssignment2.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
						{
							goto IL_6B2;
						}
						goto IL_1E7;
					}
					case 17:
						num = (short)311820306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)863109134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (zoneChannelAssignment2 != null)
						{
							num = (short)664403969;
							if (num != 0)
							{
							}
							num = (short)1799094298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_234;
					}
					case 20:
						if (scanLstScanListZone_A2.RefRecset == null)
						{
							num = (short)443678720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2107506713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1BA;
					case 22:
						if (index == 0)
						{
							num = (short)1423835139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)592838676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return true;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment2;
						if (zoneChannelAssignment2 != null)
						{
							num = (short)1389297665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E7;
					}
					case 25:
						if (index >= 1)
						{
							num = (short)1871446020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						num = (short)518914059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
					IL_1E7:
					num = (short)253755401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_234:
					num = (short)790822936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B2:
					num = (short)589365258;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1BA:
				return false;
				IL_1E0:
				try
				{
					num = (short)821035014;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_422;
						case 1:
							num = (short)1788870656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (!self.Parent.Equals(acpFeatureNode))
							{
								num = (short)1332871171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							result = false;
							num = (short)1523253255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)465567746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1837105153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							scanLstScanListZone_A2 = (acpFeatureNode[10133] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection).ScanLstScanListZone_A9718;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3 = scanLstScanListZone_A2.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
							num = (short)835256329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_2C3;
							}
							continue;
						case 7:
							goto IL_403;
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3;
							if (zoneChannelAssignment3 != zoneChannelAssignment)
							{
								num = (short)2015952900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment3;
							if (zoneChannelAssignment3 != null)
							{
								num = (short)857538570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							num = (short)1121320968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2C5:
						num = (short)1152778245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C3:
						goto IL_2C5;
					}
					IL_403:
					return result;
					IL_422:;
				}
				finally
				{
					num = (short)448397312;
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
								goto IL_456;
							}
							continue;
						case 1:
							goto IL_48E;
						case 2:
							enumerator.Dispose();
							num = (short)1450049537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_456:
						if (enumerator == null)
						{
							break;
						}
						num = (short)737214466;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_48E:;
				}
				return true;
				IL_9A:
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection;
				scanList = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList);
				scanLstScanListZone_A = scanListInnerSection.ScanLstScanListZone_A9718;
				scanLstScanListZone_A2 = scanListInnerSection.ScanLstScanListZone_A9718;
				scanListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
				num = (short)606208022;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00278840 File Offset: 0x00276A40
		public static bool ConIsScanPriority1MbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1672675328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_22D;
					case 1:
						num = (short)629342243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
						if (scanLstGeneralPriority1Type_A.Value == 3)
						{
							num = (short)1311637511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					}
					case 3:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
						if (scanLstGeneralScanType_A.Value != 1)
						{
							num = (short)450166802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					}
					case 4:
						goto IL_3FA;
					case 5:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A;
						if (scanLstGeneralPriority2Type_A.Value != 1)
						{
							num = (short)1766785036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_489;
					}
					case 6:
						goto IL_484;
					case 7:
						goto IL_1BC;
					case 8:
						if (index == 0)
						{
							num = (short)1009188900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1169489948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1072562178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1617690651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1414463502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1530986519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
						if (scanLstGeneralScanType_A.Value != 2)
						{
							num = (short)202113048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner != null)
						{
							num = (short)372506634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					}
					case 15:
						goto IL_656;
					case 16:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A;
						if (index <= scanLstGeneralPriorityMember1_A.RefRecset.Count)
						{
							num = (short)1915224084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 17:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
						if (scanLstGeneralScanType_A.Value == 0)
						{
							num = (short)1283653632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 18:
						num = (short)1770782733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
						if (scanLstGeneralPriority1Type_A.Value != 1)
						{
							num = (short)1846804514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_656;
					}
					case 20:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2 = scanLstGeneralPriorityMember1_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = general.ScanLstGeneralPriorityMember2_A8749.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						num = (short)1259470869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner2 != null)
						{
							num = (short)178716683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 22:
						goto IL_179;
					case 23:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A;
						if (scanLstGeneralPriority2Type_A.Value == 3)
						{
							num = (short)1144193055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_179;
					}
					case 24:
						num = (short)896729105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1939537936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner2.ScanListInnerSection.ScanLstScanListChannel_A7620.Value == 0)
						{
							num = (short)1177288710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 27:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
						if (scanLstGeneralPriority1Type_A.Value != 1)
						{
							num = (short)1958019081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC;
					}
					case 28:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A;
						if (scanLstGeneralPriorityMember1_A.RefRecset != null)
						{
							num = (short)1016463361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 29:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
						if (scanLstGeneralPriority1Type_A.Value == 1)
						{
							num = (short)2003501060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner2 != scanListInner)
						{
							num = (short)1993408513;
							if (num != 0)
							{
							}
							num = (short)1825112086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 31:
						goto IL_489;
					case 32:
						num = (short)54919194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
						if (scanLstGeneralPriority1Type_A.Value == 3)
						{
							num = (short)1485766671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 34:
						num = (short)587333665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (index >= 1)
						{
							num = (short)1906049049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 36:
						num = (short)1851129885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner2.ScanListInnerSection.ScanLstScanListZone_A9718.Value != 0)
						{
							num = (short)377421856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					goto IL_C8;
					IL_179:
					num = (short)1868038163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC:
					num = (short)72876032;
					short num3 = num;
					num = (short)1956970501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					num = (short)92078088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					num = (short)132317214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_656:
					num = (short)125173797;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3FA:
				return false;
				IL_484:
				return false;
				IL_C8:
				num = (short)188561791;
				short num4 = num;
				num = (short)1836071295;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)975437824;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General;
					global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember1_A = general.ScanLstGeneralPriorityMember1_A8747;
					global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
					global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A = general.ScanLstGeneralPriority1Type_A8745;
					global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A = general.ScanLstGeneralPriority2Type_A8748;
					num = (short)1655111683;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00278EF4 File Offset: 0x002770F4
		public static bool ConIsScanPriority2MbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)457506816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				global::AcpBusinessLayer.AcpListField scanLstGeneralPriority2Type_A;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
				global::AcpBusinessLayer.AcpListField scanLstGeneralPriority1Type_A;
				global::AcpBusinessLayer.AcpRecRefField scanLstGeneralPriorityMember2_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_192;
					case 1:
						goto IL_300;
					case 2:
						num = (short)1182728192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)222429192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (scanLstGeneralScanType_A.Value != 1)
						{
							num = (short)443154452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 5:
						goto IL_135;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner != scanListInner2)
						{
							num = (short)1812856837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 7:
						if (scanLstGeneralPriority2Type_A.Value == 3)
						{
							num = (short)727646209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 8:
						if (!general.ScanLstGeneralDynamicPriority_A7915.Value)
						{
							num = (short)577765393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						if (scanLstGeneralPriority2Type_A.Value != 1)
						{
							num = (short)874643492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_654;
					case 10:
						return false;
					case 11:
						if (scanLstGeneralPriority2Type_A.Value == 1)
						{
							num = (short)497156106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_383;
					case 12:
						num = (short)1535770662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (index == 0)
						{
							num = (short)1780613157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1889075225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)2117384966;
						short num3 = num;
						num = (short)485276422;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_192;
						default:
							num = (short)752877569;
							if (num != 0)
							{
							}
							num = (short)1749483520;
							if (num != 0)
							{
							}
							goto IL_6A0;
						}
						break;
					}
					case 15:
						goto IL_654;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
						if (scanListInner2 != null)
						{
							num = (short)1584857109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					}
					case 17:
						goto IL_43A;
					case 18:
						if (index >= 1)
						{
							num = (short)755171355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 19:
						if (scanLstGeneralScanType_A.Value == 0)
						{
							num = (short)1659371523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
						num = (short)264437783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)2039939094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (scanLstGeneralPriority1Type_A.Value != 1)
						{
							num = (short)1053753346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A0;
					case 23:
						if (scanLstGeneralScanType_A.Value != 2)
						{
							num = (short)725614623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43A;
					case 24:
						num = (short)68157456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (scanLstGeneralPriorityMember2_A.RefRecset != null)
						{
							num = (short)1592918049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						if (index <= scanLstGeneralPriorityMember2_A.RefRecset.Count)
						{
							num = (short)726728734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						num = (short)2013528090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (scanLstGeneralPriority2Type_A.Value == 3)
						{
							num = (short)2115960847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.Value != 0)
						{
							num = (short)398131212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanLstGeneralPriorityMember2_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2 = general.ScanLstGeneralPriorityMember1_A8747.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						num = (short)1288568864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)373424147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner != null)
						{
							num = (short)424017944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 33:
						num = (short)750452754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)446234631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_2B5;
					case 36:
						num = (short)429785116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)323158027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.Value == 0)
						{
							num = (short)536608803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 39:
						if (scanLstGeneralPriority2Type_A.Value != 1)
						{
							num = (short)844300322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_300;
					}
					goto IL_CE;
					IL_135:
					num = (short)192020489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					if (scanLstGeneralPriority1Type_A.Value == 3)
					{
						num = (short)1503657998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_135;
					IL_300:
					num = (short)1988100102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_43A:
					num = (short)107675661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_654:
					num = (short)981860381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A0:
					num = (short)56754215;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_2B5:
				return false;
				IL_383:
				num = (short)1725759488;
				short num4 = num;
				return true;
				IL_CE:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
				scanLstGeneralPriorityMember2_A = general.ScanLstGeneralPriorityMember2_A8749;
				scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
				scanLstGeneralPriority1Type_A = general.ScanLstGeneralPriority1Type_A8745;
				scanLstGeneralPriority2Type_A = general.ScanLstGeneralPriority2Type_A8748;
				num = (short)1417412612;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x002795E8 File Offset: 0x002777E8
		internal static bool ConScanListTypeIsConventional(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)690887411;
			short num2 = num;
			num = (short)1866406643;
			switch (num2 == num)
			{
			}
			num = (short)189005824;
			short num3 = num;
			num = (short)225771520;
			if (num != 0)
			{
			}
			num = (short)1082523649;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList).General.ScanLstGeneralScanType_A9058.Value == 0;
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x002796B4 File Offset: 0x002778B4
		public static bool ConIsScanDesignatedDataMbrRecRefValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)559808512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
				global::AcpBusinessLayer.AcpListField scanLstGeneralScanType_A;
				global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedDataMember_A;
				global::AcpBusinessLayer.AcpListField scanLstGeneralDesignatedDataTxRxType_A;
				global::Motorola.MackinawCPS.CoreFeatures.ScanList.General general;
				bool flag4;
				bool flag5;
				bool flag6;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return false;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value != 0)
						{
							num = (short)512491538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						conventionalPersonality = (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality);
						num = (short)1624637446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (scanLstGeneralScanType_A.Value == 0)
						{
							num = (short)2117861404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 3:
						num = (short)2106785799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (index > scanLstGeneralDesignatedDataMember_A.RefRecset.Count)
						{
							num = (short)813891600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanLstGeneralDesignatedDataMember_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
						num = (short)1807089666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1681784851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (conventionalPersonality == null)
						{
							num = (short)2007629835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						num = (short)1467547670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_749;
					case 8:
						if (scanLstGeneralDesignatedDataMember_A.RefRecset == null)
						{
							num = (short)1197539337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1906507814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return false;
					case 10:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)311296034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						return false;
					case 12:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1605042179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)856686624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1232732160;
							short num3 = num;
							num = (short)1720385562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 14:
						return false;
					case 15:
					{
						bool flag2;
						bool flag3;
						if (scanLstGeneralScanType_A.Value == 0 && flag2 && flag3)
						{
							num = (short)1629683747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 16:
						goto IL_6EC;
					case 17:
						if (scanLstGeneralDesignatedDataTxRxType_A.Value != 0)
						{
							num = (short)1159987225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
						return false;
					case 19:
					{
						bool flag2;
						bool flag3;
						if (scanLstGeneralScanType_A.Value == 0 && flag2 && flag3)
						{
							num = (short)819462167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 20:
						goto IL_1AA;
					case 21:
					{
						global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A;
						if (scanLstScanListChannel_A.Value == 0)
						{
							num = (short)2162715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanLstScanListChannel_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1438187549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if (conventionalSystem == null)
						{
							num = (short)1411645479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles a_ = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment a_2;
						bool flag2 = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.a(a_2, general);
						bool flag3 = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.a(conventionalPersonality);
						bool flag = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.a(conventionalSystem, a_);
						flag4 = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.a(general);
						flag5 = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.b(conventionalPersonality, general);
						flag6 = global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListConstraints.a(conventionalPersonality, general);
						num = (short)1156841496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)649068556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1602224133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1520500746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)2011889697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_53D;
					case 27:
						return false;
					case 28:
						num = (short)41680913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
						if (channelAssignmentListInner == null)
						{
							num = (short)1794834469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65E;
					}
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner != null)
						{
							global::AcpBusinessLayer.AcpRecRefField scanLstScanListChannel_A = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment a_2 = scanListInner.ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
							num = (short)298975253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1709506561;
						if (num != 0)
						{
						}
						num = (short)210199779;
						short num4 = num;
						num = (short)682910947;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
							num = (short)2007760896;
							if (num != 0)
							{
							}
							num = (short)1175519232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 31:
						num = (short)1588527108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_55A;
					case 33:
						if (scanLstGeneralDesignatedDataTxRxType_A.Value == 2)
						{
							num = (short)1308753940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FD;
					case 34:
						num = (short)1879244815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)568786957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment == null)
						{
							num = (short)1547501582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65E;
					}
					case 37:
						num = (short)2023882788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (index >= 1)
						{
							num = (short)515047455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 39:
						return false;
					}
					goto IL_CF;
					IL_2FD:
					num = (short)1905786910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65E:
					num = (short)1323237377;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1AA:
				return true;
				IL_53D:
				return conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.Value && flag4 && flag5;
				IL_55A:
				bool flag7 = true;
				goto IL_7BB;
				IL_6EC:
				return false;
				IL_749:
				flag7 = (conventionalPersonality.Secure.CnvPerSecureASTROOTAR_A7493.Value && flag4 && flag5);
				IL_7BB:
				return flag7 || flag6;
				IL_CF:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.General);
				scanLstGeneralScanType_A = general.ScanLstGeneralScanType_A9058;
				scanLstGeneralDesignatedDataTxRxType_A = general.ScanLstGeneralDesignatedDataTxRxType_A21525;
				scanLstGeneralDesignatedDataMember_A = general.ScanLstGeneralDesignatedDataMember_A7829;
				num = (short)2066087944;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00279E84 File Offset: 0x00278084
		internal static bool ConIsTxSteeringVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)419692544;
			short num2 = num;
			num = (short)1871976289;
			short num3 = num;
			num = (short)1572738913;
			switch (num3 == num)
			{
			}
			num = (short)588578817;
			if (num != 0)
			{
			}
			num = (short)1540423680;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList).General.ScanLstGeneralScanType_A9058.Value == 4;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00279F4C File Offset: 0x0027814C
		[global::ConstraintHelper.TriggerValidOnLoading]
		internal static bool SetLTEInterferenceFreqInUse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2025848832;
			switch (num)
			{
			default:
			{
				num = (short)663748612;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection scanListInnerSection;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
					global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality == null)
						{
							num = (short)1417347077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_436;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality == null)
						{
							num = (short)280690713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_214;
					}
					case 2:
						if (channelAssignmentListInner != null)
						{
							num = (short)1997799451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						scanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.SetValue(false);
						num = (short)1805058060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						try
						{
							num = (short)2046689281;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1449394179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4F2;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner).ScanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.Value)
									{
										num = (short)218890246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_5B0;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1894252544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)802160642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_593;
								case 6:
									flag = true;
									num = (short)455016453;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_53D:
								num = (short)1434779652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F2:
								goto IL_53D;
							}
							IL_593:
							IL_5B0:
							goto IL_3CF;
						}
						finally
						{
							num = (short)949092354;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_671;
								case 1:
								{
									enumerator.Dispose();
									num = (short)832626258;
									short num3 = num;
									num = (short)763813458;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_5EE;
									default:
										num = (short)901906432;
										if (num != 0)
										{
										}
										num = (short)883359744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5E7;
									}
									continue;
								}
								goto IL_5E7;
								IL_5EE:
								num = (short)309657601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E7:
								if (enumerator != null)
								{
									goto IL_5EE;
								}
								break;
							}
							IL_671:;
						}
						goto IL_674;
						IL_3CF:
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList;
						num = (short)480182292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)314769437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_79E;
					case 7:
						return true;
					case 8:
						channelAssignmentListInner2 = (scanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
						goto IL_472;
					case 9:
						return true;
					case 10:
						goto IL_79E;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)109772800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_79E;
					case 13:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
						num = (short)1440481283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						num = (short)1929248784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						scanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.SetValue(trunkingSystem.ASTRO25ChannelID.TrkSysLTEInterferingFreqPresent_A42198.Value);
						num = (short)1143996426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem != null)
						{
							num = (short)1900347424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality.FrequencyOptions.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value != scanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.Value)
						{
							num = (short)399179810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 18:
						goto IL_214;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						scanList.Labtool.ScanLstLabtoolLTEInterferingFreqPresent_A42197.SetValue(flag);
						num = (short)1875181577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
						if (flag != scanList.Labtool.ScanLstLabtoolLTEInterferingFreqPresent_A42197.Value)
						{
							num = (short)1760231443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 21:
					{
						num = (short)418709504;
						short num4 = num;
						num = (short)996278289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != null)
						{
							num = (short)851836949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality != null)
						{
							num = (short)2099576846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.ASTRO25ChannelID.TrkSysLTEInterferingFreqPresent_A42198.Value != scanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.Value)
						{
							num = (short)581304335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						num = (short)1841102866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (scanListInnerSection.ScanLstScanListChannel_A7620.Value != 0)
						{
							num = (short)953745439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1779105822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1844772892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 0)
						{
							num = (short)2023292929;
							if (num != 0)
							{
							}
							num = (short)967901195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						num = (short)1738670081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_436;
					case 30:
						channelAssignmentListInner2 = null;
						goto IL_472;
					case 31:
						goto IL_674;
					case 32:
						num = (short)1903034392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (scanListInnerRecset != null)
						{
							num = (short)155320333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 34:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						scanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.SetValue(conventionalPersonality.FrequencyOptions.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value);
						num = (short)401342470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_CF:
					if (!(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
					{
						num = (short)275251207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					scanListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection);
					num = (short)639172634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_214:
					num = (short)1475870743;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_436:
					num = (short)1453785110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					channelAssignmentListInner = channelAssignmentListInner2;
					num = (short)911081474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_674:
					num = (short)902955016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79E:
					scanListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
					flag = false;
					num = (short)23789601;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0027A7E8 File Offset: 0x002789E8
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality A_0)
		{
			short num = (short)407324647;
			short num2 = num;
			num = (short)621627367;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1233584129;
				if (num != 0)
				{
				}
				num = (short)541130752;
				short num3 = num;
				num = (short)1557987328;
				if (num != 0)
				{
				}
				if (A_0.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 1)
				{
					return A_0.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value == 2;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x0027A8C0 File Offset: 0x00278AC0
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem A_0, global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles A_1)
		{
			short num = (short)2047344640;
			short num2 = num;
			num = (short)227475456;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					continue;
				case 1:
					goto IL_142;
				case 2:
					if (A_1 != null)
					{
						num = (short)1326383105;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					num = (short)2072838146;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5E:
				num = (short)686778284;
				short num4 = num;
				num = (short)734881708;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)292618240;
					if (num != 0)
					{
					}
					num = (short)1961295873;
					if (num != 0)
					{
					}
					if (A_0.General.CnvSysGeneralDataProfileSelection_A13266.Value == 0)
					{
						return false;
					}
					num = (short)704446467;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_142:
			return A_1.Features.DataProfFeaturesTerminalData_A9288.Value;
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x0027AA14 File Offset: 0x00278C14
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.ScanList.General A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)918224897;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (A_0.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)120324099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 2:
						goto IL_1B4;
					case 3:
					{
						num = (short)1646133248;
						short num3 = num;
						num = (short)723241894;
						short num4 = num;
						num = (short)1793313702;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1355218945;
							if (num != 0)
							{
							}
							num = (short)636682240;
							if (num != 0)
							{
							}
							num = (short)21364740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (!A_0.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)1812267010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						num = (short)1235484672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3E:
					if (A_0.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						return true;
					}
					num = (short)1378091013;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_1B4:
			return A_0.RefSecureWide.General.SecureWideDESAlgorithmEnable_43744.Value;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0027ABDC File Offset: 0x00278DDC
		private static bool b(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality A_0, global::Motorola.MackinawCPS.CoreFeatures.ScanList.General A_1)
		{
			short num = (short)244711424;
			short num2 = num;
			num = (short)779485184;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 1:
					goto IL_161;
				case 2:
					if (A_1.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						num = (short)107806721;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)198123894;
					short num4 = num;
					num = (short)1195647350;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						num = (short)1264844801;
						if (num != 0)
						{
						}
						num = (short)1798701056;
						if (num != 0)
						{
						}
						num = (short)881590274;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_5F:
				if (!A_1.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
				{
					return false;
				}
				num = (short)441450499;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_161:
			return !A_0.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.Value;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0027AD50 File Offset: 0x00278F50
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment A_0, global::Motorola.MackinawCPS.CoreFeatures.ScanList.General A_1)
		{
			short num = (short)1663631360;
			short num2 = num;
			num = (short)550633472;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 1:
					goto IL_140;
				case 2:
					if (A_0 != null)
					{
						num = (short)786300929;
						if (num != 0)
						{
						}
						num = (short)656867329;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					num = (short)1878720514;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5D:
				num = (short)161314060;
				short num4 = num;
				num = (short)130970892;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)1785462784;
					if (num != 0)
					{
					}
					if (A_1.ScanLstGeneralDesignatedDataTxRxType_A21525.Value != 1)
					{
						return false;
					}
					num = (short)1243938819;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_140:
			return !A_0.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value;
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0027AEA0 File Offset: 0x002790A0
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality A_0, global::Motorola.MackinawCPS.CoreFeatures.ScanList.General A_1)
		{
			short num = (short)1287585792;
			short num2 = num;
			num = (short)2086141952;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 1:
					goto IL_158;
				case 2:
					if (!A_1.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACRFeature_A8662.Value)
					{
						num = (short)1556807681;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1291059202;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5C:
				num = (short)1460578281;
				short num4 = num;
				num = (short)914073577;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)533594113;
					if (num != 0)
					{
					}
					num = (short)1470365696;
					if (num != 0)
					{
					}
					if (!A_0.Features.CnvPerLabtoolOTACROTACSMessaging_A8663.Value)
					{
						return false;
					}
					num = (short)1146748931;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_158:
			return A_1.RefConventionalWide.ASTROOTAC.CnvWideASTROOTACOTACSFeature_A8667.Value;
		}
	}
}
