using System;
using Microsoft.Extensions.Logging.Internal;

namespace Microsoft.Extensions.Logging
{
	// Token: 0x02000007 RID: 7
	public static class LoggerExtensions
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002095 File Offset: 0x00000295
		public static void LogDebug(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Debug, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000020BB File Offset: 0x000002BB
		public static void LogDebug(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Debug, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020E0 File Offset: 0x000002E0
		public static void LogDebug(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Debug, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000210A File Offset: 0x0000030A
		public static void LogTrace(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Trace, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002130 File Offset: 0x00000330
		public static void LogTrace(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Trace, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002155 File Offset: 0x00000355
		public static void LogTrace(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Trace, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000217F File Offset: 0x0000037F
		public static void LogInformation(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Information, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000021A5 File Offset: 0x000003A5
		public static void LogInformation(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Information, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021CA File Offset: 0x000003CA
		public static void LogInformation(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Information, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021F4 File Offset: 0x000003F4
		public static void LogWarning(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Warning, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000221A File Offset: 0x0000041A
		public static void LogWarning(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Warning, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000223F File Offset: 0x0000043F
		public static void LogWarning(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Warning, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002269 File Offset: 0x00000469
		public static void LogError(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Error, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000228F File Offset: 0x0000048F
		public static void LogError(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Error, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000022B4 File Offset: 0x000004B4
		public static void LogError(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Error, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000022DE File Offset: 0x000004DE
		public static void LogCritical(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, global::System.Exception exception, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Critical, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), exception, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002304 File Offset: 0x00000504
		public static void LogCritical(this global::Microsoft.Extensions.Logging.ILogger logger, global::Microsoft.Extensions.Logging.EventId eventId, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Critical, eventId, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002329 File Offset: 0x00000529
		public static void LogCritical(this global::Microsoft.Extensions.Logging.ILogger logger, string message, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			logger.Log<object>(global::Microsoft.Extensions.Logging.LogLevel.Critical, 0, new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(message, args), null, global::Microsoft.Extensions.Logging.LoggerExtensions._messageFormatter);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002353 File Offset: 0x00000553
		public static global::System.IDisposable BeginScope(this global::Microsoft.Extensions.Logging.ILogger logger, string messageFormat, params object[] args)
		{
			if (logger == null)
			{
				throw new global::System.ArgumentNullException("logger");
			}
			return logger.BeginScope<global::Microsoft.Extensions.Logging.Internal.FormattedLogValues>(new global::Microsoft.Extensions.Logging.Internal.FormattedLogValues(messageFormat, args));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002370 File Offset: 0x00000570
		private static string MessageFormatter(object state, global::System.Exception error)
		{
			return state.ToString();
		}

		// Token: 0x04000003 RID: 3
		private static readonly global::System.Func<object, global::System.Exception, string> _messageFormatter = new global::System.Func<object, global::System.Exception, string>(global::Microsoft.Extensions.Logging.LoggerExtensions.MessageFormatter);
	}
}
