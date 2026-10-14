using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.IO;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200025D RID: 605
	public sealed class SqlCeConnectionFactory : global::System.Data.Entity.Infrastructure.IDbConnectionFactory
	{
		// Token: 0x06001EE0 RID: 7904 RVA: 0x00054C59 File Offset: 0x00052E59
		public SqlCeConnectionFactory(string providerInvariantName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			this._providerInvariantName = providerInvariantName;
			this._databaseDirectory = "|DataDirectory|";
			this._baseConnectionString = "";
		}

		// Token: 0x06001EE1 RID: 7905 RVA: 0x00054C8C File Offset: 0x00052E8C
		public SqlCeConnectionFactory(string providerInvariantName, string databaseDirectory, string baseConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(databaseDirectory, "databaseDirectory");
			global::System.Data.Entity.Utilities.Check.NotNull<string>(baseConnectionString, "baseConnectionString");
			this._providerInvariantName = providerInvariantName;
			this._databaseDirectory = databaseDirectory;
			this._baseConnectionString = baseConnectionString;
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x06001EE2 RID: 7906 RVA: 0x00054CD8 File Offset: 0x00052ED8
		public string DatabaseDirectory
		{
			get
			{
				return this._databaseDirectory;
			}
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x06001EE3 RID: 7907 RVA: 0x00054CE0 File Offset: 0x00052EE0
		public string BaseConnectionString
		{
			get
			{
				return this._baseConnectionString;
			}
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x06001EE4 RID: 7908 RVA: 0x00054CE8 File Offset: 0x00052EE8
		public string ProviderInvariantName
		{
			get
			{
				return this._providerInvariantName;
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00054CF0 File Offset: 0x00052EF0
		public global::System.Data.Common.DbConnection CreateConnection(string nameOrConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			global::System.Data.Common.DbConnection dbConnection = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(this.ProviderInvariantName).CreateConnection();
			if (dbConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbContext_ProviderReturnedNullConnection();
			}
			string value;
			if (global::System.Data.Entity.Internal.DbHelpers.TreatAsConnectionString(nameOrConnectionString))
			{
				value = nameOrConnectionString;
			}
			else
			{
				if (!nameOrConnectionString.EndsWith(".sdf", true, null))
				{
					nameOrConnectionString += ".sdf";
				}
				string text = (this.DatabaseDirectory.StartsWith("|", global::System.StringComparison.Ordinal) && this.DatabaseDirectory.EndsWith("|", global::System.StringComparison.Ordinal)) ? (this.DatabaseDirectory + nameOrConnectionString) : global::System.IO.Path.Combine(this.DatabaseDirectory, nameOrConnectionString);
				value = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "Data Source={0}; {1}", new object[]
				{
					text,
					this.BaseConnectionString
				});
			}
			global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(dbConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(value));
			return dbConnection;
		}

		// Token: 0x04000B3C RID: 2876
		private readonly string _databaseDirectory;

		// Token: 0x04000B3D RID: 2877
		private readonly string _baseConnectionString;

		// Token: 0x04000B3E RID: 2878
		private readonly string _providerInvariantName;
	}
}
