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
	// Token: 0x020001D5 RID: 469
	public class DeleteModificationStoredProcedureConfiguration<TEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfigurationBase where TEntityType : class
	{
		// Token: 0x06001887 RID: 6279 RVA: 0x000413B9 File Offset: 0x0003F5B9
		internal DeleteModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000413C1 File Offset: 0x0003F5C1
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000413DC File Offset: 0x0003F5DC
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x00041404 File Offset: 0x0003F604
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x00041433 File Offset: 0x0003F633
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x00041462 File Offset: 0x0003F662
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x00041491 File Offset: 0x0003F691
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600188E RID: 6286 RVA: 0x000414C0 File Offset: 0x0003F6C0
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeography>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x000414EF File Offset: 0x0003F6EF
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Parameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, global::System.Data.Entity.Spatial.DbGeometry>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetComplexPropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0004151E File Offset: 0x0003F71E
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> RowsAffectedParameter(string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.RowsAffectedParameter(parameterName);
			return this;
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0004153C File Offset: 0x0003F73C
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, TEntityType>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x00041580 File Offset: 0x0003F780
		public global::System.Data.Entity.ModelConfiguration.Configuration.DeleteModificationStoredProcedureConfiguration<TEntityType> Navigation<TPrincipalEntityType>(global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>> navigationPropertyExpression, global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>> associationModificationStoredProcedureConfigurationAction) where TPrincipalEntityType : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TPrincipalEntityType, global::System.Collections.Generic.ICollection<TEntityType>>>>(navigationPropertyExpression, "navigationPropertyExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Action<global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>>>(associationModificationStoredProcedureConfigurationAction, "associationModificationStoredProcedureConfigurationAction");
			global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType> obj = new global::System.Data.Entity.ModelConfiguration.Configuration.AssociationModificationStoredProcedureConfiguration<TPrincipalEntityType>(navigationPropertyExpression.GetSimplePropertyAccess().Single<global::System.Reflection.PropertyInfo>(), base.Configuration);
			associationModificationStoredProcedureConfigurationAction(obj);
			return this;
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x000415C4 File Offset: 0x0003F7C4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001894 RID: 6292 RVA: 0x000415CC File Offset: 0x0003F7CC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001895 RID: 6293 RVA: 0x000415D5 File Offset: 0x0003F7D5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000415DD File Offset: 0x0003F7DD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
