using System;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000C1 RID: 193
	public interface IPropertyInterceptor
	{
		// Token: 0x060005BC RID: 1468
		object InterceptGet(global::System.Func<object> propertyGetter, string propertName);

		// Token: 0x060005BD RID: 1469
		void InterceptSet(global::System.Action<object> propertySetter, object parameter, string propertName);
	}
}
