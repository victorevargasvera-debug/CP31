using System;

namespace SourceGrid
{
	// Token: 0x0200038A RID: 906
	internal class RangeRegionChangedEventArgs : global::System.EventArgs
	{
		// Token: 0x06002AB9 RID: 10937 RVA: 0x0008FCC8 File Offset: 0x0008DEC8
		public RangeRegionChangedEventArgs(global::SourceGrid.Range addedRange, global::SourceGrid.Range removedRange)
		{
			if (!addedRange.IsEmpty())
			{
				this.addedRange = new global::SourceGrid.RangeRegion(addedRange);
			}
			if (!removedRange.IsEmpty())
			{
				this.removedRange = new global::SourceGrid.RangeRegion(removedRange);
			}
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x0008FD00 File Offset: 0x0008DF00
		public RangeRegionChangedEventArgs(global::SourceGrid.RangeRegion addedRange, global::SourceGrid.RangeRegion removedRange)
		{
			this.addedRange = addedRange;
			this.removedRange = removedRange;
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x06002ABB RID: 10939 RVA: 0x0008FD18 File Offset: 0x0008DF18
		public global::SourceGrid.RangeRegion AddedRange
		{
			get
			{
				return this.addedRange;
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x06002ABC RID: 10940 RVA: 0x0008FD20 File Offset: 0x0008DF20
		public global::SourceGrid.RangeRegion RemovedRange
		{
			get
			{
				return this.removedRange;
			}
		}

		// Token: 0x04000E5E RID: 3678
		private global::SourceGrid.RangeRegion addedRange;

		// Token: 0x04000E5F RID: 3679
		private global::SourceGrid.RangeRegion removedRange;
	}
}
