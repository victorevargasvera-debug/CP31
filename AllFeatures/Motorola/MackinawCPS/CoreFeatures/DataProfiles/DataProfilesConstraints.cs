using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F0 RID: 1264
	public static class DataProfilesConstraints
	{
		// Token: 0x0600A9D0 RID: 43472 RVA: 0x009D87DC File Offset: 0x009D69DC
		internal static bool conARSModeIsServer(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1668481024;
			short num2 = num;
			num = (short)222212179;
			short num3 = num;
			num = (short)1948692563;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1777270784;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField dataProfFeaturesARSMode_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DataProfFeaturesARSMode_A7465;
				if (dataProfFeaturesARSMode_A.Value != 1)
				{
					num = (short)307757057;
					if (num != 0)
					{
					}
					return dataProfFeaturesARSMode_A.Value == 5;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x009D88A8 File Offset: 0x009D6AA8
		internal static bool ConDataProfileTypeIsConventional(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1748107264;
			short num2 = num;
			num = (short)782259688;
			short num3 = num;
			num = (short)1453610472;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1009713152;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General).DataProfGeneralDataProfileType_A21320;
				if (dataProfGeneralDataProfileType_A.Value != 0)
				{
					num = (short)793968641;
					if (num != 0)
					{
					}
					return dataProfGeneralDataProfileType_A.Value == 3;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x009D8974 File Offset: 0x009D6B74
		internal static bool ConDataProfileIsNotTrunkingOrNotNonServer(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1525809158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)962285758;
					short num3 = num2;
					num2 = (short)1728860350;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)438763520;
						if (num2 != 0)
						{
						}
						if (dataProfiles.General.DataProfGeneralPacketDataMode_A8689 != 0)
						{
							return true;
						}
						break;
					}
					num2 = (short)1283063813;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (dataProfGeneralDataProfileType_A.Value != 2)
					{
						num2 = (short)424411144;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 3:
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)1971519492;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 4:
					num2 = (short)626393089;
					if (num2 != 0)
					{
					}
					num2 = (short)1185087495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_122;
				case 6:
					if (dataProfGeneralDataProfileType_A.Value == 3)
					{
						num2 = (short)206372873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					if (dataProfGeneralDataProfileType_A.Value != 4)
					{
						num2 = (short)2121662464;
						short num4 = num2;
						num2 = (short)1468530699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F1;
				case 8:
					num2 = (short)1782054922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_94;
				case 10:
					if (dataProfGeneralDataProfileType_A.Value != 0)
					{
						num2 = (short)1796472832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_94;
				case 11:
					num2 = (short)2051866626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_94:
				num2 = (short)894631937;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_122:
			IL_1F1:
			return index != 3;
			IL_40:
			dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			dataProfGeneralDataProfileType_A = dataProfiles.General.DataProfGeneralDataProfileType_A21320;
			num2 = (short)1265106947;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x009D8BF4 File Offset: 0x009D6DF4
		internal static bool conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)371064832;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				num = (short)1155842362;
				short num3 = num;
				num = (short)174178618;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
				{
					num = (short)294125568;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)195690497;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 1:
						goto IL_148;
					case 2:
						num = (short)1718484995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)391577600;
						short num4 = num;
						if (dataProfGeneralDataProfileType_A.Value != 0)
						{
							num = (short)1229389825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					}
					IL_A8:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General;
					dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
					if (general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
					{
						return false;
					}
					num = (short)2144403458;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return true;
			IL_148:
			return dataProfGeneralDataProfileType_A.Value == 3;
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x009D8D4C File Offset: 0x009D6F4C
		internal static bool conDataProfileTypeIsConventionalForPortable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)172818432;
			short num2 = num;
			num = (short)1837520256;
			short num3 = num;
			num = (short)288576896;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)25362432;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General).DataProfGeneralDataProfileType_A21320;
				if (dataProfGeneralDataProfileType_A.Value != 0)
				{
					num = (short)949092353;
					if (num != 0)
					{
					}
					return dataProfGeneralDataProfileType_A.Value == 3;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x009D8E14 File Offset: 0x009D7014
		internal static bool conReturnFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1516765184;
			short num2 = num;
			num = (short)1914372097;
			if (num != 0)
			{
			}
			num = (short)160294152;
			short num3 = num;
			num = (short)21488904;
			switch (num3 == num)
			{
			}
			num = (short)144441344;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x009D8EC0 File Offset: 0x009D70C0
		internal static bool conTrkSysTypeIsTrunking(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)951779328;
			short num2 = num;
			num = (short)1046407282;
			short num3 = num;
			num = (short)1478289522;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2035154945;
				if (num != 0)
				{
				}
				num = (short)438108160;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
				if (dataProfGeneralDataProfileType_A.Value != 1)
				{
					return dataProfGeneralDataProfileType_A.Value == 4;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x009D8F98 File Offset: 0x009D7198
		public static bool conDataProfileTypeTrunking(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			short num2;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (!self.ParentRecset.IsEmbeddedRecset)
					{
						dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
						num2 = (short)985792514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)441978771;
					short num3 = num2;
					num2 = (short)2050101139;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_182;
					default:
						num2 = (short)1956380672;
						if (num2 != 0)
						{
						}
						num2 = (short)2041380865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					dataProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					num2 = (short)942211075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_B5;
				case 3:
					goto IL_182;
				case 4:
				{
					num2 = (short)1061486592;
					short num4 = num2;
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)989462533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 5:
					goto IL_125;
				}
				goto IL_28;
				IL_B5:
				dataProfGeneralDataProfileType_A = dataProfiles.General.DataProfGeneralDataProfileType_A21320;
				num2 = (short)358088708;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_182:
				num2 = (short)1276575745;
				if (num2 != 0)
				{
				}
				goto IL_B5;
			}
			IL_125:
			return dataProfGeneralDataProfileType_A.Value == 4;
			IL_28:
			dataProfiles = null;
			num2 = (short)1069481984;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x009D9160 File Offset: 0x009D7360
		internal static bool ConPadModeIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1621950464;
			short num2 = num;
			num = (short)2004969895;
			short num3 = num;
			num = (short)512125351;
			switch (num3 == num)
			{
			}
			num = (short)762380289;
			if (num != 0)
			{
			}
			num = (short)1345126400;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesPADMode_A20536.Value != 0;
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x009D9218 File Offset: 0x009D7418
		public static bool conEnsureSameSubnetBetweenSubscriberAndPeerIP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2124480512;
			switch (num)
			{
			default:
			{
				num = (short)1942028301;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralMobileComputerIPAddress_A;
					global::AcpBusinessLayer.AcpIPAddressField dataWideGeneralSubscriberIPAddress1_A;
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
					switch (num2)
					{
					case 0:
					{
						num = (short)1040711681;
						if (num != 0)
						{
						}
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)1511391262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 1:
					{
						byte[] addressBytes;
						if (addressBytes[12] <= 191)
						{
							num = (short)202702856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					}
					case 2:
						num = (short)2006056993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3A1;
					case 4:
					{
						byte[] addressBytes;
						if (addressBytes[12] >= 192)
						{
							num = (short)1167458306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[13] == addressBytes2[13])
						{
							num = (short)1025572896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
					{
						if (dataProfGeneralMobileComputerIPAddress_A.Value == 0L)
						{
							num = (short)1102250004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)692453376;
						short num3 = num;
						num = (short)1350828055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)810614802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
						num = (short)1707147271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						byte[] addressBytes;
						if (addressBytes[12] >= 128)
						{
							num = (short)117571605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EE;
					}
					case 10:
						num = (short)796983321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return false;
					case 12:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[14] == addressBytes2[14])
						{
							num = (short)391315480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					case 14:
						num = (short)243073029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)849805331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (dataProfGeneralMobileComputerIPAddress_A.Value != dataWideGeneralSubscriberIPAddress1_A.Value)
						{
							num = (short)80347151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						return true;
					case 18:
						num = (short)1078198294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (dataProfGeneralMobileComputerIPAddress_A.Value != dataProfGeneralSubscriberIPAddress_A.Value)
						{
							num = (short)612368412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 20:
						goto IL_5E9;
					case 21:
						num = (short)1918697473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[13] == addressBytes2[13])
						{
							num = (short)2086928410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 23:
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataProfGeneralMobileComputerIPAddress_A.Value)))
						{
							num = (short)1088356363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)152829968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return true;
					case 25:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[12] == addressBytes2[12])
						{
							num = (short)1984626702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 26:
						return true;
					case 27:
					{
						if (dataProfGeneralMobileComputerIPAddress_A.Value == general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
						{
							num = (short)1401946115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] addressBytes = dataProfGeneralSubscriberIPAddress_A.AddressBytes;
						byte[] addressBytes2 = dataProfGeneralMobileComputerIPAddress_A.AddressBytes;
						num = (short)1020264477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num = (short)499777563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						num = (short)726388371;
						short num4 = num;
						num = (short)2805395;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
						{
							num = (short)555679744;
							if (num != 0)
							{
							}
							byte[] addressBytes;
							if (addressBytes[12] <= 127)
							{
								num = (short)279576607;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2088108041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 30:
						return true;
					case 31:
						num = (short)1716387840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)158597132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						byte[] addressBytes;
						if (addressBytes[12] <= 223)
						{
							num = (short)552075274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					IL_CC:
					if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
					{
						num = (short)1716322321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
					dataProfGeneralSubscriberIPAddress_A = general.DataProfGeneralSubscriberIPAddress_A21157;
					dataWideGeneralSubscriberIPAddress1_A = general.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222;
					dataProfGeneralMobileComputerIPAddress_A = general.DataProfGeneralMobileComputerIPAddress_A8523;
					num = (short)2120548358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EE:
					num = (short)1908998148;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_3A1:
				return false;
				IL_5E9:
				return false;
			}
			}
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x009D9858 File Offset: 0x009D7A58
		internal static bool ConDestinationPortValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features;
			short num2;
			global::AcpBusinessLayer.AcpSimpleRangeField datProFeaturesDestinationPort_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					if (features.DatProFeaturesPADMode_A20536.Value == 0)
					{
						num2 = (short)1401159680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_11D;
				case 3:
					if (datProFeaturesDestinationPort_A.Value <= 65535)
					{
						num2 = (short)1156907015;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_106;
				case 4:
				{
					num2 = (short)1560569356;
					short num3 = num2;
					num2 = (short)826238476;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11D;
					default:
					{
						num2 = (short)374996992;
						if (num2 != 0)
						{
						}
						num2 = (short)495517696;
						short num4 = num2;
						num2 = (short)479264769;
						if (num2 != 0)
						{
						}
						num2 = (short)1780219907;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					num2 = (short)1508442113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (datProFeaturesDestinationPort_A.Value > 0)
					{
						num2 = (short)1313144836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_106;
				case 7:
					return true;
				}
				goto IL_30;
				IL_106:
				num2 = (short)913178626;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_11D:
				if (datProFeaturesDestinationPort_A.Value != 0)
				{
					return false;
				}
				num2 = (short)2083520517;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_30:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features);
			datProFeaturesDestinationPort_A = features.DatProFeaturesDestinationPort_A20544;
			num2 = (short)2092236806;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x009D9A40 File Offset: 0x009D7C40
		internal static bool ConDestinationAddressValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpIPAddressField datProFeaturesDestinationAddress_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					while (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(datProFeaturesDestinationAddress_A.Value)))
					{
						num2 = (short)259114613;
						short num3 = num2;
						num2 = (short)602064501;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num2 = (short)155320320;
							short num4 = num2;
							num2 = (short)1956970496;
							if (num2 != 0)
							{
							}
							num2 = (short)1755119619;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
						}
					}
					goto IL_122;
				case 1:
					return false;
				case 2:
					if (datProFeaturesDestinationAddress_A.Value == 0L)
					{
						num2 = (short)230096897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)99680256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return false;
				}
				goto IL_20;
			}
			return false;
			IL_122:
			num2 = (short)146800641;
			if (num2 != 0)
			{
			}
			return true;
			IL_20:
			datProFeaturesDestinationAddress_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesDestinationAddress_A20543;
			num2 = (short)658440194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x009D9B98 File Offset: 0x009D7D98
		internal static bool ConMaximumBufferThresholdApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField datProFeaturesPADMode_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesPADMode_A20536;
			if (datProFeaturesPADMode_A.Value != 2)
			{
				short num;
				for (;;)
				{
					num = (short)1662429224;
					short num2 = num;
					num = (short)426289192;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_78;
					}
					break;
				}
				num = (short)804323328;
				short num3 = num;
				IL_78:
				num = (short)2058223617;
				if (num != 0)
				{
				}
				num = (short)1127743488;
				if (num != 0)
				{
				}
				return datProFeaturesPADMode_A.Value == 1;
			}
			return true;
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x009D9C64 File Offset: 0x009D7E64
		internal static bool ConTransmissionInhibitValueApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1331141800;
			short num2 = num;
			num = (short)673750184;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1765801984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)309985280;
			if (num != 0)
			{
			}
			num = (short)1793458177;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesPADMode_A20536.Value != 0;
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x009D9D20 File Offset: 0x009D7F20
		internal static bool ConReceiveIdleTimeOutApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField datProFeaturesPADMode_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesPADMode_A20536;
			if (datProFeaturesPADMode_A.Value != 2)
			{
				short num;
				for (;;)
				{
					num = (short)348494013;
					short num2 = num;
					num = (short)962435261;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				num = (short)1938948096;
				short num3 = num;
				IL_79:
				num = (short)2138636288;
				if (num != 0)
				{
				}
				num = (short)1529872385;
				if (num != 0)
				{
				}
				return datProFeaturesPADMode_A.Value == 1;
			}
			return true;
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x009D9DF0 File Offset: 0x009D7FF0
		internal static bool ConEscapeSequenceIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1070596102;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.AcpField<string> datProFeaturesEscapeSequence_A;
				switch (num2)
				{
				case 0:
					num = (short)1005715459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (datProFeaturesEscapeSequence_A.Value.Length != 0)
					{
						num = (short)230621184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					if (datProFeaturesEscapeSequence_A.Value != null)
					{
						num = (short)344719361;
						if (num != 0)
						{
						}
						num = (short)1050279941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					if (datProFeaturesEscapeSequence_A.Value.Length >= 2)
					{
						num = (short)2106851335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)811270144;
					short num3 = num;
					num = (short)388497410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)1769996289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					goto IL_1EC;
				}
				IL_45:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features;
				datProFeaturesEscapeSequence_A = features.DatProFeaturesEscapeSequence_A20539;
				if (features.DatProFeaturesPADMode_A20536.Value != 2)
				{
					return true;
				}
				num = (short)1331036164;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1EC:
			num = (short)44835693;
			short num4 = num;
			num = (short)337388397;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
			{
				num = (short)1996226560;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> datProFeaturesEscapeSequence_A;
				return datProFeaturesEscapeSequence_A.Value.Length % 2 == 0;
			}
			}
			return true;
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x009D9FF0 File Offset: 0x009D81F0
		internal static bool ConStopSequenceIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 1;
			short num = (short)1199177734;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpField<string> datProFeaturesStopSequence_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F7;
				case 1:
					goto IL_A5;
				case 2:
					if (datProFeaturesStopSequence_A.Value != null)
					{
						num = (short)292290565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (datProFeaturesStopSequence_A.Value != global::AllFeatures.CodeplugGuid.b("", a_))
					{
						num = (short)1256194055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)2047028184;
					short num3 = num;
					num = (short)832515032;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A5;
					default:
						num = (short)271450112;
						if (num != 0)
						{
						}
						num = (short)1916600321;
						if (num != 0)
						{
						}
						num = (short)1992818690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)1356333059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 7:
					num = (short)1674969089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4D:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features;
				datProFeaturesStopSequence_A = features.DatProFeaturesStopSequence_A20538;
				if (features.DatProFeaturesPADMode_A20536.Value == 2)
				{
					num = (short)1991049220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_A5:
				num = (short)1993277440;
				short num4 = num;
				if (datProFeaturesStopSequence_A.Value.Length < 2)
				{
					return false;
				}
				num = (short)962854912;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F7:
			return datProFeaturesStopSequence_A.Value.Length % 2 == 0;
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x009DA1F4 File Offset: 0x009D83F4
		internal static bool ConPadModIsSentence(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1017259925;
			short num2 = num;
			num = (short)1076242325;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1651245056;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2032467969;
			if (num != 0)
			{
			}
			num = (short)1229651968;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).DatProFeaturesPADMode_A20536.Value == 2;
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x009DA2B4 File Offset: 0x009D84B4
		internal static bool ConStartSequenceIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 8;
			short num = (short)1820590086;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpField<string> datProFeaturesStartSequence_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					goto IL_FC;
				case 2:
					if (datProFeaturesStartSequence_A.Value != null)
					{
						num = (short)1184235525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (datProFeaturesStartSequence_A.Value != global::AllFeatures.CodeplugGuid.b("杻", a_))
					{
						num = (short)874446855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
				{
					num = (short)92858769;
					short num3 = num;
					num = (short)404089233;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						num = (short)1443758080;
						if (num != 0)
						{
						}
						num = (short)354418690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					num = (short)650903555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4F;
					}
					continue;
				case 7:
				{
					num = (short)1954414592;
					short num4 = num;
					num = (short)739115009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4F:
				num = (short)993460225;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features;
				datProFeaturesStartSequence_A = features.DatProFeaturesStartSequence_A20537;
				if (features.DatProFeaturesPADMode_A20536.Value == 2)
				{
					num = (short)982908932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_FC:
				if (datProFeaturesStartSequence_A.Value.Length < 2)
				{
					return false;
				}
				num = (short)999292928;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_125:
			return datProFeaturesStartSequence_A.Value.Length % 2 == 0;
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x009DA4C0 File Offset: 0x009D86C0
		internal static bool conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)367329282;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (dataProfGeneralDataProfileType_A.Value != 0)
					{
						num = (short)1135083523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1600847872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1682243585;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
				{
					num = (short)53404271;
					short num3 = num;
					num = (short)1288626799;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_CB;
					}
					break;
				}
				}
				IL_5C:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General;
				dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
				if (general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
				{
					return false;
				}
				num = (short)1426915329;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_CB:
			num = (short)1360330752;
			short num4 = num;
			num = (short)1408892928;
			if (num != 0)
			{
			}
			return dataProfGeneralDataProfileType_A.Value == 3;
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x009DA624 File Offset: 0x009D8824
		internal static void conSetDataPrfPeerIpSubIpPeerIpAssignTypeValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1239810048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1739849728;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
				global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralMobileComputerIPAddress_A;
				global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
				global::AcpBusinessLayer.AcpListField dataWideGeneralPeerIPAddressAssignmentType_A;
				global::AcpBusinessLayer.AcpIPAddressField dataProfilesGeneralBTDUNSUIPAddress_A;
				global::AcpBusinessLayer.AcpIPAddressField dataProfilesGeneralBTDUNPeerIPAddress_A;
				global::AcpBusinessLayer.AcpListField dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
				for (;;)
				{
					IL_53:
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (flag != radioWide.LTE.RadWideLabtoolLTEUsed_A42064.Value)
						{
							num = (short)1213530121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (dataProfGeneralDataProfileType_A.Value != 1)
						{
							num = (short)731381763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56D;
					case 3:
						num = (short)122617862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_691;
					case 5:
						if (dataProfGeneralDataProfileType_A.Value == 3)
						{
							num = (short)1189412872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_651;
					case 6:
						num = (short)265879553;
						if (num != 0)
						{
						}
						if (dataProfGeneralDataProfileType_A.Value == 4)
						{
							num = (short)835387406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DE;
					case 7:
						goto IL_691;
					case 8:
						goto IL_468;
					case 9:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.LTE.RadWideLabtoolLTEUsed_A42064, flag));
						num = (short)641138688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (dataProfGeneralDataProfileType_A.Value != 2)
						{
							num = (short)775749645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_468;
					case 11:
						goto IL_651;
					case 12:
						try
						{
							num = (short)1029242888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfBroadbandSource_A42858.Value == 1)
									{
										num = (short)770375684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_2AC;
								case 2:
									goto IL_312;
								case 3:
									goto IL_2A7;
								case 4:
									flag = true;
									num = (short)1946484738;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1345191948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 3)
									{
										goto IL_2AC;
									}
									num = (short)846310976;
									short num4 = num;
									num = (short)642035264;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2A7;
									default:
										num = (short)14221312;
										if (num != 0)
										{
										}
										num = (short)409927683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1353121798;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_170;
									}
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
									{
										num = (short)685506567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2AC;
								}
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1142685701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1303707657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
									{
										num = (short)472711169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									goto IL_36D;
								}
								goto IL_170;
								IL_2A7:
								num = (short)866189323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2AC:
								num = (short)793772032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_317:
								num = (short)1935343626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_170:
								goto IL_317;
							}
							IL_312:
							IL_36D:
							goto IL_4AA;
						}
						finally
						{
							num = (short)795344897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1895890946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3A4;
									}
									continue;
								case 2:
									goto IL_3DB;
								}
								IL_3A4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2038890496;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3DB:;
						}
						goto IL_3DE;
						IL_4AA:
						num = (short)1228079105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1128333317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_56D;
					}
					goto IL_96;
					IL_3DE:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfGeneralMobileComputerIPAddress_A, 0L));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfGeneralSubscriberIPAddress_A, 0L));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataWideGeneralPeerIPAddressAssignmentType_A, dataWideGeneralPeerIPAddressAssignmentType_A.DefaultValue));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfilesGeneralBTDUNSUIPAddress_A, dataProfilesGeneralBTDUNSUIPAddress_A.DefaultValue));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfilesGeneralBTDUNPeerIPAddress_A, dataProfilesGeneralBTDUNPeerIPAddress_A.DefaultValue));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A, dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A.DefaultValue));
					num = (short)364576775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_468:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2 = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(dataProfiles2.General.DataWideGeneralNATEnable_A38866, true));
					num = (short)960954379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56D:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfGeneralSubscriberIPAddress_A, general.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfGeneralMobileComputerIPAddress_A, general.RefDataWide.General.DataWideGeneralPeerIPAddress1_A8524.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataWideGeneralPeerIPAddressAssignmentType_A, general.RefDataWide.General.DataWideGeneralPeerIPAddressAssignmentType1_A22376.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfilesGeneralBTDUNSUIPAddress_A, general.RefDataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<long>(dataProfilesGeneralBTDUNPeerIPAddress_A, general.RefDataWide.General.DataWideGeneralBTDUNPeerIPAddress_A41123.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A, general.RefDataWide.General.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.Value));
					num = (short)161218564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_651:
					num = (short)1375993858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_691:
					flag = false;
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
					num = (short)709361676;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_96:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
				dataProfGeneralSubscriberIPAddress_A = general.DataProfGeneralSubscriberIPAddress_A21157;
				dataProfGeneralMobileComputerIPAddress_A = general.DataProfGeneralMobileComputerIPAddress_A8523;
				dataWideGeneralPeerIPAddressAssignmentType_A = general.DataWideGeneralPeerIPAddressAssignmentType_A22263;
				dataProfilesGeneralBTDUNSUIPAddress_A = general.DataProfilesGeneralBTDUNSUIPAddress_A41126;
				dataProfilesGeneralBTDUNPeerIPAddress_A = general.DataProfilesGeneralBTDUNPeerIPAddress_A41127;
				dataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A = general.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;
				num = (short)1406337034;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_53;
			}
			}
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x009DAD98 File Offset: 0x009D8F98
		public static bool conEnsureSubscriberIPAddressDifferentIpAddress(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1326710787;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return true;
				case 1:
				{
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
					if (dataProfGeneralSubscriberIPAddress_A.Value != general.DataProfGeneralMobileComputerIPAddress_A8523.Value)
					{
						num = (short)307232776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 2:
				{
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
					if (dataProfGeneralSubscriberIPAddress_A.Value != general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
					{
						num = (short)274530309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					return false;
				case 5:
					num = (short)636354561;
					if (num != 0)
					{
					}
					num = (short)1836777478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)883779080;
					short num3 = num;
					num = (short)1970365960;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num = (short)235274240;
						if (num != 0)
						{
						}
						global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
						if (dataProfGeneralSubscriberIPAddress_A.Value == 0L)
						{
							num = (short)1026031627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27C;
					}
					}
					break;
				}
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataProfGeneralSubscriberIPAddress_A21157.Value)))
					{
						num = (short)1014890500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A = general.DataProfGeneralSubscriberIPAddress_A21157;
					num = (short)137035777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					num = (short)1007550473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					global::AcpBusinessLayer.AcpIPAddressField dataProfGeneralSubscriberIPAddress_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					if (dataProfGeneralSubscriberIPAddress_A.Value != dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.Value)
					{
						num = (short)1231880202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 10:
					num = (short)572260354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_223;
				}
				IL_55:
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)908132352;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
					num = (short)2065498119;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_223:
			return false;
			IL_27C:
			num = (short)1650524160;
			short num4 = num;
			return true;
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x009DB04C File Offset: 0x009D924C
		internal static bool conEnsureSubscriberAirInterfaceIPAddressDifferentIpAddress(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)829816832;
			switch (num)
			{
			default:
			{
				num = (short)394002461;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					bool value;
					switch (num2)
					{
					case 0:
						if (general.DataProfGeneralDataProfileType_A21320.Value != 0)
						{
							num = (short)1592131602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
					case 1:
						goto IL_4CE;
					case 2:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != general.DataProfGeneralSubscriberIPAddress_A21157.Value)
						{
							num = (short)386334743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)585367564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return false;
					case 5:
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
						{
							num = (short)2023161892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						if (general.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value == 0)
						{
							num = (short)174784515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 7:
						return true;
					case 8:
					{
						num = (short)2045812303;
						short num3 = num;
						num = (short)841588303;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4CE;
						default:
							num = (short)2028011520;
							if (num != 0)
							{
							}
							if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != dataWide.General.DataWideGeneralPeerIPAddress1_A8524.Value)
							{
								num = (short)124780563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 9:
						num = (short)1291649029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)812777496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_709;
					case 12:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value)
						{
							num = (short)1385562126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						return false;
					case 14:
						goto IL_15A;
					case 15:
						if (general.DataProfGeneralPacketDataMode_A8689.Value != 0)
						{
							num = (short)1187577873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 16:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value)
						{
							num = (short)1941962763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						goto IL_520;
					case 18:
						num = (short)1559691299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)2081292288;
						short num4 = num;
						num = (short)618987553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_104;
					case 21:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != dataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.Value)
						{
							num = (short)1355022358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						num = (short)1437007880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)213385253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value != 1)
						{
							num = (short)1454899209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E8;
					case 25:
						if (value)
						{
							num = (short)796262426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_709;
					case 26:
						num = (short)366215174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value == dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.Value)
						{
							num = (short)681771012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 28:
						num = (short)2124939264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						switch (0)
						{
						case 0:
							goto IL_DD;
						}
						continue;
					case 30:
						num = (short)1697775631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)))
						{
							num = (short)1799880717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1180303392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (!general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
						{
							num = (short)1196556316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 33:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != 0L)
						{
							num = (short)1291190282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 34:
						goto IL_4B6;
					case 35:
						if (general.DataProfGeneralDataProfileType_A21320.Value == 3)
						{
							num = (short)1537212450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					case 36:
						goto IL_2E8;
					case 37:
						if (general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value != general.DataProfGeneralMobileComputerIPAddress_A8523.Value)
						{
							num = (short)92209172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					IL_DD:
					if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
					{
						num = (short)1147469831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
					value = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
					dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
					dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					num = (short)10682399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_104:
					num = (short)1065615381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A:
					num = (short)1269694480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					num = (short)814219291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B6:
					num = (short)1057030145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CE:
					num = (short)1691484161;
					if (num != 0)
					{
					}
					if (general.DataWideGeneralNATEnable_A38866.Value)
					{
						num = (short)18808862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_520:
					num = (short)304545817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_709:
					num = (short)1371668482;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x009DB7B8 File Offset: 0x009D99B8
		internal static bool conAutoRegSvrAddressValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpIPAddressField dataProfFeaturesAutomaticRegistrationServerAddress_A;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1103495172;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (dataProfFeaturesAutomaticRegistrationServerAddress_A.Value != 0L)
					{
						num2 = (short)564461568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					return false;
				case 3:
				{
					num2 = (short)1277357102;
					short num3 = num2;
					num2 = (short)553380910;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_24C;
					default:
						num2 = (short)145293312;
						if (num2 != 0)
						{
						}
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataProfFeaturesAutomaticRegistrationServerAddress_A.Value)))
						{
							num2 = (short)1254031367;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 4:
					if (dataProfFeaturesAutomaticRegistrationServerAddress_A.Value != dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.Value)
					{
						num2 = (short)429391878;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					num2 = (short)2058682376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)72351753;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_127;
				case 8:
				{
					num2 = (short)928514048;
					short num4 = num2;
					if (dataProfFeaturesAutomaticRegistrationServerAddress_A.Value == features.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.Value)
					{
						num2 = (short)1472921602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1875771395;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					if (dataProfFeaturesAutomaticRegistrationServerAddress_A.Value != dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
					{
						goto IL_24C;
					}
					return false;
				}
				goto IL_38;
				IL_24C:
				num2 = (short)26738693;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_127:
			num2 = (short)67305473;
			if (num2 != 0)
			{
			}
			return false;
			IL_38:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features);
			dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			dataProfFeaturesAutomaticRegistrationServerAddress_A = features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524;
			global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
			num2 = (short)85590017;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x009DBA30 File Offset: 0x009D9C30
		internal static bool conDataProfTypeIsTrkAndDataRegVerIsSNDCPv3(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
					if (dataProfGeneralDataProfileType_A.Value == 4)
					{
						num2 = (short)142934019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
				{
					global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)502988802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_105;
				}
				case 2:
					goto IL_103;
				case 3:
					goto IL_14B;
				}
				goto IL_20;
			}
			IL_103:
			goto IL_114;
			IL_105:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			return general.DataConigurationDataProfilePacketDataRegistrationVersion_A36210.Value == 1;
			IL_14B:
			goto IL_105;
			IL_20:
			num2 = (short)2130514718;
			short num3 = num2;
			num2 = (short)2036994846;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_114:
				num2 = (short)1062273024;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1247412224;
				short num4 = num2;
				num2 = (short)356122624;
				if (num2 != 0)
				{
				}
				num2 = (short)328597505;
				if (num2 != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
				num2 = (short)1115619329;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x009DBB8C File Offset: 0x009D9D8C
		internal static bool conDataProfileTypeIsTrkAndOperationModeIsControlledChannelAccess(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1763704832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection daclistInnerSection;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							num = (short)1343094784;
							short num3 = num;
							try
							{
								num = (short)1546649600;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1D9;
										}
										continue;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
										conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.CalculateApplicability();
										conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.CalculateValidity();
										num = (short)1058799618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)857669638;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
										num = (short)1954414597;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_2F7;
									case 5:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
										if (conventionalSystem != null)
										{
											num = (short)476446728;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)1411710980;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
										if (conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value == 2)
										{
											num = (short)805109761;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										num = (short)174260231;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_213:
									num = (short)236716035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D9:
									goto IL_213;
								}
								IL_2F7:
								goto IL_143;
							}
							finally
							{
								num = (short)1154482176;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_330;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)984612866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_366;
									}
									IL_330:
									if (enumerator == null)
									{
										break;
									}
									num = (short)594673665;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_366:;
							}
							goto IL_369;
							IL_143:
							num = (short)908328961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
							{
								num = (short)745472004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_369;
						case 2:
						{
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 4)
							{
								goto IL_378;
							}
							num = (short)1070040839;
							short num4 = num;
							num = (short)1570146055;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_6B;
							default:
								num = (short)198770688;
								if (num != 0)
								{
								}
								num = (short)2044526595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_13E;
						case 4:
							num = (short)436994050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42;
					}
					IL_13E:
					IL_369:
					return daclistInnerSection.DataProfilesDACOperationalMode_A36199.Value == 1;
					IL_378:
					num = (short)1052442625;
					if (num != 0)
					{
					}
					return false;
				}
				IL_42:
				daclistInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection);
				dataProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
				enumerator = dataProfiles.ReferencingNodes.GetEnumerator();
				IL_6B:
				num = (short)1365377024;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x009DBF58 File Offset: 0x009DA158
		internal static bool conFirstRowOfDACTableNotEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)905641984;
				short num2 = num;
				global::AcpCommonLib.IAcpFeatureNode parent = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection).DataProfilesDACOperationalMode_A36199.Parent.Parent;
				if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) != 0)
				{
					return true;
				}
				num = (short)1354636861;
				short num3 = num;
				num = (short)299310653;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_89;
				}
			}
			IL_89:
			num = (short)1339555841;
			if (num != 0)
			{
			}
			num = (short)330760192;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x009DC030 File Offset: 0x009DA230
		internal static bool conSecureClearStrappingApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_130;
				case 1:
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)262733824;
						short num3 = num2;
						num2 = (short)1566113794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1049690112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1063452673;
					if (num2 != 0)
					{
					}
					num2 = (short)1608911560;
					short num4 = num2;
					num2 = (short)291769032;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)164757504;
						if (num2 != 0)
						{
						}
						num2 = (short)448004099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_14B;
				}
				goto IL_20;
			}
			IL_130:
			bool flag = true;
			goto IL_156;
			IL_14B:
			flag = (dataProfGeneralDataProfileType_A.Value == 4);
			IL_156:
			bool flag2;
			return flag && flag2;
			IL_20:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity networkLayerSecurity = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity;
			dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
			flag2 = global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.a(networkLayerSecurity.RefSecureWide);
			num2 = (short)1117061121;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x009DC198 File Offset: 0x009DA398
		internal static bool conSecureClearStrappingSecure(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)519831552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool flag2;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity networkLayerSecurity;
					global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
					bool flag4;
					for (;;)
					{
						IL_27:
						bool flag;
						global::AcpBusinessLayer.AcpRecRefField dataProfNLSKMFProfSele_A;
						bool flag3;
						switch (num2)
						{
						case 0:
							flag = true;
							goto IL_230;
						case 1:
							return flag2;
						case 2:
						{
							num = (short)1644691457;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = dataProfNLSKMFProfSele_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.a(networkLayerSecurity, a_, flag2);
							num = (short)969801729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							num = (short)2119041028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							flag = (dataProfGeneralDataProfileType_A.Value == 4);
							goto IL_230;
						case 5:
							if (dataProfNLSKMFProfSele_A.Value == 0)
							{
								num = (short)1635778566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag2;
						case 6:
						{
							num = (short)1290190699;
							short num3 = num;
							num = (short)1691467627;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1418788864;
								if (num != 0)
								{
								}
								global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.a(networkLayerSecurity, null, flag2);
								num = (short)556204046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							num = (short)1646592011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (dataProfGeneralDataProfileType_A.Value != 1)
							{
								num = (short)2019033091;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)175046656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (dataProfNLSKMFProfSele_A != null)
							{
								num = (short)1282473991;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DF;
						case 10:
							num = (short)2090270725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (dataProfNLSKMFProfSele_A.ReferencedNode != null)
							{
								num = (short)1584857090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2DF;
						case 12:
							flag3 = false;
							goto IL_29F;
						case 13:
							flag3 = (networkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value == 1);
							goto IL_29F;
						case 14:
							return flag2;
						case 15:
						{
							num = (short)146866176;
							short num4 = num;
							num = (short)139591693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							if (dataProfNLSKMFProfSele_A != null)
							{
								num = (short)2034368522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return flag2;
						}
						break;
						IL_230:
						if (flag && flag4)
						{
							num = (short)333185039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)803930124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_29F:
						flag2 = flag3;
						dataProfNLSKMFProfSele_A = networkLayerSecurity.DataProfNLSKMFProfSele_A36419;
						num = (short)1264386057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2DF:
						num = (short)688586768;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_72:
					networkLayerSecurity = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity);
					dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
					global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = networkLayerSecurity.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
					flag4 = global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.a(networkLayerSecurity.RefSecureWide);
					num = (short)1465778184;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				return flag2;
			}
			}
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x009DC52C File Offset: 0x009DA72C
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity A_0, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile A_1, bool A_2)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset recset;
			for (;;)
			{
				IL_0A:
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)1065746436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					if (general.SecKmfProfGenIndependentKeyList_43597.Applicable)
					{
						num2 = (short)1937965056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)760741894;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_11E;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide;
					embeddedRecset = refSecureWide.EncryptionKeyList.EmbeddedRecset;
					goto IL_106;
				}
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general;
					flag = general.SecKmfProfGenIndependentKeyList_43597.Value;
					goto IL_206;
				}
				case 5:
					if (A_1 != null)
					{
						num2 = (short)1930166281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_252;
				case 6:
					flag = false;
					goto IL_206;
				case 7:
					embeddedRecset = A_1.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset;
					goto IL_106;
				case 8:
					num2 = (short)1572470785;
					if (num2 != 0)
					{
					}
					num2 = (short)46465027;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)903222152;
					short num3 = num2;
					num2 = (short)293409672;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_252;
					default:
					{
						num2 = (short)441319424;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = A_1.General;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide = A_1.General.RefSecureWide;
						num2 = (short)914292737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_38;
				IL_106:
				recset = embeddedRecset;
				num2 = (short)1084686338;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_206:
				if (!flag || !A_2)
				{
					num2 = (short)1410793480;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)110624775;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_11E:
			IL_252:
			A_0.DataProfNLSKeySele_A36410.SetRecset(recset);
			return;
			IL_38:
			recset = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10040].EmbeddedRecset;
			num2 = (short)772603904;
			short num4 = num2;
			num2 = (short)1266221061;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x009DC798 File Offset: 0x009DA998
		public static bool conIPAddrIsUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 4;
			short num = (short)2093481984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				int num3;
				long value;
				string text;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection eidbypassListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset eidbypassListInnerRecset;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						global::System.Net.IPAddress ipaddress;
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(ipaddress))
						{
							num = (short)1906311179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] addressBytes = ipaddress.GetAddressBytes();
						byte b = addressBytes[0];
						num = (short)1768685575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return false;
					case 2:
						goto IL_5C0;
					case 3:
						num = (short)1007943692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)832634894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_235;
					case 6:
					{
						byte[] addressBytes;
						if (addressBytes[2] == 255)
						{
							num = (short)948043779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					}
					case 7:
					{
						byte[] addressBytes;
						if (addressBytes[0] == 255)
						{
							num = (short)1198522372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					}
					case 8:
					{
						byte b;
						if (b == 0)
						{
							num = (short)1763639298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105;
					}
					case 9:
					{
						byte b;
						if (b <= 223)
						{
							num = (short)789643279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						try
						{
							num = (short)22216706;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									IL_379:
									num = (short)1761607685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num3++;
									num = (short)790364164;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2F4;
									}
									continue;
								case 3:
									if (value.ToString() == text)
									{
										num = (short)910360577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									goto IL_421;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)605618176;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									value = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10602] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection).DataProfEIDByPassListIPAddr_A36417.Value;
									num = (short)8519683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2F6:
								num = (short)1653633462;
								short num4 = num;
								num = (short)1133212086;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_379;
								default:
									num = (short)726335488;
									if (num != 0)
									{
									}
									num = (short)648085510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2F4:
								goto IL_2F6;
							}
							IL_421:
							goto IL_276;
						}
						finally
						{
							num = (short)477102082;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)797769729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_491;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_459;
									}
									continue;
								}
								IL_459:
								if (enumerator == null)
								{
									break;
								}
								num = (short)426573824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_491:;
						}
						goto IL_494;
						IL_276:
						num = (short)1351680013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return false;
					case 12:
					{
						byte[] addressBytes;
						if (addressBytes[3] != 255)
						{
							num = (short)1235615745;
							if (num != 0)
							{
							}
							num = (short)549126149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105;
					}
					case 13:
						if (num3 <= 1)
						{
							num = (short)1857814546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
					{
						byte[] addressBytes;
						if (addressBytes[1] == 255)
						{
							num = (short)336330769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					}
					case 15:
						num = (short)1622343700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						if (text == global::AllFeatures.CodeplugGuid.b("", a_))
						{
							num = (short)634650625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress(eidbypassListInnerSection.DataProfEIDByPassListIPAddr_A36417.Value);
						num = (short)956104704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_494;
					case 18:
						return true;
					case 19:
						num = (short)72744968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						num = (short)1338376192;
						short num5 = num;
						byte b;
						if (b != 127)
						{
							num = (short)621150227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					goto IL_8C;
					IL_105:
					enumerator = eidbypassListInnerRecset.GetEnumerator();
					num = (short)1171783690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_235:
					num = (short)923664393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_494:
					num = (short)1505886214;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_5C0:
				return false;
				IL_8C:
				eidbypassListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection);
				eidbypassListInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerRecset);
				num3 = 0;
				value = eidbypassListInnerSection.DataProfEIDByPassListIPAddr_A36417.Value;
				text = value.ToString();
				num = (short)584384528;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x009DCD88 File Offset: 0x009DAF88
		public static bool conKeySelValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)259391488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				bool flag;
				global::AcpBusinessLayer.AcpRecRefField dataProfNLSKMFProfSele_A;
				global::AcpBusinessLayer.AcpRecRefField dataProfNLSKeySele_A;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset encryptionKeyListInnerRecset;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						try
						{
							num = (short)1338441730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = true;
									num = (short)677052420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_310;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)546242561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2014117894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2CE;
								case 5:
									goto IL_32A;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194.ReferencedNode == featureNode)
									{
										num = (short)409072193;
										short num3 = num;
										num = (short)891613761;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_310;
										default:
											num = (short)1660223488;
											if (num != 0)
											{
											}
											num = (short)1661009920;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								}
								IL_2D3:
								num = (short)268435459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20C:
								goto IL_2D3;
								IL_310:
								num = (short)1068302341;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2CE:
							IL_32A:
							goto IL_6CE;
						}
						finally
						{
							num = (short)101974018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)840630273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_39B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_362;
									}
									continue;
								}
								IL_362:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1675624448;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39B:;
						}
						goto IL_39E;
					case 2:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Value)
						{
							num = (short)594149381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_428;
					}
					case 3:
						if (dataProfNLSKMFProfSele_A.Value > 0)
						{
							num = (short)1606025223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					case 4:
						return false;
					case 5:
						num = (short)1031929878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (index == 0)
						{
							num = (short)542441488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1970798620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = dataProfNLSKMFProfSele_A.RefRecset[dataProfNLSKMFProfSele_A.Value - 1] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)924778517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset secureHardwareEncryptionKeyReferencesListInnerRecset;
						if (secureHardwareEncryptionKeyReferencesListInnerRecset == null)
						{
							num = (short)540999680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = secureHardwareEncryptionKeyReferencesListInnerRecset.GetEnumerator();
						num = (short)1271398401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (dataProfNLSKMFProfSele_A.ReferencedNode != null)
						{
							num = (short)1861615634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DD;
					case 10:
						num = (short)231473171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (dataProfNLSKMFProfSele_A.UIValue == dataProfNLSKMFProfSele_A.InvalidText)
						{
							num = (short)1085669380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CE;
					case 12:
						goto IL_468;
					case 13:
					{
						global::AcpBusinessLayer.FeatureNode featureNode = encryptionKeyListInnerRecset[index - 1] as global::AcpBusinessLayer.FeatureNode;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset secureHardwareEncryptionKeyReferencesListInnerRecset = (dataProfNLSKMFProfSele_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile).SecureHardwareEncryptionKeyReferencesList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerRecset;
						num = (short)349503496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_ = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597;
						num = (short)393019394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (dataProfNLSKeySele_A.RefRecset is global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionIndependentKeyListInnerRecset)
						{
							num = (short)1677721612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					case 16:
						return true;
					case 17:
						goto IL_428;
					case 18:
						num = (short)1586626585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.General != null)
						{
							num = (short)1652883470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					}
					case 20:
						if (dataProfNLSKeySele_A.RefRecset != null)
						{
							num = (short)2041905176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1698889738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					}
					case 22:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (!secKmfProfGenIndependentKeyList_.Applicable)
						{
							num = (short)759169041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160;
					}
					case 23:
						if (dataProfNLSKMFProfSele_A.Value < 0)
						{
							num = (short)632946714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E;
					case 24:
						num = (short)53018647;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (encryptionKeyListInnerRecset != null)
						{
							num = (short)1667366925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DD;
					case 26:
						return false;
					case 27:
						num = (short)844955651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (dataProfNLSKMFProfSele_A.RefRecset != null)
						{
							num = (short)1741946907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					}
					goto IL_A2;
					IL_39E:
					num = (short)1804992518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DD:
					num = (short)940179467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_428:
					num = (short)118292495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67F:
					encryptionKeyListInnerRecset = (dataProfNLSKeySele_A.RefRecset as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.EncryptionKeyListInnerRecset);
					flag = false;
					num = (short)225509385;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_160:
				num = (short)1706557441;
				if (num != 0)
				{
				}
				return true;
				IL_468:
				goto IL_160;
				IL_6CE:
				num = (short)1768030208;
				short num4 = num;
				return dataProfNLSKMFProfSele_A.Value == 0 || flag;
				IL_A2:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity networkLayerSecurity = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity;
				dataProfNLSKMFProfSele_A = networkLayerSecurity.DataProfNLSKMFProfSele_A36419;
				dataProfNLSKeySele_A = networkLayerSecurity.DataProfNLSKeySele_A36410;
				num = (short)2009137172;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x009DD4B4 File Offset: 0x009DB6B4
		public static bool conSecureClearStrappingValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			bool flag;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (index == 0)
					{
						num2 = (short)261488641;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = self.Parent[10504].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerRecset;
					flag = true;
					enumerator = collection.GetEnumerator();
					num2 = (short)2135293958;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return true;
				case 2:
					goto IL_200;
				case 3:
				{
					try
					{
						num2 = (short)921370628;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1657667587;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num2 = (short)681443328;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).General.TrkSysGeneralDataProfileSelection_A19449.CalculateValidity();
								num2 = (short)531234818;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_2E8;
							case 3:
								goto IL_33A;
							case 4:
								goto IL_243;
							}
							goto IL_267;
							IL_243:
							switch (0)
							{
							case 0:
							{
								IL_267:
								num2 = (short)861820310;
								short num3 = num2;
								num2 = (short)774591894;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_243;
								default:
									num2 = (short)1586429952;
									if (num2 != 0)
									{
									}
									goto IL_2E8;
								}
								break;
							}
							}
							continue;
							IL_2E8:
							num2 = (short)1135476737;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_33A:
						goto IL_3C7;
					}
					finally
					{
						num2 = (short)332464130;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)247726081;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_3A5;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_370;
								}
								continue;
							}
							IL_370:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)587268096;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_3A5:;
					}
					goto IL_3A8;
					IL_3C7:
					num2 = (short)695271425;
					if (num2 != 0)
					{
					}
					num2 = (short)260636672;
					short num4 = num2;
					num2 = (short)2052718592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_3BF;
				case 5:
					goto IL_217;
				case 6:
					try
					{
						num2 = (short)1753743362;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)1648689157;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_177;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_D7;
								}
								continue;
							case 3:
								flag = false;
								num2 = (short)1311178753;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10506] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection).DataProfilesDACOperationalMode_A36199.Value == 1)
								{
									num2 = (short)753270787;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 5:
								goto IL_194;
							case 6:
								if (!enumerator.MoveNext())
								{
									num2 = (short)1041498112;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)459800580;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_D9:
							num2 = (short)1785266182;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_D7:
							goto IL_D9;
						}
						IL_177:
						IL_194:
						goto IL_5E;
					}
					finally
					{
						num2 = (short)196083714;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)1699020801;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_1FD;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1C9;
								}
								continue;
							}
							IL_1C9:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)749928448;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1FD:;
					}
					goto IL_200;
					IL_5E:
					num2 = (short)6356999;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (index == 1)
					{
						num2 = (short)1324482562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3A8;
				}
				goto IL_30;
				IL_200:
				num2 = (short)1995440133;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3A8:
				num2 = (short)2139947012;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_217:
			bool flag2 = !dataProfiles.General.DataConfigDataProfIPHeaderCompressionEnable_A36190.Value;
			goto IL_49B;
			IL_3BF:
			flag2 = false;
			IL_49B:
			return flag2 && flag;
			IL_30:
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
			num2 = (short)1368522755;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x009DD994 File Offset: 0x009DBB94
		public static bool condataProfNLSKMFProfSeleValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_52;
			}
			short num;
			int num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				num = (short)1195114497;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
					if (secureKMFProfile != null)
					{
						num = (short)308871172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
					if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFIPAddress_A8375 == 0L)
					{
						num = (short)65863682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 2:
					return false;
				case 3:
				{
					num = (short)1275985920;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = global::AcpCommonLib.FeatureManager.GetFeature(2055)[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
					num = (short)2110521344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)268500993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (index > 0)
					{
						num = (short)1148715011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					try
					{
						num = (short)1599864836;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)253624323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current).General.TrkSysGeneralDataProfileSelection_A19449.CalculateValidity();
								num = (short)1773862913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1B9;
							case 3:
								num = (short)740294658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_13D;
								}
								continue;
							}
							IL_13F:
							num = (short)1484980224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13D:
							goto IL_13F;
						}
						IL_1B9:
						goto IL_C9;
					}
					finally
					{
						num = (short)152305666;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_277;
							case 1:
							{
								num = (short)2007512864;
								short num4 = num;
								num = (short)510408480;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)1335951360;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)162988032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1F0;
								}
								continue;
							}
							IL_1F0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)459800577;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_277:;
					}
					return false;
					IL_C9:
					num = (short)718536709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_52;
			}
			return false;
			IL_52:
			enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
			num = (short)6291462;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x009DDCA8 File Offset: 0x009DBEA8
		internal static bool conIPAddrNonZeroValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			short num;
			int num2;
			global::AcpBusinessLayer.AcpIPAddressField dataProfNLSEncGatewayAddr_A;
			for (;;)
			{
				IL_0A:
				num = (short)1740832769;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					while (dataProfNLSEncGatewayAddr_A.Value != 0L)
					{
						num = (short)938956365;
						short num3 = num;
						num = (short)650073677;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_132;
						}
					}
					num = (short)1522401281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return false;
				case 2:
					goto IL_93;
				case 3:
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataProfNLSEncGatewayAddr_A.Value)))
					{
						num = (short)1371275266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1584988160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_47;
			}
			IL_93:
			num = (short)376242176;
			short num4 = num;
			return false;
			IL_132:
			num = (short)1082982400;
			if (num != 0)
			{
			}
			return true;
			IL_47:
			dataProfNLSEncGatewayAddr_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity).DataProfNLSEncGatewayAddr_A36412;
			num = (short)982908931;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600A9F3 RID: 43507 RVA: 0x009DDE00 File Offset: 0x009DC000
		public static bool conTerminalDataScanlistDataMember(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)730595328;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
				try
				{
					num = (short)1975123984;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2;
							if (dataProfiles2.Features.DataProfFeaturesTerminalData_A9288.Equals(dataProfiles.Features.DataProfFeaturesTerminalData_A9288))
							{
								num = (short)1666121736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
							num = (short)404357133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_350;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1074462735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedDataMember_A = ((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current).General.ScanLstGeneralDesignatedDataMember_A7829;
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanLstGeneralDesignatedDataMember_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
							num = (short)1150156810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2 = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
							num = (short)199884806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							num = (short)555745281;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							if (conventionalPersonality != null)
							{
								num = (short)336986119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2;
							if (dataProfiles2 != null)
							{
								num = (short)1314586635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
							num = (short)339476492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::AcpBusinessLayer.AcpRecRefField scanLstGeneralDesignatedDataMember_A;
							scanLstGeneralDesignatedDataMember_A.CalculateValidity();
							num = (short)697892873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
							if (scanListInner != null)
							{
								num = (short)1312030721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							num = (short)993525760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
							if (conventionalSystem != null)
							{
								num = (short)781647876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							if (channelAssignmentListInner != null)
							{
								num = (short)544800782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 14:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
							num = (short)1531117573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							num = (short)580255746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						}
						IL_1D7:
						num = (short)1686306819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_AB:
						goto IL_1D7;
					}
					IL_350:;
				}
				finally
				{
					num = (short)1274871810;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_40D;
						case 1:
						{
							num = (short)210937863;
							short num3 = num;
							num = (short)2110236679;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)1016266752;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)306315264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_388;
							}
							continue;
						}
						IL_388:
						if (enumerator == null)
						{
							break;
						}
						num = (short)395444225;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_40D:;
				}
				num = (short)889651200;
				short num4 = num;
				return true;
			}
			}
		}

		// Token: 0x0600A9F4 RID: 43508 RVA: 0x009DE264 File Offset: 0x009DC464
		public static bool conDataProfileGroupIDIsUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1222049792;
			switch (num)
			{
			default:
			{
				num = (short)2124414986;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection trunkingGroupIDListInnerSection;
					int num3;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::AcpCommonLib.IAcpRecordset parent;
					switch (num2)
					{
					case 0:
					{
						num = (short)2079129601;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner = trunkingGroupIDListInnerSection.Parent.Parent[num3] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner;
						num = (short)829095945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						return false;
					case 2:
						return true;
					case 3:
					{
						if (num3 >= trunkingGroupIDListInnerSection.Parent.Parent.Count)
						{
							num = (short)388759554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1135476736;
						short num4 = num;
						num = (short)1372782596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int num5;
						if (num3 != num5)
						{
							num = (short)201195520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					}
					case 5:
					{
						try
						{
							num = (short)392429576;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2113339398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode != null)
									{
										num = (short)1991639045;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1574830080;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
									num = (short)2048458753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode == self.Parent.Parent.ParentSection.Parent)
									{
										num = (short)1818624007;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)790691843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_3CE;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									trunkingSystem.General.TrkSysGeneralUnitID_A12651.CalculateValidity();
									num = (short)1378484228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_298;
									}
									continue;
								}
								IL_29A:
								num = (short)1001914370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_298:
								goto IL_29A;
							}
							IL_3CE:;
						}
						finally
						{
							num = (short)463601666;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_490;
								case 1:
								{
									num = (short)1770316725;
									short num6 = num;
									num = (short)745792437;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1869479936;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1992228864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_405;
									}
									continue;
								}
								IL_405:
								if (enumerator == null)
								{
									break;
								}
								num = (short)703660033;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_490:;
						}
						int num5 = parent.IndexOf(self.Parent);
						int value = trunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Value;
						num3 = 0;
						num = (short)581042183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1FD;
					case 7:
						goto IL_1FD;
					case 8:
						return true;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						int value;
						if (value == trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Value)
						{
							num = (short)1620049921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						continue;
					}
					IL_6F:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection).DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.HiddenStatic)
					{
						num = (short)295108616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					trunkingGroupIDListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerSection);
					parent = self.Parent.Parent;
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset).GetEnumerator();
					num = (short)1767571461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					num3++;
					num = (short)2042822662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					num = (short)1478098947;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x0600A9F5 RID: 43509 RVA: 0x009DE75C File Offset: 0x009DC95C
		public static bool conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)65142787;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				num = (short)1941307393;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_127;
				case 1:
					goto IL_146;
				case 2:
				{
					num = (short)728891392;
					short num3 = num;
					num = (short)124728755;
					short num4 = num;
					num = (short)288961971;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					default:
						num = (short)1470955520;
						if (num != 0)
						{
						}
						num = (short)1528037376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				}
				IL_5D:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General;
				dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
				if (!general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
				{
					num = (short)1182597122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_127:
				if (dataProfGeneralDataProfileType_A.Value == 0)
				{
					break;
				}
				num = (short)990904321;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_146:
			return dataProfGeneralDataProfileType_A.Value == 3;
		}

		// Token: 0x0600A9F6 RID: 43510 RVA: 0x009DE8B4 File Offset: 0x009DCAB4
		internal static bool ConNATEableAvaliable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			short num2;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (general.DataProfGeneralPacketDataMode_A8689.Value == 2)
					{
						num2 = (short)724762630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_96;
				case 1:
					goto IL_184;
				case 2:
					goto IL_96;
				case 3:
					return true;
				case 4:
				{
					if (general.DataProfGeneralPacketDataMode_A8689.Value == 0)
					{
						return true;
					}
					num2 = (short)1006981708;
					short num3 = num2;
					num2 = (short)1810453068;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15C;
					default:
						num2 = (short)2012545025;
						if (num2 != 0)
						{
						}
						num2 = (short)1834549248;
						if (num2 != 0)
						{
						}
						num2 = (short)374538248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
				{
					num2 = (short)85524480;
					short num4 = num2;
					if (dataProfGeneralDataProfileType_A.Value == 2)
					{
						num2 = (short)803930115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 6:
					num2 = (short)853278727;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!dataProfiles.Features.DataProfFeaturesAtakField)
					{
						num2 = (short)1159790594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					num2 = (short)541982720;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)118358026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_15C;
				case 11:
					if (dataProfGeneralDataProfileType_A.Value != 0)
					{
						num2 = (short)1648164873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_184;
				}
				goto IL_40;
				IL_96:
				num2 = (short)2142502917;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15C:
				if (dataProfGeneralDataProfileType_A.Value == 3)
				{
					num2 = (short)413335553;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_96;
				IL_184:
				num2 = (short)657260548;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_40:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
			num2 = (short)1396113419;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9F7 RID: 43511 RVA: 0x009DEB40 File Offset: 0x009DCD40
		internal static bool conDataProfileTypeIsCnvPacketDataModeIsFNEAndAutoGenIpAddrDisabledNATEnableDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1944780806;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)466877990;
					short num3 = num2;
					num2 = (short)1473838630;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88;
					default:
					{
						num2 = (short)2035744768;
						if (num2 != 0)
						{
						}
						num2 = (short)1917976576;
						short num4 = num2;
						if (dataProfGeneralDataProfileType_A.Value == 3)
						{
							num2 = (short)2043412485;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1B1;
					}
					}
					break;
				}
				case 2:
					if (general.DataWideGeneralNATEnable_A38866.Value)
					{
						num2 = (short)1968504835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_C4;
				case 4:
					num2 = (short)1724383233;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_88;
				case 6:
					if (dataProfGeneralDataProfileType_A.Value != 0)
					{
						num2 = (short)1515388932;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_88;
				case 7:
					if (!general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
					{
						num2 = (short)1447362560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				}
				goto IL_30;
				IL_88:
				num2 = (short)1213136898;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_C4:
			return general.DataProfGeneralPacketDataMode_A8689.Value != 0;
			IL_1B1:
			num2 = (short)489422849;
			if (num2 != 0)
			{
			}
			return false;
			IL_30:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
			num2 = (short)269484039;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9F8 RID: 43512 RVA: 0x009DED28 File Offset: 0x009DCF28
		internal static bool ConDataProBTDUNPeerIPAddressesIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			bool value;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)152633345;
					if (num2 != 0)
					{
					}
					if (general.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value == 0)
					{
						num2 = (short)1755971590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (general.DataProfGeneralDataProfileType_A21320.Value == 3)
					{
						num2 = (short)22806532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)788987906;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					flag = false;
					goto IL_261;
				case 3:
				{
					num2 = (short)1626177384;
					short num3 = num2;
					num2 = (short)91193192;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19B;
					default:
						num2 = (short)2002059264;
						if (num2 != 0)
						{
						}
						num2 = (short)1285357576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					goto IL_184;
				case 5:
				{
					num2 = (short)1604976640;
					short num4 = num2;
					if (general.DataWideGeneralNATEnable_A38866.Value)
					{
						num2 = (short)614400003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 6:
					num2 = (short)448266245;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1812594688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_252;
				case 9:
					num2 = (short)1600585729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_19B;
				case 11:
					if (general.DataProfGeneralDataProfileType_A21320.Value != 0)
					{
						num2 = (short)908001289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_184;
				}
				goto IL_40;
				IL_184:
				num2 = (short)845283338;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_261:
				if (flag && value)
				{
					num2 = (short)534511623;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
				IL_19B:
				flag = !general.DataProfGeneralAutoGenerateIPAddress_A19320.Value;
				goto IL_261;
			}
			return true;
			IL_252:
			return general.DataProfGeneralPacketDataMode_A8689.Value != 0;
			IL_40:
			value = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			num2 = (short)244514827;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9F9 RID: 43513 RVA: 0x009DEFD4 File Offset: 0x009DD1D4
		public static bool ConDataProBTDUNSUIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1642856485;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num = (short)1393819668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56F;
				}
				case 2:
					num = (short)1033437187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value)
					{
						num = (short)1711734784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1948188701;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)2062745630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 5:
					return true;
				case 6:
					return false;
				case 7:
					return false;
				case 8:
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == general.DataProfGeneralSubscriberIPAddress_A21157.Value)
					{
						num = (short)1663827974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1661534244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return true;
				case 10:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[14] == addressBytes2[14])
					{
						num = (short)937754633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 11:
					return true;
				case 12:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num = (short)502595605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 13:
					return false;
				case 14:
					num = (short)2038497281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)828375068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 16:
					num = (short)486932502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return false;
				case 18:
				{
					num = (short)473694208;
					short num3 = num;
					num = (short)1870790666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					num = (short)165609503;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)451280900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					return true;
				case 22:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num = (short)1988886560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 23:
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value)))
					{
						num = (short)234291234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)678887451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						num = (short)66912272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 25:
					if (general.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.Value == 0)
					{
						num = (short)27131906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 26:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[13] == addressBytes2[13])
					{
						num = (short)666238994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 27:
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == 0L)
					{
						num = (short)1957494791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1233977379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					num = (short)42336282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num = (short)140312595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1327169569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 30:
					num = (short)699203596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes[12] == addressBytes2[12])
					{
						num = (short)545062917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 32:
					goto IL_173;
				case 33:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						num = (short)250413070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56F;
				}
				case 34:
					return false;
				case 35:
				{
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
					{
						num = (short)553123853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] addressBytes = general.DataProfilesGeneralBTDUNSUIPAddress_A41126.AddressBytes;
					byte[] addressBytes2 = general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.AddressBytes;
					num = (short)611516424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 36:
				{
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == general.DataProfGeneralMobileComputerIPAddress_A8523.Value)
					{
						num = (short)1985150977;
						if (num != 0)
						{
						}
						num = (short)1691222033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1234275866;
					short num4 = num;
					num = (short)1204325914;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						num = (short)1900937216;
						if (num != 0)
						{
						}
						num = (short)1046413337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 37:
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					continue;
				}
				IL_BC:
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)1887830027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				num = (short)526188567;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_173:
				num = (short)328138767;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_56F:
				num = (short)689963032;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600A9FA RID: 43514 RVA: 0x009DF678 File Offset: 0x009DD878
		public static bool ConDataProBTDUNPeerIPAddressesIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1057488899;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
				switch (num2)
				{
				case 0:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 127)
					{
						num = (short)91815968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1440350213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)43319323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)1594228762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_B6;
					}
					continue;
				case 4:
				{
					if (general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value == general.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
					{
						num = (short)831979529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					byte[] addressBytes2 = general.DataProfilesGeneralBTDUNSUIPAddress_A41126.AddressBytes;
					byte[] addressBytes = general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.AddressBytes;
					num = (short)1201012750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 128)
					{
						goto IL_48F;
					}
					goto IL_3D9;
				}
				case 6:
					if (general.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value == general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value)
					{
						num = (short)1292304396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1528102916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num = (short)51052579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 8:
					num = (short)560332802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return false;
				case 10:
					if (general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value == general.DataProfGeneralSubscriberIPAddress_A21157.Value)
					{
						num = (short)218365965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1220739072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1253703697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return false;
				case 13:
					return false;
				case 14:
					if (general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value == general.DataProfGeneralMobileComputerIPAddress_A8523.Value)
					{
						num = (short)482410519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)968884234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					return true;
				case 16:
					num = (short)181534749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[13] == addressBytes[13])
					{
						num = (short)853999617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 18:
				{
					byte[] addressBytes;
					if (addressBytes[12] >= 192)
					{
						num = (short)1470234654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 19:
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value)))
					{
						num = (short)322109460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)212664354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					return false;
				case 21:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 223)
					{
						num = (short)1605566465;
						if (num != 0)
						{
						}
						num = (short)2041446416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 22:
					num = (short)628162593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					return false;
				case 24:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)459603968;
						short num3 = num;
						num = (short)772079631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 25:
					return true;
				case 26:
					num = (short)191234055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[14] != addressBytes[14])
					{
						return false;
					}
					num = (short)847387625;
					short num4 = num;
					num = (short)1144331241;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48F;
					default:
						num = (short)1498808320;
						if (num != 0)
						{
						}
						num = (short)541720601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 28:
					return false;
				case 29:
				{
					byte[] addressBytes;
					byte[] addressBytes2;
					if (addressBytes2[12] == addressBytes[12])
					{
						num = (short)532283403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 30:
					num = (short)1146290197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					return true;
				case 32:
					num = (short)532348952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
				{
					byte[] addressBytes;
					if (addressBytes[12] <= 191)
					{
						num = (short)1406140424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D9;
				}
				case 34:
					if (general.DataProfilesGeneralBTDUNPeerIPAddress_A41127.Value == 0L)
					{
						num = (short)397148188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1912209414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					return true;
				}
				IL_B6:
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)866189343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				num = (short)976814099;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D9:
				num = (short)1950482450;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_48F:
				num = (short)1590165526;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600A9FB RID: 43515 RVA: 0x009DFCCC File Offset: 0x009DDECC
		internal static bool ConBluetoothEnableIsEnabledDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledAndDataModeIsFNEAndNATEnableDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_131;
				case 1:
					if (general.DataProfGeneralDataProfileType_A21320.Value == 3)
					{
						num2 = (short)771162112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)169541633;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)215613448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)438718441;
					short num3 = num2;
					num2 = (short)1080315881;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1312096256;
						if (num2 != 0)
						{
						}
						if (general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
						{
							return false;
						}
						break;
					}
					num2 = (short)1151467523;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (general.DataProfGeneralDataProfileType_A21320.Value != 0)
					{
						num2 = (short)315359234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 6:
					goto IL_253;
				case 7:
					if (general.DataWideGeneralNATEnable_A38866.Value)
					{
						num2 = (short)1186332673;
						if (num2 != 0)
						{
						}
						num2 = (short)2123235328;
						short num4 = num2;
						num2 = (short)1889665030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					if (radioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value)
					{
						num2 = (short)1599471625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					num2 = (short)606535687;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
				IL_131:
				num2 = (short)88276996;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_253:
			return general.DataProfGeneralPacketDataMode_A8689.Value != 0;
			IL_38:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			num2 = (short)891092997;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A9FC RID: 43516 RVA: 0x009DFF34 File Offset: 0x009DE134
		public static bool conNonEditableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1406256229;
			short num2 = num;
			num = (short)40879205;
			switch (num2 == num)
			{
			}
			num = (short)486277120;
			short num3 = num;
			num = (short)490209280;
			if (num != 0)
			{
			}
			num = (short)1206845441;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x0600A9FD RID: 43517 RVA: 0x009DFFE8 File Offset: 0x009DE1E8
		internal static bool conDataProfileTypeIsConventionalAndAutoGenIpAddrDisabledEditblForRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1136918533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
					{
						num2 = (short)706019332;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_12C;
				case 3:
					if (general.DataProfGeneralDataProfileType_A21320.Value != 0)
					{
						num2 = (short)559808512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 4:
					num2 = (short)2098855939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_104;
				}
				goto IL_28;
			}
			IL_E4:
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
			IL_104:
			if (general.DataProfGeneralDataProfileType_A21320.Value == 3)
			{
				goto IL_115;
			}
			return false;
			IL_12C:
			num2 = (short)260046848;
			short num3 = num2;
			goto IL_E4;
			IL_28:
			num2 = (short)287688491;
			short num4 = num2;
			num2 = (short)1039451947;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_115:
				num2 = (short)1836056578;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1299775489;
				if (num2 != 0)
				{
				}
				num2 = (short)272760832;
				if (num2 != 0)
				{
				}
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				num2 = (short)69730305;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A9FE RID: 43518 RVA: 0x009E0194 File Offset: 0x009DE394
		public static bool conAutoGenerateIPAddressIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1340473344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1193213952;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)954007553;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1566769158;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles == self.Parent)
									{
										num = (short)1004273669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles != null)
									{
										num = (short)840761348;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1442250760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1487798281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1424949249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitKillOperation_A41553.CalculateApplicability();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitKillOperation_A41553.CalculateValidity();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitStunOperation_A41557.CalculateApplicability();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitStunOperation_A41557.CalculateValidity();
									num = (short)1274347520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_FB;
									}
									continue;
								case 7:
									goto IL_2A7;
								case 8:
									num = (short)1561264135;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)2000617482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
									num = (short)277544962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_100:
								num = (short)512622595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FB:
								goto IL_100;
							}
							IL_2A7:
							return true;
						}
						finally
						{
							num = (short)760610817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_363;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2DE;
									}
									continue;
								case 2:
								{
									num = (short)1737629930;
									short num4 = num;
									num = (short)794960106;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2E4;
									default:
										num = (short)1989410816;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1138688000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_2DE;
								IL_2E4:
								num = (short)419561474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DE:
								if (enumerator != null)
								{
									goto IL_2E4;
								}
								break;
							}
							IL_363:;
						}
						goto IL_366;
					case 1:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1158414338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						goto IL_366;
					}
					goto IL_64;
					IL_366:
					enumerator = conventionalPersonalityRecset.GetEnumerator();
					num = (short)1125711872;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_64:
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)438435841;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600A9FF RID: 43519 RVA: 0x009E0570 File Offset: 0x009DE770
		internal static bool ConARSModeIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)141295616;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_75;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				for (;;)
				{
					IL_28:
					num = (short)1431437313;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3)
						{
							num = (short)258932737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_427;
					case 1:
						num = (short)484704260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 0)
						{
							num = (short)2003042309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_427;
					case 3:
						goto IL_427;
					case 4:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 2)
						{
							num = (short)2030960643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						num = (short)1006960640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)863895554;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)921632770;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
												if (conventionalPersonality != null)
												{
													num = (short)1517415535;
													short num3 = num;
													num = (short)643755119;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														continue;
													default:
														num = (short)1841168384;
														if (num != 0)
														{
														}
														num = (short)1364918273;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
												}
												break;
											}
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
												conventionalPersonality.Features.CnvPerFeaturesFiregroundRegistration_A33242.CalculateValidity();
												num = (short)2099970052;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_21E;
												}
												continue;
											case 3:
												goto IL_32E;
											case 5:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)598671366;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
												num = (short)568459264;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												num = (short)1666318339;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_220:
											num = (short)1624768517;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_21E:
											goto IL_220;
										}
										IL_32E:
										break;
									}
									finally
									{
										num = (short)1668022273;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												goto IL_39B;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_366;
												}
												continue;
											case 2:
												enumerator.Dispose();
												num = (short)384892928;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_366:
											if (enumerator == null)
											{
												break;
											}
											num = (short)144506882;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_39B:;
									}
									goto IL_39E;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)264175620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_13A;
									}
									continue;
								case 3:
									goto IL_3B6;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalSystem.ReferencingNodes.GetEnumerator();
									num = (short)443744256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1350959110;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)438960129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_39E;
								}
								IL_13C:
								num = (short)1440743429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13A:
								goto IL_13C;
								IL_39E:
								num = (short)1255342083;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B6:
							return true;
						}
						finally
						{
							num = (short)471138305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_424;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3EE;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1753350144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3EE:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)791937026;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_424:;
						}
						goto IL_427;
					}
					goto IL_75;
					IL_427:
					enumerator2 = dataProfiles.ReferencingNodes.GetEnumerator();
					num = (short)1325924358;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_75:
				dataProfiles = ((self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features).Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
				num = (short)1650196480;
				short num4 = num;
				num = (short)1609957378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600AA00 RID: 43520 RVA: 0x009E0A94 File Offset: 0x009DEC94
		internal static bool conDataPrfTypeIsConventionalAndAutoGenIpAddrDisabledWithRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1218183172;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)1291845635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)787614876;
					short num3 = num;
					num = (short)982060188;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_BC;
					}
					break;
				}
				case 3:
					if (general.DataProfGeneralDataProfileType_A21320.Value != 0)
					{
						num = (short)1118699522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 5:
					if (!general.DataProfGeneralAutoGenerateIPAddress_A19320.Value)
					{
						num = (short)271777793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
				}
				IL_3C:
				num = (short)557449217;
				if (num != 0)
				{
				}
				if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
				{
					num = (short)1593049088;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
					num = (short)732823557;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_BC:
			num = (short)945553408;
			if (num != 0)
			{
			}
			return general.DataProfGeneralDataProfileType_A21320.Value == 3;
			IL_16F:
			num = (short)467468288;
			short num4 = num;
			return false;
		}

		// Token: 0x0600AA01 RID: 43521 RVA: 0x009E0C3C File Offset: 0x009DEE3C
		internal static bool conEnhancedDataApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_158;
				case 1:
					num2 = (short)1423048707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)636026881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EA;
				case 3:
					if (dataProfGeneralDataProfileType_A.Value == 4)
					{
						num2 = (short)1001259009;
						if (num2 != 0)
						{
						}
						num2 = (short)416350208;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_20;
			}
			IL_EA:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData enhancedData;
			return enhancedData.DatProFeaturesPortListSelection_A42011.Value != 0;
			IL_158:
			goto IL_EA;
			IL_20:
			num2 = (short)1622867968;
			short num3 = num2;
			enhancedData = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData);
			dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
			num2 = (short)322799165;
			short num4 = num2;
			num2 = (short)831161917;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)874184704;
				if (num2 != 0)
				{
				}
				num2 = (short)730726402;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AA02 RID: 43522 RVA: 0x009E0DA4 File Offset: 0x009DEFA4
		internal static bool conPackDataRegVerValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)330104837;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)63832065;
					if (num2 != 0)
					{
					}
					num2 = (short)204537859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_166;
				case 3:
					if (general.DataProfGeneralDataProfileType_A21320.Value == 4)
					{
						num2 = (short)414908418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
				{
					if (index != 0)
					{
						return true;
					}
					num2 = (short)1621229568;
					short num3 = num2;
					num2 = (short)228823010;
					short num4 = num2;
					num2 = (short)529698786;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)502792192;
						if (num2 != 0)
						{
						}
						num2 = (short)1399521280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (general.DataProfGeneralDataProfileType_A21320.Value != 1)
					{
						num2 = (short)383647745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E8;
				}
				goto IL_28;
			}
			IL_E8:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			return dataProfiles.EnhancedData.DatProFeaturesPortListSelection_A42011.Value <= 0;
			IL_166:
			goto IL_E8;
			IL_28:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			num2 = (short)456851460;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA03 RID: 43523 RVA: 0x009E0F64 File Offset: 0x009DF164
		public static bool conAutoGenerateTargetIPAddressIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2051211264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_36F;
					case 1:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1289879552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9;
					case 2:
						try
						{
							num = (short)1400504329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									num = (short)1839699035;
									short num3 = num;
									num = (short)479302747;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_16D;
									default:
										num = (short)1333657600;
										if (num != 0)
										{
										}
										num = (short)783417347;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)2023489543;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles == self.Parent)
									{
										num = (short)149159946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)70713352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles != null)
									{
										num = (short)1417740289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)486604802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									goto IL_16D;
								}
								case 7:
									goto IL_300;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
									num = (short)1762656261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_109;
									}
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitKillOperation_A41553.CalculateApplicability();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitKillOperation_A41553.CalculateValidity();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitStunOperation_A41557.CalculateApplicability();
									conventionalPersonality.ASTROCall.CnvPerTacticalInhibitStunOperation_A41557.CalculateValidity();
									num = (short)331350016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_10E:
								num = (short)681967622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_109:
								goto IL_10E;
								IL_16D:
								num = (short)452001796;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_300:
							goto IL_3B9;
						}
						finally
						{
							num = (short)901775361;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2045313026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_337;
									}
									continue;
								case 2:
									goto IL_36C;
								}
								IL_337:
								if (enumerator == null)
								{
									break;
								}
								num = (short)416940032;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_36C:;
						}
						goto IL_36F;
					}
					goto IL_3A;
					IL_36F:
					enumerator = conventionalPersonalityRecset.GetEnumerator();
					num = (short)1456996353;
					if (num != 0)
					{
					}
					num = (short)654704642;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B9:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
				return general.DataProfGeneralAutoGenerateIPAddress_A19320.Value;
				IL_3A:
				num = (short)2099773440;
				short num4 = num;
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)114294785;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600AA04 RID: 43524 RVA: 0x009E1354 File Offset: 0x009DF554
		internal static bool conDataProfileTypeIsLMR(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)730529797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)514392067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_152;
				case 3:
					goto IL_104;
				case 4:
					if (dataProfGeneralDataProfileType_A.Value != 0)
					{
						num2 = (short)243269632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)1161166849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
			}
			IL_152:
			return dataProfGeneralDataProfileType_A.Value == 4;
			IL_28:
			num2 = (short)1344446140;
			short num3 = num2;
			num2 = (short)1734385340;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_104:
				if (dataProfGeneralDataProfileType_A.Value != 3)
				{
					num2 = (short)289734657;
					if (num2 != 0)
					{
					}
					num2 = (short)400490498;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)884539392;
				if (num2 != 0)
				{
				}
				num2 = (short)605487104;
				short num4 = num2;
				dataProfGeneralDataProfileType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General).DataProfGeneralDataProfileType_A21320;
				num2 = (short)922419204;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return true;
		}

		// Token: 0x0600AA05 RID: 43525 RVA: 0x009E14F4 File Offset: 0x009DF6F4
		internal static bool conDataProfileOperModeApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)215941125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_12F;
				case 2:
					goto IL_16F;
				case 3:
					if (dataProfiles.EnhancedData.DatProFeaturesPortListSelection_A42011.ReferencedNode != null)
					{
						num2 = (short)394723330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
				{
					num2 = (short)706084864;
					short num3 = num2;
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 1)
					{
						goto IL_12F;
					}
					num2 = (short)731537058;
					short num4 = num2;
					num2 = (short)581983906;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)1396834304;
						if (num2 != 0)
						{
						}
						num2 = (short)2026045440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
					{
						num2 = (short)337444865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_28;
				IL_12F:
				num2 = (short)1276313603;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16F:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection daclistInnerSection;
			return daclistInnerSection.DataProfilesDACOperationalMode_A36199.Value != 0;
			IL_28:
			daclistInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInnerSection);
			dataProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			num2 = (short)1358888961;
			if (num2 != 0)
			{
			}
			num2 = (short)1284374532;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA06 RID: 43526 RVA: 0x009E16BC File Offset: 0x009DF8BC
		internal static bool conDataProfileOperModeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_199;
				case 1:
					goto IL_1B8;
				case 2:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
					{
						num2 = (short)138149893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19F;
				case 3:
				{
					num2 = (short)751632385;
					if (num2 != 0)
					{
					}
					num2 = (short)1417208574;
					short num3 = num2;
					num2 = (short)2095244030;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)872808448;
						if (num2 != 0)
						{
						}
						num2 = (short)895483906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					if (dataProfiles.EnhancedData.DatProFeaturesPortListSelection_A42011.ReferencedNode != null)
					{
						num2 = (short)192020487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19F;
				case 5:
					goto IL_13C;
				case 6:
					if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
					{
						num2 = (short)581697539;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13C;
				case 7:
					num2 = (short)1427243008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_13C:
				num2 = (short)1967783940;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19F:
				num2 = (short)2006515713;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_199:
			bool flag = index != 0;
			goto IL_1E4;
			IL_1B8:
			num2 = (short)1523908608;
			short num4 = num2;
			flag = false;
			IL_1E4:
			bool flag2 = dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4 && index != 0;
			return !flag && !flag2;
			IL_30:
			dataProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
			num2 = (short)1476919302;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA07 RID: 43527 RVA: 0x009E18D4 File Offset: 0x009DFAD4
		internal static bool ConDataProfLTEApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)946929664;
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
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
						{
							num = (short)1341194243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1376256008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3)
						{
							num = (short)1240924160;
							short num3 = num;
							num = (short)1263468548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_7E3;
					case 4:
						goto IL_856;
					case 5:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)844955649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F61;
					case 6:
						num = (short)106299397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)1705443329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_EA7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D2F;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									trunkingPersonality.Features.TrkPerFeatureBackupPTTOperation_A43628.CalculateValidity();
									num = (short)1948385282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)502464520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
									num = (short)477888519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2 = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (dataProfiles2 == self.Parent && trunkingPersonality.Features.TrkPerFeaturesScanListSelection_A9053.ReferencedNode != null)
									{
										trunkingPersonality.Features.TrkPerFeaturesScanListSelection_A9053.CalculateValidity();
									}
									if (dataProfiles2 == self.Parent)
									{
										num = (short)1027801091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)2140798981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
									if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
									{
										num = (short)1944190982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)2020605952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E51:
								num = (short)372899844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D2F:
								goto IL_E51;
							}
							IL_EA7:
							goto IL_FAE;
						}
						finally
						{
							num = (short)1334116353;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									IL_EF6:
									enumerator.Dispose();
									num = (short)571670530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EDE;
									}
									continue;
								case 2:
									goto IL_F15;
								}
								IL_EDE:
								if (enumerator != null)
								{
									num = (short)1280442368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F15:
								num = (short)1374505547;
								short num4 = num;
								num = (short)2027571787;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_EF6;
								default:
									goto IL_F4B;
								}
							}
							IL_F4B:
							num = (short)957743104;
							if (num != 0)
							{
							}
						}
						goto IL_F61;
						IL_FAE:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
						num = (short)1427963914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)604438562;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)182321160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = conventionalPersonality.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)1343291401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles == self.Parent)
									{
										num = (short)877264913;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								}
								case 2:
									goto IL_772;
								case 3:
									num = (short)116850702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									if (conventionalPersonality2.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
									{
										num = (short)962134021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalPersonality2.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
									num = (short)2143617049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (conventionalPersonality.FrequencyOptions.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.Value)
									{
										num = (short)1078853643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)752746497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)9961474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (conventionalPersonality.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044.Value != 0)
									{
										num = (short)933953565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								case 10:
									num = (short)844955652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1604190232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
									if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.Value != 0)
									{
										num = (short)761397283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
									num = (short)264241182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles == self.Parent)
									{
										num = (short)1851850768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 16:
									conventionalPersonality.Features.CnvPerLabtoolScanListSelection_A9054.CalculateValidity();
									num = (short)190971919;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									conventionalPersonality.Features.ConPerFeatureIncidentSignalingType_A41507.CalculateValidity();
									conventionalPersonality.Features.CnvPerFeaturesTacticalRekeyEnable_A19309.CalculateValidity();
									conventionalPersonality.FrequencyOptions.CnvPerConventionalChannelOptionsInterferenceFreqAllowed_A42257.CalculateValidity();
									conventionalPersonality.Secure.CnvPerSecureKMFProfileIndex_A8381.CalculateValidity();
									num = (short)1306460186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)499056652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									num = (short)1118896159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
									if (scanListInner != null)
									{
										num = (short)93454349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = scanList.General.ScanLstGeneralDesignatedDataMember_A7829.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner;
									num = (short)24051732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
									conventionalPersonality.Features.CnvPerLabtoolScanListSelection_A9054.CalculateValidity();
									num = (short)560988187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
									if (conventionalSystem != null)
									{
										num = (short)1426587655;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_296;
								}
								case 24:
									if (scanList != null)
									{
										num = (short)885784609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2 != null)
									{
										num = (short)753074195;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 26:
									if (conventionalPersonality.Features.CnvPerLabtoolScanListSelection_A9054.ReferencedNode != null)
									{
										num = (short)1594294294;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 28:
									if (scanList.General.ScanLstGeneralDesignatedDataTxRxType_A21525.Value == 1)
									{
										num = (short)435027989;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 29:
									num = (short)1714421783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									if (channelAssignmentListInner != null)
									{
										num = (short)1800863762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 31:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2;
									if (conventionalSystem2.General.CnvSysGeneralSystemType_A13262.Value == 0)
									{
										num = (short)2131361795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 32:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2;
									if (conventionalPersonality2 != null)
									{
										num = (short)1951662090;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 33:
									num = (short)1687486492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									switch (0)
									{
									case 0:
										goto IL_1B1;
									}
									continue;
								case 35:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
									global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality2 = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
									num = (short)151060512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_1B1;
								IL_296:
								scanList = (conventionalPersonality.Features.CnvPerLabtoolScanListSelection_A9054.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList);
								num = (short)1996488710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_719:
								num = (short)627834880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B1:
								goto IL_719;
							}
							IL_772:
							goto IL_101F;
						}
						finally
						{
							num = (short)617611265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_7E0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7AA;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1324089344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7AA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2080505858;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7E0:;
						}
						goto IL_7E3;
						IL_101F:
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
						num = (short)1503985671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
						{
							num = (short)732233734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F61;
					case 10:
						try
						{
							num = (short)951386113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1877868554;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)1071579143;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2;
												scanListInner2.ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)184352774;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
												if (conventionalSystem3 != null)
												{
													num = (short)1755512835;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 3:
												num = (short)1094123532;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3 = conventionalPersonality3.Signaling.CnvPerSignalingASTROSystem_A7498.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
												num = (short)75431938;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)132972552;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator2.Current;
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2 = scanListInner2.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
												num = (short)1341325323;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 7:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
												if (channelAssignmentListInner2.ChannelAssignmentListInnerSection.FrequencyOptionsInnerSectionForZnChanCfgChannelsConventionalChannelReference_A20560 != null)
												{
													num = (short)522125326;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												num = (short)1772093449;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
												goto IL_B5C;
											case 10:
												switch (0)
												{
												case 0:
													goto IL_922;
												}
												continue;
											case 11:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
												if (channelAssignmentListInner2 != null)
												{
													num = (short)1002569728;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 12:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem3;
												if (conventionalSystem3.General.CnvSysGeneralDataProfileSelection_A13266.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles == self.Parent)
												{
													num = (short)2062548993;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 13:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3;
												if (conventionalPersonality3 != null)
												{
													num = (short)1388183556;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 14:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
												global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality3 = channelAssignmentListInner2.ChannelAssignmentListInnerSection.FrequencyOptionsInnerSectionForZnChanCfgChannelsConventionalChannelReference_A20560.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
												num = (short)605552653;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_987:
											num = (short)1990983685;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_922:
											goto IL_987;
										}
										IL_B5C:;
									}
									finally
									{
										num = (short)297205761;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												goto IL_BC7;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_B90;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)336396288;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_B90:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1308229634;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_BC7:;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8BB;
									}
									continue;
								case 2:
									goto IL_C60;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1381826564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current).ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset).GetEnumerator();
									num = (short)1015939072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)2112421890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_BCA:
								num = (short)1025310723;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8BB:
								goto IL_BCA;
							}
							IL_C60:
							goto IL_F61;
						}
						finally
						{
							num = (short)1449918465;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2134835202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C97;
									}
									continue;
								case 2:
									goto IL_CCD;
								}
								IL_C97:
								if (enumerator == null)
								{
									break;
								}
								num = (short)785514496;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CCD:;
						}
						goto IL_CD0;
					}
					goto IL_5A;
					IL_7E3:
					num = (short)70975490;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F61:
					num = (short)414056448;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_856:
				IL_CD0:
				return dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4;
				IL_5A:
				num = (short)2012807169;
				if (num != 0)
				{
				}
				dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1238761481;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x009E2998 File Offset: 0x009E0B98
		internal static bool ConDataProfPADModeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dataProfGeneralDataProfileType_A.Value == 4)
					{
						num2 = (short)994246657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_DB;
				case 2:
					if (dataProfGeneralDataProfileType_A.Value != 2)
					{
						num2 = (short)1750466565;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9B;
				case 3:
					num2 = (short)1873805312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (dataProfGeneralDataProfileType_A.Value != 3)
					{
						num2 = (short)552730624;
						short num3 = num2;
						num2 = (short)217055235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9B;
				case 5:
				{
					num2 = (short)61257625;
					short num4 = num2;
					num2 = (short)534755225;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DB;
					default:
						num2 = (short)465108992;
						if (num2 != 0)
						{
						}
						num2 = (short)1719861252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			IL_9B:
			return index == 0;
			IL_DB:
			goto IL_9B;
			IL_28:
			num2 = (short)524091393;
			if (num2 != 0)
			{
			}
			dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
			num2 = (short)521535490;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x009E2B38 File Offset: 0x009E0D38
		internal static bool ConDataProfNATEableValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				num = (short)1948345487;
				short num2 = num;
				num = (short)1652319375;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1076756480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_E3;
					case 1:
						goto IL_146;
					case 2:
						if (dataProfGeneralDataProfileType_A.Value == 2)
						{
							num = (short)1154088961;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						if (dataProfGeneralDataProfileType_A.Value != 3)
						{
							num = (short)130416640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1;
					}
					goto IL_6A;
				}
				IL_E3:
				num = (short)850132992;
				short num4 = num;
				num = (short)1167458306;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_B1:
			num = (short)1477443585;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			return general.DataWideGeneralNATEnable_A38866;
			IL_146:
			goto IL_B1;
			IL_6A:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
			num = (short)1115881475;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x009E2C94 File Offset: 0x009E0E94
		internal static bool ConDataProfVPNSecureClearStrappingApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)153485314;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (dataProfGeneralDataProfileType_A.Value != 3)
					{
						num = (short)873005057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_CD;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
				{
					num = (short)1528758273;
					if (num != 0)
					{
					}
					num = (short)136904704;
					short num3 = num;
					num = (short)1750597632;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)1172155931;
					short num4 = num;
					num = (short)1167830555;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CF;
					default:
						num = (short)1131151360;
						if (num != 0)
						{
						}
						if (dataProfGeneralDataProfileType_A.Value != 2)
						{
							num = (short)1184759811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 5:
					goto IL_CF;
				}
				IL_3D:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity networkLayerSecurity = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity;
				dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
				if (networkLayerSecurity.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
				{
					num = (short)1428226053;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_CF:
				num = (short)945291268;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CD:
			return dataProfGeneralDataProfileType_A.Value == 4;
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x009E2E4C File Offset: 0x009E104C
		internal static bool ConDataProfVPNGatewayIPApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity networkLayerSecurity;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)345047041;
					if (num2 != 0)
					{
					}
					if (networkLayerSecurity.DataProfVPNSecClrStrp_A42120.Value == 1)
					{
						num2 = (short)293666822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (dataProfGeneralDataProfileType_A.Value != 2)
					{
						num2 = (short)1347354626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					num2 = (short)1513422853;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_151;
				case 4:
				{
					num2 = (short)668925952;
					short num3 = num2;
					if (networkLayerSecurity.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)742850567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 5:
					goto IL_12E;
				case 6:
					num2 = (short)1046609921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)709165056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_12E:
			if (dataProfGeneralDataProfileType_A.Value != 3)
			{
				goto IL_13A;
			}
			return true;
			IL_151:
			return dataProfGeneralDataProfileType_A.Value == 4;
			IL_30:
			networkLayerSecurity = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity);
			dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
			num2 = (short)1230163577;
			short num4 = num2;
			num2 = (short)836554361;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13A:
				num2 = (short)1195048963;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1420951552;
				if (num2 != 0)
				{
				}
				num2 = (short)56229892;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x009E3058 File Offset: 0x009E1258
		internal static bool conDataProfByPassApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2129395712;
			switch (num)
			{
			default:
			{
				num = (short)1014759426;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				for (;;)
				{
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						if (!flag)
						{
							num = (short)373489665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					case 1:
						num = (short)277348356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)472958666;
						short num3 = num;
						num = (short)1623967434;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A3;
						default:
							num = (short)1165099008;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A7;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_1E4;
					case 4:
						if (flag2)
						{
							goto IL_1A3;
						}
						return false;
					case 5:
						num = (short)1973092352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A7:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection eidbypassListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInnerSection;
					dataProfiles = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
					global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = dataProfiles.General.DataProfGeneralDataProfileType_A21320;
					bool flag3 = global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesConstraints.a(eidbypassListInnerSection.RefSecureWide);
					flag2 = (dataProfGeneralDataProfileType_A.Value == 2 || dataProfGeneralDataProfileType_A.Value == 3 || dataProfGeneralDataProfileType_A.Value == 4);
					flag = ((dataProfGeneralDataProfileType_A.Value == 1 || dataProfGeneralDataProfileType_A.Value == 4) && dataProfiles.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value == 1);
					if (flag3)
					{
						num = (short)853737477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_1A3:
					num = (short)1435828225;
					if (num != 0)
					{
					}
					num = (short)2042232835;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E4:
				return dataProfiles.NetworkLayerSecurity.DataProfVPNSecClrStrp_A42120.Value == 1;
				IL_1FC:
				num = (short)1298202624;
				short num4 = num;
				return true;
			}
			}
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x009E3290 File Offset: 0x009E1490
		internal static void conDataProfileLTEValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)708313088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE lte;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(lte.DataProfBroadbandSource_A42858, 0));
						num = (short)1697644552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag != radioWide.LTE.RadWideLabtoolLTEUsed_A42064.Value)
						{
							num = (short)69926925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_504;
					case 2:
						num = (short)406519809;
						if (num != 0)
						{
						}
						goto IL_504;
					case 3:
						if (lte.DataProfBroadbandSource_A42858.Value == 0)
						{
							num = (short)143523846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E;
					case 4:
						num = (short)170393607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (lte.DataProfBroadbandSource_A42858.Value != 0)
						{
							num = (short)1426587648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_5FF;
					case 7:
						if (lte.DataProfLTEEnabled_A42075.Value)
						{
							num = (short)1891172366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48E;
					case 8:
						goto IL_4FF;
					case 9:
						if (!lte.DataProfLTEEnabled_A42075.Value)
						{
							num = (short)678559756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
						{
							num = (short)1965817860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						try
						{
							num = (short)198377483;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1813708809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									flag = true;
									num = (short)2013659142;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3CE;
								case 3:
									num = (short)1956249602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfLTEEnabled_A42075.Value)
									{
										num = (short)89653249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
									{
										num = (short)1373962240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DC;
								}
								case 6:
									goto IL_3B1;
								case 7:
									if (radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
									{
										num = (short)1642594318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
									{
										num = (short)951779338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 3)
									{
										num = (short)1025114124;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1DC;
								}
								case 10:
									goto IL_1DC;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 12:
									num = (short)1535377416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)781254659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)1003552773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)187891716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D7;
								IL_1DC:
								num = (short)408682503;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_358:
								num = (short)257556493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D7:
								goto IL_358;
							}
							IL_3B1:
							IL_3CE:
							goto IL_551;
						}
						finally
						{
							num = (short)1032912898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_442;
								case 1:
									IL_421:
									enumerator.Dispose();
									num = (short)853934080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_406;
									}
									continue;
								}
								IL_406:
								if (enumerator != null)
								{
									num = (short)369557505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_442:
								num = (short)1475927466;
								short num3 = num;
								num = (short)1992940970;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_421;
								default:
									goto IL_477;
								}
							}
							IL_477:
							num = (short)1784086528;
							if (num != 0)
							{
							}
						}
						goto IL_48E;
						IL_551:
						num = (short)1655635969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)672399365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)27590656;
						short num4 = num;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.LTE.RadWideLabtoolLTEUsed_A42064, flag));
						num = (short)748552194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)1765277699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_48E:
					num = (short)290390025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_504:
					num = (short)859635722;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4FF:
				return;
				IL_5FF:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(lte.DataProfBroadbandSource_A42858, 1));
				return;
				IL_6B:
				flag = false;
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				lte = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
				num = (short)231014411;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x009E391C File Offset: 0x009E1B1C
		internal static bool ConVPNGatewayIPAddrValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpIPAddressField dataProfVPNGatewayIPAddress_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.NetworkLayerSecurity).DataProfVPNGatewayIPAddress_A42079;
			if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataProfVPNGatewayIPAddress_A.Value)))
			{
				short num = (short)592924712;
				short num2 = num;
				num = (short)5263400;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)439353344;
					if (num != 0)
					{
					}
					num = (short)695599104;
					short num3 = num;
					num = (short)737017857;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return dataProfVPNGatewayIPAddress_A.Value != 0L;
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x009E39F4 File Offset: 0x009E1BF4
		internal static bool ConDataProfileNATEnabledVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_69;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			for (;;)
			{
				IL_0A:
				num = (short)964384287;
				short num2 = num;
				num = (short)410080799;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)129826816;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_B7;
					case 1:
						goto IL_119;
					case 2:
					{
						num = (short)1649868800;
						short num4 = num;
						if (dataProfGeneralDataProfileType_A.Value != 3)
						{
							num = (short)2036006913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
						if (dataProfGeneralDataProfileType_A.Value != 0)
						{
							num = (short)901513216;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_69;
				}
				IL_B7:
				num = (short)1369571330;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_119:
			num = (short)1996488705;
			if (num != 0)
			{
			}
			return dataProfGeneralDataProfileType_A.Value == 2;
			IL_69:
			dataProfGeneralDataProfileType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General).DataProfGeneralDataProfileType_A21320;
			num = (short)1230307331;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x009E3B48 File Offset: 0x009E1D48
		internal static bool ConDataProfPADModeVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features;
			if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320.Value == 2)
			{
				short num = (short)1325096157;
				short num2 = num;
				num = (short)540040413;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)66453505;
					if (num != 0)
					{
					}
					num = (short)17498112;
					short num3 = num;
					num = (short)1080033280;
					if (num != 0)
					{
					}
					return features.DatProFeaturesPADMode_A20536 != 0;
				}
				}
			}
			return true;
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x009E3C28 File Offset: 0x009E1E28
		internal static bool conDirectLocationRegInApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (features.DataProfFeaturesARSMode_A7465.Value != 5)
					{
						num2 = (short)1230962689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_100;
				case 2:
					if (radioWide.Location.RadWideLocationLocationEnable_A8448.Value)
					{
						num2 = (short)560660485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)2001731584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (features.DataProfFeaturesARSMode_A7465.Value != 1)
					{
						num2 = (short)790036480;
						short num3 = num2;
						num2 = (short)1141047299;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)1736966145;
					if (num2 != 0)
					{
					}
					num2 = (short)1439921099;
					short num4 = num2;
					num2 = (short)2079552459;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_100;
					default:
						num2 = (short)1685848064;
						if (num2 != 0)
						{
						}
						num2 = (short)948371460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			IL_100:
			return radioWide.Location.RadWideLocP25LocationReporting_42412.Value;
			IL_28:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1217658882;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x009E3DF0 File Offset: 0x009E1FF0
		internal static bool conDirectLocationRegIsAppAndEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (radioWide.Location.RadWideLocationLocationEnable_A8448.Value)
					{
						num2 = (short)357040134;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (radioWide.Location.RadWideLocP25LocationReporting_42412.Value)
					{
						num2 = (short)1497628674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)1276313605;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_157;
				case 4:
				{
					num2 = (short)1636040704;
					short num3 = num2;
					if (features.DataProfFeaturesDirLocReg_A42332.Value)
					{
						num2 = (short)503775239;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 5:
					goto IL_12D;
				case 6:
					num2 = (short)714932225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)789184512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_12D:
			if (features.DataProfFeaturesARSMode_A7465.Value != 1)
			{
				goto IL_13E;
			}
			return false;
			IL_157:
			num2 = (short)2044723201;
			if (num2 != 0)
			{
			}
			return features.DataProfFeaturesARSMode_A7465.Value != 5;
			IL_30:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1893036254;
			short num4 = num2;
			num2 = (short)2137223390;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13E:
				num2 = (short)71237635;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)719060992;
				if (num2 != 0)
				{
				}
				num2 = (short)1589968900;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x009E4008 File Offset: 0x009E2208
		internal static bool conLocServerIPAddrValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)419168256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::AcpBusinessLayer.AcpIPAddressField dataProfFeaturesLocServerIPAddr_A;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (dataProfFeaturesLocServerIPAddr_A.Value != dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.Value)
						{
							num = (short)1669529601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 1:
						num = (short)1273495559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1389035526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_142;
					case 4:
						num = (short)582090766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1830551553;
						if (num != 0)
						{
						}
						num = (short)909115392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (dataProfFeaturesLocServerIPAddr_A.Value != dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.Value)
						{
							num = (short)2949130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 7:
						if (dataProfFeaturesLocServerIPAddr_A.Value != dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.Value)
						{
							num = (short)1706229760;
							short num3 = num;
							num = (short)2092105730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 8:
						return false;
					case 9:
						if (dataProfFeaturesLocServerIPAddr_A.Value != radioWide.Bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.Value)
						{
							num = (short)518914059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 10:
						num = (short)138870793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)191496207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						IL_BF:
						if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(new global::System.Net.IPAddress(dataProfFeaturesLocServerIPAddr_A.Value)))
						{
							num = (short)774766600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)731381773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (features.DataProfFeaturesDirLocReg_A42332.Value)
						{
							num = (short)1224015876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						if (dataProfFeaturesLocServerIPAddr_A.Value != 0L)
						{
							num = (short)1837826053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					case 15:
						if (dataProfFeaturesLocServerIPAddr_A.Value != features.RefDataWide.General.DataWideGeneralSubscriberIPAddress1_A9222.Value)
						{
							num = (short)1116667907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24C;
					}
					goto IL_6F;
					IL_24C:
					num = (short)1928032520;
					short num4 = num;
					num = (short)1339126024;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
						goto IL_281;
					}
				}
				return false;
				IL_142:
				return dataProfFeaturesLocServerIPAddr_A.Value != features.RefDataWide.General.DataWideGeneralBTDUNSUIPAddress_A41120.Value;
				IL_281:
				num = (short)1745027072;
				if (num != 0)
				{
				}
				return false;
				IL_6F:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features);
				dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				dataProfFeaturesLocServerIPAddr_A = features.DataProfFeaturesLocServerIPAddr_A42333;
				global::ConstraintHelper.UtilityMack.CalculateNewIPFieldsValidity(null);
				num = (short)1729888268;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x009E43E0 File Offset: 0x009E25E0
		internal static bool ConPacketDataModeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)833617923;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_E2;
				case 1:
					goto IL_13E;
				case 2:
					if (index != 1)
					{
						num = (short)1072103425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)263865947;
					short num3 = num;
					num = (short)681068123;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						num = (short)1869676545;
						if (num != 0)
						{
						}
						num = (short)600047616;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					}
					break;
				}
				}
				IL_AC:
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General).DataProfGeneralDataProfileType_A21320.Value == 3)
				{
					num = (short)1278476288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_E2:
				num = (short)1971847168;
				short num4 = num;
				num = (short)1128202242;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_13E:
			return index != 2;
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x009E4530 File Offset: 0x009E2730
		internal static bool conCallGroupIDConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset trunkingGroupIDListInnerRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					goto IL_93;
				case 1:
					try
					{
						num2 = (short)1605632004;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_152;
							case 1:
								num2 = (short)1089077251;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num2 = (short)282394625;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner)enumerator.Current).TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.CalculateApplicability();
								num2 = (short)784072704;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								goto IL_1A4;
							case 4:
								goto IL_AE;
							}
							goto IL_D2;
							IL_AE:
							switch (0)
							{
							case 0:
							{
								IL_D2:
								num2 = (short)2124869814;
								short num3 = num2;
								num2 = (short)1044050102;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AE;
								default:
									num2 = (short)278134784;
									if (num2 != 0)
									{
									}
									goto IL_152;
								}
								break;
							}
							}
							continue;
							IL_152:
							num2 = (short)63897602;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_1A4:
						return true;
					}
					finally
					{
						num2 = (short)729546754;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								enumerator.Dispose();
								num2 = (short)155058177;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								goto IL_20E;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1DA;
								}
								continue;
							}
							IL_1DA:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1389428736;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_20E:;
					}
					goto IL_211;
				case 2:
					if (trunkingGroupIDListInnerRecset == null)
					{
						num2 = (short)445120512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_211;
				}
				goto IL_1C;
				IL_211:
				enumerator = trunkingGroupIDListInnerRecset.GetEnumerator();
				num2 = (short)1645805569;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_93:
			num2 = (short)201588737;
			if (num2 != 0)
			{
			}
			return true;
			IL_1C:
			trunkingGroupIDListInnerRecset = (self.Parent[10505].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset);
			num2 = (short)1683292160;
			short num4 = num2;
			num2 = (short)414318594;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x009E47BC File Offset: 0x009E29BC
		public static bool conDataProfileTypeTrunkingAndRID(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (dataProfGeneralDataProfileType_A.Value == 4)
					{
						num2 = (short)1458241538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					num2 = (short)1040318464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_144;
				case 3:
					if (dataProfGeneralDataProfileType_A.Value != 1)
					{
						num2 = (short)1719926785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FF;
				}
				goto IL_20;
			}
			IL_FF:
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General general;
			return general.TrkSysLabtoolRxVoiceInterruptsData_A9043.Value;
			IL_144:
			goto IL_FF;
			IL_20:
			num2 = (short)1008992256;
			short num3 = num2;
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.General);
			dataProfGeneralDataProfileType_A = general.DataProfGeneralDataProfileType_A21320;
			num2 = (short)736837559;
			short num4 = num2;
			num2 = (short)1159413687;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)522059777;
				if (num2 != 0)
				{
				}
				num2 = (short)832897024;
				if (num2 != 0)
				{
				}
				num2 = (short)1676869635;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x009E4910 File Offset: 0x009E2B10
		internal static bool ConDataProfDataTypeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1869742080;
			short num2 = num;
			num = (short)1846935552;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B1;
				}
				bool flag2;
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI wifi;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem;
				bool flag5;
				bool flag6;
				for (;;)
				{
					IL_52:
					bool flag3;
					bool flag4;
					switch (num3)
					{
					case 0:
					{
						bool flag = index == 2;
						flag2 = (index == 1);
						if (flag)
						{
							num = (short)837025796;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)78381058;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						flag3 = false;
						goto IL_2BC;
					case 2:
						goto IL_1CC;
					case 3:
						goto IL_33A;
					case 4:
					{
						num = (short)1915352613;
						short num4 = num;
						num = (short)1755837989;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2043674624;
							if (num != 0)
							{
							}
							num = (short)285540364;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						if (value != 0)
						{
							num = (short)1930625035;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_380;
					case 6:
						num = (short)18415626;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						flag4 = false;
						goto IL_1CF;
					case 8:
						if (value != 3)
						{
							num = (short)337379347;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33A;
					case 9:
						num = (short)1772093448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						flag4 = wifi.DataWideWIFIEnable_42506Value;
						goto IL_1CF;
					case 11:
						num = (short)1640169487;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_143;
					case 13:
						if (externalDataModem.ModemConnectionType_43350.Value == 1)
						{
							num = (short)1328611334;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1664090119;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (externalDataModem.ModemConnectionType_43350.Value == 0)
						{
							num = (short)344784912;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)260112385;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (value == 1)
						{
							num = (short)456196113;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F9;
					case 16:
						num = (short)918814740;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_294;
					case 18:
						if (value == 4)
						{
							num = (short)99549187;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1748893701;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1165754386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						flag3 = (externalDataModem.DataWideExternalDataModemType_42843.Value != 0);
						goto IL_2BC;
					case 21:
						if (value != 2)
						{
							num = (short)605683721;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33A;
					}
					goto IL_B1;
					IL_1CF:
					flag5 = flag4;
					num = (short)571539456;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC:
					flag6 = flag3;
					num = (short)1417936909;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_33A:
					num = (short)1167261710;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_143:
				bool flag7 = flag5 || flag6;
				IL_165:
				return flag7 || flag2;
				IL_1CC:
				flag7 = false;
				goto IL_165;
				IL_294:
				IL_380:
				return index == 0;
				IL_3F9:
				num = (short)1689583617;
				if (num != 0)
				{
				}
				return false;
				IL_B1:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
				value = dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value;
				externalDataModem = dataProfiles.General.RefDataWide.ExternalDataModem;
				wifi = dataProfiles.General.RefDataWide.WIFI;
				num = (short)320929813;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_52;
			}
			}
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x009E4D40 File Offset: 0x009E2F40
		internal static void conSynLTEEnable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)362414080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE lte;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_5EB;
					case 1:
						if (lte.DataProfBroadbandSource_A42858.Value == 1)
						{
							num = (short)2093285379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 2:
						num = (short)1338114062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)674889735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(lte.DataProfLTEEnabled_A42075, false));
						num = (short)105971712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1502806026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!lte.DataProfLTEEnabled_A42075.Value)
						{
							num = (short)535298056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5EB;
					case 8:
						goto IL_3EF;
					case 9:
						if (flag != radioWide.LTE.RadWideLabtoolLTEUsed_A42064.Value)
						{
							num = (short)845676545;
							if (num != 0)
							{
							}
							num = (short)142934027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						if (lte.DataProfBroadbandSource_A42858.Value == 0)
						{
							num = (short)30212098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_635;
					case 11:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.LTE.RadWideLabtoolLTEUsed_A42064, flag));
						num = (short)1316356100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_5EB;
					case 13:
					{
						try
						{
							num = (short)1521090574;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 4)
									{
										num = (short)315424775;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1978925068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current;
									num = (short)311296013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_37C;
								case 3:
									goto IL_35F;
								case 4:
									goto IL_1DD;
								case 5:
									if (radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
									{
										num = (short)2032271371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.LTE.DataProfLTEEnabled_A42075.Value)
									{
										num = (short)2119106569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_13E;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 3)
									{
										goto IL_13E;
									}
									num = (short)1158141256;
									short num3 = num;
									num = (short)28824904;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1DD;
									default:
										num = (short)1128464384;
										if (num != 0)
										{
										}
										num = (short)534839306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									flag = true;
									num = (short)349962243;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)543490048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1149829126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)1259405314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 2)
									{
										num = (short)5439492;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_13E;
								}
								case 14:
									switch (0)
									{
									case 0:
										goto IL_139;
									}
									continue;
								}
								goto IL_139;
								IL_13E:
								num = (short)432472069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DD:
								num = (short)1071644680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_305:
								num = (short)1338048513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_139:
								goto IL_305;
							}
							IL_35F:
							IL_37C:
							goto IL_465;
						}
						finally
						{
							num = (short)1211826178;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)338296833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3EC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3B4;
									}
									continue;
								}
								IL_3B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)717225984;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EC:;
						}
						goto IL_3EF;
						IL_465:
						num = (short)462028800;
						short num4 = num;
						num = (short)1824784393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (lte.DataProfLTEEnabled_A42075.Value)
						{
							num = (short)337772549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_635;
					case 15:
						if (radioInformation.Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
						{
							num = (short)1187119110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_6F;
					IL_3EF:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(lte.DataProfLTEEnabled_A42075, true));
					num = (short)294912012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5EB:
					radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
					num = (short)2095185933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					num = (short)342360065;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6F:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				lte = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE);
				flag = false;
				num = (short)920518671;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x009E53E4 File Offset: 0x009E35E4
		internal static bool conSendDataDurEmerHangtimeIsVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField dataProfGeneralDataProfileType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).General.DataProfGeneralDataProfileType_A21320;
			short num;
			if (dataProfGeneralDataProfileType_A.Value != 1)
			{
				for (;;)
				{
					num = (short)1729363969;
					if (num != 0)
					{
					}
					num = (short)1558047595;
					short num2 = num;
					num = (short)2005920619;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_81;
					}
				}
				IL_81:
				num = (short)757858304;
				if (num != 0)
				{
				}
				return dataProfGeneralDataProfileType_A.Value == 4;
			}
			num = (short)831979520;
			short num3 = num;
			return true;
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x009E54BC File Offset: 0x009E36BC
		internal static bool conSendDataDurEmerHangtimeIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1720869638;
			short num2 = num;
			num = (short)718758662;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2112225280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)437780481;
			if (num != 0)
			{
			}
			num = (short)1688993792;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EnhancedData).DatProFeaturesPortListSelection_A42011.Value != 0;
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x009E5578 File Offset: 0x009E3778
		internal static bool conBackUpPTTTLSPortUnique(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)29556736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_10E;
				}
				int value;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset natlistInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset secureKMFProfileRecset;
					global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset enhancedDataPortListRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					switch (num2)
					{
					case 0:
						if (value != 161)
						{
							num = (short)1584332855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_638;
					case 2:
						if (dataWide.PortConfiguration.SensorMeasurementReportingUDPPort_A43022.Value == value)
						{
							num = (short)180682771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)101646383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)1105199104;
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
										goto IL_2D1;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListLANPort_A8385.Value != value)
									{
										num = (short)2074148871;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_30F;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner;
									if ((natlistInner[10068] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerSection).DataWideNATListWANPort_A9677.Value == value)
									{
										num = (short)1031340036;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1938882565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_30F;
								case 5:
									goto IL_404;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1684209667;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner natlistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)enumerator.Current;
									num = (short)1393819649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)103088130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_32B;
								}
								IL_2D3:
								num = (short)1231093766;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D1:
								goto IL_2D3;
								IL_30F:
								result = false;
								num = (short)219938824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32B:
							return result;
							IL_404:
							goto IL_1244;
						}
						finally
						{
							num = (short)1951268864;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_43C;
									}
									continue;
								case 1:
									goto IL_475;
								case 2:
									enumerator.Dispose();
									num = (short)118947841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_43C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1294008322;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_475:;
						}
						goto IL_478;
					case 4:
						if (value != 4005)
						{
							num = (short)1437401114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (natlistInnerRecset != null)
						{
							num = (short)1307574304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1244;
					case 6:
						if (secureKMFProfileRecset != null)
						{
							num = (short)1448804385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						try
						{
							num = (short)1060765700;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)512098307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles)enumerator.Current).Features.DatProFeaturesDestinationPort_A20544.Value == value)
									{
										num = (short)129433606;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1215954944;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1948319745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_78F;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_6CE;
									}
									continue;
								case 5:
									goto IL_772;
								case 6:
									result = false;
									num = (short)68419589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_71A:
								num = (short)1050214402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6CE:
								goto IL_71A;
							}
							IL_772:
							return result;
							IL_78F:
							goto IL_932;
						}
						finally
						{
							num = (short)143196160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_7C6;
									}
									continue;
								case 1:
									goto IL_801;
								case 2:
									enumerator.Dispose();
									num = (short)606011393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7C6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)464322562;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_801:;
						}
						goto IL_804;
					case 8:
						try
						{
							num = (short)1088290819;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = enhancedDataPortTableInnerRecset.GetEnumerator();
									num = (short)2044067846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset != null)
									{
										num = (short)1714421772;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList != null)
									{
										num = (short)2141519883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E6B;
									}
									continue;
								case 4:
									num = (short)1141047297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									if (enhancedDataPortList.EnhancedDataPortList42005 != null)
									{
										num = (short)1335828518;
										short num3 = num;
										num = (short)310321190;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_11D2;
										default:
											num = (short)98304000;
											if (num != 0)
											{
											}
											num = (short)1573388292;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								case 6:
									try
									{
										num = (short)626589700;
										num2 = (int)((global::System.IntPtr)num);
										bool result;
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if ((enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner).EnhancedDataPortTableInnerSection.DataWideEnhDataPortListPortNum_A42008.Value == value)
												{
													num = (short)2136408069;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)34603014;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1470824448;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_FBD;
											case 3:
												goto IL_102F;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_F69;
												}
												continue;
											case 5:
												result = false;
												num = (short)2112815106;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												num = (short)876019715;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_F6B:
											num = (short)340066305;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_F69:
											goto IL_F6B;
										}
										IL_FBD:
										return result;
										IL_102F:;
									}
									finally
									{
										num = (short)489684992;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_1064;
												}
												continue;
											case 1:
												goto IL_109E;
											case 2:
												enumerator2.Dispose();
												num = (short)1067319297;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_1064:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)277741570;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_109E:;
									}
									break;
								case 7:
									goto IL_11D2;
								case 8:
									num = (short)458489863;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)199098376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList;
									num = (short)1610874882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset;
									if (enhancedDataPortTableInnerRecset != null)
									{
										num = (short)771489792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									num = (short)879165445;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortList enhancedDataPortList;
									global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset enhancedDataPortTableInnerRecset = enhancedDataPortList.EnhancedDataPortList42005.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInnerRecset;
									num = (short)486932490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_10A1:
								num = (short)1138491401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6B:
								goto IL_10A1;
							}
							IL_11D2:
							goto IL_63D;
						}
						finally
						{
							num = (short)118489088;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1209;
									}
									continue;
								case 1:
									goto IL_1241;
								case 2:
									enumerator.Dispose();
									num = (short)451805185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1209:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1528889346;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1241:;
						}
						goto IL_1244;
					case 9:
						num = (short)828309521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (value != 162)
						{
							num = (short)1204158473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						enumerator = enhancedDataPortListRecset.GetEnumerator();
						num = (short)1127219208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)450166784;
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
										goto IL_B2D;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFUDPPort_A8384.Value == value)
									{
										num = (short)578617351;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)644349956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = (global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile)enumerator.Current;
									num = (short)1776287747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
									if (secureKMFProfile.DataTransport.SecKmfProfDataTransportSubscriberOTARPort_A9226.Value != value)
									{
										num = (short)173342728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B2F;
								}
								case 4:
									num = (short)206110725;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_C3F;
								case 6:
									goto IL_B47;
								case 7:
									goto IL_B2F;
								case 8:
									num = (short)67895297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B2D;
								IL_B2F:
								result = false;
								num = (short)1321861126;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B9F:
								num = (short)348585986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B2D:
								goto IL_B9F;
							}
							IL_B47:
							return result;
							IL_C3F:
							return true;
						}
						finally
						{
							num = (short)1088356352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C77;
									}
									continue;
								case 1:
									goto IL_CAE;
								case 2:
									enumerator.Dispose();
									num = (short)440991745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C77:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1428291586;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CAE:;
						}
						goto IL_CB1;
					case 13:
						num = (short)1538981903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (value != 4006)
						{
							num = (short)693436454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
					{
						num = (short)1480851456;
						short num4 = num;
						if (value != 4011)
						{
							num = (short)646447125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 16:
						num = (short)523894804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (value != 4000)
						{
							num = (short)1396178979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						num = (short)463536157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						return false;
					case 20:
						if (dataWide.PortConfiguration.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)1553727525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_853;
					case 21:
						num = (short)1524564022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (value != 4004)
						{
							num = (short)7209006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
						return false;
					case 24:
						if (value != 4002)
						{
							num = (short)1507852332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 25:
						num = (short)1001455658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)296484878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						enumerator = dataProfilesRecset.GetEnumerator();
						num = (short)696254471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (dataWide.PortConfiguration.DataWideWIFIOTAPTCPPort_42627.Value == value)
						{
							num = (short)558039070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1641086978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (value != 4050)
						{
							num = (short)91815961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 30:
						return false;
					case 31:
						if (dataWide.PortConfiguration.RefRadioWide.Location.RadWideLocP25LocationReporting_42412.Value)
						{
							num = (short)1200554036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_853;
					case 32:
						enumerator = natlistInnerRecset.GetEnumerator();
						num = (short)1051525123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_478;
					case 34:
						if (dataWide.PortConfiguration.DataWideP25LocationReportingUDPPort_42413.Value == value)
						{
							num = (short)306577424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_853;
					case 35:
						num = (short)1790836779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (dataWide.PortConfiguration.DataConfDataWidePortConAuthenticationUDPPort_A37608.Value == value)
						{
							num = (short)1073545261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_804;
					case 37:
						num = (short)1263796255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)64946216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (dataProfilesRecset != null)
						{
							num = (short)1579352065;
							if (num != 0)
							{
							}
							num = (short)724697115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_932;
					case 40:
						if (value != 4007)
						{
							num = (short)503054349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 41:
						goto IL_CB1;
					case 42:
						if (value == 49223)
						{
							num = (short)358875137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
						num = (short)1929904177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (value != 4001)
						{
							num = (short)822476841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 44:
						num = (short)1806303280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						return false;
					case 46:
						num = (short)1675362308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (dataWide.PortConfiguration.DataWideKVLKeyloadingUDPPort_43205.Value == value)
						{
							num = (short)2086076439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)619053090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (value != 4003)
						{
							num = (short)2079391797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 49:
						if (dataWide != null)
						{
							num = (short)1133772851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1244;
					case 50:
						if (enhancedDataPortListRecset != null)
						{
							num = (short)1946353675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63D;
					case 51:
						num = (short)23855140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						return false;
					case 53:
						num = (short)1335033878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (value != 4012)
						{
							num = (short)1866465298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 55:
						num = (short)1456668682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10E;
					IL_478:
					enumerator = secureKMFProfileRecset.GetEnumerator();
					num = (short)1610088460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63D:
					secureKMFProfileRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2055) as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfileRecset);
					num = (short)15204358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_804:
					num = (short)157351964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_853:
					natlistInnerRecset = (dataWide.NATList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset);
					num = (short)783745029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_932:
					enhancedDataPortListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4148) as global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortListRecset);
					num = (short)946602034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB1:
					num = (short)1547829272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1244:
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)2088501287;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_638:
				return false;
				IL_10E:
				value = (self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.LTE).DataProfLTEBackupPTTGatewayPort_A43618.Value;
				num = (short)1566769152;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x009E68BC File Offset: 0x009E4ABC
		internal static bool conBackupPTTHostnameValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)616038401;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							goto IL_ED;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						num = (short)1588854792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_66;
						}
						continue;
					case 2:
					{
						num = (short)458115615;
						short num3 = num;
						num = (short)208357919;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_ED;
						default:
							goto IL_1F9;
						}
						break;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						trunkingPersonality.Features.TrkPerFeatureBackupPTTOperation_A43628.CalculateValidity();
						num = (short)628359172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)2096037889;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles == self.Parent)
						{
							num = (short)682360835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)179175426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1894711301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1829175303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_CB:
					num = (short)665911296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66:
					goto IL_CB;
					IL_ED:
					num = (short)632160262;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F9:
				num = (short)684982272;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)715849730;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1456275457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_274;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_241;
						}
						continue;
					}
					IL_241:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1831600128;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_274:;
			}
			num = (short)974848000;
			short num4 = num;
			return true;
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x009E6B88 File Offset: 0x009E4D88
		private static bool a(global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide A_0)
		{
			short num = (short)405798912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)600788582;
					short num3 = num;
					num = (short)558124646;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)1799880704;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					break;
				}
				case 1:
					if (!A_0.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num = (short)634716164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					num = (short)199950337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_0.General.SecWideGeneralSecureOperation_A9067.Value == 3)
					{
						num = (short)822345730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_17A;
				case 5:
					num = (short)546504707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_89;
				IL_9F:
				num = (short)1036386309;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				if (A_0.General.SecWideGeneralSecureOperation_A9067.Value != 1)
				{
					goto IL_9F;
				}
				goto IL_17F;
			}
			return true;
			IL_17A:
			num = (short)1461583873;
			if (num != 0)
			{
			}
			return A_0.General.SecureWideDESAlgorithmEnable_43744.Value;
			IL_17F:
			num = (short)1919877120;
			short num4 = num;
			return true;
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x009E6D40 File Offset: 0x009E4F40
		internal static bool ConDataProfATAKFieldVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)926220288;
			short num2 = num;
			num = (short)45154305;
			if (num != 0)
			{
			}
			num = (short)2073176008;
			short num3 = num;
			num = (short)371861448;
			switch (num3 == num)
			{
			}
			num = (short)329908224;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.Features;
			bool flag = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolAtakHOption_HA00680;
			if (!flag)
			{
				features.DataProfFeaturesAtakField.Value = false;
			}
			return flag;
		}

		// Token: 0x0600AA1F RID: 43551 RVA: 0x009E6E2C File Offset: 0x009E502C
		internal static bool ConDataProfATAKFieldApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (dataProfiles.General.DataProfGeneralPacketDataMode_A8689.Value == 2)
						{
							num2 = (short)1743912962;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_124;
					case 1:
						num2 = (short)752484352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return true;
					case 3:
					{
						num2 = (short)835210227;
						short num3 = num2;
						num2 = (short)201214963;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1624440833;
							if (num2 != 0)
							{
							}
							num2 = (short)1774845952;
							if (num2 != 0)
							{
							}
							if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 0)
							{
								num2 = (short)305922049;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_124;
						}
						break;
					}
					}
					break;
				}
				IL_20:
				dataProfiles = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
				num2 = (short)298713091;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return true;
			IL_124:
			num2 = (short)1526988800;
			short num4 = num2;
			return false;
		}

		// Token: 0x0600AA20 RID: 43552 RVA: 0x009E6F88 File Offset: 0x009E5188
		internal static bool ConDataProfATAKDataEnableChannels(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)774635520;
			short num2 = num;
			num = (short)1093035548;
			short num3 = num;
			num = (short)1427662364;
			switch (num3 == num)
			{
			}
			num = (short)74842113;
			if (num != 0)
			{
			}
			num = (short)2033385472;
			if (num != 0)
			{
			}
			return !(self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).Features.DataProfFeaturesAtakField;
		}

		// Token: 0x0600AA21 RID: 43553 RVA: 0x009E7050 File Offset: 0x009E5250
		internal static bool ConDataProfATAKDataEnableChannelsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)684720128;
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
				bool flag;
				bool value;
				bool value2;
				bool value3;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)1964638214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag && value)
						{
							num = (short)1136001031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1126498308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return false;
					case 3:
					{
						num = (short)316158413;
						short num3 = num;
						num = (short)1034826189;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_130;
						default:
							num = (short)1071579137;
							if (num != 0)
							{
							}
							num = (short)883228672;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)1161494528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					case 4:
						goto IL_130;
					case 5:
						return false;
					case 6:
						if (!value2)
						{
							num = (short)1684733957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						return false;
					}
					goto IL_4F;
					IL_130:
					if (flag && value3)
					{
						num = (short)2057175040;
						short num4 = num;
						num = (short)233439234;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1008599043;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return false;
				IL_4F:
				global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
				value = dataProfiles.General.DataProfGeneralLimitedBroadcast_A8431.Value;
				value3 = dataProfiles.Features.DataProfFeaturesTerminalData_A9288.Value;
				value2 = dataProfiles.General.DataWideGeneralNATEnable_A38866.Value;
				flag = dataProfiles.Features.DataProfFeaturesAtakField;
				num = (short)947716097;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
