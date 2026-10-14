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
	// Token: 0x020001B1 RID: 433
	public class PluralizingEntitySetNameConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001788 RID: 6024 RVA: 0x0003EB88 File Offset: 0x0003CD88
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntitySet item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.GetConfiguration() == null)
			{
				item.Name = model.ConceptualModel.GetEntitySets().Except(new global::System.Data.Entity.Core.Metadata.Edm.EntitySet[]
				{
					item
				}).UniquifyName(global::System.Data.Entity.ModelConfiguration.Conventions.PluralizingEntitySetNameConvention._pluralizationService.Pluralize(item.Name));
			}
		}

		// Token: 0x04000A36 RID: 2614
		private static readonly global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService _pluralizationService = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.Pluralization.IPluralizationService>();
	}
}
