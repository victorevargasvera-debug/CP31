using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021B RID: 539
	[global::System.Runtime.Serialization.DataContract]
	public class LoadingFinishedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001080 RID: 4224 RVA: 0x0001210B File Offset: 0x0001030B
		// (set) Token: 0x06001081 RID: 4225 RVA: 0x00012113 File Offset: 0x00010313
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001082 RID: 4226 RVA: 0x0001211C File Offset: 0x0001031C
		// (set) Token: 0x06001083 RID: 4227 RVA: 0x00012124 File Offset: 0x00010324
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001084 RID: 4228 RVA: 0x0001212D File Offset: 0x0001032D
		// (set) Token: 0x06001085 RID: 4229 RVA: 0x00012135 File Offset: 0x00010335
		[global::System.Runtime.Serialization.DataMember(Name = "encodedDataLength", IsRequired = true)]
		public double EncodedDataLength { get; private set; }

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001086 RID: 4230 RVA: 0x0001213E File Offset: 0x0001033E
		// (set) Token: 0x06001087 RID: 4231 RVA: 0x00012146 File Offset: 0x00010346
		[global::System.Runtime.Serialization.DataMember(Name = "shouldReportCorbBlocking", IsRequired = false)]
		public bool? ShouldReportCorbBlocking { get; private set; }
	}
}
