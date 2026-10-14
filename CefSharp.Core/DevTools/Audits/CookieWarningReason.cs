using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x0200034C RID: 844
	public enum CookieWarningReason
	{
		// Token: 0x04000D36 RID: 3382
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteUnspecifiedCrossSiteContext")]
		WarnSameSiteUnspecifiedCrossSiteContext,
		// Token: 0x04000D37 RID: 3383
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteNoneInsecure")]
		WarnSameSiteNoneInsecure,
		// Token: 0x04000D38 RID: 3384
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteUnspecifiedLaxAllowUnsafe")]
		WarnSameSiteUnspecifiedLaxAllowUnsafe,
		// Token: 0x04000D39 RID: 3385
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteStrictLaxDowngradeStrict")]
		WarnSameSiteStrictLaxDowngradeStrict,
		// Token: 0x04000D3A RID: 3386
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteStrictCrossDowngradeStrict")]
		WarnSameSiteStrictCrossDowngradeStrict,
		// Token: 0x04000D3B RID: 3387
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteStrictCrossDowngradeLax")]
		WarnSameSiteStrictCrossDowngradeLax,
		// Token: 0x04000D3C RID: 3388
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteLaxCrossDowngradeStrict")]
		WarnSameSiteLaxCrossDowngradeStrict,
		// Token: 0x04000D3D RID: 3389
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnSameSiteLaxCrossDowngradeLax")]
		WarnSameSiteLaxCrossDowngradeLax,
		// Token: 0x04000D3E RID: 3390
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnAttributeValueExceedsMaxSize")]
		WarnAttributeValueExceedsMaxSize,
		// Token: 0x04000D3F RID: 3391
		[global::System.Runtime.Serialization.EnumMember(Value = "WarnDomainNonASCII")]
		WarnDomainNonASCII
	}
}
