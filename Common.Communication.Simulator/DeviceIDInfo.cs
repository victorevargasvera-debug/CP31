using System;
using Motorola.Common.Communication.CommonUtil;

namespace Common.Communication.Simulator
{
	// Token: 0x02000007 RID: 7
	[global::System.Serializable]
	public class DeviceIDInfo
	{
		// Token: 0x0600006A RID: 106 RVA: 0x00007E5C File Offset: 0x0000605C
		public DeviceIDInfo(global::Motorola.Common.Communication.CommonUtil.ConnectionType connType, string radioId)
		{
			this.ConnType = connType;
			this.RadioID = radioId;
		}

		// Token: 0x04000013 RID: 19
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnType;

		// Token: 0x04000014 RID: 20
		public string RadioID;
	}
}
