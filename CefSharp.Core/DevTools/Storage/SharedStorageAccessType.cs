using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000126 RID: 294
	public enum SharedStorageAccessType
	{
		// Token: 0x04000427 RID: 1063
		[global::System.Runtime.Serialization.EnumMember(Value = "documentAddModule")]
		DocumentAddModule,
		// Token: 0x04000428 RID: 1064
		[global::System.Runtime.Serialization.EnumMember(Value = "documentSelectURL")]
		DocumentSelectURL,
		// Token: 0x04000429 RID: 1065
		[global::System.Runtime.Serialization.EnumMember(Value = "documentRun")]
		DocumentRun,
		// Token: 0x0400042A RID: 1066
		[global::System.Runtime.Serialization.EnumMember(Value = "documentSet")]
		DocumentSet,
		// Token: 0x0400042B RID: 1067
		[global::System.Runtime.Serialization.EnumMember(Value = "documentAppend")]
		DocumentAppend,
		// Token: 0x0400042C RID: 1068
		[global::System.Runtime.Serialization.EnumMember(Value = "documentDelete")]
		DocumentDelete,
		// Token: 0x0400042D RID: 1069
		[global::System.Runtime.Serialization.EnumMember(Value = "documentClear")]
		DocumentClear,
		// Token: 0x0400042E RID: 1070
		[global::System.Runtime.Serialization.EnumMember(Value = "workletSet")]
		WorkletSet,
		// Token: 0x0400042F RID: 1071
		[global::System.Runtime.Serialization.EnumMember(Value = "workletAppend")]
		WorkletAppend,
		// Token: 0x04000430 RID: 1072
		[global::System.Runtime.Serialization.EnumMember(Value = "workletDelete")]
		WorkletDelete,
		// Token: 0x04000431 RID: 1073
		[global::System.Runtime.Serialization.EnumMember(Value = "workletClear")]
		WorkletClear,
		// Token: 0x04000432 RID: 1074
		[global::System.Runtime.Serialization.EnumMember(Value = "workletGet")]
		WorkletGet,
		// Token: 0x04000433 RID: 1075
		[global::System.Runtime.Serialization.EnumMember(Value = "workletKeys")]
		WorkletKeys,
		// Token: 0x04000434 RID: 1076
		[global::System.Runtime.Serialization.EnumMember(Value = "workletEntries")]
		WorkletEntries,
		// Token: 0x04000435 RID: 1077
		[global::System.Runtime.Serialization.EnumMember(Value = "workletLength")]
		WorkletLength,
		// Token: 0x04000436 RID: 1078
		[global::System.Runtime.Serialization.EnumMember(Value = "workletRemainingBudget")]
		WorkletRemainingBudget
	}
}
