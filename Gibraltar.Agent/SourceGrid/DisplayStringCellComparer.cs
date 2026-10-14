using System;
using System.Collections;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x020003BD RID: 957
	internal class DisplayStringCellComparer : global::System.Collections.IComparer
	{
		// Token: 0x06002BBE RID: 11198 RVA: 0x00092DB8 File Offset: 0x00090FB8
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
			string displayText = ((global::SourceGrid.Cells.ICell)x).DisplayText;
			string displayText2 = ((global::SourceGrid.Cells.ICell)y).DisplayText;
			if (displayText == null && displayText2 == null)
			{
				return 0;
			}
			if (displayText == null)
			{
				return -1;
			}
			if (displayText2 == null)
			{
				return 1;
			}
			return displayText.CompareTo(displayText2);
		}
	}
}
