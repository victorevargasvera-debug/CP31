using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000ED RID: 237
	[global::System.Flags]
	public enum ValueConstraintFlags
	{
		// Token: 0x040003FE RID: 1022
		Enumeration = 1,
		// Token: 0x040003FF RID: 1023
		FixedValue = 2,
		// Token: 0x04000400 RID: 1024
		ImplicitValueAsTypeConstraints = 4,
		// Token: 0x04000401 RID: 1025
		ImplicitTypeParameterConstraints = 8,
		// Token: 0x04000402 RID: 1026
		MaxExclusive = 16,
		// Token: 0x04000403 RID: 1027
		MaxInclusive = 32,
		// Token: 0x04000404 RID: 1028
		MaxLength = 64,
		// Token: 0x04000405 RID: 1029
		MinExclusive = 128,
		// Token: 0x04000406 RID: 1030
		MinInclusive = 256,
		// Token: 0x04000407 RID: 1031
		MinLength = 512,
		// Token: 0x04000408 RID: 1032
		Nullable = 1024,
		// Token: 0x04000409 RID: 1033
		RegexPattern = 2048,
		// Token: 0x0400040A RID: 1034
		ValidationRules = 4096,
		// Token: 0x0400040B RID: 1035
		All = 2147483647
	}
}
