using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F9 RID: 505
	public enum SetCookieBlockedReason
	{
		// Token: 0x0400087A RID: 2170
		[global::System.Runtime.Serialization.EnumMember(Value = "SecureOnly")]
		SecureOnly,
		// Token: 0x0400087B RID: 2171
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteStrict")]
		SameSiteStrict,
		// Token: 0x0400087C RID: 2172
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteLax")]
		SameSiteLax,
		// Token: 0x0400087D RID: 2173
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteUnspecifiedTreatedAsLax")]
		SameSiteUnspecifiedTreatedAsLax,
		// Token: 0x0400087E RID: 2174
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteNoneInsecure")]
		SameSiteNoneInsecure,
		// Token: 0x0400087F RID: 2175
		[global::System.Runtime.Serialization.EnumMember(Value = "UserPreferences")]
		UserPreferences,
		// Token: 0x04000880 RID: 2176
		[global::System.Runtime.Serialization.EnumMember(Value = "ThirdPartyBlockedInFirstPartySet")]
		ThirdPartyBlockedInFirstPartySet,
		// Token: 0x04000881 RID: 2177
		[global::System.Runtime.Serialization.EnumMember(Value = "SyntaxError")]
		SyntaxError,
		// Token: 0x04000882 RID: 2178
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemeNotSupported")]
		SchemeNotSupported,
		// Token: 0x04000883 RID: 2179
		[global::System.Runtime.Serialization.EnumMember(Value = "OverwriteSecure")]
		OverwriteSecure,
		// Token: 0x04000884 RID: 2180
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidDomain")]
		InvalidDomain,
		// Token: 0x04000885 RID: 2181
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidPrefix")]
		InvalidPrefix,
		// Token: 0x04000886 RID: 2182
		[global::System.Runtime.Serialization.EnumMember(Value = "UnknownError")]
		UnknownError,
		// Token: 0x04000887 RID: 2183
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteStrict")]
		SchemefulSameSiteStrict,
		// Token: 0x04000888 RID: 2184
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteLax")]
		SchemefulSameSiteLax,
		// Token: 0x04000889 RID: 2185
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteUnspecifiedTreatedAsLax")]
		SchemefulSameSiteUnspecifiedTreatedAsLax,
		// Token: 0x0400088A RID: 2186
		[global::System.Runtime.Serialization.EnumMember(Value = "SamePartyFromCrossPartyContext")]
		SamePartyFromCrossPartyContext,
		// Token: 0x0400088B RID: 2187
		[global::System.Runtime.Serialization.EnumMember(Value = "SamePartyConflictsWithOtherAttributes")]
		SamePartyConflictsWithOtherAttributes,
		// Token: 0x0400088C RID: 2188
		[global::System.Runtime.Serialization.EnumMember(Value = "NameValuePairExceedsMaxSize")]
		NameValuePairExceedsMaxSize
	}
}
