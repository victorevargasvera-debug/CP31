using System;

namespace SourceGrid
{
	// Token: 0x02000367 RID: 871
	internal class ColumnCancelEventArgs : global::SourceGrid.ColumnEventArgs
	{
		// Token: 0x17000C9D RID: 3229
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0008FA94 File Offset: 0x0008DC94
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x0008FA9C File Offset: 0x0008DC9C
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

		// Token: 0x06002A3A RID: 10810 RVA: 0x0008FAA8 File Offset: 0x0008DCA8
		public ColumnCancelEventArgs(int pColumn) : base(pColumn)
		{
		}

		// Token: 0x04000E45 RID: 3653
		private bool m_Cancel;
	}
}
