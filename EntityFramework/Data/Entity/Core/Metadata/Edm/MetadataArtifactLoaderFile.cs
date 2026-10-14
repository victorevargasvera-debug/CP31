using System;
using System.Collections.Generic;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D5 RID: 1237
	internal class MetadataArtifactLoaderFile : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.IComparable
	{
		// Token: 0x06003D6B RID: 15723 RVA: 0x000CA6AC File Offset: 0x000C88AC
		public MetadataArtifactLoaderFile(string path, global::System.Collections.Generic.ICollection<string> uriRegistry)
		{
			this._path = path;
			this._alreadyLoaded = uriRegistry.Contains(this._path);
			if (!this._alreadyLoaded)
			{
				uriRegistry.Add(this._path);
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06003D6C RID: 15724 RVA: 0x000CA6E1 File Offset: 0x000C88E1
		public override string Path
		{
			get
			{
				return this._path;
			}
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x000CA6EC File Offset: 0x000C88EC
		public int CompareTo(object obj)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile = obj as global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile;
			if (metadataArtifactLoaderFile != null)
			{
				return string.Compare(this._path, metadataArtifactLoaderFile._path, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return -1;
		}

		// Token: 0x06003D6E RID: 15726 RVA: 0x000CA717 File Offset: 0x000C8917
		public override bool Equals(object obj)
		{
			return this.CompareTo(obj) == 0;
		}

		// Token: 0x06003D6F RID: 15727 RVA: 0x000CA723 File Offset: 0x000C8923
		public override int GetHashCode()
		{
			return this._path.GetHashCode();
		}

		// Token: 0x06003D70 RID: 15728 RVA: 0x000CA730 File Offset: 0x000C8930
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (!this._alreadyLoaded && global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this._path, spaceToGet))
			{
				list.Add(this._path);
			}
			return list;
		}

		// Token: 0x06003D71 RID: 15729 RVA: 0x000CA768 File Offset: 0x000C8968
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (!this._alreadyLoaded)
			{
				list.Add(this._path);
			}
			return list;
		}

		// Token: 0x06003D72 RID: 15730 RVA: 0x000CA790 File Offset: 0x000C8990
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			if (!this._alreadyLoaded)
			{
				global::System.Xml.XmlReader xmlReader = this.CreateXmlReader();
				list.Add(xmlReader);
				if (sourceDictionary != null)
				{
					sourceDictionary.Add(this, xmlReader);
				}
			}
			return list;
		}

		// Token: 0x06003D73 RID: 15731 RVA: 0x000CA7C8 File Offset: 0x000C89C8
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			if (!this._alreadyLoaded && global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this._path, spaceToGet))
			{
				global::System.Xml.XmlReader item = this.CreateXmlReader();
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06003D74 RID: 15732 RVA: 0x000CA800 File Offset: 0x000C8A00
		private global::System.Xml.XmlReader CreateXmlReader()
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = global::System.Data.Entity.Core.SchemaObjectModel.Schema.CreateEdmStandardXmlReaderSettings();
			xmlReaderSettings.ConformanceLevel = global::System.Xml.ConformanceLevel.Document;
			return global::System.Xml.XmlReader.Create(this._path, xmlReaderSettings);
		}

		// Token: 0x040014F8 RID: 5368
		private readonly bool _alreadyLoaded;

		// Token: 0x040014F9 RID: 5369
		private readonly string _path;
	}
}
