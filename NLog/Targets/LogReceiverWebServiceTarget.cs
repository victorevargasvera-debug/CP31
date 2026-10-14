using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;
using NLog.LogReceiverService;

namespace NLog.Targets
{
	// Token: 0x02000041 RID: 65
	[global::NLog.Targets.Target("LogReceiverService")]
	public class LogReceiverWebServiceTarget : global::NLog.Targets.Target
	{
		// Token: 0x06000632 RID: 1586 RVA: 0x0000F165 File Offset: 0x0000D365
		public LogReceiverWebServiceTarget()
		{
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.MethodCallParameter>();
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x0000F18E File Offset: 0x0000D38E
		public LogReceiverWebServiceTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0000F19D File Offset: 0x0000D39D
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0000F1A5 File Offset: 0x0000D3A5
		[global::NLog.Config.RequiredParameter]
		public virtual string EndpointAddress { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0000F1AE File Offset: 0x0000D3AE
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x0000F1B6 File Offset: 0x0000D3B6
		public string EndpointConfigurationName { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x0000F1BF File Offset: 0x0000D3BF
		// (set) Token: 0x06000639 RID: 1593 RVA: 0x0000F1C7 File Offset: 0x0000D3C7
		public bool UseBinaryEncoding { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		// (set) Token: 0x0600063B RID: 1595 RVA: 0x0000F1D8 File Offset: 0x0000D3D8
		public bool UseOneWayContract { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x0000F1E1 File Offset: 0x0000D3E1
		// (set) Token: 0x0600063D RID: 1597 RVA: 0x0000F1E9 File Offset: 0x0000D3E9
		public global::NLog.Layouts.Layout ClientId { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0000F1F2 File Offset: 0x0000D3F2
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x0000F1FA File Offset: 0x0000D3FA
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.MethodCallParameter), "parameter")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.MethodCallParameter> Parameters { get; private set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x0000F203 File Offset: 0x0000D403
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x0000F20B File Offset: 0x0000D40B
		public bool IncludeEventProperties { get; set; }

		// Token: 0x06000642 RID: 1602 RVA: 0x0000F214 File Offset: 0x0000D414
		protected internal virtual bool OnSend(global::NLog.LogReceiverService.NLogEvents events, global::System.Collections.Generic.IEnumerable<global::NLog.Common.AsyncLogEventInfo> asyncContinuations)
		{
			return true;
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x0000F217 File Offset: 0x0000D417
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			this.Write(new global::NLog.Common.AsyncLogEventInfo[]
			{
				logEvent
			});
		}

		// Token: 0x06000644 RID: 1604 RVA: 0x0000F22D File Offset: 0x0000D42D
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected override void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x06000645 RID: 1605 RVA: 0x0000F238 File Offset: 0x0000D438
		protected override void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			if (this.inCall)
			{
				for (int i = 0; i < logEvents.Count; i++)
				{
					base.PrecalculateVolatileLayouts(logEvents[i].LogEvent);
					this.buffer.Append(logEvents[i]);
				}
				return;
			}
			global::NLog.Common.AsyncLogEventInfo[] array = new global::NLog.Common.AsyncLogEventInfo[logEvents.Count];
			logEvents.CopyTo(array, 0);
			global::NLog.LogReceiverService.NLogEvents events = this.TranslateLogEvents(array);
			this.Send(events, array, null);
		}

		// Token: 0x06000646 RID: 1606 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this.SendBufferedEvents(asyncContinuation);
		}

		// Token: 0x06000647 RID: 1607 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
		private static int AddValueAndGetStringOrdinal(global::NLog.LogReceiverService.NLogEvents context, global::System.Collections.Generic.Dictionary<string, int> stringTable, string value)
		{
			int count;
			if (value == null || !stringTable.TryGetValue(value, out count))
			{
				count = context.Strings.Count;
				if (value != null)
				{
					stringTable.Add(value, count);
				}
				context.Strings.Add(value);
			}
			return count;
		}

		// Token: 0x06000648 RID: 1608 RVA: 0x0000F2F8 File Offset: 0x0000D4F8
		private global::NLog.LogReceiverService.NLogEvents TranslateLogEvents(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			if (logEvents.Count == 0 && !global::NLog.LogManager.ThrowExceptions)
			{
				global::NLog.Common.InternalLogger.Error<string>("LogReceiverServiceTarget(Name={0}): LogEvents array is empty, sending empty event...", base.Name);
				return new global::NLog.LogReceiverService.NLogEvents();
			}
			string clientName = string.Empty;
			if (this.ClientId != null)
			{
				clientName = this.ClientId.Render(logEvents[0].LogEvent);
			}
			global::NLog.LogReceiverService.NLogEvents nlogEvents = new global::NLog.LogReceiverService.NLogEvents
			{
				ClientName = clientName,
				LayoutNames = new global::NLog.LogReceiverService.StringCollection(),
				Strings = new global::NLog.LogReceiverService.StringCollection(),
				BaseTimeUtc = logEvents[0].LogEvent.TimeStamp.ToUniversalTime().Ticks
			};
			global::System.Collections.Generic.Dictionary<string, int> stringTable = new global::System.Collections.Generic.Dictionary<string, int>();
			for (int i = 0; i < this.Parameters.Count; i++)
			{
				nlogEvents.LayoutNames.Add(this.Parameters[i].Name);
			}
			if (this.IncludeEventProperties)
			{
				for (int j = 0; j < logEvents.Count; j++)
				{
					global::NLog.LogEventInfo logEvent = logEvents[j].LogEvent;
					if (logEvent.HasProperties)
					{
						foreach (global::System.Collections.Generic.KeyValuePair<object, object> keyValuePair in logEvent.Properties)
						{
							string text = keyValuePair.Key as string;
							if (text != null && !nlogEvents.LayoutNames.Contains(text))
							{
								nlogEvents.LayoutNames.Add(text);
							}
						}
					}
				}
			}
			nlogEvents.Events = new global::NLog.LogReceiverService.NLogEvent[logEvents.Count];
			for (int k = 0; k < logEvents.Count; k++)
			{
				global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = logEvents[k];
				nlogEvents.Events[k] = this.TranslateEvent(asyncLogEventInfo.LogEvent, nlogEvents, stringTable);
			}
			return nlogEvents;
		}

		// Token: 0x06000649 RID: 1609 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		private void Send(global::NLog.LogReceiverService.NLogEvents events, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> asyncContinuations, global::NLog.Common.AsyncContinuation flushContinuations)
		{
			if (!this.OnSend(events, asyncContinuations))
			{
				if (flushContinuations != null)
				{
					flushContinuations(null);
				}
				return;
			}
			global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = this.CreateLogReceiver();
			wcfLogReceiverClient.ProcessLogMessagesCompleted += delegate(object sender, global::System.ComponentModel.AsyncCompletedEventArgs e)
			{
				if (e.Error != null)
				{
					global::NLog.Common.InternalLogger.Error(e.Error, "LogReceiverServiceTarget(Name={0}): Error while sending", new object[]
					{
						this.Name
					});
				}
				for (int i = 0; i < asyncContinuations.Count; i++)
				{
					asyncContinuations[i].Continuation(e.Error);
				}
				if (flushContinuations != null)
				{
					flushContinuations(e.Error);
				}
				this.SendBufferedEvents(null);
			};
			this.inCall = true;
			wcfLogReceiverClient.ProcessLogMessagesAsync(events);
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x0000F548 File Offset: 0x0000D748
		[global::System.Obsolete("Use CreateLogReceiver instead. Marked obsolete before v4.3.11 and it may be removed in a future release.")]
		protected virtual global::NLog.LogReceiverService.WcfLogReceiverClient CreateWcfLogReceiverClient()
		{
			global::NLog.LogReceiverService.WcfLogReceiverClient wcfLogReceiverClient;
			if (string.IsNullOrEmpty(this.EndpointConfigurationName))
			{
				global::System.ServiceModel.Channels.Binding binding;
				if (this.UseBinaryEncoding)
				{
					binding = new global::System.ServiceModel.Channels.CustomBinding(new global::System.ServiceModel.Channels.BindingElement[]
					{
						new global::System.ServiceModel.Channels.BinaryMessageEncodingBindingElement(),
						new global::System.ServiceModel.Channels.HttpTransportBindingElement()
					});
				}
				else
				{
					binding = new global::System.ServiceModel.BasicHttpBinding();
				}
				wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverClient(this.UseOneWayContract, binding, new global::System.ServiceModel.EndpointAddress(this.EndpointAddress));
			}
			else
			{
				wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverClient(this.UseOneWayContract, this.EndpointConfigurationName, new global::System.ServiceModel.EndpointAddress(this.EndpointAddress));
			}
			wcfLogReceiverClient.ProcessLogMessagesCompleted += this.ClientOnProcessLogMessagesCompleted;
			return wcfLogReceiverClient;
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		protected virtual global::NLog.LogReceiverService.IWcfLogReceiverClient CreateLogReceiver()
		{
			return this.CreateWcfLogReceiverClient();
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x0000F5E0 File Offset: 0x0000D7E0
		private void ClientOnProcessLogMessagesCompleted(object sender, global::System.ComponentModel.AsyncCompletedEventArgs asyncCompletedEventArgs)
		{
			global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = sender as global::NLog.LogReceiverService.IWcfLogReceiverClient;
			if (wcfLogReceiverClient != null && wcfLogReceiverClient.State == global::System.ServiceModel.CommunicationState.Opened)
			{
				try
				{
					wcfLogReceiverClient.Close();
				}
				catch
				{
					wcfLogReceiverClient.Abort();
				}
			}
		}

		// Token: 0x0600064D RID: 1613 RVA: 0x0000F624 File Offset: 0x0000D824
		private void SendBufferedEvents(global::NLog.Common.AsyncContinuation flushContinuation)
		{
			try
			{
				object syncRoot = base.SyncRoot;
				lock (syncRoot)
				{
					global::NLog.Common.AsyncLogEventInfo[] eventsAndClear = this.buffer.GetEventsAndClear();
					if (eventsAndClear.Length != 0)
					{
						global::NLog.LogReceiverService.NLogEvents events = this.TranslateLogEvents(eventsAndClear);
						this.Send(events, eventsAndClear, flushContinuation);
					}
					else
					{
						this.inCall = false;
						if (flushContinuation != null)
						{
							flushContinuation(null);
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (flushContinuation != null)
				{
					global::NLog.Common.InternalLogger.Error(ex, "LogReceiverServiceTarget(Name={0}): Error in flush async", new object[]
					{
						base.Name
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
					flushContinuation(ex);
				}
				else
				{
					global::NLog.Common.InternalLogger.Error(ex, "LogReceiverServiceTarget(Name={0}): Error in send async", new object[]
					{
						base.Name
					});
					if (ex.MustBeRethrownImmediately())
					{
						throw;
					}
				}
			}
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000F700 File Offset: 0x0000D900
		internal global::NLog.LogReceiverService.NLogEvent TranslateEvent(global::NLog.LogEventInfo eventInfo, global::NLog.LogReceiverService.NLogEvents context, global::System.Collections.Generic.Dictionary<string, int> stringTable)
		{
			global::NLog.LogReceiverService.NLogEvent nlogEvent = new global::NLog.LogReceiverService.NLogEvent();
			nlogEvent.Id = eventInfo.SequenceID;
			nlogEvent.MessageOrdinal = global::NLog.Targets.LogReceiverWebServiceTarget.AddValueAndGetStringOrdinal(context, stringTable, eventInfo.FormattedMessage);
			nlogEvent.LevelOrdinal = eventInfo.Level.Ordinal;
			nlogEvent.LoggerOrdinal = global::NLog.Targets.LogReceiverWebServiceTarget.AddValueAndGetStringOrdinal(context, stringTable, eventInfo.LoggerName);
			nlogEvent.TimeDelta = eventInfo.TimeStamp.ToUniversalTime().Ticks - context.BaseTimeUtc;
			for (int i = 0; i < this.Parameters.Count; i++)
			{
				string value = this.Parameters[i].Layout.Render(eventInfo);
				int item = global::NLog.Targets.LogReceiverWebServiceTarget.AddValueAndGetStringOrdinal(context, stringTable, value);
				nlogEvent.ValueIndexes.Add(item);
			}
			for (int j = this.Parameters.Count; j < context.LayoutNames.Count; j++)
			{
				object value2;
				string value3;
				if (eventInfo.HasProperties && eventInfo.Properties.TryGetValue(context.LayoutNames[j], out value2))
				{
					value3 = global::System.Convert.ToString(value2, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				else
				{
					value3 = string.Empty;
				}
				int item2 = global::NLog.Targets.LogReceiverWebServiceTarget.AddValueAndGetStringOrdinal(context, stringTable, value3);
				nlogEvent.ValueIndexes.Add(item2);
			}
			if (eventInfo.Exception != null)
			{
				nlogEvent.ValueIndexes.Add(global::NLog.Targets.LogReceiverWebServiceTarget.AddValueAndGetStringOrdinal(context, stringTable, eventInfo.Exception.ToString()));
			}
			return nlogEvent;
		}

		// Token: 0x04000114 RID: 276
		private readonly global::NLog.Common.LogEventInfoBuffer buffer = new global::NLog.Common.LogEventInfoBuffer(10000, false, 10000);

		// Token: 0x04000115 RID: 277
		private bool inCall;
	}
}
