using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace NLog.Fluent
{
	// Token: 0x02000149 RID: 329
	public static class Log
	{
		// Token: 0x06000EC7 RID: 3783 RVA: 0x00025BAB File Offset: 0x00023DAB
		public static global::NLog.Fluent.LogBuilder Level(global::NLog.LogLevel logLevel, [global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(logLevel, callerFilePath);
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00025BB4 File Offset: 0x00023DB4
		public static global::NLog.Fluent.LogBuilder Trace([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Trace, callerFilePath);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00025BC1 File Offset: 0x00023DC1
		public static global::NLog.Fluent.LogBuilder Debug([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Debug, callerFilePath);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x00025BCE File Offset: 0x00023DCE
		public static global::NLog.Fluent.LogBuilder Info([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Info, callerFilePath);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x00025BDB File Offset: 0x00023DDB
		public static global::NLog.Fluent.LogBuilder Warn([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Warn, callerFilePath);
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00025BE8 File Offset: 0x00023DE8
		public static global::NLog.Fluent.LogBuilder Error([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Error, callerFilePath);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00025BF5 File Offset: 0x00023DF5
		public static global::NLog.Fluent.LogBuilder Fatal([global::System.Runtime.CompilerServices.CallerFilePath] string callerFilePath = null)
		{
			return global::NLog.Fluent.Log.Create(global::NLog.LogLevel.Fatal, callerFilePath);
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00025C04 File Offset: 0x00023E04
		private static global::NLog.Fluent.LogBuilder Create(global::NLog.LogLevel logLevel, string callerFilePath)
		{
			string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(callerFilePath ?? string.Empty);
			global::NLog.ILogger logger2;
			if (!string.IsNullOrWhiteSpace(fileNameWithoutExtension))
			{
				global::NLog.ILogger logger = global::NLog.LogManager.GetLogger(fileNameWithoutExtension);
				logger2 = logger;
			}
			else
			{
				logger2 = global::NLog.Fluent.Log._logger;
			}
			global::NLog.Fluent.LogBuilder logBuilder = new global::NLog.Fluent.LogBuilder(logger2, logLevel);
			if (callerFilePath != null)
			{
				logBuilder.Property("CallerFilePath", callerFilePath);
			}
			return logBuilder;
		}

		// Token: 0x04000414 RID: 1044
		private static readonly global::NLog.ILogger _logger = global::NLog.LogManager.GetCurrentClassLogger();
	}
}
