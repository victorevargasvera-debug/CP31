using System;
using System.Collections.Concurrent;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023E RID: 574
	public class DefaultManifestTokenResolver : global::System.Data.Entity.Infrastructure.IManifestTokenResolver
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x000535B8 File Offset: 0x000517B8
		public string ResolveManifestToken(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext();
			global::System.Tuple<global::System.Type, string, string> key = global::System.Tuple.Create<global::System.Type, string, string>(connection.GetType(), global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDataSource(connection, interceptionContext), global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetDatabase(connection, interceptionContext));
			return this._cachedTokens.GetOrAdd(key, (global::System.Tuple<global::System.Type, string, string> k) => global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection).GetProviderManifestTokenChecked(connection));
		}

		// Token: 0x04000B2E RID: 2862
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, string, string>, string> _cachedTokens = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, string, string>, string>();
	}
}
