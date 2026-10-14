using System;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000006 RID: 6
	public class CellRangeFillEndedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000019 RID: 25 RVA: 0x00003170 File Offset: 0x00001370
		public CellRangeFillEndedEventArgs(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange cellRange)
		{
			this.a = cellRange;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000318C File Offset: 0x0000138C
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange SelectionRange
		{
			get
			{
				short num = (short)1950351360;
				short num2 = num;
				num = (short)9620163;
				short num3 = num;
				num = (short)1097583299;
				switch (num3 == num)
				{
				}
				num = (short)1167327232;
				if (num != 0)
				{
				}
				num = (short)1632436225;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x04000007 RID: 7
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange a;
	}
}
