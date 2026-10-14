using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000BF RID: 191
	public enum AuthenticatorProtocol
	{
		// Token: 0x040002DE RID: 734
		[global::System.Runtime.Serialization.EnumMember(Value = "u2f")]
		U2f,
		// Token: 0x040002DF RID: 735
		[global::System.Runtime.Serialization.EnumMember(Value = "ctap2")]
		Ctap2
	}
}
