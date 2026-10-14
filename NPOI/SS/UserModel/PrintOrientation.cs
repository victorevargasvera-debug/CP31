using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200007F RID: 127
	public class PrintOrientation
	{
		// Token: 0x06000451 RID: 1105 RVA: 0x0000D974 File Offset: 0x0000BB74
		static PrintOrientation()
		{
			global::NPOI.SS.UserModel.PrintOrientation.DEFAULT = new global::NPOI.SS.UserModel.PrintOrientation(1);
			global::NPOI.SS.UserModel.PrintOrientation.PORTRAIT = new global::NPOI.SS.UserModel.PrintOrientation(2);
			global::NPOI.SS.UserModel.PrintOrientation.LANDSCAPE = new global::NPOI.SS.UserModel.PrintOrientation(3);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x0000D9A2 File Offset: 0x0000BBA2
		private PrintOrientation(int orientation)
		{
			this.orientation = orientation;
			global::NPOI.SS.UserModel.PrintOrientation._table[this.Value] = this;
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0000D9BE File Offset: 0x0000BBBE
		public int Value
		{
			get
			{
				return this.orientation;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0000D9C6 File Offset: 0x0000BBC6
		public static global::NPOI.SS.UserModel.PrintOrientation ValueOf(int value)
		{
			return global::NPOI.SS.UserModel.PrintOrientation._table[value];
		}

		// Token: 0x04000270 RID: 624
		public static global::NPOI.SS.UserModel.PrintOrientation DEFAULT;

		// Token: 0x04000271 RID: 625
		public static global::NPOI.SS.UserModel.PrintOrientation PORTRAIT;

		// Token: 0x04000272 RID: 626
		public static global::NPOI.SS.UserModel.PrintOrientation LANDSCAPE;

		// Token: 0x04000273 RID: 627
		private int orientation;

		// Token: 0x04000274 RID: 628
		private static global::NPOI.SS.UserModel.PrintOrientation[] _table = new global::NPOI.SS.UserModel.PrintOrientation[4];
	}
}
