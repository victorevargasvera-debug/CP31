using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200053D RID: 1341
	internal sealed class FunctionImportReturnTypeEntityTypeColumnsRenameBuilder
	{
		// Token: 0x06004204 RID: 16900 RVA: 0x000DEA8C File Offset: 0x000DCC8C
		internal FunctionImportReturnTypeEntityTypeColumnsRenameBuilder(global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>> isOfTypeEntityTypeColumnsRenameMapping, global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Metadata.Edm.EntityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>> entityTypeColumnsRenameMapping)
		{
			this.ColumnRenameMapping = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping>();
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType in isOfTypeEntityTypeColumnsRenameMapping.Keys)
			{
				this.SetStructuralTypeColumnsRename(entityType, isOfTypeEntityTypeColumnsRenameMapping[entityType], true);
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType2 in entityTypeColumnsRenameMapping.Keys)
			{
				this.SetStructuralTypeColumnsRename(entityType2, entityTypeColumnsRenameMapping[entityType2], false);
			}
		}

		// Token: 0x06004205 RID: 16901 RVA: 0x000DEB44 File Offset: 0x000DCD44
		private void SetStructuralTypeColumnsRename(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> columnsRenameMapping, bool isTypeOf)
		{
			foreach (global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping functionImportReturnTypePropertyMapping in columnsRenameMapping)
			{
				if (!this.ColumnRenameMapping.Keys.Contains(functionImportReturnTypePropertyMapping.CMember))
				{
					this.ColumnRenameMapping[functionImportReturnTypePropertyMapping.CMember] = new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping(functionImportReturnTypePropertyMapping.CMember);
				}
				this.ColumnRenameMapping[functionImportReturnTypePropertyMapping.CMember].AddRename(new global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumn(functionImportReturnTypePropertyMapping.SColumn, entityType, isTypeOf, functionImportReturnTypePropertyMapping.LineInfo));
			}
		}

		// Token: 0x040016E2 RID: 5858
		internal global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypeStructuralTypeColumnRenameMapping> ColumnRenameMapping;
	}
}
