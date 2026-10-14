using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200013B RID: 315
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrationPBBConfigurationAndWiFi
	{
		// Token: 0x06001210 RID: 4624 RVA: 0x000C0F70 File Offset: 0x000BF170
		public MigrationPBBConfigurationAndWiFi()
		{
			this.Configurations = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigrationInfo>();
			this.WiFiLists = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBWiFiListInfo>();
		}

		// Token: 0x04000872 RID: 2162
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBConfigrationInfo> Configurations;

		// Token: 0x04000873 RID: 2163
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MigrationPBBWiFiListInfo> WiFiLists;
	}
}
