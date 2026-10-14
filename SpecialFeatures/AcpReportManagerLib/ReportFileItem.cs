using System;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x02000249 RID: 585
	internal static class ReportFileItem
	{
		// Token: 0x06001D40 RID: 7488 RVA: 0x002B0358 File Offset: 0x002AE558
		public static string GetFileNameByRptType(global::SpecialFeatures.AcpReportManagerLib.reportType rptType)
		{
			int a_ = 5;
			short num = (short)1382612993;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11C;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					num = (short)28508160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_39:
				switch (rptType)
				{
				case global::SpecialFeatures.AcpReportManagerLib.reportType.RadioInfo:
					goto IL_E6;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOut:
					goto IL_173;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO2:
					goto IL_164;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO3:
					goto IL_8B;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO7:
					goto IL_11E;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO5:
					goto IL_F5;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutO9:
					goto IL_12D;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.Choices:
					goto IL_182;
				case global::SpecialFeatures.AcpReportManagerLib.reportType.HandOutE5:
					goto IL_7C;
				default:
					num = (short)220659714;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_7C:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab薯", a_);
			IL_8B:
			num = (short)618991246;
			short num3 = num;
			num = (short)973606542;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11C:
				goto IL_182;
			default:
				num = (short)1213595648;
				if (num != 0)
				{
				}
				return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab莯", a_);
			}
			IL_E6:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda87ﾏ\udb91望\udc99힟쮣얥\udda7잩즫삭쒯", a_);
			IL_F5:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab薯", a_);
			IL_11E:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab螯", a_);
			IL_12D:
			num = (short)846594049;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab覯", a_);
			IL_164:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab芯", a_);
			IL_173:
			return global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삇\udf8f킕\uda9d쾟송톣쮥춧쒩\ud8ab", a_);
			IL_182:
			num = (short)451215360;
			short num4 = num;
			return string.Empty;
		}
	}
}
