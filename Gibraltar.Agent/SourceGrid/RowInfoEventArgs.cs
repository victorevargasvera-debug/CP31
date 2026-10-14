using System;

namespace SourceGrid
{
	// Token: 0x02000369 RID: 873
	internal class RowInfoEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A3F RID: 10815 RVA: 0x0008FAB4 File Offset: 0x0008DCB4
		public RowInfoEventArgs(global::SourceGrid.RowInfo p_RowInfo)
		{
			this.m_RowInfo = p_RowInfo;
		}

		// Token: 0x17000C9E RID: 3230
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x0008FAC4 File Offset: 0x0008DCC4
		public global::SourceGrid.RowInfo Row
		{
			get
			{
				return this.m_RowInfo;
			}
		}

		// Token: 0x04000E46 RID: 3654
		private global::SourceGrid.RowInfo m_RowInfo;
	}
}
