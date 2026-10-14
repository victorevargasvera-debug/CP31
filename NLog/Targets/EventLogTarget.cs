using System;
using System.ComponentModel;
using System.Diagnostics;
using NLog.Common;
using NLog.Config;
using NLog.Internal.Fakeables;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000036 RID: 54
	[global::NLog.Targets.Target("EventLog")]
	public class EventLogTarget : global::NLog.Targets.TargetWithLayout, global::NLog.Config.IInstallable
	{
		// Token: 0x0600056C RID: 1388 RVA: 0x0000C0D4 File Offset: 0x0000A2D4
		public EventLogTarget() : this(global::NLog.LogFactory.CurrentAppDomain)
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x0000C0E4 File Offset: 0x0000A2E4
		public EventLogTarget(global::NLog.Internal.Fakeables.IAppDomain appDomain)
		{
			this.Source = appDomain.FriendlyName;
			this.Log = "Application";
			this.MachineName = ".";
			this.MaxMessageLength = 16384;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.EventLogTarget));
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x0000C144 File Offset: 0x0000A344
		public EventLogTarget(string name) : this(global::NLog.LogFactory.CurrentAppDomain)
		{
			base.Name = name;
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600056F RID: 1391 RVA: 0x0000C158 File Offset: 0x0000A358
		// (set) Token: 0x06000570 RID: 1392 RVA: 0x0000C160 File Offset: 0x0000A360
		[global::System.ComponentModel.DefaultValue(".")]
		public string MachineName { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000571 RID: 1393 RVA: 0x0000C169 File Offset: 0x0000A369
		// (set) Token: 0x06000572 RID: 1394 RVA: 0x0000C171 File Offset: 0x0000A371
		public global::NLog.Layouts.Layout EventId { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0000C17A File Offset: 0x0000A37A
		// (set) Token: 0x06000574 RID: 1396 RVA: 0x0000C182 File Offset: 0x0000A382
		public global::NLog.Layouts.Layout Category { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0000C18B File Offset: 0x0000A38B
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x0000C193 File Offset: 0x0000A393
		public global::NLog.Layouts.Layout EntryType { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0000C19C File Offset: 0x0000A39C
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000C1A4 File Offset: 0x0000A3A4
		public global::NLog.Layouts.Layout Source { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000C1AD File Offset: 0x0000A3AD
		// (set) Token: 0x0600057A RID: 1402 RVA: 0x0000C1B5 File Offset: 0x0000A3B5
		[global::System.ComponentModel.DefaultValue("Application")]
		public string Log { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600057B RID: 1403 RVA: 0x0000C1BE File Offset: 0x0000A3BE
		// (set) Token: 0x0600057C RID: 1404 RVA: 0x0000C1C6 File Offset: 0x0000A3C6
		[global::System.ComponentModel.DefaultValue(16384)]
		public int MaxMessageLength
		{
			get
			{
				return this.maxMessageLength;
			}
			set
			{
				if (value <= 0)
				{
					throw new global::System.ArgumentException("MaxMessageLength cannot be zero or negative.");
				}
				this.maxMessageLength = value;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600057D RID: 1405 RVA: 0x0000C1DE File Offset: 0x0000A3DE
		// (set) Token: 0x0600057E RID: 1406 RVA: 0x0000C1E8 File Offset: 0x0000A3E8
		[global::System.ComponentModel.DefaultValue(null)]
		public long? MaxKilobytes
		{
			get
			{
				return this.maxKilobytes;
			}
			set
			{
				if (value != null && (value < 64L || value > 4194240L || value % 64L != 0L))
				{
					throw new global::System.ArgumentException("MaxKilobytes must be a multitude of 64, and between 64 and 4194240");
				}
				this.maxKilobytes = value;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600057F RID: 1407 RVA: 0x0000C294 File Offset: 0x0000A494
		// (set) Token: 0x06000580 RID: 1408 RVA: 0x0000C29C File Offset: 0x0000A49C
		[global::System.ComponentModel.DefaultValue(global::NLog.Targets.EventLogTargetOverflowAction.Truncate)]
		public global::NLog.Targets.EventLogTargetOverflowAction OnOverflow { get; set; }

		// Token: 0x06000581 RID: 1409 RVA: 0x0000C2A8 File Offset: 0x0000A4A8
		public void Install(global::NLog.Config.InstallationContext installationContext)
		{
			string fixedSource = this.GetFixedSource();
			this.CreateEventSourceIfNeeded(fixedSource, true);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0000C2C4 File Offset: 0x0000A4C4
		public void Uninstall(global::NLog.Config.InstallationContext installationContext)
		{
			string fixedSource = this.GetFixedSource();
			if (string.IsNullOrEmpty(fixedSource))
			{
				global::NLog.Common.InternalLogger.Debug<string>("EventLogTarget(Name={0}): Skipping removing of event source because it contains layout renderers", base.Name);
				return;
			}
			global::System.Diagnostics.EventLog.DeleteEventSource(fixedSource, this.MachineName);
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0000C300 File Offset: 0x0000A500
		public bool? IsInstalled(global::NLog.Config.InstallationContext installationContext)
		{
			string fixedSource = this.GetFixedSource();
			if (!string.IsNullOrEmpty(fixedSource))
			{
				return new bool?(global::System.Diagnostics.EventLog.SourceExists(fixedSource, this.MachineName));
			}
			global::NLog.Common.InternalLogger.Debug<string>("EventLogTarget(Name={0}): Unclear if event source exists because it contains layout renderers", base.Name);
			return null;
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0000C348 File Offset: 0x0000A548
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			string fixedSource = this.GetFixedSource();
			if (string.IsNullOrEmpty(fixedSource))
			{
				global::NLog.Common.InternalLogger.Debug<string>("EventLogTarget(Name={0}): Skipping creation of event source because it contains layout renderers", base.Name);
				return;
			}
			if (!global::System.Diagnostics.EventLog.LogNameFromSourceName(fixedSource, this.MachineName).Equals(this.Log, global::System.StringComparison.CurrentCultureIgnoreCase))
			{
				this.CreateEventSourceIfNeeded(fixedSource, false);
			}
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0000C3A0 File Offset: 0x0000A5A0
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			string text = base.RenderLogEvent(this.Layout, logEvent);
			global::System.Diagnostics.EventLogEntryType entryType = this.GetEntryType(logEvent);
			int eventId = 0;
			string text2 = base.RenderLogEvent(this.EventId, logEvent);
			if (!string.IsNullOrEmpty(text2) && !int.TryParse(text2, out eventId))
			{
				global::NLog.Common.InternalLogger.Warn<string, string>("EventLogTarget(Name={0}): WriteEntry failed to parse EventId={1}", base.Name, text2);
			}
			short category = 0;
			string text3 = base.RenderLogEvent(this.Category, logEvent);
			if (!string.IsNullOrEmpty(text3) && !short.TryParse(text3, out category))
			{
				global::NLog.Common.InternalLogger.Warn<string, string>("EventLogTarget(Name={0}): WriteEntry failed to parse Category={1}", base.Name, text3);
			}
			if (text.Length <= this.MaxMessageLength)
			{
				this.WriteEntry(logEvent, text, entryType, eventId, category);
				return;
			}
			if (this.OnOverflow == global::NLog.Targets.EventLogTargetOverflowAction.Truncate)
			{
				text = text.Substring(0, this.MaxMessageLength);
				this.WriteEntry(logEvent, text, entryType, eventId, category);
				return;
			}
			if (this.OnOverflow == global::NLog.Targets.EventLogTargetOverflowAction.Split)
			{
				for (int i = 0; i < text.Length; i += this.MaxMessageLength)
				{
					string message = text.Substring(i, global::System.Math.Min(this.MaxMessageLength, text.Length - i));
					this.WriteEntry(logEvent, message, entryType, eventId, category);
				}
				return;
			}
			global::NLog.Targets.EventLogTargetOverflowAction onOverflow = this.OnOverflow;
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		internal virtual void WriteEntry(global::NLog.LogEventInfo logEventInfo, string message, global::System.Diagnostics.EventLogEntryType entryType, int eventId, short category)
		{
			this.GetEventLog(logEventInfo).WriteEntry(message, entryType, eventId, category);
		}

		// Token: 0x06000587 RID: 1415 RVA: 0x0000C4D8 File Offset: 0x0000A6D8
		private global::System.Diagnostics.EventLogEntryType GetEntryType(global::NLog.LogEventInfo logEvent)
		{
			string text = base.RenderLogEvent(this.EntryType, logEvent);
			if (!string.IsNullOrEmpty(text))
			{
				global::System.Diagnostics.EventLogEntryType result;
				if (global::NLog.Common.ConversionHelpers.TryParseEnum<global::System.Diagnostics.EventLogEntryType>(text, out result, (global::System.Diagnostics.EventLogEntryType)0))
				{
					return result;
				}
				global::NLog.Common.InternalLogger.Warn<string, string>("EventLogTarget(Name={0}): WriteEntry failed to parse EntryType={1}", base.Name, text);
			}
			if (logEvent.Level >= global::NLog.LogLevel.Error)
			{
				return global::System.Diagnostics.EventLogEntryType.Error;
			}
			if (logEvent.Level >= global::NLog.LogLevel.Warn)
			{
				return global::System.Diagnostics.EventLogEntryType.Warning;
			}
			return global::System.Diagnostics.EventLogEntryType.Information;
		}

		// Token: 0x06000588 RID: 1416 RVA: 0x0000C544 File Offset: 0x0000A744
		internal string GetFixedSource()
		{
			if (this.Source == null)
			{
				return null;
			}
			global::NLog.Layouts.SimpleLayout simpleLayout = this.Source as global::NLog.Layouts.SimpleLayout;
			if (simpleLayout != null && simpleLayout.IsFixedText)
			{
				return simpleLayout.FixedText;
			}
			return null;
		}

		// Token: 0x06000589 RID: 1417 RVA: 0x0000C57C File Offset: 0x0000A77C
		private global::System.Diagnostics.EventLog GetEventLog(global::NLog.LogEventInfo logEvent)
		{
			string text = this.RenderSource(logEvent);
			if (this.eventLogInstance == null || !(text == this.eventLogInstance.Source) || !(this.eventLogInstance.Log == this.Log) || !(this.eventLogInstance.MachineName == this.MachineName))
			{
				this.eventLogInstance = new global::System.Diagnostics.EventLog(this.Log, this.MachineName, text);
			}
			if (this.MaxKilobytes != null)
			{
				this.eventLogInstance.MaximumKilobytes = this.MaxKilobytes.Value;
			}
			return this.eventLogInstance;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x0000C626 File Offset: 0x0000A826
		internal string RenderSource(global::NLog.LogEventInfo logEvent)
		{
			if (this.Source == null)
			{
				return null;
			}
			return base.RenderLogEvent(this.Source, logEvent);
		}

		// Token: 0x0600058B RID: 1419 RVA: 0x0000C640 File Offset: 0x0000A840
		private void CreateEventSourceIfNeeded(string fixedSource, bool alwaysThrowError)
		{
			if (string.IsNullOrEmpty(fixedSource))
			{
				global::NLog.Common.InternalLogger.Debug<string>("EventLogTarget(Name={0}): Skipping creation of event source because it contains layout renderers", base.Name);
				return;
			}
			try
			{
				if (global::System.Diagnostics.EventLog.SourceExists(fixedSource, this.MachineName))
				{
					if (!global::System.Diagnostics.EventLog.LogNameFromSourceName(fixedSource, this.MachineName).Equals(this.Log, global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						global::System.Diagnostics.EventLog.DeleteEventSource(fixedSource, this.MachineName);
						global::System.Diagnostics.EventLog.CreateEventSource(new global::System.Diagnostics.EventSourceCreationData(fixedSource, this.Log)
						{
							MachineName = this.MachineName
						});
					}
				}
				else
				{
					global::System.Diagnostics.EventLog.CreateEventSource(new global::System.Diagnostics.EventSourceCreationData(fixedSource, this.Log)
					{
						MachineName = this.MachineName
					});
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "EventLogTarget(Name={0}): Error when connecting to EventLog.", new object[]
				{
					base.Name
				});
				if (alwaysThrowError || global::NLog.LogManager.ThrowExceptions)
				{
					throw;
				}
			}
		}

		// Token: 0x040000B3 RID: 179
		private global::System.Diagnostics.EventLog eventLogInstance;

		// Token: 0x040000BA RID: 186
		private int maxMessageLength;

		// Token: 0x040000BB RID: 187
		private long? maxKilobytes;
	}
}
