using System;
using System.Collections.Generic;
using System.Data.Entity.Core.SchemaObjectModel;
using System.Data.Entity.Resources;
using System.IO;
using System.Reflection;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D6 RID: 1238
	internal class MetadataArtifactLoaderResource : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.IComparable
	{
		// Token: 0x06003D75 RID: 15733 RVA: 0x000CA828 File Offset: 0x000C8A28
		internal MetadataArtifactLoaderResource(global::System.Reflection.Assembly assembly, string resourceName, global::System.Collections.Generic.ICollection<string> uriRegistry)
		{
			this._assembly = assembly;
			this._resourceName = resourceName;
			string item = global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateResPath(this._assembly, this._resourceName);
			this._alreadyLoaded = uriRegistry.Contains(item);
			if (!this._alreadyLoaded)
			{
				uriRegistry.Add(item);
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06003D76 RID: 15734 RVA: 0x000CA877 File Offset: 0x000C8A77
		public override string Path
		{
			get
			{
				return global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeResource.CreateResPath(this._assembly, this._resourceName);
			}
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x000CA88C File Offset: 0x000C8A8C
		public int CompareTo(object obj)
		{
			global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource metadataArtifactLoaderResource = obj as global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderResource;
			if (metadataArtifactLoaderResource != null)
			{
				return string.Compare(this.Path, metadataArtifactLoaderResource.Path, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return -1;
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x000CA8B7 File Offset: 0x000C8AB7
		public override bool Equals(object obj)
		{
			return this.CompareTo(obj) == 0;
		}

		// Token: 0x06003D79 RID: 15737 RVA: 0x000CA8C3 File Offset: 0x000C8AC3
		public override int GetHashCode()
		{
			return this.Path.GetHashCode();
		}

		// Token: 0x06003D7A RID: 15738 RVA: 0x000CA8D0 File Offset: 0x000C8AD0
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (!this._alreadyLoaded && global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this.Path, spaceToGet))
			{
				list.Add(this.Path);
			}
			return list;
		}

		// Token: 0x06003D7B RID: 15739 RVA: 0x000CA908 File Offset: 0x000C8B08
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			if (!this._alreadyLoaded)
			{
				list.Add(this.Path);
			}
			return list;
		}

		// Token: 0x06003D7C RID: 15740 RVA: 0x000CA930 File Offset: 0x000C8B30
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			if (!this._alreadyLoaded)
			{
				global::System.Xml.XmlReader xmlReader = this.CreateReader();
				list.Add(xmlReader);
				if (sourceDictionary != null)
				{
					sourceDictionary.Add(this, xmlReader);
				}
			}
			return list;
		}

		// Token: 0x06003D7D RID: 15741 RVA: 0x000CA968 File Offset: 0x000C8B68
		private global::System.Xml.XmlReader CreateReader()
		{
			global::System.IO.Stream input = this.LoadResource();
			global::System.Xml.XmlReaderSettings xmlReaderSettings = global::System.Data.Entity.Core.SchemaObjectModel.Schema.CreateEdmStandardXmlReaderSettings();
			xmlReaderSettings.CloseInput = true;
			xmlReaderSettings.ConformanceLevel = global::System.Xml.ConformanceLevel.Document;
			return global::System.Xml.XmlReader.Create(input, xmlReaderSettings);
		}

		// Token: 0x06003D7E RID: 15742 RVA: 0x000CA998 File Offset: 0x000C8B98
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			if (!this._alreadyLoaded && global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.IsArtifactOfDataSpace(this.Path, spaceToGet))
			{
				global::System.Xml.XmlReader item = this.CreateReader();
				list.Add(item);
			}
			return list;
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x000CA9D0 File Offset: 0x000C8BD0
		private global::System.IO.Stream LoadResource()
		{
			global::System.IO.Stream result;
			if (this.TryCreateResourceStream(out result))
			{
				return result;
			}
			throw new global::System.Data.Entity.Core.MetadataException(global::System.Data.Entity.Resources.Strings.UnableToLoadResource);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x000CA9F3 File Offset: 0x000C8BF3
		private bool TryCreateResourceStream(out global::System.IO.Stream resourceStream)
		{
			resourceStream = this._assembly.GetManifestResourceStream(this._resourceName);
			return resourceStream != null;
		}

		// Token: 0x040014FA RID: 5370
		private readonly bool _alreadyLoaded;

		// Token: 0x040014FB RID: 5371
		private readonly global::System.Reflection.Assembly _assembly;

		// Token: 0x040014FC RID: 5372
		private readonly string _resourceName;
	}
}
