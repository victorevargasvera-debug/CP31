using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200013E RID: 318
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationPBBWiFi
	{
		// Token: 0x0400087E RID: 2174
		[global::System.Runtime.Serialization.DataMember]
		public string Ssid;

		// Token: 0x0400087F RID: 2175
		[global::System.Runtime.Serialization.DataMember]
		public string SecMode;

		// Token: 0x04000880 RID: 2176
		[global::System.Runtime.Serialization.DataMember]
		public string PSK;

		// Token: 0x04000881 RID: 2177
		[global::System.Runtime.Serialization.DataMember]
		public string WepKey;

		// Token: 0x04000882 RID: 2178
		[global::System.Runtime.Serialization.DataMember]
		public string Alias;

		// Token: 0x04000883 RID: 2179
		[global::System.Runtime.Serialization.DataMember]
		public string Comment;
	}
}
