using System;

namespace SourceGrid
{
	// Token: 0x020003CD RID: 973
	internal class RangeLoader : global::SourceGrid.IRangeLoader
	{
		// Token: 0x06002C38 RID: 11320 RVA: 0x00094A48 File Offset: 0x00092C48
		public RangeLoader(global::SourceGrid.Range range)
		{
			this.mRange = range;
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x00094A58 File Offset: 0x00092C58
		// (set) Token: 0x06002C3A RID: 11322 RVA: 0x00094A60 File Offset: 0x00092C60
		public global::SourceGrid.Range Range
		{
			get
			{
				return this.mRange;
			}
			set
			{
				this.mRange = value;
			}
		}

		// Token: 0x06002C3B RID: 11323 RVA: 0x00094A6C File Offset: 0x00092C6C
		public virtual global::SourceGrid.Range GetRange(global::SourceGrid.GridVirtual p_Grid)
		{
			return this.mRange;
		}

		// Token: 0x04000EB2 RID: 3762
		private global::SourceGrid.Range mRange;
	}
}
