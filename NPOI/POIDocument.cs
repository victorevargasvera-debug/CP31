using System;
using System.Collections;
using System.IO;
using NPOI.HPSF;
using NPOI.POIFS.Crypt;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI
{
	// Token: 0x02000005 RID: 5
	[global::System.Serializable]
	public abstract class POIDocument : global::NPOI.Util.ICloseable
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002091 File Offset: 0x00000291
		protected internal void SetDirectoryNode(global::NPOI.POIFS.FileSystem.DirectoryNode directory)
		{
			this.directory = directory;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000209A File Offset: 0x0000029A
		protected POIDocument(global::NPOI.POIFS.FileSystem.DirectoryNode dir)
		{
			this.directory = dir;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020A9 File Offset: 0x000002A9
		protected POIDocument(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020B7 File Offset: 0x000002B7
		public POIDocument(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000020B7 File Offset: 0x000002B7
		protected POIDocument(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020C5 File Offset: 0x000002C5
		public void CreateInformationProperties()
		{
			if (!this.initialized)
			{
				this.ReadProperties();
			}
			if (this.sInf == null)
			{
				this.sInf = global::NPOI.HPSF.PropertySetFactory.CreateSummaryInformation();
			}
			if (this.dsInf == null)
			{
				this.dsInf = global::NPOI.HPSF.PropertySetFactory.CreateDocumentSummaryInformation();
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020FB File Offset: 0x000002FB
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002111 File Offset: 0x00000311
		public global::NPOI.HPSF.DocumentSummaryInformation DocumentSummaryInformation
		{
			get
			{
				if (!this.initialized)
				{
					this.ReadProperties();
				}
				return this.dsInf;
			}
			set
			{
				this.dsInf = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000211A File Offset: 0x0000031A
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002130 File Offset: 0x00000330
		public global::NPOI.HPSF.SummaryInformation SummaryInformation
		{
			get
			{
				if (!this.initialized)
				{
					this.ReadProperties();
				}
				return this.sInf;
			}
			set
			{
				this.sInf = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000213C File Offset: 0x0000033C
		protected internal void ReadProperties()
		{
			global::NPOI.HPSF.PropertySet propertySet = this.GetPropertySet("\u0005DocumentSummaryInformation");
			if (propertySet != null && propertySet is global::NPOI.HPSF.DocumentSummaryInformation)
			{
				this.dsInf = (global::NPOI.HPSF.DocumentSummaryInformation)propertySet;
			}
			else if (propertySet != null)
			{
				global::NPOI.POIDocument.logger.Log(5, "DocumentSummaryInformation property Set came back with wrong class - ", propertySet.GetType());
			}
			else
			{
				global::NPOI.POIDocument.logger.Log(5, "DocumentSummaryInformation property set came back as null");
			}
			propertySet = this.GetPropertySet("\u0005SummaryInformation");
			if (propertySet is global::NPOI.HPSF.SummaryInformation)
			{
				this.sInf = (global::NPOI.HPSF.SummaryInformation)propertySet;
			}
			else if (propertySet != null)
			{
				global::NPOI.POIDocument.logger.Log(5, "SummaryInformation property Set came back with wrong class - ", propertySet.GetType());
			}
			else
			{
				global::NPOI.POIDocument.logger.Log(5, "SummaryInformation property set came back as null");
			}
			this.initialized = true;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000021ED File Offset: 0x000003ED
		protected global::NPOI.HPSF.PropertySet GetPropertySet(string setName)
		{
			return this.GetPropertySet(setName, null);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021F8 File Offset: 0x000003F8
		protected global::NPOI.HPSF.PropertySet GetPropertySet(string setName, global::NPOI.POIFS.Crypt.EncryptionInfo encryptionInfo)
		{
			global::NPOI.POIFS.FileSystem.DirectoryNode root = this.directory;
			global::NPOI.POIFS.FileSystem.NPOIFSFileSystem npoifsfileSystem = null;
			string str = "getting";
			global::NPOI.HPSF.PropertySet result;
			try
			{
				if (encryptionInfo != null)
				{
					str = "getting encrypted";
					global::NPOI.Util.InputStream dataStream = encryptionInfo.Decryptor.GetDataStream(this.directory);
					try
					{
						npoifsfileSystem = new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(dataStream);
						root = npoifsfileSystem.Root;
					}
					finally
					{
						dataStream.Close();
					}
				}
				if (root == null || !root.HasEntry(setName))
				{
					result = null;
				}
				else
				{
					str = "getting";
					global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = root.CreateDocumentInputStream(root.GetEntry(setName));
					try
					{
						str = "creating";
						result = global::NPOI.HPSF.PropertySetFactory.Create(documentInputStream);
					}
					finally
					{
						documentInputStream.Close();
					}
				}
			}
			catch (global::System.Exception exception)
			{
				global::NPOI.POIDocument.logger.Log(5, "Error " + str + " property set with name " + setName, exception);
				result = null;
			}
			finally
			{
				if (npoifsfileSystem != null)
				{
					try
					{
						npoifsfileSystem.Close();
					}
					catch (global::System.IO.IOException exception2)
					{
						global::NPOI.POIDocument.logger.Log(5, "Error closing encrypted property poifs", exception2);
					}
				}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002310 File Offset: 0x00000510
		protected internal void WriteProperties()
		{
			this.ValidateInPlaceWritePossible();
			this.WriteProperties(this.directory.FileSystem, null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000232A File Offset: 0x0000052A
		protected internal void WriteProperties(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem outFS)
		{
			this.WriteProperties(outFS, null);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002334 File Offset: 0x00000534
		protected internal void WriteProperties(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem outFS, global::System.Collections.IList writtenEntries)
		{
			if (this.sInf != null)
			{
				this.WritePropertySet("\u0005SummaryInformation", this.sInf, outFS);
				if (writtenEntries != null)
				{
					writtenEntries.Add("\u0005SummaryInformation");
				}
			}
			if (this.dsInf != null)
			{
				this.WritePropertySet("\u0005DocumentSummaryInformation", this.dsInf, outFS);
				if (writtenEntries != null)
				{
					writtenEntries.Add("\u0005DocumentSummaryInformation");
				}
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002394 File Offset: 0x00000594
		protected void WritePropertySet(string name, global::NPOI.HPSF.PropertySet Set, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem outFS)
		{
			try
			{
				global::NPOI.HPSF.MutablePropertySet mutablePropertySet = new global::NPOI.HPSF.MutablePropertySet(Set);
				using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
				{
					mutablePropertySet.Write(memoryStream);
					using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(memoryStream.ToArray()))
					{
						outFS.CreateOrUpdateDocument(memoryStream2, name);
					}
				}
			}
			catch (global::NPOI.HPSF.WritingNotSupportedException)
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002410 File Offset: 0x00000610
		protected void ValidateInPlaceWritePossible()
		{
			if (this.directory == null)
			{
				throw new global::System.InvalidOperationException("Newly created Document, cannot save in-place");
			}
			if (this.directory.Parent != null)
			{
				throw new global::System.InvalidOperationException("This is not the root Document, cannot save embedded resource in-place");
			}
			if (this.directory.FileSystem == null || !this.directory.FileSystem.IsInPlaceWriteable())
			{
				throw new global::System.InvalidOperationException("Opened read-only or via an InputStream, a Writeable File is required");
			}
		}

		// Token: 0x06000019 RID: 25
		public abstract void Write();

		// Token: 0x0600001A RID: 26
		public abstract void Write(global::System.IO.FileInfo newFile);

		// Token: 0x0600001B RID: 27
		public abstract void Write(global::System.IO.Stream out1);

		// Token: 0x0600001C RID: 28 RVA: 0x00002472 File Offset: 0x00000672
		public virtual void Close()
		{
			if (this.directory != null && this.directory.NFileSystem != null)
			{
				this.directory.NFileSystem.Close();
				this.directory = null;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000024A0 File Offset: 0x000006A0
		public global::NPOI.POIFS.FileSystem.DirectoryNode Directory
		{
			get
			{
				return this.directory;
			}
		}

		// Token: 0x04000002 RID: 2
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIDocument));

		// Token: 0x04000003 RID: 3
		protected global::NPOI.HPSF.SummaryInformation sInf;

		// Token: 0x04000004 RID: 4
		protected global::NPOI.HPSF.DocumentSummaryInformation dsInf;

		// Token: 0x04000005 RID: 5
		protected global::NPOI.POIFS.FileSystem.DirectoryNode directory;

		// Token: 0x04000006 RID: 6
		protected bool initialized;
	}
}
