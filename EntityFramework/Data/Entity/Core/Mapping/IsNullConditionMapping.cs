using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000544 RID: 1348
	public class IsNullConditionMapping : global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping
	{
		// Token: 0x06004222 RID: 16930 RVA: 0x000DFB46 File Offset: 0x000DDD46
		public IsNullConditionMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyOrColumn, bool isNull) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(propertyOrColumn, "propertyOrColumn"), null, new bool?(isNull))
		{
		}

		// Token: 0x17000D19 RID: 3353
		// (get) Token: 0x06004223 RID: 16931 RVA: 0x000DFB60 File Offset: 0x000DDD60
		public new bool IsNull
		{
			get
			{
				return base.IsNull.Value;
			}
		}
	}
}
