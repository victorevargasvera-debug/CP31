using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200011C RID: 284
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class InternalUpgradeData
	{
		// Token: 0x040007BB RID: 1979
		[global::System.Runtime.Serialization.DataMember]
		public string ToCodeplugVersion;

		// Token: 0x040007BC RID: 1980
		[global::System.Runtime.Serialization.DataMember]
		public string ToFwVersion;
	}
}
