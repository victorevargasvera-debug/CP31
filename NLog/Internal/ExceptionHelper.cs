using System;
using System.Threading;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x020000FF RID: 255
	internal static class ExceptionHelper
	{
		// Token: 0x06000CC5 RID: 3269 RVA: 0x0001F4AC File Offset: 0x0001D6AC
		public static void MarkAsLoggedToInternalLogger(this global::System.Exception exception)
		{
			if (exception != null)
			{
				exception.Data["NLog.ExceptionLoggedToInternalLogger"] = true;
			}
		}

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0001F4C8 File Offset: 0x0001D6C8
		public static bool IsLoggedToInternalLogger(this global::System.Exception exception)
		{
			return exception != null && ((exception.Data["NLog.ExceptionLoggedToInternalLogger"] as bool?) ?? false);
		}

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0001F508 File Offset: 0x0001D708
		public static bool MustBeRethrown(this global::System.Exception exception)
		{
			if (exception.MustBeRethrownImmediately())
			{
				return true;
			}
			bool flag = exception is global::NLog.NLogConfigurationException;
			if (!exception.IsLoggedToInternalLogger())
			{
				global::NLog.LogLevel level = flag ? global::NLog.LogLevel.Warn : global::NLog.LogLevel.Error;
				global::NLog.Common.InternalLogger.Log(exception, level, "Error has been raised.");
			}
			if (!flag)
			{
				return global::NLog.LogManager.ThrowExceptions;
			}
			bool? throwConfigExceptions = global::NLog.LogManager.ThrowConfigExceptions;
			if (throwConfigExceptions == null)
			{
				return global::NLog.LogManager.ThrowExceptions;
			}
			return throwConfigExceptions.GetValueOrDefault();
		}

		// Token: 0x06000CC8 RID: 3272 RVA: 0x0001F572 File Offset: 0x0001D772
		public static bool MustBeRethrownImmediately(this global::System.Exception exception)
		{
			return exception is global::System.StackOverflowException || exception is global::System.Threading.ThreadAbortException || exception is global::System.OutOfMemoryException;
		}

		// Token: 0x04000388 RID: 904
		private const string LoggedKey = "NLog.ExceptionLoggedToInternalLogger";
	}
}
