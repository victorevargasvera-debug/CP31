using System;

namespace Microsoft.Practices.Prism.Modularity
{
	// Token: 0x02000047 RID: 71
	public enum ModuleState
	{
		// Token: 0x04000071 RID: 113
		NotStarted,
		// Token: 0x04000072 RID: 114
		LoadingTypes,
		// Token: 0x04000073 RID: 115
		ReadyForInitialization,
		// Token: 0x04000074 RID: 116
		Initializing,
		// Token: 0x04000075 RID: 117
		Initialized
	}
}
