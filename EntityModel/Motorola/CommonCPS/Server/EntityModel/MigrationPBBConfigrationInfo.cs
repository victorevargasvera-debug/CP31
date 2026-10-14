using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200013C RID: 316
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationPBBConfigrationInfo
	{
		// Token: 0x06001211 RID: 4625 RVA: 0x000C0F9C File Offset: 0x000BF19C
		public MigrationPBBConfigrationInfo()
		{
			this.Radios = new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x04000874 RID: 2164
		[global::System.Runtime.Serialization.DataMember]
		public string Uuid;

		// Token: 0x04000875 RID: 2165
		[global::System.Runtime.Serialization.DataMember]
		public string Name;

		// Token: 0x04000876 RID: 2166
		[global::System.Runtime.Serialization.DataMember]
		public string Comments;

		// Token: 0x04000877 RID: 2167
		[global::System.Runtime.Serialization.DataMember]
		public byte[] FileContent;

		// Token: 0x04000878 RID: 2168
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> Radios;
	}
}
