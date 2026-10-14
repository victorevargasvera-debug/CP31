using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000067 RID: 103
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Flags]
	public enum RelationShipType
	{
		// Token: 0x040003EE RID: 1006
		TopLevelSingleInstance = 0,
		// Token: 0x040003EF RID: 1007
		TopLevelMultipleInstance = 1,
		// Token: 0x040003F0 RID: 1008
		EmbeddedList = 2
	}
}
