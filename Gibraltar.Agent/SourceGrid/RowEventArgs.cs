using System;

namespace SourceGrid
{
	// Token: 0x02000361 RID: 865
	internal class RowEventArgs : global::System.EventArgs
	{
		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06002A23 RID: 10787 RVA: 0x0008FA2C File Offset: 0x0008DC2C
		// (set) Token: 0x06002A24 RID: 10788 RVA: 0x0008FA34 File Offset: 0x0008DC34
		public int Row
		{
			get
			{
				return this.m_Row;
			}
			set
			{
				this.m_Row = value;
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x0008FA40 File Offset: 0x0008DC40
		public RowEventArgs(int pRow)
		{
			this.m_Row = pRow;
		}

		// Token: 0x04000E42 RID: 3650
		private int m_Row;
	}
}
