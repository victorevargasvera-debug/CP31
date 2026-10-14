using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200013D RID: 317
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationPBBWiFiListInfo
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x000C0FBC File Offset: 0x000BF1BC
		public MigrationPBBWiFiListInfo()
		{
			this.Radios = new global::System.Collections.Generic.List<string>();
			this.WiFis = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBWiFi>();
		}

		// Token: 0x04000879 RID: 2169
		[global::System.Runtime.Serialization.DataMember]
		public string Uuid;

		// Token: 0x0400087A RID: 2170
		[global::System.Runtime.Serialization.DataMember]
		public string Name;

		// Token: 0x0400087B RID: 2171
		[global::System.Runtime.Serialization.DataMember]
		public string Comments;

		// Token: 0x0400087C RID: 2172
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> Radios;

		// Token: 0x0400087D RID: 2173
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBWiFi> WiFis;
	}
}
