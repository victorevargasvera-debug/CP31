using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000533 RID: 1331
	public sealed class FunctionImportEntityTypeMapping : global::System.Data.Entity.Core.Mapping.FunctionImportStructuralTypeMapping
	{
		// Token: 0x060041B8 RID: 16824 RVA: 0x000DCF8E File Offset: 0x000DB18E
		public FunctionImportEntityTypeMapping(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> isOfTypeEntityTypes, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> properties, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> conditions) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType>>(isOfTypeEntityTypes, "isOfTypeEntityTypes"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType>>(entityTypes, "entityTypes"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>>(conditions, "conditions"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping>>(properties, "properties"), global::System.Data.Entity.Core.Mapping.LineInfo.Empty)
		{
		}

		// Token: 0x060041B9 RID: 16825 RVA: 0x000DCFC8 File Offset: 0x000DB1C8
		internal FunctionImportEntityTypeMapping(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> isOfTypeEntityTypes, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> entityTypes, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> conditions, global::System.Collections.ObjectModel.Collection<global::System.Data.Entity.Core.Mapping.FunctionImportReturnTypePropertyMapping> columnsRenameList, global::System.Data.Entity.Core.Mapping.LineInfo lineInfo) : base(columnsRenameList, lineInfo)
		{
			this._isOfTypeEntityTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(isOfTypeEntityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
			this._entityTypes = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityTypes.ToList<global::System.Data.Entity.Core.Metadata.Edm.EntityType>());
			this._conditions = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>(conditions.ToList<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition>());
		}

		// Token: 0x17000D00 RID: 3328
		// (get) Token: 0x060041BA RID: 16826 RVA: 0x000DD007 File Offset: 0x000DB207
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> EntityTypes
		{
			get
			{
				return this._entityTypes;
			}
		}

		// Token: 0x17000D01 RID: 3329
		// (get) Token: 0x060041BB RID: 16827 RVA: 0x000DD00F File Offset: 0x000DB20F
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> IsOfTypeEntityTypes
		{
			get
			{
				return this._isOfTypeEntityTypes;
			}
		}

		// Token: 0x17000D02 RID: 3330
		// (get) Token: 0x060041BC RID: 16828 RVA: 0x000DD017 File Offset: 0x000DB217
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> Conditions
		{
			get
			{
				return this._conditions;
			}
		}

		// Token: 0x060041BD RID: 16829 RVA: 0x000DD01F File Offset: 0x000DB21F
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._conditions);
			base.SetReadOnly();
		}

		// Token: 0x060041BE RID: 16830 RVA: 0x000DD034 File Offset: 0x000DB234
		internal global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntityType> GetMappedEntityTypes(global::System.Data.Entity.Core.Metadata.Edm.ItemCollection itemCollection)
		{
			return this.EntityTypes.Concat(this.IsOfTypeEntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType) => global::System.Data.Entity.Core.Common.Utils.MetadataHelper.GetTypeAndSubtypesOf(entityType, itemCollection, false).Cast<global::System.Data.Entity.Core.Metadata.Edm.EntityType>()));
		}

		// Token: 0x060041BF RID: 16831 RVA: 0x000DD070 File Offset: 0x000DB270
		internal global::System.Collections.Generic.IEnumerable<string> GetDiscriminatorColumns()
		{
			return from condition in this.Conditions
			select condition.ColumnName;
		}

		// Token: 0x040016C7 RID: 5831
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> _entityTypes;

		// Token: 0x040016C8 RID: 5832
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Metadata.Edm.EntityType> _isOfTypeEntityTypes;

		// Token: 0x040016C9 RID: 5833
		private readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.FunctionImportEntityTypeMappingCondition> _conditions;
	}
}
