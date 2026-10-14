using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000285 RID: 645
	public static class DbInterception
	{
		// Token: 0x06002081 RID: 8321 RVA: 0x0005B23D File Offset: 0x0005943D
		public static void Add(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(interceptor, "interceptor");
			global::System.Data.Entity.Infrastructure.Interception.DbInterception._dispatchers.Value.AddInterceptor(interceptor);
		}

		// Token: 0x06002082 RID: 8322 RVA: 0x0005B25B File Offset: 0x0005945B
		public static void Remove(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor>(interceptor, "interceptor");
			global::System.Data.Entity.Infrastructure.Interception.DbInterception._dispatchers.Value.RemoveInterceptor(interceptor);
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0005B279 File Offset: 0x00059479
		public static global::System.Data.Entity.Infrastructure.Interception.DbDispatchers Dispatch
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.Interception.DbInterception._dispatchers.Value;
			}
		}

		// Token: 0x04000B83 RID: 2947
		private static readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers> _dispatchers = new global::System.Lazy<global::System.Data.Entity.Infrastructure.Interception.DbDispatchers>(() => new global::System.Data.Entity.Infrastructure.Interception.DbDispatchers());
	}
}
