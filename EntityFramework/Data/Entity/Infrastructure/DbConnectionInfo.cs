using System;
using System.ComponentModel;
using System.Configuration;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000222 RID: 546
	[global::System.Serializable]
	public class DbConnectionInfo
	{
		// Token: 0x06001C9A RID: 7322 RVA: 0x00050EE1 File Offset: 0x0004F0E1
		public DbConnectionInfo(string connectionName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(connectionName, "connectionName");
			this._connectionName = connectionName;
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x00050EFC File Offset: 0x0004F0FC
		public DbConnectionInfo(string connectionString, string providerInvariantName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(connectionString, "connectionString");
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			this._connectionString = connectionString;
			this._providerInvariantName = providerInvariantName;
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x00050F2A File Offset: 0x0004F12A
		internal global::System.Configuration.ConnectionStringSettings GetConnectionString(global::System.Data.Entity.Internal.AppConfig config)
		{
			if (this._connectionName == null)
			{
				return new global::System.Configuration.ConnectionStringSettings(null, this._connectionString, this._providerInvariantName);
			}
			global::System.Configuration.ConnectionStringSettings connectionString = config.GetConnectionString(this._connectionName);
			if (connectionString == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbConnectionInfo_ConnectionStringNotFound(this._connectionName);
			}
			return connectionString;
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00050F62 File Offset: 0x0004F162
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x00050F6A File Offset: 0x0004F16A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x00050F73 File Offset: 0x0004F173
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00050F7B File Offset: 0x0004F17B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000AFA RID: 2810
		private readonly string _connectionName;

		// Token: 0x04000AFB RID: 2811
		private readonly string _connectionString;

		// Token: 0x04000AFC RID: 2812
		private readonly string _providerInvariantName;
	}
}
