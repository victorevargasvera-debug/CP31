using System;
using System.Collections;
using System.Collections.Generic;

namespace NPOI.SS.Util
{
	// Token: 0x0200000E RID: 14
	public class CellRangeUtil
	{
		// Token: 0x06000087 RID: 135 RVA: 0x0000253E File Offset: 0x0000073E
		private CellRangeUtil()
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002C00 File Offset: 0x00000E00
		public static int Intersect(global::NPOI.SS.Util.CellRangeAddress crA, global::NPOI.SS.Util.CellRangeAddress crB)
		{
			int firstRow = crB.FirstRow;
			int lastRow = crB.LastRow;
			int firstColumn = crB.FirstColumn;
			int lastColumn = crB.LastColumn;
			if (global::NPOI.SS.Util.CellRangeUtil.gt(crA.FirstRow, lastRow) || global::NPOI.SS.Util.CellRangeUtil.lt(crA.LastRow, firstRow) || global::NPOI.SS.Util.CellRangeUtil.gt(crA.FirstColumn, lastColumn) || global::NPOI.SS.Util.CellRangeUtil.lt(crA.LastColumn, firstColumn))
			{
				return 1;
			}
			if (global::NPOI.SS.Util.CellRangeUtil.Contains(crA, crB))
			{
				return 3;
			}
			if (global::NPOI.SS.Util.CellRangeUtil.Contains(crB, crA))
			{
				return 4;
			}
			return 2;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002C7A File Offset: 0x00000E7A
		public static global::NPOI.SS.Util.CellRangeAddress[] MergeCellRanges(global::NPOI.SS.Util.CellRangeAddress[] cellRanges)
		{
			if (cellRanges.Length < 1)
			{
				return new global::NPOI.SS.Util.CellRangeAddress[0];
			}
			return global::NPOI.SS.Util.CellRangeUtil.MergeCellRanges(new global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress>(cellRanges)).ToArray();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002C9C File Offset: 0x00000E9C
		private static global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> MergeCellRanges(global::System.Collections.Generic.List<global::NPOI.SS.Util.CellRangeAddress> cellRangeList)
		{
			while (cellRangeList.Count > 1)
			{
				bool flag = false;
				for (int i = 0; i < cellRangeList.Count; i++)
				{
					global::NPOI.SS.Util.CellRangeAddress range = cellRangeList[i];
					for (int j = i + 1; j < cellRangeList.Count; j++)
					{
						global::NPOI.SS.Util.CellRangeAddress range2 = cellRangeList[j];
						global::NPOI.SS.Util.CellRangeAddress[] array = global::NPOI.SS.Util.CellRangeUtil.MergeRanges(range, range2);
						if (array != null)
						{
							flag = true;
							cellRangeList[i] = array[0];
							cellRangeList.RemoveAt(j--);
							for (int k = 1; k < array.Length; k++)
							{
								j++;
								cellRangeList.Insert(j, array[k]);
							}
						}
					}
				}
				if (!flag)
				{
					break;
				}
			}
			return cellRangeList;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002D40 File Offset: 0x00000F40
		private static global::NPOI.SS.Util.CellRangeAddress[] MergeRanges(global::NPOI.SS.Util.CellRangeAddress range1, global::NPOI.SS.Util.CellRangeAddress range2)
		{
			int num = global::NPOI.SS.Util.CellRangeUtil.Intersect(range1, range2);
			switch (num)
			{
			case 1:
				if (global::NPOI.SS.Util.CellRangeUtil.HasExactSharedBorder(range1, range2))
				{
					return new global::NPOI.SS.Util.CellRangeAddress[]
					{
						global::NPOI.SS.Util.CellRangeUtil.CreateEnclosingCellRange(range1, range2)
					};
				}
				return null;
			case 2:
				return null;
			case 3:
				return new global::NPOI.SS.Util.CellRangeAddress[]
				{
					range1
				};
			case 4:
				return new global::NPOI.SS.Util.CellRangeAddress[]
				{
					range2
				};
			default:
				throw new global::System.InvalidOperationException("unexpected intersection result (" + num.ToString() + ")");
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002DBE File Offset: 0x00000FBE
		[global::System.Obsolete]
		private static global::NPOI.SS.Util.CellRangeAddress[] ToArray(global::System.Collections.ArrayList temp)
		{
			new global::NPOI.SS.Util.CellRangeAddress[temp.Count];
			return (global::NPOI.SS.Util.CellRangeAddress[])temp.ToArray(typeof(global::NPOI.SS.Util.CellRangeAddress));
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002DE4 File Offset: 0x00000FE4
		public static bool Contains(global::NPOI.SS.Util.CellRangeAddress crA, global::NPOI.SS.Util.CellRangeAddress crB)
		{
			return global::NPOI.SS.Util.CellRangeUtil.le(crA.FirstRow, crB.FirstRow) && global::NPOI.SS.Util.CellRangeUtil.ge(crA.LastRow, crB.LastRow) && global::NPOI.SS.Util.CellRangeUtil.le(crA.FirstColumn, crB.FirstColumn) && global::NPOI.SS.Util.CellRangeUtil.ge(crA.LastColumn, crB.LastColumn);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002E40 File Offset: 0x00001040
		public static bool HasExactSharedBorder(global::NPOI.SS.Util.CellRangeAddress crA, global::NPOI.SS.Util.CellRangeAddress crB)
		{
			int firstRow = crB.FirstRow;
			int lastRow = crB.LastRow;
			int firstColumn = crB.FirstColumn;
			int lastColumn = crB.LastColumn;
			if ((crA.FirstRow > 0 && crA.FirstRow - 1 == lastRow) || (firstRow > 0 && firstRow - 1 == crA.LastRow))
			{
				return crA.FirstColumn == firstColumn && crA.LastColumn == lastColumn;
			}
			return ((crA.FirstColumn > 0 && crA.FirstColumn - 1 == lastColumn) || (firstColumn > 0 && crA.LastColumn == firstColumn - 1)) && crA.FirstRow == firstRow && crA.LastRow == lastRow;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002EDC File Offset: 0x000010DC
		public static global::NPOI.SS.Util.CellRangeAddress CreateEnclosingCellRange(global::NPOI.SS.Util.CellRangeAddress crA, global::NPOI.SS.Util.CellRangeAddress crB)
		{
			if (crB == null)
			{
				return crA.Copy();
			}
			int firstRow = global::NPOI.SS.Util.CellRangeUtil.lt(crB.FirstRow, crA.FirstRow) ? crB.FirstRow : crA.FirstRow;
			int lastRow = global::NPOI.SS.Util.CellRangeUtil.gt(crB.LastRow, crA.LastRow) ? crB.LastRow : crA.LastRow;
			int firstCol = global::NPOI.SS.Util.CellRangeUtil.lt(crB.FirstColumn, crA.FirstColumn) ? crB.FirstColumn : crA.FirstColumn;
			int lastCol = global::NPOI.SS.Util.CellRangeUtil.gt(crB.LastColumn, crA.LastColumn) ? crB.LastColumn : crA.LastColumn;
			return new global::NPOI.SS.Util.CellRangeAddress(firstRow, lastRow, firstCol, lastCol);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002F82 File Offset: 0x00001182
		private static bool lt(int a, int b)
		{
			return a != -1 && (b == -1 || a < b);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002F94 File Offset: 0x00001194
		private static bool le(int a, int b)
		{
			return a == b || global::NPOI.SS.Util.CellRangeUtil.lt(a, b);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002FA3 File Offset: 0x000011A3
		private static bool gt(int a, int b)
		{
			return global::NPOI.SS.Util.CellRangeUtil.lt(b, a);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002FAC File Offset: 0x000011AC
		private static bool ge(int a, int b)
		{
			return !global::NPOI.SS.Util.CellRangeUtil.lt(a, b);
		}

		// Token: 0x0400001B RID: 27
		public const int NO_INTERSECTION = 1;

		// Token: 0x0400001C RID: 28
		public const int OVERLAP = 2;

		// Token: 0x0400001D RID: 29
		public const int INSIDE = 3;

		// Token: 0x0400001E RID: 30
		public const int ENCLOSES = 4;
	}
}
