using System;

namespace SourceGrid
{
	// Token: 0x0200037A RID: 890
	internal class RangeRegionCancelEventArgs : global::SourceGrid.RangeRegionEventArgs
	{
		// Token: 0x06002A7B RID: 10875 RVA: 0x0008FBE4 File Offset: 0x0008DDE4
		public RangeRegionCancelEventArgs(global::SourceGrid.RangeRegion p_GridRangeRegion) : base(p_GridRangeRegion)
		{
		}

		// Token: 0x17000CAB RID: 3243
		// (get) Token: 0x06002A7C RID: 10876 RVA: 0x0008FBF0 File Offset: 0x0008DDF0
		// (set) Token: 0x06002A7D RID: 10877 RVA: 0x0008FBF8 File Offset: 0x0008DDF8
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

		// Token: 0x04000E53 RID: 3667
		private bool m_Cancel;
	}
}
