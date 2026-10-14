using System;
using System.Data.Entity.Infrastructure.DependencyResolution;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200028F RID: 655
	public interface IDbConfigurationInterceptor : global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x060020CC RID: 8396
		void Loaded(global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs loadedEventArgs, global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext interceptionContext);
	}
}
