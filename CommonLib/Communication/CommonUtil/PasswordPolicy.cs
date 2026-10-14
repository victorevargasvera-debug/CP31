using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000060 RID: 96
	[global::System.Runtime.Serialization.DataContract]
	public enum PasswordPolicy : sbyte
	{
		// Token: 0x0400026B RID: 619
		[global::System.Runtime.Serialization.EnumMember]
		NA = -1,
		// Token: 0x0400026C RID: 620
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400026D RID: 621
		[global::System.Runtime.Serialization.EnumMember]
		Basic,
		// Token: 0x0400026E RID: 622
		[global::System.Runtime.Serialization.EnumMember]
		Enhanced
	}
}
