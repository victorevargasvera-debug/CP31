using System;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001CF RID: 463
	public class AssociationModificationStoredProcedureConfiguration<TEntityType> where TEntityType : class
	{
		// Token: 0x06001854 RID: 6228 RVA: 0x00040D62 File Offset: 0x0003EF62
		internal AssociationModificationStoredProcedureConfiguration(global::System.Reflection.PropertyInfo navigationPropertyInfo, global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration configuration)
		{
			this._navigationPropertyInfo = navigationPropertyInfo;
			this._configuration = configuration;
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00040D78 File Offset: 0x0003EF78
		public global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			this._configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(new global::System.Reflection.PropertyInfo[]
			{
				this._navigationPropertyInfo
			}.Concat(propertyExpression.GetSimplePropertyAccess())), parameterName, null, false);
			return this;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00040DCC File Offset: 0x0003EFCC
		public global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			this._configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(new global::System.Reflection.PropertyInfo[]
			{
				this._navigationPropertyInfo
			}.Concat(propertyExpression.GetSimplePropertyAccess())), parameterName, null, false);
			return this;
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00040E20 File Offset: 0x0003F020
		public global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			this._configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(new global::System.Reflection.PropertyInfo[]
			{
				this._navigationPropertyInfo
			}.Concat(propertyExpression.GetSimplePropertyAccess())), parameterName, null, false);
			return this;
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00040E74 File Offset: 0x0003F074
		public global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			this._configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(new global::System.Reflection.PropertyInfo[]
			{
				this._navigationPropertyInfo
			}.Concat(propertyExpression.GetSimplePropertyAccess())), parameterName, null, false);
			return this;
		}

		// Token: 0x04000A60 RID: 2656
		private readonly global::System.Reflection.PropertyInfo _navigationPropertyInfo;

		// Token: 0x04000A61 RID: 2657
		private readonly global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfiguration _configuration;
	}
}
