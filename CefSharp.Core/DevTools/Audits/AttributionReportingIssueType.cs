using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000360 RID: 864
	public enum AttributionReportingIssueType
	{
		// Token: 0x04000DB5 RID: 3509
		[global::System.Runtime.Serialization.EnumMember(Value = "PermissionPolicyDisabled")]
		PermissionPolicyDisabled,
		// Token: 0x04000DB6 RID: 3510
		[global::System.Runtime.Serialization.EnumMember(Value = "UntrustworthyReportingOrigin")]
		UntrustworthyReportingOrigin,
		// Token: 0x04000DB7 RID: 3511
		[global::System.Runtime.Serialization.EnumMember(Value = "InsecureContext")]
		InsecureContext,
		// Token: 0x04000DB8 RID: 3512
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidHeader")]
		InvalidHeader,
		// Token: 0x04000DB9 RID: 3513
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidRegisterTriggerHeader")]
		InvalidRegisterTriggerHeader,
		// Token: 0x04000DBA RID: 3514
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidEligibleHeader")]
		InvalidEligibleHeader,
		// Token: 0x04000DBB RID: 3515
		[global::System.Runtime.Serialization.EnumMember(Value = "SourceAndTriggerHeaders")]
		SourceAndTriggerHeaders,
		// Token: 0x04000DBC RID: 3516
		[global::System.Runtime.Serialization.EnumMember(Value = "SourceIgnored")]
		SourceIgnored,
		// Token: 0x04000DBD RID: 3517
		[global::System.Runtime.Serialization.EnumMember(Value = "TriggerIgnored")]
		TriggerIgnored,
		// Token: 0x04000DBE RID: 3518
		[global::System.Runtime.Serialization.EnumMember(Value = "OsSourceIgnored")]
		OsSourceIgnored,
		// Token: 0x04000DBF RID: 3519
		[global::System.Runtime.Serialization.EnumMember(Value = "OsTriggerIgnored")]
		OsTriggerIgnored,
		// Token: 0x04000DC0 RID: 3520
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidRegisterOsSourceHeader")]
		InvalidRegisterOsSourceHeader,
		// Token: 0x04000DC1 RID: 3521
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidRegisterOsTriggerHeader")]
		InvalidRegisterOsTriggerHeader,
		// Token: 0x04000DC2 RID: 3522
		[global::System.Runtime.Serialization.EnumMember(Value = "WebAndOsHeaders")]
		WebAndOsHeaders,
		// Token: 0x04000DC3 RID: 3523
		[global::System.Runtime.Serialization.EnumMember(Value = "NoWebOrOsSupport")]
		NoWebOrOsSupport
	}
}
