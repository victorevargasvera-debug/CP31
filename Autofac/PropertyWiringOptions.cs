using System;

namespace Autofac
{
	// Token: 0x02000011 RID: 17
	[global::System.Flags]
	public enum PropertyWiringOptions
	{
		// Token: 0x04000012 RID: 18
		None = 0,
		// Token: 0x04000013 RID: 19
		AllowCircularDependencies = 1,
		// Token: 0x04000014 RID: 20
		PreserveSetValues = 2
	}
}
