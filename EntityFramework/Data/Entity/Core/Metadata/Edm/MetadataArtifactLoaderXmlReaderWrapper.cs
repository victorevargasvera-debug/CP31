using System;
using System.Collections.Generic;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D7 RID: 1239
	internal class MetadataArtifactLoaderXmlReaderWrapper : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.IComparable
	{
		// Token: 0x06003D81 RID: 15745 RVA: 0x000CAA0D File Offset: 0x000C8C0D
		public MetadataArtifactLoaderXmlReaderWrapper(global::System.Xml.XmlReader xmlReader)
		{
			this._reader = xmlReader;
			this._resourceUri = xmlReader.BaseURI;
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x06003D82 RID: 15746 RVA: 0x000CAA28 File Offset: 0x000C8C28
		public override string Path
		{
			get
			{
				if (string.IsNullOrEmpty(this._resourceUri))
				{
					return string.Empty;
				}
				return this._resourceUri;
			}
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x000CAA44 File Offset: 0x000C8C44
		public int CompareTo(object obj)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderXmlReaderWrapper metadataArtifactLoaderXmlReaderWrapper = obj as global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderXmlReaderWrapper;
			if (metadataArtifactLoaderXmlReaderWrapper == null)
			{
				return -1;
			}
			if (this._reader == metadataArtifactLoaderXmlReaderWrapper._reader)
			{
				return 0;
			}
			return -1;
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x000CAA6E File Offset: 0x000C8C6E
		public override bool Equals(object obj)
		{
			return this.CompareTo(obj) == 0;
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x000CAA7A File Offset: 0x000C8C7A
		public override int GetHashCode()
		{
			return this._reader.GetHashCode();
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x000CAA88 File Offset: 0x000C8C88
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this.Path, spaceToGet))
			{
				list.Add(this.Path);
			}
			return list;
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000CAAB6 File Offset: 0x000C8CB6
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			return new global::System.Collections.Generic.List<string>(new string[]
			{
				this.Path
			});
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000CAACC File Offset: 0x000C8CCC
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			list.Add(this._reader);
			if (sourceDictionary != null)
			{
				sourceDictionary.Add(this, this._reader);
			}
			return list;
		}

		// Token: 0x06003D89 RID: 15753 RVA: 0x000CAAF0 File Offset: 0x000C8CF0
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			if (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this.Path, spaceToGet))
			{
				list.Add(this._reader);
			}
			return list;
		}

		// Token: 0x040014FD RID: 5373
		private readonly global::System.Xml.XmlReader _reader;

		// Token: 0x040014FE RID: 5374
		private readonly string _resourceUri;
	}
}
