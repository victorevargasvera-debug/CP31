using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000081 RID: 129
	[global::System.Runtime.Serialization.DataContract]
	public enum MetaDataPathType
	{
		// Token: 0x0400038F RID: 911
		[global::System.Runtime.Serialization.EnumMember]
		Firmware,
		// Token: 0x04000390 RID: 912
		[global::System.Runtime.Serialization.EnumMember]
		Config,
		// Token: 0x04000391 RID: 913
		[global::System.Runtime.Serialization.EnumMember]
		Kenel,
		// Token: 0x04000392 RID: 914
		[global::System.Runtime.Serialization.EnumMember]
		Flashstrap,
		// Token: 0x04000393 RID: 915
		[global::System.Runtime.Serialization.EnumMember]
		ModelTable
	}
}
