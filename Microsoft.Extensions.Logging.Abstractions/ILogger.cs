using System;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000003 RID: 3
	public interface ILogger
	{
		// Token: 0x06000006 RID: 6
		void Log<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter);

		// Token: 0x06000007 RID: 7
		bool IsEnabled(global::Microsoft.Extensions.Logging.LogLevel logLevel);

		// Token: 0x06000008 RID: 8
		global::System.IDisposable BeginScope<TState>(TState state);
	}
}
