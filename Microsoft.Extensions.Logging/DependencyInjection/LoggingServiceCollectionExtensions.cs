using System;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

namespace Microsoft.Extensions.DependencyInjection
{
	// Token: 0x02000002 RID: 2
	public static class LoggingServiceCollectionExtensions
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddLogging(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			services.TryAdd(global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton<global::Microsoft.Extensions.Logging.ILoggerFactory, global::Microsoft.Extensions.Logging.LoggerFactory>());
			services.TryAdd(global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(typeof(global::Microsoft.Extensions.Logging.ILogger<>), typeof(global::Microsoft.Extensions.Logging.Logger<>)));
			return services;
		}
	}
}
