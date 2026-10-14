using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using Loupe.Extensibility.Data;

namespace Gibraltar.Monitor.Net
{
	// Token: 0x020001D2 RID: 466
	internal class ConsoleListener : global::System.IO.TextWriter
	{
		// Token: 0x06001624 RID: 5668 RVA: 0x00042C3C File Offset: 0x00040E3C
		public ConsoleListener(string outputCategory, global::System.IO.TextWriter originalWriter) : base(global::System.Globalization.CultureInfo.InvariantCulture)
		{
			this.m_OutputCategory = outputCategory;
			this.m_OriginalWriter = originalWriter;
			this.m_Encoding = originalWriter.Encoding;
			this.m_Buffer = new global::System.Text.StringBuilder();
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001625 RID: 5669 RVA: 0x00042C70 File Offset: 0x00040E70
		public override global::System.Text.Encoding Encoding
		{
			get
			{
				return this.m_Encoding;
			}
		}

		// Token: 0x06001626 RID: 5670 RVA: 0x00042C78 File Offset: 0x00040E78
		public override void Write(char value)
		{
			this.m_OriginalWriter.Write(value);
			if (value == '\n')
			{
				if (this.m_Buffer.Length > 0)
				{
					global::Gibraltar.Monitor.LogMessageBase logMessageBase = new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Console", this.m_OutputCategory, 3, null, this.m_Buffer.ToString(), new object[0]);
					this.m_Buffer.Length = 0;
					logMessageBase.PublishToLog();
					return;
				}
			}
			else if (value != '\r')
			{
				this.m_Buffer.Append(value);
			}
		}

		// Token: 0x06001627 RID: 5671 RVA: 0x00042CFC File Offset: 0x00040EFC
		public override void Flush()
		{
			base.Flush();
			this.m_OriginalWriter.Flush();
			if (this.m_Buffer.Length > 0)
			{
				global::Gibraltar.Monitor.LogMessageBase logMessageBase = new global::Gibraltar.Monitor.SimpleLogMessage(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, global::Gibraltar.Monitor.LogWriteMode.Queued, "Console", this.m_OutputCategory, 1, null, this.m_Buffer.ToString(), new object[0]);
				this.m_Buffer.Length = 0;
				logMessageBase.PublishToLog();
			}
		}

		// Token: 0x06001628 RID: 5672 RVA: 0x00042D68 File Offset: 0x00040F68
		private static object GetConsoleLockObject()
		{
			object result;
			try
			{
				result = typeof(global::System.Console).InvokeMember("InternalSyncObject", global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.GetProperty, null, null, null);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06001629 RID: 5673 RVA: 0x00042DB0 File Offset: 0x00040FB0
		public static void RegisterConsoleIntercepter()
		{
			object consoleLockObject = global::Gibraltar.Monitor.Net.ConsoleListener.GetConsoleLockObject();
			if (consoleLockObject != null)
			{
				object obj = consoleLockObject;
				lock (obj)
				{
					global::System.Console.SetOut(new global::Gibraltar.Monitor.Net.ConsoleListener("Console.Out", global::System.Console.Out));
					global::System.Console.SetError(new global::Gibraltar.Monitor.Net.ConsoleListener("Console.Error", global::System.Console.Error));
					return;
				}
			}
			global::System.Console.SetOut(new global::Gibraltar.Monitor.Net.ConsoleListener("Console.Out", global::System.Console.Out));
			global::System.Console.SetError(new global::Gibraltar.Monitor.Net.ConsoleListener("Console.Error", global::System.Console.Error));
		}

		// Token: 0x0400071A RID: 1818
		private const string OutCategoryName = "Console.Out";

		// Token: 0x0400071B RID: 1819
		private const string ErrorCategoryName = "Console.Error";

		// Token: 0x0400071C RID: 1820
		private const string ConsoleLogSystem = "Console";

		// Token: 0x0400071D RID: 1821
		private readonly string m_OutputCategory;

		// Token: 0x0400071E RID: 1822
		private readonly global::System.IO.TextWriter m_OriginalWriter;

		// Token: 0x0400071F RID: 1823
		private readonly global::System.Text.Encoding m_Encoding;

		// Token: 0x04000720 RID: 1824
		private readonly global::System.Text.StringBuilder m_Buffer;
	}
}
