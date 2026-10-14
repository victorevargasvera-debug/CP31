using System;
using Microsoft.Extensions.Logging.Abstractions.Internal;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000008 RID: 8
	public static class LoggerFactoryExtensions
	{
		// Token: 0x06000021 RID: 33 RVA: 0x0000238B File Offset: 0x0000058B
		public static global::Microsoft.Extensions.Logging.ILogger<T> CreateLogger<T>(this global::Microsoft.Extensions.Logging.ILoggerFactory factory)
		{
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			return new global::Microsoft.Extensions.Logging.Logger<T>(factory);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023A1 File Offset: 0x000005A1
		public static global::Microsoft.Extensions.Logging.ILogger CreateLogger(this global::Microsoft.Extensions.Logging.ILoggerFactory factory, global::System.Type type)
		{
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			if (type == null)
			{
				throw new global::System.ArgumentNullException("type");
			}
			return factory.CreateLogger(global::Microsoft.Extensions.Logging.Abstractions.Internal.TypeNameHelper.GetTypeDisplayName(type));
		}
	}
}
