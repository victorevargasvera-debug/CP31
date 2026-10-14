using System;
using System.Collections.Generic;

namespace Microsoft.Practices.ServiceLocation
{
	// Token: 0x02000003 RID: 3
	public interface IServiceLocator : global::System.IServiceProvider
	{
		// Token: 0x06000005 RID: 5
		object GetInstance(global::System.Type serviceType);

		// Token: 0x06000006 RID: 6
		object GetInstance(global::System.Type serviceType, string key);

		// Token: 0x06000007 RID: 7
		global::System.Collections.Generic.IEnumerable<object> GetAllInstances(global::System.Type serviceType);

		// Token: 0x06000008 RID: 8
		TService GetInstance<TService>();

		// Token: 0x06000009 RID: 9
		TService GetInstance<TService>(string key);

		// Token: 0x0600000A RID: 10
		global::System.Collections.Generic.IEnumerable<TService> GetAllInstances<TService>();
	}
}
