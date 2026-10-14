using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200034E RID: 846
	public static class ControlHeadO9Constraints
	{
		// Token: 0x06008153 RID: 33107 RVA: 0x0076AB24 File Offset: 0x00768D24
		internal static bool ConO9BottomProBtnIndexApplicability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1229455360;
			short num2 = num;
			num = (short)325976064;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
				global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
				for (;;)
				{
					IL_51:
					switch (num3)
					{
					case 0:
						directionalButtonsListInnerRecset.CalculateValidity();
						num = (short)317849608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (bottomFunctionProgrammableButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
						{
							num = (short)278462468;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						num = (short)1158086663;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (cho9BottomFunctionButtonFeature_A.Value != 206)
						{
							num = (short)1156382726;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 4:
						num = (short)2014969859;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1823866881;
						if (num != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)141361154;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						goto IL_194;
					case 7:
						if (bottomFunctionProgrammableButtonInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
						{
							num = (short)1475018752;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					case 8:
						goto IL_253;
					}
					goto IL_7C;
					IL_253:
					topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
					bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.CalculateValidityAcrossRecset();
					num = (short)754778113;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_194:
				return cho9BottomFunctionButtonFeature_A.Value == 207;
				IL_204:
				num = (short)1217609370;
				short num4 = num;
				num = (short)2107915930;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)1873739776;
					if (num != 0)
					{
					}
					return true;
				}
				return false;
				IL_7C:
				bottomFunctionProgrammableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
				cho9BottomFunctionButtonFeature_A = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664;
				topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
				directionalButtonsListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
				num = (short)839450629;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x0076ADE8 File Offset: 0x00768FE8
		internal static bool ConO9BottomProBtnFeatureValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)318898176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				bool result2;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						num = (short)312147975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)1900871682;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)369426440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 10)
									{
										num = (short)1304428554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1025;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_ED6;
									}
									continue;
								case 3:
									goto IL_1025;
								case 4:
									goto IL_1041;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 11)
									{
										num = (short)703266816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1025;
								}
								case 6:
									num = (short)1222377481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1255866374;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)75235329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)788529155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_105E;
								case 10:
									num = (short)2021588997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F86:
								num = (short)922091527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED6:
								goto IL_F86;
								IL_1025:
								result = true;
								num = (short)1477115908;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1041:
							return result;
							IL_105E:
							goto IL_C4C;
						}
						finally
						{
							num = (short)2088566784;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1096;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)408748034;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_10CE;
								}
								IL_1096:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1318387713;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10CE:;
						}
						goto IL_10D1;
						IL_C4C:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)395247640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)515768325;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1055784964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1963589638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									result = true;
									num = (short)578093059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_D7F;
								case 3:
									goto IL_CD0;
								case 4:
									num = (short)1960640514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_CB5;
									}
									continue;
								case 6:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 11)
									{
										num = (short)22478849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_D29:
								num = (short)1486880768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CB5:
								goto IL_D29;
							}
							IL_CD0:
							return result;
							IL_D7F:
							return false;
						}
						finally
						{
							num = (short)778043392;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_DB6;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2009726978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_DEF;
								}
								IL_DB6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)973275137;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DEF:;
						}
						goto IL_DF2;
					case 3:
						try
						{
							num = (short)1754136580;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_127F;
								case 1:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 11)
									{
										num = (short)1731592195;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)963969029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)936837121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									result = true;
									num = (short)1758986246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_11B5;
									}
									continue;
								case 5:
									num = (short)976617472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1262;
								}
								IL_1209:
								num = (short)123863042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11B5:
								goto IL_1209;
							}
							IL_1262:
							return result;
							IL_127F:
							goto IL_33E;
						}
						finally
						{
							num = (short)350027776;
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
									enumerator.Dispose();
									num = (short)1896218626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_12F0;
								}
								IL_12B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)882769921;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12F0:;
						}
						goto IL_12F3;
					case 4:
						num = (short)736034832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)14090254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1111883803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)1118437395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E41;
					case 7:
						goto IL_C20;
					case 8:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1619984396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1062600735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_7CA;
					case 10:
						num = (short)1321795602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_E1B;
					case 12:
						goto IL_E41;
					case 13:
						flag2 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_112C;
					case 14:
						num = (short)1852768257;
						if (num != 0)
						{
						}
						num = (short)1509949451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						try
						{
							num = (short)2028994565;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)323813378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1093664768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1721434115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_B78;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 10)
									{
										num = (short)625147910;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_B59;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_AAD;
									}
									continue;
								case 6:
									result = true;
									num = (short)740884484;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B02:
								num = (short)2062483457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AAD:
								goto IL_B02;
							}
							IL_B59:
							return result;
							IL_B78:
							return false;
						}
						finally
						{
							num = (short)33619969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_BE6;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BAF;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1763966976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_BAF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1547960322;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BE6:;
						}
						goto IL_BE9;
					case 16:
						switch (index)
						{
						case 134:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)122028033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1313341463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 136:
							goto IL_DF2;
						case 137:
						{
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1131282432;
							short num3 = num;
							num = (short)1006764062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 138:
							goto IL_12F3;
						case 139:
							return result2;
						case 140:
							goto IL_10D1;
						default:
							num = (short)1817509897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 17:
						goto IL_C02;
					case 18:
						if (index - 290 > 1)
						{
							num = (short)2090139648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3A;
					case 19:
						num = (short)801701896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_1146;
					case 21:
						goto IL_BE9;
					case 22:
						try
						{
							num = (short)657260549;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1494482948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)183500803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_465;
								case 2:
									goto IL_4C1;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
									{
										num = (short)1143472134;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)1424687106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_3F7;
									}
									continue;
								case 6:
									result = true;
									num = (short)576192513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_46A:
								num = (short)166002688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F7:
								goto IL_46A;
							}
							IL_465:
							return result;
							IL_4C1:
							return false;
						}
						finally
						{
							num = (short)114229249;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_530;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4F8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1271529472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4F8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)908918786;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_530:;
						}
						goto Block_4;
					case 23:
						try
						{
							num = (short)138018821;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1120731138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)344129536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)131923971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_9F5;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 10)
									{
										num = (short)2019360774;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_9D6;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_92D;
									}
									continue;
								case 6:
									result = true;
									num = (short)759037956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_97F:
								num = (short)1302659073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_92D:
								goto IL_97F;
							}
							IL_9D6:
							return result;
							IL_9F5:
							goto IL_13FC;
						}
						finally
						{
							num = (short)2061565953;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_A63;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A2C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1000800256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A2C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)890634242;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A63:;
						}
						return result2;
						IL_13FC:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)449970191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_533;
					case 25:
						if (index != 163)
						{
							num = (short)1888354325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)126091270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_E35;
					case 27:
						flag = false;
						goto IL_E1B;
					case 28:
						if (index != 207)
						{
							num = (short)895942666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84F;
					case 29:
						if (index <= 163)
						{
							num = (short)568786948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)681574428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						try
						{
							num = (short)1023475717;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)26345476;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)581304323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_26D;
								case 2:
									goto IL_2CA;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)1147731974;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									num = (short)1908015106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1FE;
									}
									continue;
								case 6:
									result = true;
									num = (short)590151681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_272:
								num = (short)1828978688;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FE:
								goto IL_272;
							}
							IL_26D:
							return result;
							IL_2CA:
							goto IL_8A7;
						}
						finally
						{
							num = (short)366608385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_33B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_302;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1162608640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_302:
								if (enumerator == null)
								{
									break;
								}
								num = (short)928186370;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33B:;
						}
						goto IL_33E;
						IL_8A7:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)639631382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						flag2 = true;
						goto IL_112C;
					}
					goto IL_AF;
					IL_33E:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)346947586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CA:
					num = (short)596901913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_533:
						num = (short)1782185992;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
								{
									num = (short)170786819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F4;
							}
							case 1:
								num = (short)802881541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 11)
								{
									num = (short)320471044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5D2;
							}
							case 3:
								goto IL_5D2;
							case 4:
								num = (short)1529937920;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_758;
							case 6:
								num = (short)1375338498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1836318721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
								num = (short)833617930;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								switch (0)
								{
								case 0:
									goto IL_585;
								}
								continue;
							case 9:
								goto IL_5EF;
							case 10:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 10)
								{
									num = (short)1706688518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5D2;
							}
							}
							goto IL_585;
							IL_5D2:
							result = true;
							num = (short)1623392265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5F4:
							num = (short)1492713479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_585:
							num = (short)1310746807;
							short num4 = num;
							num = (short)134047927;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_758;
							default:
								num = (short)913965056;
								if (num != 0)
								{
								}
								goto IL_5F4;
							}
						}
						IL_5EF:
						return result;
						IL_758:
						return false;
					}
					finally
					{
						num = (short)1546256385;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_7C7;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_78F;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1521221632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_78F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)96206850;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7C7:;
					}
					goto IL_7CA;
					IL_BE9:
					num = (short)783548433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF2:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)656867331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1B:
					result2 = flag;
					num = (short)327811098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E41:
					num = (short)2084765709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_112C:
					result2 = flag2;
					num = (short)908656660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12F3:
					num = (short)391249925;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_84F:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
				return bottomFunctionProgrammableButtonInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				IL_C02:
				IL_C20:
				return result2;
				IL_E35:
				return result2;
				IL_E3A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				return features.RadWideFeaturesChannelFallbackEnableValue;
				IL_10D1:
				return bottomFunctionProgrammableButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0;
				IL_1146:
				return result2;
				IL_AF:
				bottomFunctionProgrammableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = bottomFunctionProgrammableButtonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radErgoWideControlHeadMultiControlHead_A = bottomFunctionProgrammableButtonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				result2 = true;
				num = (short)2116550685;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x0076C2E0 File Offset: 0x0076A4E0
		internal static void ConValueSetDirLightingButtonsIndex(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)361496576;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
				for (;;)
				{
					IL_28:
					num = (short)93323264;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)782434304;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_144;
									}
									continue;
								case 1:
									goto IL_23D;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10621] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection).RdEgoO9DirLtbarPatternBcoListIndex_A36707, directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601.UIValue));
									num = (short)1930493955;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_220;
								case 4:
									num = (short)1423638529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1625489412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)843907078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10621] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection).RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarBCO_A36559.Value)
									{
										num = (short)604962818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_146:
								num = (short)804323333;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_144:
								goto IL_146;
							}
							IL_220:
							IL_23D:
							return;
						}
						finally
						{
							num = (short)1832976385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1063501731;
									short num4 = num;
									num = (short)2061877155;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_298;
									default:
										goto IL_2E4;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_274;
									}
									continue;
								case 2:
									enumerator.Dispose();
									goto IL_298;
								}
								IL_274:
								if (enumerator != null)
								{
									num = (short)593756162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2FB;
								IL_298:
								num = (short)1139933184;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2E4:
							num = (short)885325824;
							if (num != 0)
							{
							}
							IL_2FB:;
						}
						goto IL_2FC;
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1904738306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_2FC;
					}
					goto IL_67;
					IL_2FC:
					enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
					num = (short)488898560;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_67:
				num = (short)1609236481;
				if (num != 0)
				{
				}
				directionalButtonsListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection);
				relayPatternBCOListListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset);
				num = (short)1482031105;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008156 RID: 33110 RVA: 0x0076C62C File Offset: 0x0076A82C
		internal static bool ConResponseSelectorIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)747307009;
			if (num != 0)
			{
			}
			num = (short)1265369088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_93;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_4E:
					num = (short)1874853888;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return true;
					case 1:
						if (index != 0)
						{
							num = (short)1849688067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)224985088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)213188612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)358416386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_FA;
					}
					goto IL_93;
				}
				IL_FA:
				bool result;
				bool result2;
				try
				{
					num = (short)581238787;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						bool flag;
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1403650052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)2121465864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							flag = false;
							goto IL_250;
						case 2:
							goto IL_2F6;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_18E;
							}
							continue;
						case 4:
							num = (short)2130640898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0)
							{
								num = (short)1821245447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1303642113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_26A;
						case 7:
							num = (short)652214281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
							{
								num = (short)1431240714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							flag = (acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGeneralActionAllowed_A36579.Value;
							goto IL_250;
						}
						case 10:
							num = (short)420413445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_190:
						num = (short)773783552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_18E:
						goto IL_190;
						IL_250:
						result = flag;
						num = (short)1018953734;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_26A:
					return result;
					IL_2F6:
					return result2;
				}
				finally
				{
					num = (short)933822465;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							num = (short)1408053303;
							short num4 = num;
							num = (short)1453600823;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_351;
							default:
								goto IL_39B;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_32E;
							}
							continue;
						case 2:
							enumerator.Dispose();
							goto IL_351;
						}
						IL_32E:
						if (enumerator != null)
						{
							num = (short)309133314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B2;
						IL_351:
						num = (short)894763008;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_39B:
					num = (short)255328256;
					if (num != 0)
					{
					}
					IL_3B2:;
				}
				return result;
				IL_93:
				actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
				result2 = true;
				num = (short)886308865;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x06008157 RID: 33111 RVA: 0x0076CA0C File Offset: 0x0076AC0C
		internal static void ConSyncTrkTopButtonLabel1WithCnvTopButtonLabel1inO9(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_117;
				case 1:
					goto IL_85;
				case 2:
					if (topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine1_A36626.Value == null)
					{
						num2 = (short)811401217;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)533659651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)955056129;
					if (num2 != 0)
					{
					}
					if (topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine1_A36626.Value.Length > 6)
					{
						num2 = (short)860291072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				}
				goto IL_20;
			}
			IL_85:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(topFunctionProgrammableButtonListInnerSection.CHO9TrkTopFunctionButtonLabelLine1_A36650, topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine1_A36626.Value));
			return;
			IL_117:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(topFunctionProgrammableButtonListInnerSection.CHO9TrkTopFunctionButtonLabelLine1_A36650, topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine1_A36626.Value.Substring(0, 6)));
			return;
			IL_139:
			num2 = (short)1028463753;
			short num3 = num2;
			num2 = (short)1637162121;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20:
				num2 = (short)350945280;
				short num4 = num2;
				topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
				num2 = (short)1564409858;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)734658560;
				if (num2 != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(topFunctionProgrammableButtonListInnerSection.CHO9TrkTopFunctionButtonLabelLine1_A36650, topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine1_A36626.Value));
				return;
			}
		}

		// Token: 0x06008158 RID: 33112 RVA: 0x0076CBBC File Offset: 0x0076ADBC
		internal static void ConSyncTrkTopButtonLabel2WithCnvTopButtonLabel2inO9(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::AcpBusinessLayer.AcpField<string> cho9CnvTopFunctionButtonLabelLine2_A;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_115;
				case 1:
					goto IL_90;
				case 2:
					if (cho9CnvTopFunctionButtonLabelLine2_A.Value == null)
					{
						num2 = (short)1532821505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)564985859;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1116995585;
					if (num2 != 0)
					{
					}
					if (cho9CnvTopFunctionButtonLabelLine2_A.Value.Length > 6)
					{
						num2 = (short)536543232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_12D;
				}
				goto IL_20;
			}
			IL_90:
			global::AcpBusinessLayer.AcpField<string> cho9TrkTopFunctionButtonLabelLine2_A;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(cho9TrkTopFunctionButtonLabelLine2_A, cho9CnvTopFunctionButtonLabelLine2_A.Value));
			return;
			IL_115:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(cho9TrkTopFunctionButtonLabelLine2_A, cho9CnvTopFunctionButtonLabelLine2_A.Value.Substring(0, 6)));
			return;
			IL_12D:
			num2 = (short)1555744229;
			short num3 = num2;
			num2 = (short)1109640677;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_20:
				num2 = (short)1625423872;
				short num4 = num2;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection;
				cho9CnvTopFunctionButtonLabelLine2_A = topFunctionProgrammableButtonListInnerSection.CHO9CnvTopFunctionButtonLabelLine2_A36627;
				cho9TrkTopFunctionButtonLabelLine2_A = topFunctionProgrammableButtonListInnerSection.CHO9TrkTopFunctionButtonLabelLine2_A36651;
				num2 = (short)1268514818;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)115015680;
				if (num2 != 0)
				{
				}
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(cho9TrkTopFunctionButtonLabelLine2_A, cho9CnvTopFunctionButtonLabelLine2_A.Value));
				return;
			}
		}

		// Token: 0x06008159 RID: 33113 RVA: 0x0076CD54 File Offset: 0x0076AF54
		public static void ConValueSetIfBottomBtnFeatIsACOrLB(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1473052672;
			switch (num)
			{
			default:
			{
				num = (short)969736209;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					object obj;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection2;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
					switch (num2)
					{
					case 0:
						if (e5BottomFunctionButtonInnerSection != null)
						{
							num = (short)998309889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)463273996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset;
						if (controlHeadE5Recset == null)
						{
							num = (short)1255079961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = controlHeadE5Recset[0][10903].EmbeddedRecset;
						goto IL_A6E;
					}
					case 3:
						obj = null;
						goto IL_A9D;
					case 4:
						goto IL_456;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset recset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
						e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.SetRecset(recset);
						num = (short)971374607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(relayPatternBCOListListInnerRecset.CreateDefaultRecord()));
						int index = relayPatternBCOListListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = relayPatternBCOListListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue));
						num = (short)1377370123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						e5BottomFunctionButtonInnerSection2 = null;
						goto IL_ACC;
					case 8:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value != 207)
						{
							num = (short)2090795032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79C;
					}
					case 9:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value != 206)
						{
							num = (short)1831731227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79C;
					}
					case 10:
						try
						{
							num = (short)2138963968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_301;
									}
									continue;
								case 1:
									goto IL_3E5;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value)
									{
										num = (short)637468675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)1834614790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1970864129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)592707588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1864237058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_363;
								}
								IL_303:
								num = (short)821624837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_301:
								goto IL_303;
							}
							IL_363:
							IL_3E5:;
						}
						finally
						{
							num = (short)579928065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_453;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_419;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1562574848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_419:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1334312962;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_453:;
						}
						goto IL_456;
					case 11:
						goto IL_6F3;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value != 165)
						{
							num = (short)2023555093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758, cho9BottomFunctionButtonFeature_A.Value));
						num = (short)1116733458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						num = (short)521928705;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index2 = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue));
						num = (short)1647509508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 207)
						{
							num = (short)1225064454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
						num = (short)1777926173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_C73;
					case 16:
						goto IL_79C;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_C2;
						}
						continue;
					case 18:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 206)
						{
							num = (short)904855578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDE;
					}
					case 19:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 207)
						{
							num = (short)297992197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C73;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection;
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664;
						controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
						topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
						bottomFunctionProgrammableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
						directionalButtonsListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset = controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset;
						num = (short)876019735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						return;
					case 22:
						goto IL_BDE;
					case 23:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 206)
						{
							num = (short)348454925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)282918922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)2022899721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						num = (short)1932132352;
						short num3 = num;
						acpRecordset = null;
						goto IL_A6E;
					}
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset recset2 = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.SetRecset(recset2);
						num = (short)2072313878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.ResetToDefaultWithUndo(task);
						num = (short)679936016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						return;
					case 29:
						try
						{
							num = (short)1470889984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5A9;
									}
									continue;
								case 1:
									goto IL_684;
								case 2:
									num = (short)158531585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_667;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(relayPatternBCOListListInner2));
									num = (short)1402732547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2;
									if (relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value)
									{
										num = (short)2081554436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1437990914;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)1081868293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_604:
								num = (short)2038824966;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A9:
								goto IL_604;
							}
							IL_667:
							IL_684:;
						}
						finally
						{
							num = (short)538705921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6F0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6B8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1523777536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6B8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1925971970;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6F0:;
						}
						goto IL_6F3;
					case 30:
						try
						{
							num = (short)1831272448;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_82F;
									}
									continue;
								case 1:
									goto IL_970;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)880345091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner)enumerator.Current;
									num = (short)217579524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									num = (short)1114958693;
									short num4 = num;
									num = (short)129690469;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1725562880;
										if (num != 0)
										{
										}
										num = (short)1863122945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner;
									if (bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value == bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value)
									{
										num = (short)1296039942;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_867;
								case 6:
								{
									global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonFeature_A36826, cho9BottomFunctionButtonFeature_A.Value));
									num = (short)296943621;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_8CD:
								num = (short)361889794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_82F:
								goto IL_8CD;
							}
							IL_867:
							IL_970:;
						}
						finally
						{
							num = (short)1499987969;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9DE;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_9A5;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)541130752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9A5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)347996162;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9DE:;
						}
						num = (short)1155334146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C2:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)2094661652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_456:
					relayPatternBCOListListInnerRecset = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset);
					num = (short)309329934;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F3:
					num = (short)628555784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79C:
					topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
					directionalButtonsListInnerRecset.CalculateValidity();
					bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
					enumerator = (controlHeadO9Recset[0][10628].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset).GetEnumerator();
					num = (short)1518534686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6E:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset e5BottomFunctionButtonInnerRecset = acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset;
					if (e5BottomFunctionButtonInnerRecset == null)
					{
						num = (short)1537146883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = e5BottomFunctionButtonInnerRecset[0];
					IL_A9D:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner e5BottomFunctionButtonInner = obj as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner;
					if (e5BottomFunctionButtonInner == null)
					{
						num = (short)211746823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					e5BottomFunctionButtonInnerSection2 = e5BottomFunctionButtonInner.E5BottomFunctionButtonInnerSection;
					IL_ACC:
					e5BottomFunctionButtonInnerSection = e5BottomFunctionButtonInnerSection2;
					num = (short)1861287936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BDE:
					num = (short)1223163923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C73:
					e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.CalculateValidity();
					num = (short)1787822108;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600815A RID: 33114 RVA: 0x0076DA48 File Offset: 0x0076BC48
		public static void ConValueSetIfTopButtomFeatIsStxOrMsgOrACOrLB(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1310654464;
			switch (num)
			{
			default:
			{
				num = (short)403636256;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
					global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_C32;
					case 1:
						goto IL_A72;
					case 2:
						goto IL_3D3;
					case 3:
						try
						{
							num = (short)258408455;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_360;
								case 2:
									num = (short)1487667206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)2117599232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									if (topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 76)
									{
										num = (short)460259333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									num3 = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
									num = (short)1848639497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
									if (num3 <= directMessageListInnerRecset.Count)
									{
										num = (short)1455161354;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_1C1;
									}
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1026228227;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)140705796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									if (num3 >= 1)
									{
										num = (short)443154434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
									num = (short)1897988097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1C6:
								num = (short)558497800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C1:
								goto IL_1C6;
							}
							IL_360:
							goto IL_176B;
						}
						finally
						{
							num = (short)1098055681;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)345636866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_399;
									}
									continue;
								case 2:
									goto IL_3D0;
								}
								IL_399:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1908277248;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3D0:;
						}
						goto IL_3D3;
						IL_176B:
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)1853227030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 76)
						{
							num = (short)1263927307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 5:
						try
						{
							num = (short)1137770502;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_18B9;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2069233666;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)725024772;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1344012293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(relayPatternBCOListListInner));
									num = (short)359137280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									if (relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value)
									{
										num = (short)1543110659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1915;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1835;
									}
									continue;
								}
								IL_18BE:
								num = (short)663552001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1835:
								goto IL_18BE;
							}
							IL_18B9:
							IL_1915:
							goto IL_1698;
						}
						finally
						{
							num = (short)1121058818;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)141492225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1988;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_194E;
									}
									continue;
								}
								IL_194E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1541013504;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1988:;
						}
						goto Block_19;
					case 6:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.DefaultValue));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonStsMsgIndex_A36782, topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonStsMsgIndex_A36782.DefaultValue));
						num = (short)1101266975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 75)
						{
							num = (short)1533607942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_419;
					case 8:
						try
						{
							num = (short)1434124290;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_BBF;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)758710276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner directStatusBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInner.DirectStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, 0));
									num = (short)1930428419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B2E;
									}
									continue;
								case 4:
									num = (short)755499008;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B6E:
								num = (short)1606156289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B2E:
								goto IL_B6E;
							}
							IL_BBF:
							goto IL_70E;
						}
						finally
						{
							num = (short)863567873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1051721730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BF8;
									}
									continue;
								case 2:
									goto IL_C2F;
								}
								IL_BF8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1378484224;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C2F:;
						}
						goto IL_C32;
					case 9:
						goto IL_1698;
					case 10:
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 207)
						{
							num = (short)280756224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD8;
					case 11:
						goto IL_1BEA;
					case 12:
						try
						{
							num = (short)2135818246;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1488;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)623181826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1561722884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)805371909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)2075787264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonBCO_A36636.Value)
									{
										num = (short)1698955267;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_14E4;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1405;
									}
									continue;
								}
								IL_148D:
								num = (short)502988801;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1405:
								goto IL_148D;
							}
							IL_1488:
							IL_14E4:
							goto IL_1791;
						}
						finally
						{
							num = (short)1575354370;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)648413185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1553;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_151C;
									}
									continue;
								}
								IL_151C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1878065152;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1553:;
						}
						goto Block_15;
					case 13:
						try
						{
							num = (short)2056912903;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9FF;
								case 1:
									if (num4 <= directStatusBCOListInnerRecset.Count)
									{
										num = (short)334561289;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)866123782;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)1033633796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)559939585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
									if (topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 75)
									{
										num = (short)1439891461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
									num4 = topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
									num = (short)278069256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1246101504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_863;
									}
									continue;
								case 8:
									if (num4 >= 1)
									{
										num = (short)1014824963;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
									num = (short)1112080394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_8ED:
								num = (short)1617559554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_863:
								goto IL_8ED;
							}
							IL_9FF:
							goto IL_DE2;
						}
						finally
						{
							num = (short)606601217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1669005314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A37;
									}
									continue;
								case 2:
									goto IL_A6F;
								}
								IL_A37:
								if (enumerator == null)
								{
									break;
								}
								num = (short)93913088;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A6F:;
						}
						goto IL_A72;
						IL_DE2:
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)738852883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 206)
						{
							num = (short)1726545946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1729;
					case 15:
					{
						bool flag;
						if (!flag)
						{
							num = (short)1845035033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D3;
					}
					case 16:
					{
						global::AcpBusinessLayer.Recordset recordset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						global::AcpBusinessLayer.Recordset recordset2 = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						dekrecset.CalculateValidity();
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
						{
							directionalButtonsListInnerRecset.CalculateValidity();
						}
						recordset2.CalculateValidity();
						recordset.CalculateValidity();
						num = (short)1025507351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						try
						{
							num = (short)936574979;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E9B;
								case 1:
								{
									num = (short)1150466561;
									short num5 = num;
									num = (short)1953020417;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_EB9;
									default:
										goto IL_F4F;
									}
									break;
								}
								case 2:
								{
									bool flag = true;
									num = (short)1982267392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E4A;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)155320325;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)443416582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)723386369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_EB9;
								}
								IL_E4C:
								num = (short)1060175876;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB9:
								if (((global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current).DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonBCO_A36636.Value)
								{
									num = (short)1598488578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E4A:
								goto IL_E4C;
							}
							IL_E9B:
							goto IL_1386;
							IL_F4F:
							num = (short)268173312;
							if (num != 0)
							{
							}
							goto IL_1386;
						}
						finally
						{
							num = (short)1355022337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1912799234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F9D;
									}
									continue;
								case 2:
									goto IL_FD5;
								}
								IL_F9D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1019215872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FD5:;
						}
						goto IL_FD8;
						IL_1386:
						num = (short)873463823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue));
						num = (short)1537736725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						try
						{
							num = (short)1171259399;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11EF;
								case 1:
									if (num4 >= 1)
									{
										num = (short)1130430473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (num4 <= directStatusBCOListInnerRecset.Count)
									{
										num = (short)1300037638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)297271296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 75)
									{
										num = (short)2107506693;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									num4 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
									num = (short)978124801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
									num = (short)38666250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_1052;
									}
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1917976579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)909901828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1365508098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1057:
								num = (short)441974792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1052:
								goto IL_1057;
							}
							IL_11EF:
							goto IL_D06;
						}
						finally
						{
							num = (short)684261378;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)579272705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_125E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1226;
									}
									continue;
								}
								IL_1226:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1098252288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_125E:;
						}
						goto IL_1261;
						IL_D06:
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset = dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset;
						enumerator = directMessageListInnerRecset.GetEnumerator();
						num = (short)527761435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						num = (short)1239547918;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1791;
					case 22:
						goto IL_198B;
					case 23:
						return;
					case 24:
						try
						{
							num = (short)2127233027;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)797573121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_69B;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(directModeBCOListInner));
									topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.ResetToDefaultWithUndo(task);
									topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.ResetToDefaultWithUndo(task);
									num = (short)797048836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5A6;
									}
									continue;
								case 4:
									goto IL_5E2;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1229586432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)2134704134;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonBCO_A36636.Value)
									{
										num = (short)1985150978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_5E7:
								num = (short)1914437637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A6:
								goto IL_5E7;
							}
							IL_5E2:
							IL_69B:
							goto IL_3D3;
						}
						finally
						{
							num = (short)568852481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)331874306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6D3;
									}
									continue;
								case 2:
									goto IL_70B;
								}
								IL_6D3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)500301824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_70B:;
						}
						goto IL_70E;
					case 25:
					{
						num = (short)1371734016;
						short num6 = num;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(directModeBCOListInnerRecset.CreateDefaultRecord()));
						int index2 = directModeBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner2 = directModeBCOListInnerRecset[index2] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534, topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeZone_A8538, topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.UIValue));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535, topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.UIValue));
						num = (short)382599170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_1261;
					case 27:
						goto IL_1556;
					case 28:
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 207)
						{
							num = (short)673382420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1729;
					case 29:
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 74)
						{
							num = (short)762445825;
							if (num != 0)
							{
							}
							num = (short)1639776289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)375783448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_1729;
					case 31:
						goto IL_419;
					case 32:
						switch (0)
						{
						case 0:
							goto IL_D3;
						}
						continue;
					case 33:
					{
						bool flag = false;
						enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)1723006993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 206)
						{
							num = (short)1668153362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)433061900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_D3:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)471072769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_15:
					try
					{
						IL_1556:
						num = (short)476971012;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1575616515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1865940993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner directMessageListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)enumerator.Current;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInner.DirectMessageListInnerSection.DEKDirectMessageBCO_A8506, 0));
								num = (short)1760821248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_1623;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_1591;
								}
								continue;
							}
							IL_1593:
							num = (short)190185474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1591:
							goto IL_1593;
						}
						IL_1623:
						goto IL_148;
					}
					finally
					{
						num = (short)641728514;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)888602625;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1695;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_165B;
								}
								continue;
							}
							IL_165B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)270401536;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1695:;
					}
					goto IL_1698;
					IL_148:
					num3 = 0;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)850591747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D3:
					num = (short)959119388;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_419:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonFeature_A36637, o9CHCnvTopFunctionButtonFeature_A.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.Value));
					num = (short)1396572176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70E:
					num4 = 0;
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)1319043085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A72:
					topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
					o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
					consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
					num = (short)1192624162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C32:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(relayPatternBCOListListInnerRecset.CreateDefaultRecord()));
					int index3 = relayPatternBCOListListInnerRecset.Count - 1;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2 = relayPatternBCOListListInnerRecset[index3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661, topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue));
					num = (short)1785331721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FD8:
					enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
					num = (short)525271045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1261:
					topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.ResetToDefaultWithUndo(task);
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639, topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639.DefaultValue));
					num = (short)852492318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_19:
					try
					{
						IL_198B:
						num = (short)50724874;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (num3 >= 1)
								{
									num = (short)2121990150;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								goto IL_1B77;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)445710341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
								num = (short)870842377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, dekbuttonInner2.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
								num = (short)1145569288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								num3 = dekbuttonInner2.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
								num = (short)1615527936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)1870528513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)685834247;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
								if (num3 <= directMessageListInnerRecset.Count)
								{
									num = (short)1610940419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								if (dekbuttonInner2.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 76)
								{
									num = (short)530186244;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								switch (0)
								{
								case 0:
									goto IL_19DD;
								}
								continue;
							}
							IL_1AD1:
							num = (short)248774658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_19DD:
							goto IL_1AD1;
						}
						IL_1B77:
						goto IL_12FC;
					}
					finally
					{
						num = (short)1768030210;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)512688129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1BE7;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1BAE;
								}
								continue;
							}
							IL_1BAE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1646067712;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1BE7:;
					}
					goto IL_1BEA;
					IL_12FC:
					directModeBCOListInnerRecset = (dekrecset[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset);
					num = (short)413335581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1698:
					dekrecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
					topFunctionProgrammableButtonListInnerRecset = (controlHeadO9Recset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
					dekbuttonInnerRecset = (dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset);
					directStatusBCOListInnerRecset = (dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset);
					enumerator = directStatusBCOListInnerRecset.GetEnumerator();
					num = (short)1888878600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1729:
					num = (short)234356740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1791:
					relayPatternBCOListListInnerRecset = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset);
					num = (short)781975562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BEA:
					num = (short)1675034631;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600815B RID: 33115 RVA: 0x0076F778 File Offset: 0x0076D978
		public static void ConValueSetIfBottomBtnIndexIsChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)257163264;
			switch (num)
			{
			default:
			{
				num = (short)703725570;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection2;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset).GetEnumerator();
						num = (short)1560805385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						obj = null;
						goto IL_6C7;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 3:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 207)
						{
							num = (short)1372585984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63A;
					}
					case 4:
						e5BottomFunctionButtonInnerSection = null;
						goto IL_6F4;
					case 5:
						goto IL_79A;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value != 165)
						{
							num = (short)127205381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(e5BottomFunctionButtonInnerSection2.E5BottomFunctionButtonIndex_43759, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue));
						num = (short)561119242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_63A;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset;
						if (controlHeadE5Recset == null)
						{
							num = (short)113115149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpRecordset = controlHeadE5Recset[0][10903].EmbeddedRecset;
						goto IL_699;
					}
					case 9:
					{
						try
						{
							num = (short)1020592132;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1442381829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue));
									num = (short)1430519810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_4D4;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									if (relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value)
									{
										num = (short)1782317057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_45F;
									}
									continue;
								case 5:
									goto IL_555;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1028063232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)1462173699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_461:
								num = (short)1399455750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45F:
								goto IL_461;
							}
							IL_4D4:
							IL_555:;
						}
						finally
						{
							num = (short)1823604738;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)549847041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_610;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_58C;
									}
									continue;
								}
								IL_58C:
								num = (short)1319083881;
								short num3 = num;
								num = (short)108175209;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_612;
								default:
									num = (short)1985216512;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_612;
									}
									num = (short)690552832;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_610:
							IL_612:;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						directionalButtonsListInnerRecset.CalculateValidity();
						num = (short)574357511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return;
					case 11:
						if (e5BottomFunctionButtonInnerSection2 != null)
						{
							num = (short)1854865422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_63A;
					case 13:
						acpRecordset = null;
						goto IL_699;
					case 14:
						num = (short)946143233;
						if (num != 0)
						{
						}
						num = (short)1235484678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A;
						if (cho9BottomFunctionButtonFeature_A.Value == 206)
						{
							num = (short)340590609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1787101187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection;
						global::AcpBusinessLayer.AcpListField cho9BottomFunctionButtonFeature_A = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						global::AcpCommonLib.IAcpRecordset embeddedRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						num = (short)1125646351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)303693842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						try
						{
							num = (short)1995505668;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value)
									{
										num = (short)1556480002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1096613893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.UIValue));
									num = (short)405667846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)653197313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1563230208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_20E;
									}
									continue;
								case 5:
									goto IL_309;
								case 6:
									goto IL_24A;
								}
								IL_2B2:
								num = (short)557973507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20E:
								goto IL_2B2;
							}
							IL_24A:
							IL_309:;
						}
						finally
						{
							num = (short)251068418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)66846721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_375;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_33E;
									}
									continue;
								}
								IL_33E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1303117824;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_375:;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
						num = (short)232849420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_90:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)936574992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_63A:
					num = (short)1197080584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_699:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset e5BottomFunctionButtonInnerRecset = acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset;
					if (e5BottomFunctionButtonInnerRecset == null)
					{
						num = (short)411762689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = e5BottomFunctionButtonInnerRecset[0];
					IL_6C7:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner e5BottomFunctionButtonInner = obj as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInner;
					if (e5BottomFunctionButtonInner == null)
					{
						num = (short)1067384836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					e5BottomFunctionButtonInnerSection = e5BottomFunctionButtonInner.E5BottomFunctionButtonInnerSection;
					IL_6F4:
					e5BottomFunctionButtonInnerSection2 = e5BottomFunctionButtonInnerSection;
					num = (short)904003595;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_79A:
				num = (short)1346699264;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x0600815C RID: 33116 RVA: 0x0076FFB8 File Offset: 0x0076E1B8
		public static void ConValueSetIfTopButtomStxOrMsgIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)619053056;
			switch (num)
			{
			default:
			{
				num = (short)1562640394;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)257032193;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
					switch (num2)
					{
					case 0:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 75)
						{
							num = (short)1610612742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54D;
					}
					case 1:
						try
						{
							num = (short)291373065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									if (topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 75)
									{
										num = (short)611778565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_798;
								case 2:
									goto IL_6E2;
								case 3:
									num = (short)288817160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)829947911;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)926482432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									int num3 = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
									num = (short)1494745099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1473118209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									int num3;
									if (num3 > directStatusBCOListInnerRecset.Count)
									{
										num = (short)2028797962;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
									num = (short)1762131974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_5E7;
									}
									continue;
								case 10:
									goto IL_6CA;
								case 11:
								{
									int num3;
									if (num3 >= 1)
									{
										num = (short)1473183747;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6CA;
								}
								}
								goto IL_5E7;
								IL_6CA:
								num = (short)705363970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6E7:
								num = (short)409665540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E7:
								goto IL_6E7;
							}
							IL_6E2:
							return;
							IL_798:
							goto IL_B0E;
						}
						finally
						{
							num = (short)247857154;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)279314433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_80A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7D0;
									}
									continue;
								}
								IL_7D0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)71434240;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_80A:;
						}
						goto Block_6;
						IL_B0E:
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)1505230856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_80D;
					case 3:
					{
						try
						{
							num = (short)447414275;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_24F;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)25100290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner directStatusBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInner.DirectStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, 0));
									num = (short)1066139652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)624492544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1BF;
									}
									continue;
								}
								IL_1FE:
								num = (short)996343809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BF:
								goto IL_1FE;
							}
							IL_24F:
							goto IL_134;
						}
						finally
						{
							num = (short)723386370;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1058144257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2BF;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_286;
									}
									continue;
								}
								IL_286:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1763508224;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BF:;
						}
						goto Block_3;
						IL_134:
						int num3 = 0;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1225195521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset = dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset;
						enumerator = directMessageListInnerRecset.GetEnumerator();
						num = (short)944898060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return;
					case 6:
						goto IL_E60;
					case 7:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 76)
						{
							num = (short)951189508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD3;
					}
					case 8:
						try
						{
							num = (short)1625817089;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1320878091;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)1463025668;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C34;
									}
									continue;
								case 2:
									goto IL_DED;
								case 3:
								{
									int num3;
									if (num3 >= 1)
									{
										num = (short)956301320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_C8E;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 75)
									{
										num = (short)726794249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_CA6;
								case 7:
									goto IL_C8E;
								case 8:
									num = (short)323551242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									int num3 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
									num = (short)221052931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									int num3;
									if (num3 > directStatusBCOListInnerRecset.Count)
									{
										num = (short)1674313735;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
									num = (short)1706688518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)91947010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_C34;
								IL_C8E:
								num = (short)1930821637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_CF8:
								num = (short)468516864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C34:
								goto IL_CF8;
							}
							IL_CA6:
							return;
							IL_DED:
							goto IL_AD3;
						}
						finally
						{
							num = (short)1916993536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E24;
									}
									continue;
								case 1:
									goto IL_E5D;
								case 2:
									enumerator.Dispose();
									num = (short)480182273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E24:
								if (enumerator == null)
								{
									break;
								}
								num = (short)641794050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E5D:;
						}
						goto IL_E60;
					case 9:
					{
						topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						global::AcpBusinessLayer.Recordset recordset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
						dekrecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = recordset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						dekbuttonInnerRecset = (dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset);
						num = (short)1145962496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 11:
						goto IL_2C2;
					case 12:
					{
						try
						{
							num = (short)134086658;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1049821187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1371275264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner directMessageListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInner.DirectMessageListInnerSection.DEKDirectMessageBCO_A8506, 0));
									num = (short)1910046724;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F07;
									}
									continue;
								case 3:
									goto IL_F9B;
								}
								IL_F09:
								num = (short)1115553793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F07:
								goto IL_F09;
							}
							IL_F9B:
							goto IL_C9;
						}
						finally
						{
							num = (short)1489895424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FD3;
									}
									continue;
								case 1:
									goto IL_100B;
								case 2:
									enumerator.Dispose();
									num = (short)2062745601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FD3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1204224002;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_100B:;
						}
						return;
						IL_C9:
						int num4 = 0;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)822214667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A2:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)2049966089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_3:
					try
					{
						IL_2C2:
						num = (short)428081161;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)860815361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_4D8;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								if (topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 76)
								{
									num = (short)912588804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
								int num4;
								if (num4 > directMessageListInnerRecset.Count)
								{
									num = (short)369819654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
								num = (short)479330312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								int num4 = topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
								num = (short)1764163594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_4BA;
							case 6:
								goto IL_4A2;
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1166737408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
								num = (short)34144258;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_31A;
								}
								continue;
							case 10:
							{
								int num4;
								if (num4 >= 1)
								{
									num = (short)1347223563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4A2;
							}
							case 11:
								num = (short)290455555;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_460:
							num = (short)1160708103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_31A:
							goto IL_460;
							IL_4A2:
							num = (short)1947074565;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4BA:
						break;
						IL_4D8:
						goto IL_15D;
					}
					finally
					{
						num = (short)1276575746;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1050017793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_54A;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_510;
								}
								continue;
							}
							IL_510:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1347682304;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_54A:;
					}
					goto IL_54D;
					IL_15D:
					enumerator = dekbuttonInnerRecset.GetEnumerator();
					num = (short)1151598594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54D:
					num = (short)603389959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD3:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonStsMsgIndex_A36782, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value));
					num = (short)96534533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_80D:
						num = (short)794951689;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_A61;
							case 2:
								num = (short)1452212228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)1872429057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
								int num4;
								if (num4 > directMessageListInnerRecset.Count)
								{
									num = (short)32899079;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, dekbuttonInner2.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
								goto IL_A0C;
							}
							case 5:
								goto IL_A44;
							case 6:
							{
								int num4;
								if (num4 >= 1)
								{
									num = (short)1134886914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A2A;
							}
							case 7:
							{
								num = (short)966635836;
								short num5 = num;
								num = (short)1907536188;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_A0C;
								default:
									num = (short)1224933376;
									if (num != 0)
									{
									}
									goto IL_A2A;
								}
								break;
							}
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								if (dekbuttonInner2.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 76)
								{
									num = (short)315359242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_863;
								}
								continue;
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								int num4 = dekbuttonInner2.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
								num = (short)1564672006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)810287107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
								num = (short)1278935048;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_8BB:
							num = (short)826736651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_863:
							goto IL_8BB;
							IL_A0C:
							num = (short)1879441408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A2A:
							num = (short)417202181;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A44:
						break;
						IL_A61:;
					}
					finally
					{
						num = (short)1456734208;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A97;
								}
								continue;
							case 1:
								goto IL_AD0;
							case 2:
								enumerator.Dispose();
								num = (short)2115960833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A97:
							if (enumerator == null)
							{
								break;
							}
							num = (short)171442178;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_AD0:;
					}
					goto IL_AD3;
					IL_E60:
					num = (short)1860304896;
					short num6 = num;
					directStatusBCOListInnerRecset = (dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset);
					enumerator = directStatusBCOListInnerRecset.GetEnumerator();
					num = (short)395575299;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x0600815D RID: 33117 RVA: 0x00771068 File Offset: 0x0076F268
		public static void ConValueSetIfTopButtomACOrLBIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)864813056;
			switch (num)
			{
			default:
			{
				num = (short)216793091;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1157890048;
					short num3 = num;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					switch (num2)
					{
					case 0:
						goto IL_658;
					case 1:
						goto IL_451;
					case 2:
						goto IL_374;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_99;
						}
						continue;
					case 4:
					{
						try
						{
							num = (short)1461649408;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_14F;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue));
									num = (short)273285124;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_24E;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									if (relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value)
									{
										num = (short)130875393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_18D;
								case 5:
									num = (short)2112225282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)137166853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)418119683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1F5:
								num = (short)65994758;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14F:
								goto IL_1F5;
							}
							IL_18D:
							IL_24E:
							goto IL_34A;
						}
						finally
						{
							num = (short)412811265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2BF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_286;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)243924992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_286:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2083323906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2BF:;
						}
						goto IL_2C2;
						IL_34A:
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
						bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						directionalButtonsListInnerRecset.CalculateValidity();
						num = (short)296812545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)426508295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_487;
					case 7:
					{
						try
						{
							num = (short)20447234;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.UIValue));
									num = (short)432472070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)586285060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4F2;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2071986177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1665925125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_5E7;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value)
									{
										num = (short)1725628416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_58B;
								}
								IL_590:
								num = (short)208273411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F2:
								goto IL_590;
							}
							IL_58B:
							IL_5E7:
							goto IL_48C;
						}
						finally
						{
							num = (short)1395851265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_655;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_61E;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)2490368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_61E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)191234050;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_655:;
						}
						goto IL_658;
						IL_48C:
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
						bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
						num = (short)2000879625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 207)
						{
							num = (short)327352320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					}
					case 9:
						goto IL_451;
					case 10:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 206)
						{
							num = (short)1201274885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C2;
					}
					}
					IL_99:
					num = (short)1662170078;
					short num4 = num;
					num = (short)1419686878;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
					{
						IL_374:
						topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
						global::AcpCommonLib.IAcpRecordset embeddedRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						num = (short)850133002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					default:
						num = (short)582877184;
						if (num != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)816381954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_697;
					}
					IL_2C2:
					num = (short)1988493320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_451:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(topFunctionProgrammableButtonListInnerSection.O9CHTrkTopFunctionButtonIndex_A36639, topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.Value));
					num = (short)621740038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_658:
					enumerator = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset).GetEnumerator();
					num = (short)1816854532;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_487:
				IL_697:
				num = (short)512819201;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600815E RID: 33118 RVA: 0x00771768 File Offset: 0x0076F968
		internal static bool ConTopFunctionButtonIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1761148930;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
				switch (num2)
				{
				case 0:
					goto IL_161;
				case 1:
				{
					num = (short)464442942;
					short num3 = num;
					num = (short)1632228926;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_161;
					default:
						goto IL_1AE;
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					num = (short)2140274693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1192165382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (o9CHCnvTopFunctionButtonFeature_A.Value == 206)
					{
						num = (short)1299120128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					if (o9CHCnvTopFunctionButtonFeature_A.Value != 207)
					{
						num = (short)2041708547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				}
				goto IL_41;
				IL_161:
				num = (short)1856897025;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_41:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection;
				o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
				topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.CalculateValidityAcrossRecset();
				bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
				if (topFunctionProgrammableButtonListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
				{
					directionalButtonsListInnerRecset.CalculateValidity();
				}
				if (topFunctionProgrammableButtonListInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
				{
					return false;
				}
				num = (short)1534853124;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1AE:
			num = (short)1754595328;
			if (num != 0)
			{
			}
			num = (short)1273757696;
			short num4 = num;
			num = (short)804454401;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600815F RID: 33119 RVA: 0x007719BC File Offset: 0x0076FBBC
		[global::ConstraintHelper.TriggerValidOnLoading]
		internal static bool ConCHO9ButtonFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)748486656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				bool result2;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)439418889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)2001207301;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E7C;
								case 1:
									result = true;
									num = (short)586022912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 10)
									{
										num = (short)993132545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_ED8;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1342111750;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1554186242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E0D;
									}
									continue;
								case 6:
									num = (short)1706033155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E81:
								num = (short)758382596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E0D:
								goto IL_E81;
							}
							IL_E7C:
							return result;
							IL_ED8:
							return false;
						}
						finally
						{
							num = (short)447676417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1116930050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F10;
									}
									continue;
								case 2:
									goto IL_F49;
								}
								IL_F10:
								if (enumerator == null)
								{
									break;
								}
								num = (short)245432320;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F49:;
						}
						goto IL_F4C;
					case 2:
						goto IL_7A1;
					case 3:
						if (radErgoWidePASirenSirenOperation_A.Value == 2)
						{
							num = (short)2124480520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)197918746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_626;
					case 5:
						num = (short)643235853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)590413825;
						if (num != 0)
						{
						}
						num = (short)1330839576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_FDA;
					case 8:
						num = (short)404488217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						switch (index)
						{
						case 134:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1300037665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							goto IL_BDD;
						case 136:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1901920260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 137:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1231814685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)58458124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 10:
						goto IL_12E2;
					case 11:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)409600032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 12:
						num = (short)228130852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (index)
						{
						case 89:
						case 91:
						case 92:
						case 94:
							goto IL_CD8;
						case 90:
						case 95:
							goto IL_FB7;
						case 93:
						case 96:
							goto IL_C9A;
						default:
							num = (short)1516765184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						goto IL_37B;
					case 15:
						goto IL_951;
					case 16:
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.UIValue != topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.InvalidText)
						{
							num = (short)1869742115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 17:
						if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
						{
							num = (short)1955332130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 18:
						try
						{
							num = (short)1509163013;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 10)
									{
										num = (short)745472004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									num = (short)493617155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)1394409473;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2050162688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_8DD;
								case 4:
									result = true;
									num = (short)820772870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_817;
									}
									continue;
								case 6:
									goto IL_8C0;
								}
								IL_819:
								num = (short)1236926466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_817:
								goto IL_819;
							}
							IL_8C0:
							return result;
							IL_8DD:
							goto IL_DA7;
						}
						finally
						{
							num = (short)337313793;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)806813698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_914;
									}
									continue;
								case 2:
									goto IL_94E;
								}
								IL_914:
								if (enumerator == null)
								{
									break;
								}
								num = (short)417202176;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_94E:;
						}
						goto IL_951;
						IL_DA7:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)991428609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943 != null)
						{
							num = (short)1849884687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 20:
						try
						{
							num = (short)235601925;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1843265539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)355860480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)505544708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_ABF;
								case 3:
									goto IL_B6B;
								case 4:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
									{
										num = (short)2070020102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_AA5;
									}
									continue;
								case 6:
									result = true;
									num = (short)1549926402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_AC4:
								num = (short)1801519105;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AA5:
								goto IL_AC4;
							}
							IL_ABF:
							return result;
							IL_B6B:
							return false;
						}
						finally
						{
							num = (short)974192641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1539899394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BA3;
									}
									continue;
								case 2:
									goto IL_BDA;
								}
								IL_BA3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)759234560;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BDA:;
						}
						goto IL_BDD;
					case 21:
						if (index <= 137)
						{
							num = (short)1685127173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EF;
					case 22:
						try
						{
							num = (short)1514536966;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5B4;
								case 1:
									goto IL_525;
								case 2:
									goto IL_541;
								case 3:
									num = (short)597688324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
									{
										num = (short)176029697;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1920860168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1740177417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_437;
									}
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 11)
									{
										num = (short)1252065283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_525;
								}
								case 8:
									num = (short)938409984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 10)
									{
										num = (short)957349898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_525;
								}
								case 10:
									num = (short)929169415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4EA:
								num = (short)18087941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_437:
								goto IL_4EA;
								IL_525:
								result = true;
								num = (short)2094465026;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_541:
							return result;
							IL_5B4:
							return false;
						}
						finally
						{
							num = (short)455999489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1055981570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5EB;
									}
									continue;
								case 2:
									goto IL_623;
								}
								IL_5EB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1380646912;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_623:;
						}
						goto Block_6;
					case 23:
						if (index != 207)
						{
							num = (short)937164806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7BF;
					case 24:
						switch (index)
						{
						case 222:
						case 223:
						case 225:
							goto IL_CD8;
						case 224:
							goto IL_C9A;
						case 226:
							goto IL_FB7;
						default:
							num = (short)1413545986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 25:
						flag = !topFunctionProgrammableButtonListInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
						goto IL_C02;
					case 26:
						flag = false;
						goto IL_C02;
					case 27:
						num = (short)1068826640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_7BA;
					case 29:
						try
						{
							num = (short)200933378;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)673775617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_260;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B7;
									}
									continue;
								case 3:
									num = (short)1087504388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_27D;
								case 5:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)1401356288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1890779139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1072431109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20A:
								num = (short)1808990214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B7:
								goto IL_20A;
							}
							IL_260:
							return result;
							IL_27D:
							goto IL_14B2;
						}
						finally
						{
							num = (short)1084162049;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2EC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B5;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1204158464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)414515202;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EC:;
						}
						goto IL_2EF;
						IL_14B2:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1017446420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_CFB;
					case 31:
						if (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.ReferencedNode == null)
						{
							num = (short)1881014299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 32:
						goto IL_127F;
					case 33:
						try
						{
							num = (short)1545469961;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1349386250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)910032903;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)390594565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_11EE;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 11)
									{
										num = (short)25559041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11D3;
								}
								case 4:
									goto IL_11D3;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)1752563716;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1509031939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 10)
									{
										num = (short)102367238;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11D3;
								}
								case 8:
									goto IL_120B;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_108F;
									}
									continue;
								case 10:
									num = (short)1517027336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1195:
								num = (short)1619984384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_108F:
								goto IL_1195;
								IL_11D3:
								result = true;
								num = (short)6750210;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11EE:
							return result;
							IL_120B:
							goto IL_A3C;
						}
						finally
						{
							num = (short)1762656257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)664535042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1244;
									}
									continue;
								case 2:
									goto IL_127C;
								}
								IL_1244:
								if (enumerator == null)
								{
									break;
								}
								num = (short)314900480;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_127C:;
						}
						goto IL_127F;
						IL_A3C:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)643170326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_F4C;
					case 35:
						num = (short)769196043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_9B1;
					case 37:
						goto IL_C1D;
					}
					goto IL_C6;
					IL_2EF:
					num = (short)572915735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					result2 = true;
					num = (short)2022965269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A1:
					num = (short)1098252316;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_626:
						num = (short)2009399301;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								result = true;
								num = (short)772669442;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 11)
								{
									num = (short)142802944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
								goto IL_683;
							case 3:
								goto IL_72E;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1700921350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1979056129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_668;
								}
								continue;
							case 6:
								num = (short)801243139;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_6DB:
							num = (short)1268711428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_668:
							goto IL_6DB;
						}
						IL_683:
						return result;
						IL_72E:
						goto IL_12C1;
					}
					finally
					{
						num = (short)278724609;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1263927298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_765;
								}
								continue;
							case 2:
								goto IL_79E;
							}
							IL_765:
							if (enumerator == null)
							{
								break;
							}
							num = (short)328531968;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_79E:;
					}
					goto IL_7A1;
					IL_12C1:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)1939013642;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_951:
					num = (short)234487839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BDD:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)1120927762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C02:
					result2 = flag;
					num = (short)1797259301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9A:
					num = (short)1079312387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD8:
					result2 = (radErgoWidePASirenSirenOperation_A.Value == 2);
					num = (short)397606942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4C:
					topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943.ResetToDefaultWithUndo();
					num = (short)1908408334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB7:
					result2 = (radErgoWidePASirenSirenOperation_A.Value != 0);
					num = (short)1771831303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_127F:
					num = (short)358350865;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7BA:
				return result2;
				IL_7BF:
				return topFunctionProgrammableButtonListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				IL_9B1:
				IL_C1D:
				return result2;
				IL_CFB:
				num = (short)843448320;
				short num3 = num;
				return result2;
				IL_FDA:
				return result2;
				IL_12E2:
				try
				{
					num = (short)115933189;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							result = true;
							num = (short)1239416834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_135E;
						case 2:
							goto IL_1342;
						case 3:
							goto IL_143C;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)935198726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)304218113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_1328;
							}
							continue;
						case 6:
						{
							num = (short)78852750;
							short num4 = num;
							num = (short)587084430;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_135E;
							default:
								num = (short)404422656;
								if (num != 0)
								{
								}
								num = (short)1405550595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_1328;
						IL_135E:
						if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 11)
						{
							num = (short)1989083136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_139C:
						num = (short)589234180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1328:
						goto IL_139C;
					}
					IL_1342:
					return result;
					IL_143C:
					return false;
				}
				finally
				{
					num = (short)444923905;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_14AC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1473;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1357119488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1473:
						if (enumerator == null)
						{
							break;
						}
						num = (short)201457666;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_14AC:;
				}
				return result2;
				IL_C6:
				topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
				radErgoWidePASirenSirenOperation_A = topFunctionProgrammableButtonListInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139;
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				num = (short)1415512083;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008160 RID: 33120 RVA: 0x00772F6C File Offset: 0x0077116C
		internal static bool ConTopFunctionButtonStsMsgIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (o9CHCnvTopFunctionButtonFeature_A.Value != 76)
					{
						num2 = (short)207093762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (topFunctionProgrammableButtonListInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)1335754755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)630219539;
					short num3 = num2;
					num2 = (short)1410949907;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1094582273;
						if (num2 != 0)
						{
						}
						num2 = (short)2115371008;
						if (num2 != 0)
						{
						}
						break;
					}
					num2 = (short)1988820996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1651638272;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (o9CHCnvTopFunctionButtonFeature_A.Value == 75)
					{
						num2 = (short)1809055749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					goto IL_123;
				}
				goto IL_28;
			}
			return true;
			IL_123:
			return true;
			IL_28:
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
			global::AcpBusinessLayer.Recordset recordset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
			topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.CalculateValidityAcrossRecset();
			recordset.CalculateValidity();
			num2 = (short)1373437952;
			short num4 = num2;
			num2 = (short)717357057;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008161 RID: 33121 RVA: 0x00773154 File Offset: 0x00771354
		internal static bool ConTopFunStsOrMsgIndexPairUniqueConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)121503744;
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
				int num4;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
				global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1267597322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									int num3;
									if (num3 > 1)
									{
										num = (short)1817509890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value == num4)
									{
										num = (short)273219587;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)569311237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									int num3;
									num3++;
									num = (short)2129461248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1183186950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1113456648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_46F;
								case 6:
									num = (short)1303773193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1395589121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value == 75)
									{
										num = (short)707919879;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_48D;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_325;
									}
									continue;
								}
								IL_327:
								num = (short)988217348;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_325:
								goto IL_327;
							}
							IL_46F:
							IL_48D:
							goto IL_22F;
						}
						finally
						{
							num = (short)1284243458;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1301013484;
									short num5 = num;
									num = (short)416211948;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)387448832;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										break;
									}
									num = (short)2031617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_54B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4C4;
									}
									continue;
								}
								IL_4C4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1381236736;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_54B:;
						}
						goto Block_8;
						IL_22F:
						num = (short)1471873039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return false;
					case 2:
					{
						int num6;
						if (num6 > 1)
						{
							num = (short)682164229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
					{
						int num6;
						if (num6 > 1)
						{
							num = (short)754909196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BFF;
					}
					case 4:
						goto IL_9D6;
					case 5:
						return false;
					case 6:
					{
						int num3;
						if (num3 > 1)
						{
							num = (short)1902968833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1712193536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_54E;
					case 8:
						try
						{
							num = (short)388956170;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_902;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonFeature_A21353.Value == 76)
									{
										num = (short)1213595651;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									int num6;
									if (num6 > 1)
									{
										num = (short)1502478341;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)615383048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1666318342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1202061313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)718602240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1598619657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									int num6;
									num6++;
									num = (short)1711472642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonIndex_A22570.Value == num4)
									{
										num = (short)290258951;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_962;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_7FC;
									}
									continue;
								}
								IL_7FE:
								num = (short)1292107780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7FC:
								goto IL_7FE;
							}
							IL_902:
							IL_962:
							goto IL_14C;
						}
						finally
						{
							num = (short)1297481730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1842151425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_9D3;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_99B;
									}
									continue;
								}
								IL_99B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)954269696;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9D3:;
						}
						goto Block_10;
						IL_14C:
						num = (short)795344899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_268;
					case 10:
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 75)
						{
							num = (short)808910859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1169752077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int num3 = 0;
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)1099104260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						return false;
					case 13:
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 76)
						{
							num = (short)995491854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
					{
						int num6 = 0;
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)834666504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						int num3;
						if (num3 > 1)
						{
							num = (short)1442775049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					}
					goto IL_6F;
					Block_8:
					try
					{
						IL_54E:
						num = (short)642908170;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2047606786;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
								num = (short)1092026372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								int num6;
								if (num6 > 1)
								{
									num = (short)683868163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								num = (short)390266889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)611778565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value == 76)
								{
									num = (short)2024734726;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_715;
							case 6:
								num = (short)1525940232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								int num6;
								num6++;
								num = (short)191234049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value == num4)
								{
									num = (short)415760391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_732;
							case 10:
								num = (short)1856438273;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_5C7;
								}
								continue;
							}
							IL_6BC:
							num = (short)831258624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5C7:
							goto IL_6BC;
						}
						IL_715:
						IL_732:
						goto IL_1F3;
					}
					finally
					{
						num = (short)1592786946;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)447348737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_7A3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_76A;
								}
								continue;
							}
							IL_76A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)824180736;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7A3:;
					}
					return false;
					IL_1F3:
					num = (short)849674242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_10:
					try
					{
						IL_9D6:
						num = (short)1057423370;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								int num3;
								if (num3 > 1)
								{
									num = (short)293535746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)416808963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
								num = (short)1143734276;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)1743192069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								num = (short)491388937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								if ((acpFeatureNode4[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonFeature_A21353.Value == 75)
								{
									num = (short)882966534;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_B6D;
							case 6:
								num = (short)588644360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								int num3;
								num3++;
								num = (short)892272640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
								if ((acpFeatureNode4[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonIndex_A22570.Value == num4)
								{
									num = (short)462946311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_B8C;
							case 10:
								switch (0)
								{
								case 0:
									goto IL_A29;
								}
								continue;
							}
							IL_A83:
							num = (short)5636097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A29:
							goto IL_A83;
						}
						IL_B6D:
						IL_B8C:
						goto IL_295;
					}
					finally
					{
						num = (short)44367874;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)423559169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_BFC;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BC4;
								}
								continue;
							}
							IL_BC4:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1026228224;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BFC:;
					}
					goto IL_BFF;
					IL_295:
					num = (short)1281097734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BFF:
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)122486784;
					short num7 = num;
					num = (short)1664811015;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_268:
				return false;
				IL_6F:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection;
				o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
				dekbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset);
				topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
				num4 = 0;
				num4 = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
				num = (short)1059586058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x00773E14 File Offset: 0x00772014
		public static void ConTopFunctionButtonModeZoneSelect(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)898760704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)1110441984;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)1306394625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1519255558;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1740044904;
								short num4 = num;
								num = (short)895023720;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)947519488;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
										global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A;
										if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == cnvTopFunctionButtonBCO_A.Value)
										{
											num = (short)135069697;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
										global::AcpBusinessLayer.AcpListField topFunctionBtnCnvZone_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeZone_A8538, topFunctionBtnCnvZone_A.UIValue));
										num = (short)428474371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1963261956;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
										num = (short)1405091840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_2AF;
									case 4:
										goto IL_315;
									case 5:
										goto IL_32E;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_23A;
										}
										continue;
									}
									IL_23C:
									num = (short)69533698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_23A:
									goto IL_23C;
								}
								IL_315:
								num = (short)2037317637;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2AF:
							IL_32E:
							goto IL_EC;
						}
						finally
						{
							num = (short)417857538;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1025966081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_39F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_365;
									}
									continue;
								}
								IL_365:
								if (enumerator == null)
								{
									break;
								}
								num = (short)43122688;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39F:;
						}
						return;
					case 2:
					{
						global::AcpBusinessLayer.AcpListField topFunctionBtnCnvZone_A;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944, topFunctionBtnCnvZone_A.UIValue));
						num = (short)1874264068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944.HiddenStatic)
						{
							num = (short)1758330881;
							if (num != 0)
							{
							}
							num = (short)611319810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						return;
					case 5:
					{
						global::AcpBusinessLayer.AcpField<int> o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						global::AcpBusinessLayer.AcpListField topFunctionBtnCnvZone_A = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942;
						global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A = topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 74)
						{
							num = (short)204210176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC;
					}
					}
					goto IL_46;
					IL_EC:
					num = (short)1264648195;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_46:
				topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
				num = (short)940638213;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x007741E0 File Offset: 0x007723E0
		public static void ConTopFunctionButtonModeChannelSelect(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)223870976;
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
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
				for (;;)
				{
					IL_28:
					num = (short)1998913536;
					short num3 = num;
					global::AcpBusinessLayer.AcpListField topFunctionBtnCnvChannel_A;
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)1666739942;
						short num4 = num;
						num = (short)850423526;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_155;
						default:
						{
							num = (short)898564096;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directModeBCOListInnerRecset.GetEnumerator();
							num = (short)915800067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						global::AcpBusinessLayer.AcpField<int> o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						topFunctionBtnCnvChannel_A = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943;
						global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A = topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 74)
						{
							num = (short)1950810113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF;
					}
					case 3:
						try
						{
							num = (short)12779523;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535, topFunctionBtnCnvChannel_A.UIValue));
									num = (short)705036292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_32A;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)883490822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)286982149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_23D;
									}
									continue;
								case 4:
									goto IL_2AE;
								case 5:
								{
									global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == cnvTopFunctionButtonBCO_A.Value)
									{
										num = (short)1813905408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1168769025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_23F:
								num = (short)2116026370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23D:
								goto IL_23F;
							}
							IL_2AE:
							IL_32A:
							goto IL_EF;
						}
						finally
						{
							num = (short)317652992;
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
										goto IL_361;
									}
									continue;
								case 1:
									goto IL_398;
								case 2:
									enumerator.Dispose();
									num = (short)1509425153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_361:
								if (enumerator == null)
								{
									break;
								}
								num = (short)691404802;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_398:;
						}
						return;
					case 4:
						goto IL_155;
					case 5:
						num = (short)616431617;
						if (num != 0)
						{
						}
						if (!topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkChannel_A36945.HiddenStatic)
						{
							num = (short)476053508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_70;
					IL_EF:
					num = (short)2130706437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkChannel_A36945, topFunctionBtnCnvChannel_A.UIValue));
					num = (short)1414135808;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_70:
				topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
				num = (short)1478754306;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x007745A4 File Offset: 0x007727A4
		public static bool ConTopFunctionBtnCnvChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (zoneChannelAssignment != null)
					{
						num2 = (short)1554186244;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17A;
				case 1:
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)2002452483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17A;
				case 2:
					return true;
				case 3:
					return false;
				case 4:
					num2 = (short)1910308865;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)1861615622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
				{
					num2 = (short)267647051;
					short num3 = num2;
					num2 = (short)366409803;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)157810688;
						if (num2 != 0)
						{
						}
						num2 = (short)1477181441;
						if (num2 != 0)
						{
						}
						num2 = (short)611123207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					if (topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 74)
					{
						num2 = (short)1852702722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_30;
				IL_17A:
				num2 = (short)1482424325;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_30:
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			zoneChannelAssignment = (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)1877082112;
			short num4 = num2;
			num2 = (short)830341120;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x007747BC File Offset: 0x007729BC
		internal static bool ConTopFunctionButtonCnvZoneApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_0A:
				num = (short)1615659008;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (topFunctionProgrammableButtonListInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num = (short)781189123;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
				case 1:
					return true;
				case 2:
					if (topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 74)
					{
						num = (short)708182017;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
				case 3:
					num = (short)1826226177;
					if (num != 0)
					{
					}
					num = (short)374538242;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_49;
				IL_102:
				num = (short)536564988;
				short num4 = num;
				num = (short)1321096444;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_136;
				}
			}
			return true;
			IL_136:
			num = (short)1648492544;
			if (num != 0)
			{
			}
			return false;
			IL_49:
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			num = (short)1321664512;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00774918 File Offset: 0x00772B18
		internal static bool ConACorRelayPatternUniqueinTopandBottomandDirLightTBL(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)855244800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
					switch (num2)
					{
					case 0:
					{
						if (index == 0)
						{
							num = (short)571080717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)8323073;
						if (num != 0)
						{
						}
						int num3 = 0;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)236716062;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (num4 == -1)
						{
							num = (short)1943076876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE6;
					case 2:
						goto IL_C28;
					case 3:
						try
						{
							num = (short)258342915;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value != 0)
									{
										num = (short)981729286;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_F1E;
								case 2:
									num = (short)1060438017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E05;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
									{
										num = (short)1671495687;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_E20;
								case 6:
									result = false;
									num = (short)1567358981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)463863808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1636106242;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)454819844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E75:
								num = (short)1860108296;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E05:
								goto IL_E75;
							}
							IL_E20:
							return result;
							IL_F1E:
							goto IL_193;
						}
						finally
						{
							num = (short)425328641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F8F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F56;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)112001024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F56:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1982857218;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F8F:;
						}
						goto IL_F92;
					case 4:
						goto IL_C28;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection;
						num = (short)61800476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						bottomFunctionProgrammableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
						num = (short)403243040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value != 206)
						{
							num = (short)1736572951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 8:
						topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
						num = (short)1809317895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_51F;
					case 10:
						enumerator = directionalButtonsListInnerRecset.GetEnumerator();
						num = (short)1658388502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)814678034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						bool result2;
						return result2;
					}
					case 13:
						return false;
					case 14:
						if (num4 == 206)
						{
							num = (short)320012309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 15:
						goto IL_27A;
					case 16:
						try
						{
							num = (short)858980356;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B27;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection).CHO9BottomFunctionButtonFeature_A36664.Value == num4)
									{
										num = (short)2010447881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									result = false;
									num = (short)1230110727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (self.Parent != acpFeatureNode2)
									{
										num = (short)192151557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_97B;
									}
									continue;
								case 5:
									num = (short)260833281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)86769676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1950285827;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_A69;
								case 8:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)1449590786;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)1753088010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection).CHO9BottomFunctionButtonIndex_A36665.Value == index)
									{
										num = (short)1232273419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									int num3;
									num3++;
									num = (short)763691016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)702873600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9CE:
								num = (short)1463156742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_97B:
								goto IL_9CE;
							}
							IL_A69:
							return result;
							IL_B27:
							goto IL_21A;
						}
						finally
						{
							num = (short)1028456449;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B99;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B5F;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)40960000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B5F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1823801346;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B99:
							num = (short)618179155;
							short num5 = num;
							num = (short)1602857555;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_B99;
							default:
								num = (short)444792832;
								if (num != 0)
								{
								}
								break;
							}
						}
						goto IL_BE6;
						IL_21A:
						num = (short)921763869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)595460120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Value == 207)
						{
							num = (short)721944585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C28;
					case 19:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection)
						{
							num = (short)1773928456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1896480794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
						num4 = directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Value;
						num = (short)30277634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)501153795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_91B;
					case 23:
						num = (short)1480523807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						bool result2 = true;
						num4 = -1;
						num = (short)774504467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_C28;
					case 26:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection)
						{
							num = (short)752484358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1842413595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						num = (short)1211564032;
						short num6 = num;
						if (self is global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection)
						{
							num = (short)1802305541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C28;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
						if (directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Value == 207)
						{
							num = (short)1165164564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C28;
					}
					case 29:
					{
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
						{
							num = (short)177012746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool result2;
						return result2;
					}
					case 30:
						try
						{
							num = (short)793182212;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4AB;
								case 1:
									goto IL_31A;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (self.Parent != acpFeatureNode3)
									{
										num = (short)55115783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)923336709;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_300;
									}
									continue;
								case 5:
									result = false;
									num = (short)798294017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)2005598218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1172832265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)396296192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value == num4)
									{
										num = (short)1815019526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonIndex_A36634.Value == index)
									{
										num = (short)2028339211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									int num3;
									num3++;
									num = (short)1128660995;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)659095560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1533935618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_371:
								num = (short)984416268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_300:
								goto IL_371;
							}
							IL_31A:
							return result;
							IL_4AB:
							goto IL_F92;
						}
						finally
						{
							num = (short)1714225152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4E4;
									}
									continue;
								case 1:
									goto IL_51C;
								case 2:
									enumerator.Dispose();
									num = (short)2108096513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4E4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1773076482;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_51C:;
						}
						goto IL_51F;
					case 31:
						if (topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 207)
						{
							num = (short)738590735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C28;
					case 32:
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Value != 206)
						{
							num = (short)1254424587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51F;
					}
					goto IL_B4;
					IL_193:
					num = (short)1860829184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27A:
					num4 = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value;
					num = (short)2109341700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51F:
					num4 = bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Value;
					num = (short)650510361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE6:
					num = (short)394199054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C28:
					num = (short)1936457729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F92:
					enumerator = bottomFunctionProgrammableButtonInnerRecset.GetEnumerator();
					num = (short)99024912;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_91B:
				try
				{
					num = (short)814022660;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_753;
						case 1:
						{
							int num4;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((acpFeatureNode4[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection).RadErgCtrlHeadO9DirLightBarFeature_A36597.Value == num4)
							{
								num = (short)1032454153;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							num = (short)1252065280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							result = false;
							num = (short)925433861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_5A4;
							}
							continue;
						case 5:
							goto IL_735;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (self.Parent != acpFeatureNode4)
							{
								num = (short)364707852;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((acpFeatureNode4[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection).RadErgCtrlHeadO9DirLightBarIndex_A36601.Value == index)
							{
								num = (short)1152909322;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)821624834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
							num = (short)289538054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1394671623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							int num3;
							num3++;
							num = (short)1535180811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
						{
							int num3;
							if (num3 > 0)
							{
								num = (short)718274563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							num = (short)765001729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_646:
						num = (short)1418657800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5A4:
						goto IL_646;
					}
					IL_735:
					return result;
					IL_753:
					bool result2;
					return result2;
				}
				finally
				{
					num = (short)425132032;
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
								goto IL_78A;
							}
							continue;
						case 1:
							goto IL_7C3;
						case 2:
							enumerator.Dispose();
							num = (short)1205731329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_78A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)159186946;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7C3:;
				}
				return true;
				IL_B4:
				global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
				topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
				bottomFunctionProgrammableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
				directionalButtonsListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
				actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
				num = (short)1794244625;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x0077599C File Offset: 0x00773B9C
		internal static bool ConDirectionalLightBarIndexisApplicableWhenUniversalRelayControllerEquipped(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
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
						if (directionalButtonsListInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
						{
							num2 = (short)397737986;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F3;
					case 2:
						num2 = (short)1664286723;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (directionalButtonsListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
						{
							num2 = (short)1974009856;
							short num3 = num2;
							num2 = (short)117112832;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_F3;
					}
					goto IL_20;
				}
				IL_EE:
				return directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Value == 207;
				IL_F3:
				num2 = (short)1356248642;
				short num4 = num2;
				num2 = (short)395556418;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_27;
				default:
					num2 = (short)1175912449;
					if (num2 != 0)
					{
					}
					num2 = (short)768016384;
					if (num2 != 0)
					{
					}
					return false;
				}
				break;
			}
			}
			IL_20:
			directionalButtonsListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection);
			IL_27:
			num2 = (short)23855105;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x00775B10 File Offset: 0x00773D10
		internal static bool ConDirectionalLightBarFeatureisApplicableWhenUniversalRelayControllerEquipped(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1801493780;
			short num2 = num;
			num = (short)546348308;
			switch (num2 == num)
			{
			}
			num = (short)1251672065;
			if (num != 0)
			{
			}
			num = (short)1234567168;
			short num3 = num;
			num = (short)1329135616;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
			if (directionalButtonsListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
			{
				bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
				directionalButtonsListInnerRecset.CalculateValidity();
				topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
			}
			return directionalButtonsListInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x00775C84 File Offset: 0x00773E84
		internal static bool ConTopFunctionButtonLabel1Valid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			global::AcpBusinessLayer.AcpField<string> cho9CnvTopFunctionButtonLabelLine1_A;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (cho9CnvTopFunctionButtonLabelLine1_A.Value.Contains(global::AllFeatures.CodeplugGuid.b("鏌", a_)))
					{
						num2 = (short)589496320;
						short num3 = num2;
						num2 = (short)515899395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 1:
					num2 = (short)1797259264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					IL_49:
					if (cho9CnvTopFunctionButtonLabelLine1_A.Value != null)
					{
						num2 = (short)1044905985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DD;
				case 3:
					return false;
				}
				goto IL_29;
				IL_DD:
				num2 = (short)1249139349;
				short num4 = num2;
				num2 = (short)2039306901;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_49;
				default:
					goto IL_113;
				}
			}
			return false;
			IL_113:
			num2 = (short)1346240513;
			if (num2 != 0)
			{
			}
			num2 = (short)1120403456;
			if (num2 != 0)
			{
			}
			return true;
			IL_29:
			cho9CnvTopFunctionButtonLabelLine1_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).CHO9CnvTopFunctionButtonLabelLine1_A36626;
			num2 = (short)788398082;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x00775DE4 File Offset: 0x00773FE4
		internal static bool ConTopFunctionButtonLabel2Valid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpField<string> cho9CnvTopFunctionButtonLabelLine2_A;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)194969600;
					short num3 = num2;
					if (cho9CnvTopFunctionButtonLabelLine2_A.Value.Contains(global::AllFeatures.CodeplugGuid.b("雇", a_)))
					{
						num2 = (short)1370161155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10C;
				}
				case 1:
					num2 = (short)2075590656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					IL_49:
					num2 = (short)136577025;
					if (num2 != 0)
					{
					}
					if (cho9CnvTopFunctionButtonLabelLine2_A.Value != null)
					{
						num2 = (short)1765408769;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10C;
				case 3:
					return false;
				}
				goto IL_29;
				IL_10C:
				num2 = (short)678644176;
				short num4 = num2;
				num2 = (short)1092307408;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_49;
				default:
					goto IL_141;
				}
			}
			return false;
			IL_141:
			num2 = (short)1335427072;
			if (num2 != 0)
			{
			}
			return true;
			IL_29:
			cho9CnvTopFunctionButtonLabelLine2_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).CHO9CnvTopFunctionButtonLabelLine2_A36627;
			num2 = (short)1884749826;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00775F48 File Offset: 0x00774148
		internal static bool ConTopFunctionButtonTrkZoneApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1733427200;
				short num2 = num;
				num = (short)1208287234;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)865677552;
						short num4 = num;
						num = (short)983314672;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)145686529;
							if (num != 0)
							{
							}
							num = (short)1986330624;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
							{
								num = (short)596967427;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 1:
						num = (short)1600258048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 3:
						return true;
					}
					IL_5D:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value != 74)
					{
						return false;
					}
					num = (short)464191489;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00776094 File Offset: 0x00774294
		public static bool ConTopFunctionBtnTrkChannelApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)129826816;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_32:
				switch (num3)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num = (short)305659909;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					goto IL_1B0;
				case 2:
				{
					num = (short)711579069;
					short num4 = num;
					num = (short)98424253;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B0;
					default:
						num = (short)952303616;
						if (num != 0)
						{
						}
						if (zoneChannelAssignment != null)
						{
							num = (short)1642790918;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12C;
					}
					break;
				}
				case 3:
					num = (short)1630404609;
					if (num != 0)
					{
					}
					if (topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 74)
					{
						num = (short)696778756;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					num = (short)986251264;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return true;
				case 6:
					num = (short)225312769;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return false;
				}
				goto IL_58;
				IL_12C:
				num = (short)435159043;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B0:
				if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
				{
					goto IL_12C;
				}
				num = (short)770506759;
				num3 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_58:
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			zoneChannelAssignment = (topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num = (short)1503002626;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00776288 File Offset: 0x00774488
		internal static bool ConTopFunctionButtonIndexEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1009909760;
				short num2 = num;
				num = (short)90308609;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
					switch (num3)
					{
					case 0:
						num = (short)1947140099;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 2:
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 207)
						{
							num = (short)26476544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
					{
						if (o9CHCnvTopFunctionButtonFeature_A.Value != 206)
						{
							return false;
						}
						num = (short)696043749;
						short num4 = num;
						num = (short)769247461;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1085407232;
							if (num != 0)
							{
							}
							num = (short)640614404;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return true;
					case 5:
						directionalButtonsListInnerRecset.CalculateValidity();
						num = (short)1591476230;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_19D;
					}
					IL_6A:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection;
					o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
					directionalButtonsListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset);
					topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonIndex_A36634.CalculateValidityAcrossRecset();
					bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
					if (topFunctionProgrammableButtonListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
					{
						num = (short)2021785605;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_19D:
					num = (short)771751937;
					if (num != 0)
					{
					}
					num = (short)1023410178;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x007764C4 File Offset: 0x007746C4
		internal static bool ConTopFunctionButtonStsMsgIndexEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (o9CHCnvTopFunctionButtonFeature_A.Value == 75)
					{
						num2 = (short)681181184;
						short num3 = num2;
						num2 = (short)1025900547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1015771893;
					short num4 = num2;
					num2 = (short)249000693;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_163;
					}
					break;
				}
				case 1:
					num2 = (short)497942528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_7C;
				case 3:
					goto IL_101;
				}
				goto IL_20;
				IL_7C:
				if (o9CHCnvTopFunctionButtonFeature_A.Value == 76)
				{
					break;
				}
				num2 = (short)781647873;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_101:
			num2 = (short)1498021889;
			if (num2 != 0)
			{
			}
			return true;
			IL_163:
			num2 = (short)767295488;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection;
			o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
			global::AcpBusinessLayer.Recordset recordset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
			topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.CalculateValidityAcrossRecset();
			recordset.CalculateValidity();
			num2 = (short)410255362;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x0077664C File Offset: 0x0077484C
		internal static bool ConTopFunctionButtonTrkZoneEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1260847104;
				short num2 = num;
				num = (short)1193213954;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)733575170;
						short num4 = num;
						num = (short)459700226;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)302579713;
							if (num != 0)
							{
							}
							num = (short)389480448;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
							{
								num = (short)1441202179;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 1:
						num = (short)1539964928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 3:
						return true;
					}
					IL_5E:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value != 74)
					{
						return false;
					}
					num = (short)1630470145;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00776794 File Offset: 0x00774994
		internal static bool ConTopFunctionBtnTrkChannelEditabl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1777926144;
				short num2 = num;
				num = (short)1590099970;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)554461835;
						short num4 = num;
						num = (short)1393977995;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1742471168;
							if (num != 0)
							{
							}
							if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
							{
								num = (short)841678851;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_112;
						}
						break;
					}
					case 1:
						num = (short)1661599744;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						return true;
					}
					IL_5F:
					if ((self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value != 74)
					{
						goto IL_112;
					}
					num = (short)176553985;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_112:
			num = (short)1973813249;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x007768DC File Offset: 0x00774ADC
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1381826560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)953810944;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_F7;
				}
				int num4;
				global::AcpCommonLib.IAcpRecordset parentRecset;
				int num6;
				bool flag;
				for (;;)
				{
					IL_50:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection o9NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						if (num4 != 88)
						{
							num = (short)1936523286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 1:
						goto IL_5FB;
					case 2:
						num = (short)656670745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (parentRecset == null)
						{
							return;
						}
						num = (short)1832924132;
						short num5 = num;
						num = (short)2091791332;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_18A;
						default:
							num = (short)1394737152;
							if (num != 0)
							{
							}
							num = (short)2094727175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						if (num4 != 0)
						{
							num = (short)915472404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_404;
					case 6:
						goto IL_1C9;
					case 7:
						num = (short)1030881295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)527237121;
						if (num != 0)
						{
						}
						num4 = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371.Value;
						num6 = num4 + 1;
						num = (short)1296629774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_6D4;
					case 10:
						if (num6 == 38)
						{
							num = (short)452919332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FB;
					case 11:
						num = (short)589430802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num4 != 144)
						{
							num = (short)1769996309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 13:
						if (num4 != 65)
						{
							num = (short)1248002059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 14:
						if (num4 == 38)
						{
							num = (short)842137626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51D;
					case 15:
						if (parentRecset.Count < 2)
						{
							num = (short)137035813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2001469463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_3DF;
					case 17:
						goto IL_1C9;
					case 18:
						if (num4 != 67)
						{
							num = (short)1211826206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 19:
						if (num6 != 66)
						{
							num = (short)1435631648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 20:
						num = (short)1772814370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_18A;
					case 22:
						num = (short)1527054360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)397475871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 24:
						if (num6 != 143)
						{
							num = (short)177078274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 25:
						if (num6 != 64)
						{
							num = (short)462290977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DF;
					case 26:
						num6 = 38;
						num = (short)340459559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (num6 == 87)
						{
							num = (short)966197264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D9;
					case 28:
						if (!flag)
						{
							num = (short)712572936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6 = o9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371.Value;
						num4 = num6 - 1;
						num = (short)721092618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)649920540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)415891456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						flag = true;
						num = (short)131596323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1218510875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1499987987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (num6 == 0)
						{
							num = (short)1760952329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1583284236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_204;
					case 36:
						num4 = 38;
						num = (short)1570766849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_495;
					case 38:
						if (o9NavigationControlsTableInnerSection != null)
						{
							num = (short)704315421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 39:
						goto IL_51D;
					}
					goto IL_F7;
					IL_18A:
					num = (short)1614151693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C9:
					num = (short)6881284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					o9NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection);
					num = (short)1136853030;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DF:
					num4 = 143;
					num6 = 144;
					num = (short)17694725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51D:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner).O9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371, num6));
					num = (short)748617734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FB:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInner).O9NavigationControlsTableInnerSection.RadErgoControlO9NaviControlFeature_A41371, num4));
					num = (short)2134966289;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_404:
				goto IL_6D9;
				IL_495:
				return;
				IL_6D4:
				return;
				IL_6D9:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.SyncO5NavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.SyncKeypadMicAndAccessoriesNavigationControls(task, num4, num6);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
				return;
				IL_F7:
				num4 = 0;
				num6 = 0;
				flag = false;
				parentRecset = self.ParentRecset;
				num = (short)439222275;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x00777000 File Offset: 0x00775200
		public static void SyncO9NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num;
			for (;;)
			{
				num = (short)1457192960;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					for (;;)
					{
						IL_29:
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
							if (o9NavigationControlsTableInnerRecset != null)
							{
								num = (short)1485504516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 1:
							goto IL_147;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset = controlHeadO9Recset[0][10731].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset;
							num = (short)161873920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							num = (short)151584768;
							short num3 = num;
							if (controlHeadO9Recset != null)
							{
								num = (short)809238530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerRecset o9NavigationControlsTableInnerRecset;
							global::AcpBusinessLayer.AcpListField radErgoControlO9NaviControlFeature_A = (o9NavigationControlsTableInnerRecset[0][10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection).RadErgoControlO9NaviControlFeature_A41371;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO9NaviControlFeature_A, upButtonConfigedFeatureValue));
							global::AcpBusinessLayer.AcpListField radErgoControlO9NaviControlFeature_A2 = (o9NavigationControlsTableInnerRecset[1][10734] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsTableInnerSection).RadErgoControlO9NaviControlFeature_A41371;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO9NaviControlFeature_A2, downButtonConfigedFeatureValue));
							num = (short)1072431105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_44;
					}
					IL_147:
					num = (short)926199050;
					short num4 = num;
					num = (short)1361751306;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_17C;
					}
					IL_44:
					num = (short)301531137;
					if (num != 0)
					{
					}
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1408368643;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
			}
			IL_17C:
			num = (short)947978240;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x007771F8 File Offset: 0x007753F8
		public static void ConSyncCnvDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1742405632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_19B;
				}
				int num3;
				int featureSectionId;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::AcpBusinessLayer.AcpListField acpListField;
				bool flag;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_AB7;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)519241776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (num3 != 140)
						{
							num = (short)884473944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6A;
					case 3:
						num = (short)1913454628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_2199;
					case 5:
						num = (short)2020999251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)2109145133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1907163153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)1988952070;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)992215044;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)591265797;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_100A;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1469382657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1068;
								case 4:
									num = (short)1131282435;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)83427330;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_F74;
									}
									continue;
								}
								IL_100F:
								num = (short)1900675072;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F74:
								goto IL_100F;
							}
							IL_100A:
							IL_1068:
							goto IL_34F;
						}
						finally
						{
							num = (short)1993408512;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_10A1;
									}
									continue;
								case 1:
									goto IL_10D9;
								case 2:
									enumerator.Dispose();
									num = (short)67043329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10A1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)39387138;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10D9:;
						}
						goto IL_10DC;
					case 9:
						goto IL_164D;
					case 10:
					{
						num = (short)1369309184;
						short num4 = num;
						goto IL_12FC;
					}
					case 11:
						goto IL_225D;
					case 12:
						dataButtonInnerRecset2 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						num = (short)2107244607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)103350345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_164D;
					case 15:
						return;
					case 16:
						goto IL_15E4;
					case 17:
						if (featureSectionId != 10608)
						{
							num = (short)1496776750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10DC;
					case 18:
						if (featureSectionId != 10212)
						{
							num = (short)1210318855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1ECD;
					case 19:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)507445306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225D;
					case 20:
						if (buttonsRecset != null)
						{
							num = (short)1596653580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EA;
					case 21:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)452657227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34F;
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)1524170789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E9;
					}
					case 23:
						goto IL_6D2;
					case 24:
						goto IL_164D;
					case 25:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1909981195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)2124873732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6A;
					case 27:
						if (num3 == 227)
						{
							num = (short)468516877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225D;
					case 28:
						if (featureSectionId <= 10209)
						{
							num = (short)231735335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1718026258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1827602500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225D;
					case 30:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)2040266795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 31:
						num = (short)785645570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1546518551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1195573249;
						if (num != 0)
						{
						}
						try
						{
							num = (short)407437313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2127;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2034;
									}
									continue;
								case 2:
									num = (short)1992687616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_20CA;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)717357058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)256376838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)1278148611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)944046085;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_20CF:
								num = (short)1804337156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2034:
								goto IL_20CF;
							}
							IL_20CA:
							IL_2127:
							goto IL_22E;
						}
						finally
						{
							num = (short)1010630658;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2127822849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2196;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_215E;
									}
									continue;
								}
								IL_215E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)628424704;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2196:;
						}
						goto IL_2199;
					case 34:
						if (acpListField != null)
						{
							num = (short)660537394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 35:
					{
						if (!flag)
						{
							num = (short)238092303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)922550341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1404698629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)81723416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)270729282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1445265441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)796327997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1283194936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF4;
					case 41:
						if (controlHeadO9Recset != null)
						{
							num = (short)1885470806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB7;
					case 42:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1465909327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1859518531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (num3 != 227)
						{
							num = (short)2050621471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6A;
					case 45:
						try
						{
							num = (short)677904385;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1483;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1449;
									}
									continue;
								case 2:
									goto IL_1535;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)412483589;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)798359558;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1619853315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1958412288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1790246914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1488:
								num = (short)1037303812;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1449:
								goto IL_1488;
							}
							IL_1483:
							IL_1535:
							goto IL_ED1;
						}
						finally
						{
							num = (short)923664384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_156C;
									}
									continue;
								case 1:
									goto IL_15A5;
								case 2:
									enumerator.Dispose();
									num = (short)336396289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_156C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)309395458;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_15A5:;
						}
						goto IL_15A8;
					case 46:
						num = (short)1810366511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						if (featureSectionId != 10713)
						{
							num = (short)584319008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)695795721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_8CD;
					case 49:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
						num = (short)1515323444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						goto IL_15A8;
					case 51:
						dataButtonInnerRecset3 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1464402005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_AF5;
					case 53:
						if (controlHeadO9Recset != null)
						{
							num = (short)366542919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225D;
					case 54:
						if (controlHeadO7Recset != null)
						{
							num = (short)1716256845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FC;
					case 55:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)216662058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B48;
					case 56:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)712769610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)445055014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 58:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1925644366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)1624637441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2221;
					}
					case 60:
						goto IL_164D;
					case 61:
					{
						if (featureSectionId != 10090)
						{
							num = (short)2004418563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
						num3 = dataButtonInnerSection2.BtnConventionalButtonDatatButtonFeature_A22610.Value;
						acpListField = dataButtonInnerSection2.BtnTrunkingButtonDatatButtonFeature_A22608;
						num = (short)268763150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1027866711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C31;
					case 63:
						goto IL_3EA;
					case 64:
						num = (short)31326234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_164D;
					case 66:
						try
						{
							num = (short)1328939009;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1E5A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1D6F;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
									num = (short)879296518;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)650969088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
									{
										num = (short)1562640386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1161953283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)42467332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1DA9;
								}
								IL_1DAE:
								num = (short)705888261;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D6F:
								goto IL_1DAE;
							}
							IL_1DA9:
							IL_1E5A:
							goto IL_15E9;
						}
						finally
						{
							num = (short)984547330;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1635057665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1ECA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E91;
									}
									continue;
								}
								IL_1E91:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1702952960;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1ECA:;
						}
						goto IL_1ECD;
					case 67:
						try
						{
							num = (short)230359046;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1946353668;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)1142030338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)2022637573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1084030977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_59F;
								case 4:
									num = (short)802422787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_4E5;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_4A8;
									}
									continue;
								}
								IL_547:
								num = (short)41418752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A8:
								goto IL_547;
							}
							IL_4E5:
							IL_59F:
							return;
						}
						finally
						{
							num = (short)1446248450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)519372801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_612;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5D8;
									}
									continue;
								}
								IL_5D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1352531968;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_612:;
						}
						goto IL_615;
					case 68:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)1587871763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)418185265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF5;
					}
					case 70:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1149501446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED1;
					case 71:
						goto IL_1AE9;
					case 72:
						if (num3 == 228)
						{
							num = (short)34799680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2199;
					case 73:
						if (!flag2)
						{
							num = (short)248709145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_225D;
					case 74:
						try
						{
							num = (short)372768769;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11D8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_119E;
									}
									continue;
								case 2:
									goto IL_128A;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)1503133701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2071920646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)288096259;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)1227161600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)659488770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11DD:
								num = (short)1430781956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_119E:
								goto IL_11DD;
							}
							IL_11D8:
							IL_128A:
							goto IL_1BF4;
						}
						finally
						{
							num = (short)619773952;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12C2;
									}
									continue;
								case 1:
									goto IL_12F9;
								case 2:
									enumerator.Dispose();
									num = (short)298319873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12C2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1567686658;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12F9:;
						}
						goto IL_12FC;
					case 75:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)139460616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (controlHeadO3Recset != null)
						{
							num = (short)453771315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C27;
					case 77:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)7733258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						try
						{
							num = (short)480641024;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_16E9;
									}
									continue;
								case 1:
									goto IL_18BE;
								case 2:
									num = (short)976814091;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_18D7;
								case 4:
									if (num3 != 227)
									{
										num = (short)1583742988;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)1988427785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1722;
								case 6:
									num = (short)507772932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_17AD;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)778240006;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									if (acpRecRefField != null)
									{
										num = (short)561381378;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18BE;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1669070849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)216334344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (acpRecRefField.Value != consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)611713037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18BE;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner2));
									num = (short)1719271431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)591265797;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1804:
								num = (short)1375862794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E9:
								goto IL_1804;
								IL_18BE:
								num = (short)1761804291;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1722:
							IL_17AD:
							IL_18D7:
							goto IL_A77;
						}
						finally
						{
							num = (short)313655296;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1910;
									}
									continue;
								case 1:
									goto IL_1948;
								case 2:
									enumerator.Dispose();
									num = (short)47448065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1910:
								if (enumerator == null)
								{
									break;
								}
								num = (short)260767746;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1948:;
						}
						goto Block_30;
					case 79:
						try
						{
							num = (short)1206321158;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1112539139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1041235968;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)2100756485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)520093700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_85B;
								case 4:
									goto IL_83E;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)224264194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_770;
									}
									continue;
								}
								IL_7C8:
								num = (short)1828651009;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_770:
								goto IL_7C8;
							}
							IL_83E:
							IL_85B:
							goto IL_B48;
						}
						finally
						{
							num = (short)1267269634;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)829423617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_8CA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_892;
									}
									continue;
								}
								IL_892:
								if (enumerator == null)
								{
									break;
								}
								num = (short)560529408;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8CA:;
						}
						goto Block_12;
					case 80:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1800798292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C6D;
					case 81:
						goto IL_164D;
					case 82:
						goto IL_194B;
					case 83:
						goto IL_6D2;
					case 84:
						goto IL_615;
					case 85:
						goto IL_C27;
					case 86:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)105250816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1704001626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)1531707464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (!acpListField.HiddenStatic)
						{
							num = (short)2102788112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6A;
					case 90:
						try
						{
							num = (short)610992134;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)2006843396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									num = (short)1498259321;
									short num5 = num;
									num = (short)2102173561;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_CF9;
									default:
										num = (short)655622144;
										if (num != 0)
										{
										}
										num = (short)240517123;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)915472385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)2052325376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_E5E;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)567410693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_D60;
								case 6:
									goto IL_CF9;
								}
								goto IL_D26;
								IL_CF9:
								switch (0)
								{
								case 0:
									IL_D26:
									goto IL_D65;
								}
								continue;
								IL_D65:
								num = (short)1489240066;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D60:
							IL_E5E:
							goto IL_1C31;
						}
						finally
						{
							num = (short)547946498;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)561446913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_ECE;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E95;
									}
									continue;
								}
								IL_E95:
								if (enumerator == null)
								{
									break;
								}
								num = (short)128974848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_ECE:;
						}
						goto IL_ED1;
					}
					goto IL_19B;
					IL_22E:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)875036725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34F:
					num = (short)564658216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EA:
					controlHeadO3Recset = null;
					dataButtonInnerRecset3 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)953745484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_615:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)12320850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D2:
					flag = false;
					num = (short)12517441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A77:
					num = (short)51576859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_8CD:
						num = (short)1113456646;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1377042436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
								num = (short)516423682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
								num = (short)1946746885;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								if (num3 != (acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
								{
									num = (short)1034223617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_A03;
							case 4:
								num = (short)186515459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_94C;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_90F;
								}
								continue;
							}
							IL_9AD:
							num = (short)1508442112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_90F:
							goto IL_9AD;
						}
						IL_94C:
						IL_A03:
						goto IL_2221;
					}
					finally
					{
						num = (short)2109210626;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)585826305;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_A74;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A3A;
								}
								continue;
							}
							IL_A3A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)192020480;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A74:;
					}
					goto IL_A77;
					IL_AB7:
					num = (short)493158470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF5:
					buttonsRecset = null;
					dataButtonInnerRecset2 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1095172116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B48:
					num = (short)718929942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C27:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1674838070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED1:
					num = (short)418316347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10DC:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
					num = (short)591003729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12FC:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)730267689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A8:
					num = (short)428343385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E9:
					num = (short)445251605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_164D:
					num = (short)890437667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AE9:
					num = (short)819462173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_30:
					try
					{
						IL_194B:
						num = (short)1657339905;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
								{
									num = (short)1436418052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_198E;
								}
								continue;
							case 2:
								goto IL_1A76;
							case 3:
								num = (short)474152962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
								num = (short)1315176453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_1A59;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)590872579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)671285248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_19E4:
							num = (short)218497030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_198E:
							goto IL_19E4;
						}
						IL_1A59:
						IL_1A76:
						goto IL_1C6D;
					}
					finally
					{
						num = (short)117047298;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1826881537;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1AE6;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1AAE;
								}
								continue;
							}
							IL_1AAE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)834732032;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AE6:;
					}
					goto IL_1AE9;
					IL_1B6A:
					num = (short)640679991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BF4:
					num = (short)2083389470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C31:
					num = (short)734855225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C6D:
					num = (short)458752062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ECD:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection3 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection3.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
					acpRecRefField = dataButtonInnerSection3.CHO3DataButtonConvIndex_A41419;
					acpListField = dataButtonInnerSection3.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
					num = (short)832045116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2199:
					num = (short)1505886242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2221:
					num = (short)1579548752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_225D:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)346685484;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_15E4:
				return;
				IL_19B:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)549519388;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00779634 File Offset: 0x00777834
		public static void ConSyncTrkDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)799801344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_18A;
				}
				int featureSectionId;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				int num3;
				bool flag2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					switch (num2)
					{
					case 0:
						if (dataButtonInnerRecset != null)
						{
							num = (short)23199780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199F;
					case 1:
						if (featureSectionId <= 10209)
						{
							num = (short)811335711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1752825926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)656408587;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1514;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)182059017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_14FB;
								case 3:
									if (num3 != 227)
									{
										num = (short)88801288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)237699085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)438566915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpRecRefField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1781858305;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14FB;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1984954370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)189202444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_13BE;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)241565703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_1358;
								case 10:
									num = (short)578486277;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_1320;
									}
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1240137732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									if (acpRecRefField != null)
									{
										num = (short)1705246730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14FB;
								}
								IL_1417:
								num = (short)2070413318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1320:
								goto IL_1417;
								IL_14FB:
								num = (short)809107456;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1358:
							IL_13BE:
							IL_1514:
							goto IL_1B84;
						}
						finally
						{
							num = (short)1263796226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2068054017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1584;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_154B;
									}
									continue;
								}
								IL_154B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2022375424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1584:;
						}
						goto IL_1587;
					case 3:
						if (buttonsRecset != null)
						{
							num = (short)1885405232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A3;
					case 4:
						goto IL_1688;
						try
						{
							for (;;)
							{
								IL_1688:
								num = (short)773652486;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_180C;
									case 1:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1188364290;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)1818886149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)1832976384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_17EF;
									case 4:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
										num = (short)2075328515;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (num3 != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
										{
											num = (short)1773952702;
											short num4 = num;
											num = (short)385375934;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_1688;
											default:
												num = (short)939589632;
												if (num != 0)
												{
												}
												num = (short)163643396;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_16CC;
										}
										continue;
									}
									IL_1775:
									num = (short)1435435009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_16CC:
									goto IL_1775;
								}
							}
							IL_17EF:
							IL_180C:
							goto IL_199F;
						}
						finally
						{
							num = (short)1138884610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)637140993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_187B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1844;
									}
									continue;
								}
								IL_1844:
								if (enumerator == null)
								{
									break;
								}
								num = (short)807927808;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_187B:;
						}
						goto IL_187E;
					case 5:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)245497890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num3 != 140)
						{
							num = (short)1382023241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC0;
					case 7:
						if (controlHeadO7Recset != null)
						{
							num = (short)218300424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C35;
					case 8:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)175964225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1625;
					case 10:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1851195449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (!flag)
						{
							num = (short)226820106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C2;
					case 12:
						return;
					case 13:
						if (num3 == 227)
						{
							num = (short)1421606994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C2;
					case 14:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)2124480552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D15;
					case 15:
						goto IL_A3F;
					case 16:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)156958805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)56623185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)879427629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)738590746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_1625;
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)1280638991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (controlHeadO9Recset != null)
						{
							num = (short)463011859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C2;
					case 23:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)13107250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (featureSectionId != 10090)
						{
							num = (short)839843857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value;
						num = (short)908853268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_1625;
					case 26:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)914489412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C2;
					case 27:
						goto IL_A02;
					case 28:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)985792589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2184;
					case 29:
						goto IL_193E;
					case 30:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1485897760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BFE;
					case 31:
						num = (short)1742012440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_9DB;
					case 33:
						num = (short)1757347894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						try
						{
							num = (short)592379908;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1007484931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)441319424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1455816706;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)1196359685;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_114B;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_105D;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)575864838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1096;
								}
								IL_109B:
								num = (short)1851064321;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_105D:
								goto IL_109B;
							}
							IL_1096:
							IL_114B:
							goto IL_1BC1;
						}
						finally
						{
							num = (short)2101084162;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11BC;
								case 1:
									enumerator.Dispose();
									num = (short)84410368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1183;
									}
									continue;
								}
								IL_1183:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1215234049;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11BC:;
						}
						goto IL_11BF;
					case 35:
						if (featureSectionId != 10608)
						{
							num = (short)2133852229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA2;
					case 36:
						goto IL_5C7;
					case 37:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)752549917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC0;
					case 38:
						if (num3 != 227)
						{
							num = (short)1910112302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC0;
					case 39:
						num = (short)392822821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)2048262205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)908591120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 42:
						goto IL_20F7;
					case 43:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1211826197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A3F;
					}
					case 44:
						try
						{
							num = (short)218562566;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1DE8;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1497366530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1195245571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1DC9;
								case 4:
									num = (short)408944640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1488388100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)335478785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1CF9;
									}
									continue;
								}
								IL_1CFB:
								num = (short)1438515205;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CF9:
								goto IL_1CFB;
							}
							IL_1DC9:
							IL_1DE8:
							goto IL_187E;
						}
						finally
						{
							num = (short)295174144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E1F;
									}
									continue;
								case 1:
									goto IL_1E56;
								case 2:
									enumerator.Dispose();
									num = (short)2040987649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E1F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)403832834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E56:;
						}
						goto IL_1E59;
					case 45:
						try
						{
							num = (short)113508356;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)409337858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)935460870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)1683881989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1226375171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_BC2;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_AD6;
									}
									continue;
								case 5:
									goto IL_BA4;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
									{
										num = (short)1848639489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_B2C:
								num = (short)1227882496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AD6:
								goto IL_B2C;
							}
							IL_BA4:
							IL_BC2:
							goto IL_15AE;
						}
						finally
						{
							num = (short)1048379394;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_C32;
								case 1:
									enumerator.Dispose();
									num = (short)1112604672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_BFA;
									}
									continue;
								}
								IL_BFA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)556072961;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C32:;
						}
						goto IL_C35;
					case 46:
						num = (short)518848518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)409600001;
						if (num != 0)
						{
						}
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)422838314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187E;
					case 48:
						goto IL_11BF;
					case 49:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1107886160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						try
						{
							num = (short)192413700;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)598736899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1448804352;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)1676804098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
									{
										num = (short)236584965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_F31;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_E41;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
									num = (short)280559622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_E7A;
								}
								IL_E7F:
								num = (short)527237121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E41:
								goto IL_E7F;
							}
							IL_E7A:
							IL_F31:
							goto IL_15E7;
						}
						finally
						{
							num = (short)803012610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F9F;
								case 1:
									enumerator.Dispose();
									num = (short)2092564480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F68;
									}
									continue;
								}
								IL_F68:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1236598785;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F9F:;
						}
						goto IL_FA2;
					case 51:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1146290199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E7;
					case 52:
						if (controlHeadO9Recset != null)
						{
							num = (short)1704263743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A02;
					case 53:
						try
						{
							num = (short)1033109506;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2085;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)944439302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)1443889156;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F9C;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)1187512325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1722482691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_2068;
								case 6:
									num = (short)1314979840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F9E:
								num = (short)596049921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F9C:
								goto IL_1F9E;
							}
							IL_2068:
							IL_2085:
							goto IL_2184;
						}
						finally
						{
							num = (short)1543897088;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20BD;
									}
									continue;
								case 1:
									goto IL_20F4;
								case 2:
									enumerator.Dispose();
									num = (short)857735169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20BD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1098383362;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20F4:;
						}
						goto IL_20F7;
					case 54:
						goto IL_631;
					case 55:
						if (controlHeadO3Recset != null)
						{
							num = (short)1298726961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C89;
					case 56:
						goto IL_1625;
					case 57:
						goto IL_21C2;
					case 58:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)1755906124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C2;
					case 59:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)495845440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_1625;
					case 61:
						try
						{
							num = (short)644874246;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B12;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)1729888261;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1361379331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)110231556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1850081280;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)418447361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1A5B;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1A1F;
									}
									continue;
								}
								IL_1ABC:
								num = (short)1707737090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A1F:
								goto IL_1ABC;
							}
							IL_1A5B:
							IL_1B12:
							goto IL_D15;
						}
						finally
						{
							num = (short)1977417730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)575799297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1B81;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1B4A;
									}
									continue;
								}
								IL_1B4A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1191772160;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B81:;
						}
						goto IL_1B84;
					case 62:
						if (num3 == 228)
						{
							num = (short)1423966247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 63:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)2005925915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						try
						{
							num = (short)1079902213;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)1537671170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_7BF;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)284950531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_762;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)877723654;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)1330839552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_6D0;
									}
									continue;
								case 6:
									num = (short)1490485249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_767:
								num = (short)1712455684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D0:
								goto IL_767;
							}
							IL_762:
							IL_7BF:
							goto IL_1C7A;
						}
						finally
						{
							num = (short)1231880194;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_830;
								case 1:
									enumerator.Dispose();
									num = (short)2094530560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7F7;
									}
									continue;
								}
								IL_7F7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)289996801;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_830:;
						}
						goto Block_8;
					case 65:
						goto IL_C35;
					case 66:
					{
						if (!flag2)
						{
							num = (short)1845690380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)1058668587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						goto IL_833;
					case 68:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)1892876346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)1738408022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (featureSectionId != 10212)
						{
							num = (short)1898446920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E59;
					case 71:
						goto IL_631;
					case 72:
						num = (short)1845559331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						num = (short)333250622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1511391291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C7A;
					case 75:
						num = (short)942866503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1448345602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_1587;
					case 78:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)409010194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15AE;
					case 79:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1942814725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC1;
					case 80:
						goto IL_C89;
					case 81:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1364459595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						num = (short)648216636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						num = (short)1974796299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_3A3;
					case 84:
						goto IL_1625;
					case 85:
						try
						{
							num = (short)1881604101;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_49E;
								case 1:
									goto IL_555;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									if (num3 != (acpFeatureNode9[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)964558851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)955842560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)527826950;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
									num = (short)766574594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_461;
									}
									continue;
								case 6:
									num = (short)1656553473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_500:
								num = (short)755630084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_461:
								goto IL_500;
							}
							IL_49E:
							IL_555:
							return;
						}
						finally
						{
							num = (short)494927873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)33488898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_58C;
									}
									continue;
								case 2:
									goto IL_5C4;
								}
								IL_58C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1617952768;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C4:;
						}
						goto IL_5C7;
					case 86:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1796669473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						num = (short)1889075284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_18A;
					IL_3A3:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)320733239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C7:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)1842348036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_631:
					flag2 = false;
					num = (short)886308889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DB:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)1124466755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_833:
						num = (short)1997471748;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_8EB;
							case 1:
								num = (short)476708867;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
								{
									num = (short)101122053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_969;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_875;
								}
								continue;
							case 5:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
								num = (short)63635456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)238878721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)775290882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_877:
							num = (short)722403334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_875:
							goto IL_877;
						}
						IL_8EB:
						IL_969:
						goto IL_1BFE;
					}
					finally
					{
						num = (short)1417936898;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_9D8;
							case 1:
								enumerator.Dispose();
								num = (short)873594880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_9A1;
								}
								continue;
							}
							IL_9A1:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1511325697;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_9D8:;
					}
					goto IL_9DB;
					IL_A02:
					num = (short)501547036;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3F:
					buttonsRecset = null;
					dataButtonInnerRecset3 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1422262275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C35:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1140850740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C89:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)2030370823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D15:
					num = (short)303235119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC0:
					num = (short)1933312074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA2:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
					num = (short)910491704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11BF:
					dataButtonInnerRecset3 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
					num = (short)1595998291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1587:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)1812463669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15AE:
					num = (short)18939955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E7:
					num = (short)1588985935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1625:
					num = (short)1803092034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187E:
					consolidatedActionBCOListInnerRecset = null;
					flag = false;
					num = (short)2021851158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199F:
					num = (short)294977550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B84:
					num = (short)623640589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC1:
					num = (short)1928986665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BFE:
					num = (short)109707264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7A:
					num = (short)11010126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E59:
					num = (short)1924202496;
					short num5 = num;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
					acpRecRefField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
					num = (short)1142882313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20F7:
					enumerator = o9DataButtonInnerRecset.GetEnumerator();
					num = (short)1392902188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2184:
					num = (short)1394475038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21C2:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1637416998;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_193E:
				return;
				IL_18A:
				num3 = 0;
				flag2 = true;
				acpRecRefField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1572536321;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x0077B9D0 File Offset: 0x00779BD0
		public static void ConSyncOrangeBtn(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1306066944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FB;
				}
				int featureSectionId;
				int num3;
				bool flag;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					switch (num2)
					{
					case 0:
						goto IL_1010;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						if (e5InnerRecset != null)
						{
							num = (short)2056650794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D22;
					}
					case 2:
						num = (short)251723794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_6C2;
					case 4:
						if (featureSectionId != 10715)
						{
							num = (short)250806272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_490;
					case 5:
						goto IL_9BA;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o5InnerRecset.GetEnumerator();
						num = (short)1447821347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_9BA;
					case 8:
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						num = (short)1456340995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_CE5;
					case 10:
						o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
						num = (short)958791701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)742064178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (featureSectionId != 10716)
						{
							num = (short)1955921935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value;
						num = (short)741933081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
						num = (short)99418148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (controlHeadO2Recset != null)
						{
							num = (short)485818407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE5;
					case 15:
						goto IL_65A;
					case 16:
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value;
						num = (short)1398013981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (featureSectionId == 10901)
						{
							num = (short)1950482448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB0;
					case 18:
						if (featureSectionId != 10627)
						{
							num = (short)171442198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value;
						num = (short)1507065861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						num = (short)1139736576;
						short num4 = num;
						if (controlHeadO5Recset != null)
						{
							num = (short)1985609741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111F;
					}
					case 20:
						goto IL_A95;
					case 21:
						goto IL_D70;
					case 22:
						num = (short)1555234817;
						if (num != 0)
						{
						}
						num = (short)153550879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						try
						{
							num = (short)697368577;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)936902658;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)388431877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7C3;
									}
									continue;
								case 2:
									num = (short)1468923907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_8B5;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value)
									{
										num = (short)976355334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768, num3));
									num = (short)987693060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_7C5:
								num = (short)1450246144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7C3:
								goto IL_7C5;
							}
							IL_8B5:
							goto IL_D22;
						}
						finally
						{
							num = (short)1371013120;
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
										goto IL_8EC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)537526274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_923;
								}
								IL_8EC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1123090433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_923:;
						}
						goto IL_926;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						if (controlHeadE5Recset != null)
						{
							num = (short)616235055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A95;
					}
					case 25:
						goto IL_9BA;
					case 26:
						IL_BAA:
						try
						{
							num = (short)1169293317;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1879310342;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)967901188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_5E9;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291, num3));
									num = (short)599588866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value)
									{
										num = (short)934084611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_501;
									}
									continue;
								case 6:
									num = (short)1523515393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_557:
								num = (short)697303040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_501:
								goto IL_557;
							}
							IL_5E9:
							goto IL_72D;
						}
						finally
						{
							num = (short)324730880;
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
										goto IL_620;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1507196930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_657;
								}
								IL_620:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1833959425;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_657:;
						}
						goto IL_65A;
					case 27:
						if (o9InnerRecset != null)
						{
							num = (short)1067843614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						if (controlHeadO7Recset != null)
						{
							num = (short)292683786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D70;
					case 29:
						goto IL_9BA;
					case 30:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9InnerRecset.GetEnumerator();
						num = (short)206503977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_BB0;
					case 32:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)395313178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (featureSectionId != 10211)
						{
							num = (short)400752642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value;
						num = (short)1745420295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_926;
					case 35:
						try
						{
							num = (short)1556676613;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_27E;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754, num3));
									num = (short)807731200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)633733121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)138149891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1159200774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_18E;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value)
									{
										num = (short)1613496322;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_190:
								num = (short)724893700;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18E:
								goto IL_190;
							}
							IL_27E:
							goto IL_1053;
						}
						finally
						{
							num = (short)1209794561;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2ED;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B5;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1136394240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)665780226;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2ED:;
						}
						goto Block_3;
					case 36:
						goto IL_111F;
					case 37:
						if (o7InnerRecset != null)
						{
							num = (short)1186529312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72D;
					case 38:
						if (o5InnerRecset != null)
						{
							num = (short)1639448582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1053;
					case 39:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						num = (short)250609673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (featureSectionId <= 10627)
						{
							num = (short)959971362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1241907204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						try
						{
							num = (short)1047789569;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EB1;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value)
									{
										num = (short)228065284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_F9F;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682, num3));
									num = (short)56164352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)989724678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)455475202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1180499971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F4A:
								num = (short)13762565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EB1:
								goto IL_F4A;
							}
							IL_F9F:
							return;
						}
						finally
						{
							num = (short)1342963712;
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
										goto IL_FD6;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)662175746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_100D;
								}
								IL_FD6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)988282881;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_100D:;
						}
						goto IL_1010;
					case 42:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = e5InnerRecset.GetEnumerator();
						num = (short)1924595735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						if (o2InnerRecset != null)
						{
							num = (short)1157103627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10A7;
					case 44:
					{
						if (!flag)
						{
							num = (short)354025520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = null;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = null;
						controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
						num = (short)47054872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_9BA;
					case 46:
						if (controlHeadO9Recset != null)
						{
							num = (short)498991112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 47:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset;
						num = (short)845086740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						return;
					case 49:
						goto IL_9BA;
					case 50:
						goto IL_2F0;
					}
					goto IL_FB;
					IL_490:
					num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value;
					num = (short)1449721905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_2F0:
						num = (short)745865221;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								if (num3 != (acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value)
								{
									num = (short)40828934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_41F;
							case 3:
								num = (short)1197342721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)2007695363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
								num = (short)988938240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_333;
								}
								continue;
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272, num3));
								num = (short)125566978;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_335:
							num = (short)1697185796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_333:
							goto IL_335;
						}
						IL_41F:
						goto IL_10A7;
					}
					finally
					{
						num = (short)844759041;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_48D;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_456;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)42139648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_456:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1243414530;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_48D:;
					}
					goto IL_490;
					IL_65A:
					num = (short)140247057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB0:
					flag = false;
					num = (short)1713285285;
					short num5 = num;
					num = (short)122661029;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BAA;
					default:
						num = (short)1990524928;
						if (num != 0)
						{
						}
						num = (short)1122893869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6C2:
					num = (short)1269039131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72D:
					controlHeadO9Recset = null;
					o9InnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)902955054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_926:
					num = (short)502202401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9BA:
					num = (short)1793130540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A95:
					num = (short)1989476353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE5:
					num = (short)944963627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D22:
					controlHeadO2Recset = null;
					o2InnerRecset = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)886571022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D70:
					num = (short)33030181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1010:
					num = (short)1820655628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1053:
					controlHeadO7Recset = null;
					o7InnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1212416028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10A7:
					controlHeadO5Recset = null;
					o5InnerRecset = null;
					controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
					num = (short)549781523;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111F:
					num = (short)1816133670;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FB:
				num3 = 0;
				flag = true;
				featureSectionId = self.FeatureSectionId;
				num = (short)1111752744;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x0077CBB8 File Offset: 0x0077ADB8
		public static bool ConIsDynamicZoneValidInO9TopButtonCnvZone(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)52232192;
					short num3 = num2;
					result = false;
					goto IL_1F4;
				}
				case 1:
				{
					num2 = (short)626606297;
					short num4 = num2;
					num2 = (short)699023577;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F4;
					default:
					{
						num2 = (short)2120482816;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num2 = (short)908132355;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 2:
					goto IL_20C;
				case 3:
					num2 = (short)1946943489;
					if (num2 != 0)
					{
					}
					num2 = (short)402194436;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)1014759424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 5:
					goto IL_1C5;
				case 6:
					if (index >= 0)
					{
						num2 = (short)534052871;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					num2 = (short)78708744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (index > topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.RefRecset.Count)
					{
						num2 = (short)382992389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvZone_A36942.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)1025048577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_34;
				IL_1F4:
				num2 = (short)314114050;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C5:
			return true;
			IL_20C:
			return result;
			IL_34:
			result = true;
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			num2 = (short)1007878150;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x0077CDD8 File Offset: 0x0077AFD8
		public static bool ConIsDynamicZoneValidInO9TopButtonTrkZone(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)639107072;
					short num3 = num2;
					result = false;
					goto IL_1F3;
				}
				case 1:
				{
					num2 = (short)251963143;
					short num4 = num2;
					num2 = (short)1795991303;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F3;
					default:
					{
						num2 = (short)633405440;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (zoneChannelAssignment != null)
						{
							num2 = (short)150798339;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 2:
					goto IL_20B;
				case 3:
					num2 = (short)700186628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)1121779712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 5:
					goto IL_1C6;
				case 6:
					if (index >= 0)
					{
						num2 = (short)349569031;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					num2 = (short)1738801153;
					if (num2 != 0)
					{
					}
					num2 = (short)740294664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (index > topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944.RefRecset.Count)
					{
						num2 = (short)1331101701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnTrkZone_A36944.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)1676410881;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_34;
				IL_1F3:
				num2 = (short)745930754;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C6:
			return true;
			IL_20B:
			return result;
			IL_34:
			result = true;
			topFunctionProgrammableButtonListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection);
			num2 = (short)33357830;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x0077CFF8 File Offset: 0x0077B1F8
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (self.ParentRecset[1] == self.Parent)
			{
				short num = (short)246919262;
				short num2 = num;
				num = (short)821538910;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				case 1:
					break;
				default:
				{
					num = (short)2051211264;
					short num3 = num;
					break;
				}
				}
				num = (short)1840054272;
				if (num != 0)
				{
				}
				num = (short)1325793281;
				if (num != 0)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x0077D0C0 File Offset: 0x0077B2C0
		internal static bool ConO9DataButtonConvIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_95:
					num2 = (short)702218243;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return true;
				case 2:
					if (o9DataButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)801439744;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				case 3:
					if (o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value == 227)
					{
						num2 = (short)1410400257;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DC;
				}
				goto IL_20;
				IL_DC:
				num2 = (short)1818858113;
				short num3 = num2;
				num2 = (short)1595970177;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_95;
				default:
					goto IL_111;
				}
			}
			return true;
			IL_111:
			num2 = (short)777650177;
			if (num2 != 0)
			{
			}
			num2 = (short)1986265088;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			o9DataButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection);
			num2 = (short)1805778944;
			short num4 = num2;
			num2 = (short)1789788162;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x0077D21C File Offset: 0x0077B41C
		internal static bool ConO9DataButtonTrkIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_92:
					num2 = (short)1574240259;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return true;
				case 2:
					if (o9DataButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)613810176;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DA;
				case 3:
					if (o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value == 227)
					{
						num2 = (short)1202520065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_DA;
				}
				goto IL_20;
				IL_DA:
				num2 = (short)1089022085;
				short num3 = num2;
				num2 = (short)1035348101;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_92;
				default:
					goto IL_10F;
				}
			}
			return true;
			IL_10F:
			num2 = (short)1941241856;
			if (num2 != 0)
			{
			}
			num2 = (short)1755643905;
			if (num2 != 0)
			{
			}
			return false;
			IL_20:
			o9DataButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection);
			num2 = (short)1411055616;
			short num4 = num2;
			num2 = (short)417333250;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x0077D378 File Offset: 0x0077B578
		public static void ConValueSetIfDataCnvIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)775159808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_116;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_BC2;
					case 1:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1463943187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1379;
					case 2:
						try
						{
							num = (short)890699788;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1755512837;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)913244163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_3BF;
								case 2:
									if (flag)
									{
										num = (short)1539833865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)1872691211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_284;
								}
								case 4:
									goto IL_247;
								case 5:
									num = (short)586678273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField.UIValue));
									flag = true;
									num = (short)2016673796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_3A1;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)374734854;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_247;
								}
								case 9:
									num = (short)492371975;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_284;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField.UIValue));
									flag = true;
									num = (short)2003501066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									switch (0)
									{
									case 0:
										goto IL_1BE;
									}
									continue;
								}
								IL_1C3:
								num = (short)214433792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BE:
								goto IL_1C3;
								IL_247:
								num = (short)249364482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_284:
								num = (short)737214472;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A1:
							IL_3BF:
							goto IL_1497;
						}
						finally
						{
							num = (short)1080885250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_42F;
								case 1:
									enumerator.Dispose();
									num = (short)1423900672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3F6;
									}
									continue;
								}
								IL_3F6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)60948481;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_42F:;
						}
						goto IL_432;
					case 3:
						goto IL_150F;
					case 4:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)360579126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A4;
					case 5:
						if (controlHeadO9Recset != null)
						{
							num = (short)605356065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16DE;
					case 6:
						num = (short)1563492397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)619446273;
						if (num != 0)
						{
						}
						goto IL_1447;
					case 8:
						goto IL_16DE;
					case 9:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)226164784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15ED;
					case 10:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)965738498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						try
						{
							num = (short)850591752;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1306132483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_A5D;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1327759364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)257556487;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1490681862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A44;
								}
								case 4:
									goto IL_A44;
								case 5:
									goto IL_9A6;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField.UIValue));
									num = (short)1562050565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)850526208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_923;
									}
									continue;
								}
								IL_9AB:
								num = (short)1176240130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_923:
								goto IL_9AB;
								IL_A44:
								num = (short)1871904769;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9A6:
							IL_A5D:
							return;
						}
						finally
						{
							num = (short)201850880;
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
										goto IL_A94;
									}
									continue;
								case 1:
									goto IL_ACC;
								case 2:
									enumerator.Dispose();
									num = (short)1828782081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A94:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1103298562;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_ACC:;
						}
						goto IL_ACF;
					case 12:
						if (featureSectionId <= 10212)
						{
							num = (short)1020330020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)403832860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						acpListField = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668;
						num = (short)1567162410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (controlHeadO3Recset != null)
						{
							num = (short)1201274906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ACF;
					case 15:
						goto IL_BC2;
					case 16:
						goto IL_15ED;
					case 17:
						if (acpListField2.Value != 134)
						{
							num = (short)865992755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150F;
					case 18:
					{
						if (featureSectionId != 10212)
						{
							num = (short)1586298901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField = dataButtonInnerSection.CHO3DataButtonConvIndex_A41419;
						acpListField2 = dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
						num = (short)123863081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)492568625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (controlHeadO9Recset != null)
						{
							num = (short)1943994374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						num = (short)410976256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1548484618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1497;
					case 23:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1876623406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField2 = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
						num = (short)1742143503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (acpListField == null)
						{
							num = (short)786825268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FCD;
					case 25:
						try
						{
							num = (short)766509065;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_EFD;
								case 1:
									num = (short)385220618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1766522881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1212809223;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_E13;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField.UIValue));
									flag = true;
									num = (short)1404960771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									if (flag)
									{
										num = (short)337575944;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)272236556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EAE;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)1022296068;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E13;
								}
								case 8:
									num = (short)110886912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_D67;
									}
									continue;
								case 10:
									goto IL_F5A;
								case 11:
									goto IL_EAE;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField.UIValue));
									flag = true;
									num = (short)565641227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_D67;
								IL_E13:
								num = (short)1059454982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EAE:
								num = (short)6094853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F02:
								num = (short)549650434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D67:
								goto IL_F02;
							}
							IL_EFD:
							IL_F5A:
							goto IL_4A4;
						}
						finally
						{
							num = (short)2089025536;
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
										goto IL_F93;
									}
									continue;
								case 1:
									goto IL_FCA;
								case 2:
									enumerator.Dispose();
									num = (short)853803009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F93:
								if (enumerator == null)
								{
									break;
								}
								num = (short)297467906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FCA:;
						}
						goto IL_FCD;
					case 26:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1671036959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1323761707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (featureSectionId != 10608)
						{
							num = (short)1160183835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_432;
					case 29:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1951137799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)800718859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_ACF;
					case 32:
						if (controlHeadO7Recset != null)
						{
							num = (short)1033043997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1447;
					case 33:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)1528758280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (acpListField2 != null)
						{
							num = (short)1712717868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 35:
						if (134 == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
						{
							num = (short)488964109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC2;
					case 36:
						num = (short)1018101783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (acpListField2.Value == 227)
						{
							num = (short)2115305475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 38:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1678311463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
						num = (short)818806839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						num = (short)80478264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1839792178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_BC2;
					case 42:
						goto IL_BC2;
					case 43:
						if (featureSectionId != 10623)
						{
							num = (short)302121007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83E;
					case 44:
						num = (short)1061290001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)136118302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
						num = (short)1972371474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)703922214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)319553552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						try
						{
							num = (short)1565065228;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_66A;
								case 1:
									goto IL_7C9;
								case 2:
									goto IL_5CA;
								case 3:
								{
									num = (short)639230705;
									short num3 = num;
									num = (short)162783985;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_53C;
									default:
										num = (short)1535246336;
										if (num != 0)
										{
										}
										num = (short)1471479809;
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
										num = (short)378339331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1306853387;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)1367998474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_66A;
								}
								case 6:
									goto IL_6BA;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField.UIValue));
									flag = true;
									num = (short)938082306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2049572870;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (flag)
									{
										num = (short)854392840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField.UIValue));
									flag = true;
									num = (short)1075707904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)1836777479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5CA;
								}
								case 12:
									goto IL_53C;
								}
								goto IL_581;
								IL_53C:
								switch (0)
								{
								case 0:
									IL_581:
									goto IL_6BF;
								}
								continue;
								IL_5CA:
								num = (short)1116733445;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_66A:
								num = (short)177078281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6BF:
								num = (short)1305542660;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6BA:
							IL_7C9:
							goto IL_1379;
						}
						finally
						{
							num = (short)816316418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_83B;
								case 1:
									enumerator.Dispose();
									num = (short)186056704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_801;
									}
									continue;
								}
								IL_801:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2092564481;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_83B:;
						}
						goto IL_83E;
					case 50:
						try
						{
							num = (short)531890185;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)1282932738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1171;
								}
								case 1:
									goto IL_128A;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField.UIValue));
									flag = true;
									num = (short)1253834758;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (flag)
									{
										num = (short)19726343;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_10AE;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1418526728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1323892736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1171;
								case 7:
									num = (short)728694785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)875757578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_10A9;
									}
									continue;
								case 10:
									goto IL_12A8;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField.UIValue));
									flag = true;
									num = (short)291504132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)1501691915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10AE;
								}
								}
								goto IL_10A9;
								IL_10AE:
								num = (short)717815811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1171:
								num = (short)95748108;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11CC:
								num = (short)339869701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A9:
								goto IL_11CC;
							}
							IL_128A:
							IL_12A8:
							goto IL_165E;
						}
						finally
						{
							num = (short)1419051008;
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
										goto IL_12DF;
									}
									continue;
								case 1:
									goto IL_1317;
								case 2:
									enumerator.Dispose();
									num = (short)2037841921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12DF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1781006338;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1317:;
						}
						return;
					case 51:
						num = (short)917241893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						return;
					case 53:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)63569960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165E;
					case 54:
					{
						num = (short)594214912;
						short num4 = num;
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)823984153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						goto IL_BC2;
					case 56:
						goto IL_BC2;
					case 57:
						goto IL_BC2;
					}
					goto IL_116;
					IL_432:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					acpListField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField2 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num = (short)171835449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A4:
					num = (short)1699020822;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83E:
					consolidatedActionBCOListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection);
					num = (short)211746851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ACF:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)503906336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC2:
					num = (short)1794637848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FCD:
					keypadMicAndAccessoriesRecset = null;
					dataButtonInnerRecset = null;
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)1522008073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1379:
					num = (short)201523204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1447:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1686962181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1497:
					num = (short)782630965;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_150F:
					num = (short)1437532180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15ED:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)784990222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165E:
					num = (short)349044770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16DE:
					flag = false;
					num = (short)2025914369;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_116:
				acpListField = null;
				acpListField2 = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)854917132;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x0077EB74 File Offset: 0x0077CD74
		public static void ConValueSetIfDataTrkIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1905983488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_102;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField2;
				for (;;)
				{
					IL_27:
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					switch (num2)
					{
					case 0:
						if (acpListField != null)
						{
							num = (short)1080295459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						if (featureSectionId != 10608)
						{
							num = (short)886374429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
						acpListField2 = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
						acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
						num = (short)1340932127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						flag = false;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)183762950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)982253611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_573;
					case 5:
						goto IL_5F4;
					case 6:
						try
						{
							num = (short)1420230661;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField2.UIValue));
									flag = true;
									num = (short)739377160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_1468;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)984547334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)340983818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_13F9;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField2.UIValue));
									flag = true;
									num = (short)1294467075;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1393;
									}
									continue;
								case 6:
									num = (short)1705246731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)162594816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_146D;
								}
								case 8:
									goto IL_146D;
								case 9:
									if (flag)
									{
										num = (short)1773666316;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)1515454468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_13F9;
								}
								case 11:
									goto IL_158D;
								case 12:
									num = (short)728498177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1393;
								IL_13F9:
								num = (short)1379401735;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_146D:
								num = (short)217382921;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1535:
								num = (short)903479298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1393:
								goto IL_1535;
							}
							IL_1468:
							IL_158D:;
						}
						finally
						{
							num = (short)1938882561;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1344012290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_15C2;
									}
									continue;
								case 2:
									goto IL_15FB;
								}
								IL_15C2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)276889600;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_15FB:;
						}
						goto IL_15FE;
					case 7:
						return;
					case 8:
						if (controlHeadO3Recset != null)
						{
							num = (short)829620233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E2;
					case 9:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1966473230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_573;
					case 11:
						goto IL_C86;
					case 12:
					{
						if (featureSectionId != 10209)
						{
							num = (short)116654120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1091633162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)2030829573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_7E2;
					case 15:
					{
						if (featureSectionId != 10713)
						{
							num = (short)44433438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField2 = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)460259370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_573;
					case 17:
						try
						{
							num = (short)2129723393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2062680069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_109F;
									}
									continue;
								case 2:
									goto IL_11C7;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1137246210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)570163206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField2.UIValue));
									num = (short)157417480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField2.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)198770692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11C7;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)747765760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_11DF;
								case 8:
									goto IL_1181;
								}
								IL_1186:
								num = (short)524419075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_109F:
								goto IL_1186;
								IL_11C7:
								num = (short)1327890439;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1181:
							IL_11DF:
							return;
						}
						finally
						{
							num = (short)1887764480;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1216;
									}
									continue;
								case 1:
									goto IL_124E;
								case 2:
									enumerator.Dispose();
									num = (short)1732902913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1216:
								if (enumerator == null)
								{
									break;
								}
								num = (short)283181058;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_124E:;
						}
						goto IL_1251;
					case 18:
						try
						{
							num = (short)799211525;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1165754369;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1741619212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)894631947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField2.UIValue));
									flag = true;
									num = (short)1623982089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)645922818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CB;
								}
								case 4:
									if (flag)
									{
										num = (short)310509575;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1AC;
									}
									continue;
								case 6:
									goto IL_2E6;
								case 7:
									num = (short)596115466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField2.UIValue));
									flag = true;
									num = (short)1589248006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_1CB;
								case 10:
									goto IL_1C6;
								case 11:
									goto IL_3A4;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)958988296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E6;
								}
								}
								goto IL_1AC;
								IL_1CB:
								num = (short)157351940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								num = (short)1121910784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AC:
								goto IL_200;
								IL_2E6:
								num = (short)319029251;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C6:
							IL_3A4:
							goto IL_12F9;
						}
						finally
						{
							num = (short)1576534016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3DB;
									}
									continue;
								case 1:
									goto IL_414;
								case 2:
									enumerator.Dispose();
									num = (short)987824129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3DB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1419247618;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_414:;
						}
						goto IL_417;
					case 19:
						goto IL_F93;
					case 20:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1562116117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_484;
					case 21:
						flag = false;
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)48955430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)1464860677;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_A8E;
								case 1:
									if (flag)
									{
										num = (short)1336803337;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1640038406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1946157060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_ACC;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)1666252807;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_ACC;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_9CA;
									}
									continue;
								case 6:
									num = (short)1996029963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField2.UIValue));
									flag = true;
									num = (short)1766260739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField2.UIValue));
									flag = true;
									num = (short)1330511882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)665583616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_A93;
								case 11:
									goto IL_BC4;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)855048200;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A93;
								}
								}
								goto IL_9CA;
								IL_A93:
								num = (short)1230372865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ACC:
								num = (short)1233387532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B6B:
								num = (short)1984036866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9CA:
								goto IL_B6B;
							}
							IL_A8E:
							IL_BC4:
							goto IL_417;
						}
						finally
						{
							num = (short)1539178496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_BDE;
								case 1:
								{
									num = (short)502958550;
									short num3 = num;
									num = (short)1879280086;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_BDE;
									default:
										goto IL_C6D;
									}
									break;
								}
								case 2:
									enumerator.Dispose();
									num = (short)360316929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_BFB;
								IL_BDE:
								switch (0)
								{
								case 0:
									IL_BFB:
									if (enumerator == null)
									{
										goto IL_C85;
									}
									num = (short)956956674;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_C6D:
							num = (short)522911744;
							if (num != 0)
							{
							}
							IL_C85:;
						}
						goto IL_C86;
					case 23:
						if (controlHeadO9Recset != null)
						{
							num = (short)2031812644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C86;
					case 24:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1462763539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_417;
					case 25:
						num = (short)1231028256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (controlHeadO7Recset != null)
						{
							num = (short)1582497805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F4;
					case 27:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1863974961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						num = (short)2136473601;
						if (num != 0)
						{
						}
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1288568883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F9;
					case 29:
						num = (short)872939535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)992280580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_573;
					case 32:
						if (acpListField.Value == 227)
						{
							num = (short)345964590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 33:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1599406082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FE;
					case 34:
						goto IL_835;
					case 35:
						num = (short)1568997426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_1251;
					case 37:
						num = (short)988676108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						try
						{
							num = (short)2137718789;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)956104705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E4C;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField2.UIValue));
									flag = true;
									num = (short)1916469258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)73138182;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DAB;
								}
								case 3:
									goto IL_E9F;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2060713991;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1710292994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_D21;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField2.UIValue));
									flag = true;
									num = (short)119668745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)983302155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1638137859;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_DAB;
								case 10:
									goto IL_E4C;
								case 11:
									goto IL_F21;
								case 12:
									if (flag)
									{
										num = (short)1162739720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_D6A:
								num = (short)509804548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D21:
								goto IL_D6A;
								IL_DAB:
								num = (short)580780032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E4C:
								num = (short)20250636;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E9F:
							IL_F21:
							goto IL_484;
						}
						finally
						{
							num = (short)353107968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F59;
									}
									continue;
								case 1:
									goto IL_F90;
								case 2:
									enumerator.Dispose();
									num = (short)1708326913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F59:
								if (enumerator == null)
								{
									break;
								}
								num = (short)445251586;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F90:;
						}
						goto IL_F93;
					case 39:
						num = (short)1134493723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1694564400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)2111045666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_573;
					case 43:
						goto IL_573;
					case 44:
						if (controlHeadO9Recset != null)
						{
							num = (short)1917190183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 45:
						if (featureSectionId <= 10212)
						{
							num = (short)856227877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1544814593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_73D;
					case 47:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1188560937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_835;
					}
					case 48:
					{
						if (featureSectionId != 10212)
						{
							num = (short)1279131651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
						acpListField = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
						num = (short)534970384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)61079569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (acpListField.Value != 134)
						{
							num = (short)1437532185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73D;
					case 51:
						flag = false;
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)207880210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						if (acpListField2 == null)
						{
							num = (short)1051787271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)104136751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_102;
					IL_417:
					num = (short)2069954593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_484:
					num = (short)1519124480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_573:
					num = (short)1882193972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F4:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1868890135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73D:
					num = (short)608763948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E2:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1887961114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_835:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1033764872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C86:
					flag = false;
					num = (short)449183768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F93:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)1675624470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1251:
					num = (short)1439170560;
					short num4 = num;
					o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
					num = (short)1404895243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12F9:
					num = (short)309264404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FE:
					num = (short)1635254300;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_102:
				acpListField2 = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)584908845;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x007802AC File Offset: 0x0077E4AC
		internal static bool ConDataButtonIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1386151936;
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
					bool result;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					for (;;)
					{
						IL_27:
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
						{
							if (index != 0)
							{
								goto IL_C0F;
							}
							num = (short)748033952;
							short num3 = num;
							num = (short)1899829152;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1148715008;
								if (num != 0)
								{
								}
								num = (short)1385365505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_F4;
						case 2:
							try
							{
								num = (short)1185349648;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
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
									switch (num2)
									{
									case 0:
										num = (short)270401554;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay6_A36511.Value == 3);
										goto IL_B47;
									}
									case 2:
										num = (short)254410803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										flag2 = false;
										goto IL_9F5;
									case 4:
										if (flag3)
										{
											num = (short)1255276568;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)489095212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										num = (short)1083310139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag4 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay8_A36513.Value == 3);
										goto IL_827;
									}
									case 8:
										if (flag3)
										{
											num = (short)947257367;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1901133827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)1293877294;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										num = (short)68485165;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection = generalLightbarPatternInner.GeneralLightbarPatternInnerSection;
										flag3 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay1_A36506.Value == 3);
										num = (short)912523272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										flag5 = false;
										goto IL_AA0;
									case 13:
										flag6 = false;
										goto IL_A34;
									case 15:
										if (flag3)
										{
											num = (short)2121269250;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)479723533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
										switch (0)
										{
										case 0:
											goto IL_24B;
										}
										continue;
									case 17:
										if (flag3)
										{
											num = (short)897187862;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1590558757;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										goto IL_B9F;
									case 19:
										num = (short)2125594673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 20:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value != 1)
										{
											num = (short)646512704;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_4DF;
									}
									case 21:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag2 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay2_A36507.Value == 3);
										goto IL_9F5;
									}
									case 22:
										num = (short)853999617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 23:
										num = (short)289669141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
										num = (short)582484004;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 25:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
										int num4;
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner = generalLightbarPatternInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
										num = (short)1584201756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 26:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
										{
											num = (short)1759117321;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 27:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGeneralActionAllowed_A36579.Value)
										{
											num = (short)2076770335;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5EB;
									}
									case 28:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
										if (generalLightbarPatternInner != null)
										{
											num = (short)861208587;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_60A;
									}
									case 29:
										flag7 = false;
										goto IL_553;
									case 30:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
										int num4;
										if (generalLightbarPatternInnerRecset.Count > num4)
										{
											num = (short)315686917;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_60A;
									}
									case 31:
										num = (short)1197867028;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 32:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
										if (radioWideRecset != null)
										{
											num = (short)658047039;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_60A;
									}
									case 33:
										if (flag3)
										{
											num = (short)515899444;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)817233932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 34:
										if (flag3)
										{
											num = (short)1980825610;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)856424477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 35:
										result = false;
										num = (short)946864170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 36:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag8 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay5_A36510.Value == 3);
										goto IL_868;
									}
									case 37:
										flag = false;
										goto IL_B47;
									case 39:
										num = (short)1800077355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 40:
										goto IL_4DF;
									case 41:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value == 7)
										{
											num = (short)1685389352;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										result = false;
										num = (short)1689190438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 43:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag9 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay10_A36516.Value == 3);
										goto IL_451;
									}
									case 44:
										flag8 = false;
										goto IL_868;
									case 45:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag7 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay7_A36512.Value == 3);
										goto IL_553;
									}
									case 46:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0)
										{
											num = (short)1592000560;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_5EB;
									}
									case 47:
										flag9 = false;
										goto IL_451;
									case 48:
										num = (short)1033306139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 49:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag10 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay3_A36508.Value == 3);
										goto IL_8D4;
									}
									case 50:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag5 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay9_A36515.Value == 3);
										goto IL_AA0;
									}
									case 51:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
										flag6 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay4_A36509.Value == 3);
										goto IL_A34;
									}
									case 52:
										num = (short)1144848434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 53:
										goto IL_60A;
									case 54:
										num = (short)345702406;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 55:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value <= 0)
										{
											num = (short)1605435427;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										int num4 = (acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value - 1;
										flag3 = false;
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
										num = (short)39518240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 56:
										if (flag3)
										{
											num = (short)1840513078;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1719205946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 57:
										flag10 = false;
										goto IL_8D4;
									case 58:
										flag4 = false;
										goto IL_827;
									case 59:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
										int num4;
										if (generalLightbarPatternInnerRecset[num4] != null)
										{
											num = (short)651624473;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_60A;
									}
									case 60:
										if (flag3)
										{
											num = (short)2021457959;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1037762607;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 61:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1397227520;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)568721434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 62:
										if (flag3)
										{
											num = (short)1629290515;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1238564921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 63:
									{
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
										global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = radioWideRecset[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
										num = (short)1145962526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 64:
										num = (short)1257373737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_24B;
									IL_451:
									flag3 = flag9;
									num = (short)860749877;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_49E:
									num = (short)1978794045;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_24B:
									goto IL_49E;
									IL_4DF:
									num = (short)116129847;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_553:
									flag3 = flag7;
									num = (short)1355743288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_5EB:
									result = false;
									num = (short)267386887;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_60A:
									result = flag3;
									num = (short)1428946958;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_827:
									flag3 = flag4;
									num = (short)26804257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_868:
									flag3 = flag8;
									num = (short)1625620497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_8D4:
									flag3 = flag10;
									num = (short)685637647;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_9F5:
									flag3 = flag2;
									num = (short)839974974;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_A34:
									flag3 = flag6;
									num = (short)1482948612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_AA0:
									flag3 = flag5;
									num = (short)473366588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_B47:
									flag3 = flag;
									num = (short)1591803938;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_B9F:
								return result;
							}
							finally
							{
								num = (short)1809711104;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_BD7;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)1215234050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_C0C;
									}
									IL_BD7:
									if (enumerator == null)
									{
										break;
									}
									num = (short)488964097;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_C0C:;
							}
							goto IL_C0F;
						}
						break;
						IL_C0F:
						enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)938868738;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3A:
					num = (short)2133524481;
					if (num != 0)
					{
					}
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					result = true;
					num = (short)169410560;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			IL_F4:
			num = (short)1735131136;
			short num5 = num;
			return false;
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x00780F0C File Offset: 0x0077F10C
		internal static bool conDataBtnTrkFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			int num;
			int featureSectionId;
			short num2;
			global::AcpBusinessLayer.AcpListField acpListField;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num)
				{
				case 0:
					if (featureSectionId != 10212)
					{
						num2 = (short)65863696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
					num2 = (short)1562902558;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (acpListField.Value == 140)
					{
						num2 = (short)567345164;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1566834713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (featureSectionId != 10209)
					{
						num2 = (short)864681988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
					num2 = (short)218759185;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)152109069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)698941472;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1209925632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)545325077;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_12E;
				case 7:
					if (featureSectionId <= 10212)
					{
						num2 = (short)1041104918;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)68616200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (featureSectionId != 10608)
					{
						num2 = (short)301465624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num2 = (short)1655504930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (index != 227)
					{
						goto IL_403;
					}
					return false;
				case 10:
					goto IL_30B;
				case 11:
					goto IL_41C;
				case 12:
					goto IL_5B3;
				case 13:
					num2 = (short)1011941411;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)32309254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)593494036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_49A;
				case 16:
					num2 = (short)944504847;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_49A;
				case 18:
					if (acpListField != null)
					{
						num2 = (short)550043653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 19:
					goto IL_49A;
				case 20:
					if (index != 227)
					{
						num2 = (short)370147361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 21:
					if (acpListField.Value == 227)
					{
						num2 = (short)624754698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1456472065;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)628097026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)924319763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)749600796;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
				{
					if (acpListField.Value != 228)
					{
						num2 = (short)2108489731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1914313711;
					short num3 = num2;
					num2 = (short)1413815279;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_403;
					default:
						num2 = (short)944177152;
						if (num2 != 0)
						{
						}
						num2 = (short)1527382043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 26:
					goto IL_209;
				case 27:
					num2 = (short)1410727950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (featureSectionId != 10713)
					{
						num2 = (short)406650903;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
					num2 = (short)286195741;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_49A;
				case 30:
					goto IL_49A;
				case 31:
					num2 = (short)1603600393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (index != 227)
					{
						num2 = (short)902889498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 33:
					goto IL_642;
				case 34:
					goto IL_49A;
				case 35:
					if (index != 228)
					{
						num2 = (short)1996947487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_A0;
				IL_403:
				num2 = (short)1960509451;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_49A:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1879179282;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12E:
			num2 = (short)13697025;
			if (num2 != 0)
			{
			}
			return index == 228;
			IL_209:
			return index != 140;
			IL_30B:
			num2 = (short)1446248448;
			short num4 = num2;
			return index == 227;
			IL_41C:
			return index != 140;
			IL_5B3:
			return index == 140;
			IL_642:
			return index != 140;
			IL_A0:
			acpListField = null;
			featureSectionId = self.FeatureSectionId;
			num2 = (short)580386823;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x00781564 File Offset: 0x0077F764
		public static void ConSynSirenPAtoShepherd(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)216268801;
			if (num != 0)
			{
			}
			num = (short)563544064;
			short num2 = num;
			global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
			try
			{
				num = (short)812580868;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner signalIndependentProductIndependentNonProgrammableButtonListInner;
					switch (num3)
					{
					case 0:
						goto IL_137;
					case 1:
						goto IL_1FB;
					case 2:
						num = (short)1817706497;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1987994804;
						short num4 = num;
						num = (short)747398324;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
							num = (short)1002897408;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					case 5:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, pasirenButtonsListInnerSection.CHO9PASirenButtonsFeature_A41540.Value));
						num = (short)868614147;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (signalIndependentProductIndependentNonProgrammableButtonListInner.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == pasirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value)
						{
							num = (short)1061617669;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					goto IL_CA;
					IL_137:
					if (!enumerator.MoveNext())
					{
						num = (short)55377922;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					signalIndependentProductIndependentNonProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInner)enumerator.Current;
					num = (short)1744699398;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)674562048;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_CA:
					goto IL_120;
				}
				IL_1FB:;
			}
			finally
			{
				num = (short)921632770;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1447690241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_262;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_22E;
						}
						continue;
					}
					IL_22E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)474808320;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_262:;
			}
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x007817F4 File Offset: 0x0077F9F4
		public static bool ConPASirenFeatureIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)719912960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection pasirenButtonsListInnerSection;
				bool flag2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_3AB;
					case 1:
						num = (short)944701459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)887554048;
						short num3 = num;
						num = (short)65273868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_26C;
					case 4:
						num = (short)743571464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4E5;
					case 6:
						if (index != 202)
						{
							num = (short)1852112899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						if (flag)
						{
							num = (short)814940164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
					{
						num = (short)1018658005;
						short num4 = num;
						num = (short)1420786901;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_435;
						default:
							num = (short)1828126720;
							if (num != 0)
							{
							}
							if (index != 200)
							{
								num = (short)1937702912;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					case 9:
						num = (short)393805835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (flag)
						{
							num = (short)399900687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						if (index != 203)
						{
							num = (short)937361421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						if (index != 228)
						{
							num = (short)1065811993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						goto IL_1C7;
					case 14:
					{
						if (index == 35)
						{
							num = (short)1753415685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = pasirenButtonsListInnerSection.CHO9PASirenButtonsBCO_A41538.Value;
						num = (short)1729167378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1426391060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (flag2)
						{
							num = (short)698810394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						goto IL_4A7;
					case 18:
					{
						int value;
						switch (value)
						{
						case 112:
							num = (short)1748566023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 113:
							goto IL_435;
						case 114:
							num = (short)1498677269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 115:
							num = (short)1342636055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 116:
							goto IL_287;
						case 117:
							num = (short)874774544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)167772161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						return true;
					case 20:
						if (index != 201)
						{
							num = (short)1003159569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						if (flag)
						{
							num = (short)498139158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 22:
						num = (short)646709254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (flag2)
						{
							num = (short)761462793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
						if (index != 38)
						{
							num = (short)701169665;
							if (num != 0)
							{
							}
							num = (short)624689154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 25:
						num = (short)1867644942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_185;
					}
					goto IL_9B;
					IL_435:
					num = (short)678821898;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_185:
				return index == 199;
				IL_1C7:
				return index == 224;
				IL_26C:
				return index == 223;
				IL_287:
				return index == 204;
				IL_3AB:
				return index == 225;
				IL_4A7:
				return index == 222;
				IL_4E5:
				return true;
				IL_9B:
				pasirenButtonsListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtonsListInnerSection);
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
				flag = (radioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.Value == 2);
				flag2 = !radioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
				num = (short)1209466904;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x00781D2C File Offset: 0x0077FF2C
		internal static bool ConDirectionalLightBarFeatureisValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection;
			if (index == 207)
			{
				short num = (short)337308666;
				short num2 = num;
				num = (short)765783034;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)967507968;
					short num3 = num;
					num = (short)1775763456;
					if (num != 0)
					{
					}
					num = (short)358154241;
					if (num != 0)
					{
					}
					return directionalButtonsListInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				}
				}
			}
			return true;
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x00781E00 File Offset: 0x00780000
		public static void ConSetDirectionalButtonIndex(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1508704260;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection directionalButtonsListInnerSection;
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_13A;
				case 2:
					directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarIndex_A36601.ResetToDefaultWithUndo(task);
					num = (short)1761214464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2065201138;
					short num3 = num;
					num = (short)1261533170;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13A;
					default:
						num = (short)159907841;
						if (num != 0)
						{
						}
						num = (short)771424256;
						if (num != 0)
						{
						}
						directionalButtonsListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection);
						num = (short)1145700353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
				{
					num = (short)130744320;
					short num4 = num;
					num = (short)1219821571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_13A:
				if (directionalButtonsListInnerSection.RadErgCtrlHeadO9DirLightBarFeature_A36597.Value == 207)
				{
					break;
				}
				num = (short)1678770178;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x00781F78 File Offset: 0x00780178
		internal static bool conDataBtnConvFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						goto IL_150;
					}
					return true;
				case 1:
					return false;
				case 2:
					num2 = (short)66715648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)585039876;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (index == 140)
					{
						num2 = (short)1671364609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (radioWide != null)
					{
						num2 = (short)655452281;
						short num3 = num2;
						num2 = (short)1168271481;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_150;
						case 1:
							break;
						default:
						{
							num2 = (short)1127022592;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)374210560;
						if (num2 != 0)
						{
						}
						num2 = (short)594608130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
				IL_150:
				num2 = (short)1607860225;
				if (num2 != 0)
				{
				}
				num2 = (short)1692532739;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_28:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)48168965;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x0078211C File Offset: 0x0078031C
		internal static bool ConStandaloneRadioSystemEnableApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1345082166;
			short num2 = num;
			num = (short)1217483574;
			switch (num2 == num)
			{
			}
			num = (short)15859712;
			short num3 = num;
			num = (short)640024577;
			if (num != 0)
			{
			}
			num = (short)765657088;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x007821FC File Offset: 0x007803FC
		internal static bool ConStandaloneRadioSystemEnableEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1915556797;
			short num2 = num;
			num = (short)1252070333;
			switch (num2 == num)
			{
			}
			num = (short)352518144;
			short num3 = num;
			num = (short)202440704;
			if (num != 0)
			{
			}
			num = (short)1088028673;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x007822DC File Offset: 0x007804DC
		internal static bool ConControlHeadEmergencyFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)745209856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				bool result;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection o9InnerSection;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						if (index != 138)
						{
							num = (short)817496100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1019150351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (index - 290 > 1)
						{
							num = (short)1239941142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)1283129369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (index != 140)
						{
							num = (short)1788739588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (radWideDualRadioSelection_A.Value != 0);
						num = (short)1422000141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radWideDualRadioSelection_A.Value == 1)
						{
							num = (short)1506410529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 4:
						num = (short)2064252949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return result;
					case 6:
						num = (short)2090401793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1990983681;
						if (num != 0)
						{
						}
						flag = true;
						goto IL_48B;
					case 8:
						num = (short)1022296093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)1316487179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_238;
					case 10:
						return result;
					case 11:
						num = (short)1281622040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						flag2 = true;
						goto IL_61C;
					case 13:
						return result;
					case 14:
						num = (short)463142930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)615972148;
							short num3 = num;
							num = (short)1538456884;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							case 1:
								break;
							default:
							{
								num = (short)1303969792;
								short num4 = num;
								break;
							}
							}
							num = (short)288948224;
							if (num != 0)
							{
							}
							num = (short)542179336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1986527259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1383923740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1636892702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (index - 124 > 2)
						{
							num = (short)1140064290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (radWideDualRadioSelection_A.Value == 0);
						num = (short)22151199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (o9InnerSection.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
						{
							num = (short)1303511057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 20:
						return result;
					case 21:
						if (index != 163)
						{
							num = (short)1386348550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1655046153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)181469207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return result;
					case 24:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1702428698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)386793484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						return result;
					case 26:
						goto IL_238;
					case 27:
						flag3 = false;
						goto IL_3F6;
					case 28:
						if (index != 31)
						{
							num = (short)268697614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1052246019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						flag3 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_3F6;
					case 30:
						flag = !o9InnerSection.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.Value;
						goto IL_48B;
					case 31:
						return result;
					case 32:
						return result;
					case 33:
						num = (short)1207042067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)321978368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (index <= 138)
						{
							num = (short)479985680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)682754050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)914817029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						flag2 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_61C;
					}
					goto IL_C7;
					IL_238:
					num = (short)715522085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num = (short)2107441159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F6:
					result = flag3;
					num = (short)2116026400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_48B:
					result = flag;
					num = (short)513671178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61C:
					result = flag2;
					num = (short)2113339412;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C7:
				o9InnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = o9InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radWideDualRadioSelection_A = o9InnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				radErgoWideControlHeadMultiControlHead_A = o9InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				result = true;
				num = (short)741539875;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
