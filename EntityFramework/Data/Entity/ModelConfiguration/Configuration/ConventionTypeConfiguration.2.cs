using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation;
using System.Data.Entity.ModelConfiguration.Configuration.Types;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001FB RID: 507
	public class ConventionTypeConfiguration<T> where T : class
	{
		// Token: 0x06001AA8 RID: 6824 RVA: 0x00047594 File Offset: 0x00045794
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.EntityTypeConfiguration> entityTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(type, entityTypeConfiguration, modelConfiguration);
		}

		// Token: 0x06001AA9 RID: 6825 RVA: 0x000475AA File Offset: 0x000457AA
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Func<global::System.Data.Entity.ModelConfiguration.Configuration.Types.ComplexTypeConfiguration> complexTypeConfiguration, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(type, complexTypeConfiguration, modelConfiguration);
		}

		// Token: 0x06001AAA RID: 6826 RVA: 0x000475C0 File Offset: 0x000457C0
		internal ConventionTypeConfiguration(global::System.Type type, global::System.Data.Entity.ModelConfiguration.Configuration.ModelConfiguration modelConfiguration)
		{
			this._configuration = new global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration(type, modelConfiguration);
		}

		// Token: 0x06001AAB RID: 6827 RVA: 0x000475D5 File Offset: 0x000457D5
		[global::System.Diagnostics.Conditional("DEBUG")]
		private static void VerifyType(global::System.Type type)
		{
		}

		// Token: 0x17000606 RID: 1542
		// (get) Token: 0x06001AAC RID: 6828 RVA: 0x000475D7 File Offset: 0x000457D7
		public global::System.Type ClrType
		{
			get
			{
				return this._configuration.ClrType;
			}
		}

		// Token: 0x06001AAD RID: 6829 RVA: 0x000475E4 File Offset: 0x000457E4
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> HasEntitySetName(string entitySetName)
		{
			this._configuration.HasEntitySetName(entitySetName);
			return this;
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x000475F4 File Offset: 0x000457F4
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> Ignore()
		{
			this._configuration.Ignore();
			return this;
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x00047603 File Offset: 0x00045803
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> IsComplexType()
		{
			this._configuration.IsComplexType();
			return this;
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00047612 File Offset: 0x00045812
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> Ignore<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>> propertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>>>(propertyExpression, "propertyExpression");
			this._configuration.Ignore(propertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x00047638 File Offset: 0x00045838
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionPrimitivePropertyConfiguration Property<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>> propertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>>>(propertyExpression, "propertyExpression");
			return this._configuration.Property(propertyExpression.GetComplexPropertyAccess());
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x00047657 File Offset: 0x00045857
		internal global::System.Data.Entity.ModelConfiguration.Configuration.Properties.Navigation.ConventionNavigationPropertyConfiguration NavigationProperty<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>> propertyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>>>(propertyExpression, "propertyExpression");
			return this._configuration.NavigationProperty(propertyExpression.GetComplexPropertyAccess());
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x00047678 File Offset: 0x00045878
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> HasKey<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>> keyExpression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<T, TProperty>>>(keyExpression, "keyExpression");
			this._configuration.HasKey(from p in keyExpression.GetSimplePropertyAccessList()
			select p.Single<global::System.Reflection.PropertyInfo>());
			return this;
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x000476C8 File Offset: 0x000458C8
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> ToTable(string tableName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._configuration.ToTable(tableName);
			return this;
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x000476E4 File Offset: 0x000458E4
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> ToTable(string tableName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(tableName, "tableName");
			this._configuration.ToTable(tableName, schemaName);
			return this;
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x00047701 File Offset: 0x00045901
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> HasTableAnnotation(string name, object value)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(name, "name");
			this._configuration.HasTableAnnotation(name, value);
			return this;
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x0004771E File Offset: 0x0004591E
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> MapToStoredProcedures()
		{
			this._configuration.MapToStoredProcedures();
			return this;
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x00047730 File Offset: 0x00045930
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration<T> MapToStoredProcedures(global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<T>> modificationStoredProceduresConfigurationAction)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<T>>>(modificationStoredProceduresConfigurationAction, "modificationStoredProceduresConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<T> modificationStoredProceduresConfiguration = new global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProceduresConfiguration<T>();
			modificationStoredProceduresConfigurationAction(modificationStoredProceduresConfiguration);
			this._configuration.MapToStoredProcedures(modificationStoredProceduresConfiguration.Configuration);
			return this;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x00047768 File Offset: 0x00045968
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001ABA RID: 6842 RVA: 0x00047770 File Offset: 0x00045970
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x00047779 File Offset: 0x00045979
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00047781 File Offset: 0x00045981
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000AA2 RID: 2722
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ConventionTypeConfiguration _configuration;
	}
}
