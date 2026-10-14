using System;

namespace Microsoft.Practices.ServiceLocation
{
	// Token: 0x02000005 RID: 5
	public static class ServiceLocator
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000217A File Offset: 0x0000117A
		public static global::Microsoft.Practices.ServiceLocation.IServiceLocator Current
		{
			get
			{
				return global::Microsoft.Practices.ServiceLocation.ServiceLocator.currentProvider();
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002186 File Offset: 0x00001186
		public static void SetLocatorProvider(global::Microsoft.Practices.ServiceLocation.ServiceLocatorProvider newProvider)
		{
			global::Microsoft.Practices.ServiceLocation.ServiceLocator.currentProvider = newProvider;
		}

		// Token: 0x04000003 RID: 3
		private static global::Microsoft.Practices.ServiceLocation.ServiceLocatorProvider currentProvider;
	}
}
