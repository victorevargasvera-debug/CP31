using System;

namespace SourceGrid.Decorators
{
	// Token: 0x02000340 RID: 832
	internal abstract class DecoratorBase
	{
		// Token: 0x06002842 RID: 10306
		public abstract bool IntersectWith(global::SourceGrid.Range range);

		// Token: 0x06002843 RID: 10307
		public abstract void Draw(global::SourceGrid.RangePaintEventArgs e);
	}
}
