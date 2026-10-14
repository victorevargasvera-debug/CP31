using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D1 RID: 465
	public class ConventionInsertModificationStoredProcedureConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProcedureConfiguration
	{
		// Token: 0x06001863 RID: 6243 RVA: 0x00040FAE File Offset: 0x0003F1AE
		internal ConventionInsertModificationStoredProcedureConfiguration(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x06001864 RID: 6244 RVA: 0x00040FBD File Offset: 0x0003F1BD
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x06001865 RID: 6245 RVA: 0x00040FD8 File Offset: 0x0003F1D8
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x06001866 RID: 6246 RVA: 0x00041000 File Offset: 0x0003F200
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration Parameter(string propertyName, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			return this.Parameter(this._type.GetAnyProperty(propertyName), parameterName);
		}

		// Token: 0x06001867 RID: 6247 RVA: 0x0004102D File Offset: 0x0003F22D
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration Parameter(global::System.Reflection.PropertyInfo propertyInfo, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			if (propertyInfo != null)
			{
				base.Configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), parameterName, null, false);
			}
			return this;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00041059 File Offset: 0x0003F259
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration Result(string propertyName, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(this._type.GetAnyProperty(propertyName)), columnName);
			return this;
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00041091 File Offset: 0x0003F291
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionInsertModificationStoredProcedureConfiguration Result(global::System.Reflection.PropertyInfo propertyInfo, string columnName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Reflection.PropertyInfo>(propertyInfo, "propertyInfo");
			global::System.Data.Entity.Utilities.Check.NotEmpty(columnName, "columnName");
			base.Configuration.Result(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), columnName);
			return this;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x000410BE File Offset: 0x0003F2BE
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x000410C6 File Offset: 0x0003F2C6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600186C RID: 6252 RVA: 0x000410CF File Offset: 0x0003F2CF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x000410D7 File Offset: 0x0003F2D7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A63 RID: 2659
		private readonly global::System.Type _type;
	}
}
