using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000029 RID: 41
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum SwitchOverOption : ushort
	{
		// Token: 0x04000108 RID: 264
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x04000109 RID: 265
		[global::System.Runtime.Serialization.EnumMember]
		DelayTOD = 64,
		// Token: 0x0400010A RID: 266
		[global::System.Runtime.Serialization.EnumMember]
		SuppressPN = 128
	}
}
