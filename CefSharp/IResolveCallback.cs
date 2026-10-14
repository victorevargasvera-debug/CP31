using System;
using System.Collections.Generic;

namespace CefSharp
{
	// Token: 0x02000012 RID: 18
	public interface IResolveCallback : global::System.IDisposable
	{
		// Token: 0x06000035 RID: 53
		void OnResolveCompleted(global::CefSharp.CefErrorCode result, global::System.Collections.Generic.IList<string> resolvedIpAddresses);

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54
		bool IsDisposed { get; }
	}
}
