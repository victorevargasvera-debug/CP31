using System;
using Microsoft.Extensions.Logging.Abstractions.Internal;

namespace Microsoft.Extensions.Logging.Abstractions
{
	// Token: 0x0200000E RID: 14
	public class NullLogger : global::Microsoft.Extensions.Logging.ILogger
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00002A42 File Offset: 0x00000C42
		public static global::Microsoft.Extensions.Logging.Abstractions.NullLogger Instance { get; } = new global::Microsoft.Extensions.Logging.Abstractions.NullLogger();

		// Token: 0x06000045 RID: 69 RVA: 0x00002A49 File Offset: 0x00000C49
		private NullLogger()
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002A51 File Offset: 0x00000C51
		public global::System.IDisposable BeginScope<TState>(TState state)
		{
			return global::Microsoft.Extensions.Logging.Abstractions.Internal.NullScope.Instance;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002A58 File Offset: 0x00000C58
		public bool IsEnabled(global::Microsoft.Extensions.Logging.LogLevel logLevel)
		{
			return false;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002A5B File Offset: 0x00000C5B
		public void Log<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter)
		{
		}
	}
}
