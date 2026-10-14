using System;
using System.Diagnostics;
using Gibraltar.Monitor;
using Gibraltar.Monitor.Net;

namespace Gibraltar.Agent
{
	// Token: 0x0200000B RID: 11
	public sealed class LogListener : global::System.Diagnostics.TraceListener
	{
		// Token: 0x06000087 RID: 135 RVA: 0x000037FC File Offset: 0x000019FC
		public LogListener()
		{
			global::Gibraltar.Monitor.Log.SilentMode = true;
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.ActiveObjectChanged += this.LogListener_ActiveObjectChanged;
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.Register(this);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003824 File Offset: 0x00001A24
		public override bool IsThreadSafe
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00003828 File Offset: 0x00001A28
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00003864 File Offset: 0x00001A64
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string message)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id, message);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000038A0 File Offset: 0x00001AA0
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args)
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.TraceEvent(base.TraceOutputOptions, base.IndentLevel, base.IndentSize, eventCache, source, eventType, id, format, args);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000038E0 File Offset: 0x00001AE0
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

		// Token: 0x0600008D RID: 141 RVA: 0x00003920 File Offset: 0x00001B20
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

		// Token: 0x0600008E RID: 142 RVA: 0x00003960 File Offset: 0x00001B60
		public override void Flush()
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.Flush();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00003974 File Offset: 0x00001B74
		public override void Close()
		{
			if (this.m_ListenerActive)
			{
				global::Gibraltar.Monitor.Net.TracePublisher.Close();
			}
			global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.Unregister(this);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000398C File Offset: 0x00001B8C
		protected override void WriteIndent()
		{
			if (!this.m_ListenerActive)
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.WriteIndent(base.IndentLevel, base.IndentSize);
			base.NeedIndent = false;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000039B4 File Offset: 0x00001BB4
		private void LogListener_ActiveObjectChanged(object sender, global::System.EventArgs e)
		{
			this.m_ListenerActive = (global::Gibraltar.SingletonArbitrator<global::System.Diagnostics.TraceListener>.ActiveObject == this);
		}

		// Token: 0x0400002E RID: 46
		private bool m_ListenerActive;
	}
}
