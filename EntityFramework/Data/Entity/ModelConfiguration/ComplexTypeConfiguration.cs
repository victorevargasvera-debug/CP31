using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration
{
	// Token: 0x02000155 RID: 341
	public class ComplexTypeConfiguration<TComplexType> : global::System.Data.Entity.ModelConfiguration.Configuration.StructuralTypeConfiguration<TComplexType> where TComplexType : class
	{
		// Token: 0x060015CD RID: 5581 RVA: 0x0003793D File Offset: 0x00035B3D
		public ComplexTypeConfiguration() : this(new global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration(typeof(TComplexType)))
		{
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00037954 File Offset: 0x00035B54
		public global::System.Data.Entity.ModelConfiguration.ComplexTypeConfiguration<TComplexType> Ignore<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TComplexType, TProperty>> propertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TComplexType, TProperty>>>(propertyExpression, "propertyExpression");
			this.Configuration.Ignore(propertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00037979 File Offset: 0x00035B79
		internal ComplexTypeConfiguration(global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration configuration)
		{
			this._complexTypeConfiguration = configuration;
		}

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x060015D0 RID: 5584 RVA: 0x00037988 File Offset: 0x00035B88
		internal override global::System.Data.Entity.ModelConfiguration.Configuration.Types.StructuralTypeConfiguration Configuration
		{
			get
			{
				return this._complexTypeConfiguration;
			}
		}

		// Token: 0x060015D1 RID: 5585 RVA: 0x00037990 File Offset: 0x00035B90
		internal override TPrimitivePropertyConfiguration Property<TPrimitivePropertyConfiguration>(global::System.Linq.Expressions.LambdaExpression lambdaExpression)
		{
			return this.Configuration.Property<TPrimitivePropertyConfiguration>(lambdaExpression.GetSimplePropertyAccess(), delegate()
			{
				TPrimitivePropertyConfiguration tprimitivePropertyConfiguration = global::System.Activator.CreateInstance<TPrimitivePropertyConfiguration>();
				tprimitivePropertyConfiguration.OverridableConfigurationParts = global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Primitive.OverridableConfigurationParts.OverridableInSSpace;
				return tprimitivePropertyConfiguration;
			});
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x000379C2 File Offset: 0x00035BC2
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000379CA File Offset: 0x00035BCA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x000379D3 File Offset: 0x00035BD3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x000379DB File Offset: 0x00035BDB
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040009F3 RID: 2547
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration _complexTypeConfiguration;
	}
}
