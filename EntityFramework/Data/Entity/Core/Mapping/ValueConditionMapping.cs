using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000561 RID: 1377
	public class ValueConditionMapping : global::System.Data.Entity.Core.Mapping.ConditionPropertyMapping
	{
		// Token: 0x06004354 RID: 17236 RVA: 0x000E68DC File Offset: 0x000E4ADC
		public ValueConditionMapping(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty propertyOrColumn, object value) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>(propertyOrColumn, "propertyOrColumn"), global::System.Data.Entity.Utilities.Check.NotNull<object>(value, "value"), null)
		{
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x000E690E File Offset: 0x000E4B0E
		public new object Value
		{
			get
			{
				return base.Value;
			}
		}
	}
}
