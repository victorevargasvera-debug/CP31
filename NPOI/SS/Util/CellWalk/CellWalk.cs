using System;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util.CellWalk
{
	// Token: 0x02000031 RID: 49
	public class CellWalk
	{
		// Token: 0x060001E4 RID: 484 RVA: 0x00008E86 File Offset: 0x00007086
		public CellWalk(global::NPOI.SS.UserModel.ISheet sheet, global::NPOI.SS.Util.CellRangeAddress range)
		{
			this.sheet = sheet;
			this.range = range;
			this.traverseEmptyCells = false;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00008EA3 File Offset: 0x000070A3
		public bool IsTraverseEmptyCells()
		{
			return this.traverseEmptyCells;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00008EAB File Offset: 0x000070AB
		public void SetTraverseEmptyCells(bool traverseEmptyCells)
		{
			this.traverseEmptyCells = traverseEmptyCells;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00008EB4 File Offset: 0x000070B4
		public void Traverse(global::NPOI.SS.Util.CellWalk.ICellHandler handler)
		{
			int firstRow = this.range.FirstRow;
			int lastRow = this.range.LastRow;
			int firstColumn = this.range.FirstColumn;
			int lastColumn = this.range.LastColumn;
			int num = lastColumn - firstColumn + 1;
			global::NPOI.SS.Util.CellWalk.CellWalk.SimpleCellWalkContext simpleCellWalkContext = new global::NPOI.SS.Util.CellWalk.CellWalk.SimpleCellWalkContext();
			simpleCellWalkContext.rowNumber = firstRow;
			while (simpleCellWalkContext.rowNumber <= lastRow)
			{
				global::NPOI.SS.UserModel.IRow row = this.sheet.GetRow(simpleCellWalkContext.rowNumber);
				if (row != null)
				{
					simpleCellWalkContext.colNumber = firstColumn;
					while (simpleCellWalkContext.colNumber <= lastColumn)
					{
						global::NPOI.SS.UserModel.ICell cell = row.GetCell(simpleCellWalkContext.colNumber);
						if (cell != null && (!this.IsEmpty(cell) || this.traverseEmptyCells))
						{
							simpleCellWalkContext.ordinalNumber = (long)((simpleCellWalkContext.rowNumber - firstRow) * num + (simpleCellWalkContext.colNumber - firstColumn + 1));
							handler.OnCell(cell, simpleCellWalkContext);
						}
						simpleCellWalkContext.colNumber++;
					}
				}
				simpleCellWalkContext.rowNumber++;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00008FB9 File Offset: 0x000071B9
		private bool IsEmpty(global::NPOI.SS.UserModel.ICell cell)
		{
			return cell.CellType == global::NPOI.SS.UserModel.CellType.Blank;
		}

		// Token: 0x040000AC RID: 172
		private global::NPOI.SS.UserModel.ISheet sheet;

		// Token: 0x040000AD RID: 173
		private global::NPOI.SS.Util.CellRangeAddress range;

		// Token: 0x040000AE RID: 174
		private bool traverseEmptyCells;

		// Token: 0x02000559 RID: 1369
		private class SimpleCellWalkContext : global::NPOI.SS.Util.CellWalk.ICellWalkContext
		{
			// Token: 0x17000D88 RID: 3464
			// (get) Token: 0x06003387 RID: 13191 RVA: 0x000A1238 File Offset: 0x0009F438
			public long OrdinalNumber
			{
				get
				{
					return this.ordinalNumber;
				}
			}

			// Token: 0x17000D89 RID: 3465
			// (get) Token: 0x06003388 RID: 13192 RVA: 0x000A1240 File Offset: 0x0009F440
			public int RowNumber
			{
				get
				{
					return this.rowNumber;
				}
			}

			// Token: 0x17000D8A RID: 3466
			// (get) Token: 0x06003389 RID: 13193 RVA: 0x000A1248 File Offset: 0x0009F448
			public int ColumnNumber
			{
				get
				{
					return this.colNumber;
				}
			}

			// Token: 0x04001874 RID: 6260
			public long ordinalNumber;

			// Token: 0x04001875 RID: 6261
			public int rowNumber;

			// Token: 0x04001876 RID: 6262
			public int colNumber;
		}
	}
}
