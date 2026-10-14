using System;

namespace NPOI.SS.Format
{
	// Token: 0x02000242 RID: 578
	public class CellNumberStringMod : global::System.IComparable<global::NPOI.SS.Format.CellNumberStringMod>
	{
		// Token: 0x06000E17 RID: 3607 RVA: 0x00028296 File Offset: 0x00026496
		public CellNumberStringMod(global::NPOI.SS.Format.CellNumberFormatter.Special special, string toAdd, int op)
		{
			this.special = special;
			this.toAdd = toAdd;
			this.op = op;
		}

		// Token: 0x06000E18 RID: 3608 RVA: 0x000282B3 File Offset: 0x000264B3
		public CellNumberStringMod(global::NPOI.SS.Format.CellNumberFormatter.Special start, bool startInclusive, global::NPOI.SS.Format.CellNumberFormatter.Special end, bool endInclusive, char toAdd) : this(start, startInclusive, end, endInclusive)
		{
			this.toAdd = (toAdd.ToString() ?? "");
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x000282D6 File Offset: 0x000264D6
		public CellNumberStringMod(global::NPOI.SS.Format.CellNumberFormatter.Special start, bool startInclusive, global::NPOI.SS.Format.CellNumberFormatter.Special end, bool endInclusive)
		{
			this.special = start;
			this.startInclusive = startInclusive;
			this.end = end;
			this.endInclusive = endInclusive;
			this.op = 3;
			this.toAdd = "";
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00028310 File Offset: 0x00026510
		public int CompareTo(global::NPOI.SS.Format.CellNumberStringMod that)
		{
			int num = this.special.pos - that.special.pos;
			if (num == 0)
			{
				return this.op - that.op;
			}
			return num;
		}

		// Token: 0x06000E1B RID: 3611 RVA: 0x00028348 File Offset: 0x00026548
		public override bool Equals(object that)
		{
			bool result;
			try
			{
				result = (this.CompareTo((global::NPOI.SS.Format.CellNumberStringMod)that) == 0);
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000E1C RID: 3612 RVA: 0x00028380 File Offset: 0x00026580
		public override int GetHashCode()
		{
			return this.special.GetHashCode() + this.op;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00028394 File Offset: 0x00026594
		public global::NPOI.SS.Format.CellNumberFormatter.Special GetSpecial()
		{
			return this.special;
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000E1E RID: 3614 RVA: 0x0002839C File Offset: 0x0002659C
		public int Op
		{
			get
			{
				return this.op;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x06000E1F RID: 3615 RVA: 0x000283A4 File Offset: 0x000265A4
		public string ToAdd
		{
			get
			{
				return this.toAdd;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x06000E20 RID: 3616 RVA: 0x000283AC File Offset: 0x000265AC
		public global::NPOI.SS.Format.CellNumberFormatter.Special End
		{
			get
			{
				return this.end;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000E21 RID: 3617 RVA: 0x000283B4 File Offset: 0x000265B4
		public bool IsStartInclusive
		{
			get
			{
				return this.startInclusive;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x000283BC File Offset: 0x000265BC
		public bool IsEndInclusive
		{
			get
			{
				return this.endInclusive;
			}
		}

		// Token: 0x04000646 RID: 1606
		public const int BEFORE = 1;

		// Token: 0x04000647 RID: 1607
		public const int AFTER = 2;

		// Token: 0x04000648 RID: 1608
		public const int REPLACE = 3;

		// Token: 0x04000649 RID: 1609
		private global::NPOI.SS.Format.CellNumberFormatter.Special special;

		// Token: 0x0400064A RID: 1610
		private int op;

		// Token: 0x0400064B RID: 1611
		private string toAdd;

		// Token: 0x0400064C RID: 1612
		private global::NPOI.SS.Format.CellNumberFormatter.Special end;

		// Token: 0x0400064D RID: 1613
		private bool startInclusive;

		// Token: 0x0400064E RID: 1614
		private bool endInclusive;
	}
}
