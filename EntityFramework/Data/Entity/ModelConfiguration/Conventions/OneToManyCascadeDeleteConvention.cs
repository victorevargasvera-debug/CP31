using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001AF RID: 431
	public class OneToManyCascadeDeleteConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001784 RID: 6020 RVA: 0x0003E9C8 File Offset: 0x0003CBC8
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.IsSelfReferencing())
			{
				return;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration = item.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration;
			if (navigationPropertyConfiguration != null && navigationPropertyConfiguration.DeleteAction != null)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember associationEndMember = null;
			if (item.IsRequiredToMany())
			{
				associationEndMember = item.SourceEnd;
			}
			else if (item.IsManyToRequired())
			{
				associationEndMember = item.TargetEnd;
			}
			if (associationEndMember != null)
			{
				associationEndMember.DeleteBehavior = global::System.Data.Entity.Core.Metadata.Edm.OperationAction.Cascade;
			}
		}
	}
}
