using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D4 RID: 468
	public class ConventionUpdateModificationStoredProcedureConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProcedureConfiguration
	{
		// Token: 0x06001879 RID: 6265 RVA: 0x000411FB File Offset: 0x0003F3FB
		internal ConventionUpdateModificationStoredProcedureConfiguration(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x0600187A RID: 6266 RVA: 0x0004120A File Offset: 0x0003F40A
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x0600187B RID: 6267 RVA: 0x00041225 File Offset: 0x0003F425
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0004124D File Offset: 0x0003F44D
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Parameter(string propertyName, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			return this.Parameter(this._type.GetAnyProperty(propertyName), parameterName);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0004127A File Offset: 0x0003F47A
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Parameter(global::System.Reflection.PropertyInfo propertyInfo, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			if (propertyInfo != null)
			{
				base.Configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), parameterName, null, false);
			}
			return this;
		}

		// Token: 0x0600187E RID: 6270 RVA: 0x000412A6 File Offset: 0x0003F4A6
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Parameter(string propertyName, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			return this.Parameter(this._type.GetAnyProperty(propertyName), currentValueParameterName, originalValueParameterName);
		}

		// Token: 0x0600187F RID: 6271 RVA: 0x000412E0 File Offset: 0x0003F4E0
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Parameter(global::System.Reflection.PropertyInfo propertyInfo, string currentValueParameterName, string originalValueParameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(currentValueParameterName, "currentValueParameterName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(originalValueParameterName, "originalValueParameterName");
			if (propertyInfo != null)
			{
				base.Configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), currentValueParameterName, originalValueParameterName, false);
			}
			return this;
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x00041318 File Offset: 0x0003F518
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Result(string propertyName, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(this._type.GetAnyProperty(propertyName)), columnName);
			return this;
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x00041350 File Offset: 0x0003F550
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration Result(global::System.Reflection.PropertyInfo propertyInfo, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), columnName);
			return this;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0004137D File Offset: 0x0003F57D
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionUpdateModificationStoredProcedureConfiguration RowsAffectedParameter(string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.RowsAffectedParameter(parameterName);
			return this;
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x00041398 File Offset: 0x0003F598
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000413A0 File Offset: 0x0003F5A0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000413A9 File Offset: 0x0003F5A9
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000413B1 File Offset: 0x0003F5B1
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A67 RID: 2663
		private readonly global::System.Type _type;
	}
}
