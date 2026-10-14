using System;
using System.Diagnostics;
using System.Text;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D3 RID: 467
	internal static class TracePublisher
	{
		// Token: 0x0600162A RID: 5674 RVA: 0x00042E40 File Offset: 0x00041040
		static TracePublisher()
		{
			global::Gibraltar.Monitor.Log.IsLoggingActive(true);
			global::Gibraltar.Monitor.Net.TracePublisher.m_Configuration = global::Gibraltar.Monitor.Log.Configuration.Listener;
		}

		// Token: 0x0600162B RID: 5675 RVA: 0x00042E58 File Offset: 0x00041058
		public static void Initialize(global::Gibraltar.Monitor.ListenerConfiguration configuration)
		{
			global::Gibraltar.Monitor.Net.TracePublisher.m_Configuration = configuration;
		}

		// Token: 0x0600162C RID: 5676 RVA: 0x00042E60 File Offset: 0x00041060
		public static void TraceEvent(global::System.Diagnostics.TraceOptions options, int indentLevel, int indentSize, global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			string str = global::Gibraltar.Monitor.Net.TracePublisher.ComputeIndentString(indentLevel, indentSize);
			new global::Gibraltar.Monitor.SimpleLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)eventType, "Trace", "Trace", 2, str + "Event {0}", new object[]
			{
				id
			}).PublishToLog();
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x00042EB8 File Offset: 0x000410B8
		public static void TraceEvent(global::System.Diagnostics.TraceOptions options, int indentLevel, int indentSize, global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string message)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			string str = global::Gibraltar.Monitor.Net.TracePublisher.ComputeIndentString(indentLevel, indentSize);
			((id != 0) ? new global::Gibraltar.Monitor.SimpleLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)eventType, "Trace", "Trace", 2, str + "Event {0}: {1}", new object[]
			{
				id,
				message
			}) : new global::Gibraltar.Monitor.SimpleLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)eventType, "Trace", "Trace", 2, str + (message ?? string.Empty), new object[0])).PublishToLog();
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00042F4C File Offset: 0x0004114C
		public static void TraceEvent(global::System.Diagnostics.TraceOptions options, int indentLevel, int indentSize, global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string format, object[] args)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			string text = global::Gibraltar.Monitor.Net.TracePublisher.ComputeIndentString(indentLevel, indentSize);
			((id != 0) ? new global::Gibraltar.Monitor.SimpleLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)eventType, "Trace", "Trace", 2, string.Format("{2}Event {0}: {1}", id, format, text), args) : new global::Gibraltar.Monitor.SimpleLogMessage((global::Loupe.Extensibility.Data.LogMessageSeverity)eventType, "Trace", "Trace", 2, text + (format ?? string.Empty), args)).PublishToLog();
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00042FD4 File Offset: 0x000411D4
		public static void Write(string message, ref bool needIndent, int indentLevel, int indentSize)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.WriteMessage(message, false, ref needIndent, indentLevel, indentSize);
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x00042FEC File Offset: 0x000411EC
		public static void WriteLine(string message, ref bool needIndent, int indentLevel, int indentSize)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			global::Gibraltar.Monitor.Net.TracePublisher.WriteMessage(message, true, ref needIndent, indentLevel, indentSize);
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x00043004 File Offset: 0x00041204
		public static void Flush()
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			try
			{
				if (global::Gibraltar.Monitor.Net.TracePublisher.t_buffer == null)
				{
					global::Gibraltar.Monitor.Net.TracePublisher.t_buffer = new global::System.Text.StringBuilder();
				}
				if (global::Gibraltar.Monitor.Net.TracePublisher.t_buffer.Length > 0)
				{
					bool flag = false;
					global::Gibraltar.Monitor.Net.TracePublisher.WriteLine(null, ref flag, 0, 0);
				}
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x00043070 File Offset: 0x00041270
		public static void Close()
		{
			if (global::Gibraltar.Monitor.Net.TracePublisher.m_Configuration != null && global::Gibraltar.Monitor.Net.TracePublisher.m_Configuration.EndSessionOnTraceClose && !global::Gibraltar.Monitor.Log.IsSessionEnding)
			{
				global::Gibraltar.Monitor.Log.EndSession(global::Loupe.Extensibility.Data.SessionStatus.Normal, 4, "System.Diagnostics.Trace has been closed.");
			}
		}

		// Token: 0x06001633 RID: 5683 RVA: 0x000430A4 File Offset: 0x000412A4
		public static void WriteIndent(int indentLevel, int indentSize)
		{
			if (!global::Gibraltar.Monitor.Log.IsLoggingActive(true))
			{
				return;
			}
			if (global::Gibraltar.Monitor.Net.TracePublisher.t_buffer == null)
			{
				global::Gibraltar.Monitor.Net.TracePublisher.t_buffer = new global::System.Text.StringBuilder();
			}
			global::Gibraltar.Monitor.Net.TracePublisher.t_buffer.Append(global::Gibraltar.Monitor.Net.TracePublisher.ComputeIndentString(indentLevel, indentSize));
			if (!global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSaved)
			{
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSize = indentSize;
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevel = indentLevel;
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSaved = true;
			}
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x00043104 File Offset: 0x00041304
		private static string ComputeIndentString(int indentLevel, int indentSize)
		{
			if (indentSize <= 0 || indentLevel <= 0)
			{
				return string.Empty;
			}
			string text;
			if (global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSizeCache != null && global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSizeCache.Length == indentSize)
			{
				text = global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSizeCache;
			}
			else
			{
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevelCache = null;
				string text2 = " ";
				text = string.Empty;
				for (int i = indentSize; i > 1; i >>= 1)
				{
					if ((i & 1) != 0)
					{
						text += text2;
					}
					text2 += text2;
				}
				text += text2;
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSizeCache = text;
			}
			string text3;
			if (global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevelCache != null && global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevelCache.Length == indentLevel * indentSize)
			{
				text3 = global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevelCache;
			}
			else
			{
				string text2 = text;
				text3 = string.Empty;
				for (int j = indentLevel; j > 1; j >>= 1)
				{
					if ((j & 1) != 0)
					{
						text3 += text2;
					}
					text2 += text2;
				}
				text3 += text2;
				global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevelCache = text3;
			}
			return text3;
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x00043200 File Offset: 0x00041400
		private static void WriteMessage(string message, bool endLine, ref bool needIndent, int indentLevel, int indentSize)
		{
			try
			{
				if (global::Gibraltar.Monitor.Net.TracePublisher.t_buffer == null)
				{
					global::Gibraltar.Monitor.Net.TracePublisher.t_buffer = new global::System.Text.StringBuilder();
				}
				if (needIndent)
				{
					global::Gibraltar.Monitor.Net.TracePublisher.WriteIndent(indentLevel, indentSize);
				}
				if (!string.IsNullOrEmpty(message))
				{
					global::Gibraltar.Monitor.Net.TracePublisher.t_buffer.Append(message);
				}
				if (endLine)
				{
					global::Gibraltar.Monitor.LogMessageBase logMessageBase = new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Trace", "Trace", 3, null, global::Gibraltar.Monitor.Net.TracePublisher.t_buffer.ToString(), new object[0]);
					global::Gibraltar.Monitor.Net.TracePublisher.t_buffer.Length = 0;
					global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSaved = false;
					global::Gibraltar.Monitor.Net.TracePublisher.t_IndentLevel = 0;
					global::Gibraltar.Monitor.Net.TracePublisher.t_IndentSize = 0;
					needIndent = true;
					logMessageBase.PublishToLog();
				}
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x04000721 RID: 1825
		[global::System.ThreadStatic]
		private static global::System.Text.StringBuilder t_buffer;

		// Token: 0x04000722 RID: 1826
		[global::System.ThreadStatic]
		private static int t_IndentSize;

		// Token: 0x04000723 RID: 1827
		[global::System.ThreadStatic]
		private static int t_IndentLevel;

		// Token: 0x04000724 RID: 1828
		[global::System.ThreadStatic]
		private static bool t_IndentSaved;

		// Token: 0x04000725 RID: 1829
		[global::System.ThreadStatic]
		private static string t_IndentSizeCache;

		// Token: 0x04000726 RID: 1830
		[global::System.ThreadStatic]
		private static string t_IndentLevelCache;

		// Token: 0x04000727 RID: 1831
		private static global::Gibraltar.Monitor.ListenerConfiguration m_Configuration;

		// Token: 0x04000728 RID: 1832
		private const string LogSystem = "Trace";

		// Token: 0x04000729 RID: 1833
		private const string LogListenerCategory = "Trace";
	}
}
