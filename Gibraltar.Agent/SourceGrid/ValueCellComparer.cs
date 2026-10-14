using System;
using System.Collections;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x020003BB RID: 955
	internal class ValueCellComparer : global::System.Collections.IComparer
	{
		// Token: 0x06002BBA RID: 11194 RVA: 0x00092BF4 File Offset: 0x00090DF4
		public virtual int Compare(object x, object y)
		{
			if (x == null && y == null)
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			if (x is global::System.IComparable)
			{
				return ((global::System.IComparable)x).CompareTo(y);
			}
			if (y is global::System.IComparable)
			{
				return -1 * ((global::System.IComparable)y).CompareTo(x);
			}
			object value = ((global::SourceGrid.Cells.ICell)x).Value;
			object value2 = ((global::SourceGrid.Cells.ICell)y).Value;
			if (value == null && value2 == null)
			{
				return 0;
			}
			if (value == null)
			{
				return -1;
			}
			if (value2 == null)
			{
				return 1;
			}
			if (value is global::System.IComparable)
			{
				return ((global::System.IComparable)value).CompareTo(value2);
			}
			if (value2 is global::System.IComparable)
			{
				return -1 * ((global::System.IComparable)value2).CompareTo(value);
			}
			throw new global::System.ArgumentException("Invalid cell object, no IComparable interface found");
		}
	}
}
