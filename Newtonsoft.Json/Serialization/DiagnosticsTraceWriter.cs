using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000078 RID: 120
	public class DiagnosticsTraceWriter : global::Newtonsoft.Json.Serialization.ITraceWriter
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x0001B8E4 File Offset: 0x00019AE4
		// (set) Token: 0x06000662 RID: 1634 RVA: 0x0001B8EC File Offset: 0x00019AEC
		public global::System.Diagnostics.TraceLevel LevelFilter { get; set; }

		// Token: 0x06000663 RID: 1635 RVA: 0x0001B8F5 File Offset: 0x00019AF5
		private global::System.Diagnostics.TraceEventType GetTraceEventType(global::System.Diagnostics.TraceLevel level)
		{
			switch (level)
			{
			case global::System.Diagnostics.TraceLevel.Error:
				return global::System.Diagnostics.TraceEventType.Error;
			case global::System.Diagnostics.TraceLevel.Warning:
				return global::System.Diagnostics.TraceEventType.Warning;
			case global::System.Diagnostics.TraceLevel.Info:
				return global::System.Diagnostics.TraceEventType.Information;
			case global::System.Diagnostics.TraceLevel.Verbose:
				return global::System.Diagnostics.TraceEventType.Verbose;
			default:
				throw new global::System.ArgumentOutOfRangeException("level");
			}
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x0001B924 File Offset: 0x00019B24
		[global::System.Runtime.CompilerServices.NullableContext(1)]
		public void Trace(global::System.Diagnostics.TraceLevel level, string message, [global::System.Runtime.CompilerServices.Nullable(2)] global::System.Exception ex)
		{
			if (level == global::System.Diagnostics.TraceLevel.Off)
			{
				return;
			}
			global::System.Diagnostics.TraceEventCache eventCache = new global::System.Diagnostics.TraceEventCache();
			global::System.Diagnostics.TraceEventType traceEventType = this.GetTraceEventType(level);
			foreach (object obj in global::System.Diagnostics.Trace.Listeners)
			{
				global::System.Diagnostics.TraceListener traceListener = (global::System.Diagnostics.TraceListener)obj;
				if (!traceListener.IsThreadSafe)
				{
					global::System.Diagnostics.TraceListener obj2 = traceListener;
					lock (obj2)
					{
						traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
						goto IL_6E;
					}
					goto IL_5F;
				}
				goto IL_5F;
				IL_6E:
				if (global::System.Diagnostics.Trace.AutoFlush)
				{
					traceListener.Flush();
					continue;
				}
				continue;
				IL_5F:
				traceListener.TraceEvent(eventCache, "Newtonsoft.Json", traceEventType, 0, message);
				goto IL_6E;
			}
		}
	}
}
