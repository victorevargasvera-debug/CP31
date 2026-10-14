using System;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D8 RID: 728
	public class ChainLoopDetector
	{
		// Token: 0x06001423 RID: 5155 RVA: 0x0003CA0C File Offset: 0x0003AC0C
		public ChainLoopDetector(long rawSize, global::NPOI.POIFS.FileSystem.BlockStore blockStore)
		{
			this.blockStore = blockStore;
			int blockStoreBlockSize = blockStore.GetBlockStoreBlockSize();
			int num = (int)(rawSize / (long)blockStoreBlockSize);
			if (rawSize % (long)blockStoreBlockSize != 0L)
			{
				num++;
			}
			this.used_blocks = new bool[num];
		}

		// Token: 0x06001424 RID: 5156 RVA: 0x0003CA49 File Offset: 0x0003AC49
		public void Claim(int offset)
		{
			if (offset >= this.used_blocks.Length)
			{
				return;
			}
			if (this.used_blocks[offset])
			{
				throw new global::System.InvalidOperationException("Potential loop detected - Block " + offset.ToString() + " was already claimed but was just requested again");
			}
			this.used_blocks[offset] = true;
		}

		// Token: 0x0400085A RID: 2138
		private bool[] used_blocks;

		// Token: 0x0400085B RID: 2139
		private global::NPOI.POIFS.FileSystem.BlockStore blockStore;
	}
}
