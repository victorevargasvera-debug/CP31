using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200003D RID: 61
	public class FontUnderline
	{
		// Token: 0x0600024C RID: 588 RVA: 0x00009B17 File Offset: 0x00007D17
		private FontUnderline(int val)
		{
			this.value = val;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00009B26 File Offset: 0x00007D26
		public int Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00009B2E File Offset: 0x00007D2E
		public byte ByteValue
		{
			get
			{
				if (this == global::NPOI.SS.UserModel.FontUnderline.DOUBLE)
				{
					return 2;
				}
				if (this == global::NPOI.SS.UserModel.FontUnderline.DOUBLE_ACCOUNTING)
				{
					return 34;
				}
				if (this == global::NPOI.SS.UserModel.FontUnderline.SINGLE_ACCOUNTING)
				{
					return 33;
				}
				if (this == global::NPOI.SS.UserModel.FontUnderline.NONE)
				{
					return 0;
				}
				global::NPOI.SS.UserModel.FontUnderline single = global::NPOI.SS.UserModel.FontUnderline.SINGLE;
				return 1;
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00009B64 File Offset: 0x00007D64
		static FontUnderline()
		{
			if (global::NPOI.SS.UserModel.FontUnderline._table == null)
			{
				global::NPOI.SS.UserModel.FontUnderline._table = new global::NPOI.SS.UserModel.FontUnderline[5];
				global::NPOI.SS.UserModel.FontUnderline._table[0] = global::NPOI.SS.UserModel.FontUnderline.NONE;
				global::NPOI.SS.UserModel.FontUnderline._table[1] = global::NPOI.SS.UserModel.FontUnderline.SINGLE;
				global::NPOI.SS.UserModel.FontUnderline._table[2] = global::NPOI.SS.UserModel.FontUnderline.DOUBLE;
				global::NPOI.SS.UserModel.FontUnderline._table[3] = global::NPOI.SS.UserModel.FontUnderline.SINGLE_ACCOUNTING;
				global::NPOI.SS.UserModel.FontUnderline._table[4] = global::NPOI.SS.UserModel.FontUnderline.DOUBLE_ACCOUNTING;
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00009BFC File Offset: 0x00007DFC
		public static global::NPOI.SS.UserModel.FontUnderline ValueOf(int value)
		{
			return global::NPOI.SS.UserModel.FontUnderline._table[value];
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00009C08 File Offset: 0x00007E08
		public static global::NPOI.SS.UserModel.FontUnderline ValueOf(global::NPOI.SS.UserModel.FontUnderlineType value)
		{
			if (value <= global::NPOI.SS.UserModel.FontUnderlineType.Double)
			{
				if (value == global::NPOI.SS.UserModel.FontUnderlineType.Single)
				{
					return global::NPOI.SS.UserModel.FontUnderline.SINGLE;
				}
				if (value == global::NPOI.SS.UserModel.FontUnderlineType.Double)
				{
					return global::NPOI.SS.UserModel.FontUnderline.DOUBLE;
				}
			}
			else
			{
				if (value == global::NPOI.SS.UserModel.FontUnderlineType.SingleAccounting)
				{
					return global::NPOI.SS.UserModel.FontUnderline.SINGLE_ACCOUNTING;
				}
				if (value == global::NPOI.SS.UserModel.FontUnderlineType.DoubleAccounting)
				{
					return global::NPOI.SS.UserModel.FontUnderline.DOUBLE_ACCOUNTING;
				}
			}
			return global::NPOI.SS.UserModel.FontUnderline.NONE;
		}

		// Token: 0x040000EC RID: 236
		public static readonly global::NPOI.SS.UserModel.FontUnderline SINGLE = new global::NPOI.SS.UserModel.FontUnderline(1);

		// Token: 0x040000ED RID: 237
		public static readonly global::NPOI.SS.UserModel.FontUnderline DOUBLE = new global::NPOI.SS.UserModel.FontUnderline(2);

		// Token: 0x040000EE RID: 238
		public static readonly global::NPOI.SS.UserModel.FontUnderline SINGLE_ACCOUNTING = new global::NPOI.SS.UserModel.FontUnderline(3);

		// Token: 0x040000EF RID: 239
		public static readonly global::NPOI.SS.UserModel.FontUnderline DOUBLE_ACCOUNTING = new global::NPOI.SS.UserModel.FontUnderline(4);

		// Token: 0x040000F0 RID: 240
		public static readonly global::NPOI.SS.UserModel.FontUnderline NONE = new global::NPOI.SS.UserModel.FontUnderline(0);

		// Token: 0x040000F1 RID: 241
		private int value;

		// Token: 0x040000F2 RID: 242
		private static global::NPOI.SS.UserModel.FontUnderline[] _table = null;
	}
}
