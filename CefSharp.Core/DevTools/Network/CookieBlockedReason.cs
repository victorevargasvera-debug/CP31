using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001FA RID: 506
	public enum CookieBlockedReason
	{
		// Token: 0x0400088E RID: 2190
		[global::System.Runtime.Serialization.EnumMember(Value = "SecureOnly")]
		SecureOnly,
		// Token: 0x0400088F RID: 2191
		[global::System.Runtime.Serialization.EnumMember(Value = "NotOnPath")]
		NotOnPath,
		// Token: 0x04000890 RID: 2192
		[global::System.Runtime.Serialization.EnumMember(Value = "DomainMismatch")]
		DomainMismatch,
		// Token: 0x04000891 RID: 2193
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteStrict")]
		SameSiteStrict,
		// Token: 0x04000892 RID: 2194
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteLax")]
		SameSiteLax,
		// Token: 0x04000893 RID: 2195
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteUnspecifiedTreatedAsLax")]
		SameSiteUnspecifiedTreatedAsLax,
		// Token: 0x04000894 RID: 2196
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteNoneInsecure")]
		SameSiteNoneInsecure,
		// Token: 0x04000895 RID: 2197
		[global::System.Runtime.Serialization.EnumMember(Value = "UserPreferences")]
		UserPreferences,
		// Token: 0x04000896 RID: 2198
		[global::System.Runtime.Serialization.EnumMember(Value = "ThirdPartyBlockedInFirstPartySet")]
		ThirdPartyBlockedInFirstPartySet,
		// Token: 0x04000897 RID: 2199
		[global::System.Runtime.Serialization.EnumMember(Value = "UnknownError")]
		UnknownError,
		// Token: 0x04000898 RID: 2200
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteStrict")]
		SchemefulSameSiteStrict,
		// Token: 0x04000899 RID: 2201
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteLax")]
		SchemefulSameSiteLax,
		// Token: 0x0400089A RID: 2202
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemefulSameSiteUnspecifiedTreatedAsLax")]
		SchemefulSameSiteUnspecifiedTreatedAsLax,
		// Token: 0x0400089B RID: 2203
		[global::System.Runtime.Serialization.EnumMember(Value = "SamePartyFromCrossPartyContext")]
		SamePartyFromCrossPartyContext,
		// Token: 0x0400089C RID: 2204
		[global::System.Runtime.Serialization.EnumMember(Value = "NameValuePairExceedsMaxSize")]
		NameValuePairExceedsMaxSize
	}
}
