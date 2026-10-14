using System;

namespace Gibraltar.Serialization
{
	// Token: 0x02000103 RID: 259
	internal interface IPacketWriter
	{
		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06000AC0 RID: 2752
		long Position { get; }

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06000AC1 RID: 2753
		long Length { get; }

		// Token: 0x06000AC2 RID: 2754
		void Write(global::Gibraltar.Serialization.IPacket packet);
	}
}
