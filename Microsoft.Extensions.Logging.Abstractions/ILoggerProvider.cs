using System;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000006 RID: 6
	public interface ILoggerProvider : global::System.IDisposable
	{
		// Token: 0x0600000B RID: 11
		global::Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName);
	}
}
