using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000094 RID: 148
	internal class RowColumnIndex : global::System.IEquatable<global::Infragistics.Windows.DataPresenter.RowColumnIndex>
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x0001E5B8 File Offset: 0x0001C7B8
		public RowColumnIndex(int row, int column)
		{
			this.Row = row;
			this.Column = column;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0001E5CE File Offset: 0x0001C7CE
		public override bool Equals(object obj)
		{
			return obj is global::Infragistics.Windows.DataPresenter.RowColumnIndex && this.Equals((global::Infragistics.Windows.DataPresenter.RowColumnIndex)obj);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0001E5E8 File Offset: 0x0001C7E8
		public override int GetHashCode()
		{
			return this.Row.GetHashCode() + this.Column.GetHashCode();
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0001E612 File Offset: 0x0001C812
		public override string ToString()
		{
			return string.Format("{0}, {1}", this.Row, this.Column);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001E634 File Offset: 0x0001C834
		public bool Equals(global::Infragistics.Windows.DataPresenter.RowColumnIndex other)
		{
			return other != null && other.Row == this.Row && other.Column == this.Column;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001E657 File Offset: 0x0001C857
		internal bool Equals(int row, int column)
		{
			return row == this.Row && column == this.Column;
		}

		// Token: 0x04000245 RID: 581
		public readonly int Row;

		// Token: 0x04000246 RID: 582
		public readonly int Column;
	}
}
