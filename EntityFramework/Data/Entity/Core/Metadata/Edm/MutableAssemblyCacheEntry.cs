using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000511 RID: 1297
	internal class MutableAssemblyCacheEntry : global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry
	{
		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06003FF1 RID: 16369 RVA: 0x000D3C7B File Offset: 0x000D1E7B
		internal override global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmType> TypesInAssembly
		{
			get
			{
				return this._typesInAssembly;
			}
		}

		// Token: 0x17000C81 RID: 3201
		// (get) Token: 0x06003FF2 RID: 16370 RVA: 0x000D3C83 File Offset: 0x000D1E83
		internal override global::System.Collections.Generic.IList<global::System.Reflection.Assembly> ClosureAssemblies
		{
			get
			{
				return this._closureAssemblies;
			}
		}

		// Token: 0x04001652 RID: 5714
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType> _typesInAssembly = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType>();

		// Token: 0x04001653 RID: 5715
		private readonly global::System.Collections.Generic.List<global::System.Reflection.Assembly> _closureAssemblies = new global::System.Collections.Generic.List<global::System.Reflection.Assembly>();
	}
}
