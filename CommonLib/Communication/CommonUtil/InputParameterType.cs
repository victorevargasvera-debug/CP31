using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000028 RID: 40
	[global::System.Runtime.Serialization.DataContract]
	public enum InputParameterType
	{
		// Token: 0x04000101 RID: 257
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x04000102 RID: 258
		[global::System.Runtime.Serialization.EnumMember]
		FlashStrapPath,
		// Token: 0x04000103 RID: 259
		[global::System.Runtime.Serialization.EnumMember]
		ModelNumber,
		// Token: 0x04000104 RID: 260
		[global::System.Runtime.Serialization.EnumMember]
		CPVersion,
		// Token: 0x04000105 RID: 261
		[global::System.Runtime.Serialization.EnumMember]
		SerialNumber,
		// Token: 0x04000106 RID: 262
		[global::System.Runtime.Serialization.EnumMember]
		FWPath
	}
}
