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
	// Token: 0x020001DD RID: 477
	public class UpdateModificationStoredProcedureConfiguration<TEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfigurationBase where TEntityType : class
	{
		// Token: 0x060018F3 RID: 6387 RVA: 0x00042749 File Offset: 0x00040949
		internal UpdateModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00042751 File Offset: 0x00040951
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x0004276C File Offset: 0x0004096C
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00042794 File Offset: 0x00040994
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000427C3 File Offset: 0x000409C3
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x000427F2 File Offset: 0x000409F2
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00042821 File Offset: 0x00040A21
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00042850 File Offset: 0x00040A50
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0004287F File Offset: 0x00040A7F
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x000428AE File Offset: 0x00040AAE
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string currentValueParameterName, string originalValueParameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x000428E9 File Offset: 0x00040AE9
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string currentValueParameterName, string originalValueParameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x00042924 File Offset: 0x00040B24
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0004295F File Offset: 0x00040B5F
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0004299A File Offset: 0x00040B9A
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x000429D5 File Offset: 0x00040BD5
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), currentValueParameterName, originalValueParameterName, false);
			return this;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x00042A10 File Offset: 0x00040C10
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string columnName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x00042A3D File Offset: 0x00040C3D
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string columnName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x00042A6A File Offset: 0x00040C6A
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x00042A97 File Offset: 0x00040C97
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x00042AC4 File Offset: 0x00040CC4
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x00042AF1 File Offset: 0x00040CF1
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Result(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(propertyExpression.GetSimplePropertyAccess(), columnName);
			return this;
		}

		// Token: 0x06001908 RID: 6408 RVA: 0x00042B1E File Offset: 0x00040D1E
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> RowsAffectedParameter(string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.RowsAffectedParameter(parameterName);
			return this;
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00042B3C File Offset: 0x00040D3C
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x00042B80 File Offset: 0x00040D80
		public global::System.Data.Entity.ModelConfiguration.Configuration.UpdateModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x0600190B RID: 6411 RVA: 0x00042BC4 File Offset: 0x00040DC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x00042BCC File Offset: 0x00040DCC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x00042BD5 File Offset: 0x00040DD5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x00042BDD File Offset: 0x00040DDD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
