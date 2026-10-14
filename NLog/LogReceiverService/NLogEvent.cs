using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace NLog.LogReceiverService
{
	// Token: 0x02000090 RID: 144
	[global::System.Runtime.Serialization.DataContract(Name = "e", Namespace = "http://nlog-project.org/ws/")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://nlog-project.org/ws/")]
	[global::System.Diagnostics.DebuggerDisplay("Event ID = {Id} Level={LevelName} Values={Values.Count}")]
	public class NLogEvent
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00017C5E File Offset: 0x00015E5E
		public NLogEvent()
		{
			this.ValueIndexes = new global::System.Collections.Generic.List<int>();
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00017C71 File Offset: 0x00015E71
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x00017C79 File Offset: 0x00015E79
		[global::System.Runtime.Serialization.DataMember(Name = "id", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("id", Order = 0)]
		public int Id { get; set; }

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x00017C82 File Offset: 0x00015E82
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x00017C8A File Offset: 0x00015E8A
		[global::System.Runtime.Serialization.DataMember(Name = "lv", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("lv", Order = 1)]
		public int LevelOrdinal { get; set; }

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x00017C93 File Offset: 0x00015E93
		// (set) Token: 0x06000907 RID: 2311 RVA: 0x00017C9B File Offset: 0x00015E9B
		[global::System.Runtime.Serialization.DataMember(Name = "lg", Order = 2)]
		[global::System.Xml.Serialization.XmlElement("lg", Order = 2)]
		public int LoggerOrdinal { get; set; }

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x00017CA4 File Offset: 0x00015EA4
		// (set) Token: 0x06000909 RID: 2313 RVA: 0x00017CAC File Offset: 0x00015EAC
		[global::System.Runtime.Serialization.DataMember(Name = "ts", Order = 3)]
		[global::System.Xml.Serialization.XmlElement("ts", Order = 3)]
		public long TimeDelta { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x00017CB5 File Offset: 0x00015EB5
		// (set) Token: 0x0600090B RID: 2315 RVA: 0x00017CBD File Offset: 0x00015EBD
		[global::System.Runtime.Serialization.DataMember(Name = "m", Order = 4)]
		[global::System.Xml.Serialization.XmlElement("m", Order = 4)]
		public int MessageOrdinal { get; set; }

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x00017CC8 File Offset: 0x00015EC8
		// (set) Token: 0x0600090D RID: 2317 RVA: 0x00017D40 File Offset: 0x00015F40
		[global::System.Runtime.Serialization.DataMember(Name = "val", Order = 100)]
		[global::System.Xml.Serialization.XmlElement("val", Order = 100)]
		public string Values
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				string value = string.Empty;
				if (this.ValueIndexes != null)
				{
					foreach (int value2 in this.ValueIndexes)
					{
						stringBuilder.Append(value);
						stringBuilder.Append(value2);
						value = "|";
					}
				}
				return stringBuilder.ToString();
			}
			set
			{
				if (this.ValueIndexes != null)
				{
					this.ValueIndexes.Clear();
				}
				else
				{
					this.ValueIndexes = new global::System.Collections.Generic.List<int>();
				}
				if (!string.IsNullOrEmpty(value))
				{
					foreach (string value2 in value.Split(new char[]
					{
						'|'
					}))
					{
						this.ValueIndexes.Add(global::System.Convert.ToInt32(value2, global::System.Globalization.CultureInfo.InvariantCulture));
					}
				}
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x00017DAF File Offset: 0x00015FAF
		// (set) Token: 0x0600090F RID: 2319 RVA: 0x00017DB7 File Offset: 0x00015FB7
		[global::System.Runtime.Serialization.IgnoreDataMember]
		[global::System.Xml.Serialization.XmlIgnore]
		internal global::System.Collections.Generic.IList<int> ValueIndexes { get; private set; }

		// Token: 0x06000910 RID: 2320 RVA: 0x00017DC0 File Offset: 0x00015FC0
		internal global::NLog.LogEventInfo ToEventInfo(global::NLog.LogReceiverService.NLogEvents context, string loggerNamePrefix)
		{
			global::NLog.LogEventInfo logEventInfo = new global::NLog.LogEventInfo(global::NLog.LogLevel.FromOrdinal(this.LevelOrdinal), loggerNamePrefix + context.Strings[this.LoggerOrdinal], context.Strings[this.MessageOrdinal]);
			logEventInfo.TimeStamp = new global::System.DateTime(context.BaseTimeUtc + this.TimeDelta, global::System.DateTimeKind.Utc).ToLocalTime();
			for (int i = 0; i < context.LayoutNames.Count; i++)
			{
				string key = context.LayoutNames[i];
				string value = context.Strings[this.ValueIndexes[i]];
				logEventInfo.Properties[key] = value;
			}
			return logEventInfo;
		}
	}
}
