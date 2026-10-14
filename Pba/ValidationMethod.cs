using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000036 RID: 54
	[global::System.Runtime.Serialization.DataContract]
	public enum ValidationMethod
	{
		// Token: 0x0400013D RID: 317
		[global::System.Runtime.Serialization.EnumMember]
		Equal,
		// Token: 0x0400013E RID: 318
		[global::System.Runtime.Serialization.EnumMember]
		Greater,
		// Token: 0x0400013F RID: 319
		[global::System.Runtime.Serialization.EnumMember]
		NotGreater,
		// Token: 0x04000140 RID: 320
		[global::System.Runtime.Serialization.EnumMember]
		Less,
		// Token: 0x04000141 RID: 321
		[global::System.Runtime.Serialization.EnumMember]
		NotLess
	}
}
