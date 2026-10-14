using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001DD RID: 477
	public enum ConnectionType
	{
		// Token: 0x04000791 RID: 1937
		[global::System.Runtime.Serialization.EnumMember(Value = "none")]
		None,
		// Token: 0x04000792 RID: 1938
		[global::System.Runtime.Serialization.EnumMember(Value = "cellular2g")]
		Cellular2g,
		// Token: 0x04000793 RID: 1939
		[global::System.Runtime.Serialization.EnumMember(Value = "cellular3g")]
		Cellular3g,
		// Token: 0x04000794 RID: 1940
		[global::System.Runtime.Serialization.EnumMember(Value = "cellular4g")]
		Cellular4g,
		// Token: 0x04000795 RID: 1941
		[global::System.Runtime.Serialization.EnumMember(Value = "bluetooth")]
		Bluetooth,
		// Token: 0x04000796 RID: 1942
		[global::System.Runtime.Serialization.EnumMember(Value = "ethernet")]
		Ethernet,
		// Token: 0x04000797 RID: 1943
		[global::System.Runtime.Serialization.EnumMember(Value = "wifi")]
		Wifi,
		// Token: 0x04000798 RID: 1944
		[global::System.Runtime.Serialization.EnumMember(Value = "wimax")]
		Wimax,
		// Token: 0x04000799 RID: 1945
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other
	}
}
