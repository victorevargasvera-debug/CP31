using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000073 RID: 115
	[global::System.Runtime.Serialization.DataContract]
	public enum TetraRadioType
	{
		// Token: 0x04000335 RID: 821
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x04000336 RID: 822
		[global::System.Runtime.Serialization.EnumMember]
		CONTROL_HEAD,
		// Token: 0x04000337 RID: 823
		[global::System.Runtime.Serialization.EnumMember]
		TRANSCEIVER,
		// Token: 0x04000338 RID: 824
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL,
		// Token: 0x04000339 RID: 825
		[global::System.Runtime.Serialization.EnumMember]
		DATABOX_PORT1,
		// Token: 0x0400033A RID: 826
		[global::System.Runtime.Serialization.EnumMember]
		DATABOX_PORT2
	}
}
