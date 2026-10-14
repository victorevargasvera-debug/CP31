using System;
using System.Diagnostics;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D6 RID: 470
	internal class LogListener : global::System.Diagnostics.TraceListener
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x000454AC File Offset: 0x000436AC
		public LogListener()
		{
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.ActiveObjectChanged += this.LogListener_ActiveObjectChanged;
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.Register(this);
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x000454CC File Offset: 0x000436CC
		public void Initialize(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			global::Gibraltar.Monitor.Net.TracePublisher.Initialize(configuration);
			if (configuration.AutoTraceRegistration)
			{
				bool flag = false;
				foreach (object obj in global::System.Diagnostics.Trace.Listeners)
				{
					global::System.Diagnostics.TraceListener traceListener = (global::System.Diagnostics.TraceListener)obj;
					if (traceListener is global::Gibraltar.Monitor.Net.LogListener && traceListener == this)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					global::System.Diagnostics.Trace.Listeners.Add(this);
				}
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001673 RID: 5747 RVA: 0x00045560 File Offset: 0x00043760
		public override bool IsThreadSafe
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00045564 File Offset: 0x00043764
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x000455A0 File Offset: 0x000437A0
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string message)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id, message);
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x000455DC File Offset: 0x000437DC
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id, format, args);
		}

		// Token: 0x06001677 RID: 5751 RVA: 0x0004561C File Offset: 0x0004381C
		public override void Write(string message)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			bool needIndent = base.NeedIndent;
			global::Gibraltar.Monitor.Net.TracePublisher.Write(message, ref needIndent, base.IndentLevel, base.IndentSize);
			base.NeedIndent = needIndent;
		}

		// Token: 0x06001678 RID: 5752 RVA: 0x0004565C File Offset: 0x0004385C
		public override void WriteLine(string message)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			bool needIndent = base.NeedIndent;
			global::Gibraltar.Monitor.Net.TracePublisher.WriteLine(message, ref needIndent, base.IndentLevel, base.IndentSize);
			base.NeedIndent = needIndent;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x0004569C File Offset: 0x0004389C
		public override void Flush()
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.Flush();
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000456B0 File Offset: 0x000438B0
		public override void Close()
		{
			if (this.m_ListenerActive)
			{
				global::Gibraltar.Monitor.Net.TracePublisher.Close();
			}
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.Unregister(this);
		}

		// Token: 0x0600167B RID: 5755 RVA: 0x000456C8 File Offset: 0x000438C8
		protected override void WriteIndent()
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.WriteIndent(base.IndentLevel, base.IndentSize);
			base.NeedIndent = false;
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000456F0 File Offset: 0x000438F0
		private void LogListener_ActiveObjectChanged(object sender, global::System.EventArgs e)
		{
			this.m_ListenerActive = (global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.ActiveObject == this);
		}

		// Token: 0x04000744 RID: 1860
		private bool m_ListenerActive;
	}
}
