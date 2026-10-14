using System;
using System.ComponentModel;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Core
{
	// Token: 0x020002D2 RID: 722
	[global::System.AttributeUsage(global::System.AttributeTargets.All)]
	internal sealed class EntityResCategoryAttribute : global::System.ComponentModel.CategoryAttribute
	{
		// Token: 0x060022F5 RID: 8949 RVA: 0x0006226B File Offset: 0x0006046B
		public EntityResCategoryAttribute(string category) : base(category)
		{
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00062274 File Offset: 0x00060474
		protected override string GetLocalizedString(string value)
		{
			return global::System.Data.Entity.Resources.EntityRes.GetString(value);
		}
	}
}
