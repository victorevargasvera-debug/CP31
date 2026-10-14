using System;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism
{
	// Token: 0x0200008A RID: 138
	public static class ServiceLocatorExtensions
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x0000A528 File Offset: 0x00008728
		public static object TryResolve(this global::Microsoft.Practices.ServiceLocation.IServiceLocator locator, global::System.Type type)
		{
			if (locator == null)
			{
				throw new global::System.ArgumentNullException("locator");
			}
			object result;
			try
			{
				result = locator.GetInstance(type);
			}
			catch (global::Microsoft.Practices.ServiceLocation.ActivationException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000A564 File Offset: 0x00008764
		public static T TryResolve<T>(this global::Microsoft.Practices.ServiceLocation.IServiceLocator locator) where T : class
		{
			return locator.TryResolve(typeof(T)) as T;
		}
	}
}
