using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.SqlClient;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200025E RID: 606
	public sealed class SqlConnectionFactory : global::System.Data.Entity.Infrastructure.IDbConnectionFactory
	{
		// Token: 0x06001EE6 RID: 7910 RVA: 0x00054DD3 File Offset: 0x00052FD3
		public SqlConnectionFactory()
		{
			this._baseConnectionString = "Data Source=.\\SQLEXPRESS; Integrated Security=True; MultipleActiveResultSets=True;";
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00054DE6 File Offset: 0x00052FE6
		public SqlConnectionFactory(string baseConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<string>(baseConnectionString, "baseConnectionString");
			this._baseConnectionString = baseConnectionString;
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x06001EE8 RID: 7912 RVA: 0x00054E01 File Offset: 0x00053001
		// (set) Token: 0x06001EE9 RID: 7913 RVA: 0x00054E1D File Offset: 0x0005301D
		internal global::System.Func<string, global::System.Data.Common.DbProviderFactory> ProviderFactory
		{
			get
			{
				return this._providerFactoryCreator ?? new global::System.Func<string, global::System.Data.Common.DbProviderFactory>(global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Common.DbProviderFactory>);
			}
			set
			{
				this._providerFactoryCreator = value;
			}
		}

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x06001EEA RID: 7914 RVA: 0x00054E26 File Offset: 0x00053026
		public string BaseConnectionString
		{
			get
			{
				return this._baseConnectionString;
			}
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00054E30 File Offset: 0x00053030
		public global::System.Data.Common.DbConnection CreateConnection(string nameOrConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			string value = nameOrConnectionString;
			if (!global::System.Data.Entity.Internal.DbHelpers.TreatAsConnectionString(nameOrConnectionString))
			{
				if (nameOrConnectionString.EndsWith(".mdf", true, null))
				{
					throw global::System.Data.Entity.Resources.Error.SqlConnectionFactory_MdfNotSupported(nameOrConnectionString);
				}
				value = new global::System.Data.SqlClient.SqlConnectionStringBuilder(this.BaseConnectionString)
				{
					InitialCatalog = nameOrConnectionString
				}.ConnectionString;
			}
			global::System.Data.Common.DbConnection dbConnection = null;
			try
			{
				dbConnection = this.ProviderFactory("System.Data.SqlClient").CreateConnection();
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(value));
			}
			catch
			{
				dbConnection = new global::System.Data.SqlClient.SqlConnection();
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(value));
			}
			return dbConnection;
		}

		// Token: 0x04000B3F RID: 2879
		private readonly string _baseConnectionString;

		// Token: 0x04000B40 RID: 2880
		private global::System.Func<string, global::System.Data.Common.DbProviderFactory> _providerFactoryCreator;
	}
}
