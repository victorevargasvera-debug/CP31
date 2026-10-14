using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x02000420 RID: 1056
	public static class ActionConsolidationConstraints
	{
		// Token: 0x060090F1 RID: 37105 RVA: 0x00889048 File Offset: 0x00887248
		internal static bool ConWhenSirenTypeIsNoChange(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value == 0)
			{
				short num = (short)1978591111;
				short num2 = num;
				num = (short)1790961543;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)734986240;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)923074561;
				if (num != 0)
				{
				}
				num = (short)1081212928;
				short num3 = num;
				return false;
			}
			return true;
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0088910C File Offset: 0x0088730C
		internal static bool ConGPSReportErrStrategyApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGpsReport_A36587.Value)
			{
				short num = (short)28352628;
				short num2 = num;
				num = (short)569876596;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)96206849;
					if (num != 0)
					{
					}
					num = (short)992870400;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)863502336;
				short num3 = num;
				return true;
			}
			return false;
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x008891CC File Offset: 0x008873CC
		internal static bool ConGPSAndModeCannotBothBeConfigured(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general = self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (self.Parent[10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1009844231;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1FB;
					case 1:
						goto IL_1B7;
					case 2:
						num = (short)1132265475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (general.RadioErgoConfigACGpsReport_A36587.Value)
						{
							num = (short)782434304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 74)
						{
							num = (short)1175912450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						if (!enumerator.MoveNext())
						{
							num = (short)638844936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1955921924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_214;
					case 7:
					{
						num = (short)1998275661;
						short num3 = num;
						num = (short)1861174349;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1FB;
						default:
							num = (short)1537343488;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_E8;
							}
							continue;
						}
						break;
					}
					case 8:
						num = (short)478937089;
						if (num != 0)
						{
						}
						num = (short)247136262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_EA:
					num = (short)1403125765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E8:
					goto IL_EA;
					IL_1FB:
					result = false;
					num = (short)1969029121;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B7:
				return result;
				IL_214:
				goto IL_29;
			}
			finally
			{
				num = (short)356319234;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1827733505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_27F;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_24A;
						}
						continue;
					}
					IL_24A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1600585728;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27F:;
			}
			return result;
			IL_29:
			num = (short)873332736;
			short num4 = num;
			return true;
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x00889478 File Offset: 0x00887678
		internal static void ConValueSetActionAllowedOnResponseSelector(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)110559232;
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
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
				int num3;
				global::AcpBusinessLayer.AcpFieldX<bool, string> radioErgoConfigACGeneralActionAllowed_A;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (consolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260)
						{
							num = (short)1476329481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (num3 > 1)
						{
							num = (short)1047265286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioErgoConfigACGeneralActionAllowed_A, true));
						num = (short)323485703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)66584576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)2145583104;
						short num4 = num;
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 2)
						{
							num = (short)398196737;
							if (num != 0)
							{
							}
							num = (short)1839267842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						goto IL_3B9;
					case 5:
						return;
					case 6:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioErgoConfigACGeneralActionAllowed_A, false));
						num = (short)1092681732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_3B9;
					case 8:
						try
						{
							num = (short)1973420040;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1519321097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)454885379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num3++;
									num = (short)1571356679;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radioErgoConfigACGeneralActionAllowed_A, false));
									num = (short)2085814277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 74)
									{
										num = (short)199950338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)94371844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									num = (short)36676872;
									short num5 = num;
									num = (short)1756931336;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)251920384;
										if (num != 0)
										{
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 75)
										{
											num = (short)1399586817;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 5:
									goto IL_226;
								case 6:
									goto IL_344;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1A5;
									}
									continue;
								case 9:
									num = (short)1263337478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A7:
								num = (short)1637154816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A5:
								goto IL_1A7;
							}
							IL_226:
							return;
							IL_344:
							goto IL_47D;
						}
						finally
						{
							num = (short)952172546;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)135266305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3B6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_37C;
									}
									continue;
								}
								IL_37C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)758972416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B6:;
						}
						goto IL_3B9;
						IL_47D:
						num = (short)1583546369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877, 255));
						num = (short)1724252165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_3B9:
					num = (short)308871171;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_56:
				consolidatedActionsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection);
				actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
				radioErgoConfigACGeneralActionAllowed_A = actionConsolidation.General.RadioErgoConfigACGeneralActionAllowed_A36579;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset;
				num3 = 0;
				enumerator = collection.GetEnumerator();
				num = (short)1534853128;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x0088995C File Offset: 0x00887B5C
		internal static bool ConZoneApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value == 74)
			{
				short num = (short)1949114869;
				short num2 = num;
				num = (short)1373315573;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)800391169;
					if (num != 0)
					{
					}
					num = (short)1520238592;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1138688000;
				short num3 = num;
				return true;
			}
			return false;
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00889A24 File Offset: 0x00887C24
		internal static bool ConStsXIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::AcpBusinessLayer.AcpListField radioErgoConfigACActionID_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
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
						if (radioErgoConfigACActionID_A.Value == 75)
						{
							num2 = (short)496369672;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 1:
					{
						if (radioErgoConfigACActionID_A.Value == 75)
						{
							return true;
						}
						num2 = (short)940314396;
						short num3 = num2;
						num2 = (short)1321144092;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_72;
						default:
							num2 = (short)2043871232;
							if (num2 != 0)
							{
							}
							num2 = (short)789315596;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						num2 = (short)1147731969;
						if (num2 != 0)
						{
						}
						goto IL_11A;
					case 3:
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value != 0)
						{
							num2 = (short)754778125;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F5;
					case 4:
						goto IL_2A1;
					case 5:
						if (radioErgoConfigACActionID_A.Value != 259)
						{
							num2 = (short)1053818882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 6:
						num2 = (short)741539849;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 5)
						{
							num2 = (short)899416079;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 8:
						goto IL_230;
					case 9:
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value != 1)
						{
							num2 = (short)702349323;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2A1;
					case 10:
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value == 2)
						{
							num2 = (short)184483844;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11A;
					case 11:
						num2 = (short)707264522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						num2 = (short)890699781;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 13:
						num2 = (short)1925775367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
					{
						num2 = (short)959315968;
						short num4 = num2;
						if (actionConsolidation != null)
						{
							num2 = (short)100794374;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					case 15:
						goto IL_1F5;
					}
					goto IL_50;
					IL_11A:
					num2 = (short)698155011;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1F5:
					num2 = (short)1586233344;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_2A1:
					num2 = (short)76808193;
					num = (int)((global::System.IntPtr)num2);
				}
				return true;
				IL_230:
				return true;
			}
			IL_50:
			radioErgoConfigACActionID_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590;
			actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
			IL_72:
			num2 = (short)554958862;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00889D60 File Offset: 0x00887F60
		internal static bool ConRelayPatternErrStrategyApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value == 0)
			{
				short num = (short)264947412;
				short num2 = num;
				num = (short)425772756;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)585367553;
					if (num != 0)
					{
					}
					num = (short)1447165952;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1051590656;
				short num3 = num;
				return false;
			}
			return true;
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x00889E24 File Offset: 0x00888024
		internal static bool ConChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
			global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACGeneralZone_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)60817412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12F;
				case 1:
					num2 = (short)1429405701;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (consolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 74)
					{
						num2 = (short)1832255489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_12A;
				case 4:
					return false;
				case 5:
					if (radioErgoConfigACGeneralZone_A.Value != 0)
					{
						num2 = (short)924057603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
				{
					if (zoneChannelAssignment == null)
					{
						goto IL_12F;
					}
					num2 = (short)702645717;
					short num3 = num2;
					num2 = (short)1334609365;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)1948975104;
						if (num2 != 0)
						{
						}
						num2 = (short)1841889281;
						if (num2 != 0)
						{
						}
						num2 = (short)1915420679;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)2113011712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_12F:
				num2 = (short)1115029506;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_12A:
			num2 = (short)1862533120;
			short num4 = num2;
			return true;
			IL_30:
			consolidatedActionsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection);
			radioErgoConfigACGeneralZone_A = consolidatedActionsInnerSection.RadioErgoConfigACGeneralZone_A36592;
			zoneChannelAssignment = (radioErgoConfigACGeneralZone_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)710803462;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x0088A014 File Offset: 0x00888214
		internal static bool ConModeAndGPSCannotBothBeConfigured(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_E8;
			}
			int num;
			global::AcpBusinessLayer.AcpListField radioErgoConfigACActionType_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioErgoConfigACActionType_A.Value != 2)
					{
						num2 = (short)618201108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_1D8;
				case 2:
					if (radioErgoConfigACActionType_A.Value != 3)
					{
						num2 = (short)1037041717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1390673970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_75D;
				case 5:
					if (radioErgoConfigACActionType_A.Value == 5)
					{
						num2 = (short)1927151664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					goto IL_641;
				case 7:
					goto IL_6BF;
				case 8:
					if (radioErgoConfigACActionType_A.Value == 0)
					{
						num2 = (short)1029701672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					num2 = (short)885719054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1887633432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (radioErgoConfigACActionType_A.Value == 5)
					{
						num2 = (short)1081802759;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 12:
					num2 = (short)857604124;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)208011269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (radioErgoConfigACActionType_A.Value != 4)
					{
						num2 = (short)118947853;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 15:
					num2 = (short)1124532247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (index != 42)
					{
						num2 = (short)1737490447;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_25C;
				case 17:
					if (radioErgoConfigACActionType_A.Value != 4)
					{
						num2 = (short)924647453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 18:
					if (!actionConsolidation.General.RadioErgoConfigACGpsReport_A36587.Value)
					{
						num2 = (short)1654259742;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 19:
					num2 = (short)1327169552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)1943928857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_71B;
				case 22:
					num2 = (short)1757741067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (index != 74)
					{
						num2 = (short)517996590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2106851346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
				{
					num2 = (short)1129008301;
					short num3 = num2;
					num2 = (short)1349733549;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46B;
					default:
						num2 = (short)1634795520;
						if (num2 != 0)
						{
						}
						if (radioErgoConfigACActionType_A.Value != 0)
						{
							num2 = (short)1081737225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 25:
					if (radioErgoConfigACActionType_A.Value != 3)
					{
						num2 = (short)1194590220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 26:
					num2 = (short)119668737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)1082130465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (radioErgoConfigACActionType_A.Value != 0)
					{
						num2 = (short)221446191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 29:
					num2 = (short)238288931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)1488191531;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1546256425;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (radioErgoConfigACActionType_A.Value != 3)
					{
						num2 = (short)663879722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 33:
					if (radioErgoConfigACActionType_A.Value != 4)
					{
						num2 = (short)1541865494;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 34:
					return false;
				case 35:
					if (radioErgoConfigACActionType_A.Value == 5)
					{
						num2 = (short)1832255492;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 36:
					num2 = (short)921567233;
					if (num2 != 0)
					{
					}
					if (radioErgoConfigACActionType_A.Value == 4)
					{
						num2 = (short)589037602;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 37:
					switch (index)
					{
					case 259:
						num2 = (short)1354825773;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 260:
						num2 = (short)999358472;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 261:
						return true;
					case 262:
						goto IL_25C;
					default:
						num2 = (short)1912864794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 38:
					if (index != 160)
					{
						num2 = (short)1107427380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1941045280;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 39:
					num2 = (short)1597308966;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					return false;
				case 41:
					goto IL_46B;
				case 42:
					num2 = (short)468123699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					if (radioErgoConfigACActionType_A.Value != 3)
					{
						num2 = (short)223281183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 44:
					if (index != 75)
					{
						num2 = (short)617480231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)659947522;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					if (radioErgoConfigACActionType_A.Value != 3)
					{
						num2 = (short)1285554186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 46:
					num2 = (short)1241972757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					num2 = (short)2044198929;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					goto IL_815;
				case 49:
					if (index <= 74)
					{
						num2 = (short)637992979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1912537132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 50:
					if (radioErgoConfigACActionType_A.Value == 4)
					{
						num2 = (short)298057734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 51:
					if (radioErgoConfigACActionType_A.Value != 0)
					{
						num2 = (short)346226715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 52:
					num2 = (short)2008678437;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					num2 = (short)1994653732;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_E8;
				IL_25C:
				num2 = (short)1949040640;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_46B:
				if (radioErgoConfigACActionType_A.Value == 2)
				{
					return false;
				}
				num2 = (short)163053568;
				short num4 = num2;
				num2 = (short)1901133827;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1D8:
			return true;
			IL_641:
			return false;
			IL_6BF:
			return false;
			IL_71B:
			return true;
			IL_75D:
			return false;
			IL_815:
			return false;
			IL_E8:
			actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
			radioErgoConfigACActionType_A = actionConsolidation.General.RadioErgoConfigACActionType_A42871;
			num2 = (short)855965745;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x0088A87C File Offset: 0x00888A7C
		internal static bool ConRelayPatternIsValidWhenURCEquipped(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
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
						if (general.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num2 = (short)623181824;
							short num3 = num2;
							num2 = (short)1724448769;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)734658563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return true;
					case 2:
						goto IL_DF;
					case 3:
						if (index != 0)
						{
							num2 = (short)1873018882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E3;
					}
					goto IL_20;
				}
				return true;
				IL_DF:
				return general.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				IL_E3:
				num2 = (short)1291452417;
				if (num2 != 0)
				{
				}
				num2 = (short)1218003661;
				short num4 = num2;
				num2 = (short)1353597645;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_27;
				default:
					num2 = (short)2000617472;
					if (num2 != 0)
					{
					}
					return true;
				}
				break;
			}
			}
			IL_20:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
			IL_27:
			num2 = (short)296026112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x0088A9E0 File Offset: 0x00888BE0
		internal static bool ConACSirenTypeIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
			for (;;)
			{
				IL_0A:
				bool result;
				switch (num)
				{
				case 0:
					goto IL_1C7;
				case 1:
					return result;
				case 2:
					num2 = (short)1816592392;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (radErgoWidePASirenSirenOperation_A.Value != 2)
					{
						num2 = (short)1443233798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				case 5:
					if (radErgoWidePASirenSirenOperation_A.Value != 2)
					{
						num2 = (short)708313088;
						short num3 = num2;
						num2 = (short)1357578254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					result = false;
					num2 = (short)309657621;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					num2 = (short)1090059213;
					short num4 = num2;
					num2 = (short)1716779981;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1C7;
					default:
						goto IL_FD;
					}
					break;
				}
				case 8:
					if (index != 7)
					{
						num2 = (short)100270095;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)121307148;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (index != 5)
					{
						num2 = (short)1504247810;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)930414602;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (radErgoWidePASirenSirenOperation_A.Value == 2)
					{
						num2 = (short)962592788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_355;
				case 11:
					result = false;
					num2 = (short)1019150337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (radErgoWidePASirenSirenOperation_A.Value == 0)
					{
						num2 = (short)1822883851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 13:
					if (!general.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value)
					{
						num2 = (short)1609957376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_283;
				case 14:
					goto IL_283;
				case 15:
					num2 = (short)420544530;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (index != 0)
					{
						num2 = (short)830013459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 17:
					if (general.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
					{
						num2 = (short)176291847;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = true;
					num2 = (short)1064435728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1215889411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)2036203529;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)345243661;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					return result;
				}
				goto IL_68;
				IL_283:
				result = false;
				num2 = (short)631963652;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_355:
				num2 = (short)637009925;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C7:
				goto IL_355;
			}
			IL_FD:
			num2 = (short)1239875585;
			if (num2 != 0)
			{
			}
			num2 = (short)1669398528;
			if (num2 != 0)
			{
			}
			return true;
			IL_68:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
			radErgoWidePASirenSirenOperation_A = general.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139;
			num2 = (short)458489873;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x0088ADC8 File Offset: 0x00888FC8
		internal static bool ConErrStrategyValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)330301440;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 1:
					num = (short)724762627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return false;
				case 3:
					if (index == 0)
					{
						num = (short)253427714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_34:
				num = (short)171871788;
				short num3 = num;
				num = (short)1932365356;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)461701120;
					short num4 = num;
					num = (short)1195048961;
					if (num != 0)
					{
					}
					num = (short)583860224;
					if (num != 0)
					{
					}
					if ((self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).General.RadioErgoConfigACActionType_A42871.Value != 4)
					{
						return true;
					}
					num = (short)648282113;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return false;
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x0088AF1C File Offset: 0x0088911C
		internal static bool ConChannelValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (consolidatedActionsInnerSection.RadioErgoConfigACGeneralZone_A36592.Value != 0)
					{
						num2 = (short)837943302;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					num2 = (short)1867448323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (index == 0)
					{
						goto IL_7A;
					}
					return result;
				case 3:
					if (consolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 74)
					{
						num2 = (short)1763049477;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				case 5:
				{
					num2 = (short)836683336;
					short num3 = num2;
					num2 = (short)2029176392;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						num2 = (short)1321795584;
						if (num2 != 0)
						{
						}
						num2 = (short)384040960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					num2 = (short)144375809;
					if (num2 != 0)
					{
					}
					result = false;
					num2 = (short)1552416772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_2C;
				IL_7A:
				num2 = (short)1847590913;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			consolidatedActionsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection);
			result = true;
			num2 = (short)1334116352;
			short num4 = num2;
			num2 = (short)197722114;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x0088B0DC File Offset: 0x008892DC
		public static bool ConZoneReferencedIsNormalOrDynamicOneBased(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)2115436569;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				switch (num2)
				{
				case 0:
					goto IL_25F;
				case 1:
					goto IL_25A;
				case 2:
					zoneChannelAssignment = (acpRecRefField.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
					num = (short)1266745355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_130;
				case 4:
					goto IL_25F;
				case 5:
					num = (short)1473118229;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_25F;
				case 7:
					if (zoneChannelAssignment != null)
					{
						num = (short)1509883909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 8:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)self).CnvWideASTROOTACZone_A8645;
					num = (short)869007375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
					{
						num = (short)1504509953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 10:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)
					{
						num = (short)769196051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)805306396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_4A7;
				case 12:
					goto IL_348;
				case 13:
					num = (short)483655709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)self).RadErgoWideHomeModeZone_A9691;
					num = (short)1028849668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_25F;
				case 16:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)self).RadioErgoConfigACGeneralZone_A36592;
					num = (short)1913520134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (acpRecRefField != null)
					{
						num = (short)1296957442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A7;
				case 18:
				{
					num = (short)1254789366;
					short num3 = num;
					num = (short)1425248502;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25A;
					default:
						goto IL_3AA;
					}
					break;
				}
				case 19:
					acpRecRefField = ((global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.Signaling)self).CnvPerSignalingRevertZone_A13269;
					num = (short)2091319296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (index > acpRecRefField.RefRecset.Count)
					{
						num = (short)1464336387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)855179281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (zoneChannelAssignment.RSI != null)
					{
						num = (short)1371799565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 22:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode)
					{
						num = (short)1959264270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)227868682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)2103508993;
					if (num != 0)
					{
					}
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
					{
						num = (short)286130192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25F;
				case 24:
					if (index >= 0)
					{
						num = (short)1231814683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 25:
					switch (0)
					{
					case 0:
						goto IL_9E;
					}
					continue;
				case 26:
				{
					num = (short)1049624576;
					short num4 = num;
					num = (short)1434976265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 27:
					num = (short)620757012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.OTACInnerSection)
					{
						num = (short)544669704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2101411863;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num = (short)1356922906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32F;
				}
				IL_9E:
				if (index == 0)
				{
					num = (short)1219887122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				result = true;
				acpRecRefField = null;
				zoneChannelAssignment = null;
				num = (short)1595473942;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25F:
				num = (short)1981480984;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32F:
				result = false;
				num = (short)1148321804;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25A:
				goto IL_32F;
				IL_4A7:
				num = (short)230359047;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_130:
			return true;
			IL_348:
			return result;
			IL_3AA:
			num = (short)2096168960;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x0088B5F4 File Offset: 0x008897F4
		internal static bool ConThirdPartyNotiErrStategyApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1396520471;
			short num2 = num;
			num = (short)933312023;
			switch (num2 == num)
			{
			}
			num = (short)782958593;
			if (num != 0)
			{
			}
			num = (short)555024384;
			short num3 = num;
			num = (short)1880686592;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigAC3rdPartyNotification_A41510.Value != 0;
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x0088B6B0 File Offset: 0x008898B0
		internal static bool ConAlertAliasAudioFileIntervalApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1298792448;
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
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (consolidatedActionsInnerRecset.Count > 0)
						{
							num = (short)323813376;
							short num3 = num;
							num = (short)1429340164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 1:
						if (consolidatedActionsInnerRecset != null)
						{
							num = (short)1203568643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 2:
						try
						{
							num = (short)1288699907;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
									if (consolidatedActionsInner != null)
									{
										num = (short)774242309;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1555365894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_CF;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)853147650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner;
									num = (short)1926739869;
									short num4 = num;
									num = (short)363771805;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1341587456;
										if (num != 0)
										{
										}
										num = (short)1700331521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
									consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877.CalculateValidity();
									num = (short)2012610560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1E1;
								}
								IL_161:
								num = (short)1521745924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF:
								goto IL_161;
							}
							IL_1E1:
							goto IL_308;
						}
						finally
						{
							num = (short)1311244289;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2139291650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_218;
									}
									continue;
								case 2:
									goto IL_24E;
								}
								IL_218:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1187184640;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_24E:;
						}
						goto IL_251;
					case 3:
						num = (short)769392641;
						if (num != 0)
						{
						}
						num = (short)1924530176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_251;
					}
					goto IL_42;
					IL_251:
					enumerator = consolidatedActionsInnerRecset.GetEnumerator();
					num = (short)670433282;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_308:
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
				return consolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260;
				IL_42:
				consolidatedActionsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection);
				consolidatedActionsInnerRecset = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset);
				num = (short)451018753;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x0088B9F4 File Offset: 0x00889BF4
		internal static bool ConACActionTypeIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation).ReferencingNodes.GetEnumerator();
			short num;
			try
			{
				num = (short)1372389379;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner;
						if (perAccListTableInner != null)
						{
							num = (short)981467141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)422313990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5A;
						}
						continue;
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)739049474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner;
						num = (short)1849024346;
						short num3 = num;
						num = (short)796516186;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1993408512;
							if (num != 0)
							{
							}
							num = (short)763035649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PerAccListTableInner perAccListTableInner;
						perAccListTableInner.PerAccListTableInnerSection.RadioErgoConfigACReference_A42911.CalculateValidity();
						num = (short)1039138816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_164;
					}
					IL_E8:
					num = (short)1724645380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A:
					goto IL_E8;
				}
				IL_164:;
			}
			finally
			{
				num = (short)1447165953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)911867906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_198;
						}
						continue;
					case 2:
						goto IL_1CC;
					}
					IL_198:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1022951424;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CC:;
			}
			num = (short)1068236800;
			short num4 = num;
			num = (short)1727922177;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x0088BC3C File Offset: 0x00889E3C
		internal static bool ConCAAlertIntervalIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1356464128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_57C;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
						if (self == consolidatedActionsInnerSection)
						{
							num = (short)722403342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1258029069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_57C;
					case 3:
						goto IL_57C;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
						if (consolidatedActionsInnerRecset != null)
						{
							num = (short)533594118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						goto IL_620;
					case 6:
					{
						num = (short)1811087361;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = consolidatedActionsInnerRecset.GetEnumerator();
						num = (short)1111556107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (actionConsolidation.General.RadioErgoConfigACActionType_A42871.Value != 0)
						{
							num = (short)507838473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (self.ParentRecset == null)
						{
							num = (short)1604780044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)1586298880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset;
						num = (short)1771175940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						if (num3 >= actionConsolidationRecset.Count)
						{
							num = (short)857145359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num3][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
						num = (short)319488001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_253;
						try
						{
							bool result;
							for (;;)
							{
								IL_253:
								num = (short)1477050375;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner2;
										if (consolidatedActionsInner != consolidatedActionsInner2)
										{
											num = (short)1750073345;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										num = (short)918224907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										num = (short)1048313870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										result = false;
										num = (short)1237843980;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
										if (consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260)
										{
											num = (short)1192230915;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1931542530;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner2 = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner;
										num = (short)504561664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner2;
										if (consolidatedActionsInner2.ConsolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877.Value < 255)
										{
											num = (short)582615048;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										switch (0)
										{
										case 0:
											goto IL_2B5;
										}
										continue;
									case 8:
										num = (short)1032912905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner;
										if (consolidatedActionsInner.ConsolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877.Value < 255)
										{
											num = (short)253952013;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										num = (short)947650566;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner consolidatedActionsInner2;
										if (consolidatedActionsInner2.ConsolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260)
										{
											num = (short)1862270986;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
										goto IL_400;
									case 13:
										num = (short)1696006148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										goto IL_509;
									}
									IL_3A3:
									num = (short)561577989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2B5:
									goto IL_3A3;
								}
								IL_400:
								num = (short)784031120;
								short num4 = num;
								num = (short)952458640;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_435;
								}
							}
							IL_435:
							num = (short)383909888;
							if (num != 0)
							{
							}
							return result;
							IL_509:
							return true;
						}
						finally
						{
							num = (short)740098049;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)72482818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_541;
									}
									continue;
								case 2:
									goto IL_579;
								}
								IL_541:
								if (enumerator == null)
								{
									break;
								}
								num = (short)463863808;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_579:;
						}
						goto IL_57C;
					case 12:
					{
						num = (short)285605888;
						short num5 = num;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						int num3 = 0;
						num = (short)1135411205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_620;
					case 14:
					{
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						actionConsolidation = (actionConsolidationRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)2053963779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1255538690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_70;
					IL_57C:
					num = (short)2004942855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_620:
					num = (short)1537015818;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_70:
				actionConsolidation = null;
				num = (short)1697579016;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x0088C2CC File Offset: 0x0088A4CC
		internal static bool ConTextMsgApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2105870830;
			short num2 = num;
			num = (short)473106926;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2077360128;
				short num3 = num;
				num = (short)373555200;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value != 160)
				{
					num = (short)355467265;
					if (num != 0)
					{
					}
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x0088C390 File Offset: 0x0088A590
		internal static bool ConTxPowerChangeApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)682082474;
			short num2 = num;
			num = (short)891535530;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2025390080;
				short num3 = num;
				num = (short)1141702657;
				if (num != 0)
				{
				}
				num = (short)1409482752;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value != 42)
				{
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x0088C454 File Offset: 0x0088A654
		internal static bool ConMuteSSAApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)675661658;
			short num2 = num;
			num = (short)418957146;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)471203840;
				short num3 = num;
				num = (short)1189019649;
				if (num != 0)
				{
				}
				num = (short)399376384;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection).RadioErgoConfigACActionID_A36590.Value != 262)
				{
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0088C518 File Offset: 0x0088A718
		public static bool ConActionTypeIsGeneralOrControlOrInvalidSim(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)415039488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_370;
					case 1:
					{
						num = (short)1074987009;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num3;
						actionConsolidation = (actionConsolidationRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)1837236227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (general.RadioErgoConfigACActionType_A42871.Value != 1)
						{
							num = (short)392364051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						goto IL_370;
					case 4:
						goto IL_214;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num3;
						if (num3 >= actionConsolidationRecset.Count)
						{
							num = (short)2129657876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num3][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
						num = (short)179830793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						int num3 = 0;
						num = (short)173080591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
						num = (short)590610432;
						short num4 = num;
						num = (short)1460011012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_214;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
						if (self == consolidatedActionsInnerSection)
						{
							num = (short)2000617473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)1065025548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_C0;
					case 11:
						if (general.RadioErgoConfigACActionType_A42871.Value != 0)
						{
							num = (short)695336978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						goto IL_3F7;
					case 13:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
						{
							num = (short)1998061578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1307836433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (self.ParentRecset == null)
						{
							num = (short)1931673606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)1424359440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3F7;
					case 16:
						goto IL_370;
					case 17:
					{
						num = (short)725448925;
						short num5 = num;
						num = (short)1766619357;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C0;
						default:
							num = (short)13369344;
							if (num != 0)
							{
							}
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General)
							{
								num = (short)819789831;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_214;
						}
						break;
					}
					case 18:
						goto IL_36B;
					case 19:
						num = (short)858259467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1206845440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
					IL_C0:
					num = (short)1552154638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_214:
					num = (short)2064580610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_370:
					general = actionConsolidation.General;
					num = (short)1138950152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F7:
					num = (short)1907490821;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_36B:
				return general.RadioErgoConfigACActionType_A42871.Value == 5;
				IL_83:
				actionConsolidation = null;
				general = null;
				num = (short)1502019597;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06009107 RID: 37127 RVA: 0x0088C960 File Offset: 0x0088AB60
		public static bool ConActionTypeIsGeneral(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1506738176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BD;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				for (;;)
				{
					IL_27:
					num = (short)990361993;
					short num3 = num;
					num = (short)1597094281;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)138608640;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
							int num4;
							actionConsolidation = (actionConsolidationRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
							num = (short)626655248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (self.ParentRecset == null)
							{
								num = (short)708640775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
							num = (short)1217200136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)2133655563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_298;
						case 4:
							goto IL_15D;
						case 5:
							goto IL_2DD;
						case 6:
							general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
							num = (short)2030895118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
							int num4 = 0;
							num = (short)2096168961;
							if (num != 0)
							{
							}
							num = (short)370081796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_277;
						case 9:
						{
							num = (short)613613568;
							short num5 = num;
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
							{
								num = (short)617938957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1210712079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
							if (self == consolidatedActionsInnerSection)
							{
								num = (short)1559232512;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4;
							num4++;
							num = (short)1412890629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_277;
						case 12:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
							int num4;
							if (num4 >= actionConsolidationRecset.Count)
							{
								num = (short)1219493890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num4][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
							num = (short)235339786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							num = (short)1950023681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							goto IL_2BC;
						case 15:
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General)
							{
								num = (short)125566982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38C;
						case 16:
							goto IL_277;
						}
						goto IL_BD;
						IL_277:
						general = actionConsolidation.General;
						num = (short)1876688899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_15D:
					num = (short)848625676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DD:
					goto IL_15D;
				}
				IL_298:
				IL_2BC:
				IL_38C:
				return general.RadioErgoConfigACActionType_A42871.Value == 1;
				IL_BD:
				actionConsolidation = null;
				general = null;
				num = (short)345702409;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x0088CD08 File Offset: 0x0088AF08
		public static bool ConActionTypeIsGeneralOrExit(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1372061696;
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
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				for (;;)
				{
					IL_27:
					num = (short)1335296000;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						int num4 = 0;
						num = (short)9371661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (general.RadioErgoConfigACActionType_A42871.Value != 1)
						{
							num = (short)996802565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						goto IL_335;
					case 3:
						goto IL_26C;
					case 4:
						if (self.ParentRecset == null)
						{
							num = (short)142016512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)102170642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_23E;
					case 6:
						num = (short)1482424336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_1FB;
					case 8:
						num = (short)619446276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_29F;
					case 10:
					{
						num = (short)538363693;
						short num5 = num;
						num = (short)1578485549;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_335;
						default:
							num = (short)1845755904;
							if (num != 0)
							{
							}
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General)
							{
								num = (short)1816788994;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1FB;
						}
						break;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num4;
						actionConsolidation = (actionConsolidationRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)757596163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num4;
						if (num4 >= actionConsolidationRecset.Count)
						{
							num = (short)903086081;
							if (num != 0)
							{
							}
							num = (short)1727856646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num4][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
						num = (short)619905039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_29F;
					case 14:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
						{
							num = (short)1910898696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2142961674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
						if (self == consolidatedActionsInnerSection)
						{
							num = (short)2030632971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4;
						num4++;
						num = (short)83951625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_26C;
					case 17:
						goto IL_1FB;
					case 18:
						goto IL_26C;
					}
					goto IL_A2;
					IL_1FB:
					num = (short)2060976129;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26C:
					general = actionConsolidation.General;
					num = (short)2110128135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29F:
					num = (short)48300044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_335:
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
					num = (short)2136211473;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23E:
				return general.RadioErgoConfigACActionType_A42871.Value == 2;
				IL_A2:
				actionConsolidation = null;
				general = null;
				num = (short)905838606;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x0088D104 File Offset: 0x0088B304
		internal static bool ConActionTypeIsControl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)681632062;
			short num2 = num;
			num = (short)822272318;
			switch (num2 == num)
			{
			default:
			{
				num = (short)465174528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1682898945;
			if (num != 0)
			{
			}
			num = (short)881786880;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0;
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x0088D1C0 File Offset: 0x0088B3C0
		internal static void ConSetAlertIntervalValue(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2126577664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset consolidatedActionsInnerRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)488833028;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
									if (consolidatedActionsInnerSection.RadioErgoConfigACActionID_A36590.Value == 260)
									{
										num = (short)1522663425;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionsInnerSection.RadioErgoConfigACAlertInterval_A42877, 255));
									num = (short)1035337734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)212336645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1206386690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10614] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection;
									num = (short)129630215;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_FD;
									}
									continue;
								case 5:
									goto IL_21E;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
									if (consolidatedActionsInnerSection != null)
									{
										num = (short)1299382280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									num = (short)644349952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12D:
								num = (short)49610755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FD:
								goto IL_12D;
							}
							IL_21E:
							return;
						}
						finally
						{
							num = (short)257884160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_256;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)922877954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_28C;
								}
								IL_256:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1638727681;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_28C:;
						}
						goto IL_28F;
					case 1:
						if (general.RadioErgoConfigACActionType_A42871.Value == 2)
						{
							num = (short)10027013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (general != null)
						{
							num = (short)1447559168;
							short num3 = num;
							num = (short)782368772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						goto IL_28F;
					case 4:
						num = (short)1396506625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						consolidatedActionsInnerRecset = (self.Parent[10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset);
						num = (short)2130575366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						while (consolidatedActionsInnerRecset != null)
						{
							num = (short)265960136;
							short num4 = num;
							num = (short)1082145480;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1008074753;
								if (num != 0)
								{
								}
								num = (short)229048320;
								if (num != 0)
								{
								}
								num = (short)1373437955;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_27;
							}
						}
						return;
					}
					goto IL_4A;
					IL_28F:
					enumerator = consolidatedActionsInnerRecset.GetEnumerator();
					num = (short)1005453312;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4A:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
				num = (short)484769794;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600910B RID: 37131 RVA: 0x0088D5AC File Offset: 0x0088B7AC
		internal static bool ConActionTypeIsNotExit(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2015625216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BD;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				for (;;)
				{
					IL_29:
					num = (short)1574909613;
					short num3 = num;
					num = (short)718223021;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1299120128;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_294;
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
							int num4;
							actionConsolidation = (actionConsolidationRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
							num = (short)1468399631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_24F;
						case 3:
							goto IL_2DC;
						case 4:
							general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
							num = (short)1769668614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General)
							{
								num = (short)1977024516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38B;
						case 6:
							goto IL_2BA;
						case 7:
							goto IL_24F;
						case 8:
							num = (short)1578827787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_15F;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
							int num4 = 0;
							num = (short)366280713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							if (self.ParentRecset == null)
							{
								num = (short)1496973322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
							num = (short)874643458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							num = (short)117768192;
							short num5 = num;
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
							{
								num = (short)1641742344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2012872709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							num = (short)1561985031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
							int num4;
							if (num4 >= actionConsolidationRecset.Count)
							{
								num = (short)275447821;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num4][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
							num = (short)957022224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_24F;
						case 16:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
							if (self == consolidatedActionsInnerSection)
							{
								num = (short)1218904065;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							int num4;
							num4++;
							num = (short)1477246979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_BD;
						IL_24F:
						general = actionConsolidation.General;
						num = (short)1509228545;
						if (num != 0)
						{
						}
						num = (short)1479016448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_15F:
					num = (short)1750990862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DC:
					goto IL_15F;
				}
				IL_294:
				IL_2BA:
				IL_38B:
				return general.RadioErgoConfigACActionType_A42871.Value != 2;
				IL_BD:
				actionConsolidation = null;
				general = null;
				num = (short)1498611724;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x0088D958 File Offset: 0x0088BB58
		public static bool ConActionTypeIsGeneralOrPAOrVPOrInvalidSim(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2141454341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					if (general.RadioErgoConfigACActionType_A42871.Value == 4)
					{
						return true;
					}
					num2 = (short)863140874;
					short num3 = num2;
					num2 = (short)1161657354;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						num2 = (short)976879616;
						if (num2 != 0)
						{
						}
						num2 = (short)1649016834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_107;
				case 3:
					if (general.RadioErgoConfigACActionType_A42871.Value != 1)
					{
						num2 = (short)374341632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					num2 = (short)820379649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (general.RadioErgoConfigACActionType_A42871.Value != 3)
					{
						goto IL_157;
					}
					return true;
				}
				goto IL_28;
				IL_157:
				num2 = (short)1746534400;
				short num4 = num2;
				num2 = (short)953483268;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_107:
			num2 = (short)1992491009;
			if (num2 != 0)
			{
			}
			return general.RadioErgoConfigACActionType_A42871.Value == 5;
			IL_28:
			general = (self as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General);
			num2 = (short)1016922115;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x0088DB04 File Offset: 0x0088BD04
		public static bool ConActionTypeIsGeneralOrExitOrControlOrInvalidSim(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2076508160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation actionConsolidation;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)668008449;
						if (num != 0)
						{
						}
						if (self.ParentRecset == null)
						{
							num = (short)2118582273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						actionConsolidation = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)620756997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						int num3 = 0;
						num = (short)1934229510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)747569156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1D0;
					case 4:
						if (general.RadioErgoConfigACActionType_A42871.Value != 2)
						{
							num = (short)1872691219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						goto IL_1FE;
					case 6:
						goto IL_233;
					case 7:
						goto IL_1FE;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num3;
						if (num3 >= actionConsolidationRecset.Count)
						{
							num = (short)1398669325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection = ((actionConsolidationRecset[num3][10615].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset).TemplateNode as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInner).ConsolidatedActionsInnerSection;
						num = (short)1636761616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1887043584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						int num3;
						actionConsolidation = (actionConsolidationRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidation);
						num = (short)628555783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (general.RadioErgoConfigACActionType_A42871.Value != 1)
						{
							num = (short)2118647810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						if (general.RadioErgoConfigACActionType_A42871.Value != 0)
						{
							num = (short)246874115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						num = (short)870973457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_C1;
					case 15:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection)
						{
							num = (short)1965948937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerSection consolidatedActionsInnerSection;
						if (self == consolidatedActionsInnerSection)
						{
							num = (short)688783370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num3;
						num3++;
						num = (short)852099090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_1FE;
					case 18:
					{
						num = (short)1403850140;
						short num4 = num;
						num = (short)1963003292;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D0;
						case 1:
							break;
						default:
						{
							num = (short)344784896;
							short num5 = num;
							break;
						}
						}
						num = (short)344260608;
						if (num != 0)
						{
						}
						goto IL_233;
					}
					case 19:
						num = (short)663814156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
					IL_C1:
					num = (short)834994187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FE:
					general = actionConsolidation.General;
					num = (short)1999831054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_233:
					num = (short)1785528328;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D0:
				return general.RadioErgoConfigACActionType_A42871.Value == 5;
				IL_7F:
				actionConsolidation = null;
				general = null;
				num = (short)1407713295;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
