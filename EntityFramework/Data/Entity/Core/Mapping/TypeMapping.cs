using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055F RID: 1375
	public abstract class TypeMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x06004348 RID: 17224 RVA: 0x000E683D File Offset: 0x000E4A3D
		internal TypeMapping()
		{
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06004349 RID: 17225
		internal abstract global::System.Data.Entity.Core.Mapping.EntitySetBaseMapping SetMapping { get; }

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x0600434A RID: 17226
		internal abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> Types { get; }

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x0600434B RID: 17227
		internal abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityTypeBase> IsOfTypes { get; }

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x0600434C RID: 17228
		internal abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.MappingFragment> MappingFragments { get; }
	}
}
