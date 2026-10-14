using System;
using System.Collections.Generic;
using System.Threading;

namespace CefSharp.DevTools
{
	// Token: 0x02000029 RID: 41
	internal struct DevToolsMethodResponseContext
	{
		// Token: 0x06000213 RID: 531 RVA: 0x00004DA7 File Offset: 0x00002FA7
		public DevToolsMethodResponseContext(global::System.Type type, global::System.Func<object, bool> setResult, global::System.Func<global::System.Exception, bool> setException, global::System.Threading.SynchronizationContext syncContext)
		{
			this.Type = type;
			this.setResult = setResult;
			this.setException = setException;
			this.syncContext = syncContext;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00004DC6 File Offset: 0x00002FC6
		public void SetResult(object result)
		{
			this.InvokeOnSyncContext<object>(this.setResult, result);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00004DD5 File Offset: 0x00002FD5
		public void SetException(global::System.Exception ex)
		{
			this.InvokeOnSyncContext<global::System.Exception>(this.setException, ex);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00004DE4 File Offset: 0x00002FE4
		private void InvokeOnSyncContext<T>(global::System.Func<T, bool> fn, T value)
		{
			if (this.syncContext == null || this.syncContext == global::System.Threading.SynchronizationContext.Current)
			{
				fn(value);
				return;
			}
			this.syncContext.Post(delegate(object state)
			{
				global::System.Collections.Generic.KeyValuePair<global::System.Func<T, bool>, T> keyValuePair = (global::System.Collections.Generic.KeyValuePair<global::System.Func<T, bool>, T>)state;
				keyValuePair.Key(keyValuePair.Value);
			}, new global::System.Collections.Generic.KeyValuePair<global::System.Func<T, bool>, T>(fn, value));
		}

		// Token: 0x04000060 RID: 96
		public readonly global::System.Type Type;

		// Token: 0x04000061 RID: 97
		private readonly global::System.Func<object, bool> setResult;

		// Token: 0x04000062 RID: 98
		private readonly global::System.Func<global::System.Exception, bool> setException;

		// Token: 0x04000063 RID: 99
		private readonly global::System.Threading.SynchronizationContext syncContext;
	}
}
