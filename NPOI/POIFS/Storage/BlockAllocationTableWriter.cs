using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A6 RID: 678
	public class BlockAllocationTableWriter : global::NPOI.POIFS.Storage.BlockWritable, global::NPOI.POIFS.FileSystem.BATManaged
	{
		// Token: 0x060012B4 RID: 4788 RVA: 0x000383BA File Offset: 0x000365BA
		public BlockAllocationTableWriter(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize)
		{
			this._start_block = -2;
			this._entries = new global::System.Collections.Generic.List<int>(global::NPOI.POIFS.Storage.BlockAllocationTableWriter._default_size);
			this._blocks = new global::NPOI.POIFS.Storage.BATBlock[0];
			this._bigBlockSize = bigBlockSize;
		}

		// Token: 0x060012B5 RID: 4789 RVA: 0x000383F0 File Offset: 0x000365F0
		public int CreateBlocks()
		{
			int num = 0;
			int num2 = 0;
			for (;;)
			{
				int num3 = global::NPOI.POIFS.Storage.BATBlock.CalculateStorageRequirements(this._bigBlockSize, num2 + num + this._entries.Count);
				int num4 = global::NPOI.POIFS.Storage.HeaderBlockWriter.CalculateXBATStorageRequirements(this._bigBlockSize, num3);
				if (num2 == num3 && num == num4)
				{
					break;
				}
				num2 = num3;
				num = num4;
			}
			int result = this.AllocateSpace(num2);
			this.AllocateSpace(num);
			this.SimpleCreateBlocks();
			return result;
		}

		// Token: 0x060012B6 RID: 4790 RVA: 0x0003844C File Offset: 0x0003664C
		public int AllocateSpace(int blockCount)
		{
			int count = this._entries.Count;
			if (blockCount > 0)
			{
				int num = blockCount - 1;
				int num2 = count + 1;
				for (int i = 0; i < num; i++)
				{
					this._entries.Add(num2++);
				}
				this._entries.Add(-2);
			}
			return count;
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x0003849B File Offset: 0x0003669B
		// (set) Token: 0x060012B8 RID: 4792 RVA: 0x000384A3 File Offset: 0x000366A3
		public int StartBlock
		{
			get
			{
				return this._start_block;
			}
			set
			{
				this._start_block = value;
			}
		}

		// Token: 0x060012B9 RID: 4793 RVA: 0x000384AC File Offset: 0x000366AC
		internal void SimpleCreateBlocks()
		{
			this._blocks = global::NPOI.POIFS.Storage.BATBlock.CreateBATBlocks(this._bigBlockSize, this._entries.ToArray());
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000384CC File Offset: 0x000366CC
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			for (int i = 0; i < this._blocks.Length; i++)
			{
				this._blocks[i].WriteBlocks(stream);
			}
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000384FA File Offset: 0x000366FA
		public static void WriteBlock(global::NPOI.POIFS.Storage.BATBlock bat, global::NPOI.Util.ByteBuffer block)
		{
			bat.WriteData(block);
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x00038503 File Offset: 0x00036703
		public int CountBlocks
		{
			get
			{
				return this._blocks.Length;
			}
		}

		// Token: 0x040007BF RID: 1983
		private global::System.Collections.Generic.List<int> _entries;

		// Token: 0x040007C0 RID: 1984
		private global::NPOI.POIFS.Storage.BATBlock[] _blocks;

		// Token: 0x040007C1 RID: 1985
		private int _start_block;

		// Token: 0x040007C2 RID: 1986
		private global::NPOI.POIFS.Common.POIFSBigBlockSize _bigBlockSize;

		// Token: 0x040007C3 RID: 1987
		private static int _default_size = 128;
	}
}
