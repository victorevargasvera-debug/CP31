using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A2 RID: 674
	public class BATBlock : global::NPOI.POIFS.Storage.BigBlock
	{
		// Token: 0x06001281 RID: 4737 RVA: 0x00037998 File Offset: 0x00035B98
		protected BATBlock()
		{
			this._data = new byte[512];
			for (int i = 0; i < this._data.Length; i++)
			{
				this._data[i] = global::NPOI.POIFS.Storage.BATBlock._default_value;
			}
			this._fields = new global::NPOI.Util.IntegerField[global::NPOI.POIFS.Storage.BATBlock._entries_per_block];
			int num = 0;
			for (int j = 0; j < global::NPOI.POIFS.Storage.BATBlock._entries_per_block; j++)
			{
				this._fields[j] = new global::NPOI.Util.IntegerField(num);
				num += 4;
			}
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x00037A10 File Offset: 0x00035C10
		protected BATBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize) : base(bigBlockSize)
		{
			int batentriesPerBlock = bigBlockSize.GetBATEntriesPerBlock();
			this._values = new int[batentriesPerBlock];
			this._has_free_sectors = true;
			for (int i = 0; i < this._values.Length; i++)
			{
				this._values[i] = -1;
			}
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00037A5C File Offset: 0x00035C5C
		protected BATBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int[] entries, int start_index, int end_index) : this(bigBlockSize)
		{
			for (int i = start_index; i < end_index; i++)
			{
				this._values[i - start_index] = entries[i];
			}
			if (end_index - start_index == this._values.Length)
			{
				this.RecomputeFree();
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00037AA0 File Offset: 0x00035CA0
		private void RecomputeFree()
		{
			bool has_free_sectors = false;
			for (int i = 0; i < this._values.Length; i++)
			{
				if (this._values[i] == -1)
				{
					has_free_sectors = true;
					break;
				}
			}
			this._has_free_sectors = has_free_sectors;
		}

		// Token: 0x06001285 RID: 4741 RVA: 0x00037AD8 File Offset: 0x00035CD8
		public static global::NPOI.POIFS.Storage.BATBlock CreateBATBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::System.IO.BinaryReader data)
		{
			global::NPOI.POIFS.Storage.BATBlock batblock = new global::NPOI.POIFS.Storage.BATBlock(bigBlockSize);
			byte[] array = new byte[4];
			for (int i = 0; i < batblock._values.Length; i++)
			{
				data.Read(array, 0, array.Length);
				batblock._values[i] = global::NPOI.Util.LittleEndian.GetInt(array);
			}
			batblock.RecomputeFree();
			return batblock;
		}

		// Token: 0x06001286 RID: 4742 RVA: 0x00037B28 File Offset: 0x00035D28
		public static global::NPOI.POIFS.Storage.BATBlock CreateBATBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.Util.ByteBuffer data)
		{
			global::NPOI.POIFS.Storage.BATBlock batblock = new global::NPOI.POIFS.Storage.BATBlock(bigBlockSize);
			byte[] array = new byte[4];
			for (int i = 0; i < batblock._values.Length; i++)
			{
				data.Read(array);
				batblock._values[i] = global::NPOI.Util.LittleEndian.GetInt(array);
			}
			batblock.RecomputeFree();
			return batblock;
		}

		// Token: 0x06001287 RID: 4743 RVA: 0x00037B74 File Offset: 0x00035D74
		public static global::NPOI.POIFS.Storage.BATBlock CreateEmptyBATBlock(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, bool isXBAT)
		{
			global::NPOI.POIFS.Storage.BATBlock batblock = new global::NPOI.POIFS.Storage.BATBlock(bigBlockSize);
			if (isXBAT)
			{
				batblock.SetXBATChain(bigBlockSize, -2);
			}
			return batblock;
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x00037B98 File Offset: 0x00035D98
		public static global::NPOI.POIFS.Storage.BATBlock[] CreateBATBlocks(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int[] entries)
		{
			global::NPOI.POIFS.Storage.BATBlock[] array = new global::NPOI.POIFS.Storage.BATBlock[global::NPOI.POIFS.Storage.BATBlock.CalculateStorageRequirements(entries.Length)];
			int num = 0;
			int num2 = entries.Length;
			for (int i = 0; i < entries.Length; i += global::NPOI.POIFS.Storage.BATBlock._entries_per_block)
			{
				array[num++] = new global::NPOI.POIFS.Storage.BATBlock(bigBlockSize, entries, i, (num2 > global::NPOI.POIFS.Storage.BATBlock._entries_per_block) ? (i + global::NPOI.POIFS.Storage.BATBlock._entries_per_block) : entries.Length);
				num2 -= global::NPOI.POIFS.Storage.BATBlock._entries_per_block;
			}
			return array;
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00037BF8 File Offset: 0x00035DF8
		public static global::NPOI.POIFS.Storage.BATBlock[] CreateXBATBlocks(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int[] entries, int startBlock)
		{
			int num = global::NPOI.POIFS.Storage.BATBlock.CalculateXBATStorageRequirements(entries.Length);
			global::NPOI.POIFS.Storage.BATBlock[] array = new global::NPOI.POIFS.Storage.BATBlock[num];
			int i = 0;
			int num2 = entries.Length;
			if (num != 0)
			{
				for (int j = 0; j < entries.Length; j += global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block)
				{
					array[i++] = new global::NPOI.POIFS.Storage.BATBlock(bigBlockSize, entries, j, (num2 > global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block) ? (j + global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block) : entries.Length);
					num2 -= global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block;
				}
				for (i = 0; i < array.Length - 1; i++)
				{
					array[i].SetXBATChain(bigBlockSize, startBlock + i + 1);
				}
				array[i].SetXBATChain(bigBlockSize, -2);
			}
			return array;
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00037C83 File Offset: 0x00035E83
		public static int CalculateStorageRequirements(int entryCount)
		{
			return (entryCount + global::NPOI.POIFS.Storage.BATBlock._entries_per_block - 1) / global::NPOI.POIFS.Storage.BATBlock._entries_per_block;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00037C94 File Offset: 0x00035E94
		public static int CalculateStorageRequirements(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int entryCount)
		{
			int batentriesPerBlock = bigBlockSize.GetBATEntriesPerBlock();
			return (entryCount + batentriesPerBlock - 1) / batentriesPerBlock;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00037CAF File Offset: 0x00035EAF
		public static int CalculateXBATStorageRequirements(int entryCount)
		{
			return (entryCount + global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block - 1) / global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00037CC0 File Offset: 0x00035EC0
		public static int CalculateXBATStorageRequirements(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int entryCount)
		{
			int xbatentriesPerBlock = bigBlockSize.GetXBATEntriesPerBlock();
			return (entryCount + xbatentriesPerBlock - 1) / xbatentriesPerBlock;
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00037CDB File Offset: 0x00035EDB
		public static long CalculateMaximumSize(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int numBATs)
		{
			return (1L + (long)numBATs * (long)bigBlockSize.GetBATEntriesPerBlock()) * (long)bigBlockSize.GetBigBlockSize();
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00037CF2 File Offset: 0x00035EF2
		public static long CalculateMaximumSize(global::NPOI.POIFS.Storage.HeaderBlock header)
		{
			return global::NPOI.POIFS.Storage.BATBlock.CalculateMaximumSize(header.BigBlockSize, header.BATCount);
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00037D08 File Offset: 0x00035F08
		public static global::NPOI.POIFS.Storage.BATBlockAndIndex GetBATBlockAndIndex(int offset, global::NPOI.POIFS.Storage.HeaderBlock header, global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> bats)
		{
			int batentriesPerBlock = header.BigBlockSize.GetBATEntriesPerBlock();
			int index = (int)global::System.Math.Floor(1.0 * (double)offset / (double)batentriesPerBlock);
			return new global::NPOI.POIFS.Storage.BATBlockAndIndex(offset % batentriesPerBlock, bats[index]);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00037D48 File Offset: 0x00035F48
		public static global::NPOI.POIFS.Storage.BATBlockAndIndex GetSBATBlockAndIndex(int offset, global::NPOI.POIFS.Storage.HeaderBlock header, global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> sbats)
		{
			int batentriesPerBlock = header.BigBlockSize.GetBATEntriesPerBlock();
			int index = (int)global::System.Math.Floor(1.0 * (double)offset / (double)batentriesPerBlock);
			return new global::NPOI.POIFS.Storage.BATBlockAndIndex(offset % batentriesPerBlock, sbats[index]);
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001292 RID: 4754 RVA: 0x00037D86 File Offset: 0x00035F86
		public static int EntriesPerBlock
		{
			get
			{
				return global::NPOI.POIFS.Storage.BATBlock._entries_per_block;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001293 RID: 4755 RVA: 0x00037D8D File Offset: 0x00035F8D
		public static int EntriesPerXBATBlock
		{
			get
			{
				return global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001294 RID: 4756 RVA: 0x00037D94 File Offset: 0x00035F94
		public static int XBATChainOffset
		{
			get
			{
				return global::NPOI.POIFS.Storage.BATBlock._xbat_chain_offset;
			}
		}

		// Token: 0x06001295 RID: 4757 RVA: 0x00037D9B File Offset: 0x00035F9B
		private void SetXBATChain(int chainIndex)
		{
			this._fields[global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block].Set(chainIndex, this._data);
		}

		// Token: 0x06001296 RID: 4758 RVA: 0x00037DB8 File Offset: 0x00035FB8
		private void SetXBATChain(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, int chainIndex)
		{
			int xbatentriesPerBlock = bigBlockSize.GetXBATEntriesPerBlock();
			this._values[xbatentriesPerBlock] = chainIndex;
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001297 RID: 4759 RVA: 0x00037DD5 File Offset: 0x00035FD5
		public bool HasFreeSectors
		{
			get
			{
				return this._has_free_sectors;
			}
		}

		// Token: 0x06001298 RID: 4760 RVA: 0x00037DE0 File Offset: 0x00035FE0
		public int GetUsedSectors(bool isAnXBAT)
		{
			int num = 0;
			int num2 = this._values.Length;
			if (isAnXBAT)
			{
				num2--;
			}
			for (int i = 0; i < num2; i++)
			{
				if (this._values[i] != -1)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x00037E1C File Offset: 0x0003601C
		public int GetValueAt(int relativeOffset)
		{
			if (relativeOffset >= this._values.Length)
			{
				throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
				{
					"Unable to fetch offset ",
					relativeOffset.ToString(),
					" as the BAT only contains ",
					this._values.Length.ToString(),
					" entries"
				}));
			}
			return this._values[relativeOffset];
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x00037E84 File Offset: 0x00036084
		public void SetValueAt(int relativeOffset, int value)
		{
			int num = this._values[relativeOffset];
			this._values[relativeOffset] = value;
			if (value == -1)
			{
				this._has_free_sectors = true;
				return;
			}
			if (num == -1)
			{
				this.RecomputeFree();
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x0600129B RID: 4763 RVA: 0x00037EB9 File Offset: 0x000360B9
		// (set) Token: 0x0600129C RID: 4764 RVA: 0x00037EC1 File Offset: 0x000360C1
		public int OurBlockIndex
		{
			get
			{
				return this.ourBlockIndex;
			}
			set
			{
				this.ourBlockIndex = value;
			}
		}

		// Token: 0x0600129D RID: 4765 RVA: 0x00037ECC File Offset: 0x000360CC
		private BATBlock(int[] entries, int start_index, int end_index) : this()
		{
			for (int i = start_index; i < end_index; i++)
			{
				this._fields[i - start_index].Set(entries[i], this._data);
			}
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x00037F03 File Offset: 0x00036103
		public void WriteData(global::NPOI.Util.ByteBuffer block)
		{
			block.Write(this.Serialize());
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x00037F14 File Offset: 0x00036114
		public override void WriteData(global::System.IO.Stream stream)
		{
			byte[] array = this.Serialize();
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x060012A0 RID: 4768 RVA: 0x00037F34 File Offset: 0x00036134
		public void WriteData(byte[] block)
		{
			byte[] array = this.Serialize();
			for (int i = 0; i < array.Length; i++)
			{
				block[i] = array[i];
			}
		}

		// Token: 0x060012A1 RID: 4769 RVA: 0x00037F5C File Offset: 0x0003615C
		private byte[] Serialize()
		{
			byte[] array = new byte[this.bigBlockSize.GetBigBlockSize()];
			int num = 0;
			for (int i = 0; i < this._values.Length; i++)
			{
				global::NPOI.Util.LittleEndian.PutInt(array, num, this._values[i]);
				num += 4;
			}
			return array;
		}

		// Token: 0x040007AF RID: 1967
		private static int _entries_per_block = 128;

		// Token: 0x040007B0 RID: 1968
		private static int _entries_per_xbat_block = global::NPOI.POIFS.Storage.BATBlock._entries_per_block - 1;

		// Token: 0x040007B1 RID: 1969
		private static int _xbat_chain_offset = global::NPOI.POIFS.Storage.BATBlock._entries_per_xbat_block * 4;

		// Token: 0x040007B2 RID: 1970
		private static byte _default_value = byte.MaxValue;

		// Token: 0x040007B3 RID: 1971
		private global::NPOI.Util.IntegerField[] _fields;

		// Token: 0x040007B4 RID: 1972
		private byte[] _data;

		// Token: 0x040007B5 RID: 1973
		private int[] _values;

		// Token: 0x040007B6 RID: 1974
		private bool _has_free_sectors;

		// Token: 0x040007B7 RID: 1975
		private int ourBlockIndex;
	}
}
