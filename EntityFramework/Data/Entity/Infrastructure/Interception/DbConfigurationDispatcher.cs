using System;
using System.Data.Entity.Infrastructure.DependencyResolution;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027E RID: 638
	internal class DbConfigurationDispatcher
	{
		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06002034 RID: 8244 RVA: 0x0005A62D File Offset: 0x0005882D
		public global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x0005A638 File Offset: 0x00058838
		public virtual void Loaded(global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs loadedEventArgs, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext clonedInterceptionContext = new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext(interceptionContext);
			this._internalDispatcher.Dispatch(delegate(global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor i)
			{
				i.Loaded(loadedEventArgs, clonedInterceptionContext);
			});
		}

		// Token: 0x04000B7A RID: 2938
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor>();
	}
}
