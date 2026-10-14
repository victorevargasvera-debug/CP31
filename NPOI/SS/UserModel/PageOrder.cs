using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000078 RID: 120
	public class PageOrder
	{
		// Token: 0x06000432 RID: 1074 RVA: 0x0000D8CE File Offset: 0x0000BACE
		static PageOrder()
		{
			global::NPOI.SS.UserModel.PageOrder.DOWN_THEN_OVER = new global::NPOI.SS.UserModel.PageOrder(1);
			global::NPOI.SS.UserModel.PageOrder.OVER_THEN_DOWN = new global::NPOI.SS.UserModel.PageOrder(2);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x0000D8F1 File Offset: 0x0000BAF1
		private PageOrder(int order)
		{
			this.order = order;
			global::NPOI.SS.UserModel.PageOrder._table[order] = this;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000D908 File Offset: 0x0000BB08
		public int Value
		{
			get
			{
				return this.order;
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0000D910 File Offset: 0x0000BB10
		public static global::NPOI.SS.UserModel.PageOrder ValueOf(int value)
		{
			return global::NPOI.SS.UserModel.PageOrder._table[value];
		}

		// Token: 0x04000233 RID: 563
		public static global::NPOI.SS.UserModel.PageOrder DOWN_THEN_OVER;

		// Token: 0x04000234 RID: 564
		public static global::NPOI.SS.UserModel.PageOrder OVER_THEN_DOWN;

		// Token: 0x04000235 RID: 565
		private int order;

		// Token: 0x04000236 RID: 566
		private static global::NPOI.SS.UserModel.PageOrder[] _table = new global::NPOI.SS.UserModel.PageOrder[3];
	}
}
