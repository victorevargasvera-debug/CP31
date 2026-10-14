using System;
using System.Collections.Generic;
using NPOI.POIFS.Properties;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DF RID: 735
	public class NPOIFSMiniStore : global::NPOI.POIFS.FileSystem.BlockStore
	{
		// Token: 0x060014B7 RID: 5303 RVA: 0x0003E502 File Offset: 0x0003C702
		public NPOIFSMiniStore(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem filesystem, global::NPOI.POIFS.Properties.RootProperty root, global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> sbats, global::NPOI.POIFS.Storage.HeaderBlock header)
		{
			this._filesystem = filesystem;
			this._sbat_blocks = sbats;
			this._header = header;
			this._root = root;
			this._mini_stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(filesystem, root.StartBlock);
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0003E53C File Offset: 0x0003C73C
		private global::NPOI.Util.ByteBuffer GetBlockAt(int offset, bool throwIfNotFound)
		{
			int num = offset * 64;
			int num2 = num / this._filesystem.GetBigBlockSize();
			int num3 = num % this._filesystem.GetBigBlockSize();
			global::NPOI.POIFS.FileSystem.NPOIFSStream.StreamBlockByteBufferIterator streamBlockByteBufferIterator = this._mini_stream.GetBlockIterator() as global::NPOI.POIFS.FileSystem.NPOIFSStream.StreamBlockByteBufferIterator;
			for (int i = 0; i < num2; i++)
			{
				streamBlockByteBufferIterator.Next();
			}
			if (streamBlockByteBufferIterator.HasNext())
			{
				global::NPOI.Util.ByteBuffer byteBuffer = streamBlockByteBufferIterator.Next();
				byteBuffer.Position += num3;
				global::NPOI.Util.ByteBuffer byteBuffer2 = byteBuffer.Slice();
				byteBuffer2.Limit = 64;
				return byteBuffer2;
			}
			if (throwIfNotFound)
			{
				throw new global::System.IndexOutOfRangeException("Big block " + num2.ToString() + " outside stream");
			}
			return null;
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0003E5D6 File Offset: 0x0003C7D6
		public override global::NPOI.Util.ByteBuffer GetBlockAt(int offset)
		{
			return this.GetBlockAt(offset, true);
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0003E5E0 File Offset: 0x0003C7E0
		public override bool TryGetBlockAt(int offset, out global::NPOI.Util.ByteBuffer byteBuffer)
		{
			byteBuffer = null;
			bool result;
			try
			{
				byteBuffer = this.GetBlockAt(offset, false);
				result = (byteBuffer != null);
			}
			catch (global::System.IndexOutOfRangeException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0003E618 File Offset: 0x0003C818
		public override global::NPOI.Util.ByteBuffer CreateBlockIfNeeded(int offset)
		{
			bool flag = false;
			if (this._mini_stream.GetStartBlock() == -2)
			{
				flag = true;
			}
			global::NPOI.Util.ByteBuffer result;
			if (!flag && this.TryGetBlockAt(offset, out result))
			{
				return result;
			}
			int freeBlock = this._filesystem.GetFreeBlock();
			this._filesystem.CreateBlockIfNeeded(freeBlock);
			if (flag)
			{
				this._filesystem.PropertyTable.Root.StartBlock = freeBlock;
				this._mini_stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this._filesystem, freeBlock);
			}
			else
			{
				global::NPOI.POIFS.FileSystem.ChainLoopDetector chainLoopDetector = this._filesystem.GetChainLoopDetector();
				int offset2 = this._mini_stream.GetStartBlock();
				for (;;)
				{
					chainLoopDetector.Claim(offset2);
					int nextBlock = this._filesystem.GetNextBlock(offset2);
					if (nextBlock == -2)
					{
						break;
					}
					offset2 = nextBlock;
				}
				this._filesystem.SetNextBlock(offset2, freeBlock);
			}
			this._filesystem.SetNextBlock(freeBlock, -2);
			return this.CreateBlockIfNeeded(offset);
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0003E6ED File Offset: 0x0003C8ED
		public override global::NPOI.POIFS.Storage.BATBlockAndIndex GetBATBlockAndIndex(int offset)
		{
			return global::NPOI.POIFS.Storage.BATBlock.GetSBATBlockAndIndex(offset, this._header, this._sbat_blocks);
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0003E704 File Offset: 0x0003C904
		public override int GetNextBlock(int offset)
		{
			global::NPOI.POIFS.Storage.BATBlockAndIndex batblockAndIndex = this.GetBATBlockAndIndex(offset);
			return batblockAndIndex.Block.GetValueAt(batblockAndIndex.Index);
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0003E72C File Offset: 0x0003C92C
		public override void SetNextBlock(int offset, int nextBlock)
		{
			global::NPOI.POIFS.Storage.BATBlockAndIndex batblockAndIndex = this.GetBATBlockAndIndex(offset);
			batblockAndIndex.Block.SetValueAt(batblockAndIndex.Index, nextBlock);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0003E754 File Offset: 0x0003C954
		public override int GetFreeBlock()
		{
			int batentriesPerBlock = this._filesystem.GetBigBlockSizeDetails().GetBATEntriesPerBlock();
			int num = 0;
			for (int i = 0; i < this._sbat_blocks.Count; i++)
			{
				global::NPOI.POIFS.Storage.BATBlock batblock = this._sbat_blocks[i];
				if (batblock.HasFreeSectors)
				{
					for (int j = 0; j < batentriesPerBlock; j++)
					{
						if (batblock.GetValueAt(j) == -1)
						{
							return num + j;
						}
					}
				}
				num += batentriesPerBlock;
			}
			global::NPOI.POIFS.Storage.BATBlock batblock2 = global::NPOI.POIFS.Storage.BATBlock.CreateEmptyBATBlock(this._filesystem.GetBigBlockSizeDetails(), false);
			int freeBlock = this._filesystem.GetFreeBlock();
			batblock2.OurBlockIndex = freeBlock;
			if (this._header.SBATCount == 0)
			{
				this._header.SBATStart = freeBlock;
				this._header.SBATBlockCount = 1;
			}
			else
			{
				global::NPOI.POIFS.FileSystem.ChainLoopDetector chainLoopDetector = this._filesystem.GetChainLoopDetector();
				int offset = this._header.SBATStart;
				for (;;)
				{
					chainLoopDetector.Claim(offset);
					int nextBlock = this._filesystem.GetNextBlock(offset);
					if (nextBlock == -2)
					{
						break;
					}
					offset = nextBlock;
				}
				this._filesystem.SetNextBlock(offset, freeBlock);
				this._header.SBATBlockCount = this._header.SBATCount + 1;
			}
			this._filesystem.SetNextBlock(freeBlock, -2);
			this._sbat_blocks.Add(batblock2);
			return num;
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0003E896 File Offset: 0x0003CA96
		public override global::NPOI.POIFS.FileSystem.ChainLoopDetector GetChainLoopDetector()
		{
			return new global::NPOI.POIFS.FileSystem.ChainLoopDetector((long)this._root.Size, this);
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000177BF File Offset: 0x000159BF
		public override int GetBlockStoreBlockSize()
		{
			return 64;
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0003E8AC File Offset: 0x0003CAAC
		public void SyncWithDataSource()
		{
			int num = 0;
			foreach (global::NPOI.POIFS.Storage.BATBlock batblock in this._sbat_blocks)
			{
				global::NPOI.Util.ByteBuffer blockAt = this._filesystem.GetBlockAt(batblock.OurBlockIndex);
				global::NPOI.POIFS.Storage.BlockAllocationTableWriter.WriteBlock(batblock, blockAt);
				if (!batblock.HasFreeSectors)
				{
					num += this._filesystem.GetBigBlockSizeDetails().GetBATEntriesPerBlock();
				}
				else
				{
					num += batblock.GetUsedSectors(false);
				}
			}
			this._filesystem.PropertyTable.Root.Size = num;
		}

		// Token: 0x0400087B RID: 2171
		private global::NPOI.POIFS.FileSystem.NPOIFSFileSystem _filesystem;

		// Token: 0x0400087C RID: 2172
		private global::NPOI.POIFS.FileSystem.NPOIFSStream _mini_stream;

		// Token: 0x0400087D RID: 2173
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> _sbat_blocks;

		// Token: 0x0400087E RID: 2174
		private global::NPOI.POIFS.Storage.HeaderBlock _header;

		// Token: 0x0400087F RID: 2175
		private global::NPOI.POIFS.Properties.RootProperty _root;
	}
}
