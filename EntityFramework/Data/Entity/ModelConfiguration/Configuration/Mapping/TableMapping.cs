using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000219 RID: 537
	[global::System.Diagnostics.DebuggerDisplay("{Table.Name}")]
	internal class TableMapping
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x0005018D File Offset: 0x0004E38D
		public TableMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityType table)
		{
			this._table = table;
			this._entityTypes = new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex();
			this._columns = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping>();
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x000501B2 File Offset: 0x0004E3B2
		public global::System.Data.Entity.Core.Metadata.Edm.EntityType Table
		{
			get
			{
				return this._table;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001C49 RID: 7241 RVA: 0x000501BA File Offset: 0x0004E3BA
		public global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex EntityTypes
		{
			get
			{
				return this._entityTypes;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x000501C2 File Offset: 0x0004E3C2
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping> ColumnMappings
		{
			get
			{
				return this._columns;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x000501CC File Offset: 0x0004E3CC
		public void AddEntityTypeMappingFragment(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Mapping.MappingFragment fragment)
		{
			this._entityTypes.Add(entitySet, entityType);
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty defaultDiscriminator = fragment.GetDefaultDiscriminator();
			using (global::System.Collections.Generic.IEnumerator<global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder> enumerator = fragment.ColumnMappings.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder cm = enumerator.Current;
					this.FindOrCreateColumnMapping(cm.ColumnProperty).AddMapping(entityType, cm.PropertyPath, from cc in fragment.ColumnConditions
					where cc.Column == cm.ColumnProperty
					select cc, defaultDiscriminator == cm.ColumnProperty);
				}
			}
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> columnConditions = fragment.ColumnConditions;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping, bool> predicate;
			if ((predicate = <>9__1) == null)
			{
				predicate = (<>9__1 = ((global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping cc) => fragment.ColumnMappings.All((global::System.Data.Entity.Core.Mapping.ColumnMappingBuilder pm) => pm.ColumnProperty != cc.Column)));
			}
			foreach (global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping conditionPropertyMapping in columnConditions.Where(predicate))
			{
				this.FindOrCreateColumnMapping(conditionPropertyMapping.Column).AddMapping(entityType, null, new global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping[]
				{
					conditionPropertyMapping
				}, defaultDiscriminator == conditionPropertyMapping.Column);
			}
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00050324 File Offset: 0x0004E524
		private global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping FindOrCreateColumnMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping columnMapping = this._columns.SingleOrDefault((global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping c) => c.Column == column);
			if (columnMapping == null)
			{
				columnMapping = new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping(column);
				this._columns.Add(columnMapping);
			}
			return columnMapping;
		}

		// Token: 0x04000AEC RID: 2796
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntityType _table;

		// Token: 0x04000AED RID: 2797
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.SortedEntityTypeIndex _entityTypes;

		// Token: 0x04000AEE RID: 2798
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ColumnMapping> _columns;
	}
}
