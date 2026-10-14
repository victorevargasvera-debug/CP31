using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000052 RID: 82
	[global::System.Flags]
	public enum ValueConstraintFlags
	{
		// Token: 0x0400013F RID: 319
		Enumeration = 1,
		// Token: 0x04000140 RID: 320
		FixedValue = 2,
		// Token: 0x04000141 RID: 321
		ImplicitValueAsTypeConstraints = 4,
		// Token: 0x04000142 RID: 322
		ImplicitTypeParameterConstraints = 8,
		// Token: 0x04000143 RID: 323
		MaxExclusive = 16,
		// Token: 0x04000144 RID: 324
		MaxInclusive = 32,
		// Token: 0x04000145 RID: 325
		MaxLength = 64,
		// Token: 0x04000146 RID: 326
		MinExclusive = 128,
		// Token: 0x04000147 RID: 327
		MinInclusive = 256,
		// Token: 0x04000148 RID: 328
		MinLength = 512,
		// Token: 0x04000149 RID: 329
		Nullable = 1024,
		// Token: 0x0400014A RID: 330
		RegexPattern = 2048,
		// Token: 0x0400014B RID: 331
		All = 2147483647
	}
}
