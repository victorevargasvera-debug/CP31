using System;

namespace SourceGrid
{
	// Token: 0x02000372 RID: 882
	internal class RangeEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A60 RID: 10848 RVA: 0x0008FB5C File Offset: 0x0008DD5C
		public RangeEventArgs(global::SourceGrid.Range p_GridRange)
		{
			this.m_GridRange = p_GridRange;
		}

		// Token: 0x17000CA5 RID: 3237
		// (get) Token: 0x06002A61 RID: 10849 RVA: 0x0008FB6C File Offset: 0x0008DD6C
		public global::SourceGrid.Range Range
		{
			get
			{
				return this.m_GridRange;
			}
		}

		// Token: 0x04000E4D RID: 3661
		private global::SourceGrid.Range m_GridRange;
	}
}
