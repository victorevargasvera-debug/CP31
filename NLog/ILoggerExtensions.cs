using System;

namespace NLog
{
	// Token: 0x02000008 RID: 8
	public static class ILoggerExtensions
	{
		// Token: 0x06000172 RID: 370 RVA: 0x000022AC File Offset: 0x000004AC
		[global::System.CLSCompliant(false)]
		public static void Log(this global::NLog.ILogger logger, global::NLog.LogLevel level, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsEnabled(level))
			{
				logger.Log(level, exception, messageFunc(), null);
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000022C6 File Offset: 0x000004C6
		[global::System.CLSCompliant(false)]
		public static void Trace(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsTraceEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Trace(exception, messageFunc());
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x000022EB File Offset: 0x000004EB
		[global::System.CLSCompliant(false)]
		public static void Debug(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsDebugEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Debug(exception, messageFunc());
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002310 File Offset: 0x00000510
		[global::System.CLSCompliant(false)]
		public static void Info(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsInfoEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Info(exception, messageFunc());
			}
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00002335 File Offset: 0x00000535
		[global::System.CLSCompliant(false)]
		public static void Warn(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsWarnEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Warn(exception, messageFunc());
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000235A File Offset: 0x0000055A
		[global::System.CLSCompliant(false)]
		public static void Error(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsErrorEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Error(exception, messageFunc());
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000237F File Offset: 0x0000057F
		[global::System.CLSCompliant(false)]
		public static void Fatal(this global::NLog.ILogger logger, global::System.Exception exception, global::NLog.LogMessageGenerator messageFunc)
		{
			if (logger.IsFatalEnabled)
			{
				if (messageFunc == null)
				{
					throw new global::System.ArgumentNullException("messageFunc");
				}
				logger.Fatal(exception, messageFunc());
			}
		}
	}
}
