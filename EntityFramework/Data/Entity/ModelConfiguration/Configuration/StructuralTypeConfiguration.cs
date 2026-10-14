using System;
using System.ComponentModel;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Spatial;
using System.Linq.Expressions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001FC RID: 508
	public abstract class StructuralTypeConfiguration<TStructuralType> where TStructuralType : class
	{
		// Token: 0x06001ABD RID: 6845 RVA: 0x00047789 File Offset: 0x00045989
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration Property<T>(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, T>> propertyExpression) where T : struct
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x00047797 File Offset: 0x00045997
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration Property<T>(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, T?>> propertyExpression) where T : struct
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000477A5 File Offset: 0x000459A5
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.Data.Entity.Hierarchy.HierarchyId>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000477B3 File Offset: 0x000459B3
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x000477C1 File Offset: 0x000459C1
		public global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.PrimitivePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x000477CF File Offset: 0x000459CF
		public global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, string>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.StringPropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.StringPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC3 RID: 6851 RVA: 0x000477DD File Offset: 0x000459DD
		public global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, byte[]>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.BinaryPropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.BinaryPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC4 RID: 6852 RVA: 0x000477EB File Offset: 0x000459EB
		public global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, decimal>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC5 RID: 6853 RVA: 0x000477F9 File Offset: 0x000459F9
		public global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, decimal?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DecimalPropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DecimalPropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC6 RID: 6854 RVA: 0x00047807 File Offset: 0x00045A07
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.DateTime>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00047815 File Offset: 0x00045A15
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.DateTime?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00047823 File Offset: 0x00045A23
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.DateTimeOffset>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00047831 File Offset: 0x00045A31
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.DateTimeOffset?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0004783F File Offset: 0x00045A3F
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.TimeSpan>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004784D File Offset: 0x00045A4D
		public global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration Property(global::System.Linq.Expressions.Expression<global::System.Func<TStructuralType, global::System.TimeSpan?>> propertyExpression)
		{
			return new global::System.Data.Entity.ModelConfiguration.Configuration.DateTimePropertyConfiguration(this.Property<global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.DateTimePropertyConfiguration>(propertyExpression));
		}

		// Token: 0x17000607 RID: 1543
		// (get) Token: 0x06001ACC RID: 6860
		internal abstract global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration Configuration { get; }

		// Token: 0x06001ACD RID: 6861
		internal abstract TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Linq.Expressions.LambdaExpression lambdaExpression) where TPrimitivePropertyConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.PrimitivePropertyConfiguration, new();

		// Token: 0x06001ACE RID: 6862 RVA: 0x0004785B File Offset: 0x00045A5B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x00047863 File Offset: 0x00045A63
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0004786C File Offset: 0x00045A6C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00047874 File Offset: 0x00045A74
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
