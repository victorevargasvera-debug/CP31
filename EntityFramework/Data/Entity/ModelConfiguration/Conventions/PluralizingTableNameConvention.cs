using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Pluralization;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A6 RID: 422
	public class PluralizingTableNameConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IStoreModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600176C RID: 5996 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			this._pluralizationService = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>();
			if (item.GetTableName() == null)
			{
				global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet = model.StoreModel.GetEntitySet(item);
				entitySet.Table = (from n in (from es in model.StoreModel.GetEntitySets()
				where es.Schema == entitySet.Schema
				select es).Except(new global::System.Data.Entity.Core.Metadata.Edm.EntitySet[]
				{
					entitySet
				})
				select n.Table).Uniquify(this._pluralizationService.Pluralize(entitySet.Table));
			}
		}

		// Token: 0x04000A32 RID: 2610
		private global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService _pluralizationService = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>();
	}
}
