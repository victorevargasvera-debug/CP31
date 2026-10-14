using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000027 RID: 39
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum RadioStorage
	{
		// Token: 0x040000FC RID: 252
		[global::System.Runtime.Serialization.EnumMember]
		Unknown = 0,
		// Token: 0x040000FD RID: 253
		[global::System.Runtime.Serialization.EnumMember]
		Raw = 1,
		// Token: 0x040000FE RID: 254
		[global::System.Runtime.Serialization.EnumMember]
		FileSystem = 2,
		// Token: 0x040000FF RID: 255
		[global::System.Runtime.Serialization.EnumMember]
		Any = 65535
	}
}
