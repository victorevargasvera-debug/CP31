using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002C0 RID: 704
	public class PropertyTable : global::NPOI.POIFS.Properties.PropertyTableBase, global::NPOI.POIFS.Storage.BlockWritable
	{
		// Token: 0x06001376 RID: 4982 RVA: 0x0003A75C File Offset: 0x0003895C
		public PropertyTable(global::NPOI.POIFS.Storage.HeaderBlock headerBlock) : base(headerBlock)
		{
			this._bigBigBlockSize = headerBlock.BigBlockSize;
			this._blocks = null;
		}

		// Token: 0x06001377 RID: 4983 RVA: 0x0003A778 File Offset: 0x00038978
		public PropertyTable(global::NPOI.POIFS.Storage.HeaderBlock headerBlock, global::NPOI.POIFS.Storage.RawDataBlockList blockList) : base(headerBlock, global::NPOI.POIFS.Properties.PropertyFactory.ConvertToProperties(blockList.FetchBlocks(headerBlock.PropertyStart, -1)))
		{
			this._bigBigBlockSize = headerBlock.BigBlockSize;
			this._blocks = null;
		}

		// Token: 0x06001378 RID: 4984 RVA: 0x0003A7A8 File Offset: 0x000389A8
		public void PreWrite()
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Properties.Property>(this._properties.Count);
			for (int i = 0; i < this._properties.Count; i++)
			{
				list.Add(this._properties[i]);
			}
			for (int j = 0; j < list.Count; j++)
			{
				list[j].Index = j;
			}
			this._blocks = global::NPOI.POIFS.Storage.PropertyBlock.CreatePropertyBlockArray(this._bigBigBlockSize, list);
			for (int k = 0; k < list.Count; k++)
			{
				list[k].PreWrite();
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x0003A83B File Offset: 0x00038A3B
		public override int CountBlocks
		{
			get
			{
				if (this._blocks != null)
				{
					return this._blocks.Length;
				}
				return 0;
			}
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x0003A850 File Offset: 0x00038A50
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			if (this._blocks != null)
			{
				for (int i = 0; i < this._blocks.Length; i++)
				{
					this._blocks[i].WriteBlocks(stream);
				}
			}
		}

		// Token: 0x04000822 RID: 2082
		private global::NPOI.POIFS.Common.POIFSBigBlockSize _bigBigBlockSize;

		// Token: 0x04000823 RID: 2083
		private global::NPOI.POIFS.Storage.BlockWritable[] _blocks;
	}
}
