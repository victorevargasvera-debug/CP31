using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalWide
{
	// Token: 0x02000545 RID: 1349
	public static class ConventionalWideConstraints
	{
		// Token: 0x0600B517 RID: 46359 RVA: 0x00A7AF58 File Offset: 0x00A79158
		internal static bool conARPCacheDepthNotZero(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1972150195;
			short num2 = num;
			num = (short)843030451;
			switch (num2 == num)
			{
			}
			num = (short)426770432;
			short num3 = num;
			num = (short)1783889921;
			if (num != 0)
			{
			}
			num = (short)1765146624;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData).CnvWideASTRODataARPCacheDepth_A7463.Value != 0;
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x00A7B014 File Offset: 0x00A79214
		internal static bool ConCheckOtacChanValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpRecRefField cnvWideASTROOTACZone_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index == 65535)
					{
						num2 = (short)1926299655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2037710850;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (index < 255)
					{
						num2 = (short)1279721483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					if (index <= 0)
					{
						return false;
					}
					num2 = (short)1618804737;
					if (num2 != 0)
					{
					}
					num2 = (short)745272270;
					short num3 = num2;
					num2 = (short)1801581518;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
					{
						num2 = (short)1743519744;
						if (num2 != 0)
						{
						}
						num2 = (short)1189609472;
						short num4 = num2;
						num2 = (short)1701838858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					num2 = (short)1500315648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return true;
				case 5:
					if (index != 0)
					{
						num2 = (short)486080515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_194;
				case 6:
					if (cnvWideASTROOTACZone_A.Value > 0)
					{
						num2 = (short)781516809;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					goto IL_194;
				case 8:
					if (cnvWideASTROOTACZone_A.Value <= 0)
					{
						num2 = (short)25100292;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					return true;
				case 10:
					num2 = (short)1892089857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1317470214;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_194:
				num2 = (short)2114519048;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_40:
			cnvWideASTROOTACZone_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection).CnvWideASTROOTACZone_A8645;
			num2 = (short)1299316741;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x00A7B278 File Offset: 0x00A79478
		public static bool ConZoneReferencedIsNormalOrDynamicOneBased(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1529151500;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				switch (num2)
				{
				case 0:
					if (index >= 0)
					{
						num = (short)1982201863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)684785669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)
					{
						num = (short)166526997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1617166344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)self).CnvWideASTROOTACZone_A8645;
					num = (short)5963802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (index > acpRecRefField.RefRecset.Count)
					{
						num = (short)1855389714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)743112728;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
					{
						num = (short)936837148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 6:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)self).RadioErgoConfigACGeneralZone_A36592;
					num = (short)305856541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1857224708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)
					{
						num = (short)2038366223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)606208016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_4A0;
				case 10:
					goto IL_3B8;
				case 11:
					goto IL_25F;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				case 13:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
					{
						num = (short)602210310;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25F;
				case 14:
					num = (short)1011482644;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)self).CnvPerSignalingRevertZone_A13269;
					num = (short)514326545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)
					{
						num = (short)393478147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)707526669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_25F;
				case 18:
					goto IL_131;
				case 19:
					if (zoneChannelAssignment != null)
					{
						num = (short)96600078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 20:
					if (zoneChannelAssignment.RSI != null)
					{
						num = (short)745078811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 21:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)self).RadErgoWideHomeModeZone_A9691;
					num = (short)1244594187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
				{
					num = (short)18874368;
					short num3 = num;
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num = (short)185532417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_355;
				}
				case 23:
					return true;
				case 24:
					IL_1F2:
					if (acpRecRefField != null)
					{
						num = (short)775946265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A0;
				case 25:
					zoneChannelAssignment = (acpRecRefField.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)1469710345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 26:
					goto IL_25F;
				case 27:
					num = (short)990117910;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_355;
				case 29:
					goto IL_25F;
				}
				IL_9D:
				if (index == 0)
				{
					num = (short)1967128599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = true;
				acpRecRefField = null;
				zoneChannelAssignment = null;
				num = (short)51838978;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_355:
				result = false;
				num = (short)2022635357;
				short num4 = num;
				num = (short)1149368157;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1F2;
				default:
					num = (short)456065024;
					if (num != 0)
					{
					}
					num = (short)1526661130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_25F:
				num = (short)949616641;
				if (num != 0)
				{
				}
				num = (short)1869676544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4A0:
				num = (short)1950875667;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_131:
			return true;
			IL_3B8:
			return result;
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x00A7B78C File Offset: 0x00A7998C
		public static bool ConASTROOTACChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_6F;
			}
			short num;
			int num3;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				num = (short)990553151;
				short num2 = num;
				num = (short)1129358399;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2051473408;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_9F;
					case 1:
						num = (short)222887939;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)211615748;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
					{
						result = false;
						num = (short)1125384192;
						short num4 = num;
						num = (short)207355906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6F;
				}
				IL_9F:
				if (zoneChannelAssignment == null)
				{
					break;
				}
				num = (short)1974009857;
				if (num != 0)
				{
				}
				num = (short)306249729;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6F:
			result = true;
			zoneChannelAssignment = ((self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection).CnvWideASTROOTACZone_A8645.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num = (short)631832576;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x00A7B910 File Offset: 0x00A79B10
		public static void conChangeLengthOfSoftIDUsername(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 14;
			short num = (short)1281949696;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				string text;
				global::AcpBusinessLayer.AcpFieldX<string, string> radWideUserInformationandPasswordsSoftIDUsername_A;
				for (;;)
				{
					IL_30:
					num = (short)1977286657;
					if (num != 0)
					{
					}
					int value;
					int length;
					switch (num2)
					{
					case 0:
						goto IL_F5;
					case 1:
						goto IL_294;
					case 2:
						if (radioWideRecset != null)
						{
							num = (short)462356485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_261;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
						if (conventionalWideRecset != null)
						{
							num = (short)856293388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
						num = (short)2006450183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453, 8));
						num = (short)2139947008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						num = (short)303733484;
						short num3 = num;
						num = (short)904370924;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_261;
						default:
						{
							num = (short)1309212672;
							if (num != 0)
							{
							}
							if (radioWideRecset.Count < 1)
							{
								num = (short)1419837455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords = radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords;
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2024) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset;
							num = (short)1400897540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 8:
						goto IL_F5;
					case 9:
						goto IL_2FA;
					case 10:
					{
						int num4 = value - length;
						int num5 = 0;
						num = (short)502530049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int num4;
						int num5;
						if (num5 >= num4)
						{
							num = (short)407961609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text += global::AllFeatures.CodeplugGuid.b("", a_);
						num5++;
						num = (short)826277891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)570753038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (length < value)
						{
							num = (short)1636171786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44F;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
						if (conventionalWideRecset.Count < 1)
						{
							num = (short)1404502032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1272709137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_387;
					case 16:
						goto IL_44A;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
						if ((conventionalWideRecset[0][10057] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.Features).CnvWideFeaturesSoftIDFeature_A9168.Value)
						{
							num = (short)954204166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords userInformationAndPasswords;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(userInformationAndPasswords.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453, 20));
						num = (short)11534344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A7;
					IL_F5:
					radWideUserInformationandPasswordsSoftIDUsername_A = (radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsername_A9169;
					string value2 = radWideUserInformationandPasswordsSoftIDUsername_A.Value;
					global::AcpBusinessLayer.AcpSimpleRangeField radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A = (radioWideRecset[0][10102] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.UserInformationAndPasswords).RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;
					text = global::System.Convert.ToString(value2).TrimEnd(global::System.Array.Empty<char>());
					length = text.Length;
					value = radWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A.Value;
					num = (short)674562061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_294:
					num = (short)526057472;
					short num6 = num;
					num = (short)2112421899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_261:
					goto IL_294;
				}
				return;
				IL_2FA:
				goto IL_44F;
				IL_387:
				return;
				IL_44A:
				return;
				IL_44F:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(radWideUserInformationandPasswordsSoftIDUsername_A, text));
				return;
				IL_A7:
				radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				num = (short)1149239298;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x00A7BD7C File Offset: 0x00A79F7C
		internal static bool ConTacticalInhibitEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1504174267;
			short num2 = num;
			num = (short)516874427;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)703791104;
				if (num != 0)
				{
				}
				num = (short)1615331328;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					break;
				}
				break;
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
			bool value;
			bool result;
			for (;;)
			{
				IL_70:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					if (conventionalPersonalityRecset != null)
					{
						num = (short)1556742145;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 1:
					goto IL_38C;
				case 2:
				{
					num = (short)1778581504;
					short num4 = num;
					try
					{
						num = (short)1181155330;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
								if (astrocall != null)
								{
									num = (short)1136721930;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1371275273;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10141] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall;
								num = (short)1960771584;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_148;
								}
								continue;
							case 3:
								goto IL_1B2;
							case 4:
							{
								int value2;
								if (value2 == 3)
								{
									num = (short)121634824;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								num = (short)212729870;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (!value)
								{
									num = (short)638779397;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_198;
							case 7:
								num = (short)96206852;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_287;
							case 9:
								num = (short)1537540109;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
								int value2 = astrocall.CnvPerASTROCallTacticalServicesOperation.Value;
								int value3 = astrocall.CnvPerASTROCallRadioUninhibitDecodeAction_A9045.Value;
								num = (short)13041670;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_198;
							case 12:
							{
								int value3;
								if (value3 == 0)
								{
									num = (short)549060619;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 13:
								goto IL_31B;
							case 14:
							{
								int value2;
								if (value2 != 1)
								{
									num = (short)1510735879;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_287;
							}
							}
							goto IL_148;
							IL_198:
							result = true;
							num = (short)1752825859;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_1B7:
							num = (short)2042888193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_148:
							goto IL_1B7;
							IL_287:
							num = (short)1604386828;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1B2:
						IL_31B:
						return result;
					}
					finally
					{
						num = (short)1737424896;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_352;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1038221314;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_389;
							}
							IL_352:
							if (enumerator == null)
							{
								break;
							}
							num = (short)793837569;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_389:;
					}
					goto IL_38C;
				}
				}
				goto IL_83;
				IL_38C:
				num = (short)594214913;
				if (num != 0)
				{
				}
				result = false;
				enumerator = conventionalPersonalityRecset.GetEnumerator();
				num = (short)1091698690;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_83:
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData astrodata = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ASTROData;
			conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
			value = astrodata.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.Value;
			num = (short)786235392;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_70;
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x00A7C1AC File Offset: 0x00A7A3AC
		public static bool ConDirectFreqEnableIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)210698240;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				num = (short)1523712000;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)767950849;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 1:
					return result;
				case 2:
					for (;;)
					{
						result = false;
						num = (short)1581992745;
						short num4 = num;
						num = (short)81546025;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_F5;
						}
					}
					IL_F5:
					num = (short)452329472;
					if (num != 0)
					{
					}
					num = (short)1475739649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_83:
				global::AcpBusinessLayer.AcpField<bool> cnvWideGeneralDirectFrequency_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.General).CnvWideGeneralDirectFrequency_A7860;
				result = true;
				bool flag = false;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
				if (radioWide != null && radioWide.Features.RadWideFeaturesZoneCloneEnable_43130 != null)
				{
					flag = radioWide.Features.RadWideFeaturesZoneCloneEnable_43130.Value;
				}
				if (!cnvWideGeneralDirectFrequency_A || !flag)
				{
					break;
				}
				num = (short)1411973122;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
		}
	}
}
