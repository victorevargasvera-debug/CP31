using System;

namespace SourceGrid
{
	// Token: 0x02000365 RID: 869
	internal class ColumnEventArgs : global::System.EventArgs
	{
		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0008FA70 File Offset: 0x0008DC70
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0008FA78 File Offset: 0x0008DC78
		public int Column
		{
			get
			{
				return this.m_Column;
			}
			set
			{
				this.m_Column = value;
			}
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0008FA84 File Offset: 0x0008DC84
		public ColumnEventArgs(int pColumn)
		{
			this.m_Column = pColumn;
		}

		// Token: 0x04000E44 RID: 3652
		private int m_Column;
	}
}
