using System;
using System.ComponentModel;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D7 RID: 471
	public class ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> : global::System.Data.Entity.ModelConfiguration.Configuration.ModificationStoredProcedureConfigurationBase where TEntityType : class where TTargetEntityType : class
	{
		// Token: 0x060018AC RID: 6316 RVA: 0x00041901 File Offset: 0x0003FB01
		internal ManyToManyModificationStoredProcedureConfiguration()
		{
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00041909 File Offset: 0x0003FB09
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x00041924 File Offset: 0x0003FB24
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x0004194C File Offset: 0x0003FB4C
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> LeftKeyParameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x0004197B File Offset: 0x0003FB7B
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> LeftKeyParameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000419AA File Offset: 0x0003FBAA
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> LeftKeyParameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000419D9 File Offset: 0x0003FBD9
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> LeftKeyParameter(global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, false);
			return this;
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00041A08 File Offset: 0x0003FC08
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> RightKeyParameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TProperty>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TProperty>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, true);
			return this;
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00041A37 File Offset: 0x0003FC37
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> RightKeyParameter<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TProperty?>> propertyExpression, string parameterName) where TProperty : struct
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, TProperty?>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, true);
			return this;
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00041A66 File Offset: 0x0003FC66
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> RightKeyParameter(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, string>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, string>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, true);
			return this;
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00041A95 File Offset: 0x0003FC95
		public global::System.Data.Entity.ModelConfiguration.Configuration.ManyToManyModificationStoredProcedureConfiguration<TEntityType, TTargetEntityType> RightKeyParameter(global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, byte[]>> propertyExpression, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TTargetEntityType, byte[]>>>(propertyExpression, "propertyExpression");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.Parameter(propertyExpression.GetSimplePropertyAccess(), parameterName, null, true);
			return this;
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x00041AC4 File Offset: 0x0003FCC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x00041ACC File Offset: 0x0003FCCC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x00041AD5 File Offset: 0x0003FCD5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x00041ADD File Offset: 0x0003FCDD
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
