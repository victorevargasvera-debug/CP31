using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001EA RID: 490
	public enum CorsError
	{
		// Token: 0x040007FE RID: 2046
		[global::System.Runtime.Serialization.EnumMember(Value = "DisallowedByMode")]
		DisallowedByMode,
		// Token: 0x040007FF RID: 2047
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidResponse")]
		InvalidResponse,
		// Token: 0x04000800 RID: 2048
		[global::System.Runtime.Serialization.EnumMember(Value = "WildcardOriginNotAllowed")]
		WildcardOriginNotAllowed,
		// Token: 0x04000801 RID: 2049
		[global::System.Runtime.Serialization.EnumMember(Value = "MissingAllowOriginHeader")]
		MissingAllowOriginHeader,
		// Token: 0x04000802 RID: 2050
		[global::System.Runtime.Serialization.EnumMember(Value = "MultipleAllowOriginValues")]
		MultipleAllowOriginValues,
		// Token: 0x04000803 RID: 2051
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidAllowOriginValue")]
		InvalidAllowOriginValue,
		// Token: 0x04000804 RID: 2052
		[global::System.Runtime.Serialization.EnumMember(Value = "AllowOriginMismatch")]
		AllowOriginMismatch,
		// Token: 0x04000805 RID: 2053
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidAllowCredentials")]
		InvalidAllowCredentials,
		// Token: 0x04000806 RID: 2054
		[global::System.Runtime.Serialization.EnumMember(Value = "CorsDisabledScheme")]
		CorsDisabledScheme,
		// Token: 0x04000807 RID: 2055
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightInvalidStatus")]
		PreflightInvalidStatus,
		// Token: 0x04000808 RID: 2056
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightDisallowedRedirect")]
		PreflightDisallowedRedirect,
		// Token: 0x04000809 RID: 2057
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightWildcardOriginNotAllowed")]
		PreflightWildcardOriginNotAllowed,
		// Token: 0x0400080A RID: 2058
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightMissingAllowOriginHeader")]
		PreflightMissingAllowOriginHeader,
		// Token: 0x0400080B RID: 2059
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightMultipleAllowOriginValues")]
		PreflightMultipleAllowOriginValues,
		// Token: 0x0400080C RID: 2060
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightInvalidAllowOriginValue")]
		PreflightInvalidAllowOriginValue,
		// Token: 0x0400080D RID: 2061
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightAllowOriginMismatch")]
		PreflightAllowOriginMismatch,
		// Token: 0x0400080E RID: 2062
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightInvalidAllowCredentials")]
		PreflightInvalidAllowCredentials,
		// Token: 0x0400080F RID: 2063
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightMissingAllowExternal")]
		PreflightMissingAllowExternal,
		// Token: 0x04000810 RID: 2064
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightInvalidAllowExternal")]
		PreflightInvalidAllowExternal,
		// Token: 0x04000811 RID: 2065
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightMissingAllowPrivateNetwork")]
		PreflightMissingAllowPrivateNetwork,
		// Token: 0x04000812 RID: 2066
		[global::System.Runtime.Serialization.EnumMember(Value = "PreflightInvalidAllowPrivateNetwork")]
		PreflightInvalidAllowPrivateNetwork,
		// Token: 0x04000813 RID: 2067
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidAllowMethodsPreflightResponse")]
		InvalidAllowMethodsPreflightResponse,
		// Token: 0x04000814 RID: 2068
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidAllowHeadersPreflightResponse")]
		InvalidAllowHeadersPreflightResponse,
		// Token: 0x04000815 RID: 2069
		[global::System.Runtime.Serialization.EnumMember(Value = "MethodDisallowedByPreflightResponse")]
		MethodDisallowedByPreflightResponse,
		// Token: 0x04000816 RID: 2070
		[global::System.Runtime.Serialization.EnumMember(Value = "HeaderDisallowedByPreflightResponse")]
		HeaderDisallowedByPreflightResponse,
		// Token: 0x04000817 RID: 2071
		[global::System.Runtime.Serialization.EnumMember(Value = "RedirectContainsCredentials")]
		RedirectContainsCredentials,
		// Token: 0x04000818 RID: 2072
		[global::System.Runtime.Serialization.EnumMember(Value = "InsecurePrivateNetwork")]
		InsecurePrivateNetwork,
		// Token: 0x04000819 RID: 2073
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidPrivateNetworkAccess")]
		InvalidPrivateNetworkAccess,
		// Token: 0x0400081A RID: 2074
		[global::System.Runtime.Serialization.EnumMember(Value = "UnexpectedPrivateNetworkAccess")]
		UnexpectedPrivateNetworkAccess,
		// Token: 0x0400081B RID: 2075
		[global::System.Runtime.Serialization.EnumMember(Value = "NoCorsRedirectModeNotFollow")]
		NoCorsRedirectModeNotFollow
	}
}
