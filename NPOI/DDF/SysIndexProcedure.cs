using System;
using NPOI.Util;

namespace NPOI.DDF
{
	// Token: 0x0200052C RID: 1324
	public class SysIndexProcedure
	{
		// Token: 0x060031B3 RID: 12723 RVA: 0x0009660C File Offset: 0x0009480C
		internal static global::NPOI.DDF.SysIndexProcedure[] Values()
		{
			return new global::NPOI.DDF.SysIndexProcedure[]
			{
				global::NPOI.DDF.SysIndexProcedure.DARKEN_COLOR,
				global::NPOI.DDF.SysIndexProcedure.LIGHTEN_COLOR,
				global::NPOI.DDF.SysIndexProcedure.ADD_GRAY_LEVEL,
				global::NPOI.DDF.SysIndexProcedure.SUB_GRAY_LEVEL,
				global::NPOI.DDF.SysIndexProcedure.REVERSE_GRAY_LEVEL,
				global::NPOI.DDF.SysIndexProcedure.THRESHOLD,
				global::NPOI.DDF.SysIndexProcedure.INVERT_AFTER,
				global::NPOI.DDF.SysIndexProcedure.INVERT_HIGHBIT_AFTER
			};
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x0009665F File Offset: 0x0009485F
		internal SysIndexProcedure(int mask)
		{
			this.mask = new global::NPOI.Util.BitField(mask);
		}

		// Token: 0x04001628 RID: 5672
		public static global::NPOI.DDF.SysIndexProcedure DARKEN_COLOR = new global::NPOI.DDF.SysIndexProcedure(1);

		// Token: 0x04001629 RID: 5673
		public static global::NPOI.DDF.SysIndexProcedure LIGHTEN_COLOR = new global::NPOI.DDF.SysIndexProcedure(2);

		// Token: 0x0400162A RID: 5674
		public static global::NPOI.DDF.SysIndexProcedure ADD_GRAY_LEVEL = new global::NPOI.DDF.SysIndexProcedure(3);

		// Token: 0x0400162B RID: 5675
		public static global::NPOI.DDF.SysIndexProcedure SUB_GRAY_LEVEL = new global::NPOI.DDF.SysIndexProcedure(4);

		// Token: 0x0400162C RID: 5676
		public static global::NPOI.DDF.SysIndexProcedure REVERSE_GRAY_LEVEL = new global::NPOI.DDF.SysIndexProcedure(5);

		// Token: 0x0400162D RID: 5677
		public static global::NPOI.DDF.SysIndexProcedure THRESHOLD = new global::NPOI.DDF.SysIndexProcedure(6);

		// Token: 0x0400162E RID: 5678
		public static global::NPOI.DDF.SysIndexProcedure INVERT_AFTER = new global::NPOI.DDF.SysIndexProcedure(32);

		// Token: 0x0400162F RID: 5679
		public static global::NPOI.DDF.SysIndexProcedure INVERT_HIGHBIT_AFTER = new global::NPOI.DDF.SysIndexProcedure(64);

		// Token: 0x04001630 RID: 5680
		internal global::NPOI.Util.BitField mask;
	}
}
