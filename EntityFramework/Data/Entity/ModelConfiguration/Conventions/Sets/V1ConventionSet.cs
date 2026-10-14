using System;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions.Sets
{
	// Token: 0x020001BB RID: 443
	internal static class V1ConventionSet
	{
		// Token: 0x170005C6 RID: 1478
		// (get) Token: 0x060017AE RID: 6062 RVA: 0x0003F417 File Offset: 0x0003D617
		public static global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet Conventions
		{
			get
			{
				return global::System.Data.Entity.ModelConfiguration.Conventions.Sets.V1ConventionSet._conventions;
			}
		}

		// Token: 0x04000A40 RID: 2624
		private static readonly global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet _conventions = new global::System.Data.Entity.ModelConfiguration.Conventions.Sets.ConventionSet(new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
		{
			new global::System.Data.Entity.ModelConfiguration.Conventions.NotMappedTypeAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ComplexTypeAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.TableAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.NotMappedPropertyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.KeyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.RequiredPrimitivePropertyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.RequiredNavigationPropertyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.TimestampAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ConcurrencyCheckAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.DatabaseGeneratedAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.MaxLengthAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.StringLengthAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ColumnAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.IndexAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.InversePropertyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyPrimitivePropertyAttributeConvention()
		}.Reverse<global::System.Data.Entity.ModelConfiguration.Conventions.IConvention>(), new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
		{
			new global::System.Data.Entity.ModelConfiguration.Conventions.IdKeyDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.AssociationInverseDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyNavigationPropertyAttributeConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.OneToOneConstraintIntroductionConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.NavigationPropertyNameForeignKeyDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.PrimaryKeyNameForeignKeyDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.TypeNameForeignKeyDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyAssociationMultiplicityConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.OneToManyCascadeDeleteConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ComplexTypeDiscoveryConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.StoreGeneratedIdentityKeyConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.PluralizingEntitySetNameConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.DeclaredPropertyOrderingConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.SqlCePropertyMaxLengthConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.PropertyMaxLengthConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.DecimalPropertyConvention()
		}, new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
		{
			new global::System.Data.Entity.ModelConfiguration.Conventions.ManyToManyCascadeDeleteConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.MappingInheritedPropertiesSupportConvention()
		}, new global::System.Data.Entity.ModelConfiguration.Conventions.IConvention[]
		{
			new global::System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConvention(),
			new global::System.Data.Entity.ModelConfiguration.Conventions.ForeignKeyIndexConvention()
		});
	}
}
