using System;

namespace Autofac.Builder
{
	// Token: 0x020000B9 RID: 185
	[global::System.Flags]
	public enum ContainerBuildOptions
	{
		// Token: 0x04000123 RID: 291
		None = 0,
		// Token: 0x04000124 RID: 292
		ExcludeDefaultModules = 2,
		// Token: 0x04000125 RID: 293
		IgnoreStartableComponents = 4
	}
}
