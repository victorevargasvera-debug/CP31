using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.Keypad;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000320 RID: 800
	public static class DEKConstraints
	{
		// Token: 0x06007D33 RID: 32051 RVA: 0x0072AFE8 File Offset: 0x007291E8
		[global::ConstraintHelper.TriggerValidOnLoading]
		internal static bool ConDEKButtonFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_F0;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
			bool result;
			global::AcpBusinessLayer.AcpListField radErgoWidePASirenSirenOperation_A;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					if (index != 92)
					{
						num2 = (short)1858732039;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (index != 224)
					{
						num2 = (short)1354170422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (dekbuttonInnerSection.DEKChannel_A22565 != null)
					{
						num2 = (short)263979033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 3:
					if (index == 95)
					{
						num2 = (short)676266013;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CF;
				case 4:
					num2 = (short)570949663;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_34F;
				case 6:
					num2 = (short)1904869400;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1950482464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					switch (index)
					{
					case 89:
					case 91:
					case 92:
					case 94:
						goto IL_32D;
					case 90:
					case 95:
						goto IL_8DC;
					case 93:
					case 96:
						goto IL_6F8;
					default:
						num2 = (short)494075949;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 9:
					if (index != 91)
					{
						num2 = (short)1293287428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 10:
					if (!global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
					{
						num2 = (short)1081671735;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 11:
					goto IL_5BE;
				case 12:
					if (index != 140)
					{
						num2 = (short)2130444289;
						if (num2 != 0)
						{
						}
						num2 = (short)777453595;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = (dekbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0);
					num2 = (short)669646869;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					return result;
				case 14:
					if (index != 94)
					{
						num2 = (short)445775892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 15:
					if (dekbuttonInnerSection != null)
					{
						num2 = (short)1771831326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 16:
				{
					num2 = (short)1108694967;
					short num3 = num2;
					num2 = (short)917985207;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_32D;
					default:
						goto IL_419;
					}
					break;
				}
				case 17:
					num2 = (short)1065091075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1163788302;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (index != 96)
					{
						num2 = (short)461766690;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 20:
					num2 = (short)807534618;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_465;
				case 22:
					if (radErgoWidePASirenSirenOperation_A.Value == 2)
					{
						num2 = (short)1133707306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)661127209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)1335230474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
				{
					num2 = (short)1905197056;
					short num4 = num2;
					if (index != 89)
					{
						num2 = (short)187170868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 25:
					num2 = (short)1824915493;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (index != 223)
					{
						num2 = (short)1826291760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 27:
					num2 = (short)2103902257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					flag = !dekbuttonInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.Value;
					goto IL_3CA;
				case 29:
					return true;
				case 30:
					num2 = (short)988086274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (index != 90)
					{
						num2 = (short)1520828422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 32:
					if (index != 222)
					{
						num2 = (short)745144355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 33:
					if (index != 225)
					{
						num2 = (short)2146959378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 34:
					num2 = (short)254738433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					num2 = (short)1108279305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					num2 = (short)369492006;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (dekbuttonInnerSection.DEKChannel_A22565.ReferencedNode == null)
					{
						num2 = (short)524222500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 38:
					if (dekbuttonInnerSection.DEKChannel_A22565.UIValue != dekbuttonInnerSection.DEKChannel_A22565.InvalidText)
					{
						num2 = (short)1185742891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 39:
					num2 = (short)168886305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (index != 226)
					{
						num2 = (short)1405943825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 41:
					flag = false;
					goto IL_3CA;
				case 42:
					num2 = (short)2006122524;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)1389953068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
					{
						num2 = (short)291569687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 45:
					num2 = (short)733937676;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					num2 = (short)225705995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					if (index != 93)
					{
						num2 = (short)1459093543;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 48:
					num2 = (short)497745920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					switch (index)
					{
					case 222:
					case 223:
					case 225:
						goto IL_32D;
					case 224:
						goto IL_6F8;
					case 226:
						goto IL_8DC;
					default:
						num2 = (short)1088946222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 50:
					goto IL_20E;
				case 51:
					if (dekbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
					{
						num2 = (short)5636149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CF;
				case 52:
					num2 = (short)376373288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					num2 = (short)1481900051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					num2 = (short)1021837359;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					dekbuttonInnerSection.DEKChannel_A22565.ResetToDefaultWithUndo();
					num2 = (short)1659764786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_F0;
				IL_20E:
				num2 = (short)473104435;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CF:
				result = true;
				num2 = (short)190316552;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_32D:
				result = (radErgoWidePASirenSirenOperation_A.Value == 2);
				num2 = (short)1578434565;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3CA:
				result = flag;
				num2 = (short)1243938832;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6F8:
				num2 = (short)281083926;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_8DC:
				result = (radErgoWidePASirenSirenOperation_A.Value != 0);
				num2 = (short)427163661;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_34F:
			return result;
			IL_419:
			num2 = (short)1505689600;
			if (num2 != 0)
			{
			}
			IL_465:
			IL_5BE:
			return result;
			IL_F0:
			dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
			radErgoWidePASirenSirenOperation_A = dekbuttonInnerSection.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139;
			num2 = (short)1725890575;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x0072B8F8 File Offset: 0x00729AF8
		internal static bool ConNumOfDekBoxesAndFeatIsStsXOrMsgX(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)576258048;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1562968065;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_AD;
				}
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				int num3;
				global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)1513226247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_180;
					case 2:
						num = (short)1600716804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17B;
					case 4:
						if (num3 >= 0)
						{
							num = (short)1699217413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 5:
						num = (short)1463222283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)165806099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180;
					case 7:
						num = (short)143785997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num3 <= 23)
						{
							num = (short)1516503057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)1354956821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						IL_155:
						if (dekbuttonFeature_A.Value != 75)
						{
							num = (short)1837891587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
						if (num3 > 7)
						{
							num = (short)1637875732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					case 12:
						num = (short)1294073864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num3 >= 0)
						{
							num = (short)1254227980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 14:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)478019600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						if (num3 >= 0)
						{
							num = (short)1102774281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180;
					case 16:
						num = (short)1700200466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						num = (short)540278784;
						short num4 = num;
						goto IL_13B;
					}
					case 18:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)1711603714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 19:
						num = (short)1448869903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_32A;
					case 21:
						if (num3 > 15)
						{
							num = (short)1945370625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13B;
					}
					goto IL_AD;
					IL_13B:
					num = (short)2047672330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_180:
					num = (short)421701264;
					short num5 = num;
					num = (short)931309200;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						num = (short)653983744;
						if (num != 0)
						{
						}
						num = (short)729612288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_32A:
					num = (short)117374982;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17B:
				return dekbuttonFeature_A.Value == 76;
				IL_AD:
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				dekbuttonFeature_A = dekbuttonInnerSection.DEKButtonFeature_A21353;
				global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)380829710;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x0072BD3C File Offset: 0x00729F3C
		internal static bool ConNumOfDekBoxesAndFeatIsMode(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1277100032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				int num3;
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (num3 >= 0)
						{
							num = (short)386138132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					case 1:
						num = (short)391249921;
						if (num != 0)
						{
						}
						if (num3 <= 23)
						{
							num = (short)440991747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)738131981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					case 3:
						goto IL_3B0;
					case 4:
						if (num3 >= 0)
						{
							num = (short)642973715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					case 5:
						num = (short)1355939858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (num3 > 7)
						{
							num = (short)330432526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C;
					case 7:
						goto IL_10D;
					case 8:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)592576519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1279655957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)2098528267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1667891200;
						short num4 = num;
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)1462173701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)1973813265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					case 12:
						goto IL_26B;
					case 13:
						num = (short)9502724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2D5;
					case 15:
						if (num3 > 15)
						{
							num = (short)1204027404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21C;
					case 16:
						num = (short)675151873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_217;
					case 18:
					{
						num = (short)1155381913;
						short num5 = num;
						num = (short)1093843609;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_217;
						default:
							num = (short)151650304;
							if (num != 0)
							{
							}
							if (num3 >= 0)
							{
								num = (short)1579221008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 19:
						num = (short)1280114703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1386217478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1713176585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_88;
					IL_217:
					num = (short)1297088512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26B:
					num = (short)444071946;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D5:
					num = (short)874577922;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10D:
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
				dekbuttonInnerSection.DEKZone_A22566.Valid = true;
				dekbuttonInnerSection.DEKChannel_A22565.Valid = true;
				return false;
				IL_21C:
				return dekbuttonInnerSection.DEKButtonFeature_A21353.Value == 74;
				IL_3B0:
				goto IL_21C;
				IL_88:
				dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)1793851400;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x0072C198 File Offset: 0x0072A398
		internal static bool ConNumOfDekBoxesForDEKVIP(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1385889792;
			short num2 = num;
			num = (short)1565609282;
			short num3 = num;
			num = (short)1418546498;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_223:
				num = (short)923271180;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1719664640;
				if (num != 0)
				{
				}
				num = (short)130613248;
				num4 = (int)num;
				switch (num4)
				{
				default:
					num = (short)1377566721;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_10D;
					}
					break;
				}
				break;
			}
			int num5;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
			for (;;)
			{
				IL_C2:
				switch (num4)
				{
				case 0:
					goto IL_45D;
				case 1:
					if (num5 >= 0)
					{
						num = (short)431095823;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1923350533;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					try
					{
						num = (short)224657410;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								goto IL_3AF;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)1877147651;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10798] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).GCAIVipInputFeature_42623.CalculateValidity();
								num = (short)1295843332;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_325;
								}
								continue;
							case 3:
								num = (short)102760448;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_35E:
							num = (short)1411645441;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_325:
							goto IL_35E;
						}
						IL_3AF:
						goto IL_200;
					}
					finally
					{
						num = (short)931069952;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_3E6;
								}
								continue;
							case 1:
								goto IL_41E;
							case 2:
								enumerator.Dispose();
								num = (short)219414529;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_3E6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1089208322;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_41E:;
					}
					goto IL_421;
				case 4:
					num = (short)981139462;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (num5 > 2)
					{
						num = (short)34668544;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					if (num5 > 5)
					{
						num = (short)1342570504;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					num = (short)1094189070;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_183;
				case 9:
					if (num5 >= 0)
					{
						num = (short)1763049474;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45D;
				case 10:
					if (deknumberofDEKBoxes_A.Value == 3)
					{
						num = (short)546701325;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
					if (deknumberofDEKBoxes_A.Value == 2)
					{
						num = (short)1032126471;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 12:
					if (deknumberofDEKBoxes_A.Value == 1)
					{
						num = (short)1710293008;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_45D;
				case 13:
					goto IL_421;
				case 14:
					if (num5 >= 0)
					{
						num = (short)192544772;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 15:
					goto IL_458;
				case 16:
					num = (short)1856110601;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_10D;
				IL_183:
				num = (short)187891722;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_421:
				num = (short)1994588161;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_45D:
				num = (short)519372811;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_200:
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection dekvipinnerSection;
			global::AcpCommonLib.IAcpFeatureNode parent = dekvipinnerSection.DEKVIPName_A22574.Parent.Parent;
			num5 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
			goto IL_223;
			IL_458:
			return num5 <= 8;
			IL_10D:
			dekvipinnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection);
			deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
			enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset).GetEnumerator();
			num = (short)2062155779;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_C2;
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x0072C690 File Offset: 0x0072A890
		internal static bool ConDekFeatIndexPairUniqueConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool result;
			for (;;)
			{
				short num = (short)503840768;
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
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
							if (dekbuttonFeature_A.Value == 75)
							{
								num = (short)1474363400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_136;
						}
						case 1:
						{
							int num3;
							if (num3 > 1)
							{
								num = (short)1360068612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)649986058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							int num4 = 0;
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dekbuttonInnerRecset.GetEnumerator();
							num = (short)379781125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							int num4;
							if (num4 > 1)
							{
								num = (short)212402189;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_615;
						}
						case 4:
							result = false;
							num = (short)1262747657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_3E9;
						case 6:
							return result;
						case 7:
						{
							global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
							if (dekbuttonFeature_A.Value == 76)
							{
								num = (short)150405121;
								if (num != 0)
								{
								}
								num = (short)1043464194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 8:
						{
							int num3 = 0;
							global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dekbuttonInnerRecset.GetEnumerator();
							num = (short)1720844288;
							short num5 = num;
							num = (short)69140491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							goto IL_136;
						case 10:
							goto IL_136;
						case 11:
							try
							{
								num = (short)198377473;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1159004167;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_211;
										}
										continue;
									case 2:
										goto IL_376;
									case 3:
										num = (short)747110408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										int num3;
										if (num3 > 1)
										{
											num = (short)672595968;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonFeature_A21353.Value == 75)
										{
											num = (short)1324285955;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)590086154;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)1329004549;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										goto IL_359;
									case 8:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										int value;
										if ((acpFeatureNode[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonIndex_A22570.Value == value)
										{
											num = (short)1217593353;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										int num3;
										num3++;
										num = (short)1417478148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										num = (short)1247543298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_302:
									num = (short)1307508742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_211:
									goto IL_302;
								}
								IL_359:
								IL_376:
								goto IL_654;
							}
							finally
							{
								num = (short)1709572097;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										enumerator.Dispose();
										num = (short)1595670530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_3AE;
										}
										continue;
									case 2:
										goto IL_3E6;
									}
									IL_3AE:
									if (enumerator == null)
									{
										break;
									}
									num = (short)197328896;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3E6:;
							}
							goto Block_3;
							IL_654:
							num = (short)1426784257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							return result;
						case 13:
							result = false;
							num = (short)610271238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_136:
						num = (short)2115043335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_615:
						result = true;
						num = (short)176488460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_3:
						try
						{
							IL_3E9:
							num = (short)1992556545;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonFeature_A21353.Value == 76)
									{
										num = (short)870776838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_43D;
									}
									continue;
								case 2:
									goto IL_5A4;
								case 3:
								{
									int num4;
									num4++;
									num = (short)1073348616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_4EE;
								case 5:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10204] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonIndex_A22570.Value == value)
									{
										num = (short)681115651;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)1883832325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1157824514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									int num4;
									if (num4 > 1)
									{
										num = (short)987627529;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)1748893700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)706150407;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1325858816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_550:
								num = (short)641662986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_43D:
								goto IL_550;
							}
							IL_4EE:
							IL_5A4:
							goto IL_68F;
						}
						finally
						{
							num = (short)2091188225;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2065367042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5DB;
									}
									continue;
								case 2:
									goto IL_612;
								}
								IL_5DB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)780206080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_612:;
						}
						goto IL_615;
						IL_68F:
						num = (short)646053891;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_66:
					num = (short)1434397049;
					short num6 = num;
					num = (short)1869752697;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2045837312;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A = dekbuttonInnerSection.DEKButtonFeature_A21353;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
						int value = dekbuttonInnerSection.DEKButtonIndex_A22570.Value;
						result = true;
						num = (short)1482555392;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_27;
					}
					}
					break;
				}
				}
			}
			return result;
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x0072CE3C File Offset: 0x0072B03C
		public static bool conReturnTrueIfViewSetToLabtool(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			while (global::AcpCommonLib.AppInfoManager.AppView != global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
			{
				num = (short)1549355113;
				short num2 = num;
				num = (short)1001212009;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1730478081;
					if (num != 0)
					{
					}
					num = (short)1382875136;
					if (num != 0)
					{
					}
					return false;
				}
			}
			num = (short)1304821760;
			short num3 = num;
			return true;
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x0072CEF4 File Offset: 0x0072B0F4
		public static void ConDEKButtonModeZoneSelect(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)814088192;
			switch (num)
			{
			default:
			{
				num = (short)1857617920;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
				global::AcpBusinessLayer.AcpListField dekzone_A = dekbuttonInnerSection.DEKZone_A22566;
				global::AcpBusinessLayer.AcpListField dekbuttonBCO_A = dekbuttonInnerSection.DEKButtonBCO_A21352;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset).GetEnumerator();
				goto IL_8C;
				try
				{
					for (;;)
					{
						IL_8C:
						num = (short)1198194689;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
							{
								num = (short)939393025;
								if (num != 0)
								{
								}
								if (!enumerator.MoveNext())
								{
									num = (short)1325924355;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)790494216;
								short num4 = num;
								num = (short)1638923272;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_8C;
								default:
								{
									num = (short)1250099200;
									if (num != 0)
									{
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)1594621954;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_CF;
								}
								continue;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
								if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == dekbuttonBCO_A.Value)
								{
									num = (short)189857797;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1964572676;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_233;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeZone_A8538, dekzone_A.UIValue));
								num = (short)1989607430;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_216;
							}
							IL_179:
							num = (short)1519517696;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_CF:
							goto IL_179;
						}
					}
					IL_216:
					IL_233:;
				}
				finally
				{
					num = (short)1538981889;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1425211394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_268;
							}
							continue;
						case 2:
							goto IL_29F;
						}
						IL_268:
						if (enumerator == null)
						{
							break;
						}
						num = (short)863109120;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_29F:;
				}
				return;
			}
			}
		}

		// Token: 0x06007D3A RID: 32058 RVA: 0x0072D1C0 File Offset: 0x0072B3C0
		public static void ConDEKButtonModeChannelSelect(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1296433152;
			switch (num)
			{
			default:
			{
				num = (short)1367670785;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
				global::AcpBusinessLayer.AcpListField dekchannel_A = dekbuttonInnerSection.DEKChannel_A22565;
				global::AcpBusinessLayer.AcpListField dekbuttonBCO_A = dekbuttonInnerSection.DEKButtonBCO_A21352;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset).GetEnumerator();
				goto IL_89;
				try
				{
					for (;;)
					{
						IL_89:
						num = (short)1921974273;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1261502467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)673544370;
								short num3 = num;
								num = (short)661158066;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_89;
								default:
								{
									num = (short)1847590912;
									if (num != 0)
									{
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)145162242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_CB;
								}
								continue;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
								if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == dekbuttonBCO_A.Value)
								{
									num = (short)841940997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1775960068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1FE;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535, dekchannel_A.UIValue));
								num = (short)1884749830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_1E1;
							}
							IL_170:
							num = (short)664862720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CB:
							goto IL_170;
						}
					}
					IL_1E1:
					IL_1FE:;
				}
				finally
				{
					num = (short)1068957697;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)169541634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_233;
							}
							continue;
						case 2:
							goto IL_26A;
						}
						IL_233:
						if (enumerator == null)
						{
							break;
						}
						num = (short)375324672;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_26A:;
				}
				num = (short)194576384;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x0072D480 File Offset: 0x0072B680
		public static void ConValueSetIfFeatIsStsXOrMsgXOrMode(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)955973632;
			switch (num)
			{
			default:
			{
				num = (short)1176043533;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
					int num4;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_119F;
					case 1:
						goto IL_AC6;
					case 2:
						try
						{
							num = (short)1998061569;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)530251780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_100F;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1088421888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)809718943;
									short num3 = num;
									num = (short)2065650847;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_10CD;
									default:
										num = (short)846462976;
										if (num != 0)
										{
										}
										num = (short)938672134;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_1066;
								case 4:
									goto IL_112D;
								case 5:
									flag = true;
									num = (short)190119939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_10CD;
								}
								IL_1011:
								num = (short)207814658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10CD:
								if (((global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current).DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == dekbuttonInnerSection.DEKButtonBCO_A21352.Value)
								{
									num = (short)1059520517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_100F:
								goto IL_1011;
							}
							IL_1066:
							IL_112D:
							goto IL_78E;
						}
						finally
						{
							num = (short)1760755712;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1164;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1839923202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_119C;
								}
								IL_1164:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1201012737;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_119C:;
						}
						goto Block_11;
						IL_78E:
						num = (short)2108948488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)737017860;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1567162377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)915210247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (num4 >= 1)
									{
										num = (short)1379991553;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_DA0;
									}
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									if (topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 75)
									{
										num = (short)238551046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									num4 = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
									num = (short)1959198723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_F31;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
									num = (short)952631296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									if (num4 <= directStatusBCOListInnerRecset.Count)
									{
										num = (short)2120089608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)737738754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)997261317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E99:
								num = (short)2146762762;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DA0:
								goto IL_E99;
							}
							IL_F31:
							goto IL_3CB;
						}
						finally
						{
							num = (short)2054684672;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F6A;
									}
									continue;
								case 1:
									goto IL_FA2;
								case 2:
									enumerator.Dispose();
									num = (short)679936001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F6A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1597571074;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FA2:;
						}
						goto IL_FA5;
						IL_3CB:
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)1712390150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_12E2;
					case 5:
					{
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
						if (dekbuttonFeature_A.Value != 76)
						{
							num = (short)750059535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						try
						{
							num = (short)931266564;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num4 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
									num = (short)1236336640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)483786759;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (num4 <= directStatusBCOListInnerRecset.Count)
									{
										num = (short)1860239361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_135;
									}
									continue;
								case 5:
									if (num4 >= 1)
									{
										num = (short)2145058822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1646133251;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_2C6;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									num4 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
									num = (short)241893381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 75)
									{
										num = (short)1429798920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1647247362;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)360579081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_217:
								num = (short)1277558794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_135:
								goto IL_217;
							}
							IL_2C6:
							goto IL_FA5;
						}
						finally
						{
							num = (short)368705536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2FD;
									}
									continue;
								case 1:
									goto IL_337;
								case 2:
									enumerator.Dispose();
									num = (short)647168001;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2FD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)289275906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_337:;
						}
						goto IL_33A;
					case 7:
						return;
					case 8:
					{
						num = (short)178978816;
						short num5 = num;
						num = (short)1817706497;
						if (num != 0)
						{
						}
						if (!flag)
						{
							num = (short)1069940752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81B;
					}
					case 9:
						try
						{
							num = (short)1847984129;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(directModeBCOListInner));
									dekbuttonInnerSection.DEKZone_A22566.ResetToDefaultWithUndo(task);
									dekbuttonInnerSection.DEKChannel_A22565.ResetToDefaultWithUndo(task);
									num = (short)1510866949;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_435;
									}
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == dekbuttonInnerSection.DEKButtonBCO_A21352.Value)
									{
										num = (short)1114374144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1270939654;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)1444085762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_526;
								case 5:
									goto IL_508;
								case 6:
									num = (short)302055428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_490:
								num = (short)1732116483;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_435:
								goto IL_490;
							}
							IL_508:
							IL_526:
							goto IL_81B;
						}
						finally
						{
							num = (short)744292352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_55D;
									}
									continue;
								case 1:
									goto IL_595;
								case 2:
									enumerator.Dispose();
									num = (short)956760065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_55D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)154337282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_595:;
						}
						goto IL_598;
					case 10:
						goto IL_598;
					case 11:
					{
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
						if (dekbuttonFeature_A.Value == 74)
						{
							num = (short)929431556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33A;
					}
					case 12:
					{
						dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
						global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
						global::AcpBusinessLayer.AcpFieldBase dekbuttonName_A = dekbuttonInnerSection.DEKButtonName_A22568;
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A = dekbuttonInnerSection.DEKButtonFeature_A21353;
						global::AcpCommonLib.IAcpFeatureNode parent2 = dekbuttonName_A.Parent.Parent;
						(parent2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent2);
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset = global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset;
						directMessageListInnerRecset = (dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset);
						directStatusBCOListInnerRecset = (dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset);
						directModeBCOListInnerRecset = (dekrecset[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset);
						dekbuttonInnerRecset = (dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset);
						int dekbuttonIndex_A22570Value = dekbuttonInnerSection.DEKButtonIndex_A22570Value;
						num = (short)778436619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						continue;
					case 14:
						try
						{
							num = (short)50200580;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1709244419;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)796065797;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									int num6;
									if (num6 >= 1)
									{
										num = (short)1563557898;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									int num6;
									if (num6 <= directMessageListInnerRecset.Count)
									{
										num = (short)1962147849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)705495047;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_8C0;
									}
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
									if (dekbuttonInner2.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 76)
									{
										num = (short)702611462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
									int num6 = dekbuttonInner2.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
									num = (short)178388993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_A52;
								case 9:
								{
									int num6;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num6 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, dekbuttonInner2.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
									num = (short)1997602824;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)400949250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_915:
								num = (short)1348337664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8C0:
								goto IL_915;
							}
							IL_A52:
							goto IL_388;
						}
						finally
						{
							num = (short)1422983168;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A89;
									}
									continue;
								case 1:
									goto IL_AC3;
								case 2:
									enumerator.Dispose();
									num = (short)2118057985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A89:
								if (enumerator == null)
								{
									break;
								}
								num = (short)462880770;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AC3:;
						}
						goto Block_8;
						IL_388:
						num = (short)1433862149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_144E;
					case 16:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(directModeBCOListInnerRecset.CreateDefaultRecord()));
						int index = directModeBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner2 = directModeBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534, dekbuttonInnerSection.DEKButtonBCO_A21352.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeZone_A8538, dekbuttonInnerSection.DEKZone_A22566.UIValue));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535, dekbuttonInnerSection.DEKChannel_A22565.UIValue));
						num = (short)143982611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
						if (dekbuttonFeature_A.Value != 75)
						{
							num = (short)148242442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 18:
					{
						try
						{
							num = (short)747175938;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2059665411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner directMessageListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInner.DirectMessageListInnerSection.DEKDirectMessageBCO_A8506, 0));
									num = (short)1431830529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1348;
									}
									continue;
								case 3:
									num = (short)1680408580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_13DC;
								}
								IL_134A:
								num = (short)1894318080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1348:
								goto IL_134A;
							}
							IL_13DC:
							goto IL_B8;
						}
						finally
						{
							num = (short)256638976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1413;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2128084994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_144B;
								}
								IL_1413:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1256390657;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_144B:;
						}
						goto IL_144E;
						IL_B8:
						int num6 = 0;
						enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1394081793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_81B;
					}
					IL_94:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)2044067852;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_33A:
					enumerator = directModeBCOListInnerRecset.GetEnumerator();
					num = (short)206045193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_AC6:
						num = (short)389939204;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)810287107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
								num = (short)1685127177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								int num6;
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num6 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
								num = (short)311296001;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								num = (short)584843271;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B18;
								}
								continue;
							case 5:
							{
								int num6;
								if (num6 >= 1)
								{
									num = (short)922484742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								num = (short)1031274506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_CB5;
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								int num6 = topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
								num = (short)615186437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
								if (topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 76)
								{
									num = (short)907870216;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
							{
								int num6;
								if (num6 <= directMessageListInnerRecset.Count)
								{
									num = (short)167116802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_B62:
							num = (short)534315008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B18:
							goto IL_B62;
						}
						IL_CB5:
						goto IL_361;
					}
					finally
					{
						num = (short)616497152;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_CEC;
								}
								continue;
							case 1:
								goto IL_D24;
							case 2:
								enumerator.Dispose();
								num = (short)920190977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_CEC:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1515192322;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_D24:;
					}
					goto IL_D27;
					IL_361:
					enumerator = dekbuttonInnerRecset.GetEnumerator();
					num = (short)1773928462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_598:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekbuttonInnerSection.DEKButtonIndex_A22570, dekbuttonInnerSection.DEKButtonIndex_A22570.DefaultValue));
					num = (short)1453588487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81B:
					topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
					enumerator = directStatusBCOListInnerRecset.GetEnumerator();
					num = (short)1107558400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D27:
					num4 = 0;
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)123666435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_11:
					try
					{
						IL_119F:
						num = (short)806289410;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								num = (short)1837236228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_11D9;
								}
								continue;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1340669953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner directStatusBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)enumerator.Current;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInner.DirectStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, 0));
								num = (short)1516175360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_126E;
							}
							IL_121A:
							num = (short)448790531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_11D9:
							goto IL_121A;
						}
						IL_126E:
						goto IL_D27;
					}
					finally
					{
						num = (short)2031026176;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_12A5;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1312227330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_12DF;
							}
							IL_12A5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)241631233;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_12DF:;
					}
					goto IL_12E2;
					IL_FA5:
					enumerator = directMessageListInnerRecset.GetEnumerator();
					num = (short)1288437778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E2:
					flag = false;
					enumerator = directModeBCOListInnerRecset.GetEnumerator();
					num = (short)565837826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_144E:
					num = (short)2037841937;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x0072E9E0 File Offset: 0x0072CBE0
		public static void ConValueSetIfFeatIdxIsChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1793589248;
			switch (num)
			{
			default:
			{
				num = (short)1226899460;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_F85;
					case 1:
					{
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
						if (dekbuttonFeature_A.Value == 75)
						{
							num = (short)313393157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)462618635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)826081284;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									num3 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
									num = (short)1238237190;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_A82;
								case 2:
								{
									if (num3 > directStatusBCOListInnerRecset.Count)
									{
										num = (short)732758017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
									num = (short)456065033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_B0E;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_957;
									}
									continue;
								case 5:
									goto IL_A9A;
								case 6:
									if (num3 >= 1)
									{
										num = (short)1303838730;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A82;
								case 7:
									num = (short)830078979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)353304583;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
									num = (short)1631846411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									num = (short)1310982146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
									if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 75)
									{
										num = (short)1117454336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_A04:
								num = (short)220200968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_957:
								goto IL_A04;
								IL_A82:
								num = (short)307691525;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A9A:
							IL_B0E:
							return;
						}
						finally
						{
							num = (short)236126210;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1127219201;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_B7E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B46;
									}
									continue;
								}
								IL_B46:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1494482944;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B7E:;
						}
						goto Block_8;
					case 3:
						goto IL_E41;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_74;
						}
						continue;
					case 5:
						goto IL_8BD;
					case 6:
					{
						num = (short)1057357824;
						short num4 = num;
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection).DEKButtonFeature_A21353;
						global::AcpBusinessLayer.Recordset recordset = global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset;
						dekrecset = (global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset);
						topFunctionProgrammableButtonListInnerRecset = (recordset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
						dekbuttonInnerRecset = (dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset);
						num = (short)602669057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)259129345;
						if (num != 0)
						{
						}
						goto IL_269;
					case 8:
						try
						{
							num = (short)793706500;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (num3 > directStatusBCOListInnerRecset.Count)
									{
										num = (short)449445896;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num3 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
									num = (short)460128265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									if (num3 >= 1)
									{
										num = (short)476381189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6E5;
								case 2:
									num = (short)236191747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_848;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_686;
									}
									continue;
								case 5:
									num = (short)1316618240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									if (topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 75)
									{
										num = (short)2140536842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1764687874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
									num = (short)2086010886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_6E5;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
									num3 = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
									num = (short)975503361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_6FF;
								}
								goto IL_686;
								IL_6E5:
								num = (short)1225654283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_745:
								num = (short)829751303;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_686:
								goto IL_745;
							}
							IL_6FF:
							return;
							IL_848:
							goto IL_564;
						}
						finally
						{
							num = (short)246808578;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1495728129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_8BA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_87F;
									}
									continue;
								}
								IL_87F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)433127424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8BA:;
						}
						goto IL_8BD;
						IL_564:
						enumerator = dekbuttonInnerRecset.GetEnumerator();
						num = (short)2134704130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)1998651395;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)209780737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1F8;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_166;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)113967104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner directStatusBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner)enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInner.DirectStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, 0));
									num = (short)219480066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_168:
								num = (short)776601604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_166:
								goto IL_168;
							}
							IL_1F8:
							goto IL_4EE;
						}
						finally
						{
							num = (short)415760386;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)399048705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_266;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_22F;
									}
									continue;
								}
								IL_22F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)102498304;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_266:;
						}
						goto Block_4;
					case 10:
						goto IL_B81;
					case 11:
					{
						global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
						if (dekbuttonFeature_A.Value == 76)
						{
							num = (short)1548615680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_74:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num = (short)1116012550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					Block_9:
					try
					{
						IL_E41:
						num = (short)297074691;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)2004287489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_F10;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_E7D;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)71696384;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner directMessageListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner)enumerator.Current;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInner.DirectMessageListInnerSection.DEKDirectMessageBCO_A8506, 0));
								num = (short)123666434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_E7F:
							num = (short)454033412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E7D:
							goto IL_E7F;
						}
						IL_F10:
						goto IL_C0;
					}
					finally
					{
						num = (short)1981415426;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)984088577;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_F82;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_F49;
								}
								continue;
							}
							IL_F49:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2047279104;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_F82:;
					}
					goto IL_F85;
					IL_C0:
					int num5 = 0;
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)1553137674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
					try
					{
						IL_B81:
						num = (short)1968373764;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner2;
							switch (num2)
							{
							case 0:
								num = (short)874512391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (!enumerator.MoveNext())
								{
									num = (short)1542914053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								topFunctionProgrammableButtonListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner)enumerator.Current;
								num = (short)1839857670;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_D99;
							case 3:
								goto IL_DCE;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_BD7;
								}
								continue;
							case 5:
								num = (short)1499332611;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629.Value == 76)
								{
									num = (short)760217610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 7:
							{
								if (num5 > directMessageListInnerRecset.Count)
								{
									num = (short)1884225538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num5 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628.Value));
								num = (short)1465384968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_DB1;
							case 10:
								goto IL_C31;
							case 11:
							{
								num = (short)553354533;
								short num6 = num;
								num = (short)1852212517;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_C31;
								default:
									num = (short)941293568;
									if (num != 0)
									{
									}
									if (num5 >= 1)
									{
										num = (short)1604780032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D99;
								}
								break;
							}
							}
							goto IL_BD7;
							IL_C31:
							num5 = topFunctionProgrammableButtonListInner2.TopFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonStsMsgIndex_A36781.Value;
							num = (short)374276107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D5A:
							num = (short)1666318337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BD7:
							goto IL_D5A;
							IL_D99:
							num = (short)1848770569;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DB1:
						break;
						IL_DCE:
						goto IL_516;
					}
					finally
					{
						num = (short)1227489282;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)2018639873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_E3E;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_E05;
								}
								continue;
							}
							IL_E05:
							if (enumerator == null)
							{
								break;
							}
							num = (short)359464960;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_E3E:;
					}
					goto Block_9;
					IL_516:
					enumerator = dekbuttonInnerRecset.GetEnumerator();
					num = (short)1761280007;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EE:
					num3 = 0;
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)680263688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_269:
						num = (short)29425668;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)386662403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								num5 = dekbuttonInner2.DEKButtonInnerSection.DEKButtonIndex_A22570.Value;
								num = (short)1937833990;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								if (dekbuttonInner2.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 76)
								{
									num = (short)50003969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_47C;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_2BF;
								}
								continue;
							case 5:
								goto IL_407;
							case 6:
								if (num5 >= 1)
								{
									num = (short)768802826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3EE;
							case 7:
								goto IL_3EE;
							case 8:
							{
								if (num5 > directMessageListInnerRecset.Count)
								{
									num = (short)1165164551;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num5 - 1] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, dekbuttonInner2.DEKButtonInnerSection.DEKButtonBCO_A21352.Value));
								num = (short)1638465545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								num = (short)1091239944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1285881856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner)enumerator.Current;
								num = (short)103153666;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_30F:
							num = (short)680722443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2BF:
							goto IL_30F;
							IL_3EE:
							num = (short)883490821;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_407:
						IL_47C:
						break;
					}
					finally
					{
						num = (short)285081602;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)2036531201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_4EB;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4B3;
								}
								continue;
							}
							IL_4B3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)509542400;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4EB:;
					}
					goto IL_4EE;
					IL_8BD:
					directStatusBCOListInnerRecset = (dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset);
					enumerator = directStatusBCOListInnerRecset.GetEnumerator();
					num = (short)208863241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F85:
					directMessageListInnerRecset = (dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset);
					enumerator = directMessageListInnerRecset.GetEnumerator();
					num = (short)785252355;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x0072FA4C File Offset: 0x0072DC4C
		internal static bool ConNumOfDekBoxesForDEKButton(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (deknumberofDEKBoxes_A.Value == 1)
					{
						num2 = (short)1164705805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_35C;
				case 1:
					num2 = (short)391249922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (num3 >= 0)
					{
						num2 = (short)1099694096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31B;
				case 3:
					num2 = (short)1806368785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_31B;
				case 5:
					goto IL_174;
				case 6:
					goto IL_35C;
				case 7:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num2 = (short)485490699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 8:
					if (deknumberofDEKBoxes_A.Value == 3)
					{
						num2 = (short)1035862019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					if (num3 >= 0)
					{
						num2 = (short)1235681290;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_35C;
				case 10:
					num2 = (short)788529167;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)2017263617;
					if (num2 != 0)
					{
					}
					num2 = (short)2125856768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)421030638;
					short num4 = num2;
					num2 = (short)1614244590;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
						num2 = (short)1145438208;
						if (num2 != 0)
						{
						}
						if (num3 > 15)
						{
							num2 = (short)1753219072;
							short num5 = num2;
							num2 = (short)123731972;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 13:
					num2 = (short)1433403401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (deknumberofDEKBoxes_A.Value == 2)
					{
						num2 = (short)1908211713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31B;
				case 15:
					if (num3 > 7)
					{
						num2 = (short)657850374;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 16:
					num2 = (short)1660747788;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (num3 >= 0)
					{
						num2 = (short)272433157;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_58;
				IL_31B:
				num2 = (short)964165640;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_35C:
				num2 = (short)1505689614;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_174:
			return num3 <= 23;
			IL_58:
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
			deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
			((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset).CalculateValidity();
			dekbuttonInnerSection.DEKButtonIndex_A22570.CalculateValidityAcrossRecset();
			global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
			num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
			num2 = (short)400687111;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x0072FDF4 File Offset: 0x0072DFF4
		internal static bool ConNumOfDekBoxesForDEKVIPForR4(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1359740928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				int num3;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection dekvipinnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset e5BottomFunctionButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset keypadButtonInnerRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1168506881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 > 5)
						{
							num = (short)1902313490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						return true;
					case 3:
						goto IL_20F;
					case 4:
						goto IL_90F;
					case 5:
						if (num3 >= 0)
						{
							num = (short)2013659136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49A;
					case 6:
						num = (short)530382855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1771503617;
						if (num != 0)
						{
						}
						if (num3 >= 0)
						{
							num = (short)1778647055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_914;
					case 8:
						try
						{
							num = (short)903938052;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A1;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)190382083;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10709] as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerSection).RadErgCtrlKeypadGeneralKeypadButtonFeature_A41071.CalculateValidity();
									num = (short)2007760898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1857880064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_518;
									}
									continue;
								}
								IL_51A:
								num = (short)668270593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_518:
								goto IL_51A;
							}
							IL_5A1:
							goto IL_955;
						}
						finally
						{
							num = (short)1921515522;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_611;
								case 1:
									enumerator.Dispose();
									num = (short)1353121792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5DA;
									}
									continue;
								}
								IL_5DA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1997406209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_611:;
						}
						goto Block_8;
						IL_955:
						bottomFunctionProgrammableButtonInnerRecset.CalculateValidity();
						topFunctionProgrammableButtonListInnerRecset.CalculateValidity();
						num = (short)1135280139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)2139619344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						try
						{
							num = (short)1380515844;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_838;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)336855043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10904] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection).E5BottomFunctionButtonFeature_43758.CalculateValidity();
									num = (short)1195114498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)223936512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_7AB;
									}
									continue;
								}
								IL_7AD:
								num = (short)2143027201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7AB:
								goto IL_7AD;
							}
							IL_838:
							goto IL_74C;
						}
						finally
						{
							num = (short)1774387202;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8AB;
								case 1:
									enumerator.Dispose();
									num = (short)681508864;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_871;
									}
									continue;
								}
								IL_871:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1375272961;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8AB:;
						}
						goto IL_8AE;
					case 11:
						if (dekvipinnerSection.DEKVIPOutputFeature_A21346.Value == 20)
						{
							num = (short)1933770754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)857538583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)1005322246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_914;
					case 13:
						goto IL_614;
					case 14:
						goto IL_914;
					case 15:
						num = (short)728694801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)278200342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (num3 > 2)
						{
							num = (short)1397358606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
						goto IL_49A;
					case 19:
						try
						{
							num = (short)1348403204;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3D7;
								case 2:
									num = (short)1760493568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)874381314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.CalculateValidity();
									num = (short)436797441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_34D;
									}
									continue;
								}
								IL_387:
								num = (short)1631911939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_34D:
								goto IL_387;
							}
							IL_3D7:
							goto IL_8AE;
						}
						finally
						{
							num = (short)1545142274;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_497;
								case 1:
								{
									enumerator.Dispose();
									num = (short)399595463;
									short num4 = num;
									num = (short)215242695;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_416;
									default:
										num = (short)1134755840;
										if (num != 0)
										{
										}
										num = (short)246546432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_40F;
									}
									continue;
								}
								goto IL_40F;
								IL_416:
								num = (short)798031873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_40F:
								if (enumerator != null)
								{
									goto IL_416;
								}
								break;
							}
							IL_497:;
						}
						goto IL_49A;
					case 20:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)944111637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49A;
					case 21:
						num = (short)795738117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num3 >= 0)
						{
							num = (short)1709441028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
					{
						if (dekvipinnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num = (short)355008515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode parent = dekvipinnerSection.DEKVIPName_A22574.Parent.Parent;
						num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						num = (short)2083061772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_8E;
					Block_8:
					try
					{
						IL_614:
						num = (short)749731844;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_6DA;
							case 2:
								num = (short)1549926400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (!enumerator.MoveNext())
								{
									num = (short)572522498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10619] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection).CHO9BottomFunctionButtonFeature_A36664.CalculateValidity();
								num = (short)293142529;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_64E;
								}
								continue;
							}
							IL_688:
							num = (short)151257091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_64E:
							goto IL_688;
						}
						IL_6DA:
						goto IL_27C;
					}
					finally
					{
						num = (short)1730281474;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_749;
							case 1:
								enumerator.Dispose();
								num = (short)1935409152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_712;
								}
								continue;
							}
							IL_712:
							if (enumerator == null)
							{
								break;
							}
							num = (short)2015821825;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_749:;
					}
					goto IL_74C;
					IL_27C:
					enumerator = e5BottomFunctionButtonInnerRecset.GetEnumerator();
					num = (short)1520828426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49A:
					num = (short)640483337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74C:
					enumerator = topFunctionProgrammableButtonListInnerRecset.GetEnumerator();
					num = (short)822476819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8AE:
					enumerator = keypadButtonInnerRecset.GetEnumerator();
					num = (short)87883784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_914:
					num = (short)1917059092;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_20F:
				num = (short)1639972864;
				short num5 = num;
				return false;
				IL_90F:
				return num3 <= 8;
				IL_8E:
				dekvipinnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection);
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				topFunctionProgrammableButtonListInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset);
				bottomFunctionProgrammableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10618].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset);
				keypadButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4109) as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadRecset)[0][10710].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset);
				e5BottomFunctionButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset)[0][10903].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerRecset);
				enumerator = bottomFunctionProgrammableButtonInnerRecset.GetEnumerator();
				num = (short)1425735693;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x0073088C File Offset: 0x0072EA8C
		internal static bool ConEmerAlrmRxIndicTypeNotNoIndicAndVipOutFeatureIsEmergencyAlarmRx(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1190985728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CA;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_194;
					case 1:
					{
						int num3 = 0;
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1468792856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_B71;
					case 3:
					{
						int num4;
						if (num4 > 0)
						{
							num = (short)120979478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_668;
					}
					case 4:
					{
						int num4 = 0;
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1049493536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num4;
						if (num4 > 0)
						{
							num = (short)1993932820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD0;
					}
					case 6:
						try
						{
							num = (short)1136852999;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = false;
									num = (short)2046361608;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1518272516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (self.Parent != acpFeatureNode)
									{
										num = (short)311689219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)154140677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_F42;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 20)
									{
										num = (short)1614217216;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1300692993;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)424738818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_E33;
									}
									continue;
								case 8:
									goto IL_F25;
								}
								IL_E35:
								num = (short)560988166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E33:
								goto IL_E35;
							}
							IL_F25:
							return result;
							IL_F42:
							return true;
						}
						finally
						{
							num = (short)2013986817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1567096834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F7A;
									}
									continue;
								case 2:
									goto IL_FB2;
								}
								IL_F7A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1772879872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FB2:;
						}
						goto IL_FB5;
					case 7:
						if (index == 14)
						{
							num = (short)1584726017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					case 8:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)2040397861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)1614675996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						try
						{
							num = (short)1310457858;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1446510596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_959;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_904;
									}
									continue;
								case 3:
									num5++;
									num = (short)884342789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_A0D;
								case 5:
									if (num5 > 0)
									{
										num = (short)1526726663;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)629669888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1349517320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)680984577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 13)
									{
										num = (short)1915748355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_9B8:
								num = (short)1425997830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_904:
								goto IL_9B8;
							}
							IL_959:
							IL_A0D:
							goto IL_7F9;
						}
						finally
						{
							num = (short)862846977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)128158554;
									short num6 = num;
									num = (short)145197914;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1847918592;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1665007618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A44;
									}
									continue;
								case 2:
									goto IL_ACD;
								}
								IL_A44:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2110586880;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_ACD:;
						}
						goto IL_AD0;
						IL_7F9:
						num = (short)671678474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num5 > 0)
						{
							num = (short)349765645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_87A;
					case 11:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)830668821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_363;
					}
					case 12:
						return false;
					case 13:
						return false;
					case 14:
						goto IL_D81;
					case 15:
						if (index == 8)
						{
							num = (short)56688640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1277886489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_FB5;
					case 17:
						try
						{
							num = (short)543752193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)950730761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4A1;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (self.Parent != acpFeatureNode2)
									{
										num = (short)1229389834;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_5F6;
								case 4:
									num = (short)491192323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num5++;
									num = (short)877592584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)515833860;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)215089154;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 13)
									{
										num = (short)98435077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									if (num5 > 0)
									{
										num = (short)1776812032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
									goto IL_513;
								case 10:
									num = (short)913178631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_560:
								num = (short)2008219654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A1:
								goto IL_560;
							}
							IL_513:
							IL_5F6:
							goto IL_7BE;
						}
						finally
						{
							num = (short)1397620737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_665;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_62D;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1520369664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_62D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1362296834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_665:;
						}
						goto IL_668;
						IL_7BE:
						num = (short)789446682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (index == 20)
						{
							num = (short)759169055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 19:
						if (!(global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide).Advanced.RadErgoWideAdvancedConsoletteEnable_A37231)
						{
							num = (short)363266062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 20:
						return false;
					case 21:
						return false;
					case 22:
						return false;
					case 23:
						if (radWideDualRadioSelection_A.Value != 1)
						{
							num = (short)2084438050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
						try
						{
							num = (short)2034761737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1533935618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 14)
									{
										num = (short)60686339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1128;
								case 3:
								{
									int num3;
									num3++;
									num = (short)1436811271;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)135790593;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2134376458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1295974408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1184;
								case 7:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)1791426560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (self.Parent != acpFeatureNode3)
									{
										num = (short)2067529732;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_1038;
									}
									continue;
								case 10:
									num = (short)386400262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_112D:
								num = (short)2088435717;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1038:
								goto IL_112D;
							}
							IL_1128:
							IL_1184:
							goto IL_766;
						}
						finally
						{
							num = (short)1583087617;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1385299970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11BC;
									}
									continue;
								case 2:
									goto IL_11F4;
								}
								IL_11BC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)709885952;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11F4:;
						}
						goto IL_11F7;
						IL_766:
						num = (short)811663368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (index == 5)
						{
							num = (short)371261442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)275251236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (num5 > 0)
						{
							num = (short)736100364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)873332737;
						if (num != 0)
						{
						}
						enumerator = radioVIPInnerRecset.GetEnumerator();
						num = (short)1582497801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911)
						{
							num = (short)1317994496;
							short num7 = num;
							num = (short)1982201889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)648937478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						try
						{
							num = (short)1824456711;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)294125576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)880803844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 14)
									{
										num = (short)1217069059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
								{
									int num3;
									num3++;
									num = (short)248643589;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_D0C;
								case 5:
								{
									int num3;
									if (num3 > 0)
									{
										num = (short)1263140864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)55115777;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)846069762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_BFE;
									}
									continue;
								case 8:
									goto IL_CEF;
								}
								IL_C00:
								num = (short)821821446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BFE:
								goto IL_C00;
							}
							IL_CEF:
							IL_D0C:
							goto IL_B76;
						}
						finally
						{
							num = (short)1938030593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)20381698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D45;
									}
									continue;
								case 2:
									goto IL_D7E;
								}
								IL_D45:
								if (enumerator == null)
								{
									break;
								}
								num = (short)511180800;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D7E:;
						}
						goto IL_D81;
						IL_B76:
						num = (short)810483723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (index == 15)
						{
							num = (short)1249771524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD0;
					case 30:
						if (radWideDualRadioSelection_A.Value != 2)
						{
							num = (short)656605222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 31:
						num = (short)1616379923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						try
						{
							num = (short)837025801;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if ((acpFeatureNode4[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 15)
									{
										num = (short)309526530;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1021050888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									int num4;
									num4++;
									num = (short)199622660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (self.Parent != acpFeatureNode4)
									{
										num = (short)1232994311;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									int num4;
									if (num4 > 0)
									{
										num = (short)140312577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1171128330;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)13893635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1415;
								case 7:
									num = (short)231407616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_12E1;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_12C7;
									}
									continue;
								case 10:
									num = (short)1982595078;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_13BE:
								num = (short)183369733;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_12C7:
								goto IL_13BE;
							}
							IL_12E1:
							IL_1415:;
						}
						finally
						{
							num = (short)231342081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2069757954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_144B;
									}
									continue;
								case 2:
									goto IL_1484;
								}
								IL_144B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)650903552;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1484:;
						}
						num = (short)1919156227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_761;
					case 34:
						num = (short)2136014878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						try
						{
							num = (short)473432066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)895746049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_235;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E3;
									}
									continue;
								case 3:
								{
									int num4;
									num4++;
									num = (short)1758855174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_2EF;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1971847175;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2039939080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									int num4;
									if (num4 > 0)
									{
										num = (short)84148224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1012989956;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 15)
									{
										num = (short)1632567299;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_1E5:
								num = (short)1294729221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E3:
								goto IL_1E5;
							}
							IL_235:
							IL_2EF:
							goto IL_11F7;
						}
						finally
						{
							num = (short)437256193;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_360;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_327;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)757727232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_327:
								if (enumerator == null)
								{
									break;
								}
								num = (short)649330690;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_360:;
						}
						goto IL_363;
					case 36:
						if (index == 13)
						{
							num = (short)849412112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_87A;
					case 37:
						return false;
					case 38:
						num = (short)1192165403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CA;
					IL_363:
					num = (short)736362525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_668:
					enumerator = radioVIPInnerRecset.GetEnumerator();
					num = (short)665059363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_87A:
					num = (short)627769351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD0:
					num = (short)808910866;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D81:
					num = (short)1126694935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FB5:
					num5 = 0;
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)105381905;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F7:
					num = (short)1294729221;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_194:
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection dekvipinnerSection;
				return dekvipinnerSection.RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value != 0;
				IL_761:
				return false;
				IL_B71:
				int num8;
				return num8 == 1;
				IL_CA:
				dekvipinnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection);
				radWideDualRadioSelection_A = dekvipinnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = dekvipinnerSection.DEKVIPOutputFeature_A21346.Parent.Parent;
				num8 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)477691919;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x00731E0C File Offset: 0x0073000C
		public static bool conReturnTrueIfViewSetToLabtoolEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)505210273;
			short num2 = num;
			num = (short)2035738017;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)627900416;
				short num3 = num;
				num = (short)4849665;
				if (num != 0)
				{
				}
				num = (short)381943808;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x00731EC4 File Offset: 0x007300C4
		internal static bool ConNumOfDekBoxesAndFeatIsStsXOrMsgXEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)788201472;
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
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				int num3;
				global::AcpBusinessLayer.AcpListField dekbuttonFeature_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)882638869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 1:
						if (num3 <= 23)
						{
							num = (short)1580924933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1445003272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
					{
						num = (short)936181760;
						short num4 = num;
						num = (short)269221889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (num3 >= 0)
						{
							num = (short)546242578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 5:
						goto IL_116;
					case 6:
						goto IL_156;
					case 7:
						goto IL_15B;
					case 8:
						num = (short)794034193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (num3 >= 0)
						{
							num = (short)1700134932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					case 10:
						num = (short)823721993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num3 >= 0)
						{
							num = (short)1184563203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						if (num3 > 7)
						{
							num = (short)1471676432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116;
					case 13:
						num = (short)709820427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1418788865;
						if (num != 0)
						{
						}
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)1931018253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (dekbuttonFeature_A.Value != 75)
						{
							num = (short)920780806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						goto IL_2E4;
					case 17:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)637992970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					case 18:
						num = (short)120520723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (num3 > 15)
						{
							num = (short)546373639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_116;
					case 20:
						num = (short)588906508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1878523908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_116:
					num = (short)963837967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B:
					num = (short)1310734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E4:
					num = (short)1097245589;
					short num5 = num;
					num = (short)330277781;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)795017216;
						if (num != 0)
						{
						}
						num = (short)737017856;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_156:
				return dekbuttonFeature_A.Value == 76;
				IL_86:
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				dekbuttonFeature_A = dekbuttonInnerSection.DEKButtonFeature_A21353;
				global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)400031746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x00732310 File Offset: 0x00730510
		internal static bool ConNumOfDekBoxesAndFeatIsModeEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)424411136;
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
				int num3;
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (num3 >= 0)
						{
							num = (short)234160149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 1:
					{
						num = (short)645136384;
						short num4 = num;
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)1295908869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)665190408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1621688329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_3B4;
					case 4:
						if (num3 > 7)
						{
							num = (short)1965096978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CD;
					case 5:
						num = (short)1266089999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)360841227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)676134926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_10C;
					case 9:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1940324372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 10:
						goto IL_21D;
					case 11:
						if (num3 <= 23)
						{
							num = (short)1517682691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)865796112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 13:
						num = (short)1259667473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (num3 >= 0)
						{
							num = (short)1676214285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 15:
						if (num3 >= 0)
						{
							num = (short)211222534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 16:
					{
						num = (short)218759169;
						if (num != 0)
						{
						}
						num = (short)204926190;
						short num5 = num;
						num = (short)321907950;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)702742528;
							if (num != 0)
							{
							}
							num = (short)208666624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
						if (num3 > 15)
						{
							num = (short)1392771082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CD;
					case 18:
						goto IL_288;
					case 19:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)1789591559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 20:
						num = (short)901775372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)291962884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_21D:
					num = (short)834666497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_288:
					num = (short)1412628499;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10C:
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
				dekbuttonInnerSection.DEKZone_A22566.Valid = true;
				dekbuttonInnerSection.DEKChannel_A22565.Valid = true;
				return false;
				IL_1CD:
				return dekbuttonInnerSection.DEKButtonFeature_A21353.Value == 74;
				IL_3B4:
				goto IL_1CD;
				IL_86:
				dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)811335682;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x0073276C File Offset: 0x0073096C
		internal static bool ConNumOfDekBoxesForDEKButtonEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (deknumberofDEKBoxes_A.Value == 1)
					{
						num2 = (short)1009319944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_361;
				case 1:
					if (num3 >= 0)
					{
						num2 = (short)2142109712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_361;
				case 2:
					num2 = (short)45809664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1584332811;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
					{
						num2 = (short)834535426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (deknumberofDEKBoxes_A.Value == 2)
					{
						num2 = (short)1771962382;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_320;
				case 6:
					goto IL_14C;
				case 7:
					goto IL_361;
				case 8:
				{
					num2 = (short)1663218927;
					short num4 = num2;
					num2 = (short)470594799;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_302;
					default:
						num2 = (short)443088896;
						if (num2 != 0)
						{
						}
						num2 = (short)896008193;
						if (num2 != 0)
						{
						}
						num2 = (short)277151745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
				{
					num2 = (short)1098579968;
					short num5 = num2;
					if (num3 > 15)
					{
						num2 = (short)689242124;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 10:
					num2 = (short)2073034761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (num3 >= 0)
					{
						num2 = (short)1888878598;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 12:
					goto IL_320;
				case 13:
					if (deknumberofDEKBoxes_A.Value == 3)
					{
						num2 = (short)535560195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 14:
					num2 = (short)288161807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (num3 >= 0)
					{
						num2 = (short)2141782026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_320;
				case 16:
					num2 = (short)2054946833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_302;
				}
				goto IL_58;
				IL_302:
				if (num3 > 7)
				{
					num2 = (short)1760493575;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				return true;
				IL_320:
				num2 = (short)793182221;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_361:
				num2 = (short)2136145925;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14C:
			return num3 <= 23;
			IL_58:
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection;
			deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
			((global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset)[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset).CalculateValidity();
			dekbuttonInnerSection.DEKButtonIndex_A22570.CalculateValidityAcrossRecset();
			global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
			num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
			num2 = (short)1826947076;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x00732B18 File Offset: 0x00730D18
		internal static bool ConNumOfDekBoxesForDEKVIPEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
			short num2;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (deknumberofDEKBoxes_A.Value == 3)
					{
						num2 = (short)450428941;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_266;
				case 2:
					num2 = (short)1861353482;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)340066304;
					short num3 = num2;
					goto IL_2DE;
				}
				case 4:
					num2 = (short)1256325129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)1347525301;
					short num4 = num2;
					num2 = (short)411736757;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D8;
					default:
						num2 = (short)1471676416;
						if (num2 != 0)
						{
						}
						if (num5 > 2)
						{
							num2 = (short)519241731;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					break;
				}
				case 6:
					num2 = (short)992477185;
					if (num2 != 0)
					{
					}
					if (num5 >= 0)
					{
						num2 = (short)920256519;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 7:
					num2 = (short)1375666181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (num5 >= 0)
					{
						num2 = (short)143589388;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					if (num5 >= 0)
					{
						num2 = (short)1805778946;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_266;
				case 10:
					if (num5 > 5)
					{
						num2 = (short)1089667073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 11:
					if (deknumberofDEKBoxes_A.Value == 2)
					{
						num2 = (short)147914756;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_266;
				case 12:
					goto IL_10D;
				case 13:
					goto IL_D8;
				case 14:
					num2 = (short)238944262;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (deknumberofDEKBoxes_A.Value == 1)
					{
						num2 = (short)306511886;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				}
				goto IL_50;
				IL_D8:
				num2 = (short)1483407368;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_266:
				num2 = (short)637337600;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DE:
				num2 = (short)284229643;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10D:
			return num5 <= 8;
			IL_50:
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection dekvipinnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection;
			deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
			global::AcpCommonLib.IAcpFeatureNode parent = dekvipinnerSection.DEKVIPName_A22574.Parent.Parent;
			num5 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
			num2 = (short)1333657615;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x00732E40 File Offset: 0x00731040
		public static void ConValueSetOfDEKBoxNum(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)574291968;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_286;
				}
				global::Motorola.MackinawCPS.CoreFeatures.DEK.General general;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner4;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9 controlHeadO;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner5;
					global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner dekbuttonInner;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner6;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner7;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner8;
					global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner10;
					int num8;
					int num9;
					int num12;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset;
						int num3;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerSection directMessageListInnerSection = (directMessageListInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInner).DirectMessageListInnerSection;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directMessageListInnerSection.DEKDirectMessageBCO_A8506, 0));
						num = (short)1098645528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1A46;
					case 2:
						goto IL_806;
					case 3:
					{
						int num4 = 24;
						int num5 = 9;
						num = (short)1256194195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1962475589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_160F;
					case 6:
						goto IL_1EAF;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner = radioVIPInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner;
						num = (short)1132920873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (radioVIPInner2.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)1200095321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E8;
					case 9:
						if (radioVIPInner3.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 1)
						{
							num = (short)504561793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EF4;
					case 10:
						goto IL_1744;
					case 11:
						goto IL_B10;
					case 12:
						if (radioVIPInner4.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)950403176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DCD;
					case 13:
						goto IL_1EF4;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner.RadioVIPInnerSection.RadVipOutputFeature_A20947, 2));
						num = (short)969605255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						int num3;
						if (num3 >= 0)
						{
							num = (short)712572960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_548;
					}
					case 16:
						goto IL_113C;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset = controlHeadO.TopFunctionProgrammableButton.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset;
						num = (short)550174848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						int value;
						if (value != 0)
						{
							num = (short)84082807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)248905790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (radioVIPInner5.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)1295843431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_127C;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner.RadioVIPInnerSection.RadVipInputFeature_A21329, 97));
						num = (short)849018881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_31A;
					case 22:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Valid)
						{
							num = (short)249102427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2D;
					case 23:
						goto IL_1D0C;
					case 24:
						goto IL_548;
					case 25:
						goto IL_149D;
					case 26:
						num = (short)1447690256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (radioVIPInner6 != null)
						{
							num = (short)618135587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					case 28:
						num = (short)13565971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection topFunctionProgrammableButtonListInnerSection = topFunctionProgrammableButtonListInner.TopFunctionProgrammableButtonListInnerSection;
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A = topFunctionProgrammableButtonListInnerSection.O9CHCnvTopFunctionButtonFeature_A36629;
						global::AcpBusinessLayer.AcpListField topFunctionBtnCnvChannel_A = topFunctionProgrammableButtonListInnerSection.TopFunctionBtnCnvChannel_A36943;
						global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A = topFunctionProgrammableButtonListInnerSection.CnvTopFunctionButtonBCO_A36628;
						num = (short)1209306461;
						short num6 = num;
						num = (short)2023918941;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_113C;
						default:
							num = (short)1134952448;
							if (num != 0)
							{
							}
							num = (short)1808400433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 30:
						goto IL_64A;
					case 31:
						goto IL_1D0C;
					case 32:
						num = (short)2041315454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1272578191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner7.RadioVIPInnerSection.RadVipInputFeature_A21329, 72));
						num = (short)1735196730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1909129287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 75)
						{
							num = (short)445186113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 37:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner8.RadioVIPInnerSection.RadVipOutputFeature_A20947, 3));
						num = (short)756744202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner9;
						if (radioVIPInner9.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)1917452398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_972;
					}
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338.Value != 38)
						{
							num = (short)2095251562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0C;
					}
					case 40:
					{
						int value;
						if (value == 2)
						{
							num = (short)2114912351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1189871683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						if (radioVIPInner.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 97)
						{
							num = (short)1345650708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A46;
					}
					case 42:
						if (radioVIPInner3.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)938672207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1033;
					case 43:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner6.RadioVIPInnerSection.RadVipOutputFeature_A20947, 21));
						num = (short)488374348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)318767205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (radioVIPInner5 != null)
						{
							num = (short)790822938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B9;
					case 46:
						goto IL_C0C;
					case 47:
						if (global::AcpCommonLib.FeatureManager.GetFeature(4003) != null)
						{
							num = (short)909115436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 48:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner4.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)1695875093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::AcpBusinessLayer.AcpListField o9CHCnvTopFunctionButtonFeature_A;
						if (o9CHCnvTopFunctionButtonFeature_A.Value == 74)
						{
							num = (short)1744830578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E0A;
					}
					case 50:
						try
						{
							num = (short)283181056;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3AA;
									}
									continue;
								case 1:
									goto IL_3CE;
								case 2:
									num = (short)1310723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_489;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(directModeBCOListInner));
									num = (short)1234436097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1693712386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)1487077382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner;
									if (directModeBCOListInner.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == dekbuttonInner.DEKButtonInnerSection.DEKButtonBCO_A21352.Value)
									{
										num = (short)1167065092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_3D3:
								num = (short)2025717765;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AA:
								goto IL_3D3;
							}
							IL_3CE:
							IL_489:
							goto IL_16A7;
						}
						finally
						{
							num = (short)1672216577;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_4FA;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_4C2;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)853475328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_4C2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1271005186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4FA:;
						}
						goto IL_4FD;
						IL_16A7:
						dekbuttonInner.DEKButtonInnerSection.DEKZone_A22566.ResetToDefaultWithUndo(task);
						dekbuttonInner.DEKButtonInnerSection.DEKChannel_A22565.ResetToDefaultWithUndo(task);
						num = (short)1029570590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338.Value != 38)
						{
							num = (short)1671626884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0C;
					}
					case 52:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner10.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)9175134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner;
						if (topFunctionProgrammableButtonListInner != null)
						{
							num = (short)725286941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E0A;
					}
					case 54:
						if (radioVIPInner2.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)528351313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12EE;
					case 55:
						goto IL_160F;
					case 56:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner5.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)1159004284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (radioVIPInner7 != null)
						{
							num = (short)1803681941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107F;
					case 58:
						goto IL_107F;
					case 59:
						if (radioVIPInner8.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 3)
						{
							num = (short)1147076645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1744;
					case 60:
						if (controlHeadO != null)
						{
							num = (short)61014033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner;
						if (radioVIPInner.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 2)
						{
							num = (short)266665998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D7;
					}
					case 62:
					{
						int value;
						if (value == 0)
						{
							num = (short)315621383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B9;
					}
					case 63:
						if (radioVIPInner4 != null)
						{
							num = (short)429981792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DCD;
					case 64:
						if (radioVIPInner10.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)761397336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC0;
					case 65:
					{
						num = (short)1054736385;
						if (num != 0)
						{
						}
						int num7 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value - 1;
						num = (short)588120205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
						if (radioVIPInner6 != null)
						{
							num = (short)638451716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					case 67:
					{
						int value;
						if (value == 1)
						{
							num = (short)1109786723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)385548404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						return;
					case 69:
						if (radioVIPInner6.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 21)
						{
							num = (short)1023017003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FD;
					case 70:
						goto IL_1833;
					case 71:
						if (radioVIPInner6.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)1489174620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_900;
					case 72:
						goto IL_BC0;
					case 73:
						num8 = 0;
						num = (short)278528006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1349517334;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_1C68;
					case 76:
						goto IL_4FD;
					case 77:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner8.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)1572077651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)1154088978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner3.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)619184261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (radioVIPInner4 != null)
						{
							num = (short)43909202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 81:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner2.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)1559363693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)349896789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_2CE;
					case 84:
					{
						int num5;
						if (num9 >= num5)
						{
							num = (short)1272053838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num10 = 9 - num5 + num9;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner = dekvipinnerRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner;
						num = (short)1438253143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						if (radioVIPInner4.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)1542520880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 86:
						goto IL_CEE;
					case 87:
					{
						num = (short)1526857728;
						short num11 = num;
						int num10;
						if (num10 == 0)
						{
							num = (short)1238171788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1461714995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner10.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)1563820104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner2.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)1982660719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_10B9;
					case 91:
					{
						int num7;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerSection directStatusBCOListInnerSection = (directStatusBCOListInnerRecset[num7] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInner).DirectStatusBCOListInnerSection;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(directStatusBCOListInnerSection.DEKDirectStatusBCO_A9196, 0));
						num = (short)502988907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 92:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner6.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)685310096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (radioVIPInner7 != null)
						{
							num = (short)1171259425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B9;
					case 94:
						goto IL_19C6;
					case 95:
					{
						int num4 = 8;
						int num5 = 3;
						num = (short)1038155781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						num = (short)1742733324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_B10;
					case 98:
						goto IL_1DCD;
					case 99:
					{
						int num4 = 16;
						int num5 = 6;
						num = (short)1922891831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner9;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner9.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)1551433753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 101:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						if (directModeBCOListInnerRecset != null)
						{
							num = (short)772407371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 102:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner9;
						if (radioVIPInner9.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)51642468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149D;
					}
					case 103:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner5.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)233439377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner4.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)1031733346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 74)
						{
							num = (short)113967252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64A;
					case 106:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338, 38));
						num = (short)1552285719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 107:
						goto IL_F2D;
					case 108:
						try
						{
							num = (short)1815674880;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B0A;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1466171397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner)enumerator.Current;
									num = (short)1693253638;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1B77;
								case 3:
									goto IL_1BF5;
								case 4:
								{
									global::AcpBusinessLayer.AcpListField topFunctionBtnCnvChannel_A;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner2;
									directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeChannel_A8535.UIValue = topFunctionBtnCnvChannel_A.UIValue;
									num = (short)844038146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)384958467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.AcpListField cnvTopFunctionButtonBCO_A;
									global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInner directModeBCOListInner2;
									if (directModeBCOListInner2.DirectModeBCOListInnerSection.DEKDirectModeBCO_A8534.Value == cnvTopFunctionButtonBCO_A.Value)
									{
										num = (short)1851588612;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1B0C:
								num = (short)381616129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B0A:
								goto IL_1B0C;
							}
							IL_1B77:
							IL_1BF5:
							goto IL_1E0A;
						}
						finally
						{
							num = (short)177471489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1C65;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1C2C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)217710592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1C2C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1685848066;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C65:;
						}
						goto IL_1C68;
					case 109:
						goto IL_12EE;
					case 110:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner9;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner9.RadioVIPInnerSection.RadVipInputFeature_A21329, 38));
						num = (short)930611313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 111:
						goto IL_16E8;
					case 112:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						(dekbuttonInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner).DEKButtonInnerSection.DEKButtonIndex_A22570.CalculateValidityAcrossRecset();
						num9 = 0;
						num = (short)821821586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 113:
						goto IL_972;
					case 114:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)627245164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 115:
						if (radioVIPInner5 != null)
						{
							num = (short)771424284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_127C;
					case 116:
					{
						int value;
						if (value == 0)
						{
							num = (short)1671299075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_160F;
					}
					case 117:
						if (radioVIPInner8.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 38)
						{
							num = (short)181403725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CE;
					case 118:
						goto IL_8A0;
					case 119:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner radioVIPInner9 = radioVIPInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner;
						num = (short)1612251174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 120:
					{
						int num4;
						if (num12 >= num4)
						{
							num = (short)1356267632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset;
						dekbuttonInner = (dekbuttonInnerRecset[24 - num4 + num12] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInner);
						num = (short)429916299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 121:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						if (dekvipinner.DEKVIPInnerSection.DEKVIPOutputFeature_A21346.Value != 0)
						{
							num = (short)19398786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0C;
					}
					case 122:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1087373437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 123:
						goto IL_1EAF;
					case 124:
						goto IL_10B9;
					case 125:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset dekrecset = global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset dekbuttonInnerRecset = dekrecset[0][10232].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset = dekrecset[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset;
						radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset directMessageListInnerRecset = dekrecset[0][10229].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectMessageListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset directStatusBCOListInnerRecset = dekrecset[0][10219].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectStatusBCOListInnerRecset;
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset = dekrecset[0][10220].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset;
						int value = general.DEKNumberofDEKBoxes_A8579.Value;
						int num4 = 0;
						int num5 = 0;
						num = (short)1755643944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 126:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Valid)
						{
							num = (short)448724992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_548;
					case 127:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner7.RadioVIPInnerSection.RadVipOutputFeature_A20947, 0));
						num = (short)911212634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (topFunctionProgrammableButtonListInnerRecset != null)
						{
							num = (short)403374153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 129:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radioVIPInner3.RadioVIPInnerSection.RadVipOutputFeature_A20947, 1));
						num = (short)1665990669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekvipinner.DEKVIPInnerSection.DEKVIPOutputFeature_A21346, 0));
						num = (short)1282211886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 131:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value == 76)
						{
							num = (short)1485111434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CEE;
					case 132:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInner dekvipinner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekvipinner.DEKVIPInnerSection.DEKVIPInputFeature_A21338, 38));
						num = (short)495255583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 133:
						goto IL_1033;
					case 134:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset topFunctionProgrammableButtonListInnerRecset;
						if (num8 >= topFunctionProgrammableButtonListInnerRecset.Count)
						{
							num = (short)1860436036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner topFunctionProgrammableButtonListInner = topFunctionProgrammableButtonListInnerRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInner;
						num = (short)1044578357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 135:
						goto IL_17D7;
					case 136:
						num = (short)808255619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						if (radioVIPInner7.RadioVIPInnerSection.RadVipInputFeature_A21329.Value != 72)
						{
							num = (short)2026176546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107F;
					case 138:
					{
						int num3 = dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.Value - 1;
						num = (short)1954217999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 139:
						if (dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353.Value != 38)
						{
							num = (short)375914632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A0;
					case 140:
						num = (short)190775335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
					{
						int num7;
						if (num7 >= 0)
						{
							num = (short)1102381130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F2D;
					}
					case 142:
						if (radioVIPInner10.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)278396980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C6;
					case 143:
						if (radioVIPInner7.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
						{
							num = (short)882180223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B9;
					case 144:
						goto IL_900;
					case 145:
						goto IL_127C;
					case 146:
						goto IL_1833;
					case 147:
						goto IL_160F;
					case 148:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DEK.DirectModeBCOListInnerRecset directModeBCOListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = directModeBCOListInnerRecset.GetEnumerator();
						num = (short)1299710002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 149:
						num = (short)1926758537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_286;
					IL_2CE:
					num = (short)1955987515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					radioVIPInner5 = (radioVIPInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)2121007219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FD:
					radioVIPInner7 = (radioVIPInnerRecset[4] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)351928377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_548:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570, dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.DefaultValue));
					num = (short)1090191446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64A:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekbuttonInner.DEKButtonInnerSection.DEKButtonFeature_A21353, 38));
					num = (short)2002845814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_806:
					num = (short)1652949097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8A0:
					num12++;
					num = (short)1152188513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_900:
					num = (short)1596850242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_972:
					num = (short)114032742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B10:
					num = (short)79495288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC0:
					num = (short)1046937742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C0C:
					num9++;
					num = (short)587530310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CEE:
					num = (short)1793196068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2D:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570, dekbuttonInner.DEKButtonInnerSection.DEKButtonIndex_A22570.DefaultValue));
					num = (short)881852418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1033:
					num = (short)1727856649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107F:
					num = (short)1372520541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B9:
					num = (short)1219821615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_113C:
					if (radioVIPInner5.RadioVIPInnerSection.RadVipOutputFeature_A20947.Value != 0)
					{
						num = (short)940572728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10B9;
					IL_127C:
					num = (short)860422189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12EE:
					num = (short)1458241544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_149D:
					radioVIPInner2 = (radioVIPInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)966983734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_160F:
					num12 = 0;
					num = (short)663552011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E8:
					radioVIPInner10 = (radioVIPInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)52166720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1744:
					radioVIPInner3 = (radioVIPInnerRecset[2] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)244318250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D7:
					radioVIPInner8 = (radioVIPInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)961413237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1833:
					num = (short)2077294676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C6:
					radioVIPInner4 = (radioVIPInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)1471021119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A46:
					num = (short)803078205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C68:
					controlHeadO = (global::AcpCommonLib.FeatureManager.GetFeature(4003)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9);
					num = (short)45940796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D0C:
					num = (short)659751033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DCD:
					num = (short)1722024016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0A:
					num8++;
					num = (short)1245184123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EAF:
					num = (short)830210182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EF4:
					radioVIPInner6 = (radioVIPInnerRecset[3] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInner);
					num = (short)1530265627;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_286:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.General);
				num = (short)1520763002;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x00734E10 File Offset: 0x00733010
		public static bool ConDynamicZoneInDEKValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6F;
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)413073412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
				{
					if (index > dekbuttonInnerSection.DEKZone_A22566.RefRecset.Count)
					{
						num2 = (short)514785287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = dekbuttonInnerSection.DEKZone_A22566.RefRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)1353515016;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					num2 = (short)1817968641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1941176320;
					short num3 = num2;
					num2 = (short)28364572;
					short num4 = num2;
					num2 = (short)1538051868;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)699662336;
						if (num2 != 0)
						{
						}
						result = false;
						num2 = (short)1403125765;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_200;
				case 6:
					if (index >= 0)
					{
						num2 = (short)1430061056;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					goto IL_174;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)1407123459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_34;
				IL_6F:
				num2 = (short)441450498;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_174:
			num2 = (short)1378942977;
			if (num2 != 0)
			{
			}
			return true;
			IL_200:
			return result;
			IL_34:
			result = true;
			dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
			num2 = (short)200867846;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x00735024 File Offset: 0x00733224
		public static bool ConNumOfDekBoxesAndFeatIsModeAndNonDynamicZone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1984954368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
				global::AcpBusinessLayer.AcpListField deknumberofDEKBoxes_A;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection dekbuttonInnerSection;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_24E;
					case 1:
						return false;
					case 2:
						num = (short)1698627608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)459997196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num3 <= 23)
						{
							num = (short)1421082624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (num3 > 15)
						{
							num = (short)382140422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_365;
					case 6:
						goto IL_155;
					case 7:
						num = (short)1591672853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)582156288;
						short num4 = num;
						goto IL_198;
					}
					case 9:
						goto IL_360;
					case 10:
						num = (short)1006436356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4F6;
					case 12:
						if (num3 >= 0)
						{
							num = (short)1848639499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					case 13:
					{
						if (zoneChannelAssignment == null)
						{
							goto IL_2FF;
						}
						num = (short)758105183;
						short num5 = num;
						num = (short)1257489503;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4F6;
						default:
							num = (short)284229632;
							if (num != 0)
							{
							}
							num = (short)1018691607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						if (num3 >= 0)
						{
							num = (short)576192522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (num3 > 7)
						{
							num = (short)1777336328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_365;
					case 16:
						if (deknumberofDEKBoxes_A.Value == 3)
						{
							num = (short)485425169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						num = (short)1530069006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (deknumberofDEKBoxes_A.Value == 2)
						{
							num = (short)18350083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_155;
					case 19:
						num = (short)1471807503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (global::ConstraintHelper.UtilityMack.IsMobileOnly())
						{
							num = (short)1583480839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 21:
						if (deknumberofDEKBoxes_A.Value == 1)
						{
							num = (short)412090370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 22:
						if (zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
						{
							num = (short)779943937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2FF;
					case 23:
						num = (short)1655635990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (num3 >= 0)
						{
							num = (short)1013186579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_198;
					case 25:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)264241161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1588330516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97;
					IL_155:
					num = (short)192086032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_198:
					num = (short)1437859858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FF:
					global::AcpCommonLib.IAcpFeatureNode parent = dekbuttonInnerSection.DEKButtonName_A22568.Parent.Parent;
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)1426325529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F6:
					num = (short)652804101;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_24E:
				goto IL_365;
				IL_360:
				num = (short)1849950209;
				if (num != 0)
				{
				}
				dekbuttonInnerSection.DEKZone_A22566.Valid = true;
				dekbuttonInnerSection.DEKChannel_A22565.Valid = true;
				return false;
				IL_365:
				return dekbuttonInnerSection.DEKButtonFeature_A21353.Value == 74;
				IL_97:
				dekbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKButtonInnerSection);
				deknumberofDEKBoxes_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK).General.DEKNumberofDEKBoxes_A8579;
				zoneChannelAssignment = (dekbuttonInnerSection.DEKZone_A22566.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
				num = (short)626524173;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x00735530 File Offset: 0x00733730
		internal static bool conDEKInputSelectionsIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1431699456;
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
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset gcaivipinnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (self is global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection)
						{
							num = (short)1968963585;
							if (num != 0)
							{
							}
							num = (short)1327169549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (radWideDualRadioSelection_A.Value != 1)
						{
							num = (short)1535377411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						goto IL_473;
					case 3:
					{
						num = (short)1203896320;
						short num3 = num;
						num = (short)953942024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (index == 27)
						{
							num = (short)1791361031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						if (!(global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide).Advanced.RadErgoWideAdvancedConsoletteEnable_A37231)
						{
							num = (short)465829900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if ((global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide).General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911)
						{
							num = (short)1676017674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)1340669954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_63C;
					case 8:
						if (radWideDualRadioSelection_A.Value != 2)
						{
							num = (short)2079588361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)1594818566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_700;
					case 11:
						try
						{
							num = (short)1993867266;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3A6;
								case 1:
								{
									num = (short)1472382479;
									short num4 = num;
									num = (short)808568335;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_273;
									default:
										num = (short)66256896;
										if (num != 0)
										{
										}
										num = (short)448266243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_273;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10798] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerSection).GCAIVipInputFeature_42623.Value == 27)
									{
										num = (short)2034761735;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_402;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)800653320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1966997510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (self.Parent != acpFeatureNode)
									{
										num = (short)1757872129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									result = false;
									num = (short)534642688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1420623876;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2A8;
								IL_273:
								switch (0)
								{
								case 0:
									IL_2A8:
									goto IL_3AB;
								}
								continue;
								IL_3AB:
								num = (short)559415301;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3A6:
							return result;
							IL_402:
							return true;
						}
						finally
						{
							num = (short)511049728;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_43A;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1707868162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_470;
								}
								IL_43A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1722089473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_470:;
						}
						goto Block_6;
					case 12:
						num = (short)1827930113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1867382789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
					Block_6:
					try
					{
						IL_473:
						num = (short)595787778;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (self.Parent != acpFeatureNode2)
								{
									num = (short)1791361029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)333381636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4BD;
								}
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPInputFeature_A21338.Value == 27)
								{
									num = (short)407306247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_5CD;
							case 5:
								num = (short)1539637251;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1565523969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
								num = (short)327155712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								result = false;
								num = (short)69402632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_5AE;
							}
							IL_4BF:
							num = (short)160366598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_4BD:
							goto IL_4BF;
						}
						IL_5AE:
						return result;
						IL_5CD:
						goto IL_10E;
					}
					finally
					{
						num = (short)214630400;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_604;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1721237506;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_639;
							}
							IL_604:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1102708737;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_639:;
					}
					goto IL_63C;
					IL_10E:
					enumerator = gcaivipinnerRecset.GetEnumerator();
					num = (short)1957494795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_63C:
					num = (short)1647378432;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_700:
				return false;
				IL_66:
				radWideDualRadioSelection_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				gcaivipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10797].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.GCAIVIPInnerRecset);
				num = (short)2055340036;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
