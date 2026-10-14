using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AB RID: 683
	internal class DatabaseInitializerResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021A0 RID: 8608 RVA: 0x0005D630 File Offset: 0x0005B830
		public virtual object GetService(global::System.Type type, object key)
		{
			global::System.Type type2 = type.TryGetElementType(typeof(global::System.Data.Entity.IDatabaseInitializer<>));
			object result;
			if (type2 != null && this._initializers.TryGetValue(type2, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0005D66C File Offset: 0x0005B86C
		public virtual void SetInitializer(global::System.Type contextType, object initializer)
		{
			this._initializers.AddOrUpdate(contextType, initializer, (global::System.Type c, object i) => initializer);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x0005D6A5 File Offset: 0x0005B8A5
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x04000BB8 RID: 3000
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, object> _initializers = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, object>();
	}
}
