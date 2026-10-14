using System;
using System.Runtime.CompilerServices;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x020001AB RID: 427
	internal class SimpleLogMessage : global::Gibraltar.Monitor.LogMessageBase
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x00037F6C File Offset: 0x0003616C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName, int skipFrames, string message, params object[] args) : this(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, logSystem, categoryName, skipFrames + 1, global::Gibraltar.Monitor.LogMessageBase.FirstException(args), message, args)
		{
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x00037F98 File Offset: 0x00036198
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, string message, params object[] args) : this(severity, writeMode, logSystem, categoryName, skipFrames + 1, global::Gibraltar.Monitor.LogMessageBase.FirstException(args), message, args)
		{
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x00037FC4 File Offset: 0x000361C4
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, global::System.Exception exception, string message, params object[] args) : base(severity, logSystem, categoryName, skipFrames + 1, false, false, null)
		{
			base.WriteMode = writeMode;
			base.Exception = exception;
			base.DetailsXml = null;
			base.Caption = null;
			base.Description = message;
			base.MessageArgs = args;
		}
	}
}
