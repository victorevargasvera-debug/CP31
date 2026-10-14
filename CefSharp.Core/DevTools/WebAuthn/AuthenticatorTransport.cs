using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.WebAuthn
{
	// Token: 0x020000C1 RID: 193
	public enum AuthenticatorTransport
	{
		// Token: 0x040002E4 RID: 740
		[global::System.Runtime.Serialization.EnumMember(Value = "usb")]
		Usb,
		// Token: 0x040002E5 RID: 741
		[global::System.Runtime.Serialization.EnumMember(Value = "nfc")]
		Nfc,
		// Token: 0x040002E6 RID: 742
		[global::System.Runtime.Serialization.EnumMember(Value = "ble")]
		Ble,
		// Token: 0x040002E7 RID: 743
		[global::System.Runtime.Serialization.EnumMember(Value = "cable")]
		Cable,
		// Token: 0x040002E8 RID: 744
		[global::System.Runtime.Serialization.EnumMember(Value = "internal")]
		Internal
	}
}
