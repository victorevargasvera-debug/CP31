using System;

namespace SourceGrid
{
	// Token: 0x0200035A RID: 858
	internal class CellContextEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A0B RID: 10763 RVA: 0x0008F998 File Offset: 0x0008DB98
		public CellContextEventArgs(global::SourceGrid.CellContext pCellContext)
		{
			this.mCellContext = pCellContext;
		}

		// Token: 0x17000C94 RID: 3220
		// (get) Token: 0x06002A0C RID: 10764 RVA: 0x0008F9A8 File Offset: 0x0008DBA8
		public global::SourceGrid.CellContext CellContext
		{
			get
			{
				return this.mCellContext;
			}
		}

		// Token: 0x04000E3D RID: 3645
		private global::SourceGrid.CellContext mCellContext;
	}
}
