using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x0200000B RID: 11
	internal static class WeakEventHandlerManager
	{
		// Token: 0x06000050 RID: 80 RVA: 0x00002BD4 File Offset: 0x00000DD4
		public static void CallWeakReferenceHandlers(object sender, global::System.Collections.Generic.List<global::System.WeakReference> handlers)
		{
			if (handlers != null)
			{
				global::System.EventHandler[] array = new global::System.EventHandler[handlers.Count];
				int num = 0;
				num = global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.CleanupOldHandlers(handlers, array, num);
				for (int i = 0; i < num; i++)
				{
					global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.CallHandler(sender, array[i]);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002C10 File Offset: 0x00000E10
		private static void CallHandler(object sender, global::System.EventHandler eventHandler)
		{
			global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.DispatcherProxy dispatcherProxy = global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.DispatcherProxy.CreateDispatcher();
			if (eventHandler != null)
			{
				if (dispatcherProxy != null && !dispatcherProxy.CheckAccess())
				{
					dispatcherProxy.BeginInvoke(new global::System.Action<object, global::System.EventHandler>(global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.CallHandler), new object[]
					{
						sender,
						eventHandler
					});
					return;
				}
				eventHandler(sender, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002C64 File Offset: 0x00000E64
		private static int CleanupOldHandlers(global::System.Collections.Generic.List<global::System.WeakReference> handlers, global::System.EventHandler[] callees, int count)
		{
			for (int i = handlers.Count - 1; i >= 0; i--)
			{
				global::System.WeakReference weakReference = handlers[i];
				global::System.EventHandler eventHandler = weakReference.Target as global::System.EventHandler;
				if (eventHandler == null)
				{
					handlers.RemoveAt(i);
				}
				else
				{
					callees[count] = eventHandler;
					count++;
				}
			}
			return count;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002CAE File Offset: 0x00000EAE
		public static void AddWeakReferenceHandler(ref global::System.Collections.Generic.List<global::System.WeakReference> handlers, global::System.EventHandler handler, int defaultListSize)
		{
			if (handlers == null)
			{
				handlers = ((defaultListSize > 0) ? new global::System.Collections.Generic.List<global::System.WeakReference>(defaultListSize) : new global::System.Collections.Generic.List<global::System.WeakReference>());
			}
			handlers.Add(new global::System.WeakReference(handler));
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002CD4 File Offset: 0x00000ED4
		public static void RemoveWeakReferenceHandler(global::System.Collections.Generic.List<global::System.WeakReference> handlers, global::System.EventHandler handler)
		{
			if (handlers != null)
			{
				for (int i = handlers.Count - 1; i >= 0; i--)
				{
					global::System.WeakReference weakReference = handlers[i];
					global::System.EventHandler eventHandler = weakReference.Target as global::System.EventHandler;
					if (eventHandler == null || eventHandler == handler)
					{
						handlers.RemoveAt(i);
					}
				}
			}
		}

		// Token: 0x0200000C RID: 12
		private class DispatcherProxy
		{
			// Token: 0x06000055 RID: 85 RVA: 0x00002D1E File Offset: 0x00000F1E
			private DispatcherProxy(global::System.Windows.Threading.Dispatcher dispatcher)
			{
				this.innerDispatcher = dispatcher;
			}

			// Token: 0x06000056 RID: 86 RVA: 0x00002D30 File Offset: 0x00000F30
			public static global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.DispatcherProxy CreateDispatcher()
			{
				if (global::System.Windows.Application.Current == null)
				{
					return null;
				}
				return new global::Microsoft.Practices.Prism.Commands.WeakEventHandlerManager.DispatcherProxy(global::System.Windows.Application.Current.Dispatcher);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00002D59 File Offset: 0x00000F59
			public bool CheckAccess()
			{
				return this.innerDispatcher.CheckAccess();
			}

			// Token: 0x06000058 RID: 88 RVA: 0x00002D66 File Offset: 0x00000F66
			public global::System.Windows.Threading.DispatcherOperation BeginInvoke(global::System.Delegate method, params object[] args)
			{
				return this.innerDispatcher.BeginInvoke(method, global::System.Windows.Threading.DispatcherPriority.Normal, args);
			}

			// Token: 0x04000016 RID: 22
			private global::System.Windows.Threading.Dispatcher innerDispatcher;
		}
	}
}
