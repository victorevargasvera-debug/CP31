using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BB RID: 699
	internal class ResolverChain : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021FD RID: 8701 RVA: 0x0005E859 File Offset: 0x0005CA59
		public virtual void Add(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>(resolver, "resolver");
			this._resolvers.Push(resolver);
			this._resolversSnapshot = this._resolvers.ToArray();
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x060021FE RID: 8702 RVA: 0x0005E886 File Offset: 0x0005CA86
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> Resolvers
		{
			get
			{
				return this._resolversSnapshot.Reverse<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>();
			}
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0005E898 File Offset: 0x0005CA98
		public virtual object GetService(global::System.Type type, object key)
		{
			return (from r in this._resolversSnapshot
			select r.GetService(type, key)).FirstOrDefault((object s) => s != null);
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0005E8F8 File Offset: 0x0005CAF8
		public virtual global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this._resolversSnapshot.SelectMany((global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver r) => r.GetServices(type, key));
		}

		// Token: 0x04000BD0 RID: 3024
		private readonly global::System.Collections.Concurrent.ConcurrentStack<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> _resolvers = new global::System.Collections.Concurrent.ConcurrentStack<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver>();

		// Token: 0x04000BD1 RID: 3025
		private volatile global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver[] _resolversSnapshot = new global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver[0];
	}
}
