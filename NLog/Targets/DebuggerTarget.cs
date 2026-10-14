using System;
using System.Diagnostics;
using System.Text;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000033 RID: 51
	[global::NLog.Targets.Target("Debugger")]
	public sealed class DebuggerTarget : global::NLog.Targets.TargetWithLayoutHeaderAndFooter
	{
		// Token: 0x06000547 RID: 1351 RVA: 0x0000B214 File Offset: 0x00009414
		public DebuggerTarget()
		{
			base.OptimizeBufferReuse = true;
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0000B223 File Offset: 0x00009423
		public DebuggerTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0000B232 File Offset: 0x00009432
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			if (base.Header != null)
			{
				global::System.Diagnostics.Debugger.Log(global::NLog.LogLevel.Off.Ordinal, string.Empty, base.RenderLogEvent(base.Header, global::NLog.LogEventInfo.CreateNullEvent()) + "\n");
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0000B271 File Offset: 0x00009471
		protected override void CloseTarget()
		{
			if (base.Footer != null)
			{
				global::System.Diagnostics.Debugger.Log(global::NLog.LogLevel.Off.Ordinal, string.Empty, base.RenderLogEvent(base.Footer, global::NLog.LogEventInfo.CreateNullEvent()) + "\n");
			}
			base.CloseTarget();
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000B2B0 File Offset: 0x000094B0
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (global::System.Diagnostics.Debugger.IsLogging())
			{
				string message = string.Empty;
				if (base.OptimizeBufferReuse)
				{
					using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
					{
						this.Layout.RenderAppendBuilder(logEvent, lockOject.Result, false);
						lockOject.Result.Append('\n');
						message = lockOject.Result.ToString();
						goto IL_79;
					}
				}
				message = base.RenderLogEvent(this.Layout, logEvent) + "\n";
				IL_79:
				global::System.Diagnostics.Debugger.Log(logEvent.Level.Ordinal, logEvent.LoggerName, message);
			}
		}
	}
}
