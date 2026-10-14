using System;

namespace Gibraltar.Serialization
{
	// Token: 0x020000FC RID: 252
	internal interface IDynamicPacket : global::Gibraltar.Serialization.IPacket
	{
		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06000A70 RID: 2672
		// (set) Token: 0x06000A71 RID: 2673
		string DynamicTypeName { get; set; }
	}
}
