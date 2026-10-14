using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000508 RID: 1288
	internal abstract class AssemblyCacheEntry
	{
		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06003FBF RID: 16319
		internal abstract global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmType> TypesInAssembly { get; }

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x06003FC0 RID: 16320
		internal abstract global::System.Collections.Generic.IList<global::System.Reflection.Assembly> ClosureAssemblies { get; }

		// Token: 0x06003FC1 RID: 16321 RVA: 0x000D363C File Offset: 0x000D183C
		internal bool TryGetEdmType(string typeName, out global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType)
		{
			edmType = null;
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType2 in this.TypesInAssembly)
			{
				if (edmType2.Identity == typeName)
				{
					edmType = edmType2;
					break;
				}
			}
			return edmType != null;
		}

		// Token: 0x06003FC2 RID: 16322 RVA: 0x000D36A0 File Offset: 0x000D18A0
		internal bool ContainsType(string typeName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType = null;
			return this.TryGetEdmType(typeName, out edmType);
		}
	}
}
