using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BD RID: 701
	public class SingletonDependencyResolver<T> : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver where T : class
	{
		// Token: 0x06002209 RID: 8713 RVA: 0x0005EC1A File Offset: 0x0005CE1A
		public SingletonDependencyResolver(T singletonInstance) : this(singletonInstance, null)
		{
		}

		// Token: 0x0600220A RID: 8714 RVA: 0x0005EC24 File Offset: 0x0005CE24
		public SingletonDependencyResolver(T singletonInstance, object key)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<T>(singletonInstance, "singletonInstance");
			this._singletonInstance = singletonInstance;
			this._keyPredicate = ((object k) => key == null || object.Equals(key, k));
		}

		// Token: 0x0600220B RID: 8715 RVA: 0x0005EC69 File Offset: 0x0005CE69
		public SingletonDependencyResolver(T singletonInstance, global::System.Func<object, bool> keyPredicate)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<T>(singletonInstance, "singletonInstance");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<object, bool>>(keyPredicate, "keyPredicate");
			this._singletonInstance = singletonInstance;
			this._keyPredicate = keyPredicate;
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0005EC98 File Offset: 0x0005CE98
		public object GetService(global::System.Type type, object key)
		{
			return (type == typeof(T) && this._keyPredicate(key)) ? this._singletonInstance : default(T);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0005ECDB File Offset: 0x0005CEDB
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x04000BD6 RID: 3030
		private readonly T _singletonInstance;

		// Token: 0x04000BD7 RID: 3031
		private readonly global::System.Func<object, bool> _keyPredicate;
	}
}
