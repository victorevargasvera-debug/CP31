using System;

namespace NPOI.DDF
{
	// Token: 0x0200052B RID: 1323
	public class SysIndexSource
	{
		// Token: 0x060031B0 RID: 12720 RVA: 0x00096533 File Offset: 0x00094733
		internal static global::NPOI.DDF.SysIndexSource[] Values()
		{
			return new global::NPOI.DDF.SysIndexSource[]
			{
				global::NPOI.DDF.SysIndexSource.FILL_COLOR,
				global::NPOI.DDF.SysIndexSource.LINE_OR_FILL_COLOR,
				global::NPOI.DDF.SysIndexSource.SHADOW_COLOR,
				global::NPOI.DDF.SysIndexSource.CURRENT_OR_LAST_COLOR,
				global::NPOI.DDF.SysIndexSource.FILL_BACKGROUND_COLOR,
				global::NPOI.DDF.SysIndexSource.LINE_BACKGROUND_COLOR,
				global::NPOI.DDF.SysIndexSource.FILL_OR_LINE_COLOR
			};
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00096573 File Offset: 0x00094773
		internal SysIndexSource(int value)
		{
			this.value = value;
		}

		// Token: 0x0400161F RID: 5663
		public static global::NPOI.DDF.SysIndexSource FILL_COLOR = new global::NPOI.DDF.SysIndexSource(240);

		// Token: 0x04001620 RID: 5664
		public static global::NPOI.DDF.SysIndexSource LINE_OR_FILL_COLOR = new global::NPOI.DDF.SysIndexSource(241);

		// Token: 0x04001621 RID: 5665
		public static global::NPOI.DDF.SysIndexSource LINE_COLOR = new global::NPOI.DDF.SysIndexSource(242);

		// Token: 0x04001622 RID: 5666
		public static global::NPOI.DDF.SysIndexSource SHADOW_COLOR = new global::NPOI.DDF.SysIndexSource(243);

		// Token: 0x04001623 RID: 5667
		public static global::NPOI.DDF.SysIndexSource CURRENT_OR_LAST_COLOR = new global::NPOI.DDF.SysIndexSource(244);

		// Token: 0x04001624 RID: 5668
		public static global::NPOI.DDF.SysIndexSource FILL_BACKGROUND_COLOR = new global::NPOI.DDF.SysIndexSource(245);

		// Token: 0x04001625 RID: 5669
		public static global::NPOI.DDF.SysIndexSource LINE_BACKGROUND_COLOR = new global::NPOI.DDF.SysIndexSource(246);

		// Token: 0x04001626 RID: 5670
		public static global::NPOI.DDF.SysIndexSource FILL_OR_LINE_COLOR = new global::NPOI.DDF.SysIndexSource(247);

		// Token: 0x04001627 RID: 5671
		internal int value;
	}
}
