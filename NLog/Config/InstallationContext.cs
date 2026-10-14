using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;

namespace NLog.Config
{
	// Token: 0x02000164 RID: 356
	public sealed class InstallationContext : global::System.IDisposable
	{
		// Token: 0x06000F74 RID: 3956 RVA: 0x00027A3E File Offset: 0x00025C3E
		public InstallationContext() : this(global::System.IO.TextWriter.Null)
		{
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00027A4B File Offset: 0x00025C4B
		public InstallationContext(global::System.IO.TextWriter logOutput)
		{
			this.LogOutput = logOutput;
			this.Parameters = new global::System.Collections.Generic.Dictionary<string, string>();
			this.LogLevel = global::NLog.LogLevel.Info;
			this.ThrowExceptions = false;
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000F76 RID: 3958 RVA: 0x00027A77 File Offset: 0x00025C77
		// (set) Token: 0x06000F77 RID: 3959 RVA: 0x00027A7F File Offset: 0x00025C7F
		public global::NLog.LogLevel LogLevel { get; set; }

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000F78 RID: 3960 RVA: 0x00027A88 File Offset: 0x00025C88
		// (set) Token: 0x06000F79 RID: 3961 RVA: 0x00027A90 File Offset: 0x00025C90
		public bool IgnoreFailures { get; set; }

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000F7A RID: 3962 RVA: 0x00027A99 File Offset: 0x00025C99
		// (set) Token: 0x06000F7B RID: 3963 RVA: 0x00027AA1 File Offset: 0x00025CA1
		public bool ThrowExceptions { get; set; }

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000F7C RID: 3964 RVA: 0x00027AAA File Offset: 0x00025CAA
		// (set) Token: 0x06000F7D RID: 3965 RVA: 0x00027AB2 File Offset: 0x00025CB2
		public global::System.Collections.Generic.IDictionary<string, string> Parameters { get; private set; }

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00027ABB File Offset: 0x00025CBB
		// (set) Token: 0x06000F7F RID: 3967 RVA: 0x00027AC3 File Offset: 0x00025CC3
		public global::System.IO.TextWriter LogOutput { get; set; }

		// Token: 0x06000F80 RID: 3968 RVA: 0x00027ACC File Offset: 0x00025CCC
		public void Trace([global::System.ComponentModel.Localizable(false)] string message, params object[] arguments)
		{
			this.Log(global::NLog.LogLevel.Trace, message, arguments);
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00027ADB File Offset: 0x00025CDB
		public void Debug([global::System.ComponentModel.Localizable(false)] string message, params object[] arguments)
		{
			this.Log(global::NLog.LogLevel.Debug, message, arguments);
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00027AEA File Offset: 0x00025CEA
		public void Info([global::System.ComponentModel.Localizable(false)] string message, params object[] arguments)
		{
			this.Log(global::NLog.LogLevel.Info, message, arguments);
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00027AF9 File Offset: 0x00025CF9
		public void Warning([global::System.ComponentModel.Localizable(false)] string message, params object[] arguments)
		{
			this.Log(global::NLog.LogLevel.Warn, message, arguments);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x00027B08 File Offset: 0x00025D08
		public void Error([global::System.ComponentModel.Localizable(false)] string message, params object[] arguments)
		{
			this.Log(global::NLog.LogLevel.Error, message, arguments);
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x00027B17 File Offset: 0x00025D17
		public void Dispose()
		{
			if (this.LogOutput != null)
			{
				this.LogOutput.Close();
				this.LogOutput = null;
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00027B34 File Offset: 0x00025D34
		public global::NLog.LogEventInfo CreateLogEvent()
		{
			global::NLog.LogEventInfo logEventInfo = global::NLog.LogEventInfo.CreateNullEvent();
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in this.Parameters)
			{
				logEventInfo.Properties.Add(keyValuePair.Key, keyValuePair.Value);
			}
			return logEventInfo;
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00027B9C File Offset: 0x00025D9C
		private void Log(global::NLog.LogLevel logLevel, [global::System.ComponentModel.Localizable(false)] string message, object[] arguments)
		{
			if (logLevel >= this.LogLevel)
			{
				if (arguments != null && arguments.Length != 0)
				{
					message = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, message, arguments);
				}
				global::System.ConsoleColor foregroundColor = global::System.Console.ForegroundColor;
				global::System.Console.ForegroundColor = global::NLog.Config.InstallationContext.logLevel2ConsoleColor[logLevel];
				try
				{
					this.LogOutput.WriteLine(message);
				}
				finally
				{
					global::System.Console.ForegroundColor = foregroundColor;
				}
			}
		}

		// Token: 0x04000451 RID: 1105
		private static readonly global::System.Collections.Generic.Dictionary<global::NLog.LogLevel, global::System.ConsoleColor> logLevel2ConsoleColor = new global::System.Collections.Generic.Dictionary<global::NLog.LogLevel, global::System.ConsoleColor>
		{
			{
				global::NLog.LogLevel.Trace,
				global::System.ConsoleColor.DarkGray
			},
			{
				global::NLog.LogLevel.Debug,
				global::System.ConsoleColor.Gray
			},
			{
				global::NLog.LogLevel.Info,
				global::System.ConsoleColor.White
			},
			{
				global::NLog.LogLevel.Warn,
				global::System.ConsoleColor.Yellow
			},
			{
				global::NLog.LogLevel.Error,
				global::System.ConsoleColor.Red
			},
			{
				global::NLog.LogLevel.Fatal,
				global::System.ConsoleColor.DarkRed
			}
		};
	}
}
