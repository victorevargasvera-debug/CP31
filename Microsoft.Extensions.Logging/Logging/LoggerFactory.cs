using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000004 RID: 4
	public class LoggerFactory : global::Microsoft.Extensions.Logging.ILoggerFactory, global::System.IDisposable
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000022EC File Offset: 0x000004EC
		public global::Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName)
		{
			if (this.CheckDisposed())
			{
				throw new global::System.ObjectDisposedException("LoggerFactory");
			}
			object sync = this._sync;
			global::Microsoft.Extensions.Logging.Logger logger;
			lock (sync)
			{
				if (!this._loggers.TryGetValue(categoryName, out logger))
				{
					logger = new global::Microsoft.Extensions.Logging.Logger(this, categoryName);
					this._loggers[categoryName] = logger;
				}
			}
			return logger;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002360 File Offset: 0x00000560
		public void AddProvider(global::Microsoft.Extensions.Logging.ILoggerProvider provider)
		{
			if (this.CheckDisposed())
			{
				throw new global::System.ObjectDisposedException("LoggerFactory");
			}
			object sync = this._sync;
			lock (sync)
			{
				this._providers = this._providers.Concat(new global::Microsoft.Extensions.Logging.ILoggerProvider[]
				{
					provider
				}).ToArray<global::Microsoft.Extensions.Logging.ILoggerProvider>();
				foreach (global::System.Collections.Generic.KeyValuePair<string, global::Microsoft.Extensions.Logging.Logger> keyValuePair in this._loggers)
				{
					keyValuePair.Value.AddProvider(provider);
				}
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002414 File Offset: 0x00000614
		internal global::Microsoft.Extensions.Logging.ILoggerProvider[] GetProviders()
		{
			return this._providers;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000241C File Offset: 0x0000061C
		protected virtual bool CheckDisposed()
		{
			return this._disposed;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002428 File Offset: 0x00000628
		public void Dispose()
		{
			if (!this._disposed)
			{
				this._disposed = true;
				foreach (global::Microsoft.Extensions.Logging.ILoggerProvider loggerProvider in this._providers)
				{
					try
					{
						loggerProvider.Dispose();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private readonly global::System.Collections.Generic.Dictionary<string, global::Microsoft.Extensions.Logging.Logger> _loggers = new global::System.Collections.Generic.Dictionary<string, global::Microsoft.Extensions.Logging.Logger>(global::System.StringComparer.Ordinal);

		// Token: 0x04000005 RID: 5
		private global::Microsoft.Extensions.Logging.ILoggerProvider[] _providers = new global::Microsoft.Extensions.Logging.ILoggerProvider[0];

		// Token: 0x04000006 RID: 6
		private readonly object _sync = new object();

		// Token: 0x04000007 RID: 7
		private volatile bool _disposed;
	}
}
