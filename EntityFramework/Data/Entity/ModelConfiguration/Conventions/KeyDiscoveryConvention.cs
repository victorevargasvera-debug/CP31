using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AD RID: 429
	public abstract class KeyDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600177E RID: 6014 RVA: 0x0003E888 File Offset: 0x0003CA88
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.KeyProperties.Count > 0 || item.BaseType != null)
			{
				return;
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty in this.MatchKeyProperty(item, item.GetDeclaredPrimitiveProperties()))
			{
				edmProperty.Nullable = false;
				item.AddKeyMember(edmProperty);
			}
		}

		// Token: 0x0600177F RID: 6015
		protected abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> MatchKeyProperty(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty> primitiveProperties);
	}
}
