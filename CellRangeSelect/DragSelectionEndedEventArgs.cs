using System;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x0200000F RID: 15
	public class DragSelectionEndedEventArgs : global::System.EventArgs
	{
		// Token: 0x0600008F RID: 143 RVA: 0x0000AB2C File Offset: 0x00008D2C
		public DragSelectionEndedEventArgs(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange cellRange)
		{
			this.a = cellRange;
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000090 RID: 144 RVA: 0x0000AB48 File Offset: 0x00008D48
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange SelectionRange
		{
			get
			{
				short num = (short)695431552;
				short num2 = num;
				num = (short)383218048;
				switch (num2 == num)
				{
				default:
				{
					num = (short)173146112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1269497857;
				if (num != 0)
				{
				}
				num = (short)977993728;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400003A RID: 58
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange a;
	}
}
