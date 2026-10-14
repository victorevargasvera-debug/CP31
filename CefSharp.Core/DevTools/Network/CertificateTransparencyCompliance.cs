using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001E8 RID: 488
	public enum CertificateTransparencyCompliance
	{
		// Token: 0x040007ED RID: 2029
		[global::System.Runtime.Serialization.EnumMember(Value = "unknown")]
		Unknown,
		// Token: 0x040007EE RID: 2030
		[global::System.Runtime.Serialization.EnumMember(Value = "not-compliant")]
		NotCompliant,
		// Token: 0x040007EF RID: 2031
		[global::System.Runtime.Serialization.EnumMember(Value = "compliant")]
		Compliant
	}
}
