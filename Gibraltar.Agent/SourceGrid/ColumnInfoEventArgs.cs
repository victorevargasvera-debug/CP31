using System;

namespace SourceGrid
{
	// Token: 0x0200036B RID: 875
	internal class ColumnInfoEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A45 RID: 10821 RVA: 0x0008FACC File Offset: 0x0008DCCC
		public ColumnInfoEventArgs(global::SourceGrid.ColumnInfo p_ColumnInfo)
		{
			this.m_ColumnInfo = p_ColumnInfo;
		}

		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x0008FADC File Offset: 0x0008DCDC
		public global::SourceGrid.ColumnInfo Column
		{
			get
			{
				return this.m_ColumnInfo;
			}
		}

		// Token: 0x04000E47 RID: 3655
		private global::SourceGrid.ColumnInfo m_ColumnInfo;
	}
}
