using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000546 RID: 1350
	public abstract class MappingBase : global::System.Data.Entity.Core.Metadata.Edm.GlobalItem
	{
		// Token: 0x0600422B RID: 16939 RVA: 0x000DFBF6 File Offset: 0x000DDDF6
		internal MappingBase() : base(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags.Readonly)
		{
		}

		// Token: 0x0600422C RID: 16940 RVA: 0x000DFBFF File Offset: 0x000DDDFF
		internal MappingBase(global::System.Data.Entity.Core.Metadata.Edm.MetadataItem.MetadataFlags flags) : base(flags)
		{
		}

		// Token: 0x17000D1C RID: 3356
		// (get) Token: 0x0600422D RID: 16941
		internal abstract global::System.Data.Entity.Core.Metadata.Edm.MetadataItem EdmItem { get; }
	}
}
