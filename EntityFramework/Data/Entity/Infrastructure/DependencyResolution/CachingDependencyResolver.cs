using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002A8 RID: 680
	internal class CachingDependencyResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x06002195 RID: 8597 RVA: 0x0005D48B File Offset: 0x0005B68B
		public CachingDependencyResolver(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver underlyingResolver)
		{
			this._underlyingResolver = underlyingResolver;
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x0005D4B0 File Offset: 0x0005B6B0
		public virtual object GetService(global::System.Type type, object key)
		{
			return this._resolvedDependencies.GetOrAdd(global::System.Tuple.Create<global::System.Type, object>(type, key), (global::System.Tuple<global::System.Type, object> k) => this._underlyingResolver.GetService(type, key));
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x0005D500 File Offset: 0x0005B700
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this._resolvedAllDependencies.GetOrAdd(global::System.Tuple.Create<global::System.Type, object>(type, key), (global::System.Tuple<global::System.Type, object> k) => this._underlyingResolver.GetServices(type, key));
		}

		// Token: 0x04000BB3 RID: 2995
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver _underlyingResolver;

		// Token: 0x04000BB4 RID: 2996
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, object> _resolvedDependencies = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, object>();

		// Token: 0x04000BB5 RID: 2997
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Collections.Generic.IEnumerable<object>> _resolvedAllDependencies = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Collections.Generic.IEnumerable<object>>();
	}
}
