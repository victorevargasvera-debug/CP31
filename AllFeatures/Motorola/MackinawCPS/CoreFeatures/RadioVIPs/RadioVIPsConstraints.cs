using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpCommonLib;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002DE RID: 734
	public static class RadioVIPsConstraints
	{
		// Token: 0x060078BF RID: 30911 RVA: 0x006D9B18 File Offset: 0x006D7D18
		internal static bool ConNumOfDekBoxesIs0(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection radioVIPInnerSection;
			short num;
			for (;;)
			{
				radioVIPInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection);
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset).GetEnumerator();
				try
				{
					num = (short)723124225;
					if (num != 0)
					{
					}
					num = (short)1640628225;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						case 2:
							goto IL_119;
						case 3:
							num = (short)676134914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1499725827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10798] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).GCAIVipInputFeature_42623.CalculateValidity();
							num = (short)1986068480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_CD:
						num = (short)254476292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_96:
						goto IL_CD;
					}
					IL_119:;
				}
				finally
				{
					num = (short)2088960000;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_14C;
							}
							continue;
						case 1:
							goto IL_17F;
						case 2:
							enumerator.Dispose();
							num = (short)776863745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_14C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1290862594;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_17F:;
				}
				num = (short)1412497408;
				short num3 = num;
				num = (short)285382751;
				short num4 = num;
				num = (short)854628447;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1DF;
				}
			}
			IL_1DF:
			num = (short)1340342272;
			if (num != 0)
			{
			}
			return radioVIPInnerSection.RefDEK.General.DEKNumberofDEKBoxes_A8579.Value == 0;
		}

		// Token: 0x060078C0 RID: 30912 RVA: 0x006D9D44 File Offset: 0x006D7F44
		internal static bool ConNumOfDekBoxesIs0ForR4(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2059337728;
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
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection radioVIPInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset e5BottomFunctionButtonInnerRecset;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_526;
					case 1:
						try
						{
							num = (short)253755393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)518651908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10904] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection).E5BottomFunctionButtonFeature_43758.CalculateValidity();
									num = (short)1268318211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_215;
									}
									continue;
								case 2:
									goto IL_2A0;
								case 4:
									num = (short)1992818690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_217:
								num = (short)1023606784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_215:
								goto IL_217;
							}
							IL_2A0:
							goto IL_3CA;
						}
						finally
						{
							num = (short)2138439680;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
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
									goto IL_30E;
								case 2:
									enumerator.Dispose();
									num = (short)1635909633;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2D7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1513095170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_30E:;
						}
						goto IL_311;
						IL_3CA:
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)143458304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_34C;
					case 3:
						goto IL_6AB;
					case 4:
						if (radioVIPInnerSection.RefDEK.General.DEKNumberofDEKBoxes_A8579.Value == 0)
						{
							num = (short)1626603520;
							short num3 = num;
							num = (short)581566470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311;
					case 5:
						try
						{
							num = (short)735379457;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_42A;
									}
									continue;
								case 2:
									goto IL_4B4;
								case 3:
									num = (short)2126118914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1293025283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection).CHO9BottomFunctionButtonFeature_A36664.CalculateValidity();
									num = (short)754712576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_463:
								num = (short)121700356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_42A:
								goto IL_463;
							}
							IL_4B4:
							goto IL_350;
						}
						finally
						{
							num = (short)707198976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4EB;
									}
									continue;
								case 1:
									goto IL_523;
								case 2:
									enumerator.Dispose();
									num = (short)676724737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4EB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1340538882;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_523:;
						}
						goto Block_6;
						IL_350:
						enumerator = e5BottomFunctionButtonInnerRecset.GetEnumerator();
						num = (short)1977155585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1119027208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_311;
					case 8:
						if (radWideDualRadioSelection_A.Value == 2)
						{
							num = (short)1673396231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E3;
					case 9:
						if (radWideDualRadioSelection_A.Value == 2)
						{
							num = (short)107216898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_57;
					Block_7:
					try
					{
						IL_6AB:
						num = (short)2128805889;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_6E6;
								}
								continue;
							case 2:
								goto IL_771;
							case 3:
								num = (short)1134624770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)1438842883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.CalculateValidity();
								num = (short)1623851008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_71F:
							num = (short)864354308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6E6:
							goto IL_71F;
						}
						IL_771:
						goto IL_13B;
					}
					finally
					{
						num = (short)1010630656;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_7A8;
								}
								continue;
							case 1:
								goto IL_7E0;
							case 2:
								enumerator.Dispose();
								num = (short)1445199873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_7A8:
							if (enumerator == null)
							{
								break;
							}
							num = (short)388497410;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7E0:;
					}
					goto IL_7E3;
					IL_13B:
					num = (short)1417084932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_311:
					num = (short)1726611465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_526:
						num = (short)879230977;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)1837826052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.CalculateValidity();
								num = (short)905052163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_560;
								}
								continue;
							case 2:
								goto IL_638;
							case 4:
							{
								num = (short)275559659;
								short num4 = num;
								num = (short)808039659;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)2098987008;
									if (num != 0)
									{
									}
									break;
								}
								num = (short)1437728770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_562:
							num = (short)376897536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_560:
							goto IL_562;
						}
						IL_638:
						goto IL_1B5;
					}
					finally
					{
						num = (short)147652608;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_66F;
								}
								continue;
							case 1:
								goto IL_6A8;
							case 2:
								enumerator.Dispose();
								num = (short)1844445185;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_66F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)150077442;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_6A8:;
					}
					goto Block_7;
					IL_1B5:
					enumerator = keypadButtonInnerRecset.GetEnumerator();
					num = (short)828506115;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_34C:
				return radioVIPInnerSection.RadVipOutputFeature_A20947.Value == 20;
				IL_7E3:
				num = (short)794361857;
				if (num != 0)
				{
				}
				return true;
				IL_57:
				radioVIPInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection);
				radWideDualRadioSelection_A = radioVIPInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
				keypadButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset)[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
				e5BottomFunctionButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset)[0][10903].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset);
				enumerator = collection.GetEnumerator();
				num = (short)232980485;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060078C1 RID: 30913 RVA: 0x006DA5C0 File Offset: 0x006D87C0
		internal static bool ConRadioVIPOutputFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1559887872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_257;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection radioVIPInnerSection;
				int num6;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				bool value;
				bool result2;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					bool flag2;
					bool flag3;
					bool flag4;
					bool flag5;
					bool flag6;
					bool result;
					bool flag7;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1999306756;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1404436481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1120;
								case 2:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)1750466560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 14)
									{
										num = (short)961806344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1081;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (self.Parent != acpFeatureNode)
									{
										num = (short)265420807;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)90046474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)834076675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									int num3;
									num3++;
									num = (short)703922178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1422524422;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)2084765701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_11D2;
								}
								IL_1125:
								num = (short)1687093257;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1081:
								goto IL_1125;
							}
							IL_1120:
							IL_11D2:
							goto IL_EA9;
						}
						finally
						{
							num = (short)1860173824;
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
									enumerator.Dispose();
									num = (short)1824718850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1243;
								}
								IL_1209:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1660485633;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1243:;
						}
						goto Block_36;
						IL_EA9:
						num = (short)1757610022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)949813353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num4 = 0;
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)1248460843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						return false;
					case 4:
						goto IL_1917;
					case 5:
						if (index != 10)
						{
							num = (short)1179779101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 6:
						num = (short)1277034543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radWideDualRadioSelection_A.Value != 1)
						{
							num = (short)346161153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_787;
					case 8:
						goto IL_AAA;
					case 9:
						goto IL_17F2;
					case 10:
						if (index == 7)
						{
							num = (short)2009399372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3C;
					case 11:
						flag = false;
						goto IL_B53;
					case 12:
						flag = (index != 21);
						goto IL_B53;
					case 13:
						goto IL_787;
					case 14:
						goto IL_15EF;
					case 15:
						if (index != 12)
						{
							num = (short)723976252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 16:
						num = (short)576389176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_4C7;
					case 18:
						num = (short)1348075607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (radioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)229900323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C79;
					case 20:
						return false;
					case 21:
						try
						{
							num = (short)1055522818;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 14)
									{
										num = (short)816709635;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_16CC;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_167E;
									}
									continue;
								case 3:
								{
									int num3;
									num3++;
									num = (short)1821835268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)2085879813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)823590913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)2072707080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (!enumerator.MoveNext())
									{
										num = (short)1632043014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)299040768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_177F;
								}
								IL_16D1:
								num = (short)240320519;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_167E:
								goto IL_16D1;
							}
							IL_16CC:
							IL_177F:
							goto IL_943;
						}
						finally
						{
							num = (short)2113208320;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_17B7;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)422445058;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_17EF;
								}
								IL_17B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)735510529;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17EF:;
						}
						goto IL_17F2;
						IL_943:
						num = (short)696844320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (index != 6)
						{
							num = (short)1530134573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
					{
						if (index == 21)
						{
							num = (short)1406599185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1858535424;
						short num5 = num;
						num = (short)1340932220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						flag2 = false;
						goto IL_A90;
					case 25:
						flag3 = false;
						goto IL_BDE;
					case 26:
						flag4 = false;
						goto IL_14E2;
					case 27:
						flag5 = false;
						goto IL_B72;
					case 28:
						if (index == 20)
						{
							num = (short)1284964450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)333709369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1190264863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_2156;
					case 31:
						if (index != 11)
						{
							num = (short)327352350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 32:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)510001155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 33:
						goto IL_220B;
					case 34:
						switch (num6)
						{
						case 0:
							num = (short)728039476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)803930226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)809304144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1639710809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1554448478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)250740797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 35:
						num = (short)1847525472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (index != 4)
						{
							num = (short)575799367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 37:
						num = (short)1811808300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)1896087591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)709165077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						return false;
					case 40:
						num = (short)1912471575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1413087239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						switch (num6)
						{
						case 0:
							num = (short)1531445374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)887357556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)204537941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)201719875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)2122252310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)274858057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 43:
						try
						{
							num = (short)1276641284;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1659371525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (self.Parent != acpFeatureNode2)
									{
										num = (short)799997952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)417136646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1590624266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1DC0;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 13)
									{
										num = (short)574160905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_1F1D;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)247463938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)978780161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									int num4;
									if (num4 > 0)
									{
										num = (short)1647509507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									int num4;
									num4++;
									num = (short)1508704264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_1E34;
								}
								IL_1E85:
								num = (short)1637941255;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DC0:
								goto IL_1E85;
							}
							IL_1E34:
							IL_1F1D:
							goto IL_1D30;
						}
						finally
						{
							num = (short)717946881;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1F8C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1F54;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1199702016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F54:
								if (enumerator == null)
								{
									break;
								}
								num = (short)268566530;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F8C:;
						}
						goto Block_57;
						IL_1D30:
						num = (short)477954107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						flag5 = (index != 21);
						goto IL_B72;
					case 45:
						num = (short)466550872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)496369783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						flag4 = (radioVIPInnerSection.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value != 0);
						goto IL_14E2;
					case 48:
						flag2 = (index != 19);
						goto IL_A90;
					case 49:
						if (index != 2)
						{
							num = (short)614793348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 50:
						if (index != 16)
						{
							num = (short)657850486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 51:
						if (index != 18)
						{
							num = (short)356581491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 52:
						if (flag6)
						{
							num = (short)1743126565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)134742043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_18F7;
					case 54:
						num = (short)38010928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						try
						{
							num = (short)279773188;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 15)
									{
										num = (short)356909063;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)43909126;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)669515776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1095368712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									int num7;
									if (num7 > 0)
									{
										num = (short)2051997698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_5D0;
									}
									continue;
								case 5:
									goto IL_6D7;
								case 6:
									num = (short)870318085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									int num7;
									num7++;
									num = (short)1332543491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_65C;
								}
								IL_60B:
								num = (short)1011023873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5D0:
								goto IL_60B;
							}
							IL_65C:
							IL_6D7:
							goto IL_1462;
						}
						finally
						{
							num = (short)1752825856;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_70E;
									}
									continue;
								case 1:
									goto IL_747;
								case 2:
									enumerator.Dispose();
									num = (short)1822425089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_70E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)839122946;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_747:;
						}
						goto IL_74A;
					case 56:
						if (index != 19)
						{
							num = (short)515440737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E7;
					case 57:
						if (index != 0)
						{
							num = (short)824639613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 58:
						if (index != 9)
						{
							num = (short)953876589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 59:
					{
						int num4;
						if (num4 > 0)
						{
							num = (short)1970470932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)200147080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						num = (short)1679687730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)158531713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_FE9;
					case 63:
						if (index != 19)
						{
							num = (short)1895628930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 64:
						num = (short)792002693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)1856569471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1853030449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (index != 6)
						{
							num = (short)324796528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 68:
						flag4 = true;
						goto IL_14E2;
					case 69:
						goto IL_C3C;
					case 70:
					{
						int num7;
						if (num7 > 0)
						{
							num = (short)1431437394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 71:
						num = (short)1932328965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (index != 21)
						{
							num = (short)869597312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 73:
						num = (short)1882325061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						return false;
					case 75:
					{
						int num7;
						if (num7 > 0)
						{
							num = (short)306315338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1804927031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						goto IL_A8B;
					case 77:
						if (index != 7 && value)
						{
							num = (short)26476623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3C;
					case 78:
						goto IL_B8D;
					case 79:
						goto IL_E16;
					case 80:
						if (flag6)
						{
							num = (short)1323303003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF7;
					case 81:
						if (!radioVIPInnerSection.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedConsoletteEnable_A37231)
						{
							num = (short)46792745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_787;
					case 82:
						return false;
					case 83:
						num = (short)1578958947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (index != 20)
						{
							num = (short)1548615698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 85:
						if (index != 6)
						{
							num = (short)1988558931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 86:
						num = (short)1343291411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (index != 1)
						{
							num = (short)1950744642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 88:
						if (index == 7)
						{
							num = (short)1322516513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3C;
					case 89:
						if (flag6)
						{
							num = (short)1242562614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)806223896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (index != 19)
						{
							num = (short)1116078120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 91:
						num = (short)865992826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						if (index != 6)
						{
							num = (short)456523841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E16;
					case 93:
						num = (short)2134442061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						if (flag6)
						{
							num = (short)753336336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E7;
					case 95:
						num = (short)1821835300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						if (index != 0)
						{
							num = (short)485228650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C79;
					case 97:
						num = (short)778502156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						result = true;
						num = (short)683802705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (index == 7)
						{
							num = (short)1470759025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3C;
					case 100:
						if (index == 15)
						{
							num = (short)1508769896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)753401884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
					{
						int num4;
						if (num4 > 0)
						{
							num = (short)1341325446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 102:
						if (index != 3)
						{
							num = (short)2122317919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 103:
					{
						int num3 = 0;
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)77266944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
					{
						int num7 = 0;
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)1230831753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
						if (radWideDualRadioSelection_A.Value != 2)
						{
							num = (short)579469376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_787;
					case 106:
						return false;
					case 107:
						if (num6 == 4)
						{
							num = (short)1802764374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C79;
					case 108:
						if (index != 17)
						{
							num = (short)1699217525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191E;
					case 109:
						num = (short)266338376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						if (index == 13)
						{
							num = (short)703266818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)654639225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						goto IL_BF9;
					case 112:
						num = (short)1995046922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						goto IL_15B2;
					case 114:
						if (flag6)
						{
							num = (short)1366425609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C7;
					case 115:
						goto IL_74A;
					case 116:
						if (value)
						{
							num = (short)1557266552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 117:
						num = (short)317325363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						num = (short)776601708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						flag3 = (index != 21);
						goto IL_BDE;
					case 120:
						goto IL_22BE;
					case 121:
						if (index == 14)
						{
							num = (short)954269799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1238630500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						if (index != 19)
						{
							num = (short)431423534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF7;
					case 123:
						goto IL_B6D;
					case 124:
						flag7 = true;
						goto IL_FA8;
					case 125:
						num = (short)1898643540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (value)
						{
							num = (short)1651441678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 127:
						if (index != 7)
						{
							num = (short)1816199261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E16;
					case 128:
						num = (short)1054736515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						goto IL_4C2;
					case 130:
						num = (short)2045313082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
						if (index == 8)
						{
							num = (short)1814560774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)480378906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						num = (short)816709734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (radioVIPInnerSection.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911)
						{
							num = (short)432996365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F7;
					case 134:
						return false;
					case 135:
						flag7 = (index == 5);
						goto IL_FA8;
					case 136:
						goto IL_1F8F;
					case 137:
						goto IL_1246;
					}
					goto IL_257;
					Block_36:
					try
					{
						IL_1246:
						num = (short)479133700;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1140785157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								int num7;
								if (num7 > 0)
								{
									num = (short)1863319561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (self.Parent != acpFeatureNode3)
								{
									num = (short)1232863232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)103743496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
								num = (short)1312292866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_1299;
								}
								continue;
							case 5:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 15)
								{
									num = (short)1305673735;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								goto IL_1391;
							case 7:
							{
								int num7;
								num7++;
								num = (short)2010972161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								num = (short)591790090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)754057222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_13EF;
							}
							IL_1396:
							num = (short)962002947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1299:
							goto IL_1396;
						}
						IL_1391:
						IL_13EF:
						goto IL_38E;
					}
					finally
					{
						num = (short)251592704;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1427;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1287782402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_145F;
							}
							IL_1427:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1983184897;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_145F:;
					}
					goto IL_1462;
					IL_38E:
					num = (short)577241163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C7:
					num = (short)50462855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74A:
					num = (short)1733492799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_787:
					result = false;
					num = (short)1649213493;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E7:
					num = (short)251002891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A90:
					result2 = flag2;
					num = (short)441974792;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B53:
					result2 = flag;
					num = (short)2036531323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B72:
					result2 = flag5;
					num = (short)510722126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BDE:
					result2 = flag3;
					num = (short)1389101167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3C:
					num = (short)54984814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C79:
					num = (short)694091868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF7:
					num = (short)726269977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E16:
					num = (short)1633419306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA8:
					result2 = flag7;
					num = (short)1212678145;
					if (num != 0)
					{
					}
					num = (short)1798438974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1462:
					num = (short)711262278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14E2:
					flag6 = flag4;
					result2 = false;
					num = (short)919142434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_57:
					try
					{
						IL_1F8F:
						num = (short)791609346;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)717815816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_20E3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1FD9;
								}
								continue;
							case 3:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 13)
								{
									num = (short)599392263;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								num = (short)1466826753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								int num4;
								if (num4 > 0)
								{
									num = (short)1750597632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)1809907716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)691339267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								int num4;
								num4++;
								num = (short)880082949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 8:
								goto IL_2047;
							}
							IL_208B:
							num = (short)1673003014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1FD9:
							goto IL_208B;
						}
						IL_2047:
						IL_20E3:
						goto IL_15F4;
					}
					finally
					{
						num = (short)2006122497;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2153;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_211B;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)677052416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_211B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)54001666;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2153:;
					}
					goto IL_2156;
					IL_15F4:
					num = (short)53346405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17F2:
					num = (short)1675034714;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F7:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)1292632068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191E:
					num = (short)1655963716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2156:
					num = (short)764018703;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_4C2:
				return result2;
				IL_A8B:
				return false;
				IL_AAA:
				IL_B6D:
				IL_B8D:
				IL_BF9:
				return result2;
				IL_FE9:
				return result2;
				IL_15B2:
				return false;
				IL_15EF:
				return index == 6;
				IL_1917:
				try
				{
					num = (short)1524301826;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)1071120392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (self.Parent != acpFeatureNode4)
							{
								num = (short)1714946055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_1ACF;
							}
							continue;
						case 3:
							goto IL_1BC3;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((acpFeatureNode4[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 20)
							{
								num = (short)483721221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							result = false;
							num = (short)1887174659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)799604736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
							num = (short)1368719361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num = (short)1796669444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_1BE2;
						}
						IL_1B6B:
						num = (short)958922758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1ACF:
						goto IL_1B6B;
					}
					IL_1BC3:
					IL_1BE2:
					return result;
				}
				finally
				{
					num = (short)432144385;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1CA1;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1C1A;
							}
							continue;
						case 2:
							goto IL_1C80;
						}
						IL_1C1A:
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						if (enumerator == null)
						{
							break;
						}
						num = (short)35353618;
						short num8 = num;
						num = (short)947614738;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1916403712;
							if (num != 0)
							{
							}
							num = (short)1795686402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1C80:
						enumerator.Dispose();
						num = (short)819789824;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1CA1:;
				}
				IL_1CA4:
				return index == 7;
				IL_220B:
				return false;
				IL_22BE:
				goto IL_1CA4;
				IL_257:
				radioVIPInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection);
				radWideDualRadioSelection_A = radioVIPInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = radioVIPInnerSection.RadVipOutputFeature_A20947.Parent.Parent;
				radioVIPInnerSection.RadVipOutputFeature_A20947.CalculateApplicability();
				value = radioVIPInnerSection.RefRadioErgonomicsWide.Advanced.RadErgoWideMOSCADDataEnable_A8545.Value;
				num6 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)1499988075;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060078C2 RID: 30914 RVA: 0x006DC940 File Offset: 0x006DAB40
		internal static bool ConNumOfDekBoxesIs0Editbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1818045737;
			short num2 = num;
			num = (short)1574776105;
			switch (num2 == num)
			{
			default:
			{
				num = (short)90832896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)398458880;
			if (num != 0)
			{
			}
			num = (short)1562640385;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RefDEK.General.DEKNumberofDEKBoxes_A8579.Value == 0;
		}

		// Token: 0x060078C3 RID: 30915 RVA: 0x006DCA08 File Offset: 0x006DAC08
		internal static bool ConGCAIVIPInputFeatureSelectValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1089798144;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)986644487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (index == 27)
						{
							num = (short)793444360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)1898971138;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1357447173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									result = false;
									num = (short)1821376519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_668;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1245446152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)312213508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (self.Parent != acpFeatureNode)
									{
										num = (short)292093952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10798] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).GCAIVipInputFeature_42623.Value == 27)
									{
										num = (short)1211236353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_77D;
								case 7:
									goto IL_71F;
								case 8:
									num = (short)915275782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_724:
								num = (short)1325858819;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_668:
								goto IL_724;
							}
							IL_71F:
							return result;
							IL_77D:
							goto IL_916;
						}
						finally
						{
							num = (short)703528960;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_7B4;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1230766082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_7EB;
								}
								IL_7B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)465567745;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7EB:;
						}
						goto IL_7EE;
						IL_916:
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)2070413316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (radWideDualRadioSelection_A.Value != 1)
						{
							num = (short)295960586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						try
						{
							num = (short)1848115202;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipInputFeature_A21329.Value == 27)
									{
										num = (short)1447231495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (self.Parent != acpFeatureNode2)
									{
										num = (short)712572932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_497;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)60751880;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1464532993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)733544448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_4B4;
								case 6:
									goto IL_5AA;
								case 7:
									result = false;
									num = (short)684523525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)954925062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_551:
								num = (short)2125660163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_497:
								goto IL_551;
							}
							IL_4B4:
							return result;
							IL_5AA:
							goto IL_82C;
						}
						finally
						{
							num = (short)95682560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5E2;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1355808770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_619;
								}
								IL_5E2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1626865665;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_619:;
						}
						return true;
						IL_82C:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1302069254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)2113142785;
						if (num != 0)
						{
						}
						num = (short)178061312;
						short num3 = num;
						goto IL_7EE;
					}
					case 6:
						try
						{
							num = (short)451543042;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (self.Parent != acpFeatureNode3)
									{
										num = (short)1024524295;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)739049478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1624206360;
									short num4 = num;
									num = (short)1540123672;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_22E;
									default:
										num = (short)1868562432;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_216;
										}
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPInputFeature_A21338.Value == 27)
									{
										num = (short)322699272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_269;
								case 5:
									goto IL_22E;
								case 6:
									goto IL_329;
								case 7:
									num = (short)1810104323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									result = false;
									num = (short)693436420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_218:
								num = (short)677707781;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_216:
								goto IL_218;
								IL_22E:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1649213441;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1265762304;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_269:
							return result;
							IL_329:
							return true;
						}
						finally
						{
							num = (short)1925120000;
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
										goto IL_360;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1063845890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_39A;
								}
								IL_360:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1042677761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39A:;
						}
						goto IL_39D;
					case 7:
					{
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911)
						{
							num = (short)1467613198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = gcaivipinnerRecset.GetEnumerator();
						num = (short)1088159746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)303104013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!(global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide).Advanced.RadErgoWideAdvancedConsoletteEnable_A37231)
						{
							num = (short)786825221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						num = (short)1140326411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (radWideDualRadioSelection_A.Value != 2)
						{
							num = (short)767033344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						goto IL_39D;
					case 13:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection)
						{
							num = (short)1878523916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						goto IL_8EC;
					}
					goto IL_6B;
					IL_39D:
					num = (short)1932722185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EE:
					num = (short)255983619;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_8EC:
				return false;
				IL_6B:
				radWideDualRadioSelection_A = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				gcaivipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				num = (short)1647968257;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060078C4 RID: 30916 RVA: 0x006DD3A0 File Offset: 0x006DB5A0
		internal static bool conGCAIVipInputSelectIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
			short num;
			try
			{
				num = (short)608763907;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!enumerator.MoveNext())
						{
							num = (short)444727297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipInputFeature_A21329.CalculateValidity();
						num = (short)1368850436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)835387394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2CC;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_247;
						}
						continue;
					}
					IL_249:
					num = (short)534708224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					goto IL_249;
				}
				IL_2CC:
				goto IL_1D9;
			}
			finally
			{
				num = (short)593690625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)964427778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_301;
						}
						continue;
					case 2:
						goto IL_336;
					}
					IL_301:
					if (enumerator == null)
					{
						break;
					}
					num = (short)791805952;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_336:;
			}
			goto IL_339;
			for (;;)
			{
				IL_1D9:
				num = (short)1921187840;
				short num3 = num;
				enumerator = dekvipinnerRecset.GetEnumerator();
				try
				{
					num = (short)1391919107;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)113739513;
						short num4 = num;
						num = (short)1492551417;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2031616000;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_F8;
							case 1:
								num = (short)1260060674;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_16C;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_E1;
								}
								continue;
							}
							IL_E3:
							num = (short)241041408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E1:
							goto IL_E3;
						}
						IL_F8:
						if (!enumerator.MoveNext())
						{
							num = (short)1236467713;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPInputFeature_A21338.CalculateValidity();
							num = (short)1801256964;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_16C:
					break;
				}
				finally
				{
					num = (short)40239105;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1473839106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1A1;
							}
							continue;
						case 2:
							goto IL_1D6;
						}
						IL_1A1:
						if (enumerator == null)
						{
							break;
						}
						num = (short)734527488;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D6:;
				}
			}
			IL_339:
			num = (short)476512257;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x060078C5 RID: 30917 RVA: 0x006DD744 File Offset: 0x006DB944
		internal static bool conRadioVIPInputSelectionIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1325203456;
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
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				int num4;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection radioVIPInnerSection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)1423245312;
						short num3 = num;
						num = (short)138346517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (index == 27)
						{
							num = (short)1414397952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE;
					case 2:
						num = (short)2087321613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (index != 38)
						{
							num = (short)650182670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 4:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection)
						{
							num = (short)1141112857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 5:
						goto IL_538;
					case 6:
					{
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911)
						{
							num = (short)1719336968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = gcaivipinnerRecset.GetEnumerator();
						num = (short)1025769483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (radWideDualRadioSelection_A.Value != 2)
						{
							num = (short)9109519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_6E2;
					case 9:
						return false;
					case 10:
						num = (short)1018298387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						bool result;
						try
						{
							num = (short)412155911;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_867;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10798] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).GCAIVipInputFeature_42623.Value == 27)
									{
										num = (short)1286012934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (self.Parent != acpFeatureNode)
									{
										num = (short)727187459;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)417792001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1288568840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)508100610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_885;
								case 6:
									result = false;
									num = (short)400687104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_770;
									}
									continue;
								case 8:
									num = (short)711000069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_80E:
								num = (short)761921540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_770:
								goto IL_80E;
							}
							IL_867:
							return result;
							IL_885:
							goto IL_164;
						}
						finally
						{
							num = (short)1515847681;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1494941698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8BC;
									}
									continue;
								case 2:
									goto IL_8F7;
								}
								IL_8BC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1429340160;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8F7:;
						}
						return result;
						IL_164:
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)262144024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (num4 == 3)
						{
							num = (short)1235877905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 13:
						if (radWideDualRadioSelection_A.Value != 1)
						{
							num = (short)875036690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
						num = (short)820051990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1769603078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (index == 72)
						{
							num = (short)59572247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 17:
						num = (short)130875396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1199570951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (!(global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide).Advanced.RadErgoWideAdvancedConsoletteEnable_A37231)
						{
							num = (short)1020002306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 20:
						if (num4 != 4)
						{
							num = (short)297402373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection)
						{
							num = (short)1246756874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE;
					case 22:
						if (radioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)1929838601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B0;
					case 23:
						num = (short)1473052692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						try
						{
							num = (short)2020802567;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_404;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipInputFeature_A21329.Value == 27)
									{
										num = (short)959250438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (self.Parent != acpFeatureNode2)
									{
										num = (short)823132163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1873346561;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2005008392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1066688061;
									short num5 = num;
									num = (short)1097686589;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_404;
									default:
										num = (short)783613952;
										if (num != 0)
										{
										}
										num = (short)961675266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_421;
								case 6:
									result = false;
									num = (short)1267859456;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_2BC;
									}
									continue;
								case 8:
									num = (short)1544355845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A8:
								num = (short)106627076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2BC:
								goto IL_3A8;
							}
							IL_404:
							return result;
							IL_421:
							goto IL_1EE;
						}
						finally
						{
							num = (short)1454768129;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1316290562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_458;
									}
									continue;
								case 2:
									goto IL_490;
								}
								IL_458:
								if (enumerator == null)
								{
									break;
								}
								num = (short)787283968;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_490:;
						}
						return false;
					case 25:
						num = (short)62783491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
					IL_1B0:
					num = (short)1112211457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE:
					num = (short)2147155984;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_538:
				num = (short)1727856641;
				if (num != 0)
				{
				}
				return false;
				IL_6E2:
				return false;
				IL_96:
				radioVIPInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection);
				radWideDualRadioSelection_A = radioVIPInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				gcaivipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = radioVIPInnerSection.RadVipOutputFeature_A20947.Parent.Parent;
				num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)259063820;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
