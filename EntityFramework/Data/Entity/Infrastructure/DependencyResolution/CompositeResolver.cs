using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AA RID: 682
	internal class CompositeResolver<TFirst, TSecond> : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver where TFirst : class, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver where TSecond : class, global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x0600219B RID: 8603 RVA: 0x0005D5B4 File Offset: 0x0005B7B4
		public CompositeResolver(TFirst firstResolver, TSecond secondResolver)
		{
			this._firstResolver = firstResolver;
			this._secondResolver = secondResolver;
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x0600219C RID: 8604 RVA: 0x0005D5CA File Offset: 0x0005B7CA
		public TFirst First
		{
			get
			{
				return this._firstResolver;
			}
		}

		// Token: 0x17000731 RID: 1841
		// (get) Token: 0x0600219D RID: 8605 RVA: 0x0005D5D2 File Offset: 0x0005B7D2
		public TSecond Second
		{
			get
			{
				return this._secondResolver;
			}
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x0005D5DA File Offset: 0x0005B7DA
		public virtual object GetService(global::System.Type type, object key)
		{
			return this._firstResolver.GetService(type, key) ?? this._secondResolver.GetService(type, key);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x0005D604 File Offset: 0x0005B804
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this._firstResolver.GetServices(type, key).Concat(this._secondResolver.GetServices(type, key));
		}

		// Token: 0x04000BB6 RID: 2998
		private readonly TFirst _firstResolver;

		// Token: 0x04000BB7 RID: 2999
		private readonly TSecond _secondResolver;
	}
}
