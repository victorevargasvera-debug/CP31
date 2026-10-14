using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E0 RID: 736
	public class NPOIFSStream : global::System.Collections.Generic.IEnumerable<global::NPOI.Util.ByteBuffer>, global::System.Collections.IEnumerable
	{
		// Token: 0x060014C3 RID: 5315 RVA: 0x0003E950 File Offset: 0x0003CB50
		public NPOIFSStream(global::NPOI.POIFS.FileSystem.BlockStore blockStore, int startBlock)
		{
			this.blockStore = blockStore;
			this.startBlock = startBlock;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0003E966 File Offset: 0x0003CB66
		public NPOIFSStream(global::NPOI.POIFS.FileSystem.BlockStore blockStore)
		{
			this.blockStore = blockStore;
			this.startBlock = -2;
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0003E97D File Offset: 0x0003CB7D
		public int GetStartBlock()
		{
			return this.startBlock;
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0003E985 File Offset: 0x0003CB85
		public global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer> GetEnumerator()
		{
			return this.GetBlockIterator();
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0003E985 File Offset: 0x0003CB85
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetBlockIterator();
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0003E98D File Offset: 0x0003CB8D
		public global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer> GetBlockIterator()
		{
			if (this.startBlock == -2)
			{
				throw new global::System.InvalidOperationException("Can't read from a new stream before it has been written to");
			}
			return new global::NPOI.POIFS.FileSystem.NPOIFSStream.StreamBlockByteBufferIterator(this, this.startBlock);
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0003E9B0 File Offset: 0x0003CBB0
		public void UpdateContents(byte[] contents)
		{
			global::System.IO.Stream outputStream = this.GetOutputStream();
			outputStream.Write(contents, 0, contents.Length);
			outputStream.Close();
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		public global::System.IO.Stream GetOutputStream()
		{
			if (this.outStream == null)
			{
				this.outStream = new global::NPOI.POIFS.FileSystem.NPOIFSStream.StreamBlockByteBuffer(this);
			}
			return this.outStream;
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x0003E9E4 File Offset: 0x0003CBE4
		public void Free()
		{
			global::NPOI.POIFS.FileSystem.ChainLoopDetector chainLoopDetector = this.blockStore.GetChainLoopDetector();
			this.Free(chainLoopDetector);
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x0003EA04 File Offset: 0x0003CC04
		internal void Free(global::NPOI.POIFS.FileSystem.ChainLoopDetector loopDetector)
		{
			int nextBlock = this.startBlock;
			while (nextBlock != -2)
			{
				int offset = nextBlock;
				loopDetector.Claim(offset);
				nextBlock = this.blockStore.GetNextBlock(offset);
				this.blockStore.SetNextBlock(offset, -1);
			}
			this.startBlock = -2;
		}

		// Token: 0x04000880 RID: 2176
		private global::NPOI.POIFS.FileSystem.BlockStore blockStore;

		// Token: 0x04000881 RID: 2177
		private int startBlock;

		// Token: 0x04000882 RID: 2178
		private global::System.IO.MemoryStream outStream;

		// Token: 0x020005AC RID: 1452
		public class StreamBlockByteBuffer : global::System.IO.MemoryStream
		{
			// Token: 0x06003492 RID: 13458 RVA: 0x000A3634 File Offset: 0x000A1834
			protected internal StreamBlockByteBuffer(global::NPOI.POIFS.FileSystem.NPOIFSStream pStream)
			{
				this.pStream = pStream;
				this.loopDetector = pStream.blockStore.GetChainLoopDetector();
				this.prevBlock = -2;
				this.nextBlock = pStream.startBlock;
			}

			// Token: 0x06003493 RID: 13459 RVA: 0x000A3674 File Offset: 0x000A1874
			protected void CreateBlockIfNeeded()
			{
				if (this.buffer != null && this.buffer.HasRemaining())
				{
					return;
				}
				int freeBlock = this.nextBlock;
				if (freeBlock == -2)
				{
					freeBlock = this.pStream.blockStore.GetFreeBlock();
					this.loopDetector.Claim(freeBlock);
					this.nextBlock = -2;
					if (this.prevBlock != -2)
					{
						this.pStream.blockStore.SetNextBlock(this.prevBlock, freeBlock);
					}
					this.pStream.blockStore.SetNextBlock(freeBlock, -2);
					if (this.pStream.startBlock == -2)
					{
						this.pStream.startBlock = freeBlock;
					}
				}
				else
				{
					this.loopDetector.Claim(freeBlock);
					this.nextBlock = this.pStream.blockStore.GetNextBlock(freeBlock);
				}
				this.buffer = this.pStream.blockStore.CreateBlockIfNeeded(freeBlock);
				this.prevBlock = freeBlock;
			}

			// Token: 0x06003494 RID: 13460 RVA: 0x000A375A File Offset: 0x000A195A
			public void Write(int b)
			{
				this.oneByte[0] = (byte)(b & 255);
				base.Write(this.oneByte, 0, this.oneByte.Length);
			}

			// Token: 0x06003495 RID: 13461 RVA: 0x000A3784 File Offset: 0x000A1984
			public override void Write(byte[] b, int off, int len)
			{
				if (off < 0 || off > b.Length || len < 0 || off + len > b.Length || off + len < 0)
				{
					throw new global::System.IndexOutOfRangeException();
				}
				if (len == 0)
				{
					return;
				}
				do
				{
					this.CreateBlockIfNeeded();
					int num = global::System.Math.Min(this.buffer.Remaining(), len);
					this.buffer.Write(b, off, num);
					off += num;
					len -= num;
				}
				while (len > 0);
			}

			// Token: 0x06003496 RID: 13462 RVA: 0x000A37EC File Offset: 0x000A19EC
			public override void Close()
			{
				new global::NPOI.POIFS.FileSystem.NPOIFSStream(this.pStream.blockStore, this.nextBlock).Free(this.loopDetector);
				if (this.prevBlock != -2)
				{
					this.pStream.blockStore.SetNextBlock(this.prevBlock, -2);
				}
				base.Close();
			}

			// Token: 0x04001928 RID: 6440
			private byte[] oneByte = new byte[1];

			// Token: 0x04001929 RID: 6441
			private global::NPOI.Util.ByteBuffer buffer;

			// Token: 0x0400192A RID: 6442
			private global::NPOI.POIFS.FileSystem.ChainLoopDetector loopDetector;

			// Token: 0x0400192B RID: 6443
			private int prevBlock;

			// Token: 0x0400192C RID: 6444
			private int nextBlock;

			// Token: 0x0400192D RID: 6445
			private global::NPOI.POIFS.FileSystem.NPOIFSStream pStream;
		}

		// Token: 0x020005AD RID: 1453
		public class StreamBlockByteBufferIterator : global::System.Collections.Generic.IEnumerator<global::NPOI.Util.ByteBuffer>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06003497 RID: 13463 RVA: 0x000A3844 File Offset: 0x000A1A44
			public StreamBlockByteBufferIterator(global::NPOI.POIFS.FileSystem.NPOIFSStream pStream, int firstBlock)
			{
				this.pStream = pStream;
				this.nextBlock = firstBlock;
				try
				{
					this.loopDetector = pStream.blockStore.GetChainLoopDetector();
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::System.Exception(ex.Message);
				}
			}

			// Token: 0x06003498 RID: 13464 RVA: 0x000A3894 File Offset: 0x000A1A94
			public bool HasNext()
			{
				return this.nextBlock != -2;
			}

			// Token: 0x06003499 RID: 13465 RVA: 0x000A38A4 File Offset: 0x000A1AA4
			public global::NPOI.Util.ByteBuffer Next()
			{
				if (this.nextBlock == -2)
				{
					throw new global::System.IndexOutOfRangeException("Can't read past the end of the stream");
				}
				global::NPOI.Util.ByteBuffer result;
				try
				{
					this.loopDetector.Claim(this.nextBlock);
					global::NPOI.Util.ByteBuffer blockAt = this.pStream.blockStore.GetBlockAt(this.nextBlock);
					this.nextBlock = this.pStream.blockStore.GetNextBlock(this.nextBlock);
					result = blockAt;
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::NPOI.Util.RuntimeException(ex.Message);
				}
				return result;
			}

			// Token: 0x0600349A RID: 13466 RVA: 0x000A392C File Offset: 0x000A1B2C
			public void Remove()
			{
				throw new global::System.NotImplementedException("Unsupported Operations!");
			}

			// Token: 0x17000DB9 RID: 3513
			// (get) Token: 0x0600349B RID: 13467 RVA: 0x000A3938 File Offset: 0x000A1B38
			public global::NPOI.Util.ByteBuffer Current
			{
				get
				{
					return this.current;
				}
			}

			// Token: 0x17000DBA RID: 3514
			// (get) Token: 0x0600349C RID: 13468 RVA: 0x000A3938 File Offset: 0x000A1B38
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.current;
				}
			}

			// Token: 0x0600349D RID: 13469 RVA: 0x00008C75 File Offset: 0x00006E75
			void global::System.Collections.IEnumerator.Reset()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x0600349E RID: 13470 RVA: 0x000A3940 File Offset: 0x000A1B40
			bool global::System.Collections.IEnumerator.MoveNext()
			{
				if (this.nextBlock == -2)
				{
					return false;
				}
				bool result;
				try
				{
					this.loopDetector.Claim(this.nextBlock);
					this.current = this.pStream.blockStore.GetBlockAt(this.nextBlock);
					this.nextBlock = this.pStream.blockStore.GetNextBlock(this.nextBlock);
					result = true;
				}
				catch (global::System.IO.IOException)
				{
					result = false;
				}
				return result;
			}

			// Token: 0x0600349F RID: 13471 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Dispose()
			{
			}

			// Token: 0x0400192E RID: 6446
			private global::NPOI.POIFS.FileSystem.ChainLoopDetector loopDetector;

			// Token: 0x0400192F RID: 6447
			private int nextBlock;

			// Token: 0x04001930 RID: 6448
			private global::NPOI.Util.ByteBuffer current;

			// Token: 0x04001931 RID: 6449
			private global::NPOI.POIFS.FileSystem.NPOIFSStream pStream;
		}
	}
}
