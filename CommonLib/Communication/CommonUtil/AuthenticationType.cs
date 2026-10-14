using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200001A RID: 26
	[global::System.Runtime.Serialization.DataContract]
	public enum AuthenticationType : short
	{
		// Token: 0x04000091 RID: 145
		[global::System.Runtime.Serialization.EnumMember]
		None = -1,
		// Token: 0x04000092 RID: 146
		[global::System.Runtime.Serialization.EnumMember]
		PreSharedKey,
		// Token: 0x04000093 RID: 147
		[global::System.Runtime.Serialization.EnumMember]
		Certificate,
		// Token: 0x04000094 RID: 148
		[global::System.Runtime.Serialization.EnumMember]
		PasswordIndex
	}
}
