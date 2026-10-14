using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Common;
using NPOI.POIFS.Dev;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.Properties;
using NPOI.POIFS.Storage;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D6 RID: 726
	[global::System.Serializable]
	public class OPOIFSFileSystem : global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x06001404 RID: 5124 RVA: 0x0003C4F2 File Offset: 0x0003A6F2
		public static global::System.IO.Stream CreateNonClosingInputStream(global::System.IO.Stream stream)
		{
			return new global::NPOI.POIFS.FileSystem.CloseIgnoringInputStream(stream);
		}

		// Token: 0x06001405 RID: 5125 RVA: 0x0003C4FC File Offset: 0x0003A6FC
		public OPOIFSFileSystem()
		{
			global::NPOI.POIFS.Storage.HeaderBlock headerBlock = new global::NPOI.POIFS.Storage.HeaderBlock(this.bigBlockSize);
			this._property_table = new global::NPOI.POIFS.Properties.PropertyTable(headerBlock);
			this._documents = new global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.OPOIFSDocument>();
			this._root = null;
		}

		// Token: 0x06001406 RID: 5126 RVA: 0x0003C544 File Offset: 0x0003A744
		public OPOIFSFileSystem(global::System.IO.Stream stream) : this()
		{
			bool success = false;
			global::NPOI.POIFS.Storage.HeaderBlock headerBlock;
			global::NPOI.POIFS.Storage.RawDataBlockList rawDataBlockList;
			try
			{
				headerBlock = new global::NPOI.POIFS.Storage.HeaderBlock(stream);
				this.bigBlockSize = headerBlock.BigBlockSize;
				rawDataBlockList = new global::NPOI.POIFS.Storage.RawDataBlockList(stream, this.bigBlockSize);
				success = true;
			}
			finally
			{
				this.CloseInputStream(stream, success);
			}
			new global::NPOI.POIFS.Storage.BlockAllocationTableReader(headerBlock.BigBlockSize, headerBlock.BATCount, headerBlock.BATArray, headerBlock.XBATCount, headerBlock.XBATIndex, rawDataBlockList);
			global::NPOI.POIFS.Properties.PropertyTable propertyTable = new global::NPOI.POIFS.Properties.PropertyTable(headerBlock, rawDataBlockList);
			this.ProcessProperties(global::NPOI.POIFS.Storage.SmallBlockTableReader.GetSmallDocumentBlocks(this.bigBlockSize, rawDataBlockList, propertyTable.Root, headerBlock.SBATStart), rawDataBlockList, propertyTable.Root.Children, null, headerBlock.PropertyStart);
			this.Root.StorageClsid = propertyTable.Root.StorageClsid;
		}

		// Token: 0x06001407 RID: 5127 RVA: 0x0003C60C File Offset: 0x0003A80C
		private void CloseInputStream(global::System.IO.Stream stream, bool success)
		{
			if (stream is global::System.IO.MemoryStream)
			{
				"POIFS is closing the supplied input stream of type (" + stream.GetType().Name + ") which supports mark/reset.  This will be a problem for the caller if the stream will still be used.  If that is the case the caller should wrap the input stream to avoid this Close logic.  This warning is only temporary and will not be present in future versions of POI.";
			}
			try
			{
				stream.Close();
			}
			catch (global::System.IO.IOException)
			{
				if (success)
				{
					throw;
				}
			}
		}

		// Token: 0x06001408 RID: 5128 RVA: 0x0003C660 File Offset: 0x0003A860
		public static bool HasPOIFSHeader(global::NPOI.Util.InputStream inp)
		{
			return global::NPOI.POIFS.FileSystem.OPOIFSFileSystem.HasPOIFSHeader(global::NPOI.Util.IOUtils.PeekFirst8Bytes(inp));
		}

		// Token: 0x06001409 RID: 5129 RVA: 0x0003C66D File Offset: 0x0003A86D
		public static bool HasPOIFSHeader(byte[] header8Bytes)
		{
			return new global::NPOI.Util.LongField(0, header8Bytes).Value == -2226271756974174256L;
		}

		// Token: 0x0600140A RID: 5130 RVA: 0x0003C686 File Offset: 0x0003A886
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(global::System.IO.Stream stream, string name)
		{
			return this.Root.CreateDocument(name, stream);
		}

		// Token: 0x0600140B RID: 5131 RVA: 0x0003C695 File Offset: 0x0003A895
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
		{
			return this.Root.CreateDocument(name, size, writer);
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0003C6A5 File Offset: 0x0003A8A5
		public global::NPOI.POIFS.FileSystem.DirectoryEntry CreateDirectory(string name)
		{
			return this.Root.CreateDirectory(name);
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0003C6B3 File Offset: 0x0003A8B3
		public global::NPOI.POIFS.FileSystem.DocumentInputStream CreateDocumentInputStream(string documentName)
		{
			return this.Root.CreateDocumentInputStream(documentName);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		public void WriteFileSystem(global::System.IO.Stream stream)
		{
			this._property_table.PreWrite();
			global::NPOI.POIFS.Storage.SmallBlockTableWriter smallBlockTableWriter = new global::NPOI.POIFS.Storage.SmallBlockTableWriter(this.bigBlockSize, this._documents, this._property_table.Root);
			global::NPOI.POIFS.Storage.BlockAllocationTableWriter blockAllocationTableWriter = new global::NPOI.POIFS.Storage.BlockAllocationTableWriter(this.bigBlockSize);
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			list.AddRange(this._documents);
			list.Add(this._property_table);
			list.Add(smallBlockTableWriter);
			list.Add(smallBlockTableWriter.SBAT);
			foreach (object obj in list)
			{
				global::NPOI.POIFS.FileSystem.BATManaged batmanaged = (global::NPOI.POIFS.FileSystem.BATManaged)obj;
				int countBlocks = batmanaged.CountBlocks;
				if (countBlocks != 0)
				{
					batmanaged.StartBlock = blockAllocationTableWriter.AllocateSpace(countBlocks);
				}
			}
			int startBlock = blockAllocationTableWriter.CreateBlocks();
			global::NPOI.POIFS.Storage.HeaderBlockWriter headerBlockWriter = new global::NPOI.POIFS.Storage.HeaderBlockWriter(this.bigBlockSize);
			global::NPOI.POIFS.Storage.BATBlock[] array = headerBlockWriter.SetBATBlocks(blockAllocationTableWriter.CountBlocks, startBlock);
			headerBlockWriter.PropertyStart = this._property_table.StartBlock;
			headerBlockWriter.SBATStart = smallBlockTableWriter.SBAT.StartBlock;
			headerBlockWriter.SBATBlockCount = smallBlockTableWriter.SBATBlockCount;
			global::System.Collections.Generic.List<object> list2 = new global::System.Collections.Generic.List<object>();
			list2.Add(headerBlockWriter);
			list2.AddRange(this._documents);
			list2.Add(this._property_table);
			list2.Add(smallBlockTableWriter);
			list2.Add(smallBlockTableWriter.SBAT);
			list2.Add(blockAllocationTableWriter);
			for (int i = 0; i < array.Length; i++)
			{
				list2.Add(array[i]);
			}
			foreach (object obj2 in list2)
			{
				((global::NPOI.POIFS.Storage.BlockWritable)obj2).WriteBlocks(stream);
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x0600140F RID: 5135 RVA: 0x0003C85B File Offset: 0x0003AA5B
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

		// Token: 0x06001410 RID: 5136 RVA: 0x0003C883 File Offset: 0x0003AA83
		public void AddDocument(global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			this._documents.Add(document);
			this._property_table.AddProperty(document.DocumentProperty);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x0003C8A2 File Offset: 0x0003AAA2
		public void AddDirectory(global::NPOI.POIFS.Properties.DirectoryProperty directory)
		{
			this._property_table.AddProperty(directory);
		}

		// Token: 0x06001412 RID: 5138 RVA: 0x0003C8B0 File Offset: 0x0003AAB0
		public void Remove(global::NPOI.POIFS.FileSystem.EntryNode entry)
		{
			this._property_table.RemoveProperty(entry.Property);
			if (entry.IsDocumentEntry)
			{
				this._documents.Remove(((global::NPOI.POIFS.FileSystem.DocumentNode)entry).Document);
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		private void ProcessProperties(global::NPOI.POIFS.Storage.BlockList small_blocks, global::NPOI.POIFS.Storage.BlockList big_blocks, global::System.Collections.IEnumerator properties, global::NPOI.POIFS.FileSystem.DirectoryNode dir, int headerPropertiesStartAt)
		{
			while (properties.MoveNext())
			{
				object obj = properties.Current;
				global::NPOI.POIFS.Properties.Property property = (global::NPOI.POIFS.Properties.Property)obj;
				string name = property.Name;
				global::NPOI.POIFS.FileSystem.DirectoryNode directoryNode = (dir == null) ? this.Root : dir;
				if (property.IsDirectory)
				{
					global::NPOI.POIFS.FileSystem.DirectoryNode directoryNode2 = (global::NPOI.POIFS.FileSystem.DirectoryNode)directoryNode.CreateDirectory(name);
					directoryNode2.StorageClsid = property.StorageClsid;
					this.ProcessProperties(small_blocks, big_blocks, ((global::NPOI.POIFS.Properties.DirectoryProperty)property).Children, directoryNode2, headerPropertiesStartAt);
				}
				else
				{
					int startBlock = property.StartBlock;
					int size = property.Size;
					global::NPOI.POIFS.FileSystem.OPOIFSDocument document;
					if (property.ShouldUseSmallBlocks)
					{
						document = new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, small_blocks.FetchBlocks(startBlock, headerPropertiesStartAt), size);
					}
					else
					{
						document = new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, big_blocks.FetchBlocks(startBlock, headerPropertiesStartAt), size);
					}
					directoryNode.CreateDocument(document);
				}
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0003C9AA File Offset: 0x0003ABAA
		public global::System.Array ViewableArray
		{
			get
			{
				if (this.PreferArray)
				{
					return ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).ViewableArray;
				}
				return new object[0];
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001415 RID: 5141 RVA: 0x0003C9C6 File Offset: 0x0003ABC6
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				if (!this.PreferArray)
				{
					return ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).ViewableIterator;
				}
				return global::System.Collections.ArrayList.ReadOnly(new global::System.Collections.ArrayList()).GetEnumerator();
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0003C9EB File Offset: 0x0003ABEB
		public bool PreferArray
		{
			get
			{
				return ((global::NPOI.POIFS.Dev.POIFSViewable)this.Root).PreferArray;
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001417 RID: 5143 RVA: 0x0003C9F8 File Offset: 0x0003ABF8
		public string ShortDescription
		{
			get
			{
				return "POIFS FileSystem";
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0003C9FF File Offset: 0x0003ABFF
		public int BigBlockSize
		{
			get
			{
				return this.bigBlockSize.GetBigBlockSize();
			}
		}

		// Token: 0x04000856 RID: 2134
		private global::NPOI.POIFS.Properties.PropertyTable _property_table;

		// Token: 0x04000857 RID: 2135
		private global::System.Collections.Generic.IList<global::NPOI.POIFS.FileSystem.OPOIFSDocument> _documents;

		// Token: 0x04000858 RID: 2136
		private global::NPOI.POIFS.FileSystem.DirectoryNode _root;

		// Token: 0x04000859 RID: 2137
		private global::NPOI.POIFS.Common.POIFSBigBlockSize bigBlockSize = global::NPOI.POIFS.Common.POIFSConstants.SMALLER_BIG_BLOCK_SIZE_DETAILS;
	}
}
