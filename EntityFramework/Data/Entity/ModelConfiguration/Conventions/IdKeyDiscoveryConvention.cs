using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AC RID: 428
	public class IdKeyDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.KeyDiscoveryConvention
	{
		// Token: 0x0600177C RID: 6012 RVA: 0x0003E7E0 File Offset: 0x0003C9E0
		protected override global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> MatchKeyProperty(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> primitiveProperties)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(entityType, "entityType");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>>(primitiveProperties, "primitiveProperties");
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> enumerable = from p in primitiveProperties
			where "Id".Equals(p.Name, global::System.StringComparison.OrdinalIgnoreCase)
			select p;
			if (!enumerable.Any<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>())
			{
				enumerable = from p in primitiveProperties
				where (entityType.Name + "Id").Equals(p.Name, global::System.StringComparison.OrdinalIgnoreCase)
				select p;
			}
			if (enumerable.Count<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>() > 1)
			{
				throw global::System.Data.Entity.Resources.Error.MultiplePropertiesMatchedAsKeys(enumerable.First<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>().Name, entityType.Name);
			}
			return enumerable;
		}

		// Token: 0x04000A35 RID: 2613
		private const string Id = "Id";
	}
}
