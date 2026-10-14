using System;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.ACPXMLCoreEngineLib
{
	// Token: 0x02000233 RID: 563
	public class XMLCoreEngineFactory
	{
		// Token: 0x06001C6F RID: 7279 RVA: 0x0026C88C File Offset: 0x0026AA8C
		public global::SpecialFeatures.ACPXMLCoreEngineLib.AcpBaseXMLCoreEngine MakeXMLCoreObj(global::SpecialFeatures.AcpReportManagerLib.reportType reporytype)
		{
			short num = (short)797048832;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
				{
					num = (short)418643968;
					short num3 = num;
					num = (short)864747522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_F1;
				}
				IL_32:
				switch (reporytype)
				{
				case global::SpecialFeatures.AcpReportManagerLib.reportType.RadioInfo:
				{
					num = (short)2039494886;
					short num4 = num;
					num = (short)1366178022;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_130;
					}
					break;
				}
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOut:
					goto IL_A5;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO2:
					goto IL_151;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO3:
					goto IL_14B;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO7:
					goto IL_72;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO5:
					goto IL_F3;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO9:
					goto IL_AB;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.Choices:
					goto IL_157;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutE5:
					goto IL_78;
				}
				num = (short)1873084417;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_72:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.O7XMLCoreEngine();
			IL_78:
			num = (short)2036072449;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.E5XMLCoreEngine();
			IL_A5:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.HandOutXMLCoreEngine();
			IL_AB:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.O9XMLCoreEngine();
			IL_F1:
			goto IL_157;
			IL_F3:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.O5XMLCoreEngine();
			IL_130:
			num = (short)1182793728;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.BaseRadioInfoXMLCoreEngine();
			IL_14B:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.O3XMLCoreEngine();
			IL_151:
			return new global::SpecialFeatures.ACPXMLCoreEngineLib.O2XMLCoreEngine();
			IL_157:
			return null;
		}
	}
}
