using System;
using System.Runtime.CompilerServices;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000192 RID: 402
	internal class LocalLogMessage : global::Gibraltar.Monitor.LogMessageBase
	{
		// Token: 0x060010F1 RID: 4337 RVA: 0x000301F0 File Offset: 0x0002E3F0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal LocalLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName, int skipFrames, string detailsXml, string caption, string description, params object[] args) : this(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, logSystem, categoryName, skipFrames + 1, detailsXml, caption, description, args)
		{
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x00030218 File Offset: 0x0002E418
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal LocalLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, string detailsXml, string caption, string description, params object[] args) : this(severity, writeMode, logSystem, categoryName, skipFrames + 1, null, false, detailsXml, caption, description, args)
		{
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x00030244 File Offset: 0x0002E444
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal LocalLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, global::System.Exception exception, bool attributeToException, string detailsXml, string caption, string description, params object[] args) : base(severity, logSystem, categoryName, skipFrames + 1, true, attributeToException, exception)
		{
			base.WriteMode = writeMode;
			base.Exception = exception;
			base.DetailsXml = detailsXml;
			base.Caption = caption;
			base.Description = description;
			base.MessageArgs = args;
		}
	}
}
