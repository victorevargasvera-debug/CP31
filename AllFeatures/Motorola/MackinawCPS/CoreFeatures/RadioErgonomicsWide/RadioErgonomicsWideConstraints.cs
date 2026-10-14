using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x0200021D RID: 541
	public static class RadioErgonomicsWideConstraints
	{
		// Token: 0x060063D0 RID: 25552 RVA: 0x005947F8 File Offset: 0x005929F8
		internal static bool ConRadWideHomeModSelIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode homeMode;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_D3;
					case 1:
						if (!homeMode.RadErgoWideHomeModeZone_A9691.HiddenStatic)
						{
							num2 = (short)1029701632;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D5;
					case 2:
						if (homeMode.RadErgoWideHomeModeHomeModeSelection_A8202.Value)
						{
							num2 = (short)1701707779;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_D5;
					case 3:
						num2 = (short)1597898753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_D5:
				num2 = (short)1798377956;
				short num3 = num2;
				num2 = (short)1787564516;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_10A;
				}
				IL_20:
				homeMode = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode);
				num2 = (short)31457280;
				short num4 = num2;
				num2 = (short)683737090;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_D3:
			return !homeMode.HomeModeChannel.HiddenStatic;
			IL_10A:
			num2 = (short)1812856833;
			if (num2 != 0)
			{
			}
			num2 = (short)1932656640;
			if (num2 != 0)
			{
			}
			return false;
		}

		// Token: 0x060063D1 RID: 25553 RVA: 0x00594950 File Offset: 0x00592B50
		internal static bool ConHornAndLightIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights hornAndLights = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights;
			if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
			{
				short num = (short)166068225;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)1131806720;
				short num2 = num;
				num = (short)381068139;
				short num3 = num;
				num = (short)745317227;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1775697920;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return hornAndLights.RadErgoWideHornandLightsHornLights_A8206.Value;
		}

		// Token: 0x060063D2 RID: 25554 RVA: 0x00594A14 File Offset: 0x00592C14
		internal static bool ConPaOnlyDisplayChoice(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
			short num2;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_146;
					case 1:
						if (radErgoWidePASirenSirenOperation_A.Value != 3)
						{
							num2 = (short)733544448;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_8D;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num2 = (short)967901187;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 3:
						num2 = (short)1126629377;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20;
				}
				IL_8D:
				num2 = (short)1312646799;
				short num3 = num2;
				num2 = (short)1940219535;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_C2;
				}
				IL_20:
				radErgoWidePASirenSirenOperation_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren).RadErgoWidePASirenSirenOperation_A9139;
				num2 = (short)338755584;
				short num4 = num2;
				num2 = (short)868745218;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_C2:
			num2 = (short)24313857;
			if (num2 != 0)
			{
			}
			num2 = (short)91488256;
			if (num2 != 0)
			{
			}
			return true;
			IL_146:
			return radErgoWidePASirenSirenOperation_A.Value == 2;
		}

		// Token: 0x060063D3 RID: 25555 RVA: 0x00594B6C File Offset: 0x00592D6C
		internal static bool ConTwoAlarmOptIsDisabledAndHornAndLightIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights hornAndLights;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)1707212800;
					short num2 = num;
					switch (num3)
					{
					case 0:
						goto IL_153;
					case 1:
						if (hornAndLights.RadErgoWideHornandLightsHornLights_A8206.Value)
						{
							num = (short)43319296;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)624951299;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)805502977;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_49;
				}
				IL_B4:
				num = (short)1876588665;
				short num4 = num;
				num = (short)338589817;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_EA;
				}
				IL_49:
				hornAndLights = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights);
				num = (short)1695154177;
				if (num != 0)
				{
				}
				num = (short)2130771970;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_EA:
			num = (short)1194721280;
			if (num != 0)
			{
			}
			return false;
			IL_153:
			return !hornAndLights.RadErgoWideHornAndLightsTwoAlarmOption_A9510.Value;
		}

		// Token: 0x060063D4 RID: 25556 RVA: 0x00594CD0 File Offset: 0x00592ED0
		internal static bool ConSirenPaDisplayChoice(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
			for (;;)
			{
				num = (short)86376448;
				short num2 = num;
				pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
				{
					return false;
				}
				num = (short)1679879512;
				short num3 = num;
				num = (short)463596888;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_6F;
				}
			}
			IL_6F:
			num = (short)1943339008;
			if (num != 0)
			{
			}
			num = (short)1212547073;
			if (num != 0)
			{
			}
			return pasiren.RadErgoWidePASirenSirenOperation_A9139.Value == 2;
		}

		// Token: 0x060063D5 RID: 25557 RVA: 0x00594D9C File Offset: 0x00592F9C
		internal static bool conMultiControlHeadIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				short num;
				for (;;)
				{
					IL_0A:
					num = (short)379060224;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						radioErgonomicsWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
						num = (short)178913283;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (self.ParentRecset.IsEmbeddedRecset)
						{
							num = (short)797835264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						radioErgonomicsWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
						num = (short)1029439490;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_11E;
					case 3:
						goto IL_14E;
					}
					break;
				}
				IL_48:
				radioErgonomicsWide = null;
				num = (short)1009683971;
				short num4 = num;
				num = (short)1089113603;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1209401345;
					if (num != 0)
					{
					}
					num = (short)702742528;
					if (num != 0)
					{
					}
					num = (short)1874788353;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
			IL_11E:
			IL_14E:
			return radioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550.Value;
		}

		// Token: 0x060063D6 RID: 25558 RVA: 0x00594F0C File Offset: 0x0059310C
		internal static bool conMultiCHStyleIsAllActvAndMultiCHIsEnOrMultiCHIsDis(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				short num;
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
				for (;;)
				{
					IL_0A:
					num = (short)1048531410;
					short num2 = num;
					num = (short)1476874706;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
						num = (short)740491264;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
							{
								num = (short)1735655427;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							goto IL_101;
						case 2:
							if (!radErgoWideControlHeadMultiControlHead_A.Value)
							{
								num = (short)47448065;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 3:
							num = (short)607649797;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)725286914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1440546817;
							if (num != 0)
							{
							}
							if (controlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.Value == 1)
							{
								num = (short)928907264;
								short num4 = num;
								num = (short)1454833668;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BC;
						}
						goto IL_73;
					}
				}
				IL_73:
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				radErgoWideControlHeadMultiControlHead_A = controlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				num = (short)1581514752;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			IL_BC:
			return !radErgoWideControlHeadMultiControlHead_A.Value;
			IL_101:
			goto IL_BC;
		}

		// Token: 0x060063D7 RID: 25559 RVA: 0x005950B8 File Offset: 0x005932B8
		internal static bool conMultiCHIsEnabledAndMultiCHStyleIsAllActive(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)815398913;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num2;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)1194065923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
				{
					num = (short)1893662720;
					short num3 = num;
					num = (short)989462533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (radErgoWideControlHeadMultiControlHead_A.Value)
					{
						num = (short)288620545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					num = (short)1796866050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_189;
				case 5:
				{
					if (!radErgoWideControlHeadMultiControlHead_A.Value)
					{
						return false;
					}
					num = (short)1843712083;
					short num4 = num;
					num = (short)774688851;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1581449216;
						if (num != 0)
						{
						}
						num = (short)1034092548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4E;
			}
			return false;
			IL_189:
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			return controlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.Value == 1;
			IL_4E:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			radErgoWideControlHeadMultiControlHead_A = controlHead.RadErgoWideControlHeadMultiControlHead_A8550;
			num = (short)78905344;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x060063D8 RID: 25560 RVA: 0x00595254 File Offset: 0x00593454
		internal static bool ConRadWideLongPressDurIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1873477632;
			short num2 = num;
			num = (short)1688408381;
			short num3 = num;
			num = (short)1886064957;
			switch (num3 == num)
			{
			}
			num = (short)497090560;
			if (num != 0)
			{
			}
			num = (short)2035941377;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced;
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationms_A = advanced.RadErgoWideAdvancedLongKeypressDurationms_A8450;
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationms_A = advanced.RadErgoWideAdvancedShortKeypressDurationms_A9125;
			return global::System.Convert.ToInt32(radErgoWideAdvancedLongKeypressDurationms_A.Converter.Convert(radErgoWideAdvancedLongKeypressDurationms_A.Value, null, radErgoWideAdvancedLongKeypressDurationms_A.ConverterParameterObject, null)) > global::System.Convert.ToInt32(radErgoWideAdvancedShortKeypressDurationms_A.Converter.Convert(radErgoWideAdvancedShortKeypressDurationms_A.Value, null, radErgoWideAdvancedShortKeypressDurationms_A.ConverterParameterObject, null));
		}

		// Token: 0x060063D9 RID: 25561 RVA: 0x00595358 File Offset: 0x00593558
		internal static bool conIsShortKeypressDurEmergencyValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1303855310;
			short num2 = num;
			num = (short)1417756878;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_8C:
				if (!global::ConstraintHelper.UtilityMack.IsNFPARadio)
				{
					return true;
				}
				num = (short)1987248128;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)318504960;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				break;
			}
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationforEmergencyms_A;
			int num4;
			for (;;)
			{
				IL_54:
				switch (num3)
				{
				case 0:
					num4 = global::System.Convert.ToInt32(radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.Converter.Convert(radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.Value, null, radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.ConverterParameterObject, null));
					num = (short)1778384898;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_8C;
				case 2:
					if (num4 >= 1000)
					{
						num = (short)490536963;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					goto IL_115;
				}
				goto IL_6A;
			}
			return false;
			IL_115:
			num = (short)410124288;
			short num5 = num;
			num = (short)565968897;
			if (num != 0)
			{
			}
			return num4 <= 3000;
			IL_6A:
			radErgoWideAdvancedShortKeypressDurationforEmergencyms_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;
			num = (short)1155006465;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x060063DA RID: 25562 RVA: 0x005954D0 File Offset: 0x005936D0
		internal static bool conIsLongKeypressDurEmergencyValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationforEmergencyms_A;
			global::AcpBusinessLayer.AcpField<bool> emerWideGeneralKeepAlive_A;
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationforEmergencyms_A;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_49;
				}
				short num;
				for (;;)
				{
					IL_0A:
					num = (short)401473536;
					short num2 = num;
					int num3;
					switch (num3)
					{
					case 0:
						num = (short)345636866;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (radErgoWideAdvancedLongKeypressDurationforEmergencyms_A.Value == 0)
						{
							num = (short)651165696;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F;
					case 2:
						if (emerWideGeneralKeepAlive_A == null)
						{
							num = (short)1283588099;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 3:
						return true;
					}
					break;
				}
				IL_49:
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced;
				radErgoWideAdvancedLongKeypressDurationforEmergencyms_A = advanced.RadErgoWideAdvancedLongKeypressDurationforEmergencyms_A8451;
				radErgoWideAdvancedShortKeypressDurationforEmergencyms_A = advanced.RadErgoWideAdvancedShortKeypressDurationforEmergencyms_A9126;
				emerWideGeneralKeepAlive_A = advanced.RefEmergencyWide.General.EmerWideGeneralKeepAlive_A8360;
				emerWideGeneralKeepAlive_A.CalculateValidity();
				num = (short)945906663;
				short num4 = num;
				num = (short)576152551;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1740177409;
					if (num != 0)
					{
					}
					num = (short)181272576;
					if (num != 0)
					{
					}
					num = (short)1315962881;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
			IL_11E:
			return !emerWideGeneralKeepAlive_A.Value;
			IL_15F:
			return global::System.Convert.ToInt32(radErgoWideAdvancedLongKeypressDurationforEmergencyms_A.Converter.Convert(radErgoWideAdvancedLongKeypressDurationforEmergencyms_A.Value, null, radErgoWideAdvancedLongKeypressDurationforEmergencyms_A.ConverterParameterObject, null)) > global::System.Convert.ToInt32(radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.Converter.Convert(radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.Value, null, radErgoWideAdvancedShortKeypressDurationforEmergencyms_A.ConverterParameterObject, null));
		}

		// Token: 0x060063DB RID: 25563 RVA: 0x00595684 File Offset: 0x00593884
		internal static bool ConMchNumCtrlHeadsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)275644419;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)1352400909;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)606601227;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)21561359;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return true;
				case 4:
				{
					if (controlHead.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
					{
						goto IL_1F0;
					}
					num2 = (short)21595619;
					short num3 = num2;
					num2 = (short)1459652067;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_224;
					default:
						num2 = (short)1880424448;
						if (num2 != 0)
						{
						}
						num2 = (short)1064960001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					flag = false;
					goto IL_234;
				case 6:
					goto IL_224;
				case 7:
				{
					num2 = (short)1293746176;
					short num4 = num2;
					num2 = (short)1479671814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (controlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.Value == 1)
					{
						num2 = (short)1152712711;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F0;
				case 9:
					num2 = (short)441253896;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_26F;
				case 11:
					if (radErgoWideControlHeadMultiControlHead_A.Value)
					{
						num2 = (short)1256194057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F0;
				case 12:
					goto IL_24C;
				case 13:
					switch (index)
					{
					case 1:
						result = !radErgoWideControlHeadMultiControlHead_A.Value;
						num2 = (short)2033713166;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						result = radErgoWideControlHeadMultiControlHead_A.Value;
						num2 = (short)1323958282;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					case 4:
						num2 = (short)1584660484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1010368514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 14:
					return result;
				case 15:
					return result;
				}
				goto IL_50;
				IL_1F0:
				num2 = (short)26673157;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_234:
				result = flag;
				num2 = (short)12910604;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_224:
				flag = (controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value == 0);
				goto IL_234;
			}
			return true;
			IL_24C:
			return result;
			IL_26F:
			num2 = (short)1922301953;
			if (num2 != 0)
			{
			}
			return result;
			IL_50:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			radErgoWideControlHeadMultiControlHead_A = controlHead.RadErgoWideControlHeadMultiControlHead_A8550;
			num2 = (short)1902772224;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063DC RID: 25564 RVA: 0x005959A4 File Offset: 0x00593BA4
		public static bool ConRadWideHomeModSelChannelIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2143092736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C3;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				bool value;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode homeMode;
				for (;;)
				{
					IL_28:
					int[] array;
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
					int num5;
					switch (num2)
					{
					case 0:
					{
						int num3;
						int count;
						if (num3 >= count)
						{
							num = (short)930742299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature;
						array[num3] = feature[num3][10114].EmbeddedRecset.Count;
						num3++;
						num = (short)1330839567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (zoneChannelAssignment == null)
						{
							num = (short)228851748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE;
					case 2:
						return false;
					case 3:
						if (value)
						{
							num = (short)294453253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EE;
					case 4:
						if (num4 != 0)
						{
							num = (short)365756446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EF;
					case 5:
						num = (short)350748673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (zoneChannelAssignment == null)
						{
							num = (short)1598226451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
						num = (short)1942814731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if ((trunkingPersonality = (referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)) == null)
						{
							num = (short)547684384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_353;
					}
					case 8:
						num = (short)1776615440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if ((conventionalPersonality = (referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)) == null)
						{
							num = (short)1967849495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C;
					}
					case 10:
						goto IL_6EF;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						if (homeMode.HomeModeChannel.Value > channelAssignmentListInnerRecset.Count)
						{
							num = (short)1973092354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)8454157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1692991519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (global::ConstraintHelper.UtilityMack.IsNFPARadio && value)
						{
							num = (short)649920520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						goto IL_4F9;
					case 15:
						goto IL_4F9;
					case 16:
						if (homeMode.HomeModeChannel.Value > 0)
						{
							num = (short)1519255586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						return false;
					case 18:
						if (array[num4] > num5)
						{
							num = (short)586350612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EF;
					case 19:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2051);
						int count = feature.Count;
						array = new int[count];
						int num3 = 0;
						num = (short)510525454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						num = (short)1769436676;
						short num6 = num;
						num = (short)645166596;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_534;
						default:
							num = (short)1753284608;
							if (num != 0)
							{
							}
							num5 = array[num4];
							num = (short)158138378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
					{
						int znChanCfgChannelsChannelType_A22241Value;
						if (znChanCfgChannelsChannelType_A22241Value == 1)
						{
							num = (short)160235545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 22:
					{
						int znChanCfgChannelsChannelType_A22241Value;
						if (znChanCfgChannelsChannelType_A22241Value == 0)
						{
							num = (short)134348833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					}
					case 23:
						conventionalPersonality = global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.b();
						goto IL_28C;
					case 24:
					{
						int count;
						if (num4 >= count)
						{
							num = (short)720896012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)57933828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						num = (short)1570766855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return false;
					case 27:
						goto IL_534;
					case 28:
						return false;
					case 29:
						goto IL_5B5;
					case 30:
						num = (short)843644946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (homeMode.HomeModeChannel.Value > num5)
						{
							num = (short)1047855130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B8;
					case 32:
						trunkingPersonality = global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.a();
						goto IL_353;
					case 33:
						num = (short)1877803017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = channelAssignmentListInnerRecset[homeMode.HomeModeChannel.Value - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						global::AcpBusinessLayer.FeatureNode referencedNode = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode;
						int znChanCfgChannelsChannelType_A22241Value = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241Value;
						num = (short)568393750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_5B5;
					case 36:
						return false;
					}
					goto IL_C3;
					IL_28C:
					if (!conventionalPersonality.Features.CnvPerFeaturesHazardZoneModePersonalityValue)
					{
						num = (short)1553006609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B9;
					IL_353:
					if (!trunkingPersonality.Features.TrkPerFeaturesHazardZoneModePersonalityValue)
					{
						num = (short)1932460060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
					IL_3EE:
					num = (short)1263861760;
					short num7 = num;
					num = (short)244383750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B9:
					num = (short)1972764693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F9:
					num = (short)107872256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_534:
					num5 = array[0];
					num4 = 0;
					num = (short)1989869597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B5:
					num = (short)646184984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EF:
					num4++;
					num = (short)731840547;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_2B8:
				num = (short)1947205633;
				if (num != 0)
				{
				}
				return true;
				IL_C3:
				homeMode = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode);
				zoneChannelAssignment = (homeMode.RadErgoWideHomeModeZone_A9691.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				value = homeMode.RefRadioWide.Features.RadWideFeaturesNFPACompliant.Value;
				num = (short)1947992067;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060063DD RID: 25565 RVA: 0x005960C8 File Offset: 0x005942C8
		public static bool ConRadWidePresetChannelSelIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)775225344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1269170176;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection presetZoneAndChannelTableInnerSection;
				for (;;)
				{
					IL_51:
					int num4;
					global::AcpCommonLib.IAcpRecordset feature;
					int num6;
					switch (num2)
					{
					case 0:
					{
						num = (short)2004877313;
						if (num != 0)
						{
						}
						if (zoneChannelAssignment == null)
						{
							num = (short)477626373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset = zoneChannelAssignment.Channels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset;
						num = (short)364969985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset channelAssignmentListInnerRecset;
						if (presetZoneAndChannelTableInnerSection.LabtoolPresetChannel_A41080.Value > channelAssignmentListInnerRecset.Count)
						{
							num = (short)231800838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
					{
						if (num4 < feature.Count)
						{
							num = (short)1723334666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)649846716;
						short num5 = num;
						num = (short)776593340;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_166;
						default:
							num = (short)1200226304;
							if (num != 0)
							{
							}
							num = (short)753139719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return false;
					case 4:
						if (presetZoneAndChannelTableInnerSection.LabtoolPresetChannel_A41080.Value > num6)
						{
							num = (short)13238275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						feature = global::AcpCommonLib.FeatureManager.GetFeature(2051);
						num6 = 0;
						num4 = 0;
						num = (short)1618870281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return false;
					case 7:
						num = (short)1190330372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num6 = feature[num4][10114].EmbeddedRecset.Count;
						num = (short)2063138828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_28B;
					case 10:
						goto IL_166;
					case 11:
						goto IL_28B;
					case 12:
						goto IL_230;
					}
					goto IL_8C;
					IL_166:
					if (feature[num4][10114].EmbeddedRecset.Count > num6)
					{
						num = (short)1859387400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_230:
					num4++;
					num = (short)874512395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28B:
					num = (short)1562771458;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_8C:
				presetZoneAndChannelTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PresetZoneAndChannelTableInnerSection);
				zoneChannelAssignment = (presetZoneAndChannelTableInnerSection.LabtoolPresetZone_A41079.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)57933824;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x060063DE RID: 25566 RVA: 0x005963F0 File Offset: 0x005945F0
		private static global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality b()
		{
			short num = (short)167182336;
			short num2 = num;
			num = (short)165320347;
			short num3 = num;
			num = (short)1212061339;
			switch (num3 == num)
			{
			}
			num = (short)1056768000;
			if (num != 0)
			{
			}
			num = (short)747438081;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2059)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
		}

		// Token: 0x060063DF RID: 25567 RVA: 0x005964AC File Offset: 0x005946AC
		private static global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality a()
		{
			short num = (short)663289856;
			short num2 = num;
			num = (short)1964734394;
			short num3 = num;
			num = (short)1188132794;
			switch (num3 == num)
			{
			}
			num = (short)537067521;
			if (num != 0)
			{
			}
			num = (short)1903886336;
			if (num != 0)
			{
			}
			return global::AcpCommonLib.FeatureManager.GetFeature(2072)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
		}

		// Token: 0x060063E0 RID: 25568 RVA: 0x0059656C File Offset: 0x0059476C
		internal static bool ConRadWideHomeModSelIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1606025216;
			short num2 = num;
			num = (short)1735947910;
			short num3 = num;
			num = (short)1780971142;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D1:
				num = (short)1995833346;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)524156928;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				break;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode homeMode;
			for (;;)
			{
				IL_80:
				switch (num4)
				{
				case 0:
					goto IL_D1;
				case 1:
					if (global::ConstraintHelper.UtilityMack.IsNFPARadio)
					{
						num = (short)1105854464;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					num = (short)1690566657;
					if (num != 0)
					{
					}
					if (homeMode.RefRadioWide.Features.RadWideFeaturesNFPACompliant.Value)
					{
						num = (short)1263730691;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					return false;
				}
				goto IL_96;
			}
			return false;
			IL_96:
			homeMode = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode);
			num = (short)1658585089;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_80;
		}

		// Token: 0x060063E1 RID: 25569 RVA: 0x005966BC File Offset: 0x005948BC
		internal static void ConToSyncLogicalSwitch2ToPosAInTrkAndCnv(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1656225792;
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
				global::AcpBusinessLayer.AcpListField radErgoWideAdvancedLogicalSwitch2_A;
				for (;;)
				{
					IL_27:
					int newValue;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection;
					switch (num2)
					{
					case 0:
					{
						try
						{
							num = (short)1760559107;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1520828420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, newValue));
									int newValue2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, newValue2));
									int newValue3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition3Feature_A19657, newValue3));
									goto IL_279;
								}
								case 2:
									goto IL_292;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_185;
									}
									continue;
								case 4:
									goto IL_309;
								case 5:
								{
									num = (short)1653729077;
									short num3 = num;
									num = (short)910681909;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_279;
									default:
									{
										num = (short)62455808;
										if (num != 0)
										{
										}
										if (!enumerator.MoveNext())
										{
											num = (short)644874240;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)1904214022;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 2)
									{
										num = (short)1879048193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_18A:
								num = (short)1991180293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_185:
								goto IL_18A;
								IL_279:
								num = (short)309854210;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_292:
							IL_309:
							goto IL_C9;
						}
						finally
						{
							num = (short)1259012097;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_379;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_341;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1842741248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_341:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1908015106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_379:;
						}
						goto IL_37C;
						IL_C9:
						num = (short)370343937;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
						enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)383451138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						collection = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
						global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset;
						newValue = 38;
						int newValue2 = 38;
						int newValue3 = 38;
						if (radErgoWideAdvancedLogicalSwitch2_A == 0)
						{
							goto IL_573;
						}
						goto IL_37C;
					}
					case 2:
					{
						num = (short)994508800;
						short num4 = num;
						try
						{
							num = (short)78184451;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, newValue));
									int newValue2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, newValue2));
									int newValue3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition3Feature_A21006, newValue3));
									num = (short)1212153858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)184090628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4A4;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_3D0;
									}
									continue;
								case 4:
									goto IL_501;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 2)
									{
										num = (short)1600651264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1209139201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1653473285;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_4A9:
								num = (short)1495400454;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3D0:
								goto IL_4A9;
							}
							IL_4A4:
							IL_501:
							return;
						}
						finally
						{
							num = (short)636223489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_570;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_539;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1199702016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_539:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1566572546;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_570:;
						}
						goto IL_573;
					}
					}
					goto IL_3A;
					IL_578:
					enumerator = collection.GetEnumerator();
					num = (short)90832896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					if (radErgoWideAdvancedLogicalSwitch2_A == 1)
					{
						int newValue2 = 42;
						goto IL_578;
					}
					goto IL_578;
					IL_573:
					newValue = 42;
					goto IL_578;
				}
				return;
				IL_3A:
				radErgoWideAdvancedLogicalSwitch2_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedLogicalSwitch2_A7756;
				num = (short)1677524993;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060063E2 RID: 25570 RVA: 0x00596CA0 File Offset: 0x00594EA0
		internal static bool ConRadioIsLockedAndSirenLockChecked(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)561381376;
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
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						result = false;
						num = (short)557187074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (pasiren.RefRadioWide.UserInformationAndPasswords.RadWideUserinfoPassRequiredForSiren_A36533)
						{
							num = (short)1848639488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_573;
					case 2:
						goto IL_573;
					case 3:
						return result;
					case 4:
						try
						{
							num = (short)886767619;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = false;
									num = (short)910688258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)70582276;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E1;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_170;
									}
									continue;
								case 4:
								{
									num = (short)1985607302;
									short num3 = num;
									num = (short)287897222;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_272;
									}
									break;
								}
								case 5:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPInputFeature_A21338.Value == 111)
									{
										num = (short)1583808512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)835911681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1018494981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E6:
								num = (short)1620770822;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_170:
								goto IL_1E6;
							}
							IL_1E1:
							return result;
							IL_272:
							num = (short)1288503296;
							if (num != 0)
							{
							}
							return result;
						}
						finally
						{
							num = (short)1725169665;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2F7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C0;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)900923392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2C0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)694681602;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F7:;
						}
						goto Block_3;
					case 5:
						num = (short)119209995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (pasiren.RadErgoWidePASirenSirenOperation_A9139.Value != 0)
						{
							num = 8;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_573;
					case 7:
						num = (short)1303707654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_475;
					case 9:
						num = (short)1878589441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)397541376;
							short num4 = num;
							num = (short)263651333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 11:
						if (index == 0)
						{
							num = (short)1195114503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = true;
						num = (short)1338507265;
						if (num != 0)
						{
						}
						num = (short)334036995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (pasiren.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value)
						{
							num = (short)1015087113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_573;
					case 13:
						goto IL_2FA;
					}
					goto IL_66;
					IL_475:
					num = (short)1390346252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_2FA:
						num = (short)1991049219;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1023868932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								result = false;
								num = (short)359661570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_38B;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_33C;
								}
								continue;
							case 4:
								goto IL_404;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)157941760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1152188422;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipInputFeature_A21329.Value == 111)
								{
									num = (short)1754464257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_33E:
							num = (short)708050949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_33C:
							goto IL_33E;
						}
						IL_38B:
						IL_404:
						goto IL_54B;
					}
					finally
					{
						num = (short)269352961;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_472;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_43B;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1111556096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_43B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)160366594;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_472:;
					}
					goto IL_475;
					IL_54B:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)1591017476;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_573:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)628752397;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_66:
				pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				result = true;
				num = (short)338296842;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060063E3 RID: 25571 RVA: 0x00597324 File Offset: 0x00595524
		internal static bool ConFieldsAlwaysNonEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2094841759;
			short num2 = num;
			num = (short)713867167;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1026293760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)651755521;
			if (num != 0)
			{
			}
			num = (short)548470784;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x060063E4 RID: 25572 RVA: 0x005973D0 File Offset: 0x005955D0
		internal static bool conZoneBankOperationIsEnhanced(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)245850424;
			short num2 = num;
			num = (short)1726832952;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1698168832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1437204481;
			if (num != 0)
			{
			}
			num = (short)1557463040;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedZoneBankOperation_A37543.Value == 1;
		}

		// Token: 0x060063E5 RID: 25573 RVA: 0x0059748C File Offset: 0x0059568C
		internal static bool conFixedVolumeIsEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1942716803;
			short num2 = num;
			num = (short)1037140355;
			switch (num2 == num)
			{
			default:
			{
				num = (short)36044800;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1247543297;
			if (num != 0)
			{
			}
			num = (short)512622592;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RadErgoWideAdvancedFixedVolumeEnable_A37218.Value;
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x00597548 File Offset: 0x00595748
		internal static bool conActiveDurationIsNotMomentary(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection;
			global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAuxOffAlias_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)333709312;
					short num3 = num2;
					if (auxControlTableInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
					{
						num2 = (short)594477058;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					if (radErgoWideAuxControlAuxOffAlias_A.Value.Length <= 0)
					{
						num2 = (short)34209793;
						if (num2 != 0)
						{
						}
						num2 = (short)237371396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BB;
				case 2:
					goto IL_130;
				case 3:
					if (radErgoWideAuxControlAuxOffAlias_A.Value != null)
					{
						num2 = (short)2104885253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BB;
				case 4:
					goto IL_135;
				case 5:
				{
					num2 = (short)589064809;
					short num4 = num2;
					num2 = (short)1459055209;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num2 = (short)1792933888;
						if (num2 != 0)
						{
						}
						num2 = (short)1477443585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_BB;
				}
				goto IL_2C;
				IL_BB:
				num2 = (short)395444224;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_135:
				radErgoWideAuxControlAuxOffAlias_A.SetValue(radErgoWideAuxControlAuxOffAlias_A.DefaultValue);
				num2 = (short)1831010310;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_130:
			return auxControlTableInnerSection.RadErgoWideAuxControlActiveDuration_A37249.Value != 0;
			IL_2C:
			auxControlTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection);
			radErgoWideAuxControlAuxOffAlias_A = auxControlTableInnerSection.RadErgoWideAuxControlAuxOffAlias_A37252;
			num2 = (short)27394051;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x00597734 File Offset: 0x00595934
		public static void ConSetNullIfHiloAirhornToneDisabled(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1369243648;
			switch (num)
			{
			default:
			{
				num = (short)732037121;
				if (num != 0)
				{
				}
				num = (short)24051713;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)673644549;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 199));
									goto IL_578;
								}
								case 1:
									goto IL_16C;
								case 2:
									if (flag)
									{
										num = (short)2026831882;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_75F;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 224)
									{
										num = (short)440860689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									if (flag)
									{
										num = (short)1987772438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_282;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_167;
									}
									continue;
								case 6:
									num = (short)1792933892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 203));
									num = (short)1953759246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_7EF;
								case 9:
									num = (short)1197277186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)484179997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value != 203)
									{
										num = (short)1908015119;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_619;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 117)
									{
										num = (short)723845126;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1238958098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_16C;
								case 14:
									goto IL_16C;
								case 15:
									num = (short)149487619;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)112263168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_282;
								}
								case 17:
									goto IL_619;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 115)
									{
										num = (short)23068681;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 19:
									num = (short)2103181320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)766771219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner)enumerator.Current;
									num = (short)917766156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 21:
									if (!flag)
									{
										num = (short)367591452;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 22:
									num = (short)1744371728;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_16C;
								case 24:
									num = (short)1444806681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 199)
									{
										num = (short)301989918;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 26:
									if (!flag)
									{
										num = (short)859504664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 27:
									try
									{
										num = (short)1920794627;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
												task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value));
												num = (short)1346764801;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)651558918;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner)enumerator2.Current;
												num = (short)1868431365;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 3:
												switch (0)
												{
												case 0:
													goto IL_301;
												}
												continue;
											case 4:
												goto IL_404;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
												if (signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value)
												{
													num = (short)2087649280;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
												num = (short)1255407620;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_366:
											num = (short)1847721986;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_301:
											goto IL_366;
										}
										IL_404:;
									}
									finally
									{
										num = (short)2033844225;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_472;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_439;
												}
												continue;
											case 2:
												enumerator2.Dispose();
												num = (short)527433728;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_439:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)675282946;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_472:;
									}
									break;
								case 28:
									num = (short)335872011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)1590034439;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_75F;
								}
								case 30:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
									num = (short)1840840727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_167;
								IL_16C:
								enumerator2 = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.GetEnumerator();
								num = (short)1767833627;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_282:
								num = (short)1749352474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_475:
								num = (short)1455685652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_167:
								goto IL_475;
								IL_578:
								num = (short)904527885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_619:
								num = (short)896039101;
								short num3 = num;
								num = (short)1991932093;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_578;
								default:
								{
									num = (short)148897792;
									if (num != 0)
									{
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
									num = (short)2147155969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_75F:
								num = (short)1209663509;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7EF:
							return;
						}
						finally
						{
							num = (short)1756495872;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_827;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1367670786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_85E;
								}
								IL_827:
								if (enumerator == null)
								{
									break;
								}
								num = (short)275775489;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_85E:;
						}
						goto IL_861;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 2:
						goto IL_861;
					}
					IL_76:
					num = (short)397082624;
					short num4 = num;
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)1017511938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_861:
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren;
					signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset);
					global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset;
					flag = !pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
					enumerator = collection.GetEnumerator();
					num = (short)820838400;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060063E8 RID: 25576 RVA: 0x00598064 File Offset: 0x00596264
		public static void conSetSirenPASystemLookupAndSirenPAOnly(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)575209472;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenPaSystemLookup_A;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolSirenPaOnly_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset pasirenButtonsListInnerRecset;
					switch (num2)
					{
					case 0:
						if (radErgoWidePASirenSirenOperation_A.Value == 2)
						{
							num = (short)2140733454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11B2;
					case 1:
						try
						{
							num = (short)1185939495;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner pasirenButtonsListInner;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									num = (short)1321205807;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 114)
									{
										num = (short)1477967908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)336920582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)774307847;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)386859036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 117)
									{
										num = (short)504234033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)570359831;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)272105503;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 115)
									{
										num = (short)2066939945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 223)
									{
										num = (short)1429602346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									try
									{
										num = (short)354615296;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_94A;
												}
												continue;
											case 1:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1877344259;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner)enumerator.Current;
												num = (short)918880262;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_A50;
											case 3:
												num = (short)774701058;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
												task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value));
												num = (short)625147908;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
												if (signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value)
												{
													num = (short)889126917;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_9F8:
											num = (short)1731723265;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_94A:
											goto IL_9F8;
										}
										IL_A50:
										break;
									}
									finally
									{
										for (;;)
										{
											IL_A55:
											num = (short)1946419202;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_B09;
												case 1:
													enumerator.Dispose();
													num = (short)1435172864;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
												{
													num = (short)1866651128;
													short num3 = num;
													num = (short)1204803064;
													switch ((num3 == num) ? 1 : 0)
													{
													case 0:
													case 2:
														goto IL_A55;
													default:
														num = (short)1628438528;
														if (num != 0)
														{
														}
														switch (0)
														{
														case 0:
															goto IL_AD0;
														}
														continue;
													}
													break;
												}
												}
												IL_AD0:
												if (enumerator == null)
												{
													goto IL_B0B;
												}
												num = (short)2012020737;
												num2 = (int)((global::System.IntPtr)num);
											}
										}
										IL_B09:
										IL_B0B:;
									}
									goto IL_B0C;
								case 9:
									goto IL_86A;
								case 10:
								{
									bool flag;
									if (flag)
									{
										num = (short)22216725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E15;
								}
								case 11:
									num = (short)1846673477;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_86A;
								case 13:
									goto IL_86A;
								case 14:
								{
									num = (short)1932066817;
									if (num != 0)
									{
									}
									bool flag;
									if (flag)
									{
										num = (short)1259732992;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_376;
								}
								case 15:
									if (!enumerator2.MoveNext())
									{
										num = (short)1047003153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									pasirenButtonsListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInner)enumerator2.Current;
									num = (short)455147524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 199));
									num = (short)1867251742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)1133772851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									goto IL_5E9;
								case 19:
									goto IL_3B3;
								case 20:
									num = (short)160628763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)650772552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									num = (short)115015694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 112)
									{
										num = (short)486539286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B0C;
								case 24:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
									num = (short)799932429;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)2083586085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_86A;
								case 27:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value != 201)
									{
										num = (short)662765611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E53;
								case 28:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)14745656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_78F;
								case 29:
									num = (short)1851654202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_86A;
								case 31:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 199)
									{
										num = (short)185139224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 32:
									num = (short)880738375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 222)
									{
										num = (short)1324613684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 34:
								{
									bool flag;
									if (flag)
									{
										num = (short)1996685315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_78F;
								}
								case 35:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1734737940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 36:
									num = (short)1775435786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 225)
									{
										num = (short)1255931922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 38:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value != 202)
									{
										num = (short)1252196354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C62;
								case 39:
									switch (0)
									{
									case 0:
										goto IL_2DA;
									}
									continue;
								case 40:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 202));
									num = (short)515964990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 41:
									num = (short)1809842241;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									goto IL_C62;
								case 43:
									num = (short)720371745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
									num = (short)755236898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									if (!flag2)
									{
										num = (short)1962082371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 46:
									num = (short)105840678;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)892141616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_376;
								case 48:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 200));
									num = (short)1558839305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
									num = (short)2002387012;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									goto IL_86A;
								case 51:
									goto IL_100B;
								case 52:
									goto IL_E53;
								case 53:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 203));
									num = (short)590741516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 224)
									{
										num = (short)464846867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 55:
									goto IL_86A;
								case 56:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 201));
									num = (short)1656488006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
									num = (short)273285174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value != 200)
									{
										num = (short)127533081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5E9;
								case 59:
								{
									bool flag;
									if (!flag)
									{
										num = (short)1845952558;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 60:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value == 113)
									{
										num = (short)1519255596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)773455873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
								{
									bool flag;
									if (!flag)
									{
										num = (short)369426461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 62:
									goto IL_86A;
								case 63:
									goto IL_86A;
								case 64:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value != 203)
									{
										num = (short)929300537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B3;
								case 65:
									if (flag2)
									{
										num = (short)1554972683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BAD;
								case 66:
									if (!flag2)
									{
										num = (short)593821701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 67:
									num = (short)786366528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 68:
									if (flag2)
									{
										num = (short)77463584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_88F;
								case 69:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)1283326005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_BAD;
								case 70:
									goto IL_86A;
								case 71:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)1004404752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_88F;
								case 72:
									if (pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value == 38)
									{
										num = (short)168230952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E15;
								}
								goto IL_2DA;
								IL_376:
								num = (short)557056061;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B3:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
								num = (short)1737031735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E9:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
								num = (short)320471103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_78F:
								num = (short)183500835;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_86A:
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
								enumerator = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.GetEnumerator();
								num = (short)1935540232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_88F:
								num = (short)1459355714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B0C:
								num = (short)239796284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BAD:
								num = (short)1942028333;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C62:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
								num = (short)938868762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E15:
								num = (short)905183291;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E53:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(pasirenButtonsListInner.PASirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540, 38));
								num = (short)1590100018;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F11:
								num = (short)1441267727;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2DA:
								goto IL_F11;
							}
							IL_100B:
							return;
						}
						finally
						{
							num = (short)573702146;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_107B;
								case 1:
									enumerator2.Dispose();
									num = (short)1811218432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1042;
									}
									continue;
								}
								IL_1042:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1282146305;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_107B:;
						}
						goto IL_107E;
					case 2:
						if (radErgoWidePASirenSirenOperation_A.Value == 3)
						{
							num = (short)2125922311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_115F;
					case 3:
						goto IL_107E;
					case 4:
						goto IL_1228;
					case 5:
						goto IL_11B2;
					case 6:
						if (radErgoWidePASirenSirenOperation_A.Value == 0)
						{
							num = (short)1936392207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107E;
					case 7:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaSystemLookup_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaOnly_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200, true));
						num = (short)717094929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						pasirenButtonsListInnerRecset = (controlHeadO9Recset[0][10743].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerRecset);
						num = (short)551485444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_11F0;
					case 10:
						if (controlHeadO9Recset != null)
						{
							num = (short)368967688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1228;
					case 11:
						if (pasirenButtonsListInnerRecset != null)
						{
							num = (short)833159184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200, true));
						num = (short)209911817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						bool flag;
						if (!flag)
						{
							num = (short)695664652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F0;
					}
					case 14:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaSystemLookup_A, true));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaOnly_A, false));
						num = (short)163119109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaSystemLookup_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolSirenPaOnly_A, false));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200, true));
						num = (short)1185218563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						bool flag = radErgoWidePASirenSirenOperation_A.Value == 2;
						num = (short)1613889549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_115F;
					}
					goto IL_77;
					IL_107E:
					num = (short)1385496576;
					short num4 = num;
					num = (short)1557463040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_115F:
					pasirenButtonsListInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)311885834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11B2:
					num = (short)203751426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F0:
					flag2 = !pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
					enumerator2 = pasirenButtonsListInnerRecset.GetEnumerator();
					num = (short)1230635009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1228:
					num = (short)678690827;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_77:
				pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				radErgoWidePASirenSirenOperation_A = pasiren.RadErgoWidePASirenSirenOperation_A9139;
				radWideLabtoolSirenPaSystemLookup_A = pasiren.RefRadioWide.Labtool.RadWideLabtoolSirenPaSystemLookup_A9143;
				radWideLabtoolSirenPaOnly_A = pasiren.RefRadioWide.Labtool.RadWideLabtoolSirenPaOnly_A9142;
				num = (short)1293942790;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060063E9 RID: 25577 RVA: 0x005993A0 File Offset: 0x005975A0
		internal static bool ConManualToneIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index == 4)
					{
						num2 = (short)1836384260;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					result = false;
					num2 = (short)959447046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1013514241;
					if (num2 != 0)
					{
					}
					num2 = (short)172883973;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_159;
				case 4:
					num2 = (short)1751056387;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (pasiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value)
					{
						num2 = (short)2063466497;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					goto IL_FC;
				}
				goto IL_2C;
			}
			IL_FC:
			return result;
			IL_159:
			if (pasiren.RadErgoWidePASirenSirenOperation_A9139.Value == 2)
			{
				goto IL_167;
			}
			return result;
			IL_2C:
			pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
			result = true;
			num2 = (short)1651019766;
			short num3 = num2;
			num2 = (short)1070960630;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_167:
				num2 = (short)282066946;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)1311113216;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)937295872;
			if (num2 != 0)
			{
			}
			num2 = (short)1231880192;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063EA RID: 25578 RVA: 0x00599560 File Offset: 0x00597760
		internal static bool ConCHVIPInputSourceValidWhenCableLengthEnable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0)
					{
						num2 = (short)1524826113;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2145845250;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_D0;
				case 2:
					if (index > 2)
					{
						num2 = (short)1562968070;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_19D;
				case 4:
					if (index - 3 > 1)
					{
						num2 = (short)127991809;
						if (num2 != 0)
						{
						}
						num2 = (short)372375559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_158;
				case 5:
					if (index != 1)
					{
						num2 = (short)901906435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					num2 = (short)952369156;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1805254664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return true;
				}
				goto IL_34;
			}
			IL_D0:
			goto IL_16A;
			IL_158:
			return controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value != 1;
			IL_19D:
			num2 = (short)19660800;
			short num3 = num2;
			return index == 0;
			IL_34:
			num2 = (short)1165118531;
			short num4 = num2;
			num2 = (short)996887619;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_16A:
				num2 = (short)1143668741;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1551958016;
				if (num2 != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				num2 = (short)1813577728;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060063EB RID: 25579 RVA: 0x00599774 File Offset: 0x00597974
		internal static bool conMulCHTxAudioRootingValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (!controlHead.RadErgoWideControlHeadMultiControlHead_A8550.Value)
					{
						return false;
					}
					num2 = (short)479201289;
					short num3 = num2;
					num2 = (short)325715977;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2147024896;
						if (num2 != 0)
						{
						}
						num2 = (short)921894914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (controlHead.RadErgoWideControlHeadMulCHTxAudioRouting_A38459.Value)
					{
						num2 = (short)268828675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					goto IL_14C;
				case 3:
				{
					num2 = (short)1386348544;
					short num4 = num2;
					num2 = (short)1440546817;
					if (num2 != 0)
					{
					}
					num2 = (short)2012282880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			return false;
			IL_14C:
			return controlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561.Value == 1;
			IL_20:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			num2 = (short)1705771009;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063EC RID: 25580 RVA: 0x005998D4 File Offset: 0x00597AD4
		internal static bool ConRemoteMicSourceValidWhenCableLengthEnable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0)
					{
						num2 = (short)206962689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1103036418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_D2;
				case 2:
					if (index > 2)
					{
						num2 = (short)1032781830;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_19D;
				case 4:
					if (index - 3 > 1)
					{
						num2 = (short)2124283911;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_157;
				case 5:
					if (index != 1)
					{
						num2 = (short)1605632003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					num2 = (short)968949764;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1265172481;
					if (num2 != 0)
					{
					}
					num2 = (short)574029832;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return true;
				}
				goto IL_34;
			}
			IL_D2:
			goto IL_169;
			IL_157:
			return controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value != 1;
			IL_19D:
			num2 = (short)1535574016;
			short num3 = num2;
			return index == 0;
			IL_34:
			num2 = (short)1355417686;
			short num4 = num2;
			num2 = (short)184027222;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_169:
				num2 = (short)1592262661;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1064108032;
				if (num2 != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				num2 = (short)1086259200;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060063ED RID: 25581 RVA: 0x00599AE8 File Offset: 0x00597CE8
		internal static bool ConTransceiverDEKDimControlValidWhenCableLengthEnable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1573257216;
					short num3 = num2;
					num2 = (short)785317892;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1C1;
				case 2:
					num2 = (short)410845187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (index - 3 > 1)
					{
						num2 = (short)400162816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_107;
				case 4:
					return true;
				case 5:
					if (controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0)
					{
						goto IL_6A;
					}
					num2 = (short)506331143;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)793613144;
					short num4 = num2;
					num2 = (short)1322488664;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num2 = (short)1807155200;
						if (num2 != 0)
						{
						}
						if (index != 1)
						{
							num2 = (short)458753;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 7:
					if (index > 2)
					{
						num2 = (short)332595202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					num2 = (short)493813766;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_6A:
				num2 = (short)1330184200;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_107:
			num2 = (short)393478145;
			if (num2 != 0)
			{
			}
			return controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value != 1;
			IL_1C1:
			return index == 0;
			IL_34:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			num2 = (short)271712261;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063EE RID: 25582 RVA: 0x00599CF8 File Offset: 0x00597EF8
		internal static bool ConTransceiverVolControlValidWhenCableLengthEnable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)88801280;
					short num3 = num2;
					num2 = (short)1473642500;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_1BD;
				case 2:
					num2 = (short)1727201283;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (index - 3 > 1)
					{
						num2 = (short)938868736;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_105;
				case 4:
					return true;
				case 5:
					if (controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0)
					{
						goto IL_6B;
					}
					num2 = (short)966918151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)2081604194;
					short num4 = num2;
					num2 = (short)1834861154;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B;
					default:
						num2 = (short)998965249;
						if (num2 != 0)
						{
						}
						num2 = (short)1401815040;
						if (num2 != 0)
						{
						}
						if (index != 1)
						{
							num2 = (short)494272513;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 7:
					if (index > 2)
					{
						num2 = (short)450887682;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					num2 = (short)453902342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_34;
				IL_6B:
				num2 = (short)526843912;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_105:
			return controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value != 1;
			IL_1BD:
			return index == 0;
			IL_34:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			num2 = (short)302120965;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063EF RID: 25583 RVA: 0x00599F04 File Offset: 0x00598104
		internal static bool conIsLongKeypressDurForMFKValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced;
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedLongKeypressDurationforMFK_A = advanced.RadErgoWideAdvancedLongKeypressDurationforMFK_A38506;
			global::AcpBusinessLayer.AcpSimpleRangeField radErgoWideAdvancedShortKeypressDurationforMFK_A = advanced.RadErgoWideAdvancedShortKeypressDurationforMFK_A38505;
			if (!global::ConstraintHelper.UtilityMack.IsMobile())
			{
				short num = (short)1174633662;
				short num2 = num;
				num = (short)796753086;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)494338049;
					if (num != 0)
					{
					}
					num = (short)289996800;
					if (num != 0)
					{
					}
					num = (short)2022178816;
					short num3 = num;
					return global::System.Convert.ToInt32(radErgoWideAdvancedLongKeypressDurationforMFK_A.Converter.Convert(radErgoWideAdvancedLongKeypressDurationforMFK_A.Value, null, radErgoWideAdvancedLongKeypressDurationforMFK_A.ConverterParameterObject, null)) > global::System.Convert.ToInt32(radErgoWideAdvancedShortKeypressDurationforMFK_A.Converter.Convert(radErgoWideAdvancedShortKeypressDurationforMFK_A.Value, null, radErgoWideAdvancedShortKeypressDurationforMFK_A.ConverterParameterObject, null));
				}
				}
			}
			return true;
		}

		// Token: 0x060063F0 RID: 25584 RVA: 0x0059A014 File Offset: 0x00598214
		internal static bool ConAbbreviatedAuxOnAliasNotEmpty(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)316014593;
			if (num != 0)
			{
			}
			num = (short)196214784;
			short num2 = num;
			num = (short)78754192;
			short num3 = num;
			num = (short)653046160;
			switch (num3 == num)
			{
			}
			num = (short)563412992;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection;
			global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAbbrAuxOnAlias_A = auxControlTableInnerSection.RadErgoWideAuxControlAbbrAuxOnAlias_A37612;
			if (radErgoWideAuxControlAbbrAuxOnAlias_A.Value != null && radErgoWideAuxControlAbbrAuxOnAlias_A.Value.Length <= 0)
			{
				radErgoWideAuxControlAbbrAuxOnAlias_A.SetValue(radErgoWideAuxControlAbbrAuxOnAlias_A.DefaultValue);
			}
			return auxControlTableInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x0059A10C File Offset: 0x0059830C
		internal static bool ConAuxOnAliasNotEmpty(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)995033089;
			if (num != 0)
			{
			}
			num = (short)2118516736;
			short num2 = num;
			num = (short)1338627155;
			short num3 = num;
			num = (short)1897059411;
			switch (num3 == num)
			{
			}
			num = (short)621150208;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection auxControlTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.AuxControlTableInnerSection;
			global::AcpBusinessLayer.AcpField<string> radErgoWideAuxControlAuxOnAlias_A = auxControlTableInnerSection.RadErgoWideAuxControlAuxOnAlias_A37250;
			if (radErgoWideAuxControlAuxOnAlias_A.Value != null && radErgoWideAuxControlAuxOnAlias_A.Value.Length <= 0)
			{
				radErgoWideAuxControlAuxOnAlias_A.SetValue(radErgoWideAuxControlAuxOnAlias_A.DefaultValue);
			}
			return auxControlTableInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x0059A204 File Offset: 0x00598404
		internal static bool ConRadWideLastSelChanIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1149894657;
			if (num != 0)
			{
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_31:
					num = (short)1269497856;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (advanced.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value)
						{
							num = (short)251854851;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						num = (short)1610678276;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1910192361;
						short num4 = num;
						num = (short)2115909865;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7E;
						default:
							num = (short)1302265856;
							if (num != 0)
							{
							}
							num = (short)2128412672;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_153;
					case 4:
						if (advanced.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value)
						{
							num = (short)1528233986;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					case 5:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)119406593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_77;
				}
				IL_BA:
				return !advanced.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value;
				IL_153:
				goto IL_BA;
			}
			IL_77:
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
			IL_7E:
			num = (short)1342636037;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_31;
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x0059A3B4 File Offset: 0x005985B4
		internal static void ConSetPowerUpOnLastZoneChan(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideAdvancedLastSelectedChannelPerZone_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2041053187;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)501547009;
					if (num2 != 0)
					{
					}
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(advanced.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787, radErgoWideAdvancedLastSelectedChannelPerZone_A.Value));
					goto IL_CE;
				case 2:
					return;
				case 3:
				{
					num2 = (short)612368384;
					short num3 = num2;
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)1532821505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 4:
				{
					if (!radErgoWideAdvancedLastSelectedChannelPerZone_A.Value)
					{
						return;
					}
					num2 = (short)1490778436;
					short num4 = num2;
					num2 = (short)1822652740;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CE;
					default:
						num2 = (short)1448476672;
						if (num2 != 0)
						{
						}
						num2 = (short)568524800;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_CE:
				num2 = (short)150536194;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_24:
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
			radErgoWideAdvancedLastSelectedChannelPerZone_A = advanced.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073;
			num2 = (short)448724996;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063F4 RID: 25588 RVA: 0x0059A538 File Offset: 0x00598738
		internal static bool ConRadWidePowerUpOnLastZoneChanIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)112412199;
					short num3 = num2;
					num2 = (short)2142193191;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_E7;
					}
					break;
				}
				case 1:
					num2 = (short)1635057666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (advanced.RadErgoWideAdvancedLastSelectedChannelPerZone_A41073.Value)
					{
						num2 = (short)260046848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_86;
				case 3:
					num2 = (short)165871617;
					if (num2 != 0)
					{
					}
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)1794441217;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_20;
			}
			IL_86:
			num2 = (short)1626865664;
			short num4 = num2;
			return true;
			IL_E7:
			num2 = (short)810483712;
			if (num2 != 0)
			{
			}
			return advanced.RadErgoWideAdvancedPowerUpOnLastSelectedZoneandChannel_A8787.Value;
			IL_20:
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
			num2 = (short)383516675;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063F5 RID: 25589 RVA: 0x0059A698 File Offset: 0x00598898
		public static bool ConBluetoothEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)335465101;
			short num2 = num;
			num = (short)514312845;
			switch (num2 == num)
			{
			default:
			{
				num = (short)819789824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1795555328;
			if (num != 0)
			{
			}
			num = (short)1919418369;
			if (num != 0)
			{
			}
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth.RadWideBluetoothBluetoothEnable_A37028.Value;
		}

		// Token: 0x060063F6 RID: 25590 RVA: 0x0059A764 File Offset: 0x00598964
		public static bool ConZoneReferencedIsNormalOrDynamicOneBased(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)2069037071;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				switch (num2)
				{
				case 0:
					if (zoneChannelAssignment.RSI != null)
					{
						num = (short)1142358017;
						if (num != 0)
						{
						}
						num = (short)273022998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					goto IL_207;
				case 2:
					zoneChannelAssignment = (acpRecRefField.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)374931477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (index > acpRecRefField.RefRecset.Count)
					{
						num = (short)1755512861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1151991831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)self).RadioErgoConfigACGeneralZone_A36592;
					num = (short)74776588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (zoneChannelAssignment != null)
					{
						num = (short)1522466844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 6:
					goto IL_2B3;
				case 7:
					if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
					{
						num = (short)361103376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 8:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
					{
						num = (short)1450639364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B3;
				case 9:
					goto IL_2B3;
				case 10:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)self).CnvPerSignalingRevertZone_A13269;
					num = (short)1951465478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_2B3;
				case 12:
					goto IL_2B3;
				case 13:
					goto IL_374;
				case 14:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)
					{
						num = (short)278396929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1939144722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_9C;
					}
					continue;
				case 16:
					goto IL_35B;
				case 17:
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num = (short)1101660184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_35B;
				case 18:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)
					{
						num = (short)459735040;
						short num3 = num;
						num = (short)701038602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)34603027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)
					{
						num = (short)1824784411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)713818120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)19005443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_4AE;
				case 22:
					num = (short)1207959569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					if (acpRecRefField != null)
					{
						num = (short)592642050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4AE;
				case 24:
					num = (short)271777799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (index >= 0)
					{
						num = (short)1129906196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 26:
					return true;
				case 27:
				{
					num = (short)166585332;
					short num4 = num;
					num = (short)942400500;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_207;
					default:
						num = (short)1944322048;
						if (num != 0)
						{
						}
						acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)self).CnvWideASTROOTACZone_A8645;
						num = (short)113049609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 28:
					num = (short)981008384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_12F;
				}
				IL_9C:
				if (index == 0)
				{
					num = (short)1665204250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = true;
				acpRecRefField = null;
				zoneChannelAssignment = null;
				num = (short)1179779086;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_207:
				acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)self).RadErgoWideHomeModeZone_A9691;
				num = (short)30539787;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B3:
				num = (short)947650585;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35B:
				result = false;
				num = (short)1326383117;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4AE:
				num = (short)643629061;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_12F:
			return true;
			IL_374:
			return result;
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x0059AC84 File Offset: 0x00598E84
		public static bool ConRadWideHomeModSelIsEnabledAndNonDynamicZone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode homeMode;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					return false;
				case 1:
					num2 = (short)1375600643;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_130;
				case 3:
					goto IL_109;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)259129351;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_135;
				}
				case 5:
				{
					num2 = (short)1938948096;
					short num3 = num2;
					if (homeMode.RadErgoWideHomeModeHomeModeSelection_A8202.Value)
					{
						num2 = (short)870383617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)1387003904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_135;
				}
				case 7:
					num2 = (short)793247750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_135:
				num2 = (short)1960050693;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_130:
			return !homeMode.HomeModeChannel.HiddenStatic;
			IL_30:
			num2 = (short)31354705;
			short num4 = num2;
			num2 = (short)1017016145;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_109:
				if (!homeMode.RadErgoWideHomeModeZone_A9691.HiddenStatic)
				{
					num2 = (short)1461321730;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)511574016;
				if (num2 != 0)
				{
				}
				num2 = (short)741277697;
				if (num2 != 0)
				{
				}
				homeMode = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode);
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = homeMode.RadErgoWideHomeModeZone_A9691.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
				num2 = (short)1616773124;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x0059AE88 File Offset: 0x00599088
		internal static bool ConSirenPaDisplayChoiceEdt(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1058799616;
			short num2 = num;
			num = (short)2145394153;
			short num3 = num;
			num = (short)607002089;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1149435904;
				if (num != 0)
				{
				}
				num = (short)60882945;
				if (num != 0)
				{
				}
				pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				if (!global::ConstraintHelper.UtilityMack.IsMobileOnly())
				{
					return false;
				}
				break;
			}
			return pasiren.RadErgoWidePASirenSirenOperation_A9139.Value == 2;
		}

		// Token: 0x060063F9 RID: 25593 RVA: 0x0059AF50 File Offset: 0x00599150
		internal static bool ConDVRSIsEnAndConsoletteApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (advanced.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
					{
						num2 = (short)452919297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_93;
				case 1:
					num2 = (short)65863681;
					if (num2 != 0)
					{
					}
					num2 = (short)740622339;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)135349026;
					short num3 = num2;
					num2 = (short)1321943842;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_145;
					}
					break;
				}
				case 3:
					if (advanced.RadErgoWideAdvancedConsoletteEnable_A37231.Value)
					{
						num2 = (short)1149173762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_20;
			}
			IL_93:
			return advanced.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
			IL_145:
			num2 = (short)661323776;
			if (num2 != 0)
			{
			}
			goto IL_93;
			IL_20:
			num2 = (short)1533739008;
			short num4 = num2;
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
			num2 = (short)1962541056;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x0059B0C0 File Offset: 0x005992C0
		internal static bool ConDVRSIsEnAndConsoletteValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1132331008;
			short num2 = num;
			num = (short)994758231;
			short num3 = num;
			num = (short)1656016471;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)336199681;
				if (num != 0)
				{
				}
				num = (short)767754240;
				if (num != 0)
				{
				}
				advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
				if (!advanced.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
				{
					return true;
				}
				break;
			}
			return !advanced.RadErgoWideAdvancedConsoletteEnable_A37231.Value;
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x0059B198 File Offset: 0x00599398
		public static bool ConRadEmerKeyPressEditability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1237057536;
			short num2 = num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						num = (short)1165426689;
						if (num != 0)
						{
						}
						if (radioInformation != null)
						{
							num = (short)1793261569;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						num = (short)1525940226;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
						{
							num = (short)432144390;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_100;
					case 4:
					{
						int radInfoLabtoolProductModelIdentifier_A37178Value;
						if (radInfoLabtoolProductModelIdentifier_A37178Value == 7)
						{
							num = (short)1311965187;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						num = (short)1524760580;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						int radInfoLabtoolProductModelIdentifier_A37178Value = radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value;
						num = (short)1147928583;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int radInfoLabtoolProductModelIdentifier_A37178Value;
						if (radInfoLabtoolProductModelIdentifier_A37178Value != 4)
						{
							num = (short)485425157;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B;
					}
					}
					goto IL_59;
				}
				IL_100:
				IL_17B:
				num = (short)1906511446;
				short num4 = num;
				num = (short)1569394262;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_6F;
				default:
					num = (short)2013200384;
					if (num != 0)
					{
					}
					return false;
				}
				return true;
			}
			}
			IL_59:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			IL_6F:
			num = (short)360710144;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060063FC RID: 25596 RVA: 0x0059B370 File Offset: 0x00599570
		internal static bool ConMKFPressBehaviorIsNOTEmergency(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)412345659;
			short num2 = num;
			num = (short)551216443;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1705574400;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)257490945;
			if (num != 0)
			{
			}
			num = (short)1789460480;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced).RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value != 31;
		}

		// Token: 0x060063FD RID: 25597 RVA: 0x0059B43C File Offset: 0x0059963C
		internal static bool ConAggregateCableLengthWhenDualRadioEnable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)2129526784;
			short num2 = num;
			num = (short)27176712;
			short num3 = num;
			num = (short)1984278280;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1062338560;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
				{
					num = (short)1722744833;
					if (num != 0)
					{
					}
					return true;
				}
				break;
			}
			return index == 0;
		}

		// Token: 0x060063FE RID: 25598 RVA: 0x0059B508 File Offset: 0x00599708
		internal static bool ConDualRadioSystemIsNOTSecondaryApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)175046657;
					if (num2 != 0)
					{
					}
					if (self.ParentRecset.IsEmbeddedRecset)
					{
						num2 = (short)2136735745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					radioErgonomicsWide = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num2 = (short)549191683;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)899563099;
					short num3 = num2;
					num2 = (short)1306213979;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1912406016;
						short num4 = num2;
						num2 = (short)1326841856;
						if (num2 != 0)
						{
						}
						radioErgonomicsWide = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
						num2 = (short)1300758530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_14D;
				case 3:
					goto IL_A8;
				}
				goto IL_20;
			}
			IL_A8:
			IL_14D:
			return radioErgonomicsWide.ControlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
			IL_20:
			radioErgonomicsWide = null;
			num2 = (short)494338048;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x0059B684 File Offset: 0x00599884
		internal static bool ConDualRadioSystemIsNOTSecondaryAppAndBlockDarkestDimLevelNotEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1139015680;
			short num2 = num;
			num = (short)325449428;
			short num3 = num;
			num = (short)1317664468;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1132068864;
				if (num != 0)
				{
				}
				num = (short)204079105;
				if (num != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				if (!global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWideConstraints.ConDualRadioSystemIsNOTSecondaryApp(self))
				{
					return false;
				}
				break;
			}
			return !controlHead.RadioErgoWideControlHeadBlockDarkestDimLevel.Value;
		}

		// Token: 0x06006400 RID: 25600 RVA: 0x0059B754 File Offset: 0x00599954
		internal static bool ConRadErgoWideMCHValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1892941824;
			short num2 = num;
			num = (short)1964337551;
			short num3 = num;
			num = (short)49310095;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1323237376;
				if (num != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				if (!controlHead.RadErgoWideControlHeadMultiControlHead_A8550.Value)
				{
					num = (short)1362165761;
					if (num != 0)
					{
					}
					return true;
				}
				break;
			}
			return controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06006401 RID: 25601 RVA: 0x0059B82C File Offset: 0x00599A2C
		internal static bool ConRadErgoWideMCHApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1308229632;
			short num2 = num;
			num = (short)1644397826;
			short num3 = num;
			num = (short)1987478786;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1959723009;
				if (num != 0)
				{
				}
				num = (short)1888747520;
				if (num != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				if (controlHead.RadErgoWideControlHeadMultiControlHead_A8550.Value)
				{
					return true;
				}
				break;
			}
			return controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06006402 RID: 25602 RVA: 0x0059B904 File Offset: 0x00599B04
		internal static bool ConAggregateCableLengthApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1493958656;
			short num2 = num;
			num = (short)199088012;
			short num3 = num;
			num = (short)1926354828;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1285357569;
				if (num != 0)
				{
				}
				num = (short)63373312;
				if (num != 0)
				{
				}
				controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
				if (controlHead.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
				{
					return true;
				}
				break;
			}
			return controlHead.RadErgoWideControlHeadAggregateCableLength_A38456.Value != 0;
		}

		// Token: 0x06006403 RID: 25603 RVA: 0x0059B9DC File Offset: 0x00599BDC
		internal static bool ConRadErgoWideSirenOperationValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1441726464;
			short num2 = num;
			num = (short)1139172028;
			short num3 = num;
			num = (short)554721980;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1056636929;
				if (num != 0)
				{
				}
				num = (short)945750016;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				break;
			}
			return index == 0;
		}

		// Token: 0x06006404 RID: 25604 RVA: 0x0059BAAC File Offset: 0x00599CAC
		internal static bool ConRadErgoWideSirenOperationApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1669005312;
			short num2 = num;
			num = (short)731337261;
			short num3 = num;
			num = (short)413815341;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren pasiren;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1463549952;
				if (num != 0)
				{
				}
				pasiren = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.PASiren);
				if (pasiren.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				break;
			}
			num = (short)245628929;
			if (num != 0)
			{
			}
			return pasiren.RadErgoWidePASirenSirenOperation_A9139.Value != 0;
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x0059BB88 File Offset: 0x00599D88
		internal static bool ConRadErgoHornLightIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1472397312;
			short num2 = num;
			num = (short)947332751;
			short num3 = num;
			num = (short)1707157135;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights hornAndLights;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1922891776;
				if (num != 0)
				{
				}
				hornAndLights = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights);
				if (hornAndLights.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					num = (short)1759903745;
					if (num != 0)
					{
					}
					return true;
				}
				break;
			}
			return !hornAndLights.RadErgoWideHornandLightsHornLights_A8206.Value;
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x0059BC60 File Offset: 0x00599E60
		internal static bool ConRadErgoHornLightIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)480575488;
			short num2 = num;
			num = (short)814828253;
			short num3 = num;
			num = (short)118770397;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights hornAndLights;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1491927041;
				if (num != 0)
				{
				}
				num = (short)1738407936;
				if (num != 0)
				{
				}
				hornAndLights = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HornAndLights);
				if (hornAndLights.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2)
				{
					return true;
				}
				break;
			}
			return hornAndLights.RadErgoWideHornandLightsHornLights_A8206.Value;
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x0059BD38 File Offset: 0x00599F38
		internal static bool ConMKFPressBehaviorIsNOTEmergencyANDSecondaryRadio(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1860632576;
			short num2 = num;
			num = (short)923897953;
			short num3 = num;
			num = (short)1498517601;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)416153601;
				if (num != 0)
				{
				}
				num = (short)993394688;
				if (num != 0)
				{
				}
				advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
				if (advanced.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value == 31)
				{
					return false;
				}
				break;
			}
			return advanced.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x06006408 RID: 25608 RVA: 0x0059BE20 File Offset: 0x0059A020
		internal static bool conMOSCADDataApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2088697856;
			short num2 = num;
			num = (short)1680554241;
			short num3 = num;
			num = (short)1019951361;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)898826241;
				if (num != 0)
				{
				}
				num = (short)1829044224;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset).GetEnumerator();
				try
				{
					num = (short)839516161;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_105;
							}
							continue;
						case 2:
							num = (short)1411907587;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_189;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1031274498;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.CalculateValidity();
							num = (short)378011648;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_13C:
						num = (short)2018902020;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_105:
						goto IL_13C;
					}
					IL_189:;
				}
				finally
				{
					num = (short)823721984;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1BB;
							}
							continue;
						case 1:
							goto IL_1EF;
						case 2:
							enumerator.Dispose();
							num = (short)117112833;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1BB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1029046274;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1EF:;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x0059C030 File Offset: 0x0059A230
		internal static bool conMOSCADDataValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)327811072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced advanced;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					switch (num2)
					{
					case 0:
					{
						num = (short)1847918592;
						short num3 = num;
						try
						{
							num = (short)1322188801;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_450;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_34A;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality)enumerator.Current).Features.CnvPerFeatureRFModem_42485.Value != 0)
									{
										num = (short)390463493;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_432;
								case 4:
									if (advanced.RadErgoWideMOSCADDataEnable_A8545.Value)
									{
										num = (short)517013512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)1878654980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)310247424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1970012166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)710737922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									result = false;
									num = (short)1474691075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3D7:
								num = (short)1965883399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34A:
								goto IL_3D7;
							}
							IL_432:
							return result;
							IL_450:
							goto IL_1F0;
						}
						finally
						{
							num = (short)1282408448;
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
										goto IL_487;
									}
									continue;
								case 1:
									goto IL_4BC;
								case 2:
									enumerator.Dispose();
									num = (short)128385025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_487:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1041432578;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4BC:;
						}
						goto IL_4BF;
					}
					case 1:
						num = (short)1877409795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (radioErgonomicsWide == null)
						{
							goto IL_268;
						}
						num = (short)582348241;
						short num4 = num;
						num = (short)924184017;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2F9;
						default:
							num = (short)1071841280;
							if (num != 0)
							{
							}
							num = (short)248381449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (advanced.RadErgoWideMOSCADDataEnable_A8545.Value)
						{
							num = (short)1145896971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 4:
						if ((((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset).ParentSection as global::Motorola.MackinawCPS.CoreFeatures.DEK.General).DEKNumberofDEKBoxes_A8579.Value != 0)
						{
							num = (short)1461190672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1546125324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F0;
					case 6:
						goto IL_2F9;
					case 7:
						if (advanced.RadErgoWideMOSCADDataEnable_A8545.Value)
						{
							num = (short)938082317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (advanced.RefRadioWide.Features.RadWideAdvancedRFModem_A8972.Value != 0)
						{
							num = (short)712835073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_114;
					case 9:
						num = (short)1982922767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (advanced.RadErgoWideMOSCADDataEnable_A8545.Value)
						{
							num = (short)2135425025;
							if (num != 0)
							{
							}
							num = (short)880345102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					case 11:
						return false;
					case 12:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)2075131904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						return false;
					case 14:
						return false;
					case 15:
						if (radioErgonomicsWide.ControlHead.RadErgoWideControlHeadExpectedNumofControlHeads_A7982.Value != 1)
						{
							num = (short)731578374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_268;
					case 16:
						num = (short)1890254855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_72;
					IL_114:
					radioErgonomicsWide = (advanced.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					num = (short)278855682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F0:
					num = (short)1249640452;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_268:
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)1700265989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BF:
					num = (short)5636106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					goto IL_4BF;
				}
				return false;
				IL_72:
				advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.Advanced);
				num = (short)1471283208;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x0059C5D0 File Offset: 0x0059A7D0
		internal static void ConSyncNewToActiveRSMInternalMicIfNoBTMic(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)131858432;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_5E;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_34:
				switch (num3)
				{
				case 0:
					goto IL_24B;
				case 1:
					while (radioErgonomicsWide != null)
					{
						num = (short)1351328385;
						short num4 = num;
						num = (short)966763137;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)758972416;
							if (num != 0)
							{
							}
							num = (short)2021326850;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_34;
						}
					}
					return;
				case 2:
					num = (short)766967816;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num = (short)345833472;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576, true));
					num = (short)461963270;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (!radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.Value)
					{
						num = (short)374669316;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_1DF;
				case 7:
					num = (short)735379459;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedActiveMicForBTPTT_43051.Value == 3)
					{
						num = (short)679477255;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1962409989;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5E;
			}
			IL_1DF:
			num = (short)1723203585;
			if (num != 0)
			{
			}
			return;
			IL_24B:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioWide.Bluetooth.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576, false));
			return;
			IL_5E:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
			num = (short)959447041;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_34;
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x0059C830 File Offset: 0x0059AA30
		public static bool ConRadioProfileDifferentValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1109983232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B6;
				}
				global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationDefaultProfile_A;
				global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationSurveillanceProfile_A;
				global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationCovertProfile_A;
				global::AcpBusinessLayer.AcpRecRefField radErgoWideLogicalProfileConfigurationLoudAudioProfile_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						goto IL_1E4;
					case 2:
						if (self.CurrentField.Name == radErgoWideLogicalProfileConfigurationDefaultProfile_A.Name)
						{
							num = (short)705036316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					case 3:
						if (index == radErgoWideLogicalProfileConfigurationSurveillanceProfile_A.Value)
						{
							num = (short)311558145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EF;
					case 4:
						if (index != radErgoWideLogicalProfileConfigurationDefaultProfile_A.Value)
						{
							num = (short)2127888414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)613613571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (index == 0)
						{
							num = (short)1522860032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)417857560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (index != radErgoWideLogicalProfileConfigurationCovertProfile_A.Value)
						{
							num = (short)1435435020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_2D9;
					case 9:
						if (index != radErgoWideLogicalProfileConfigurationLoudAudioProfile_A.Value)
						{
							num = (short)1246232581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
					{
						num = (short)99024896;
						short num3 = num;
						if (index != radErgoWideLogicalProfileConfigurationDefaultProfile_A.Value)
						{
							num = (short)1616642065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26F;
					}
					case 11:
						goto IL_2D4;
					case 12:
						num = (short)854392836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (self.CurrentField.Name == radErgoWideLogicalProfileConfigurationSurveillanceProfile_A.Name)
						{
							num = (short)1291976724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						num = (short)1547960329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_150;
					case 16:
						if (self.CurrentField.Name == radErgoWideLogicalProfileConfigurationLoudAudioProfile_A.Name)
						{
							num = (short)1240858643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_483;
					case 17:
						num = (short)1818689561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (index == radErgoWideLogicalProfileConfigurationLoudAudioProfile_A.Value)
						{
							num = (short)1728708619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
						num = (short)1266221079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)2067791879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (index == radErgoWideLogicalProfileConfigurationSurveillanceProfile_A.Value)
						{
							num = (short)2041511944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					case 22:
						num = (short)1185284106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (index != radErgoWideLogicalProfileConfigurationCovertProfile_A.Value)
						{
							goto IL_5F6;
						}
						goto IL_26F;
					case 24:
						if (self.CurrentField.Name == radErgoWideLogicalProfileConfigurationCovertProfile_A.Name)
						{
							num = (short)660865055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EF;
					case 25:
						if (index == radErgoWideLogicalProfileConfigurationSurveillanceProfile_A.Value)
						{
							num = (short)1927413775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_483;
					case 26:
						if (index != radErgoWideLogicalProfileConfigurationDefaultProfile_A.Value)
						{
							num = (short)95617038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						if (index != radErgoWideLogicalProfileConfigurationCovertProfile_A.Value)
						{
							num = (short)977403937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 28:
						num = (short)965476379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)2141126677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1983512594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)299565082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (index != radErgoWideLogicalProfileConfigurationLoudAudioProfile_A.Value)
						{
							num = (short)1129512989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 33:
						num = (short)884146208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6;
					IL_155:
					num = (short)179634192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EF:
					num = (short)1419706370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_483:
					num = (short)1191051277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F6:
					num = (short)1949368342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D9:
					num = (short)968318306;
					short num4 = num;
					num = (short)193158498;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5F6;
					default:
						goto IL_310;
					}
				}
				return true;
				IL_150:
				goto IL_26F;
				IL_1E4:
				return false;
				IL_26F:
				num = (short)1744175105;
				if (num != 0)
				{
				}
				return false;
				IL_2D4:
				return false;
				IL_310:
				num = (short)1736441856;
				if (num != 0)
				{
				}
				return false;
				IL_B6:
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration logicalProfileConfiguration = self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.LogicalProfileConfiguration;
				radErgoWideLogicalProfileConfigurationCovertProfile_A = logicalProfileConfiguration.RadErgoWideLogicalProfileConfigurationCovertProfile_A43135;
				radErgoWideLogicalProfileConfigurationDefaultProfile_A = logicalProfileConfiguration.RadErgoWideLogicalProfileConfigurationDefaultProfile_A43136;
				radErgoWideLogicalProfileConfigurationLoudAudioProfile_A = logicalProfileConfiguration.RadErgoWideLogicalProfileConfigurationLoudAudioProfile_A43137;
				radErgoWideLogicalProfileConfigurationSurveillanceProfile_A = logicalProfileConfiguration.RadErgoWideLogicalProfileConfigurationSurveillanceProfile_A43138;
				num = (short)1072037894;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x0059CE54 File Offset: 0x0059B054
		public static bool ConRadErgoWideControlHeadBluetoothControlApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::AcpBusinessLayer.AcpField<bool> acpField;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead controlHead;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					flag = false;
					goto IL_1B1;
				case 1:
					return false;
				case 2:
					if (acpField == null)
					{
						num2 = (short)1130561542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_203;
				case 3:
					goto IL_1CB;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					if (radioWide == null)
					{
						num2 = (short)4128776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1211564037;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A = controlHead.RadErgoWideControlHeadMultiControlHead_A8550;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth = radioWide.Bluetooth;
					acpField = ((bluetooth != null) ? bluetooth.RadWideBluetoothBluetoothEnable_A37028 : null);
					if (radErgoWideControlHeadMultiControlHead_A == null)
					{
						num2 = (short)190513152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					flag = radErgoWideControlHeadMultiControlHead_A.Value;
					goto IL_1B1;
				}
				case 6:
					return false;
				case 7:
				{
					num2 = (short)330432512;
					short num3 = num2;
					if (controlHead == null)
					{
						num2 = (short)1891631105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)820903937;
					if (num2 != 0)
					{
					}
					num2 = (short)1059144127;
					short num4 = num2;
					num2 = (short)351879615;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1CB;
					default:
					{
						num2 = (short)75890688;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num2 = (short)1056899076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
					return false;
				}
				goto IL_34;
				IL_1B1:
				if (flag)
				{
					num2 = (short)393543683;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return false;
				IL_1CB:
				num2 = (short)984285186;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_203:
			return acpField.Value;
			IL_34:
			controlHead = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHead);
			num2 = (short)338165767;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
