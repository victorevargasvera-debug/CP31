using System;
using System.Runtime.CompilerServices;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor
{
	// Token: 0x0200018C RID: 396
	internal class DetailLogMessage : global::Gibraltar.Monitor.LogMessageBase
	{
		// Token: 0x06001092 RID: 4242 RVA: 0x0002E064 File Offset: 0x0002C264
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, string logSystem, string categoryName, int skipFrames, string detailsXml, string caption, string description, params object[] args) : this(severity, global::Gibraltar.Monitor.LogWriteMode.Queued, logSystem, categoryName, skipFrames + 1, detailsXml, caption, description, args)
		{
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002E08C File Offset: 0x0002C28C
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, string detailsXml, string caption, string description, params object[] args) : this(severity, writeMode, logSystem, categoryName, skipFrames + 1, null, false, detailsXml, caption, description, args)
		{
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002E0B8 File Offset: 0x0002C2B8
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public DetailLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity severity, global::Gibraltar.Monitor.LogWriteMode writeMode, string logSystem, string categoryName, int skipFrames, global::System.Exception exception, bool attributeToException, string detailsXml, string caption, string description, params object[] args) : base(severity, logSystem, categoryName, skipFrames + 1, false, attributeToException, exception)
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
