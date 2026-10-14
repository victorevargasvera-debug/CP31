using System;

namespace NLog.LogReceiverService
{
	// Token: 0x02000086 RID: 134
	public abstract class BaseLogReceiverForwardingService
	{
		// Token: 0x060008DD RID: 2269 RVA: 0x00017A84 File Offset: 0x00015C84
		protected BaseLogReceiverForwardingService() : this(null)
		{
		}

		// Token: 0x060008DE RID: 2270 RVA: 0x00017A8D File Offset: 0x00015C8D
		protected BaseLogReceiverForwardingService(global::NLog.LogFactory logFactory)
		{
			this._logFactory = logFactory;
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x00017A9C File Offset: 0x00015C9C
		public void ProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events)
		{
			global::System.DateTime dateTime = new global::System.DateTime(events.BaseTimeUtc, global::System.DateTimeKind.Utc);
			global::NLog.LogEventInfo[] array = new global::NLog.LogEventInfo[events.Events.Length];
			for (int i = 0; i < events.Events.Length; i++)
			{
				global::NLog.LogReceiverService.NLogEvent nlogEvent = events.Events[i];
				global::NLog.LogLevel level = global::NLog.LogLevel.FromOrdinal(nlogEvent.LevelOrdinal);
				string loggerName = events.Strings[nlogEvent.LoggerOrdinal];
				global::NLog.LogEventInfo logEventInfo = new global::NLog.LogEventInfo();
				logEventInfo.Level = level;
				logEventInfo.LoggerName = loggerName;
				logEventInfo.TimeStamp = dateTime.AddTicks(nlogEvent.TimeDelta).ToLocalTime();
				logEventInfo.Message = events.Strings[nlogEvent.MessageOrdinal];
				logEventInfo.Properties.Add("ClientName", events.ClientName);
				for (int j = 0; j < events.LayoutNames.Count; j++)
				{
					logEventInfo.Properties.Add(events.LayoutNames[j], events.Strings[nlogEvent.ValueIndexes[j]]);
				}
				array[i] = logEventInfo;
			}
			this.ProcessLogMessages(array);
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x00017BC4 File Offset: 0x00015DC4
		protected virtual void ProcessLogMessages(global::NLog.LogEventInfo[] logEvents)
		{
			global::NLog.ILogger logger = null;
			string b = string.Empty;
			foreach (global::NLog.LogEventInfo logEventInfo in logEvents)
			{
				if (logEventInfo.LoggerName != b)
				{
					if (this._logFactory != null)
					{
						logger = this._logFactory.GetLogger(logEventInfo.LoggerName);
					}
					else
					{
						logger = global::NLog.LogManager.GetLogger(logEventInfo.LoggerName);
					}
					b = logEventInfo.LoggerName;
				}
				if (logger != null)
				{
					logger.Log(logEventInfo);
				}
			}
		}

		// Token: 0x04000226 RID: 550
		private readonly global::NLog.LogFactory _logFactory;
	}
}
