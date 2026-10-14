using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioState
	{
		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.Serialization.EnumMember]
		Attached,
		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.Serialization.EnumMember]
		InitializingDevice,
		// Token: 0x040000E6 RID: 230
		[global::System.Runtime.Serialization.EnumMember]
		Connecting,
		// Token: 0x040000E7 RID: 231
		[global::System.Runtime.Serialization.EnumMember]
		Ready,
		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.Serialization.EnumMember]
		Busy,
		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.Serialization.EnumMember]
		Removing,
		// Token: 0x040000EA RID: 234
		[global::System.Runtime.Serialization.EnumMember]
		Detached
	}
}
