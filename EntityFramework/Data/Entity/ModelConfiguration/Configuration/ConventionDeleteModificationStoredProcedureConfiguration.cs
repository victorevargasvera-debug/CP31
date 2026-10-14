using System;
using System.ComponentModel;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Reflection;

namespace System.Data.Entity.ModelConfiguration.Configuration
{
	// Token: 0x020001D0 RID: 464
	public class ConventionDeleteModificationStoredProcedureConfiguration : global::System.Data.Entity.ModelConfiguration.Configuration.ConventionModificationStoredProcedureConfiguration
	{
		// Token: 0x06001859 RID: 6233 RVA: 0x00040EC7 File Offset: 0x0003F0C7
		internal ConventionDeleteModificationStoredProcedureConfiguration(global::System.Type type)
		{
			this._type = type;
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00040ED6 File Offset: 0x0003F0D6
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration HasName(string procedureName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			base.Configuration.HasName(procedureName);
			return this;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x00040EF1 File Offset: 0x0003F0F1
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration HasName(string procedureName, string schemaName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(procedureName, "procedureName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(schemaName, "schemaName");
			base.Configuration.HasName(procedureName, schemaName);
			return this;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00040F19 File Offset: 0x0003F119
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration Parameter(string propertyName, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			return this.Parameter(this._type.GetAnyProperty(propertyName), parameterName);
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00040F46 File Offset: 0x0003F146
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration Parameter(global::System.Reflection.PropertyInfo propertyInfo, string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			if (propertyInfo != null)
			{
				base.Configuration.Parameter(new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(propertyInfo), parameterName, null, false);
			}
			return this;
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00040F72 File Offset: 0x0003F172
		public global::System.Data.Entity.ModelConfiguration.Configuration.ConventionDeleteModificationStoredProcedureConfiguration RowsAffectedParameter(string parameterName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(parameterName, "parameterName");
			base.Configuration.RowsAffectedParameter(parameterName);
			return this;
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00040F8D File Offset: 0x0003F18D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00040F95 File Offset: 0x0003F195
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x00040F9E File Offset: 0x0003F19E
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x00040FA6 File Offset: 0x0003F1A6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000A62 RID: 2658
		private readonly global::System.Type _type;
	}
}
