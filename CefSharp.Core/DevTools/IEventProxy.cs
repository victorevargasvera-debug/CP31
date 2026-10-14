using System;
using System.IO;
using System.Threading;

namespace CefSharp.DevTools
{
	// Token: 0x0200002C RID: 44
	internal interface IEventProxy : global::System.IDisposable
	{
		// Token: 0x06000225 RID: 549
		void Raise(object sender, string eventName, global::System.IO.Stream stream, global::System.Threading.SynchronizationContext syncContext);
	}
}
