using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000012 RID: 18
	[global::System.Flags]
	public enum DeviceControlOperationType
	{
		// Token: 0x0400003F RID: 63
		None = 0,
		// Token: 0x04000040 RID: 64
		TurnOffRadio = 1,
		// Token: 0x04000041 RID: 65
		LLPIsAvailable = 2,
		// Token: 0x04000042 RID: 66
		SwitchModeToNormal = 4,
		// Token: 0x04000043 RID: 67
		SwitchModeToKernel = 8,
		// Token: 0x04000044 RID: 68
		RemoveRadio = 16
	}
}
