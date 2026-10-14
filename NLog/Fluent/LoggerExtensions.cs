using System;

namespace NLog.Fluent
{
	// Token: 0x0200014B RID: 331
	public static class LoggerExtensions
	{
		// Token: 0x06000EE4 RID: 3812 RVA: 0x0002604D File Offset: 0x0002424D
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Log(this global::NLog.ILogger logger, global::NLog.LogLevel logLevel)
		{
			return new global::NLog.Fluent.LogBuilder(logger, logLevel);
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00026056 File Offset: 0x00024256
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Trace(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Trace);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x00026063 File Offset: 0x00024263
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Debug(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Debug);
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x00026070 File Offset: 0x00024270
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Info(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Info);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x0002607D File Offset: 0x0002427D
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Warn(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Warn);
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x0002608A File Offset: 0x0002428A
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Error(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Error);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00026097 File Offset: 0x00024297
		[global::System.CLSCompliant(false)]
		public static global::NLog.Fluent.LogBuilder Fatal(this global::NLog.ILogger logger)
		{
			return new global::NLog.Fluent.LogBuilder(logger, global::NLog.LogLevel.Fatal);
		}
	}
}
