using System;

namespace Motorola.CommonCPS.UI.CellRangeSelect
{
	// Token: 0x02000010 RID: 16
	public class DragSelectionStartedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000ABF8 File Offset: 0x00008DF8
		public DragSelectionStartedEventArgs(global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange cellRange)
		{
			this.a = cellRange;
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000092 RID: 146 RVA: 0x0000AC14 File Offset: 0x00008E14
		public global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange SelectionRange
		{
			get
			{
				short num = (short)2108488334;
				short num2 = num;
				num = (short)272956046;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1742405632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)920322048;
				if (num != 0)
				{
				}
				num = (short)1782513665;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x0400003B RID: 59
		private global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange a;
	}
}
