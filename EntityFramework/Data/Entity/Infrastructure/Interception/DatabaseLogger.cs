using System;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Utilities;
using System.IO;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000277 RID: 631
	public class DatabaseLogger : global::System.IDisposable, global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x06001FD8 RID: 8152 RVA: 0x00059D19 File Offset: 0x00057F19
		public DatabaseLogger()
		{
		}

		// Token: 0x06001FD9 RID: 8153 RVA: 0x00059D2C File Offset: 0x00057F2C
		public DatabaseLogger(string path) : this(path, false)
		{
		}

		// Token: 0x06001FDA RID: 8154 RVA: 0x00059D36 File Offset: 0x00057F36
		public DatabaseLogger(string path, bool append)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(path, "path");
			this._writer = new global::System.IO.StreamWriter(path, append)
			{
				AutoFlush = true
			};
		}

		// Token: 0x06001FDB RID: 8155 RVA: 0x00059D69 File Offset: 0x00057F69
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x00059D78 File Offset: 0x00057F78
		protected virtual void Dispose(bool disposing)
		{
			this.StopLogging();
			if (disposing && this._writer != null)
			{
				this._writer.Dispose();
				this._writer = null;
			}
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x00059D9D File Offset: 0x00057F9D
		public void StartLogging()
		{
			this.StartLogging(global::System.Data.Entity.DbConfiguration.DependencyResolver);
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x00059DAA File Offset: 0x00057FAA
		public void StopLogging()
		{
			if (this._formatter != null)
			{
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Remove(this._formatter);
				this._formatter = null;
			}
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x00059DC6 File Offset: 0x00057FC6
		void global::System.Data.Entity.Infrastructure.Interception.IDbConfigurationInterceptor.Loaded(global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs loadedEventArgs, global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext interceptionContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs>(loadedEventArgs, "loadedEventArgs");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.Interception.DbConfigurationInterceptionContext>(interceptionContext, "interceptionContext");
			this.StartLogging(loadedEventArgs.DependencyResolver);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x00059DEC File Offset: 0x00057FEC
		private void StartLogging(global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver resolver)
		{
			if (this._formatter == null)
			{
				this._formatter = resolver.GetService<global::System.Func<global::System.Data.Entity.DbContext, global::System.Action<string>, global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter>>()(null, (this._writer == null) ? new global::System.Action<string>(global::System.Console.Write) : new global::System.Action<string>(this.WriteThreadSafe));
				global::System.Data.Entity.Infrastructure.Interception.DbInterception.Add(this._formatter);
			}
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00059E40 File Offset: 0x00058040
		private void WriteThreadSafe(string value)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				this._writer.Write(value);
			}
		}

		// Token: 0x04000B72 RID: 2930
		private global::System.IO.TextWriter _writer;

		// Token: 0x04000B73 RID: 2931
		private global::System.Data.Entity.Infrastructure.Interception.DatabaseLogFormatter _formatter;

		// Token: 0x04000B74 RID: 2932
		private readonly object _lock = new object();
	}
}
