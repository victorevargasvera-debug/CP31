using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging.Abstractions.Internal;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000003 RID: 3
	internal class Logger : global::Microsoft.Extensions.Logging.ILogger
	{
		// Token: 0x06000002 RID: 2 RVA: 0x0000208C File Offset: 0x0000028C
		public Logger(global::Microsoft.Extensions.Logging.LoggerFactory loggerFactory, string name)
		{
			this._loggerFactory = loggerFactory;
			this._name = name;
			global::Microsoft.Extensions.Logging.ILoggerProvider[] providers = loggerFactory.GetProviders();
			if (providers.Length != 0)
			{
				this._loggers = new global::Microsoft.Extensions.Logging.ILogger[providers.Length];
				for (int i = 0; i < providers.Length; i++)
				{
					this._loggers[i] = providers[i].CreateLogger(name);
				}
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020E8 File Offset: 0x000002E8
		public void Log<TState>(global::Microsoft.Extensions.Logging.LogLevel logLevel, global::Microsoft.Extensions.Logging.EventId eventId, TState state, global::System.Exception exception, global::System.Func<TState, global::System.Exception, string> formatter)
		{
			if (this._loggers == null)
			{
				return;
			}
			global::System.Collections.Generic.List<global::System.Exception> list = null;
			foreach (global::Microsoft.Extensions.Logging.ILogger logger in this._loggers)
			{
				try
				{
					logger.Log<TState>(logLevel, eventId, state, exception, formatter);
				}
				catch (global::System.Exception item)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Exception>();
					}
					list.Add(item);
				}
			}
			if (list != null && list.Count > 0)
			{
				throw new global::System.AggregateException("An error occurred while writing to logger(s).", list);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002168 File Offset: 0x00000368
		public bool IsEnabled(global::Microsoft.Extensions.Logging.LogLevel logLevel)
		{
			if (this._loggers == null)
			{
				return false;
			}
			global::System.Collections.Generic.List<global::System.Exception> list = null;
			foreach (global::Microsoft.Extensions.Logging.ILogger logger in this._loggers)
			{
				try
				{
					if (logger.IsEnabled(logLevel))
					{
						return true;
					}
				}
				catch (global::System.Exception item)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Exception>();
					}
					list.Add(item);
				}
			}
			if (list != null && list.Count > 0)
			{
				throw new global::System.AggregateException("An error occurred while writing to logger(s).", list);
			}
			return false;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021EC File Offset: 0x000003EC
		public global::System.IDisposable BeginScope<TState>(TState state)
		{
			if (this._loggers == null)
			{
				return global::Microsoft.Extensions.Logging.Abstractions.Internal.NullScope.Instance;
			}
			if (this._loggers.Length == 1)
			{
				return this._loggers[0].BeginScope<TState>(state);
			}
			global::Microsoft.Extensions.Logging.ILogger[] loggers = this._loggers;
			global::Microsoft.Extensions.Logging.Logger.Scope scope = new global::Microsoft.Extensions.Logging.Logger.Scope(loggers.Length);
			global::System.Collections.Generic.List<global::System.Exception> list = null;
			for (int i = 0; i < loggers.Length; i++)
			{
				try
				{
					global::System.IDisposable disposable = loggers[i].BeginScope<TState>(state);
					scope.SetDisposable(i, disposable);
				}
				catch (global::System.Exception item)
				{
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<global::System.Exception>();
					}
					list.Add(item);
				}
			}
			if (list != null && list.Count > 0)
			{
				throw new global::System.AggregateException("An error occurred while writing to logger(s).", list);
			}
			return scope;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002298 File Offset: 0x00000498
		internal void AddProvider(global::Microsoft.Extensions.Logging.ILoggerProvider provider)
		{
			global::Microsoft.Extensions.Logging.ILogger logger = provider.CreateLogger(this._name);
			int num;
			if (this._loggers == null)
			{
				num = 0;
				this._loggers = new global::Microsoft.Extensions.Logging.ILogger[1];
			}
			else
			{
				num = this._loggers.Length;
				global::System.Array.Resize<global::Microsoft.Extensions.Logging.ILogger>(ref this._loggers, num + 1);
			}
			this._loggers[num] = logger;
		}

		// Token: 0x04000001 RID: 1
		private readonly global::Microsoft.Extensions.Logging.LoggerFactory _loggerFactory;

		// Token: 0x04000002 RID: 2
		private readonly string _name;

		// Token: 0x04000003 RID: 3
		private global::Microsoft.Extensions.Logging.ILogger[] _loggers;

		// Token: 0x02000005 RID: 5
		private class Scope : global::System.IDisposable
		{
			// Token: 0x0600000D RID: 13 RVA: 0x000024AB File Offset: 0x000006AB
			public Scope(int count)
			{
				if (count > 2)
				{
					this._disposable = new global::System.IDisposable[count - 2];
				}
			}

			// Token: 0x0600000E RID: 14 RVA: 0x000024C5 File Offset: 0x000006C5
			public void SetDisposable(int index, global::System.IDisposable disposable)
			{
				if (index == 0)
				{
					this._disposable0 = disposable;
					return;
				}
				if (index == 1)
				{
					this._disposable1 = disposable;
					return;
				}
				this._disposable[index - 2] = disposable;
			}

			// Token: 0x0600000F RID: 15 RVA: 0x000024EC File Offset: 0x000006EC
			public void Dispose()
			{
				if (!this._isDisposed)
				{
					if (this._disposable0 != null)
					{
						this._disposable0.Dispose();
					}
					if (this._disposable1 != null)
					{
						this._disposable1.Dispose();
					}
					if (this._disposable != null)
					{
						int num = this._disposable.Length;
						for (int num2 = 0; num2 != num; num2++)
						{
							if (this._disposable[num2] != null)
							{
								this._disposable[num2].Dispose();
							}
						}
					}
					this._isDisposed = true;
				}
			}

			// Token: 0x06000010 RID: 16 RVA: 0x00002562 File Offset: 0x00000762
			internal void Add(global::System.IDisposable disposable)
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04000008 RID: 8
			private bool _isDisposed;

			// Token: 0x04000009 RID: 9
			private global::System.IDisposable _disposable0;

			// Token: 0x0400000A RID: 10
			private global::System.IDisposable _disposable1;

			// Token: 0x0400000B RID: 11
			private readonly global::System.IDisposable[] _disposable;
		}
	}
}
