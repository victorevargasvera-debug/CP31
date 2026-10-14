using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200006C RID: 108
	public class FontScheme
	{
		// Token: 0x060003F4 RID: 1012 RVA: 0x0000D577 File Offset: 0x0000B777
		private FontScheme(int val)
		{
			this.value = val;
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x0000D586 File Offset: 0x0000B786
		public int Value
		{
			get
			{
				return this.value;
			}
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x0000D58E File Offset: 0x0000B78E
		public static global::NPOI.SS.UserModel.FontScheme ValueOf(int value)
		{
			switch (value)
			{
			case 1:
				return global::NPOI.SS.UserModel.FontScheme.NONE;
			case 2:
				return global::NPOI.SS.UserModel.FontScheme.MAJOR;
			case 3:
				return global::NPOI.SS.UserModel.FontScheme.MINOR;
			default:
				return global::NPOI.SS.UserModel.FontScheme.NONE;
			}
		}

		// Token: 0x040001F6 RID: 502
		public static readonly global::NPOI.SS.UserModel.FontScheme NONE = new global::NPOI.SS.UserModel.FontScheme(1);

		// Token: 0x040001F7 RID: 503
		public static readonly global::NPOI.SS.UserModel.FontScheme MAJOR = new global::NPOI.SS.UserModel.FontScheme(2);

		// Token: 0x040001F8 RID: 504
		public static readonly global::NPOI.SS.UserModel.FontScheme MINOR = new global::NPOI.SS.UserModel.FontScheme(3);

		// Token: 0x040001F9 RID: 505
		private int value;
	}
}
