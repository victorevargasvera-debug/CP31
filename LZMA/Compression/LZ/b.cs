using System;

namespace SevenZip.Compression.LZ
{
	// Token: 0x02000013 RID: 19
	internal interface b : global::SevenZip.Compression.LZ.a
	{
		// Token: 0x06000047 RID: 71
		void Create(uint historySize, uint keepAddBufferBefore, uint matchMaxLen, uint keepAddBufferAfter);

		// Token: 0x06000048 RID: 72
		uint GetMatches(uint[] distances);

		// Token: 0x06000049 RID: 73
		void Skip(uint num);
	}
}
