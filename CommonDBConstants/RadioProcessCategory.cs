using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public enum RadioProcessCategory
	{
		// Token: 0x040003D2 RID: 978
		OnlyRadio,
		// Token: 0x040003D3 RID: 979
		OnlyArchive,
		// Token: 0x040003D4 RID: 980
		PbaAndArchive
	}
}
