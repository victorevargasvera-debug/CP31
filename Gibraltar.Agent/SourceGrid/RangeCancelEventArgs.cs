using System;

namespace SourceGrid
{
	// Token: 0x02000374 RID: 884
	internal class RangeCancelEventArgs : global::SourceGrid.RangeEventArgs
	{
		// Token: 0x06002A66 RID: 10854 RVA: 0x0008FB74 File Offset: 0x0008DD74
		public RangeCancelEventArgs(global::SourceGrid.Range p_GridRange) : base(p_GridRange)
		{
		}

		// Token: 0x17000CA6 RID: 3238
		// (get) Token: 0x06002A67 RID: 10855 RVA: 0x0008FB80 File Offset: 0x0008DD80
		// (set) Token: 0x06002A68 RID: 10856 RVA: 0x0008FB88 File Offset: 0x0008DD88
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

		// Token: 0x04000E4E RID: 3662
		private bool m_Cancel;
	}
}
