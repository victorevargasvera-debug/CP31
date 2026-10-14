using System;

namespace SourceGrid
{
	// Token: 0x0200035B RID: 859
	internal class CellCancelEventArgs : global::SourceGrid.CellContextEventArgs
	{
		// Token: 0x06002A0D RID: 10765 RVA: 0x0008F9B0 File Offset: 0x0008DBB0
		public CellCancelEventArgs(global::SourceGrid.CellContext pCellContext) : base(pCellContext)
		{
		}

		// Token: 0x17000C95 RID: 3221
		// (get) Token: 0x06002A0E RID: 10766 RVA: 0x0008F9BC File Offset: 0x0008DBBC
		// (set) Token: 0x06002A0F RID: 10767 RVA: 0x0008F9C4 File Offset: 0x0008DBC4
		public bool Cancel
		{
			get
			{
				return this.m_bCancel;
			}
			set
			{
				this.m_bCancel = value;
			}
		}

		// Token: 0x04000E3E RID: 3646
		private bool m_bCancel;
	}
}
