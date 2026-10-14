using System;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000015 RID: 21
	public class CellRangeFillStartedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000078 RID: 120 RVA: 0x000092F8 File Offset: 0x000074F8
		public CellRangeFillStartedEventArgs(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange cellRange)
		{
			this.a = cellRange;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00009314 File Offset: 0x00007514
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange SelectionRange
		{
			get
			{
				short num = (short)1022858123;
				short num2 = num;
				num = (short)1047303051;
				switch (num2 == num)
				{
				}
				num = (short)1043398657;
				if (num != 0)
				{
				}
				num = (short)1170866176;
				if (num != 0)
				{
				}
				num = (short)1636302848;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x04000039 RID: 57
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange a;
	}
}
