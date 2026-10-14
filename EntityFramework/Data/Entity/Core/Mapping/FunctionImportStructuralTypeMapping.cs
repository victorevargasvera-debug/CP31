using System;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000542 RID: 1346
	public abstract class FunctionImportStructuralTypeMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x06004216 RID: 16918 RVA: 0x000DEE1F File Offset: 0x000DD01F
		internal FunctionImportStructuralTypeMapping(global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> columnsRenameList, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo)
		{
			this.ColumnsRenameList = columnsRenameList;
			this.LineInfo = lineInfo;
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x06004217 RID: 16919 RVA: 0x000DEE35 File Offset: 0x000DD035
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> PropertyMappings
		{
			get
			{
				return new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>(this.ColumnsRenameList);
			}
		}

		// Token: 0x06004218 RID: 16920 RVA: 0x000DEE42 File Offset: 0x000DD042
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this.ColumnsRenameList);
			base.SetReadOnly();
		}

		// Token: 0x040016EE RID: 5870
		internal readonly global::System.Data.Entity.Core.Mapping.LineInfo LineInfo;

		// Token: 0x040016EF RID: 5871
		internal readonly global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> ColumnsRenameList;
	}
}
