using System;
using System.Collections.Generic;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B6 RID: 694
	public class SmallDocumentBlockList : global::NPOI.POIFS.Storage.BlockListImpl
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x000399B8 File Offset: 0x00037BB8
		public SmallDocumentBlockList(global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.SmallDocumentBlock> blocks)
		{
			global::NPOI.POIFS.Storage.ListManagedBlock[] blocks2 = blocks.ToArray();
			this.SetBlocks(blocks2);
		}
	}
}
