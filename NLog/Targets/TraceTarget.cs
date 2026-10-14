using System;
using System.ComponentModel;
using System.Diagnostics;

namespace NLog.Targets
{
	// Token: 0x02000056 RID: 86
	[global::NLog.Targets.Target("Trace")]
	public sealed class TraceTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00012EB5 File Offset: 0x000110B5
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00012EBD File Offset: 0x000110BD
		[global::System.ComponentModel.DefaultValue(false)]
		public bool RawWrite { get; set; }

		// Token: 0x0600077E RID: 1918 RVA: 0x00012EC6 File Offset: 0x000110C6
		public TraceTarget()
		{
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00012ED5 File Offset: 0x000110D5
		public TraceTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x00012EE4 File Offset: 0x000110E4
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			string message = base.RenderLogEvent(this.Layout, logEvent);
			if (this.RawWrite || logEvent.Level <= global::NLog.LogLevel.Debug)
			{
				global::System.Diagnostics.Trace.WriteLine(message);
				return;
			}
			if (logEvent.Level == global::NLog.LogLevel.Info)
			{
				global::System.Diagnostics.Trace.TraceInformation(message);
				return;
			}
			if (logEvent.Level == global::NLog.LogLevel.Warn)
			{
				global::System.Diagnostics.Trace.TraceWarning(message);
				return;
			}
			if (logEvent.Level == global::NLog.LogLevel.Error)
			{
				global::System.Diagnostics.Trace.TraceError(message);
				return;
			}
			if (logEvent.Level >= global::NLog.LogLevel.Fatal)
			{
				global::System.Diagnostics.Trace.Fail(message);
				return;
			}
			global::System.Diagnostics.Trace.WriteLine(message);
		}
	}
}
