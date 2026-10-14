using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000F7 RID: 247
	[global::System.Runtime.Serialization.DataContract]
	public class TracingCompleteEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x0000A880 File Offset: 0x00008A80
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x0000A888 File Offset: 0x00008A88
		[global::System.Runtime.Serialization.DataMember(Name = "dataLossOccurred", IsRequired = true)]
		public bool DataLossOccurred { get; private set; }

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x0000A891 File Offset: 0x00008A91
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0000A899 File Offset: 0x00008A99
		[global::System.Runtime.Serialization.DataMember(Name = "stream", IsRequired = false)]
		public string Stream { get; private set; }

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0000A8A2 File Offset: 0x00008AA2
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x0000A8BE File Offset: 0x00008ABE
		public global::CefSharp.DevTools.Tracing.StreamFormat? TraceFormat
		{
			get
			{
				return (global::CefSharp.DevTools.Tracing.StreamFormat?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Tracing.StreamFormat?), this.traceFormat);
			}
			set
			{
				this.traceFormat = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x0000A8D1 File Offset: 0x00008AD1
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x0000A8D9 File Offset: 0x00008AD9
		[global::System.Runtime.Serialization.DataMember(Name = "traceFormat", IsRequired = false)]
		internal string traceFormat { get; private set; }

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0000A8E2 File Offset: 0x00008AE2
		// (set) Token: 0x060007FA RID: 2042 RVA: 0x0000A8FE File Offset: 0x00008AFE
		public global::CefSharp.DevTools.Tracing.StreamCompression? StreamCompression
		{
			get
			{
				return (global::CefSharp.DevTools.Tracing.StreamCompression?)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Tracing.StreamCompression?), this.streamCompression);
			}
			set
			{
				this.streamCompression = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x0000A911 File Offset: 0x00008B11
		// (set) Token: 0x060007FC RID: 2044 RVA: 0x0000A919 File Offset: 0x00008B19
		[global::System.Runtime.Serialization.DataMember(Name = "streamCompression", IsRequired = false)]
		internal string streamCompression { get; private set; }
	}
}
