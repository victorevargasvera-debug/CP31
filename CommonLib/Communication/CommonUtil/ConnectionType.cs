using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000022 RID: 34
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum ConnectionType
	{
		// Token: 0x040000B8 RID: 184
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x040000B9 RID: 185
		[global::System.Runtime.Serialization.EnumMember]
		VCOM = 1,
		// Token: 0x040000BA RID: 186
		[global::System.Runtime.Serialization.EnumMember]
		RS232 = 2,
		// Token: 0x040000BB RID: 187
		[global::System.Runtime.Serialization.EnumMember]
		NetAdapter = 4,
		// Token: 0x040000BC RID: 188
		[global::System.Runtime.Serialization.EnumMember]
		LENetwork = 8,
		// Token: 0x040000BD RID: 189
		[global::System.Runtime.Serialization.EnumMember]
		Otap = 16,
		// Token: 0x040000BE RID: 190
		[global::System.Runtime.Serialization.EnumMember]
		Bluetooth = 32,
		// Token: 0x040000BF RID: 191
		[global::System.Runtime.Serialization.EnumMember]
		WIFI = 64,
		// Token: 0x040000C0 RID: 192
		[global::System.Runtime.Serialization.EnumMember]
		Fudally = 128,
		// Token: 0x040000C1 RID: 193
		[global::System.Runtime.Serialization.EnumMember]
		Provisioning = 256,
		// Token: 0x040000C2 RID: 194
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Network = 512,
		// Token: 0x040000C3 RID: 195
		[global::System.Runtime.Serialization.EnumMember]
		VirtualConnection = 1024,
		// Token: 0x040000C4 RID: 196
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
