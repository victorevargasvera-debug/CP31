using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000E1 RID: 225
	[global::System.Flags]
	public enum ValueConstraintFlags
	{
		// Token: 0x040003C4 RID: 964
		Enumeration = 1,
		// Token: 0x040003C5 RID: 965
		FixedValue = 2,
		// Token: 0x040003C6 RID: 966
		ImplicitValueAsTypeConstraints = 4,
		// Token: 0x040003C7 RID: 967
		ImplicitTypeParameterConstraints = 8,
		// Token: 0x040003C8 RID: 968
		MaxExclusive = 16,
		// Token: 0x040003C9 RID: 969
		MaxInclusive = 32,
		// Token: 0x040003CA RID: 970
		MaxLength = 64,
		// Token: 0x040003CB RID: 971
		MinExclusive = 128,
		// Token: 0x040003CC RID: 972
		MinInclusive = 256,
		// Token: 0x040003CD RID: 973
		MinLength = 512,
		// Token: 0x040003CE RID: 974
		Nullable = 1024,
		// Token: 0x040003CF RID: 975
		RegexPattern = 2048,
		// Token: 0x040003D0 RID: 976
		ValidationRules = 4096,
		// Token: 0x040003D1 RID: 977
		All = 2147483647
	}
}
