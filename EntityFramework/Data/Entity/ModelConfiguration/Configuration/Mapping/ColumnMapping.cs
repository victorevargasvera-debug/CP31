using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000215 RID: 533
	[global::System.Diagnostics.DebuggerDisplay("{Column.Name}")]
	internal class ColumnMapping
	{
		// Token: 0x06001C26 RID: 7206 RVA: 0x0004EDA6 File Offset: 0x0004CFA6
		public ColumnMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column)
		{
			this._column = column;
			this._propertyMappings = new global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification>();
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001C27 RID: 7207 RVA: 0x0004EDC0 File Offset: 0x0004CFC0
		public global::System.Data.Entity.Core.Metadata.Edm.EdmProperty Column
		{
			get
			{
				return this._column;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
		public global::System.Collections.Generic.IList<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification> PropertyMappings
		{
			get
			{
				return this._propertyMappings;
			}
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0004EDD0 File Offset: 0x0004CFD0
		public void AddMapping(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> propertyPath, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> conditions, bool isDefaultDiscriminatorCondition)
		{
			this._propertyMappings.Add(new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification(entityType, propertyPath, conditions.ToList<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping>(), isDefaultDiscriminatorCondition));
		}

		// Token: 0x04000AE1 RID: 2785
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmProperty _column;

		// Token: 0x04000AE2 RID: 2786
		private readonly global::System.Collections.Generic.List<global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.PropertyMappingSpecification> _propertyMappings;
	}
}
