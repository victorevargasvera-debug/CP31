using System;
using System.Runtime.Serialization;

namespace Motorola.Common.CustomException
{
	// Token: 0x0200000D RID: 13
	[global::System.Runtime.Serialization.DataContract]
	public enum CruncherErrorCode
	{
		// Token: 0x0400144D RID: 5197
		None,
		// Token: 0x0400144E RID: 5198
		[global::System.Runtime.Serialization.EnumMember]
		CruncherUnknownException = 30000,
		// Token: 0x0400144F RID: 5199
		[global::System.Runtime.Serialization.EnumMember]
		CruncherWorkObjectCreatedFailed = 30005,
		// Token: 0x04001450 RID: 5200
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpsWasDeleted = 30010,
		// Token: 0x04001451 RID: 5201
		[global::System.Runtime.Serialization.EnumMember]
		CruncherFolderWasDeleted = 30015,
		// Token: 0x04001452 RID: 5202
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCpsCrashed = 30020,
		// Token: 0x04001453 RID: 5203
		[global::System.Runtime.Serialization.EnumMember]
		CruncherCodeplugWasDeleted = 30025
	}
}
