using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200006A RID: 106
	public class FontFamily
	{
		// Token: 0x060003E2 RID: 994 RVA: 0x0000D4B6 File Offset: 0x0000B6B6
		private FontFamily(int value)
		{
			this.family = value;
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0000D4C5 File Offset: 0x0000B6C5
		public int Value
		{
			get
			{
				return this.family;
			}
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0000D4D0 File Offset: 0x0000B6D0
		public static global::NPOI.SS.UserModel.FontFamily ValueOf(int family)
		{
			switch (family)
			{
			case 0:
				return global::NPOI.SS.UserModel.FontFamily.NOT_APPLICABLE;
			case 1:
				return global::NPOI.SS.UserModel.FontFamily.ROMAN;
			case 2:
				return global::NPOI.SS.UserModel.FontFamily.SWISS;
			case 3:
				return global::NPOI.SS.UserModel.FontFamily.MODERN;
			case 4:
				return global::NPOI.SS.UserModel.FontFamily.SCRIPT;
			case 5:
				return global::NPOI.SS.UserModel.FontFamily.DECORATIVE;
			default:
				return global::NPOI.SS.UserModel.FontFamily.NOT_APPLICABLE;
			}
		}

		// Token: 0x040001EF RID: 495
		public static readonly global::NPOI.SS.UserModel.FontFamily NOT_APPLICABLE = new global::NPOI.SS.UserModel.FontFamily(0);

		// Token: 0x040001F0 RID: 496
		public static readonly global::NPOI.SS.UserModel.FontFamily ROMAN = new global::NPOI.SS.UserModel.FontFamily(1);

		// Token: 0x040001F1 RID: 497
		public static readonly global::NPOI.SS.UserModel.FontFamily SWISS = new global::NPOI.SS.UserModel.FontFamily(2);

		// Token: 0x040001F2 RID: 498
		public static readonly global::NPOI.SS.UserModel.FontFamily MODERN = new global::NPOI.SS.UserModel.FontFamily(3);

		// Token: 0x040001F3 RID: 499
		public static readonly global::NPOI.SS.UserModel.FontFamily SCRIPT = new global::NPOI.SS.UserModel.FontFamily(4);

		// Token: 0x040001F4 RID: 500
		public static readonly global::NPOI.SS.UserModel.FontFamily DECORATIVE = new global::NPOI.SS.UserModel.FontFamily(5);

		// Token: 0x040001F5 RID: 501
		private int family;
	}
}
