using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200019C RID: 412
	[global::System.Flags]
	internal enum ImplicitUseKindFlags
	{
		// Token: 0x040004D5 RID: 1237
		Default = 7,
		// Token: 0x040004D6 RID: 1238
		Access = 1,
		// Token: 0x040004D7 RID: 1239
		Assign = 2,
		// Token: 0x040004D8 RID: 1240
		InstantiatedWithFixedConstructorSignature = 4,
		// Token: 0x040004D9 RID: 1241
		InstantiatedNoFixedConstructorSignature = 8
	}
}
