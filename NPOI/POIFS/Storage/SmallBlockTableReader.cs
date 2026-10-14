using System;
using NPOI.POIFS.Common;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B3 RID: 691
	public class SmallBlockTableReader
	{
		// Token: 0x0600130B RID: 4875 RVA: 0x00039458 File Offset: 0x00037658
		private static global::NPOI.POIFS.Storage.BlockList prepareSmallDocumentBlocks(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.RawDataBlockList blockList, global::NPOI.POIFS.Properties.RootProperty root, int sbatStart)
		{
			global::NPOI.POIFS.Storage.ListManagedBlock[] blocks = blockList.FetchBlocks(root.StartBlock, -1);
			return new global::NPOI.POIFS.Storage.SmallDocumentBlockList(global::NPOI.POIFS.Storage.SmallDocumentBlock.Extract(bigBlockSize, blocks));
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x0003947F File Offset: 0x0003767F
		private static global::NPOI.POIFS.Storage.BlockAllocationTableReader prepareReader(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.RawDataBlockList blockList, global::NPOI.POIFS.Storage.BlockList list, global::NPOI.POIFS.Properties.RootProperty root, int sbatStart)
		{
			return new global::NPOI.POIFS.Storage.BlockAllocationTableReader(bigBlockSize, blockList.FetchBlocks(sbatStart, -1), list);
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00039494 File Offset: 0x00037694
		public static global::NPOI.POIFS.Storage.BlockAllocationTableReader _getSmallDocumentBlockReader(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.RawDataBlockList blockList, global::NPOI.POIFS.Properties.RootProperty root, int sbatStart)
		{
			global::NPOI.POIFS.Storage.BlockList list = global::NPOI.POIFS.Storage.SmallBlockTableReader.prepareSmallDocumentBlocks(bigBlockSize, blockList, root, sbatStart);
			return global::NPOI.POIFS.Storage.SmallBlockTableReader.prepareReader(bigBlockSize, blockList, list, root, sbatStart);
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x000394B8 File Offset: 0x000376B8
		public static global::NPOI.POIFS.Storage.BlockList GetSmallDocumentBlocks(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.RawDataBlockList blockList, global::NPOI.POIFS.Properties.RootProperty root, int sbatStart)
		{
			global::NPOI.POIFS.Storage.BlockList blockList2 = new global::NPOI.POIFS.Storage.SmallDocumentBlockList(global::NPOI.POIFS.Storage.SmallDocumentBlock.Extract(bigBlockSize, blockList.FetchBlocks(root.StartBlock, -1)));
			new global::NPOI.POIFS.Storage.BlockAllocationTableReader(bigBlockSize, blockList.FetchBlocks(sbatStart, -1), blockList2);
			return blockList2;
		}
	}
}
