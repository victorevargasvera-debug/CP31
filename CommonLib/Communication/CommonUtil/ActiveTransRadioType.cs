using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000074 RID: 116
	[global::System.Runtime.Serialization.DataContract]
	public enum ActiveTransRadioType
	{
		// Token: 0x0400033C RID: 828
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x0400033D RID: 829
		[global::System.Runtime.Serialization.EnumMember]
		LegacyRadio,
		// Token: 0x0400033E RID: 830
		[global::System.Runtime.Serialization.EnumMember]
		FrodoRadio,
		// Token: 0x0400033F RID: 831
		NotAvailble
	}
}
