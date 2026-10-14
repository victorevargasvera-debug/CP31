using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000F3 RID: 243
	internal class DatabaseOperations
	{
		// Token: 0x06001219 RID: 4633 RVA: 0x0002DFEA File Offset: 0x0002C1EA
		public virtual bool Create(global::System.Data.Entity.Core.Objects.ObjectContext objectContext)
		{
			objectContext.CreateDatabase();
			return true;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public virtual bool Exists(global::System.Data.Common.DbConnection connection, int? commandTimeout, global::System.Lazy<global::System.Data.Entity.Core.Metadata.Edm.StoreItemCollection> storeItemCollection)
		{
			if (connection.State == global::System.Data.ConnectionState.Open)
			{
				return true;
			}
			bool result;
			try
			{
				result = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection).DatabaseExists(connection, commandTimeout, storeItemCollection);
			}
			catch
			{
				try
				{
					connection.Open();
					result = true;
				}
				catch (global::System.Exception)
				{
					result = false;
				}
				finally
				{
					connection.Close();
				}
			}
			return result;
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0002E060 File Offset: 0x0002C260
		public virtual void Delete(global::System.Data.Entity.Core.Objects.ObjectContext objectContext)
		{
			objectContext.DeleteDatabase();
		}
	}
}
