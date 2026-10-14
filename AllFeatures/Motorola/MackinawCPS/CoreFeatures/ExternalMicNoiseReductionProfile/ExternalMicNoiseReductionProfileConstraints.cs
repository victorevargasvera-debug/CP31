using System;
using AcpBusinessLayer;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x0200025D RID: 605
	public static class ExternalMicNoiseReductionProfileConstraints
	{
		// Token: 0x06006C0B RID: 27659 RVA: 0x00606D74 File Offset: 0x00604F74
		internal static bool ConExtMicMaxVectorsLengthNoLessThan128(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)812134196;
			short num2 = num;
			num = (short)520826676;
			global::AcpBusinessLayer.AcpField<string> radErgoCfgGeneralMAXSVECTOR_A;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)185401344;
				if (num != 0)
				{
				}
				num = (short)1166082049;
				if (num != 0)
				{
				}
				radErgoCfgGeneralMAXSVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).RadErgoCfgGeneralMAXSVECTOR_A22297;
				if (radErgoCfgGeneralMAXSVECTOR_A.Value == null)
				{
					return false;
				}
				break;
			}
			num = (short)1615200256;
			short num3 = num;
			return radErgoCfgGeneralMAXSVECTOR_A.Value.Length >= 128;
		}

		// Token: 0x06006C0C RID: 27660 RVA: 0x00606E4C File Offset: 0x0060504C
		internal static bool ConExtMicDincOutputEqVectorLengthEqualsTo124(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1397555201;
			if (num != 0)
			{
			}
			num = (short)42672735;
			short num2 = num;
			num = (short)1483416159;
			global::AcpBusinessLayer.AcpField<string> extMicNsRdGenDINCOUTPUTEQVECTOR_A;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1648492544;
				if (num != 0)
				{
				}
				extMicNsRdGenDINCOUTPUTEQVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).ExtMicNsRdGenDINCOUTPUTEQVECTOR_A37720;
				if (extMicNsRdGenDINCOUTPUTEQVECTOR_A.Value == null)
				{
					return false;
				}
				break;
			}
			num = (short)3342336;
			short num3 = num;
			return extMicNsRdGenDINCOUTPUTEQVECTOR_A.Value.Length == 124;
		}

		// Token: 0x06006C0D RID: 27661 RVA: 0x00606F20 File Offset: 0x00605120
		internal static bool ConExtMicDincEPVectorLengthEqualsTo64(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1363372734;
			short num2 = num;
			num = (short)1397516990;
			global::AcpBusinessLayer.AcpField<string> extMicNsRdGenDINCEPVECTOR_A;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)168689664;
				if (num != 0)
				{
				}
				extMicNsRdGenDINCEPVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).ExtMicNsRdGenDINCEPVECTOR_A37721;
				if (extMicNsRdGenDINCEPVECTOR_A.Value == null)
				{
					num = (short)1269628929;
					if (num != 0)
					{
					}
					return false;
				}
				break;
			}
			num = (short)2035023872;
			short num3 = num;
			return extMicNsRdGenDINCEPVECTOR_A.Value.Length == 64;
		}

		// Token: 0x06006C0E RID: 27662 RVA: 0x00606FF0 File Offset: 0x006051F0
		internal static bool ConACCAUTONSBDSDBQ8LengthEqualsTo8(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1041367040;
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
				global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_;
				for (;;)
				{
					IL_27:
					short num4;
					switch (num2)
					{
					case 0:
						if (extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_.Value == null)
						{
							num = (short)1510080521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1874133005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)571277313;
						if (num != 0)
						{
						}
						num = (short)1022427138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						short num3;
						if (num3 <= 0)
						{
							num = (short)1390018565;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (num4 >= -23040)
						{
							num = (short)2042167296;
							short num5 = num;
							num = (short)2009202695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
					{
						short num3;
						if (num3 >= -23040)
						{
							num = (short)1800667137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
						num = (short)1791819787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_23B;
					case 7:
						num = (short)908591110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)718390853;
						short num6 = num;
						num = (short)1780467269;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23B;
						default:
						{
							num = (short)269156352;
							if (num != 0)
							{
							}
							string value = extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_.Value.Substring(0, 4);
							string value2 = extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_.Value.Substring(4, 4);
							num4 = global::System.Convert.ToInt16(value, 16);
							short num3 = global::System.Convert.ToInt16(value2, 16);
							num = (short)648019971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						return false;
					case 10:
						num = (short)1088684036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						short num3;
						if (num4 <= num3)
						{
							num = (short)257490956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 12:
						return true;
					case 13:
						if (extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_.Value.Length == 8)
						{
							num = (short)1313931272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_66;
					IL_23B:
					if (num4 > 0)
					{
						return false;
					}
					num = (short)21299210;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_66:
				extMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_ = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).ExtMicNsRdGenACCESSORYAUTONOISEBOUNDSDBQ8_42686;
				num = (short)934281216;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06006C0F RID: 27663 RVA: 0x006072F0 File Offset: 0x006054F0
		internal static bool ConACCAUTOMINGAINVCTLengthEqualsTo8(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)374996992;
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
				global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_;
				for (;;)
				{
					IL_27:
					short num4;
					switch (num2)
					{
					case 0:
						if (extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_.Value == null)
						{
							num = (short)710869001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2040201217;
						if (num != 0)
						{
						}
						num = (short)312213517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)576978946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						short num3;
						if (num3 <= 32767)
						{
							num = (short)1124663301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (num4 >= 0)
						{
							num = (short)1326972928;
							short num5 = num;
							num = (short)1304231943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
					{
						short num3;
						if (num3 >= 0)
						{
							num = (short)1770455041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
						num = (short)1445920779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_23A;
					case 7:
						num = (short)396689414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)584732977;
						short num6 = num;
						num = (short)777605425;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23A;
						default:
						{
							num = (short)465174528;
							if (num != 0)
							{
							}
							string value = extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_.Value.Substring(0, 4);
							string value2 = extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_.Value.Substring(4, 4);
							num4 = global::System.Convert.ToInt16(value, 16);
							short num3 = global::System.Convert.ToInt16(value2, 16);
							num = (short)208273411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						return false;
					case 10:
						num = (short)1391591428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						short num3;
						if (num4 >= num3)
						{
							num = (short)1570963468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 12:
						return true;
					case 13:
						if (extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_.Value.Length == 8)
						{
							num = (short)1047134216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_66;
					IL_23A:
					if (num4 > 32767)
					{
						return false;
					}
					num = (short)2127101962;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_66:
				extMicNsRdGenACCESSORYAUTOMINGAINVECTOR_ = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).ExtMicNsRdGenACCESSORYAUTOMINGAINVECTOR_42687;
				num = (short)1387790336;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06006C10 RID: 27664 RVA: 0x006075F0 File Offset: 0x006057F0
		internal static bool ConACCAUTORELAXATIONBDSLengthEqualsTo4(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1101004800;
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
				global::AcpBusinessLayer.AcpField<string> extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_;
				for (;;)
				{
					IL_28:
					short num3;
					switch (num2)
					{
					case 0:
						if (extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_.Value == null)
						{
							num = (short)1741488137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1605828621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1555628034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num3 <= 10)
						{
							num = (short)1731592197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						short num4;
						if (num4 >= 0)
						{
							num = (short)1963261952;
							short num5 = num;
							num = (short)1268514823;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
					{
						short num4;
						if (num4 >= 0)
						{
							num = (short)738197505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
						num = (short)1285685259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_23A;
					case 7:
						num = (short)1409220614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)1817116673;
						if (num != 0)
						{
						}
						num = (short)586214213;
						short num6 = num;
						num = (short)344451909;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_23A;
						default:
						{
							num = (short)2132410368;
							if (num != 0)
							{
							}
							string value = extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_.Value.Substring(0, 2);
							string value2 = extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_.Value.Substring(2, 2);
							short num4 = global::System.Convert.ToInt16(value, 16);
							num3 = global::System.Convert.ToInt16(value2, 16);
							num = (short)1645805571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 9:
						return false;
					case 10:
						num = (short)713818116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						short num4;
						if (num4 <= num3)
						{
							num = (short)1835925516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 12:
						return true;
					case 13:
						if (extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_.Value.Length == 4)
						{
							num = (short)1290272776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_67;
					IL_23A:
					if (num3 > 10)
					{
						return false;
					}
					num = (short)1579155466;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_67:
				extMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_ = (self as global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.General).ExtMicNsRdGenACCESSORYAUTORELAXTIONBOUNDS_42688;
				num = (short)517210112;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
