using System;
using System.Data.Common;
using System.Data.Entity.Core;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FE RID: 254
	internal class EdmMetadataRepository : global::System.Data.Entity.Internal.RepositoryBase
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x0002F70F File Offset: 0x0002D90F
		public EdmMetadataRepository(global::System.Data.Entity.Internal.InternalContext usersContext, string connectionString, global::System.Data.Common.DbProviderFactory providerFactory) : base(usersContext, connectionString, providerFactory)
		{
			this._existingTransaction = usersContext.TryGetCurrentStoreTransaction();
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0002F728 File Offset: 0x0002D928
		public virtual string QueryForModelHash(global::System.Func<global::System.Data.Common.DbConnection, global::System.Data.Entity.Internal.EdmMetadataContext> createContext)
		{
			global::System.Data.Common.DbConnection dbConnection = base.CreateConnection();
			string result;
			try
			{
				using (global::System.Data.Entity.Internal.EdmMetadataContext edmMetadataContext = createContext(dbConnection))
				{
					if (this._existingTransaction != null && this._existingTransaction.Connection == dbConnection)
					{
						edmMetadataContext.Database.UseTransaction(this._existingTransaction);
					}
					try
					{
						global::System.Data.Entity.Infrastructure.EdmMetadata edmMetadata = (from m in edmMetadataContext.Metadata.AsNoTracking<global::System.Data.Entity.Infrastructure.EdmMetadata>()
						orderby m.Id descending
						select m).FirstOrDefault<global::System.Data.Entity.Infrastructure.EdmMetadata>();
						result = ((edmMetadata != null) ? edmMetadata.ModelHash : null);
					}
					catch (global::System.Data.Entity.Core.EntityCommandExecutionException)
					{
						result = null;
					}
				}
			}
			finally
			{
				base.DisposeConnection(dbConnection);
			}
			return result;
		}

		// Token: 0x0400091F RID: 2335
		private readonly global::System.Data.Common.DbTransaction _existingTransaction;
	}
}
