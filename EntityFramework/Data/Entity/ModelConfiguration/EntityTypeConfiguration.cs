using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration
{
	// Token: 0x02000156 RID: 342
	public class EntityTypeConfiguration<TEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.StructuralTypeConfiguration<TEntityType> where TEntityType : class
	{
		// Token: 0x060015D6 RID: 5590 RVA: 0x000379E3 File Offset: 0x00035BE3
		public EntityTypeConfiguration() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration(typeof(TEntityType)))
		{
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000379FA File Offset: 0x00035BFA
		internal EntityTypeConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration entityTypeConfiguration)
		{
			this._entityTypeConfiguration = entityTypeConfiguration;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x060015D8 RID: 5592 RVA: 0x00037A09 File Offset: 0x00035C09
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration Configuration
		{
			get
			{
				return this._entityTypeConfiguration;
			}
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00037A11 File Offset: 0x00035C11
		internal override TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Linq.Expressions.LambdaExpression lambdaExpression)
		{
			return this.Configuration.Property<TPrimitivePropertyConfiguration>(lambdaExpression.GetComplexPropertyAccess(), delegate()
			{
				TPrimitivePropertyConfiguration tprimitivePropertyConfiguration = global::System.Activator.CreateInstance<TPrimitivePropertyConfiguration>();
				tprimitivePropertyConfiguration.OverridableConfigurationParts = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.None;
				return tprimitivePropertyConfiguration;
			});
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00037A44 File Offset: 0x00035C44
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> HasKey<TKey>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TKey>> keyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TKey>>>(keyExpression, "keyExpression");
			this._entityTypeConfiguration.Key(from p in keyExpression.GetSimplePropertyAccessList()
			select p.Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00037A94 File Offset: 0x00035C94
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> HasKey<TKey>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TKey>> keyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration> buildAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TKey>>>(keyExpression, "keyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration>>(buildAction, "buildAction");
			this._entityTypeConfiguration.Key(from p in keyExpression.GetSimplePropertyAccessList()
			select p.Single<global::System.Reflection.PropertyInfo>());
			buildAction(new global::System.Data.Entity.ModelConfiguration.Configuration.PrimaryKeyIndexConfiguration(this._entityTypeConfiguration.ConfigureKey()));
			return this;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00037B08 File Offset: 0x00035D08
		public global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration HasIndex<TIndex>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TIndex>> indexExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TIndex>>>(indexExpression, "indexExpression");
			global::System.Collections.Generic.IEnumerable<global::System.Reflection.PropertyInfo> components = from p in indexExpression.GetSimplePropertyAccessList()
			select p.Single<global::System.Reflection.PropertyInfo>();
			return new global::System.Data.Entity.ModelConfiguration.Configuration.IndexConfiguration(this._entityTypeConfiguration.Index(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(components)));
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00037B62 File Offset: 0x00035D62
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> HasEntitySetName(string entitySetName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySetName, "entitySetName");
			this._entityTypeConfiguration.EntitySetName = entitySetName;
			return this;
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00037B7D File Offset: 0x00035D7D
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> Ignore<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			this.Configuration.Ignore(propertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x060015DF RID: 5599 RVA: 0x00037BA4 File Offset: 0x00035DA4
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(tableName);
			this._entityTypeConfiguration.ToTable(databaseName.Name, databaseName.Schema);
			return this;
		}

		// Token: 0x060015E0 RID: 5600 RVA: 0x00037BDC File Offset: 0x00035DDC
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._entityTypeConfiguration.ToTable(tableName, schemaName);
			return this;
		}

		// Token: 0x060015E1 RID: 5601 RVA: 0x00037BF8 File Offset: 0x00035DF8
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> HasTableAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._entityTypeConfiguration.SetAnnotation(name, value);
			return this;
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x00037C14 File Offset: 0x00035E14
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> MapToStoredProcedures()
		{
			this._entityTypeConfiguration.MapToStoredProcedures();
			return this;
		}

		// Token: 0x060015E3 RID: 5603 RVA: 0x00037C24 File Offset: 0x00035E24
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> MapToStoredProcedures(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType>> modificationStoredProcedureMappingConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType>>>(modificationStoredProcedureMappingConfigurationAction, "modificationStoredProcedureMappingConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType> modificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<TEntityType>();
			modificationStoredProcedureMappingConfigurationAction(modificationStoredProceduresConfiguration);
			this._entityTypeConfiguration.MapToStoredProcedures(modificationStoredProceduresConfiguration.Configuration, true);
			return this;
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x00037C60 File Offset: 0x00035E60
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> Map(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType>> entityMappingConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType>>>(entityMappingConfigurationAction, "entityMappingConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType> entityMappingConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType>();
			entityMappingConfigurationAction(entityMappingConfiguration);
			this._entityTypeConfiguration.AddMappingConfiguration(entityMappingConfiguration.EntityMappingConfigurationInstance, true);
			return this;
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x00037C9C File Offset: 0x00035E9C
		public global::System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TEntityType> Map<TDerived>(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TDerived>> derivedTypeMapConfigurationAction) where TDerived : class, TEntityType
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TDerived>>>(derivedTypeMapConfigurationAction, "derivedTypeMapConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TDerived> entityMappingConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TDerived>();
			global::System.Data.Entity.Utilities.DatabaseName tableName = this._entityTypeConfiguration.GetTableName();
			if (tableName != null)
			{
				entityMappingConfiguration.EntityMappingConfigurationInstance.TableName = tableName;
			}
			derivedTypeMapConfigurationAction(entityMappingConfiguration);
			if (typeof(TDerived) == typeof(TEntityType))
			{
				this._entityTypeConfiguration.AddMappingConfiguration(entityMappingConfiguration.EntityMappingConfigurationInstance, true);
			}
			else
			{
				this._entityTypeConfiguration.AddSubTypeMappingConfiguration(typeof(TDerived), entityMappingConfiguration.EntityMappingConfigurationInstance);
			}
			return this;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00037D28 File Offset: 0x00035F28
		public global::System.Data.Entity.ModelConfiguration.Configuration.OptionalNavigationPropertyConfiguration<TEntityType, TTargetEntity> HasOptional<TTargetEntity>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TTargetEntity>>>(navigationPropertyExpression, "navigationPropertyExpression");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.OptionalNavigationPropertyConfiguration<TEntityType, TTargetEntity>(this._entityTypeConfiguration.Navigation(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>()));
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00037D51 File Offset: 0x00035F51
		public global::System.Data.Entity.ModelConfiguration.Configuration.RequiredNavigationPropertyConfiguration<TEntityType, TTargetEntity> HasRequired<TTargetEntity>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TTargetEntity>>>(navigationPropertyExpression, "navigationPropertyExpression");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.RequiredNavigationPropertyConfiguration<TEntityType, TTargetEntity>(this._entityTypeConfiguration.Navigation(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>()));
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00037D7A File Offset: 0x00035F7A
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyNavigationPropertyConfiguration<TEntityType, TTargetEntity> HasMany<TTargetEntity>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Collections.Generic.ICollection<TTargetEntity>>> navigationPropertyExpression) where TTargetEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Collections.Generic.ICollection<TTargetEntity>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ManyNavigationPropertyConfiguration<TEntityType, TTargetEntity>(this._entityTypeConfiguration.Navigation(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>()));
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00037DA3 File Offset: 0x00035FA3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00037DAB File Offset: 0x00035FAB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00037DB4 File Offset: 0x00035FB4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00037DBC File Offset: 0x00035FBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040009F4 RID: 2548
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration _entityTypeConfiguration;
	}
}
