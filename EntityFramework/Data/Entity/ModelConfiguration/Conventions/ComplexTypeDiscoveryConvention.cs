using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x0200019F RID: 415
	public class ComplexTypeDiscoveryConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600175A RID: 5978 RVA: 0x0003D61C File Offset: 0x0003B81C
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EdmModel item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EdmModel>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			foreach (var <>f__AnonymousType in (from entityType in item.EntityTypes
			where entityType.KeyProperties.Count == 0 && entityType.BaseType == null
			let entityTypeConfiguration = entityType.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration
			where (entityTypeConfiguration == null || (!entityTypeConfiguration.IsExplicitEntity && entityTypeConfiguration.IsStructuralConfigurationOnly)) && !entityType.Members.Where(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, bool>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty)).Any<global::System.Data.Entity.Core.Metadata.Edm.EdmMember>()
			let matchingAssociations = 
				from associationType in item.AssociationTypes
				where associationType.SourceEnd.GetEntityType() == entityType || associationType.TargetEnd.GetEntityType() == entityType
				let declaringEnd = (associationType.SourceEnd.GetEntityType() == entityType) ? associationType.SourceEnd : associationType.TargetEnd
				let declaringEntity = associationType.GetOtherEnd(declaringEnd).GetEntityType()
				let navigationProperties = 
					from global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty n in declaringEntity.Members.Where(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, bool>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty))
					where n.ResultEnd.GetEntityType() == entityType
					select n
				select new
				{
					DeclaringEnd = declaringEnd,
					AssociationType = associationType,
					DeclaringEntityType = declaringEntity,
					NavigationProperties = navigationProperties.ToList<global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty>()
				}
			where matchingAssociations.All(delegate(a)
			{
				if (a.AssociationType.Constraint == null && a.AssociationType.GetConfiguration() == null && !a.AssociationType.IsSelfReferencing() && a.DeclaringEnd.IsOptional())
				{
					return a.NavigationProperties.All((global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty n) => n.GetConfiguration() == null);
				}
				return false;
			})
			select new
			{
				EntityType = entityType,
				MatchingAssociations = matchingAssociations.ToList()
			}).ToList())
			{
				global::System.Data.Entity.Core.Metadata.Edm.ComplexType complexType = item.AddComplexType(<>f__AnonymousType.EntityType.Name, <>f__AnonymousType.EntityType.NamespaceName);
				foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmProperty member in <>f__AnonymousType.EntityType.DeclaredProperties)
				{
					complexType.AddMember(member);
				}
				foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item2 in <>f__AnonymousType.EntityType.Annotations)
				{
					complexType.GetMetadataProperties().Add(item2);
				}
				foreach (var <>f__AnonymousType2 in <>f__AnonymousType.MatchingAssociations)
				{
					foreach (global::System.Data.Entity.Core.Metadata.Edm.NavigationProperty navigationProperty in <>f__AnonymousType2.NavigationProperties)
					{
						if (<>f__AnonymousType2.DeclaringEntityType.Members.Where(new global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmMember, bool>(global::System.Data.Entity.Core.Metadata.Edm.Helper.IsNavigationProperty)).Contains(navigationProperty))
						{
							<>f__AnonymousType2.DeclaringEntityType.RemoveMember(navigationProperty);
							global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = <>f__AnonymousType2.DeclaringEntityType.AddComplexProperty(navigationProperty.Name, complexType);
							foreach (global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty item3 in navigationProperty.Annotations)
							{
								edmProperty.GetMetadataProperties().Add(item3);
							}
						}
					}
					item.RemoveAssociationType(<>f__AnonymousType2.AssociationType);
				}
				item.RemoveEntityType(<>f__AnonymousType.EntityType);
			}
		}
	}
}
