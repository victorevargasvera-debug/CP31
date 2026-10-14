using System;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000066 RID: 102
	public abstract class XSSFAnchor
	{
		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600043B RID: 1083
		// (set) Token: 0x0600043C RID: 1084
		public abstract int Dx1 { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600043D RID: 1085
		// (set) Token: 0x0600043E RID: 1086
		public abstract int Dy1 { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x0600043F RID: 1087
		// (set) Token: 0x06000440 RID: 1088
		public abstract int Dy2 { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000441 RID: 1089
		// (set) Token: 0x06000442 RID: 1090
		public abstract int Dx2 { get; set; }
	}
}
