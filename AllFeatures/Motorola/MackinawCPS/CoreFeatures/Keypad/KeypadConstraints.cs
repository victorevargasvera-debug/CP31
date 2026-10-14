using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x020002FB RID: 763
	public static class KeypadConstraints
	{
		// Token: 0x06007AAD RID: 31405 RVA: 0x006FAB80 File Offset: 0x006F8D80
		public static void ConSyncKeypadtoShepherd(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)340918272;
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
				int index;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
				global::AcpBusinessLayer.AcpListField radErgCtrlKeypadGeneralKeypadButtonFeature_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						bool flag = false;
						index = -1;
						enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
						num = (short)1845100544;
						short num3 = num;
						num = (short)1612185601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)354877442;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)46333953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_51F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3F8;
									}
									continue;
								case 3:
								{
									for (;;)
									{
										num = (short)278290391;
										short num4 = num;
										num = (short)827678679;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_4C5;
										}
									}
									IL_4C5:
									num = (short)1495990272;
									if (num != 0)
									{
									}
									bool flag = true;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									index = relayPatternBCOListListInner.Position - 1;
									num = (short)680984582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									if (relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value)
									{
										num = (short)1408499715;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)423297024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)898564100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_501;
								}
								IL_452:
								num = (short)1984364549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3F8:
								goto IL_452;
							}
							IL_501:
							IL_51F:
							goto IL_110;
						}
						finally
						{
							num = (short)1776418818;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1476526081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_58E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_557;
									}
									continue;
								}
								IL_557:
								if (enumerator == null)
								{
									break;
								}
								num = (short)987561984;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_58E:;
						}
						goto Block_5;
						IL_110:
						num = (short)624099332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_591;
					case 3:
						goto IL_148;
					case 4:
					{
						bool flag;
						if (flag)
						{
							num = (short)2033713155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A1;
					}
					case 5:
						if (radErgCtrlKeypadGeneralKeypadButtonFeature_A.Value == 207)
						{
							num = (short)1578041344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_739;
					case 6:
						goto IL_759;
					}
					goto IL_4A;
					Block_5:
					try
					{
						IL_591:
						num = (short)1606615046;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(signalIndependentProductIndependentProgrammableButtonListInner.SignalIndependentProductIndependentProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonFeature_A19758, radErgCtrlKeypadGeneralKeypadButtonFeature_A.Value));
								num = (short)1639645188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)1378877443;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)153878529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner)enumerator.Current;
								num = (short)1526136837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_6C7;
							case 4:
								goto IL_60A;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInner signalIndependentProductIndependentProgrammableButtonListInner;
								if (signalIndependentProductIndependentProgrammableButtonListInner.SignalIndependentProductIndependentProgrammableButtonListInnerSection.RadErgoCfgSignalIndependentProductIndependentProgrammableButtonBCO_A19757.Value == keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value)
								{
									num = (short)376897536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_5D3;
								}
								continue;
							}
							IL_670:
							num = (short)1727397890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_5D3:
							goto IL_670;
						}
						IL_60A:
						IL_6C7:
						goto IL_14D;
					}
					finally
					{
						num = (short)1734213634;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1752236033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_736;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_6FF;
								}
								continue;
							}
							IL_6FF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)69140480;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_736:;
					}
					goto IL_739;
					IL_14D:
					relayPatternBCOListListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset);
					num = (short)1697841157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_739:
					enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
					num = (short)2013265926;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A1:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(relayPatternBCOListListInnerRecset.CreateDefaultRecord()));
				int index2 = relayPatternBCOListListInnerRecset.Count - 1;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2 = relayPatternBCOListListInnerRecset[index2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661, keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value));
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue));
				return;
				IL_148:
				IL_382:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner3 = relayPatternBCOListListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner3.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue));
				return;
				IL_759:
				try
				{
					num = (short)1680211970;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1837694982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner4 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
							num = (short)1403584516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_2E9;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1FF;
							}
							continue;
						case 3:
						{
							keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.ResetToDefaultWithUndo(task);
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner4;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(relayPatternBCOListListInner4));
							num = (short)299106309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner4;
							if (relayPatternBCOListListInner4.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value)
							{
								num = (short)1461714947;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_28F;
						case 6:
							num = (short)572456961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_294:
						num = (short)2009399296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1FF:
						goto IL_294;
					}
					IL_28F:
					IL_2E9:
					return;
				}
				finally
				{
					num = (short)1626669056;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_321;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)10813442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_356;
						}
						IL_321:
						if (enumerator == null)
						{
							goto IL_381;
						}
						num = (short)1930493953;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_356:
					num = (short)1537277953;
					if (num != 0)
					{
					}
					IL_381:;
				}
				goto IL_382;
				IL_4A:
				keypadButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection);
				radErgCtrlKeypadGeneralKeypadButtonFeature_A = keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071;
				enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10029].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentProgrammableButtonListInnerRecset).GetEnumerator();
				num = (short)841613314;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x006FB38C File Offset: 0x006F958C
		internal static bool ConIsKeypadFeatureValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)120717312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_F6;
				}
				global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (index != 90)
						{
							num = (short)870580243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ADB;
					case 1:
						if (index != 223)
						{
							num = (short)1571618861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						num = (short)1554972687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (index != 207)
						{
							num = (short)404226097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (radErgoWidePASirenSirenOperation_A.Value == 2)
						{
							num = (short)1561788463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						switch (index)
						{
						case 134:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1684340750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							goto IL_FC8;
						case 136:
							goto IL_14F5;
						case 137:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)333512738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1521680416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
						try
						{
							num = (short)906887173;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)1772617730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1303;
								case 2:
									goto IL_1257;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 11)
									{
										num = (short)139788288;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1751842822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1283915779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_123D;
									}
									continue;
								case 6:
									num = (short)136708097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_125C:
								num = (short)1797783556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_123D:
								goto IL_125C;
							}
							IL_1257:
							return result;
							IL_1303:
							goto IL_155D;
						}
						finally
						{
							num = (short)1464532993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1374;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_133C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1363542016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_133C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)353959938;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1374:;
						}
						goto Block_26;
						IL_155D:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)930480174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)477954061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)130482219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						switch (index)
						{
						case 222:
						case 223:
						case 225:
							goto IL_AD1;
						case 224:
							goto IL_8E9;
						case 226:
							goto IL_ADB;
						default:
							num = (short)1534328839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 10:
						if (index != 224)
						{
							num = (short)61669376;
							short num3 = num;
							num = (short)1705771020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						num = (short)1259012122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)39518241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_E43;
					case 14:
						try
						{
							num = (short)916127753;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 11)
									{
										num = (short)436011014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5F2;
								}
								case 1:
									goto IL_60D;
								case 2:
									num = (short)1756102656;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_5F2;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)1298989059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 10)
									{
										num = (short)576061442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5F2;
								}
								case 6:
									num = (short)718864388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1786970122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1151533061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_721;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_5A5;
									}
									continue;
								case 10:
									num = (short)1431044104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5A5;
								IL_5F2:
								result = true;
								num = (short)1119485953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_612:
								num = (short)948174855;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A5:
								goto IL_612;
							}
							IL_60D:
							return result;
							IL_721:
							goto IL_AE5;
						}
						finally
						{
							num = (short)900792321;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_792;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_758;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)753205248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_758:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1625489410;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_792:;
						}
						goto IL_795;
						IL_AE5:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)376963114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (index != 90)
						{
							num = (short)1021509663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						num = (short)1576992812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1680343041;
						if (num != 0)
						{
						}
						num = (short)4194313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (index != 226)
						{
							num = (short)2037514268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
						num = (short)408027156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (index != 96)
						{
							num = (short)1430388763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E9;
					case 21:
						goto IL_1377;
					case 22:
						num = (short)182190081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (index != 137)
						{
							num = (short)920977416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 24:
						num = (short)1963720714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1834221591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (index != 96)
						{
							num = (short)811401240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 27:
						num = (short)2084765733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)526712835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (index != 135)
						{
							num = (short)1567752208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 30:
						goto IL_A62;
					case 31:
						num = (short)1996554258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)54329379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (index != 225)
						{
							num = (short)1507786774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 34:
						try
						{
							num = (short)1034485765;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)2079719426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_111F;
								case 2:
									goto IL_1073;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)1804599296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)114098182;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1191968771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1057;
									}
									continue;
								case 6:
									num = (short)1197211649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1078:
								num = (short)1583218692;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1057:
								goto IL_1078;
							}
							IL_1073:
							return result;
							IL_111F:
							goto IL_8AB;
						}
						finally
						{
							num = (short)927662081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_118F;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1156;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1922433024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1156:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1997340674;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_118F:;
						}
						return false;
						IL_8AB:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)255983664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (index != 207)
						{
							num = (short)169672721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_795;
					case 36:
						if (keypadButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num = (short)2091384843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_513;
					case 37:
						goto IL_A3B;
					case 38:
						goto IL_28A;
					case 39:
						if (index != 222)
						{
							num = (short)592379906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 40:
						if (index <= 96)
						{
							num = (short)159514665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)392167429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)562561024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_B05;
					case 43:
						if (index == 134)
						{
							num = (short)1318584358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_513;
					case 44:
						if (index != 136)
						{
							num = (short)1761542169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 45:
						goto IL_DEA;
					case 46:
						try
						{
							num = (short)369688581;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)923009025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_F55;
								case 2:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 11)
									{
										num = (short)1319829508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)661323776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1285816322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									result = true;
									num = (short)1122435078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E8B;
									}
									continue;
								case 6:
									goto IL_EFA;
								}
								IL_EFF:
								num = (short)918683651;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E8B:
								goto IL_EFF;
							}
							IL_EFA:
							return result;
							IL_F55:
							return false;
						}
						finally
						{
							num = (short)1518206977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FC5;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F8D;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)231014400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F8D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1113915394;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FC5:;
						}
						goto IL_FC8;
					case 47:
						goto IL_926;
					case 48:
						try
						{
							num = (short)833224709;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)367788033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_D2E;
								case 2:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
									{
										num = (short)1838940164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)716374016;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1360723970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									result = true;
									num = (short)871890950;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_C62;
									}
									continue;
								case 6:
									goto IL_CD1;
								}
								IL_CD6:
								num = (short)1217724419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C62:
								goto IL_CD6;
							}
							IL_CD1:
							return result;
							IL_D2E:
							return false;
						}
						finally
						{
							num = (short)341901313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_DE7;
								case 1:
								{
									num = (short)1041100334;
									short num4 = num;
									num = (short)2092101166;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_DCB;
									default:
										num = (short)1674182656;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_DB0;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_DCB;
								}
								IL_DB0:
								if (enumerator != null)
								{
									num = (short)436994050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_DCB:
								enumerator.Dispose();
								num = (short)1522401280;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DE7:;
						}
						goto IL_DEA;
					case 49:
						num = (short)1157365789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F6;
					IL_513:
					num = (short)825098280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E9:
					num = (short)1357971460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_26:
					try
					{
						IL_1377:
						num = (short)967376900;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)67239937;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1506213890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								num = (short)2050621445;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 10)
								{
									num = (short)1214906374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_1463;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_13BA;
								}
								continue;
							case 5:
								goto IL_1482;
							case 6:
								result = true;
								num = (short)719847427;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_140D:
							num = (short)796065792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_13BA:
							goto IL_140D;
						}
						IL_1463:
						return result;
						IL_1482:
						goto IL_A40;
					}
					finally
					{
						num = (short)931790850;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1200685057;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_14F2;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_14BA;
								}
								continue;
							}
							IL_14BA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)399572992;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_14F2:;
					}
					goto IL_14F5;
					IL_A40:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)1811021854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DEA:
					num = (short)96534567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC8:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)1372520469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14F5:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)937820166;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_28A:
				return true;
				IL_795:
				return keypadButtonInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				IL_926:
				return !keypadButtonInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
				IL_A3B:
				return true;
				IL_A62:
				try
				{
					num = (short)769785860;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							result = true;
							num = (short)853671938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)219086851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)367067142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_15DF;
						case 3:
							num = (short)140050437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_15C5;
							}
							continue;
						case 5:
							goto IL_168B;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 10)
							{
								num = (short)1377107968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_1637:
						num = (short)1525350401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_15C5:
						goto IL_1637;
					}
					IL_15DF:
					return result;
					IL_168B:
					return false;
				}
				finally
				{
					num = (short)1196425218;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)39583745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_16FB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_16C2;
							}
							continue;
						}
						IL_16C2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1266876416;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_16FB:;
				}
				return result;
				IL_AD1:
				return radErgoWidePASirenSirenOperation_A.Value == 2;
				IL_ADB:
				return radErgoWidePASirenSirenOperation_A.Value != 0;
				IL_B05:
				try
				{
					num = (short)1360592903;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_49F;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 10)
							{
								num = (short)445448200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CA;
						}
						case 2:
							goto IL_3CA;
						case 3:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1915027460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)109445121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1859387392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_3E5;
						case 6:
							num = (short)1602945033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_324;
							}
							continue;
						case 8:
							num = (short)443219978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
							{
								num = (short)1987248130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 11)
							{
								num = (short)1530200070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3CA;
						}
						}
						goto IL_324;
						IL_3CA:
						result = true;
						num = (short)492371973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3EA:
						num = (short)1518731267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_324:
						goto IL_3EA;
					}
					IL_3E5:
					return result;
					IL_49F:
					return false;
				}
				finally
				{
					num = (short)1898708993;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_50E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_4D7;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)2057240576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_4D7:
						if (enumerator == null)
						{
							break;
						}
						num = (short)197656578;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_50E:;
				}
				return false;
				IL_E43:
				return true;
				IL_F6:
				keypadButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection);
				radErgoWidePASirenSirenOperation_A = keypadButtonInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139;
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
				hashSet.Add(115);
				hashSet.Add(116);
				hashSet.Add(117);
				hashSet.Add(118);
				hashSet.Add(169);
				hashSet.Add(170);
				hashSet.Add(171);
				hashSet.Add(172);
				hashSet.Add(173);
				hashSet.Add(174);
				hashSet.Add(175);
				hashSet.Add(176);
				hashSet.Add(177);
				num = (short)674889764;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x006FCB60 File Offset: 0x006FAD60
		public static bool ConIsKeypadIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1332150272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)1288110086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_A4;
					case 2:
						goto IL_F7;
					case 3:
					{
						num = (short)235667456;
						short num3 = num;
						flag = true;
						num = (short)1314914305;
						if (num != 0)
						{
						}
						num = (short)1279328257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (keypadButtonInnerSection.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value || flag)
						{
							num = (short)454361090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (radioWideRecset != null)
						{
							num = (short)400621575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					case 6:
					{
						num = (short)576545462;
						short num4 = num;
						num = (short)837247670;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B3;
						default:
						{
							num = (short)1445789696;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
							if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
							{
								num = (short)1965817859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A4;
						}
						}
						break;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1046872072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1523122176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4;
					}
					}
					goto IL_53;
					IL_A4:
					keypadButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection);
					num = (short)628621316;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F7:
				IL_1B3:
				return keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Value == 207;
				IL_53:
				self.ParentRecset.CalculateValidity();
				flag = false;
				radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				num = (short)738852869;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x006FCDCC File Offset: 0x006FAFCC
		public static bool ConIsKeypadIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1513750528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_364;
					case 1:
					{
						if (index <= 0)
						{
							num = (short)655753218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset).GetEnumerator();
						num = (short)80871424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_A7;
					}
					goto IL_3C;
				}
				IL_A7:
				num = (short)874905600;
				short num3 = num;
				return false;
				IL_364:
				int value;
				try
				{
					num = (short)1589116933;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)353566723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner;
							if (keypadButtonInner.KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.Value == index)
							{
								num = (short)417005575;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner;
							if (self.Parent != keypadButtonInner)
							{
								num = (short)1890582538;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_27B;
						case 4:
							num = (short)2038628353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_128;
							}
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner;
							if (keypadButtonInner.KeypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Value == value)
							{
								num = (short)656867332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							result = false;
							num = (short)706674697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1030881280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner keypadButtonInner = (global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInner)enumerator.Current;
							num = (short)1085603842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_142;
						case 10:
							num = (short)591790086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_147:
						num = (short)1314127880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_128:
						goto IL_147;
					}
					IL_142:
					return result;
					IL_27B:
					return true;
				}
				finally
				{
					num = (short)2078408705;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_2EB;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2B3;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)868089856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2B3:
						if (enumerator != null)
						{
							num = (short)404226050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2EB:
						num = (short)930399637;
						short num4 = num;
						num = (short)2138490261;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_31F;
						}
					}
					IL_31F:
					num = (short)650575872;
					if (num != 0)
					{
					}
				}
				return false;
				IL_3C:
				num = (short)1008992257;
				if (num != 0)
				{
				}
				value = (self as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.Value;
				num = (short)627965953;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x006FD160 File Offset: 0x006FB360
		public static void ConValueSetKeypadToDirLightingButtonsIndex(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)863633408;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection keypadButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset).GetEnumerator();
			try
			{
				num = (short)1385365509;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)1026686977;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10621] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection).RdEgoO9DirLtbarPatternBcoListIndex_A36707, keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadButtonIndex_41415.UIValue));
						num = (short)796655619;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)521666566;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
						num = (short)1005322244;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1BE;
					case 3:
						goto IL_1A2;
					case 4:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if ((acpFeatureNode[10621] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerSection).RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == keypadButtonInnerSection.RadErgCtrlKeypadGeneralKeypadBCO_A41070.Value)
						{
							num = (short)1413808128;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 6:
						num = (short)1631715330;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_FD:
					num = (short)763297793;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_A3:
					goto IL_FD;
				}
				IL_1A2:
				IL_1BE:;
			}
			finally
			{
				num = (short)1326055425;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_228;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1F3;
						}
						continue;
					case 2:
						enumerator.Dispose();
						num = (short)1681981440;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1F3:
					if (enumerator != null)
					{
						num = (short)956039170;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_228:
					num = (short)1668939573;
					short num4 = num;
					num = (short)1605041973;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_25F;
					}
				}
				IL_25F:
				num = (short)2114912256;
				if (num != 0)
				{
				}
			}
		}
	}
}
