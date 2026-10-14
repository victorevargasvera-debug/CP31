using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Mapping;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001DE RID: 478
	public class EntityMappingConfiguration<TEntityType> where TEntityType : class
	{
		// Token: 0x0600190F RID: 6415 RVA: 0x00042BE5 File Offset: 0x00040DE5
		public EntityMappingConfiguration() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration())
		{
		}

		// Token: 0x06001910 RID: 6416 RVA: 0x00042BF2 File Offset: 0x00040DF2
		internal EntityMappingConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration entityMappingConfiguration)
		{
			this._entityMappingConfiguration = entityMappingConfiguration;
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001911 RID: 6417 RVA: 0x00042C01 File Offset: 0x00040E01
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration EntityMappingConfigurationInstance
		{
			get
			{
				return this._entityMappingConfiguration;
			}
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00042C09 File Offset: 0x00040E09
		public void Properties<TObject>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TObject>> propertiesExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TObject>>>(propertiesExpression, "propertiesExpression");
			this._entityMappingConfiguration.Properties = propertiesExpression.GetComplexPropertyAccessList().ToList<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath>();
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00042C2D File Offset: 0x00040E2D
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property<T>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, T>> propertyExpression) where T : struct
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00042C3B File Offset: 0x00040E3B
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property<T>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, T?>> propertyExpression) where T : struct
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00042C49 File Offset: 0x00040E49
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00042C57 File Offset: 0x00040E57
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00042C65 File Offset: 0x00040E65
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00042C73 File Offset: 0x00040E73
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00042C81 File Offset: 0x00040E81
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, decimal>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00042C8F File Offset: 0x00040E8F
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, decimal?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00042C9D File Offset: 0x00040E9D
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.DateTime>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x00042CAB File Offset: 0x00040EAB
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.DateTime?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x00042CB9 File Offset: 0x00040EB9
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.DateTimeOffset>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x00042CC7 File Offset: 0x00040EC7
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.DateTimeOffset?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x0600191F RID: 6431 RVA: 0x00042CD5 File Offset: 0x00040ED5
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.TimeSpan>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001920 RID: 6432 RVA: 0x00042CE3 File Offset: 0x00040EE3
		public global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.TimeSpan?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PropertyMappingConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001921 RID: 6433 RVA: 0x00042CF1 File Offset: 0x00040EF1
		internal TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Linq.Expressions.LambdaExpression lambdaExpression) where TPrimitivePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration, new()
		{
			return this._entityMappingConfiguration.Property<TPrimitivePropertyConfiguration>(lambdaExpression.GetComplexPropertyAccess(), delegate()
			{
				TPrimitivePropertyConfiguration tprimitivePropertyConfiguration = global::System.Activator.CreateInstance<TPrimitivePropertyConfiguration>();
				tprimitivePropertyConfiguration.OverridableConfigurationParts = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.None;
				return tprimitivePropertyConfiguration;
			});
		}

		// Token: 0x06001922 RID: 6434 RVA: 0x00042D23 File Offset: 0x00040F23
		public global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType> MapInheritedProperties()
		{
			this._entityMappingConfiguration.MapInheritedProperties = true;
			return this;
		}

		// Token: 0x06001923 RID: 6435 RVA: 0x00042D34 File Offset: 0x00040F34
		public global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType> ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			global::System.Data.Entity.Utilities.DatabaseName databaseName = global::System.Data.Entity.Utilities.DatabaseName.Parse(tableName);
			this.ToTable(databaseName.Name, databaseName.Schema);
			return this;
		}

		// Token: 0x06001924 RID: 6436 RVA: 0x00042D68 File Offset: 0x00040F68
		public global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType> ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._entityMappingConfiguration.TableName = new global::System.Data.Entity.Utilities.DatabaseName(tableName, schemaName);
			return this;
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x00042D89 File Offset: 0x00040F89
		public global::System.Data.Entity.ModelConfiguration.Configuration.EntityMappingConfiguration<TEntityType> HasTableAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._entityMappingConfiguration.SetAnnotation(name, value);
			return this;
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x00042DA5 File Offset: 0x00040FA5
		public global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration Requires(string discriminator)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(discriminator, "discriminator");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.ValueConditionConfiguration(this._entityMappingConfiguration, discriminator);
		}

		// Token: 0x06001927 RID: 6439 RVA: 0x00042DBF File Offset: 0x00040FBF
		public global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration Requires<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(property, "property");
			return new global::System.Data.Entity.ModelConfiguration.Configuration.NotNullConditionConfiguration(this._entityMappingConfiguration, property.GetComplexPropertyAccess());
		}

		// Token: 0x06001928 RID: 6440 RVA: 0x00042DDE File Offset: 0x00040FDE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001929 RID: 6441 RVA: 0x00042DE6 File Offset: 0x00040FE6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600192A RID: 6442 RVA: 0x00042DEF File Offset: 0x00040FEF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600192B RID: 6443 RVA: 0x00042DF7 File Offset: 0x00040FF7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A74 RID: 2676
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.EntityMappingConfiguration _entityMappingConfiguration;
	}
}
