using System;
using System.IO;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000012 RID: 18
	internal interface a
	{
		// Token: 0x06000041 RID: 65
		void SetStream(global::System.IO.Stream inStream);

		// Token: 0x06000042 RID: 66
		void Init();

		// Token: 0x06000043 RID: 67
		void ReleaseStream();

		// Token: 0x06000044 RID: 68
		byte GetIndexByte(int index);

		// Token: 0x06000045 RID: 69
		uint GetMatchLen(int index, uint distance, uint limit);

		// Token: 0x06000046 RID: 70
		uint GetNumAvailableBytes();
	}
}
