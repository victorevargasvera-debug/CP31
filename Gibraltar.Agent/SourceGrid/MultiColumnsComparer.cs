using System;
using System.Collections;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x020003BC RID: 956
	internal class MultiColumnsComparer : global::System.Collections.IComparer
	{
		// Token: 0x06002BBC RID: 11196 RVA: 0x00092CD0 File Offset: 0x00090ED0
		public MultiColumnsComparer(params int[] secondarySortColumns)
		{
			this.m_SecondarySortColumns = secondarySortColumns;
		}

		// Token: 0x06002BBD RID: 11197 RVA: 0x00092CEC File Offset: 0x00090EEC
		public virtual int Compare(object x, object y)
		{
			int num = this.m_defaultComparer.Compare(x, y);
			if (num == 0)
			{
				global::SourceGrid.Grid grid = ((global::SourceGrid.Cells.ICell)x).Grid;
				int row = ((global::SourceGrid.Cells.ICell)x).Range.Start.Row;
				int row2 = ((global::SourceGrid.Cells.ICell)y).Range.Start.Row;
				for (int i = 0; i < this.m_SecondarySortColumns.Length; i++)
				{
					global::SourceGrid.Cells.ICellVirtual cell = grid.GetCell(row, this.m_SecondarySortColumns[i]);
					global::SourceGrid.Cells.ICellVirtual cell2 = grid.GetCell(row2, this.m_SecondarySortColumns[i]);
					int num2 = this.m_defaultComparer.Compare(cell, cell2);
					if (num2 != 0)
					{
						return num2;
					}
				}
				return 0;
			}
			return num;
		}

		// Token: 0x04000EA4 RID: 3748
		private global::System.Collections.IComparer m_defaultComparer = new global::SourceGrid.ValueCellComparer();

		// Token: 0x04000EA5 RID: 3749
		private int[] m_SecondarySortColumns;
	}
}
