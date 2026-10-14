using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000026 RID: 38
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioOperation : ulong
	{
		// Token: 0x040000EC RID: 236
		[global::System.Runtime.Serialization.EnumMember]
		None = 0UL,
		// Token: 0x040000ED RID: 237
		[global::System.Runtime.Serialization.EnumMember]
		Create = 1UL,
		// Token: 0x040000EE RID: 238
		[global::System.Runtime.Serialization.EnumMember]
		Read = 2UL,
		// Token: 0x040000EF RID: 239
		[global::System.Runtime.Serialization.EnumMember]
		Program = 4UL,
		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.EnumMember]
		Flash = 8UL,
		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.Serialization.EnumMember]
		ChargingFeature = 16UL,
		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.Serialization.EnumMember]
		RemoteProgram = 32UL,
		// Token: 0x040000F3 RID: 243
		[global::System.Runtime.Serialization.EnumMember]
		RemoteUpdate = 64UL,
		// Token: 0x040000F4 RID: 244
		[global::System.Runtime.Serialization.EnumMember]
		CBIProgram = 128UL,
		// Token: 0x040000F5 RID: 245
		[global::System.Runtime.Serialization.EnumMember]
		DepotFlash = 256UL,
		// Token: 0x040000F6 RID: 246
		[global::System.Runtime.Serialization.EnumMember]
		SwitchOver = 512UL,
		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.Serialization.EnumMember]
		FileUpdate = 1024UL,
		// Token: 0x040000F8 RID: 248
		[global::System.Runtime.Serialization.EnumMember]
		PasswordReset = 2048UL,
		// Token: 0x040000F9 RID: 249
		[global::System.Runtime.Serialization.EnumMember]
		TlsHandshake = 4096UL,
		// Token: 0x040000FA RID: 250
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535UL
	}
}
