using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x0200000F RID: 15
	[global::System.Runtime.Serialization.DataContract]
	public enum ProxyErrorCode
	{
		// Token: 0x04001456 RID: 5206
		None,
		// Token: 0x04001457 RID: 5207
		[global::System.Runtime.Serialization.EnumMember]
		ProxyUnknownException = 40000,
		// Token: 0x04001458 RID: 5208
		[global::System.Runtime.Serialization.EnumMember]
		ProxyValidationFailed = 40005
	}
}
