using System;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.FileSystem;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.Storage
{
	// Token: 0x020002B4 RID: 692
	public class SmallBlockTableWriter : global::NPOI.POIFS.Storage.BlockWritable, global::NPOI.POIFS.FileSystem.BATManaged
	{
		// Token: 0x06001310 RID: 4880 RVA: 0x000394F0 File Offset: 0x000376F0
		public SmallBlockTableWriter(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::System.Collections.Generic.IList<global::NPOI.POIFS.FileSystem.OPOIFSDocument> documents, global::NPOI.POIFS.Properties.RootProperty root)
		{
			this._sbat = new global::NPOI.POIFS.Storage.BlockAllocationTableWriter(bigBlockSize);
			this._small_blocks = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.SmallDocumentBlock>();
			this._root = root;
			foreach (object obj in documents)
			{
				global::NPOI.POIFS.FileSystem.OPOIFSDocument opoifsdocument = (global::NPOI.POIFS.FileSystem.OPOIFSDocument)obj;
				global::NPOI.POIFS.Storage.SmallDocumentBlock[] smallBlocks = opoifsdocument.SmallBlocks;
				if (smallBlocks.Length != 0)
				{
					opoifsdocument.StartBlock = this._sbat.AllocateSpace(smallBlocks.Length);
					for (int i = 0; i < smallBlocks.Length; i++)
					{
						this._small_blocks.Add(smallBlocks[i]);
					}
				}
				else
				{
					opoifsdocument.StartBlock = -2;
				}
			}
			this._sbat.SimpleCreateBlocks();
			this._root.Size = this._small_blocks.Count;
			this._big_block_count = global::NPOI.POIFS.Storage.SmallDocumentBlock.Fill(bigBlockSize, this._small_blocks);
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001311 RID: 4881 RVA: 0x000395B6 File Offset: 0x000377B6
		public int SBATBlockCount
		{
			get
			{
				return (this._big_block_count + 15) / 16;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001312 RID: 4882 RVA: 0x000395C4 File Offset: 0x000377C4
		public global::NPOI.POIFS.Storage.BlockAllocationTableWriter SBAT
		{
			get
			{
				return this._sbat;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001313 RID: 4883 RVA: 0x000395CC File Offset: 0x000377CC
		public int CountBlocks
		{
			get
			{
				return this._big_block_count;
			}
		}

		// Token: 0x1700038D RID: 909
		// (set) Token: 0x06001314 RID: 4884 RVA: 0x000395D4 File Offset: 0x000377D4
		public int StartBlock
		{
			set
			{
				this._root.StartBlock = value;
			}
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x000395E4 File Offset: 0x000377E4
		public void WriteBlocks(global::System.IO.Stream stream)
		{
			foreach (global::NPOI.POIFS.Storage.SmallDocumentBlock smallDocumentBlock in this._small_blocks)
			{
				((global::NPOI.POIFS.Storage.BlockWritable)smallDocumentBlock).WriteBlocks(stream);
			}
		}

		// Token: 0x040007E4 RID: 2020
		private global::NPOI.POIFS.Storage.BlockAllocationTableWriter _sbat;

		// Token: 0x040007E5 RID: 2021
		private global::System.Collections.Generic.IList<global::NPOI.POIFS.Storage.SmallDocumentBlock> _small_blocks;

		// Token: 0x040007E6 RID: 2022
		private int _big_block_count;

		// Token: 0x040007E7 RID: 2023
		private global::NPOI.POIFS.Properties.RootProperty _root;
	}
}
