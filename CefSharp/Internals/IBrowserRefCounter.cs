using System;
using System.Threading;

namespace CefSharp.Internals
{
	// Token: 0x020000D6 RID: 214
	public interface IBrowserRefCounter : global::System.IDisposable
	{
		// Token: 0x06000642 RID: 1602
		void Increment(global::System.Type type);

		// Token: 0x06000643 RID: 1603
		bool Decrement(global::System.Type type);

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000644 RID: 1604
		int Count { get; }

		// Token: 0x06000645 RID: 1605
		void EnableLogging();

		// Token: 0x06000646 RID: 1606
		string GetLog();

		// Token: 0x06000647 RID: 1607
		void WaitForBrowsersToClose(int timeoutInMiliseconds = 500);

		// Token: 0x06000648 RID: 1608
		void WaitForBrowsersToClose(int timeoutInMiliseconds, global::System.Threading.CancellationToken cancellationToken);
	}
}
