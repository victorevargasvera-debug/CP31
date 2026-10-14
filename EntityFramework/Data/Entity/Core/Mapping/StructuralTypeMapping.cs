using System;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055E RID: 1374
	public abstract class StructuralTypeMapping : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06004341 RID: 17217
		public abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.PropertyMapping> PropertyMappings { get; }

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06004342 RID: 17218
		public abstract global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping> Conditions { get; }

		// Token: 0x06004343 RID: 17219
		public abstract void AddPropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping);

		// Token: 0x06004344 RID: 17220
		public abstract void RemovePropertyMapping(global::System.Data.Entity.Core.Mapping.PropertyMapping propertyMapping);

		// Token: 0x06004345 RID: 17221
		public abstract void AddCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition);

		// Token: 0x06004346 RID: 17222
		public abstract void RemoveCondition(global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping condition);
	}
}
