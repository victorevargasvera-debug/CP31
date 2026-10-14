using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003A RID: 58
	public class DataConsolidateFunction
	{
		// Token: 0x0600022E RID: 558 RVA: 0x00009673 File Offset: 0x00007873
		public DataConsolidateFunction(int value, string name)
		{
			this.value = value;
			this.name = name;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00009689 File Offset: 0x00007889
		public string Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00009691 File Offset: 0x00007891
		public int Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x040000D9 RID: 217
		public static global::NPOI.SS.UserModel.DataConsolidateFunction AVERAGE = new global::NPOI.SS.UserModel.DataConsolidateFunction(0, "Average");

		// Token: 0x040000DA RID: 218
		public static global::NPOI.SS.UserModel.DataConsolidateFunction COUNT = new global::NPOI.SS.UserModel.DataConsolidateFunction(1, "Count");

		// Token: 0x040000DB RID: 219
		public static global::NPOI.SS.UserModel.DataConsolidateFunction COUNT_NUMS = new global::NPOI.SS.UserModel.DataConsolidateFunction(2, "Count");

		// Token: 0x040000DC RID: 220
		public static global::NPOI.SS.UserModel.DataConsolidateFunction MAX = new global::NPOI.SS.UserModel.DataConsolidateFunction(3, "Max");

		// Token: 0x040000DD RID: 221
		public static global::NPOI.SS.UserModel.DataConsolidateFunction MIN = new global::NPOI.SS.UserModel.DataConsolidateFunction(4, "Min");

		// Token: 0x040000DE RID: 222
		public static global::NPOI.SS.UserModel.DataConsolidateFunction PRODUCT = new global::NPOI.SS.UserModel.DataConsolidateFunction(5, "Product");

		// Token: 0x040000DF RID: 223
		public static global::NPOI.SS.UserModel.DataConsolidateFunction STD_DEV = new global::NPOI.SS.UserModel.DataConsolidateFunction(6, "StdDev");

		// Token: 0x040000E0 RID: 224
		public static global::NPOI.SS.UserModel.DataConsolidateFunction STD_DEVP = new global::NPOI.SS.UserModel.DataConsolidateFunction(7, "StdDevp");

		// Token: 0x040000E1 RID: 225
		public static global::NPOI.SS.UserModel.DataConsolidateFunction SUM = new global::NPOI.SS.UserModel.DataConsolidateFunction(8, "Sum");

		// Token: 0x040000E2 RID: 226
		public static global::NPOI.SS.UserModel.DataConsolidateFunction VAR = new global::NPOI.SS.UserModel.DataConsolidateFunction(9, "Var");

		// Token: 0x040000E3 RID: 227
		public static global::NPOI.SS.UserModel.DataConsolidateFunction VARP = new global::NPOI.SS.UserModel.DataConsolidateFunction(10, "Varp");

		// Token: 0x040000E4 RID: 228
		private int value;

		// Token: 0x040000E5 RID: 229
		private string name;
	}
}
