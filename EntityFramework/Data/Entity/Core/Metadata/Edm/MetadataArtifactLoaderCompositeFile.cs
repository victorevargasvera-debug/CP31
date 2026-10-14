using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D3 RID: 1235
	internal class MetadataArtifactLoaderCompositeFile : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader
	{
		// Token: 0x06003D4A RID: 15690 RVA: 0x000C9E12 File Offset: 0x000C8012
		public MetadataArtifactLoaderCompositeFile(string path, global::System.Collections.Generic.ICollection<string> uriRegistry)
		{
			this._path = path;
			this._uriRegistry = uriRegistry;
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x000C9E28 File Offset: 0x000C8028
		public override string Path
		{
			get
			{
				return this._path;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x000C9E30 File Offset: 0x000C8030
		public override bool IsComposite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000C9E33 File Offset: 0x000C8033
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> CsdlChildren
		{
			get
			{
				this.LoadCollections();
				return this._csdlChildren;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x000C9E41 File Offset: 0x000C8041
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> SsdlChildren
		{
			get
			{
				this.LoadCollections();
				return this._ssdlChildren;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x000C9E4F File Offset: 0x000C804F
		internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> MslChildren
		{
			get
			{
				this.LoadCollections();
				return this._mslChildren;
			}
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x000C9E60 File Offset: 0x000C8060
		private void LoadCollections()
		{
			if (this._csdlChildren == null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> value = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeFile.GetArtifactsInDirectory(this._path, ".csdl", this._uriRegistry));
				global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>>(ref this._csdlChildren, value, null);
			}
			if (this._ssdlChildren == null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> value2 = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeFile.GetArtifactsInDirectory(this._path, ".ssdl", this._uriRegistry));
				global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>>(ref this._ssdlChildren, value2, null);
			}
			if (this._mslChildren == null)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> value3 = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>(global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderCompositeFile.GetArtifactsInDirectory(this._path, ".msl", this._uriRegistry));
				global::System.Threading.Interlocked.CompareExchange<global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>>(ref this._mslChildren, value3, null);
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x000C9F03 File Offset: 0x000C8103
		public override global::System.Collections.Generic.List<string> GetOriginalPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			return this.GetOriginalPaths();
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x000C9F0C File Offset: 0x000C810C
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> list2;
			if (!this.TryGetListForSpace(spaceToGet, out list2))
			{
				return list;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile in list2)
			{
				list.AddRange(metadataArtifactLoaderFile.GetPaths(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x000C9F70 File Offset: 0x000C8170
		private bool TryGetListForSpace(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet, out global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> files)
		{
			switch (spaceToGet)
			{
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSpace:
				files = this.CsdlChildren;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace:
				files = this.SsdlChildren;
				return true;
			case global::System.Data.Entity.Core.Metadata.Edm.DataSpace.CSSpace:
				files = this.MslChildren;
				return true;
			}
			files = null;
			return false;
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x000C9FB0 File Offset: 0x000C81B0
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile in this.CsdlChildren)
			{
				list.AddRange(metadataArtifactLoaderFile.GetPaths());
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile2 in this.SsdlChildren)
			{
				list.AddRange(metadataArtifactLoaderFile2.GetPaths());
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile3 in this.MslChildren)
			{
				list.AddRange(metadataArtifactLoaderFile3.GetPaths());
			}
			return list;
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x000CA090 File Offset: 0x000C8290
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile in this.CsdlChildren)
			{
				list.AddRange(metadataArtifactLoaderFile.GetReaders(sourceDictionary));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile2 in this.SsdlChildren)
			{
				list.AddRange(metadataArtifactLoaderFile2.GetReaders(sourceDictionary));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile3 in this.MslChildren)
			{
				list.AddRange(metadataArtifactLoaderFile3.GetReaders(sourceDictionary));
			}
			return list;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x000CA170 File Offset: 0x000C8370
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> list2;
			if (!this.TryGetListForSpace(spaceToGet, out list2))
			{
				return list;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile metadataArtifactLoaderFile in list2)
			{
				list.AddRange(metadataArtifactLoaderFile.CreateReaders(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x000CA1D4 File Offset: 0x000C83D4
		private static global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> GetArtifactsInDirectory(string directory, string extension, global::System.Collections.Generic.ICollection<string> uriRegistry)
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile>();
			foreach (string text in global::System.IO.Directory.GetFiles(directory, global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader.wildcard + extension, global::System.IO.SearchOption.TopDirectoryOnly))
			{
				string text2 = global::System.IO.Path.Combine(directory, text);
				if (!uriRegistry.Contains(text2) && text.EndsWith(extension, global::System.StringComparison.OrdinalIgnoreCase))
				{
					list.Add(new global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile(text2, uriRegistry));
				}
			}
			return list;
		}

		// Token: 0x040014F1 RID: 5361
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> _csdlChildren;

		// Token: 0x040014F2 RID: 5362
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> _ssdlChildren;

		// Token: 0x040014F3 RID: 5363
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoaderFile> _mslChildren;

		// Token: 0x040014F4 RID: 5364
		private readonly string _path;

		// Token: 0x040014F5 RID: 5365
		private readonly global::System.Collections.Generic.ICollection<string> _uriRegistry;
	}
}
