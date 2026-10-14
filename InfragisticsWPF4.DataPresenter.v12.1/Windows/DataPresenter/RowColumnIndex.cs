using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200008E RID: 142
	internal class RowColumnIndex : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.RowColumnIndex>
	{
		// Token: 0x060006E3 RID: 1763 RVA: 0x0001B8D8 File Offset: 0x00019AD8
		public RowColumnIndex(int row, int column)
		{
			this.Row = row;
			this.Column = column;
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0001B8EE File Offset: 0x00019AEE
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.RowColumnIndex && this.Equals((global::Infragistics.Windows.DataPresenter.RowColumnIndex)obj);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001B908 File Offset: 0x00019B08
		public override int GetHashCode()
		{
			return this.Row.GetHashCode() + this.Column.GetHashCode();
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001B932 File Offset: 0x00019B32
		public override string ToString()
		{
			return string.Format("{0}, {1}", this.Row, this.Column);
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0001B954 File Offset: 0x00019B54
		public bool Equals(global::Infragistics.Windows.DataPresenter.RowColumnIndex other)
		{
			return other != null && other.Row == this.Row && other.Column == this.Column;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0001B977 File Offset: 0x00019B77
		internal bool Equals(int row, int column)
		{
			return row == this.Row && column == this.Column;
		}

		// Token: 0x04000201 RID: 513
		public readonly int Row;

		// Token: 0x04000202 RID: 514
		public readonly int Column;
	}
}
