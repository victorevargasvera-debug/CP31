using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B2 RID: 690
	public class RawDataBlockList : global::NPOI.POIFS.Storage.BlockListImpl
	{
		// Token: 0x0600130A RID: 4874 RVA: 0x0003940C File Offset: 0x0003760C
		public RawDataBlockList(global::System.IO.Stream stream, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.RawDataBlock> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.RawDataBlock>();
			global::NPOI.POIFS.Storage.RawDataBlock rawDataBlock;
			do
			{
				rawDataBlock = new global::NPOI.POIFS.Storage.RawDataBlock(stream, bigBlockSize.GetBigBlockSize());
				if (rawDataBlock.HasData)
				{
					list.Add(rawDataBlock);
				}
			}
			while (!rawDataBlock.EOF);
			global::NPOI.POIFS.Storage.ListManagedBlock[] blocks = list.ToArray();
			this.SetBlocks(blocks);
		}
	}
}
