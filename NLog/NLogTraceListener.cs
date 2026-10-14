using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Xml;
using NLog.Internal;

namespace NLog
{
	// Token: 0x0200001D RID: 29
	public class NLogTraceListener : global::System.Diagnostics.TraceListener
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x000088FF File Offset: 0x00006AFF
		// (set) Token: 0x06000466 RID: 1126 RVA: 0x0000890D File Offset: 0x00006B0D
		public global::NLog.LogFactory LogFactory
		{
			get
			{
				this.InitAttributes();
				return this._logFactory;
			}
			set
			{
				this._logFactory = value;
				this._attributesLoaded = true;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x0000891D File Offset: 0x00006B1D
		// (set) Token: 0x06000468 RID: 1128 RVA: 0x0000892B File Offset: 0x00006B2B
		public global::NLog.LogLevel DefaultLogLevel
		{
			get
			{
				this.InitAttributes();
				return this._defaultLogLevel;
			}
			set
			{
				this._defaultLogLevel = value;
				this._attributesLoaded = true;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x0000893B File Offset: 0x00006B3B
		// (set) Token: 0x0600046A RID: 1130 RVA: 0x00008949 File Offset: 0x00006B49
		public global::NLog.LogLevel ForceLogLevel
		{
			get
			{
				this.InitAttributes();
				return this._forceLogLevel;
			}
			set
			{
				this._forceLogLevel = value;
				this._attributesLoaded = true;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00008959 File Offset: 0x00006B59
		// (set) Token: 0x0600046C RID: 1132 RVA: 0x00008967 File Offset: 0x00006B67
		public bool DisableFlush
		{
			get
			{
				this.InitAttributes();
				return this._disableFlush;
			}
			set
			{
				this._disableFlush = value;
				this._attributesLoaded = true;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00008977 File Offset: 0x00006B77
		public override bool IsThreadSafe
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0000897A File Offset: 0x00006B7A
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00008988 File Offset: 0x00006B88
		public bool AutoLoggerName
		{
			get
			{
				this.InitAttributes();
				return this._autoLoggerName;
			}
			set
			{
				this._autoLoggerName = value;
				this._attributesLoaded = true;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00008998 File Offset: 0x00006B98
		public override void Write(string message)
		{
			this.ProcessLogEventInfo(this.DefaultLogLevel, null, message, null, null, new global::System.Diagnostics.TraceEventType?(global::System.Diagnostics.TraceEventType.Resume), null);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x000089D0 File Offset: 0x00006BD0
		public override void WriteLine(string message)
		{
			this.ProcessLogEventInfo(this.DefaultLogLevel, null, message, null, null, new global::System.Diagnostics.TraceEventType?(global::System.Diagnostics.TraceEventType.Resume), null);
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00008A08 File Offset: 0x00006C08
		public override void Close()
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00008A0C File Offset: 0x00006C0C
		public override void Fail(string message)
		{
			this.ProcessLogEventInfo(global::NLog.LogLevel.Error, null, message, null, null, new global::System.Diagnostics.TraceEventType?(global::System.Diagnostics.TraceEventType.Error), null);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00008A40 File Offset: 0x00006C40
		public override void Fail(string message, string detailMessage)
		{
			this.ProcessLogEventInfo(global::NLog.LogLevel.Error, null, message + " " + detailMessage, null, null, new global::System.Diagnostics.TraceEventType?(global::System.Diagnostics.TraceEventType.Error), null);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00008A7E File Offset: 0x00006C7E
		public override void Flush()
		{
			if (!this.DisableFlush)
			{
				if (this.LogFactory != null)
				{
					this.LogFactory.Flush();
					return;
				}
				global::NLog.LogManager.Flush();
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00008AA4 File Offset: 0x00006CA4
		public override void TraceData(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, object data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, string.Empty, null, data, null))
			{
				return;
			}
			this.TraceData(eventCache, source, eventType, id, new object[]
			{
				data
			});
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00008AEC File Offset: 0x00006CEC
		public override void TraceData(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, params object[] data)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, string.Empty, null, null, data))
			{
				return;
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < data.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(", ");
				}
				stringBuilder.Append("{");
				stringBuilder.Append(i);
				stringBuilder.Append("}");
			}
			this.ProcessLogEventInfo(global::NLog.NLogTraceListener.TranslateLogLevel(eventType), source, stringBuilder.ToString(), data, new int?(id), new global::System.Diagnostics.TraceEventType?(eventType), null);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00008B90 File Offset: 0x00006D90
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, string.Empty, null, null, null))
			{
				return;
			}
			this.ProcessLogEventInfo(global::NLog.NLogTraceListener.TranslateLogLevel(eventType), source, string.Empty, null, new int?(id), new global::System.Diagnostics.TraceEventType?(eventType), null);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00008BEC File Offset: 0x00006DEC
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string format, params object[] args)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, format, args, null, null))
			{
				return;
			}
			this.ProcessLogEventInfo(global::NLog.NLogTraceListener.TranslateLogLevel(eventType), source, format, args, new int?(id), new global::System.Diagnostics.TraceEventType?(eventType), null);
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00008C44 File Offset: 0x00006E44
		public override void TraceEvent(global::System.Diagnostics.TraceEventCache eventCache, string source, global::System.Diagnostics.TraceEventType eventType, int id, string message)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, eventType, id, message, null, null, null))
			{
				return;
			}
			this.ProcessLogEventInfo(global::NLog.NLogTraceListener.TranslateLogLevel(eventType), source, message, null, new int?(id), new global::System.Diagnostics.TraceEventType?(eventType), null);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00008C98 File Offset: 0x00006E98
		public override void TraceTransfer(global::System.Diagnostics.TraceEventCache eventCache, string source, int id, string message, global::System.Guid relatedActivityId)
		{
			if (base.Filter != null && !base.Filter.ShouldTrace(eventCache, source, global::System.Diagnostics.TraceEventType.Transfer, id, message, null, null, null))
			{
				return;
			}
			this.ProcessLogEventInfo(global::NLog.LogLevel.Debug, source, message, null, new int?(id), new global::System.Diagnostics.TraceEventType?(global::System.Diagnostics.TraceEventType.Transfer), new global::System.Guid?(relatedActivityId));
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00008CEE File Offset: 0x00006EEE
		protected override string[] GetSupportedAttributes()
		{
			return new string[]
			{
				"defaultLogLevel",
				"autoLoggerName",
				"forceLogLevel",
				"disableFlush"
			};
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00008D18 File Offset: 0x00006F18
		private static global::NLog.LogLevel TranslateLogLevel(global::System.Diagnostics.TraceEventType eventType)
		{
			switch (eventType)
			{
			case global::System.Diagnostics.TraceEventType.Critical:
				return global::NLog.LogLevel.Fatal;
			case global::System.Diagnostics.TraceEventType.Error:
				return global::NLog.LogLevel.Error;
			case (global::System.Diagnostics.TraceEventType)3:
				break;
			case global::System.Diagnostics.TraceEventType.Warning:
				return global::NLog.LogLevel.Warn;
			default:
				if (eventType == global::System.Diagnostics.TraceEventType.Information)
				{
					return global::NLog.LogLevel.Info;
				}
				if (eventType == global::System.Diagnostics.TraceEventType.Verbose)
				{
					return global::NLog.LogLevel.Trace;
				}
				break;
			}
			return global::NLog.LogLevel.Debug;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00008D6C File Offset: 0x00006F6C
		protected virtual void ProcessLogEventInfo(global::NLog.LogLevel logLevel, string loggerName, [global::System.ComponentModel.Localizable(false)] string message, object[] arguments, int? eventId, global::System.Diagnostics.TraceEventType? eventType, global::System.Guid? relatedActiviyId)
		{
			loggerName = ((loggerName ?? this.Name) ?? string.Empty);
			global::System.Diagnostics.StackTrace stackTrace = null;
			int num = -1;
			if (this.AutoLoggerName)
			{
				stackTrace = new global::System.Diagnostics.StackTrace();
				for (int i = 0; i < stackTrace.FrameCount; i++)
				{
					loggerName = global::NLog.Internal.StackTraceUsageUtils.LookupClassNameFromStackFrame(stackTrace.GetFrame(i));
					if (!string.IsNullOrEmpty(loggerName))
					{
						num = i;
						break;
					}
				}
			}
			global::NLog.ILogger logger;
			if (this.LogFactory != null)
			{
				logger = this.LogFactory.GetLogger(loggerName);
			}
			else
			{
				logger = global::NLog.LogManager.GetLogger(loggerName);
			}
			logLevel = (this._forceLogLevel ?? logLevel);
			if (!logger.IsEnabled(logLevel))
			{
				return;
			}
			global::NLog.LogEventInfo logEventInfo = new global::NLog.LogEventInfo();
			logEventInfo.LoggerName = loggerName;
			logEventInfo.Level = logLevel;
			if (eventType != null)
			{
				logEventInfo.Properties.Add("EventType", eventType.Value);
			}
			if (relatedActiviyId != null)
			{
				logEventInfo.Properties.Add("RelatedActivityID", relatedActiviyId.Value);
			}
			logEventInfo.Message = message;
			logEventInfo.Parameters = arguments;
			logEventInfo.Level = (this._forceLogLevel ?? logLevel);
			if (eventId != null)
			{
				logEventInfo.Properties.Add("EventID", eventId.Value);
			}
			if (stackTrace != null && num >= 0)
			{
				logEventInfo.SetStackTrace(stackTrace, num);
			}
			logger.Log(logEventInfo);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00008EC0 File Offset: 0x000070C0
		private void InitAttributes()
		{
			if (!this._attributesLoaded)
			{
				this._attributesLoaded = true;
				if (global::System.Diagnostics.Trace.AutoFlush)
				{
					this._disableFlush = true;
				}
				foreach (object obj in base.Attributes)
				{
					global::System.Collections.DictionaryEntry dictionaryEntry = (global::System.Collections.DictionaryEntry)obj;
					string text = (string)dictionaryEntry.Key;
					string text2 = (string)dictionaryEntry.Value;
					string a = text.ToUpperInvariant();
					if (!(a == "DEFAULTLOGLEVEL"))
					{
						if (!(a == "FORCELOGLEVEL"))
						{
							if (!(a == "AUTOLOGGERNAME"))
							{
								if (a == "DISABLEFLUSH")
								{
									this._disableFlush = bool.Parse(text2);
								}
							}
							else
							{
								this.AutoLoggerName = global::System.Xml.XmlConvert.ToBoolean(text2);
							}
						}
						else
						{
							this._forceLogLevel = global::NLog.LogLevel.FromString(text2);
						}
					}
					else
					{
						this._defaultLogLevel = global::NLog.LogLevel.FromString(text2);
					}
				}
			}
		}

		// Token: 0x04000047 RID: 71
		private global::NLog.LogFactory _logFactory;

		// Token: 0x04000048 RID: 72
		private global::NLog.LogLevel _defaultLogLevel = global::NLog.LogLevel.Debug;

		// Token: 0x04000049 RID: 73
		private bool _attributesLoaded;

		// Token: 0x0400004A RID: 74
		private bool _autoLoggerName;

		// Token: 0x0400004B RID: 75
		private global::NLog.LogLevel _forceLogLevel;

		// Token: 0x0400004C RID: 76
		private bool _disableFlush;
	}
}
