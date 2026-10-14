using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000008 RID: 8
	public struct Cntr_Alarm
	{
		// Token: 0x04000053 RID: 83
		public short cntrRegSz;

		// Token: 0x04000054 RID: 84
		public short cntrRegOffset;

		// Token: 0x04000055 RID: 85
		public short alarmRegSz;

		// Token: 0x04000056 RID: 86
		public short alarmRegOffset;

		// Token: 0x04000057 RID: 87
		public byte statusRegByte;

		// Token: 0x04000058 RID: 88
		public uint timerVal;

		// Token: 0x04000059 RID: 89
		public uint alarmVal;
	}
}
