using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200005D RID: 93
	public interface IDataValidationConstraint
	{
		// Token: 0x06000381 RID: 897
		int GetValidationType();

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000382 RID: 898
		// (set) Token: 0x06000383 RID: 899
		int Operator { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000384 RID: 900
		// (set) Token: 0x06000385 RID: 901
		string[] ExplicitListValues { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000386 RID: 902
		// (set) Token: 0x06000387 RID: 903
		string Formula1 { get; set; }

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000388 RID: 904
		// (set) Token: 0x06000389 RID: 905
		string Formula2 { get; set; }
	}
}
