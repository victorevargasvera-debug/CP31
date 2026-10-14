using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002C0 RID: 704
	internal class WrappingDependencyResolver<TService> : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x06002217 RID: 8727 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
		public WrappingDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver snapshot, global::System.Func<TService, object, TService> serviceWrapper)
		{
			this._snapshot = snapshot;
			this._serviceWrapper = serviceWrapper;
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0005EEFE File Offset: 0x0005D0FE
		public object GetService(global::System.Type type, object key)
		{
			if (!(type == typeof(TService)))
			{
				return null;
			}
			return this._serviceWrapper(this._snapshot.GetService(key), key);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0005EF34 File Offset: 0x0005D134
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			if (!(type == typeof(TService)))
			{
				return global::System.Linq.Enumerable.Empty<object>();
			}
			return (global::System.Collections.Generic.IEnumerable<object>)(from s in this._snapshot.GetServices(key)
			select this._serviceWrapper(s, key));
		}

		// Token: 0x04000BDC RID: 3036
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _snapshot;

		// Token: 0x04000BDD RID: 3037
		private readonly global::System.Func<TService, object, TService> _serviceWrapper;
	}
}
