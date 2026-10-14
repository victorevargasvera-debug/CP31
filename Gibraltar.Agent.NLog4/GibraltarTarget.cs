using System;
using System.Diagnostics;
using System.Reflection;
using NLog;
using NLog.Layouts;
using NLog.Targets;

namespace Gibraltar.Agent.NLog
{
	// Token: 0x02000002 RID: 2
	[global::NLog.Targets.Target("Gibraltar")]
	public class GibraltarTarget : global::NLog.Targets.TargetWithLayout
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public GibraltarTarget()
		{
			this.Layout = new global::NLog.Layouts.SimpleLayout("${callsite}");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			if (logEvent == null)
			{
				return;
			}
			this.Layout.Render(logEvent);
			global::Gibraltar.Agent.LogMessageSeverity severityLevel = global::Gibraltar.Agent.NLog.GibraltarTarget.GetSeverityLevel(logEvent.Level);
			global::Gibraltar.Agent.NLog.GibraltarTarget.NLogSourceProvider sourceProvider = new global::Gibraltar.Agent.NLog.GibraltarTarget.NLogSourceProvider(logEvent);
			string category = global::Gibraltar.Agent.NLog.GibraltarTarget.GetCategory(logEvent);
			global::System.Exception exception = global::Gibraltar.Agent.NLog.GibraltarTarget.GetException(logEvent);
			global::Gibraltar.Agent.Log.Write(severityLevel, "NLog", sourceProvider, null, exception, global::Gibraltar.Agent.LogWriteMode.Queued, null, category, null, logEvent.FormattedMessage, new object[0]);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020C4 File Offset: 0x000002C4
		private static string GetCategory(global::NLog.LogEventInfo logEvent)
		{
			return logEvent.LoggerName;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020CC File Offset: 0x000002CC
		private static global::System.Exception GetException(global::NLog.LogEventInfo logEvent)
		{
			global::System.Exception ex = logEvent.Exception;
			object[] parameters = logEvent.Parameters;
			if (ex == null && parameters != null && parameters.Length != 0)
			{
				object[] array = parameters;
				for (int i = 0; i < array.Length; i++)
				{
					global::System.Exception ex2 = array[i] as global::System.Exception;
					if (ex2 != null)
					{
						ex = ex2;
						break;
					}
				}
			}
			return ex;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00000318
		private static global::Gibraltar.Agent.LogMessageSeverity GetSeverityLevel(global::NLog.LogLevel level)
		{
			global::Gibraltar.Agent.LogMessageSeverity result = global::Gibraltar.Agent.LogMessageSeverity.None;
			if (level < global::NLog.LogLevel.Info)
			{
				result = global::Gibraltar.Agent.LogMessageSeverity.Verbose;
			}
			else if (level < global::NLog.LogLevel.Warn)
			{
				result = global::Gibraltar.Agent.LogMessageSeverity.Information;
			}
			else if (level < global::NLog.LogLevel.Error)
			{
				result = global::Gibraltar.Agent.LogMessageSeverity.Warning;
			}
			else if (level < global::NLog.LogLevel.Fatal)
			{
				result = global::Gibraltar.Agent.LogMessageSeverity.Error;
			}
			else if (level < global::NLog.LogLevel.Off)
			{
				result = global::Gibraltar.Agent.LogMessageSeverity.Critical;
			}
			return result;
		}

		// Token: 0x04000001 RID: 1
		private const string ThisLogSystem = "NLog";

		// Token: 0x02000003 RID: 3
		private class NLogSourceProvider : global::Gibraltar.Agent.IMessageSourceProvider
		{
			// Token: 0x06000006 RID: 6 RVA: 0x0000217C File Offset: 0x0000037C
			public NLogSourceProvider(global::NLog.LogEventInfo logEvent)
			{
				this.m_MethodName = null;
				this.m_ClassName = null;
				this.m_FileName = null;
				this.m_LineNumber = 0;
				try
				{
					global::System.Diagnostics.StackFrame userStackFrame = logEvent.UserStackFrame;
					if (userStackFrame != null)
					{
						global::System.Reflection.MethodBase method = userStackFrame.GetMethod();
						if (method != null)
						{
							this.m_MethodName = method.Name;
							this.m_ClassName = method.ReflectedType.FullName;
							try
							{
								this.m_FileName = userStackFrame.GetFileName();
								if (!string.IsNullOrEmpty(this.m_FileName))
								{
									this.m_LineNumber = userStackFrame.GetFileLineNumber();
								}
								else
								{
									this.m_LineNumber = 0;
								}
							}
							catch
							{
								this.m_FileName = null;
								this.m_LineNumber = 0;
							}
						}
					}
				}
				catch
				{
					this.m_MethodName = null;
					this.m_ClassName = null;
					this.m_FileName = null;
					this.m_LineNumber = 0;
				}
			}

			// Token: 0x17000001 RID: 1
			// (get) Token: 0x06000007 RID: 7 RVA: 0x00002260 File Offset: 0x00000460
			public string MethodName
			{
				get
				{
					return this.m_MethodName;
				}
			}

			// Token: 0x17000002 RID: 2
			// (get) Token: 0x06000008 RID: 8 RVA: 0x00002268 File Offset: 0x00000468
			public string ClassName
			{
				get
				{
					return this.m_ClassName;
				}
			}

			// Token: 0x17000003 RID: 3
			// (get) Token: 0x06000009 RID: 9 RVA: 0x00002270 File Offset: 0x00000470
			public string FileName
			{
				get
				{
					return this.m_FileName;
				}
			}

			// Token: 0x17000004 RID: 4
			// (get) Token: 0x0600000A RID: 10 RVA: 0x00002278 File Offset: 0x00000478
			public int LineNumber
			{
				get
				{
					return this.m_LineNumber;
				}
			}

			// Token: 0x04000002 RID: 2
			private readonly string m_MethodName;

			// Token: 0x04000003 RID: 3
			private readonly string m_ClassName;

			// Token: 0x04000004 RID: 4
			private readonly string m_FileName;

			// Token: 0x04000005 RID: 5
			private readonly int m_LineNumber;
		}
	}
}
