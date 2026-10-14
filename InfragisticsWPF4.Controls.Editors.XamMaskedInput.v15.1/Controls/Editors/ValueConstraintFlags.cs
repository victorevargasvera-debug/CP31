using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000051 RID: 81
	[global::System.Flags]
	public enum ValueConstraintFlags
	{
		// Token: 0x04000144 RID: 324
		Enumeration = 1,
		// Token: 0x04000145 RID: 325
		FixedValue = 2,
		// Token: 0x04000146 RID: 326
		ImplicitValueAsTypeConstraints = 4,
		// Token: 0x04000147 RID: 327
		ImplicitTypeParameterConstraints = 8,
		// Token: 0x04000148 RID: 328
		MaxExclusive = 16,
		// Token: 0x04000149 RID: 329
		MaxInclusive = 32,
		// Token: 0x0400014A RID: 330
		MaxLength = 64,
		// Token: 0x0400014B RID: 331
		MinExclusive = 128,
		// Token: 0x0400014C RID: 332
		MinInclusive = 256,
		// Token: 0x0400014D RID: 333
		MinLength = 512,
		// Token: 0x0400014E RID: 334
		Nullable = 1024,
		// Token: 0x0400014F RID: 335
		RegexPattern = 2048,
		// Token: 0x04000150 RID: 336
		All = 2147483647
	}
}
