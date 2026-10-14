using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BE RID: 702
	internal class TransactionContextInitializerResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x0600220E RID: 8718 RVA: 0x0005ECE8 File Offset: 0x0005CEE8
		public object GetService(global::System.Type type, object key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(type, "type");
			global::System.Type type2 = type.TryGetElementType(typeof(global::System.Data.Entity.IDatabaseInitializer<>));
			if (type2 != null && typeof(global::System.Data.Entity.Infrastructure.TransactionContext).IsAssignableFrom(type2))
			{
				return this._initializers.GetOrAdd(type2, new global::System.Func<global::System.Type, object>(this.CreateInitializerInstance));
			}
			return null;
		}

		// Token: 0x0600220F RID: 8719 RVA: 0x0005ED47 File Offset: 0x0005CF47
		private object CreateInitializerInstance(global::System.Type type)
		{
			return global::System.Activator.CreateInstance(typeof(global::System.Data.Entity.Infrastructure.TransactionContextInitializer<>).MakeGenericType(new global::System.Type[]
			{
				type
			}));
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0005ED67 File Offset: 0x0005CF67
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x04000BD8 RID: 3032
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, object> _initializers = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, object>();
	}
}
