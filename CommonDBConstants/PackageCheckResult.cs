using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200004D RID: 77
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum PackageCheckResult
	{
		// Token: 0x040002A1 RID: 673
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x040002A2 RID: 674
		[global::System.Runtime.Serialization.EnumMember]
		VAPackageMatched = 1,
		// Token: 0x040002A3 RID: 675
		[global::System.Runtime.Serialization.EnumMember]
		LPPackageMatched = 2,
		// Token: 0x040002A4 RID: 676
		[global::System.Runtime.Serialization.EnumMember]
		TTSPackageMatched = 4
	}
}
