using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A5 RID: 677
	public class BlockAllocationTableReader
	{
		// Token: 0x060012AB RID: 4779 RVA: 0x0003801C File Offset: 0x0003621C
		public BlockAllocationTableReader(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSizse, int block_count, int[] block_array, int xbat_count, int xbat_index, global::NPOI.POIFS.Storage.BlockList raw_block_list) : this(bigBlockSizse)
		{
			global::NPOI.POIFS.Storage.BlockAllocationTableReader.SanityCheckBlockCount(block_count);
			global::NPOI.POIFS.Storage.RawDataBlock[] array = new global::NPOI.POIFS.Storage.RawDataBlock[block_count];
			int num = global::System.Math.Min(block_count, block_array.Length);
			int i;
			for (i = 0; i < num; i++)
			{
				int num2 = block_array[i];
				if (num2 > raw_block_list.BlockCount())
				{
					throw new global::System.IO.IOException(string.Concat(new string[]
					{
						"Your file contains ",
						raw_block_list.BlockCount().ToString(),
						" sectors, but the initial DIFAT array at index ",
						i.ToString(),
						" referenced block # ",
						num2.ToString(),
						". This isn't allowed and  your file is corrupt"
					}));
				}
				array[i] = (global::NPOI.POIFS.Storage.RawDataBlock)raw_block_list.Remove(num2);
			}
			if (i < block_count)
			{
				if (xbat_index < 0)
				{
					throw new global::System.IO.IOException("BAT count exceeds limit, yet XBAT index indicates no valid entries");
				}
				int num3 = xbat_index;
				int entriesPerXBATBlock = global::NPOI.POIFS.Storage.BATBlock.EntriesPerXBATBlock;
				int xbatchainOffset = global::NPOI.POIFS.Storage.BATBlock.XBATChainOffset;
				for (int j = 0; j < xbat_count; j++)
				{
					num = global::System.Math.Min(block_count - i, entriesPerXBATBlock);
					byte[] data = raw_block_list.Remove(num3).Data;
					int num4 = 0;
					for (int k = 0; k < num; k++)
					{
						array[i++] = (global::NPOI.POIFS.Storage.RawDataBlock)raw_block_list.Remove(global::NPOI.Util.LittleEndian.GetInt(data, num4));
						num4 += 4;
					}
					num3 = global::NPOI.Util.LittleEndian.GetInt(data, xbatchainOffset);
					if (num3 == -2)
					{
						break;
					}
				}
			}
			if (i != block_count)
			{
				throw new global::System.IO.IOException("Could not find all blocks");
			}
			global::NPOI.POIFS.Storage.ListManagedBlock[] blocks = array;
			this.SetEntries(blocks, raw_block_list);
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x00038180 File Offset: 0x00036380
		public BlockAllocationTableReader(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.ListManagedBlock[] blocks, global::NPOI.POIFS.Storage.BlockList raw_block_list) : this(bigBlockSize)
		{
			this.SetEntries(blocks, raw_block_list);
		}

		// Token: 0x060012AD RID: 4781 RVA: 0x00038191 File Offset: 0x00036391
		public BlockAllocationTableReader(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this.bigBlockSize = bigBlockSize;
			this._entries = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000381AC File Offset: 0x000363AC
		public global::NPOI.POIFS.Storage.ListManagedBlock[] FetchBlocks(int startBlock, int headerPropertiesStartBlock, global::NPOI.POIFS.Storage.BlockList blockList)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.ListManagedBlock> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.ListManagedBlock>();
			int num = startBlock;
			bool flag = true;
			while (num != -2)
			{
				try
				{
					global::NPOI.POIFS.Storage.ListManagedBlock item = blockList.Remove(num);
					list.Add(item);
					num = this._entries[num];
					flag = false;
				}
				catch (global::System.Exception)
				{
					if (num == headerPropertiesStartBlock)
					{
						global::NPOI.POIFS.Storage.BlockAllocationTableReader._logger.Log(5, "Warning, header block comes after data blocks in POIFS block listing");
						num = -2;
					}
					else
					{
						if (num != 0 || !flag)
						{
							throw;
						}
						global::NPOI.POIFS.Storage.BlockAllocationTableReader._logger.Log(5, "Warning, incorrectly terminated empty data blocks in POIFS block listing (should end at -2, ended at 0)");
						num = -2;
					}
				}
			}
			return list.ToArray();
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x00038240 File Offset: 0x00036440
		public bool IsUsed(int index)
		{
			bool result = false;
			try
			{
				result = (this._entries[index] != -1);
			}
			catch (global::System.IndexOutOfRangeException)
			{
			}
			return result;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x00038278 File Offset: 0x00036478
		public int GetNextBlockIndex(int index)
		{
			if (this.IsUsed(index))
			{
				return this._entries[index];
			}
			throw new global::System.IO.IOException("index " + index.ToString() + " is unused");
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000382AC File Offset: 0x000364AC
		private void SetEntries(global::NPOI.POIFS.Storage.ListManagedBlock[] blocks, global::NPOI.POIFS.Storage.BlockList raw_blocks)
		{
			int batentriesPerBlock = this.bigBlockSize.GetBATEntriesPerBlock();
			for (int i = 0; i < blocks.Length; i++)
			{
				byte[] data = blocks[i].Data;
				int num = 0;
				for (int j = 0; j < batentriesPerBlock; j++)
				{
					int @int = global::NPOI.Util.LittleEndian.GetInt(data, num);
					if (@int == -1)
					{
						raw_blocks.Zap(this._entries.Count);
					}
					this._entries.Add(@int);
					num += 4;
				}
				blocks[i] = null;
			}
			raw_blocks.BAT = this;
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x0003832C File Offset: 0x0003652C
		public static void SanityCheckBlockCount(int block_count)
		{
			if (block_count <= 0)
			{
				throw new global::System.IO.IOException("Illegal block count; minimum count is 1, got " + block_count.ToString() + " instead");
			}
			if (block_count > 65535)
			{
				throw new global::System.IO.IOException(string.Concat(new string[]
				{
					"Block count ",
					block_count.ToString(),
					" is too high. POI maximum is ",
					65535.ToString(),
					"."
				}));
			}
		}

		// Token: 0x040007BB RID: 1979
		private static global::NPOI.Util.POILogger _logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIFS.Storage.BlockAllocationTableReader));

		// Token: 0x040007BC RID: 1980
		private const int MAX_BLOCK_COUNT = 65535;

		// Token: 0x040007BD RID: 1981
		private global::System.Collections.Generic.List<int> _entries;

		// Token: 0x040007BE RID: 1982
		private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;
	}
}
