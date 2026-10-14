using System;
using Microsoft.Extensions.Logging.Abstractions.Internal;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x0200000A RID: 10
	public class Logger<T> : global::Microsoft.Extensions.Logging.ILogger<T>, global::Microsoft.Extensions.Logging.ILogger
	{
		// Token: 0x0600002F RID: 47 RVA: 0x000025D3 File Offset: 0x000007D3
		public Logger(global::Microsoft.Extensions.Logging.ILoggerFactory factory)
		{
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			this._logger = factory.CreateLogger(global::Microsoft.Extensions.Logging.Abstractions.Internal.TypeNameHelper.GetTypeDisplayName(typeof(T)));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002604 File Offset: 0x00000804
		global::System.IDisposable global::Microsoft.Extensions.Logging.ILogger.BeginScope<TState>(TState state)
		{
			return this._logger.BeginScope<TState>(state);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002612 File Offset: 0x00000812
		bool global::Microsoft.Extensions.Logging.ILogger.IsEnabled(global::Microsoft.Extensions.Logging.LogLevel logLevel)
		{
			return this._logger.IsEnabled(logLevel);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002620 File Offset: 0x00000820
		void global::Microsoft.Extensions.Logging.ILogger.Log<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter)
		{
			this._logger.Log<TState>(logLevel, eventId, state, exception, formatter);
		}

		// Token: 0x04000004 RID: 4
		private readonly global::Microsoft.Extensions.Logging.ILogger _logger;
	}
}
