using System;

namespace SourceGrid
{
	// Token: 0x0200036D RID: 877
	internal class IndexRangeEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A4B RID: 10827 RVA: 0x0008FAE4 File Offset: 0x0008DCE4
		public IndexRangeEventArgs(int p_iStartIndex, int p_iCount)
		{
			this.m_iStartIndex = p_iStartIndex;
			this.m_iCount = p_iCount;
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x0008FAFC File Offset: 0x0008DCFC
		public int StartIndex
		{
			get
			{
				return this.m_iStartIndex;
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06002A4D RID: 10829 RVA: 0x0008FB04 File Offset: 0x0008DD04
		public int Count
		{
			get
			{
				return this.m_iCount;
			}
		}

		// Token: 0x04000E48 RID: 3656
		private int m_iStartIndex;

		// Token: 0x04000E49 RID: 3657
		private int m_iCount;
	}
}
