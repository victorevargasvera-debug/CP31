using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001F0 RID: 496
	public enum AlternateProtocolUsage
	{
		// Token: 0x0400082E RID: 2094
		[global::System.Runtime.Serialization.EnumMember(Value = "alternativeJobWonWithoutRace")]
		AlternativeJobWonWithoutRace,
		// Token: 0x0400082F RID: 2095
		[global::System.Runtime.Serialization.EnumMember(Value = "alternativeJobWonRace")]
		AlternativeJobWonRace,
		// Token: 0x04000830 RID: 2096
		[global::System.Runtime.Serialization.EnumMember(Value = "mainJobWonRace")]
		MainJobWonRace,
		// Token: 0x04000831 RID: 2097
		[global::System.Runtime.Serialization.EnumMember(Value = "mappingMissing")]
		MappingMissing,
		// Token: 0x04000832 RID: 2098
		[global::System.Runtime.Serialization.EnumMember(Value = "broken")]
		Broken,
		// Token: 0x04000833 RID: 2099
		[global::System.Runtime.Serialization.EnumMember(Value = "dnsAlpnH3JobWonWithoutRace")]
		DnsAlpnH3JobWonWithoutRace,
		// Token: 0x04000834 RID: 2100
		[global::System.Runtime.Serialization.EnumMember(Value = "dnsAlpnH3JobWonRace")]
		DnsAlpnH3JobWonRace,
		// Token: 0x04000835 RID: 2101
		[global::System.Runtime.Serialization.EnumMember(Value = "unspecifiedReason")]
		UnspecifiedReason
	}
}
