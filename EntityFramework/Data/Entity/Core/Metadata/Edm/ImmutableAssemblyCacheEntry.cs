using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050B RID: 1291
	internal class ImmutableAssemblyCacheEntry : global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry
	{
		// Token: 0x06003FCE RID: 16334 RVA: 0x000D387C File Offset: 0x000D1A7C
		internal ImmutableAssemblyCacheEntry(global::System.Data.Entity.Core.Metadata.Edm.MutableAssemblyCacheEntry mutableEntry)
		{
			this._typesInAssembly = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmType>(mutableEntry.TypesInAssembly));
			this._closureAssemblies = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Reflection.Assembly>(new global::System.Collections.Generic.List<global::System.Reflection.Assembly>(mutableEntry.ClosureAssemblies));
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x06003FCF RID: 16335 RVA: 0x000D38B0 File Offset: 0x000D1AB0
		internal override global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmType> TypesInAssembly
		{
			get
			{
				return this._typesInAssembly;
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06003FD0 RID: 16336 RVA: 0x000D38B8 File Offset: 0x000D1AB8
		internal override global::System.Collections.Generic.IList<global::System.Reflection.Assembly> ClosureAssemblies
		{
			get
			{
				return this._closureAssemblies;
			}
		}

		// Token: 0x04001643 RID: 5699
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EdmType> _typesInAssembly;

		// Token: 0x04001644 RID: 5700
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Reflection.Assembly> _closureAssemblies;
	}
}
