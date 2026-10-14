using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004D2 RID: 1234
	internal class MetadataArtifactLoaderComposite : global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>, global::System.Collections.IEnumerable
	{
		// Token: 0x06003D3F RID: 15679 RVA: 0x000C9BAA File Offset: 0x000C7DAA
		public MetadataArtifactLoaderComposite(global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> children)
		{
			this._children = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader>(children));
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06003D40 RID: 15680 RVA: 0x000C9BC3 File Offset: 0x000C7DC3
		public override string Path
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x000C9BCA File Offset: 0x000C7DCA
		public override bool IsComposite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x000C9BD0 File Offset: 0x000C7DD0
		public override global::System.Collections.Generic.List<string> GetOriginalPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.GetOriginalPaths());
			}
			return list;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x000C9C2C File Offset: 0x000C7E2C
		public override global::System.Collections.Generic.List<string> GetOriginalPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.GetOriginalPaths(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x000C9C88 File Offset: 0x000C7E88
		public override global::System.Collections.Generic.List<string> GetPaths(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.GetPaths(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x000C9CE4 File Offset: 0x000C7EE4
		public override global::System.Collections.Generic.List<string> GetPaths()
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.GetPaths());
			}
			return list;
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x000C9D40 File Offset: 0x000C7F40
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> GetReaders(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader, global::System.Xml.XmlReader> sourceDictionary)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.GetReaders(sourceDictionary));
			}
			return list;
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x000C9D9C File Offset: 0x000C7F9C
		public override global::System.Collections.Generic.List<global::System.Xml.XmlReader> CreateReaders(global::System.Data.Entity.Core.Metadata.Edm.DataSpace spaceToGet)
		{
			global::System.Collections.Generic.List<global::System.Xml.XmlReader> list = new global::System.Collections.Generic.List<global::System.Xml.XmlReader>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader metadataArtifactLoader in this._children)
			{
				list.AddRange(metadataArtifactLoader.CreateReaders(spaceToGet));
			}
			return list;
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x000C9DF8 File Offset: 0x000C7FF8
		public global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x000C9E05 File Offset: 0x000C8005
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._children.GetEnumerator();
		}

		// Token: 0x040014F0 RID: 5360
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.MetadataArtifactLoader> _children;
	}
}
