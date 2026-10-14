using System;
using System.Collections.Generic;
using System.Linq;
using NPOI.SS.Formula;
using NPOI.SS.Util;

namespace NPOI.SS.UserModel.Helpers
{
	// Token: 0x020000AA RID: 170
	public abstract class RowShifter
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x0000D9E9 File Offset: 0x0000BBE9
		public RowShifter(global::NPOI.SS.UserModel.ISheet sh)
		{
			this.sheet = sh;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000D9F8 File Offset: 0x0000BBF8
		public global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> ShiftMergedRegions(int startRow, int endRow, int n)
		{
			global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> list = new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>();
			global::System.Collections.Generic.ISet<int> set = new global::System.Collections.Generic.HashSet<int>();
			int numMergedRegions = this.sheet.NumMergedRegions;
			for (int i = 0; i < numMergedRegions; i++)
			{
				global::NPOI.SS.Util.CellRangeAddress mergedRegion = this.sheet.GetMergedRegion(i);
				if (startRow + n <= mergedRegion.FirstRow && endRow + n >= mergedRegion.LastRow)
				{
					set.Add(i);
				}
				else
				{
					bool flag = mergedRegion.FirstRow >= startRow || mergedRegion.LastRow >= startRow;
					bool flag2 = mergedRegion.FirstRow <= endRow || mergedRegion.LastRow <= endRow;
					if (flag && flag2 && !mergedRegion.ContainsRow(startRow - 1) && !mergedRegion.ContainsRow(endRow + 1))
					{
						mergedRegion.FirstRow += n;
						mergedRegion.LastRow += n;
						list.Add(mergedRegion);
						set.Add(i);
					}
				}
			}
			if (set.Count != 0)
			{
				this.sheet.RemoveMergedRegions(set.ToList<int>());
			}
			foreach (global::NPOI.SS.Util.CellRangeAddress region in list)
			{
				this.sheet.AddMergedRegion(region);
			}
			return list;
		}

		// Token: 0x060005E3 RID: 1507
		public abstract void UpdateNamedRanges(global::NPOI.SS.Formula.FormulaShifter Shifter);

		// Token: 0x060005E4 RID: 1508
		public abstract void UpdateFormulas(global::NPOI.SS.Formula.FormulaShifter Shifter);

		// Token: 0x060005E5 RID: 1509
		public abstract void UpdateRowFormulas(global::NPOI.SS.UserModel.IRow row, global::NPOI.SS.Formula.FormulaShifter Shifter);

		// Token: 0x060005E6 RID: 1510
		public abstract void UpdateConditionalFormatting(global::NPOI.SS.Formula.FormulaShifter Shifter);

		// Token: 0x060005E7 RID: 1511
		public abstract void UpdateHyperlinks(global::NPOI.SS.Formula.FormulaShifter Shifter);

		// Token: 0x04000389 RID: 905
		protected global::NPOI.SS.UserModel.ISheet sheet;
	}
}
