using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Spreadsheet;

namespace NPOI.XSSF.Util
{
	// Token: 0x02000058 RID: 88
	public class CTColComparator : global::System.Collections.Generic.Comparer<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col>
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x000100D0 File Offset: 0x0000E2D0
		public override int Compare(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col o1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col o2)
		{
			if (o1.min < o2.min)
			{
				return -1;
			}
			if (o1.min > o2.min)
			{
				return 1;
			}
			if (o1.max < o2.max)
			{
				return -1;
			}
			if (o1.max > o2.max)
			{
				return 1;
			}
			return 0;
		}

		// Token: 0x0400024C RID: 588
		public static global::System.Collections.Generic.IComparer<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> BY_MAX = new global::NPOI.XSSF.Util.CTColComparator.CTColComparatorByMax();

		// Token: 0x0400024D RID: 589
		public static global::System.Collections.Generic.IComparer<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col> BY_MIN_MAX = new global::NPOI.XSSF.Util.CTColComparator.CTColComparatorByMinMax();

		// Token: 0x02000122 RID: 290
		public class CTColComparatorByMinMax : global::NPOI.XSSF.Util.CTColComparator
		{
			// Token: 0x06000FDE RID: 4062 RVA: 0x000382CC File Offset: 0x000364CC
			public override int Compare(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2)
			{
				long num = (long)((ulong)col1.min);
				long num2 = (long)((ulong)col2.min);
				if (num < num2)
				{
					return -1;
				}
				if (num <= num2)
				{
					return global::NPOI.XSSF.Util.CTColComparator.BY_MAX.Compare(col1, col2);
				}
				return 1;
			}
		}

		// Token: 0x02000123 RID: 291
		public class CTColComparatorByMax : global::NPOI.XSSF.Util.CTColComparator
		{
			// Token: 0x06000FE0 RID: 4064 RVA: 0x0003830C File Offset: 0x0003650C
			public override int Compare(global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col1, global::NPOI.OpenXmlFormats.Spreadsheet.CT_Col col2)
			{
				long num = (long)((ulong)col1.max);
				long num2 = (long)((ulong)col2.max);
				if (num < num2)
				{
					return -1;
				}
				if (num <= num2)
				{
					return 0;
				}
				return 1;
			}
		}
	}
}
