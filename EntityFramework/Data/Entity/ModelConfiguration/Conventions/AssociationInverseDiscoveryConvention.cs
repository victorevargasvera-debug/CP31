using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019E RID: 414
	public class AssociationInverseDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x06001757 RID: 5975 RVA: 0x0003D284 File Offset: 0x0003B484
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EdmModel item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			foreach (var <>f__AnonymousType in from g in (from a1 in item.AssociationTypes
			from a2 in item.AssociationTypes
			where a1 != a2
			where a1.SourceEnd.GetEntityType() == a2.TargetEnd.GetEntityType() && a1.TargetEnd.GetEntityType() == a2.SourceEnd.GetEntityType()
			let a1Configuration = a1.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration
			let a2Configuration = a2.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.NavigationPropertyConfiguration
			where (a1Configuration == null || (a1Configuration.InverseEndKind == null && a1Configuration.InverseNavigationProperty == null)) && (a2Configuration == null || (a2Configuration.InverseEndKind == null && a2Configuration.InverseNavigationProperty == null))
			select new
			{
				a1,
				a2
			}).Distinct((a, b) => a.a1 == b.a2 && a.a2 == b.a1).GroupBy((a, b) => a.a1.SourceEnd.GetEntityType() == b.a2.TargetEnd.GetEntityType() && a.a1.TargetEnd.GetEntityType() == b.a2.SourceEnd.GetEntityType())
			where g.Count() == 1
			select g.Single())
			{
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType = (<>f__AnonymousType.a2.GetConfiguration() != null) ? <>f__AnonymousType.a2 : <>f__AnonymousType.a1;
				global::System.Data.Entity.Core.Metadata.Edm.AssociationType associationType2 = (associationType == <>f__AnonymousType.a1) ? <>f__AnonymousType.a2 : <>f__AnonymousType.a1;
				associationType.SourceEnd.RelationshipMultiplicity = associationType2.TargetEnd.RelationshipMultiplicity;
				if (associationType2.Constraint != null)
				{
					associationType.Constraint = associationType2.Constraint;
					associationType.Constraint.FromRole = associationType.SourceEnd;
					associationType.Constraint.ToRole = associationType.TargetEnd;
				}
				global::System.Reflection.PropertyInfo clrPropertyInfo = associationType2.SourceEnd.GetClrPropertyInfo();
				if (clrPropertyInfo != null)
				{
					associationType.TargetEnd.SetClrPropertyInfo(clrPropertyInfo);
				}
				global::System.Data.Entity.ModelConfiguration.Conventions.AssociationInverseDiscoveryConvention.FixNavigationProperties(item, associationType, associationType2);
				item.RemoveAssociationType(associationType2);
			}
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0003D55C File Offset: 0x0003B75C
		private static void FixNavigationProperties(global::System.Data.Entity.Core.Metadata.Edm.EdmModel model, global::System.Data.Entity.Core.Metadata.Edm.AssociationType unifiedAssociation, global::System.Data.Entity.Core.Metadata.Edm.AssociationType redundantAssociation)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty> source = model.EntityTypes.SelectMany((global::System.Data.Entity.Core.Metadata.Edm.EntityType e) => e.NavigationProperties);
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, bool> <>9__1;
			global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty, bool> predicate;
			if ((predicate = <>9__1) == null)
			{
				predicate = (<>9__1 = ((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty np) => np.Association == redundantAssociation));
			}
			foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in source.Where(predicate))
			{
				navigationProperty.RelationshipType = unifiedAssociation;
				navigationProperty.FromEndMember = unifiedAssociation.TargetEnd;
				navigationProperty.ToEndMember = unifiedAssociation.SourceEnd;
			}
		}
	}
}
