using System;
using System.Runtime.CompilerServices;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x02000185 RID: 389
	internal class BasicLogMessage : global::Gibraltar.Monitor.LogMessageBase
	{
		// Token: 0x06001046 RID: 4166 RVA: 0x0002D0F8 File Offset: 0x0002B2F8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName, int skipFrames, string caption, string description, params object[] args) : this(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, logSystem, categoryName, skipFrames + 1, null, false, caption, description, args)
		{
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x0002D120 File Offset: 0x0002B320
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, string caption, string description, params object[] args) : this(severity, writeMode, logSystem, categoryName, skipFrames + 1, null, false, caption, description, args)
		{
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x0002D148 File Offset: 0x0002B348
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public BasicLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, global::System.Exception exception, bool attributeToException, string caption, string description, params object[] args) : base(severity, logSystem, categoryName, skipFrames + 1, false, attributeToException, exception)
		{
			base.WriteMode = writeMode;
			base.Exception = exception;
			base.DetailsXml = null;
			base.Caption = caption;
			base.Description = description;
			base.MessageArgs = args;
		}
	}
}
