using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace NLog.LogReceiverService
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Serialization.DataContract(Name = "events", Namespace = "http://nlog-project.org/ws/")]
	[global::System.Xml.Serialization.XmlType(Namespace = "http://nlog-project.org/ws/")]
	[global::System.Xml.Serialization.XmlRoot("events", Namespace = "http://nlog-project.org/ws/")]
	[global::System.Diagnostics.DebuggerDisplay("Count = {Events.Length}")]
	public class NLogEvents
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x00017E72 File Offset: 0x00016072
		// (set) Token: 0x06000912 RID: 2322 RVA: 0x00017E7A File Offset: 0x0001607A
		[global::System.Runtime.Serialization.DataMember(Name = "cli", Order = 0)]
		[global::System.Xml.Serialization.XmlElement("cli", Order = 0)]
		public string ClientName { get; set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x00017E83 File Offset: 0x00016083
		// (set) Token: 0x06000914 RID: 2324 RVA: 0x00017E8B File Offset: 0x0001608B
		[global::System.Runtime.Serialization.DataMember(Name = "bts", Order = 1)]
		[global::System.Xml.Serialization.XmlElement("bts", Order = 1)]
		public long BaseTimeUtc { get; set; }

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x00017E94 File Offset: 0x00016094
		// (set) Token: 0x06000916 RID: 2326 RVA: 0x00017E9C File Offset: 0x0001609C
		[global::System.Runtime.Serialization.DataMember(Name = "lts", Order = 100)]
		[global::System.Xml.Serialization.XmlArray("lts", Order = 100)]
		[global::System.Xml.Serialization.XmlArrayItem("l")]
		public global::NLog.LogReceiverService.StringCollection LayoutNames { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x00017EA5 File Offset: 0x000160A5
		// (set) Token: 0x06000918 RID: 2328 RVA: 0x00017EAD File Offset: 0x000160AD
		[global::System.Runtime.Serialization.DataMember(Name = "str", Order = 200)]
		[global::System.Xml.Serialization.XmlArray("str", Order = 200)]
		[global::System.Xml.Serialization.XmlArrayItem("l")]
		public global::NLog.LogReceiverService.StringCollection Strings { get; set; }

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x00017EB6 File Offset: 0x000160B6
		// (set) Token: 0x0600091A RID: 2330 RVA: 0x00017EBE File Offset: 0x000160BE
		[global::System.Runtime.Serialization.DataMember(Name = "ev", Order = 1000)]
		[global::System.Xml.Serialization.XmlArray("ev", Order = 1000)]
		[global::System.Xml.Serialization.XmlArrayItem("e")]
		public global::NLog.LogReceiverService.NLogEvent[] Events { get; set; }

		// Token: 0x0600091B RID: 2331 RVA: 0x00017EC8 File Offset: 0x000160C8
		public global::System.Collections.Generic.IList<global::NLog.LogEventInfo> ToEventInfo(string loggerNamePrefix)
		{
			global::NLog.LogEventInfo[] array = new global::NLog.LogEventInfo[this.Events.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = this.Events[i].ToEventInfo(this, loggerNamePrefix);
			}
			return array;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x00017F04 File Offset: 0x00016104
		public global::System.Collections.Generic.IList<global::NLog.LogEventInfo> ToEventInfo()
		{
			return this.ToEventInfo(string.Empty);
		}
	}
}
