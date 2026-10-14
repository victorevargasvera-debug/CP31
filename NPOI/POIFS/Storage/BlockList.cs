using System;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A7 RID: 679
	public interface BlockList
	{
		// Token: 0x060012BE RID: 4798
		void Zap(int index);

		// Token: 0x060012BF RID: 4799
		global::NPOI.POIFS.Storage.ListManagedBlock Remove(int index);

		// Token: 0x060012C0 RID: 4800
		global::NPOI.POIFS.Storage.ListManagedBlock[] FetchBlocks(int startBlock, int headerPropertiesStartBlock);

		// Token: 0x17000375 RID: 885
		// (set) Token: 0x060012C1 RID: 4801
		global::NPOI.POIFS.Storage.BlockAllocationTableReader BAT { set; }

		// Token: 0x060012C2 RID: 4802
		int BlockCount();
	}
}
