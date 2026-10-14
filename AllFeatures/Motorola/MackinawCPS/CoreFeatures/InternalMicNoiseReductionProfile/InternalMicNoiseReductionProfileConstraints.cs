using System;
using AcpBusinessLayer;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x0200024E RID: 590
	public static class InternalMicNoiseReductionProfileConstraints
	{
		// Token: 0x060068BD RID: 26813 RVA: 0x005DC0F0 File Offset: 0x005DA2F0
		internal static bool ConIntMicMaxVectorsLengthNoLessThan128(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<string> radErgoCfgGeneralMAXSVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).RadErgoCfgGeneralMAXSVECTOR_A21565;
			if (radErgoCfgGeneralMAXSVECTOR_A.Value == null)
			{
				short num;
				for (;;)
				{
					num = (short)1487798272;
					short num2 = num;
					num = (short)117791578;
					short num3 = num;
					num = (short)794516314;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7B;
					}
				}
				IL_7B:
				num = (short)1605828609;
				if (num != 0)
				{
				}
				num = (short)523436032;
				if (num != 0)
				{
				}
				return false;
			}
			return radErgoCfgGeneralMAXSVECTOR_A.Value.Length >= 128;
		}

		// Token: 0x060068BE RID: 26814 RVA: 0x005DC1CC File Offset: 0x005DA3CC
		internal static bool ConIntMicDincOutputEqVectorLengthEqualsTo124(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<string> intMicNsRdGenDINCOUTPUTEQVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).IntMicNsRdGenDINCOUTPUTEQVECTOR_A37718;
			if (intMicNsRdGenDINCOUTPUTEQVECTOR_A.Value == null)
			{
				short num;
				for (;;)
				{
					num = (short)291307520;
					short num2 = num;
					num = (short)1307253267;
					short num3 = num;
					num = (short)1239816723;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)204865537;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				if (num != 0)
				{
				}
				return false;
			}
			return intMicNsRdGenDINCOUTPUTEQVECTOR_A.Value.Length == 124;
		}

		// Token: 0x060068BF RID: 26815 RVA: 0x005DC29C File Offset: 0x005DA49C
		internal static bool ConIntMicDincEPVectorLengthEqualsTo64(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<string> intMicNsRdGenDINCEPVECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).IntMicNsRdGenDINCEPVECTOR_A37719;
			if (intMicNsRdGenDINCEPVECTOR_A.Value == null)
			{
				short num;
				for (;;)
				{
					num = (short)642711552;
					short num2 = num;
					num = (short)649428347;
					short num3 = num;
					num = (short)325483899;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_76;
					}
				}
				IL_76:
				num = (short)1143734273;
				if (num != 0)
				{
				}
				num = (short)1028063232;
				if (num != 0)
				{
				}
				return false;
			}
			return intMicNsRdGenDINCEPVECTOR_A.Value.Length == 64;
		}

		// Token: 0x060068C0 RID: 26816 RVA: 0x005DC370 File Offset: 0x005DA570
		internal static bool ConRADAUTONSBDSDBQ8LengthEqualsTo8(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)177995776;
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
				global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						string value = intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_.Value.Substring(0, 4);
						string value2 = intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_.Value.Substring(4, 4);
						short num3 = global::System.Convert.ToInt16(value, 16);
						short num4 = global::System.Convert.ToInt16(value2, 16);
						goto IL_2BC;
					}
					case 1:
					{
						num = (short)16646144;
						short num5 = num;
						num = (short)682557445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						short num3;
						if (num3 >= -23040)
						{
							num = (short)1606090765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_.Value == null)
						{
							num = (short)1943339016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)160956426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
					{
						short num4;
						if (num4 <= 0)
						{
							num = (short)1055522828;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
						num = (short)1589313543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						short num4;
						if (num4 >= -23040)
						{
							num = (short)346030081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
						return false;
					case 9:
					{
						short num3;
						short num4;
						if (num3 <= num4)
						{
							num = (short)1290600452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						if (intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_.Value.Length == 8)
						{
							num = (short)14548993;
							if (num != 0)
							{
							}
							num = (short)2139160576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						short num3;
						if (num3 > 0)
						{
							return false;
						}
						num = (short)658226934;
						short num6 = num;
						num = (short)2003287798;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2BC;
						default:
							num = (short)1874657280;
							if (num != 0)
							{
							}
							num = (short)609157126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						num = (short)737214473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1473052683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
					IL_2BC:
					num = (short)1019084802;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_67:
				intMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_ = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).IntMicNsRdGenRADIOAUTONOISEBOUNDSDBQ8_42676;
				num = (short)912064515;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060068C1 RID: 26817 RVA: 0x005DC678 File Offset: 0x005DA878
		internal static bool ConRADAUTOMINGAINVCTLengthEqualsTo8(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)475136000;
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
				global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTOMINGAINVECTOR_;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)967114753;
						if (num != 0)
						{
						}
						string value = intMicNsRdGenRADIOAUTOMINGAINVECTOR_.Value.Substring(0, 4);
						string value2 = intMicNsRdGenRADIOAUTOMINGAINVECTOR_.Value.Substring(4, 4);
						short num3 = global::System.Convert.ToInt16(value, 16);
						short num4 = global::System.Convert.ToInt16(value2, 16);
						goto IL_2BE;
					}
					case 1:
					{
						num = (short)967770112;
						short num5 = num;
						num = (short)95748101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						short num3;
						if (num3 >= 0)
						{
							num = (short)54198285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (intMicNsRdGenRADIOAUTOMINGAINVECTOR_.Value == null)
						{
							num = (short)1968832520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)932511754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
					{
						short num4;
						if (num4 <= 32767)
						{
							num = (short)527237132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
						num = (short)1855913991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						short num4;
						if (num4 >= 0)
						{
							num = (short)478085121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
						return false;
					case 9:
					{
						short num3;
						short num4;
						if (num3 >= num4)
						{
							num = (short)917635076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						if (intMicNsRdGenRADIOAUTOMINGAINVECTOR_.Value.Length == 8)
						{
							num = (short)34603008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						short num3;
						if (num3 > 32767)
						{
							return false;
						}
						num = (short)711818588;
						short num6 = num;
						num = (short)223444316;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2BE;
						default:
							num = (short)1497759744;
							if (num != 0)
							{
							}
							num = (short)474611718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						num = (short)695336969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1651769355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
					IL_2BE:
					num = (short)1080295426;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_67:
				intMicNsRdGenRADIOAUTOMINGAINVECTOR_ = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).IntMicNsRdGenRADIOAUTOMINGAINVECTOR_42677;
				num = (short)1510998019;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x005DC980 File Offset: 0x005DAB80
		internal static bool ConRADAUTORELAXTIONBDSEqualsTo4(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)136839168;
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
				global::AcpBusinessLayer.AcpField<string> intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						string value = intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_.Value.Substring(0, 2);
						string value2 = intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_.Value.Substring(2, 2);
						short num3 = global::System.Convert.ToInt16(value, 16);
						short num4 = global::System.Convert.ToInt16(value2, 16);
						goto IL_2B5;
					}
					case 1:
						num = (short)1550057477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						short num3;
						if (num3 >= 0)
						{
							num = (short)261029901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 3:
						if (intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_.Value == null)
						{
							num = (short)1901920264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)233046026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
					{
						short num4;
						if (num4 <= 10)
						{
							num = (short)502530060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
						num = (short)1985216519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)908525569;
						if (num != 0)
						{
						}
						short num3;
						if (num3 >= 0)
						{
							num = (short)206176256;
							short num5 = num;
							num = (short)658440193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
						return false;
					case 9:
					{
						short num3;
						short num4;
						if (num3 <= num4)
						{
							num = (short)1934753796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						if (intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_.Value.Length == 4)
						{
							num = (short)1051590656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						short num4;
						if (num4 > 10)
						{
							return false;
						}
						num = (short)1925426794;
						short num6 = num;
						num = (short)1674161770;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B5;
						default:
							num = (short)867368960;
							if (num != 0)
							{
							}
							num = (short)1616248838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
						num = (short)1872494601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)693764107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_66;
					IL_2B5:
					num = (short)1945239554;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_66:
				intMicNsRdGenRADIOAUTORELAXTIONBOUNDS_ = (self as global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.General).IntMicNsRdGenRADIOAUTORELAXTIONBOUNDS_42678;
				num = (short)1025310723;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
