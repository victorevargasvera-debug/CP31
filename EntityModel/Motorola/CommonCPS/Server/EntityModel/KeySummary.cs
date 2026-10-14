using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200005B RID: 91
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class KeySummary
	{
		// Token: 0x04000378 RID: 888
		[global::System.Runtime.Serialization.DataMember]
		public int ID;

		// Token: 0x04000379 RID: 889
		[global::System.Runtime.Serialization.DataMember]
		public long? Value;

		// Token: 0x0400037A RID: 890
		[global::System.Runtime.Serialization.DataMember]
		public string Alias;

		// Token: 0x0400037B RID: 891
		[global::System.Runtime.Serialization.DataMember]
		public int ReferenceCount;
	}
}
