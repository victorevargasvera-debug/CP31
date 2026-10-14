using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A9 RID: 425
	public class ForeignKeyAssociationMultiplicityConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001773 RID: 6003 RVA: 0x0003E274 File Offset: 0x0003C474
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.AssociationType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.AssociationType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			global::System.Data.Entity.Core.Metadata.Edm.ReferentialConstraint constraint = item.Constraint;
			if (constraint == null)
			{
				return;
			}
			global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration navigationPropertyConfiguration = item.Annotations.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration;
			if (constraint.ToProperties.All((global::System.Data.Entity.Core.Metadata.Edm.EdmProperty p) => !p.Nullable))
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationEndMember principalEnd = item.GetOtherEnd(constraint.DependentEnd);
				global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty = model.ConceptualModel.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType et) => et.DeclaredNavigationProperties).SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty np) => np.ResultEnd == principalEnd);
				global::System.Reflection.PropertyInfo clrPropertyInfo;
				if (navigationPropertyConfiguration != null && navigationProperty != null && (clrPropertyInfo = navigationProperty.Annotations.GetClrPropertyInfo()) != null && ((clrPropertyInfo == navigationPropertyConfiguration.NavigationProperty && navigationPropertyConfiguration.RelationshipMultiplicity != null) || (clrPropertyInfo == navigationPropertyConfiguration.InverseNavigationProperty && navigationPropertyConfiguration.InverseEndKind != null)))
				{
					return;
				}
				principalEnd.RelationshipMultiplicity = global::System.Data.Entity.Core.Metadata.Edm.RelationshipMultiplicity.One;
			}
		}
	}
}
