using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.Dev;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.NIO;
using NPOI.POIFS.Properties;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002DE RID: 734
	public class NPOIFSFileSystem : global::NPOI.POIFS.FileSystem.BlockStore, global::NPOI.POIFS.Dev.POIFSViewable, global::NPOI.Util.ICloseable
	{
		// Token: 0x06001482 RID: 5250 RVA: 0x0003C4F2 File Offset: 0x0003A6F2
		public static global::System.IO.Stream CreateNonClosingInputStream(global::System.IO.Stream stream)
		{
			return new global::NPOI.POIFS.FileSystem.CloseIgnoringInputStream(stream);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0003D834 File Offset: 0x0003BA34
		// (set) Token: 0x06001484 RID: 5252 RVA: 0x0003D83C File Offset: 0x0003BA3C
		public global::NPOI.POIFS.NIO.DataSource Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0003D848 File Offset: 0x0003BA48
		private NPOIFSFileSystem(bool newFS)
		{
			this._header = new global::NPOI.POIFS.Storage.HeaderBlock(this.bigBlockSize);
			this._property_table = new global::NPOI.POIFS.Properties.NPropertyTable(this._header);
			this._mini_store = new global::NPOI.POIFS.FileSystem.NPOIFSMiniStore(this, this._property_table.Root, new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock>(), this._header);
			this._xbat_blocks = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock>();
			this._bat_blocks = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock>();
			this._root = null;
			if (newFS)
			{
				this._data = new global::NPOI.POIFS.NIO.ByteArrayBackedDataSource(new byte[this.bigBlockSize.GetBigBlockSize() * 3]);
			}
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x0003D8E8 File Offset: 0x0003BAE8
		public NPOIFSFileSystem() : this(true)
		{
			this._header.BATCount = 1;
			this._header.BATArray = new int[]
			{
				1
			};
			global::NPOI.POIFS.Storage.BATBlock batblock = global::NPOI.POIFS.Storage.BATBlock.CreateEmptyBATBlock(this.bigBlockSize, false);
			batblock.OurBlockIndex = 1;
			this._bat_blocks.Add(batblock);
			this.SetNextBlock(0, -2);
			this.SetNextBlock(1, -3);
			this._property_table.StartBlock = 0;
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0003D95B File Offset: 0x0003BB5B
		public NPOIFSFileSystem(global::System.IO.FileInfo file) : this(file, true)
		{
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0003D965 File Offset: 0x0003BB65
		public NPOIFSFileSystem(global::System.IO.FileInfo file, bool readOnly) : this(null, file, readOnly, true)
		{
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x0003D971 File Offset: 0x0003BB71
		public NPOIFSFileSystem(global::System.IO.FileStream channel) : this(channel, true)
		{
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x0003D97B File Offset: 0x0003BB7B
		public NPOIFSFileSystem(global::System.IO.FileStream channel, bool readOnly) : this(channel, null, readOnly, false)
		{
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x0003D988 File Offset: 0x0003BB88
		public NPOIFSFileSystem(global::System.IO.FileStream channel, global::System.IO.FileInfo srcFile, bool readOnly, bool closeChannelOnError) : this(false)
		{
			try
			{
				if (srcFile != null)
				{
					if (srcFile.Length == 0L)
					{
						throw new global::NPOI.EmptyFileException();
					}
					channel = new global::System.IO.FileStream(srcFile.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					this._data = new global::NPOI.POIFS.NIO.FileBackedDataSource(channel, readOnly);
				}
				else
				{
					this._data = new global::NPOI.POIFS.NIO.FileBackedDataSource(channel, readOnly);
				}
				try
				{
					byte[] array = new byte[512];
					global::NPOI.Util.IOUtils.ReadFully(channel, array);
					this._header = new global::NPOI.POIFS.Storage.HeaderBlock(array);
					this.ReadCoreContents();
				}
				catch (global::System.Exception)
				{
					throw;
				}
				finally
				{
					if (channel != null)
					{
						channel.Close();
					}
				}
			}
			catch (global::System.IO.IOException ex)
			{
				if (closeChannelOnError && channel != null)
				{
					channel.Close();
					channel = null;
				}
				throw ex;
			}
			catch (global::NPOI.Util.RuntimeException ex2)
			{
				if (closeChannelOnError && channel != null)
				{
					channel.Close();
					channel = null;
				}
				throw ex2;
			}
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x0003DA68 File Offset: 0x0003BC68
		public NPOIFSFileSystem(global::System.IO.Stream stream) : this(false)
		{
			global::System.IO.Stream stream2 = null;
			bool success = false;
			try
			{
				stream2 = stream;
				global::NPOI.Util.ByteBuffer byteBuffer = global::NPOI.Util.ByteBuffer.CreateBuffer(512);
				global::NPOI.Util.IOUtils.ReadFully(stream2, byteBuffer.Buffer);
				this._header = new global::NPOI.POIFS.Storage.HeaderBlock(byteBuffer);
				global::NPOI.POIFS.Storage.BlockAllocationTableReader.SanityCheckBlockCount(this._header.BATCount);
				long num = global::NPOI.POIFS.Storage.BATBlock.CalculateMaximumSize(this._header);
				if (num > 2147483647L)
				{
					throw new global::System.ArgumentException("Unable read a >2gb file via an InputStream");
				}
				global::NPOI.Util.ByteBuffer byteBuffer2 = global::NPOI.Util.ByteBuffer.CreateBuffer((int)num);
				byteBuffer.Position = 0;
				byteBuffer2.Write(byteBuffer.Buffer);
				byteBuffer2.Position = byteBuffer.Length;
				byteBuffer2.Position += global::NPOI.Util.IOUtils.ReadFully(stream2, byteBuffer2.Buffer, byteBuffer2.Position, (int)stream2.Length);
				success = true;
				this._data = new global::NPOI.POIFS.NIO.ByteArrayBackedDataSource(byteBuffer2.Buffer, byteBuffer2.Position);
			}
			finally
			{
				if (stream2 != null)
				{
					stream2.Close();
				}
				this.CloseInputStream(stream, success);
			}
			this.ReadCoreContents();
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0003DB68 File Offset: 0x0003BD68
		private void CloseInputStream(global::System.IO.Stream stream, bool success)
		{
			try
			{
				stream.Close();
			}
			catch (global::System.IO.IOException ex)
			{
				if (success)
				{
					throw new global::System.Exception(ex.Message);
				}
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x0003DBA0 File Offset: 0x0003BDA0
		public static bool HasPOIFSHeader(global::System.IO.Stream inp)
		{
			byte[] array = new byte[8];
			int len = global::NPOI.Util.IOUtils.ReadFully(inp, array);
			global::NPOI.Util.LongField longField = new global::NPOI.Util.LongField(0, array);
			if (inp is global::NPOI.Util.PushbackInputStream)
			{
				((global::NPOI.Util.PushbackInputStream)inp).Unread(array, 0, len);
			}
			else
			{
				inp.Position = 0L;
			}
			return longField.Value == -2226271756974174256L;
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x0003C66D File Offset: 0x0003A86D
		public static bool HasPOIFSHeader(byte[] header8Bytes)
		{
			return new global::NPOI.Util.LongField(0, header8Bytes).Value == -2226271756974174256L;
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x0003DBF4 File Offset: 0x0003BDF4
		private void ReadCoreContents()
		{
			this.bigBlockSize = this._header.BigBlockSize;
			global::NPOI.POIFS.FileSystem.ChainLoopDetector chainLoopDetector = this.GetChainLoopDetector();
			foreach (int batAt in this._header.BATArray)
			{
				this.ReadBAT(batAt, chainLoopDetector);
			}
			int num = this._header.BATCount - this._header.BATArray.Length;
			int num2 = this._header.XBATIndex;
			for (int j = 0; j < this._header.XBATCount; j++)
			{
				chainLoopDetector.Claim(num2);
				global::NPOI.Util.ByteBuffer blockAt = this.GetBlockAt(num2);
				global::NPOI.POIFS.Storage.BATBlock batblock = global::NPOI.POIFS.Storage.BATBlock.CreateBATBlock(this.bigBlockSize, blockAt);
				batblock.OurBlockIndex = num2;
				num2 = batblock.GetValueAt(this.bigBlockSize.GetXBATEntriesPerBlock());
				this._xbat_blocks.Add(batblock);
				int num3 = global::System.Math.Min(num, this.bigBlockSize.GetXBATEntriesPerBlock());
				for (int k = 0; k < num3; k++)
				{
					int valueAt = batblock.GetValueAt(k);
					if (valueAt == -1 || valueAt == -2)
					{
						break;
					}
					this.ReadBAT(valueAt, chainLoopDetector);
				}
				num -= num3;
			}
			this._property_table = new global::NPOI.POIFS.Properties.NPropertyTable(this._header, this);
			global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock>();
			this._mini_store = new global::NPOI.POIFS.FileSystem.NPOIFSMiniStore(this, this._property_table.Root, list, this._header);
			num2 = this._header.SBATStart;
			int num4 = 0;
			while (num4 < this._header.SBATCount && num2 != -2)
			{
				chainLoopDetector.Claim(num2);
				global::NPOI.Util.ByteBuffer blockAt2 = this.GetBlockAt(num2);
				global::NPOI.POIFS.Storage.BATBlock batblock2 = global::NPOI.POIFS.Storage.BATBlock.CreateBATBlock(this.bigBlockSize, blockAt2);
				batblock2.OurBlockIndex = num2;
				list.Add(batblock2);
				num2 = this.GetNextBlock(num2);
				num4++;
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x0003DDB4 File Offset: 0x0003BFB4
		private void ReadBAT(int batAt, global::NPOI.POIFS.FileSystem.ChainLoopDetector loopDetector)
		{
			loopDetector.Claim(batAt);
			global::NPOI.Util.ByteBuffer blockAt = this.GetBlockAt(batAt);
			global::NPOI.POIFS.Storage.BATBlock batblock = global::NPOI.POIFS.Storage.BATBlock.CreateBATBlock(this.bigBlockSize, blockAt);
			batblock.OurBlockIndex = batAt;
			this._bat_blocks.Add(batblock);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x0003DDF0 File Offset: 0x0003BFF0
		private global::NPOI.POIFS.Storage.BATBlock CreateBAT(int offset, bool isBAT)
		{
			global::NPOI.POIFS.Storage.BATBlock batblock = global::NPOI.POIFS.Storage.BATBlock.CreateEmptyBATBlock(this.bigBlockSize, !isBAT);
			batblock.OurBlockIndex = offset;
			global::NPOI.Util.ByteBuffer src = global::NPOI.Util.ByteBuffer.CreateBuffer(this.bigBlockSize.GetBigBlockSize());
			int num = (1 + offset) * this.bigBlockSize.GetBigBlockSize();
			this._data.Write(src, (long)num);
			return batblock;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x0003DE44 File Offset: 0x0003C044
		public override global::NPOI.Util.ByteBuffer GetBlockAt(int offset)
		{
			global::NPOI.Util.ByteBuffer result = null;
			if (!this.TryGetBlockAt(offset, out result))
			{
				throw new global::System.IndexOutOfRangeException("Block " + offset.ToString() + " not found");
			}
			return result;
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x0003DE7C File Offset: 0x0003C07C
		public override bool TryGetBlockAt(int offset, out global::NPOI.Util.ByteBuffer buffer)
		{
			long num = (long)((offset + 1) * this.bigBlockSize.GetBigBlockSize());
			buffer = null;
			if (num >= this._data.Size)
			{
				return false;
			}
			bool result;
			try
			{
				buffer = this._data.Read(this.bigBlockSize.GetBigBlockSize(), num);
				result = true;
			}
			catch (global::System.IndexOutOfRangeException innerException)
			{
				throw new global::System.IndexOutOfRangeException("Block " + offset.ToString() + " not found - ", innerException);
			}
			return result;
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x0003DEFC File Offset: 0x0003C0FC
		public override global::NPOI.Util.ByteBuffer CreateBlockIfNeeded(int offset)
		{
			global::NPOI.Util.ByteBuffer result;
			if (this.TryGetBlockAt(offset, out result))
			{
				return result;
			}
			long position = (long)((offset + 1) * this.bigBlockSize.GetBigBlockSize());
			global::NPOI.Util.ByteBuffer src = global::NPOI.Util.ByteBuffer.CreateBuffer(this.GetBigBlockSize());
			this._data.Write(src, position);
			return this.GetBlockAt(offset);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x0003DF47 File Offset: 0x0003C147
		public override global::NPOI.POIFS.Storage.BATBlockAndIndex GetBATBlockAndIndex(int offset)
		{
			return global::NPOI.POIFS.Storage.BATBlock.GetBATBlockAndIndex(offset, this._header, this._bat_blocks);
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x0003DF5C File Offset: 0x0003C15C
		public override int GetNextBlock(int offset)
		{
			global::NPOI.POIFS.Storage.BATBlockAndIndex batblockAndIndex = this.GetBATBlockAndIndex(offset);
			return batblockAndIndex.Block.GetValueAt(batblockAndIndex.Index);
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x0003DF84 File Offset: 0x0003C184
		public override void SetNextBlock(int offset, int nextBlock)
		{
			global::NPOI.POIFS.Storage.BATBlockAndIndex batblockAndIndex = this.GetBATBlockAndIndex(offset);
			batblockAndIndex.Block.SetValueAt(batblockAndIndex.Index, nextBlock);
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0003DFAC File Offset: 0x0003C1AC
		public override int GetFreeBlock()
		{
			int batentriesPerBlock = this.bigBlockSize.GetBATEntriesPerBlock();
			int num = 0;
			foreach (global::NPOI.POIFS.Storage.BATBlock batblock in this._bat_blocks)
			{
				if (batblock.HasFreeSectors)
				{
					for (int i = 0; i < batentriesPerBlock; i++)
					{
						if (batblock.GetValueAt(i) == -1)
						{
							return num + i;
						}
					}
				}
				num += batentriesPerBlock;
			}
			global::NPOI.POIFS.Storage.BATBlock batblock2 = this.CreateBAT(num, true);
			batblock2.SetValueAt(0, -3);
			this._bat_blocks.Add(batblock2);
			if (this._header.BATCount >= 109)
			{
				global::NPOI.POIFS.Storage.BATBlock batblock3 = null;
				foreach (global::NPOI.POIFS.Storage.BATBlock batblock4 in this._xbat_blocks)
				{
					if (batblock4.HasFreeSectors)
					{
						batblock3 = batblock4;
						break;
					}
				}
				if (batblock3 == null)
				{
					batblock3 = this.CreateBAT(num + 1, false);
					batblock3.SetValueAt(0, num);
					batblock2.SetValueAt(1, -4);
					num++;
					if (this._xbat_blocks.Count == 0)
					{
						this._header.XBATStart = num;
					}
					else
					{
						this._xbat_blocks[this._xbat_blocks.Count - 1].SetValueAt(this.bigBlockSize.GetXBATEntriesPerBlock(), num);
					}
					this._xbat_blocks.Add(batblock3);
					this._header.XBATCount = this._xbat_blocks.Count;
				}
				else
				{
					for (int j = 0; j < this.bigBlockSize.GetXBATEntriesPerBlock(); j++)
					{
						if (batblock3.GetValueAt(j) == -1)
						{
							batblock3.SetValueAt(j, num);
							break;
						}
					}
				}
			}
			else
			{
				int[] array = new int[this._header.BATCount + 1];
				global::System.Array.Copy(this._header.BATArray, 0, array, 0, array.Length - 1);
				array[array.Length - 1] = num;
				this._header.BATArray = array;
			}
			this._header.BATCount = this._bat_blocks.Count;
			return num + 1;
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x0003E1E0 File Offset: 0x0003C3E0
		protected internal long Size
		{
			get
			{
				return this._data.Size;
			}
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0003E1ED File Offset: 0x0003C3ED
		public override global::NPOI.POIFS.FileSystem.ChainLoopDetector GetChainLoopDetector()
		{
			return new global::NPOI.POIFS.FileSystem.ChainLoopDetector(this._data.Size, this);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x0600149C RID: 5276 RVA: 0x0003E200 File Offset: 0x0003C400
		public global::NPOI.POIFS.Properties.NPropertyTable PropertyTable
		{
			get
			{
				return this._property_table;
			}
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x0003E208 File Offset: 0x0003C408
		public global::NPOI.POIFS.FileSystem.NPOIFSMiniStore GetMiniStore()
		{
			return this._mini_store;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0003E210 File Offset: 0x0003C410
		public void AddDocument(global::NPOI.POIFS.FileSystem.NPOIFSDocument document)
		{
			this._property_table.AddProperty(document.DocumentProperty);
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x0003E223 File Offset: 0x0003C423
		public void AddDirectory(global::NPOI.POIFS.Properties.DirectoryProperty directory)
		{
			this._property_table.AddProperty(directory);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x0003E231 File Offset: 0x0003C431
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(global::System.IO.Stream stream, string name)
		{
			return this.Root.CreateDocument(name, stream);
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0003E240 File Offset: 0x0003C440
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
		{
			return this.Root.CreateDocument(name, size, writer);
		}

		// Token: 0x060014A2 RID: 5282 RVA: 0x0003E250 File Offset: 0x0003C450
		public global::NPOI.POIFS.FileSystem.DirectoryEntry CreateDirectory(string name)
		{
			return this.Root.CreateDirectory(name);
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0003E25E File Offset: 0x0003C45E
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateOrUpdateDocument(global::System.IO.Stream stream, string name)
		{
			return this.Root.CreateOrUpdateDocument(name, stream);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0003E26D File Offset: 0x0003C46D
		public bool IsInPlaceWriteable()
		{
			return this._data is global::NPOI.POIFS.NIO.FileBackedDataSource && ((global::NPOI.POIFS.NIO.FileBackedDataSource)this._data).IsWriteable;
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x0003E291 File Offset: 0x0003C491
		public void WriteFileSystem()
		{
			if (!(this._data is global::NPOI.POIFS.NIO.FileBackedDataSource))
			{
				throw new global::System.ArgumentException("POIFS opened from an inputstream, so WriteFilesystem() may not be called. Use WriteFilesystem(OutputStream) instead");
			}
			this.syncWithDataSource();
		}

		// Token: 0x060014A6 RID: 5286 RVA: 0x0003E2B1 File Offset: 0x0003C4B1
		public void WriteFileSystem(global::System.IO.Stream stream)
		{
			this.syncWithDataSource();
			this._data.CopyTo(stream);
		}

		// Token: 0x060014A7 RID: 5287 RVA: 0x0003E2C8 File Offset: 0x0003C4C8
		private void syncWithDataSource()
		{
			this._mini_store.SyncWithDataSource();
			global::NPOI.POIFS.FileSystem.NPOIFSStream stream = new global::NPOI.POIFS.FileSystem.NPOIFSStream(this, this._header.PropertyStart);
			this._property_table.PreWrite();
			this._property_table.Write(stream);
			new global::NPOI.POIFS.Storage.HeaderBlockWriter(this._header).WriteBlock(this.GetBlockAt(-1));
			foreach (global::NPOI.POIFS.Storage.BATBlock batblock in this._bat_blocks)
			{
				global::NPOI.Util.ByteBuffer blockAt = this.GetBlockAt(batblock.OurBlockIndex);
				global::NPOI.POIFS.Storage.BlockAllocationTableWriter.WriteBlock(batblock, blockAt);
			}
			foreach (global::NPOI.POIFS.Storage.BATBlock batblock2 in this._xbat_blocks)
			{
				global::NPOI.Util.ByteBuffer blockAt2 = this.GetBlockAt(batblock2.OurBlockIndex);
				global::NPOI.POIFS.Storage.BlockAllocationTableWriter.WriteBlock(batblock2, blockAt2);
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x0003E3C8 File Offset: 0x0003C5C8
		public void Close()
		{
			this._data.Close();
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0003E3D5 File Offset: 0x0003C5D5
		public global::NPOI.POIFS.FileSystem.DirectoryNode Root
		{
			get
			{
				if (this._root == null)
				{
					this._root = new global::NPOI.POIFS.FileSystem.DirectoryNode(this._property_table.Root, this, null);
				}
				return this._root;
			}
		}

		// Token: 0x060014AA RID: 5290 RVA: 0x0003E3FD File Offset: 0x0003C5FD
		public global::NPOI.POIFS.FileSystem.DocumentInputStream CreateDocumentInputStream(string documentName)
		{
			return this.Root.CreateDocumentInputStream(documentName);
		}

		// Token: 0x060014AB RID: 5291 RVA: 0x0003E40B File Offset: 0x0003C60B
		public void Remove(global::NPOI.POIFS.FileSystem.EntryNode entry)
		{
			if (entry is global::NPOI.POIFS.FileSystem.DocumentEntry)
			{
				new global::NPOI.POIFS.FileSystem.NPOIFSDocument((global::NPOI.POIFS.Properties.DocumentProperty)entry.Property, this).Free();
			}
			this._property_table.RemoveProperty(entry.Property);
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x0003E43C File Offset: 0x0003C63C
		protected object[] GetViewableArray()
		{
			if (this.PreferArray)
			{
				global::System.Array viewableArray = ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).ViewableArray;
				object[] array = new object[viewableArray.Length];
				for (int i = 0; i < viewableArray.Length; i++)
				{
					array[i] = viewableArray.GetValue(i);
				}
				return array;
			}
			return new object[0];
		}

		// Token: 0x060014AD RID: 5293 RVA: 0x0003E48C File Offset: 0x0003C68C
		protected global::System.Collections.IEnumerator GetViewableIterator()
		{
			if (!this.PreferArray)
			{
				return ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).ViewableIterator;
			}
			return null;
		}

		// Token: 0x060014AE RID: 5294 RVA: 0x0003E4A3 File Offset: 0x0003C6A3
		protected string GetShortDescription()
		{
			return "POIFS FileSystem";
		}

		// Token: 0x060014AF RID: 5295 RVA: 0x0003E4AA File Offset: 0x0003C6AA
		public int GetBigBlockSize()
		{
			return this.bigBlockSize.GetBigBlockSize();
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x0003E4B7 File Offset: 0x0003C6B7
		public global::NPOI.POIFS.Common.POIFSBigBlockSize GetBigBlockSizeDetails()
		{
			return this.bigBlockSize;
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0003E4BF File Offset: 0x0003C6BF
		public override int GetBlockStoreBlockSize()
		{
			return this.GetBigBlockSize();
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x0003E4C7 File Offset: 0x0003C6C7
		public bool PreferArray
		{
			get
			{
				return ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).PreferArray;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0003E4D4 File Offset: 0x0003C6D4
		public string ShortDescription
		{
			get
			{
				return this.GetShortDescription();
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060014B4 RID: 5300 RVA: 0x0003E4DC File Offset: 0x0003C6DC
		public global::System.Array ViewableArray
		{
			get
			{
				return this.GetViewableArray();
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060014B5 RID: 5301 RVA: 0x0003E4E4 File Offset: 0x0003C6E4
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				return this.GetViewableIterator();
			}
		}

		// Token: 0x04000872 RID: 2162
		private static global::NPOI.Util.POILogger _logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem));

		// Token: 0x04000873 RID: 2163
		private global::NPOI.POIFS.FileSystem.NPOIFSMiniStore _mini_store;

		// Token: 0x04000874 RID: 2164
		private global::NPOI.POIFS.Properties.NPropertyTable _property_table;

		// Token: 0x04000875 RID: 2165
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> _xbat_blocks;

		// Token: 0x04000876 RID: 2166
		private global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.BATBlock> _bat_blocks;

		// Token: 0x04000877 RID: 2167
		private global::NPOI.POIFS.Storage.HeaderBlock _header;

		// Token: 0x04000878 RID: 2168
		private global::NPOI.POIFS.FileSystem.DirectoryNode _root;

		// Token: 0x04000879 RID: 2169
		private global::NPOI.POIFS.NIO.DataSource _data;

		// Token: 0x0400087A RID: 2170
		private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
	}
}
