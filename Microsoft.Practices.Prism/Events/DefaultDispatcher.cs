using System;
using System.Windows;
using System.Windows.Threading;

namespace Microsoft.Practices.Prism.Events
{
	// Token: 0x02000014 RID: 20
	public class DefaultDispatcher : global::Microsoft.Practices.Prism.Events.IDispatcherFacade
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00003463 File Offset: 0x00001663
		public void BeginInvoke(global::System.Delegate method, object arg)
		{
			if (global::System.Windows.Application.Current != null)
			{
				global::System.Windows.Application.Current.Dispatcher.BeginInvoke(global::System.Windows.Threading.DispatcherPriority.Normal, method, arg);
			}
		}
	}
}
