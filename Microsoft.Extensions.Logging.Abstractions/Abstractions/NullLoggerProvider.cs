using System;

namespace Microsoft.Extensions.Logging.Abstractions
{
	// Token: 0x0200000F RID: 15
	public class NullLoggerProvider : global::Microsoft.Extensions.Logging.ILoggerProvider, global::System.IDisposable
	{
		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002A69 File Offset: 0x00000C69
		public static global::Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider Instance { get; } = new global::Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider();

		// Token: 0x0600004B RID: 75 RVA: 0x00002A49 File Offset: 0x00000C49
		private NullLoggerProvider()
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002A70 File Offset: 0x00000C70
		public global::Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName)
		{
			return global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002A5B File Offset: 0x00000C5B
		public void Dispose()
		{
		}
	}
}
