using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.FileSystem;
using NPOI.POIFS.Properties;
using NPOI.POIFS.Storage;

namespace NPOI.POIFS.EventFileSystem
{
	// Token: 0x020002C9 RID: 713
	public class POIFSReader
	{
		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060013A9 RID: 5033 RVA: 0x0003ADD0 File Offset: 0x00038FD0
		// (remove) Token: 0x060013AA RID: 5034 RVA: 0x0003AE08 File Offset: 0x00039008
		public event global::NPOI.POIFS.EventFileSystem.POIFSReaderEventHandler StreamReaded;

		// Token: 0x060013AB RID: 5035 RVA: 0x0003AE3D File Offset: 0x0003903D
		protected virtual void OnStreamReaded(global::NPOI.POIFS.EventFileSystem.POIFSReaderEventArgs e)
		{
			if (this.StreamReaded != null)
			{
				this.StreamReaded(this, e);
			}
		}

		// Token: 0x060013AC RID: 5036 RVA: 0x0003AE54 File Offset: 0x00039054
		public POIFSReader()
		{
			this.registry = new global::NPOI.POIFS.EventFileSystem.POIFSReaderRegistry();
			this.registryClosed = false;
		}

		// Token: 0x060013AD RID: 5037 RVA: 0x0003AE70 File Offset: 0x00039070
		public global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.DocumentDescriptor> Read(global::System.IO.Stream stream)
		{
			this.registryClosed = true;
			global::NPOI.POIFS.Storage.HeaderBlock headerBlock = new global::NPOI.POIFS.Storage.HeaderBlock(stream);
			global::NPOI.POIFS.Storage.RawDataBlockList rawDataBlockList = new global::NPOI.POIFS.Storage.RawDataBlockList(stream, headerBlock.BigBlockSize);
			new global::NPOI.POIFS.Storage.BlockAllocationTableReader(headerBlock.BigBlockSize, headerBlock.BATCount, headerBlock.BATArray, headerBlock.XBATCount, headerBlock.XBATIndex, rawDataBlockList);
			global::NPOI.POIFS.Properties.PropertyTable propertyTable = new global::NPOI.POIFS.Properties.PropertyTable(headerBlock, rawDataBlockList);
			return this.ProcessProperties(global::NPOI.POIFS.Storage.SmallBlockTableReader.GetSmallDocumentBlocks(headerBlock.BigBlockSize, rawDataBlockList, propertyTable.Root, headerBlock.SBATStart), rawDataBlockList, propertyTable.Root.Children, new global::NPOI.POIFS.FileSystem.POIFSDocumentPath());
		}

		// Token: 0x060013AE RID: 5038 RVA: 0x0003AEF4 File Offset: 0x000390F4
		public void RegisterListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener)
		{
			if (listener == null)
			{
				throw new global::System.NullReferenceException();
			}
			if (this.registryClosed)
			{
				throw new global::System.InvalidOperationException();
			}
			this.registry.RegisterListener(listener);
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0003AF19 File Offset: 0x00039119
		public void RegisterListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener, string name)
		{
			this.RegisterListener(listener, null, name);
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0003AF24 File Offset: 0x00039124
		public void RegisterListener(global::NPOI.POIFS.EventFileSystem.POIFSReaderListener listener, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path, string name)
		{
			if (listener == null || name == null || name.Length == 0)
			{
				throw new global::System.NullReferenceException();
			}
			if (this.registryClosed)
			{
				throw new global::System.InvalidOperationException();
			}
			this.registry.RegisterListener(listener, (path == null) ? new global::NPOI.POIFS.FileSystem.POIFSDocumentPath() : path, name);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x0003AF60 File Offset: 0x00039160
		private global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.DocumentDescriptor> ProcessProperties(global::NPOI.POIFS.Storage.BlockList small_blocks, global::NPOI.POIFS.Storage.BlockList big_blocks, global::System.Collections.IEnumerator properties, global::NPOI.POIFS.FileSystem.POIFSDocumentPath path)
		{
			global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.DocumentDescriptor> result = new global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.DocumentDescriptor>();
			while (properties.MoveNext())
			{
				object obj = properties.Current;
				global::NPOI.POIFS.Properties.Property property = (global::NPOI.POIFS.Properties.Property)obj;
				string name = property.Name;
				if (property.IsDirectory)
				{
					global::NPOI.POIFS.FileSystem.POIFSDocumentPath path2 = new global::NPOI.POIFS.FileSystem.POIFSDocumentPath(path, new string[]
					{
						name
					});
					this.ProcessProperties(small_blocks, big_blocks, ((global::NPOI.POIFS.Properties.DirectoryProperty)property).Children, path2);
				}
				else
				{
					int startBlock = property.StartBlock;
					global::System.Collections.IEnumerator listeners = this.registry.GetListeners(path, name);
					if (listeners.MoveNext())
					{
						listeners.Reset();
						int size = property.Size;
						global::NPOI.POIFS.FileSystem.OPOIFSDocument document;
						if (property.ShouldUseSmallBlocks)
						{
							document = new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, small_blocks.FetchBlocks(startBlock, -1), size);
						}
						else
						{
							document = new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, big_blocks.FetchBlocks(startBlock, -1), size);
						}
						while (listeners.MoveNext())
						{
							object obj2 = listeners.Current;
							((global::NPOI.POIFS.EventFileSystem.POIFSReaderListener)obj2).ProcessPOIFSReaderEvent(new global::NPOI.POIFS.EventFileSystem.POIFSReaderEvent(new global::NPOI.POIFS.FileSystem.DocumentInputStream(document), path, name));
						}
					}
					else if (property.ShouldUseSmallBlocks)
					{
						small_blocks.FetchBlocks(startBlock, -1);
					}
					else
					{
						big_blocks.FetchBlocks(startBlock, -1);
					}
				}
			}
			return result;
		}

		// Token: 0x04000834 RID: 2100
		private global::NPOI.POIFS.EventFileSystem.POIFSReaderRegistry registry;

		// Token: 0x04000835 RID: 2101
		private bool registryClosed;
	}
}
