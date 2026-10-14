using System;
using System.ServiceModel;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000FE RID: 254
	[global::System.ServiceModel.ServiceContract]
	public interface IRecordSummary
	{
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06000F68 RID: 3944
		// (set) Token: 0x06000F69 RID: 3945
		string SetName { get; set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06000F6A RID: 3946
		// (set) Token: 0x06000F6B RID: 3947
		string UUID { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x06000F6C RID: 3948
		// (set) Token: 0x06000F6D RID: 3949
		string Comments { get; set; }

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x06000F6E RID: 3950
		// (set) Token: 0x06000F6F RID: 3951
		global::System.DateTime LastModifiedDate { get; set; }

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x06000F70 RID: 3952
		// (set) Token: 0x06000F71 RID: 3953
		byte[] Timestamp { get; set; }

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x06000F72 RID: 3954
		// (set) Token: 0x06000F73 RID: 3955
		global::Motorola.CommonCPS.Server.EntityModel.RSExtentions Extention { get; set; }
	}
}
