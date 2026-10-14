using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200054A RID: 1354
	public abstract class MappingItemCollection : global::System.Data.Entity.Core.Metadata.Edm.ItemCollection
	{
		// Token: 0x06004256 RID: 16982 RVA: 0x000E016B File Offset: 0x000DE36B
		internal MappingItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(dataSpace)
		{
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x000E0174 File Offset: 0x000DE374
		internal virtual bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x000E017B File Offset: 0x000DE37B
		internal virtual global::System.Data.Entity.Core.Mapping.MappingBase GetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x06004259 RID: 16985 RVA: 0x000E0182 File Offset: 0x000DE382
		internal virtual bool TryGetMap(global::System.Data.Entity.Core.Metadata.Edm.GlobalItem item, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x0600425A RID: 16986 RVA: 0x000E0189 File Offset: 0x000DE389
		internal virtual global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x0600425B RID: 16987 RVA: 0x000E0190 File Offset: 0x000DE390
		internal virtual bool TryGetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace, bool ignoreCase, out global::System.Data.Entity.Core.Mapping.MappingBase map)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}

		// Token: 0x0600425C RID: 16988 RVA: 0x000E0197 File Offset: 0x000DE397
		internal virtual global::System.Data.Entity.Core.Mapping.MappingBase GetMap(string identity, global::System.Data.Entity.Core.Metadata.Edm.DataSpace typeSpace)
		{
			throw global::System.Data.Entity.Resources.Error.NotSupported();
		}
	}
}
