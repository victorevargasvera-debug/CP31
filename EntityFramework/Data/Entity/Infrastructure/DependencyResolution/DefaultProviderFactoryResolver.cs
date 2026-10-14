using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Resources;
using System.Data.SqlClient;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B2 RID: 690
	internal class DefaultProviderFactoryResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021C9 RID: 8649 RVA: 0x0005E076 File Offset: 0x0005C276
		public virtual object GetService(global::System.Type type, object key)
		{
			return global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderFactoryResolver.GetService(type, key, delegate(global::System.ArgumentException e, string n)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.EntityClient_InvalidStoreProvider(n), e);
			});
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0005E0A0 File Offset: 0x0005C2A0
		private static object GetService(global::System.Type type, object key, global::System.Func<global::System.ArgumentException, string, object> handleFailedLookup)
		{
			if (type == typeof(global::System.Data.Common.DbProviderFactory))
			{
				string text = key as string;
				if (string.IsNullOrWhiteSpace(text))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_NoProviderInvariantName(typeof(global::System.Data.Common.DbProviderFactory).Name));
				}
				try
				{
					return global::System.Data.Common.DbProviderFactories.GetFactory(text);
				}
				catch (global::System.ArgumentException arg)
				{
					if (string.Equals(text, "System.Data.SqlClient", global::System.StringComparison.OrdinalIgnoreCase))
					{
						return global::System.Data.SqlClient.SqlClientFactory.Instance;
					}
					return handleFailedLookup(arg, text);
				}
			}
			return null;
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x0005E128 File Offset: 0x0005C328
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			object service = global::System.Data.Entity.Infrastructure.DependencyResolution.DefaultProviderFactoryResolver.GetService(type, key, (global::System.ArgumentException e, string n) => null);
			if (service != null)
			{
				return new object[]
				{
					service
				};
			}
			return global::System.Linq.Enumerable.Empty<object>();
		}
	}
}
