using System;
using System.Runtime.Serialization;

namespace System.Data.Entity.Spatial
{
	// Token: 0x02000094 RID: 148
	[global::System.Runtime.Serialization.DataContract]
	public sealed class DbGeometryWellKnownValue
	{
		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000560 RID: 1376 RVA: 0x00011570 File Offset: 0x0000F770
		// (set) Token: 0x06000561 RID: 1377 RVA: 0x00011578 File Offset: 0x0000F778
		[global::System.Runtime.Serialization.DataMember(Order = 1, IsRequired = false, EmitDefaultValue = false)]
		public int CoordinateSystemId { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00011581 File Offset: 0x0000F781
		// (set) Token: 0x06000563 RID: 1379 RVA: 0x00011589 File Offset: 0x0000F789
		[global::System.Runtime.Serialization.DataMember(Order = 2, IsRequired = false, EmitDefaultValue = false)]
		public string WellKnownText { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000564 RID: 1380 RVA: 0x00011592 File Offset: 0x0000F792
		// (set) Token: 0x06000565 RID: 1381 RVA: 0x0001159A File Offset: 0x0000F79A
		[global::System.Runtime.Serialization.DataMember(Order = 3, IsRequired = false, EmitDefaultValue = false)]
		public byte[] WellKnownBinary { get; set; }
	}
}
