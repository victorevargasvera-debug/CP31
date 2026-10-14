using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.RadioProfiles
{
	// Token: 0x020001F2 RID: 498
	public static class RadioProfilesConstraints
	{
		// Token: 0x06005DBB RID: 23995 RVA: 0x0053D75C File Offset: 0x0053B95C
		internal static bool ConRadWideIntAnlgDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1778581505;
			if (num != 0)
			{
			}
			num = (short)80433529;
			short num2 = num;
			num = (short)1644581241;
			switch (num2 == num)
			{
			}
			num = (short)655491072;
			if (num != 0)
			{
			}
			num = (short)282853376;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsAnalogAGC1_A7440.Value;
		}

		// Token: 0x06005DBC RID: 23996 RVA: 0x0053D818 File Offset: 0x0053BA18
		internal static bool ConRadWideIntSecrntDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)435116877;
			short num2 = num;
			num = (short)1617713997;
			switch (num2 == num)
			{
			}
			num = (short)370999296;
			if (num != 0)
			{
			}
			num = (short)513540097;
			if (num != 0)
			{
			}
			num = (short)1837432832;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsSecurenetAGC1_A9099.Value;
		}

		// Token: 0x06005DBD RID: 23997 RVA: 0x0053D8D4 File Offset: 0x0053BAD4
		internal static bool ConRadWideIntDgtlDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1537998849;
			if (num != 0)
			{
			}
			num = (short)1632965892;
			short num2 = num;
			num = (short)1377834244;
			switch (num2 == num)
			{
			}
			num = (short)553648128;
			if (num != 0)
			{
			}
			num = (short)401408000;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsDigitalAGC1_A7854.Value;
		}

		// Token: 0x06005DBE RID: 23998 RVA: 0x0053D990 File Offset: 0x0053BB90
		internal static bool ConRadWideExtAnlgIsDisable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)436715136;
			short num2 = num;
			num = (short)579387008;
			switch (num2 == num)
			{
			}
			num = (short)564920320;
			if (num != 0)
			{
			}
			num = (short)942931969;
			if (num != 0)
			{
			}
			num = (short)906362880;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsAnalogAGC2_A7439.Value;
		}

		// Token: 0x06005DBF RID: 23999 RVA: 0x0053DA4C File Offset: 0x0053BC4C
		internal static bool ConRadWideExtSecrntDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)593339343;
			short num2 = num;
			num = (short)1377280975;
			switch (num2 == num)
			{
			}
			num = (short)266403841;
			if (num != 0)
			{
			}
			num = (short)746389504;
			if (num != 0)
			{
			}
			num = (short)749469696;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsSecurenetAGC2_A9098.Value;
		}

		// Token: 0x06005DC0 RID: 24000 RVA: 0x0053DB0C File Offset: 0x0053BD0C
		internal static bool ConRadWideExtDgtlDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1322183706;
			short num2 = num;
			num = (short)967765018;
			switch (num2 == num)
			{
			}
			num = (short)1206452225;
			if (num != 0)
			{
			}
			num = (short)2053963776;
			if (num != 0)
			{
			}
			num = (short)1322188800;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsDigitalAGC2_A7853.Value;
		}

		// Token: 0x06005DC1 RID: 24001 RVA: 0x0053DBC8 File Offset: 0x0053BDC8
		internal static bool ConIsAGCOutputIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)951123968;
			short num2 = num;
			num = (short)1162149888;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)628359169;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC1_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsSecurenetAGC1_A;
				global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC1_A;
				for (;;)
				{
					IL_79:
					switch (num3)
					{
					case 0:
						num = (short)2127233026;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1961230343;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!radProfAudioSettingsAnalogAGC1_A.Value)
						{
							num = (short)18546689;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						if (!audioSettings.RadProfAudioSettingsSecurenetAGC2_A9098.Value)
						{
							num = (short)428736522;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (!radProfAudioSettingsAnalogAGC1_A.Value)
						{
							num = (short)1914634249;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
						{
							num = (short)1160577024;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)210239492;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_23A;
					case 7:
						if (!radProfAudioSettingsSecurenetAGC1_A.Value)
						{
							num = (short)959250438;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						num = (short)1032519683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1025179659;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_283;
					case 11:
						goto IL_18A;
					case 12:
						if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
						{
							num = (short)385417224;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						num = (short)1492975628;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)406966055;
						short num4 = num;
						num = (short)1267257127;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18A;
						default:
							num = (short)983433216;
							if (num != 0)
							{
							}
							num = (short)408420367;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (!radProfAudioSettingsDigitalAGC1_A.Value)
						{
							num = (short)963969037;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_C0;
					IL_18A:
					if (radProfAudioSettingsSecurenetAGC1_A.Value)
					{
						return true;
					}
					num = (short)1791361038;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_23A:
				return radProfAudioSettingsDigitalAGC1_A.Value;
				IL_283:
				return audioSettings.RadProfAudioSettingsDigitalAGC2_A7853.Value;
				IL_C0:
				audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
				radProfAudioSettingsAnalogAGC1_A = audioSettings.RadProfAudioSettingsAnalogAGC1_A7440;
				radProfAudioSettingsSecurenetAGC1_A = audioSettings.RadProfAudioSettingsSecurenetAGC1_A9099;
				radProfAudioSettingsDigitalAGC1_A = audioSettings.RadProfAudioSettingsDigitalAGC1_A7854;
				num = (short)1981218821;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_79;
			}
			}
		}

		// Token: 0x06005DC2 RID: 24002 RVA: 0x0053DF2C File Offset: 0x0053C12C
		internal static bool ConAlertToneInhIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)553713665;
			if (num != 0)
			{
			}
			num = (short)265647328;
			short num2 = num;
			num = (short)376534240;
			switch (num2 == num)
			{
			}
			num = (short)227737600;
			if (num != 0)
			{
			}
			num = (short)535691264;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones).RefRadioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.Value;
		}

		// Token: 0x06005DC3 RID: 24003 RVA: 0x0053DFF4 File Offset: 0x0053C1F4
		internal static bool conIsMaxAlertToneVolGreaterThanOrEqualToMinAlertToneVol(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)544653139;
			short num2 = num;
			num = (short)600162131;
			switch (num2 == num)
			{
			}
			num = (short)255197185;
			if (num != 0)
			{
			}
			num = (short)1034420224;
			if (num != 0)
			{
			}
			num = (short)1092812800;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones alertTones = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AlertTones;
			return alertTones.RadProfAudioSettingsMaximumAlertToneVolume_A21368.Value >= alertTones.RadProfAlertTonesMinimumAlertToneVolume_A8521.Value;
		}

		// Token: 0x06005DC4 RID: 24004 RVA: 0x0053E0C0 File Offset: 0x0053C2C0
		internal static bool conIsMaxAudioVolGreaterThanOrEqualToMinAudioVol(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)508244822;
			short num2 = num;
			num = (short)2003841878;
			switch (num2 == num)
			{
			}
			num = (short)1975517185;
			if (num != 0)
			{
			}
			num = (short)1008336896;
			if (num != 0)
			{
			}
			num = (short)1550843904;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			return audioSettings.RadProfAudioSettingsMaximumAudioVolume_A19577.Value >= audioSettings.RadProfAlertTonesMinimumAudioVolume_A8517.Value;
		}

		// Token: 0x06005DC5 RID: 24005 RVA: 0x0053E18C File Offset: 0x0053C38C
		internal static bool conCustomInternalMicNoiseReductionEnableDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1613621631;
			short num2 = num;
			num = (short)75884927;
			switch (num2 == num)
			{
			}
			num = (short)1090453505;
			if (num != 0)
			{
			}
			num = (short)1050869760;
			if (num != 0)
			{
			}
			num = (short)1823604736;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DC6 RID: 24006 RVA: 0x0053E248 File Offset: 0x0053C448
		internal static bool conCustomExternalMicNoiseReductionEnableDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1600247323;
			short num2 = num;
			num = (short)682219035;
			switch (num2 == num)
			{
			}
			num = (short)1207828481;
			if (num != 0)
			{
			}
			num = (short)2105212928;
			if (num != 0)
			{
			}
			num = (short)2011037696;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DC7 RID: 24007 RVA: 0x0053E300 File Offset: 0x0053C500
		internal static bool ConIsIntMicNoiseReduLevelSeleValidforWind(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)2125529092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_13B;
				case 1:
				{
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A;
					if (radProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A.Value != 0)
					{
						num = (short)1336147973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
				}
				case 2:
					goto IL_B8;
				case 3:
				{
					num = (short)1932591104;
					short num3 = num;
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292;
					num = (short)754778113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					num = (short)531955719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A;
					if (radProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A.Value == 0)
					{
						num = (short)434438144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 7:
					if (index != 0)
					{
						num = (short)2001076226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				IL_44:
				num = (short)694878209;
				if (num != 0)
				{
				}
				if (global::ConstraintHelper.UtilityMack.IsPortable())
				{
					num = (short)520290307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_B8:
				num = (short)607337546;
				short num4 = num;
				num = (short)1955216458;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)900071424;
					if (num != 0)
					{
					}
					num = (short)99090438;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return true;
			IL_13B:
			return index == 0;
		}

		// Token: 0x06005DC8 RID: 24008 RVA: 0x0053E4D4 File Offset: 0x0053C6D4
		internal static bool ConIsExtMicWindNoiseReduLevelSeleValidforWind(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1101725697;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)491257857;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 2:
				{
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A;
					if (radProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A.Value != 0)
					{
						num = (short)566362121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EB;
				}
				case 3:
					goto IL_1EB;
				case 4:
				{
					num = (short)384067852;
					short num3 = num;
					num = (short)455502092;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					case 1:
						break;
					default:
					{
						num = (short)88473600;
						short num4 = num;
						break;
					}
					}
					num = (short)1454964736;
					if (num != 0)
					{
					}
					num = (short)1548943370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A;
					if (radProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A.Value == 0)
					{
						num = (short)270139403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
					global::AcpBusinessLayer.AcpListField radProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A = audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291;
					if (audioSettings.RefRadioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548)
					{
						num = (short)1033895940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)257818626;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					goto IL_B9;
				case 8:
					num = (short)495714310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1836711943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (index != 0)
					{
						num = (short)128057344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					goto IL_225;
				}
				IL_7B:
				if (global::ConstraintHelper.UtilityMack.IsPortable())
				{
					num = (short)1505099784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_B9:
				if (index != 0)
				{
					num = (short)1231355907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_1EB:
				num = (short)1712128005;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_225:
			return index == 0;
		}

		// Token: 0x06005DC9 RID: 24009 RVA: 0x0053E750 File Offset: 0x0053C950
		internal static bool ConBluetoothEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)512142369;
			short num2 = num;
			num = (short)2109713441;
			switch (num2 == num)
			{
			}
			num = (short)1484652544;
			if (num != 0)
			{
			}
			num = (short)1860239361;
			if (num != 0)
			{
			}
			num = (short)254541824;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RefRadioWide.Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
		}

		// Token: 0x06005DCA RID: 24010 RVA: 0x0053E818 File Offset: 0x0053CA18
		internal static bool ConIsIntMicNoiseReduLevelSeleValidforBackground(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1378156561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 0)
					{
						num2 = (short)2075852807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (index == 0)
					{
						num2 = (short)258736147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)1067646997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1802764290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_357;
				case 5:
					goto IL_11A;
				case 6:
					if (index == 3)
					{
						num2 = (short)1164509184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11A;
				case 7:
					return false;
				case 8:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 1)
					{
						num2 = (short)1314390036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					num2 = (short)373162006;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1173880859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)588578845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 0)
					{
						num2 = (short)1035862020;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 13:
					goto IL_150;
				case 14:
					goto IL_420;
				case 15:
					if (index == 4)
					{
						num2 = (short)2039611401;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 16:
					num2 = (short)1043464210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					num2 = (short)896663552;
					short num3 = num2;
					num2 = (short)1541799937;
					if (num2 != 0)
					{
					}
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 1)
					{
						num2 = (short)141099034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 18:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 2)
					{
						num2 = (short)1258356750;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 19:
					num2 = (short)22609921;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					goto IL_4DC;
				case 21:
					num2 = (short)87359494;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 2)
					{
						num2 = (short)1985216536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 23:
					if (index == 1)
					{
						num2 = (short)1027735563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_420;
				case 24:
					goto IL_498;
				case 25:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 2)
					{
						num2 = (short)1378549765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 26:
					num2 = (short)1745092633;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
				{
					num2 = (short)267907270;
					short num4 = num2;
					num2 = (short)797110470;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_150;
					default:
						num2 = (short)4063232;
						if (num2 != 0)
						{
						}
						if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 2)
						{
							num2 = (short)1874853918;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 28:
					if (index == 0)
					{
						num2 = (short)1241382925;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_357;
				case 29:
					if (radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value != 1)
					{
						num2 = (short)1169358864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 30:
					num2 = (short)312606728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (index == 2)
					{
						num2 = (short)1461846026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4DC;
				}
				goto IL_90;
				IL_11A:
				num2 = (short)1524498460;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_150:
				num2 = (short)923205644;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_357:
				num2 = (short)1964310551;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_420:
				num2 = (short)1624244255;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4DC:
				num2 = (short)1235353615;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_498:
			return radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A.Value == 1;
			IL_90:
			radProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194;
			num2 = (short)676462595;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DCB RID: 24011 RVA: 0x0053ED40 File Offset: 0x0053CF40
		internal static bool ConIsExtMicWindNoiseReduLevelSeleValidforBackground(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_F4;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField radProfExternalMicWindNoiseReductionLevelSelection_A;
			bool flag;
			for (;;)
			{
				IL_0A:
				num = (short)2007381466;
				short num2 = num;
				num = (short)993342938;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1120272384;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1163919373;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)356384805;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (index == 3)
						{
							num = (short)2115108865;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297;
					case 3:
						num = (short)1059258370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1750466596;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1464336403;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_4CF;
					case 7:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 2)
						{
							num = (short)1702821889;
							if (num != 0)
							{
							}
							num = (short)1055850530;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)126746629;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1550647313;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_546;
					case 10:
						num = (short)1853816853;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (index == 1)
						{
							num = (short)265748508;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CF;
					case 12:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 1)
						{
							num = (short)956629001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 2)
						{
							num = (short)1846345734;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						if (index == 0)
						{
							num = (short)1553858591;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_417;
					case 15:
						goto IL_1D9;
					case 16:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 0)
						{
							num = (short)1532100631;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						if (index == 0)
						{
							num = (short)1999765533;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
						goto IL_5C7;
					case 19:
						if (flag)
						{
							num = (short)615317504;
							short num4 = num;
							num = (short)1543831578;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					case 20:
						if (index == 4)
						{
							num = (short)535363608;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 1)
						{
							num = (short)2131230724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 22:
						if (!flag)
						{
							num = (short)1136001027;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
						return false;
					case 24:
						num = (short)1990852620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_417;
					case 26:
						goto IL_371;
					case 27:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 0)
						{
							num = (short)1775108121;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 28:
						num = (short)1003159582;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)855244816;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 1)
						{
							num = (short)358285312;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 31:
						num = (short)1181417499;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (index == 2)
						{
							num = (short)739508234;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C7;
					case 33:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 0)
						{
							num = (short)1499987983;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 34:
						goto IL_297;
					case 35:
						num = (short)606076935;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 2)
						{
							num = (short)1945501714;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 37:
						if (radProfExternalMicWindNoiseReductionLevelSelection_A.Value != 1)
						{
							num = (short)595329059;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_F4;
					IL_1D9:
					num = (short)776142870;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_297:
					num = (short)1335164942;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_417:
					num = (short)1170866187;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					num = (short)1077280800;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C7:
					num = (short)147783700;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_371:
				num = (short)1439301665;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_546:
			return radProfExternalMicWindNoiseReductionLevelSelection_A.Value == 2;
			IL_F4:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			radProfExternalMicWindNoiseReductionLevelSelection_A = audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511;
			flag = audioSettings.RefRadioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;
			num = (short)633143304;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06005DCC RID: 24012 RVA: 0x0053F354 File Offset: 0x0053D554
		internal static bool conNoDigAnBalAndAGCChannelEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)889298511;
			short num2 = num;
			num = (short)2039062095;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_104:
				if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
				{
					num = (short)814481428;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1348272136;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)369950720;
				if (num != 0)
				{
				}
				num = (short)593690624;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_D0;
					}
					break;
				}
				break;
			}
			global::AcpBusinessLayer.AcpField<bool> radioProfileAudioSettingsTxDigitalAnalogBalance_A;
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC1_A;
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC1_A;
			for (;;)
			{
				IL_71:
				switch (num3)
				{
				case 0:
					if (radioProfileAudioSettingsTxDigitalAnalogBalance_A.Value)
					{
						num = (short)794624012;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1441988625;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (radProfAudioSettingsDigitalAGC1_A.Value)
					{
						num = (short)925564929;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EE;
				case 3:
					num = (short)409927701;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_104;
				case 5:
					goto IL_2EE;
				case 6:
					if (radProfAudioSettingsAnalogAGC1_A.Value)
					{
						num = (short)519176195;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B0;
				case 7:
					goto IL_2B0;
				case 8:
					if (radioProfileAudioSettingsTxDigitalAnalogBalance_A.Value)
					{
						num = (short)508624897;
						if (num != 0)
						{
						}
						num = (short)898957331;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 9:
					goto IL_2E9;
				case 10:
					num = (short)53477394;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (radProfAudioSettingsDigitalAGC1_A.Value)
					{
						num = (short)121896969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
				{
					num = (short)346030080;
					short num4 = num;
					num = (short)349503503;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					goto IL_17D;
				case 14:
					goto IL_32E;
				case 15:
					if (radProfAudioSettingsAnalogAGC1_A.Value)
					{
						num = (short)956760074;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17D;
				case 16:
					if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
					{
						num = (short)604962830;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 17:
					if (radProfAudioSettingsDigitalAGC1_A.HiddenStatic)
					{
						num = (short)981401605;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 18:
					if (radProfAudioSettingsAnalogAGC1_A.HiddenStatic)
					{
						num = (short)901447693;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 19:
					num = (short)397737990;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)417333248;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (radProfAudioSettingsAnalogAGC1_A.HiddenStatic)
					{
						num = (short)307101703;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_D0;
				IL_17D:
				num = (short)2077949954;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B0:
				num = (short)587005963;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2EE:
				num = (short)1237385232;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_2E9:
			return radProfAudioSettingsDigitalAGC1_A.HiddenStatic;
			IL_32E:
			return !audioSettings.RadProfAudioSettingsDigitalAGC2_A7853.Value;
			IL_D0:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radProfAudioSettingsAnalogAGC1_A = audioSettings.RadProfAudioSettingsAnalogAGC1_A7440;
			radProfAudioSettingsDigitalAGC1_A = audioSettings.RadProfAudioSettingsDigitalAGC1_A7854;
			radioProfileAudioSettingsTxDigitalAnalogBalance_A = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			num = (short)1090846724;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_71;
		}

		// Token: 0x06005DCD RID: 24013 RVA: 0x0053F790 File Offset: 0x0053D990
		internal static bool conDigAnBalSetToPerProfile(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)569392072;
			short num2 = num;
			num = (short)762526664;
			switch (num2 == num)
			{
			}
			num = (short)1741750272;
			short num3 = num;
			num = (short)1374158849;
			if (num != 0)
			{
			}
			num = (short)225640448;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851.Value == 2;
		}

		// Token: 0x06005DCE RID: 24014 RVA: 0x0053F858 File Offset: 0x0053DA58
		internal static bool conIntAnaAGCRadWideRadProfTxDigAnaBalMutExclusive(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			global::AcpBusinessLayer.AcpListField radWideLabtoolDigitalAnalogBalance_A;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC1_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_11E;
				case 1:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num2 = (short)736100352;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1784020992;
					short num3 = num2;
					num2 = (short)168099843;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!radProfAudioSettingsAnalogAGC1_A.HiddenStatic)
					{
						num2 = (short)1399193604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_1A6;
				case 5:
					if (radProfAudioSettingsAnalogAGC1_A.Value)
					{
						num2 = (short)128909314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
			}
			IL_11E:
			num2 = (short)2115633153;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			return !audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			IL_28:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radProfAudioSettingsAnalogAGC1_A = audioSettings.RadProfAudioSettingsAnalogAGC1_A7440;
			radWideLabtoolDigitalAnalogBalance_A = audioSettings.RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851;
			radWideLabtoolDigitalAnalogBalance_A.CalculateValidity();
			num2 = (short)1106207838;
			short num4 = num2;
			num2 = (short)794715230;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A6:
				num2 = (short)272629761;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)921501696;
				if (num2 != 0)
				{
				}
				num2 = (short)1025114117;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06005DCF RID: 24015 RVA: 0x0053FA14 File Offset: 0x0053DC14
		internal static bool conIntDigAGCRadWideRadProfTxDigAnaBalMutExclusive(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			global::AcpBusinessLayer.AcpListField radWideLabtoolDigitalAnalogBalance_A;
			short num2;
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC1_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_141;
				case 1:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num2 = (short)211353600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1562443776;
					short num3 = num2;
					num2 = (short)1991901187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!radProfAudioSettingsDigitalAGC1_A.HiddenStatic)
					{
						num2 = (short)1058996228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_1A2;
				case 5:
					num2 = (short)1361117185;
					if (num2 != 0)
					{
					}
					if (radProfAudioSettingsDigitalAGC1_A.Value)
					{
						num2 = (short)543948802;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
			}
			IL_141:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			return !audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			IL_28:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radProfAudioSettingsDigitalAGC1_A = audioSettings.RadProfAudioSettingsDigitalAGC1_A7854;
			radWideLabtoolDigitalAnalogBalance_A = audioSettings.RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851;
			radWideLabtoolDigitalAnalogBalance_A.CalculateValidity();
			num2 = (short)1626620578;
			short num4 = num2;
			num2 = (short)2032353954;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1A2:
				num2 = (short)2117926913;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1051000832;
				if (num2 != 0)
				{
				}
				num2 = (short)1251737605;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06005DD0 RID: 24016 RVA: 0x0053FBCC File Offset: 0x0053DDCC
		internal static bool conExtAnaAGCRadWideRadProfTxDigAnaBalMutExclusive(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)233246435;
			short num2 = num;
			num = (short)1557401315;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_163:
				num = (short)1087897604;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1001586688;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				break;
			}
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC2_A;
			global::AcpBusinessLayer.AcpListField radWideLabtoolDigitalAnalogBalance_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					if (radProfAudioSettingsAnalogAGC2_A.Value)
					{
						num = (short)375783431;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num = (short)1995767814;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_229;
				case 2:
					goto IL_19E;
				case 3:
					goto IL_1E9;
				case 4:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num = (short)455147522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					if (radProfAudioSettingsAnalogAGC2_A.Value)
					{
						num = (short)1651769347;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					goto IL_15F;
				case 7:
					num = (short)1831403521;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						num = (short)1000538121;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1645543424;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)459603973;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_82;
			}
			IL_15F:
			return !audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			IL_19E:
			return !audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;
			IL_1E9:
			goto IL_163;
			IL_229:
			num = (short)1434583041;
			if (num != 0)
			{
			}
			return false;
			IL_82:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radProfAudioSettingsAnalogAGC2_A = audioSettings.RadProfAudioSettingsAnalogAGC2_A7439;
			radWideLabtoolDigitalAnalogBalance_A = audioSettings.RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851;
			radWideLabtoolDigitalAnalogBalance_A.CalculateValidity();
			num = (short)1964834816;
			short num4 = num;
			num = (short)49545224;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x06005DD1 RID: 24017 RVA: 0x0053FE3C File Offset: 0x0053E03C
		internal static bool conExtDigAGCRadWideRadProfTxDigAnaBalMutExclusive(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1688382572;
			short num2 = num;
			num = (short)2111941740;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_15A:
				num = (short)1167523844;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1624113152;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_81;
				}
				break;
			}
			global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC2_A;
			global::AcpBusinessLayer.AcpListField radWideLabtoolDigitalAnalogBalance_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
					if (radProfAudioSettingsDigitalAGC2_A.Value)
					{
						num = (short)1250492423;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num = (short)1217069062;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_195;
				case 3:
					goto IL_209;
				case 4:
					if (radWideLabtoolDigitalAnalogBalance_A.Value != 1)
					{
						num = (short)38010882;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					if (radProfAudioSettingsDigitalAGC2_A.Value)
					{
						num = (short)648019971;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					goto IL_156;
				case 7:
					num = (short)92274689;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						num = (short)851705865;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)513933312;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)824115205;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_81;
			}
			IL_156:
			return !audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			IL_195:
			num = (short)93454337;
			if (num != 0)
			{
			}
			return !audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;
			IL_209:
			goto IL_15A;
			IL_81:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radProfAudioSettingsDigitalAGC2_A = audioSettings.RadProfAudioSettingsDigitalAGC2_A7853;
			radWideLabtoolDigitalAnalogBalance_A = audioSettings.RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851;
			radWideLabtoolDigitalAnalogBalance_A.CalculateValidity();
			num = (short)2029453312;
			short num4 = num;
			num = (short)385875976;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x06005DD2 RID: 24018 RVA: 0x005400AC File Offset: 0x0053E2AC
		internal static bool ConNVGEnabledAndPermanentFrDisplayBackLightEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General;
			if (general.RadProfNVGEnable_A41615)
			{
				short num = (short)130416640;
				short num2 = num;
				num = (short)1966122353;
				short num3 = num;
				num = (short)1799202161;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1829699585;
					if (num != 0)
					{
					}
					num = (short)275709952;
					if (num != 0)
					{
					}
					break;
				}
				return !general.PermanentFrontDisplayBacklight_A22337;
			}
			return true;
		}

		// Token: 0x06005DD3 RID: 24019 RVA: 0x00540180 File Offset: 0x0053E380
		internal static bool ConNVGEnabledAndPermanentDisableTxRxLEDEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1341784065;
			if (num != 0)
			{
			}
			num = (short)216530944;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General;
			if (general.RadProfNVGEnable_A41615)
			{
				num = (short)2070808815;
				short num3 = num;
				num = (short)1540229359;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1317601280;
					if (num != 0)
					{
					}
					break;
				}
				return general.RadProfPermanentDisableTxRxLED_A41609;
			}
			return true;
		}

		// Token: 0x06005DD4 RID: 24020 RVA: 0x0054024C File Offset: 0x0053E44C
		internal static bool ConNVGEnabledAndDisableLightEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General;
			if (general.RadProfNVGEnable_A41615)
			{
				short num = (short)2057109504;
				short num2 = num;
				num = (short)795050354;
				short num3 = num;
				num = (short)81101170;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)486735872;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)298909697;
				if (num != 0)
				{
				}
				return !general.RadProfGeneralDisableLights_A7866;
			}
			return true;
		}

		// Token: 0x06005DD5 RID: 24021 RVA: 0x00540320 File Offset: 0x0053E520
		internal static bool ConNVGEnabledAndDisableEmerNotifyEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1248329729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (general.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171)
					{
						goto IL_C6;
					}
					return true;
				case 2:
				{
					num2 = (short)1061464147;
					short num3 = num2;
					num2 = (short)1535879251;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C6;
					default:
						goto IL_112;
					}
					break;
				}
				case 3:
					if (!general.RadProfNVGEnable_A41615)
					{
						num2 = (short)1262747648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_89;
				}
				goto IL_20;
				IL_C6:
				num2 = (short)1270939650;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_89:
			return general.RadProfGeneralDisableEmergencyAlertsNotification_A19570;
			IL_112:
			num2 = (short)117833728;
			short num4 = num2;
			num2 = (short)1447231488;
			if (num2 != 0)
			{
			}
			goto IL_89;
			IL_20:
			num2 = (short)463798273;
			if (num2 != 0)
			{
			}
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General);
			num2 = (short)1246363651;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DD6 RID: 24022 RVA: 0x00540484 File Offset: 0x0053E684
		internal static bool ConNVGEnabledAndDisableCriticalNotifyEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)295698433;
					if (num2 != 0)
					{
					}
					num2 = (short)1929838593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (general.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171)
					{
						goto IL_C4;
					}
					return true;
				case 2:
				{
					num2 = (short)389297120;
					short num3 = num2;
					num2 = (short)1347171296;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C4;
					default:
						goto IL_112;
					}
					break;
				}
				case 3:
					if (!general.RadProfNVGEnable_A41615)
					{
						num2 = (short)771227648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_87;
				}
				goto IL_20;
				IL_C4:
				num2 = (short)2062286850;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_87:
			return general.RadProfGeneralDisableCriticalAlertsNotification_A19571;
			IL_112:
			num2 = (short)1228472320;
			short num4 = num2;
			num2 = (short)394330112;
			if (num2 != 0)
			{
			}
			goto IL_87;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General);
			num2 = (short)625410051;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DD7 RID: 24023 RVA: 0x005405EC File Offset: 0x0053E7EC
		internal static bool ConNVGEnabledAndDisableCallNotifyEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)903610369;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (general.RefDisplayAndMenu.Advanced.DisplMenuAdvancedTopLightColorPerChannel_A43171)
					{
						goto IL_99;
					}
					return true;
				case 2:
				{
					num2 = (short)975070131;
					short num3 = num2;
					num2 = (short)228746163;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_99;
					default:
						goto IL_E5;
					}
					break;
				}
				case 3:
					if (!general.RadProfNVGEnable_A41615)
					{
						num2 = (short)737280000;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5F;
				}
				goto IL_20;
				IL_99:
				num2 = (short)546439170;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_5F:
			return general.RadProfGeneralDisableCallAlertsNotification_A19572;
			IL_E5:
			num2 = (short)1816657921;
			if (num2 != 0)
			{
			}
			num2 = (short)2089615360;
			short num4 = num2;
			num2 = (short)559480832;
			if (num2 != 0)
			{
			}
			goto IL_5F;
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General);
			num2 = (short)511180803;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DD8 RID: 24024 RVA: 0x00540748 File Offset: 0x0053E948
		internal static bool conPermanentDisableTxRxLEDIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1163700068;
			short num2 = num;
			num = (short)630892388;
			switch (num2 == num)
			{
			}
			num = (short)1546518529;
			if (num != 0)
			{
			}
			num = (short)1503592448;
			if (num != 0)
			{
			}
			num = (short)664666112;
			short num3 = num;
			return !(self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.General).RadProfGeneralDisableLights_A7866;
		}

		// Token: 0x06005DD9 RID: 24025 RVA: 0x00540804 File Offset: 0x0053EA04
		internal static bool conIsMicPassAlramFilterApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)539183667;
			short num2 = num;
			num = (short)851003955;
			switch (num2 == num)
			{
			}
			num = (short)2077687809;
			if (num != 0)
			{
			}
			num = (short)356974592;
			if (num != 0)
			{
			}
			num = (short)1457061888;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			bool value = audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.Value;
			bool flag = audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292.Value == 0 && audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194.Value == 0;
			return !value && !flag;
		}

		// Token: 0x06005DDA RID: 24026 RVA: 0x005408E8 File Offset: 0x0053EAE8
		internal static bool conIsExtPassAlramFilterApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1112670209;
			if (num != 0)
			{
			}
			num = (short)110484764;
			short num2 = num;
			num = (short)1125047580;
			switch (num2 == num)
			{
			}
			num = (short)2064187392;
			if (num != 0)
			{
			}
			num = (short)1155596288;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			bool value = audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.Value;
			bool flag = audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291.Value == 0 && audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511.Value == 0;
			return !value && !flag;
		}

		// Token: 0x06005DDB RID: 24027 RVA: 0x005409CC File Offset: 0x0053EBCC
		internal static void conNoiseReductionRadioGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			global::AcpBusinessLayer.AcpListField noiseReductionGroupSettingRadio_;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (noiseReductionGroupSettingRadio_.Value == 1)
					{
						num2 = (short)826605571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1186988040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_17A;
				case 2:
					if (noiseReductionGroupSettingRadio_.Value == 5)
					{
						num2 = (short)165478410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					goto IL_7E;
				case 4:
					return;
				case 5:
					if (noiseReductionGroupSettingRadio_.Value == 3)
					{
						num2 = (short)893976585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)899743746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_359;
				case 7:
					if (noiseReductionGroupSettingRadio_.Value == 2)
					{
						num2 = (short)382861318;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1944453125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (noiseReductionGroupSettingRadio_.Value == 0)
					{
						num2 = (short)2030567425;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1139605511;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_2B5;
				case 10:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294, false));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292, 4));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194, 1));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382, true));
					num2 = (short)1599995908;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_3C;
			}
			IL_7E:
			num2 = (short)1500933714;
			short num3 = num2;
			num2 = (short)1317170770;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_359:
				num2 = (short)1970667520;
				short num4 = num2;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294, false));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292, 2));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194, 1));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382, false));
				return;
			}
			default:
				num2 = (short)673513472;
				if (num2 != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294, false));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382, false));
				return;
			}
			IL_17A:
			num2 = (short)880672769;
			if (num2 != 0)
			{
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294, false));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292, 1));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194, 1));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382, false));
			return;
			IL_2B5:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294, false));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicGeneralNoiseReductionLevelSelection_A22292, 3));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsInternalMicWindNoiseReductionLevelSelection_A22194, 1));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsIntMicPassAlarmFilter_A42382, true));
			return;
			IL_3C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			noiseReductionGroupSettingRadio_ = audioSettings.NoiseReductionGroupSettingRadio_42584;
			num2 = (short)1885929472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DDC RID: 24028 RVA: 0x00540D80 File Offset: 0x0053EF80
		internal static bool conCustomRadioMicNoiseReductionEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)415468395;
			short num2 = num;
			num = (short)10259307;
			switch (num2 == num)
			{
			}
			num = (short)1535967233;
			if (num != 0)
			{
			}
			num = (short)1684078592;
			if (num != 0)
			{
			}
			num = (short)771948544;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DDD RID: 24029 RVA: 0x00540E3C File Offset: 0x0053F03C
		internal static bool conCustomAccMicNoiseReductionEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1681549940;
			short num2 = num;
			num = (short)1204906612;
			switch (num2 == num)
			{
			}
			num = (short)571932673;
			if (num != 0)
			{
			}
			num = (short)1566638080;
			if (num != 0)
			{
			}
			num = (short)1784545280;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DDE RID: 24030 RVA: 0x00540EF8 File Offset: 0x0053F0F8
		internal static void conNoiseReductionAccessoryGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				int num;
				bool flag;
				global::AcpBusinessLayer.AcpListField noiseReductionGroupSettingAccessory_;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291, 2));
						num2 = (short)260505605;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291, 3));
						num2 = (short)1670184964;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_1A4;
					case 3:
						goto IL_DC;
					case 4:
					{
						if (!flag)
						{
							num2 = (short)732889108;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1428422656;
						short num3 = num2;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 0));
						num2 = (short)618135567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						if (!flag)
						{
							num2 = (short)2104950791;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 0));
						num2 = (short)125042709;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291, 1));
						num2 = (short)1195311128;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 1));
						num2 = (short)477822998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (noiseReductionGroupSettingAccessory_.Value == 2)
						{
							num2 = (short)705888256;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1609170955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						if (noiseReductionGroupSettingAccessory_.Value == 1)
						{
							num2 = (short)1251147779;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1059258391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 10:
						goto IL_4F8;
					case 11:
						if (noiseReductionGroupSettingAccessory_.Value == 3)
						{
							num2 = (short)1905000449;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)646447129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						num2 = (short)584843265;
						if (num2 != 0)
						{
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 1));
						num2 = (short)913637390;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						if (!flag)
						{
							num2 = (short)297336844;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 0));
						num2 = (short)1825112080;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						goto IL_31C;
					case 15:
						goto IL_134;
					case 16:
						goto IL_31C;
					case 17:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291, 4));
						num2 = (short)1344798733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 18:
						goto IL_41B;
					case 19:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 1));
						num2 = (short)1573781522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 20:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 1));
						num2 = (short)1495400458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 21:
						goto IL_526;
					case 22:
						goto IL_48A;
					case 23:
						if (noiseReductionGroupSettingAccessory_.Value == 0)
						{
							num2 = (short)1448935430;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)955973640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 24:
						if (!flag)
						{
							num2 = (short)114098195;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 0));
						num2 = (short)1688010754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 25:
						if (noiseReductionGroupSettingAccessory_.Value == 5)
						{
							num2 = (short)315424785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5C6;
					case 26:
						goto IL_346;
					}
					goto IL_7C;
					IL_31C:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386, true));
					num2 = (short)1740046362;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_5C6:
				num2 = (short)1645016871;
				short num4 = num2;
				num2 = (short)870053671;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_5FB;
				}
				IL_346:
				goto IL_5C6;
				IL_7C:
				audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
				noiseReductionGroupSettingAccessory_ = audioSettings.NoiseReductionGroupSettingAccessory_42585;
				flag = audioSettings.RefRadioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;
				num2 = (short)1755119625;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_DC:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294, false));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsExternalMicGeneralNoiseReductionLevelSelection_A22291, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfExternalMicWindNoiseReductionLevelSelection_A21511, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386, false));
			return;
			IL_134:
			goto IL_28D;
			IL_1A4:
			goto IL_2DE;
			IL_28D:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386, true));
			return;
			IL_2CB:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386, false));
			return;
			IL_2DE:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadProfAudioSettingsExternalMicPassAlarmFilter_A42386, false));
			return;
			IL_41B:
			goto IL_2DE;
			IL_48A:
			goto IL_2CB;
			IL_4F8:
			goto IL_28D;
			IL_526:
			goto IL_2CB;
			IL_5FB:
			num2 = (short)1274478592;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x06005DDF RID: 24031 RVA: 0x00541518 File Offset: 0x0053F718
		internal static void conGainSensitivityRadioGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)762773504;
			switch (num)
			{
			default:
			{
				num = (short)254149784;
				short num2 = num;
				num = (short)1806435480;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_320:
					num = (short)2092236804;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)993591296;
					if (num != 0)
					{
					}
					num = (short)880607232;
					short num4 = num;
					num = (short)685047810;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					global::AcpBusinessLayer.AcpListField gainSensitivityGroupSettingAccessory_;
					global::AcpBusinessLayer.AcpListField gainSensitivityGroupSettingRadio_;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						goto IL_320;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					case 3:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(gainSensitivityGroupSettingAccessory_, gainSensitivityGroupSettingRadio_.Value));
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conGainSensitivityAccessoryGroupSettingValueSetter(self, task);
						num = (short)486146048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (gainSensitivityGroupSettingRadio_.Value != gainSensitivityGroupSettingAccessory_.Value)
						{
							num = (short)2064777219;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_C9:
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
					gainSensitivityGroupSettingRadio_ = audioSettings.GainSensitivityGroupSettingRadio_42608;
					gainSensitivityGroupSettingAccessory_ = audioSettings.GainSensitivityGroupSettingAccessory_42610;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC1_A = audioSettings.RadProfAudioSettingsAnalogAGC1_A7440;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC1_A = audioSettings.RadProfAudioSettingsDigitalAGC1_A7854;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsSecurenetAGC1_A = audioSettings.RadProfAudioSettingsSecurenetAGC1_A9099;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsAnalogFixedGain1_A = audioSettings.RadProfAudioSettingsAnalogFixedGain1_A7442;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsDigitalFixedGain1_A = audioSettings.RadProfAudioSettingsDigitalFixedGain1_A7856;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsSecurenetFixedGain1_A = audioSettings.RadProfAudioSettingsSecurenetFixedGain1_A9100;
					global::AcpBusinessLayer.AcpField<bool> radioProfileAudioSettingsTxDigitalAnalogBalance_A = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsOutput_A = audioSettings.RadProfAudioSettingsOutput_A8679;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsTotal_A = audioSettings.RadProfAudioSettingsTotal_A9394;
					if (gainSensitivityGroupSettingRadio_.Value == 0)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsOutput_A, 0));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsTotal_A, 6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsTxDigitalAnalogBalance_A, false));
					}
					else if (gainSensitivityGroupSettingRadio_.Value == 1)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsAnalogFixedGain1_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsDigitalFixedGain1_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsSecurenetFixedGain1_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsTxDigitalAnalogBalance_A, true));
					}
					else if (gainSensitivityGroupSettingRadio_.Value == 2)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC1_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsOutput_A, 6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsTotal_A, 9));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsTxDigitalAnalogBalance_A, false));
					}
					else if (gainSensitivityGroupSettingRadio_.Value == 3)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC1_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsAnalogFixedGain1_A, -9));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsDigitalFixedGain1_A, -9));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsSecurenetFixedGain1_A, -9));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsTxDigitalAnalogBalance_A, true));
					}
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value != 0)
					{
						break;
					}
					num = (short)1431306241;
					if (num != 0)
					{
					}
					num = (short)1863647233;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x005418BC File Offset: 0x0053FABC
		internal static void conGainSensitivityAccessoryGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1982791680;
			switch (num)
			{
			default:
			{
				num = (short)1839663088;
				short num2 = num;
				num = (short)1033439216;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_329:
					num = (short)903675908;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)21037057;
					if (num != 0)
					{
					}
					num = (short)921305088;
					short num4 = num;
					num = (short)13762560;
					if (num != 0)
					{
					}
					num = (short)1938227202;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					global::AcpBusinessLayer.AcpListField gainSensitivityGroupSettingRadio_;
					global::AcpBusinessLayer.AcpListField gainSensitivityGroupSettingAccessory_;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						goto IL_329;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F9;
						}
						continue;
					case 3:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(gainSensitivityGroupSettingRadio_, gainSensitivityGroupSettingAccessory_.Value));
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conGainSensitivityRadioGroupSettingValueSetter(self, task);
						num = (short)602406912;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (gainSensitivityGroupSettingRadio_.Value != gainSensitivityGroupSettingAccessory_.Value)
						{
							num = (short)1091174403;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_F9:
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
					gainSensitivityGroupSettingRadio_ = audioSettings.GainSensitivityGroupSettingRadio_42608;
					gainSensitivityGroupSettingAccessory_ = audioSettings.GainSensitivityGroupSettingAccessory_42610;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsAnalogAGC2_A = audioSettings.RadProfAudioSettingsAnalogAGC2_A7439;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsDigitalAGC2_A = audioSettings.RadProfAudioSettingsDigitalAGC2_A7853;
					global::AcpBusinessLayer.AcpField<bool> radProfAudioSettingsSecurenetAGC2_A = audioSettings.RadProfAudioSettingsSecurenetAGC2_A9098;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsAnalogFixedGain2_A = audioSettings.RadProfAudioSettingsAnalogFixedGain2_A7441;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsDigitalFixedGain2_A = audioSettings.RadProfAudioSettingsDigitalFixedGain2_A7855;
					global::AcpBusinessLayer.AcpRangeField<int, string> radProfAudioSettingsSecurenetFixedGain2_A = audioSettings.RadProfAudioSettingsSecurenetFixedGain2_A9101;
					global::AcpBusinessLayer.AcpField<bool> radioProfileAudioSettingsDigitalAnalogBalanceAccessory_ = audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661;
					global::AcpBusinessLayer.AcpRangeField<int, int> agcgainControlOutputAccessory_ = audioSettings.AGCGainControlOutputAccessory_42644;
					global::AcpBusinessLayer.AcpRangeField<int, int> agcgainControlTotalAccessory_ = audioSettings.AGCGainControlTotalAccessory_42645;
					if (gainSensitivityGroupSettingAccessory_.Value == 0)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(agcgainControlOutputAccessory_, 0));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(agcgainControlTotalAccessory_, 6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsDigitalAnalogBalanceAccessory_, false));
					}
					else if (gainSensitivityGroupSettingAccessory_.Value == 1)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsAnalogFixedGain2_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsDigitalFixedGain2_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsSecurenetFixedGain2_A, -6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsDigitalAnalogBalanceAccessory_, true));
					}
					else if (gainSensitivityGroupSettingAccessory_.Value == 2)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC2_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(agcgainControlOutputAccessory_, 6));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(agcgainControlTotalAccessory_, 9));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsDigitalAnalogBalanceAccessory_, false));
					}
					else if (gainSensitivityGroupSettingAccessory_.Value == 3)
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsAnalogAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsDigitalAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radProfAudioSettingsSecurenetAGC2_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsAnalogFixedGain2_A, -12));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsDigitalFixedGain2_A, -12));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radProfAudioSettingsSecurenetFixedGain2_A, -12));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioProfileAudioSettingsDigitalAnalogBalanceAccessory_, true));
					}
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value != 0)
					{
						break;
					}
					num = (short)288358401;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x00541C6C File Offset: 0x0053FE6C
		internal static void conAudioEqualizationRadioGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_7F;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingRadio_;
			for (;;)
			{
				IL_0A:
				num = (short)1354104832;
				short num2 = num;
				num = (short)814743553;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (audioEqualizationGroupSettingRadio_.Value == 0)
					{
						num = (short)914030597;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1042219012;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (audioEqualizationGroupSettingRadio_.Value == 3)
					{
						num = (short)1304821763;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AA;
				case 2:
					if (audioEqualizationGroupSettingRadio_.Value == 2)
					{
						num = (short)1778647047;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)526057473;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_26E;
				case 4:
					if (audioEqualizationGroupSettingRadio_.Value == 1)
					{
						num = (short)854523910;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)734265346;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_C6;
				case 6:
					goto IL_178;
				case 7:
					goto IL_13E;
				}
				goto IL_7F;
			}
			IL_C6:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandRadio_42638, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandRadio_42640, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandRadio_42642, 0));
			return;
			IL_13E:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandRadio_42638, -9));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandRadio_42640, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandRadio_42642, 0));
			return;
			IL_178:
			num = (short)2089104877;
			short num4 = num;
			num = (short)1596601837;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2AA:
				int value = audioEqualizationGroupSettingRadio_.Value;
				return;
			}
			default:
				num = (short)1667694592;
				if (num != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandRadio_42638, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandRadio_42640, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandRadio_42642, 6));
				return;
			}
			IL_26E:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandRadio_42638, -3));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandRadio_42640, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandRadio_42642, 6));
			return;
			IL_7F:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			audioEqualizationGroupSettingRadio_ = audioSettings.AudioEqualizationGroupSettingRadio_42613;
			num = (short)896532480;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x00541F2C File Offset: 0x0054012C
		internal static void conAudioEqualizationAccessoryGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingAccessory_;
			for (;;)
			{
				IL_0A:
				num = (short)1313865728;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (audioEqualizationGroupSettingAccessory_.Value == 0)
					{
						num = (short)54067205;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1224605700;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (audioEqualizationGroupSettingAccessory_.Value == 3)
					{
						num = (short)777519107;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AD;
				case 2:
					if (audioEqualizationGroupSettingAccessory_.Value == 2)
					{
						num = (short)1809645575;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2104819713;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_271;
				case 4:
					if (audioEqualizationGroupSettingAccessory_.Value == 1)
					{
						num = (short)1039532038;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)55836674;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_9F;
				case 6:
					goto IL_152;
				case 7:
					goto IL_118;
				}
				goto IL_59;
			}
			IL_9F:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandAccessory_42639, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandAccessory_42641, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandAccessory_42643, 0));
			return;
			IL_118:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandAccessory_42639, -9));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandAccessory_42641, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandAccessory_42643, 0));
			return;
			IL_152:
			num = (short)378468742;
			short num4 = num;
			num = (short)439744902;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2AD:
				int value = audioEqualizationGroupSettingAccessory_.Value;
				return;
			}
			default:
				num = (short)401014784;
				if (num != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandAccessory_42639, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandAccessory_42641, 0));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandAccessory_42643, 6));
				return;
			}
			IL_271:
			num = (short)1495531521;
			if (num != 0)
			{
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.LowFrequencyBandAccessory_42639, -3));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.MidFrequencyBandAccessory_42641, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.HighFrequencyBandAccessory_42643, 6));
			return;
			IL_59:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			audioEqualizationGroupSettingAccessory_ = audioSettings.AudioEqualizationGroupSettingAccessory_42614;
			num = (short)1537605632;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x005421F0 File Offset: 0x005403F0
		internal static void conSpeakerRXSettingsAudioEqualizationAccessoryGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			short num2;
			global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingAccessory_;
			global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingRadio_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogLowFrequencyBandAccessory_42647, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandAccessory_42649, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalLowFrequencyBandAccessory_42652, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandAccessory_42654, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetLowFrequencyBandAccessory_42657, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandAccessory_42659, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, 0));
					num2 = (short)1732182016;
					short num3 = num2;
					num2 = (short)1150943234;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					if (audioEqualizationGroupSettingAccessory_.Value == 3)
					{
						num2 = (short)1892679685;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int value = audioEqualizationGroupSettingAccessory_.Value;
					num2 = (short)1537736708;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_278;
				case 3:
					if (audioEqualizationGroupSettingAccessory_.Value == 2)
					{
						num2 = (short)1287192585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				case 4:
					goto IL_278;
				case 5:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogLowFrequencyBandAccessory_42647, -6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandAccessory_42649, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, -6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalLowFrequencyBandAccessory_42652, -6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandAccessory_42654, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, -6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetLowFrequencyBandAccessory_42657, -6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandAccessory_42659, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, -6));
					num2 = (short)37093386;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (audioEqualizationGroupSettingAccessory_.Value == 0)
					{
						num2 = (short)75825152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1403125775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
					{
						num2 = (short)1010302989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogLowFrequencyBandAccessory_42647, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandAccessory_42649, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, 6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalLowFrequencyBandAccessory_42652, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandAccessory_42654, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, 6));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetLowFrequencyBandAccessory_42657, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandAccessory_42659, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, 6));
					num2 = (short)848953358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogLowFrequencyBandAccessory_42647, -9));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandAccessory_42649, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalLowFrequencyBandAccessory_42652, -9));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandAccessory_42654, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetLowFrequencyBandAccessory_42657, -9));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandAccessory_42659, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, 0));
					num2 = (short)192151564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_278;
				case 11:
					if (audioEqualizationGroupSettingRadio_.Value != audioEqualizationGroupSettingAccessory_.Value)
					{
						num2 = (short)1986658321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 12:
					goto IL_278;
				case 13:
					num2 = (short)1184956417;
					if (num2 != 0)
					{
					}
					num2 = (short)619970571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_278;
				case 15:
					if (audioEqualizationGroupSettingAccessory_.Value == 1)
					{
						num2 = (short)1678442504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)686424067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					num2 = (short)224739271;
					short num4 = num2;
					num2 = (short)1358249927;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						goto IL_353;
					}
					break;
				}
				case 17:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioEqualizationGroupSettingRadio_, audioEqualizationGroupSettingAccessory_.Value));
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conSpeakerRXSettingsAudioEqualizationRadioGroupSettingValueSetter(self, task);
					num2 = (short)1349976080;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_58;
				IL_CD:
				num2 = (short)553910273;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_278:
				num2 = (short)1987510279;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_353:
			num2 = (short)307494912;
			if (num2 != 0)
			{
			}
			return;
			IL_58:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			audioEqualizationGroupSettingAccessory_ = audioSettings.AudioEqualizationGroupSettingAccessory_42605;
			audioEqualizationGroupSettingRadio_ = audioSettings.AudioEqualizationGroupSettingRadio_42604;
			num2 = (short)2082603014;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x005427F4 File Offset: 0x005409F4
		internal static void conSpeakerRXSettingsAudioEqualizationRadioGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1959985152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_113;
				}
				global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingRadio_;
				global::AcpBusinessLayer.AcpListField audioEqualizationGroupSettingAccessory_;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (audioEqualizationGroupSettingRadio_.Value != audioEqualizationGroupSettingAccessory_.Value)
						{
							num = (short)737411104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_159;
					case 2:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1224671257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C17;
					case 3:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506, 0));
						num = (short)1123745833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506, -6));
						num = (short)1855455286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (audioEqualizationGroupSettingRadio_.Value == 2)
						{
							num = (short)131268626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)50331662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)462815232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_63E;
					case 8:
						goto IL_69C;
					case 9:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1308688387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_414;
					case 10:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506, 0));
						num = (short)2048917523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2D9;
					case 12:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)2087190572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E2;
					case 13:
						goto IL_34D;
					case 14:
						if (audioEqualizationGroupSettingRadio_.Value == 3)
						{
							num = (short)1974272022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC8;
					case 15:
						goto IL_BC8;
					case 16:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)307036205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE3;
					case 17:
					{
						num = (short)37486592;
						short num3 = num;
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)594149411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					}
					case 18:
						num = (short)1812987916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_1D5;
					case 20:
						if (audioSettings == null)
						{
							num = (short)160956467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 21:
						num = (short)716963841;
						if (num != 0)
						{
						}
						goto IL_C17;
					case 22:
						num = (short)1486290977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return;
					case 24:
						goto IL_267;
					case 25:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507, -9));
						num = (short)1869348885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508, -6));
						num = (short)2076835851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num = (short)775618566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						goto IL_BC8;
					case 29:
						num = (short)1204813833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_6DE;
					case 31:
						if (audioEqualizationGroupSettingRadio_.Value == 1)
						{
							num = (short)1586102301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1827536901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioEqualizationGroupSettingAccessory_, audioEqualizationGroupSettingRadio_.Value));
						global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfilesConstraints.conSpeakerRXSettingsAudioEqualizationAccessoryGroupSettingValueSetter(self, task);
						num = (short)312016919;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1658978308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B3;
					case 34:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)600637466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 35:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508, -9));
						num = (short)1074462721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_AE3;
					case 37:
						if (audioEqualizationGroupSettingRadio_.Value == 0)
						{
							num = (short)1971060791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2051866655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_981;
					case 39:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508, 0));
						num = (short)637337608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_BC8;
					case 41:
						goto IL_414;
					case 42:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)214761479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34D;
					case 43:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)320733223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69C;
					case 44:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolAnalogBassControl_A19506, -9));
						num = (short)746455087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolSecurenetBassControl_A19508, 0));
						num = (short)1615003684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1320878128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6DE;
					case 47:
						goto IL_9E2;
					case 48:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507, -6));
						num = (short)1165885470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						try
						{
							num = (short)894828549;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.GetType() == typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA))
									{
										goto IL_527;
									}
									break;
								}
								case 1:
									goto IL_5CA;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1606483974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
									num = (short)750321664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1745832707;
									short num4 = num;
									num = (short)807619331;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_527;
									default:
										goto IL_598;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									labtoolRAD_PROF_CDA = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
									num = (short)496500739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_4B6;
									}
									continue;
								case 6:
									num = (short)234291201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4B8:
								num = (short)1284112386;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4B6:
								goto IL_4B8;
								IL_527:
								num = (short)3407876;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_598:
							num = (short)349437952;
							if (num != 0)
							{
							}
							IL_5CA:
							goto IL_B6A;
						}
						finally
						{
							num = (short)1361969154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1290207233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_63B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_601;
									}
									continue;
								}
								IL_601:
								if (enumerator == null)
								{
									break;
								}
								num = (short)668729344;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_63B:;
						}
						goto IL_63E;
						IL_B6A:
						num = (short)1197408276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1394343992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_981;
					case 51:
						audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
						num = (short)1866989592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)602406922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D5;
					case 53:
						goto IL_BC8;
					case 54:
						goto IL_8B3;
					case 55:
						num = (short)1500971060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507, 0));
						num = (short)1491861542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_113;
					IL_159:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandRadio_42658, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, 0));
					num = (short)1826291740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D5:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandRadio_42648, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, 0));
					num = (short)1049100330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_267:
					num = (short)922943525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D9:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandRadio_42658, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, -6));
					num = (short)964100149;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34D:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandRadio_42653, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, 0));
					num = (short)147652651;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_414:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandRadio_42648, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, 6));
					num = (short)625672242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63E:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(labtoolRAD_PROF_CDA.RadProfLabtoolDigitalBassControl_A19507, 0));
					num = (short)1706622989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69C:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandRadio_42658, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, 0));
					num = (short)1839267880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6DE:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandRadio_42653, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, -6));
					num = (short)1627914274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B3:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandRadio_42648, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, -6));
					num = (short)299237422;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_981:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandRadio_42653, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, 6));
					num = (short)305790992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E2:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogMidFrequencyBandRadio_42648, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, 0));
					num = (short)566558722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE3:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetMidFrequencyBandRadio_42658, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, 6));
					num = (short)105644047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC8:
					num = (short)47644699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C17:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalMidFrequencyBandRadio_42653, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, 0));
					num = (short)1709703185;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_113:
				audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
				audioEqualizationGroupSettingAccessory_ = audioSettings.AudioEqualizationGroupSettingAccessory_42605;
				audioEqualizationGroupSettingRadio_ = audioSettings.AudioEqualizationGroupSettingRadio_42604;
				labtoolRAD_PROF_CDA = null;
				enumerator = audioSettings.Parent.FeatureSectionsCollection.GetEnumerator();
				num = (short)195559473;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x00543504 File Offset: 0x00541704
		internal static void conGainControlRadioGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::AcpBusinessLayer.AcpListField receiveAGCGroupSettingInternal_;
			short num2;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlOutputInternal_;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlTotalInternal_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (receiveAGCGroupSettingInternal_.Value == 2)
					{
						num2 = (short)84410373;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2110652422;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (receiveAGCGroupSettingInternal_.Value == 0)
					{
						num2 = (short)471859202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)611581956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_91;
				case 3:
					goto IL_175;
				case 4:
				{
					if (receiveAGCGroupSettingInternal_.Value != 1)
					{
						num2 = (short)1406533632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1744192704;
					short num3 = num2;
					num2 = (short)1566655680;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_233;
					default:
						num2 = (short)1810759680;
						if (num2 != 0)
						{
						}
						num2 = (short)477560835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_ED;
				case 6:
					if (receiveAGCGroupSettingInternal_.Value == 3)
					{
						num2 = (short)110100487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputInternal_, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalInternal_, 0));
					num2 = (short)1368719368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1D6;
				}
				goto IL_34;
			}
			IL_91:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputInternal_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalInternal_, 15));
			return;
			IL_ED:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputInternal_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalInternal_, 0));
			return;
			IL_175:
			num2 = (short)329515008;
			short num4 = num2;
			goto IL_233;
			IL_1D6:
			return;
			IL_233:
			num2 = (short)1975582721;
			if (num2 != 0)
			{
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputInternal_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalInternal_, 21));
			return;
			IL_34:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			receiveAGCGroupSettingInternal_ = audioSettings.ReceiveAGCGroupSettingInternal_42615;
			receiveAGCGainControlOutputInternal_ = audioSettings.ReceiveAGCGainControlOutputInternal_42745;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlOutputAccessory_ = audioSettings.ReceiveAGCGainControlOutputAccessory_42746;
			receiveAGCGainControlTotalInternal_ = audioSettings.ReceiveAGCGainControlTotalInternal_42741;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlTotalAccessory_ = audioSettings.ReceiveAGCGainControlTotalAccessory_42742;
			num2 = (short)326107137;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x00543788 File Offset: 0x00541988
		internal static void conGainControlAccessoryGroupSettingValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::AcpBusinessLayer.AcpListField receiveAGCGroupSettingAccessory_;
			short num2;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlOutputAccessory_;
			global::AcpBusinessLayer.AcpRangeField<int, int> receiveAGCGainControlTotalAccessory_;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (receiveAGCGroupSettingAccessory_.Value == 2)
					{
						num2 = (short)1613496325;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1745092614;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (receiveAGCGroupSettingAccessory_.Value == 0)
					{
						num2 = (short)5898242;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1949237252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_83;
				case 3:
					goto IL_1B5;
				case 4:
				{
					if (receiveAGCGroupSettingAccessory_.Value != 1)
					{
						num2 = (short)1644953600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1155102523;
					short num3 = num2;
					num2 = (short)961509179;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_247;
					default:
					{
						num2 = (short)980877312;
						if (num2 != 0)
						{
						}
						num2 = (short)642580480;
						short num4 = num2;
						num2 = (short)1978073091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_DD;
				case 6:
					if (receiveAGCGroupSettingAccessory_.Value == 3)
					{
						num2 = (short)120848391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 7:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputAccessory_, 0));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalAccessory_, 0));
					num2 = (short)1033502728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1EC;
				}
				goto IL_34;
			}
			IL_83:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputAccessory_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalAccessory_, 15));
			return;
			IL_DD:
			num2 = (short)589692929;
			if (num2 != 0)
			{
			}
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputAccessory_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalAccessory_, 0));
			return;
			IL_1B5:
			goto IL_247;
			IL_1EC:
			return;
			IL_247:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlOutputAccessory_, 0));
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(receiveAGCGainControlTotalAccessory_, 21));
			return;
			IL_34:
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
			receiveAGCGroupSettingAccessory_ = audioSettings.ReceiveAGCGroupSettingAccessory_42616;
			receiveAGCGainControlOutputAccessory_ = audioSettings.ReceiveAGCGainControlOutputAccessory_42746;
			receiveAGCGainControlTotalAccessory_ = audioSettings.ReceiveAGCGainControlTotalAccessory_42742;
			num2 = (short)71696385;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x005439F8 File Offset: 0x00541BF8
		internal static bool conNoiseReductionRadioGroupFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)569573376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (audioSettings != null)
						{
							num = (short)532676609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)1622474761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1506672643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_381;
					case 3:
					{
						num = (short)792002560;
						short num3 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = labtoolRAD_PROF_CDA.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)1399848964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)1983119360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_137;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.GetType() == typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings))
									{
										num = (short)124321795;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1781268486;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
									num = (short)1344733185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
									num = (short)1171718149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1FD;
								case 5:
									goto IL_1DF;
								case 6:
									num = (short)1779564548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_184:
								num = (short)2031222786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_137:
								goto IL_184;
							}
							IL_1DF:
							IL_1FD:
							goto IL_381;
						}
						finally
						{
							num = (short)1678245888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_235;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)664010754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_26A;
								}
								IL_235:
								if (enumerator == null)
								{
									break;
								}
								num = (short)611254273;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_26A:;
						}
						return true;
					case 5:
						goto IL_3B7;
					case 6:
						goto IL_96;
					case 7:
						if (audioSettings == null)
						{
							num = (short)719323141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96;
					case 8:
					{
						num = (short)1589391176;
						short num4 = num;
						num = (short)1650536264;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B7;
						default:
							goto IL_33E;
						}
						break;
					}
					case 9:
						if (audioSettings.NoiseReductionGroupSettingRadio_42584.Value == 4)
						{
							num = (short)475987976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_56;
					IL_96:
					num = (short)384827392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_381:
					num = (short)632160263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B7:
					audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
					num = (short)962199558;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_33E:
				num = (short)637927425;
				if (num != 0)
				{
				}
				num = (short)247332864;
				if (num != 0)
				{
				}
				return true;
				IL_56:
				audioSettings = null;
				labtoolRAD_PROF_CDA = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
				num = (short)668401666;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x00543DE0 File Offset: 0x00541FE0
		internal static bool conNoiseReductionAccessoryGroupFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1778122752;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_58;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (audioSettings != null)
						{
							num = (short)4521985;
							if (num != 0)
							{
							}
							num = (short)571867137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)1586233353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)2042691587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_382;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = labtoolRAD_PROF_CDA.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)2044657668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						try
						{
							num = (short)1582039040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_162;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.GetType() == typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings))
									{
										num = (short)2067070979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1457717254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
									num = (short)347275265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
									num = (short)2099380229;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_226;
								case 5:
									goto IL_209;
								case 6:
									num = (short)235732996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AF:
								num = (short)446889986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_162:
								goto IL_1AF;
							}
							IL_209:
							IL_226:
							goto IL_382;
						}
						finally
						{
							num = (short)4128768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_25D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)260767746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_293;
								}
								IL_25D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2037841921;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_293:;
						}
						goto IL_296;
					case 5:
						goto IL_3B9;
					case 6:
						goto IL_99;
					case 7:
						if (audioSettings == null)
						{
							num = (short)51380229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					case 8:
					{
						num = (short)1234353109;
						short num3 = num;
						num = (short)773766101;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3B9;
						default:
							goto IL_368;
						}
						break;
					}
					case 9:
						if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value == 4)
						{
							num = (short)623181832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_58;
					IL_99:
					num = (short)1973223424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_382:
					num = (short)95027207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B9:
					audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
					num = (short)1750990854;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_296:
				num = (short)1450704896;
				short num4 = num;
				return true;
				IL_368:
				num = (short)2021195776;
				if (num != 0)
				{
				}
				goto IL_296;
				IL_58:
				audioSettings = null;
				labtoolRAD_PROF_CDA = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
				num = (short)217841666;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06005DE9 RID: 24041 RVA: 0x005441C8 File Offset: 0x005423C8
		internal static bool conGainSensitivityGroupRadioFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
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
					goto IL_DB;
				case 1:
					num2 = (short)1738080259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return true;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
					if (audioSettings.GainSensitivityGroupSettingRadio_42608.Value == 4)
					{
						num2 = (short)548012034;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_20;
			}
			return true;
			IL_20:
			num2 = (short)215509309;
			short num3 = num2;
			num2 = (short)67987773;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DB:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				if (audioSettings != null)
				{
					num2 = (short)1399521281;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)801243136;
				if (num2 != 0)
				{
				}
				num2 = (short)811728897;
				if (num2 != 0)
				{
				}
				num2 = (short)897253376;
				short num4 = num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
				num2 = (short)1592983552;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x06005DEA RID: 24042 RVA: 0x00544310 File Offset: 0x00542510
		internal static bool conGainSensitivityGroupAccessoryFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
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
					goto IL_D7;
				case 1:
					num2 = (short)2125266947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return true;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
					if (audioSettings.GainSensitivityGroupSettingAccessory_42610.Value == 4)
					{
						num2 = (short)1487929346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_20;
			}
			return true;
			IL_20:
			num2 = (short)982843393;
			if (num2 != 0)
			{
			}
			num2 = (short)1415513912;
			short num3 = num2;
			num2 = (short)504956728;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D7:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				if (audioSettings != null)
				{
					num2 = (short)679149569;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)1399652352;
				if (num2 != 0)
				{
				}
				num2 = (short)303366144;
				short num4 = num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
				num2 = (short)1798897664;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x06005DEB RID: 24043 RVA: 0x00544454 File Offset: 0x00542654
		internal static bool conMicrophoneTXSettingsAudioEqualizationGroupSettingRadioFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)1059717121;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_DA;
				case 1:
					num = (short)676921347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return true;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
					if (audioSettings.AudioEqualizationGroupSettingRadio_42613.Value == 4)
					{
						num = (short)1488191490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				}
				goto IL_46;
			}
			return true;
			IL_46:
			num = (short)1870320632;
			short num3 = num;
			num = (short)1490146296;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DA:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				if (audioSettings != null)
				{
					num = (short)280952833;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num = (short)578027520;
				if (num != 0)
				{
				}
				num = (short)2063990784;
				short num4 = num;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
				num = (short)129957888;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x0054459C File Offset: 0x0054279C
		internal static bool conMicrophoneTXSettingsAudioEqualizationGroupSettingAccessoryFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
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
					goto IL_B4;
				case 1:
					num2 = (short)965738497;
					if (num2 != 0)
					{
					}
					num2 = (short)1822162947;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return true;
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
					if (audioSettings.AudioEqualizationGroupSettingAccessory_42614.Value == 4)
					{
						num2 = (short)1828519938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_20;
			}
			return true;
			IL_20:
			num2 = (short)329946699;
			short num3 = num2;
			num2 = (short)693737035;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B4:
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				if (audioSettings != null)
				{
					num2 = (short)247529473;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)128712704;
				if (num2 != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings = self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings;
				num2 = (short)742195200;
				short num4 = num2;
				num2 = (short)1327824896;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x005446E8 File Offset: 0x005428E8
		internal static bool conSpeakerRXSettingsAudioEqualizationGroupSettingRadioFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1579810816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_57;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (audioSettings != null)
						{
							num = (short)853278721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)636354569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (labtoolRAD_PROF_CDA != null)
						{
							num = (short)1227161603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38D;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = labtoolRAD_PROF_CDA.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)1411514372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1333919745;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1579352064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_165;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.GetType() == typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings))
									{
										num = (short)985071619;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)171245574;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
									num = (short)1249640449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
									num = (short)107282437;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_22F;
								case 5:
									goto IL_211;
								case 6:
									num = (short)1839529988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B3:
								num = (short)95289346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_165:
								goto IL_1B3;
							}
							IL_211:
							IL_22F:
							goto IL_38D;
						}
						finally
						{
							num = (short)1268514816;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_267;
									}
									continue;
								case 1:
								{
									num = (short)1266609134;
									short num3 = num;
									num = (short)12446702;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2ED;
									default:
										num = (short)2128216064;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)416022530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_2ED;
								}
								IL_267:
								if (enumerator == null)
								{
									break;
								}
								num = (short)901185537;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2ED:;
						}
						return true;
					case 5:
						audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
						num = (short)2112815110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_95;
					case 7:
						if (audioSettings == null)
						{
							num = (short)1829109765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_95;
					case 8:
						goto IL_388;
					case 9:
						if (audioSettings.AudioEqualizationGroupSettingRadio_42604.Value == 4)
						{
							num = (short)649854984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_57;
					IL_95:
					num = (short)314245120;
					short num4 = num;
					num = (short)185204736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38D:
					num = (short)2027356167;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_388:
				return true;
				IL_57:
				audioSettings = null;
				labtoolRAD_PROF_CDA = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
				num = (short)259391490;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x00544ADC File Offset: 0x00542CDC
		internal static bool conSpeakerRXSettingsAudioEqualizationGroupSettingAccessoryFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1930297347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_132;
				case 2:
					if (audioSettings != null)
					{
						num2 = (short)211419136;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
				{
					num2 = (short)1177073387;
					short num3 = num2;
					num2 = (short)1953150699;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num2 = (short)1394999296;
						if (num2 != 0)
						{
						}
						num2 = (short)1574240256;
						short num4 = num2;
						if (audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value == 4)
						{
							num2 = (short)1615855617;
							if (num2 != 0)
							{
							}
							num2 = (short)1872035841;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				}
				goto IL_20;
			}
			return true;
			IL_132:
			return true;
			IL_20:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)733544450;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x00544C24 File Offset: 0x00542E24
		internal static bool conDigitalAnalogBalanceAccessoryValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
					{
						num2 = (short)1659764740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1010630659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)2057895936;
					short num3 = num2;
					num2 = (short)1684930562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
					{
						goto IL_125;
					}
					return false;
				case 3:
					if (audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.Value)
					{
						num2 = (short)1852112897;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_79;
				case 5:
				{
					num2 = (short)1969684481;
					if (num2 != 0)
					{
					}
					num2 = (short)1169960589;
					short num4 = num2;
					num2 = (short)1307324045;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						goto IL_DB;
					}
					break;
				}
				}
				goto IL_28;
				IL_125:
				num2 = (short)2072379397;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_79:
			global::AcpBusinessLayer.AcpField<bool> radioProfileAudioSettingsTxDigitalAnalogBalance_A;
			radioProfileAudioSettingsTxDigitalAnalogBalance_A.CalculateValidity();
			return radioProfileAudioSettingsTxDigitalAnalogBalance_A.Valid;
			IL_DB:
			num2 = (short)1600258048;
			if (num2 != 0)
			{
			}
			return !audioSettings.RadProfAudioSettingsDigitalAGC2_A7853.Value;
			IL_28:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			radioProfileAudioSettingsTxDigitalAnalogBalance_A = audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715;
			num2 = (short)307363840;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x00544DF0 File Offset: 0x00542FF0
		internal static bool conCustomNoiseReductionProfileSelectionRadioApplicability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1065746432;
			short num2 = num;
			num = (short)1626449674;
			short num3 = num;
			num = (short)1741989642;
			switch (num3 == num)
			{
			}
			num = (short)402718721;
			if (num != 0)
			{
			}
			num = (short)631635968;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles).AudioSettings.RadProfAudioSettingsCustomIntMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x00544EB4 File Offset: 0x005430B4
		internal static bool conCustomNoiseReductionProfileSelectionAccessoryApplicability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)394985472;
			short num2 = num;
			num = (short)781975379;
			short num3 = num;
			num = (short)2084437843;
			switch (num3 == num)
			{
			}
			num = (short)357105665;
			if (num != 0)
			{
			}
			num = (short)1475936256;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles).AudioSettings.RadProfAudioSettingsCustomExtMicNoiseReductionEnable_A22294.Value;
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x00544F7C File Offset: 0x0054317C
		internal static bool conIsAGCOutputAccessoryIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2105933827;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_147;
				case 2:
					if (!audioSettings.RadProfAudioSettingsAnalogAGC2_A7439.Value)
					{
						num2 = (short)1581187072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
				{
					num2 = (short)1797407381;
					short num3 = num2;
					num2 = (short)1023689365;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_89;
					default:
					{
						num2 = (short)853540864;
						short num4 = num2;
						num2 = (short)612106240;
						if (num2 != 0)
						{
						}
						if (!audioSettings.RadProfAudioSettingsSecurenetAGC2_A9098.Value)
						{
							num2 = (short)611647489;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_89:
			return audioSettings.RadProfAudioSettingsDigitalAGC2_A7853.Value;
			IL_147:
			goto IL_89;
			IL_20:
			num2 = (short)44826625;
			if (num2 != 0)
			{
			}
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)1144913922;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x005450D8 File Offset: 0x005432D8
		internal static bool conIsAudioConfigurationLevelEnhanced(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)119865344;
			short num2 = num;
			num = (short)76525280;
			short num3 = num;
			num = (short)1112518368;
			switch (num3 == num)
			{
			}
			num = (short)1990656001;
			if (num != 0)
			{
			}
			num = (short)681312256;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.RadioProfiles).AudioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1;
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x005451A8 File Offset: 0x005433A8
		internal static bool conDigitalAnalogBanlanceAccessoryApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1895170048;
			short num2 = num;
			num = (short)858156947;
			short num3 = num;
			num = (short)669544339;
			switch (num3 == num)
			{
			}
			num = (short)1313472512;
			if (num != 0)
			{
			}
			num = (short)1240399873;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RefRadioWide.DigitalAudioOptions.RadWideLabtoolDigitalAnalogBalance_A7851.Value == 2;
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x00545270 File Offset: 0x00543470
		internal static void conAGCGainControlOutputRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_C6;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1534918656;
							short num3 = num2;
							num2 = (short)391905282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C8;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AGCGainControlOutputAccessory_42644, audioSettings.RadProfAudioSettingsOutput_A8679.Value));
						num2 = (short)1654587392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_C6:
				IL_C8:
				num2 = (short)555070864;
				short num4 = num2;
				num2 = (short)1620817296;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)794886144;
					if (num2 != 0)
					{
					}
					num2 = (short)1100218369;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1045626881;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x005453B8 File Offset: 0x005435B8
		internal static void conAGCGainControlOutputAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EA;
					case 1:
					{
						num2 = (short)1277100033;
						if (num2 != 0)
						{
						}
						num2 = (short)1281425408;
						short num3 = num2;
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)44105730;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EC;
					}
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsOutput_A8679, audioSettings.AGCGainControlOutputAccessory_42644.Value));
						num2 = (short)831782912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EA:
				IL_EC:
				num2 = (short)1546330717;
				short num4 = num2;
				num2 = (short)110830173;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)1932263424;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1911816193;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x005454FC File Offset: 0x005436FC
		internal static void conAGCGainControlTotalAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EF;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)32047104;
							short num3 = num2;
							num2 = (short)1668022274;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F1;
					case 2:
						num2 = (short)125501441;
						if (num2 != 0)
						{
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsTotal_A9394, audioSettings.AGCGainControlTotalAccessory_42645.Value));
						num2 = (short)1572208640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EF:
				IL_F1:
				num2 = (short)836387782;
				short num4 = num2;
				num2 = (short)376652742;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)1123090432;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1925840897;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x00545644 File Offset: 0x00543844
		internal static void conAGCGainControlTotalRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_C8;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1117323264;
							short num3 = num2;
							num2 = (short)504365058;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F3;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AGCGainControlTotalAccessory_42645, audioSettings.RadProfAudioSettingsTotal_A9394.Value));
						num2 = (short)755367936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_C8:
				num2 = (short)459538433;
				if (num2 != 0)
				{
				}
				IL_F3:
				num2 = (short)281058119;
				short num4 = num2;
				num2 = (short)1207212871;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)185401344;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)863698945;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x00545790 File Offset: 0x00543990
		internal static void conDigitalAnalogBalanceAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EC;
					case 1:
					{
						num2 = (short)1335164929;
						if (num2 != 0)
						{
						}
						num2 = (short)2818048;
						short num3 = num2;
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1421213698;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EE;
					}
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715, audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661.Value));
						num2 = (short)1384906752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EC:
				IL_EE:
				num2 = (short)1140068652;
				short num4 = num2;
				num2 = (short)1524896044;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)2071396352;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1306984449;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x005458D8 File Offset: 0x00543AD8
		internal static void conDigitalAnalogBalanceRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EA;
					case 1:
					{
						num2 = (short)1765670913;
						if (num2 != 0)
						{
						}
						num2 = (short)2142175232;
						short num3 = num2;
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1115684866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EC;
					}
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(audioSettings.RadioProfileAudioSettingsDigitalAnalogBalanceAccessory_42661, audioSettings.RadioProfileAudioSettingsTxDigitalAnalogBalance_A37715.Value));
						num2 = (short)155058176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EA:
				IL_EC:
				num2 = (short)706156526;
				short num4 = num2;
				num2 = (short)976164846;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)1897136128;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)602079233;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x00545A20 File Offset: 0x00543C20
		internal static void conAnalogHighFrequencyBandRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_E9;
					case 1:
					{
						num2 = (short)1032257536;
						short num3 = num2;
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1494024194;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EB;
					}
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.AnalogHighFrequencyBandAccessory_42650, audioSettings.RadProfAudioSettingsAnalog_A7438.Value));
						num2 = (short)1442971648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_E9:
				IL_EB:
				num2 = (short)1972103459;
				short num4 = num2;
				num2 = (short)283306275;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)141099008;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)538902529;
			if (num2 != 0)
			{
			}
			num2 = (short)106954753;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x00545B64 File Offset: 0x00543D64
		internal static void conDigitalHighFrequencyBandRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_BF;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1027604480;
							short num3 = num2;
							num2 = (short)74973186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C1;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.DigitalHighFrequencyBandAccessory_42655, audioSettings.RadProfAudioSettingsDigital_A7850.Value));
						num2 = (short)203292672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_BF:
				IL_C1:
				num2 = (short)1765280866;
				short num4 = num2;
				num2 = (short)320670818;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)921108480;
					if (num2 != 0)
					{
					}
					num2 = (short)1396637697;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1888878593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00545CA8 File Offset: 0x00543EA8
		internal static void conSecurenetHighFrequencyBandRadioValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EC;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)930283520;
							short num3 = num2;
							num2 = (short)1192165377;
							if (num2 != 0)
							{
							}
							num2 = (short)783417346;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_EE;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.SecurenetHighFrequencyBandAccessory_42660, audioSettings.RadProfAudioSettingsSecurenet_A9097.Value));
						num2 = (short)1927348224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EC:
				IL_EE:
				num2 = (short)1900439496;
				short num4 = num2;
				num2 = (short)1100310472;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)1340604416;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)2116943873;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00545DF0 File Offset: 0x00543FF0
		internal static void conAnalogHighFrequencyBandAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_C6;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1504378880;
							short num3 = num2;
							num2 = (short)1405222914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C8;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsAnalog_A7438, audioSettings.AnalogHighFrequencyBandAccessory_42650.Value));
						num2 = (short)193069056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_C6:
				IL_C8:
				num2 = (short)41398495;
				short num4 = num2;
				num2 = (short)827306207;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)390987777;
					if (num2 != 0)
					{
					}
					num2 = (short)1864105984;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1037631489;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00545F38 File Offset: 0x00544138
		internal static void conDigitalHighFrequencyBandAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_C6;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)99090432;
							short num3 = num2;
							num2 = (short)2026635266;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C8;
					case 2:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsDigital_A7850, audioSettings.DigitalHighFrequencyBandAccessory_42655.Value));
						num2 = (short)2052521984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_C6:
				IL_C8:
				num2 = (short)2145189527;
				short num4 = num2;
				num2 = (short)1584987799;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)2114060288;
					if (num2 != 0)
					{
					}
					num2 = (short)1574436865;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)2058289153;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x00546080 File Offset: 0x00544280
		internal static void conSecurenetHighFrequencyBandAccessoryValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
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
						goto IL_EE;
					case 1:
						if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 0)
						{
							num2 = (short)1836449792;
							short num3 = num2;
							num2 = (short)1070596098;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F0;
					case 2:
						num2 = (short)1065025537;
						if (num2 != 0)
						{
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(audioSettings.RadProfAudioSettingsSecurenet_A9097, audioSettings.SecurenetHighFrequencyBandAccessory_42660.Value));
						num2 = (short)1448017920;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_EE:
				IL_F0:
				num2 = (short)983872762;
				short num4 = num2;
				num2 = (short)541046010;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_23;
				default:
					num2 = (short)2034302976;
					if (num2 != 0)
					{
					}
					return;
				}
				break;
			}
			}
			IL_1C:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			IL_23:
			num2 = (short)1549926401;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x005461CC File Offset: 0x005443CC
		internal static bool conIsAudioConfigurationLevelEnhancedOrAPX3000(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 5;
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value != 1)
			{
				short num = (short)1968308225;
				if (num != 0)
				{
				}
				num = (short)985459757;
				short num2 = num;
				num = (short)549973037;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1752498176;
					if (num != 0)
					{
					}
					num = (short)2056978432;
					short num3 = num;
					return global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("蟅飇鋉ￋﻍ", a_));
				}
				}
			}
			return true;
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x005462BC File Offset: 0x005444BC
		internal static bool conGainSensitivityAGCGainControlOutputAccessoryEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_1C4;
				case 1:
					goto IL_BC;
				case 2:
					if (audioSettings != null)
					{
						num2 = (short)141819910;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1575813125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1567752199;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("軎臐诒", a_)))
					{
						num2 = (short)564264961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)926351360;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1323892736;
					short num3 = num2;
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						return true;
					}
					num2 = (short)1855401450;
					short num4 = num2;
					num2 = (short)1995386346;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C4;
					default:
						num2 = (short)965541888;
						if (num2 != 0)
						{
						}
						num2 = (short)1336016899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_39;
				IL_1C4:
				if (audioSettings.GainSensitivityGroupSettingAccessory_42610.Value != 4)
				{
					return false;
				}
				num2 = (short)736034820;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_BC:
			num2 = (short)1898446849;
			if (num2 != 0)
			{
			}
			return true;
			IL_39:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)431882242;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06005E03 RID: 24067 RVA: 0x005464BC File Offset: 0x005446BC
		internal static bool conSpeakerRXSettingsAudioEqualizationHighFrequencyBandAccessoryFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_19E;
				case 1:
					return true;
				case 2:
					if (audioSettings != null)
					{
						num2 = (short)984940550;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1188298757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1019478017;
					if (num2 != 0)
					{
					}
					num2 = (short)156434439;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("蟅飇鋉ￋﻍ", a_)))
					{
						num2 = (short)1699741697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)1754005504;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						return true;
					}
					num2 = (short)1364066304;
					short num3 = num2;
					num2 = (short)1065904226;
					short num4 = num2;
					num2 = (short)158558306;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19E;
					default:
						num2 = (short)471859200;
						if (num2 != 0)
						{
						}
						num2 = (short)1522597891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_39;
				IL_19E:
				if (audioSettings.AudioEqualizationGroupSettingAccessory_42605.Value != 4)
				{
					return false;
				}
				num2 = (short)1480785924;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_39:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)1281949698;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06005E04 RID: 24068 RVA: 0x005466C0 File Offset: 0x005448C0
		internal static bool conWindNoiseReductionLevelAccessoryEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)363069440;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
				global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA labtoolRAD_PROF_CDA;
				for (;;)
				{
					IL_27:
					num = (short)566558720;
					short num3 = num;
					num = (short)1569014338;
					short num4 = num;
					num = (short)1133003330;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)221511680;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_155;
						case 1:
						{
							bool flag = audioSettings.RefRadioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;
							num = (short)954269704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							return true;
						case 3:
							num = (short)116195338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
							num = (short)1173487616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = labtoolRAD_PROF_CDA.Parent.FeatureSectionsCollection.GetEnumerator();
							num = (short)2019557387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (labtoolRAD_PROF_CDA != null)
							{
								num = (short)1465843717;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3BF;
						case 7:
							if (audioSettings == null)
							{
								num = (short)2001534980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_155;
						case 8:
							goto IL_36B;
						case 9:
							if (audioSettings != null)
							{
								num = (short)619642881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 10:
						{
							bool flag;
							if (!flag)
							{
								num = (short)1748828162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_397;
						}
						case 11:
							try
							{
								num = (short)101580801;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										audioSettings = (acpFeatureSection as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
										num = (short)2067529730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1D4;
										}
										continue;
									case 2:
										goto IL_27B;
									case 3:
										goto IL_298;
									case 4:
										num = (short)584450051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)367853572;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
										num = (short)1637482502;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										if (acpFeatureSection.GetType() == typeof(global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings))
										{
											num = (short)1209270272;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_1D6:
									num = (short)1374289925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D4:
									goto IL_1D6;
								}
								IL_27B:
								IL_298:
								goto IL_3BF;
							}
							finally
							{
								num = (short)741539841;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_307;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2D1;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)2105540608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2D1:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1968111618;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_307:;
							}
							return true;
						}
						goto IL_D2;
						IL_155:
						num = (short)1385168905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3BF:
						num = (short)1029963783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_36B:
					if (audioSettings.NoiseReductionGroupSettingAccessory_42585.Value != 4)
					{
						goto IL_397;
					}
					num = (short)1918500867;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_397:
				num = (short)572194817;
				if (num != 0)
				{
				}
				return false;
				IL_D2:
				audioSettings = null;
				labtoolRAD_PROF_CDA = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.LabtoolRAD_PROF_CDA);
				num = (short)984809478;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06005E05 RID: 24069 RVA: 0x00546B08 File Offset: 0x00544D08
		internal static bool conGainControlGroupSettingRadioFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_D2;
				case 1:
					num2 = (short)1019019268;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (audioSettings != null)
					{
						num2 = (short)915668993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 3:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						num2 = (short)125370368;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 4:
					if (audioSettings.ReceiveAGCGroupSettingInternal_42615.Value == 3)
					{
						num2 = (short)311951365;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 5:
				{
					num2 = (short)1126170624;
					short num3 = num2;
					num2 = (short)1774059523;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			return true;
			IL_D2:
			return true;
			IL_13D:
			num2 = (short)1813980310;
			short num4 = num2;
			num2 = (short)1733436566;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num2 = (short)891551744;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_28:
			num2 = (short)1499660289;
			if (num2 != 0)
			{
			}
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)705101826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005E06 RID: 24070 RVA: 0x00546CA0 File Offset: 0x00544EA0
		internal static bool ConIsReceiveAGCGainControlTotalIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1456732063;
			short num2 = num;
			num = (short)1749153695;
			switch (num2 == num)
			{
			}
			num = (short)577765376;
			short num3 = num;
			num = (short)662372352;
			if (num != 0)
			{
			}
			num = (short)444006401;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).ReceiveAGCGroupSettingInternal_42615.Value != 2;
		}

		// Token: 0x06005E07 RID: 24071 RVA: 0x00546D60 File Offset: 0x00544F60
		internal static bool conGainControlGroupSettingAccessoryFieldsEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings audioSettings;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A7;
				case 1:
					num2 = (short)1834156036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (audioSettings != null)
					{
						num2 = (short)1492713473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 3:
					if (audioSettings.RefRadioWide.DigitalAudioOptions.RadWideAudioConfigurationLevel_42740.Value == 1)
					{
						num2 = (short)1824260096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 4:
					if (audioSettings.ReceiveAGCGroupSettingAccessory_42616.Value == 3)
					{
						num2 = (short)1155792901;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EB;
				case 5:
					num2 = (short)420937731;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			return true;
			IL_A7:
			return true;
			IL_EB:
			num2 = (short)1917255680;
			short num3 = num2;
			num2 = (short)289720867;
			short num4 = num2;
			num2 = (short)1288620579;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num2 = (short)2067660800;
				if (num2 != 0)
				{
				}
				num2 = (short)2051211265;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_28:
			audioSettings = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings);
			num2 = (short)1136197634;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06005E08 RID: 24072 RVA: 0x00546EF4 File Offset: 0x005450F4
		internal static bool ConIsReceiveAGCGainControlTotalAccessoryIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1461859633;
			short num2 = num;
			num = (short)1709258033;
			switch (num2 == num)
			{
			}
			num = (short)1226375168;
			short num3 = num;
			num = (short)1968570369;
			if (num != 0)
			{
			}
			num = (short)1803812864;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioProfiles.AudioSettings).ReceiveAGCGroupSettingAccessory_42616.Value != 2;
		}
	}
}
