using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NPOI.POIFS.Common;
using NPOI.POIFS.Dev;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.Properties;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E2 RID: 738
	public class OPOIFSDocument : global::NPOI.POIFS.FileSystem.BATManaged, global::NPOI.POIFS.Storage.BlockWritable, global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x060014E6 RID: 5350 RVA: 0x0003F0E0 File Offset: 0x0003D2E0
		public OPOIFSDocument(string name, global::NPOI.POIFS.Storage.RawDataBlock[] blocks, int length)
		{
			this._size = length;
			if (blocks.Length == 0)
			{
				this._bigBigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
			}
			else
			{
				this._bigBigBlockSize = ((blocks[0].BigBlockSize == 512) ? global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS : global::NPOI.POIFS.Common.POIFSConstants.LARGER_BIG_BLOCK_SIZE_DETAILS);
			}
			this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(this._bigBigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.ConvertRawBlocksToBigBlocks(blocks));
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, this._size);
			this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(this._bigBigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_SMALL_BLOCK_ARRAY);
			this._property.Document = this;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x0003F17C File Offset: 0x0003D37C
		private static global::NPOI.POIFS.Storage.DocumentBlock[] ConvertRawBlocksToBigBlocks(global::NPOI.POIFS.Storage.ListManagedBlock[] blocks)
		{
			global::NPOI.POIFS.Storage.DocumentBlock[] array = new global::NPOI.POIFS.Storage.DocumentBlock[blocks.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new global::NPOI.POIFS.Storage.DocumentBlock((global::NPOI.POIFS.Storage.RawDataBlock)blocks[i]);
			}
			return array;
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x0003F1B4 File Offset: 0x0003D3B4
		private static global::NPOI.POIFS.Storage.SmallDocumentBlock[] ConvertRawBlocksToSmallBlocks(global::NPOI.POIFS.Storage.ListManagedBlock[] blocks)
		{
			if (blocks is global::NPOI.POIFS.Storage.SmallDocumentBlock[])
			{
				return (global::NPOI.POIFS.Storage.SmallDocumentBlock[])blocks;
			}
			global::NPOI.POIFS.Storage.SmallDocumentBlock[] array = new global::NPOI.POIFS.Storage.SmallDocumentBlock[blocks.Length];
			global::System.Array.Copy(blocks, 0, array, 0, blocks.Length);
			return array;
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x0003F1E8 File Offset: 0x0003D3E8
		public OPOIFSDocument(string name, global::NPOI.POIFS.Storage.SmallDocumentBlock[] blocks, int length)
		{
			this._size = length;
			if (blocks.Length == 0)
			{
				this._bigBigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
			}
			else
			{
				this._bigBigBlockSize = blocks[0].BigBlockSize;
			}
			this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(this._bigBigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_BIG_BLOCK_ARRAY);
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, this._size);
			this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(this._bigBigBlockSize, blocks);
			this._property.Document = this;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x0003F268 File Offset: 0x0003D468
		public OPOIFSDocument(string name, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.ListManagedBlock[] blocks, int length)
		{
			this._size = length;
			this._bigBigBlockSize = bigBlockSize;
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, this._size);
			this._property.Document = this;
			if (global::NPOI.POIFS.Properties.Property.IsSmall(this._size))
			{
				this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(bigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_BIG_BLOCK_ARRAY);
				this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(bigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.ConvertRawBlocksToSmallBlocks(blocks));
				return;
			}
			this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(bigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.ConvertRawBlocksToBigBlocks(blocks));
			this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(bigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_SMALL_BLOCK_ARRAY);
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x0003F2FC File Offset: 0x0003D4FC
		public OPOIFSDocument(string name, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::System.IO.Stream stream)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.DocumentBlock> list = new global::System.Collections.Generic.List<global::NPOI.POIFS.Storage.DocumentBlock>();
			this._size = 0;
			this._bigBigBlockSize = bigBlockSize;
			global::NPOI.POIFS.Storage.DocumentBlock documentBlock;
			do
			{
				documentBlock = new global::NPOI.POIFS.Storage.DocumentBlock(stream, bigBlockSize);
				int size = documentBlock.Size;
				if (size > 0)
				{
					list.Add(documentBlock);
					this._size += size;
				}
			}
			while (!documentBlock.PartiallyRead);
			global::NPOI.POIFS.Storage.DocumentBlock[] array = list.ToArray();
			this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(bigBlockSize, array);
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, this._size);
			this._property.Document = this;
			if (this._property.ShouldUseSmallBlocks)
			{
				global::NPOI.POIFS.Storage.BlockWritable[] store = array;
				this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(bigBlockSize, global::NPOI.POIFS.Storage.SmallDocumentBlock.Convert(bigBlockSize, store, this._size));
				this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(bigBlockSize, new global::NPOI.POIFS.Storage.DocumentBlock[0]);
				return;
			}
			this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(bigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_SMALL_BLOCK_ARRAY);
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x0003F3D3 File Offset: 0x0003D5D3
		public OPOIFSDocument(string name, global::System.IO.Stream stream) : this(name, global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, stream)
		{
		}

		// Token: 0x060014ED RID: 5357 RVA: 0x0003F3E4 File Offset: 0x0003D5E4
		public OPOIFSDocument(string name, int size, global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
		{
			this._size = size;
			this._bigBigBlockSize = bigBlockSize;
			this._property = new global::NPOI.POIFS.Properties.DocumentProperty(name, this._size);
			this._property.Document = this;
			if (this._property.ShouldUseSmallBlocks)
			{
				this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(this._bigBigBlockSize, path, name, size, writer);
				this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(this._bigBigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_BIG_BLOCK_ARRAY);
				return;
			}
			this._small_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore(this._bigBigBlockSize, global::NPOI.POIFS.FileSystem.OPOIFSDocument.EMPTY_SMALL_BLOCK_ARRAY);
			this._big_store = new global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore(this._bigBigBlockSize, path, name, size, writer);
		}

		// Token: 0x060014EE RID: 5358 RVA: 0x0003F48B File Offset: 0x0003D68B
		public OPOIFSDocument(string name, int size, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer) : this(name, size, global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, path, writer)
		{
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x0003F49D File Offset: 0x0003D69D
		public OPOIFSDocument(string name, global::NPOI.POIFS.Storage.ListManagedBlock[] blocks, int length) : this(name, global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS, blocks, length)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x0003F4B0 File Offset: 0x0003D6B0
		public virtual void Read(byte[] buffer, int offset)
		{
			int num = buffer.Length;
			global::NPOI.POIFS.Storage.DataInputBlock dataInputBlock = this.GetDataInputBlock(offset);
			int num2 = dataInputBlock.Available();
			if (num2 > num)
			{
				dataInputBlock.ReadFully(buffer, 0, num);
				return;
			}
			int i = num;
			int num3 = 0;
			int num4 = offset;
			while (i > 0)
			{
				bool flag = i >= num2;
				int num5;
				if (flag)
				{
					num5 = num2;
				}
				else
				{
					num5 = i;
				}
				dataInputBlock.ReadFully(buffer, num3, num5);
				i -= num5;
				num3 += num5;
				num4 += num5;
				if (flag)
				{
					if (num4 == this._size)
					{
						if (i > 0)
						{
							throw new global::System.InvalidOperationException("reached end of document stream unexpectedly");
						}
						return;
					}
					else
					{
						dataInputBlock = this.GetDataInputBlock(num4);
						num2 = dataInputBlock.Available();
					}
				}
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0003F54A File Offset: 0x0003D74A
		public virtual void WriteBlocks(global::System.IO.Stream stream)
		{
			this._big_store.WriteBlocks(stream);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0003F558 File Offset: 0x0003D758
		public global::NPOI.POIFS.Storage.DataInputBlock GetDataInputBlock(int offset)
		{
			if (offset >= this._size)
			{
				if (offset > this._size)
				{
					throw new global::NPOI.Util.RuntimeException("Request for Offset " + offset.ToString() + " doc size is " + this._size.ToString());
				}
				return null;
			}
			else
			{
				if (this._property.ShouldUseSmallBlocks)
				{
					return global::NPOI.POIFS.Storage.SmallDocumentBlock.GetDataInputBlock(this._small_store.Blocks, offset);
				}
				return global::NPOI.POIFS.Storage.DocumentBlock.GetDataInputBlock(this._big_store.Blocks, offset);
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x0003F5D0 File Offset: 0x0003D7D0
		public virtual int CountBlocks
		{
			get
			{
				return this._big_store.CountBlocks;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x060014F4 RID: 5364 RVA: 0x0003F5DD File Offset: 0x0003D7DD
		public virtual global::NPOI.POIFS.Properties.DocumentProperty DocumentProperty
		{
			get
			{
				return this._property;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x060014F5 RID: 5365 RVA: 0x00008875 File Offset: 0x00006A75
		public virtual bool PreferArray
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0003F5E8 File Offset: 0x0003D7E8
		public virtual string ShortDescription
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append("Document: \"").Append(this._property.Name).Append("\"");
				stringBuilder.Append(" size = ").Append(this.Size);
				return stringBuilder.ToString();
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0003F63C File Offset: 0x0003D83C
		public virtual int Size
		{
			get
			{
				return this._size;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x0003F644 File Offset: 0x0003D844
		public virtual global::NPOI.POIFS.Storage.SmallDocumentBlock[] SmallBlocks
		{
			get
			{
				return this._small_store.Blocks;
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0003F651 File Offset: 0x0003D851
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0003F65E File Offset: 0x0003D85E
		public virtual int StartBlock
		{
			get
			{
				return this._property.StartBlock;
			}
			set
			{
				this._property.StartBlock = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0003F66C File Offset: 0x0003D86C
		public global::System.Array ViewableArray
		{
			get
			{
				string text = "<NO DATA>";
				try
				{
					using (new global::System.IO.MemoryStream())
					{
						global::NPOI.POIFS.Storage.BlockWritable[] array = null;
						if (this._big_store.Valid)
						{
							global::NPOI.POIFS.Storage.BlockWritable[] array2 = this._big_store.Blocks;
							array = array2;
						}
						else if (this._small_store.Valid)
						{
							global::NPOI.POIFS.Storage.BlockWritable[] array2 = this._small_store.Blocks;
							array = array2;
						}
						if (array != null)
						{
							global::NPOI.Util.ByteArrayOutputStream byteArrayOutputStream = new global::NPOI.Util.ByteArrayOutputStream();
							global::NPOI.POIFS.Storage.BlockWritable[] array2 = array;
							for (int i = 0; i < array2.Length; i++)
							{
								array2[i].WriteBlocks(byteArrayOutputStream);
							}
							int length = (int)global::System.Math.Min(byteArrayOutputStream.Length, (long)this._property.Size);
							text = global::NPOI.Util.HexDump.Dump(byteArrayOutputStream.ToByteArray(), 0L, 0, length);
						}
					}
				}
				catch (global::System.IO.IOException ex)
				{
					text = ex.Message;
				}
				return new string[]
				{
					text
				};
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x0003A653 File Offset: 0x00038853
		public virtual global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				return global::System.Collections.ArrayList.ReadOnly(new global::System.Collections.ArrayList()).GetEnumerator();
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060014FD RID: 5373 RVA: 0x0003F754 File Offset: 0x0003D954
		// (remove) Token: 0x060014FE RID: 5374 RVA: 0x0003F78C File Offset: 0x0003D98C
		public event global::NPOI.POIFS.EventFileSystem.POIFSWriterEventHandler BeforeWriting;

		// Token: 0x060014FF RID: 5375 RVA: 0x0003F7C1 File Offset: 0x0003D9C1
		protected virtual void OnBeforeWriting(global::NPOI.POIFS.EventFileSystem.POIFSWriterEventArgs e)
		{
			if (this.BeforeWriting != null)
			{
				this.BeforeWriting(this, e);
			}
		}

		// Token: 0x04000889 RID: 2185
		private static global::NPOI.POIFS.Storage.DocumentBlock[] EMPTY_BIG_BLOCK_ARRAY = new global::NPOI.POIFS.Storage.DocumentBlock[0];

		// Token: 0x0400088A RID: 2186
		private static global::NPOI.POIFS.Storage.SmallDocumentBlock[] EMPTY_SMALL_BLOCK_ARRAY = new global::NPOI.POIFS.Storage.SmallDocumentBlock[0];

		// Token: 0x0400088B RID: 2187
		private global::NPOI.POIFS.Properties.DocumentProperty _property;

		// Token: 0x0400088C RID: 2188
		private int _size;

		// Token: 0x0400088D RID: 2189
		private global::NPOI.POIFS.Common.POIFSBigBlockSize _bigBigBlockSize;

		// Token: 0x0400088E RID: 2190
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument.SmallBlockStore _small_store;

		// Token: 0x0400088F RID: 2191
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument.BigBlockStore _big_store;

		// Token: 0x020005AE RID: 1454
		internal class SmallBlockStore
		{
			// Token: 0x060034A0 RID: 13472 RVA: 0x000A39C0 File Offset: 0x000A1BC0
			internal SmallBlockStore(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.SmallDocumentBlock[] blocks)
			{
				this.bigBlockSize = bigBlockSize;
				this.smallBlocks = (global::NPOI.POIFS.Storage.SmallDocumentBlock[])blocks.Clone();
				this.path = null;
				this.name = null;
				this.size = -1;
				this.writer = null;
			}

			// Token: 0x060034A1 RID: 13473 RVA: 0x000A39FC File Offset: 0x000A1BFC
			internal SmallBlockStore(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
			{
				this.bigBlockSize = bigBlockSize;
				this.smallBlocks = new global::NPOI.POIFS.Storage.SmallDocumentBlock[0];
				this.path = path;
				this.name = name;
				this.size = size;
				this.writer = writer;
			}

			// Token: 0x17000DBB RID: 3515
			// (get) Token: 0x060034A2 RID: 13474 RVA: 0x000A3A38 File Offset: 0x000A1C38
			internal virtual global::NPOI.POIFS.Storage.SmallDocumentBlock[] Blocks
			{
				get
				{
					if (this.Valid && this.writer != null)
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.size);
						global::NPOI.POIFS.FileSystem.DocumentOutputStream stream = new global::NPOI.POIFS.FileSystem.DocumentOutputStream(memoryStream, this.size);
						this.writer.ProcessPOIFSWriterEvent(new global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent(stream, this.path, this.name, this.size));
						this.smallBlocks = global::NPOI.POIFS.Storage.SmallDocumentBlock.Convert(this.bigBlockSize, memoryStream.ToArray(), this.size);
					}
					return this.smallBlocks;
				}
			}

			// Token: 0x17000DBC RID: 3516
			// (get) Token: 0x060034A3 RID: 13475 RVA: 0x000A3AB4 File Offset: 0x000A1CB4
			internal virtual bool Valid
			{
				get
				{
					return this.smallBlocks.Length != 0 || this.writer != null;
				}
			}

			// Token: 0x04001932 RID: 6450
			private global::NPOI.POIFS.Storage.SmallDocumentBlock[] smallBlocks;

			// Token: 0x04001933 RID: 6451
			private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

			// Token: 0x04001934 RID: 6452
			private string name;

			// Token: 0x04001935 RID: 6453
			private int size;

			// Token: 0x04001936 RID: 6454
			private global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer;

			// Token: 0x04001937 RID: 6455
			private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;
		}

		// Token: 0x020005AF RID: 1455
		internal class BigBlockStore
		{
			// Token: 0x060034A4 RID: 13476 RVA: 0x000A3ACA File Offset: 0x000A1CCA
			internal BigBlockStore(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.Storage.DocumentBlock[] blocks)
			{
				this.bigBlockSize = bigBlockSize;
				this.bigBlocks = (global::NPOI.POIFS.Storage.DocumentBlock[])blocks.Clone();
				this.path = null;
				this.name = null;
				this.size = -1;
				this.writer = null;
			}

			// Token: 0x060034A5 RID: 13477 RVA: 0x000A3B06 File Offset: 0x000A1D06
			internal BigBlockStore(global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
			{
				this.bigBlockSize = bigBlockSize;
				this.bigBlocks = new global::NPOI.POIFS.Storage.DocumentBlock[0];
				this.path = path;
				this.name = name;
				this.size = size;
				this.writer = writer;
			}

			// Token: 0x17000DBD RID: 3517
			// (get) Token: 0x060034A6 RID: 13478 RVA: 0x000A3B3F File Offset: 0x000A1D3F
			internal virtual bool Valid
			{
				get
				{
					return this.bigBlocks.Length != 0 || this.writer != null;
				}
			}

			// Token: 0x17000DBE RID: 3518
			// (get) Token: 0x060034A7 RID: 13479 RVA: 0x000A3B58 File Offset: 0x000A1D58
			internal virtual global::NPOI.POIFS.Storage.DocumentBlock[] Blocks
			{
				get
				{
					if (this.Valid && this.writer != null)
					{
						global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(this.size);
						global::NPOI.POIFS.FileSystem.DocumentOutputStream stream = new global::NPOI.POIFS.FileSystem.DocumentOutputStream(memoryStream, this.size);
						this.writer.ProcessPOIFSWriterEvent(new global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent(stream, this.path, this.name, this.size));
						this.bigBlocks = global::NPOI.POIFS.Storage.DocumentBlock.Convert(this.bigBlockSize, memoryStream.ToArray(), this.size);
					}
					return this.bigBlocks;
				}
			}

			// Token: 0x060034A8 RID: 13480 RVA: 0x000A3BD4 File Offset: 0x000A1DD4
			internal virtual void WriteBlocks(global::System.IO.Stream stream)
			{
				if (this.Valid)
				{
					if (this.writer != null)
					{
						global::NPOI.POIFS.FileSystem.DocumentOutputStream documentOutputStream = new global::NPOI.POIFS.FileSystem.DocumentOutputStream(stream, this.size);
						this.writer.ProcessPOIFSWriterEvent(new global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent(documentOutputStream, this.path, this.name, this.size));
						documentOutputStream.WriteFiller(this.CountBlocks * 512, global::NPOI.POIFS.Storage.DocumentBlock.FillByte);
						return;
					}
					for (int i = 0; i < this.bigBlocks.Length; i++)
					{
						this.bigBlocks[i].WriteBlocks(stream);
					}
				}
			}

			// Token: 0x17000DBF RID: 3519
			// (get) Token: 0x060034A9 RID: 13481 RVA: 0x000A3C5C File Offset: 0x000A1E5C
			internal virtual int CountBlocks
			{
				get
				{
					int result = 0;
					if (!this.Valid)
					{
						return result;
					}
					if (this.writer != null)
					{
						return (this.size + 512 - 1) / 512;
					}
					return this.bigBlocks.Length;
				}
			}

			// Token: 0x04001938 RID: 6456
			private global::NPOI.POIFS.Storage.DocumentBlock[] bigBlocks;

			// Token: 0x04001939 RID: 6457
			private global::NPOI.POIFS.FileSystem.POIFSDocumentPath path;

			// Token: 0x0400193A RID: 6458
			private string name;

			// Token: 0x0400193B RID: 6459
			private int size;

			// Token: 0x0400193C RID: 6460
			private global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer;

			// Token: 0x0400193D RID: 6461
			private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize;
		}
	}
}
