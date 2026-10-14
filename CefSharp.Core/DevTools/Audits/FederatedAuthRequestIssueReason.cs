using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200036A RID: 874
	public enum FederatedAuthRequestIssueReason
	{
		// Token: 0x04000DE8 RID: 3560
		[global::System.Runtime.Serialization.EnumMember(Value = "ShouldEmbargo")]
		ShouldEmbargo,
		// Token: 0x04000DE9 RID: 3561
		[global::System.Runtime.Serialization.EnumMember(Value = "TooManyRequests")]
		TooManyRequests,
		// Token: 0x04000DEA RID: 3562
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownHttpNotFound")]
		WellKnownHttpNotFound,
		// Token: 0x04000DEB RID: 3563
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownNoResponse")]
		WellKnownNoResponse,
		// Token: 0x04000DEC RID: 3564
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownInvalidResponse")]
		WellKnownInvalidResponse,
		// Token: 0x04000DED RID: 3565
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownListEmpty")]
		WellKnownListEmpty,
		// Token: 0x04000DEE RID: 3566
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownInvalidContentType")]
		WellKnownInvalidContentType,
		// Token: 0x04000DEF RID: 3567
		[global::System.Runtime.Serialization.EnumMember(Value = "ConfigNotInWellKnown")]
		ConfigNotInWellKnown,
		// Token: 0x04000DF0 RID: 3568
		[global::System.Runtime.Serialization.EnumMember(Value = "WellKnownTooBig")]
		WellKnownTooBig,
		// Token: 0x04000DF1 RID: 3569
		[global::System.Runtime.Serialization.EnumMember(Value = "ConfigHttpNotFound")]
		ConfigHttpNotFound,
		// Token: 0x04000DF2 RID: 3570
		[global::System.Runtime.Serialization.EnumMember(Value = "ConfigNoResponse")]
		ConfigNoResponse,
		// Token: 0x04000DF3 RID: 3571
		[global::System.Runtime.Serialization.EnumMember(Value = "ConfigInvalidResponse")]
		ConfigInvalidResponse,
		// Token: 0x04000DF4 RID: 3572
		[global::System.Runtime.Serialization.EnumMember(Value = "ConfigInvalidContentType")]
		ConfigInvalidContentType,
		// Token: 0x04000DF5 RID: 3573
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientMetadataHttpNotFound")]
		ClientMetadataHttpNotFound,
		// Token: 0x04000DF6 RID: 3574
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientMetadataNoResponse")]
		ClientMetadataNoResponse,
		// Token: 0x04000DF7 RID: 3575
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientMetadataInvalidResponse")]
		ClientMetadataInvalidResponse,
		// Token: 0x04000DF8 RID: 3576
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientMetadataInvalidContentType")]
		ClientMetadataInvalidContentType,
		// Token: 0x04000DF9 RID: 3577
		[global::System.Runtime.Serialization.EnumMember(Value = "DisabledInSettings")]
		DisabledInSettings,
		// Token: 0x04000DFA RID: 3578
		[global::System.Runtime.Serialization.EnumMember(Value = "ErrorFetchingSignin")]
		ErrorFetchingSignin,
		// Token: 0x04000DFB RID: 3579
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidSigninResponse")]
		InvalidSigninResponse,
		// Token: 0x04000DFC RID: 3580
		[global::System.Runtime.Serialization.EnumMember(Value = "AccountsHttpNotFound")]
		AccountsHttpNotFound,
		// Token: 0x04000DFD RID: 3581
		[global::System.Runtime.Serialization.EnumMember(Value = "AccountsNoResponse")]
		AccountsNoResponse,
		// Token: 0x04000DFE RID: 3582
		[global::System.Runtime.Serialization.EnumMember(Value = "AccountsInvalidResponse")]
		AccountsInvalidResponse,
		// Token: 0x04000DFF RID: 3583
		[global::System.Runtime.Serialization.EnumMember(Value = "AccountsListEmpty")]
		AccountsListEmpty,
		// Token: 0x04000E00 RID: 3584
		[global::System.Runtime.Serialization.EnumMember(Value = "AccountsInvalidContentType")]
		AccountsInvalidContentType,
		// Token: 0x04000E01 RID: 3585
		[global::System.Runtime.Serialization.EnumMember(Value = "IdTokenHttpNotFound")]
		IdTokenHttpNotFound,
		// Token: 0x04000E02 RID: 3586
		[global::System.Runtime.Serialization.EnumMember(Value = "IdTokenNoResponse")]
		IdTokenNoResponse,
		// Token: 0x04000E03 RID: 3587
		[global::System.Runtime.Serialization.EnumMember(Value = "IdTokenInvalidResponse")]
		IdTokenInvalidResponse,
		// Token: 0x04000E04 RID: 3588
		[global::System.Runtime.Serialization.EnumMember(Value = "IdTokenInvalidRequest")]
		IdTokenInvalidRequest,
		// Token: 0x04000E05 RID: 3589
		[global::System.Runtime.Serialization.EnumMember(Value = "IdTokenInvalidContentType")]
		IdTokenInvalidContentType,
		// Token: 0x04000E06 RID: 3590
		[global::System.Runtime.Serialization.EnumMember(Value = "ErrorIdToken")]
		ErrorIdToken,
		// Token: 0x04000E07 RID: 3591
		[global::System.Runtime.Serialization.EnumMember(Value = "Canceled")]
		Canceled,
		// Token: 0x04000E08 RID: 3592
		[global::System.Runtime.Serialization.EnumMember(Value = "RpPageNotVisible")]
		RpPageNotVisible
	}
}
