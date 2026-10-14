using System;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D7 RID: 727
	public abstract class BlockStore
	{
		// Token: 0x06001419 RID: 5145
		public abstract int GetBlockStoreBlockSize();

		// Token: 0x0600141A RID: 5146
		public abstract global::NPOI.Util.ByteBuffer GetBlockAt(int offset);

		// Token: 0x0600141B RID: 5147
		public abstract bool TryGetBlockAt(int offset, out global::NPOI.Util.ByteBuffer byteBuffer);

		// Token: 0x0600141C RID: 5148
		public abstract global::NPOI.Util.ByteBuffer CreateBlockIfNeeded(int offset);

		// Token: 0x0600141D RID: 5149
		public abstract global::NPOI.POIFS.Storage.BATBlockAndIndex GetBATBlockAndIndex(int offset);

		// Token: 0x0600141E RID: 5150
		public abstract int GetNextBlock(int offset);

		// Token: 0x0600141F RID: 5151
		public abstract void SetNextBlock(int offset, int nextBlock);

		// Token: 0x06001420 RID: 5152
		public abstract int GetFreeBlock();

		// Token: 0x06001421 RID: 5153
		public abstract global::NPOI.POIFS.FileSystem.ChainLoopDetector GetChainLoopDetector();
	}
}
