using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200005C RID: 92
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum ProductFamily
	{
		// Token: 0x040003A8 RID: 936
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x040003A9 RID: 937
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO)]
		APX = 1,
		// Token: 0x040003AA RID: 938
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		Matrix = 2,
		// Token: 0x040003AB RID: 939
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		[global::System.Runtime.Serialization.EnumMember]
		Paradise = 4,
		// Token: 0x040003AC RID: 940
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		Phoenix = 8,
		// Token: 0x040003AD RID: 941
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		[global::System.Runtime.Serialization.EnumMember]
		MatrixRepeater = 16,
		// Token: 0x040003AE RID: 942
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		ParadiseRepeater = 32,
		// Token: 0x040003AF RID: 943
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.MIXED)]
		Denali = 64,
		// Token: 0x040003B0 RID: 944
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		[global::System.Runtime.Serialization.EnumMember]
		ParadiseLight = 128,
		// Token: 0x040003B1 RID: 945
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PBB)]
		PBB = 256,
		// Token: 0x040003B2 RID: 946
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		[global::System.Runtime.Serialization.EnumMember]
		DMR3Controller = 512,
		// Token: 0x040003B3 RID: 947
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		MNIS = 1024,
		// Token: 0x040003B4 RID: 948
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.PCR)]
		VRC = 2048,
		// Token: 0x040003B5 RID: 949
		[global::System.Runtime.Serialization.EnumMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACType(global::Motorola.CommonCPS.Server.CommonDBConstants.PACType.ASTRO)]
		AMP = 4096,
		// Token: 0x040003B6 RID: 950
		[global::System.Runtime.Serialization.EnumMember]
		Any = 2147483647
	}
}
