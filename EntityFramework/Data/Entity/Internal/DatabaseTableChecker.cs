using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Linq;
using System.Transactions;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F4 RID: 244
	internal class DatabaseTableChecker
	{
		// Token: 0x0600121D RID: 4637 RVA: 0x0002E070 File Offset: 0x0002C270
		public global::System.Data.Entity.Internal.DatabaseExistenceState AnyModelTableExists(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			if (!internalContext.DatabaseOperations.Exists(internalContext.Connection, internalContext.CommandTimeout, new global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection>(() => global::System.Data.Entity.Internal.DatabaseTableChecker.CreateStoreItemCollection(internalContext))))
			{
				return global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist;
			}
			global::System.Data.Entity.Internal.DatabaseExistenceState result;
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = internalContext.CreateObjectContextForDdlOps())
			{
				try
				{
					if (internalContext.CodeFirstModel == null)
					{
						result = global::System.Data.Entity.Internal.DatabaseExistenceState.Exists;
					}
					else
					{
						global::System.Data.Entity.Infrastructure.TableExistenceChecker service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(internalContext.ProviderName);
						if (service == null)
						{
							result = global::System.Data.Entity.Internal.DatabaseExistenceState.Exists;
						}
						else
						{
							global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> list = this.GetModelTables(internalContext).ToList<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>();
							if (!list.Any<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>())
							{
								result = global::System.Data.Entity.Internal.DatabaseExistenceState.Exists;
							}
							else if (this.QueryForTableExistence(service, clonedObjectContext, list))
							{
								result = global::System.Data.Entity.Internal.DatabaseExistenceState.Exists;
							}
							else
							{
								result = (internalContext.HasHistoryTableEntry() ? global::System.Data.Entity.Internal.DatabaseExistenceState.Exists : global::System.Data.Entity.Internal.DatabaseExistenceState.ExistsConsideredEmpty);
							}
						}
					}
				}
				catch (global::System.Exception)
				{
					result = global::System.Data.Entity.Internal.DatabaseExistenceState.Exists;
				}
			}
			return result;
		}

		// Token: 0x0600121E RID: 4638 RVA: 0x0002E174 File Offset: 0x0002C374
		private static global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection CreateStoreItemCollection(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection result;
			using (global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext = internalContext.CreateObjectContextForDdlOps())
			{
				result = (global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection)clonedObjectContext.ObjectContext.Connection.GetMetadataWorkspace().GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace);
			}
			return result;
		}

		// Token: 0x0600121F RID: 4639 RVA: 0x0002E1C8 File Offset: 0x0002C3C8
		public virtual bool QueryForTableExistence(global::System.Data.Entity.Infrastructure.TableExistenceChecker checker, global::System.Data.Entity.Internal.ClonedObjectContext clonedObjectContext, global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> modelTables)
		{
			using (new global::System.Transactions.TransactionScope(global::System.Transactions.TransactionScopeOption.Suppress))
			{
				if (checker.AnyModelTableExistsInDatabase(clonedObjectContext.ObjectContext, clonedObjectContext.Connection, modelTables, "EdmMetadata"))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001220 RID: 4640 RVA: 0x0002E220 File Offset: 0x0002C420
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> GetModelTables(global::System.Data.Entity.Internal.InternalContext internalContext)
		{
			return from s in internalContext.ObjectContext.MetadataWorkspace.GetItemCollection(global::System.Data.Entity.Core.Metadata.Edm.DataSpace.SSpace).GetItems<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().Single<global::System.Data.Entity.Core.Metadata.Edm.EntityContainer>().BaseEntitySets.OfType<global::System.Data.Entity.Core.Metadata.Edm.EntitySet>()
			where !s.MetadataProperties.Contains("Type") || (string)s.MetadataProperties["Type"].Value == "Tables"
			select s;
		}
	}
}
