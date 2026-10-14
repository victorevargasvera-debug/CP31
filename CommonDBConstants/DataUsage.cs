using System;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000028 RID: 40
	[global::System.Flags]
	[global::System.Serializable]
	public enum DataUsage
	{
		// Token: 0x0400012F RID: 303
		RadioSpecific = 1,
		// Token: 0x04000130 RID: 304
		NeedSyncFromConfiguration = 2,
		// Token: 0x04000131 RID: 305
		NeedSyncFromConfigurationandRadioSpecific = 3
	}
}
