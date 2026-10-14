using System;

namespace CefSharp
{
	// Token: 0x02000052 RID: 82
	public interface IBrowserProcessHandler : global::System.IDisposable
	{
		// Token: 0x0600012C RID: 300
		void OnContextInitialized();

		// Token: 0x0600012D RID: 301
		void OnScheduleMessagePumpWork(long delay);
	}
}
