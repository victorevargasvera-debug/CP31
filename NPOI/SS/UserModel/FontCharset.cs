using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000069 RID: 105
	public class FontCharset
	{
		// Token: 0x060003DE RID: 990 RVA: 0x0000D22D File Offset: 0x0000B42D
		private FontCharset(int value)
		{
			this.charset = value;
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003DF RID: 991 RVA: 0x0000D23C File Offset: 0x0000B43C
		public int Value
		{
			get
			{
				return this.charset;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x0000D244 File Offset: 0x0000B444
		static FontCharset()
		{
			if (global::NPOI.SS.UserModel.FontCharset._table == null)
			{
				global::NPOI.SS.UserModel.FontCharset._table = new global::NPOI.SS.UserModel.FontCharset[256];
				global::NPOI.SS.UserModel.FontCharset._table[0] = global::NPOI.SS.UserModel.FontCharset.ANSI;
				global::NPOI.SS.UserModel.FontCharset._table[1] = global::NPOI.SS.UserModel.FontCharset.DEFAULT;
				global::NPOI.SS.UserModel.FontCharset._table[2] = global::NPOI.SS.UserModel.FontCharset.SYMBOL;
				global::NPOI.SS.UserModel.FontCharset._table[77] = global::NPOI.SS.UserModel.FontCharset.MAC;
				global::NPOI.SS.UserModel.FontCharset._table[128] = global::NPOI.SS.UserModel.FontCharset.SHIFTJIS;
				global::NPOI.SS.UserModel.FontCharset._table[129] = global::NPOI.SS.UserModel.FontCharset.HANGEUL;
				global::NPOI.SS.UserModel.FontCharset._table[130] = global::NPOI.SS.UserModel.FontCharset.JOHAB;
				global::NPOI.SS.UserModel.FontCharset._table[134] = global::NPOI.SS.UserModel.FontCharset.GB2312;
				global::NPOI.SS.UserModel.FontCharset._table[136] = global::NPOI.SS.UserModel.FontCharset.CHINESEBIG5;
				global::NPOI.SS.UserModel.FontCharset._table[161] = global::NPOI.SS.UserModel.FontCharset.GREEK;
				global::NPOI.SS.UserModel.FontCharset._table[162] = global::NPOI.SS.UserModel.FontCharset.TURKISH;
				global::NPOI.SS.UserModel.FontCharset._table[163] = global::NPOI.SS.UserModel.FontCharset.VIETNAMESE;
				global::NPOI.SS.UserModel.FontCharset._table[177] = global::NPOI.SS.UserModel.FontCharset.HEBREW;
				global::NPOI.SS.UserModel.FontCharset._table[178] = global::NPOI.SS.UserModel.FontCharset.ARABIC;
				global::NPOI.SS.UserModel.FontCharset._table[186] = global::NPOI.SS.UserModel.FontCharset.BALTIC;
				global::NPOI.SS.UserModel.FontCharset._table[204] = global::NPOI.SS.UserModel.FontCharset.RUSSIAN;
				global::NPOI.SS.UserModel.FontCharset._table[222] = global::NPOI.SS.UserModel.FontCharset.THAI;
				global::NPOI.SS.UserModel.FontCharset._table[238] = global::NPOI.SS.UserModel.FontCharset.EASTEUROPE;
				global::NPOI.SS.UserModel.FontCharset._table[255] = global::NPOI.SS.UserModel.FontCharset.OEM;
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x0000D49F File Offset: 0x0000B69F
		public static global::NPOI.SS.UserModel.FontCharset ValueOf(int value)
		{
			if (value >= 0 && value <= 255)
			{
				return global::NPOI.SS.UserModel.FontCharset._table[value];
			}
			return null;
		}

		// Token: 0x040001DA RID: 474
		public static readonly global::NPOI.SS.UserModel.FontCharset ANSI = new global::NPOI.SS.UserModel.FontCharset(0);

		// Token: 0x040001DB RID: 475
		public static readonly global::NPOI.SS.UserModel.FontCharset DEFAULT = new global::NPOI.SS.UserModel.FontCharset(1);

		// Token: 0x040001DC RID: 476
		public static readonly global::NPOI.SS.UserModel.FontCharset SYMBOL = new global::NPOI.SS.UserModel.FontCharset(2);

		// Token: 0x040001DD RID: 477
		public static readonly global::NPOI.SS.UserModel.FontCharset MAC = new global::NPOI.SS.UserModel.FontCharset(77);

		// Token: 0x040001DE RID: 478
		public static readonly global::NPOI.SS.UserModel.FontCharset SHIFTJIS = new global::NPOI.SS.UserModel.FontCharset(128);

		// Token: 0x040001DF RID: 479
		public static readonly global::NPOI.SS.UserModel.FontCharset HANGEUL = new global::NPOI.SS.UserModel.FontCharset(129);

		// Token: 0x040001E0 RID: 480
		public static readonly global::NPOI.SS.UserModel.FontCharset JOHAB = new global::NPOI.SS.UserModel.FontCharset(130);

		// Token: 0x040001E1 RID: 481
		public static readonly global::NPOI.SS.UserModel.FontCharset GB2312 = new global::NPOI.SS.UserModel.FontCharset(134);

		// Token: 0x040001E2 RID: 482
		public static readonly global::NPOI.SS.UserModel.FontCharset CHINESEBIG5 = new global::NPOI.SS.UserModel.FontCharset(136);

		// Token: 0x040001E3 RID: 483
		public static readonly global::NPOI.SS.UserModel.FontCharset GREEK = new global::NPOI.SS.UserModel.FontCharset(161);

		// Token: 0x040001E4 RID: 484
		public static readonly global::NPOI.SS.UserModel.FontCharset TURKISH = new global::NPOI.SS.UserModel.FontCharset(162);

		// Token: 0x040001E5 RID: 485
		public static readonly global::NPOI.SS.UserModel.FontCharset VIETNAMESE = new global::NPOI.SS.UserModel.FontCharset(163);

		// Token: 0x040001E6 RID: 486
		public static readonly global::NPOI.SS.UserModel.FontCharset HEBREW = new global::NPOI.SS.UserModel.FontCharset(177);

		// Token: 0x040001E7 RID: 487
		public static readonly global::NPOI.SS.UserModel.FontCharset ARABIC = new global::NPOI.SS.UserModel.FontCharset(178);

		// Token: 0x040001E8 RID: 488
		public static readonly global::NPOI.SS.UserModel.FontCharset BALTIC = new global::NPOI.SS.UserModel.FontCharset(186);

		// Token: 0x040001E9 RID: 489
		public static readonly global::NPOI.SS.UserModel.FontCharset RUSSIAN = new global::NPOI.SS.UserModel.FontCharset(204);

		// Token: 0x040001EA RID: 490
		public static readonly global::NPOI.SS.UserModel.FontCharset THAI = new global::NPOI.SS.UserModel.FontCharset(222);

		// Token: 0x040001EB RID: 491
		public static readonly global::NPOI.SS.UserModel.FontCharset EASTEUROPE = new global::NPOI.SS.UserModel.FontCharset(238);

		// Token: 0x040001EC RID: 492
		public static readonly global::NPOI.SS.UserModel.FontCharset OEM = new global::NPOI.SS.UserModel.FontCharset(255);

		// Token: 0x040001ED RID: 493
		private int charset;

		// Token: 0x040001EE RID: 494
		private static global::NPOI.SS.UserModel.FontCharset[] _table = null;
	}
}
