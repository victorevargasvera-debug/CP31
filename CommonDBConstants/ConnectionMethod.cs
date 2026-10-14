using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200001E RID: 30
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum ConnectionMethod
	{
		// Token: 0x040000F0 RID: 240
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x040000F1 RID: 241
		[global::System.Runtime.Serialization.EnumMember]
		WIRED = 1,
		// Token: 0x040000F2 RID: 242
		[global::System.Runtime.Serialization.EnumMember]
		OTAP = 2,
		// Token: 0x040000F3 RID: 243
		[global::System.Runtime.Serialization.EnumMember]
		RRP = 4,
		// Token: 0x040000F4 RID: 244
		[global::System.Runtime.Serialization.EnumMember]
		PROVISIONING = 8,
		// Token: 0x040000F5 RID: 245
		[global::System.Runtime.Serialization.EnumMember]
		DMR3RRP = 16,
		// Token: 0x040000F6 RID: 246
		[global::System.Runtime.Serialization.EnumMember]
		WIFI = 32,
		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.Serialization.EnumMember]
		BLUETOOTH = 64,
		// Token: 0x040000F8 RID: 248
		[global::System.Runtime.Serialization.EnumMember]
		USBOrWIFI = 33,
		// Token: 0x040000F9 RID: 249
		[global::System.Runtime.Serialization.EnumMember]
		USBOrWIFIOrBT = 97,
		// Token: 0x040000FA RID: 250
		[global::System.Runtime.Serialization.EnumMember]
		FUDALLYUSB = 128
	}
}
