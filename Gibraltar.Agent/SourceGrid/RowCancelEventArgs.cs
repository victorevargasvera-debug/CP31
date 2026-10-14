using System;

namespace SourceGrid
{
	// Token: 0x02000363 RID: 867
	internal class RowCancelEventArgs : global::SourceGrid.RowEventArgs
	{
		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06002A2A RID: 10794 RVA: 0x0008FA50 File Offset: 0x0008DC50
		// (set) Token: 0x06002A2B RID: 10795 RVA: 0x0008FA58 File Offset: 0x0008DC58
		public bool Cancel
		{
			get
			{
				return this.m_Cancel;
			}
			set
			{
				this.m_Cancel = value;
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0008FA64 File Offset: 0x0008DC64
		public RowCancelEventArgs(int pRow) : base(pRow)
		{
		}

		// Token: 0x04000E43 RID: 3651
		private bool m_Cancel;
	}
}
