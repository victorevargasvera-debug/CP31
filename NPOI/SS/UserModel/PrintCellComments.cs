using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200007E RID: 126
	public class PrintCellComments
	{
		// Token: 0x0600044D RID: 1101 RVA: 0x0000D919 File Offset: 0x0000BB19
		static PrintCellComments()
		{
			global::NPOI.SS.UserModel.PrintCellComments.NONE = new global::NPOI.SS.UserModel.PrintCellComments(1);
			global::NPOI.SS.UserModel.PrintCellComments.AS_DISPLAYED = new global::NPOI.SS.UserModel.PrintCellComments(2);
			global::NPOI.SS.UserModel.PrintCellComments.AT_END = new global::NPOI.SS.UserModel.PrintCellComments(3);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0000D947 File Offset: 0x0000BB47
		private PrintCellComments(int comments)
		{
			this.comments = comments;
			global::NPOI.SS.UserModel.PrintCellComments._table[this.Value] = this;
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x0000D963 File Offset: 0x0000BB63
		public int Value
		{
			get
			{
				return this.comments;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0000D96B File Offset: 0x0000BB6B
		public static global::NPOI.SS.UserModel.PrintCellComments ValueOf(int value)
		{
			return global::NPOI.SS.UserModel.PrintCellComments._table[value];
		}

		// Token: 0x0400026B RID: 619
		public static global::NPOI.SS.UserModel.PrintCellComments NONE;

		// Token: 0x0400026C RID: 620
		public static global::NPOI.SS.UserModel.PrintCellComments AS_DISPLAYED;

		// Token: 0x0400026D RID: 621
		public static global::NPOI.SS.UserModel.PrintCellComments AT_END;

		// Token: 0x0400026E RID: 622
		private int comments;

		// Token: 0x0400026F RID: 623
		private static global::NPOI.SS.UserModel.PrintCellComments[] _table = new global::NPOI.SS.UserModel.PrintCellComments[4];
	}
}
