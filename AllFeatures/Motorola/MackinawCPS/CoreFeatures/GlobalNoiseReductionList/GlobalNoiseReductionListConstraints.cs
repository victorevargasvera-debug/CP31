using System;
using AcpBusinessLayer;
using AcpCommonLib;

namespace Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList
{
	// Token: 0x02000256 RID: 598
	public static class GlobalNoiseReductionListConstraints
	{
		// Token: 0x06006B1C RID: 27420 RVA: 0x005FA950 File Offset: 0x005F8B50
		internal static bool ConDincSpatialEq1VectorLengthEqualsTo248(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)885653504;
			short num2 = num;
			num = (short)510644555;
			short num3 = num;
			num = (short)806211915;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)974323713;
				if (num != 0)
				{
				}
				num = (short)1153171456;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincspatialeq1VECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCSPATIALEQ1VECTOR_A21553;
				if (dincspatialeq1VECTOR_A.Value != null)
				{
					return dincspatialeq1VECTOR_A.Value.Length == 248;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06006B1D RID: 27421 RVA: 0x005FAA24 File Offset: 0x005F8C24
		internal static bool ConDincSpatialEq2VectorLengthEqualsTo248(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1044971520;
			short num2 = num;
			num = (short)2045563095;
			short num3 = num;
			num = (short)1338757335;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2027749377;
				if (num != 0)
				{
				}
				num = (short)1853685760;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincspatialeq2VECTOR_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCSPATIALEQ2VECTOR_A21556;
				if (dincspatialeq2VECTOR_A.Value != null)
				{
					return dincspatialeq2VECTOR_A.Value.Length == 248;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06006B1E RID: 27422 RVA: 0x005FAAF8 File Offset: 0x005F8CF8
		internal static bool ConDincBfEqVectorLengthEqualsTo124(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1099628544;
			short num2 = num;
			num = (short)2054893157;
			short num3 = num;
			num = (short)1174416997;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)557121536;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincbfeqvector_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCBFEQVECTOR_A21557;
				if (dincbfeqvector_A.Value != null)
				{
					num = (short)1611071489;
					if (num != 0)
					{
					}
					return dincbfeqvector_A.Value.Length == 124;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06006B1F RID: 27423 RVA: 0x005FABCC File Offset: 0x005F8DCC
		internal static bool ConDincOutputEqVectorLengthEqualsTo124(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)703135744;
			short num2 = num;
			num = (short)1515934239;
			short num3 = num;
			num = (short)1616597535;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1563492353;
				if (num != 0)
				{
				}
				num = (short)1512308736;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincoutputeqvector_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCOUTPUTEQVECTOR_A21558;
				if (dincoutputeqvector_A.Value != null)
				{
					return dincoutputeqvector_A.Value.Length == 124;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06006B20 RID: 27424 RVA: 0x005FAC9C File Offset: 0x005F8E9C
		internal static bool ConDincElkoVectorLengthEqualsTo64(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)122486784;
			short num2 = num;
			num = (short)1126253632;
			short num3 = num;
			num = (short)596264000;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1663762433;
				if (num != 0)
				{
				}
				num = (short)1359740928;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincelkovector_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCELKOVECTOR_A21561;
				if (dincelkovector_A.Value != null)
				{
					return dincelkovector_A.Value.Length == 64;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06006B21 RID: 27425 RVA: 0x005FAD70 File Offset: 0x005F8F70
		internal static bool ConDincSpatialEq1VectorContLngIs16BCH(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)35127296;
			short num2 = num;
			num = (short)114732724;
			short num3 = num;
			num = (short)1872539316;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1309999104;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincspatialeq1VECTORCONT_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCSPATIALEQ1VECTORCONT_A37716;
				if (dincspatialeq1VECTORCONT_A.Value != null)
				{
					return dincspatialeq1VECTORCONT_A.Value.Length == 16;
				}
				break;
			}
			}
			num = (short)2132606977;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06006B22 RID: 27426 RVA: 0x005FAE40 File Offset: 0x005F9040
		internal static bool ConDincSpatialEq2VectorContLngIs16BCH(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1026031616;
			short num2 = num;
			num = (short)2069601204;
			short num3 = num;
			num = (short)2086837172;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1159135232;
				if (num != 0)
				{
				}
				num = (short)1473445889;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpField<string> dincspatialeq2VECTORCONT_A = (self as global::Motorola.MackinawCPS.CoreFeatures.GlobalNoiseReductionList.General).DINCSPATIALEQ2VECTORCONT_A37717;
				if (dincspatialeq2VECTORCONT_A.Value != null)
				{
					return dincspatialeq2VECTORCONT_A.Value.Length == 16;
				}
				break;
			}
			}
			return false;
		}
	}
}
