using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200034B RID: 843
	public enum CookieExclusionReason
	{
		// Token: 0x04000D2D RID: 3373
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeSameSiteUnspecifiedTreatedAsLax")]
		ExcludeSameSiteUnspecifiedTreatedAsLax,
		// Token: 0x04000D2E RID: 3374
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeSameSiteNoneInsecure")]
		ExcludeSameSiteNoneInsecure,
		// Token: 0x04000D2F RID: 3375
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeSameSiteLax")]
		ExcludeSameSiteLax,
		// Token: 0x04000D30 RID: 3376
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeSameSiteStrict")]
		ExcludeSameSiteStrict,
		// Token: 0x04000D31 RID: 3377
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeInvalidSameParty")]
		ExcludeInvalidSameParty,
		// Token: 0x04000D32 RID: 3378
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeSamePartyCrossPartyContext")]
		ExcludeSamePartyCrossPartyContext,
		// Token: 0x04000D33 RID: 3379
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeDomainNonASCII")]
		ExcludeDomainNonASCII,
		// Token: 0x04000D34 RID: 3380
		[global::System.Runtime.Serialization.EnumMember(Value = "ExcludeThirdPartyCookieBlockedInFirstPartySet")]
		ExcludeThirdPartyCookieBlockedInFirstPartySet
	}
}
