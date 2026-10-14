using System;

namespace SourceGrid
{
	// Token: 0x02000378 RID: 888
	internal class RangeRegionChangingEventArgs : global::System.EventArgs
	{
		// Token: 0x06002A73 RID: 10867 RVA: 0x0008FBAC File Offset: 0x0008DDAC
		public RangeRegionChangingEventArgs(global::SourceGrid.RangeRegion pCurrentRegion, global::SourceGrid.RangeRegion pRangeToExclude, global::SourceGrid.RangeRegion pRangeToInclude)
		{
			this.mRegionToExclude = pRangeToExclude;
			this.mCurrentRegion = pCurrentRegion;
			this.mRegionToInclude = pRangeToInclude;
		}

		// Token: 0x17000CA8 RID: 3240
		// (get) Token: 0x06002A74 RID: 10868 RVA: 0x0008FBCC File Offset: 0x0008DDCC
		public global::SourceGrid.RangeRegion CurrentRegion
		{
			get
			{
				return this.mCurrentRegion;
			}
		}

		// Token: 0x17000CA9 RID: 3241
		// (get) Token: 0x06002A75 RID: 10869 RVA: 0x0008FBD4 File Offset: 0x0008DDD4
		public global::SourceGrid.RangeRegion RegionToInclude
		{
			get
			{
				return this.mRegionToInclude;
			}
		}

		// Token: 0x17000CAA RID: 3242
		// (get) Token: 0x06002A76 RID: 10870 RVA: 0x0008FBDC File Offset: 0x0008DDDC
		public global::SourceGrid.RangeRegion RegionToExclude
		{
			get
			{
				return this.mRegionToExclude;
			}
		}

		// Token: 0x04000E50 RID: 3664
		private global::SourceGrid.RangeRegion mRegionToExclude;

		// Token: 0x04000E51 RID: 3665
		private global::SourceGrid.RangeRegion mRegionToInclude;

		// Token: 0x04000E52 RID: 3666
		private global::SourceGrid.RangeRegion mCurrentRegion;
	}
}
