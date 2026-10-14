using System;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053E RID: 1342
	public abstract class FunctionImportReturnTypePropertyMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x06004206 RID: 16902 RVA: 0x000DEBE4 File Offset: 0x000DCDE4
		internal FunctionImportReturnTypePropertyMapping(global::System.Data.Entity.Core.Mapping.LineInfo lineInfo)
		{
			this.LineInfo = lineInfo;
		}

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06004207 RID: 16903
		internal abstract string CMember { get; }

		// Token: 0x17000D13 RID: 3347
		// (get) Token: 0x06004208 RID: 16904
		internal abstract string SColumn { get; }

		// Token: 0x040016E3 RID: 5859
		internal readonly global::System.Data.Entity.Core.Mapping.LineInfo LineInfo;
	}
}
