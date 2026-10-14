using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Log
{
	// Token: 0x0200024F RID: 591
	[global::System.Runtime.Serialization.DataContract]
	public class LogEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600123F RID: 4671 RVA: 0x00013DD0 File Offset: 0x00011FD0
		// (set) Token: 0x06001240 RID: 4672 RVA: 0x00013DEC File Offset: 0x00011FEC
		public global::CefSharp.DevTools.Log.LogEntrySource Source
		{
			get
			{
				return (global::CefSharp.DevTools.Log.LogEntrySource)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Log.LogEntrySource), this.source);
			}
			set
			{
				this.source = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001241 RID: 4673 RVA: 0x00013DFF File Offset: 0x00011FFF
		// (set) Token: 0x06001242 RID: 4674 RVA: 0x00013E07 File Offset: 0x00012007
		[global::System.Runtime.Serialization.DataMember(Name = "source", IsRequired = true)]
		internal string source { get; set; }

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00013E10 File Offset: 0x00012010
		// (set) Token: 0x06001244 RID: 4676 RVA: 0x00013E2C File Offset: 0x0001202C
		public global::CefSharp.DevTools.Log.LogEntryLevel Level
		{
			get
			{
				return (global::CefSharp.DevTools.Log.LogEntryLevel)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Log.LogEntryLevel), this.level);
			}
			set
			{
				this.level = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001245 RID: 4677 RVA: 0x00013E3F File Offset: 0x0001203F
		// (set) Token: 0x06001246 RID: 4678 RVA: 0x00013E47 File Offset: 0x00012047
		[global::System.Runtime.Serialization.DataMember(Name = "level", IsRequired = true)]
		internal string level { get; set; }

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001247 RID: 4679 RVA: 0x00013E50 File Offset: 0x00012050
		// (set) Token: 0x06001248 RID: 4680 RVA: 0x00013E58 File Offset: 0x00012058
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001249 RID: 4681 RVA: 0x00013E61 File Offset: 0x00012061
		// (set) Token: 0x0600124A RID: 4682 RVA: 0x00013E7D File Offset: 0x0001207D
		public global::CefSharp.DevTools.Log.LogEntryCategory? Category
		{
			get
			{
				return (global::CefSharp.DevTools.Log.LogEntryCategory?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Log.LogEntryCategory?), this.category);
			}
			set
			{
				this.category = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x0600124B RID: 4683 RVA: 0x00013E90 File Offset: 0x00012090
		// (set) Token: 0x0600124C RID: 4684 RVA: 0x00013E98 File Offset: 0x00012098
		[global::System.Runtime.Serialization.DataMember(Name = "category", IsRequired = false)]
		internal string category { get; set; }

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x00013EA1 File Offset: 0x000120A1
		// (set) Token: 0x0600124E RID: 4686 RVA: 0x00013EA9 File Offset: 0x000120A9
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; set; }

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600124F RID: 4687 RVA: 0x00013EB2 File Offset: 0x000120B2
		// (set) Token: 0x06001250 RID: 4688 RVA: 0x00013EBA File Offset: 0x000120BA
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = false)]
		public string Url { get; set; }

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00013EC3 File Offset: 0x000120C3
		// (set) Token: 0x06001252 RID: 4690 RVA: 0x00013ECB File Offset: 0x000120CB
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = false)]
		public int? LineNumber { get; set; }

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x00013ED4 File Offset: 0x000120D4
		// (set) Token: 0x06001254 RID: 4692 RVA: 0x00013EDC File Offset: 0x000120DC
		[global::System.Runtime.Serialization.DataMember(Name = "stackTrace", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.StackTrace StackTrace { get; set; }

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x06001255 RID: 4693 RVA: 0x00013EE5 File Offset: 0x000120E5
		// (set) Token: 0x06001256 RID: 4694 RVA: 0x00013EED File Offset: 0x000120ED
		[global::System.Runtime.Serialization.DataMember(Name = "networkRequestId", IsRequired = false)]
		public string NetworkRequestId { get; set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x00013EF6 File Offset: 0x000120F6
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x00013EFE File Offset: 0x000120FE
		[global::System.Runtime.Serialization.DataMember(Name = "workerId", IsRequired = false)]
		public string WorkerId { get; set; }

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x00013F07 File Offset: 0x00012107
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x00013F0F File Offset: 0x0001210F
		[global::System.Runtime.Serialization.DataMember(Name = "args", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Runtime.RemoteObject> Args { get; set; }
	}
}
