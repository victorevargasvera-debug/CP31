using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Spatial;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D6 RID: 470
	public class InsertModificationStoredProcedureConfiguration<TEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfigurationBase where TEntityType : class
	{
		// Token: 0x06001897 RID: 6295 RVA: 0x000415E5 File Offset: 0x0003F7E5
		internal InsertModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x06001898 RID: 6296 RVA: 0x000415ED File Offset: 0x0003F7ED
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x00041608 File Offset: 0x0003F808
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x00041630 File Offset: 0x0003F830
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x0004165F File Offset: 0x0003F85F
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0004168E File Offset: 0x0003F88E
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600189D RID: 6301 RVA: 0x000416BD File Offset: 0x0003F8BD
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600189E RID: 6302 RVA: 0x000416EC File Offset: 0x0003F8EC
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600189F RID: 6303 RVA: 0x0004171B File Offset: 0x0003F91B
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018A0 RID: 6304 RVA: 0x0004174A File Offset: 0x0003F94A
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string columnName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A1 RID: 6305 RVA: 0x00041777 File Offset: 0x0003F977
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string columnName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A2 RID: 6306 RVA: 0x000417A4 File Offset: 0x0003F9A4
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A3 RID: 6307 RVA: 0x000417D1 File Offset: 0x0003F9D1
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A4 RID: 6308 RVA: 0x000417FE File Offset: 0x0003F9FE
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A5 RID: 6309 RVA: 0x0004182B File Offset: 0x0003FA2B
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x060018A6 RID: 6310 RVA: 0x00041858 File Offset: 0x0003FA58
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x060018A7 RID: 6311 RVA: 0x0004189C File Offset: 0x0003FA9C
		public global::System.Data.Entity.ModelConfiguration.Configuration.InsertModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x060018A8 RID: 6312 RVA: 0x000418E0 File Offset: 0x0003FAE0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060018A9 RID: 6313 RVA: 0x000418E8 File Offset: 0x0003FAE8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060018AA RID: 6314 RVA: 0x000418F1 File Offset: 0x0003FAF1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060018AB RID: 6315 RVA: 0x000418F9 File Offset: 0x0003FAF9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
