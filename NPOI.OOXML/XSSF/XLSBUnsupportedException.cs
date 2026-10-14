using System;

namespace NPOI.XSSF
{
	// Token: 0x02000057 RID: 87
	public class XLSBUnsupportedException : global::NPOI.UnsupportedFileFormatException
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x000100B4 File Offset: 0x0000E2B4
		public XLSBUnsupportedException() : base(global::NPOI.XSSF.XLSBUnsupportedException.MESSAGE)
		{
		}

		// Token: 0x0400024B RID: 587
		public static string MESSAGE = ".XLSB Binary Workbooks are not supported";
	}
}
