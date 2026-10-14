using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000074 RID: 116
	public interface IPBBRadio
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060008E1 RID: 2273
		// (set) Token: 0x060008E2 RID: 2274
		[global::System.Runtime.Serialization.DataMember]
		string IMEI { get; set; }

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060008E3 RID: 2275
		// (set) Token: 0x060008E4 RID: 2276
		[global::System.Runtime.Serialization.DataMember]
		string ProductIdentifier { get; set; }

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x060008E5 RID: 2277
		// (set) Token: 0x060008E6 RID: 2278
		[global::System.Runtime.Serialization.DataMember]
		string ManufacturerName { get; set; }
	}
}
