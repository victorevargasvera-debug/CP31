using System;

namespace SourceGrid.Decorators
{
	// Token: 0x02000341 RID: 833
	internal class DecoratorHighlight : global::SourceGrid.Decorators.DecoratorBase
	{
		// Token: 0x17000C3F RID: 3135
		// (get) Token: 0x06002845 RID: 10309 RVA: 0x0008C23C File Offset: 0x0008A43C
		// (set) Token: 0x06002846 RID: 10310 RVA: 0x0008C244 File Offset: 0x0008A444
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

		// Token: 0x06002847 RID: 10311 RVA: 0x0008C250 File Offset: 0x0008A450
		public override bool IntersectWith(global::SourceGrid.Range range)
		{
			return this.Range.IntersectsWith(range);
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x0008C270 File Offset: 0x0008A470
		public override void Draw(global::SourceGrid.RangePaintEventArgs e)
		{
		}

		// Token: 0x04000DF1 RID: 3569
		private global::SourceGrid.Range mRange = global::SourceGrid.Range.Empty;
	}
}
