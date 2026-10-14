using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using Common;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioProfiles;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000124 RID: 292
	public static class RadioWideConstraints
	{
		// Token: 0x06002D8E RID: 11662 RVA: 0x002BC330 File Offset: 0x002BA530
		internal static bool ConLocEnIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)672171375;
			short num2 = num;
			num = (short)700351855;
			switch (num2 == num)
			{
			}
			num = (short)415432705;
			if (num != 0)
			{
			}
			num = (short)671612928;
			if (num != 0)
			{
			}
			num = (short)1543110656;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationLocationEnable_A8448.Value;
		}

		// Token: 0x06002D8F RID: 11663 RVA: 0x002BC3E8 File Offset: 0x002BA5E8
		internal static bool ConAlertToneInhIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)738805572;
			short num2 = num;
			num = (short)56313668;
			switch (num2 == num)
			{
			}
			num = (short)958857216;
			if (num != 0)
			{
			}
			num = (short)993656833;
			if (num != 0)
			{
			}
			num = (short)1966931968;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones).RadProfAlertTonesAlertTones_A7428.Value;
		}

		// Token: 0x06002D90 RID: 11664 RVA: 0x002BC4A4 File Offset: 0x002BA6A4
		internal static bool conAuxPttAudioSrcIsAuxTxAndAuxTxSnstvtyIs300mvOrAuxPttAudioSrcIsAuxMic(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			bool result;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions digitalAudioOptions;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_62;
				case 1:
					return result;
				case 2:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num2 = (short)1466368003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
				{
					num2 = (short)368956517;
					short num3 = num2;
					num2 = (short)1553519717;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_62;
					case 1:
						break;
					default:
					{
						num2 = (short)1911881728;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1639645185;
					if (num2 != 0)
					{
					}
					num2 = (short)1362886656;
					if (num2 != 0)
					{
					}
					num2 = (short)415563780;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (index == 0)
					{
						num2 = (short)1673265152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_62:
				result = (digitalAudioOptions.RadWideAdvancedAuxPTTAudioSource_A7529.Value != 1);
				num2 = (short)2016673793;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			digitalAudioOptions = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions);
			result = true;
			num2 = (short)150011906;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002D91 RID: 11665 RVA: 0x002BC614 File Offset: 0x002BA814
		internal static bool ConDependOnRadWideMultiRadSysAndRadWideHhchCapblAndRadWideRadioIdAliasEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2127672865;
			short num2 = num;
			num = (short)1385608737;
			switch (num2 == num)
			{
			}
			num = (short)2009989120;
			short num3 = num;
			num = (short)872480768;
			if (num != 0)
			{
			}
			num = (short)1463484417;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioAliasEnable_A8830.Value;
		}

		// Token: 0x06002D92 RID: 11666 RVA: 0x002BC6CC File Offset: 0x002BA8CC
		internal static bool conRadLockisEnAndSecOperIsDisOrSecOperIsADP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
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
						num2 = (short)327221249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (secWideGeneralSecureOperation_A.Value == 1)
						{
							num2 = (short)559874051;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 2:
					{
						num2 = (short)1160773632;
						short num3 = num2;
						num2 = (short)630884300;
						short num4 = num2;
						num2 = (short)1485604812;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
							num2 = (short)844693505;
							if (num2 != 0)
							{
							}
							num2 = (short)903938048;
							if (num2 != 0)
							{
							}
							if (userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value)
							{
								num2 = (short)668794880;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						}
						break;
					}
					case 3:
						goto IL_153;
					}
					goto IL_20;
				}
				return true;
				IL_153:
				return userInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
			}
			IL_20:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			secWideGeneralSecureOperation_A = userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			IL_38:
			num2 = (short)421265410;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002D93 RID: 11667 RVA: 0x002BC830 File Offset: 0x002BAA30
		internal static bool conSecHwForMobAndSecHwAndRadLockIsEnAndTacticalInhIsDisForPor(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
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
					{
						num2 = (short)1609760769;
						if (num2 != 0)
						{
						}
						num2 = (short)1357329820;
						short num3 = num2;
						num2 = (short)1257911708;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
							num2 = (short)234356736;
							if (num2 != 0)
							{
							}
							num2 = (short)318046209;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (secWideGeneralSecureOperation_A.Value == 1)
						{
							num2 = (short)962854915;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 2:
						if (userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value)
						{
							num2 = (short)1053229056;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 3:
						goto IL_159;
					}
					goto IL_20;
				}
				IL_159:
				num2 = (short)1801715712;
				short num4 = num2;
				return !userInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
			}
			}
			IL_20:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			secWideGeneralSecureOperation_A = userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			IL_38:
			num2 = (short)6225922;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x002BC99C File Offset: 0x002BAB9C
		internal static bool ConLocationEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)804525449;
			short num2 = num;
			num = (short)1096684937;
			switch (num2 == num)
			{
			}
			num = (short)1058471936;
			short num3 = num;
			num = (short)1155661825;
			if (num != 0)
			{
			}
			num = (short)378732544;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationLocationEnable_A8448.Value;
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x002BCA54 File Offset: 0x002BAC54
		internal static bool conReturnFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)581317580;
			short num2 = num;
			num = (short)1652306892;
			switch (num2 == num)
			{
			}
			num = (short)1114046464;
			short num3 = num;
			num = (short)1841364993;
			if (num != 0)
			{
			}
			num = (short)1692729344;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x002BCB00 File Offset: 0x002BAD00
		public static bool conTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndTxPwrLvlLoGrtrThanEqlToTxPwrLvlMin(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelLowW_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_13B;
				case 1:
					num2 = (short)1497759747;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
					{
						num2 = (short)1217003520;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
				{
					num2 = (short)1130364928;
					short num3 = num2;
					if (radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value)
					{
						num2 = (short)781451269;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 4:
				{
					num2 = (short)1530887272;
					short num4 = num2;
					num2 = (short)736918632;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F7;
					default:
						num2 = (short)2146631680;
						if (num2 != 0)
						{
						}
						if (!radWideTransmitPowerLevelsTxPowerLevelLowW_A.HiddenStatic)
						{
							num2 = (short)736493569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 5:
					goto IL_F7;
				}
				goto IL_28;
				IL_F7:
				num2 = (short)1437270018;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13B:
			return radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value;
			IL_28:
			txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
			radWideTransmitPowerLevelsTxPowerLevelLowW_A = txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;
			num2 = (short)1148583937;
			if (num2 != 0)
			{
			}
			num2 = (short)1328480260;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x002BCCC0 File Offset: 0x002BAEC0
		public static bool conTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTxPwrLvlHiLessThanEqlToTxPwrLvlMaxAndTxPwrLvlHiGrtrThanEqlToTxPwrLvlMin(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1580990464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A6;
				}
				global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelHighW_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolH37G50Smartnet_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolH38G51Smartzone_A;
				global::AcpBusinessLayer.AcpListField radWideTransmitPowerLevelsTxPowerLevelConfigType_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
						{
							num = (short)1883045911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						if (!radInfoLabtoolH37G50Smartnet_A.Value)
						{
							num = (short)1044381701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A9;
					case 2:
						if (!radInfoLabtoolH37G50Smartnet_A.Value)
						{
							num = (short)501809165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 3:
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value)
						{
							num = (short)1230962700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						num = (short)1048969227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)588382223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_2A9;
					case 7:
						num = (short)1538654208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)113573889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)1340407815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						goto IL_397;
					case 11:
						if (txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)732758037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						goto IL_553;
					case 13:
						num = (short)1310523418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)484048900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (radInfoLabtoolH38G51Smartzone_A.Value)
						{
							num = (short)755892230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A2;
					case 16:
						num = (short)1994653723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)673185801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 0)
						{
							num = (short)2052718592;
							short num3 = num;
							num = (short)1550909456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
						{
							num = (short)1730609181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 20:
					{
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value > txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
						{
							return false;
						}
						num = (short)351246571;
						short num4 = num;
						num = (short)275224811;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_553;
						default:
							num = (short)129105920;
							if (num != 0)
							{
							}
							num = (short)297730058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						num = (short)627179539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1346371604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_1DC;
					case 24:
						num = (short)282263554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1922039809;
						if (num != 0)
						{
						}
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 1)
						{
							num = (short)1216806920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A2;
					case 26:
						if (!radInfoLabtoolH38G51Smartzone_A.Value)
						{
							num = (short)2122121233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 27:
						if (txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)301334550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 28:
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 1)
						{
							num = (short)1994063896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 29:
						num = (short)1878261763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A6;
					IL_2A9:
					num = (short)1355087886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A2:
					num = (short)188743698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_558:
					num = (short)970915865;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1DC:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value;
				IL_397:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.Value;
				IL_553:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Value;
				IL_A6:
				txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
				radWideTransmitPowerLevelsTxPowerLevelHighW_A = txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				radWideTransmitPowerLevelsTxPowerLevelConfigType_A = radioWide.TransmitPowerLevels.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;
				radInfoLabtoolH37G50Smartnet_A = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184;
				radInfoLabtoolH38G51Smartzone_A = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185;
				num = (short)1186988060;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x002BD2E0 File Offset: 0x002BB4E0
		public static bool conReturnTrueIfViewSetToLabtool(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
			{
				short num = (short)1693666977;
				short num2 = num;
				num = (short)662589089;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1731526657;
					if (num != 0)
					{
					}
					num = (short)94044160;
					if (num != 0)
					{
					}
					num = (short)261488640;
					short num3 = num;
					break;
				}
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002D99 RID: 11673 RVA: 0x002BD39C File Offset: 0x002BB59C
		internal static bool ConIsSmartLowBatteryThreshold(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)129860810;
			short num2 = num;
			num = (short)220169418;
			switch (num2 == num)
			{
			}
			num = (short)516947968;
			short num3 = num;
			num = (short)249233409;
			if (num != 0)
			{
			}
			num = (short)1393164288;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).AlertTones.RadWideAdvancedSmartLowBatteryAlert_A9165.Value == 0;
		}

		// Token: 0x06002D9A RID: 11674 RVA: 0x002BD464 File Offset: 0x002BB664
		internal static bool ConIsEarlyWarningBatteryThreshold(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)509364514;
			short num2 = num;
			num = (short)2000505122;
			switch (num2 == num)
			{
			}
			num = (short)2141913088;
			short num3 = num;
			num = (short)1684340737;
			if (num != 0)
			{
			}
			num = (short)986906624;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).AlertTones.RadWideAdvancedSmartLowBatteryAlert_A9165.Value == 1;
		}

		// Token: 0x06002D9B RID: 11675 RVA: 0x002BD528 File Offset: 0x002BB728
		internal static void ConToSyncIgnitionSwitchToPosAInTrkAndCnv(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)767754240;
			switch (num)
			{
			default:
			{
				num = (short)2062614529;
				if (num != 0)
				{
				}
				num = (short)1258356736;
				short num2 = num;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).SwitchConventionalSwitchesPosition1_A12643;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
				try
				{
					num = (short)102694917;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1248329734;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DD;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1238761472;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)2145648644;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, switchConventionalSwitchesPosition1_A.Value));
							num = (short)431292417;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
							{
								num = (short)738656259;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_31B;
							}
							continue;
						case 6:
							goto IL_3FB;
						}
						IL_364:
						num = (short)1145634818;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_31B:
						goto IL_364;
					}
					IL_3DD:
					IL_3FB:
					goto IL_2CB;
				}
				finally
				{
					num = (short)1069219841;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1044447234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_432;
							}
							continue;
						case 2:
							goto IL_46B;
						}
						IL_432:
						if (enumerator == null)
						{
							break;
						}
						num = (short)399572992;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_46B:;
				}
				return;
				for (;;)
				{
					IL_2CB:
					enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
					try
					{
						num = (short)1425473541;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 0)
								{
									num = (short)1434714113;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, switchConventionalSwitchesPosition1_A.Value));
								num = (short)1842872322;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_197;
							case 3:
								num = (short)2112159750;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1613103107;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
								num = (short)554434560;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_11D;
								}
								continue;
							case 6:
								goto IL_20C;
							}
							IL_11F:
							num = (short)537657348;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_11D:
							goto IL_11F;
						}
						IL_197:
						IL_20C:
						break;
					}
					finally
					{
						num = (short)1300889601;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)779925292;
							short num4 = num;
							num = (short)101300012;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)793968640;
								if (num != 0)
								{
								}
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)660078594;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_28E;
									}
									continue;
								case 2:
									goto IL_2C8;
								}
								break;
							}
							IL_28E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)422641664;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_2C8:;
					}
				}
				return;
			}
			}
		}

		// Token: 0x06002D9C RID: 11676 RVA: 0x002BD9D8 File Offset: 0x002BBBD8
		public static bool ConUserSelectableLocationEnableIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1791229952;
			switch (num)
			{
			default:
			{
				num = (short)2142240793;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset embeddedRecset2;
					int num5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1543438337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1227816992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_421;
					case 2:
						return true;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						int num4;
						if ((embeddedRecset[num4][10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 106)
						{
							num = (short)495779857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)61276187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						int num4;
						if (num4 >= embeddedRecset.Count)
						{
							num = (short)278003725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2007760927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2BC;
					case 6:
						num = (short)1158610954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_143;
					case 8:
						goto IL_661;
					case 9:
						return true;
					case 10:
						if ((embeddedRecset2[num5][10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 106)
						{
							num = (short)2054160404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)73400325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1037455478;
						short num6 = num;
						num = (short)364204150;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_143;
						default:
							num = (short)405274624;
							if (num != 0)
							{
							}
							if (num5 >= embeddedRecset2.Count)
							{
								num = (short)1979056142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1178271772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						goto IL_3D4;
					case 13:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1055195160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.General).EmbeddedRecset;
						int num4 = 0;
						num = (short)510722067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_3D4;
					case 16:
						goto IL_2BC;
					case 17:
						goto IL_480;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						int num7;
						if (num7 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1811546138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)390332437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_279;
					case 20:
						goto IL_4FD;
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						int num7;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_LOC)
						{
							num = (short)155189250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7++;
						num = (short)269615112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)915406851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return true;
					case 24:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1388183559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 25:
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					case 26:
					{
						int num3 = 0;
						num = (short)1881341964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_279;
					case 28:
						if ((embeddedRecset2[num5][10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value != 106)
						{
							num = (short)2134048774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_148;
					case 29:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)1848508446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 30:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						int num7 = 0;
						num = (short)547749921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset;
						int num4;
						if ((embeddedRecset[num4][10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value != 106)
						{
							num = (short)2039742486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 32:
					{
						num = (short)2015035393;
						if (num != 0)
						{
						}
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_LOC)
						{
							num = (short)209846281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)1392967695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_661;
					}
					IL_CC:
					if (!(self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationUserSelectableLocationEnable_A9605.Value)
					{
						num = (short)847118359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					embeddedRecset2 = (global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.General).EmbeddedRecset;
					num5 = 0;
					num = (short)618528784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					num = (short)1691680797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_279:
					num = (short)723648516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC:
					num = (short)384303115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D4:
					num = (short)1364197376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_661:
					num = (short)1009385490;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_148:
				num = (short)426835968;
				short num8 = num;
				return true;
				IL_421:
				return false;
				IL_480:
				return true;
				IL_4FD:
				goto IL_148;
			}
			}
		}

		// Token: 0x06002D9D RID: 11677 RVA: 0x002BE0DC File Offset: 0x002BC2DC
		internal static bool ConRelayPatternRelay1Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1319436288;
			short num2 = num;
			num = (short)810942464;
			switch (num)
			{
			default:
			{
				num = (short)145424385;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)51970055;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1724645385;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)2023555072;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay1_A36506.Value == 1)
							{
								num = (short)1556938763;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay1_A36506.Value == 2)
							{
								num = (short)502005765;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C6;
						}
						case 4:
							goto IL_370;
						case 5:
							result2 = false;
							num = (short)1733296134;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_28A;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_127;
							}
							continue;
						case 8:
							num = (short)59375620;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (index == 1)
							{
								num = (short)813563917;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C6;
						case 10:
							goto IL_145;
						case 11:
							result2 = false;
							num = (short)50724874;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (index == 2)
							{
								num = (short)1144717327;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num = (short)54657027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (enumerator.MoveNext())
							{
								num = (short)1662522229;
								short num4 = num;
								num = (short)598872949;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)1094320128;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1256194049;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
							}
							num = (short)1944125448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)432406530;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_22C:
						num = (short)709492750;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_127:
						goto IL_22C;
						IL_2C6:
						num = (short)271908876;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_145:
					IL_28A:
					return result2;
					IL_370:
					return result;
				}
				finally
				{
					num = (short)1387462657;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)848232450;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3A8;
							}
							continue;
						case 2:
							goto IL_3DE;
						}
						IL_3A8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1144389632;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DE:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x002BE4E8 File Offset: 0x002BC6E8
		internal static bool ConRelayPatternRelay2Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)401604608;
			short num2 = num;
			num = (short)1876688896;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)787742727;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)384368649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)999555072;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay2_A36507.Value == 1)
							{
								num = (short)1550712843;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay2_A36507.Value == 2)
							{
								num = (short)1630535685;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						}
						case 4:
							goto IL_349;
						case 5:
							result2 = false;
							num = (short)102957062;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_265;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_103;
							}
							continue;
						case 8:
							num = (short)1464467460;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (index == 1)
							{
								num = (short)528547853;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A0;
						case 10:
							goto IL_122;
						case 11:
							result2 = false;
							num = (short)1448149002;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (index == 2)
							{
								num = (short)79888399;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num = (short)798556163;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (enumerator.MoveNext())
							{
								num = (short)641729854;
								short num4 = num;
								num = (short)21890366;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)1373634560;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1272578049;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
							}
							num = (short)772669448;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)901971970;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_208:
						num = (short)30343182;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_103:
						goto IL_208;
						IL_2A0:
						num = (short)1132134412;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_122:
					IL_265:
					return result2;
					IL_349:
					return result;
				}
				finally
				{
					num = (short)474284033;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)923664385;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1759707138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3A9;
							}
							continue;
						case 2:
							goto IL_3E0;
						}
						IL_3A9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)407306240;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3E0:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x002BE8F8 File Offset: 0x002BCAF8
		internal static bool ConRelayPatternRelay3Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1453457408;
			short num2 = num;
			num = (short)507052032;
			switch (num)
			{
			default:
			{
				num = (short)1206386689;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)35389447;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)797310985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)414973952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay3_A36508.Value == 1)
							{
								num = (short)1464336395;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay3_A36508.Value == 2)
							{
								num = (short)299368453;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						}
						case 4:
							goto IL_372;
						case 5:
							result2 = false;
							num = (short)320405510;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_28D;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_129;
							}
							continue;
						case 8:
							num = (short)1724055556;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (index == 1)
							{
								num = (short)452984845;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						case 10:
							goto IL_147;
						case 11:
							result2 = false;
							num = (short)1413808138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (index == 2)
							{
								num = (short)1186201615;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num = (short)1095958531;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (enumerator.MoveNext())
							{
								num = (short)566132149;
								short num4 = num;
								num = (short)551779765;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)1150877696;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1282342913;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
							}
							num = (short)1315766280;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)70713346;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_22E:
						num = (short)1636433934;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_129:
						goto IL_22E;
						IL_2C8:
						num = (short)1626734604;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_147:
					IL_28D:
					return result2;
					IL_372:
					return result;
				}
				finally
				{
					num = (short)1730150401;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)863961090;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3A9;
							}
							continue;
						case 2:
							goto IL_3DF;
						}
						IL_3A9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)560005120;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DF:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x002BED08 File Offset: 0x002BCF08
		internal static bool ConRelayPatternRelay4Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1031274496;
			short num2 = num;
			num = (short)2090926080;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1972830215;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)56164361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)761331712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay4_A36509.Value == 1)
							{
								num = (short)544669707;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay4_A36509.Value == 2)
							{
								num = (short)385286149;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29A;
						}
						case 4:
							goto IL_346;
						case 5:
							result2 = false;
							num = (short)1115095046;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_25F;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_100;
							}
							continue;
						case 8:
							num = (short)952762372;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (index == 1)
							{
								num = (short)623050765;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29A;
						case 10:
							goto IL_11D;
						case 11:
							result2 = false;
							num = (short)1733361674;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (index == 2)
							{
								num = (short)1124859919;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
							num = (short)796655619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (enumerator.MoveNext())
							{
								num = (short)1454404692;
								short num4 = num;
								num = (short)846034004;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)2089091072;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)694288385;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
							}
							num = (short)1774059528;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							num = (short)585564162;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_203:
						num = (short)287703054;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_100:
						goto IL_203;
						IL_29A:
						num = (short)1316683788;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_11D:
					IL_25F:
					return result2;
					IL_346:
					return result;
				}
				finally
				{
					num = (short)1695219713;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1504051202;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)792854529;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_3A6;
							}
							continue;
						case 2:
							goto IL_3DB;
						}
						IL_3A6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2047672320;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DB:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x002BF114 File Offset: 0x002BD314
		internal static bool ConRelayPatternRelay5Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)56426496;
			switch (num)
			{
			default:
			{
				num = (short)1002110976;
				short num2 = num;
				num = (short)2013528065;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)956891142;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_370;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2007826439;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)127926287;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay5_A36510.Value == 1)
							{
								num = (short)1596850181;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)1866661897;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay5_A36510.Value == 2)
							{
								num = (short)132186122;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						}
						case 5:
							result2 = false;
							num = (short)169213966;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_129;
							}
							continue;
						case 7:
							num = (short)1993736192;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)433717261;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)1940127748;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)1958215691;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_28A;
						case 12:
							num = (short)50790403;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2FF;
						case 14:
						{
							num = (short)2101733624;
							short num4 = num;
							num = (short)1039198456;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2FF;
							default:
								goto IL_17C;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)2070544396;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_22D:
						num = (short)1071644673;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_129:
						goto IL_22D;
						IL_2C8:
						num = (short)830275592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FF:
						num = (short)500301826;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17C:
					num = (short)128385024;
					if (num != 0)
					{
					}
					IL_28A:
					return result2;
					IL_370:
					return result;
				}
				finally
				{
					num = (short)956694530;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)12517377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3A9;
							}
							continue;
						}
						IL_3A9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1743519744;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DF:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA2 RID: 11682 RVA: 0x002BF524 File Offset: 0x002BD724
		internal static bool ConRelayPatternRelay6Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1351614464;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1018888193;
					if (num != 0)
					{
					}
					num = (short)675086342;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_371;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)431095815;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)2027552783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay6_A36511.Value == 1)
							{
								num = (short)2116222981;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)2001338377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C5;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay6_A36511.Value == 2)
							{
								num = (short)2069561354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C5;
						}
						case 5:
							result2 = false;
							num = (short)1019543566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_128;
							}
							continue;
						case 7:
							num = (short)689307648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)921108493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)826802180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)2017853451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_288;
						case 12:
							num = (short)1570832387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2FE;
						case 14:
						{
							num = (short)1260568045;
							short num3 = num;
							num = (short)1098825197;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2FE;
							default:
								goto IL_179;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)1148715020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_22C:
						num = (short)1910308865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_128:
						goto IL_22C;
						IL_2C5:
						num = (short)836829192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FE:
						num = (short)1223491586;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_179:
					num = (short)1068236800;
					if (num != 0)
					{
					}
					IL_288:
					return result2;
					IL_371:
					goto IL_70;
				}
				finally
				{
					num = (short)385875970;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2120155137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DE;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3A8;
							}
							continue;
						}
						IL_3A8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1820655616;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3DE:;
				}
				return result2;
				IL_70:
				num = (short)1964244992;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06002DA3 RID: 11683 RVA: 0x002BF930 File Offset: 0x002BDB30
		internal static bool ConRelayPatternRelay7Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1892352001;
			if (num != 0)
			{
			}
			num = (short)2135621632;
			short num2 = num;
			num = (short)523304960;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)1684078598;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_375;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)301858823;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)232194063;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay7_A36512.Value == 1)
							{
								num = (short)110559237;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)1700265993;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay7_A36512.Value == 2)
							{
								num = (short)1617821706;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C8;
						}
						case 5:
							result2 = false;
							num = (short)241041422;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_129;
							}
							continue;
						case 7:
							num = (short)1389297664;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)125829133;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)401408004;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)903872523;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_28C;
						case 12:
							num = (short)466747395;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_302;
						case 14:
						{
							num = (short)586917752;
							short num4 = num;
							num = (short)1584899960;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_302;
							default:
								goto IL_17A;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)2137391116;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_230:
						num = (short)469565441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_129:
						goto IL_230;
						IL_2C8:
						num = (short)1155399688;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_302:
						num = (short)1275789314;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17A:
					num = (short)1990590464;
					if (num != 0)
					{
					}
					IL_28C:
					return result2;
					IL_375:
					return result;
				}
				finally
				{
					num = (short)1665400834;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1252655105;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3E1;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3AC;
							}
							continue;
						}
						IL_3AC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)330432512;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3E1:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x002BFD40 File Offset: 0x002BDF40
		internal static bool ConRelayPatternRelay8Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)515833856;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)584974342;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_372;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1032519687;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)1941176335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay8_A36513.Value == 1)
							{
								num = (short)783876101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)1492451337;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29E;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay8_A36513.Value == 2)
							{
								num = (short)830144522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29E;
						}
						case 5:
							result2 = false;
							num = (short)2130182158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_101;
							}
							continue;
						case 7:
							num = (short)1433665536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)943390721;
								if (num != 0)
								{
								}
								num = (short)1643577357;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)944046084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)1882325003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_262;
						case 12:
							num = (short)355532803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2FD;
						case 14:
						{
							num = (short)468797379;
							short num3 = num;
							num = (short)800081859;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2FD;
							default:
								goto IL_154;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)1873936396;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_205:
						num = (short)286326785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_101:
						goto IL_205;
						IL_29E:
						num = (short)1877737480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FD:
						num = (short)74514434;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_154:
					num = (short)1931083776;
					if (num != 0)
					{
					}
					IL_262:
					return result2;
					IL_372:
					goto IL_6F;
				}
				finally
				{
					num = (short)1429995522;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)595918849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3E1;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3AB;
							}
							continue;
						}
						IL_3AB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1243545600;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3E1:;
				}
				return result2;
				IL_6F:
				num = (short)324861952;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x002C0150 File Offset: 0x002BE350
		internal static bool ConRelayPatternRelay9Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)369360897;
			if (num != 0)
			{
			}
			num = (short)705036288;
			short num2 = num;
			num = (short)523829248;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)850395142;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_373;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)994770951;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)1968177167;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay9_A36515.Value == 1)
							{
								num = (short)897384453;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)672661513;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CA;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay9_A36515.Value == 2)
							{
								num = (short)1136984074;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2CA;
						}
						case 5:
							result2 = false;
							num = (short)2057240590;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_128;
							}
							continue;
						case 7:
							num = (short)670498816;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)1810432013;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)82968580;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)1975648267;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_28B;
						case 12:
							num = (short)625541123;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_301;
						case 14:
						{
							num = (short)1191010602;
							short num4 = num;
							num = (short)1863934250;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_301;
							default:
								goto IL_17C;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)412549132;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_22E:
						num = (short)1475805185;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_128:
						goto IL_22E;
						IL_2CA:
						num = (short)775290888;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_301:
						num = (short)2026438658;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_17C:
					num = (short)1306263552;
					if (num != 0)
					{
					}
					IL_28B:
					return result2;
					IL_373:
					return result;
				}
				finally
				{
					num = (short)646774786;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1920073729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DF;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3AA;
							}
							continue;
						}
						IL_3AA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1701511168;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DF:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x002C0560 File Offset: 0x002BE760
		internal static bool ConRelayPatternRelay10Valid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1095106561;
			if (num != 0)
			{
			}
			num = (short)865140736;
			short num2 = num;
			num = (short)1816723456;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
				bool result = true;
				int index2 = self.Parent.Parent.IndexOf(self.Parent);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = generalLightbarPatternInnerRecset[index2];
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = generalLightbarPatternInnerRecset.GetEnumerator();
				bool result2;
				try
				{
					num = (short)252444678;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_36B;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)454295559;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)935985167;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay10_A36516.Value == 1)
							{
								num = (short)1355284485;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (index == 1)
							{
								num = (short)364118025;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C4;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10605] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection).RadWideGenLightBarPatternRelay10_A36516.Value == 2)
							{
								num = (short)1640431626;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2C4;
						}
						case 5:
							result2 = false;
							num = (short)986120206;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_128;
							}
							continue;
						case 7:
							num = (short)367984640;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (index == 2)
							{
								num = (short)1430323213;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 9:
							num = (short)138018820;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result2 = false;
							num = (short)663945227;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_287;
						case 12:
							num = (short)1699086339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_2FB;
						case 14:
						{
							num = (short)643293569;
							short num4 = num;
							num = (short)1332076929;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2FB;
							default:
								goto IL_179;
							}
							break;
						}
						case 15:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if (acpFeatureNode != acpFeatureNode2)
							{
								num = (short)1095237644;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_22B:
						num = (short)373882881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_128:
						goto IL_22B;
						IL_2C4:
						num = (short)1698234376;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FB:
						num = (short)1599864834;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_179:
					num = (short)742850560;
					if (num != 0)
					{
					}
					IL_287:
					return result2;
					IL_36B:
					return result;
				}
				finally
				{
					num = (short)972095490;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2036006913;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_3DA;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3A3;
							}
							continue;
						}
						IL_3A3:
						if (enumerator == null)
						{
							break;
						}
						num = (short)846725120;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3DA:;
				}
				return result2;
			}
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x002C0968 File Offset: 0x002BEB68
		internal static bool conRadLockisEnForPasswordRequired(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1974935432;
			short num2 = num;
			num = (short)186654600;
			switch (num2 == num)
			{
			default:
			{
				num = (short)474087424;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1356791809;
			if (num != 0)
			{
			}
			num = (short)1890648064;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioLock_A8836.Value;
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x002C0A20 File Offset: 0x002BEC20
		internal static bool conSetRadioLockPasswordValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpField<string> radWideUserInformationandPasswordsUnlockPassword_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1527447553;
					if (num2 != 0)
					{
					}
					if (radWideUserInformationandPasswordsUnlockPassword_A.Value.Length > userInformationAndPasswords.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value)
					{
						num2 = (short)1336737794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1558395470;
					short num3 = num2;
					num2 = (short)1751792206;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						goto IL_133;
					}
					break;
				}
				case 1:
					return true;
				case 2:
					return false;
				case 3:
					goto IL_6D;
				}
				goto IL_20;
				IL_6D:
				if (radWideUserInformationandPasswordsUnlockPassword_A.Value == null)
				{
					num2 = (short)1892352001;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)735903744;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return true;
			IL_133:
			num2 = (short)1798242304;
			if (num2 != 0)
			{
			}
			return true;
			IL_20:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			radWideUserInformationandPasswordsUnlockPassword_A = userInformationAndPasswords.RadWideUserInformationandPasswordsUnlockPassword_A8690;
			num2 = (short)1512833024;
			short num4 = num2;
			num2 = (short)911867907;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x002C0B78 File Offset: 0x002BED78
		internal static bool ConBluetoothEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)172868903;
			short num2 = num;
			num = (short)1065927975;
			switch (num2 == num)
			{
			}
			num = (short)1298530304;
			if (num != 0)
			{
			}
			num = (short)355860480;
			short num3 = num;
			num = (short)1674117121;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth).RadWideBluetoothBluetoothEnable_A37028.Value;
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x002C0C30 File Offset: 0x002BEE30
		internal static bool ConTxPowerLevelsByFrequencyRange(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)668205056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4FC;
				}
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				int num3;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				for (;;)
				{
					IL_29:
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					bool flag6;
					bool flag7;
					bool flag8;
					bool flag9;
					bool flag10;
					bool flag11;
					bool flag12;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_264B;
					case 1:
						goto IL_1C84;
					case 2:
						num = (short)394264857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17A5;
					case 4:
						flag2 = true;
						goto IL_1DFC;
					case 5:
						num = (short)2078146792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						flag2 = false;
						goto IL_1DFC;
					case 7:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)1397358664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA1;
					case 8:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1404698688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F74;
					case 9:
						goto IL_280D;
					case 10:
						flag3 = false;
						goto IL_2CB5;
					case 11:
						goto IL_B81;
					case 12:
						num = (short)674562114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)689176862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2068381959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)1678639241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2280;
					case 15:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)572260451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E53;
					case 16:
						switch (num3)
						{
						case 0:
							num = (short)1936261224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
							num = (short)1081147455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1320354063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1241252048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						case 12:
						case 13:
							num = (short)1685192824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						case 15:
						case 16:
						case 17:
							num = (short)1192362186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)810221685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 17:
						goto IL_27CB;
					case 18:
						num = (short)640155918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)25034759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1938489504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A5E;
					case 21:
						num = (short)1834483780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)405602490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26C8;
					case 23:
						flag4 = false;
						goto IL_23A0;
					case 24:
						num = (short)1255276739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						return result;
					case 26:
						num = (short)929693883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)870187214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1029505135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2013528109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_12E4;
					case 30:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1743913242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1389166592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						flag = false;
						goto IL_264B;
					case 32:
						num = (short)1054081166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						flag3 = true;
						goto IL_2CB5;
					case 34:
						num = (short)1087176926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)182517839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						flag5 = true;
						goto IL_F94;
					case 37:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1316487208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D56;
					case 38:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)147849289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EBD;
					case 39:
						goto IL_297B;
					case 40:
						num = (short)861077518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_E93;
					case 42:
						num = (short)307364045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (!txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value)
						{
							num = (short)1138557024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 44:
						flag3 = false;
						goto IL_2CB5;
					case 45:
						flag5 = false;
						goto IL_F94;
					case 46:
						num = (short)532938970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)866844759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						flag6 = true;
						goto IL_1FA0;
					case 49:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1956249652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)605618427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_2AF2;
					case 51:
						flag7 = radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
						goto IL_14B7;
					case 52:
						num = (short)1872101589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_254F;
					case 54:
						num = (short)614007012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						flag5 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_F94;
					case 56:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1266090107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_280D;
					case 57:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)1054998646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5E;
					case 58:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)476971196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)503382161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)1284047096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						flag7 = true;
						goto IL_14B7;
					case 61:
						num = (short)2103378136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						flag7 = false;
						goto IL_14B7;
					case 63:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)257294413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1326;
					case 64:
						num = (short)1816199441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						flag8 = true;
						goto IL_1B5B;
					case 66:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1593311347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F74;
					case 67:
						num = (short)1907228869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (!global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)681115831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD5;
					case 69:
						goto IL_6A3;
					case 70:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1423769887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F4;
					case 71:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)1121583275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26C8;
					case 72:
						num = (short)1149501569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)928972808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)1321992285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F8;
					case 75:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)2094989362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5E;
					case 76:
						num = (short)200212782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						num = (short)191496496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_2729;
					case 79:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1809383628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1744;
					case 80:
						num = (short)846069862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						flag9 = false;
						goto IL_1AB2;
					case 82:
						flag = true;
						goto IL_264B;
					case 83:
						num = (short)645136575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						flag10 = true;
						goto IL_1577;
					case 85:
						num = (short)1123483891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)590413853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9F8;
					case 87:
						if (!radInfoFrequencyRangesUHF1UsedinCodeplug_A)
						{
							num = (short)1328021507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF1;
					case 88:
						return result;
					case 89:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)1405681795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F54;
					case 90:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)216727729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 91:
						num = (short)1135345833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						return result;
					case 93:
						num = (short)1529217173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						num = (short)893452343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						num = (short)1981088035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						goto IL_278B;
					case 97:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)117702763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E5E;
					case 98:
						flag7 = false;
						goto IL_14B7;
					case 99:
						num = (short)1106968749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						flag10 = true;
						goto IL_1577;
					case 101:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)272957716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)503316585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)75563008;
							short num4 = num;
							num = (short)1682178353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_892;
					case 103:
						flag11 = true;
						goto IL_2BB9;
					case 104:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1687093333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297B;
					case 105:
						flag6 = false;
						goto IL_1FA0;
					case 106:
						num = (short)1681260800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_D2C;
					case 108:
						num = (short)221642959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num = (short)1014694070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1758134567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD5;
					case 111:
						num = (short)13893706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						flag5 = true;
						goto IL_F94;
					case 113:
						num = (short)763035915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)1351024796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_892;
					case 115:
						goto IL_1EBD;
					case 116:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)1720057857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F82;
					case 117:
						num = (short)1605894284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						num = (short)383910040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						num = (short)978321687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1822097578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 121:
						goto IL_E53;
					case 122:
						num = (short)1706491994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)940900524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)344916014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E93;
					case 125:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2086011173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C45;
					case 126:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)553189435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1388511263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						return result;
					case 128:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)481820683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F54;
					case 129:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1072365651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_932;
					case 130:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)820904115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C84;
					case 131:
						num = (short)1653342209;
						if (num != 0)
						{
						}
						num = (short)451805330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						flag9 = true;
						goto IL_1AB2;
					case 133:
						num = (short)533856501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)851574964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1475936366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)2088632453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278B;
					case 136:
						return result;
					case 137:
						goto IL_2D56;
					case 138:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)630915166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1641808062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						num = (short)1061224736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						return result;
					case 141:
						if (!global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)990511125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CD5;
					case 142:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1844117742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278B;
					case 143:
						flag12 = true;
						goto IL_276B;
					case 144:
						num = (short)379846922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						flag12 = false;
						goto IL_276B;
					case 146:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1148256280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198F;
					case 147:
						num = (short)1660092619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1101725935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20FA;
					case 149:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1484521744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E4;
					case 150:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)1496973390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE5;
					case 151:
						flag7 = true;
						goto IL_14B7;
					case 152:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)545194176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF2;
					case 153:
						num = (short)1854210241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						goto IL_7F4;
					case 155:
						return result;
					case 156:
						goto IL_1C45;
					case 157:
						goto IL_932;
					case 158:
						num = (short)1374748906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)895680656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27CB;
					case 160:
						num = (short)2067398678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)1016004827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26C8;
					case 162:
						num = (short)721682582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
						flag10 = true;
						goto IL_1577;
					case 164:
						num = (short)1534656660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						flag3 = true;
						goto IL_2CB5;
					case 166:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1145372830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)781189357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						flag12 = radInfoFrequencyRangesVHFUsedinCodeplug_A;
						goto IL_276B;
					case 168:
						num = (short)133628100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)2133721197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9D;
					case 170:
						num = (short)1454506225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						goto IL_1CE4;
					case 172:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)1035206665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_295D;
					case 173:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1226768505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_834;
					case 174:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2004680751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A5;
					case 175:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1243611155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1104806185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						num = (short)739049543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						goto IL_13A6;
					case 178:
						num = (short)1569652897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						num = (short)1877016692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
						num = (short)1167130640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1022427312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CE4;
					case 182:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1310326890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_254F;
					case 183:
					{
						num = (short)1473035918;
						short num5 = num;
						num = (short)712621710;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1F45;
						default:
							num = (short)1316093952;
							if (num != 0)
							{
							}
							num = (short)725221635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 184:
						num = (short)329908423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						return result;
					case 186:
						goto IL_2A5E;
					case 187:
						flag4 = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
						goto IL_23A0;
					case 188:
						num = (short)424411303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
						return result;
					case 190:
						flag5 = false;
						goto IL_F94;
					case 191:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)31981725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA1;
					case 192:
						num = (short)129368139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						flag2 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1DFC;
					case 194:
						goto IL_2D15;
					case 195:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)651755812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F54;
					case 196:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)1414922359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)12320868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)144310274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 198:
						flag11 = true;
						goto IL_2BB9;
					case 199:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)1881735420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_295D;
					case 200:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)51970292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B81;
					case 201:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)12058715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1392443628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 202:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1617035426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2729;
					case 203:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)585892034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E60;
					case 204:
						num = (short)1845952739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)644612260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20FA;
					case 206:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)997785855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF1;
					case 207:
						flag9 = radInfoFrequencyRangesVHFUsedinCodeplug_A;
						goto IL_1AB2;
					case 208:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1597308955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17A5;
					case 209:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1985478924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21F9;
					case 210:
						num = (short)1169686789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						return result;
					case 212:
						num = (short)2033254528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1440678066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26C8;
					case 214:
						flag2 = true;
						goto IL_1DFC;
					case 215:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)171638938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE5;
					case 216:
						if (!txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value)
						{
							num = (short)149291049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2198;
					case 217:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1547501846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2C;
					case 218:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)2006057036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2198;
					case 219:
						num = (short)56754357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 220:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)1918501114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F54;
					case 221:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1629028594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1757348141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 222:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)261554436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_834;
					case 223:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1267007530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)625737790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)753795302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2280;
					case 225:
						flag8 = radInfoFrequencyRangesUHF1UsedinCodeplug_A;
						goto IL_1B5B;
					case 226:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1380712694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF2;
					case 227:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1012990120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1983250665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 228:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)522584274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1447559178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							goto IL_1F45;
						}
						goto IL_2D15;
					case 230:
						num = (short)985268261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)518783071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1432354914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 232:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)98631955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1241;
					case 233:
						flag10 = false;
						goto IL_1577;
					case 234:
						flag11 = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
						goto IL_2BB9;
					case 235:
						if (!global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)17891450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13A6;
					case 236:
						flag6 = false;
						goto IL_1FA0;
					case 237:
						flag11 = false;
						goto IL_2BB9;
					case 238:
						num = (short)1661468715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 239:
						num = (short)1641873617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
						return result;
					case 241:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)1084293187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9C;
					case 242:
						num = (short)358285586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 243:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)1386676263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F54;
					case 244:
						num = (short)1577255132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 245:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)1930952736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 246:
						num = (short)144113721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 247:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)43974914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20FA;
					case 248:
						flag = radInfoFrequencyRangesUHF2UsedinCodeplug_A;
						goto IL_264B;
					case 249:
						flag = true;
						goto IL_264B;
					case 250:
						num = (short)1869086809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
						flag8 = false;
						goto IL_1B5B;
					case 252:
						goto IL_29FC;
					case 253:
						return result;
					case 254:
						num = (short)794755362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 255:
						num = (short)609222830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 256:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1574502453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E9D;
					case 257:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)290062444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)765591633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 258:
						goto IL_21F9;
					case 259:
						switch (num3)
						{
						case 0:
							num = (short)460652761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)992608485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)587202598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)810090620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1465581703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1205010697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)31195419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 260:
						num = (short)1026293775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 261:
						flag3 = radInfoFrequencyRanges900MHzUsedinCodeplug_A;
						goto IL_2CB5;
					case 262:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1572995098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)818413591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 263:
						flag8 = false;
						goto IL_1B5B;
					case 264:
						flag7 = true;
						goto IL_14B7;
					case 265:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)704446544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101A;
					case 266:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)2123038737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F82;
					case 267:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)920125445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1326;
					case 268:
						num = (short)2075197687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 269:
						flag8 = true;
						goto IL_1B5B;
					case 270:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1271791763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D15;
					case 271:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1971060770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E53;
					case 272:
						num = (short)1931411542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 273:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)857669644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EBD;
					case 274:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)1402339363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1744;
					case 275:
						goto IL_1326;
					case 276:
						num = (short)738853158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 277:
						return result;
					case 278:
						num = (short)1721237601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 279:
						flag10 = radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
						goto IL_1577;
					case 280:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)230228107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1705902124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						if (!radInfoFrequencyRangesUHF2UsedinCodeplug_A)
						{
							num = (short)1144782917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A9C;
					case 282:
						num = (short)176292064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						num = (short)1906245916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 284:
						return result;
					case 285:
						flag4 = true;
						goto IL_23A0;
					case 286:
						num = (short)563282145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 287:
						num = (short)2064777431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 288:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)2009661494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)688980133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 289:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)29163673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1133772806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 290:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)95682578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E60;
					case 291:
						if (!radInfoFrequencyRanges7800MHzUsedinCodeplug_A)
						{
							num = (short)503382315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)224329788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 292:
						goto IL_198F;
					case 293:
						num = (short)1598029938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 294:
						flag6 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1FA0;
					case 295:
						num = (short)1420558477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
						flag4 = true;
						goto IL_23A0;
					case 297:
						flag2 = false;
						goto IL_1DFC;
					case 298:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1580269752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29FC;
					case 299:
						num = (short)1535246387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 300:
						return result;
					case 301:
						flag10 = false;
						goto IL_1577;
					case 302:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1578958909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E93;
					case 303:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1306722516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B81;
					case 304:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)1863647345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1241;
					case 305:
						goto IL_101A;
					case 306:
						flag6 = true;
						goto IL_1FA0;
					}
					goto IL_4FC;
					IL_6A3:
					num = (short)70516766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F4:
					num = (short)964034840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_834:
					num = (short)805437488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_892:
					num = (short)1013383331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_932:
					num = (short)1001849121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F8:
					num = (short)1555038244;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9C:
					num = (short)175898706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B81:
					num = (short)798359610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2C:
					num = (short)1587478754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E53:
					num = (short)431947977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E93:
					num = (short)415563935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF1:
					num = (short)1455554625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F54:
					num = (short)143130767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F74:
					num = (short)435028232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F94:
					result = flag5;
					num = (short)1659699453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101A:
					num = (short)711983229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1241:
					num = (short)1910505686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E4:
					num = (short)352780426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1326:
					num = (short)1634402479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13A6:
					result = true;
					num = (short)586416368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B7:
					result = flag7;
					num = (short)422510684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1577:
					result = flag10;
					num = (short)1847722173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1744:
					num = (short)1737031764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17A5:
					num = (short)129302577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_198F:
					num = (short)2034827567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB2:
					result = flag9;
					num = (short)1436221625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B5B:
					result = flag8;
					num = (short)831389823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BE5:
					num = (short)556597281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C45:
					num = (short)649855197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C84:
					num = (short)1558380710;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CE4:
					num = (short)2081423380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DFC:
					result = flag2;
					num = (short)63242451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5E:
					num = (short)1751974020;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EBD:
					num = (short)1481572575;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F45:
					num = (short)330498302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F82:
					num = (short)1733427398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FA0:
					result = flag6;
					num = (short)1110966549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20FA:
					num = (short)1109328023;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2198:
					num = (short)1333526631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21F9:
					num = (short)62456039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2280:
					num = (short)1631322361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A0:
					result = flag4;
					num = (short)273481883;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_254F:
					num = (short)1207238757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_264B:
					result = flag;
					num = (short)1416036377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26C8:
					num = (short)1870135565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2729:
					num = (short)1178271814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_276B:
					result = flag12;
					num = (short)623771948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_278B:
					num = (short)554303786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27CB:
					num = (short)194379906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280D:
					num = (short)767492358;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_295D:
					num = (short)1597243688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_297B:
					num = (short)2023358664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29FC:
					num = (short)542638136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A3F:
					num = (short)1888682269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A5E:
					num = (short)2016739341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA1:
					num = (short)561446916;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AF2:
					num = (short)431554817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BB9:
					result = flag11;
					num = (short)552730760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CB5:
					result = flag3;
					num = (short)789577816;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CD5:
					num = (short)165675243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D15:
					num = (short)1429143580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D56:
					num = (short)2052784254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E60:
					num = (short)250151024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E9D:
					num = (short)711393586;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_4FC:
				txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
				radInfoGeneralPrimaryFrequencyBandVHF_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				radInfoLabtoolPrimaryBands_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoLabtoolDualBandEnable_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRanges8900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				result = false;
				num = (short)356057222;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x002C3AFC File Offset: 0x002C1CFC
		public static bool conDigAnalogBalNoAGCChannelEnabled(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)276299776;
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
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)548405255;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1097662478;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles = (global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles)enumerator.Current;
									num = (short)1332346895;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_37E;
								case 2:
									goto IL_25E;
								case 3:
									goto IL_31A;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsDigitalAGC1_A7854.Value)
									{
										num = (short)1462566921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_148;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsDigitalAGC1_A7854.HiddenStatic)
									{
										num = (short)1777008648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25E;
								}
								case 6:
									goto IL_279;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_146;
									}
									continue;
								case 8:
									goto IL_148;
								case 9:
									num = (short)1892483077;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)314245124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (!radioProfiles.AudioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
									{
										num = (short)1915355146;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25E;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsDigitalAGC2_A7853.Value)
									{
										num = (short)309264386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)1785004048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)374013953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsAnalogAGC1_A7440.Value)
									{
										num = (short)514850829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_31A;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles radioProfiles;
									if (radioProfiles.AudioSettings.RadProfAudioSettingsAnalogAGC1_A7440.HiddenStatic)
									{
										num = (short)1006239747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_25E;
								}
								}
								goto IL_146;
								IL_148:
								num = (short)1177223180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18D:
								num = (short)1255276544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_146:
								goto IL_18D;
								IL_25E:
								result = false;
								num = (short)1062273030;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_31A:
								num = (short)876347403;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_279:
							return result;
							IL_37E:
							return true;
						}
						finally
						{
							num = (short)1632239616;
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
										goto IL_3B5;
									}
									continue;
								case 1:
									goto IL_3EB;
								case 2:
									enumerator.Dispose();
									num = (short)1934163969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3B5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1292763138;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3EB:;
						}
						goto IL_3EE;
					case 1:
						goto IL_3EE;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						if (radioProfilesRecset != null)
						{
							num = (short)871301121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = radioProfilesRecset.GetEnumerator();
						num = (short)1357447168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (index == 1)
						{
							num = (short)52887552;
							short num3 = num;
							num = (short)1332609025;
							if (num != 0)
							{
							}
							num = (short)996016131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_43;
					IL_3EE:
					num = (short)969277444;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_43:
				num = (short)362931691;
				short num4 = num;
				num = (short)889841131;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					bool result;
					return result;
				}
				default:
				{
					num = (short)1947533312;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset radioProfilesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2077) as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset;
					num = (short)406585346;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x002C3FC4 File Offset: 0x002C21C4
		internal static bool ConIsIgnitionAutoPowerOffApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_149;
				case 1:
					if (switchConventionalSwitchesPosition1_A.Value != 129)
					{
						goto IL_78;
					}
					return true;
				case 2:
					if (switchConventionalSwitchesPosition1_A.Value != 104)
					{
						num2 = (short)676855808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
				{
					num2 = (short)240779265;
					if (num2 != 0)
					{
					}
					num2 = (short)1435580225;
					short num3 = num2;
					num2 = (short)1528706881;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_78;
					default:
						num2 = (short)675938304;
						if (num2 != 0)
						{
						}
						num2 = (short)1614086146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_78:
				num2 = (short)103546883;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_149:
			return switchConventionalSwitchesPosition1_A.Value == 45;
			IL_20:
			switchConventionalSwitchesPosition1_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).SwitchConventionalSwitchesPosition1_A12643;
			num2 = (short)1209335808;
			short num4 = num2;
			num2 = (short)1881473025;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x002C4120 File Offset: 0x002C2320
		internal static bool ConIsIgnitionAutoPowerOffEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1110441985;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_156;
				case 1:
					num = (short)806223873;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 2:
					num = (short)384499717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)925630468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (switchConventionalSwitchesPosition1_A.Value != 129)
					{
						num = (short)1700528130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					if (switchConventionalSwitchesPosition1_A.Value != 104)
					{
						num = (short)1703739392;
						short num3 = num;
						num = (short)348454912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_65:
				num = (short)237906824;
				short num4 = num;
				num = (short)872491912;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
				{
					num = (short)516292608;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
					switchConventionalSwitchesPosition1_A = features.SwitchConventionalSwitchesPosition1_A12643;
					if (features.RadWideFeaturesIgnitionAutoPoweroff_A38014.Value == 0)
					{
						return false;
					}
					num = (short)774242307;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_156:
			return switchConventionalSwitchesPosition1_A.Value == 45;
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x002C42C8 File Offset: 0x002C24C8
		public static bool ConSoftIDUsernameTextSizeValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)781582336;
				switch (num)
				{
				default:
				{
					num = (short)1936195585;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						string text2;
						string id_PASSWORD_CHAR;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						switch (num2)
						{
						case 0:
							num = (short)79757320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 2:
							goto IL_10C;
						case 3:
							num = (short)292290561;
							if (num != 0)
							{
							}
							num = (short)7208975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_2A4;
						case 5:
						{
							string text;
							if (num3 >= text.Length)
							{
								num = (short)193200141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							char c = text[num3];
							num = (short)652279828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (text2 != null)
							{
								num = (short)251133961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 7:
						{
							char c;
							if ('A' <= c)
							{
								num = (short)571539466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CE;
						}
						case 8:
						{
							char c;
							if ('a' <= c)
							{
								num = (short)287178755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_10C;
						}
						case 9:
							num = (short)292421653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1798766608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)320864268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							char c;
							if (c > '9')
							{
								num = (short)48758806;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34F;
						}
						case 13:
							goto IL_2E3;
						case 14:
							return true;
						case 15:
						{
							char c;
							if (c > 'z')
							{
								num = (short)194314242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34F;
						}
						case 16:
						{
							char c;
							if (c > 'Z')
							{
								num = (short)507052055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34F;
						}
						case 17:
							goto IL_2A4;
						case 18:
							goto IL_1D8;
						case 19:
						{
							char c;
							if ('0' <= c)
							{
								num = (short)1428946955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						case 20:
						{
							char c;
							if (!id_PASSWORD_CHAR.Contains(c.ToString()))
							{
								num = (short)403570688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34F;
						}
						case 21:
						{
							if (text2.Length <= userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.Value)
							{
								string text = text2;
								num3 = 0;
								num = (short)1991507985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1911261746;
							short num4 = num;
							num = (short)1115720242;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)682688512;
								if (num != 0)
								{
								}
								num = (short)1340866578;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 22:
							goto IL_3A9;
						case 23:
							goto IL_CE;
						}
						IL_A6:
						if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
						{
							num = (short)683737102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
						id_PASSWORD_CHAR = global::CommonResources.AppResources.ID_PASSWORD_CHAR;
						text2 = userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsername_A9169.Value.TrimEnd(global::System.Array.Empty<char>());
						num = (short)1662517254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CE:
						num = (short)812515347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_10C:
						num = (short)669908999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2A4:
						num = (short)1278148613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34F:
						num3++;
						num = (short)1222967300;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			return true;
			IL_1D8:
			num = (short)424214528;
			short num5 = num;
			return false;
			IL_2E3:
			return true;
			IL_3A9:
			return false;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x002C4738 File Offset: 0x002C2938
		public static bool ConAdvancedKeyTypeIsASK(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)431772171;
			short num2 = num;
			num = (short)993350155;
			switch (num2 == num)
			{
			}
			num = (short)1808334849;
			if (num != 0)
			{
			}
			num = (short)2137128960;
			if (num != 0)
			{
			}
			num = (short)972554240;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General).RadWideGeneralOwnerAdvancedKeyType_A38663.Value == 0;
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x002C47F0 File Offset: 0x002C29F0
		internal static bool ConAdvancedKeyTypeIsAWK(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)977917798;
			short num2 = num;
			num = (short)1299699558;
			switch (num2 == num)
			{
			}
			num = (short)1735852033;
			if (num != 0)
			{
			}
			num = (short)1284636672;
			if (num != 0)
			{
			}
			num = (short)1072627712;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.General).RadWideGeneralOwnerAdvancedKeyType_A38663.Value == 1;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x002C48B0 File Offset: 0x002C2AB0
		public static bool ConValidateBluetoothDropTimer(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)755171328;
			short num2 = num;
			int num3;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_32:
					switch (num3)
					{
					case 0:
						if (index != 64)
						{
							num = (short)955973635;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 1:
						return result;
					case 2:
						if (index != 32)
						{
							num = (short)116523012;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7;
					case 3:
					{
						num = (short)740151253;
						short num4 = num;
						num = (short)763940821;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_85;
						default:
							num = (short)953614336;
							if (num != 0)
							{
							}
							num = (short)1077739526;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1922433024;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_B7;
					case 6:
						if (index == 128)
						{
							num = (short)912785413;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_54;
					IL_B7:
					result = (bluetooth.RadWideBluetoothBluetoothReconnectTimer_A37037.Value == 255);
					num = (short)1793523713;
					num3 = (int)((global::System.IntPtr)num);
				}
				return result;
			}
			IL_54:
			num = (short)1233977345;
			if (num != 0)
			{
			}
			bluetooth = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth);
			result = true;
			IL_85:
			num = (short)1266548738;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x002C4A68 File Offset: 0x002C2C68
		public static bool conConvTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndConvTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndConvTxPwrLvlLoGrtrThanEqlToConvTxPwrLvlMin(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsConvTxPowerLevelLowW_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_164;
				case 1:
					if (!radWideTransmitPowerLevelsConvTxPowerLevelLowW_A.HiddenStatic)
					{
						num2 = (short)1539178499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					num2 = (short)1914699781;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_169;
				case 4:
					if (radWideTransmitPowerLevelsConvTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value)
					{
						num2 = (short)207290370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
				{
					num2 = (short)1157395369;
					short num3 = num2;
					num2 = (short)10974121;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
					{
						num2 = (short)301924352;
						if (num2 != 0)
						{
						}
						num2 = (short)1352204289;
						if (num2 != 0)
						{
						}
						num2 = (short)1840775168;
						short num4 = num2;
						if (radWideTransmitPowerLevelsConvTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
						{
							num2 = (short)5570560;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				}
				goto IL_28;
				IL_169:
				num2 = (short)83558404;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_164:
			return radWideTransmitPowerLevelsConvTxPowerLevelLowW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.Value;
			IL_28:
			txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
			radWideTransmitPowerLevelsConvTxPowerLevelLowW_A = txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;
			num2 = (short)1979711489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x002C4C28 File Offset: 0x002C2E28
		public static bool conTrkTxPwrLvlLoLessThanEqlToTxPwrLvlHiAndTrkTxPwrLvlLoLessThanEqlToTxPwrLvlMaxAndTrkTxPwrLvlLoGrtrThanEqlToTrkTxPwrLvlMin(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)626499888;
			short num2 = num;
			num = (short)808624432;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_167:
				num = (short)952500228;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1640890368;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				break;
			}
			global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					if (radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.Value)
					{
						num = (short)1310064643;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_154;
				case 2:
					if (!radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A.HiddenStatic)
					{
						num = (short)1790050309;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_13B;
				case 4:
				{
					num = (short)599851008;
					short num4 = num;
					num = (short)1268252672;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)3866625;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_73;
			}
			IL_13B:
			return radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A.Value >= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.Value;
			IL_154:
			if (radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.Value)
			{
				goto IL_167;
			}
			return false;
			IL_73:
			num = (short)1997930497;
			if (num != 0)
			{
			}
			txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
			radWideTransmitPowerLevelsTrkTxPowerLevelLowW_A = txPowerLevelsByFrequencyRangeInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;
			num = (short)1362558978;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06002DB4 RID: 11700 RVA: 0x002C4DE8 File Offset: 0x002C2FE8
		public static void conPINPasswordValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)247070720;
			short num2 = num;
			num = (short)516668859;
			short num3 = num;
			num = (short)1801108923;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_107:
				num = (short)54984708;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2026766336;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				break;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
			for (;;)
			{
				IL_80:
				string text;
				string text2;
				switch (num4)
				{
				case 0:
					if (text != null)
					{
						num = (short)702218241;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)595001350;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_181;
				case 2:
					return;
				case 3:
					if (userInformationAndPasswords != null)
					{
						num = (short)716046341;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)160759809;
					if (num != 0)
					{
					}
					text2 = text;
					goto IL_183;
				case 5:
					text = userInformationAndPasswords.RadWideUserInformationandPINPassword_41303Value;
					num = (short)1584594944;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					text2 = "";
					goto IL_183;
				}
				goto IL_A2;
				IL_183:
				text = text2;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(labtool.RadWideLabtoolEncryptedPINPassword_A41702, text));
				num = (short)207880194;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_181:
			goto IL_107;
			IL_A2:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			labtool = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool;
			num = (short)1904345091;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_80;
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x002C4FA8 File Offset: 0x002C31A8
		internal static bool conPINPasswordInputValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)395902976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9E;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
				string id_SP;
				for (;;)
				{
					IL_27:
					string encryptedPwd;
					string text;
					int num3;
					switch (num2)
					{
					case 0:
						if (userInformationAndPasswords != null)
						{
							num = (short)969211908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
					{
						char c;
						if (c > '9')
						{
							num = (short)2004811793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 2:
						goto IL_1FE;
					case 3:
					{
						char c;
						if ('A' <= c)
						{
							num = (short)1960509449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FE;
					}
					case 4:
						num = (short)366280705;
						if (num != 0)
						{
						}
						num = (short)787218457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						encryptedPwd = userInformationAndPasswords.RadWideUserInformationandPINPassword_41303.DefaultValue;
						goto IL_2AB;
					case 6:
						if (string.IsNullOrEmpty(userInformationAndPasswords.RadWideUserInformationandPINPassword_41303.Value))
						{
							num = (short)1930297371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)520749075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (text.Length > 20)
						{
							num = (short)1536032784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text2 = text;
						num3 = 0;
						num = (short)661520394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)325779480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)518782996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_37E;
					case 11:
						num = (short)418971649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2050359310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return true;
					case 14:
					{
						char c;
						if ('a' <= c)
						{
							num = (short)1247543304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48C;
					}
					case 15:
					{
						char c;
						if ('0' <= c)
						{
							num = (short)580714507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 16:
						return false;
					case 17:
						goto IL_379;
					case 18:
					{
						char c;
						if (!id_SP.Contains(c.ToString()))
						{
							num = (short)287703052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 19:
						encryptedPwd = userInformationAndPasswords.RadWideUserInformationandPINPassword_41303.Value;
						goto IL_2AB;
					case 20:
					{
						char c;
						if (c > 'Z')
						{
							num = (short)209190914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 21:
					{
						string text2;
						if (num3 >= text2.Length)
						{
							num = (short)2059337741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c = text2[num3];
						num = (short)2039152658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_37E;
					case 23:
						num = (short)2146631686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						char c;
						if (c > 'z')
						{
							num = (short)955777050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					}
					case 25:
						if (userInformationAndPasswords.RadWideUserInformationandPINPassword_41303Value != null)
						{
							num = (short)2029256727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 26:
						goto IL_48C;
					case 27:
						num = (short)1568276485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9E;
					IL_1FE:
					num = (short)1418592271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_239:
					num3++;
					num = (short)896008214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AB:
					text = global::Common.AESCryptoUtil.AESDecryptWithDefKey(encryptedPwd);
					num = (short)780338097;
					short num4 = num;
					num = (short)263193521;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)1261043712;
						if (num != 0)
						{
						}
						num = (short)2077491207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_37E:
					num = (short)2141519893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48C:
					num = (short)1332215808;
					short num5 = num;
					num = (short)892207107;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_379:
				return false;
				IL_9E:
				id_SP = global::CommonResources.AcgResources.ID_SP;
				userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
				num = (short)1418985472;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x002C54AC File Offset: 0x002C36AC
		public static bool ConIsUerLoginUnitIDEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
			{
				short num = (short)1091929971;
				short num2 = num;
				num = (short)467175283;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1885470721;
					if (num != 0)
					{
					}
					num = (short)1032060928;
					short num3 = num;
					num = (short)1248526336;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x002C5564 File Offset: 0x002C3764
		internal static bool ConIsUerLoginUnitIDApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)438576543;
			short num2 = num;
			num = (short)113255839;
			switch (num2 == num)
			{
			}
			num = (short)1490223105;
			if (num != 0)
			{
			}
			num = (short)1013776384;
			if (num != 0)
			{
			}
			num = (short)1467416576;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandUserLoginUnitIDEnable_41305.Value;
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x002C561C File Offset: 0x002C381C
		internal static bool ConIsUserLoginUnitIDValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1270349824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				global::AcpBusinessLayer.AcpField<string> radWideUserInformationandUserLoginUnitID_;
				global::AcpBusinessLayer.AcpField<int> radWideUserInformationandUserLoginUnitIDTextSize_;
				string id_SP;
				for (;;)
				{
					IL_27:
					int num5;
					switch (num2)
					{
					case 0:
					{
						char c;
						if ('a' <= c)
						{
							num = (short)248971279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48D;
					}
					case 1:
					{
						num = (short)1666671233;
						short num3 = num;
						num = (short)965239425;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2D1;
						default:
						{
							num = (short)1624375296;
							if (num != 0)
							{
							}
							char c;
							if (c > 'z')
							{
								num = (short)722468888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_340;
						}
						}
						break;
					}
					case 2:
						if (radWideUserInformationandUserLoginUnitID_.Value != null)
						{
							num = (short)1218576390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
					{
						num = (short)1132855296;
						short num4 = num;
						num = (short)969080832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (radWideUserInformationandUserLoginUnitID_.Value.TrimEnd(global::System.Array.Empty<char>()).Length == 0)
						{
							num = (short)571277321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9;
					case 5:
					{
						string value;
						if (num5 >= value.Length)
						{
							num = (short)33882126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c = value[num5];
						num = (short)2033385484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)78708757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (radWideUserInformationandUserLoginUnitID_.Value.Length > radWideUserInformationandUserLoginUnitIDTextSize_.Value)
						{
							num = (short)809041945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string value = radWideUserInformationandUserLoginUnitID_.Value;
						num5 = 0;
						num = (short)1932525576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_292;
					case 9:
						return false;
					case 10:
						goto IL_F1;
					case 11:
					{
						num = (short)1033830401;
						if (num != 0)
						{
						}
						char c;
						if (c > '9')
						{
							num = (short)721944599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					}
					case 12:
					{
						char c;
						if (!id_SP.Contains(c.ToString()))
						{
							num = (short)718929923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					}
					case 13:
						num = (short)1167196180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2D1;
					case 15:
						num = (short)296091649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1095630852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						char c;
						if ('A' <= c)
						{
							num = (short)21168141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					case 18:
					{
						char c;
						if ('0' <= c)
						{
							num = (short)66060310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 19:
						goto IL_292;
					case 20:
					{
						char c;
						if (c > 'Z')
						{
							num = (short)186449930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_340;
					}
					case 21:
						if (radWideUserInformationandUserLoginUnitID_.Value.Length != 0)
						{
							num = (short)2096300048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9;
					case 22:
						num = (short)1588789259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_3C4;
					case 24:
						goto IL_48D;
					case 25:
						return false;
					}
					goto IL_96;
					IL_F1:
					num = (short)500170770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B9:
					num = (short)1915420679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_292:
					num = (short)1838874629;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_340:
					num5++;
					num = (short)911081491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48D:
					num = (short)357564433;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_2D1:
				return true;
				IL_3C4:
				return false;
				IL_96:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
				radWideUserInformationandUserLoginUnitID_ = userInformationAndPasswords.RadWideUserInformationandUserLoginUnitID_41306;
				radWideUserInformationandUserLoginUnitIDTextSize_ = userInformationAndPasswords.RadWideUserInformationandUserLoginUnitIDTextSize_41309;
				id_SP = global::CommonResources.AcgResources.ID_SP;
				num = (short)1260322818;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x002C5AF8 File Offset: 0x002C3CF8
		internal static bool ConTxPowerLevelsByFrequencyRangeEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1358823424;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_500;
				}
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				bool result;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				int num4;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection txPowerLevelsByFrequencyRangeInnerSection;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				for (;;)
				{
					IL_29:
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					bool flag6;
					bool flag7;
					bool flag8;
					bool flag9;
					bool flag10;
					bool flag11;
					bool flag12;
					switch (num2)
					{
					case 0:
						flag = true;
						goto IL_1DDA;
					case 1:
						flag2 = true;
						goto IL_2CD4;
					case 2:
						flag3 = false;
						goto IL_1F83;
					case 3:
						flag4 = radInfoFrequencyRangesVHFUsedinCodeplug_A;
						goto IL_2744;
					case 4:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)839843865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)426049724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)997523708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2A;
					case 7:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)268763352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 8:
						goto IL_2527;
					case 9:
						num = (short)1792082155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1274871854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)69664946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_2ACB;
					case 13:
						num = (short)1593573571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1575813426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)722993412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag4 = false;
						goto IL_2744;
					case 16:
						num = (short)1949892901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!radInfoFrequencyRanges7800MHzUsedinCodeplug_A)
						{
							num = (short)1596260598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1832517817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						flag5 = true;
						goto IL_15C8;
					case 19:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1030029594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A7;
					case 20:
						num = (short)276103448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						num = (short)1861378087;
						short num3 = num;
						num = (short)1132683303;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_120D;
						default:
							num = (short)1015349248;
							if (num != 0)
							{
							}
							num = (short)694288461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						return result;
					case 23:
						goto IL_938;
					case 24:
						num = (short)1365835814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1257242756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)2104754334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1000013912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2763;
					case 28:
						goto IL_1420;
					case 29:
						if (!radInfoFrequencyRangesVHFUsedinCodeplug_A)
						{
							num = (short)1127547041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 30:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2088042676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F07;
					case 31:
						flag6 = false;
						goto IL_2BDA;
					case 32:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)366280743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E79;
					case 33:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1295712280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1128661168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_27A3;
					case 35:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)21364975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A37;
					case 36:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1018167309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C23;
					case 37:
						flag2 = radInfoFrequencyRanges900MHzUsedinCodeplug_A;
						goto IL_2CD4;
					case 38:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)150864140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB5;
					case 39:
						num = (short)300941456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)347471939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1070;
					case 41:
						switch (num4)
						{
						case 0:
							num = (short)1925972169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)393216249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)832241883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)471335057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1657143323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1588789288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)963313907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 42:
						num = (short)1332805759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						return result;
					case 44:
						num = (short)1677918314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)876413207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C64;
					case 46:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)2017067253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E79;
					case 47:
						num = (short)1124270191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)1574174789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2936;
					case 49:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)2135818409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF4;
					case 50:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1774321846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D9;
					case 51:
						goto IL_1C23;
					case 52:
						num = (short)1337721095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_2A37;
					case 54:
						num = (short)1469644806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						flag7 = false;
						goto IL_237A;
					case 56:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1933967483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1628635151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)851968085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E7;
					case 58:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)765067548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D9;
					case 59:
						num = (short)1808662606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						return result;
					case 61:
						num = (short)1578107057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						return result;
					case 63:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1528954993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2025979959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (!global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)920322321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF4;
					case 65:
						num = (short)708378815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						flag5 = true;
						goto IL_15C8;
					case 67:
						num = (short)1173946522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						flag2 = true;
						goto IL_2CD4;
					case 69:
						goto IL_29D6;
					case 70:
						flag5 = radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
						goto IL_15C8;
					case 71:
						num = (short)645136563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)364839067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB1;
					case 73:
						flag = false;
						goto IL_1DDA;
					case 74:
						flag8 = false;
						goto IL_FCD;
					case 75:
						num = (short)1857487148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)693895221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A0;
					case 77:
						switch (num4)
						{
						case 0:
							num = (short)849805394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
							num = (short)1718681686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)1482555584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)441581758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
						case 12:
						case 13:
							num = (short)107413633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						case 15:
						case 16:
						case 17:
							num = (short)693698797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1702887542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 78:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1946288387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC6;
					case 79:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)974323829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 80:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)2050687281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 81:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1257898238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB1;
					case 82:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)452132925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2956;
					case 83:
						return result;
					case 84:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)30408763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A0;
					case 85:
						num = (short)791216383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)449773795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139D;
					case 87:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)1547436131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A0;
					case 88:
						num = (short)570228974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)53674237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 90:
						num = (short)1804337427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_21D7;
					case 92:
						num = (short)1804271674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						goto IL_EC5;
					case 94:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1055195333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FE;
					case 95:
						goto IL_1070;
					case 96:
						flag7 = true;
						goto IL_237A;
					case 97:
						num = (short)276299777;
						if (num != 0)
						{
						}
						num = (short)610205805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1206583424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						goto IL_1CC6;
					case 100:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1112998157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A3;
					case 101:
						flag6 = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
						goto IL_2BDA;
					case 102:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)371130662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1335;
					case 103:
						flag8 = true;
						goto IL_FCD;
					case 104:
						num = (short)403964135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_6A7;
					case 106:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)198377563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D9;
					case 107:
						return result;
					case 108:
						flag5 = true;
						goto IL_15C8;
					case 109:
						flag8 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_FCD;
					case 110:
						num = (short)143720608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)601554986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139D;
					case 112:
						flag9 = radInfoFrequencyRangesUHF1UsedinCodeplug_A;
						goto IL_1B62;
					case 113:
						num = (short)135463101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)408879125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1278083121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1720451080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EB5;
					case 116:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)271712452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F63;
					case 117:
						goto IL_D5E;
					case 118:
						num = (short)17236075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)637010162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2175;
					case 120:
						goto IL_2763;
					case 121:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)1228079278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 122:
						goto IL_2956;
					case 123:
						num = (short)797114371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						num = (short)92733488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1117388948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19E7;
					case 126:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2028077153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)898302150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)485032217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1296;
					case 128:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)128385296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACC;
					case 129:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)247398498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A7;
					case 130:
						num = (short)1368981541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)279773308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29D6;
					case 132:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)2012020956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1338572868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)772276526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC5;
					case 134:
						flag10 = true;
						goto IL_1ABD;
					case 135:
						num = (short)1695613131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						flag11 = true;
						goto IL_2621;
					case 137:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)986054667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)93847554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						return result;
					case 139:
						flag6 = true;
						goto IL_2BDA;
					case 140:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1584595155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_838;
					case 141:
						flag8 = true;
						goto IL_FCD;
					case 142:
						return result;
					case 143:
						flag = true;
						goto IL_1DDA;
					case 144:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1596981258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D33;
					case 145:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)429195555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC5;
					case 146:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)2043805806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)462291018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)2082865302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC3;
					case 148:
						num = (short)672923728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						flag11 = true;
						goto IL_2621;
					case 150:
						goto IL_2702;
					case 151:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)76152988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)393543711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						num = (short)98828455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 153:
						num = (short)1540685903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)337444959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_897;
					case 155:
						num = (short)661454969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 156:
						num = (short)1548681317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
						flag9 = false;
						goto IL_1B62;
					case 158:
						flag = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1DDA;
					case 159:
						num = (short)341049361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 160:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)1858666700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FE;
					case 161:
						goto IL_F07;
					case 162:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)957022484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 163:
						num = (short)2132803797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						flag12 = false;
						goto IL_1509;
					case 165:
						num = (short)683737355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 166:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1483669754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ACB;
					case 167:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1247281442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2763;
					case 168:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1557004536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2103247080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						num = (short)683212864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 170:
						goto IL_7F7;
					case 171:
						goto IL_1E9F;
					case 172:
						return result;
					case 173:
						return result;
					case 174:
						goto IL_BB1;
					case 175:
						flag9 = true;
						goto IL_1B62;
					case 176:
						flag3 = false;
						goto IL_1F83;
					case 177:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)600637562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 178:
						flag3 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1F83;
					case 179:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1849819435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D72;
					case 180:
						num = (short)1678049309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)161743126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)20512834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						num = (short)758579423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 183:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1283391580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2021720298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						return result;
					case 185:
						flag12 = true;
						goto IL_1509;
					case 186:
						num = (short)1966604435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
						flag2 = false;
						goto IL_2CD4;
					case 188:
						flag2 = false;
						goto IL_2CD4;
					case 189:
						flag7 = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
						goto IL_237A;
					case 190:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1588854838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F5;
					case 191:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1015414807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A79;
					case 192:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)766247209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E86;
					case 193:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)1047461904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1793;
					case 194:
					{
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)133496962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)510722048;
						short num5 = num;
						num = (short)1971912891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 195:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)867696691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_897;
					case 196:
						goto IL_1C64;
					case 197:
						goto IL_1335;
					case 198:
						flag8 = false;
						goto IL_FCD;
					case 199:
						flag9 = true;
						goto IL_1B62;
					case 200:
						return result;
					case 201:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1740832921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5E;
					case 202:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)1892942033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225A;
					case 203:
						flag11 = radInfoFrequencyRangesUHF2UsedinCodeplug_A;
						goto IL_2621;
					case 204:
						num = (short)606339174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						flag3 = true;
						goto IL_1F83;
					case 206:
						flag12 = true;
						goto IL_1509;
					case 207:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)387842207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1731002532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 208:
						if (!txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value)
						{
							num = (short)911081565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2175;
					case 209:
						goto IL_2D72;
					case 210:
						num = (short)1933377568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						num = (short)1855455239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 212:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)730857755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 213:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2029060261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9F;
					case 214:
						if (!global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)2062549296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF4;
					case 215:
						num = (short)1480392866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 216:
						num = (short)720699649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
						num = (short)251986101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 218:
						if (!txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value)
						{
							num = (short)1076166776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A18;
					case 219:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1727397963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9F;
					case 220:
						num = (short)1678246082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 221:
						num = (short)152961139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 222:
						goto IL_27E7;
					case 223:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1999503404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D7;
					case 224:
						flag12 = radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
						goto IL_1509;
					case 225:
						flag10 = global::ConstraintHelper.UtilityMack.IsMahaloVHFRadio;
						goto IL_1ABD;
					case 226:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1998323721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17F5;
					case 227:
						num = (short)977273117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 228:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1675165722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2065039433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)634978439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1005256955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 230:
						flag7 = true;
						goto IL_237A;
					case 231:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)897253668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A0;
					case 232:
						flag = false;
						goto IL_1DDA;
					case 233:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)2139947294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A79;
					case 234:
						flag12 = false;
						goto IL_1509;
					case 235:
						if (!radInfoFrequencyRangesUHF1UsedinCodeplug_A)
						{
							num = (short)137494794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2A;
					case 236:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)123600930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F63;
					case 237:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)481034426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2702;
					case 238:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)1573388440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A18;
					case 239:
						num = (short)2102526028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)436535513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1947074856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1118765121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_938;
					case 242:
						goto IL_120D;
					case 243:
						num = (short)194969784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
						if (!radInfoFrequencyRangesUHF2UsedinCodeplug_A)
						{
							num = (short)842858601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACC;
					case 245:
						goto IL_2D33;
					case 246:
						num = (short)1810170080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 247:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1255145687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ACB;
					case 248:
						num = (short)1415905513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 249:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)2071789778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D33;
					case 250:
						num = (short)429588781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
						flag11 = false;
						goto IL_2621;
					case 252:
						num = (short)1961754850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 253:
						num = (short)1028522109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 254:
						num = (short)748421332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 255:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)861667550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2936;
					case 256:
						num = (short)1726611649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 257:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1187184914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_838;
					case 258:
						num = (short)952893680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 259:
						num = (short)1847722071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 260:
						flag9 = false;
						goto IL_1B62;
					case 261:
						flag3 = true;
						goto IL_1F83;
					case 262:
						flag6 = true;
						goto IL_2BDA;
					case 263:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)2135818268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 264:
						flag11 = false;
						goto IL_2621;
					case 265:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)2041184276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F7;
					case 266:
						goto IL_17F5;
					case 267:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1424818347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FAD;
					case 268:
						num = (short)1988821295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 269:
						num = (short)1940652268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 270:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1623392346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1981481224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 271:
						flag5 = false;
						goto IL_15C8;
					case 272:
						num = (short)1978728467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 273:
						num = (short)131334358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 274:
						goto IL_E86;
					case 275:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)756351047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225A;
					case 276:
						num = (short)655491238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 277:
						return result;
					case 278:
						num = (short)965804102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 279:
						num = (short)5374068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 280:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)326959274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC3;
					case 281:
						goto IL_139D;
					case 282:
						num = (short)812450036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						num = (short)1811808345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 284:
						num = (short)1601110066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 285:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)323092527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1296;
					case 286:
						num = (short)185991409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 287:
						if (!global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)1860894772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1420;
					case 288:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)800850024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2145714333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 289:
						flag4 = true;
						goto IL_2744;
					case 290:
						num = (short)419365082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 291:
						num = (short)471269495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 292:
						num = (short)400818260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 293:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1105592578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1793;
					case 294:
						num = (short)120717406;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 295:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1648558336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1364590863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 296:
						flag5 = false;
						goto IL_15C8;
					case 297:
						num = (short)1985872012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 298:
						return result;
					case 299:
						num = (short)1330970826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 300:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1712521379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FAD;
					case 301:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)797179916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 302:
						num = (short)611385552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 303:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1513029853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2527;
					case 304:
						num = (short)309657641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 305:
						goto IL_19E7;
					case 306:
						num = (short)1813512304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 307:
						flag12 = true;
						goto IL_1509;
					}
					goto IL_500;
					IL_6A7:
					num = (short)2072051982;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F7:
					num = (short)1581383684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_838:
					num = (short)1556545741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_897:
					num = (short)1670709266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_938:
					num = (short)1071186148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9FE:
					num = (short)1036845197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ACC:
					num = (short)661323925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB1:
					num = (short)2044592184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5E:
					num = (short)1666056439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E86:
					num = (short)2077687841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC5:
					num = (short)1063518308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F07:
					num = (short)299368673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2A:
					num = (short)1412694215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8E:
					num = (short)1272447265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FAD:
					num = (short)1404240078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FCD:
					result = flag8;
					num = (short)1753677907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1070:
					num = (short)1556086820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_120D:
					num = (short)749273221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1296:
					num = (short)1175977984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1335:
					num = (short)641925246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139D:
					num = (short)1678573736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1420:
					result = true;
					num = (short)866386092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1509:
					result = flag12;
					num = (short)954597518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15C8:
					result = flag5;
					num = (short)1997734026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1793:
					num = (short)533135468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F5:
					num = (short)1044381984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19E7:
					num = (short)1097465928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ABD:
					result = flag10;
					num = (short)80216126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B62:
					result = flag9;
					num = (short)815595818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC3:
					num = (short)1539964929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C23:
					num = (short)699007271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C64:
					num = (short)1160118423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC6:
					num = (short)1598685219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DDA:
					result = flag;
					num = (short)859242556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3D:
					num = (short)1436287110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E9F:
					num = (short)432013495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F63:
					num = (short)1394606342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F83:
					result = flag3;
					num = (short)198049992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D9:
					num = (short)1408041267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2175:
					num = (short)642646155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21D7:
					num = (short)1983840463;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_225A:
					num = (short)1857355912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_237A:
					result = flag7;
					num = (short)1215692973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2527:
					num = (short)536084617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2621:
					result = flag11;
					num = (short)652804118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26A0:
					num = (short)1678049455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2702:
					num = (short)2113798409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2744:
					result = flag4;
					num = (short)600178965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2763:
					num = (short)1819607171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A3:
					num = (short)309526573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27E7:
					num = (short)258211903;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2936:
					num = (short)2021261408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2956:
					num = (short)1480327249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29D6:
					num = (short)620494905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A18:
					num = (short)1106247910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A37:
					num = (short)1319632910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A79:
					num = (short)1604714639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2ACB:
					num = (short)2007629854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BDA:
					result = flag6;
					num = (short)438304811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CD4:
					result = flag2;
					num = (short)398327813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF4:
					num = (short)25035039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D33:
					num = (short)1161625746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D72:
					num = (short)666960101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E79:
					num = (short)565968999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EB5:
					num = (short)1381826821;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_500:
				txPowerLevelsByFrequencyRangeInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInnerSection);
				radInfoGeneralPrimaryFrequencyBandVHF_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				radInfoLabtoolPrimaryBands_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoLabtoolDualBandEnable_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				radInfoFrequencyRanges8900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
				num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				result = false;
				num = (short)473759858;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x002C89DC File Offset: 0x002C6BDC
		public static bool conNonEditableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)799422340;
			short num2 = num;
			num = (short)291059588;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1622999040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1606549504;
			if (num != 0)
			{
			}
			num = (short)1772748801;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x002C8A90 File Offset: 0x002C6C90
		internal static bool ConBluetoothReplacePairingInfoIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth;
			short num;
			if (!bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value)
			{
				num = (short)1929776970;
				short num2 = num;
				num = (short)651497290;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1348206593;
					if (num != 0)
					{
					}
					num = (short)1417936896;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1830879232;
			short num3 = num;
			return bluetooth.RadWideBluetoothBluetoothReconnectTimer_A37037.Value != 0;
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x002C8B60 File Offset: 0x002C6D60
		internal static bool ConTacticalInhibitEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1817511422;
			short num2 = num;
			num = (short)358286846;
			switch (num2 == num)
			{
			default:
			{
				num = (short)123142144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1140391937;
			if (num != 0)
			{
			}
			num = (short)1607467008;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x002C8C18 File Offset: 0x002C6E18
		internal static bool ConTacticalInhibitEnabledForRadioLock(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLock_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1505131419;
					short num3 = num2;
					num2 = (short)1431337883;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F7;
					default:
						num2 = (short)895942656;
						if (num2 != 0)
						{
						}
						num2 = (short)447283202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)274333700;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!radWideUserInformationandPasswordsRadioLock_A.Value)
					{
						num2 = (short)541982726;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_177;
				case 4:
					if (!radWideUserInformationandPasswordsRadioLock_A.Value)
					{
						num2 = (short)1452998659;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					goto IL_1F7;
				case 6:
					goto IL_1B6;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
					radWideUserInformationandPasswordsRadioLock_A = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836;
					(((global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessories).General.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInner).KMButtonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.CalculateValidity();
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
					{
						num2 = (short)1252261888;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B6;
				}
				}
				goto IL_30;
				IL_1B6:
				num2 = (short)879820800;
				short num4 = num2;
				num2 = (short)1640955909;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F7:
				if (!userInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value)
				{
					return true;
				}
				num2 = (short)530448385;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_177:
			return radWideUserInformationandPasswordsRadioLock_A.HiddenStatic;
			IL_30:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			num2 = (short)1152909313;
			if (num2 != 0)
			{
			}
			num2 = (short)747700231;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x002C8E48 File Offset: 0x002C7048
		internal static bool ConEncodePasswordLength(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
			global::AcpBusinessLayer.AcpField<string> radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A = userInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;
			short num;
			if (radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A.Value != null)
			{
				num = (short)166890426;
				short num2 = num;
				num = (short)272337850;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1941176321;
					if (num != 0)
					{
					}
					num = (short)1331757056;
					if (num != 0)
					{
					}
					return radWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A.Value.Length <= userInformationAndPasswords.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value;
				}
			}
			num = (short)1836122112;
			short num3 = num;
			return true;
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x002C8F24 File Offset: 0x002C7124
		public static bool ConNotCompareMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)34406401;
			if (num != 0)
			{
			}
			num = (short)51445760;
			short num2 = num;
			num = (short)502177444;
			short num3 = num;
			num = (short)1327734436;
			switch (num3 == num)
			{
			}
			num = (short)820051968;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode;
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x002C8FD8 File Offset: 0x002C71D8
		public static bool ConTxPowerLevelsByFrequencyRangeNewBand(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)712638464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_316;
				}
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				bool result;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpListField radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesOpenFrequency_A;
				global::AcpCommonLib.IAcpFeatureNode parent;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					int num3;
					bool flag6;
					switch (num2)
					{
					case 0:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1113129054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A0;
					case 1:
						num = (short)321978378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1688141824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)2096627855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)609091750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1917255711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)385155203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					case 7:
						num = (short)819527815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1037566011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)1412956313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 10:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1216086024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)740753591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)171376819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1267007591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)352256009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)1877475357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DF;
					case 15:
						num = (short)1225129998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag = false;
						goto IL_F50;
					case 17:
						num = (short)1405354033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)301924486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_567;
					case 19:
						num = (short)495255723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_99C;
					case 21:
						flag = true;
						goto IL_F50;
					case 22:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1103102030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 23:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1823408274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129F;
					case 24:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)771489877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DF;
					case 25:
						num = (short)1280508073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						flag2 = true;
						goto IL_14C2;
					case 27:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1186005137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					case 28:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1262223478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1430782085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_1661;
					case 30:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)998899773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103A;
					case 31:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)1536360503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186F;
					case 32:
						flag3 = true;
						goto IL_1D04;
					case 33:
						return result;
					case 34:
						num = (short)533528703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1723203681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)541065232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)336199768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E31;
					case 37:
						flag4 = true;
						goto IL_1523;
					case 38:
						num = (short)1943404649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)669384793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)2111766642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)849608738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_567;
					case 42:
						flag = false;
						goto IL_F50;
					case 43:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)1781989528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 44:
						num = (short)1107099672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						flag = true;
						goto IL_F50;
					case 46:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)195887151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63F;
					case 47:
						num = (short)1002766342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)1111949370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186F;
					case 49:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)220463194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B00;
					case 50:
						if (!radInfoFrequencyRangesUHF2UsedinCodeplug_A)
						{
							num = (short)948437136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF5;
					case 51:
						num = (short)1282867265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						flag5 = radInfoFrequencyRangesVHFUsedinCodeplug_A;
						goto IL_D6D;
					case 53:
						return result;
					case 54:
						num = (short)2141519973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_6C0;
					case 56:
						goto IL_954;
					case 57:
						goto IL_9DA;
					case 58:
						goto IL_190F;
					case 59:
						flag3 = radInfoFrequencyRanges900MHzUsedinCodeplug_A;
						goto IL_1D04;
					case 60:
						num = (short)1570373702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_155E;
					case 62:
						num = (short)353960019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)2025128095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						switch (num3)
						{
						case 0:
							num = (short)757727268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
							num = (short)51314774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1336737973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)201916462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						case 13:
						case 14:
							num = (short)554893487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						case 16:
						case 17:
						case 18:
							num = (short)2052128878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)519372968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 65:
					{
						num = (short)516250226;
						short num4 = num;
						num = (short)196369010;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_954;
						default:
							num = (short)561905664;
							if (num != 0)
							{
							}
							if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
							{
								num = (short)1936851026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_91D;
						}
						break;
					}
					case 66:
						flag6 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1221;
					case 67:
						num = (short)1565655092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_E31;
					case 69:
						num = (short)1773731862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)678953071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 71:
						goto IL_587;
					case 72:
						flag3 = false;
						goto IL_1D04;
					case 73:
						num = (short)1778974829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						flag2 = true;
						goto IL_14C2;
					case 75:
						flag4 = true;
						goto IL_1523;
					case 76:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)1463681093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 77:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1704198308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63F;
					case 78:
						goto IL_161E;
					case 79:
						return result;
					case 80:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)79102128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1300496497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1426456724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1302200392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)150798456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)55247003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 84:
						num = (short)454426723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_18CE;
					case 86:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)199360563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99C;
					case 87:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)1440546900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DF;
					case 88:
						num = (short)1280966816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)1740832941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF5;
					case 90:
						goto IL_125E;
					case 91:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)520093699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161E;
					case 92:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1881538575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1661;
					case 93:
						return result;
					case 94:
						num = (short)1755643927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						flag4 = false;
						goto IL_1523;
					case 96:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1337327654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1690042484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num = (short)102170665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						flag4 = radInfoFrequencyRangesUHF1UsedinCodeplug_A;
						goto IL_1523;
					case 99:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1058275372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18CE;
					case 100:
						goto IL_1405;
					case 101:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)836108460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161E;
					case 102:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1472266370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155E;
					case 103:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)450232337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_125E;
					case 104:
						num = (short)301727863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)553058316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B00;
					case 106:
						goto IL_129F;
					case 107:
						flag5 = true;
						goto IL_D6D;
					case 108:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1302462586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)638058637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)22216882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103A;
					case 110:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)242745349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C0;
					case 111:
						goto IL_1B26;
					case 112:
						if (radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A != null)
						{
							num = (short)994771081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 113:
						flag4 = false;
						goto IL_1523;
					case 114:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)1443561529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 115:
						flag6 = true;
						goto IL_1221;
					case 116:
						flag6 = false;
						goto IL_1221;
					case 117:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)780927080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)80674967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						num = (short)2034958400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						flag2 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_14C2;
					case 120:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)491520011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99C;
					case 121:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1070006446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67F;
					case 122:
						num = (short)1671299138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)1343750194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1721761932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 125:
						num = (short)899285040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)797442073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 127:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1736441998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8DA;
					case 128:
						if (!radInfoFrequencyRanges7800MHzUsedinCodeplug_A.Value)
						{
							num = (short)712900708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 129:
						return result;
					case 130:
						num = (short)1907687454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
						num = (short)1730805837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)945225729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)442433568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (!global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)1819803708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B26;
					case 134:
						goto IL_8DA;
					case 135:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1527185546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DF;
					case 136:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)396558442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A0;
					case 137:
						num = (short)509083818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						num = (short)1936719959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1341980685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 140:
						num = (short)1159135360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						flag6 = false;
						goto IL_1221;
					case 142:
						num = (short)709492754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)442892307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 144:
						goto IL_BE6;
					case 145:
						num = (short)320798846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						num = (short)1329594504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						if (!radInfoFrequencyRangesUHF1UsedinCodeplug_A)
						{
							num = (short)305397909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C5;
					case 148:
						num = (short)1233780868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						goto IL_63F;
					case 150:
					{
						num = (short)1789067264;
						short num5 = num;
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)245432382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13C5;
					}
					case 151:
						flag2 = false;
						goto IL_14C2;
					case 152:
						goto IL_67F;
					case 153:
						num = (short)1723400342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 154:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)87818363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE6;
					case 155:
						goto IL_13C5;
					case 156:
						return result;
					case 157:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)104661059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1397227687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1307901959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)409403487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						flag = radInfoFrequencyRangesUHF2UsedinCodeplug_A;
						goto IL_F50;
					case 160:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)1268711492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 161:
						num = (short)921763952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						goto IL_1D1E;
					case 163:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)90898505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)108068920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						num = (short)1943339155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						num = (short)1693646849;
						if (num != 0)
						{
						}
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1877213309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190F;
					case 166:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1204944936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9DA;
					case 167:
						flag5 = false;
						goto IL_D6D;
					case 168:
						num = (short)745930908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)545849348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC4;
					case 170:
						if (radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A.Value == 1)
						{
							num = (short)660013127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 171:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)924909622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 172:
						num = (short)1669922892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 173:
						num = (short)1539113114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						num = (short)1126367275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1771765799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE6;
					case 176:
						num = (short)1424752738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						flag6 = true;
						goto IL_1221;
					case 178:
						num = (short)227147878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)1188560916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91D;
					case 180:
						flag3 = true;
						goto IL_1D04;
					case 181:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)713555970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129F;
					case 182:
						if (!radInfoFrequencyRangesOpenFrequency_A.Value)
						{
							num = (short)693239969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 183:
						flag3 = false;
						goto IL_1D04;
					case 184:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1872363583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)934871082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						return result;
					}
					goto IL_316;
					IL_4C5:
					num = (short)517996619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_567:
					num = (short)1226440749;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					result = false;
					num = (short)1347747868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DF:
					num = (short)1376321573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63F:
					num = (short)1031143582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67F:
					num = (short)4653213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C0:
					num = (short)1147994277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DA:
					num = (short)2113405112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91D:
					num = (short)541851674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99C:
					num = (short)1427308707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DA:
					num = (short)357695609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC4:
					num = (short)1422917739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B00:
					num = (short)1362952369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE6:
					num = (short)1699151907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6D:
					result = flag5;
					num = (short)1908932641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E31:
					num = (short)1078067227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF5:
					num = (short)1054736405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F50:
					result = flag;
					num = (short)848887861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103A:
					num = (short)1070465098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1221:
					result = flag6;
					num = (short)160890959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_125E:
					num = (short)220790892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_129F:
					num = (short)1488978016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13C5:
					num = (short)596836476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1405:
					num = (short)551747766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14C2:
					result = flag2;
					num = (short)306118785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_954:
					flag2 = false;
					goto IL_14C2;
					IL_1523:
					result = flag4;
					num = (short)12714077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155E:
					num = (short)1129185397;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A0:
					num = (short)220725363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161E:
					num = (short)1328677003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1661:
					num = (short)107020368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_186F:
					num = (short)1262026932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18CE:
					num = (short)867827804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190F:
					num = (short)1657536593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B26:
					result = true;
					num = (short)1208680633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D04:
					result = flag3;
					num = (short)1352466594;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_1D1E:
				return result;
				IL_316:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection txPowerLevelsByFrequencyRangeNewBandPlanInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection;
				radInfoLabtoolPrimaryBands_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoFrequencyRangesOpenFrequency_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699;
				radInfoLabtoolDualBandEnable_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				parent = self.Parent;
				radInfoGeneralPrimaryFrequencyBandVHF_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;
				num = (short)1751908443;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x002CAD0C File Offset: 0x002C8F0C
		public static bool ConTxPowerLevelsByFrequencyRangeNewBandEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1983840256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_316;
				}
				bool result;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesOpenFrequency_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpListField radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				global::AcpCommonLib.IAcpFeatureNode parent;
				for (;;)
				{
					IL_27:
					int num3;
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					bool flag6;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						num = (short)1012465685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1903;
					case 3:
						num = (short)1404764168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)589430896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1262;
					case 5:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)896794699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)894369921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)277151753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!radInfoFrequencyRanges7800MHzUsedinCodeplug_A.Value)
						{
							num = (short)1916338336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 8:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)946536450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DB;
					case 9:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)1860436075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC3;
					case 10:
						num = (short)1834745940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (num3)
						{
						case 0:
							num = (short)1587019831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
						case 6:
						case 7:
						case 8:
						case 9:
							num = (short)786890845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1400242237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)1855389838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						case 13:
						case 14:
							num = (short)938279058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						case 16:
						case 17:
						case 18:
							num = (short)59506862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1447362573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 12:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1286275131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1471938741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)772079753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return result;
					case 15:
						flag = true;
						goto IL_1224;
					case 16:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1696071710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1653;
					case 17:
						num = (short)2025062454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)1797587096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC3;
					case 19:
						if (!radInfoFrequencyRanges900MHzUsedinCodeplug_A)
						{
							num = (short)173277310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A3;
					case 20:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1930559624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1694;
					case 21:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)2008023209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D3;
					case 22:
						flag2 = false;
						goto IL_D76;
					case 23:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1799028769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103B;
					case 24:
						num = (short)1755644055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)1630208047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_565;
					case 26:
						num = (short)1636761605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_12A4;
					case 28:
						num = (short)793640971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)1349779483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D2;
					case 30:
						num = (short)1873412212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						flag3 = false;
						goto IL_F55;
					case 32:
						goto IL_1262;
					case 33:
						goto IL_158F;
					case 34:
						num = (short)586154137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)2101084345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)642842642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						flag = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_1224;
					case 38:
						flag4 = false;
						goto IL_1554;
					case 39:
						flag5 = false;
						goto IL_1D02;
					case 40:
						num = (short)1377173594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)513343544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67B;
					case 42:
						goto IL_1B54;
					case 43:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1802960930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140F;
					case 44:
						num = (short)489881713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_67B;
					case 46:
						goto IL_1D1E;
					case 47:
						goto IL_8D3;
					case 48:
						num = (short)251723948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_9E0;
					case 50:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)392495272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC3;
					case 51:
						num = (short)383058069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)664600714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13CE;
					case 53:
						num = (short)779354135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1949827256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D2;
					case 55:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1761607716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E38;
					case 56:
						num = (short)1677066290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (!radInfoFrequencyRangesUHF2UsedinCodeplug_A)
						{
							num = (short)470286394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EFB;
					case 58:
						goto IL_BE9;
					case 59:
						num = (short)1800863781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)1683619846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A22;
					case 61:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)903610385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A4;
					case 62:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)1364721713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_960;
					case 63:
						flag6 = false;
						goto IL_14CB;
					case 64:
						flag5 = true;
						goto IL_1D02;
					case 65:
						num = (short)1578500193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1136918708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						flag3 = radInfoFrequencyRangesUHF2UsedinCodeplug_A;
						goto IL_F55;
					case 68:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)1562181633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_565;
					case 69:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)2085027868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1373896808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)611778701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1553793148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						flag5 = false;
						goto IL_1D02;
					case 72:
						num = (short)87687230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)742260898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						goto IL_63B;
					case 75:
						num = (short)1442709604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_1653;
					case 77:
						num = (short)958595204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						flag2 = true;
						goto IL_D76;
					case 79:
						flag5 = radInfoFrequencyRanges900MHzUsedinCodeplug_A;
						goto IL_1D02;
					case 80:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)833486888;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67B;
					case 81:
						if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
						{
							num = (short)1523318808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 82:
						num = (short)998637597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)681443495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)583532652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1653;
					case 85:
						num = (short)1694630042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						num = (short)515833923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)1273167989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)513212498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A4;
					case 89:
						if (!radInfoFrequencyRangesOpenFrequency_A.Value)
						{
							num = (short)1070661724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 90:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)86310957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC3;
					case 91:
						flag4 = true;
						goto IL_1554;
					case 92:
						num = (short)309133442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)549912754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E0;
					case 94:
						num = (short)696778915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_D92;
					case 96:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)646905907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DB;
					case 97:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1527775304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E0;
					case 98:
						num = (short)60751879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)595460246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 100:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1715601565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1321140263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						goto IL_123E;
					case 102:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)603062273;
							if (num != 0)
							{
							}
							num = (short)65536176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1944;
					case 103:
						flag3 = true;
						goto IL_F55;
					case 104:
						if (!global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)1799225454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B54;
					case 105:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)697499701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_158F;
					case 106:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)93126833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)986382500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						goto IL_A22;
					case 108:
						num = (short)1184759889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num = (short)179634244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						num = (short)464846996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						flag6 = true;
						goto IL_14CB;
					case 112:
						num = (short)1371013248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						if (!radInfoFrequencyRangesUHF1UsedinCodeplug_A)
						{
							num = (short)1432289354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C3;
					case 114:
						num = (short)473038993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)1596850311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DB;
					case 116:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)1734541385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 117:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1217396780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63B;
					case 118:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)1647378605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC3;
					case 119:
						goto IL_583;
					case 120:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1240137776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1862336575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1380778050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1945763878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)929235091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B01;
					case 123:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1125711898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1205534791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						flag = false;
						goto IL_1224;
					case 125:
						flag = true;
						goto IL_1224;
					case 126:
						goto IL_1944;
					case 127:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)1688600641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_960;
					case 128:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1800142880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B01;
					case 129:
						flag5 = true;
						goto IL_1D02;
					case 130:
						if (radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A != null)
						{
							num = (short)79495203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 131:
						goto IL_F6F;
					case 132:
						if (radInfoLabtoolDualBandEnable_A)
						{
							num = (short)60096515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1903;
					case 133:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)244318293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)989593783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						num = (short)2079129657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						goto IL_1694;
					case 136:
						num = (short)85000307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						goto IL_DB0;
					case 138:
						num = (short)1695350883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						num = (short)1367998516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						num = (short)1801191599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						num = (short)583794810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)111476850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63B;
					case 143:
						flag3 = true;
						goto IL_F55;
					case 144:
						flag6 = true;
						goto IL_14CB;
					case 145:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)264437847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C3;
					case 146:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)461635739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE9;
					case 147:
						num = (short)1950679044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						IL_73D:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)323878954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 149:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)1100677197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DB;
					case 150:
						goto IL_13CE;
					case 151:
						if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
						{
							num = (short)2074542156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 152:
						goto IL_E38;
					case 153:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)796917899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 154:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)229376170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103B;
					case 155:
						num = (short)1859322022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 156:
						flag3 = false;
						goto IL_F55;
					case 157:
						num = (short)1070530639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)396886102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1990197279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)510459998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)514326550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 160:
						goto IL_140F;
					case 161:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)626196589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1804796060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)898433034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_583;
					case 163:
						flag2 = radInfoFrequencyRangesVHFUsedinCodeplug_A;
						goto IL_D76;
					case 164:
						flag4 = false;
						goto IL_1554;
					case 165:
						goto IL_6BC;
					case 166:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)1255735379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EFB;
					case 167:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
						{
							num = (short)1921712262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE9;
					case 168:
						num = (short)1923022966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						num = (short)342097945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 170:
						num = (short)258015337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)63045730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140F;
					case 172:
						flag6 = radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
						goto IL_14CB;
					case 173:
						num = (short)1130823740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1105854604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BC;
					case 175:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)1298858149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A3;
					case 176:
						num = (short)1595801619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						num = (short)1672806496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 178:
						num = (short)217251967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						flag4 = true;
						goto IL_1554;
					case 180:
						flag4 = radInfoFrequencyRangesUHF1UsedinCodeplug_A;
						goto IL_1554;
					case 181:
						flag = false;
						goto IL_1224;
					case 182:
						goto IL_14E6;
					case 183:
						flag6 = false;
						goto IL_14CB;
					case 184:
						num = (short)1007878232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						if (radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A.Value == 1)
						{
							num = (short)392691831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_316;
					IL_4C3:
					num = (short)493617243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_565:
					num = (short)1876033679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_583:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					result = false;
					num = (short)1094123589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DB:
					num = (short)1503330483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63B:
					num = (short)878051434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67B:
					num = (short)655032479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BC:
					num = (short)710869094;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D3:
					num = (short)250598782;
					short num4 = num;
					num = (short)1304483198;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73D;
					default:
						num = (short)1766129664;
						if (num != 0)
						{
						}
						num = (short)505544862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_960:
					num = (short)1141178479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E0:
					num = (short)1099169925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A22:
					num = (short)64225360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC3:
					num = (short)1066860622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B01:
					num = (short)937230351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE9:
					num = (short)31326369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D76:
					result = flag2;
					num = (short)716636255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E38:
					num = (short)1995505705;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EFB:
					num = (short)1023672423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F55:
					result = flag3;
					num = (short)2147352707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103B:
					num = (short)1077280912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1224:
					result = flag;
					num = (short)1974141029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1262:
					num = (short)479330316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12A4:
					num = (short)1948385350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13CE:
					num = (short)250413227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140F:
					num = (short)481427545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14CB:
					result = flag6;
					num = (short)744161462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1554:
					result = flag4;
					num = (short)1338966030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_158F:
					num = (short)294781048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D2:
					num = (short)695992445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1653:
					num = (short)135462955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1694:
					num = (short)739442809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A3:
					num = (short)2090991680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1903:
					num = (short)794165268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1944:
					num = (short)396558459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B54:
					result = true;
					num = (short)796393472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D02:
					result = flag5;
					num = (short)1280245806;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D92:
				IL_DB0:
				IL_F6F:
				IL_123E:
				return result;
				IL_14E6:
				num = (short)1867710464;
				short num5 = num;
				return result;
				IL_1D1E:
				return result;
				IL_316:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection txPowerLevelsByFrequencyRangeNewBandPlanInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection;
				radInfoLabtoolPrimaryBands_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoFrequencyRangesOpenFrequency_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699;
				radInfoLabtoolDualBandEnable_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				parent = self.Parent;
				radWideTxPowerLevelsNewBandPlan78MHzBandSelection_A = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;
				radInfoGeneralPrimaryFrequencyBandVHF_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				num = (short)1421672464;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x002CCA40 File Offset: 0x002CAC40
		public static bool TxPowerLowNewBandVaild(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelLowW_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection txPowerLevelsByFrequencyRangeNewBandPlanInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854.Value)
					{
						num2 = (short)1159593987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_96;
				case 2:
				{
					num2 = (short)942167793;
					short num3 = num2;
					num2 = (short)1108498161;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num2 = (short)1596260352;
						if (num2 != 0)
						{
						}
						if (radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value <= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value)
						{
							num2 = (short)864419844;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
					num2 = (short)1653014530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_16C;
				case 5:
					num2 = (short)1846083585;
					if (num2 != 0)
					{
					}
					if (!radWideTransmitPowerLevelsTxPowerLevelLowW_A.HiddenStatic)
					{
						num2 = (short)1701380097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
				IL_96:
				num2 = (short)1339359232;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16C:
			num2 = (short)1971322880;
			short num4 = num2;
			return radWideTransmitPowerLevelsTxPowerLevelLowW_A.Value >= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Value;
			IL_28:
			txPowerLevelsByFrequencyRangeNewBandPlanInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection);
			radWideTransmitPowerLevelsTxPowerLevelLowW_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;
			num2 = (short)626982917;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x002CCC08 File Offset: 0x002CAE08
		public static bool CnvTxPowerLevelLowNewBandValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)354563535;
			short num2 = num;
			num = (short)789198287;
			switch (num2 == num)
			{
			}
			num = (short)1935605760;
			short num3 = num;
			num = (short)1745879041;
			if (num != 0)
			{
			}
			num = (short)1634795520;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x002CCCB4 File Offset: 0x002CAEB4
		public static bool TrkTxPowerLevelLowNewBandValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1785131136;
			short num2 = num;
			num = (short)454684800;
			switch (num2 == num)
			{
			}
			num = (short)1650065408;
			short num3 = num;
			num = (short)288292864;
			if (num != 0)
			{
			}
			num = (short)44105729;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002DC5 RID: 11717 RVA: 0x002CCD60 File Offset: 0x002CAF60
		public static bool TxPowerLevelHighNewBandValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)615251968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolH37G50Smartnet_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection txPowerLevelsByFrequencyRangeNewBandPlanInnerSection;
				global::AcpBusinessLayer.AcpRangeField<int, string> radWideTransmitPowerLevelsTxPowerLevelHighW_A;
				global::AcpBusinessLayer.AcpListField radWideTransmitPowerLevelsTxPowerLevelConfigType_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolH38G51Smartzone_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (!radInfoLabtoolH37G50Smartnet_A.Value)
						{
							num = (short)155844620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_532;
					case 1:
						if (!radInfoLabtoolH37G50Smartnet_A.Value)
						{
							num = (short)1486356493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CC;
					case 2:
						num = (short)1638203399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)550502404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)1566375938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 1)
						{
							num = (short)1484128262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 6:
						num = (short)612106241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value <= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value)
						{
							num = (short)2115633163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)867827730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						goto IL_1D6;
					case 10:
						num = (short)1542520833;
						if (num != 0)
						{
						}
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 0)
						{
							num = (short)1190789123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						goto IL_372;
					case 12:
						num = (short)1148059674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)935264271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)480378899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (radInfoLabtoolH38G51Smartzone_A.Value)
						{
							num = (short)1668349980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 16:
						if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value <= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value)
						{
							num = (short)809107465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)701497364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						num = (short)1979318295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)1892736502;
						short num3 = num;
						num = (short)144236022;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4FE;
						default:
							num = (short)409468928;
							if (num != 0)
							{
							}
							if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value <= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.Value)
							{
								num = (short)2115239963;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 20:
						num = (short)2059141136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						num = (short)1757151232;
						short num4 = num;
						num = (short)1889402897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (radWideTransmitPowerLevelsTxPowerLevelConfigType_A.Value == 1)
						{
							num = (short)1026228253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_532;
					case 23:
						if (txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.Value <= radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value)
						{
							num = (short)2084241422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
						goto IL_4FE;
					case 25:
						goto IL_52D;
					case 26:
						if (!radInfoLabtoolH38G51Smartzone_A.Value)
						{
							num = (short)1266745365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_532;
					case 27:
						num = (short)154730520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_2CC;
					case 29:
						num = (short)2111242240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
					IL_2CC:
					num = (short)1647181832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47D:
					num = (short)2112946186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FE:
					if (radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Value)
					{
						num = (short)1228931097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_532:
					num = (short)163184645;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1D6:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.Value;
				IL_372:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.Value;
				IL_52D:
				return radWideTransmitPowerLevelsTxPowerLevelHighW_A.Value >= txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.Value;
				IL_A7:
				txPowerLevelsByFrequencyRangeNewBandPlanInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInnerSection);
				radWideTransmitPowerLevelsTxPowerLevelHighW_A = txPowerLevelsByFrequencyRangeNewBandPlanInnerSection.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				radWideTransmitPowerLevelsTxPowerLevelConfigType_A = radioWide.TransmitPowerLevels.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;
				radInfoLabtoolH37G50Smartnet_A = radioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184;
				radInfoLabtoolH38G51Smartzone_A = radioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185;
				num = (short)725286934;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x002CD378 File Offset: 0x002CB578
		internal static bool ConIs7800BandVisibility(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1428881408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels transmitPowerLevels;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
							{
								num = (short)1806761993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 1:
							num = (short)1244594176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
							{
								return true;
							}
							num = (short)1841299328;
							short num3 = num;
							num = (short)119734144;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_119;
							default:
								num = (short)1514078208;
								if (num != 0)
								{
								}
								num = (short)1619853326;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (radInfoLabtoolPrimaryBands_A.Value != 1)
							{
								num = (short)2045837320;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 4:
							num = (short)1569456134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (radInfoLabtoolSecondaryBands_A.Value != 1)
							{
								num = (short)304676875;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 6:
							if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
							{
								num = (short)1447100434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 7:
							if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)941490191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_483;
						case 8:
							goto IL_483;
						case 9:
							num = (short)1793392653;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_230;
						case 11:
							goto IL_15A;
						case 12:
							num = (short)749469720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
							{
								num = (short)991494160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35E;
						case 14:
							goto IL_2C5;
						case 15:
							num = (short)806092801;
							if (num != 0)
							{
							}
							num = (short)520355843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
						{
							num = (short)432209920;
							short num4 = num;
							num = (short)123273238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
							{
								num = (short)35717121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 18:
							goto IL_35E;
						case 19:
							if (transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value)
							{
								num = (short)1448280076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_230;
						case 20:
							if (transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
							{
								num = (short)2057437205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15A;
						case 21:
							num = (short)863567877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
							{
								num = (short)2105409540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 23:
							num = (short)1412104209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							if (!transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value)
							{
								num = (short)715587594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 25:
							if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)1886715927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35E;
						}
						goto IL_97;
						IL_15A:
						num = (short)1154744339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_230:
						num = (short)96206850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_35E:
						num = (short)1612185607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_483:
						num = (short)1322975252;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C5:
					return transmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value == 1;
				}
				IL_97:
				transmitPowerLevels = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels);
				radInfoLabtoolPrimaryBands_A = transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoGeneralPrimaryFrequencyBand700_A = transmitPowerLevels.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = transmitPowerLevels.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				IL_119:
				num = (short)546308121;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x002CD8E0 File Offset: 0x002CBAE0
		internal static bool ConIsNewBandPlanSelOld(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1075344186;
			short num2 = num;
			num = (short)992441146;
			switch (num2 == num)
			{
			default:
			{
				num = (short)56229888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)536608769;
			if (num != 0)
			{
			}
			num = (short)2009989120;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value == 0;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x002CD9B0 File Offset: 0x002CBBB0
		internal static bool ConIsNewBandPlanSelNew(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)881906847;
			short num2 = num;
			num = (short)439997599;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1362558976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1193672705;
			if (num != 0)
			{
			}
			num = (short)44892160;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).TransmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value == 1;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x002CDA80 File Offset: 0x002CBC80
		internal static bool ConIs7800BandEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1928855552;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels transmitPowerLevels;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (radInfoLabtoolPrimaryBands_A.Value != 1)
							{
								num = (short)792788996;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 1:
							if (!transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value)
							{
								num = (short)940572673;
								if (num != 0)
								{
								}
								num = (short)245039106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 2:
							goto IL_22F;
						case 3:
							num = (short)499515397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_484;
						case 5:
							if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
							{
								num = (short)1411186696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 6:
							num = (short)1998782464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (radInfoLabtoolSecondaryBands_A.Value != 1)
							{
								num = (short)2035613714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 8:
							num = (short)484179989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_35D;
						case 10:
							if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)13828102;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_484;
						case 11:
							goto IL_2C4;
						case 12:
							num = (short)350748679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)664797204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!radInfoFrequencyRanges800MHzUsedinCodeplug_A)
							{
								num = (short)829292553;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 15:
							num = (short)1919287320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							num = (short)1707933710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value)
							{
								num = (short)1948712985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22F;
						case 18:
							goto IL_15A;
						case 19:
							if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)1243283471;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35D;
						case 20:
						{
							num = (short)1140129792;
							short num3 = num;
							if (!radInfoFrequencyRanges700MHzUsedinCodeplug_A)
							{
								num = (short)1099366416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						case 21:
							if (radInfoFrequencyRangesAllowInvalidFrequencies_A)
							{
								num = (short)2077622285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35D;
						case 22:
						{
							if (transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
							{
								return true;
							}
							num = (short)1827104835;
							short num4 = num;
							num = (short)1913808963;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_119;
							default:
								num = (short)340656128;
								if (num != 0)
								{
								}
								num = (short)1334444043;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 23:
							if (transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
							{
								num = (short)821297164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15A;
						case 24:
							if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
							{
								num = (short)662503427;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 25:
							num = (short)234160129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_97;
						IL_15A:
						num = (short)1339621393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_22F:
						num = (short)2071396374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_35D:
						num = (short)1041498122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_484:
						num = (short)807534615;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C4:
					return transmitPowerLevels.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.Value == 1;
				}
				IL_97:
				transmitPowerLevels = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TransmitPowerLevels);
				radInfoLabtoolPrimaryBands_A = transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = transmitPowerLevels.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoGeneralPrimaryFrequencyBand700_A = transmitPowerLevels.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = transmitPowerLevels.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = transmitPowerLevels.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				IL_119:
				num = (short)1499922451;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x002CDFE8 File Offset: 0x002CC1E8
		internal static bool ConDVRSIsEnAndRFModemApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!radioWide.Labtool.DVRSRangeExt_44809.Value)
					{
						num2 = (short)536477699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
				{
					num2 = (short)1487798273;
					if (num2 != 0)
					{
					}
					num2 = (short)1009580878;
					short num3 = num2;
					num2 = (short)417659726;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_173;
					default:
						num2 = (short)1275854848;
						if (num2 != 0)
						{
						}
						num2 = (short)1399914496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_173;
				case 3:
					goto IL_16E;
				case 4:
					if (features.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
					{
						num2 = (short)653787137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)568393730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_28;
				IL_173:
				num2 = (short)807272452;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16E:
			return features.RadWideAdvancedRFModem_A8972.Value != 0;
			IL_28:
			num2 = (short)163053568;
			short num4 = num2;
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			radioWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)800915461;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x002CE1B8 File Offset: 0x002CC3B8
		internal static bool ConDVRSIsEnAndRFModemValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)836304899;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num2)
				{
				case 0:
					goto IL_E5;
				case 1:
				{
					num = (short)1667366912;
					short num3 = num;
					goto IL_A3;
				}
				case 2:
					if (!radioWide.Labtool.DVRSRangeExt_44809.Value)
					{
						num = (short)964100096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E7;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				radioWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				if (features.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
				{
					num = (short)76480513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_E7;
				IL_A3:
				num = (short)799735810;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E7:
				num = (short)70451201;
				if (num != 0)
				{
				}
				num = (short)1975341153;
				short num4 = num;
				num = (short)2134724705;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A3;
				default:
					goto IL_144;
				}
			}
			IL_E5:
			return index == 0;
			IL_144:
			num = (short)464125952;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x002CE324 File Offset: 0x002CC524
		public static bool ConInvisibleWhenOpenfromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)432340993;
			if (num != 0)
			{
			}
			num = (short)604045312;
			short num2 = num;
			num = (short)2030007614;
			short num3 = num;
			num = (short)312964414;
			switch (num3 == num)
			{
			}
			num = (short)311099392;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x002CE3D4 File Offset: 0x002CC5D4
		internal static bool ConAudibleEmergencyBeaconRoutingApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)958895741;
			short num2 = num;
			num = (short)657036925;
			switch (num2 == num)
			{
			default:
			{
				num = (short)235929600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1980628993;
			if (num != 0)
			{
			}
			num = (short)1567817728;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TPS).RadWideTPSAudibleEmergencyBeaconsec_A7502.Value != 0;
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x002CE490 File Offset: 0x002CC690
		internal static bool ConBluetoothPANCOTSEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1103364097;
			if (num != 0)
			{
			}
			num = (short)1211760640;
			short num2 = num;
			num = (short)1106928042;
			short num3 = num;
			num = (short)1889231274;
			switch (num3 == num)
			{
			}
			num = (short)595853312;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth;
			global::AcpBusinessLayer.AcpListField radWideBluetoothBluetoothPairingType_A = bluetooth.RadWideBluetoothBluetoothPairingType_A37036;
			bool flag = radWideBluetoothBluetoothPairingType_A.Value == 2 || radWideBluetoothBluetoothPairingType_A.Value == 3;
			return bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value && flag;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x002CE56C File Offset: 0x002CC76C
		internal static bool ConBluetoothPANNetworkBaseAddressValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Net.IPAddress ipaddress;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_FD;
				case 1:
				{
					num2 = (short)1360920577;
					if (num2 != 0)
					{
					}
					num2 = (short)719135512;
					short num3 = num2;
					num2 = (short)186655512;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DA;
					default:
						goto IL_137;
					}
					break;
				}
				case 2:
					goto IL_DA;
				case 3:
					if (!global::ConstraintHelper.UtilityMack.CheckIPConflictionWithZoneCloneFeature(ipaddress))
					{
						num2 = (short)2091974657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)346423298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
				IL_DA:
				if (ipaddress.GetAddressBytes()[3] == 1)
				{
					goto IL_14E;
				}
				num2 = (short)792068096;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_FD:
			num2 = (short)332988416;
			short num4 = num2;
			return false;
			IL_137:
			num2 = (short)1874984960;
			if (num2 != 0)
			{
			}
			return false;
			IL_14E:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
			return global::ConstraintHelper.UtilityMack.CheckIPConflictionWithAllIPs(bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983);
			IL_20:
			bluetooth = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth);
			global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
			ipaddress = new global::System.Net.IPAddress(bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.Value);
			num2 = (short)868679683;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x002CE6D4 File Offset: 0x002CC8D4
		internal static void ConValueSetterAttachedNewMuteTones(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)602733208;
			short num2 = num;
			num = (short)838400664;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1606483968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)448200705;
			if (num != 0)
			{
			}
			num = (short)1554513920;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones alertTones = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesMuteTonesOperation_A = alertTones.RadProfAlertTonesMuteTonesOperation_A8562;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesNewMuteTonesOperation_A = alertTones.RadProfAlertTonesNewMuteTonesOperation_A42149;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesEnhancedMuteTonesOperation_A = alertTones.RadProfAlertTonesEnhancedMuteTonesOperation_A42150;
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x002CE794 File Offset: 0x002CC994
		internal static void ConValueSetterAttachedEnhancedMuteTones(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones alertTones = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesMuteTonesOperation_A = alertTones.RadProfAlertTonesMuteTonesOperation_A8562;
			global::AcpBusinessLayer.AcpListField radProfAlertTonesNewMuteTonesOperation_A = alertTones.RadProfAlertTonesNewMuteTonesOperation_A42149;
			switch (alertTones.RadProfAlertTonesEnhancedMuteTonesOperation_A42150.Value)
			{
			case 0:
				break;
			case 1:
			{
				short num = (short)1052309270;
				short num2 = num;
				num = (short)678819606;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)432013313;
					if (num != 0)
					{
					}
					num = (short)455540736;
					if (num != 0)
					{
					}
					num = (short)58851328;
					short num3 = num;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesMuteTonesOperation_A, 1));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 0));
					return;
				}
				}
				break;
			}
			case 2:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesMuteTonesOperation_A, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 1));
				return;
			case 3:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesMuteTonesOperation_A, 3));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 15));
				return;
			default:
				return;
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesMuteTonesOperation_A, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 0));
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x002CE8E4 File Offset: 0x002CCAE4
		internal static void ConValueSetterAttachedOldMuteTones(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)507117568;
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
				int value;
				global::AcpBusinessLayer.AcpListField radProfAlertTonesEnhancedMuteTonesOperation_A;
				global::AcpBusinessLayer.AcpListField radProfAlertTonesNewMuteTonesOperation_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)1805975553;
						if (num != 0)
						{
						}
						num = (short)1412095941;
						short num3 = num;
						num = (short)961470405;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FF;
						default:
							goto IL_190;
						}
						break;
					}
					case 1:
						return;
					case 2:
						switch (value)
						{
						case 0:
							goto IL_B9;
						case 1:
							goto IL_9E;
						case 2:
							return;
						case 3:
							goto IL_FF;
						default:
							num = (short)733413377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					goto IL_3B;
					IL_FF:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesEnhancedMuteTonesOperation_A, 3));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 15));
					num = (short)1986396160;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_9E:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesEnhancedMuteTonesOperation_A, 1));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 0));
				return;
				IL_B9:
				num = (short)1920532480;
				short num4 = num;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesEnhancedMuteTonesOperation_A, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAlertTonesNewMuteTonesOperation_A, 0));
				return;
				IL_190:
				num = (short)1993867264;
				if (num != 0)
				{
				}
				return;
				IL_3B:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones alertTones = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.AlertTones;
				global::AcpBusinessLayer.AcpListField radProfAlertTonesMuteTonesOperation_A = alertTones.RadProfAlertTonesMuteTonesOperation_A8562;
				radProfAlertTonesNewMuteTonesOperation_A = alertTones.RadProfAlertTonesNewMuteTonesOperation_A42149;
				radProfAlertTonesEnhancedMuteTonesOperation_A = alertTones.RadProfAlertTonesEnhancedMuteTonesOperation_A42150;
				value = radProfAlertTonesMuteTonesOperation_A.Value;
				num = (short)341049346;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x002CEA98 File Offset: 0x002CCC98
		internal static bool ConLabtoolVisibleOnly(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)301498529;
			short num2 = num;
			num = (short)696549537;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2089222144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)19202049;
			if (num != 0)
			{
			}
			num = (short)57212928;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06002DD4 RID: 11732 RVA: 0x002CEB44 File Offset: 0x002CCD44
		public static bool conReturnTrueIfViewSetToLabtoolOrDepot(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			if (global::AcpCommonLib.AppInfoManager.AppView != global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
			{
				num = (short)293314508;
				short num2 = num;
				num = (short)693608396;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1247019008;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)952041473;
			if (num != 0)
			{
			}
			num = (short)1400635392;
			short num3 = num;
			return true;
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x002CEBFC File Offset: 0x002CCDFC
		internal static bool ConDualRadioSystemEnableApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2089509901;
			short num2 = num;
			num = (short)1261593613;
			switch (num2 == num)
			{
			default:
			{
				num = (short)880345088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)177799168;
			if (num != 0)
			{
			}
			num = (short)1622802433;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio).RadWideDualRadioSelection_A42236.Value != 0;
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x002CECB8 File Offset: 0x002CCEB8
		internal static bool ConDualRadioSystemIsPrimaryApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio dualRadio;
			for (;;)
			{
				IL_00:
				short num = (short)1385562112;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_E0;
					}
					string id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY;
					string id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY;
					string id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY;
					for (;;)
					{
						IL_29:
						switch (num2)
						{
						case 0:
							num = (short)851116033;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)1145962525;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_34A;
						case 1:
							num = (short)2135031822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_3B9;
						case 3:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)719061012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)332464149;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AE;
						case 5:
							goto IL_6BF;
						case 6:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)155975695;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_260;
						case 7:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)1337262098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)414187544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D5;
						case 9:
							goto IL_3B4;
						case 10:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)1836974106;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D5;
						case 11:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)1627979799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6BF;
						case 12:
							goto IL_5FD;
						case 13:
							if (dualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 1)
							{
								num = (short)329711658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)959381539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)1431109639;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_78F;
						case 15:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)224526368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY);
							num = (short)378798107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY);
							num = (short)1696530444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_78F;
						case 19:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)824311833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D5;
						case 20:
							goto IL_2F3;
						case 21:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)952631324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							goto IL_345;
						case 23:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)414056453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY);
							num = (short)379256870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)1688010752;
							short num3 = num;
							num = (short)613941270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 26:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)2046754825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_21B;
						case 28:
							goto IL_1AE;
						case 29:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY);
							num = (short)1797521445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)145031204;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B9;
						case 31:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)696516625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5FD;
						case 32:
							goto IL_260;
						case 33:
							if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)7340048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_21B;
						case 34:
							num = (short)565444647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							if (dualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
							{
								num = (short)1037500417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D5;
						case 36:
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY);
							num = (short)343146498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_34A;
						case 38:
							goto IL_5D2;
						case 39:
							if (dualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 0)
							{
								num = (short)1444479019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1353580557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY))
							{
								num = (short)1951793155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D5;
						case 41:
							if (dualRadio.RadWideDualRadioSelection_A42236.Value == 1)
							{
								num = (short)692846626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1375797248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							num = (short)2138898462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							num = (short)704446497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_1AE:
						num = (short)1893466131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_21B:
						num = (short)1417805828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_260:
						num = (short)1718419464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34A:
						num = (short)1280245771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B9:
						num = (short)1368309754;
						short num4 = num;
						num = (short)170246138;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1351286784;
							if (num != 0)
							{
							}
							num = (short)620363807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5FD:
						num = (short)1210843176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6BF:
						num = (short)2040004618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_78F:
						num = (short)610336774;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_E0:
					dualRadio = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio);
					id_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY = global::CommonResources.AcgResources.ID_EMERGENCYTRANSMITWILLBEHANDLEDBYTHESELECTEDRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFBOTHRADIOSTOENSUREPROPERFUNCTIONALITY;
					id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY = global::CommonResources.AcgResources.ID_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHEPRIMARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHEPRIMARYRADIOTOENSUREPROPERFUNCTIONALITY;
					id_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY = global::CommonResources.AcgResources.ID_ALLEMERGENCYTRANSMITWILLBEHANDLEDBYTHESECONDARYRADIOPLEASEENABLEEMERGENCYOPERATIONVIATHECONVENTIONALSYSTEMEMERGENCYPROFILESELECTIONONALLCHANNELSOFTHESECONDARYRADIOTOENSUREPROPERFUNCTIONALITY;
					num = (short)181665833;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			IL_2F3:
			IL_345:
			IL_3B4:
			IL_5D2:
			IL_7D5:
			return dualRadio.RadWideDualRadioSelection_A42236.Value == 1;
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x002CF4A8 File Offset: 0x002CD6A8
		internal static bool ConDualRadioSystemIsSecondaryApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)639791266;
			short num2 = num;
			num = (short)1959096482;
			switch (num2 == num)
			{
			}
			num = (short)670171137;
			if (num != 0)
			{
			}
			num = (short)1592590336;
			short num3 = num;
			num = (short)554762240;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio).RadWideDualRadioSelection_A42236.Value == 2;
		}

		// Token: 0x06002DD8 RID: 11736 RVA: 0x002CF564 File Offset: 0x002CD764
		internal static void ConSetMultiRadioSystemEnable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio dualRadio;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (dualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)162136067;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(dualRadio.MultiRadioSystemEnable_A42248, false));
					num2 = (short)1768423425;
					if (num2 != 0)
					{
					}
					num2 = (short)1545076740;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1183186944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)947216773;
					short num3 = num2;
					num2 = (short)685597061;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)1959854080;
						if (num2 != 0)
						{
						}
						if (dualRadio != null)
						{
							num2 = (short)1956708353;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
					goto IL_179;
				case 4:
					goto IL_FD;
				}
				goto IL_24;
			}
			IL_FD:
			return;
			IL_179:
			num2 = (short)1157562368;
			short num4 = num2;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(dualRadio.MultiRadioSystemEnable_A42248, true));
			return;
			IL_24:
			dualRadio = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio);
			num2 = (short)1852833794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x002CF6EC File Offset: 0x002CD8EC
		internal static bool ConDualRadioSystemIsNOTSecondaryApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_11E;
				case 1:
				{
					if (self.ParentRecset.IsEmbeddedRecset)
					{
						num2 = (short)926810115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					radioWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num2 = (short)1201405952;
					short num3 = num2;
					num2 = (short)1923809280;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_14E;
				case 3:
					num2 = (short)481755137;
					if (num2 != 0)
					{
					}
					radioWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num2 = (short)1675034626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_11E:
			goto IL_150;
			IL_20:
			num2 = (short)1460574286;
			short num4 = num2;
			num2 = (short)1820563534;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14E:
				break;
			default:
			{
				num2 = (short)208601088;
				if (num2 != 0)
				{
				}
				radioWide = null;
				num2 = (short)1077346305;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_150:
			return radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x002CF860 File Offset: 0x002CDA60
		internal static bool ConIgnitionSwitchValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)692518915;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					num = (short)1796669442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)1438205174;
					short num3 = num;
					num = (short)783238390;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)1264648192;
						if (num != 0)
						{
						}
						if (index != 38)
						{
							num = (short)1329266692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 3:
					goto IL_15;
				case 4:
					num = (short)1658322945;
					if (num != 0)
					{
					}
					num = (short)270794757;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (index != 71)
					{
						num = (short)217579520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				goto IL_3D;
				IL_15:
				switch (0)
				{
				case 0:
				{
					IL_3D:
					num = (short)1245315072;
					short num4 = num;
					if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236 != 2)
					{
						return true;
					}
					num = (short)1179516929;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_D9:
			return index == 27;
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x002CF9F8 File Offset: 0x002CDBF8
		internal static bool ConRadWideURCIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern lightbarPattern;
			short num;
			for (;;)
			{
				lightbarPattern = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				num = (short)1400373248;
				short num2 = num;
				num = (short)2030757788;
				short num3 = num;
				num = (short)850847644;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_88;
				}
			}
			IL_88:
			num = (short)104071169;
			if (num != 0)
			{
			}
			num = (short)661258240;
			if (num != 0)
			{
			}
			return !lightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x002CFAD8 File Offset: 0x002CDCD8
		internal static bool ConRadWideURCIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern lightbarPattern;
			short num;
			for (;;)
			{
				lightbarPattern = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LightbarPattern);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				num = (short)39583744;
				short num2 = num;
				num = (short)348203429;
				short num3 = num;
				num = (short)1093282213;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			IL_87:
			num = (short)1884684289;
			if (num != 0)
			{
			}
			num = (short)149815296;
			if (num != 0)
			{
			}
			return lightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x002CFBB8 File Offset: 0x002CDDB8
		internal static bool ConRadWideRadioLockIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
			short num;
			for (;;)
			{
				userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				num = (short)826277888;
				short num2 = num;
				num = (short)630510135;
				short num3 = num;
				num = (short)213176887;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_88;
				}
			}
			IL_88:
			num = (short)399179777;
			if (num != 0)
			{
			}
			num = (short)1560084480;
			if (num != 0)
			{
			}
			return userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value;
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x002CFC98 File Offset: 0x002CDE98
		internal static bool conSetOutputMesgForDisableSecodaryRadioTx(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num;
			string id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES;
			short num2;
			string id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio dualRadio;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES);
					num2 = (short)479002638;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES))
					{
						num2 = (short)2084896783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_199;
				case 2:
					goto IL_16C;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO))
					{
						num2 = (short)1691156488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_199;
				case 5:
					return true;
				case 6:
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO))
					{
						num2 = (short)1998127115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO))
					{
						num2 = (short)356384785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B4;
				case 8:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO);
					num2 = (short)1365901317;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_2B4;
				case 10:
					num2 = (short)660406279;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO);
					num2 = (short)1561460757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!dualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.Value)
					{
						num2 = (short)449970186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1404108820;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)2108555276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					return true;
				case 15:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES);
					num2 = (short)798228484;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES);
					num2 = (short)1678639106;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO);
					num2 = (short)740229129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1226702849;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES))
					{
						num2 = (short)884736000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 19:
				{
					if (dualRadio.RadWideDualRadioSelection_A42236.Value != 2)
					{
						num2 = (short)871497729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)221125002;
					short num3 = num2;
					num2 = (short)1693456778;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16C;
					default:
						num2 = (short)1719795712;
						if (num2 != 0)
						{
						}
						num2 = (short)289669133;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 20:
					if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES))
					{
						num2 = (short)501022736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_344;
				case 21:
					return true;
				}
				goto IL_68;
				IL_199:
				num2 = (short)527761411;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B4:
				num2 = (short)1234698258;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_344:
				num2 = (short)112984064;
				short num4 = num2;
				num2 = (short)929890310;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_16C:
				goto IL_344;
			}
			return true;
			IL_68:
			id_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO = global::CommonResources.AcgResources.ID_SECONDARYRADIOTRANSMITISDISABLEDONLYRECEIVEFEATURESWILLBEFUNCTIONALINTHESECONDARYRADIO;
			id_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES = global::CommonResources.AcgResources.ID_SECONDARYRADIOTRANSMITISENABLEDTHESECONDARYRADIOWILLHAVEFULLRXTXCAPABILITIES;
			dualRadio = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DualRadio);
			num2 = (short)1012924435;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x002D00C0 File Offset: 0x002CE2C0
		internal static bool conIsTargetZoneChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1399635634;
			short num2 = num;
			num = (short)985579186;
			switch (num2 == num)
			{
			}
			num = (short)1657602049;
			if (num != 0)
			{
			}
			num = (short)1290928128;
			short num3 = num;
			num = (short)705298432;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadWideFeaturesChanChangeOnOffHookEnable_A42354.Value;
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x002D0178 File Offset: 0x002CE378
		internal static bool conIsTargetZoneValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1121517568;
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
				global::AcpBusinessLayer.AcpField<bool> acpField;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				bool result;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (acpField.Value)
						{
							num = (short)490078215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						goto IL_245;
					case 2:
						num = (short)1958608901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (index >= 0)
						{
							num = (short)1302069250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (zoneChannelAssignment != null)
						{
							num = (short)1319370769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						if (index > acpRecRefField.RefRecset.Count)
						{
							num = (short)284885005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						zoneChannelAssignment = (acpRecRefField.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
						num = (short)1791688705;
						if (num != 0)
						{
						}
						num = (short)664469508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_3F5;
					case 7:
						return false;
					case 8:
						num = (short)1840513046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1953955863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (acpRecRefField != null)
						{
							num = (short)1403256841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						if (zoneChannelAssignment.RSI != null)
						{
							num = (short)453115912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 12:
						if (zoneChannelAssignment.Zone != null)
						{
							num = (short)2101149716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 13:
						goto IL_45D;
					case 14:
						num = (short)1764294656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						acpField = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features)self).RadWideFeaturesChanChangeOnOffHookEnable_A42354;
						acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features)self).RadWideFeaturesTargetZoneOnOffHook_A42355;
						num = (short)1046020097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_2D5;
					case 17:
						num = (short)1717370892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						result = false;
						num = (short)23003155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_297;
					case 20:
						num = (short)170917899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						if (!(self is global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features))
						{
							goto IL_245;
						}
						num = (short)480065901;
						short num3 = num;
						num = (short)204159341;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3F5;
						default:
							num = (short)2020474880;
							if (num != 0)
							{
							}
							num = (short)26869775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 22:
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)870187026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 23:
						if (acpField == null)
						{
							num = (short)1768423440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)283312134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_3F5:
					if (index == 0)
					{
						num = (short)1908867086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)648216576;
					short num4 = num;
					num = (short)1386283011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_245:
					num = (short)1279066122;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_297:
				return result;
				IL_2D5:
				return true;
				IL_45D:
				return true;
				IL_8F:
				result = true;
				acpField = null;
				acpRecRefField = null;
				zoneChannelAssignment = null;
				num = (short)1510342677;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x002D05E8 File Offset: 0x002CE7E8
		internal static bool conIsTargetChannelValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
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
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
					if (features.RadWideFeaturesTargetZoneOnOffHook_A42355.Value == 0)
					{
						num2 = (short)1343946754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					if (index == 0)
					{
						num2 = (short)326369283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					goto IL_13D;
				case 3:
					num2 = (short)1361707008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return false;
			IL_20:
			num2 = (short)632954857;
			short num3 = num2;
			num2 = (short)2014060521;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_13D:
				num2 = (short)1067122688;
				short num4 = num2;
				return true;
			}
			default:
			{
				num2 = (short)1876164609;
				if (num2 != 0)
				{
				}
				num2 = (short)308281344;
				if (num2 != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				num2 = (short)1487732737;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x002D0738 File Offset: 0x002CE938
		internal static bool conIsTargetChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
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
					goto IL_78;
				case 1:
					num2 = (short)1956315139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)1669595140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)719060999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				}
				case 4:
					num2 = (short)395116550;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment == null)
					{
						num2 = (short)911802368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)734265346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone != null)
					{
						num2 = (short)28573697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				}
				case 7:
					return false;
				}
				goto IL_30;
			}
			IL_78:
			num2 = (short)771197816;
			short num3 = num2;
			num2 = (short)1607568248;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_30:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = features.RadWideFeaturesTargetZoneOnOffHook_A42355.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
				num2 = (short)359792645;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)1884422145;
				if (num2 != 0)
				{
				}
				num2 = (short)1200750592;
				if (num2 != 0)
				{
				}
				return false;
			}
			return false;
			IL_1B2:
			num2 = (short)510590976;
			short num4 = num2;
			return features.RadWideFeaturesChanChangeOnOffHookEnable_A42354.Value;
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x002D092C File Offset: 0x002CEB2C
		internal static bool ConLocEnOrDisplayPeerLocationIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)607780864;
			short num2 = num;
			num = (short)508191170;
			short num3 = num;
			num = (short)945054146;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)694484993;
				if (num != 0)
				{
				}
				num = (short)1239482368;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location location = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location;
				if (!location.RadWideLocationLocationEnable_A8448.Value)
				{
					return location.RadWideLocationDisplayPeerLocation_42433.Value;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x002D09F8 File Offset: 0x002CEBF8
		public static void conAudioConfigurationLevelValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 10;
			short num = (short)1956970496;
			short num2 = num;
			num = (short)1748369408;
			switch (num)
			{
			default:
			{
				num = (short)1222180866;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num3)
					{
					case 0:
						if (feature != null)
						{
							num = (short)714276869;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						num = (short)2109527191;
						short num4 = num;
						num = (short)1519113367;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A5;
						default:
							goto IL_8E5;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (feature as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesRecset).GetEnumerator();
						num = (short)994115588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)478019585;
						if (num != 0)
						{
						}
						try
						{
							num = (short)35717120;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
								global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_11A;
									}
									continue;
								case 1:
									if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_)))
									{
										num = (short)995426315;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_39C;
								case 2:
									if (labtoolRAD_PROF_CDA != null)
									{
										num = (short)14221324;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (audioSettings != null)
									{
										num = (short)1107820553;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_7FD;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)110428168;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									audioSettings = null;
									labtoolRAD_PROF_CDA = null;
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = featureNode.FeatureSectionsCollection.GetEnumerator();
									num = (short)1882718215;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									try
									{
										num = (short)651755522;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num3)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)765657097;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator2.Current;
												num = (short)299958273;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												if (featureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings)))
												{
													num = (short)164823046;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)129040388;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1E5;
												}
												continue;
											case 3:
												goto IL_32A;
											case 4:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												if (featureSection.GetType().Equals(typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA)))
												{
													num = (short)1088094216;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												audioSettings = (featureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
												num = (short)1271988229;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
											{
												global::AcpBusinessLayer.FeatureSection featureSection;
												labtoolRAD_PROF_CDA = (featureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
												num = (short)470417415;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 9:
												num = (short)1902837763;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_207:
											num = (short)1868234752;
											num3 = (int)((global::System.IntPtr)num);
											continue;
											IL_1E5:
											goto IL_207;
										}
										IL_32A:
										goto IL_63C;
									}
									finally
									{
										num = (short)439746560;
										num3 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num3)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_362;
												}
												continue;
											case 1:
												goto IL_399;
											case 2:
												enumerator2.Dispose();
												num = (short)38666241;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_362:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1954283522;
											num3 = (int)((global::System.IntPtr)num);
										}
										IL_399:;
									}
									goto IL_39C;
									IL_63C:
									num = (short)1473183747;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)809959428;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)1577713666;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AudioEqualizationGroupSettingRadio_42604, audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506, audioSettings.AnalogLowFrequencyBandAccessory_42647.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandRadio_42648, audioSettings.AnalogMidFrequencyBandAccessory_42649.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, audioSettings.AnalogHighFrequencyBandAccessory_42650.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507, audioSettings.DigitalLowFrequencyBandAccessory_42652.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandRadio_42653, audioSettings.DigitalMidFrequencyBandAccessory_42654.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, audioSettings.DigitalHighFrequencyBandAccessory_42655.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508, audioSettings.SecurenetLowFrequencyBandAccessory_42657.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandRadio_42658, audioSettings.SecurenetMidFrequencyBandAccessory_42659.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, audioSettings.SecurenetHighFrequencyBandAccessory_42660.Value));
									num = (short)1193082886;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.GainSensitivityGroupSettingAccessory_42610, audioSettings.GainSensitivityGroupSettingRadio_42608.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsAnalogAGC2_A7439, audioSettings.RadProfAudioSettingsAnalogAGC1_A7440.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsDigitalAGC2_A7853, audioSettings.RadProfAudioSettingsDigitalAGC1_A7854.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsSecurenetAGC2_A9098, audioSettings.RadProfAudioSettingsSecurenetAGC1_A9099.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalogFixedGain2_A7441, audioSettings.RadProfAudioSettingsAnalogFixedGain1_A7442.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigitalFixedGain2_A7855, audioSettings.RadProfAudioSettingsDigitalFixedGain1_A7856.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenetFixedGain2_A9101, audioSettings.RadProfAudioSettingsSecurenetFixedGain1_A9100.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AGCGainControlOutputAccessory_42644, audioSettings.RadProfAudioSettingsOutput_A8679.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AGCGainControlTotalAccessory_42645, audioSettings.RadProfAudioSettingsTotal_A9394.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661, audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.Value));
									num = (short)1518272513;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11F:
								num = (short)1080885253;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_11A:
								goto IL_11F;
								IL_39C:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AudioEqualizationGroupSettingAccessory_42605, audioSettings.AudioEqualizationGroupSettingRadio_42604.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogLowFrequencyBandAccessory_42647, labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandAccessory_42649, audioSettings.AnalogMidFrequencyBandRadio_42648.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, audioSettings.RadProfAudioSettingsAnalog_A7438.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalLowFrequencyBandAccessory_42652, labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandAccessory_42654, audioSettings.DigitalMidFrequencyBandRadio_42653.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, audioSettings.RadProfAudioSettingsDigital_A7850.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetLowFrequencyBandAccessory_42657, labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandAccessory_42659, audioSettings.SecurenetMidFrequencyBandRadio_42658.Value));
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, audioSettings.RadProfAudioSettingsSecurenet_A9097.Value));
								num = (short)858259466;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_7FD:
							return;
						}
						finally
						{
							num = (short)823459840;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_835;
									}
									continue;
								case 1:
									goto IL_86B;
								case 2:
									enumerator.Dispose();
									num = (short)199819265;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_835:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1450049538;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_86B:;
						}
						goto IL_86E;
					case 5:
						goto IL_86E;
					case 6:
						if (feature.Count != 0)
						{
							num = (short)1478688771;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_90;
					IL_A5:
					num = (short)991232001;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions).RadWideAudioConfigurationLevel_42740.Value != 0)
					{
						goto IL_A5;
					}
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2077);
					num = (short)290390016;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_86E:
					num = (short)70254598;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_8E5:
				num = (short)1511718912;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x002D13D0 File Offset: 0x002CF5D0
		internal static void ConSynVHFUHFPreAmpValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 5;
			short num = (short)1124204545;
			if (num != 0)
			{
			}
			num = (short)690028544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::AcpBusinessLayer.AcpField<bool> radWideAdvancedPreAmp_A;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpUHF_A;
				bool flag2;
				for (;;)
				{
					IL_57:
					bool flag;
					switch (num2)
					{
					case 0:
					{
						num = (short)1222770688;
						short num3 = num;
						num = (short)2117992453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (radWideAdvancedPreAmp_A.Value == radWideFeaturePreAmpVHF_A.Value)
						{
							num = (short)1721171968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1251868675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_209;
					case 3:
						flag = true;
						goto IL_20B;
					case 4:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideFeaturePreAmpVHF_A, radWideAdvancedPreAmp_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideFeaturePreAmpUHF_A, radWideAdvancedPreAmp_A.Value));
						num = (short)1995374594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						flag = (radWideAdvancedPreAmp_A.Value != radWideFeaturePreAmpUHF_A.Value);
						goto IL_20B;
					}
					break;
					IL_20B:
					if (!flag || !flag2)
					{
						return;
					}
					num = (short)821559300;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_76:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				radWideAdvancedPreAmp_A = features.RadWideAdvancedPreAmp_A8733;
				radWideFeaturePreAmpVHF_A = features.RadWideFeaturePreAmpVHF_A42960;
				radWideFeaturePreAmpUHF_A = features.RadWideFeaturePreAmpUHF_A42962;
				int num4 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("蟅飇鋉﯍", a_)) ? 1 : 0;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
				bool value = radioInformation.Labtool.RadInfoLabtoolW12Preamp_A9671.Value;
				flag2 = (num4 == 0 && value);
				num = (short)1941525602;
				short num5 = num;
				num = (short)1118458978;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_209:
					break;
				default:
					num = (short)899874816;
					if (num != 0)
					{
					}
					num = (short)128188417;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_57;
				}
				return;
			}
			}
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x002D1624 File Offset: 0x002CF824
		internal static void ConSynPreAmpValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 10;
			short num = (short)4653056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)200040842;
				short num3 = num;
				num = (short)600138122;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_161:
					num = (short)1799749634;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)402784256;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_BF;
					}
					break;
				}
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpUHF_A;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturePreAmpVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radWideAdvancedPreAmp_A;
				for (;;)
				{
					IL_7C:
					switch (num2)
					{
					case 0:
					{
						bool flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_));
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0];
						bool value = radioInformation.Labtool.RadInfoLabtoolW12Preamp_A9671.Value;
						if (flag && value)
						{
							num = (short)14745607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_324;
					case 2:
						if (!radWideFeaturePreAmpUHF_A.Value)
						{
							num = (short)1353842698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_35F;
					case 4:
						if (!radWideFeaturePreAmpVHF_A.Value)
						{
							num = (short)436273166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						num = (short)1509687308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)262406144;
						short num4 = num;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideAdvancedPreAmp_A, false));
						num = (short)1482620937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1332609032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!radWideFeaturePreAmpVHF_A.Value)
						{
							num = (short)714145797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 9:
						goto IL_294;
					case 10:
						num = (short)1522860043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (radWideAdvancedPreAmp_A.Value)
						{
							num = (short)1436811270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						if (radWideFeaturePreAmpUHF_A.Value)
						{
							num = (short)1158742017;
							if (num != 0)
							{
							}
							num = (short)1109983233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					case 13:
						if (!radWideAdvancedPreAmp_A.Value)
						{
							num = (short)101646339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A2;
					case 14:
						goto IL_1DE;
					}
					goto IL_BF;
					IL_1A2:
					num = (short)692191236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num = (short)1888747533;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DE:
				goto IL_161;
				IL_294:
				return;
				IL_35F:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideAdvancedPreAmp_A, true));
				return;
				IL_BF:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features;
				radWideAdvancedPreAmp_A = features.RadWideAdvancedPreAmp_A8733;
				radWideFeaturePreAmpVHF_A = features.RadWideFeaturePreAmpVHF_A42960;
				radWideFeaturePreAmpUHF_A = features.RadWideFeaturePreAmpUHF_A42962;
				num = (short)1457651712;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x002D1994 File Offset: 0x002CFB94
		internal static bool ConMultiBandAvai(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 1;
			short num;
			bool result;
			for (;;)
			{
				IL_09:
				num = (short)1923481600;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					bool flag3;
					bool flag4;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
						{
							bool radInfoLabtoolQA00570VHF_A37151Value;
							bool radInfoLabtoolQA00571UHFRange1_A42594Value;
							bool radInfoLabtoolQA00572UHFRange2_A42595Value;
							bool value;
							if (global::System.Convert.ToInt32(radInfoLabtoolQA00570VHF_A37151Value) + global::System.Convert.ToInt32(radInfoLabtoolQA00571UHFRange1_A42594Value) + global::System.Convert.ToInt32(radInfoLabtoolQA00572UHFRange2_A42595Value) + global::System.Convert.ToInt32(value) <= 1)
							{
								num = (short)1072496649;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool;
							bool radInfoLabtoolQA00570VHF_A37151Value = labtool.RadInfoLabtoolQA00570VHF_A37151Value;
							bool radInfoLabtoolQA00571UHFRange1_A42594Value = labtool.RadInfoLabtoolQA00571UHFRange1_A42594Value;
							bool radInfoLabtoolQA00572UHFRange2_A42595Value = labtool.RadInfoLabtoolQA00572UHFRange2_A42595Value;
							bool value = global::System.Convert.ToBoolean(labtool.RadInfoLabtoolQA00569_7800MHZ_A42596Value);
							num = (short)1273626624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							bool flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("菁铃黅ￇ韛ﳋﻍ", a_));
							bool flag2 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("菁铃黅ￇ韛ﳋﻍ裏韑", a_));
							flag3 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("菁铃黅韛ﳋﻍ", a_));
							flag4 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("菁铃黅韛ﳋﻍ裏韑", a_));
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							if (flag || flag2)
							{
								num = (short)1353121797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BE;
						}
						case 3:
							goto IL_1BE;
						case 4:
						{
							result = false;
							num = (short)298647552;
							short num3 = num;
							num = (short)1901985795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)602603526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							if (radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988Value == 0)
							{
								num = (short)1323499524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BE;
						}
						case 7:
						{
							if (!flag3 && !flag4)
							{
								return result;
							}
							num = (short)1112930671;
							short num4 = num;
							num = (short)618330479;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)493551616;
								if (num != 0)
								{
								}
								num = (short)286588929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_2A6;
						case 9:
							result = false;
							num = (short)943521800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_1BE:
						num = (short)1150418951;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_5F:
					result = true;
					flag3 = false;
					flag4 = false;
					num = (short)922484738;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			IL_2A6:
			num = (short)1509556225;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x002D1CBC File Offset: 0x002CFEBC
		public static bool ConExtRFRouteBandSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 10;
			short num = (short)119144448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_153;
				}
				bool flag;
				bool flag2;
				bool result;
				for (;;)
				{
					IL_30:
					num = (short)480301141;
					short num3 = num;
					num = (short)173592661;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)458489856;
						short num4 = num;
						num = (short)180813824;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							int radInfoLabtoolSecondaryBands_A23988Value;
							if (radInfoLabtoolSecondaryBands_A23988Value != 8)
							{
								num = (short)510459936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 1:
						{
							int radInfoLabtoolSecondaryBands_A23988Value;
							if (radInfoLabtoolSecondaryBands_A23988Value != 4)
							{
								num = (short)1021575197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 2:
							num = (short)751239203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_24B;
						case 4:
							if (flag || flag2)
							{
								num = (short)857931787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
						{
							bool flag3;
							if (!flag3)
							{
								num = (short)1414922266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 6:
						{
							int radInfoLabtoolPrimaryBands_A23987Value;
							if (radInfoLabtoolPrimaryBands_A23987Value != 1)
							{
								num = (short)200343582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 7:
							num = (short)1223098402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							bool radInfoLabtoolQA00570VHF_A37151Value;
							if (!radInfoLabtoolQA00570VHF_A37151Value)
							{
								num = (short)1657405471;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 9:
						{
							int radInfoLabtoolPrimaryBands_A23987Value;
							if (radInfoLabtoolPrimaryBands_A23987Value != 8)
							{
								num = (short)1334509601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 10:
							return result;
						case 11:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool;
							bool radInfoLabtoolQA00570VHF_A37151Value = labtool.RadInfoLabtoolQA00570VHF_A37151Value;
							bool radInfoLabtoolQA00571UHFRange1_A42594Value = labtool.RadInfoLabtoolQA00571UHFRange1_A42594Value;
							bool radInfoLabtoolQA00572UHFRange2_A42595Value = labtool.RadInfoLabtoolQA00572UHFRange2_A42595Value;
							bool flag3 = global::System.Convert.ToBoolean(labtool.RadInfoLabtoolQA00569_7800MHZ_A42596Value);
							num = (short)1064828968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							bool flag4 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_));
							bool flag5 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎臘黚", a_));
							flag = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_));
							flag2 = global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("諊鷌韎臘黚", a_));
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
							if (flag4 || flag5)
							{
								num = (short)932642830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 13:
							num = (short)1895628837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
							int radInfoLabtoolPrimaryBands_A23987Value = radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987Value;
							int radInfoLabtoolSecondaryBands_A23988Value = radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988Value;
							num = (short)719519783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							return result;
						case 16:
							result = false;
							num = (short)1589510164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_24B;
						case 18:
							return result;
						case 19:
							num = (short)583663626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_24B;
						case 21:
							goto IL_24B;
						case 22:
						{
							int radInfoLabtoolSecondaryBands_A23988Value;
							if (radInfoLabtoolSecondaryBands_A23988Value != 1)
							{
								num = (short)1125646352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						case 23:
							num = (short)1020919809;
							if (num != 0)
							{
							}
							num = (short)654049289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)2085748772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							result = false;
							num = (short)1641086994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							result = false;
							num = (short)1803812879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							return result;
						case 28:
							return result;
						case 29:
							num = (short)1570177024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)1116405782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							result = false;
							num = (short)1947926555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							result = false;
							num = (short)381681685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1335558145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							bool radInfoLabtoolQA00572UHFRange2_A42595Value;
							if (!radInfoLabtoolQA00572UHFRange2_A42595Value)
							{
								num = (short)140509209;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 35:
							if (index != 255)
							{
								num = (short)917897229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = false;
							num = (short)1905655825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							if (index != 255)
							{
								num = (short)1886060563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)282066972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_24B;
						case 38:
						{
							bool radInfoLabtoolQA00571UHFRange1_A42594Value;
							if (!radInfoLabtoolQA00571UHFRange1_A42594Value)
							{
								num = (short)1648230407;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 39:
							switch (index)
							{
							case 1:
								goto IL_4E8;
							case 2:
								num = (short)1643315241;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_24B;
							case 4:
								result = true;
								num = (short)1509425155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)2110128130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 40:
							switch (index)
							{
							case 1:
								num = (short)692912133;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)829816870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								return result;
							case 4:
								num = (short)2145910792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1296105496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 41:
						{
							int radInfoLabtoolPrimaryBands_A23987Value;
							if (radInfoLabtoolPrimaryBands_A23987Value != 4)
							{
								num = (short)2120024087;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						}
						}
						goto IL_153;
						IL_24B:
						num = (short)369229828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_4E8:
					num = (short)1452802054;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_153:
				result = true;
				flag = false;
				flag2 = false;
				num = (short)1907359756;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x002D2464 File Offset: 0x002D0664
		internal static void ConSyncOldToActiveMicforBTPTT(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1602945024;
					short num3 = num2;
					num2 = (short)1742405638;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_24F;
				case 2:
					num2 = (short)362741761;
					if (num2 != 0)
					{
					}
					if (radioWide != null)
					{
						num2 = (short)453705728;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051, 3));
					num2 = (short)1181679624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_224;
				case 5:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.Value != 3)
					{
						num2 = (short)713818115;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					if (radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num2 = (short)592904199;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1746206725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)230883332;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					num2 = (short)576389230;
					short num4 = num2;
					num2 = (short)1496252526;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_224;
					default:
						goto IL_1F3;
					}
					break;
				}
				}
				goto IL_34;
				IL_224:
				if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.Value == 2)
				{
					return;
				}
				num2 = (short)1277165569;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F3:
			num2 = (short)1437270016;
			if (num2 != 0)
			{
			}
			return;
			IL_24F:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051, 2));
			return;
			IL_34:
			radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)634585090;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x002D26C8 File Offset: 0x002D08C8
		internal static bool ConLegacyActiveRSMInternalMicVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)463064208;
			short num2 = num;
			num = (short)1292749968;
			switch (num2 == num)
			{
			default:
			{
				num = (short)520028160;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)207224832;
			if (num != 0)
			{
			}
			num = (short)407437313;
			if (num != 0)
			{
			}
			return !(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value;
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x002D2798 File Offset: 0x002D0998
		internal static bool ConSystemManagedGeofenceValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1118502912;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
				{
					num = (short)528176503;
					short num3 = num;
					num = (short)1956402551;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_8E;
					}
					break;
				}
				case 2:
					goto IL_281;
				}
				IL_31:
				if (!(self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location).RadWideLocationSystemManagedGeofence_43042.Value)
				{
					num = (short)834994177;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
					num = (short)1578893314;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8E:
			num = (short)322174976;
			if (num != 0)
			{
			}
			return true;
			IL_281:
			num = (short)472776705;
			if (num != 0)
			{
			}
			num = (short)1491468288;
			short num4 = num;
			try
			{
				num = (short)49414146;
				num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_10A;
					case 1:
						goto IL_1E8;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 3:
						num = (short)1350107137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)909508614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)2067005443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)364380168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
						{
							num = (short)262144007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						result = true;
						num = (short)1450704896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							num = (short)2058551300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_10F:
					num = (short)1855455237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2:
					goto IL_10F;
				}
				IL_10A:
				return result;
				IL_1E8:
				return false;
			}
			finally
			{
				num = (short)1798373376;
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
							goto IL_21A;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)78643202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_24E;
					}
					IL_21A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)22806529;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24E:;
			}
			return true;
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x002D2A98 File Offset: 0x002D0C98
		internal static bool ConSystemManagedGeofenceApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)318767104;
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
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1712324612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location location;
						if (location.RadWideLocationLocationEnable_A8448.Value)
						{
							num = (short)1715404800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
						goto IL_11A;
					case 3:
						goto IL_B3;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location location;
						if (location.RadWideLocationSystemManagedGeofence_43042.Value)
						{
							num = (short)965083138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset).GetEnumerator();
						num = (short)1023475715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_42;
				}
				IL_B3:
				num = (short)40042496;
				short num3 = num;
				bool result;
				try
				{
					num = (short)1658978306;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1046085637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
							num = (short)528941063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_290;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_192;
							}
							continue;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
							{
								num = (short)330498054;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_271;
						case 5:
							num = (short)487391233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							result = true;
							num = (short)1386151940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles != null)
							{
								num = (short)891551752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							num = (short)1069744131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_194:
						num = (short)1965293568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_192:
						goto IL_194;
					}
					IL_271:
					goto IL_301;
					IL_290:
					return false;
				}
				finally
				{
					num = (short)866648064;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2C9;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1354235906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2FE;
						}
						IL_2C9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)669122561;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2FE:;
				}
				IL_301:
				num = (short)1162479715;
				short num4 = num;
				num = (short)250349667;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_42:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location location = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Location;
					num = (short)1576796161;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)2009333760;
					if (num != 0)
					{
					}
					return result;
				}
				IL_11A:
				num = (short)12976129;
				if (num != 0)
				{
				}
				return true;
			}
			}
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x002D2E10 File Offset: 0x002D1010
		internal static bool ConProtectedZonePasswordCannotBeEmptyIfFPPEnabledValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
				{
					num2 = (short)655963922;
					short num3 = num2;
					num2 = (short)566966034;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_190;
					default:
						num2 = (short)185532416;
						if (num2 != 0)
						{
						}
						num2 = (short)1177878532;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_142;
				case 3:
					if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool).RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799)
					{
						num2 = (short)257884161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FF;
				case 4:
					if (userInformationAndPasswords.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 == string.Empty)
					{
						num2 = (short)1331363847;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FF;
				case 5:
					if (userInformationAndPasswords.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 == string.Empty)
					{
						num2 = (short)1005060096;
						short num4 = num2;
						num2 = (short)1842282504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					if (features.RadWideFeaturesZoneCloneEnable_43130)
					{
						num2 = (short)617873410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					goto IL_190;
				case 8:
					num2 = (short)229113862;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (features.ZnChanCfgFPPProtectionFPPEnable_A8142)
					{
						num2 = (short)114622464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FF;
				}
				goto IL_38;
				IL_190:
				num2 = (short)919339017;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FF:
				num2 = (short)474939397;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_142:
			num2 = (short)944832513;
			if (num2 != 0)
			{
			}
			return false;
			IL_38:
			userInformationAndPasswords = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords);
			features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			num2 = (short)744620035;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x002D3090 File Offset: 0x002D1290
		public static void ConZoneCloneEnableValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 7;
			short num = (short)2073952256;
			switch (num)
			{
			default:
			{
				num = (short)1320157238;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset zoneChannelAssignmentRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset astrotalkgroupListRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset;
					int num5;
					bool flag2;
					global::AcpBusinessLayer.AcpField<bool> radWideFeaturesZoneCloneEnable_;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset conventionalSystemRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment featureNode2;
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList;
					int num10;
					global::AcpCommonLib.IAcpFeatureNode featureNode3;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)1502674972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						conventionalSystem.General.CnvSysGeneralKeyofConventionalSystem_A20482.Value = global::CommonResources.AppResources.Zone_Reserved + global::AllFeatures.CodeplugGuid.b("", a_);
						num = (short)785383475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)962330629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_B92;
					case 4:
					{
						int num3;
						if (num3 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)1151795214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone = (zoneChannelAssignmentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
						num3++;
						num = (short)1336672303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						flag = radioInformation.Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.Value;
						goto IL_D76;
					case 6:
						flag = true;
						goto IL_D76;
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode rec = astrotalkgroupListRecset.CreateDefaultRecord();
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(rec));
						num = (short)1707343875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)13828120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!radioInformation.Labtool.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.Value)
						{
							num = (short)569835522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)151191558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (talkgroupTableInnerRecset.Count >= 240)
						{
							num = (short)1333264392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = talkgroupTableInnerRecset.CreateDefaultRecord();
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode, (global::AcpCommonLib.Permissions)15));
						featureNode.KeyField.Editable = false;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode));
						featureNode.KeyField.Editable = true;
						num = (short)1153761333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num4;
						if (num4 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)2039349313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone2 = (zoneChannelAssignmentRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
						num4++;
						num = (short)1879638043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (astrotalkgroupListRecset.Count == 1)
						{
							num = (short)383582215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B92;
					case 13:
					{
						if (num5 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)702545943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone3 = (zoneChannelAssignmentRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
						num5++;
						num = (short)1755447311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_AF5;
					case 15:
						goto IL_10B8;
					case 16:
						if (!global::AcpCommonLib.AppInfoManager.ImportCopyOperation)
						{
							num = (short)277676087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 17:
						goto IL_F2A;
					case 18:
						if (astrotalkgroupListRecset.Count > 0)
						{
							num = (short)590544944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0F;
					case 19:
						goto IL_AB5;
					case 20:
						num = (short)1692925989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_524;
					case 22:
						if (!flag2)
						{
							num = (short)1054408778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_269;
					case 23:
						return;
					case 24:
						if (!global::AcpCommonLib.AppInfoManager.DndOperation)
						{
							num = (short)1239941152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF7;
					case 25:
						num = (short)296222721;
						if (num != 0)
						{
						}
						if (!conventionalSystem.General.CnvSysGeneralKeyofConventionalSystem_A20482.Value.StartsWith(global::CommonResources.AppResources.Zone_Reserved))
						{
							num = (short)1345519617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_884;
					case 26:
					{
						int num6;
						if (num6 >= astrotalkgroupListRecset.Count)
						{
							num = (short)1466171452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset talkgroupTableInnerRecset2 = (astrotalkgroupListRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset;
						int num7;
						num7 += talkgroupTableInnerRecset2.Count;
						num6++;
						num = (short)238682157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_202;
					case 28:
						if (!radWideFeaturesZoneCloneEnable_.Value)
						{
							num = (short)770375719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ECA;
					case 29:
						if (astrotalkgroupListRecset != null)
						{
							num = (short)1550516258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0F;
					case 30:
						if (conventionalSystemRecset.Count > 0)
						{
							num = (short)1150025748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF1;
					case 31:
						goto IL_774;
					case 32:
						num = (short)1945698372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_ECA;
					case 34:
						num = (short)2090729490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						return;
					case 36:
						flag2 = true;
						num = (short)1991966801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (conventionalSystemRecset.Max == conventionalSystemRecset.Count)
						{
							num = (short)2044854339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF1;
					case 38:
						if (!flag2)
						{
							num = (short)266797056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ECA;
					case 39:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode2, global::AcpCommonLib.Permissions.None));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(astrotalkgroupListRecset, 1));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalSystemRecset, 1));
						num = (short)488157280;
						short num8 = num;
						num = (short)1111666784;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2AD;
						default:
							num = (short)874971136;
							if (num != 0)
							{
							}
							num = (short)1645477900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 40:
						num = (short)2004680726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_5DC;
					case 42:
						num = (short)1524236304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (conventionalSystemRecset != null)
						{
							num = (short)1425997893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF1;
					case 44:
					{
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, global::CommonResources.AppResources.Zone_Clone_Enable_Astro_Talk_Group);
						radWideFeaturesZoneCloneEnable_.Value = false;
						int num9 = 0;
						num = (short)133890112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_37F;
					case 46:
						astrotalkgroupList.General.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Value = global::CommonResources.AppResources.Zone_Reserved + global::AllFeatures.CodeplugGuid.b("", a_);
						num = (short)613023775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_AB5;
					case 48:
						num = (short)386662477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_C81;
					case 50:
						goto IL_ECA;
					case 51:
						goto IL_884;
					case 52:
						if ((zoneChannelAssignmentRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)400621604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num10++;
						goto IL_2AD;
					case 53:
						goto IL_1BB;
					case 54:
						switch (0)
						{
						case 0:
							goto IL_194;
						}
						continue;
					case 55:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode3, (global::AcpCommonLib.Permissions)15));
						num = (short)576061496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_1BB;
					case 57:
						if (!astrotalkgroupList.General.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Value.StartsWith(global::CommonResources.AppResources.Zone_Reserved))
						{
							num = (short)823459886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_774;
					case 58:
					{
						int num7;
						if (((astrotalkgroupListRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset).MaxPool - num7 < 240)
						{
							num = (short)474480702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0F;
					}
					case 59:
					{
						num = (short)665714688;
						short num11 = num;
						goto IL_202;
					}
					case 60:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode2, (global::AcpCommonLib.Permissions)14));
						num = (short)1835663389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (conventionalSystemRecset.Count == 1)
						{
							num = (short)1444872263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C81;
					case 62:
					{
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, global::CommonResources.AppResources.Zone_Clone_Enable_Astro_Talk_Group);
						radWideFeaturesZoneCloneEnable_.Value = false;
						int num3 = 0;
						num = (short)550633491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						goto IL_AF7;
					case 64:
						goto IL_CC8;
					case 65:
						goto IL_241;
					case 66:
						goto IL_524;
					case 67:
					{
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, global::CommonResources.AppResources.Zone_Clone_Enable_Con_Sys_Full);
						radWideFeaturesZoneCloneEnable_.Value = false;
						int num4 = 0;
						num = (short)1086783547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						if (global::AcpCommonLib.AppInfoManager.ImportCopyOperation)
						{
							num = (short)67960895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5DC;
					case 69:
						num = (short)139591710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (num10 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)533331985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1952383028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
					{
						global::AcpBusinessLayer.FeatureNode rec2 = conventionalSystemRecset.CreateDefaultRecord();
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(rec2));
						num = (short)1666318385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
						goto IL_CC8;
					case 73:
						if (radWideFeaturesZoneCloneEnable_.Value && flag3)
						{
							num = (short)473694248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_269;
					case 74:
					{
						int num7 = 0;
						int num6 = 0;
						num = (short)804585547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 75:
						goto IL_37F;
					case 76:
						goto IL_10B8;
					case 77:
						if (astrotalkgroupListRecset.Max == astrotalkgroupListRecset.Count)
						{
							num = (short)578486316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1785135162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (!global::AcpCommonLib.AppInfoManager.DndOperation)
						{
							num = (short)113180714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 79:
						goto IL_D07;
					case 80:
					{
						int num9;
						if (num9 >= zoneChannelAssignmentRecset.Count)
						{
							num = (short)163643471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.Zone zone4 = (zoneChannelAssignmentRecset[num9] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment).Zone;
						num9++;
						num = (short)930283592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						goto IL_F2A;
					}
					IL_194:
					if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
					{
						num = (short)1867251747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					radWideFeaturesZoneCloneEnable_ = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadWideFeaturesZoneCloneEnable_43130;
					astrotalkgroupListRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2062) as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupListRecset);
					conventionalSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset);
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					num = (short)1463418889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BB:
					num = (short)224264202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_202:
					num = (short)391512075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					num = (short)703266854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AD:
					num = (short)1925644354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37F:
					num = (short)1868365850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_524:
					num = (short)1755119686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5DC:
					global::AcpBusinessLayer.FeatureNode featureNode4 = conventionalSystemRecset.CreateDefaultRecord();
					conventionalSystem = (featureNode4 as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem);
					conventionalSystem.General.CnvSysGeneralKeyofConventionalSystem_A20482.Value = global::CommonResources.AppResources.Zone_Reserved;
					conventionalSystem.General.CnvSysGeneralSystemType_A13262.Value = 0;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode4));
					conventionalSystemRecset.MoveRecord(conventionalSystemRecset.Count - 1, 0, task);
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode4, (global::AcpCommonLib.Permissions)79));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(astrotalkgroupListRecset, 2));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangeMinTask(conventionalSystemRecset, 2));
					num = (short)436666393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_774:
					global::AcpBusinessLayer.FeatureNode featureNode5;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode5, (global::AcpCommonLib.Permissions)79));
					talkgroupTableInnerRecset = ((astrotalkgroupListRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList).TalkgroupList.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.TalkgroupTableInnerRecset);
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(talkgroupTableInnerRecset, (global::AcpCommonLib.Permissions)768));
					featureNode3 = talkgroupTableInnerRecset[0];
					num = (short)1476853838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_884:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode4, (global::AcpCommonLib.Permissions)79));
					num = (short)304087090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB5:
					num = (short)1960116228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF7:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(talkgroupTableInnerRecset[0] as global::AcpBusinessLayer.FeatureNode));
					global::AcpBusinessLayer.FeatureNode featureNode6 = talkgroupTableInnerRecset.CreateDefaultRecord();
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(featureNode6, (global::AcpCommonLib.Permissions)15));
					featureNode6.KeyField.Editable = false;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode6));
					featureNode6.KeyField.Editable = true;
					num = (short)834142249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B92:
					global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList astrotalkgroupList2 = astrotalkgroupListRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(astrotalkgroupList2, global::AcpCommonLib.Permissions.None));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(astrotalkgroupList2));
					num = (short)1976500285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C81:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem2 = conventionalSystemRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ChangePermissionsTask(conventionalSystem2, global::AcpCommonLib.Permissions.None));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(conventionalSystem2));
					num = (short)2051407905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CC8:
					num = (short)1730084944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D76:
					flag3 = flag;
					zoneChannelAssignmentRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset);
					featureNode2 = (zoneChannelAssignmentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					flag2 = false;
					num10 = 0;
					num = (short)1340342293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E0F:
					num = (short)1213792299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ECA:
					num5 = 0;
					num = (short)1505951820;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2A:
					num = (short)2142896201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FF1:
					featureNode5 = astrotalkgroupListRecset.CreateDefaultRecord();
					astrotalkgroupList = (featureNode5 as global::Motorola.MackinawCPS.CoreFeatures.ASTROTalkgroupList.ASTROTalkgroupList);
					astrotalkgroupList.General.AstTlkgrpLstGeneralKeyofASTROTalkgroupList_A12665Value = global::CommonResources.AppResources.Zone_Reserved;
					featureNode5.KeyField.Editable = false;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode5));
					featureNode5.KeyField.Editable = true;
					astrotalkgroupListRecset.MoveRecord(astrotalkgroupListRecset.Count - 1, 0, task);
					num = (short)1895301177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B8:
					num = (short)443088909;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_241:
				task.Tasks.Remove(task.Tasks[task.Tasks.Count - 1]);
				return;
				IL_AF5:
				task.Tasks.Remove(task.Tasks[task.Tasks.Count - 1]);
				return;
				IL_D07:
				task.Tasks.Remove(task.Tasks[task.Tasks.Count - 1]);
				return;
			}
			}
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x002D420C File Offset: 0x002D240C
		public static bool ConAPX1000RefreshandVertexNotEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					goto IL_132;
				case 1:
				{
					string text;
					if (text.Equals(global::AllFeatures.CodeplugGuid.b("賃ￅ﯇", a_)))
					{
						num2 = (short)296157184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_134;
				}
				case 2:
					num2 = (short)1650786305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)2041511937;
					if (num2 != 0)
					{
					}
					string text;
					if (!text.Equals(global::AllFeatures.CodeplugGuid.b("賃ￅ難", a_)))
					{
						num2 = (short)901054464;
						short num3 = num2;
						num2 = (short)1360003074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_29;
			}
			return false;
			IL_132:
			return false;
			IL_134:
			num2 = (short)1526647812;
			short num4 = num2;
			num2 = (short)1398393860;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_29:
				string text = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value.Substring(0, 3);
				num2 = (short)1489174531;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
				num2 = (short)1264386048;
				if (num2 != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x002D439C File Offset: 0x002D259C
		public static bool ConZoneCloneEnableApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1064304646;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_187;
					case 1:
					{
						if (enumerator.MoveNext())
						{
							num = (short)1627586563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)24182396;
						short num3 = num;
						num = (short)1486356092;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_187;
						default:
							num = (short)456065024;
							if (num != 0)
							{
							}
							num = (short)608043013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_16A;
					case 3:
						if (((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)1956970500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						result = false;
						num = (short)167051266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1434124288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					}
					IL_83:
					num = (short)2027945985;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81:
					goto IL_83;
				}
				IL_16A:
				return result;
				IL_187:
				goto IL_17;
			}
			finally
			{
				num = (short)1827143682;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1106182145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_21A;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1BE;
						}
						continue;
					}
					IL_1BE:
					num = (short)1827143681;
					if (num != 0)
					{
					}
					if (enumerator == null)
					{
						break;
					}
					num = (short)1827012608;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21A:;
			}
			return result;
			IL_17:
			num = (short)262602752;
			short num4 = num;
			return true;
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x002D45E4 File Offset: 0x002D27E4
		public static bool ConZoneCloneEnableValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1925120002;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					goto IL_246;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (!(self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadWideFeaturesZoneCloneEnable_43130.Value)
				{
					num = (short)2118254592;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2051) as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentRecset).GetEnumerator();
					num = (short)1361969153;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_246:
			bool result;
			try
			{
				num = (short)786956294;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1AB;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (enumerator.MoveNext())
						{
							num = (short)1095499780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1819808876;
						short num3 = num;
						num = (short)318641260;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1AB;
						default:
							num = (short)1552023552;
							if (num != 0)
							{
							}
							num = (short)1112670213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						result = true;
						num = (short)686489603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_13E;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (((global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment)enumerator.Current).Zone.ZnChanCfgZoneZoneCloningEnable_43119.Value)
						{
							num = (short)676855810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1225981952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					}
					IL_A1:
					num = (short)372703233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F:
					goto IL_A1;
				}
				IL_13E:
				goto IL_24B;
				IL_1AB:
				return false;
			}
			finally
			{
				num = (short)787939330;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)966721537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_212;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_1DD;
						}
						continue;
					}
					IL_1DD:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1666646016;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_212:;
			}
			return true;
			IL_24B:
			num = (short)8388609;
			if (num != 0)
			{
			}
			num = (short)20512768;
			short num4 = num;
			return result;
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x002D48AC File Offset: 0x002D2AAC
		public static bool ConDynamicIDIsEnableInAnyConvSystem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2053) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystemRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1231486984;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1327759367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem)enumerator.Current;
						num = (short)533921796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						result = true;
						num = (short)1366687747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_1E9;
					case 3:
						goto IL_131;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if ((conventionalSystem[10119] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features).CnvSysFeaturesDynamicIDEnable_A40100.Value)
						{
							num = (short)1262682117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1694040070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
						if ((conventionalSystem[10119] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.Features).CnvSysFeaturesDynamicIDEnable_A40100.Applicable)
						{
							num = (short)1379401729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						num = (short)1529025713;
						short num3 = num;
						num = (short)1886852273;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E9;
						default:
							num = (short)566296576;
							if (num != 0)
							{
							}
							num = (short)1552482306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					IL_8A:
					num = (short)1790509056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_88:
					goto IL_8A;
				}
				IL_131:
				goto IL_256;
				IL_1E9:
				goto IL_17;
			}
			finally
			{
				num = (short)1630470146;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1650917377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_253;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_21E;
						}
						continue;
					}
					IL_21E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)235667456;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_253:;
			}
			goto IL_256;
			IL_17:
			num = (short)1068105729;
			if (num != 0)
			{
			}
			return false;
			IL_256:
			num = (short)414515200;
			short num4 = num;
			return result;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x002D4B58 File Offset: 0x002D2D58
		internal static bool conSetRadioLockPasswordLengthBasedOnPCIValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)623706115;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)974393063;
				short num3 = num;
				num = (short)1897336551;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
				{
					num = (short)175374336;
					if (num != 0)
					{
					}
					bool value;
					switch (num2)
					{
					case 0:
						goto IL_136;
					case 1:
						if (!value)
						{
							num = (short)1699348480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						num = (short)722862081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_80;
						}
						continue;
					}
					IL_80:
					num = (short)565051393;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool;
					int value2 = userInformationAndPasswords.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477.Value;
					value = labtool.TEN_DIGIT_RL_PSWD_capable_43711.Value;
					if (value2 <= 8)
					{
						return true;
					}
					num = (short)1039794178;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_136:
			num = (short)7929856;
			short num4 = num;
			return false;
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x002D4CC8 File Offset: 0x002D2EC8
		internal static bool conEnableRadioLockAttemptsAllowed(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)799316949;
			short num2 = num;
			num = (short)1879153621;
			switch (num2 == num)
			{
			}
			num = (short)341049344;
			short num3 = num;
			num = (short)270401537;
			if (num != 0)
			{
			}
			num = (short)1727987712;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsRadioLock_A8836Value;
		}

		// Token: 0x06002DF5 RID: 11765 RVA: 0x002D4D80 File Offset: 0x002D2F80
		internal static bool conEnableRadioLockRadioInhibitOnDeadlock(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1439367169;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_C8;
			}
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			int num4;
			bool radWideUserInformationandPasswordsRadioLock_A8836Value;
			for (;;)
			{
				IL_33:
				num = (short)990776089;
				short num2 = num;
				num = (short)1684081433;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_94;
				default:
				{
					num = (short)1601175552;
					short num3 = num;
					goto IL_94;
				}
				}
				IL_FC:
				if (secWideGeneralSecureOperation_A.Value != 1)
				{
					num = (short)943390723;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2028208133;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_94:
				num = (short)870055936;
				if (num != 0)
				{
				}
				bool flag;
				switch (num4)
				{
				case 0:
					num = (short)249888772;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					flag = (secWideGeneralSecureOperation_A.Value == 3);
					goto IL_15B;
				case 2:
					goto IL_FC;
				case 3:
					num = (short)856424449;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return true;
				case 5:
					flag = true;
					goto IL_15B;
				}
				goto IL_C8;
				IL_15B:
				if (!flag || !radWideUserInformationandPasswordsRadioLock_A8836Value)
				{
					return false;
				}
				num = (short)781254656;
				num4 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_C8:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
			radWideUserInformationandPasswordsRadioLock_A8836Value = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836Value;
			secWideGeneralSecureOperation_A = userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num = (short)1332936706;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x002D4F24 File Offset: 0x002D3124
		internal static void conEnableRadioLockValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			bool radWideUserInformationandPasswordsRadioLock_A8836Value;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLockForceChangePassword_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (secWideGeneralSecureOperation_A.Value == 1 && radWideUserInformationandPasswordsRadioLock_A8836Value)
					{
						num2 = (short)2024538113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F4;
				case 1:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideUserInformationandPasswordsRadioLockForceChangePassword_A, true));
					num2 = (short)1281556482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_F4;
				}
				goto IL_1C;
				IL_F4:
				num2 = (short)392167127;
				short num3 = num2;
				num2 = (short)1349582551;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_128;
				}
			}
			IL_128:
			num2 = (short)2108358656;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
			radWideUserInformationandPasswordsRadioLock_A8836Value = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836Value;
			secWideGeneralSecureOperation_A = userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			radWideUserInformationandPasswordsRadioLockForceChangePassword_A = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;
			num2 = (short)517144576;
			short num4 = num2;
			num2 = (short)529989633;
			if (num2 != 0)
			{
			}
			num2 = (short)1327562752;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x002D5070 File Offset: 0x002D3270
		internal static bool conEnableRadioLockForceChangePassword(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
				bool radWideUserInformationandPasswordsRadioLock_A8836Value = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836Value;
				if (userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 1 || !radWideUserInformationandPasswordsRadioLock_A8836Value)
				{
					return false;
				}
				num = (short)1532032612;
				short num2 = num;
				num = (short)623441508;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_61;
				}
			}
			IL_61:
			num = (short)2038431745;
			if (num != 0)
			{
			}
			num = (short)2054750208;
			short num3 = num;
			num = (short)992935936;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x002D5148 File Offset: 0x002D3348
		internal static bool conEnableForceChangePassword(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
				bool radWideUserInformationandPasswordsRadioLock_A8836Value = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836Value;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A = userInformationAndPasswords.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
				global::AcpBusinessLayer.AcpField<bool> radWideUserInformationandPasswordsRadioLockForceChangePassword_A = userInformationAndPasswords.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;
				if (secWideGeneralSecureOperation_A.Value != 1 || !radWideUserInformationandPasswordsRadioLock_A8836Value)
				{
					return false;
				}
				num = (short)691737988;
				short num2 = num;
				num = (short)1270551940;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_69;
				}
			}
			IL_69:
			num = (short)562167808;
			if (num != 0)
			{
			}
			num = (short)1311244288;
			short num3 = num;
			num = (short)1907818497;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x002D5228 File Offset: 0x002D3428
		internal static bool ConShowWarningForRecordings(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			int num2;
			global::AcpBusinessLayer.AcpCustomRangeField radWideFeaturesRecordPlaybackAudioBufferSize_A;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1808334849;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)371261446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Warning, global::CommonResources.AppResources.Audio_Playback_Recordings_Warning);
						num = (short)1014169604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1697316867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radWideFeaturesRecordPlaybackAudioBufferSize_A.Value <= 30)
						{
							num = (short)1353383947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_258;
					case 4:
						return true;
					case 5:
						if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(global::CommonResources.AppResources.Audio_Playback_Recordings_Warning))
						{
							num = (short)826933249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)642580489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E2;
					case 7:
						goto IL_2E2;
					case 8:
						return true;
					case 9:
						num = (short)1347944461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(global::CommonResources.AppResources.Audio_Playback_Recordings_Warning))
						{
							num = (short)2071986190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						goto IL_F1;
					case 12:
						if (radWideFeaturesRecordPlaybackAudioBufferSize_A.Value >= 10)
						{
							num = (short)383713280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_258;
					case 13:
						if (radWideFeaturesRecordPlaybackAudioBufferSize_A.Value > 60)
						{
							num = (short)1965948928;
							short num3 = num;
							num = (short)848429063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					case 14:
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(global::CommonResources.AppResources.Audio_Playback_Recordings_Warning);
						num = (short)588709896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)567083010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_258;
					}
					goto IL_77;
					IL_F1:
					num = (short)327214670;
					short num4 = num;
					num = (short)811591246;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						num = (short)693370880;
						if (num != 0)
						{
						}
						num = (short)1197473797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_258:
					num = (short)185991178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E2:
					num = (short)126287887;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			IL_77:
			radWideFeaturesRecordPlaybackAudioBufferSize_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadWideFeaturesRecordPlaybackAudioBufferSize_A43125;
			IL_83:
			num = (short)706543628;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x002D5554 File Offset: 0x002D3754
		internal static bool ConSelectBluetoothMicForAuxPTTAudioSourceApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)385810432;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				object obj;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					obj = null;
					goto IL_D3;
				case 2:
					goto IL_F5;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions digitalAudioOptions;
				for (;;)
				{
					IL_32:
					digitalAudioOptions = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.DigitalAudioOptions);
					if (digitalAudioOptions != null)
					{
						goto IL_CC;
					}
					num = (short)1274544129;
					if (num != 0)
					{
					}
					num = (short)322622538;
					short num3 = num;
					num = (short)256824394;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_9D;
					}
				}
				IL_9D:
				num = (short)79364096;
				if (num != 0)
				{
				}
				num = (short)1992425473;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC:
				obj = digitalAudioOptions.Parent;
				IL_D3:
				radioWide = (obj as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				if (radioWide != null)
				{
					goto IL_121;
				}
				num = (short)1471217666;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F5:
			num = (short)1284243456;
			short num4 = num;
			object obj2 = null;
			goto IL_128;
			IL_121:
			obj2 = radioWide.Bluetooth;
			IL_128:
			object obj3 = obj2;
			return obj3 != null && obj3.RadWideBluetoothBluetoothEnable_A37028.Value;
		}

		// Token: 0x06002DFB RID: 11771 RVA: 0x002D569C File Offset: 0x002D389C
		internal static bool ConRadCfgVirtualPartnerModeEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1475608577;
			if (num != 0)
			{
			}
			num = (short)1249138738;
			short num2 = num;
			num = (short)268785714;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2009137152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)959053824;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpField<int> radWideUserInformationandPasswordsUserLoginAuthenticationType_A = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).UserInformationAndPasswords.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;
			global::AcpBusinessLayer.AcpListField radCfgVirtualPartnerMode = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadCfgVirtualPartnerMode;
			bool flag = radWideUserInformationandPasswordsUserLoginAuthenticationType_A.Value == 0;
			if (!flag)
			{
				radCfgVirtualPartnerMode.Value = 0;
			}
			return flag;
		}

		// Token: 0x06002DFC RID: 11772 RVA: 0x002D5788 File Offset: 0x002D3988
		internal static bool ConVirtualPartnerInactivityTimeEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1155569920;
			short num2 = num;
			num = (short)2025822464;
			switch (num2 == num)
			{
			}
			num = (short)777388032;
			short num3 = num;
			num = (short)1896742913;
			if (num != 0)
			{
			}
			num = (short)1491927040;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features).RadCfgVirtualPartnerMode.Value == 2;
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x002D5844 File Offset: 0x002D3A44
		internal static bool ConIsApplicableNfpaCompliant(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool value;
			bool value2;
			short num;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				value = radioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.Value;
				value2 = radioWide.Features.RadWideFeaturesNFPACompliant.Value;
				if (global::ConstraintHelper.UtilityMack.IsNFPARadio)
				{
					return false;
				}
				num = (short)887422977;
				if (num != 0)
				{
				}
				num = (short)644290531;
				short num2 = num;
				num = (short)403707875;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_93;
				}
			}
			IL_93:
			num = (short)1995112448;
			short num3 = num;
			num = (short)468385792;
			if (num != 0)
			{
			}
			return !value2 || !value;
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x002D592C File Offset: 0x002D3B2C
		internal static bool ConIsValidRSMBluetoothNfpaCompliant(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool value;
			bool isNFPARadio;
			short num;
			for (;;)
			{
				value = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothRSMLED_A37039.Value;
				isNFPARadio = global::ConstraintHelper.UtilityMack.IsNFPARadio;
				if (isNFPARadio)
				{
					goto IL_C7;
				}
				num = (short)1565018516;
				short num2 = num;
				num = (short)1214531988;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5B;
				}
			}
			IL_5B:
			num = (short)1224867840;
			if (num != 0)
			{
			}
			num = (short)993329152;
			short num3 = num;
			num = (short)1374355457;
			if (num != 0)
			{
			}
			return true;
			IL_C7:
			return isNFPARadio && value;
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x002D5A04 File Offset: 0x002D3C04
		internal static bool ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForVirtualPartnerMode(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)426704897;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					num = (short)1988820994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)346357761;
					if (num != 0)
					{
					}
					num = (short)1121517568;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				}
				case 2:
					if (!dataWide.LTE.DataWideLTEHWEnable)
					{
						num = (short)11796483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_14F;
				}
				IL_86:
				num = (short)32244328;
				short num4 = num;
				num = (short)1040712296;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)601358336;
					if (num != 0)
					{
					}
					if (index != 2)
					{
						return true;
					}
					num = (short)694026240;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_14F:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x002D5B64 File Offset: 0x002D3D64
		internal static bool ConSmartMessagingValidBasedOnLTEAndWifiEnableBitForSmartMessagingMode(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)694353921;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				num = (short)1102839808;
				short num3 = num;
				switch (num2)
				{
				case 0:
					dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					num = (short)1745682434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 2:
					if (!dataWide.LTE.DataWideLTEHWEnable)
					{
						num = (short)1462960131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_12C;
				}
				IL_5D:
				num = (short)426921657;
				short num4 = num;
				num = (short)394743481;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12E;
				default:
					num = (short)89587712;
					if (num != 0)
					{
					}
					if (index != 1)
					{
						goto IL_12E;
					}
					num = (short)1755840512;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_12C:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			IL_12E:
			num = (short)153288705;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x002D5CC8 File Offset: 0x002D3EC8
		internal static bool ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForSmartLocateReporting(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index != 2)
					{
						goto IL_1A3;
					}
					num2 = (short)1027473414;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1262616576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return true;
				case 3:
					goto IL_13B;
				case 4:
					goto IL_218;
				case 5:
				{
					num2 = (short)83296256;
					short num3 = num2;
					if (index != 1)
					{
						num2 = (short)2122448897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)881983496;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					if (dataWide.LTE.DataWideLTEHWEnable)
					{
						return true;
					}
					num2 = (short)633093275;
					short num4 = num2;
					num2 = (short)692206747;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1A3;
					default:
						num2 = (short)1055457280;
						if (num2 != 0)
						{
						}
						num2 = (short)2078212099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)1439891458;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!dataWide.LTE.DataWideLTEHWEnable)
					{
						num2 = (short)54198276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_34;
				IL_1A3:
				num2 = (short)1305083911;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13B:
			num2 = (short)1001324545;
			if (num2 != 0)
			{
			}
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			IL_218:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			IL_34:
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)740884485;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x002D5EF0 File Offset: 0x002D40F0
		internal static bool ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForMappingMode(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)837550081;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				num = (short)738197504;
				short num3 = num;
				switch (num2)
				{
				case 0:
					dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
					num = (short)2144468994;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				case 2:
					if (!dataWide.LTE.DataWideLTEHWEnable)
					{
						num = (short)1606549505;
						if (num != 0)
						{
						}
						num = (short)1162084355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_153;
				}
				IL_5F:
				num = (short)76420851;
				short num4 = num;
				num = (short)1920276211;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1524826112;
					if (num != 0)
					{
					}
					if (index != 1)
					{
						return true;
					}
					num = (short)671547392;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_153:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x002D6058 File Offset: 0x002D4258
		internal static bool ConValidBasedOnLTEAndWifiEnableBitForServerAssistedLocation(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			short num;
			for (;;)
			{
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				if (dataWide.LTE.DataWideLTEHWEnable)
				{
					return true;
				}
				num = (short)1631343956;
				short num2 = num;
				num = (short)1384011092;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_61;
				}
			}
			IL_61:
			num = (short)1579679744;
			if (num != 0)
			{
			}
			num = (short)1754136576;
			short num3 = num;
			num = (short)761856001;
			if (num != 0)
			{
			}
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x002D613C File Offset: 0x002D433C
		internal static bool ConBroadbandOptionValidBasedOnLTEAndWifiEnableBitForGeocodedLocationFormat(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index != 2)
					{
						goto IL_1AB;
					}
					num2 = (short)167706630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1028325376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return true;
				case 3:
					goto IL_168;
				case 4:
					goto IL_221;
				case 5:
				{
					num2 = (short)1180631040;
					short num3 = num2;
					if (index != 1)
					{
						num2 = (short)1891237889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1585905672;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
				{
					if (dataWide.LTE.DataWideLTEHWEnable)
					{
						return true;
					}
					num2 = (short)1039076100;
					short num4 = num2;
					num2 = (short)798362372;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1AB;
					default:
						num2 = (short)1134952449;
						if (num2 != 0)
						{
						}
						num2 = (short)2021720064;
						if (num2 != 0)
						{
						}
						num2 = (short)354025475;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)140378114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (!dataWide.LTE.DataWideLTEHWEnable)
					{
						num2 = (short)1214906372;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_34;
				IL_1AB:
				num2 = (short)777977863;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_168:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			IL_221:
			return dataWide.WIFI.DataWideWIFIEnable_42506Value;
			IL_34:
			dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
			num2 = (short)1039663109;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x002D6370 File Offset: 0x002D4570
		internal static bool ConTacticalServiceEncodePasswordIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1280507904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_27:
					num = (short)1922826215;
					short num3 = num;
					num = (short)579010535;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						bool result;
						return result;
					}
					default:
					{
						num = (short)901513216;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							if (conventionalPersonalityRecset != null)
							{
								num = (short)1039269889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							goto IL_2C2;
						case 2:
						{
							num = (short)1898184704;
							short num4 = num;
							try
							{
								num = (short)1418919941;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1EB;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
										if (conventionalPersonality.ASTROCall.CnvPerASTROCallTacticalServicesOperation != 2)
										{
											num = (short)1809776646;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1CF;
									}
									case 2:
										num = (short)1077346308;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1418592258;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current;
										num = (short)1746141185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_251;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_145;
										}
										continue;
									case 6:
										num = (short)438501383;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
										if (conventionalPersonality.ASTROCall.CnvPerASTROCallTacticalServicesOperation == 3)
										{
											num = (short)1705771016;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
										goto IL_1CF;
									}
									IL_194:
									num = (short)223674371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_145:
									goto IL_194;
									IL_1CF:
									result = true;
									num = (short)15859712;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_1EB:
								return result;
								IL_251:
								return false;
							}
							finally
							{
								num = (short)1011810304;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_288;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)295239682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_2BF;
									}
									IL_288:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1489043457;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2BF:;
							}
							goto IL_2C2;
						}
						}
						goto IL_86;
						IL_2C2:
						enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1430978562;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return false;
				IL_86:
				num = (short)2081816577;
				if (num != 0)
				{
				}
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)478806016;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
