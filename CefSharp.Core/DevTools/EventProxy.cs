using System;
using System.IO;
using System.Threading;

namespace CefSharp.DevTools
{
	// Token: 0x0200002A RID: 42
	internal class EventProxy<T> : global::CefSharp.DevTools.IEventProxy, global::System.IDisposable
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000217 RID: 535 RVA: 0x00004E48 File Offset: 0x00003048
		// (remove) Token: 0x06000218 RID: 536 RVA: 0x00004E80 File Offset: 0x00003080
		private event global::System.EventHandler<T> handlers;

		// Token: 0x06000219 RID: 537 RVA: 0x00004EB5 File Offset: 0x000030B5
		public EventProxy(global::System.Func<string, global::System.IO.Stream, T> convert)
		{
			this.convert = convert;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00004EC4 File Offset: 0x000030C4
		public void AddHandler(global::System.EventHandler<T> handler)
		{
			this.handlers += handler;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00004ECD File Offset: 0x000030CD
		public bool RemoveHandler(global::System.EventHandler<T> handler)
		{
			this.handlers -= handler;
			return this.handlers == null;
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00004EE0 File Offset: 0x000030E0
		public void Raise(object sender, string eventName, global::System.IO.Stream stream, global::System.Threading.SynchronizationContext syncContext)
		{
			stream.Position = 0L;
			T args = this.convert(eventName, stream);
			if (syncContext != null)
			{
				syncContext.Post(delegate(object state)
				{
					global::System.EventHandler<T> eventHandler2 = this.handlers;
					if (eventHandler2 == null)
					{
						return;
					}
					eventHandler2(sender, args);
				}, null);
				return;
			}
			global::System.EventHandler<T> eventHandler = this.handlers;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(sender, args);
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00004F51 File Offset: 0x00003151
		public void Dispose()
		{
			this.handlers = null;
		}

		// Token: 0x04000065 RID: 101
		private global::System.Func<string, global::System.IO.Stream, T> convert;
	}
}
