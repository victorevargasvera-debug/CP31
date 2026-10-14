using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000537 RID: 1335
	public abstract class FunctionImportMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060041D1 RID: 16849 RVA: 0x000DD2D8 File Offset: 0x000DB4D8
		internal FunctionImportMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmFunction functionImport, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction targetFunction)
		{
			this._functionImport = functionImport;
			this._targetFunction = targetFunction;
		}

		// Token: 0x17000D09 RID: 3337
		// (get) Token: 0x060041D2 RID: 16850 RVA: 0x000DD2EE File Offset: 0x000DB4EE
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction FunctionImport
		{
			get
			{
				return this._functionImport;
			}
		}

		// Token: 0x17000D0A RID: 3338
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x000DD2F6 File Offset: 0x000DB4F6
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction TargetFunction
		{
			get
			{
				return this._targetFunction;
			}
		}

		// Token: 0x040016D0 RID: 5840
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _functionImport;

		// Token: 0x040016D1 RID: 5841
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _targetFunction;
	}
}
