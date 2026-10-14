using System;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000004 RID: 4
	public interface ILoggerFactory : global::System.IDisposable
	{
		// Token: 0x06000009 RID: 9
		global::Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName);

		// Token: 0x0600000A RID: 10
		void AddProvider(global::Microsoft.Extensions.Logging.ILoggerProvider provider);
	}
}
