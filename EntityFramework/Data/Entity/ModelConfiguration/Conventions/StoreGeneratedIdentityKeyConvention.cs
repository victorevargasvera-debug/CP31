using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001B5 RID: 437
	public class StoreGeneratedIdentityKeyConvention : global::System.Data.Entity.ModelConfiguration.Conventions.IConceptualModelConvention<global::System.Data.Entity.Core.Metadata.Edm.EntityType>, global::System.Data.Entity.ModelConfiguration.Conventions.IConvention
	{
		// Token: 0x0600179B RID: 6043 RVA: 0x0003F070 File Offset: 0x0003D270
		public virtual void Apply(global::System.Data.Entity.Core.Metadata.Edm.EntityType item, global::System.Data.Entity.Infrastructure.DbModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.EntityType>(item, "item");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbModel>(model, "model");
			if (item.BaseType == null && item.KeyProperties.Count == 1)
			{
				if (!(from <>h__TransparentIdentifier0 in (from p in item.DeclaredProperties
				select new
				{
					p = p,
					sgp = p.GetStoreGeneratedPattern()
				}).Where(delegate(<>h__TransparentIdentifier0)
				{
					if (<>h__TransparentIdentifier0.sgp != null)
					{
						global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern? sgp = <>h__TransparentIdentifier0.sgp;
						global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern storeGeneratedPattern = global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity;
						return sgp.GetValueOrDefault() == storeGeneratedPattern & sgp != null;
					}
					return false;
				})
				select <>h__TransparentIdentifier0.sgp).Any<global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern?>())
				{
					global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property = item.KeyProperties.Single<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty>();
					if (property.GetStoreGeneratedPattern() == null && property.PrimitiveType != null && global::System.Data.Entity.ModelConfiguration.Conventions.StoreGeneratedIdentityKeyConvention._applicableTypes.Contains(property.PrimitiveType.PrimitiveTypeKind) && !model.ConceptualModel.AssociationTypes.Any((global::System.Data.Entity.Core.Metadata.Edm.AssociationType a) => global::System.Data.Entity.ModelConfiguration.Conventions.StoreGeneratedIdentityKeyConvention.IsNonTableSplittingForeignKey(a, property)) && !global::System.Data.Entity.ModelConfiguration.Conventions.StoreGeneratedIdentityKeyConvention.ParentOfTpc(item, model.ConceptualModel))
					{
						property.SetStoreGeneratedPattern(global::System.Data.Entity.Core.Metadata.Edm.StoreGeneratedPattern.Identity);
					}
				}
			}
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0003F1BC File Offset: 0x0003D3BC
		private static bool IsNonTableSplittingForeignKey(global::System.Data.Entity.Core.Metadata.Edm.AssociationType association, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty property)
		{
			if (association.Constraint != null && association.Constraint.ToProperties.Contains(property))
			{
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration = (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)association.SourceEnd.GetEntityType().GetConfiguration();
				global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration2 = (global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration)association.TargetEnd.GetEntityType().GetConfiguration();
				return entityTypeConfiguration == null || entityTypeConfiguration2 == null || entityTypeConfiguration.GetTableName() == null || entityTypeConfiguration2.GetTableName() == null || !entityTypeConfiguration.GetTableName().Equals(entityTypeConfiguration2.GetTableName());
			}
			return false;
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x0003F240 File Offset: 0x0003D440
		private static bool ParentOfTpc(global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EdmModel model)
		{
			return (from et in model.EntityTypes
			where et.GetRootType() == entityType
			select et into e
			let configuration = e.GetConfiguration() as global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration
			where configuration != null && configuration.IsMappingAnyInheritedProperty(e)
			select e).Any<global::System.Data.Entity.Core.Metadata.Edm.EntityType>();
		}

		// Token: 0x04000A3B RID: 2619
		private static readonly global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind> _applicableTypes = new global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind[]
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int16,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32,
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int64
		};
	}
}
