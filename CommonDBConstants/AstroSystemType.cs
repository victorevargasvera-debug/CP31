using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200000D RID: 13
	[global::System.Runtime.Serialization.DataContract]
	public enum AstroSystemType
	{
		// Token: 0x04000034 RID: 52
		[global::System.Xml.Serialization.XmlEnum("TRUNCKING")]
		[global::System.Runtime.Serialization.EnumMember]
		TRUNCKING,
		// Token: 0x04000035 RID: 53
		[global::System.Xml.Serialization.XmlEnum("CONVENTIONAL")]
		[global::System.Runtime.Serialization.EnumMember]
		CONVENTIONAL,
		// Token: 0x04000036 RID: 54
		[global::System.Runtime.Serialization.EnumMember]
		[global::System.Xml.Serialization.XmlEnum("BROADBANDONLY")]
		BROADBANDONLY,
		// Token: 0x04000037 RID: 55
		[global::System.Xml.Serialization.XmlEnum("CONVENTIONALBROADBAND")]
		[global::System.Runtime.Serialization.EnumMember]
		CONVENTIONALBROADBAND,
		// Token: 0x04000038 RID: 56
		[global::System.Xml.Serialization.XmlEnum("TRUNKINGBROADBAND")]
		[global::System.Runtime.Serialization.EnumMember]
		TRUNKINGBROADBAND
	}
}
