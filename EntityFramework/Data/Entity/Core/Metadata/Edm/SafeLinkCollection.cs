using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004F9 RID: 1273
	internal class SafeLinkCollection<TParent, TChild> : global::System.Data.Entity.Core.Metadata.Edm.ReadOnlyMetadataCollection<TChild> where TParent : class where TChild : global::System.Data.Entity.Core.Metadata.Edm.MetadataItem
	{
		// Token: 0x06003F1B RID: 16155 RVA: 0x000D0E40 File Offset: 0x000CF040
		public SafeLinkCollection(TParent parent, global::System.Func<TChild, global::System.Data.Entity.Core.Metadata.Edm.SafeLink<TParent>> getLink, global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<TChild> children) : base((global::System.Data.Entity.Core.Metadata.Edm.MetadataCollection<TChild>)global::System.Data.Entity.Core.Metadata.Edm.SafeLink<TParent>.BindChildren<TChild>(parent, getLink, children))
		{
		}
	}
}
