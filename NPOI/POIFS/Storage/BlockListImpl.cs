using System;
using System.IO;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002A8 RID: 680
	public class BlockListImpl : global::NPOI.POIFS.Storage.BlockList
	{
		// Token: 0x060012C3 RID: 4803 RVA: 0x00038519 File Offset: 0x00036719
		public BlockListImpl()
		{
			this._blocks = new global::NPOI.POIFS.Storage.ListManagedBlock[0];
			this._bat = null;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00038534 File Offset: 0x00036734
		public virtual void SetBlocks(global::NPOI.POIFS.Storage.ListManagedBlock[] blocks)
		{
			this._blocks = (global::NPOI.POIFS.Storage.ListManagedBlock[])blocks.Clone();
		}

		// Token: 0x060012C5 RID: 4805 RVA: 0x00038547 File Offset: 0x00036747
		public virtual void Zap(int index)
		{
			if (index >= 0 && index < this._blocks.Length)
			{
				this._blocks[index] = null;
			}
		}

		// Token: 0x060012C6 RID: 4806 RVA: 0x00038561 File Offset: 0x00036761
		protected global::NPOI.POIFS.Storage.ListManagedBlock Get(int index)
		{
			return this._blocks[index];
		}

		// Token: 0x060012C7 RID: 4807 RVA: 0x0003856C File Offset: 0x0003676C
		public virtual global::NPOI.POIFS.Storage.ListManagedBlock Remove(int index)
		{
			global::NPOI.POIFS.Storage.ListManagedBlock listManagedBlock = null;
			try
			{
				listManagedBlock = this._blocks[index];
				if (listManagedBlock == null)
				{
					throw new global::System.IO.IOException("block[ " + index.ToString() + " ] already removed");
				}
				this._blocks[index] = null;
			}
			catch (global::System.IndexOutOfRangeException)
			{
				throw new global::System.IO.IOException(string.Concat(new string[]
				{
					"Cannot remove block[ ",
					index.ToString(),
					" ]; out of range[ 0 - ",
					(this._blocks.Length - 1).ToString(),
					" ]"
				}));
			}
			return listManagedBlock;
		}

		// Token: 0x060012C8 RID: 4808 RVA: 0x00038608 File Offset: 0x00036808
		public virtual global::NPOI.POIFS.Storage.ListManagedBlock[] FetchBlocks(int startBlock, int headerPropertiesStartBlock)
		{
			if (this._bat == null)
			{
				throw new global::System.IO.IOException("Improperly initialized list: no block allocation table provided");
			}
			return this._bat.FetchBlocks(startBlock, headerPropertiesStartBlock, this);
		}

		// Token: 0x17000376 RID: 886
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x0003862B File Offset: 0x0003682B
		public virtual global::NPOI.POIFS.Storage.BlockAllocationTableReader BAT
		{
			set
			{
				if (this._bat != null)
				{
					throw new global::System.IO.IOException("Attempt to replace existing BlockAllocationTable");
				}
				this._bat = value;
			}
		}

		// Token: 0x060012CA RID: 4810 RVA: 0x00038647 File Offset: 0x00036847
		public virtual int BlockCount()
		{
			return this._blocks.Length;
		}

		// Token: 0x060012CB RID: 4811 RVA: 0x00038654 File Offset: 0x00036854
		protected int RemainingBlocks()
		{
			int num = 0;
			for (int i = 0; i < this._blocks.Length; i++)
			{
				if (this._blocks[i] != null)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x040007C4 RID: 1988
		private global::NPOI.POIFS.Storage.ListManagedBlock[] _blocks;

		// Token: 0x040007C5 RID: 1989
		private global::NPOI.POIFS.Storage.BlockAllocationTableReader _bat;
	}
}
